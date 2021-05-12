Public Class frm_Accounts
    Private Sub frm_Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getAccounts()
    End Sub

    Public Sub getAccounts()
        Dim dtAccounts As New DataTable

        strSQL = vbNullString
        strSQL &= "SELECT A.ID, A.Name [NAME], A.UserName [USER NAME],U.Description [TYPE],isActive [STATUS], isDeleted [DELETED] FROM Accounts A" & vbCrLf
        strSQL &= "INNER JOIN UserLevel U on A.UserLevelID = U.ID" & vbCrLf
        If txtSearch.Text <> "" Then
            strSQL &= "WHERE A.ID LIKE '%" & txtSearch.Text & "%'" & vbCrLf
            strSQL &= "OR A.Name LIKE '%" & txtSearch.Text & "%'" & vbCrLf
            strSQL &= "OR A.UserName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
            strSQL &= "OR U.Description LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        End If
        dtAccounts = SELECT_SHS(strSQL)

        grdAccounts.DataSource = dtAccounts
        With grdAccounts
            .Columns("ID").Width = .Width * 0.1
            .Columns("NAME").Width = .Width * 0.25
            .Columns("USER NAME").Width = .Width * 0.15
            .Columns("TYPE").Width = .Width * 0.1
            .Columns("STATUS").Width = .Width * 0.1
            .Columns("DELETED").Width = .Width * 0.1
        End With

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        getAccounts()
    End Sub
End Class