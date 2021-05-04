Public Class frm_CreateAccount
    Dim strSQL As String
    Dim isExist As Boolean
 

    Private Sub frm_CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getUserLevel()
        Call getQ1()
        Call getQ2()
    End Sub

    Private Sub getUserLevel()
        Dim rsUserLevel As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT Description FROM UserLevel"
        rsUserLevel.Open(strSQL, conDB, 1, 4)

        Do While rsUserLevel.EOF = False

            cboUserLevel.Items.Add(rsUserLevel.Fields(0).Value)
            rsUserLevel.MoveNext()
        Loop
    End Sub

    Private Sub getQ1()
        Dim rsQ1 As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT Question FROM SecretQuestion " & vbCrLf
        strSQL &= "WHERE QIndex = 1  " & vbCrLf
        rsQ1.Open(strSQL, conDB, 1, 4)

        Do While rsQ1.EOF = False

            cboQ1.Items.Add(rsQ1.Fields(0).Value)
            rsQ1.MoveNext()
        Loop
    End Sub

    Private Sub getQ2()
        Dim rsQ2 As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT Question FROM SecretQuestion " & vbCrLf
        strSQL &= "WHERE QIndex = 2  " & vbCrLf
        rsQ2.Open(strSQL, conDB, 1, 4)

        Do While rsQ2.EOF = False

            cboQ2.Items.Add(rsQ2.Fields(0).Value)
            rsQ2.MoveNext()
        Loop
    End Sub
 
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim rsInsert As New ADODB.Recordset
        Dim rsID As New ADODB.Recordset

        If txtPassword.Text <> txtConfirmPass.Text Then
            MsgBox("Password does not match!", vbExclamation, "ERROR")
            txtPassword.ForeColor = Color.Red
            txtConfirmPass.ForeColor = Color.Red
        ElseIf isExist = True Then
            MsgBox("User Name already exist!", vbExclamation, "ERROR")
        Else
            If MsgBox("Are you sure you want to save?", vbYesNo, "CREATE ACCOUNT") = vbYes Then
                strSQL = vbNullString
                strSQL = "SELECT RIGHT('000000' + CAST(coalesce(max(ID), 0) + 1 AS VARCHAR(6)),6) FROM Accounts "
                rsID.Open(strSQL, conDB, 1, 4)

                strSQL = vbNullString
                strSQL &= "INSERT INTO Accounts" & vbCrLf
                strSQL &= "VALUES (" & vbCrLf
                strSQL &= "'" & rsID.Fields(0).Value & "'" & vbCrLf
                strSQL &= ",'" & txtLName.Text + ", " + txtFName.Text + " " + txtMName.Text + IIf(txtExtName.Text = "NA", "", txtExtName) & "'" & vbCrLf
                strSQL &= ",'" & txtUserName.Text & "'" & vbCrLf
                strSQL &= ",'" & txtPassword.Text & "'" & vbCrLf
                strSQL &= "," & getUserLevelCOde(cboUserLevel.Text) & vbCrLf
                strSQL &= ",'" & getQuestionID(cboQ1.Text) & "'" & vbCrLf
                strSQL &= ",'" & txtA1.Text & "'" & vbCrLf
                strSQL &= ",'" & getQuestionID(cboQ2.Text) & "'" & vbCrLf
                strSQL &= ",'" & txtA2.Text & "'" & vbCrLf
                strSQL &= ",1" & vbCrLf
                strSQL &= ",0" & vbCrLf
                strSQL &= ",getDate()" & vbCrLf
                strSQL &= ",null)" & vbCrLf
                rsInsert.Open(strSQL, conDB, 1, 4)

                AuditTrail(1, "Created an Account with Account ID of :" & rsID.Fields(0).Value)

                MsgBox("Account Saved!", vbInformation, "ACCOUNT REGISTERED")
            End If
        End If
        
    End Sub

    Public Function getUserLevelCOde(strUserLevel As String) As String
        Dim strSQL As String
        Dim rsUsrLevelID As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT ID FROM UserLevel" & vbCrLf
        strSQL &= "WHERE Description LIKE '%" & strUserLevel & "%'" & vbCrLf
        rsUsrLevelID.Open(strSQL, conDB, 1, 4)

        Return rsUsrLevelID.Fields(0).Value
    End Function

    Public Function getQuestionID(strQuestion As String) As String
        Dim strSQL As String
        Dim rsQuestionID As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT QID FROM SecretQuestion" & vbCrLf
        strSQL &= "WHERE Question LIKE '%" & strQuestion & "%'" & vbCrLf
        rsQuestionID.Open(strSQL, conDB, 1, 4)

        Return rsQuestionID.Fields(0).Value
    End Function

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.ForeColor = Color.Black
        txtConfirmPass.ForeColor = Color.Black
    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        txtPassword.ForeColor = Color.Black
        txtConfirmPass.ForeColor = Color.Black
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtUserName_LostFocus(sender As Object, e As EventArgs) Handles txtUserName.LostFocus
        Dim rsChckName As New ADODB.Recordset

        strSQL = vbNullString
        strSQL &= "SELECT * FROM Accounts" & vbCrLf
        strSQL &= "WHERE UserName = '" & txtUserName.Text & "'" & vbCrLf
        rsChckName.Open(strSQL, conDB, 1, 4)

        If rsChckName.EOF = False Then
            isExist = True
            MsgBox("User Name already exist!", vbExclamation, "ERROR")
        Else
            isExist = False
        End If
    End Sub

    
End Class