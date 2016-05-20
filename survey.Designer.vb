<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class survey
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Internship_sysDataSet = New internship.internship_sysDataSet()
        Me.EmpolyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpolyerTableAdapter = New internship.internship_sysDataSetTableAdapters.EmpolyerTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.STUD_PAGE = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddPlacement = New System.Windows.Forms.Button()
        Me.cbEmployer = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDuties = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Experience = New System.Windows.Forms.GroupBox()
        Me.EmpHistDGV = New System.Windows.Forms.DataGridView()
        Me.DGVcompany = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVlocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVstartdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVenddate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVtitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duties = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Intern_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_Salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edu_Trainging = New System.Windows.Forms.GroupBox()
        Me.cbUniversity = New System.Windows.Forms.ComboBox()
        Me.btnSaveEd = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpEdDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDegree = New System.Windows.Forms.ComboBox()
        Me.DGV_Undergrad = New System.Windows.Forms.DataGridView()
        Me.DEGREE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAJOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIVERSITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COUNTRY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Personal_info = New System.Windows.Forms.GroupBox()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbxCountry = New System.Windows.Forms.ComboBox()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cbxStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.lblMName = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtYearReg = New System.Windows.Forms.TextBox()
        Me.lblYearReg = New System.Windows.Forms.Label()
        Me.cbxSemReg = New System.Windows.Forms.ComboBox()
        Me.lblSemReg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSID = New System.Windows.Forms.Label()
        Me.txtSID = New System.Windows.Forms.TextBox()
        Me.INT_PAGE = New System.Windows.Forms.TabPage()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cbInternshipType = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.JobsDGV = New System.Windows.Forms.DataGridView()
        Me.JID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOBGROUP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQUIREMENTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESPONSIBILITIES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtCNOTES = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtWEBSITE = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtPOSITION = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtCEMAIL = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtTELEPHONE = New System.Windows.Forms.TextBox()
        Me.txtCFNAME = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtCOMPANY = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCLNAME = New System.Windows.Forms.TextBox()
        Me.txtCADDRESS = New System.Windows.Forms.TextBox()
        Me.txtCCITY = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtCPOSTAL = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtCCOUNTRY = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblCopyPlacementMessage = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtJOBTYPE = New System.Windows.Forms.TextBox()
        Me.txtJOBGROUP = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtJOBSALARY = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtJOBRESPONSIBILITIES = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtJOBREQUIREMENTS = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtJOBDESCRIPTION = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtJOBPOSITION = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.btnHIRE = New System.Windows.Forms.Button()
        CType(Me.Internship_sysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpolyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.STUD_PAGE.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Experience.SuspendLayout()
        CType(Me.EmpHistDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Edu_Trainging.SuspendLayout()
        CType(Me.DGV_Undergrad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Personal_info.SuspendLayout()
        Me.INT_PAGE.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.JobsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Internship_sysDataSet
        '
        Me.Internship_sysDataSet.DataSetName = "internship_sysDataSet"
        Me.Internship_sysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpolyerBindingSource
        '
        Me.EmpolyerBindingSource.DataMember = "Empolyer"
        Me.EmpolyerBindingSource.DataSource = Me.Internship_sysDataSet
        '
        'EmpolyerTableAdapter
        '
        Me.EmpolyerTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.STUD_PAGE)
        Me.TabControl1.Controls.Add(Me.INT_PAGE)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1668, 1038)
        Me.TabControl1.TabIndex = 0
        '
        'STUD_PAGE
        '
        Me.STUD_PAGE.BackColor = System.Drawing.SystemColors.Control
        Me.STUD_PAGE.Controls.Add(Me.GroupBox2)
        Me.STUD_PAGE.Controls.Add(Me.Experience)
        Me.STUD_PAGE.Controls.Add(Me.Edu_Trainging)
        Me.STUD_PAGE.Controls.Add(Me.Personal_info)
        Me.STUD_PAGE.Controls.Add(Me.txtYearReg)
        Me.STUD_PAGE.Controls.Add(Me.lblYearReg)
        Me.STUD_PAGE.Controls.Add(Me.cbxSemReg)
        Me.STUD_PAGE.Controls.Add(Me.lblSemReg)
        Me.STUD_PAGE.Controls.Add(Me.Label1)
        Me.STUD_PAGE.Controls.Add(Me.lblSID)
        Me.STUD_PAGE.Controls.Add(Me.txtSID)
        Me.STUD_PAGE.Location = New System.Drawing.Point(4, 25)
        Me.STUD_PAGE.Name = "STUD_PAGE"
        Me.STUD_PAGE.Padding = New System.Windows.Forms.Padding(3)
        Me.STUD_PAGE.Size = New System.Drawing.Size(1660, 1009)
        Me.STUD_PAGE.TabIndex = 0
        Me.STUD_PAGE.Text = "STUDENT INFORMATION"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btnAddPlacement)
        Me.GroupBox2.Controls.Add(Me.cbEmployer)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtSalary)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtTitle)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtLocation)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.dtpStartDate)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtDuties)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 434)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1593, 89)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Work Experience"
        '
        'btnAddPlacement
        '
        Me.btnAddPlacement.BackColor = System.Drawing.Color.Lime
        Me.btnAddPlacement.Location = New System.Drawing.Point(1468, 42)
        Me.btnAddPlacement.Name = "btnAddPlacement"
        Me.btnAddPlacement.Size = New System.Drawing.Size(75, 23)
        Me.btnAddPlacement.TabIndex = 76
        Me.btnAddPlacement.Text = "HIRE"
        Me.btnAddPlacement.UseVisualStyleBackColor = False
        '
        'cbEmployer
        '
        Me.cbEmployer.Location = New System.Drawing.Point(89, 42)
        Me.cbEmployer.Name = "cbEmployer"
        Me.cbEmployer.Size = New System.Drawing.Size(287, 22)
        Me.cbEmployer.TabIndex = 19
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(7, 43)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(77, 21)
        Me.CheckBox2.TabIndex = 74
        Me.CheckBox2.Text = "HIRED"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1338, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 17)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "Salary"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(1342, 42)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(117, 22)
        Me.txtSalary.TabIndex = 70
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(670, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 17)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(673, 42)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(273, 22)
        Me.txtTitle.TabIndex = 68
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(497, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 17)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "Location"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(500, 42)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(164, 22)
        Me.txtLocation.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(384, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 17)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "StartDate"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(382, 42)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(110, 22)
        Me.dtpStartDate.TabIndex = 20
        Me.dtpStartDate.Value = New Date(2016, 3, 9, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(949, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 17)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Duties"
        '
        'txtDuties
        '
        Me.txtDuties.Location = New System.Drawing.Point(952, 42)
        Me.txtDuties.Name = "txtDuties"
        Me.txtDuties.Size = New System.Drawing.Size(380, 22)
        Me.txtDuties.TabIndex = 58
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(86, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(134, 17)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Current Employer"
        '
        'Experience
        '
        Me.Experience.Controls.Add(Me.EmpHistDGV)
        Me.Experience.Location = New System.Drawing.Point(16, 524)
        Me.Experience.Name = "Experience"
        Me.Experience.Size = New System.Drawing.Size(1597, 268)
        Me.Experience.TabIndex = 67
        Me.Experience.TabStop = False
        '
        'EmpHistDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmpHistDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.EmpHistDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpHistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpHistDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGVcompany, Me.DGVlocation, Me.DGVstartdate, Me.DGVenddate, Me.DGVtitle, Me.Duties, Me.Intern_Status, Me.Emp_Salary, Me.WID})
        Me.EmpHistDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmpHistDGV.Location = New System.Drawing.Point(3, 18)
        Me.EmpHistDGV.Name = "EmpHistDGV"
        Me.EmpHistDGV.RowTemplate.Height = 24
        Me.EmpHistDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmpHistDGV.Size = New System.Drawing.Size(1591, 247)
        Me.EmpHistDGV.TabIndex = 12
        '
        'DGVcompany
        '
        Me.DGVcompany.FillWeight = 50.0!
        Me.DGVcompany.HeaderText = "Company"
        Me.DGVcompany.Name = "DGVcompany"
        Me.DGVcompany.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVcompany.Width = 325
        '
        'DGVlocation
        '
        Me.DGVlocation.FillWeight = 50.0!
        Me.DGVlocation.HeaderText = "Location"
        Me.DGVlocation.MaxInputLength = 30
        Me.DGVlocation.Name = "DGVlocation"
        Me.DGVlocation.Width = 200
        '
        'DGVstartdate
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DGVstartdate.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVstartdate.FillWeight = 20.0!
        Me.DGVstartdate.HeaderText = "Start Date"
        Me.DGVstartdate.MaxInputLength = 10
        Me.DGVstartdate.Name = "DGVstartdate"
        Me.DGVstartdate.Width = 125
        '
        'DGVenddate
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DGVenddate.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVenddate.FillWeight = 20.0!
        Me.DGVenddate.HeaderText = "End Date"
        Me.DGVenddate.MaxInputLength = 10
        Me.DGVenddate.Name = "DGVenddate"
        Me.DGVenddate.Visible = False
        Me.DGVenddate.Width = 125
        '
        'DGVtitle
        '
        Me.DGVtitle.FillWeight = 50.0!
        Me.DGVtitle.HeaderText = "Title"
        Me.DGVtitle.MaxInputLength = 15
        Me.DGVtitle.Name = "DGVtitle"
        Me.DGVtitle.Width = 250
        '
        'Duties
        '
        Me.Duties.FillWeight = 60.0!
        Me.Duties.HeaderText = "Duties"
        Me.Duties.Name = "Duties"
        Me.Duties.Width = 380
        '
        'Intern_Status
        '
        Me.Intern_Status.FillWeight = 15.0!
        Me.Intern_Status.HeaderText = "Internship Status"
        Me.Intern_Status.Name = "Intern_Status"
        Me.Intern_Status.Width = 125
        '
        'Emp_Salary
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.Emp_Salary.DefaultCellStyle = DataGridViewCellStyle4
        Me.Emp_Salary.FillWeight = 15.0!
        Me.Emp_Salary.HeaderText = "Salary"
        Me.Emp_Salary.Name = "Emp_Salary"
        Me.Emp_Salary.Width = 125
        '
        'WID
        '
        Me.WID.HeaderText = "WID"
        Me.WID.Name = "WID"
        Me.WID.Visible = False
        '
        'Edu_Trainging
        '
        Me.Edu_Trainging.BackColor = System.Drawing.SystemColors.Control
        Me.Edu_Trainging.Controls.Add(Me.cbUniversity)
        Me.Edu_Trainging.Controls.Add(Me.btnSaveEd)
        Me.Edu_Trainging.Controls.Add(Me.Label12)
        Me.Edu_Trainging.Controls.Add(Me.dtpEdDate)
        Me.Edu_Trainging.Controls.Add(Me.Label7)
        Me.Edu_Trainging.Controls.Add(Me.txtCountry)
        Me.Edu_Trainging.Controls.Add(Me.Label6)
        Me.Edu_Trainging.Controls.Add(Me.Label5)
        Me.Edu_Trainging.Controls.Add(Me.txtGPA)
        Me.Edu_Trainging.Controls.Add(Me.Label4)
        Me.Edu_Trainging.Controls.Add(Me.txtMajor)
        Me.Edu_Trainging.Controls.Add(Me.Label3)
        Me.Edu_Trainging.Controls.Add(Me.cbDegree)
        Me.Edu_Trainging.Controls.Add(Me.DGV_Undergrad)
        Me.Edu_Trainging.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edu_Trainging.Location = New System.Drawing.Point(613, 80)
        Me.Edu_Trainging.Name = "Edu_Trainging"
        Me.Edu_Trainging.Size = New System.Drawing.Size(997, 333)
        Me.Edu_Trainging.TabIndex = 66
        Me.Edu_Trainging.TabStop = False
        Me.Edu_Trainging.Text = "EDUCATION AND TRAINING"
        '
        'cbUniversity
        '
        Me.cbUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUniversity.FormattingEnabled = True
        Me.cbUniversity.Items.AddRange(New Object() {"U OF WINDSOR", "U of TORONTO", "U of CHICAGO", "St. PETER COLLEGE", "U OF WATERLOO", "U OF INDIA", "OTHER", "U OF TAIWAN"})
        Me.cbUniversity.Location = New System.Drawing.Point(501, 54)
        Me.cbUniversity.Name = "cbUniversity"
        Me.cbUniversity.Size = New System.Drawing.Size(186, 24)
        Me.cbUniversity.TabIndex = 69
        '
        'btnSaveEd
        '
        Me.btnSaveEd.BackColor = System.Drawing.Color.Lime
        Me.btnSaveEd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEd.Location = New System.Drawing.Point(905, 54)
        Me.btnSaveEd.Name = "btnSaveEd"
        Me.btnSaveEd.Size = New System.Drawing.Size(21, 23)
        Me.btnSaveEd.TabIndex = 18
        Me.btnSaveEd.Text = "+"
        Me.btnSaveEd.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(800, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 17)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Date"
        '
        'dtpEdDate
        '
        Me.dtpEdDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpEdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEdDate.Location = New System.Drawing.Point(798, 55)
        Me.dtpEdDate.Name = "dtpEdDate"
        Me.dtpEdDate.Size = New System.Drawing.Size(101, 22)
        Me.dtpEdDate.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(693, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Country"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(696, 55)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(100, 22)
        Me.txtCountry.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(498, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Degrees University "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(438, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "GPA"
        '
        'txtGPA
        '
        Me.txtGPA.Location = New System.Drawing.Point(441, 55)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(54, 22)
        Me.txtGPA.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Major / Certification Body"
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(247, 55)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(188, 22)
        Me.txtMajor.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Degree / Certification"
        '
        'cbDegree
        '
        Me.cbDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDegree.FormattingEnabled = True
        Me.cbDegree.Items.AddRange(New Object() {"UNDERGRADUATE", "GRADUATE", "CERTIFICATION"})
        Me.cbDegree.Location = New System.Drawing.Point(45, 55)
        Me.cbDegree.Name = "cbDegree"
        Me.cbDegree.Size = New System.Drawing.Size(186, 24)
        Me.cbDegree.TabIndex = 12
        '
        'DGV_Undergrad
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Undergrad.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Undergrad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Undergrad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DEGREE, Me.MAJOR, Me.GPA, Me.UNIVERSITY, Me.COUNTRY, Me.UDATE})
        Me.DGV_Undergrad.Location = New System.Drawing.Point(45, 103)
        Me.DGV_Undergrad.MaximumSize = New System.Drawing.Size(910, 220)
        Me.DGV_Undergrad.MinimumSize = New System.Drawing.Size(910, 220)
        Me.DGV_Undergrad.Name = "DGV_Undergrad"
        Me.DGV_Undergrad.RowTemplate.Height = 24
        Me.DGV_Undergrad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Undergrad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Undergrad.Size = New System.Drawing.Size(910, 220)
        Me.DGV_Undergrad.TabIndex = 14
        '
        'DEGREE
        '
        Me.DEGREE.FillWeight = 30.0!
        Me.DEGREE.HeaderText = "DEGREE / CERTIFICATION"
        Me.DEGREE.MaxInputLength = 150
        Me.DEGREE.Name = "DEGREE"
        Me.DEGREE.Width = 200
        '
        'MAJOR
        '
        Me.MAJOR.FillWeight = 20.0!
        Me.MAJOR.HeaderText = "MAJOR / CERTIFICATION BODY"
        Me.MAJOR.Name = "MAJOR"
        Me.MAJOR.Width = 200
        '
        'GPA
        '
        Me.GPA.FillWeight = 20.0!
        Me.GPA.HeaderText = "GPA"
        Me.GPA.Name = "GPA"
        Me.GPA.Width = 50
        '
        'UNIVERSITY
        '
        Me.UNIVERSITY.FillWeight = 40.0!
        Me.UNIVERSITY.HeaderText = "DEGREES UNIVERSITY "
        Me.UNIVERSITY.Name = "UNIVERSITY"
        Me.UNIVERSITY.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UNIVERSITY.Width = 200
        '
        'COUNTRY
        '
        Me.COUNTRY.FillWeight = 20.0!
        Me.COUNTRY.HeaderText = "COUNTRY"
        Me.COUNTRY.Name = "COUNTRY"
        Me.COUNTRY.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'UDATE
        '
        Me.UDATE.FillWeight = 20.0!
        Me.UDATE.HeaderText = "DATE"
        Me.UDATE.Name = "UDATE"
        Me.UDATE.Width = 125
        '
        'Personal_info
        '
        Me.Personal_info.BackColor = System.Drawing.SystemColors.Control
        Me.Personal_info.Controls.Add(Me.btnDeleteStudent)
        Me.Personal_info.Controls.Add(Me.CheckBox1)
        Me.Personal_info.Controls.Add(Me.cbxCountry)
        Me.Personal_info.Controls.Add(Me.btnSAVE)
        Me.Personal_info.Controls.Add(Me.btnClearForm)
        Me.Personal_info.Controls.Add(Me.btnUPDATE)
        Me.Personal_info.Controls.Add(Me.txtPhone)
        Me.Personal_info.Controls.Add(Me.lblCountry)
        Me.Personal_info.Controls.Add(Me.cbxGender)
        Me.Personal_info.Controls.Add(Me.lblGender)
        Me.Personal_info.Controls.Add(Me.cbxStatus)
        Me.Personal_info.Controls.Add(Me.lblStatus)
        Me.Personal_info.Controls.Add(Me.lblPhone)
        Me.Personal_info.Controls.Add(Me.txtEmail)
        Me.Personal_info.Controls.Add(Me.lblEmail)
        Me.Personal_info.Controls.Add(Me.txtLName)
        Me.Personal_info.Controls.Add(Me.lblLName)
        Me.Personal_info.Controls.Add(Me.txtMName)
        Me.Personal_info.Controls.Add(Me.lblMName)
        Me.Personal_info.Controls.Add(Me.txtFName)
        Me.Personal_info.Controls.Add(Me.lblFName)
        Me.Personal_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Personal_info.Location = New System.Drawing.Point(20, 81)
        Me.Personal_info.Name = "Personal_info"
        Me.Personal_info.Size = New System.Drawing.Size(587, 332)
        Me.Personal_info.TabIndex = 65
        Me.Personal_info.TabStop = False
        Me.Personal_info.Text = "PERSONAL INFORMATION"
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.BackColor = System.Drawing.Color.Red
        Me.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteStudent.Location = New System.Drawing.Point(21, 289)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(84, 37)
        Me.btnDeleteStudent.TabIndex = 24
        Me.btnDeleteStudent.Text = "DELETE"
        Me.btnDeleteStudent.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(421, 189)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(143, 29)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "AVAILABLE"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cbxCountry
        '
        Me.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCountry.FormattingEnabled = True
        Me.cbxCountry.Location = New System.Drawing.Point(422, 112)
        Me.cbxCountry.Name = "cbxCountry"
        Me.cbxCountry.Size = New System.Drawing.Size(121, 24)
        Me.cbxCountry.TabIndex = 9
        '
        'btnSAVE
        '
        Me.btnSAVE.BackColor = System.Drawing.Color.Lime
        Me.btnSAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSAVE.Location = New System.Drawing.Point(499, 291)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(82, 33)
        Me.btnSAVE.TabIndex = 22
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(417, 290)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(75, 34)
        Me.btnClearForm.TabIndex = 23
        Me.btnClearForm.Text = "CLEAR"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnUPDATE
        '
        Me.btnUPDATE.BackColor = System.Drawing.Color.Orange
        Me.btnUPDATE.Location = New System.Drawing.Point(498, 290)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(82, 36)
        Me.btnUPDATE.TabIndex = 12
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = False
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(104, 110)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 22)
        Me.txtPhone.TabIndex = 8
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(359, 117)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(57, 17)
        Me.lblCountry.TabIndex = 18
        Me.lblCountry.Text = "Country"
        '
        'cbxGender
        '
        Me.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cbxGender.Location = New System.Drawing.Point(104, 196)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(106, 24)
        Me.cbxGender.TabIndex = 11
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(9, 196)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(60, 17)
        Me.lblGender.TabIndex = 15
        Me.lblGender.Text = "Gender:"
        '
        'cbxStatus
        '
        Me.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStatus.FormattingEnabled = True
        Me.cbxStatus.Items.AddRange(New Object() {"INTERNATIONAL STUDENT   ", "PERMANENT RESIDENT/CITIZEN   "})
        Me.cbxStatus.Location = New System.Drawing.Point(104, 144)
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(220, 24)
        Me.cbxStatus.TabIndex = 10
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(9, 147)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(52, 17)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "Status:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(6, 115)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(80, 17)
        Me.lblPhone.TabIndex = 11
        Me.lblPhone.Text = "Telephone:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(80, 78)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(263, 22)
        Me.txtEmail.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(6, 78)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 17)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email:"
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(462, 41)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(100, 22)
        Me.txtLName.TabIndex = 6
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(372, 44)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(80, 17)
        Me.lblLName.TabIndex = 7
        Me.lblLName.Text = "Last Name:"
        '
        'txtMName
        '
        Me.txtMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.Location = New System.Drawing.Point(293, 41)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(69, 22)
        Me.txtMName.TabIndex = 5
        '
        'lblMName
        '
        Me.lblMName.AutoSize = True
        Me.lblMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMName.Location = New System.Drawing.Point(189, 44)
        Me.lblMName.Name = "lblMName"
        Me.lblMName.Size = New System.Drawing.Size(94, 17)
        Me.lblMName.TabIndex = 5
        Me.lblMName.Text = "Middle Name:"
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(96, 41)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(83, 22)
        Me.txtFName.TabIndex = 4
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(6, 44)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(80, 17)
        Me.lblFName.TabIndex = 3
        Me.lblFName.Text = "First Name:"
        '
        'txtYearReg
        '
        Me.txtYearReg.Location = New System.Drawing.Point(482, 53)
        Me.txtYearReg.Name = "txtYearReg"
        Me.txtYearReg.Size = New System.Drawing.Size(100, 22)
        Me.txtYearReg.TabIndex = 3
        '
        'lblYearReg
        '
        Me.lblYearReg.AutoSize = True
        Me.lblYearReg.Location = New System.Drawing.Point(438, 54)
        Me.lblYearReg.Name = "lblYearReg"
        Me.lblYearReg.Size = New System.Drawing.Size(38, 17)
        Me.lblYearReg.TabIndex = 64
        Me.lblYearReg.Text = "Year"
        '
        'cbxSemReg
        '
        Me.cbxSemReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSemReg.FormattingEnabled = True
        Me.cbxSemReg.Items.AddRange(New Object() {"FALL", "WINTER"})
        Me.cbxSemReg.Location = New System.Drawing.Point(331, 51)
        Me.cbxSemReg.Name = "cbxSemReg"
        Me.cbxSemReg.Size = New System.Drawing.Size(96, 24)
        Me.cbxSemReg.TabIndex = 2
        '
        'lblSemReg
        '
        Me.lblSemReg.AutoSize = True
        Me.lblSemReg.Location = New System.Drawing.Point(180, 54)
        Me.lblSemReg.Name = "lblSemReg"
        Me.lblSemReg.Size = New System.Drawing.Size(145, 17)
        Me.lblSemReg.TabIndex = 59
        Me.lblSemReg.Text = "Semester Registered:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 17)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "STUDENT PRE-INTERNSHIP SURVEY"
        '
        'lblSID
        '
        Me.lblSID.AutoSize = True
        Me.lblSID.Location = New System.Drawing.Point(20, 54)
        Me.lblSID.Name = "lblSID"
        Me.lblSID.Size = New System.Drawing.Size(74, 17)
        Me.lblSID.TabIndex = 60
        Me.lblSID.Text = "Student ID"
        '
        'txtSID
        '
        Me.txtSID.Location = New System.Drawing.Point(100, 51)
        Me.txtSID.MaxLength = 9
        Me.txtSID.Name = "txtSID"
        Me.txtSID.Size = New System.Drawing.Size(74, 22)
        Me.txtSID.TabIndex = 1
        '
        'INT_PAGE
        '
        Me.INT_PAGE.BackColor = System.Drawing.SystemColors.Control
        Me.INT_PAGE.Controls.Add(Me.Label28)
        Me.INT_PAGE.Controls.Add(Me.cbInternshipType)
        Me.INT_PAGE.Controls.Add(Me.GroupBox3)
        Me.INT_PAGE.Location = New System.Drawing.Point(4, 25)
        Me.INT_PAGE.Name = "INT_PAGE"
        Me.INT_PAGE.Padding = New System.Windows.Forms.Padding(3)
        Me.INT_PAGE.Size = New System.Drawing.Size(1660, 1009)
        Me.INT_PAGE.TabIndex = 1
        Me.INT_PAGE.Text = "INTERNSHIP PLACEMENT"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 23)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(106, 17)
        Me.Label28.TabIndex = 72
        Me.Label28.Text = "Internship Type"
        '
        'cbInternshipType
        '
        Me.cbInternshipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInternshipType.FormattingEnabled = True
        Me.cbInternshipType.Location = New System.Drawing.Point(9, 43)
        Me.cbInternshipType.Name = "cbInternshipType"
        Me.cbInternshipType.Size = New System.Drawing.Size(289, 24)
        Me.cbInternshipType.TabIndex = 71
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.JobsDGV)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1456, 892)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Placement Finder"
        '
        'JobsDGV
        '
        Me.JobsDGV.AllowUserToAddRows = False
        Me.JobsDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.JobsDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.JobsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JobsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JID, Me.JOBGROUP, Me.POSITION, Me.REQUIREMENTS, Me.DESCRIPTION, Me.RESPONSIBILITIES, Me.SALARY})
        Me.JobsDGV.Location = New System.Drawing.Point(58, 26)
        Me.JobsDGV.MaximumSize = New System.Drawing.Size(1346, 300)
        Me.JobsDGV.MinimumSize = New System.Drawing.Size(1346, 300)
        Me.JobsDGV.Name = "JobsDGV"
        Me.JobsDGV.ReadOnly = True
        Me.JobsDGV.RowTemplate.Height = 24
        Me.JobsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.JobsDGV.Size = New System.Drawing.Size(1346, 300)
        Me.JobsDGV.TabIndex = 75
        '
        'JID
        '
        Me.JID.HeaderText = "JID"
        Me.JID.Name = "JID"
        Me.JID.ReadOnly = True
        Me.JID.Visible = False
        '
        'JOBGROUP
        '
        Me.JOBGROUP.FillWeight = 50.0!
        Me.JOBGROUP.HeaderText = "JOBGROUP"
        Me.JOBGROUP.MaxInputLength = 50
        Me.JOBGROUP.Name = "JOBGROUP"
        Me.JOBGROUP.ReadOnly = True
        Me.JOBGROUP.Width = 150
        '
        'POSITION
        '
        Me.POSITION.HeaderText = "POSITION"
        Me.POSITION.Name = "POSITION"
        Me.POSITION.ReadOnly = True
        Me.POSITION.Width = 150
        '
        'REQUIREMENTS
        '
        Me.REQUIREMENTS.HeaderText = "REQUIREMENTS"
        Me.REQUIREMENTS.Name = "REQUIREMENTS"
        Me.REQUIREMENTS.ReadOnly = True
        Me.REQUIREMENTS.Width = 300
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.HeaderText = "DESCRIPTION"
        Me.DESCRIPTION.Name = "DESCRIPTION"
        Me.DESCRIPTION.ReadOnly = True
        Me.DESCRIPTION.Width = 350
        '
        'RESPONSIBILITIES
        '
        Me.RESPONSIBILITIES.HeaderText = "RESPONSIBILITIES"
        Me.RESPONSIBILITIES.Name = "RESPONSIBILITIES"
        Me.RESPONSIBILITIES.ReadOnly = True
        Me.RESPONSIBILITIES.Width = 400
        '
        'SALARY
        '
        Me.SALARY.HeaderText = "SALARY"
        Me.SALARY.Name = "SALARY"
        Me.SALARY.ReadOnly = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(86, 583)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 17)
        Me.Label22.TabIndex = 74
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.lblCopyPlacementMessage)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.btnHIRE)
        Me.GroupBox4.Location = New System.Drawing.Point(59, 328)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1345, 431)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtCNOTES)
        Me.GroupBox6.Location = New System.Drawing.Point(868, 22)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(458, 336)
        Me.GroupBox6.TabIndex = 81
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Notes"
        '
        'txtCNOTES
        '
        Me.txtCNOTES.Location = New System.Drawing.Point(8, 31)
        Me.txtCNOTES.Multiline = True
        Me.txtCNOTES.Name = "txtCNOTES"
        Me.txtCNOTES.Size = New System.Drawing.Size(442, 290)
        Me.txtCNOTES.TabIndex = 44
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.txtWEBSITE)
        Me.GroupBox5.Controls.Add(Me.Label38)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.txtPOSITION)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.txtCEMAIL)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.txtTELEPHONE)
        Me.GroupBox5.Controls.Add(Me.txtCFNAME)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.txtCOMPANY)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtCLNAME)
        Me.GroupBox5.Controls.Add(Me.txtCADDRESS)
        Me.GroupBox5.Controls.Add(Me.txtCCITY)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.txtCPOSTAL)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Controls.Add(Me.txtCCOUNTRY)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 21)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(845, 175)
        Me.GroupBox5.TabIndex = 80
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Company Contact"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(301, 17)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(122, 17)
        Me.Label36.TabIndex = 48
        Me.Label36.Text = "Company Website"
        '
        'txtWEBSITE
        '
        Me.txtWEBSITE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWEBSITE.Location = New System.Drawing.Point(304, 37)
        Me.txtWEBSITE.Name = "txtWEBSITE"
        Me.txtWEBSITE.Size = New System.Drawing.Size(338, 22)
        Me.txtWEBSITE.TabIndex = 27
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(22, 68)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(76, 17)
        Me.Label38.TabIndex = 41
        Me.Label38.Text = "First Name"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(426, 68)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(58, 17)
        Me.Label37.TabIndex = 46
        Me.Label37.Text = "Position"
        '
        'txtPOSITION
        '
        Me.txtPOSITION.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOSITION.Location = New System.Drawing.Point(429, 88)
        Me.txtPOSITION.Name = "txtPOSITION"
        Me.txtPOSITION.Size = New System.Drawing.Size(153, 22)
        Me.txtPOSITION.TabIndex = 31
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(590, 68)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(46, 17)
        Me.Label33.TabIndex = 42
        Me.Label33.Text = "Email "
        '
        'txtCEMAIL
        '
        Me.txtCEMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCEMAIL.Location = New System.Drawing.Point(593, 88)
        Me.txtCEMAIL.Name = "txtCEMAIL"
        Me.txtCEMAIL.Size = New System.Drawing.Size(231, 22)
        Me.txtCEMAIL.TabIndex = 32
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(651, 17)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(49, 17)
        Me.Label35.TabIndex = 44
        Me.Label35.Text = "Phone"
        '
        'txtTELEPHONE
        '
        Me.txtTELEPHONE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTELEPHONE.Location = New System.Drawing.Point(654, 37)
        Me.txtTELEPHONE.Name = "txtTELEPHONE"
        Me.txtTELEPHONE.Size = New System.Drawing.Size(124, 22)
        Me.txtTELEPHONE.TabIndex = 28
        '
        'txtCFNAME
        '
        Me.txtCFNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCFNAME.Location = New System.Drawing.Point(25, 88)
        Me.txtCFNAME.Name = "txtCFNAME"
        Me.txtCFNAME.Size = New System.Drawing.Size(176, 22)
        Me.txtCFNAME.TabIndex = 29
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(20, 116)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 17)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "Address"
        '
        'txtCOMPANY
        '
        Me.txtCOMPANY.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOMPANY.Location = New System.Drawing.Point(23, 37)
        Me.txtCOMPANY.Name = "txtCOMPANY"
        Me.txtCOMPANY.Size = New System.Drawing.Size(270, 22)
        Me.txtCOMPANY.TabIndex = 26
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(204, 68)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(76, 17)
        Me.Label32.TabIndex = 39
        Me.Label32.Text = "Last Name"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(20, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(108, 17)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Company Name"
        '
        'txtCLNAME
        '
        Me.txtCLNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCLNAME.Location = New System.Drawing.Point(207, 88)
        Me.txtCLNAME.Name = "txtCLNAME"
        Me.txtCLNAME.Size = New System.Drawing.Size(213, 22)
        Me.txtCLNAME.TabIndex = 30
        '
        'txtCADDRESS
        '
        Me.txtCADDRESS.Location = New System.Drawing.Point(23, 136)
        Me.txtCADDRESS.Name = "txtCADDRESS"
        Me.txtCADDRESS.Size = New System.Drawing.Size(332, 22)
        Me.txtCADDRESS.TabIndex = 33
        '
        'txtCCITY
        '
        Me.txtCCITY.Location = New System.Drawing.Point(367, 136)
        Me.txtCCITY.Name = "txtCCITY"
        Me.txtCCITY.Size = New System.Drawing.Size(132, 22)
        Me.txtCCITY.TabIndex = 34
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(364, 116)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 17)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "City"
        '
        'txtCPOSTAL
        '
        Me.txtCPOSTAL.Location = New System.Drawing.Point(516, 136)
        Me.txtCPOSTAL.Name = "txtCPOSTAL"
        Me.txtCPOSTAL.Size = New System.Drawing.Size(100, 22)
        Me.txtCPOSTAL.TabIndex = 35
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(513, 116)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(84, 17)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "Postal Code"
        '
        'txtCCOUNTRY
        '
        Me.txtCCOUNTRY.Location = New System.Drawing.Point(633, 136)
        Me.txtCCOUNTRY.Name = "txtCCOUNTRY"
        Me.txtCCOUNTRY.Size = New System.Drawing.Size(124, 22)
        Me.txtCCOUNTRY.TabIndex = 36
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(630, 116)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(57, 17)
        Me.Label30.TabIndex = 35
        Me.Label30.Text = "Country"
        '
        'lblCopyPlacementMessage
        '
        Me.lblCopyPlacementMessage.AutoSize = True
        Me.lblCopyPlacementMessage.Location = New System.Drawing.Point(1126, 394)
        Me.lblCopyPlacementMessage.Name = "lblCopyPlacementMessage"
        Me.lblCopyPlacementMessage.Size = New System.Drawing.Size(200, 17)
        Me.lblCopyPlacementMessage.TabIndex = 79
        Me.lblCopyPlacementMessage.Text = " Placement Data Migrated."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label50)
        Me.GroupBox1.Controls.Add(Me.txtJOBTYPE)
        Me.GroupBox1.Controls.Add(Me.txtJOBGROUP)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtJOBSALARY)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.txtJOBRESPONSIBILITIES)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.txtJOBREQUIREMENTS)
        Me.GroupBox1.Controls.Add(Me.Label47)
        Me.GroupBox1.Controls.Add(Me.txtJOBDESCRIPTION)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Controls.Add(Me.txtJOBPOSITION)
        Me.GroupBox1.Controls.Add(Me.Label49)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(845, 225)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Placement"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(283, 73)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(44, 17)
        Me.Label50.TabIndex = 34
        Me.Label50.Text = "TYPE"
        '
        'txtJOBTYPE
        '
        Me.txtJOBTYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJOBTYPE.Location = New System.Drawing.Point(286, 93)
        Me.txtJOBTYPE.Name = "txtJOBTYPE"
        Me.txtJOBTYPE.Size = New System.Drawing.Size(94, 22)
        Me.txtJOBTYPE.TabIndex = 40
        '
        'txtJOBGROUP
        '
        Me.txtJOBGROUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJOBGROUP.Location = New System.Drawing.Point(46, 38)
        Me.txtJOBGROUP.Name = "txtJOBGROUP"
        Me.txtJOBGROUP.Size = New System.Drawing.Size(216, 22)
        Me.txtJOBGROUP.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(283, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "SALARY"
        '
        'txtJOBSALARY
        '
        Me.txtJOBSALARY.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJOBSALARY.Location = New System.Drawing.Point(286, 38)
        Me.txtJOBSALARY.Name = "txtJOBSALARY"
        Me.txtJOBSALARY.Size = New System.Drawing.Size(97, 22)
        Me.txtJOBSALARY.TabIndex = 38
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(390, 18)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(131, 17)
        Me.Label45.TabIndex = 29
        Me.Label45.Text = "RESPONSIBILITIES"
        '
        'txtJOBRESPONSIBILITIES
        '
        Me.txtJOBRESPONSIBILITIES.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJOBRESPONSIBILITIES.Location = New System.Drawing.Point(393, 38)
        Me.txtJOBRESPONSIBILITIES.Multiline = True
        Me.txtJOBRESPONSIBILITIES.Name = "txtJOBRESPONSIBILITIES"
        Me.txtJOBRESPONSIBILITIES.Size = New System.Drawing.Size(437, 74)
        Me.txtJOBRESPONSIBILITIES.TabIndex = 42
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(390, 129)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(118, 17)
        Me.Label46.TabIndex = 27
        Me.Label46.Text = "REQUIREMENTS"
        '
        'txtJOBREQUIREMENTS
        '
        Me.txtJOBREQUIREMENTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJOBREQUIREMENTS.Location = New System.Drawing.Point(393, 146)
        Me.txtJOBREQUIREMENTS.Multiline = True
        Me.txtJOBREQUIREMENTS.Name = "txtJOBREQUIREMENTS"
        Me.txtJOBREQUIREMENTS.Size = New System.Drawing.Size(437, 68)
        Me.txtJOBREQUIREMENTS.TabIndex = 43
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(41, 129)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(100, 17)
        Me.Label47.TabIndex = 25
        Me.Label47.Text = "DESCRIPTION"
        '
        'txtJOBDESCRIPTION
        '
        Me.txtJOBDESCRIPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJOBDESCRIPTION.Location = New System.Drawing.Point(46, 149)
        Me.txtJOBDESCRIPTION.Multiline = True
        Me.txtJOBDESCRIPTION.Name = "txtJOBDESCRIPTION"
        Me.txtJOBDESCRIPTION.Size = New System.Drawing.Size(334, 65)
        Me.txtJOBDESCRIPTION.TabIndex = 41
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(41, 73)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(73, 17)
        Me.Label48.TabIndex = 20
        Me.Label48.Text = "POSITION"
        '
        'txtJOBPOSITION
        '
        Me.txtJOBPOSITION.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJOBPOSITION.Location = New System.Drawing.Point(44, 93)
        Me.txtJOBPOSITION.Name = "txtJOBPOSITION"
        Me.txtJOBPOSITION.Size = New System.Drawing.Size(218, 22)
        Me.txtJOBPOSITION.TabIndex = 39
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(43, 18)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(90, 17)
        Me.Label49.TabIndex = 19
        Me.Label49.Text = "JOB GROUP"
        '
        'btnHIRE
        '
        Me.btnHIRE.BackColor = System.Drawing.Color.Lime
        Me.btnHIRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnHIRE.Location = New System.Drawing.Point(1142, 366)
        Me.btnHIRE.Name = "btnHIRE"
        Me.btnHIRE.Size = New System.Drawing.Size(184, 25)
        Me.btnHIRE.TabIndex = 77
        Me.btnHIRE.Text = "COPY PLACEMENT"
        Me.btnHIRE.UseVisualStyleBackColor = False
        '
        'survey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1622, 922)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "survey"
        Me.Text = "6"
        CType(Me.Internship_sysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpolyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.STUD_PAGE.ResumeLayout(False)
        Me.STUD_PAGE.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Experience.ResumeLayout(False)
        CType(Me.EmpHistDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Edu_Trainging.ResumeLayout(False)
        Me.Edu_Trainging.PerformLayout()
        CType(Me.DGV_Undergrad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Personal_info.ResumeLayout(False)
        Me.Personal_info.PerformLayout()
        Me.INT_PAGE.ResumeLayout(False)
        Me.INT_PAGE.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.JobsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Internship_sysDataSet As internship.internship_sysDataSet
    Friend WithEvents EmpolyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpolyerTableAdapter As internship.internship_sysDataSetTableAdapters.EmpolyerTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents STUD_PAGE As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDuties As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Experience As System.Windows.Forms.GroupBox
    Friend WithEvents EmpHistDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Edu_Trainging As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveEd As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpEdDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGPA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMajor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbDegree As System.Windows.Forms.ComboBox
    Friend WithEvents DGV_Undergrad As System.Windows.Forms.DataGridView
    Friend WithEvents Personal_info As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbxCountry As System.Windows.Forms.ComboBox
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents btnClearForm As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents cbxGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents cbxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents lblMName As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents txtYearReg As System.Windows.Forms.TextBox
    Friend WithEvents lblYearReg As System.Windows.Forms.Label
    Friend WithEvents cbxSemReg As System.Windows.Forms.ComboBox
    Friend WithEvents lblSemReg As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSID As System.Windows.Forms.Label
    Friend WithEvents txtSID As System.Windows.Forms.TextBox
    Friend WithEvents INT_PAGE As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cbInternshipType As System.Windows.Forms.ComboBox
    Friend WithEvents btnHIRE As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbEmployer As System.Windows.Forms.TextBox
    Friend WithEvents JobsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtJOBGROUP As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtJOBSALARY As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtJOBRESPONSIBILITIES As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtJOBREQUIREMENTS As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtJOBDESCRIPTION As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtJOBPOSITION As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtJOBTYPE As System.Windows.Forms.TextBox
    Friend WithEvents JID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JOBGROUP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POSITION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REQUIREMENTS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPTION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESPONSIBILITIES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALARY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteStudent As System.Windows.Forms.Button
    Friend WithEvents btnAddPlacement As System.Windows.Forms.Button
    Friend WithEvents lblCopyPlacementMessage As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCNOTES As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtWEBSITE As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtPOSITION As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtCEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtTELEPHONE As System.Windows.Forms.TextBox
    Friend WithEvents txtCFNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtCOMPANY As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCLNAME As System.Windows.Forms.TextBox
    Friend WithEvents txtCADDRESS As System.Windows.Forms.TextBox
    Friend WithEvents txtCCITY As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtCPOSTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCCOUNTRY As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents DGVcompany As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVlocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVstartdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVenddate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVtitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duties As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Intern_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Emp_Salary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEGREE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAJOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNIVERSITY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COUNTRY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UDATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbUniversity As System.Windows.Forms.ComboBox
End Class
