<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN_SKILLS
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbCATEGORY = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SkillsDGV = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKILL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSKILL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SkillsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbCATEGORY)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.SkillsDGV)
        Me.GroupBox2.Controls.Add(Me.btnDeleteUser)
        Me.GroupBox2.Controls.Add(Me.btnAddUser)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtSKILL)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1625, 993)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ADD/DELETE SKILLS"
        '
        'cbCATEGORY
        '
        Me.cbCATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCATEGORY.FormattingEnabled = True
        Me.cbCATEGORY.Location = New System.Drawing.Point(117, 37)
        Me.cbCATEGORY.Name = "cbCATEGORY"
        Me.cbCATEGORY.Size = New System.Drawing.Size(346, 24)
        Me.cbCATEGORY.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CLICK ON SKILL ROW TO SELECT "
        '
        'SkillsDGV
        '
        Me.SkillsDGV.AllowUserToAddRows = False
        Me.SkillsDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SkillsDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.SkillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SkillsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CATEGORY, Me.SKILL})
        Me.SkillsDGV.Location = New System.Drawing.Point(18, 179)
        Me.SkillsDGV.Name = "SkillsDGV"
        Me.SkillsDGV.ReadOnly = True
        Me.SkillsDGV.RowTemplate.Height = 24
        Me.SkillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SkillsDGV.Size = New System.Drawing.Size(445, 782)
        Me.SkillsDGV.TabIndex = 9
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'CATEGORY
        '
        Me.CATEGORY.FillWeight = 50.0!
        Me.CATEGORY.HeaderText = "CATEGORY"
        Me.CATEGORY.MaxInputLength = 200
        Me.CATEGORY.Name = "CATEGORY"
        Me.CATEGORY.ReadOnly = True
        Me.CATEGORY.Width = 150
        '
        'SKILL
        '
        Me.SKILL.FillWeight = 50.0!
        Me.SKILL.HeaderText = "SKILL"
        Me.SKILL.MaxInputLength = 50
        Me.SKILL.Name = "SKILL"
        Me.SKILL.ReadOnly = True
        Me.SKILL.Width = 150
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.Red
        Me.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteUser.Location = New System.Drawing.Point(381, 111)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(72, 33)
        Me.btnDeleteUser.TabIndex = 7
        Me.btnDeleteUser.Text = "DELETE"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.Lime
        Me.btnAddUser.Location = New System.Drawing.Point(316, 111)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(59, 33)
        Me.btnAddUser.TabIndex = 6
        Me.btnAddUser.Text = "ADD"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SKILL"
        '
        'txtSKILL
        '
        Me.txtSKILL.Location = New System.Drawing.Point(117, 73)
        Me.txtSKILL.Name = "txtSKILL"
        Me.txtSKILL.Size = New System.Drawing.Size(346, 22)
        Me.txtSKILL.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CATEGORY"
        '
        'ADMIN_SKILLS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1622, 922)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "ADMIN_SKILLS"
        Me.Text = "ADMIN___USERS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SkillsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSKILL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SkillsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CATEGORY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SKILL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbCATEGORY As System.Windows.Forms.ComboBox
End Class
