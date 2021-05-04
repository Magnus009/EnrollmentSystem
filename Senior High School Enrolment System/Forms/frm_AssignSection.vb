Public Class frm_AssignSection
    Dim strSQL As String
    
    Private Sub frm_AssignSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getStrand()
        Call setHeader()
        Call loadSection()
    End Sub

    Private Sub getStrand()
        Dim rsStrand As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT CourseName FROM Strand "
        rsStrand.Open(strSQL, conDB, 1, 4)

        cboStrand.Items.Add("ALL")
        Do While rsStrand.EOF = False
            cboStrand.Items.Add(rsStrand.Fields(0).Value)
            rsStrand.MoveNext()
        Loop
    End Sub

    Private Sub setHeader()
        Dim btnAssign As New DataGridViewButtonColumn

        btnAssign.FlatStyle = FlatStyle.Flat
        btnAssign.DefaultCellStyle.BackColor = Color.DarkGreen
        btnAssign.DefaultCellStyle.ForeColor = Color.White
        btnAssign.DefaultCellStyle.SelectionBackColor = Color.DarkGreen
        btnAssign.DefaultCellStyle.SelectionForeColor = Color.White
        With grdSections
            .Columns.Add("colCode", "CODE") : .Columns(0).Width = .Width * 0.2
            .Columns.Add("colNAME", "SECTION NAME") : .Columns(1).Width = .Width * 0.5
            .Columns.Add("colStudents", "STUDENTS") : .Columns(2).Width = .Width * 0.17
            .Columns.Add(btnAssign) : .Columns(3).Width = .Width * 0.12
        End With
    End Sub
  
    Private Sub cboStrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStrand.SelectedIndexChanged
        Call loadSection()
    End Sub

    Private Sub cboLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLevel.SelectedIndexChanged
        Call loadSection()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call loadSection()
    End Sub

    Private Sub loadSection()
        Dim rsSections As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT S.SectionCode, S.SectionName, count(SS.StudentID) FROM StudentSection SS" & vbCrLf
        strSQL &= "RIGHT JOIN Sections S ON SS.SectionCode = S.SectionCode  " & vbCrLf

        If txtSearch.Text <> "" Or cboStrand.SelectedIndex > 0 Or cboLevel.SelectedIndex > 0 Then
            strSQL &= "WHERE"

            If txtSearch.Text <> "" Then
                strSQL &= " S.SectionName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
                strSQL &= "OR S.SectionCode LIKE '%" & txtSearch.Text & "%'" & vbCrLf
                strSQL &= "AND"
            End If

            If cboStrand.SelectedIndex > 0 Then
                strSQL &= " S.CourseCode = '" & getStrandCode(cboStrand.Text) & "'" & vbCrLf
                strSQL &= "AND"
            End If

            If cboLevel.SelectedIndex > 0 Then
                strSQL &= " S.GradeLevel = " & cboLevel.Text & vbCrLf
                strSQL &= "AND"
            End If
            strSQL = Strings.Left(strSQL, Len(strSQL) - 3)
        End If
        strSQL &= "GROUP BY S.SectionCode, S.SectionName  " & vbCrLf
        rsSections.Open(strSQL, conDB, 1, 4)

        If rsSections.EOF = True Then
            MsgBox("No Record Found!", vbExclamation)
            Call getStrand()
        Else
            With grdSections
                .RowCount = 0
                Do While rsSections.EOF = False
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = rsSections.Fields(0).Value
                    .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSections.Fields(1).Value)
                    .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSections.Fields(2).Value)
                    .Rows(.RowCount - 1).Cells(3).Value = "ASSIGN"

                    rsSections.MoveNext()
                Loop
            End With
        End If
    End Sub

    Private Sub grdSections_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSections.CellContentClick
        Dim rsSectionInfo As New ADODB.Recordset
        Dim strLevel As String
        'Dim strLevel As String

        If e.ColumnIndex = 3 Then

            Call SQLConnect()
            strSQL = vbNullString
            strSQL &= "SELECT * FROM Sections" & vbCrLf
            strSQL &= "WHERE SectionCode = '" & grdSections.Rows(e.RowIndex).Cells(0).Value() & "'" & vbCrLf
            rsSectionInfo.Open(strSQL, conDB, 1, 4)


            strLevel = rsSectionInfo.Fields(2).Value
            frm_ViewSection.lblSecyionName.Text = rsSectionInfo.Fields(3).Value
            frm_ViewSection.lblSectionCode.Text = rsSectionInfo.Fields(0).Value
            frm_ViewSection.lblStrand.Text = getStrandName(rsSectionInfo.Fields(1).Value)
            frm_ViewSection.lblGradeLevel.Text = "GR - " & strLevel
            frm_ViewSection.ShowDialog()

        End If
    End Sub
End Class