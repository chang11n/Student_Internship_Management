<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN_JOBS
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
        Me.cbTYPE = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSALARY = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRESPONSIBILITIES = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtREQUIREMENTS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDESCRIPTION = New System.Windows.Forms.TextBox()
        Me.cbJOBGROUP = New System.Windows.Forms.ComboBox()
        Me.btnDeleteJob = New System.Windows.Forms.Button()
        Me.btnAddJob = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPOSITION = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.JobsDGV = New System.Windows.Forms.DataGridView()
        Me.JID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOBGROUP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQUIREMENTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESPONSIBILITIES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbSearchCompany = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.JobsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.JobsDGV)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1625, 993)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ADD/DELETE JOBS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cbSearchCompany)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbTYPE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSALARY)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtRESPONSIBILITIES)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtREQUIREMENTS)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDESCRIPTION)
        Me.GroupBox1.Controls.Add(Me.cbJOBGROUP)
        Me.GroupBox1.Controls.Add(Me.btnDeleteJob)
        Me.GroupBox1.Controls.Add(Me.btnAddJob)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPOSITION)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1346, 225)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'cbTYPE
        '
        Me.cbTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTYPE.FormattingEnabled = True
        Me.cbTYPE.Location = New System.Drawing.Point(191, 59)
        Me.cbTYPE.Name = "cbTYPE"
        Me.cbTYPE.Size = New System.Drawing.Size(304, 24)
        Me.cbTYPE.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "INTERNSHIP TYPE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1100, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "SALARY"
        '
        'txtSALARY
        '
        Me.txtSALARY.Location = New System.Drawing.Point(1194, 16)
        Me.txtSALARY.Name = "txtSALARY"
        Me.txtSALARY.Size = New System.Drawing.Size(97, 22)
        Me.txtSALARY.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(513, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "RESPONSIBILITIES"
        '
        'txtRESPONSIBILITIES
        '
        Me.txtRESPONSIBILITIES.Location = New System.Drawing.Point(650, 19)
        Me.txtRESPONSIBILITIES.Multiline = True
        Me.txtRESPONSIBILITIES.Name = "txtRESPONSIBILITIES"
        Me.txtRESPONSIBILITIES.Size = New System.Drawing.Size(437, 74)
        Me.txtRESPONSIBILITIES.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(513, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "REQUIREMENTS"
        '
        'txtREQUIREMENTS
        '
        Me.txtREQUIREMENTS.Location = New System.Drawing.Point(650, 140)
        Me.txtREQUIREMENTS.Multiline = True
        Me.txtREQUIREMENTS.Name = "txtREQUIREMENTS"
        Me.txtREQUIREMENTS.Size = New System.Drawing.Size(437, 68)
        Me.txtREQUIREMENTS.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "DESCRIPTION"
        '
        'txtDESCRIPTION
        '
        Me.txtDESCRIPTION.Location = New System.Drawing.Point(161, 143)
        Me.txtDESCRIPTION.Multiline = True
        Me.txtDESCRIPTION.Name = "txtDESCRIPTION"
        Me.txtDESCRIPTION.Size = New System.Drawing.Size(334, 65)
        Me.txtDESCRIPTION.TabIndex = 4
        '
        'cbJOBGROUP
        '
        Me.cbJOBGROUP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJOBGROUP.FormattingEnabled = True
        Me.cbJOBGROUP.Location = New System.Drawing.Point(149, 16)
        Me.cbJOBGROUP.Name = "cbJOBGROUP"
        Me.cbJOBGROUP.Size = New System.Drawing.Size(346, 24)
        Me.cbJOBGROUP.TabIndex = 1
        '
        'btnDeleteJob
        '
        Me.btnDeleteJob.BackColor = System.Drawing.Color.Red
        Me.btnDeleteJob.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteJob.Location = New System.Drawing.Point(1219, 185)
        Me.btnDeleteJob.Name = "btnDeleteJob"
        Me.btnDeleteJob.Size = New System.Drawing.Size(72, 34)
        Me.btnDeleteJob.TabIndex = 10
        Me.btnDeleteJob.Text = "DELETE"
        Me.btnDeleteJob.UseVisualStyleBackColor = False
        '
        'btnAddJob
        '
        Me.btnAddJob.BackColor = System.Drawing.Color.Lime
        Me.btnAddJob.Location = New System.Drawing.Point(1154, 185)
        Me.btnAddJob.Name = "btnAddJob"
        Me.btnAddJob.Size = New System.Drawing.Size(59, 34)
        Me.btnAddJob.TabIndex = 22
        Me.btnAddJob.Text = "ADD"
        Me.btnAddJob.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "POSITION"
        '
        'txtPOSITION
        '
        Me.txtPOSITION.Location = New System.Drawing.Point(149, 103)
        Me.txtPOSITION.Name = "txtPOSITION"
        Me.txtPOSITION.Size = New System.Drawing.Size(346, 22)
        Me.txtPOSITION.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "JOB GROUP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CLICK ON JOB ROW TO SELECT JOB"
        '
        'JobsDGV
        '
        Me.JobsDGV.AllowUserToAddRows = False
        Me.JobsDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.JobsDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.JobsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JobsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JID, Me.JOBGROUP, Me.POSITION, Me.REQUIREMENTS, Me.DESCRIPTION, Me.RESPONSIBILITIES, Me.SALARY})
        Me.JobsDGV.Location = New System.Drawing.Point(26, 281)
        Me.JobsDGV.Name = "JobsDGV"
        Me.JobsDGV.ReadOnly = True
        Me.JobsDGV.RowTemplate.Height = 24
        Me.JobsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.JobsDGV.Size = New System.Drawing.Size(1491, 571)
        Me.JobsDGV.TabIndex = 9
        '
        'JID
        '
        Me.JID.HeaderText = "JID"
        Me.JID.Name = "JID"
        Me.JID.ReadOnly = True
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
        Me.REQUIREMENTS.Width = 250
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.HeaderText = "DESCRIPTION"
        Me.DESCRIPTION.Name = "DESCRIPTION"
        Me.DESCRIPTION.ReadOnly = True
        Me.DESCRIPTION.Width = 300
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(513, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 17)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "COMPANY NAME"
        '
        'cbSearchCompany
        '
        Me.cbSearchCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchCompany.FormattingEnabled = True
        Me.cbSearchCompany.Location = New System.Drawing.Point(650, 103)
        Me.cbSearchCompany.Name = "cbSearchCompany"
        Me.cbSearchCompany.Size = New System.Drawing.Size(346, 24)
        Me.cbSearchCompany.TabIndex = 38
        '
        'ADMIN_JOBS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1622, 922)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "ADMIN_JOBS"
        Me.Text = "ADMIN___USERS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.JobsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents JobsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSALARY As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRESPONSIBILITIES As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtREQUIREMENTS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDESCRIPTION As System.Windows.Forms.TextBox
    Friend WithEvents cbJOBGROUP As System.Windows.Forms.ComboBox
    Friend WithEvents btnDeleteJob As System.Windows.Forms.Button
    Friend WithEvents btnAddJob As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPOSITION As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents JID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JOBGROUP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POSITION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REQUIREMENTS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPTION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESPONSIBILITIES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALARY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbSearchCompany As System.Windows.Forms.ComboBox
End Class
