<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STUDENTREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMPLOYERREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINISTRATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDREMOVEINTERNSHIPDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDREMOVEJOBDESCRIPTIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDREMOVESKILLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDREMOVEUSERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.ADMINISTRATIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1307, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.FILEToolStripMenuItem.Text = "STUDENT"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STUDENTREPORTToolStripMenuItem, Me.EMPLOYERREPORTToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.VIEWToolStripMenuItem.Text = "REPORTS"
        '
        'STUDENTREPORTToolStripMenuItem
        '
        Me.STUDENTREPORTToolStripMenuItem.Name = "STUDENTREPORTToolStripMenuItem"
        Me.STUDENTREPORTToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.STUDENTREPORTToolStripMenuItem.Text = "STUDENT REPORT"
        '
        'EMPLOYERREPORTToolStripMenuItem
        '
        Me.EMPLOYERREPORTToolStripMenuItem.Name = "EMPLOYERREPORTToolStripMenuItem"
        Me.EMPLOYERREPORTToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.EMPLOYERREPORTToolStripMenuItem.Text = "EMPLOYER REPORT"
        '
        'ADMINISTRATIONToolStripMenuItem
        '
        Me.ADMINISTRATIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDREMOVEINTERNSHIPDATAToolStripMenuItem, Me.ADDREMOVEJOBDESCRIPTIONSToolStripMenuItem, Me.ADDREMOVESKILLSToolStripMenuItem, Me.ADDREMOVEUSERSToolStripMenuItem})
        Me.ADMINISTRATIONToolStripMenuItem.Name = "ADMINISTRATIONToolStripMenuItem"
        Me.ADMINISTRATIONToolStripMenuItem.Size = New System.Drawing.Size(143, 24)
        Me.ADMINISTRATIONToolStripMenuItem.Text = "ADMINISTRATION"
        '
        'ADDREMOVEINTERNSHIPDATAToolStripMenuItem
        '
        Me.ADDREMOVEINTERNSHIPDATAToolStripMenuItem.Name = "ADDREMOVEINTERNSHIPDATAToolStripMenuItem"
        Me.ADDREMOVEINTERNSHIPDATAToolStripMenuItem.Size = New System.Drawing.Size(306, 24)
        Me.ADDREMOVEINTERNSHIPDATAToolStripMenuItem.Text = "ADD/REMOVE INTERNSHIP DATA"
        '
        'ADDREMOVEJOBDESCRIPTIONSToolStripMenuItem
        '
        Me.ADDREMOVEJOBDESCRIPTIONSToolStripMenuItem.Name = "ADDREMOVEJOBDESCRIPTIONSToolStripMenuItem"
        Me.ADDREMOVEJOBDESCRIPTIONSToolStripMenuItem.Size = New System.Drawing.Size(306, 24)
        Me.ADDREMOVEJOBDESCRIPTIONSToolStripMenuItem.Text = "ADD/REMOVE JOB DESCRIPTIONS"
        '
        'ADDREMOVESKILLSToolStripMenuItem
        '
        Me.ADDREMOVESKILLSToolStripMenuItem.Name = "ADDREMOVESKILLSToolStripMenuItem"
        Me.ADDREMOVESKILLSToolStripMenuItem.Size = New System.Drawing.Size(306, 24)
        Me.ADDREMOVESKILLSToolStripMenuItem.Text = "ADD/REMOVE SKILLS"
        '
        'ADDREMOVEUSERSToolStripMenuItem
        '
        Me.ADDREMOVEUSERSToolStripMenuItem.Name = "ADDREMOVEUSERSToolStripMenuItem"
        Me.ADDREMOVEUSERSToolStripMenuItem.Size = New System.Drawing.Size(306, 24)
        Me.ADDREMOVEUSERSToolStripMenuItem.Text = "ADD/REMOVE USERS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 5
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 658)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(1307, 22)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = 6
        Me.StatusBar1.Text = "StatusBar1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1307, 680)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "INTERNSHIP MANAGEMENT SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents ADMINISTRATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDREMOVEINTERNSHIPDATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDREMOVEJOBDESCRIPTIONSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDREMOVESKILLSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDREMOVEUSERSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents STUDENTREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMPLOYERREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
