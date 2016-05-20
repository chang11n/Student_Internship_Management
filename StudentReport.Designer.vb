<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentReport
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
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportDataset = New internship.ReportDataset()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cbDegree = New System.Windows.Forms.ComboBox()
        Me.lblDegree = New System.Windows.Forms.Label()
        Me.cbRegYear = New System.Windows.Forms.ComboBox()
        Me.lblRegisterYear = New System.Windows.Forms.Label()
        Me.btnSearchReportStudents = New System.Windows.Forms.Button()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.cbPaid = New System.Windows.Forms.ComboBox()
        Me.lblEmpolyed = New System.Windows.Forms.Label()
        Me.cbEmployed = New System.Windows.Forms.ComboBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.cbSearchCountry = New System.Windows.Forms.ComboBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet3 = New internship.DataSet3()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.ReportDataset
        '
        'ReportDataset
        '
        Me.ReportDataset.DataSetName = "ReportDataset"
        Me.ReportDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbGender)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.cbDegree)
        Me.GroupBox1.Controls.Add(Me.lblDegree)
        Me.GroupBox1.Controls.Add(Me.cbRegYear)
        Me.GroupBox1.Controls.Add(Me.lblRegisterYear)
        Me.GroupBox1.Controls.Add(Me.btnSearchReportStudents)
        Me.GroupBox1.Controls.Add(Me.lblPaid)
        Me.GroupBox1.Controls.Add(Me.cbPaid)
        Me.GroupBox1.Controls.Add(Me.lblEmpolyed)
        Me.GroupBox1.Controls.Add(Me.cbEmployed)
        Me.GroupBox1.Controls.Add(Me.lblCountry)
        Me.GroupBox1.Controls.Add(Me.cbSearchCountry)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 539)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Reports"
        '
        'cbGender
        '
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(122, 340)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(138, 28)
        Me.cbGender.TabIndex = 14
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(43, 348)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(64, 20)
        Me.lblGender.TabIndex = 13
        Me.lblGender.Text = "Gender"
        '
        'cbDegree
        '
        Me.cbDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDegree.FormattingEnabled = True
        Me.cbDegree.Items.AddRange(New Object() {"GRADUATE", "UNDERGRADUATE"})
        Me.cbDegree.Location = New System.Drawing.Point(122, 278)
        Me.cbDegree.Name = "cbDegree"
        Me.cbDegree.Size = New System.Drawing.Size(138, 28)
        Me.cbDegree.TabIndex = 12
        '
        'lblDegree
        '
        Me.lblDegree.AutoSize = True
        Me.lblDegree.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegree.Location = New System.Drawing.Point(43, 278)
        Me.lblDegree.Name = "lblDegree"
        Me.lblDegree.Size = New System.Drawing.Size(64, 20)
        Me.lblDegree.TabIndex = 11
        Me.lblDegree.Text = "Degree"
        '
        'cbRegYear
        '
        Me.cbRegYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRegYear.FormattingEnabled = True
        Me.cbRegYear.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2018", "2020", "2021", "2022", "2023", "2024", "2025", "2026"})
        Me.cbRegYear.Location = New System.Drawing.Point(122, 218)
        Me.cbRegYear.Name = "cbRegYear"
        Me.cbRegYear.Size = New System.Drawing.Size(138, 28)
        Me.cbRegYear.TabIndex = 10
        '
        'lblRegisterYear
        '
        Me.lblRegisterYear.AutoSize = True
        Me.lblRegisterYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterYear.Location = New System.Drawing.Point(6, 221)
        Me.lblRegisterYear.Name = "lblRegisterYear"
        Me.lblRegisterYear.Size = New System.Drawing.Size(111, 20)
        Me.lblRegisterYear.TabIndex = 9
        Me.lblRegisterYear.Text = "Register Year"
        '
        'btnSearchReportStudents
        '
        Me.btnSearchReportStudents.Location = New System.Drawing.Point(104, 438)
        Me.btnSearchReportStudents.Name = "btnSearchReportStudents"
        Me.btnSearchReportStudents.Size = New System.Drawing.Size(156, 36)
        Me.btnSearchReportStudents.TabIndex = 7
        Me.btnSearchReportStudents.Text = "SHOW REPORT"
        Me.btnSearchReportStudents.UseVisualStyleBackColor = True
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Location = New System.Drawing.Point(65, 164)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(42, 20)
        Me.lblPaid.TabIndex = 5
        Me.lblPaid.Text = "Paid"
        '
        'cbPaid
        '
        Me.cbPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaid.FormattingEnabled = True
        Me.cbPaid.Items.AddRange(New Object() {"PAID", "UNPAID"})
        Me.cbPaid.Location = New System.Drawing.Point(122, 156)
        Me.cbPaid.Name = "cbPaid"
        Me.cbPaid.Size = New System.Drawing.Size(138, 28)
        Me.cbPaid.TabIndex = 6
        '
        'lblEmpolyed
        '
        Me.lblEmpolyed.AutoSize = True
        Me.lblEmpolyed.Location = New System.Drawing.Point(25, 100)
        Me.lblEmpolyed.Name = "lblEmpolyed"
        Me.lblEmpolyed.Size = New System.Drawing.Size(82, 20)
        Me.lblEmpolyed.TabIndex = 3
        Me.lblEmpolyed.Text = "Employed"
        '
        'cbEmployed
        '
        Me.cbEmployed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmployed.FormattingEnabled = True
        Me.cbEmployed.Items.AddRange(New Object() {"AVAILABLE", "HIRED"})
        Me.cbEmployed.Location = New System.Drawing.Point(122, 100)
        Me.cbEmployed.Name = "cbEmployed"
        Me.cbEmployed.Size = New System.Drawing.Size(138, 28)
        Me.cbEmployed.TabIndex = 4
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(31, 43)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(67, 20)
        Me.lblCountry.TabIndex = 2
        Me.lblCountry.Text = "Country"
        '
        'cbSearchCountry
        '
        Me.cbSearchCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchCountry.FormattingEnabled = True
        Me.cbSearchCountry.Location = New System.Drawing.Point(122, 43)
        Me.cbSearchCountry.Name = "cbSearchCountry"
        Me.cbSearchCountry.Size = New System.Drawing.Size(138, 28)
        Me.cbSearchCountry.TabIndex = 2
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.SystemColors.Control
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "StudentReport"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.EnableHyperlinks = True
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "internship.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1612, 912)
        Me.ReportViewer1.TabIndex = 2
        Me.ReportViewer1.Visible = False
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1612, 912)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "StudentReport"
        Me.Text = "reports"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchReportStudents As System.Windows.Forms.Button
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents cbPaid As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpolyed As System.Windows.Forms.Label
    Friend WithEvents cbEmployed As System.Windows.Forms.ComboBox
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents cbSearchCountry As System.Windows.Forms.ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDataset As internship.ReportDataset
    Friend WithEvents lblRegisterYear As System.Windows.Forms.Label
    Friend WithEvents cbRegYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblDegree As System.Windows.Forms.Label
    Friend WithEvents cbDegree As System.Windows.Forms.ComboBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents cbGender As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet3 As internship.DataSet3
End Class
