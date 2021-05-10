<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ForgotPass
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
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.cboQuestion = New System.Windows.Forms.ComboBox()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp
        '
        Me.grp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grp.Controls.Add(Me.lblheader)
        Me.grp.Controls.Add(Me.btnCancel)
        Me.grp.Controls.Add(Me.lblAnswer)
        Me.grp.Controls.Add(Me.txtNewPass)
        Me.grp.Controls.Add(Me.lblQuestion)
        Me.grp.Controls.Add(Me.cboQuestion)
        Me.grp.Controls.Add(Me.lblConfirmPass)
        Me.grp.Controls.Add(Me.lblNewPass)
        Me.grp.Controls.Add(Me.txtUserName)
        Me.grp.Controls.Add(Me.btnChangePass)
        Me.grp.Controls.Add(Me.txtConfirmPass)
        Me.grp.Controls.Add(Me.lblUsername)
        Me.grp.Controls.Add(Me.txtAnswer)
        Me.grp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(12, 12)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(542, 296)
        Me.grp.TabIndex = 246
        Me.grp.TabStop = False
        Me.grp.Text = "FORGOT PASSWORD?"
        '
        'lblheader
        '
        Me.lblheader.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.ForeColor = System.Drawing.Color.Black
        Me.lblheader.Location = New System.Drawing.Point(42, 23)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(479, 37)
        Me.lblheader.TabIndex = 369
        Me.lblheader.Text = "Enter your User name and answer one of the security questions you have chosen whe" & _
    "n you created your account."
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(287, 244)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(133, 44)
        Me.btnCancel.TabIndex = 368
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblAnswer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAnswer.Location = New System.Drawing.Point(23, 139)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(63, 16)
        Me.lblAnswer.TabIndex = 365
        Me.lblAnswer.Text = "Answer :"
        '
        'txtNewPass
        '
        Me.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPass.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(179, 166)
        Me.txtNewPass.MaxLength = 10
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPass.Size = New System.Drawing.Size(342, 22)
        Me.txtNewPass.TabIndex = 364
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblQuestion.Location = New System.Drawing.Point(23, 109)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(129, 16)
        Me.lblQuestion.TabIndex = 363
        Me.lblQuestion.Text = "Security Question :"
        '
        'cboQuestion
        '
        Me.cboQuestion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboQuestion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuestion.FormattingEnabled = True
        Me.cboQuestion.Location = New System.Drawing.Point(179, 106)
        Me.cboQuestion.Name = "cboQuestion"
        Me.cboQuestion.Size = New System.Drawing.Size(342, 25)
        Me.cboQuestion.TabIndex = 362
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblConfirmPass.Location = New System.Drawing.Point(23, 197)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(131, 16)
        Me.lblConfirmPass.TabIndex = 361
        Me.lblConfirmPass.Text = "Confirm Password :"
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNewPass.Location = New System.Drawing.Point(23, 168)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(108, 16)
        Me.lblNewPass.TabIndex = 359
        Me.lblNewPass.Text = "New Password :"
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(179, 77)
        Me.txtUserName.MaxLength = 10
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(342, 23)
        Me.txtUserName.TabIndex = 358
        '
        'btnChangePass
        '
        Me.btnChangePass.BackColor = System.Drawing.SystemColors.Control
        Me.btnChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePass.Location = New System.Drawing.Point(148, 244)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(133, 44)
        Me.btnChangePass.TabIndex = 357
        Me.btnChangePass.Text = "CHANGE PASSWORD"
        Me.btnChangePass.UseVisualStyleBackColor = False
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(179, 195)
        Me.txtConfirmPass.MaxLength = 10
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmPass.Size = New System.Drawing.Size(342, 23)
        Me.txtConfirmPass.TabIndex = 245
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(23, 81)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(80, 16)
        Me.lblUsername.TabIndex = 244
        Me.lblUsername.Text = "Username :"
        '
        'txtAnswer
        '
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(179, 137)
        Me.txtAnswer.MaxLength = 10
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(342, 23)
        Me.txtAnswer.TabIndex = 243
        '
        'frm_ForgotPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 320)
        Me.Controls.Add(Me.grp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_ForgotPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VERIFICATION"
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents cboQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents lblConfirmPass As System.Windows.Forms.Label
    Friend WithEvents lblNewPass As System.Windows.Forms.Label
    Friend WithEvents btnChangePass As System.Windows.Forms.Button
    Friend WithEvents txtConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblheader As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
End Class
