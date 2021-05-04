<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SH1Report
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rpvSF1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsStudentsInfo = New Senior_High_School_Enrolment_System.dsStudentsInfo()
        Me.dtStudentsInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsStudentsInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtStudentsInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvSF1
        '
        Me.rpvSF1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsStudents"
        ReportDataSource1.Value = Me.dtStudentsInfoBindingSource
        Me.rpvSF1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvSF1.LocalReport.ReportEmbeddedResource = "Senior_High_School_Enrolment_System.SchoolForm1.rdlc"
        Me.rpvSF1.Location = New System.Drawing.Point(1, 2)
        Me.rpvSF1.Name = "rpvSF1"
        Me.rpvSF1.Size = New System.Drawing.Size(794, 291)
        Me.rpvSF1.TabIndex = 0
        '
        'dsStudentsInfo
        '
        Me.dsStudentsInfo.DataSetName = "dsStudentsInfo"
        Me.dsStudentsInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtStudentsInfoBindingSource
        '
        Me.dtStudentsInfoBindingSource.DataMember = "dtStudentsInfo"
        Me.dtStudentsInfoBindingSource.DataSource = Me.dsStudentsInfo
        '
        'frm_SF1Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 295)
        Me.Controls.Add(Me.rpvSF1)
        Me.Name = "frm_SF1Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SF1-SHS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dsStudentsInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtStudentsInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvSF1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtStudentsInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsStudentsInfo As Senior_High_School_Enrolment_System.dsStudentsInfo
End Class
