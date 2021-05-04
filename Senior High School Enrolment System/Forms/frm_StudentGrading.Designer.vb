<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_StudentGrading
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdStudents = New System.Windows.Forms.DataGridView()
        Me.grpHeader = New System.Windows.Forms.GroupBox()
        Me.lblSem = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.lblTeacherName = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.grdStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdStudents
        '
        Me.grdStudents.AllowUserToAddRows = False
        Me.grdStudents.AllowUserToDeleteRows = False
        Me.grdStudents.AllowUserToResizeColumns = False
        Me.grdStudents.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdStudents.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdStudents.Location = New System.Drawing.Point(12, 136)
        Me.grdStudents.Name = "grdStudents"
        Me.grdStudents.RowHeadersVisible = False
        Me.grdStudents.Size = New System.Drawing.Size(725, 370)
        Me.grdStudents.TabIndex = 7
        '
        'grpHeader
        '
        Me.grpHeader.Controls.Add(Me.lblSem)
        Me.grpHeader.Controls.Add(Me.lblYear)
        Me.grpHeader.Controls.Add(Me.lblSemester)
        Me.grpHeader.Controls.Add(Me.lblSchoolYear)
        Me.grpHeader.Controls.Add(Me.lblTeacherName)
        Me.grpHeader.Controls.Add(Me.lblSubject)
        Me.grpHeader.Controls.Add(Me.lblSection)
        Me.grpHeader.Location = New System.Drawing.Point(12, 12)
        Me.grpHeader.Name = "grpHeader"
        Me.grpHeader.Size = New System.Drawing.Size(725, 118)
        Me.grpHeader.TabIndex = 8
        Me.grpHeader.TabStop = False
        '
        'lblSem
        '
        Me.lblSem.AutoSize = True
        Me.lblSem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSem.Location = New System.Drawing.Point(565, 62)
        Me.lblSem.Name = "lblSem"
        Me.lblSem.Size = New System.Drawing.Size(97, 18)
        Me.lblSem.TabIndex = 13
        Me.lblSem.Text = "1st Semester"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(565, 44)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(78, 18)
        Me.lblYear.TabIndex = 12
        Me.lblYear.Text = "2020-2021"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(439, 62)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(85, 18)
        Me.lblSemester.TabIndex = 11
        Me.lblSemester.Text = "SEMESTER :"
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.AutoSize = True
        Me.lblSchoolYear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYear.Location = New System.Drawing.Point(439, 44)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(120, 18)
        Me.lblSchoolYear.TabIndex = 10
        Me.lblSchoolYear.Text = "SCHOOL YEAR :"
        '
        'lblTeacherName
        '
        Me.lblTeacherName.AutoSize = True
        Me.lblTeacherName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherName.Location = New System.Drawing.Point(32, 78)
        Me.lblTeacherName.Name = "lblTeacherName"
        Me.lblTeacherName.Size = New System.Drawing.Size(136, 19)
        Me.lblTeacherName.TabIndex = 9
        Me.lblTeacherName.Text = "[TEACHER NAME]"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(32, 21)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(158, 23)
        Me.lblSubject.TabIndex = 8
        Me.lblSubject.Text = "[SUBJECT NAME]"
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(32, 44)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(133, 19)
        Me.lblSection.TabIndex = 7
        Me.lblSection.Text = "[SECTION NAME]"
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(512, 512)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 43)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(628, 512)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 43)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frm_StudentGrading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 560)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpHeader)
        Me.Controls.Add(Me.grdStudents)
        Me.Name = "frm_StudentGrading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INPUT GRADES"
        CType(Me.grdStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHeader.ResumeLayout(False)
        Me.grpHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdStudents As System.Windows.Forms.DataGridView
    Friend WithEvents grpHeader As System.Windows.Forms.GroupBox
    Friend WithEvents lblSem As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents lblSchoolYear As System.Windows.Forms.Label
    Friend WithEvents lblTeacherName As System.Windows.Forms.Label
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
