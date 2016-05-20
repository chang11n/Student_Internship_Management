Imports System.Configuration
Imports System.Data.SqlServerCe

Public Class UserLogin


    Private con As New SqlCeConnection
    Private Shared ConnectionString As String


    Dim LoginDA As SqlCeDataAdapter
    Dim LoginDS As DataSet

   
    Private Sub MyBase_KeyDown(Sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub
    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Get number of processes of you program
        If Process.GetProcessesByName _
          (Process.GetCurrentProcess.ProcessName).Length > 1 Then

            MessageBox.Show _
             ("Another Instance of Internship Manager is already running", _
                 "Multiple Instances Forbidden", _
                  MessageBoxButtons.OK, _
                 MessageBoxIcon.Exclamation)
            Application.Exit()
        End If

    End Sub


    Private Sub LOGINCOMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LOGINCOMBO.SelectedIndexChanged
        If Not (LOGINCOMBO.SelectedIndex = -1) Then


            If txtUsername.Text = String.Empty Or txtPassword.Text = String.Empty Or LOGINCOMBO.Text = String.Empty Then
                MessageBox.Show("Sorry, Login Data incomplete.")
            Else



                Dim loginDA As SqlCeDataAdapter
                Dim LoginDS As DataSet

                Dim iRowCount As Integer = Nothing

                Dim strSQL As String = "SELECT * from USERS where USERNAME='" & txtUsername.Text & "';"
                Try
                    If con.State = 0 Then
                        con.ConnectionString = My.Settings.DBConnectionString
                        con.Open()
                    End If


                    loginDA = New SqlCeDataAdapter(strSQL, con)
                    LoginDS = New DataSet
                    iRowCount = loginDA.Fill(LoginDS, "Login")
                    If LoginDS.Tables(0).Rows(0).Item("USERNAME") = txtUsername.Text And LoginDS.Tables(0).Rows(0).Item("PASSWORD") = txtPassword.Text And LoginDS.Tables(0).Rows(0).Item("USERTYPE") = LOGINCOMBO.Text Then
                        Dim myForm As Object
                        myForm = New MainForm

                        txtUsername.Text = String.Empty
                        txtPassword.Text = String.Empty
                        LOGINCOMBO.SelectedIndex = -1
                        With myForm
                            .adminlevel = LoginDS.Tables(0).Rows(0).Item("USERTYPE")
                            .StartPosition = FormStartPosition.Manual
                            .Location = New Point(0, 0)
                            .Activate()
                            .Show()
                        End With

                    Else
                        MessageBox.Show("Incorrect Login Parameters.")
                    End If
                Catch ex2 As Exception
                    MessageBox.Show(ex2.Message)

                Finally
                    con.Close()  'get in, get info, get out.
                End Try

            End If
        End If

    End Sub

    
End Class