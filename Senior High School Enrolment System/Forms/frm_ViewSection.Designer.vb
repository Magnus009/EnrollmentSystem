<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ViewSection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblSecyionName = New System.Windows.Forms.Label()
        Me.lblStrand = New System.Windows.Forms.Label()
        Me.lblSectionCode = New System.Windows.Forms.Label()
        Me.grpSched = New System.Windows.Forms.GroupBox()
        Me.btnAddSubject = New System.Windows.Forms.Button()
        Me.grdSubjects = New System.Windows.Forms.DataGridView()
        Me.grpStudents = New System.Windows.Forms.GroupBox()
        Me.lblIrreg = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblDropped = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.grdStudents = New System.Windows.Forms.DataGridView()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAdviser = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblSem = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.lblAdvName = New System.Windows.Forms.Label()
        Me.lblQaurtr = New System.Windows.Forms.Label()
        Me.lblQuarter = New System.Windows.Forms.Label()
        Me.lblGradeLevel = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.grpSched.SuspendLayout()
        CType(Me.grdSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStudents.SuspendLayout()
        CType(Me.grdStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSecyionName
        '
        Me.lblSecyionName.AutoSize = True
        Me.lblSecyionName.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecyionName.Location = New System.Drawing.Point(266, 34)
        Me.lblSecyionName.Name = "lblSecyionName"
        Me.lblSecyionName.Size = New System.Drawing.Size(160, 23)
        Me.lblSecyionName.TabIndex = 1
        Me.lblSecyionName.Text = "[SECTION NAME]"
        '
        'lblStrand
        '
        Me.lblStrand.AutoSize = True
        Me.lblStrand.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrand.Location = New System.Drawing.Point(175, 83)
        Me.lblStrand.Name = "lblStrand"
        Me.lblStrand.Size = New System.Drawing.Size(128, 19)
        Me.lblStrand.TabIndex = 2
        Me.lblStrand.Text = "[STRAND NAME]"
        '
        'lblSectionCode
        '
        Me.lblSectionCode.AutoSize = True
        Me.lblSectionCode.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionCode.Location = New System.Drawing.Point(175, 111)
        Me.lblSectionCode.Name = "lblSectionCode"
        Me.lblSectionCode.Size = New System.Drawing.Size(128, 18)
        Me.lblSectionCode.TabIndex = 3
        Me.lblSectionCode.Text = "[SECTION CODE]"
        '
        'grpSched
        '
        Me.grpSched.Controls.Add(Me.btnAddSubject)
        Me.grpSched.Controls.Add(Me.grdSubjects)
        Me.grpSched.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSched.Location = New System.Drawing.Point(12, 147)
        Me.grpSched.Name = "grpSched"
        Me.grpSched.Size = New System.Drawing.Size(677, 449)
        Me.grpSched.TabIndex = 4
        Me.grpSched.TabStop = False
        Me.grpSched.Text = "SUBJECTS"
        '
        'btnAddSubject
        '
        Me.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSubject.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubject.Location = New System.Drawing.Point(6, 376)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(165, 26)
        Me.btnAddSubject.TabIndex = 1
        Me.btnAddSubject.Text = "ASSIGN SUBJECT"
        Me.btnAddSubject.UseVisualStyleBackColor = True
        '
        'grdSubjects
        '
        Me.grdSubjects.AllowUserToAddRows = False
        Me.grdSubjects.AllowUserToDeleteRows = False
        Me.grdSubjects.AllowUserToResizeColumns = False
        Me.grdSubjects.AllowUserToResizeRows = False
        Me.grdSubjects.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSubjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdSubjects.ColumnHeadersHeight = 30
        Me.grdSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdSubjects.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdSubjects.Location = New System.Drawing.Point(6, 25)
        Me.grdSubjects.Name = "grdSubjects"
        Me.grdSubjects.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSubjects.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdSubjects.RowHeadersVisible = False
        Me.grdSubjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSubjects.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSubjects.Size = New System.Drawing.Size(665, 345)
        Me.grdSubjects.TabIndex = 0
        '
        'grpStudents
        '
        Me.grpStudents.Controls.Add(Me.lblIrreg)
        Me.grpStudents.Controls.Add(Me.lblGreen)
        Me.grpStudents.Controls.Add(Me.lblDropped)
        Me.grpStudents.Controls.Add(Me.lblRed)
        Me.grpStudents.Controls.Add(Me.btnPrint)
        Me.grpStudents.Controls.Add(Me.btnAddStudent)
        Me.grpStudents.Controls.Add(Me.grdStudents)
        Me.grpStudents.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudents.Location = New System.Drawing.Point(695, 126)
        Me.grpStudents.Name = "grpStudents"
        Me.grpStudents.Size = New System.Drawing.Size(336, 470)
        Me.grpStudents.TabIndex = 5
        Me.grpStudents.TabStop = False
        Me.grpStudents.Text = "STUDENTS"
        '
        'lblIrreg
        '
        Me.lblIrreg.AutoSize = True
        Me.lblIrreg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIrreg.Location = New System.Drawing.Point(27, 423)
        Me.lblIrreg.Name = "lblIrreg"
        Me.lblIrreg.Size = New System.Drawing.Size(76, 17)
        Me.lblIrreg.TabIndex = 6
        Me.lblIrreg.Text = "IRREGULAR"
        '
        'lblGreen
        '
        Me.lblGreen.BackColor = System.Drawing.Color.Orange
        Me.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGreen.Location = New System.Drawing.Point(6, 425)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(14, 13)
        Me.lblGreen.TabIndex = 5
        '
        'lblDropped
        '
        Me.lblDropped.AutoSize = True
        Me.lblDropped.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDropped.Location = New System.Drawing.Point(23, 398)
        Me.lblDropped.Name = "lblDropped"
        Me.lblDropped.Size = New System.Drawing.Size(70, 17)
        Me.lblDropped.TabIndex = 4
        Me.lblDropped.Text = "DROPPED"
        '
        'lblRed
        '
        Me.lblRed.BackColor = System.Drawing.Color.Red
        Me.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRed.Location = New System.Drawing.Point(6, 400)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(14, 13)
        Me.lblRed.TabIndex = 3
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Location = New System.Drawing.Point(197, 425)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(131, 35)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnAddStudent
        '
        Me.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStudent.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Location = New System.Drawing.Point(197, 393)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(131, 26)
        Me.btnAddStudent.TabIndex = 1
        Me.btnAddStudent.Text = "ADD STUDENT"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'grdStudents
        '
        Me.grdStudents.AllowUserToAddRows = False
        Me.grdStudents.AllowUserToDeleteRows = False
        Me.grdStudents.AllowUserToResizeColumns = False
        Me.grdStudents.AllowUserToResizeRows = False
        Me.grdStudents.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdStudents.ColumnHeadersHeight = 30
        Me.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdStudents.Location = New System.Drawing.Point(6, 20)
        Me.grdStudents.Name = "grdStudents"
        Me.grdStudents.ReadOnly = True
        Me.grdStudents.RowHeadersVisible = False
        Me.grdStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdStudents.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.grdStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdStudents.Size = New System.Drawing.Size(324, 367)
        Me.grdStudents.TabIndex = 0
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.AutoSize = True
        Me.lblSchoolYear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYear.Location = New System.Drawing.Point(664, 18)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(107, 16)
        Me.lblSchoolYear.TabIndex = 6
        Me.lblSchoolYear.Text = "SCHOOL YEAR :"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(694, 40)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(77, 16)
        Me.lblSemester.TabIndex = 7
        Me.lblSemester.Text = "SEMESTER :"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(723, 65)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 16)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "DATE :"
        '
        'lblAdviser
        '
        Me.lblAdviser.AutoSize = True
        Me.lblAdviser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdviser.Location = New System.Drawing.Point(701, 89)
        Me.lblAdviser.Name = "lblAdviser"
        Me.lblAdviser.Size = New System.Drawing.Size(70, 16)
        Me.lblAdviser.TabIndex = 9
        Me.lblAdviser.Text = "ADVISER :"
        Me.lblAdviser.Visible = False
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(777, 18)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(68, 17)
        Me.lblYear.TabIndex = 10
        Me.lblYear.Text = "2020-2021"
        '
        'lblSem
        '
        Me.lblSem.AutoSize = True
        Me.lblSem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSem.Location = New System.Drawing.Point(777, 40)
        Me.lblSem.Name = "lblSem"
        Me.lblSem.Size = New System.Drawing.Size(26, 17)
        Me.lblSem.TabIndex = 11
        Me.lblSem.Text = "1ST"
        '
        'lblDate1
        '
        Me.lblDate1.AutoSize = True
        Me.lblDate1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate1.Location = New System.Drawing.Point(777, 64)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(100, 17)
        Me.lblDate1.TabIndex = 12
        Me.lblDate1.Text = "[DD/MM/YYYY]"
        '
        'lblAdvName
        '
        Me.lblAdvName.AutoSize = True
        Me.lblAdvName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvName.Location = New System.Drawing.Point(777, 88)
        Me.lblAdvName.Name = "lblAdvName"
        Me.lblAdvName.Size = New System.Drawing.Size(111, 17)
        Me.lblAdvName.TabIndex = 13
        Me.lblAdvName.Text = "[ADVISER NAME]"
        Me.lblAdvName.Visible = False
        '
        'lblQaurtr
        '
        Me.lblQaurtr.AutoSize = True
        Me.lblQaurtr.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQaurtr.Location = New System.Drawing.Point(927, 40)
        Me.lblQaurtr.Name = "lblQaurtr"
        Me.lblQaurtr.Size = New System.Drawing.Size(26, 17)
        Me.lblQaurtr.TabIndex = 15
        Me.lblQaurtr.Text = "1ST"
        '
        'lblQuarter
        '
        Me.lblQuarter.AutoSize = True
        Me.lblQuarter.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarter.Location = New System.Drawing.Point(850, 40)
        Me.lblQuarter.Name = "lblQuarter"
        Me.lblQuarter.Size = New System.Drawing.Size(74, 16)
        Me.lblQuarter.TabIndex = 14
        Me.lblQuarter.Text = "QUARTER :"
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeLevel.Location = New System.Drawing.Point(172, 33)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(71, 23)
        Me.lblGradeLevel.TabIndex = 16
        Me.lblGradeLevel.Text = "[LEVEL]"
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.Image = Global.Senior_High_School_Enrolment_System.My.Resources.Resources.LOGO
        Me.picLogo.Location = New System.Drawing.Point(23, 14)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(135, 128)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'frm_ViewSection
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1043, 608)
        Me.Controls.Add(Me.lblGradeLevel)
        Me.Controls.Add(Me.lblQaurtr)
        Me.Controls.Add(Me.lblQuarter)
        Me.Controls.Add(Me.lblAdvName)
        Me.Controls.Add(Me.lblDate1)
        Me.Controls.Add(Me.lblSem)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblAdviser)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblSchoolYear)
        Me.Controls.Add(Me.grpStudents)
        Me.Controls.Add(Me.grpSched)
        Me.Controls.Add(Me.lblSectionCode)
        Me.Controls.Add(Me.lblStrand)
        Me.Controls.Add(Me.lblSecyionName)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ViewSection"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SCHEDULES"
        Me.grpSched.ResumeLayout(False)
        CType(Me.grdSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStudents.ResumeLayout(False)
        Me.grpStudents.PerformLayout()
        CType(Me.grdStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblSecyionName As System.Windows.Forms.Label
    Friend WithEvents lblStrand As System.Windows.Forms.Label
    Friend WithEvents lblSectionCode As System.Windows.Forms.Label
    Friend WithEvents grpSched As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddSubject As System.Windows.Forms.Button
    Friend WithEvents grdSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents grpStudents As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents grdStudents As System.Windows.Forms.DataGridView
    Friend WithEvents lblDropped As System.Windows.Forms.Label
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents lblSchoolYear As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblAdviser As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblSem As System.Windows.Forms.Label
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents lblAdvName As System.Windows.Forms.Label
    Friend WithEvents lblQaurtr As System.Windows.Forms.Label
    Friend WithEvents lblQuarter As System.Windows.Forms.Label
    Friend WithEvents lblGradeLevel As System.Windows.Forms.Label
    Friend WithEvents lblIrreg As System.Windows.Forms.Label
    Friend WithEvents lblGreen As System.Windows.Forms.Label
End Class
