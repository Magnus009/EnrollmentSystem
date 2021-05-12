Public Class mdiSES

    Private Sub mdiSES_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_dashboard.Close()
        frm_Login.Show()
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lblDate.Text = Format(Now, "dd/MM/yyyy")
        frm_dashboard.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles lblTime.Click
        lblTime.Text = Now
    End Sub

    Private Sub ToolStripLabel1_Click_1(sender As Object, e As EventArgs) Handles lblDate.Click
        lblDate.Text = Now
    End Sub

    Private Sub RegisterStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterStudentToolStripMenuItem.Click
        'frm_AddStudent.MdiParent = Me
        'frm_AddStudent.Show()
    End Sub

    Private Sub ActivityLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivityLogsToolStripMenuItem.Click
        frm_AuditTrail.Show()
    End Sub

    Private Sub ChecklistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChecklistToolStripMenuItem.Click
        frm_coursecard.ShowDialog()
    End Sub

    Private Sub ViewStudentRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStudentRecordToolStripMenuItem.Click
        frm_StudentRecords.MdiParent = Me
        frm_StudentRecords.Show()
    End Sub

    Private Sub EvaluationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluationToolStripMenuItem.Click
        frm_AssignSection.MdiParent = Me
        frm_AssignSection.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ''AUDIT TRAIL MO TO COPY PASTE SA LAHAT NG FUNCTION
        ''userlevel = named
        'detail = "LOG-OUT SUCCESS"
        'activity = "Successfully LOG-OUT"
        'Call audit()

        ''~~~~~~~~~~~~~~
        Call AuditTrail(5, frm_Login.txtUserName.Text + " Sign Out")
        frm_Login.Show()
        Me.Close()
    End Sub

    Private Sub AddSchoolYearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSchoolYearToolStripMenuItem.Click
        frm_addschoolyear.Show()

    End Sub

    Private Sub EditSchoolYearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSchoolYearToolStripMenuItem.Click
        frm_setschoolyear.Show()

    End Sub

    Private Sub AddSubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSubjectToolStripMenuItem.Click
        frm_AddSubjects.ShowDialog()

    End Sub

    Private Sub PrintRegistrationFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintRegistrationFormToolStripMenuItem.Click
        frm_regform.ShowDialog()
    End Sub

    Private Sub EditSubjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSubjectsToolStripMenuItem.Click
        frm_ViewSubjectRecords.Show()
    End Sub

    Private Sub CreateAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAccountToolStripMenuItem.Click
        frm_CreateAccount.ShowDialog()
    End Sub

    Private Sub AddTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTeacherToolStripMenuItem.Click
        frm_AddTeacher.ShowDialog()
    End Sub

    Private Sub ViewTeachersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTeachersToolStripMenuItem.Click
        frm_TeacherRecords.ShowDialog()
    End Sub

    Private Sub ViewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAccountToolStripMenuItem.Click
        frm_Accounts.ShowDialog()
    End Sub

    Private Sub AddScheduleCodeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_AddSchedule.Show()
    End Sub

    Private Sub AddSectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSectionToolStripMenuItem.Click
        frm_Section.ShowDialog()
    End Sub

    Private Sub AddStrandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStrandToolStripMenuItem.Click
        frm_AddStrand.ShowDialog()
    End Sub

    Private Sub SearchStrandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchStrandToolStripMenuItem.Click
        frm_ViewStrands.ShowDialog()
    End Sub

    Private Sub EvaluateGradesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluateGradesToolStripMenuItem.Click
        frm_GradingTeacher.MdiParent = Me
        frm_GradingTeacher.Show()
    End Sub
End Class