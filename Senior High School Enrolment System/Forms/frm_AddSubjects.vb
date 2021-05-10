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
        Dim rsSubject As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT * FROM Subject"
        rsSubject.Open(strSQL, conDB, 1, 4)

        Do While rsSubject.EOF = False
            With chklstPrerequisite
                .Items.Add(rsSubject.Fields(1).Value, False)
            End With

            rsSubject.MoveNext()
        Loop
        

    End Sub

    Public Sub getSubjectType()
        Dim rsType As New ADODB.Recordset

        strSQL = vbNullString
        strSQL &= "SELECT Description FROM SubjectType"
        rsType.Open(strSQL, conDB, 1, 4)

        For i = 1 To rsType.RecordCount
            cboType.Items.Add(rsType.Fields(0).Value)

            rsType.MoveNext()
        Next

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rsInsertSub As New ADODB.Recordset
        Dim rsInserPre As New ADODB.Recordset
        Dim rsCheck As New ADODB.Recordset

        If MsgBox("Are you sure you want to register?", vbYesNo, vbQuestion) = vbYes Then

            Call SQLConnect()

            strSQL = vbNullString
            strSQL &= "SELECT * FROM Subject" & vbCrLf
            strSQL &= "WHERE SubjectCode = '" & txtSubCode.Text & "'" & vbCrLf
            rsCheck.Open(strSQL, conDB, 1, 4)

            If rsCheck.EOF = False Then
                MsgBox("Subject Code already exist!", vbExclamation)
            Else
                strSQL = vbNullString
                strSQL &= "INSERT INTO Subject " & vbCrLf
                strSQL &= "VALUES (" & vbCrLf
                strSQL &= "'" & txtSubCode.Text & "'" & vbCrLf
                strSQL &= ",'" & txtSubDescription.Text & "'" & vbCrLf
                strSQL &= ",'" & txtUnit.Text & "'" & vbCrLf
                strSQL &= ",'" & getSubjectTypeCode(cboType.Text) & "'" & vbCrLf
                strSQL &= ",getdate()" & vbCrLf
                strSQL &= ",Null" & vbCrLf
                strSQL &= ",getdate()" & vbCrLf
                strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
                rsInsertSub.Open(strSQL, conDB, 1, 4)


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
                        rsInserPre.Open(strSQL, conDB, 1, 4)

                    Next
                End If

                Call AuditTrail(1, "Registered Subject with subject code of: " & txtSubCode.Text)

                MsgBox("Subject Registered!", vbInformation)
            End If

           
        End If


    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim rsUpdateSub As New ADODB.Recordset
        Dim rsUpdatePre As New ADODB.Recordset
        Dim rsDeletePre As New ADODB.Recordset
        Dim strChckItems As String = ""

        If MsgBox("Are you sure you want to save changes?", vbYesNo, vbQuestion) = vbYes Then

            Call SQLConnect()
            strSQL = vbNullString
            strSQL &= "UPDATE Subject" & vbCrLf
            strSQL &= "Set SubjectCode = '" & txtSubCode.Text & "'" & vbCrLf
            strSQL &= ", Description = '" & txtSubDescription.Text & "'" & vbCrLf
            strSQL &= ", Units = " & txtUnit.Text & vbCrLf
            strSQL &= ", SubjectType =  '" & getSubjectTypeCode(cboType.Text) & "'" & vbCrLf
            strSQL &= ", UpdatedDate = getDate() " & vbCrLf
            strSQL &= ", UpdatedBy ='" & frm_Login.txtUserName.Text & "'" & vbCrLf
            strSQL &= "WHERE SubjectCode ='" & strCode & "'" & vbCrLf
            rsUpdateSub.Open(strSQL, conDB, 1, 4)

            strSQL = vbNullString
            strSQL &= "UPDATE SubjectRelation" & vbCrLf
            strSQL &= "SET SubjectCode = '" & txtSubCode.Text & "'" & vbCrLf
            strSQL &= "WHERE SubjectCode = '" & strCode & "'" & vbCrLf
            rsUpdatePre.Open(strSQL, conDB, 1, 4)

            If chklstPrerequisite.CheckedItems.Count <> 0 Then
                For i = 0 To chklstPrerequisite.CheckedItems.Count - 1
                    strChckItems &= "'" + chklstPrerequisite.CheckedItems(i) + "'" + ","
                Next


                strChckItems = strChckItems.Substring(0, strChckItems.Length - 1)

                strSQL = vbNullString
                strSQL &= "DELETE SubjectRelation" & vbCrLf
                strSQL &= "WHERE SubjectCode = '" & txtSubCode.Text & "' AND PreRequisiteCode NOT IN(" & strChckItems & ")"
                rsDeletePre.Open(strSQL, conDB, 1, 4)

            End If
            Call AuditTrail(2, "Modify Subjectc with code: " & txtSubCode.Text)
            MsgBox("Changes Saved!", vbInformation)
            Me.Close()
        End If
    End Sub
End Class