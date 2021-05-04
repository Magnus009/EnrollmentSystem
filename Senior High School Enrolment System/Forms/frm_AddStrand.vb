Public Class frm_AddStrand
    Dim strSQL As String
    Public strCode As String
    Private Sub txtAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rsAdd As New ADODB.Recordset
        Dim rsCheck As New ADODB.Recordset


        If MsgBox("Are you sure you want to add Strand?", vbYesNo, vbQuestion) = vbYes Then
            Call SQLConnect()

            strSQL = vbNullString
            strSQL &= "SELECT * FROM Strand " & vbCrLf
            strSQL &= "WHERE CourseCode ='" & txtStrandCode.Text & "'" & vbCrLf
            rsCheck.Open(strSQL, conDB, 1, 4)

            If rsCheck.EOF = False Then
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
                rsAdd.Open(strSQL, conDB, 1, 4)

                AuditTrail(1, "Added Sgtrand with strand code:" & txtStrandCode.Text)

                MsgBox("Saved Succesfully!", vbInformation)
            End If


            
        End If
        
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim rsUpdate As New ADODB.Recordset

        If MsgBox("Are you sure you want to save changes?", vbYesNo) = vbYes Then


            strSQL = vbNullString
            strSQL &= "UPDATE Strand" & vbCrLf
            strSQL &= "SET CourseCode = '" & txtStrandCode.Text & "'" & vbCrLf
            strSQL &= ", CourseName = '" & txtStrandName.Text & "'" & vbCrLf
            strSQL &= ", Description = '" & txtDescription.Text & "'" & vbCrLf
            strSQL &= ", UpdatedDate = getdate()" & vbCrLf
            strSQL &= ", UpdatedBy = '" & frm_Login.txtUserName.Text & "'" & vbCrLf
            strSQL &= "WHERE CourseCode = '" & strCode & "'" & vbCrLf
            rsUpdate.Open(strSQL, conDB, 1, 4)

            AuditTrail(2, "Updated Strand Information with Strand Code:" & txtStrandCode.Text)

            MsgBox("Changes Saved!", vbInformation)

        End If
        

    End Sub
End Class