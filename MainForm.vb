Imports System.Configuration
Imports System.Data.SqlServerCe
Imports System.Timers 'need this for the 5 minute inactivity timer


Public Class MainForm
    ' Implements IMessageFilter 'need for 5 minute inactivity timer
    Public _adminlevel As String

    Public Property adminlevel() As String   ' basically passing the admin level from the login.vb
        Get
            Return _adminlevel
        End Get
        Set(ByVal Value As String)
            _adminlevel = Value

        End Set
    End Property

    'timer1 is our inactivity timer. after 5 minutes it dispose of main form and ask user to log in again.
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Static SecondsCount As Integer 'Counts each second
    '    SecondsCount += 1 'Increment

    '    If SecondsCount > 3000 Then 'if inactive for 5 minutes, dispose of the main form. Ask User to re-login
    '        Timer1.Enabled = False
    '        UserLogin.BringToFront()
    '        Me.Dispose()
    '    End If
    'End Sub

    'Public Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements System.Windows.Forms.IMessageFilter.PreFilterMessage

    '    'Check for mouse movements and / or clicks
    '    Dim mouse As Boolean = (m.Msg >= &H200 And m.Msg <= &H20D) Or (m.Msg >= &HA0 And m.Msg <= &HAD)

    '    'Check for keyboard button presses
    '    Dim kbd As Boolean = (m.Msg >= &H100 And m.Msg <= &H109)

    '    If mouse Or kbd Then 'if any of these events occur
    '        If Not Timer1.Enabled Then MessageBox.Show("Waking up") 'wake up
    '        Timer1.Enabled = False
    '        Timer1.Enabled = True

    '        Return True

    '    Else
    '        Return False
    '    End If
    'End Function


    Private con As New SqlCeConnection
    Private Shared ConnectionString As String

    Private Sub MyBase_KeyDown(Sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StatusBar1.Enabled = True

        IsMdiContainer = True

        If Me.adminlevel = "ADMIN" Then
            ADMINISTRATIONToolStripMenuItem.Visible = True
            VIEWToolStripMenuItem.Visible = True
        Else
            ADMINISTRATIONToolStripMenuItem.Visible = False
            VIEWToolStripMenuItem.Visible = False
        End If

        Try
            con.ConnectionString = My.Settings.DBConnectionString
            con.Open()

        Catch ex As Exception
            MessageBox.Show(con.State)

        End Try
        'open the survey.vb form to start.
        Dim myForm As Object
        myForm = New survey
        With myForm
            .MdiParent = Me
            .StartPosition = FormStartPosition.Manual
            .Location = New Point(0, 0)
            .Activate()
            .Show()
        End With
    End Sub

 


    Private Sub ADDEDITToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim myForm As Object
        myForm = New employer

        With myForm
            '.ConnectionString = My.Settings.JcsclienConnectionString1
            .MdiParent = Me
            .StartPosition = FormStartPosition.Manual
            .Location = New Point(0, 0)
            .Activate()
            .Show()
        End With

    End Sub

   
    
    
    Private Sub ADDREMOVEUSERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDREMOVEUSERSToolStripMenuItem.Click

        Dim myForm As Object
        myForm = New ADMIN___USERS

        With myForm
            .MdiParent = Me
            .StartPosition = FormStartPosition.Manual
            .Location = New Point(0, 0)
            .Activate()
            .Show()
        End With
    End Sub

    Private Sub ADDREMOVESKILLSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDREMOVESKILLSToolStripMenuItem.Click
        Dim myForm As Object
        myForm = New ADMIN_SKILLS

        With myForm
            .MdiParent = Me
            .StartPosition = FormStartPosition.Manual
            .Location = New Point(0, 0)
            .Activate()
            .Show()
        End With
    End Sub

    Private Sub ADDREMOVEJOBDESCRIPTIONSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDREMOVEJOBDESCRIPTIONSToolStripMenuItem.Click
         Dim myForm As Object
        myForm = New ADMIN_JOBS
        With myForm
            .MdiParent = Me
            .StartPosition = FormStartPosition.Manual
            .Location = New Point(0, 0)
            .Activate()
            '.TopMost = True
            .Show()
        End With

    End Sub

    Private Sub ADDREMOVEINTERNSHIPDATAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDREMOVEINTERNSHIPDATAToolStripMenuItem.Click
        Dim myForm As Object
        myForm = New ADMIN_INTERNSHIP
        With myForm
            .MdiParent = Me
            .StartPosition = FormStartPosition.Manual
            .Location = New Point(0, 0)
            .Activate()
            '.TopMost = True
            .Show()
        End With
    End Sub

    Private Sub FILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FILEToolStripMenuItem.Click
        Dim myForm As Object
        myForm = New survey

        ' Me.Text = "New Student Data"
        ' Dim intakeID As Integer = -1   'New Student
        'call a function to create a new intake record in the table, and pull out the new intake ID for use creating the service plans
        With myForm
            .MdiParent = Me
            .StartPosition = FormStartPosition.Manual
            .Location = New Point(0, 0)
            .Activate()
            .Show()
        End With
    End Sub

    Private Sub STUDENTREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDENTREPORTToolStripMenuItem.Click
        Dim myForm As Object
        myForm = New StudentReport
        With myForm
            .MdiParent = Me
            .StartPosition = FormStartPosition.Manual
            .Location = New Point(0, 0)
            .Activate()
            '.TopMost = True
            .Show()
        End With
    End Sub


    Private Sub EMPLOYERREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMPLOYERREPORTToolStripMenuItem.Click
        Dim myForm As Object
        myForm = New report2
        With myForm
            .MdiParent = Me
            .StartPosition = FormStartPosition.Manual
            .Location = New Point(0, 0)
            .Activate()
            '.TopMost = True
            .Show()
        End With
    End Sub

    Private Sub Form_Close(sender As Object, e As EventArgs) Handles Me.FormClosed
        Application.Exit()

    End Sub


End Class
