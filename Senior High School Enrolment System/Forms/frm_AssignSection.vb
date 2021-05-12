Public Class frm_AssignSection
    Dim strSQL As String
    
    Private Sub frm_AssignSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getStrand()
        Call loadSection()
        AddHandler cboStrand.SelectedIndexChanged, AddressOf cboStrand_Changed
        AddHandler cboLevel.SelectedIndexChanged, AddressOf cboLevel_Changed
    End Sub

    Private Sub getStrand()
        strSQL = "SELECT CourseCode, CourseName FROM Strand"
        cboDataBind(cboStrand, strSQL, "ALL")
    End Sub
    Private Sub cboStrand_Changed(sender As Object, e As EventArgs)
        Call loadSection()
    End Sub

    Private Sub cboLevel_Changed(sender As Object, e As EventArgs)
        Call loadSection()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call loadSection()
    End Sub

    Private Sub loadSection()
        Dim dtSections As New DataTable
        Try
            strSQL = vbNullString
            strSQL &= "SELECT S.SectionCode [CODE], S.SectionName [SECTION NAME], count(SS.StudentID) [STUDENTS] FROM StudentSection SS" & vbCrLf
            strSQL &= "RIGHT JOIN Sections S ON SS.SectionCode = S.SectionCode  " & vbCrLf
            If txtSearch.Text <> "" Or cboStrand.SelectedIndex > 0 Or cboLevel.SelectedIndex > 0 Then
                strSQL &= "WHERE"
                If txtSearch.Text <> "" Then
                    strSQL &= " S.SectionName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
                    strSQL &= "OR S.SectionCode LIKE '%" & txtSearch.Text & "%'" & vbCrLf
                    strSQL &= "AND"
                End If
                If cboStrand.SelectedIndex > 0 Then
                    strSQL &= " S.CourseCode = '" & cboStrand.SelectedValue.ToString & "'" & vbCrLf
                    strSQL &= "AND"
                End If
                If cboLevel.SelectedIndex > 0 Then
                    strSQL &= " S.GradeLevel = " & cboLevel.Text & vbCrLf
                    strSQL &= "AND"
                End If
                strSQL = Strings.Left(strSQL, Len(strSQL) - 3)
            End If
            strSQL &= "GROUP BY S.SectionCode, S.SectionName  " & vbCrLf
            dtSections = SELECT_SHS(strSQL)

            If dtSections.Rows.Count = 0 Then
                MsgBox("No Record Found!", vbExclamation)
                Call getStrand()
            Else
                With grdSections
                    .Columns.Clear()
                    .DataSource = dtSections
                    Dim btnAssign As New DataGridViewButtonColumn
                    .Columns.Add(btnAssign)
                    btnAssign.Name = "Assign"
                    btnAssign.Text = "ASSIGN"
                    btnAssign.UseColumnTextForButtonValue = True

                    .Columns("CODE").Width = .Width * 0.2
                    .Columns("SECTION NAME").Width = .Width * 0.4
                    .Columns("STUDENTS").Width = .Width * 0.2
                    .Columns("Assign").Width = .Width * 0.15
                End With

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub grdSections_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSections.CellContentClick
        Dim dtSections As New DataTable
        Dim frmViewSection As New frm_ViewSection
        Try
            If e.ColumnIndex = 3 Then

                strSQL = "SELECT S.SectionCode,S.CourseCode,S.SectionName,S.GradeLevel, ST.CourseName FROM Sections S" & vbCrLf
                strSQL += "INNER JOIN Strand ST ON S.CourseCode = ST.CourseCode" & vbCrLf
                strSQL += "WHERE SectionCode = '" & grdSections.Rows(e.RowIndex).Cells(0).Value() & "'" & vbCrLf
                dtSections = SELECT_SHS(strSQL)

                With frmViewSection
                    .lblSectionName.Text = dtSections.Rows(0)("SectionName")
                    .lblSectionCode.Text = dtSections.Rows(0)("SectionCode")
                    .lblStrand.Text = dtSections.Rows(0)("CourseName")
                    .lblGradeLevel.Text = "GR - " + dtSections.Rows(0)("GradeLevel").ToString
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
End Class