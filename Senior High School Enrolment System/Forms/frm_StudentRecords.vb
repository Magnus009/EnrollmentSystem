Public Class frm_StudentRecords
    Dim strSQL As String
    Dim strLRN As String
    Private Sub frm_StudentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getStudent()
    End Sub

    Public Sub getStudent()
        Dim dtStudents As New DataTable

        strSQL = "SELECT" & vbCrLf
        strSQL += "LRN, " & vbCrLf
        strSQL += "LastName + ', ' + FirstName + ' ' + MiddleName AS NAME, " & vbCrLf
        strSQL += "'Grade ' + CAST(GradeLevel AS VARCHAR(2)) + ' ' + StrandCode AS 'STRAND NAME' FROM Students " & vbCrLf
        If txtSearch.Text <> "" Then
            strSQL += "WHERE LRN LIKE '%" & txtSearch.Text & "%' OR FirstName LIKE '%" & txtSearch.Text & "%' OR MiddleName LIKE '%" & txtSearch.Text & "%'  " & vbCrLf
            strSQL += "OR LastName LIKE '%" & txtSearch.Text & "%' OR CAST(GradeLevel AS VARCHAR(2))LIKE '%" & txtSearch.Text & "%' OR StrandCode  LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        End If
        dtStudents = SELECT_SHS(strSQL)

        grdStudentsInfo.DataSource = dtStudents
        With grdStudentsInfo
            Dim btnView As New DataGridViewButtonColumn()
            .Columns.Add(btnView)
            btnView.Name = "View"
            btnView.Text = "VIEW"
            btnView.UseColumnTextForButtonValue = True

            .Columns(0).Width = .Width * 0.15
            .Columns(1).Width = .Width * 0.4
            .Columns(2).Width = .Width * 0.4
            .Columns(3).Width = .Width * 0.08
        End With
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        getStudent()
    End Sub

    Private Sub grdStudentsInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdStudentsInfo.CellContentClick
        Dim frmInfo As New frm_AddStudent
        If grdStudentsInfo.Columns(e.ColumnIndex).Name = "View" Then
            strLRN = grdStudentsInfo.Rows(e.RowIndex).Cells(0).Value()
            frmInfo.strLRN = strLRN
            frmInfo.isUpdate = True
            frmInfo.ShowDialog()
        End If
    End Sub
End Class