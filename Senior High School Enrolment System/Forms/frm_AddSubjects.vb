Public Class frm_AddSubjects
    Dim strSQL As String
    Public isUpdate As Boolean
    Public strCode As String

    Private Sub frm_AddSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If isUpdate = True Then
            btnAdd.Visible = False
            btnModify.Visible = True
        Else
            btnAdd.Visible = True
            btnModify.Visible = False
            Call getSubject()
        End If

        Call getSubjectType()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub getSubject()
        Dim dtSubjects As New DataTable

        strSQL = "SELECT * FROM Subject"

        For Each row As DataRow In dtSubjects.Rows
            With chklstPrerequisite
                .Items.Add(row.Item("Description"), False)
            End With
        Next
    End Sub

    Public Sub getSubjectType()
        strSQL = "SELECT TypeCode, Description FROM SubjectType"
        cboDataBind(cboType, strSQL)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intCheck As Integer
        Dim blnResult As Boolean
        Try
            If MsgBox("Are you sure you want to register?", vbYesNo, vbQuestion) = vbYes Then

                Call SQLConnect()

                strSQL = "SELECT count(*) FROM Subject" & vbCrLf
                strSQL &= "WHERE SubjectCode = '" & txtSubCode.Text & "'" & vbCrLf
                intCheck = SELECT_SHS(strSQL).Rows(0)(0)

                If intCheck <> 0 Then
                    MsgBox("Subject Code already exist!", vbExclamation)
                Else
                    strSQL = "INSERT INTO Subject " & vbCrLf
                    strSQL &= "VALUES (" & vbCrLf
                    strSQL &= "'" & txtSubCode.Text & "'" & vbCrLf
                    strSQL &= ",'" & txtSubDescription.Text & "'" & vbCrLf
                    strSQL &= ",'" & txtUnit.Text & "'" & vbCrLf
                    strSQL &= ",'" & getSubjectTypeCode(cboType.Text) & "'" & vbCrLf
                    strSQL &= ",getdate()" & vbCrLf
                    strSQL &= ",Null" & vbCrLf
                    strSQL &= ",getdate()" & vbCrLf
                    strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
                    blnResult = EXEC_SHS(strSQL)

                    If chklstPrerequisite.CheckedItems.Count <> 0 Then
                        For i = 0 To chklstPrerequisite.CheckedItems.Count - 1

                            strSQL = vbNullString
                            strSQL &= "INSERT INTO SubjectRelation " & vbCrLf
                            strSQL &= "VALUES (" & vbCrLf
                            strSQL &= "'" & txtSubCode.Text & "'" & vbCrLf
                            strSQL &= ",'" & getSubjectCode(chklstPrerequisite.CheckedItems(i)) & "'" & vbCrLf
                            strSQL &= ",getdate()" & vbCrLf
                            strSQL &= ",Null" & vbCrLf
                            strSQL &= ",getdate()" & vbCrLf
                            strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
                            blnResult = EXEC_SHS(strSQL)
                        Next
                    End If

                    If blnResult = True Then
                        Call AuditTrail(1, "Registered Subject with subject code of: " & txtSubCode.Text)
                        MsgBox("Subject Registered!", vbInformation)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
       


    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim blnResult As Boolean

        Try
            If MsgBox("Are you sure you want to save changes?", vbYesNo, vbQuestion) = vbYes Then
                strSQL = "UPDATE Subject" & vbCrLf
                strSQL &= "Set SubjectCode = '" & txtSubCode.Text & "'" & vbCrLf
                strSQL &= ", Description = '" & txtSubDescription.Text & "'" & vbCrLf
                strSQL &= ", Units = " & txtUnit.Text & vbCrLf
                strSQL &= ", SubjectType =  '" & getSubjectTypeCode(cboType.Text) & "'" & vbCrLf
                strSQL &= ", UpdatedDate = getDate() " & vbCrLf
                strSQL &= ", UpdatedBy ='" & frm_Login.txtUserName.Text & "'" & vbCrLf
                strSQL &= "WHERE SubjectCode ='" & strCode & "'" & vbCrLf
                blnResult = EXEC_SHS(strSQL)

                If blnResult = True Then
                    strSQL = "UPDATE SubjectRelation" & vbCrLf
                    strSQL &= "SET SubjectCode = '" & txtSubCode.Text & "'" & vbCrLf
                    strSQL &= "WHERE SubjectCode = '" & strCode & "'" & vbCrLf
                    blnResult = EXEC_SHS(strSQL)

                    'If chklstPrerequisite.CheckedItems.Count <> 0 Then
                    '    For i = 0 To chklstPrerequisite.CheckedItems.Count - 1
                    '        strChckItems &= "'" + chklstPrerequisite.CheckedItems(i) + "'" + ","
                    '    Next


                    '    strChckItems = strChckItems.Substring(0, strChckItems.Length - 1)

                    '    strSQL = vbNullString
                    '    strSQL &= "DELETE SubjectRelation" & vbCrLf
                    '    strSQL &= "WHERE SubjectCode = '" & txtSubCode.Text & "' AND PreRequisiteCode NOT IN(" & strChckItems & ")"
                    '    rsDeletePre.Open(strSQL, conDB, 1, 4)

                    'End If
                End If
               
                Call AuditTrail(2, "Modify Subject with code: " & txtSubCode.Text)
                MsgBox("Changes Saved!", vbInformation)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class