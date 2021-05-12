Public Class frm_AddSchedule
    Public strSchedCode As String
    

    Private Sub frm_AddSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getSubject()
        Call getTeacher()
        Call getStrand()
        ' Call getSection()
    End Sub

    Private Sub getSubject()

        strSQL = "SELECT SubjectCode, Description FROM Subject"
        cboDataBind(cboSubject, strSQL, "--SELECT SUBJECT--")

    End Sub

    Private Sub getTeacher()
        strSQL = "SELECT TeacherCode,LastName + ', ' + " & vbCrLf
        strSQL &= "FirstName + ' ' +  " & vbCrLf
        strSQL &= "MiddleName + ' ' + " & vbCrLf
        strSQL &= "CASE WHEN ExtName = 'N/A' THEN ''" & vbCrLf
        strSQL &= "ELSE ExtName End AS Name FROM Teachers " & vbCrLf
        strSQL &= "ORDER BY LastName asc " & vbCrLf
        cboDataBind(cboTeacher, strSQL, "--SELECT TEACHER/INSTRUCTOR--")
    End Sub

    Public Sub getStrand()
        strSQL = "SELECT CourseCode, CourseName FROM Strand"
        cboDataBind(cboStrand, strSQL, "--SELECT STRAND--")
        AddHandler cboStrand.SelectedIndexChanged, AddressOf cboStrand_Changed
    End Sub

    Public Sub getSection()
        strSQL = "SELECT SectionCode, SectionName FROM Sections" & vbCrLf
        strSQL &= "WHERE CourseCode = '" & cboStrand.SelectedValue.ToString & "'"
        cboDataBind(cboSection, strSQL, "--SELECT SECTION--")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strSchedCode As String
        Dim blnResult As Boolean
        Try
            If MsgBox("Are you sure you want to add this schedule?", vbYesNo, "Register Schedule") = vbYes Then

                strSQL = vbNullString
                strSQL &= "SELECT LEFT(convert(VARCHAR, getdate(),112),6) +" & vbCrLf
                strSQL &= "RIGHT('00' + convert(VARCHAR,coalesce(max(right(ScheduleCode, 3)),0) + 1),3) FROM Schedules  " & vbCrLf
                strSQL &= "WHERE ScheduleCode LIKE LEFT(convert(VARCHAR, getdate(),112),6) + '%'"
                strSchedCode = SELECT_SHS(strSQL).Rows(0)(0)

                strSQL = vbNullString
                strSQL &= "INSERT INTO Schedules" & vbCrLf
                strSQL &= "VALUES (" & vbCrLf
                strSQL &= "'" & Now.Year & "-" & Now.Year + 1 & "'," & vbCrLf
                strSQL &= "'" & strSchedCode & "'," & vbCrLf
                strSQL &= "'" & cboStrand.SelectedValue.ToString & "'," & vbCrLf
                strSQL &= "'" & cboSubject.SelectedValue.ToString & "'," & vbCrLf
                strSQL &= "'" & cboTeacher.SelectedValue.ToString & "'," & vbCrLf
                strSQL &= "'" & cboSection.SelectedValue.ToString & "'," & vbCrLf
                strSQL &= "'" & txtRoomNo.Text & "'," & vbCrLf
                strSQL &= "'" & txtTimeFrom.Text & " " & cboFrom.Text & "'," & vbCrLf
                strSQL &= "'" & txtTimeTo.Text & " " & cboTo.Text & "'," & vbCrLf
                strSQL &= "getdate()," & vbCrLf
                strSQL &= "Null," & vbCrLf
                strSQL &= "getdate()," & vbCrLf
                strSQL &= "'" & frm_Login.txtUserName.Text & "')" & vbCrLf
                blnResult = EXEC_SHS(strSQL)

                If blnResult = True Then
                    AuditTrail(1, "Add a schedule with code: " & strSchedCode)
                    MsgBox("Schedule Saved!" & vbCrLf & "Schedule Code: " & strSchedCode, vbInformation, "Register Schedule")
                    Call frm_ViewSection.getSchedule()
                    Me.Hide()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim blnResult As Boolean
        Try
            If MsgBox("Are you sure you want to save changes?", vbYesNo, "MODIFY SCHEDULE") = vbYes Then

                strSQL = vbNullString
                strSQL &= "UPDATE Schedules" & vbCrLf
                strSQL &= "SET CourseCode = '" & getStrandCode(cboStrand.Text) & "'" & vbCrLf
                strSQL &= ", SubjectCode = '" & getSubjectCode(cboSubject.Text) & "'" & vbCrLf
                strSQL &= ", TeacherCode = '" & getTeacherCode(cboTeacher.Text) & "'" & vbCrLf
                strSQL &= ", SectionCode = '" & getSectionName(cboSection.Text) & "'" & vbCrLf
                strSQL &= ", RoomNo = " & txtRoomNo.Text & vbCrLf
                strSQL &= ", TimeFrom = '" & txtTimeFrom.Text & " " & cboFrom.Text & "'" & vbCrLf
                strSQL &= ", TimeTo = '" & txtTimeTo.Text & " " & cboTo.Text & "'" & vbCrLf
                strSQL &= ", UpdatedDate = getDate()" & vbCrLf
                strSQL &= ", UpdatedBy = '" & frm_Login.txtUserName.Text & "'" & vbCrLf
                strSQL &= "WHERE ScheduleCode = '" & strSchedCode & "'" & vbCrLf
                blnResult = EXEC_SHS(strSQL)

                If blnResult = True Then
                    AuditTrail(2, "Update schedule with Schedule Code:" & strSchedCode)
                    MsgBox("Changes Saved!", vbInformation)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
    End Sub

    Private Sub cboStrand_Changed(sender As Object, e As EventArgs)
        If cboStrand.SelectedIndex <> 0 Then
            getSection()
            cboSection.Enabled = True
        Else
            cboSection.Enabled = False
        End If
    End Sub
End Class