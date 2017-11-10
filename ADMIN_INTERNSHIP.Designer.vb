<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN_INTERNSHIP
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNOTES = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtPHONE = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtWEBSITE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCONTACTLNAME = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPOSITION = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCONTACTFNAME = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCOUNTRY = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCITY = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPOSTAL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtADDRESS = New System.Windows.Forms.TextBox()
        Me.cbTYPE = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCOMPANYNAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeleteInternship = New System.Windows.Forms.Button()
        Me.btnAddInternship = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.INTERNSHIPDGV = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COUNTRY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WEBSITE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.INTERNSHIPDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btnDeleteInternship)
        Me.GroupBox2.Controls.Add(Me.btnAddInternship)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.INTERNSHIPDGV)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1660, 993)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ADD/DELETE INTERNSHIP COMPANY"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtNOTES)
        Me.GroupBox1.Location = New System.Drawing.Point(1130, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 222)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NOTES"
        '
        'txtNOTES
        '
        Me.txtNOTES.Location = New System.Drawing.Point(6, 21)
        Me.txtNOTES.Multiline = True
        Me.txtNOTES.Name = "txtNOTES"
        Me.txtNOTES.Size = New System.Drawing.Size(402, 195)
        Me.txtNOTES.TabIndex = 53
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.txtPHONE)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtWEBSITE)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtCONTACTLNAME)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtPOSITION)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtCONTACTFNAME)
        Me.GroupBox4.Location = New System.Drawing.Point(583, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(527, 222)
        Me.GroupBox4.TabIndex = 54
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CONTACT INFORMATION"
        '
        'txtPHONE
        '
        Me.txtPHONE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHONE.Location = New System.Drawing.Point(346, 66)
        Me.txtPHONE.Mask = "(999) 000-0000"
        Me.txtPHONE.Name = "txtPHONE"
        Me.txtPHONE.Size = New System.Drawing.Size(100, 22)
        Me.txtPHONE.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "WEBSITE"
        '
        'txtWEBSITE
        '
        Me.txtWEBSITE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWEBSITE.Location = New System.Drawing.Point(81, 103)
        Me.txtWEBSITE.Name = "txtWEBSITE"
        Me.txtWEBSITE.Size = New System.Drawing.Size(340, 22)
        Me.txtWEBSITE.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(283, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 17)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "PHONE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(283, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = " LAST"
        '
        'txtCONTACTLNAME
        '
        Me.txtCONTACTLNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCONTACTLNAME.Location = New System.Drawing.Point(336, 33)
        Me.txtCONTACTLNAME.Name = "txtCONTACTLNAME"
        Me.txtCONTACTLNAME.Size = New System.Drawing.Size(177, 22)
        Me.txtCONTACTLNAME.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "POSITION"
        '
        'txtPOSITION
        '
        Me.txtPOSITION.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOSITION.Location = New System.Drawing.Point(87, 66)
        Me.txtPOSITION.Name = "txtPOSITION"
        Me.txtPOSITION.Size = New System.Drawing.Size(190, 22)
        Me.txtPOSITION.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 17)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "FIRST NAME"
        '
        'txtCONTACTFNAME
        '
        Me.txtCONTACTFNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCONTACTFNAME.Location = New System.Drawing.Point(104, 33)
        Me.txtCONTACTFNAME.Name = "txtCONTACTFNAME"
        Me.txtCONTACTFNAME.Size = New System.Drawing.Size(173, 22)
        Me.txtCONTACTFNAME.TabIndex = 46
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtCOUNTRY)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtCITY)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtPOSTAL)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtADDRESS)
        Me.GroupBox3.Controls.Add(Me.cbTYPE)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtCOMPANYNAME)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(55, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(510, 221)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "COMPANY INFORMATION"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 17)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "COUNTRY"
        '
        'txtCOUNTRY
        '
        Me.txtCOUNTRY.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOUNTRY.Location = New System.Drawing.Point(106, 170)
        Me.txtCOUNTRY.Name = "txtCOUNTRY"
        Me.txtCOUNTRY.Size = New System.Drawing.Size(216, 22)
        Me.txtCOUNTRY.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "CITY"
        '
        'txtCITY
        '
        Me.txtCITY.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCITY.Location = New System.Drawing.Point(106, 134)
        Me.txtCITY.Name = "txtCITY"
        Me.txtCITY.Size = New System.Drawing.Size(191, 22)
        Me.txtCITY.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(317, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "POSTAL"
        '
        'txtPOSTAL
        '
        Me.txtPOSTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOSTAL.Location = New System.Drawing.Point(386, 134)
        Me.txtPOSTAL.Name = "txtPOSTAL"
        Me.txtPOSTAL.Size = New System.Drawing.Size(109, 22)
        Me.txtPOSTAL.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "ADDRESS"
        '
        'txtADDRESS
        '
        Me.txtADDRESS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtADDRESS.Location = New System.Drawing.Point(129, 98)
        Me.txtADDRESS.Name = "txtADDRESS"
        Me.txtADDRESS.Size = New System.Drawing.Size(346, 22)
        Me.txtADDRESS.TabIndex = 40
        '
        'cbTYPE
        '
        Me.cbTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTYPE.FormattingEnabled = True
        Me.cbTYPE.Location = New System.Drawing.Point(129, 28)
        Me.cbTYPE.Name = "cbTYPE"
        Me.cbTYPE.Size = New System.Drawing.Size(193, 24)
        Me.cbTYPE.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "COMPANY NAME"
        '
        'txtCOMPANYNAME
        '
        Me.txtCOMPANYNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOMPANYNAME.Location = New System.Drawing.Point(160, 64)
        Me.txtCOMPANYNAME.Name = "txtCOMPANYNAME"
        Me.txtCOMPANYNAME.Size = New System.Drawing.Size(315, 22)
        Me.txtCOMPANYNAME.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "TYPE"
        '
        'btnDeleteInternship
        '
        Me.btnDeleteInternship.BackColor = System.Drawing.Color.Red
        Me.btnDeleteInternship.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteInternship.Location = New System.Drawing.Point(1224, 242)
        Me.btnDeleteInternship.Name = "btnDeleteInternship"
        Me.btnDeleteInternship.Size = New System.Drawing.Size(79, 33)
        Me.btnDeleteInternship.TabIndex = 50
        Me.btnDeleteInternship.Text = "DELETE"
        Me.btnDeleteInternship.UseVisualStyleBackColor = False
        '
        'btnAddInternship
        '
        Me.btnAddInternship.BackColor = System.Drawing.Color.Lime
        Me.btnAddInternship.Location = New System.Drawing.Point(1159, 242)
        Me.btnAddInternship.Name = "btnAddInternship"
        Me.btnAddInternship.Size = New System.Drawing.Size(59, 33)
        Me.btnAddInternship.TabIndex = 49
        Me.btnAddInternship.Text = "ADD"
        Me.btnAddInternship.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(372, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CLICK ON COMPANY ROW TO SELECT COMPANY"
        '
        'INTERNSHIPDGV
        '
        Me.INTERNSHIPDGV.AllowUserToAddRows = False
        Me.INTERNSHIPDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.INTERNSHIPDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.INTERNSHIPDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.INTERNSHIPDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.TYPE, Me.CNAME, Me.ADDRESS, Me.CITY, Me.POSTAL, Me.COUNTRY, Me.FNAME, Me.LNAME, Me.POSITION, Me.PHONE, Me.WEBSITE, Me.NOTES})
        Me.INTERNSHIPDGV.Location = New System.Drawing.Point(58, 281)
        Me.INTERNSHIPDGV.Name = "INTERNSHIPDGV"
        Me.INTERNSHIPDGV.ReadOnly = True
        Me.INTERNSHIPDGV.RowTemplate.Height = 24
        Me.INTERNSHIPDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.INTERNSHIPDGV.Size = New System.Drawing.Size(1486, 571)
        Me.INTERNSHIPDGV.TabIndex = 9
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 20
        '
        'TYPE
        '
        Me.TYPE.FillWeight = 50.0!
        Me.TYPE.HeaderText = "TYPE"
        Me.TYPE.MaxInputLength = 50
        Me.TYPE.Name = "TYPE"
        Me.TYPE.ReadOnly = True
        '
        'CNAME
        '
        Me.CNAME.HeaderText = "COMPANY NAME"
        Me.CNAME.Name = "CNAME"
        Me.CNAME.ReadOnly = True
        Me.CNAME.Width = 150
        '
        'ADDRESS
        '
        Me.ADDRESS.HeaderText = "ADDRESS"
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.ReadOnly = True
        Me.ADDRESS.Width = 150
        '
        'CITY
        '
        Me.CITY.HeaderText = "CITY"
        Me.CITY.Name = "CITY"
        Me.CITY.ReadOnly = True
        '
        'POSTAL
        '
        Me.POSTAL.HeaderText = "POSTAL"
        Me.POSTAL.Name = "POSTAL"
        Me.POSTAL.ReadOnly = True
        Me.POSTAL.Width = 80
        '
        'COUNTRY
        '
        Me.COUNTRY.HeaderText = "COUNTRY"
        Me.COUNTRY.Name = "COUNTRY"
        Me.COUNTRY.ReadOnly = True
        '
        'FNAME
        '
        Me.FNAME.HeaderText = "FNAME"
        Me.FNAME.Name = "FNAME"
        Me.FNAME.ReadOnly = True
        '
        'LNAME
        '
        Me.LNAME.HeaderText = "LNAME"
        Me.LNAME.Name = "LNAME"
        Me.LNAME.ReadOnly = True
        '
        'POSITION
        '
        Me.POSITION.HeaderText = "POSITION"
        Me.POSITION.Name = "POSITION"
        Me.POSITION.ReadOnly = True
        '
        'PHONE
        '
        Me.PHONE.HeaderText = "PHONE"
        Me.PHONE.Name = "PHONE"
        Me.PHONE.ReadOnly = True
        Me.PHONE.Width = 60
        '
        'WEBSITE
        '
        Me.WEBSITE.HeaderText = "WEBSITE"
        Me.WEBSITE.Name = "WEBSITE"
        Me.WEBSITE.ReadOnly = True
        '
        'NOTES
        '
        Me.NOTES.FillWeight = 150.0!
        Me.NOTES.HeaderText = "NOTES"
        Me.NOTES.Name = "NOTES"
        Me.NOTES.ReadOnly = True
        Me.NOTES.Width = 425
        '
        'ADMIN_INTERNSHIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1622, 922)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "ADMIN_INTERNSHIP"
        Me.Text = "ADMIN___USERS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.INTERNSHIPDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents INTERNSHIPDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNOTES As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtWEBSITE As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCONTACTLNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPOSITION As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCONTACTFNAME As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCOUNTRY As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCITY As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPOSTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtADDRESS As System.Windows.Forms.TextBox
    Friend WithEvents cbTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCOMPANYNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteInternship As System.Windows.Forms.Button
    Friend WithEvents btnAddInternship As System.Windows.Forms.Button
    Friend WithEvents txtPHONE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDRESS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CITY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POSTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COUNTRY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POSITION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHONE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WEBSITE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTES As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
