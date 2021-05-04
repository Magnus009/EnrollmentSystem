Public Class frm_Section
    Dim strSQL As String
    Dim isUpdate As Boolean
    Dim strSecCode As String

    Private Sub frm_AddSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isUpdate = False

        Call setHeader()
        Call getSection()
        Call getStrands()

        If isUpdate = True Then
            btnAdd.Enabled = False
            btnUpdate.Enabled = True
        Else
            btnAdd.Enabled = True
            btnUpdate.Enabled = False
        End If
    End Sub

    Public Sub setHeader()
        Dim btnView As New DataGridViewButtonColumn()

        With grdResult
            .Columns.Add("colSecCode", "SECTION CODE") : .Columns(0).Width = .Width * 0.1
            .Columns.Add("colCourseCode", "COURSE CODE") : .Columns(1).Width = .Width * 0.1
            .Columns.Add("colLevel", "GRADE LEVEL") : .Columns(2).Width = .Width * 0.1
            .Columns.Add("colName", "DESCRIPTION") : .Columns(3).Width = .Width * 0.62
            .Columns.Add(btnView) : .Columns(4).Width = .Width * 0.07
        End With
    End Sub

    Public Sub getSection()
        Dim rsSection As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT * FROM Sections"
        rsSection.Open(strSQL, conDB, 1, 4)

        grdResult.RowCount = 0
        Do While rsSection.EOF = False
            With grdResult
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = UCase(rsSection.Fields(0).Value)
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSection.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSection.Fields(2).Value)
                .Rows(.RowCount - 1).Cells(3).Value = UCase(rsSection.Fields(3).Value)
                .Rows(.RowCount - 1).Cells(4).Value = "EDIT"

                rsSection.MoveNext()
            End With
        Loop
    End Sub

    Public Sub getStrands()
        Dim rsStrands As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL = strSQL & "SELECT CourseCode, CourseName FROM Strand"
        rsStrands.Open(strSQL, conDB, 1, 4)

        For i = 1 To rsStrands.RecordCount
            cboStrand.Items.Add(rsStrands.Fields(1).Value)

            rsStrands.MoveNext()
        Next
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rsAdd As New ADODB.Recordset
        Dim rsCheck As New ADODB.Recordset

        If MsgBox("Are you sure you want to add section?", vbYesNo, "SECTION REGISTRATION") = vbYes Then

            strSQL = vbNullString
            strSQL &= "SELECT * FROM Sections "
            strSQL &= "WHERE SectionCode = '" & txtSecCode.Text & "'"
            rsCheck.Open(strSQL, conDB, 1, 4)

            If rsCheck.EOF = False Then
                MsgBox("Section Code already exist!", vbExclamation)
            Else
                strSQL = vbNullString
                strSQL &= "INSERT INTO Sections " & vbCrLf
                strSQL &= "VALUES (" & vbCrLf
                strSQL &= "'" & txtSecCode.Text & "'" & vbCrLf
                strSQL &= ",'" & getStrandCode(cboStrand.Text) & "'" & vbCrLf
                strSQL &= "," & cboGrdLevel.Text & "" & vbCrLf
                strSQL &= ",'" & txtSecName.Text & "'" & vbCrLf
                strSQL &= ",getdate()" & vbCrLf
                strSQL &= ",NULL" & vbCrLf
                strSQL &= ",getdate()" & vbCrLf
                strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
                rsAdd.Open(strSQL, conDB, 1, 4)

                AuditTrail(1, "Register a Section with Section Code:" & txtSecCode.Text)


                MsgBox("Section Registered!", vbInformation, "SECTION REGISTRATION")
                Call getSection()

            End If
        End If

    End Sub

    Private Sub grdResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdResult.CellContentClick

        If e.ColumnIndex = 4 Then
            strSecCode = grdResult.Rows(e.RowIndex).Cells(0).Value()
            isUpdate = True
            btnAdd.Enabled = False
            btnUpdate.Enabled = True

            txtSecCode.Text = grdResult.Rows(e.RowIndex).Cells(0).Value()
            txtSecName.Text = grdResult.Rows(e.RowIndex).Cells(3).Value()
            cboGrdLevel.Text = grdResult.Rows(e.RowIndex).Cells(2).Value()
            cboStrand.Text = getStrandName(grdResult.Rows(e.RowIndex).Cells(1).Value())
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim rsUpdate As New ADODB.Recordset


        If MsgBox("Are you sure you want to save changes?", vbYesNo, "UPDATE SECTION") = vbYes Then

            Call SQLConnect()
            strSQL = vbNullString
            strSQL &= "UPDATE Sections" & vbCrLf
            strSQL &= "SET SectionCode = '" & txtSecCode.Text & "'" & vbCrLf
            strSQL &= ", CourseCode = '" & getStrandCode(cboStrand.Text) & "'" & vbCrLf
            strSQL &= ", GradeLevel = " & cboGrdLevel.Text & vbCrLf
            strSQL &= ", SectionName = '" & txtSecName.Text & "'" & vbCrLf
            strSQL &= ", CreatedDate = getdate()" & vbCrLf
            strSQL &= ", DeletedDate = NULL" & vbCrLf
            strSQL &= ", UpdatedDate = getdate()" & vbCrLf
            strSQL &= ", UpdatedBy = '" & frm_Login.txtUserName.Text & "'" & vbCrLf
            strSQL &= "WHERE SectionCode = '" & strSecCode & "'" & vbCrLf
            rsUpdate.Open(strSQL, conDB, 1, 4)

            Call AuditTrail(2, "Update Section with Section Code:" & txtSecCode.Text)
            Call getSection()
            MsgBox("Changes Saved!", vbInformation)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtSecCode.Text = vbNullString
        txtSecName.Text = vbNullString
        cboGrdLevel.Text = vbNullString
        cboStrand.Text = vbNullString
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim rsSearch As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT * FROM Sections" & vbCrLf
        strSQL &= "WHERE SectionCode LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR CourseCode LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR GradeLevel LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR SectionName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        rsSearch.Open(strSQL, conDB, 1, 4)

        grdResult.RowCount = 0
        Do While rsSearch.EOF = False
            With grdResult
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = UCase(rsSearch.Fields(0).Value)
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSearch.Fields(2).Value)
                .Rows(.RowCount - 1).Cells(3).Value = UCase(rsSearch.Fields(3).Value)
                .Rows(.RowCount - 1).Cells(4).Value = "EDIT"

                rsSearch.MoveNext()
            End With
        Loop
    End Sub
End Class