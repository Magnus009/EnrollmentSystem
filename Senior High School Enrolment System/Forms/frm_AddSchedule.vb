Public Class frm_AddSchedule
    Dim strSQL As String
    Public strSchedCode As String
    

    Private Sub frm_AddSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getSubject()
        Call getTeacher()
        Call getStrand()
        Call getSection()
    End Sub

    Private Sub getSubject()
        Dim rsSubject As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT Description FROM Subject"
        rsSubject.Open(strSQL, conDB, 1, 4)

        For i = 1 To rsSubject.RecordCount
            cboSubject.Items.Add(rsSubject.Fields(0).Value)

            rsSubject.MoveNext()
        Next
    End Sub

    Private Sub getTeacher()
        Dim rsTeacher As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT LastName + ', ' + "
        strSQL &= "FirstName + ' ' +  "
        strSQL &= "MiddleName + ' ' + "
        strSQL &= "CASE WHEN ExtName = 'N/A' THEN ''"
        strSQL &= "ELSE ExtName End AS Name FROM Teachers "
        strSQL &= "ORDER BY LastName asc "
        rsTeacher.Open(strSQL, conDB, 1, 4)

        For i = 1 To rsTeacher.RecordCount
            cboTeacher.Items.Add(rsTeacher.Fields(0).Value)

            rsTeacher.MoveNext()
        Next
    End Sub

    Public Sub getStrand()
        Dim rsStrand As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT CourseName FROM Strand"
        rsStrand.Open(strSQL, conDB, 1, 4)

        For i = 1 To rsStrand.RecordCount
            cboStrand.Items.Add(rsStrand.Fields(0).Value)

            rsStrand.MoveNext()
        Next

    End Sub

    Public Sub getSection()
        Dim rsSection As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT SectionName FROM Sections"
        rsSection.Open(strSQL, conDB, 1, 4)

        For i = 1 To rsSection.RecordCount
            cboSection.Items.Add(rsSection.Fields(0).Value)

            rsSection.MoveNext()
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rsAdd As New ADODB.Recordset
        Dim rsCode As New ADODB.Recordset
        Dim strSchedCode As String

        If MsgBox("Are you sure you want to add this schedule?", vbYesNo, "Register Schedule") = vbYes Then

            Call SQLConnect()
            strSQL = vbNullString
            strSQL &= "SELECT LEFT(convert(VARCHAR, getdate(),112),6) +" & vbCrLf
            strSQL &= "RIGHT('00' + convert(VARCHAR,coalesce(max(right(ScheduleCode, 3)),0) + 1),3) FROM Schedules  " & vbCrLf
            strSQL &= "WHERE ScheduleCode LIKE LEFT(convert(VARCHAR, getdate(),112),6) + '%'"
            rsCode.Open(strSQL, conDB, 1, 4)
            strSchedCode = rsCode.Fields(0).Value

            strSQL = vbNullString
            strSQL &= "INSERT INTO Schedules" & vbCrLf
            strSQL &= "VALUES (" & vbCrLf
            strSQL &= "'" & Now.Year & "-" & Now.Year + 1 & "'," & vbCrLf
            strSQL &= "'" & strSchedCode & "'," & vbCrLf
            strSQL &= "'" & getStrandCode(cboStrand.Text) & "'," & vbCrLf
            strSQL &= "'" & getSubjectCode(cboSubject.Text) & "'," & vbCrLf
            strSQL &= "'" & getTeacherCode(cboTeacher.Text) & "'," & vbCrLf
            strSQL &= "'" & getSectionCode(cboSection.Text) & "'," & vbCrLf
            strSQL &= "'" & txtRoomNo.Text & "'," & vbCrLf
            strSQL &= "'" & txtTimeFrom.Text & " " & cboFrom.Text & "'," & vbCrLf
            strSQL &= "'" & txtTimeTo.Text & " " & cboTo.Text & "'," & vbCrLf
            strSQL &= "getdate()," & vbCrLf
            strSQL &= "Null," & vbCrLf
            strSQL &= "getdate()," & vbCrLf
            strSQL &= "'" & frm_Login.txtUserName.Text & "')" & vbCrLf
            rsAdd.Open(strSQL, conDB, 1, 4)

            AuditTrail(1, "Add a schedule with code: " & strSchedCode)
            MsgBox("Schedule Saved!" & vbCrLf & "Schedule Code: " & strSchedCode, vbInformation, "Register Schedule")
            Call frm_ViewSection.getSchedule()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim rsUpdate As New ADODB.Recordset

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
            rsUpdate.Open(strSQL, conDB, 1, 4)

            AuditTrail(2, "Update schedule with Schedule Code:" & strSchedCode)

            MsgBox("Changes Saved!", vbInformation)
            Me.Close()

        End If
    End Sub
End Class