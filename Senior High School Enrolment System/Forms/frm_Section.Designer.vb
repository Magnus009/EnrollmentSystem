<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Section
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
        Me.grpHeader = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboGrdLevel = New System.Windows.Forms.ComboBox()
        Me.lblGrdLevel = New System.Windows.Forms.Label()
        Me.cboStrand = New System.Windows.Forms.ComboBox()
        Me.lblStrand = New System.Windows.Forms.Label()
        Me.txtSecName = New System.Windows.Forms.TextBox()
        Me.lblSecName = New System.Windows.Forms.Label()
        Me.txtSecCode = New System.Windows.Forms.TextBox()
        Me.lblSecCode = New System.Windows.Forms.Label()
        Me.grpTable = New System.Windows.Forms.GroupBox()
        Me.grdResult = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.grpHeader.SuspendLayout()
        Me.grpTable.SuspendLayout()
        CType(Me.grdResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpHeader
        '
        Me.grpHeader.Controls.Add(Me.btnCancel)
        Me.grpHeader.Controls.Add(Me.btnUpdate)
        Me.grpHeader.Controls.Add(Me.btnAdd)
        Me.grpHeader.Controls.Add(Me.cboGrdLevel)
        Me.grpHeader.Controls.Add(Me.lblGrdLevel)
        Me.grpHeader.Controls.Add(Me.cboStrand)
        Me.grpHeader.Controls.Add(Me.lblStrand)
        Me.grpHeader.Controls.Add(Me.txtSecName)
        Me.grpHeader.Controls.Add(Me.lblSecName)
        Me.grpHeader.Controls.Add(Me.txtSecCode)
        Me.grpHeader.Controls.Add(Me.lblSecCode)
        Me.grpHeader.Location = New System.Drawing.Point(12, 12)
        Me.grpHeader.Name = "grpHeader"
        Me.grpHeader.Size = New System.Drawing.Size(626, 168)
        Me.grpHeader.TabIndex = 0
        Me.grpHeader.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(343, 122)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 33)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(262, 122)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 33)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "MODIFY"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(181, 122)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 33)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cboGrdLevel
        '
        Me.cboGrdLevel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboGrdLevel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrdLevel.FormattingEnabled = True
        Me.cboGrdLevel.Items.AddRange(New Object() {"11", "12"})
        Me.cboGrdLevel.Location = New System.Drawing.Point(384, 27)
        Me.cboGrdLevel.Name = "cboGrdLevel"
        Me.cboGrdLevel.Size = New System.Drawing.Size(121, 25)
        Me.cboGrdLevel.TabIndex = 7
        '
        'lblGrdLevel
        '
        Me.lblGrdLevel.AutoSize = True
        Me.lblGrdLevel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrdLevel.ForeColor = System.Drawing.Color.Black
        Me.lblGrdLevel.Location = New System.Drawing.Point(276, 30)
        Me.lblGrdLevel.Name = "lblGrdLevel"
        Me.lblGrdLevel.Size = New System.Drawing.Size(91, 16)
        Me.lblGrdLevel.TabIndex = 6
        Me.lblGrdLevel.Text = "Grade Level:"
        '
        'cboStrand
        '
        Me.cboStrand.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboStrand.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStrand.FormattingEnabled = True
        Me.cboStrand.Location = New System.Drawing.Point(148, 91)
        Me.cboStrand.Name = "cboStrand"
        Me.cboStrand.Size = New System.Drawing.Size(436, 25)
        Me.cboStrand.TabIndex = 5
        '
        'lblStrand
        '
        Me.lblStrand.AutoSize = True
        Me.lblStrand.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrand.ForeColor = System.Drawing.Color.Black
        Me.lblStrand.Location = New System.Drawing.Point(27, 94)
        Me.lblStrand.Name = "lblStrand"
        Me.lblStrand.Size = New System.Drawing.Size(58, 16)
        Me.lblStrand.TabIndex = 4
        Me.lblStrand.Text = "Strand :"
        '
        'txtSecName
        '
        Me.txtSecName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSecName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecName.Location = New System.Drawing.Point(148, 59)
        Me.txtSecName.Name = "txtSecName"
        Me.txtSecName.Size = New System.Drawing.Size(436, 23)
        Me.txtSecName.TabIndex = 3
        '
        'lblSecName
        '
        Me.lblSecName.AutoSize = True
        Me.lblSecName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecName.ForeColor = System.Drawing.Color.Black
        Me.lblSecName.Location = New System.Drawing.Point(27, 62)
        Me.lblSecName.Name = "lblSecName"
        Me.lblSecName.Size = New System.Drawing.Size(106, 16)
        Me.lblSecName.TabIndex = 2
        Me.lblSecName.Text = "Section Name :"
        '
        'txtSecCode
        '
        Me.txtSecCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSecCode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecCode.Location = New System.Drawing.Point(148, 27)
        Me.txtSecCode.Name = "txtSecCode"
        Me.txtSecCode.Size = New System.Drawing.Size(110, 23)
        Me.txtSecCode.TabIndex = 1
        '
        'lblSecCode
        '
        Me.lblSecCode.AutoSize = True
        Me.lblSecCode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecCode.ForeColor = System.Drawing.Color.Black
        Me.lblSecCode.Location = New System.Drawing.Point(27, 30)
        Me.lblSecCode.Name = "lblSecCode"
        Me.lblSecCode.Size = New System.Drawing.Size(102, 16)
        Me.lblSecCode.TabIndex = 0
        Me.lblSecCode.Text = "Section Code :"
        '
        'grpTable
        '
        Me.grpTable.Controls.Add(Me.grdResult)
        Me.grpTable.Controls.Add(Me.txtSearch)
        Me.grpTable.Controls.Add(Me.lblSearch)
        Me.grpTable.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTable.ForeColor = System.Drawing.Color.Black
        Me.grpTable.Location = New System.Drawing.Point(12, 181)
        Me.grpTable.Name = "grpTable"
        Me.grpTable.Size = New System.Drawing.Size(626, 384)
        Me.grpTable.TabIndex = 1
        Me.grpTable.TabStop = False
        '
        'grdResult
        '
        Me.grdResult.AllowUserToAddRows = False
        Me.grdResult.AllowUserToDeleteRows = False
        Me.grdResult.AllowUserToOrderColumns = True
        Me.grdResult.AllowUserToResizeColumns = False
        Me.grdResult.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdResult.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdResult.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdResult.Location = New System.Drawing.Point(23, 51)
        Me.grdResult.Name = "grdResult"
        Me.grdResult.RowHeadersVisible = False
        Me.grdResult.Size = New System.Drawing.Size(597, 327)
        Me.grdResult.TabIndex = 6
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(91, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(529, 23)
        Me.txtSearch.TabIndex = 5
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(20, 25)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(65, 16)
        Me.lblSearch.TabIndex = 4
        Me.lblSearch.Text = "Search  :"
        '
        'frm_Section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 577)
        Me.Controls.Add(Me.grpTable)
        Me.Controls.Add(Me.grpHeader)
        Me.Name = "frm_Section"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SECTION REGISTRATION FORM"
        Me.grpHeader.ResumeLayout(False)
        Me.grpHeader.PerformLayout()
        Me.grpTable.ResumeLayout(False)
        Me.grpTable.PerformLayout()
        CType(Me.grdResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpHeader As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cboGrdLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrdLevel As System.Windows.Forms.Label
    Friend WithEvents cboStrand As System.Windows.Forms.ComboBox
    Friend WithEvents lblStrand As System.Windows.Forms.Label
    Friend WithEvents txtSecName As System.Windows.Forms.TextBox
    Friend WithEvents lblSecName As System.Windows.Forms.Label
    Friend WithEvents txtSecCode As System.Windows.Forms.TextBox
    Friend WithEvents lblSecCode As System.Windows.Forms.Label
    Friend WithEvents grpTable As System.Windows.Forms.GroupBox
    Friend WithEvents grdResult As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
End Class
