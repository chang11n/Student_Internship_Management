<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employer
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
        Me.lblEMP_CODE = New System.Windows.Forms.Label()
        Me.lblEMP_Name = New System.Windows.Forms.Label()
        Me.lblEMP_Address = New System.Windows.Forms.Label()
        Me.lbl_EMPCity = New System.Windows.Forms.Label()
        Me.LabeEMP_PostCode = New System.Windows.Forms.Label()
        Me.txtEMP_Address = New System.Windows.Forms.TextBox()
        Me.cbxEMP_City = New System.Windows.Forms.ComboBox()
        Me.txtEMP_PostCode = New System.Windows.Forms.TextBox()
        Me.lblEMP_Country = New System.Windows.Forms.Label()
        Me.txtEMP_Code = New System.Windows.Forms.TextBox()
        Me.txtEMP_Name = New System.Windows.Forms.TextBox()
        Me.cbxEMP_Country = New System.Windows.Forms.ComboBox()
        Me.gbxEMP = New System.Windows.Forms.GroupBox()
        Me.txtEMP_Web = New System.Windows.Forms.TextBox()
        Me.lblEMP_Web = New System.Windows.Forms.Label()
        Me.gbxContact = New System.Windows.Forms.GroupBox()
        Me.txtCon_Phone = New System.Windows.Forms.MaskedTextBox()
        Me.txtCon_Email = New System.Windows.Forms.TextBox()
        Me.txtCon_Position = New System.Windows.Forms.TextBox()
        Me.txtCon_Lname = New System.Windows.Forms.TextBox()
        Me.lblCon_Email = New System.Windows.Forms.Label()
        Me.lblCon_Phone = New System.Windows.Forms.Label()
        Me.lblCon_Position = New System.Windows.Forms.Label()
        Me.lblCon_LName = New System.Windows.Forms.Label()
        Me.txtCon_Fname = New System.Windows.Forms.TextBox()
        Me.lblCon_Fname = New System.Windows.Forms.Label()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.gbxEMP.SuspendLayout()
        Me.gbxContact.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEMP_CODE
        '
        Me.lblEMP_CODE.AutoSize = True
        Me.lblEMP_CODE.Location = New System.Drawing.Point(6, 32)
        Me.lblEMP_CODE.Name = "lblEMP_CODE"
        Me.lblEMP_CODE.Size = New System.Drawing.Size(108, 17)
        Me.lblEMP_CODE.TabIndex = 0
        Me.lblEMP_CODE.Text = "Employer Code:"
        '
        'lblEMP_Name
        '
        Me.lblEMP_Name.AutoSize = True
        Me.lblEMP_Name.Location = New System.Drawing.Point(259, 32)
        Me.lblEMP_Name.Name = "lblEMP_Name"
        Me.lblEMP_Name.Size = New System.Drawing.Size(71, 17)
        Me.lblEMP_Name.TabIndex = 1
        Me.lblEMP_Name.Text = "Employer:"
        '
        'lblEMP_Address
        '
        Me.lblEMP_Address.AutoSize = True
        Me.lblEMP_Address.Location = New System.Drawing.Point(6, 65)
        Me.lblEMP_Address.Name = "lblEMP_Address"
        Me.lblEMP_Address.Size = New System.Drawing.Size(64, 17)
        Me.lblEMP_Address.TabIndex = 2
        Me.lblEMP_Address.Text = "Address:"
        '
        'lbl_EMPCity
        '
        Me.lbl_EMPCity.AutoSize = True
        Me.lbl_EMPCity.Location = New System.Drawing.Point(295, 68)
        Me.lbl_EMPCity.Name = "lbl_EMPCity"
        Me.lbl_EMPCity.Size = New System.Drawing.Size(35, 17)
        Me.lbl_EMPCity.TabIndex = 3
        Me.lbl_EMPCity.Text = "City:"
        '
        'LabeEMP_PostCode
        '
        Me.LabeEMP_PostCode.AutoSize = True
        Me.LabeEMP_PostCode.Location = New System.Drawing.Point(463, 68)
        Me.LabeEMP_PostCode.Name = "LabeEMP_PostCode"
        Me.LabeEMP_PostCode.Size = New System.Drawing.Size(77, 17)
        Me.LabeEMP_PostCode.TabIndex = 4
        Me.LabeEMP_PostCode.Text = "Post Code:"
        '
        'txtEMP_Address
        '
        Me.txtEMP_Address.Location = New System.Drawing.Point(83, 65)
        Me.txtEMP_Address.Name = "txtEMP_Address"
        Me.txtEMP_Address.Size = New System.Drawing.Size(201, 22)
        Me.txtEMP_Address.TabIndex = 3
        '
        'cbxEMP_City
        '
        Me.cbxEMP_City.FormattingEnabled = True
        Me.cbxEMP_City.Items.AddRange(New Object() {"Windsor", "Toronto", "London"})
        Me.cbxEMP_City.Location = New System.Drawing.Point(336, 65)
        Me.cbxEMP_City.Name = "cbxEMP_City"
        Me.cbxEMP_City.Size = New System.Drawing.Size(121, 24)
        Me.cbxEMP_City.TabIndex = 4
        '
        'txtEMP_PostCode
        '
        Me.txtEMP_PostCode.Location = New System.Drawing.Point(546, 65)
        Me.txtEMP_PostCode.Name = "txtEMP_PostCode"
        Me.txtEMP_PostCode.Size = New System.Drawing.Size(100, 22)
        Me.txtEMP_PostCode.TabIndex = 5
        '
        'lblEMP_Country
        '
        Me.lblEMP_Country.AutoSize = True
        Me.lblEMP_Country.Location = New System.Drawing.Point(6, 103)
        Me.lblEMP_Country.Name = "lblEMP_Country"
        Me.lblEMP_Country.Size = New System.Drawing.Size(61, 17)
        Me.lblEMP_Country.TabIndex = 9
        Me.lblEMP_Country.Text = "Country:"
        '
        'txtEMP_Code
        '
        Me.txtEMP_Code.Location = New System.Drawing.Point(121, 32)
        Me.txtEMP_Code.Name = "txtEMP_Code"
        Me.txtEMP_Code.Size = New System.Drawing.Size(100, 22)
        Me.txtEMP_Code.TabIndex = 1
        '
        'txtEMP_Name
        '
        Me.txtEMP_Name.Location = New System.Drawing.Point(336, 29)
        Me.txtEMP_Name.Name = "txtEMP_Name"
        Me.txtEMP_Name.Size = New System.Drawing.Size(310, 22)
        Me.txtEMP_Name.TabIndex = 2
        '
        'cbxEMP_Country
        '
        Me.cbxEMP_Country.FormattingEnabled = True
        Me.cbxEMP_Country.Location = New System.Drawing.Point(83, 96)
        Me.cbxEMP_Country.Name = "cbxEMP_Country"
        Me.cbxEMP_Country.Size = New System.Drawing.Size(121, 24)
        Me.cbxEMP_Country.TabIndex = 6
        '
        'gbxEMP
        '
        Me.gbxEMP.Controls.Add(Me.txtEMP_Web)
        Me.gbxEMP.Controls.Add(Me.lblEMP_Web)
        Me.gbxEMP.Controls.Add(Me.lblEMP_Name)
        Me.gbxEMP.Controls.Add(Me.cbxEMP_Country)
        Me.gbxEMP.Controls.Add(Me.txtEMP_Name)
        Me.gbxEMP.Controls.Add(Me.lblEMP_CODE)
        Me.gbxEMP.Controls.Add(Me.lblEMP_Country)
        Me.gbxEMP.Controls.Add(Me.txtEMP_Code)
        Me.gbxEMP.Controls.Add(Me.txtEMP_PostCode)
        Me.gbxEMP.Controls.Add(Me.lblEMP_Address)
        Me.gbxEMP.Controls.Add(Me.LabeEMP_PostCode)
        Me.gbxEMP.Controls.Add(Me.cbxEMP_City)
        Me.gbxEMP.Controls.Add(Me.txtEMP_Address)
        Me.gbxEMP.Controls.Add(Me.lbl_EMPCity)
        Me.gbxEMP.Location = New System.Drawing.Point(12, 45)
        Me.gbxEMP.Name = "gbxEMP"
        Me.gbxEMP.Size = New System.Drawing.Size(667, 171)
        Me.gbxEMP.TabIndex = 14
        Me.gbxEMP.TabStop = False
        Me.gbxEMP.Text = "EMPLOYER INFORMATION"
        '
        'txtEMP_Web
        '
        Me.txtEMP_Web.Location = New System.Drawing.Point(83, 136)
        Me.txtEMP_Web.Name = "txtEMP_Web"
        Me.txtEMP_Web.Size = New System.Drawing.Size(201, 22)
        Me.txtEMP_Web.TabIndex = 7
        '
        'lblEMP_Web
        '
        Me.lblEMP_Web.AutoSize = True
        Me.lblEMP_Web.Location = New System.Drawing.Point(6, 141)
        Me.lblEMP_Web.Name = "lblEMP_Web"
        Me.lblEMP_Web.Size = New System.Drawing.Size(63, 17)
        Me.lblEMP_Web.TabIndex = 14
        Me.lblEMP_Web.Text = "Website:"
        '
        'gbxContact
        '
        Me.gbxContact.Controls.Add(Me.txtCon_Phone)
        Me.gbxContact.Controls.Add(Me.txtCon_Email)
        Me.gbxContact.Controls.Add(Me.txtCon_Position)
        Me.gbxContact.Controls.Add(Me.txtCon_Lname)
        Me.gbxContact.Controls.Add(Me.lblCon_Email)
        Me.gbxContact.Controls.Add(Me.lblCon_Phone)
        Me.gbxContact.Controls.Add(Me.lblCon_Position)
        Me.gbxContact.Controls.Add(Me.lblCon_LName)
        Me.gbxContact.Controls.Add(Me.txtCon_Fname)
        Me.gbxContact.Controls.Add(Me.lblCon_Fname)
        Me.gbxContact.Location = New System.Drawing.Point(12, 260)
        Me.gbxContact.Name = "gbxContact"
        Me.gbxContact.Size = New System.Drawing.Size(667, 148)
        Me.gbxContact.TabIndex = 15
        Me.gbxContact.TabStop = False
        Me.gbxContact.Text = "CONTACT PERSON"
        '
        'txtCon_Phone
        '
        Me.txtCon_Phone.Location = New System.Drawing.Point(341, 69)
        Me.txtCon_Phone.Mask = "(999) 000-0000"
        Me.txtCon_Phone.Name = "txtCon_Phone"
        Me.txtCon_Phone.Size = New System.Drawing.Size(100, 22)
        Me.txtCon_Phone.TabIndex = 11
        '
        'txtCon_Email
        '
        Me.txtCon_Email.Location = New System.Drawing.Point(83, 114)
        Me.txtCon_Email.Name = "txtCon_Email"
        Me.txtCon_Email.Size = New System.Drawing.Size(201, 22)
        Me.txtCon_Email.TabIndex = 12
        '
        'txtCon_Position
        '
        Me.txtCon_Position.Location = New System.Drawing.Point(88, 71)
        Me.txtCon_Position.Name = "txtCon_Position"
        Me.txtCon_Position.Size = New System.Drawing.Size(133, 22)
        Me.txtCon_Position.TabIndex = 10
        '
        'txtCon_Lname
        '
        Me.txtCon_Lname.Location = New System.Drawing.Point(341, 30)
        Me.txtCon_Lname.Name = "txtCon_Lname"
        Me.txtCon_Lname.Size = New System.Drawing.Size(135, 22)
        Me.txtCon_Lname.TabIndex = 9
        '
        'lblCon_Email
        '
        Me.lblCon_Email.AutoSize = True
        Me.lblCon_Email.Location = New System.Drawing.Point(11, 114)
        Me.lblCon_Email.Name = "lblCon_Email"
        Me.lblCon_Email.Size = New System.Drawing.Size(46, 17)
        Me.lblCon_Email.TabIndex = 5
        Me.lblCon_Email.Text = "Email:"
        '
        'lblCon_Phone
        '
        Me.lblCon_Phone.AutoSize = True
        Me.lblCon_Phone.Location = New System.Drawing.Point(255, 74)
        Me.lblCon_Phone.Name = "lblCon_Phone"
        Me.lblCon_Phone.Size = New System.Drawing.Size(80, 17)
        Me.lblCon_Phone.TabIndex = 4
        Me.lblCon_Phone.Text = "Telephone:"
        '
        'lblCon_Position
        '
        Me.lblCon_Position.AutoSize = True
        Me.lblCon_Position.Location = New System.Drawing.Point(11, 71)
        Me.lblCon_Position.Name = "lblCon_Position"
        Me.lblCon_Position.Size = New System.Drawing.Size(59, 17)
        Me.lblCon_Position.TabIndex = 3
        Me.lblCon_Position.Text = "Postion:"
        '
        'lblCon_LName
        '
        Me.lblCon_LName.AutoSize = True
        Me.lblCon_LName.Location = New System.Drawing.Point(255, 33)
        Me.lblCon_LName.Name = "lblCon_LName"
        Me.lblCon_LName.Size = New System.Drawing.Size(80, 17)
        Me.lblCon_LName.TabIndex = 2
        Me.lblCon_LName.Text = "Last Name:"
        '
        'txtCon_Fname
        '
        Me.txtCon_Fname.Location = New System.Drawing.Point(88, 30)
        Me.txtCon_Fname.Name = "txtCon_Fname"
        Me.txtCon_Fname.Size = New System.Drawing.Size(148, 22)
        Me.txtCon_Fname.TabIndex = 8
        '
        'lblCon_Fname
        '
        Me.lblCon_Fname.AutoSize = True
        Me.lblCon_Fname.Location = New System.Drawing.Point(9, 33)
        Me.lblCon_Fname.Name = "lblCon_Fname"
        Me.lblCon_Fname.Size = New System.Drawing.Size(80, 17)
        Me.lblCon_Fname.TabIndex = 0
        Me.lblCon_Fname.Text = "First Name:"
        '
        'btnUPDATE
        '
        Me.btnUPDATE.Location = New System.Drawing.Point(583, 429)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(75, 23)
        Me.btnUPDATE.TabIndex = 16
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'btnSAVE
        '
        Me.btnSAVE.Location = New System.Drawing.Point(583, 429)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(75, 23)
        Me.btnSAVE.TabIndex = 17
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(477, 429)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(75, 23)
        Me.btnClearForm.TabIndex = 18
        Me.btnClearForm.Text = "CLEAR"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'employer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1656, 972)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnSAVE)
        Me.Controls.Add(Me.btnUPDATE)
        Me.Controls.Add(Me.gbxContact)
        Me.Controls.Add(Me.gbxEMP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "employer"
        Me.Text = "EMPLOYER INFORMATION"
        Me.gbxEMP.ResumeLayout(False)
        Me.gbxEMP.PerformLayout()
        Me.gbxContact.ResumeLayout(False)
        Me.gbxContact.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEMP_CODE As System.Windows.Forms.Label
    Friend WithEvents lblEMP_Name As System.Windows.Forms.Label
    Friend WithEvents lblEMP_Address As System.Windows.Forms.Label
    Friend WithEvents lbl_EMPCity As System.Windows.Forms.Label
    Friend WithEvents LabeEMP_PostCode As System.Windows.Forms.Label
    Friend WithEvents txtEMP_Address As System.Windows.Forms.TextBox
    Friend WithEvents cbxEMP_City As System.Windows.Forms.ComboBox
    Friend WithEvents txtEMP_PostCode As System.Windows.Forms.TextBox
    Friend WithEvents lblEMP_Country As System.Windows.Forms.Label
    Friend WithEvents txtEMP_Code As System.Windows.Forms.TextBox
    Friend WithEvents txtEMP_Name As System.Windows.Forms.TextBox
    Friend WithEvents cbxEMP_Country As System.Windows.Forms.ComboBox
    Friend WithEvents gbxEMP As System.Windows.Forms.GroupBox
    Friend WithEvents lblEMP_Web As System.Windows.Forms.Label
    Friend WithEvents gbxContact As System.Windows.Forms.GroupBox
    Friend WithEvents txtCon_Position As System.Windows.Forms.TextBox
    Friend WithEvents txtCon_Lname As System.Windows.Forms.TextBox
    Friend WithEvents lblCon_Email As System.Windows.Forms.Label
    Friend WithEvents lblCon_Phone As System.Windows.Forms.Label
    Friend WithEvents lblCon_Position As System.Windows.Forms.Label
    Friend WithEvents lblCon_LName As System.Windows.Forms.Label
    Friend WithEvents txtCon_Fname As System.Windows.Forms.TextBox
    Friend WithEvents lblCon_Fname As System.Windows.Forms.Label
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents txtEMP_Web As System.Windows.Forms.TextBox
    Friend WithEvents txtCon_Email As System.Windows.Forms.TextBox
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents btnClearForm As System.Windows.Forms.Button
    Friend WithEvents txtCon_Phone As System.Windows.Forms.MaskedTextBox
End Class
