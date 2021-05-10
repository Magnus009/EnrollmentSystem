<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddSubjects
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
        Me.grpSub = New System.Windows.Forms.GroupBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtSubDescription = New System.Windows.Forms.TextBox()
        Me.txtSubCode = New System.Windows.Forms.TextBox()
        Me.grpPrerequisite = New System.Windows.Forms.GroupBox()
        Me.chklstPrerequisite = New System.Windows.Forms.CheckedListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.lblSubType = New System.Windows.Forms.Label()
        Me.grpSub.SuspendLayout()
        Me.grpPrerequisite.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSub
        '
        Me.grpSub.Controls.Add(Me.lblSubType)
        Me.grpSub.Controls.Add(Me.cboType)
        Me.grpSub.Controls.Add(Me.lblUnits)
        Me.grpSub.Controls.Add(Me.txtUnit)
        Me.grpSub.Controls.Add(Me.lblDescription)
        Me.grpSub.Controls.Add(Me.lblCode)
        Me.grpSub.Controls.Add(Me.txtSubDescription)
        Me.grpSub.Controls.Add(Me.txtSubCode)
        Me.grpSub.Location = New System.Drawing.Point(12, 12)
        Me.grpSub.Name = "grpSub"
        Me.grpSub.Size = New System.Drawing.Size(665, 120)
        Me.grpSub.TabIndex = 0
        Me.grpSub.TabStop = False
        '
        'cboType
        '
        Me.cboType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboType.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(147, 69)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(276, 25)
        Me.cboType.TabIndex = 6
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(70, 95)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(38, 16)
        Me.lblUnits.TabIndex = 5
        Me.lblUnits.Text = "Units"
        '
        'txtUnit
        '
        Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(41, 69)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(100, 23)
        Me.txtUnit.TabIndex = 4
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(317, 45)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(133, 16)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Subject Description"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(70, 45)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(43, 16)
        Me.lblCode.TabIndex = 2
        Me.lblCode.Text = "Code"
        '
        'txtSubDescription
        '
        Me.txtSubDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubDescription.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubDescription.Location = New System.Drawing.Point(147, 19)
        Me.txtSubDescription.Name = "txtSubDescription"
        Me.txtSubDescription.Size = New System.Drawing.Size(474, 23)
        Me.txtSubDescription.TabIndex = 1
        '
        'txtSubCode
        '
        Me.txtSubCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubCode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCode.Location = New System.Drawing.Point(41, 19)
        Me.txtSubCode.Name = "txtSubCode"
        Me.txtSubCode.Size = New System.Drawing.Size(100, 23)
        Me.txtSubCode.TabIndex = 0
        '
        'grpPrerequisite
        '
        Me.grpPrerequisite.Controls.Add(Me.chklstPrerequisite)
        Me.grpPrerequisite.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrerequisite.Location = New System.Drawing.Point(12, 137)
        Me.grpPrerequisite.Name = "grpPrerequisite"
        Me.grpPrerequisite.Size = New System.Drawing.Size(665, 246)
        Me.grpPrerequisite.TabIndex = 1
        Me.grpPrerequisite.TabStop = False
        Me.grpPrerequisite.Text = "PRE-REQUISITE"
        '
        'chklstPrerequisite
        '
        Me.chklstPrerequisite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chklstPrerequisite.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklstPrerequisite.FormattingEnabled = True
        Me.chklstPrerequisite.Location = New System.Drawing.Point(21, 24)
        Me.chklstPrerequisite.Name = "chklstPrerequisite"
        Me.chklstPrerequisite.Size = New System.Drawing.Size(627, 200)
        Me.chklstPrerequisite.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(454, 387)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 32)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "REGISTER"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(559, 387)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 32)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModify.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(454, 387)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(101, 32)
        Me.btnModify.TabIndex = 4
        Me.btnModify.Text = "MODIFY"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'lblSubType
        '
        Me.lblSubType.AutoSize = True
        Me.lblSubType.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubType.Location = New System.Drawing.Point(235, 97)
        Me.lblSubType.Name = "lblSubType"
        Me.lblSubType.Size = New System.Drawing.Size(91, 16)
        Me.lblSubType.TabIndex = 7
        Me.lblSubType.Text = "Subject Type"
        '
        'frm_AddSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 427)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpPrerequisite)
        Me.Controls.Add(Me.grpSub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_AddSubjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUBJECT REGISTRATION"
        Me.grpSub.ResumeLayout(False)
        Me.grpSub.PerformLayout()
        Me.grpPrerequisite.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpSub As System.Windows.Forms.GroupBox
    Friend WithEvents lblUnits As System.Windows.Forms.Label
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtSubDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSubCode As System.Windows.Forms.TextBox
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents grpPrerequisite As System.Windows.Forms.GroupBox
    Friend WithEvents chklstPrerequisite As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents lblSubType As System.Windows.Forms.Label
End Class
