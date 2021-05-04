<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_IrregSchedule
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
        Me.btnAssignSub = New System.Windows.Forms.Button()
        Me.grdSubjects = New System.Windows.Forms.DataGridView()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStudentCode = New System.Windows.Forms.Label()
        Me.lblSectionName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.grdSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAssignSub
        '
        Me.btnAssignSub.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAssignSub.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAssignSub.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignSub.Location = New System.Drawing.Point(151, 362)
        Me.btnAssignSub.Name = "btnAssignSub"
        Me.btnAssignSub.Size = New System.Drawing.Size(116, 29)
        Me.btnAssignSub.TabIndex = 1
        Me.btnAssignSub.Text = "ASSIGN SUBJECT"
        Me.btnAssignSub.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdSubjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdSubjects.ColumnHeadersHeight = 25
        Me.grdSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdSubjects.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdSubjects.Location = New System.Drawing.Point(285, 12)
        Me.grdSubjects.MultiSelect = False
        Me.grdSubjects.Name = "grdSubjects"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSubjects.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdSubjects.RowHeadersVisible = False
        Me.grdSubjects.RowHeadersWidth = 90
        Me.grdSubjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSubjects.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdSubjects.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.grdSubjects.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSubjects.Size = New System.Drawing.Size(574, 379)
        Me.grdSubjects.TabIndex = 0
        '
        'lblStudentName
        '
        Me.lblStudentName.BackColor = System.Drawing.Color.White
        Me.lblStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudentName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(17, 207)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(250, 23)
        Me.lblStudentName.TabIndex = 1
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picStudent
        '
        Me.picStudent.ImageLocation = "C:\Users\jerem\Desktop\enrolment_system\Senior High School Enrolment System\Resou" & _
    "rces\male.png"
        Me.picStudent.Location = New System.Drawing.Point(48, 12)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(188, 173)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudent.TabIndex = 4
        Me.picStudent.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "STUDENT NAME"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "LRN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentCode
        '
        Me.lblStudentCode.BackColor = System.Drawing.Color.White
        Me.lblStudentCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudentCode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentCode.Location = New System.Drawing.Point(17, 250)
        Me.lblStudentCode.Name = "lblStudentCode"
        Me.lblStudentCode.Size = New System.Drawing.Size(250, 23)
        Me.lblStudentCode.TabIndex = 9
        Me.lblStudentCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSectionName
        '
        Me.lblSectionName.BackColor = System.Drawing.Color.White
        Me.lblSectionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSectionName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionName.Location = New System.Drawing.Point(17, 293)
        Me.lblSectionName.Name = "lblSectionName"
        Me.lblSectionName.Size = New System.Drawing.Size(250, 23)
        Me.lblSectionName.TabIndex = 12
        Me.lblSectionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "SECTION NAME"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_IrregSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 412)
        Me.Controls.Add(Me.grdSubjects)
        Me.Controls.Add(Me.lblSectionName)
        Me.Controls.Add(Me.btnAssignSub)
        Me.Controls.Add(Me.lblStudentCode)
        Me.Controls.Add(Me.picStudent)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_IrregSchedule"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IRREGULAR STUDENT"
        CType(Me.grdSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents btnAssignSub As System.Windows.Forms.Button
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents picStudent As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblStudentCode As System.Windows.Forms.Label
    Friend WithEvents lblSectionName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
