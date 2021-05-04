<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CreateAccount
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
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.grpPersonalInfo = New System.Windows.Forms.GroupBox()
        Me.lblNA = New System.Windows.Forms.Label()
        Me.txtExtName = New System.Windows.Forms.TextBox()
        Me.lblExtName = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.lblMName = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.grpQuestion = New System.Windows.Forms.GroupBox()
        Me.cboQ2 = New System.Windows.Forms.ComboBox()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.txtA2 = New System.Windows.Forms.TextBox()
        Me.lblA2 = New System.Windows.Forms.Label()
        Me.cboQ1 = New System.Windows.Forms.ComboBox()
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.txtA1 = New System.Windows.Forms.TextBox()
        Me.lblA1 = New System.Windows.Forms.Label()
        Me.grpUserInfo = New System.Windows.Forms.GroupBox()
        Me.cboUserLevel = New System.Windows.Forms.ComboBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserLevel = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.grpPersonalInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpQuestion.SuspendLayout()
        Me.grpUserInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLName
        '
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(161, 33)
        Me.txtLName.MaxLength = 10
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(248, 23)
        Me.txtLName.TabIndex = 1
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.BackColor = System.Drawing.Color.Transparent
        Me.lblLName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(7, 33)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(88, 16)
        Me.lblLName.TabIndex = 359
        Me.lblLName.Text = "LAST NAME :"
        '
        'grpPersonalInfo
        '
        Me.grpPersonalInfo.Controls.Add(Me.lblNA)
        Me.grpPersonalInfo.Controls.Add(Me.txtExtName)
        Me.grpPersonalInfo.Controls.Add(Me.lblExtName)
        Me.grpPersonalInfo.Controls.Add(Me.txtMName)
        Me.grpPersonalInfo.Controls.Add(Me.lblMName)
        Me.grpPersonalInfo.Controls.Add(Me.txtFName)
        Me.grpPersonalInfo.Controls.Add(Me.lblFName)
        Me.grpPersonalInfo.Controls.Add(Me.txtLName)
        Me.grpPersonalInfo.Controls.Add(Me.lblLName)
        Me.grpPersonalInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPersonalInfo.Location = New System.Drawing.Point(6, 19)
        Me.grpPersonalInfo.Name = "grpPersonalInfo"
        Me.grpPersonalInfo.Size = New System.Drawing.Size(426, 184)
        Me.grpPersonalInfo.TabIndex = 361
        Me.grpPersonalInfo.TabStop = False
        Me.grpPersonalInfo.Text = "Personal Information"
        '
        'lblNA
        '
        Me.lblNA.AutoSize = True
        Me.lblNA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNA.ForeColor = System.Drawing.Color.Red
        Me.lblNA.Location = New System.Drawing.Point(179, 151)
        Me.lblNA.Name = "lblNA"
        Me.lblNA.Size = New System.Drawing.Size(212, 15)
        Me.lblNA.TabIndex = 366
        Me.lblNA.Text = "PLEASE INPUT ""NA"" IF NOT APPLICABLE "
        '
        'txtExtName
        '
        Me.txtExtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExtName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtName.Location = New System.Drawing.Point(161, 122)
        Me.txtExtName.MaxLength = 10
        Me.txtExtName.Name = "txtExtName"
        Me.txtExtName.Size = New System.Drawing.Size(248, 23)
        Me.txtExtName.TabIndex = 364
        '
        'lblExtName
        '
        Me.lblExtName.AutoSize = True
        Me.lblExtName.BackColor = System.Drawing.Color.Transparent
        Me.lblExtName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtName.Location = New System.Drawing.Point(7, 122)
        Me.lblExtName.Name = "lblExtName"
        Me.lblExtName.Size = New System.Drawing.Size(133, 16)
        Me.lblExtName.TabIndex = 365
        Me.lblExtName.Text = "EXTENTION NAME  :"
        '
        'txtMName
        '
        Me.txtMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.Location = New System.Drawing.Point(161, 93)
        Me.txtMName.MaxLength = 10
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(248, 23)
        Me.txtMName.TabIndex = 3
        '
        'lblMName
        '
        Me.lblMName.AutoSize = True
        Me.lblMName.BackColor = System.Drawing.Color.Transparent
        Me.lblMName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMName.Location = New System.Drawing.Point(7, 93)
        Me.lblMName.Name = "lblMName"
        Me.lblMName.Size = New System.Drawing.Size(106, 16)
        Me.lblMName.TabIndex = 363
        Me.lblMName.Text = "MIDDLE NAME :"
        '
        'txtFName
        '
        Me.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(161, 61)
        Me.txtFName.MaxLength = 10
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(248, 23)
        Me.txtFName.TabIndex = 2
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.BackColor = System.Drawing.Color.Transparent
        Me.lblFName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(7, 61)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(90, 16)
        Me.lblFName.TabIndex = 361
        Me.lblFName.Text = "FIRST NAME :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnCreate)
        Me.GroupBox2.Controls.Add(Me.grpQuestion)
        Me.GroupBox2.Controls.Add(Me.grpUserInfo)
        Me.GroupBox2.Controls.Add(Me.grpPersonalInfo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(945, 406)
        Me.GroupBox2.TabIndex = 362
        Me.GroupBox2.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(688, 216)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 43)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(596, 216)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(86, 43)
        Me.btnCreate.TabIndex = 12
        Me.btnCreate.Text = "CREATE"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'grpQuestion
        '
        Me.grpQuestion.Controls.Add(Me.cboQ2)
        Me.grpQuestion.Controls.Add(Me.lblQ2)
        Me.grpQuestion.Controls.Add(Me.txtA2)
        Me.grpQuestion.Controls.Add(Me.lblA2)
        Me.grpQuestion.Controls.Add(Me.cboQ1)
        Me.grpQuestion.Controls.Add(Me.lblQ1)
        Me.grpQuestion.Controls.Add(Me.txtA1)
        Me.grpQuestion.Controls.Add(Me.lblA1)
        Me.grpQuestion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpQuestion.Location = New System.Drawing.Point(438, 19)
        Me.grpQuestion.Name = "grpQuestion"
        Me.grpQuestion.Size = New System.Drawing.Size(501, 184)
        Me.grpQuestion.TabIndex = 363
        Me.grpQuestion.TabStop = False
        Me.grpQuestion.Text = "Secret Question"
        '
        'cboQ2
        '
        Me.cboQ2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboQ2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQ2.FormattingEnabled = True
        Me.cboQ2.Location = New System.Drawing.Point(162, 105)
        Me.cboQ2.Name = "cboQ2"
        Me.cboQ2.Size = New System.Drawing.Size(333, 25)
        Me.cboQ2.TabIndex = 10
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.BackColor = System.Drawing.Color.Transparent
        Me.lblQ2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ2.Location = New System.Drawing.Point(7, 105)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(148, 16)
        Me.lblQ2.TabIndex = 365
        Me.lblQ2.Text = "SECRET QUESTION #2 :"
        '
        'txtA2
        '
        Me.txtA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA2.Location = New System.Drawing.Point(162, 138)
        Me.txtA2.MaxLength = 10
        Me.txtA2.Name = "txtA2"
        Me.txtA2.Size = New System.Drawing.Size(333, 23)
        Me.txtA2.TabIndex = 11
        '
        'lblA2
        '
        Me.lblA2.AutoSize = True
        Me.lblA2.BackColor = System.Drawing.Color.Transparent
        Me.lblA2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA2.Location = New System.Drawing.Point(7, 136)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(89, 16)
        Me.lblA2.TabIndex = 363
        Me.lblA2.Text = "ANSWER #2 :"
        '
        'cboQ1
        '
        Me.cboQ1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboQ1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQ1.FormattingEnabled = True
        Me.cboQ1.Location = New System.Drawing.Point(162, 37)
        Me.cboQ1.Name = "cboQ1"
        Me.cboQ1.Size = New System.Drawing.Size(333, 25)
        Me.cboQ1.TabIndex = 8
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.BackColor = System.Drawing.Color.Transparent
        Me.lblQ1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(7, 37)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(148, 16)
        Me.lblQ1.TabIndex = 361
        Me.lblQ1.Text = "SECRET QUESTION #1 :"
        '
        'txtA1
        '
        Me.txtA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA1.Location = New System.Drawing.Point(162, 70)
        Me.txtA1.MaxLength = 10
        Me.txtA1.Name = "txtA1"
        Me.txtA1.Size = New System.Drawing.Size(333, 23)
        Me.txtA1.TabIndex = 9
        '
        'lblA1
        '
        Me.lblA1.AutoSize = True
        Me.lblA1.BackColor = System.Drawing.Color.Transparent
        Me.lblA1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA1.Location = New System.Drawing.Point(7, 68)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(89, 16)
        Me.lblA1.TabIndex = 359
        Me.lblA1.Text = "ANSWER #1 :"
        '
        'grpUserInfo
        '
        Me.grpUserInfo.Controls.Add(Me.cboUserLevel)
        Me.grpUserInfo.Controls.Add(Me.txtConfirmPass)
        Me.grpUserInfo.Controls.Add(Me.lblConfirmPassword)
        Me.grpUserInfo.Controls.Add(Me.txtPassword)
        Me.grpUserInfo.Controls.Add(Me.lblPassword)
        Me.grpUserInfo.Controls.Add(Me.lblUserLevel)
        Me.grpUserInfo.Controls.Add(Me.txtUserName)
        Me.grpUserInfo.Controls.Add(Me.lblUserName)
        Me.grpUserInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUserInfo.Location = New System.Drawing.Point(6, 210)
        Me.grpUserInfo.Name = "grpUserInfo"
        Me.grpUserInfo.Size = New System.Drawing.Size(426, 184)
        Me.grpUserInfo.TabIndex = 362
        Me.grpUserInfo.TabStop = False
        Me.grpUserInfo.Text = "User Information"
        '
        'cboUserLevel
        '
        Me.cboUserLevel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboUserLevel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUserLevel.FormattingEnabled = True
        Me.cboUserLevel.Location = New System.Drawing.Point(162, 31)
        Me.cboUserLevel.Name = "cboUserLevel"
        Me.cboUserLevel.Size = New System.Drawing.Size(248, 25)
        Me.cboUserLevel.TabIndex = 4
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(162, 130)
        Me.txtConfirmPass.MaxLength = 10
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.Size = New System.Drawing.Size(248, 23)
        Me.txtConfirmPass.TabIndex = 7
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(7, 133)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(152, 16)
        Me.lblConfirmPassword.TabIndex = 365
        Me.lblConfirmPassword.Text = "CONFIRM PASSWORD :"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(162, 98)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(248, 23)
        Me.txtPassword.TabIndex = 6
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(7, 98)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(87, 16)
        Me.lblPassword.TabIndex = 363
        Me.lblPassword.Text = "PASSWORD :"
        '
        'lblUserLevel
        '
        Me.lblUserLevel.AutoSize = True
        Me.lblUserLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblUserLevel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLevel.Location = New System.Drawing.Point(7, 32)
        Me.lblUserLevel.Name = "lblUserLevel"
        Me.lblUserLevel.Size = New System.Drawing.Size(85, 16)
        Me.lblUserLevel.TabIndex = 361
        Me.lblUserLevel.Text = "USER LEVEL :"
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(162, 64)
        Me.txtUserName.MaxLength = 10
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(248, 23)
        Me.txtUserName.TabIndex = 5
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(9, 66)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(85, 16)
        Me.lblUserName.TabIndex = 359
        Me.lblUserName.Text = "USERNAME :"
        '
        'frm_CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 430)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_CreateAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREATE ACCOUNT"
        Me.grpPersonalInfo.ResumeLayout(False)
        Me.grpPersonalInfo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.grpQuestion.ResumeLayout(False)
        Me.grpQuestion.PerformLayout()
        Me.grpUserInfo.ResumeLayout(False)
        Me.grpUserInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents grpPersonalInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents lblMName As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpUserInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUserLevel As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents grpQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents lblQ1 As System.Windows.Forms.Label
    Friend WithEvents txtA1 As System.Windows.Forms.TextBox
    Friend WithEvents lblA1 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents cboQ2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblQ2 As System.Windows.Forms.Label
    Friend WithEvents txtA2 As System.Windows.Forms.TextBox
    Friend WithEvents lblA2 As System.Windows.Forms.Label
    Friend WithEvents cboQ1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboUserLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblNA As System.Windows.Forms.Label
    Friend WithEvents txtExtName As System.Windows.Forms.TextBox
    Friend WithEvents lblExtName As System.Windows.Forms.Label
End Class
