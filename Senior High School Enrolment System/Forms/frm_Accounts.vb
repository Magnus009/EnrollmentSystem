Public Class frm_Accounts

    Dim strSQL As String


    Private Sub frm_Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setHeader()
        Call getAccounts()
    End Sub

    Private Sub setHeader()
        Dim btnView As New DataGridViewButtonColumn()
        Dim chkActive As New DataGridViewCheckBoxColumn()
        Dim chkDeleted As New DataGridViewCheckBoxColumn()

        With grdAccounts
            .Columns.Add("colCode", "ID") : .Columns(0).Width = .Width * 0.1
            .Columns.Add("colName", "NAME") : .Columns(1).Width = .Width * 0.34
            .Columns.Add("colUName", "USER NAME") : .Columns(2).Width = .Width * 0.2
            .Columns.Add("colULevel", "USER LEVEL") : .Columns(3).Width = .Width * 0.1
            .Columns.Add(chkDeleted) : .Columns(4).Width = .Width * 0.1
            .Columns.Add(chkActive) : .Columns(5).Width = .Width * 0.1
            .Columns.Add(btnView) : .Columns(6).Width = .Width * 0.06
            .Columns(4).HeaderText = "ACTIVE"
            .Columns(5).HeaderText = "DELETED"
        End With
    End Sub


    Public Sub getAccounts()
        Dim rsAccounts As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT A.ID, A.Name, A.UserName,U.Description,isActive, isDeleted FROM Accounts A" & vbCrLf
        strSQL &= "INNER JOIN UserLevel U on A.UserLevelID = U.ID" & vbCrLf
        rsAccounts.Open(strSQL, conDB, 1, 4)

        grdAccounts.RowCount = 0
        Do While rsAccounts.EOF = False
            With grdAccounts
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = rsAccounts.Fields(0).Value
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsAccounts.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = UCase(rsAccounts.Fields(2).Value)
                .Rows(.RowCount - 1).Cells(3).Value = UCase(rsAccounts.Fields(3).Value)
                .Rows(.RowCount - 1).Cells(4).Value = rsAccounts.Fields(4).Value
                .Rows(.RowCount - 1).Cells(5).Value = rsAccounts.Fields(5).Value
                .Rows(.RowCount - 1).Cells(6).Value = "VIEW"

                rsAccounts.MoveNext()
            End With
        Loop
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim rsSearch As New ADODB.Recordset

        strSQL = vbNullString
        strSQL &= "SELECT A.ID, A.Name, A.UserName,U.Description,isActive, isDeleted FROM Accounts A" & vbCrLf
        strSQL &= "INNER JOIN UserLevel U on A.UserLevelID = U.ID" & vbCrLf
        strSQL &= "WHERE A.ID LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR A.Name LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR A.UserName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR U.Description LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        rsSearch.Open(strSQL, conDB, 1, 4)

        grdAccounts.RowCount = 0
        Do While rsSearch.EOF = False
            With grdAccounts
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = rsSearch.Fields(0).Value
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSearch.Fields(2).Value)
                .Rows(.RowCount - 1).Cells(3).Value = UCase(rsSearch.Fields(3).Value)
                .Rows(.RowCount - 1).Cells(4).Value = rsSearch.Fields(4).Value
                .Rows(.RowCount - 1).Cells(5).Value = rsSearch.Fields(5).Value
                .Rows(.RowCount - 1).Cells(6).Value = "VIEW"

                rsSearch.MoveNext()
            End With
        Loop
    End Sub
End Class