Public Class frm_IrregSchedule
    Dim strSQL As String
    Dim strCode As String
    Private Sub frm_IrregSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setHeader()
        Call getSubjects()
    End Sub

    Private Sub setHeader()
        Dim btnView As New DataGridViewButtonColumn()

        btnView.FlatStyle = FlatStyle.Flat
        btnView.DefaultCellStyle.BackColor = Color.Red
        btnView.DefaultCellStyle.ForeColor = Color.White
        btnView.DefaultCellStyle.SelectionBackColor = Color.Red
        btnView.DefaultCellStyle.SelectionForeColor = Color.White
        grdSubjects.ReadOnly = True
        With grdSubjects
            .Columns.Clear()
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Columns.Add("colsubCode", "CODE") : .Columns(0).Width = .Width * 0.1
            .Columns.Add("colSubject", "SUBJECT") : .Columns(1).Width = .Width * 0.3
            .Columns.Add("colSched", "SCHEDULE") : .Columns(2).Width = .Width * 0.12
            .Columns.Add("colHours", "HOURS") : .Columns(3).Width = .Width * 0.085
            .Columns.Add("colUnits", "UNITS") : .Columns(4).Width = .Width * 0.072
            .Columns.Add("colTeacher", "TEACHER") : .Columns(5).Width = .Width * 0.26
            .Columns.Add(btnView) : .Columns(6).Width = .Width * 0.06

        End With
    End Sub

    Public Sub getSubjects()
        Dim rsSched As New ADODB.Recordset
        Dim strTime As String
        Dim strHours As String
        Dim strUnits As String
        Dim strTeacher As String

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT I.ScheduleCode, S.SubjectCode, S.TimeFrom, S.TimeTo," & vbCrLf
        strSQL &= "CAST(datediff(minute, S.TimeFrom,S.TimeTo )/60 AS DECIMAL(2,1)) AS Sched, Sub.Units, S.TeacherCode FROM IrregSchedules I" & vbCrLf
        strSQL &= "INNER JOIN Schedules S ON I.ScheduleCode = S.ScheduleCode" & vbCrLf
        strSQL &= "INNER JOIN Subject Sub ON Sub.SubjectCode = S.SubjectCode" & vbCrLf
        strSQL &= "INNER JOIN Students ST ON ST.StudentID = I.StudentID AND ST.Classification = 2" & vbCrLf
        strSQL &= "WHERE ST.LRN = '" & lblStudentCode.Text & "'" & vbCrLf
        strSQL &= "AND I.DroppedDate IS NULL AND I.DeletedDate IS NULL"
        rsSched.Open(strSQL, conDB, 1, 4)


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
                .Rows(.RowCount - 1).Cells(6).Value = "Drop"

                rsSched.MoveNext()
            Loop
        End With
        'strCode = strCode.Substring(0, strCode.Length - 1)
    End Sub


    Private Sub grdSubjects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSubjects.CellContentClick
        Dim rsDelete As New ADODB.Recordset
        Dim strSchedCode() As String


        strSchedCode = strCode.Split(",")

        If e.ColumnIndex = 6 Then
            If MsgBox("Are you sure you want to drop this subject?", vbYesNo) = vbYes Then
                strSQL = vbNullString
                strSQL &= "UPDATE IrregSchedules" & vbCrLf
                strSQL &= "SET DroppedDate = getdate()," & vbCrLf
                strSQL &= "	UpdatedDate = getdate()," & vbCrLf
                strSQL &= "	UpdatedBy = '" & UserLevelID & "'" & vbCrLf
                strSQL &= "WHERE ScheduleCode = '" & strSchedCode(e.RowIndex) & "'" & vbCrLf
                rsDelete.Open(strSQL, conDB, 1, 4)

                Call getSubjects()

                MsgBox("Subject dropped!", vbInformation)
            End If

        End If
    End Sub

    Private Sub btnAssignSub_Click(sender As Object, e As EventArgs) Handles btnAssignSub.Click
        frm_IrregAssignSection.getStudentID(lblStudentCode.Text)
    End Sub

End Class