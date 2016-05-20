<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN___USERS
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
        Me.txtSID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserDGV = New System.Windows.Forms.DataGridView()
        Me.SID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADMINLEVEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.txtUSERNAME = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbUserlevel = New System.Windows.Forms.ComboBox()
        Me.txtPASSWORD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.UserDGV)
        Me.GroupBox2.Controls.Add(Me.btnDeleteUser)
        Me.GroupBox2.Controls.Add(Me.btnAddUser)
        Me.GroupBox2.Controls.Add(Me.txtUSERNAME)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbUserlevel)
        Me.GroupBox2.Controls.Add(Me.txtPASSWORD)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1625, 993)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ADD/DELETE USERS"
        '
        'txtSID
        '
        Me.txtSID.Location = New System.Drawing.Point(122, 70)
        Me.txtSID.Name = "txtSID"
        Me.txtSID.Size = New System.Drawing.Size(349, 22)
        Me.txtSID.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "STUDENT ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CLICK ON USER ROW TO SELECT USER"
        '
        'UserDGV
        '
        Me.UserDGV.AllowUserToAddRows = False
        Me.UserDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SID, Me.USERNAME, Me.ADMINLEVEL})
        Me.UserDGV.Location = New System.Drawing.Point(23, 224)
        Me.UserDGV.Name = "UserDGV"
        Me.UserDGV.ReadOnly = True
        Me.UserDGV.RowTemplate.Height = 24
        Me.UserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserDGV.Size = New System.Drawing.Size(462, 763)
        Me.UserDGV.TabIndex = 9
        '
        'SID
        '
        Me.SID.HeaderText = "SID"
        Me.SID.Name = "SID"
        Me.SID.ReadOnly = True
        Me.SID.Width = 120
        '
        'USERNAME
        '
        Me.USERNAME.FillWeight = 50.0!
        Me.USERNAME.HeaderText = "USERNAME"
        Me.USERNAME.MaxInputLength = 50
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.ReadOnly = True
        Me.USERNAME.Width = 150
        '
        'ADMINLEVEL
        '
        Me.ADMINLEVEL.FillWeight = 50.0!
        Me.ADMINLEVEL.HeaderText = "ADMIN LEVEL"
        Me.ADMINLEVEL.MaxInputLength = 200
        Me.ADMINLEVEL.Name = "ADMINLEVEL"
        Me.ADMINLEVEL.ReadOnly = True
        Me.ADMINLEVEL.Width = 150
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.Red
        Me.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteUser.Location = New System.Drawing.Point(381, 132)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(72, 34)
        Me.btnDeleteUser.TabIndex = 7
        Me.btnDeleteUser.Text = "DELETE"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.Lime
        Me.btnAddUser.Location = New System.Drawing.Point(316, 132)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(59, 34)
        Me.btnAddUser.TabIndex = 6
        Me.btnAddUser.Text = "ADD"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'txtUSERNAME
        '
        Me.txtUSERNAME.Location = New System.Drawing.Point(122, 37)
        Me.txtUSERNAME.Name = "txtUSERNAME"
        Me.txtUSERNAME.Size = New System.Drawing.Size(349, 22)
        Me.txtUSERNAME.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "USER LEVEL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD"
        '
        'cbUserlevel
        '
        Me.cbUserlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUserlevel.FormattingEnabled = True
        Me.cbUserlevel.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.cbUserlevel.Location = New System.Drawing.Point(122, 142)
        Me.cbUserlevel.Name = "cbUserlevel"
        Me.cbUserlevel.Size = New System.Drawing.Size(188, 24)
        Me.cbUserlevel.TabIndex = 4
        '
        'txtPASSWORD
        '
        Me.txtPASSWORD.Location = New System.Drawing.Point(122, 104)
        Me.txtPASSWORD.Name = "txtPASSWORD"
        Me.txtPASSWORD.Size = New System.Drawing.Size(346, 22)
        Me.txtPASSWORD.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'ADMIN___USERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1622, 922)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "ADMIN___USERS"
        Me.Text = "ADMIN___USERS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents txtUSERNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbUserlevel As System.Windows.Forms.ComboBox
    Friend WithEvents txtPASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADMINLEVEL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
