Public Class frm_ViewSection
    Dim strSQL As String
    Dim strCode As String
    Private Sub frm_ViewSchedules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setHeader()
        Call getSchedule()
        Call getStudents()

        lblDate1.Text = Format(Now, "dd/MM/yyyy")

    End Sub

    Public Sub setHeader()
        Dim btnRemove As New DataGridViewButtonColumn()
        Dim btnAssign As New DataGridViewButtonColumn()

        'VIEW
        btnRemove.FlatStyle = FlatStyle.Flat
        btnRemove.DefaultCellStyle.BackColor = Color.Red
        btnRemove.DefaultCellStyle.ForeColor = Color.White
        btnRemove.DefaultCellStyle.SelectionBackColor = Color.Red
        btnRemove.DefaultCellStyle.SelectionForeColor = Color.White
        'ASSIGN
        btnAssign.FlatStyle = FlatStyle.Flat
        With grdSubjects
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Columns.Clear()
            .Columns.Add("colsubCode", "CODE") : .Columns(0).Width = .Width * 0.1
            .Columns.Add("colSubject", "SUBJECT") : .Columns(1).Width = .Width * 0.327
            .Columns.Add("colSched", "SCHEDULE") : .Columns(2).Width = .Width * 0.15
            .Columns.Add("colHours", "HOURS") : .Columns(3).Width = .Width * 0.09
            .Columns.Add("colUnits", "UNITS") : .Columns(4).Width = .Width * 0.08
            .Columns.Add("colTeacher", "TEACHER") : .Columns(5).Width = .Width * 0.2
            .Columns.Add(btnRemove) : .Columns(6).Width = .Width * 0.05
        End With

        With grdStudents
            .Columns.Clear()
            .Columns.Add("colCode", "CODE") : .Columns(0).Width = .Width * 0.2
            .Columns.Add("colname", "NAME") : .Columns(1).Width = .Width * 0.62
            .Columns.Add(btnAssign) : .Columns(2).Width = .Width * 0.17
        End With
    End Sub

    Public Sub getSchedule()
        Dim rsSched As New ADODB.Recordset
        Dim strTime As String
        Dim strHours As String
        Dim strUnits As String
        Dim strTeacher As String

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT SC.ScheduleCode, SC.SubjectCode,TimeFrom,TimeTo," & vbCrLf
        strSQL &= "CAST(datediff(minute, TimeFrom,TimeTo )/60.0 AS DECIMAL(2,1)) AS Sched," & vbCrLf
        strSQL &= "S.Units, SC.TeacherCode  FROM Schedules SC" & vbCrLf
        strSQL &= "INNER JOIN Subject S ON SC.SubjectCode = S.SubjectCode " & vbCrLf
        strSQL &= "WHERE SectionCode ='" & lblSectionCode.Text & "' " & vbCrLf
        'strSQL &= "AND CourseCode ='" & getStrandCode(lblStrand.Text) & "'" & vbCrLf
        rsSched.Open(strSQL, conDB, 1, 4)

        If rsSched.EOF = False Then
            With grdSubjects
                .RowCount = 0
                strCode = vbNullString
                Do While rsSched.EOF = False
                    strTime = FormatDateTime(rsSched.Fields(2).Value, DateFormat.ShortTime) & " - " & FormatDateTime(rsSched.Fields(3).Value, DateFormat.ShortTime)
                    strHours = rsSched.Fields(4).Value & " hrs"
                    strUnits = rsSched.Fields(5).Value
                    strTeacher = getTeacherName(rsSched.Fields(6).Value)
                    strCode &= rsSched.Fields(0).Value + ","
                    .Rows.Add()
                    .Rows(.RowCount - 1).Height = 40
                    .Rows(.RowCount - 1).Cells(0).Value = rsSched.Fields(1).Value
                    .Rows(.RowCount - 1).Cells(1).Value = UCase(getSubjectName(rsSched.Fields(1).Value))
                    .Rows(.RowCount - 1).Cells(2).Value = strTime
                    .Rows(.RowCount - 1).Cells(3).Value = strHours
                    .Rows(.RowCount - 1).Cells(4).Value = strUnits
                    .Rows(.RowCount - 1).Cells(5).Value = UCase(strTeacher)
                    .Rows(.RowCount - 1).Cells(6).Value = "X"
                    .Rows(.RowCount - 1).Cells(6).Style.BackColor = Color.Red
                    .Rows(.RowCount - 1).Cells(6).Style.ForeColor = Color.White

                    rsSched.MoveNext()
                Loop
            End With
            strCode = strCode.Substring(0, strCode.Length - 1)
        End If
    End Sub

    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        frm_AddSchedule.cboStrand.Text = lblStrand.Text
        frm_AddSchedule.cboSection.Text = lblSecyionName.Text

        frm_AddSchedule.ShowDialog()
    End Sub

    Public Sub getStudents()
        Dim rsStudents As New ADODB.Recordset

        strSQL = vbNullString
        strSQL &= "SELECT S.StudentID, LastName + ', ' + FirstName + ' ' +" & vbCrLf
        strSQL &= "CASE WHEN MiddleName='' OR MiddleName IS NULL THEN ''" & vbCrLf
        strSQL &= "ELSE MiddleName END + ' ' +" & vbCrLf
        strSQL &= "CASE WHEN ExtName = '' OR ExtName IS NULL THEN ''" & vbCrLf
        strSQL &= "ELSE ExtName END AS Name, Classification FROM Students S" & vbCrLf
        strSQL &= "INNER JOIN StudentSection SS ON S.StudentID = SS.StudentID " & vbCrLf
        strSQL &= "WHERE SS.SectionCode = '" & lblSectionCode.Text & "'" & vbCrLf

        rsStudents.Open(strSQL, conDB, 1, 4)

        grdStudents.RowCount = 0
        Do While rsStudents.EOF = False
            With grdStudents
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = rsStudents.Fields(0).Value
                .Rows(.RowCount - 1).Cells(1).Value = rsStudents.Fields(1).Value

                If rsStudents.Fields(2).Value = 2 Then
                    .Rows(.RowCount - 1).Cells(2).Value = "ASSIGN"
                    .Rows(.RowCount - 1).Cells(0).Style.BackColor = Color.Orange
                    .Rows(.RowCount - 1).Cells(0).Style.SelectionBackColor = Color.OrangeRed
                    .Rows(.RowCount - 1).Cells(1).Style.BackColor = Color.Orange
                    .Rows(.RowCount - 1).Cells(1).Style.SelectionBackColor = Color.OrangeRed

                    .Rows(.RowCount - 1).DefaultCellStyle.BackColor = Color.DarkGreen
                    .Rows(.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                    .Rows(.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.DarkGreen
                    .Rows(.RowCount - 1).DefaultCellStyle.SelectionForeColor = Color.White
                ElseIf rsStudents.Fields(2).Value = 3 Then
                    .Rows(.RowCount - 1).Cells(0).Style.BackColor = Color.Red
                    .Rows(.RowCount - 1).Cells(0).Style.ForeColor = Color.White
                    .Rows(.RowCount - 1).Cells(0).Style.SelectionBackColor = Color.DarkRed
                    .Rows(.RowCount - 1).Cells(1).Style.BackColor = Color.Red
                    .Rows(.RowCount - 1).Cells(1).Style.ForeColor = Color.White
                    .Rows(.RowCount - 1).Cells(1).Style.SelectionBackColor = Color.DarkRed
                Else
                    .Rows(.RowCount - 1).Cells(2).ReadOnly = True
                End If
                rsStudents.MoveNext()
            End With
        Loop


    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        frm_AssignStudents.cboStrand.Text = lblStrand.Text

        frm_AssignStudents.cboLevel.Text = lblGradeLevel.Text.Substring(5, 2)

        frm_AssignStudents.ShowDialog()

    End Sub

    Private Sub grdSubjects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSubjects.CellContentClick
        Dim rsDelete As New ADODB.Recordset
        Dim strSchedCode() As String


        strSchedCode = strCode.Split(",")

        If e.ColumnIndex = 6 Then
            If MsgBox("Are you sure you want to drop this subject?", vbYesNo) = vbYes Then
                strSQL = vbNullString
                strSQL &= "DELETE FROM Schedules" & vbCrLf
                strSQL &= "WHERE ScheduleCode = '" & strSchedCode(e.RowIndex) & "'" & vbCrLf
                rsDelete.Open(strSQL, conDB, 1, 4)

                Call getSchedule()

                MsgBox("Subject dropped!", vbInformation)
            End If

        End If
    End Sub

    Private Sub grdStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdStudents.CellContentClick
        Dim rsType As New ADODB.Recordset

        If e.ColumnIndex = 2 Then
            strSQL = vbNullString
            strSQL &= "SELECT LastName + ', ' + FirstName + ' ' + MiddleName AS NAME, LRN, Sex, Sec.SectionName, S.Classification FROM Students S" & vbCrLf
            strSQL &= "INNER JOIN StudentSection SS ON S.StudentID = SS.StudentID" & vbCrLf
            strSQL &= "INNER JOIN Sections Sec ON SS.SectionCode = Sec.SectionCode" & vbCrLf
            strSQL &= "WHERE S.StudentID = '" & grdStudents.Rows(e.RowIndex).Cells(0).Value() & "'" & vbCrLf
            rsType.Open(strSQL, conDB, 1, 4)

            If rsType.Fields(4).Value = 2 Then
                frm_IrregSchedule.lblStudentName.Text = rsType.Fields(0).Value
                frm_IrregSchedule.lblStudentCode.Text = rsType.Fields(1).Value
                frm_IrregSchedule.picStudent.ImageLocation = "C:\Users\jerem\Desktop\enrolment_system\Senior High School Enrolment System\Resources\" & rsType.Fields(2).Value & ".png"
                frm_IrregSchedule.lblSectionName.Text = rsType.Fields(3).Value
                frm_IrregSchedule.ShowDialog()
            End If

        End If
    End Sub

End Class