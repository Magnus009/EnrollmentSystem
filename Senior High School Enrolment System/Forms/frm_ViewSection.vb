Public Class frm_ViewSection
    Dim strSQL As String
    Dim strCode As String
    Private Sub frm_ViewSchedules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getSchedule()
        Call getStudents()

        lblDate1.Text = Format(Now, "dd/MM/yyyy")

    End Sub

    Public Sub getSchedule()
        Dim dtSubjects As DataTable

        strSQL = "SELECT SC.ScheduleCode [CODE], SC.SubjectCode [SUBJ CODE],TimeFrom [FROM],TimeTo [TO]," & vbCrLf
        strSQL &= "CAST(datediff(minute, TimeFrom,TimeTo )/60.0 AS DECIMAL(2,1)) AS [HOURS]," & vbCrLf
        strSQL &= "S.Units [UNIT], SC.TeacherCode [TEACHER ID] FROM Schedules SC" & vbCrLf
        strSQL &= "INNER JOIN Subject S ON SC.SubjectCode = S.SubjectCode " & vbCrLf
        strSQL &= "WHERE SectionCode ='" & lblSectionCode.Text & "' " & vbCrLf
        'strSQL &= "AND CourseCode ='" & getStrandCode(lblStrand.Text) & "'" & vbCrLf
        dtSubjects = SELECT_SHS(strSQL)

        With grdSubjects
            .Columns.Clear()
            .Columns.Add("colSectCode", "CODE")
            .Columns.Add("colSubjCode", "SUBJ CODE")
            .Columns.Add("colFrom", "FROM")
            .Columns.Add("colTo", "TO")
            .Columns.Add("colHours", "HOURS")
            .Columns.Add("colUnits", "UNITS")
            .Columns.Add("colTeacher", "TEACHER")
            Dim btnDelete As New DataGridViewButtonColumn
            .Columns.Add(btnDelete)
            btnDelete.Name = "DROP"
            btnDelete.Text = "X"
            btnDelete.DefaultCellStyle.ForeColor = Color.White
            btnDelete.DefaultCellStyle.BackColor = Color.Red
            btnDelete.UseColumnTextForButtonValue = True
        End With

        For Each dr As DataRow In dtSubjects.Rows
            Dim row As String()

            row = New String() {dr(0), dr(1), FormatDateTime(dr(2), DateFormat.ShortTime), FormatDateTime(dr(3), DateFormat.ShortTime), dr(4), dr(5), dr(6), "X"}
            grdSubjects.Rows.Add(row)
        Next

    End Sub

    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        Dim frmAddSched As New frm_AddSchedule
        With frmAddSched
            .cboStrand.Text = lblStrand.Text
            .cboSection.Text = lblSectionName.Text
            .ShowDialog()
        End With
    End Sub
    Public Sub getStudents()
        Try
            Dim dtStudents As New DataTable

            strSQL = "SELECT S.StudentID [ID], LastName + ', ' + FirstName + ' ' +" & vbCrLf
            strSQL &= "CASE WHEN MiddleName='' OR MiddleName IS NULL THEN ''" & vbCrLf
            strSQL &= "ELSE MiddleName END + ' ' +" & vbCrLf
            strSQL &= "CASE WHEN ExtName = '' OR ExtName IS NULL THEN ''" & vbCrLf
            strSQL &= "ELSE ExtName END AS Name, Classification FROM Students S" & vbCrLf
            strSQL &= "INNER JOIN StudentSection SS ON S.StudentID = SS.StudentID " & vbCrLf
            strSQL &= "WHERE SS.SectionCode = '" & lblSectionCode.Text & "'" & vbCrLf
            dtStudents = SELECT_SHS(strSQL)

            With grdStudents
                .DataSource = dtStudents
                Dim btnView As New DataGridViewButtonColumn
                .Columns.Add(btnView)
                btnView.Name = "View"
                btnView.Text = "ASSIGN"
                btnView.UseColumnTextForButtonValue = True
                .Columns("Classification").Visible = False

                .Columns("ID").Width = .Width * 0.2
                .Columns("Name").Width = .Width * 0.5
                .Columns("View").Width = .Width * 0.15
            End With
            AddHandler grdStudents.CellFormatting, AddressOf grdStudents_CellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim frmAssignStudent As New frm_AssignStudents
        With frmAssignStudent
            .cboStrand.Text = lblStrand.Text
            .cboLevel.Text = lblGradeLevel.Text.Substring(5, 2)
            .ShowDialog()
        End With
    End Sub

    Private Sub grdSubjects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSubjects.CellContentClick
        Dim blnDelete As Boolean

        If grdSubjects.Columns(e.ColumnIndex).Name = "DROP" Then
            If MsgBox("Are you sure you want to drop this subject?", vbYesNo) = vbYes Then
                strSQL= "DELETE FROM Schedules" & vbCrLf
                strSQL &= "WHERE ScheduleCode = '" & grdSubjects.Rows(e.RowIndex).Cells("colSectCode").Value & "'" & vbCrLf
                blnDelete = EXEC_SHS(strSQL)

                If blnDelete = True Then
                    Call getSchedule()
                    MsgBox("Subject dropped!", vbInformation)
                End If
            End If
        End If
    End Sub

    Private Sub grdStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdStudents.CellContentClick
        Dim dtStudent As New DataTable
        Dim frmIrreg As New frm_IrregSchedule

        If grdStudents.Columns(e.ColumnIndex).Name = "View" Then
            strSQL = "SELECT LastName + ', ' + FirstName + ' ' + MiddleName AS NAME, LRN, Sex, Sec.SectionName, S.Classification FROM Students S" & vbCrLf
            strSQL &= "INNER JOIN StudentSection SS ON S.StudentID = SS.StudentID" & vbCrLf
            strSQL &= "INNER JOIN Sections Sec ON SS.SectionCode = Sec.SectionCode" & vbCrLf
            strSQL &= "WHERE S.StudentID = '" & grdStudents.Rows(e.RowIndex).Cells("ID").Value() & "'" & vbCrLf
            dtStudent = SELECT_SHS(strSQL)

            If dtStudent.Rows(0)("Classification") = 2 Then
                With frmIrreg
                    .lblStudentName.Text = dtStudent.Rows(0)("NAME")
                    .lblStudentCode.Text = dtStudent.Rows(0)("LRN")
                    .picStudent.ImageLocation = "C:\Users\jerem\Desktop\enrolment_system\Senior High School Enrolment System\Resources\" & dtStudent.Rows(0)("LRN") & ".png"
                    .lblSectionName.Text = dtStudent.Rows(0)("SectionName")
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub grdStudents_CellStyle(sender As Object, e As DataGridViewCellFormattingEventArgs)

        With grdStudents
            If .Rows(e.RowIndex).Cells("Classification").Value = 2 Then
                .Rows(.RowCount - 1).Cells("ID").Style.BackColor = Color.Orange
                .Rows(.RowCount - 1).Cells("ID").Style.SelectionBackColor = Color.OrangeRed
                .Rows(.RowCount - 1).Cells("Name").Style.BackColor = Color.Orange
                .Rows(.RowCount - 1).Cells("Name").Style.SelectionBackColor = Color.OrangeRed

                .Rows(.RowCount - 1).DefaultCellStyle.BackColor = Color.DarkGreen
                .Rows(.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                .Rows(.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.DarkGreen
                .Rows(.RowCount - 1).DefaultCellStyle.SelectionForeColor = Color.White
            ElseIf .Rows(e.RowIndex).Cells("Classification").Value = 3 Then
                .Rows(.RowCount - 1).Cells("ID").Style.BackColor = Color.Red
                .Rows(.RowCount - 1).Cells("ID").Style.ForeColor = Color.White
                .Rows(.RowCount - 1).Cells("ID").Style.SelectionBackColor = Color.DarkRed
                .Rows(.RowCount - 1).Cells("Name").Style.BackColor = Color.Red
                .Rows(.RowCount - 1).Cells("Name").Style.ForeColor = Color.White
                .Rows(.RowCount - 1).Cells("Name").Style.SelectionBackColor = Color.DarkRed
                .Rows(.RowCount - 1).Cells("View").ReadOnly = True
            Else
                .Rows(.RowCount - 1).Cells("View").ReadOnly = True
            End If
        End With

    End Sub
End Class