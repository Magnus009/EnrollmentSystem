Public Class frm_Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'CHECK INPUT
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                If txtUserName.Text = "" And txtPassword.Text = "" Then
                    MsgBox("Please input your USERNAME and PASSWORD!", MsgBoxStyle.Critical)
                    txtUserName.Select()
                    Exit Sub
                ElseIf ctrl.Text = "" Then
                    MsgBox("Please input your " & UCase(Mid(ctrl.Name, 4)) & "!", MsgBoxStyle.Critical)
                    ctrl.Select()
                    Exit Sub
                End If
            End If
        Next

        Call SQLConnect()
        rsDB = New ADODB.Recordset
        strQuery = vbNullString
        strQuery = "SELECT * FROM Accounts" & vbCrLf
        strQuery &= "WHERE UserName = '" & txtUserName.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS"
        rsDB.Open(strQuery, conDB, 1, 4)

        If rsDB.EOF Then
            MsgBox("USERNAME not registered!", MsgBoxStyle.Critical)
            txtUserName.Text = "" : txtPassword.Text = ""
            txtUserName.Select()
        Else
            If txtPassword.Text <> rsDB.Fields(3).Value Then
                MsgBox("Invalid PASSWORD!", MsgBoxStyle.Critical)
                txtPassword.Text = "" : txtPassword.Select()
            Else
                If rsDB.Fields(10).Value = True Then
                    MsgBox("Account already DELETED!", MsgBoxStyle.Critical)
                    txtUserName.Text = "" : txtPassword.Text = ""
                    txtUserName.Select()
                ElseIf rsDB.Fields(9).Value = False And rsDB.Fields(5).Value = False Then
                    MsgBox("Account DEACTIVATED!", MsgBoxStyle.Critical)
                    txtUserName.Text = "" : txtPassword.Text = ""
                    txtUserName.Select()
                Else
                    UserName = rsDB.Fields(2).Value
                    UserLevelID = rsDB.Fields(4).Value : getUserLevel(UserLevelID)
                    MsgBox("Successfully Logged in!", MsgBoxStyle.Information, UCase(UserName))
                    mdiSES.lblUserLevel.Text = M_Functions.UserLevel
                    mdiSES.lblUserName.Text = txtUserName.Text
                    mdiSES.Show()
                    txtUserName.Text = "" : txtPassword.Text = ""
                    Me.Hide()

                    Call AuditTrail(4, "User [" + txtUserName.Text + "] sign in")
                End If
            End If
        End If
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.Text = "" : txtPassword.Text = ""
    End Sub

  
    Private Sub forgot_Click(sender As Object, e As EventArgs) Handles forgot.Click
        frm_ForgotPass.ShowDialog()
    End Sub
    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Me.Close()
    End Sub
End Class
