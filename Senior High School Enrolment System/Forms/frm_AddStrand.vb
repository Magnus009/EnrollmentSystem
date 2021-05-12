Public Class frm_AddStrand
    Dim strSQL As String
    Public strCode As String
    Private Sub txtAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intCheck As Integer
        Dim blnResult As Boolean
        Try
            Dim dlg As New DialogResult
            dlg = MsgBox("Are you sure you want to add Strand?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ADD STRAND")

            If dlg = Windows.Forms.DialogResult.Yes Then

                strSQL = vbNullString
                strSQL &= "SELECT count(CourseCode) FROM Strand " & vbCrLf
                strSQL &= "WHERE CourseCode ='" & txtStrandCode.Text & "'" & vbCrLf
                intCheck = SELECT_SHS(strSQL).Rows(0)(0)

                If intCheck <> 0 Then
                    MsgBox("Strand/Course Code already Exist!", vbExclamation)
                Else
                    strSQL = vbNullString
                    strSQL &= "INSERT INTO Strand " & vbCrLf
                    strSQL &= "VALUES ( " & vbCrLf
                    strSQL &= "'" & txtStrandCode.Text & "'" & vbCrLf
                    strSQL &= ",'" & txtStrandName.Text & "'" & vbCrLf
                    strSQL &= ",'" & txtDescription.Text & "'" & vbCrLf
                    strSQL &= ",getDate()" & vbCrLf
                    strSQL &= ",Null" & vbCrLf
                    strSQL &= ",getDate()" & vbCrLf
                    strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
                    blnResult = EXEC_SHS(strSQL)

                    If blnResult = True Then
                        AuditTrail(1, "Added Sgtrand with strand code:" & txtStrandCode.Text)
                        MsgBox("Saved Succesfully!", vbInformation)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim blnResult As Boolean
        Try
            If MsgBox("Are you sure you want to save changes?", vbYesNo) = vbYes Then
                strSQL = vbNullString
                strSQL &= "UPDATE Strand" & vbCrLf
                strSQL &= "SET CourseCode = '" & txtStrandCode.Text & "'" & vbCrLf
                strSQL &= ", CourseName = '" & txtStrandName.Text & "'" & vbCrLf
                strSQL &= ", Description = '" & txtDescription.Text & "'" & vbCrLf
                strSQL &= ", UpdatedDate = getdate()" & vbCrLf
                strSQL &= ", UpdatedBy = '" & frm_Login.txtUserName.Text & "'" & vbCrLf
                strSQL &= "WHERE CourseCode = '" & strCode & "'" & vbCrLf
                blnResult = EXEC_SHS(strSQL)

                If blnResult = True Then
                    AuditTrail(2, "Updated Strand Information with Strand Code:" & txtStrandCode.Text)
                    MsgBox("Changes Saved!", vbInformation)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    
End Class