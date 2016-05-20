<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report2
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
        Dim lblCity As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New internship.DataSet2()
        Me.cbSearchCompany = New System.Windows.Forms.ComboBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.cbSearchCity = New System.Windows.Forms.ComboBox()
        Me.cbSearchPosition = New System.Windows.Forms.ComboBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.btnSearchReportsEmployer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        lblCity = New System.Windows.Forms.Label()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCity
        '
        lblCity.AutoSize = True
        lblCity.Location = New System.Drawing.Point(50, 95)
        lblCity.Name = "lblCity"
        lblCity.Size = New System.Drawing.Size(38, 20)
        lblCity.TabIndex = 3
        lblCity.Text = "City"
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbSearchCompany
        '
        Me.cbSearchCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchCompany.FormattingEnabled = True
        Me.cbSearchCompany.Location = New System.Drawing.Point(116, 40)
        Me.cbSearchCompany.Name = "cbSearchCompany"
        Me.cbSearchCompany.Size = New System.Drawing.Size(211, 28)
        Me.cbSearchCompany.TabIndex = 2
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(31, 43)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(79, 20)
        Me.lblCompany.TabIndex = 2
        Me.lblCompany.Text = "Company"
        '
        'cbSearchCity
        '
        Me.cbSearchCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchCity.FormattingEnabled = True
        Me.cbSearchCity.Location = New System.Drawing.Point(116, 92)
        Me.cbSearchCity.Name = "cbSearchCity"
        Me.cbSearchCity.Size = New System.Drawing.Size(211, 28)
        Me.cbSearchCity.TabIndex = 4
        '
        'cbSearchPosition
        '
        Me.cbSearchPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchPosition.FormattingEnabled = True
        Me.cbSearchPosition.Location = New System.Drawing.Point(116, 151)
        Me.cbSearchPosition.Name = "cbSearchPosition"
        Me.cbSearchPosition.Size = New System.Drawing.Size(211, 28)
        Me.cbSearchPosition.TabIndex = 6
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(41, 154)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(69, 20)
        Me.lblPosition.TabIndex = 5
        Me.lblPosition.Text = "Position"
        '
        'btnSearchReportsEmployer
        '
        Me.btnSearchReportsEmployer.Location = New System.Drawing.Point(127, 326)
        Me.btnSearchReportsEmployer.Name = "btnSearchReportsEmployer"
        Me.btnSearchReportsEmployer.Size = New System.Drawing.Size(157, 32)
        Me.btnSearchReportsEmployer.TabIndex = 7
        Me.btnSearchReportsEmployer.Text = "SHOW REPORT"
        Me.btnSearchReportsEmployer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchReportsEmployer)
        Me.GroupBox1.Controls.Add(Me.lblPosition)
        Me.GroupBox1.Controls.Add(Me.cbSearchPosition)
        Me.GroupBox1.Controls.Add(lblCity)
        Me.GroupBox1.Controls.Add(Me.cbSearchCity)
        Me.GroupBox1.Controls.Add(Me.lblCompany)
        Me.GroupBox1.Controls.Add(Me.cbSearchCompany)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 539)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employer Reports"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.SystemColors.Control
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.DataTable2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.EnableHyperlinks = True
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "internship.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1612, 912)
        Me.ReportViewer1.TabIndex = 2
        Me.ReportViewer1.Visible = False
        '
        'report2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1612, 912)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "report2"
        Me.Text = "reports"
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataTable2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2 As internship.DataSet2
    Friend WithEvents cbSearchCompany As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents cbSearchCity As System.Windows.Forms.ComboBox
    Friend WithEvents cbSearchPosition As System.Windows.Forms.ComboBox
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents btnSearchReportsEmployer As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
