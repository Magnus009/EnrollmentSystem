<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddSchedule
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
        Me.grpRegistration = New System.Windows.Forms.GroupBox()
        Me.txtTimeTo = New System.Windows.Forms.MaskedTextBox()
        Me.txtTimeFrom = New System.Windows.Forms.MaskedTextBox()
        Me.cboTo = New System.Windows.Forms.ComboBox()
        Me.cboFrom = New System.Windows.Forms.ComboBox()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.cboStrand = New System.Windows.Forms.ComboBox()
        Me.lblStrand = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblTimeTo = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtRoomNo = New System.Windows.Forms.TextBox()
        Me.cboTeacher = New System.Windows.Forms.ComboBox()
        Me.cboSubject = New System.Windows.Forms.ComboBox()
        Me.lblRmNo = New System.Windows.Forms.Label()
        Me.lblTimeFrom = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblTeacher = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.grpRegistration.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRegistration
        '
        Me.grpRegistration.Controls.Add(Me.txtTimeTo)
        Me.grpRegistration.Controls.Add(Me.txtTimeFrom)
        Me.grpRegistration.Controls.Add(Me.cboTo)
        Me.grpRegistration.Controls.Add(Me.cboFrom)
        Me.grpRegistration.Controls.Add(Me.cboSection)
        Me.grpRegistration.Controls.Add(Me.cboStrand)
        Me.grpRegistration.Controls.Add(Me.lblStrand)
        Me.grpRegistration.Controls.Add(Me.btnCancel)
        Me.grpRegistration.Controls.Add(Me.btnUpdate)
        Me.grpRegistration.Controls.Add(Me.lblTimeTo)
        Me.grpRegistration.Controls.Add(Me.btnAdd)
        Me.grpRegistration.Controls.Add(Me.txtRoomNo)
        Me.grpRegistration.Controls.Add(Me.cboTeacher)
        Me.grpRegistration.Controls.Add(Me.cboSubject)
        Me.grpRegistration.Controls.Add(Me.lblRmNo)
        Me.grpRegistration.Controls.Add(Me.lblTimeFrom)
        Me.grpRegistration.Controls.Add(Me.lblSection)
        Me.grpRegistration.Controls.Add(Me.lblTeacher)
        Me.grpRegistration.Controls.Add(Me.lblSubject)
        Me.grpRegistration.Location = New System.Drawing.Point(6, 0)
        Me.grpRegistration.Name = "grpRegistration"
        Me.grpRegistration.Size = New System.Drawing.Size(478, 254)
        Me.grpRegistration.TabIndex = 0
        Me.grpRegistration.TabStop = False
        '
        'txtTimeTo
        '
        Me.txtTimeTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimeTo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtTimeTo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeTo.Location = New System.Drawing.Point(349, 178)
        Me.txtTimeTo.Mask = "00:00"
        Me.txtTimeTo.Name = "txtTimeTo"
        Me.txtTimeTo.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtTimeTo.Size = New System.Drawing.Size(68, 23)
        Me.txtTimeTo.TabIndex = 47
        Me.txtTimeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTimeTo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'txtTimeFrom
        '
        Me.txtTimeFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimeFrom.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtTimeFrom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeFrom.Location = New System.Drawing.Point(158, 178)
        Me.txtTimeFrom.Mask = "00:00"
        Me.txtTimeFrom.Name = "txtTimeFrom"
        Me.txtTimeFrom.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtTimeFrom.Size = New System.Drawing.Size(68, 23)
        Me.txtTimeFrom.TabIndex = 46
        Me.txtTimeFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTimeFrom.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'cboTo
        '
        Me.cboTo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboTo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTo.FormattingEnabled = True
        Me.cboTo.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboTo.Location = New System.Drawing.Point(422, 177)
        Me.cboTo.Name = "cboTo"
        Me.cboTo.Size = New System.Drawing.Size(45, 25)
        Me.cboTo.TabIndex = 45
        Me.cboTo.Text = "AM"
        '
        'cboFrom
        '
        Me.cboFrom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboFrom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFrom.FormattingEnabled = True
        Me.cboFrom.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboFrom.Location = New System.Drawing.Point(232, 177)
        Me.cboFrom.Name = "cboFrom"
        Me.cboFrom.Size = New System.Drawing.Size(45, 25)
        Me.cboFrom.TabIndex = 44
        Me.cboFrom.Text = "AM"
        '
        'cboSection
        '
        Me.cboSection.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSection.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(158, 119)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(309, 25)
        Me.cboSection.TabIndex = 43
        '
        'cboStrand
        '
        Me.cboStrand.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboStrand.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStrand.FormattingEnabled = True
        Me.cboStrand.Location = New System.Drawing.Point(158, 26)
        Me.cboStrand.Name = "cboStrand"
        Me.cboStrand.Size = New System.Drawing.Size(309, 25)
        Me.cboStrand.TabIndex = 1
        '
        'lblStrand
        '
        Me.lblStrand.AutoSize = True
        Me.lblStrand.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStrand.Location = New System.Drawing.Point(88, 29)
        Me.lblStrand.Name = "lblStrand"
        Me.lblStrand.Size = New System.Drawing.Size(58, 16)
        Me.lblStrand.TabIndex = 42
        Me.lblStrand.Text = "Strand :"
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(289, 212)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 31)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(195, 212)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(88, 31)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblTimeTo
        '
        Me.lblTimeTo.AutoSize = True
        Me.lblTimeTo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTimeTo.Location = New System.Drawing.Point(283, 181)
        Me.lblTimeTo.Name = "lblTimeTo"
        Me.lblTimeTo.Size = New System.Drawing.Size(60, 16)
        Me.lblTimeTo.TabIndex = 38
        Me.lblTimeTo.Text = "Time To:"
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(101, 212)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 31)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtRoomNo
        '
        Me.txtRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoomNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNo.Location = New System.Drawing.Point(158, 149)
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.Size = New System.Drawing.Size(309, 23)
        Me.txtRoomNo.TabIndex = 5
        '
        'cboTeacher
        '
        Me.cboTeacher.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboTeacher.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTeacher.FormattingEnabled = True
        Me.cboTeacher.Location = New System.Drawing.Point(158, 88)
        Me.cboTeacher.Name = "cboTeacher"
        Me.cboTeacher.Size = New System.Drawing.Size(309, 25)
        Me.cboTeacher.TabIndex = 3
        '
        'cboSubject
        '
        Me.cboSubject.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSubject.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubject.FormattingEnabled = True
        Me.cboSubject.Location = New System.Drawing.Point(158, 57)
        Me.cboSubject.Name = "cboSubject"
        Me.cboSubject.Size = New System.Drawing.Size(309, 25)
        Me.cboSubject.TabIndex = 2
        '
        'lblRmNo
        '
        Me.lblRmNo.AutoSize = True
        Me.lblRmNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRmNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRmNo.Location = New System.Drawing.Point(68, 152)
        Me.lblRmNo.Name = "lblRmNo"
        Me.lblRmNo.Size = New System.Drawing.Size(78, 16)
        Me.lblRmNo.TabIndex = 29
        Me.lblRmNo.Text = "Room No. :"
        '
        'lblTimeFrom
        '
        Me.lblTimeFrom.AutoSize = True
        Me.lblTimeFrom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTimeFrom.Location = New System.Drawing.Point(65, 181)
        Me.lblTimeFrom.Name = "lblTimeFrom"
        Me.lblTimeFrom.Size = New System.Drawing.Size(81, 16)
        Me.lblTimeFrom.TabIndex = 28
        Me.lblTimeFrom.Text = "Time From :"
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSection.Location = New System.Drawing.Point(83, 122)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(63, 16)
        Me.lblSection.TabIndex = 27
        Me.lblSection.Text = "Section :"
        '
        'lblTeacher
        '
        Me.lblTeacher.AutoSize = True
        Me.lblTeacher.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTeacher.Location = New System.Drawing.Point(12, 91)
        Me.lblTeacher.Name = "lblTeacher"
        Me.lblTeacher.Size = New System.Drawing.Size(134, 16)
        Me.lblTeacher.TabIndex = 26
        Me.lblTeacher.Text = "Teacher/Instructor :"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSubject.Location = New System.Drawing.Point(82, 60)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(64, 16)
        Me.lblSubject.TabIndex = 24
        Me.lblSubject.Text = "Subject :"
        '
        'frm_AddSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 260)
        Me.Controls.Add(Me.grpRegistration)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_AddSchedule"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUBJECT SCHEDULING FORM "
        Me.grpRegistration.ResumeLayout(False)
        Me.grpRegistration.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpRegistration As System.Windows.Forms.GroupBox
    Friend WithEvents cboSubject As System.Windows.Forms.ComboBox
    Friend WithEvents lblRmNo As System.Windows.Forms.Label
    Friend WithEvents lblTimeFrom As System.Windows.Forms.Label
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents lblTeacher As System.Windows.Forms.Label
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtRoomNo As System.Windows.Forms.TextBox
    Friend WithEvents cboTeacher As System.Windows.Forms.ComboBox
    Friend WithEvents lblTimeTo As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cboStrand As System.Windows.Forms.ComboBox
    Friend WithEvents lblStrand As System.Windows.Forms.Label
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents cboTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboFrom As System.Windows.Forms.ComboBox
    Friend WithEvents txtTimeFrom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTimeTo As System.Windows.Forms.MaskedTextBox
End Class
