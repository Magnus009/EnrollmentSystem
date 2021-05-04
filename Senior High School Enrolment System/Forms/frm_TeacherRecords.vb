Public Class frm_TeacherRecords
    Dim strSQL As String

    Private Sub frm_TeacherRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setHeader()
        Call getTeacher()
    End Sub

    Public Sub setHeader()
        Dim btnView As New DataGridViewButtonColumn()

        With grdResult
            .Columns.Add("colCode", "CODE") : .Columns(0).Width = .Width * 0.1
            .Columns.Add("colName", "NAME") : .Columns(1).Width = .Width * 0.423
            .Columns.Add("colDept", "DEPARTMENT") : .Columns(2).Width = .Width * 0.423
            .Columns.Add(btnView) : .Columns(3).Width = .Width * 0.05
        End With
    End Sub

    Public Sub getTeacher()
        Dim rsTeacher As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT TOP 100 TeacherCode, LastName + ', ' + FirstName +  ' ' + MiddleName + ' ' + ExtName AS Name, " & vbCrLf
        strSQL &= "DeptCode FROM Teachers"
        rsTeacher.Open(strSQL, conDB, 1, 4)

        grdResult.RowCount = 0
        Do While rsTeacher.EOF = False
            With grdResult
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = UCase(rsTeacher.Fields(0).Value)
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsTeacher.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = rsTeacher.Fields(2).Value
                .Rows(.RowCount - 1).Cells(3).Value = "..."

                rsTeacher.MoveNext()
            End With
        Loop

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim rsSearch As New ADODB.Recordset

        strSQL = vbNullString
        strSQL = strSQL & "SELECT TeacherCode, LastName + ', ' + FirstName + ' ' + MiddleName AS Name, Deptname FROM Teachers T " & vbCrLf
        strSQL = strSQL & "INNER JOIN Department D ON T.DeptCode = D.DeptCode " & vbCrLf
        strSQL = strSQL & "WHERE  FirstName LIKE '%" & txtSearch.Text & "%' OR MiddleName LIKE '%" & txtSearch.Text & "%'  " & vbCrLf
        strSQL = strSQL & "OR LastName LIKE '%" & txtSearch.Text & "%' OR  D.DeptName LIKE '%" & txtSearch.Text & "%' " & vbCrLf
        strSQL = strSQL & "ORDER BY T.LastName " & vbCrLf
        rsSearch.Open(strSQL, conDB, 1, 4)


        grdResult.RowCount = 0
        Do While rsSearch.EOF = False
            With grdResult
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = UCase(rsSearch.Fields(0).Value)
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = rsSearch.Fields(2).Value
                .Rows(.RowCount - 1).Cells(3).Value = "..."

                rsSearch.MoveNext()
            End With
        Loop
    End Sub

    Private Sub grdResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdResult.CellContentClick

        Dim rsTeacher As New ADODB.Recordset

        If e.ColumnIndex() = 3 Then

            strSQL = vbNullString
            strSQL &= "SELECT * FROM Teachers " & vbCrLf
            strSQL &= "WHERE TeacherCode='" & grdResult.Rows(e.RowIndex).Cells(0).Value() & "'"
            rsTeacher.Open(strSQL, conDB, 1, 4)

            frm_AddTeacher.txtLastName.Text = rsTeacher.Fields(1).Value
            frm_AddTeacher.txtFirstName.Text = rsTeacher.Fields(2).Value
            frm_AddTeacher.txtMiddleNAme.Text = rsTeacher.Fields(3).Value
            frm_AddTeacher.txtSuffix.Text = rsTeacher.Fields(4).Value
            frm_AddTeacher.cboDepartment.Text = rsTeacher.Fields(5).Value
            frm_AddTeacher.txtContactNo.Text = rsTeacher.Fields(6).Value
            frm_AddTeacher.txtEmail.Text = rsTeacher.Fields(7).Value

            frm_AddTeacher.isUpdate = True
            frm_AddTeacher.strTeacherCode = rsTeacher.Fields(0).Value
            frm_AddTeacher.Show()
            Me.Hide()

        End If
    End Sub
End Class