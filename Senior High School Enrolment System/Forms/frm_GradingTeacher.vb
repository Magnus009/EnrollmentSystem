Public Class frm_GradingTeacher
    Dim strSQL As String


    Private Sub frm_GradingTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setHeader()
        Call getTeacher()
    End Sub
    Public Sub setHeader()
        Dim btnView As New DataGridViewButtonColumn()

        btnView.FlatStyle = FlatStyle.Flat
        btnView.DefaultCellStyle.BackColor = Color.DarkGreen
        btnView.DefaultCellStyle.ForeColor = Color.White
        btnView.DefaultCellStyle.SelectionBackColor = Color.DarkGreen
        btnView.DefaultCellStyle.SelectionForeColor = Color.White
        With grdTeacher
            .Columns.Add("colCode", "CODE") : .Columns(0).Width = .Width * 0.2
            .Columns.Add("colName", "NAME") : .Columns(1).Width = .Width * 0.69
            .Columns.Add(btnView) : .Columns(2).Width = .Width * 0.1
        End With
    End Sub

    Public Sub getTeacher()
        Dim rsTeacher As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT TeacherCode, LastName + ', ' + FirstName +  ' ' +  " & vbCrLf
        strSQL &= "CASE WHEN MiddleName IS NULL OR MiddleName = 'N/A' THEN" & vbCrLf
        strSQL &= "'' ELSE" & vbCrLf
        strSQL &= "MiddleName END + ' ' + " & vbCrLf
        strSQL &= "CASE WHEN ExtName IS NULL OR ExtName = 'N/A' THEN" & vbCrLf
        strSQL &= "'' ELSE" & vbCrLf
        strSQL &= "ExtName END AS Name" & vbCrLf
        strSQL &= "FROM Teachers" & vbCrLf
        rsTeacher.Open(strSQL, conDB, 1, 4)

        grdTeacher.RowCount = 0
        Do While rsTeacher.EOF = False
            With grdTeacher
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Rows(.RowCount - 1).Cells(0).Value = UCase(rsTeacher.Fields(0).Value)
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsTeacher.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = "..."

                rsTeacher.MoveNext()
            End With
        Loop

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim rsSearch As New ADODB.Recordset

        strSQL = vbNullString
        strSQL &= "SELECT TeacherCode, LastName + ', ' + FirstName +  ' ' +  " & vbCrLf
        strSQL &= "CASE WHEN MiddleName IS NULL OR MiddleName = 'N/A' THEN" & vbCrLf
        strSQL &= "'' ELSE" & vbCrLf
        strSQL &= "MiddleName END + ' ' + " & vbCrLf
        strSQL &= "CASE WHEN ExtName IS NULL OR ExtName = 'N/A' THEN" & vbCrLf
        strSQL &= "'' ELSE" & vbCrLf
        strSQL &= "ExtName END AS Name" & vbCrLf
        strSQL &= "FROM Teachers" & vbCrLf
        strSQL += "WHERE  FirstName LIKE '%" & txtSearch.Text & "%' OR MiddleName LIKE '%" & txtSearch.Text & "%'  " & vbCrLf
        strSQL += "OR LastName LIKE '%" & txtSearch.Text & "%'  " & vbCrLf
        strSQL += "ORDER BY LastName " & vbCrLf
        rsSearch.Open(strSQL, conDB, 1, 4)


        grdTeacher.RowCount = 0
        Do While rsSearch.EOF = False
            With grdTeacher
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Rows(.RowCount - 1).Cells(0).Value = UCase(rsSearch.Fields(0).Value)
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = "..."

                rsSearch.MoveNext()
            End With
        Loop
    End Sub

    Private Sub grdTeacher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdTeacher.CellContentClick

        If e.ColumnIndex = 2 Then
            frm_GradingSections.strTeacherCode = grdTeacher.Rows(e.RowIndex).Cells(0).Value()
            frm_GradingSections.ShowDialog()

        End If
    End Sub
End Class