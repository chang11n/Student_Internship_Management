Imports System.Configuration
Imports System.Data.SqlServerCe
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography


Public Class ADMIN_JOBS
    Private con As New SqlCeConnection
    Private Shared ConnectionString As String
    Dim LoginDS As DataSet
    Dim LoginDA As SqlCeDataAdapter
    Dim iRecordID As Integer
    Private Sub MyBase_KeyDown(Sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub
    Private Sub ADMIN___USERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If

            'preload JOBGROUP comboboxes
            'define the SQL query that will populate the drop down box
            Dim strSQL As String = "select * from JOBGROUPS ORDER BY JGID ASC;"

            Dim pprovda As New SqlCeDataAdapter(strSQL, con)
            Dim pprovds As New DataSet
            pprovda.Fill(pprovds, "JOBGROUPS")
            With cbJOBGROUP
                .DataSource = pprovds.Tables("JOBGROUPS")
                .DisplayMember = "JOBGROUP"
                .ValueMember = "JOBGROUP"
                .SelectedIndex = -1
            End With
            pprovda.Dispose()


            '*************** LOADING EMPOLYER LIST from Empolyer table
            Dim strSQL2 As String = "select distinct COMPANYNAME from INTERNSHIP_TYPES ORDER BY COMPANYNAME ASC;"

            Dim employerda As New SqlCeDataAdapter(strSQL2, con)
            Dim employerds As New DataSet
            employerda.Fill(employerds, "INTERNSHIP_TYPES")
            With cbSearchCompany
                .DataSource = employerds.Tables("INTERNSHIP_TYPES")
                .DisplayMember = "COMPANYNAME"
                .ValueMember = "COMPANYNAME"
                .SelectedIndex = -1
            End With
            employerda.Dispose()

        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally


        End Try

        refreshJobDGV()
        cbJOBGROUP.Focus()
    End Sub

    Function ManditoryFieldList() As Boolean

        Dim missingField() As Boolean = {False, False, False, False, False, False, False}
        Dim x As Boolean = False

        If IsNothing(cbJOBGROUP.Text) Or cbJOBGROUP.Text = String.Empty Then
            Label1.ForeColor = Color.Red
            missingField(0) = True
        Else
            Label1.ForeColor = Color.Black
            missingField(0) = False
        End If

        If IsNothing(cbTYPE.Text) Or cbTYPE.Text = String.Empty Then
            Label3.ForeColor = Color.Red
            missingField(1) = True
        Else
            Label3.ForeColor = Color.Black
            missingField(1) = False
        End If

        If IsNothing(txtPOSITION.Text) Or txtPOSITION.Text = String.Empty Then
            Label2.ForeColor = Color.Red
            missingField(2) = True
        Else
            Label2.ForeColor = Color.Black
            missingField(2) = False
        End If

        If IsNothing(txtDESCRIPTION.Text) Or txtDESCRIPTION.Text = String.Empty Then
            Label5.ForeColor = Color.Red
            missingField(3) = True
        Else
            Label5.ForeColor = Color.Black
            missingField(3) = False
        End If

        If IsNothing(txtRESPONSIBILITIES.Text) Or txtRESPONSIBILITIES.Text = String.Empty Then
            Label7.ForeColor = Color.Red
            missingField(4) = True
        Else
            Label7.ForeColor = Color.Black
            missingField(4) = False
        End If

        If IsNothing(txtREQUIREMENTS.Text) Or txtREQUIREMENTS.Text = String.Empty Then
            Label6.ForeColor = Color.Red
            missingField(5) = True
        Else
            Label6.ForeColor = Color.Black
            missingField(5) = False
        End If

        If IsNothing(txtSALARY.Text) Or txtSALARY.Text = String.Empty Then
            Label8.ForeColor = Color.Red
            missingField(6) = True
        Else
            Label8.ForeColor = Color.Black
            missingField(6) = False
        End If



        For i As Integer = 0 To 6
            If (missingField(i) = True) Then
                x = True
            End If
        Next
        If x = True Then
            Return True
        Else
            Return False

        End If

    End Function

    

    Public Sub refreshJobDGV()
        Dim iRowCount As Integer = Nothing
        Dim iPlacementCount As Integer = Nothing
        Dim strSQL As String = "SELECT * FROM JOBS;"
        JobsDGV.Height = 35
        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If


            LoginDA = New SqlCeDataAdapter(strSQL, con)
            LoginDS = New DataSet
            iRowCount = LoginDA.Fill(LoginDS, "JOBS")

            JobsDGV.Rows().Clear()
            While iPlacementCount < iRowCount

                JobsDGV.Rows.Add(LoginDS.Tables(0).Rows(iPlacementCount).Item("JID"),
                                 LoginDS.Tables(0).Rows(iPlacementCount).Item("JOBGROUP"),
                                 LoginDS.Tables(0).Rows(iPlacementCount).Item("POSITION"),
                                 LoginDS.Tables(0).Rows(iPlacementCount).Item("REQUIREMENTS"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("DESCRIPTION"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("RESPONSIBILITIES"),
                                 LoginDS.Tables(0).Rows(iPlacementCount).Item("SALARY"))


                JobsDGV.Rows(iPlacementCount).Selected = False
                JobsDGV.Height += 20
                iPlacementCount = iPlacementCount + 1
            End While
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally

            con.Close()
        End Try

        JobsDGV.Sort(JobsDGV.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub
    Private Sub btnAddJob_Click(sender As Object, e As EventArgs) Handles btnAddJob.Click

        If Not (ManditoryFieldList() = True) Then


            Dim cmdSQLText As String


            If iRecordID <= 0 Then
                cmdSQLText = "INSERT INTO JOBS (JOBGROUP,POSITION,DESCRIPTION,RESPONSIBILITIES,REQUIREMENTS,SALARY,INTERNSHIP_TYPE) values (@JOBGROUP,@POSITION,@DESCRIPTION,@RESPONSIBILITIES,@REQUIREMENTS,@SALARY,@INTERNSHIP_TYPE);"

                Try
                    If con.State = 0 Then
                        con.ConnectionString = My.Settings.DBConnectionString
                        con.Open()
                    End If

                    Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                    icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                    icmd.Parameters.Clear()
                    With icmd.Parameters

                        .AddWithValue("JOBGROUP", SqlDbType.NVarChar).Value = If(IsNothing(cbJOBGROUP.Text) Or cbJOBGROUP.Text = String.Empty, DBNull.Value, cbJOBGROUP.Text)
                        .AddWithValue("POSITION", SqlDbType.NVarChar).Value = If(IsNothing(txtPOSITION) Or txtPOSITION.Text = String.Empty, DBNull.Value, txtPOSITION.Text.ToUpper())
                        .AddWithValue("DESCRIPTION", SqlDbType.NVarChar).Value = If(IsNothing(txtDESCRIPTION.Text) Or txtDESCRIPTION.Text = String.Empty, DBNull.Value, txtDESCRIPTION.Text.ToUpper())
                        .AddWithValue("RESPONSIBILITIES", SqlDbType.NVarChar).Value = If(IsNothing(txtRESPONSIBILITIES.Text) Or txtRESPONSIBILITIES.Text = String.Empty, DBNull.Value, txtRESPONSIBILITIES.Text.ToUpper())
                        .AddWithValue("REQUIREMENTS", SqlDbType.NVarChar).Value = If(IsNothing(txtREQUIREMENTS.Text) Or txtREQUIREMENTS.Text = String.Empty, DBNull.Value, txtREQUIREMENTS.Text.ToUpper())
                        .AddWithValue("SALARY", SqlDbType.NVarChar).Value = If(IsNothing(txtSALARY.Text) Or txtSALARY.Text = String.Empty, DBNull.Value, txtSALARY.Text)
                        .AddWithValue("INTERNSHIP_TYPE", SqlDbType.NVarChar).Value = If(IsNothing(cbTYPE.Text) Or cbTYPE.Text = String.Empty, DBNull.Value, cbTYPE.Text.ToUpper())

                    End With

                    icmd.CommandText = cmdSQLText
                    Dim iRowsAffected As Integer
                    iRowsAffected = icmd.ExecuteNonQuery()

                    MainForm.StatusBar1.Text = iRowsAffected & " record updated."


                    icmd.Parameters.Clear() 'get the ID of the last record written so we can save it to the service plan table
                    icmd.CommandText = "Select @@Identity"
                    iRecordID = icmd.ExecuteScalar 'The ID will be returned.           

                    icmd.Parameters.Clear()
                    icmd.Dispose()

                Catch ex2 As Exception
                    MessageBox.Show(ex2.Message)

                Finally

                    con.Close()
                End Try
            Else
                cmdSQLText = "UPDATE JOBS SET [JOBGROUP]=@JOBGROUP,[POSITION]=@POSITION,[DESCRIPTION]=@DESCRIPTION,[RESPONSIBILITIES]=@RESPONSIBILITIES,[REQUIREMENTS]=@REQUIREMENTS,[SALARY]=@SALARY,[INTERNSHIP_TYPE]=@INTERNSHIP_TYPE WHERE [JID]=@JID;"

                Try
                    If con.State = 0 Then
                        con.ConnectionString = My.Settings.DBConnectionString
                        con.Open()
                    End If

                    Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                    icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                    icmd.Parameters.Clear()
                    With icmd.Parameters

                        .AddWithValue("JOBGROUP", SqlDbType.Int).Value = If(IsNothing(cbJOBGROUP.Text) Or cbJOBGROUP.Text = String.Empty, DBNull.Value, cbJOBGROUP.Text)
                        .AddWithValue("POSITION", SqlDbType.NVarChar).Value = If(IsNothing(txtPOSITION) Or txtPOSITION.Text = String.Empty, DBNull.Value, txtPOSITION.Text.ToUpper())
                        .AddWithValue("DESCRIPTION", SqlDbType.NVarChar).Value = If(IsNothing(txtDESCRIPTION.Text) Or txtDESCRIPTION.Text = String.Empty, DBNull.Value, txtDESCRIPTION.Text.ToUpper())
                        .AddWithValue("RESPONSIBILITIES", SqlDbType.NVarChar).Value = If(IsNothing(txtRESPONSIBILITIES.Text) Or txtRESPONSIBILITIES.Text = String.Empty, DBNull.Value, txtRESPONSIBILITIES.Text.ToUpper())
                        .AddWithValue("REQUIREMENTS", SqlDbType.NVarChar).Value = If(IsNothing(txtREQUIREMENTS.Text) Or txtREQUIREMENTS.Text = String.Empty, DBNull.Value, txtREQUIREMENTS.Text.ToUpper())
                        .AddWithValue("SALARY", SqlDbType.NVarChar).Value = If(IsNothing(txtSALARY.Text) Or txtSALARY.Text = String.Empty, DBNull.Value, txtSALARY.Text)
                        .AddWithValue("INTERNSHIP_TYPE", SqlDbType.NVarChar).Value = If(IsNothing(cbTYPE.Text) Or cbTYPE.Text = String.Empty, DBNull.Value, cbTYPE.Text.ToUpper())
                        .AddWithValue("JID", SqlDbType.Int).Value = iRecordID



                    End With


                    icmd.CommandText = cmdSQLText

                    Dim iRowsAffected As Integer = icmd.ExecuteNonQuery()
                    If iRowsAffected > 0 Then
                        MainForm.StatusBar1.Text = iRowsAffected & " row(s) updated."

                    Else : MainForm.StatusBar1.Text = iRowsAffected & " row(s) updated."


                    End If
                    icmd.Parameters.Clear() 'get the ID of the last record written so we can save it to the service plan table


                    icmd.Dispose()

                Catch ex2 As Exception
                    MessageBox.Show(ex2.Message)

                Finally
                    con.Close()
                End Try
            End If
            refreshJobDGV()
            JobsDGV.Sort(JobsDGV.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub JobsDGV_MouseHover(sender As Object, e As EventArgs) Handles JobsDGV.MouseHover
        JobsDGV.Focus()
    End Sub


    Private Sub JobsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles JobsDGV.CellMouseClick
        iRecordID = JobsDGV.Item(0, JobsDGV.CurrentRow.Index).Value
 
        'cbTYPE.Text = If(IsDBNull(JobsDGV.Item(1, JobsDGV.CurrentRow.Index).Value), String.Empty, JobsDGV.Item(1, JobsDGV.CurrentRow.Index).Value)
        cbJOBGROUP.Text = If(IsDBNull(JobsDGV.Item(1, JobsDGV.CurrentRow.Index).Value), String.Empty, JobsDGV.Item(1, JobsDGV.CurrentRow.Index).Value)
        txtDESCRIPTION.Text = If(IsDBNull(JobsDGV.Item(4, JobsDGV.CurrentRow.Index).Value), String.Empty, JobsDGV.Item(4, JobsDGV.CurrentRow.Index).Value)
        txtPOSITION.Text = If(IsDBNull(JobsDGV.Item(2, JobsDGV.CurrentRow.Index).Value), String.Empty, JobsDGV.Item(2, JobsDGV.CurrentRow.Index).Value)
        txtREQUIREMENTS.Text = If(IsDBNull(JobsDGV.Item(3, JobsDGV.CurrentRow.Index).Value), String.Empty, JobsDGV.Item(3, JobsDGV.CurrentRow.Index).Value)
        txtRESPONSIBILITIES.Text = If(IsDBNull(JobsDGV.Item(5, JobsDGV.CurrentRow.Index).Value), String.Empty, JobsDGV.Item(5, JobsDGV.CurrentRow.Index).Value)
        txtSALARY.Text = If(IsDBNull(JobsDGV.Item(6, JobsDGV.CurrentRow.Index).Value), String.Empty, JobsDGV.Item(6, JobsDGV.CurrentRow.Index).Value)

    End Sub

    

    Private Sub btnDeleteJob_Click(sender As Object, e As EventArgs) Handles btnDeleteJob.Click
        Dim cmdSQLText As String = "delete from JOBS  WHERE [JID]=@JID;"


        Dim result As Integer = MessageBox.Show("Are You Sure?", "Delete Job", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then


            Try
                If con.State = 0 Then
                    con.ConnectionString = My.Settings.DBConnectionString
                    con.Open()
                End If

                Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear()
                With icmd.Parameters


                    .AddWithValue("JID", SqlDbType.Int).Value = iRecordID



                End With


                icmd.CommandText = cmdSQLText

                Dim iRowsAffected As Integer = icmd.ExecuteNonQuery()

                MainForm.StatusBar1.Text = iRowsAffected & " user deleted."


                icmd.Parameters.Clear()

                icmd.Dispose()

            Catch ex2 As Exception
                MessageBox.Show(ex2.Message)

            Finally
                con.Close()
            End Try

            refreshJobDGV()
            JobsDGV.Sort(JobsDGV.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        End If
        'clear the form
        cbJOBGROUP.Text = String.Empty
        txtPOSITION.Text = String.Empty
        cbJOBGROUP.SelectedIndex = -1
        txtDESCRIPTION.Text = String.Empty
        txtPOSITION.Text = String.Empty
        txtREQUIREMENTS.Text = String.Empty
        txtRESPONSIBILITIES.Text = String.Empty
        txtSALARY.Text = String.Empty
    End Sub

    
   
    Private Sub cbTYPE_Click(sender As Object, e As EventArgs) Handles cbTYPE.Click
        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If

            'preload Country comboboxes
            'define the SQL query that will populate the drop down box
            Dim strSQL As String = "select TYPE from INTERNSHIPS ORDER BY TYPE ASC;"

            Dim pprovda As New SqlCeDataAdapter(strSQL, con)
            Dim pprovds As New DataSet
            pprovda.Fill(pprovds, "TYPE")
            With cbTYPE
                .DataSource = pprovds.Tables("TYPE")
                .DisplayMember = "TYPE"
                .ValueMember = "TYPE"
                .SelectedIndex = -1
            End With
            pprovda.Dispose()
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally


        End Try

    End Sub

  
End Class