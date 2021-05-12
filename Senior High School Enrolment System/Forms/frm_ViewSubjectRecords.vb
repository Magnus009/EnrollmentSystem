Public Class frm_ViewSubjectRecords
    Dim strSQL As String
    Dim strCode As String

    Private Sub frm_ViewSubjectRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getSubjects()
    End Sub
    Public Sub getSubjects()
        Dim dtSubjects As New DataTable

        strSQL = "SELECT S.SubjectCode [SUBJECT CODE], S.Description [DESCRIPTION], Units [UNITS], ST.Description [TYPE]  FROM Subject S" & vbCrLf
        strSQL &= "INNER JOIN SubjectType ST ON S.SubjectType = ST.TypeCode " & vbCrLf
        If txtSearch.Text <> "" Then
            strSQL &= "WHERE S.SubjectCode LIKE '%" & txtSearch.Text & "%' OR  " & vbCrLf
            strSQL &= "S.Description LIKE '%" & txtSearch.Text & "%' OR  " & vbCrLf
            strSQL &= "S.Units LIKE '%" & txtSearch.Text & "%' OR  " & vbCrLf
            strSQL &= "ST.Description LIKE '%" & txtSearch.Text & "%' " & vbCrLf
        End If
        dtSubjects = SELECT_SHS(strSQL)

        With grdResult
            Dim btnView As New DataGridViewButtonColumn()
            .DataSource = dtSubjects
            .Columns.Add(btnView)
            btnView.Name = "View"
            btnView.Text = "VIEW"
            btnView.UseColumnTextForButtonValue = True

            .Columns("SUBJECT CODE").Width = .Width * 0.1
            .Columns("DESCRIPTION").Width = .Width * 0.4
            .Columns("UNITS").Width = .Width * 0.07
            .Columns("TYPE").Width = .Width * 0.2
            .Columns("View").Width = .Width * 0.1
        End With



    End Sub

    Private Sub grdResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdResult.CellContentClick
        Dim frmSubject As New frm_AddSubjects

        If grdResult.Columns(e.ColumnIndex).Name = "View" Then
            strCode = grdResult.Rows(e.RowIndex).Cells(0).Value()

            With frmSubject
                .isUpdate = True
                .txtSubCode.Text = grdResult.Rows(e.RowIndex).Cells(0).Value()
                .txtSubDescription.Text = grdResult.Rows(e.RowIndex).Cells(1).Value()
                .txtUnit.Text = grdResult.Rows(e.RowIndex).Cells(2).Value()
                .cboType.Text = grdResult.Rows(e.RowIndex).Cells(3).Value()
                .ShowDialog()
            End With
        End If

    End Sub

End Class