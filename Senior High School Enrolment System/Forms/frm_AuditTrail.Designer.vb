<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AuditTrail
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
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cboAction = New System.Windows.Forms.ComboBox()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblUserNAme = New System.Windows.Forms.Label()
        Me.grdLogs = New System.Windows.Forms.DataGridView()
        Me.grp.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        CType(Me.grdLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp
        '
        Me.grp.BackColor = System.Drawing.Color.White
        Me.grp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grp.Controls.Add(Me.grpFilter)
        Me.grp.Controls.Add(Me.grdLogs)
        Me.grp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(12, 2)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(897, 524)
        Me.grp.TabIndex = 372
        Me.grp.TabStop = False
        '
        'grpFilter
        '
        Me.grpFilter.BackColor = System.Drawing.Color.White
        Me.grpFilter.Controls.Add(Me.btnSearch)
        Me.grpFilter.Controls.Add(Me.Label1)
        Me.grpFilter.Controls.Add(Me.lblFrom)
        Me.grpFilter.Controls.Add(Me.dtpTo)
        Me.grpFilter.Controls.Add(Me.dtpFrom)
        Me.grpFilter.Controls.Add(Me.lblDate)
        Me.grpFilter.Controls.Add(Me.cboAction)
        Me.grpFilter.Controls.Add(Me.lblAction)
        Me.grpFilter.Controls.Add(Me.txtSearch)
        Me.grpFilter.Controls.Add(Me.lblUserNAme)
        Me.grpFilter.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFilter.Location = New System.Drawing.Point(9, 12)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(882, 88)
        Me.grpFilter.TabIndex = 350
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "FILTER"
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(670, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(98, 54)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(466, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TO"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(466, 25)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(45, 16)
        Me.lblFrom.TabIndex = 7
        Me.lblFrom.Text = "FROM"
        '
        'dtpTo
        '
        Me.dtpTo.Checked = False
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(517, 51)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShowCheckBox = True
        Me.dtpTo.Size = New System.Drawing.Size(123, 23)
        Me.dtpTo.TabIndex = 6
        Me.dtpTo.Value = New Date(2020, 3, 29, 0, 0, 0, 0)
        '
        'dtpFrom
        '
        Me.dtpFrom.Checked = False
        Me.dtpFrom.CustomFormat = ""
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(517, 22)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShowCheckBox = True
        Me.dtpFrom.Size = New System.Drawing.Size(123, 23)
        Me.dtpFrom.TabIndex = 5
        Me.dtpFrom.Value = New Date(2020, 3, 29, 0, 0, 0, 0)
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(416, 25)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 16)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "DATE"
        '
        'cboAction
        '
        Me.cboAction.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAction.FormattingEnabled = True
        Me.cboAction.Items.AddRange(New Object() {"ADD", "UPDATE", "DELETE", "LOGIN", "LOG OUT"})
        Me.cboAction.Location = New System.Drawing.Point(149, 51)
        Me.cboAction.Name = "cboAction"
        Me.cboAction.Size = New System.Drawing.Size(121, 25)
        Me.cboAction.TabIndex = 3
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Location = New System.Drawing.Point(80, 54)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(59, 16)
        Me.lblAction.TabIndex = 2
        Me.lblAction.Text = "ACTION"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(149, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(232, 23)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Text = "Enter User Name.."
        '
        'lblUserNAme
        '
        Me.lblUserNAme.AutoSize = True
        Me.lblUserNAme.Location = New System.Drawing.Point(80, 25)
        Me.lblUserNAme.Name = "lblUserNAme"
        Me.lblUserNAme.Size = New System.Drawing.Size(63, 16)
        Me.lblUserNAme.TabIndex = 0
        Me.lblUserNAme.Text = "SEARCH "
        '
        'grdLogs
        '
        Me.grdLogs.AllowUserToAddRows = False
        Me.grdLogs.AllowUserToDeleteRows = False
        Me.grdLogs.AllowUserToResizeColumns = False
        Me.grdLogs.AllowUserToResizeRows = False
        Me.grdLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdLogs.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdLogs.Location = New System.Drawing.Point(9, 106)
        Me.grdLogs.MultiSelect = False
        Me.grdLogs.Name = "grdLogs"
        Me.grdLogs.ReadOnly = True
        Me.grdLogs.RowHeadersVisible = False
        Me.grdLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdLogs.Size = New System.Drawing.Size(876, 402)
        Me.grdLogs.TabIndex = 349
        '
        'frm_AuditTrail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(920, 538)
        Me.Controls.Add(Me.grp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_AuditTrail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AUDIT TRAIL"
        Me.grp.ResumeLayout(False)
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        CType(Me.grdLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents grdLogs As System.Windows.Forms.DataGridView
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblUserNAme As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents cboAction As System.Windows.Forms.ComboBox
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
