<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dashboard
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.chrtDashBoard = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnShowLegend = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.chrtDashBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Black
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(278, 0)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(31, 30)
        Me.btnHide.TabIndex = 0
        Me.btnHide.Text = "‹‹"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'lblDash
        '
        Me.lblDash.BackColor = System.Drawing.Color.White
        Me.lblDash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDash.Location = New System.Drawing.Point(0, 0)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(278, 341)
        Me.lblDash.TabIndex = 1
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.White
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(46, 228)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(200, 16)
        Me.lblHeader.TabIndex = 3
        Me.lblHeader.Text = "Total No. of Enroled Students :"
        '
        'chrtDashBoard
        '
        Me.chrtDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chrtDashBoard.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Me.chrtDashBoard.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX.LabelStyle.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea3.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea3.AxisY.IsLabelAutoFit = False
        ChartArea3.AxisY.LabelStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea3.CursorX.IsUserSelectionEnabled = True
        ChartArea3.IsSameFontSizeForAllAxes = True
        ChartArea3.Name = "chaStudents"
        Me.chrtDashBoard.ChartAreas.Add(ChartArea3)
        Legend3.Alignment = System.Drawing.StringAlignment.Far
        Legend3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Legend3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        Legend3.DockedToChartArea = "chaStudents"
        Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend3.Font = New System.Drawing.Font("Calibri", 8.0!)
        Legend3.InterlacedRowsColor = System.Drawing.Color.Silver
        Legend3.IsEquallySpacedItems = True
        Legend3.IsTextAutoFit = False
        Legend3.Name = "lgdStrands"
        Legend3.ShadowOffset = 2
        Legend3.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend3.Title = "STRANDS"
        Legend3.TitleBackColor = System.Drawing.Color.Silver
        Legend3.TitleFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine
        Legend3.TitleSeparatorColor = System.Drawing.Color.Gray
        Me.chrtDashBoard.Legends.Add(Legend3)
        Me.chrtDashBoard.Location = New System.Drawing.Point(4, 34)
        Me.chrtDashBoard.Name = "chrtDashBoard"
        Series7.ChartArea = "chaStudents"
        Series7.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series7.LabelBackColor = System.Drawing.Color.Transparent
        Series7.Legend = "lgdStrands"
        Series7.Name = "Regulars"
        Series7.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Red
        Series7.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot
        Series8.ChartArea = "chaStudents"
        Series8.Color = System.Drawing.Color.Orange
        Series8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series8.Legend = "lgdStrands"
        Series8.Name = "Irregulars"
        Series9.ChartArea = "chaStudents"
        Series9.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Series9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series9.Legend = "lgdStrands"
        Series9.Name = "Dropped"
        Me.chrtDashBoard.Series.Add(Series7)
        Me.chrtDashBoard.Series.Add(Series8)
        Me.chrtDashBoard.Series.Add(Series9)
        Me.chrtDashBoard.Size = New System.Drawing.Size(270, 274)
        Me.chrtDashBoard.TabIndex = 5
        '
        'btnShowLegend
        '
        Me.btnShowLegend.BackColor = System.Drawing.SystemColors.Control
        Me.btnShowLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowLegend.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowLegend.Location = New System.Drawing.Point(162, 314)
        Me.btnShowLegend.Name = "btnShowLegend"
        Me.btnShowLegend.Size = New System.Drawing.Size(99, 23)
        Me.btnShowLegend.TabIndex = 6
        Me.btnShowLegend.Text = "SHOW LEGENDS"
        Me.btnShowLegend.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(4, 5)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(48, 23)
        Me.btnPrev.TabIndex = 7
        Me.btnPrev.Text = "PREV"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.Control
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(226, 5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 23)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblRecord
        '
        Me.lblRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRecord.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecord.ForeColor = System.Drawing.Color.White
        Me.lblRecord.Location = New System.Drawing.Point(58, 5)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(167, 23)
        Me.lblRecord.TabIndex = 9
        Me.lblRecord.Text = "STRAND RECORD (1-10) of 10"
        Me.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 31)
        Me.Label1.TabIndex = 10
        '
        'frm_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(309, 341)
        Me.Controls.Add(Me.lblRecord)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnShowLegend)
        Me.Controls.Add(Me.chrtDashBoard)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblDash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 55)
        Me.Name = "frm_dashboard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frm_dashboard"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Aqua
        CType(Me.chrtDashBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents lblDash As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents chrtDashBoard As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnShowLegend As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblRecord As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
