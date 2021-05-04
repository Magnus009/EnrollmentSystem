<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Me.forgot = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picCNHS = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bntClose = New System.Windows.Forms.Button()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCNHS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'forgot
        '
        Me.forgot.AutoSize = True
        Me.forgot.BackColor = System.Drawing.Color.Transparent
        Me.forgot.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgot.Location = New System.Drawing.Point(399, 266)
        Me.forgot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.forgot.Name = "forgot"
        Me.forgot.Size = New System.Drawing.Size(102, 16)
        Me.forgot.TabIndex = 4
        Me.forgot.Text = "Forgot Password?"
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.Black
        Me.txtUserName.Location = New System.Drawing.Point(371, 204)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.MaxLength = 20
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(191, 16)
        Me.txtUserName.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Black
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(331, 283)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(238, 31)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "LOG IN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'picUser
        '
        Me.picUser.Image = Global.Senior_High_School_Enrolment_System.My.Resources.Resources.User
        Me.picUser.Location = New System.Drawing.Point(332, 197)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(30, 30)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUser.TabIndex = 72
        Me.picUser.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Senior_High_School_Enrolment_System.My.Resources.Resources.LOGO
        Me.picLogo.Location = New System.Drawing.Point(375, 37)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 147)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLogo.TabIndex = 71
        Me.picLogo.TabStop = False
        '
        'picCNHS
        '
        Me.picCNHS.Dock = System.Windows.Forms.DockStyle.Left
        Me.picCNHS.Image = Global.Senior_High_School_Enrolment_System.My.Resources.Resources.CNHS
        Me.picCNHS.Location = New System.Drawing.Point(0, 0)
        Me.picCNHS.Name = "picCNHS"
        Me.picCNHS.Size = New System.Drawing.Size(300, 400)
        Me.picCNHS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCNHS.TabIndex = 70
        Me.picCNHS.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUser.Location = New System.Drawing.Point(330, 196)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(240, 32)
        Me.lblUser.TabIndex = 74
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Senior_High_School_Enrolment_System.My.Resources.Resources.password
        Me.PictureBox1.Location = New System.Drawing.Point(332, 233)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(371, 240)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(191, 16)
        Me.txtPassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(330, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 32)
        Me.Label1.TabIndex = 77
        '
        'bntClose
        '
        Me.bntClose.BackColor = System.Drawing.Color.Red
        Me.bntClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntClose.ForeColor = System.Drawing.Color.White
        Me.bntClose.Location = New System.Drawing.Point(331, 318)
        Me.bntClose.Margin = New System.Windows.Forms.Padding(4)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(238, 31)
        Me.bntClose.TabIndex = 78
        Me.bntClose.Text = "CLOSE"
        Me.bntClose.UseVisualStyleBackColor = False
        '
        'frm_Login
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.bntClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.picCNHS)
        Me.Controls.Add(Me.forgot)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblUser)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER LOGIN"
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCNHS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents forgot As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents picCNHS As System.Windows.Forms.PictureBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents picUser As System.Windows.Forms.PictureBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bntClose As System.Windows.Forms.Button

End Class
