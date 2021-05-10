Public Class frm_ForgotPass
    Dim strSQL As String

    
    Private Sub frm_ForgotPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getQuestion()
    End Sub

    Private Sub getQuestion()
        Dim rsQuestions As New ADODB.Recordset

        Call SQLConnect()

        strSQL = vbNullString
        strSQL &= "SELECT Question FROM SecretQuestion "
        rsQuestions.Open(strSQL, conDB, 1, 4)

        Do While rsQuestions.EOF = False
            cboQuestion.Items.Add(rsQuestions.Fields(0).Value)

            rsQuestions.MoveNext()
        Loop
    End Sub

   
    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        Dim rsQ As New ADODB.Recordset
        Dim rsUpdate As New ADODB.Recordset
        Dim rsAccountExist As New ADODB.Recordset


        If MsgBox("Are you sure you want to change your password?", vbYesNo, "CHANGE PASSWORD") = vbYes Then

            strSQL = vbNullString
            strSQL &= "SELECT * FROM Accounts " & vbCrLf
            strSQL &= "WHERE UserName = '" & txtUserName.Text & "'"
            rsAccountExist.Open(strSQL, conDB, 1, 4)

            If rsAccountExist.EOF = True Then
                MsgBox("User name doesn't esxist!", vbExclamation, "ERROR")

            Else
                strSQL = vbNullString
                strSQL &= "SELECT ID,A.UserName, CASE WHEN Q.QIndex = 1 THEN A.Answer1 WHEN Q.QIndex = 2 THEN A.Answer2 END AS Answer, Q.Question FROM Accounts A" & vbCrLf
                strSQL &= "INNER JOIN SecretQuestion Q ON 1 = q.QIndex AND A.Question1ID = q.QID OR 2 = q.QIndex AND A.Question2ID = q.QID" & vbCrLf
                strSQL &= "WHERE A.UserName = '" & txtUserName.Text & "'" & vbCrLf
                strSQL &= "AND Q.Question = '" & cboQuestion.Text & "'" & vbCrLf
                rsQ.Open(strSQL, conDB, 1, 4)


                If rsQ.EOF = True Then
                    MsgBox("We can't find your account with this question", vbExclamation, "ERROR")
                Else
                    If UCase(rsQ.Fields(2).Value) = UCase(txtAnswer.Text) Then
                        strSQL = vbNullString
                        strSQL &= "Update Accounts  " & vbCrLf
                        strSQL &= "SET Password = '" & txtNewPass.Text & "'" & vbCrLf
                        strSQL &= "WHERE ID = '" & rsQ.Fields(0).Value & "'" & vbCrLf
                        rsUpdate.Open(strSQL, conDB, 1, 4)

                        AuditTrail(2, "Forgot Password: Update new password")

                        MsgBox("You can now login with your new password!", vbInformation, "RESET SUCCESS")
                        Me.Close()
                    End If
                End If

              
            End If

           



        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtConfirmPass_LostFocus(sender As Object, e As EventArgs) Handles txtConfirmPass.LostFocus
        If txtNewPass.Text <> txtConfirmPass.Text Then
            MsgBox("Password does not match!", vbExclamation, "ERROR")
            txtNewPass.ForeColor = Color.Red
            txtConfirmPass.ForeColor = Color.Red
        Else
            txtNewPass.ForeColor = Color.Green
            txtConfirmPass.ForeColor = Color.Green
        End If
    End Sub
End Class