Imports System.Configuration
Imports System.Data.SqlServerCe
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography


Public Class ADMIN_INTERNSHIP
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

            'preload intern types comboboxes
            'define the SQL query that will populate the drop down box
            Dim strSQL As String = "select * from INTERNSHIPS ORDER BY INTID ASC;"

            Dim pprovda As New SqlCeDataAdapter(strSQL, con)
            Dim pprovds As New DataSet
            pprovda.Fill(pprovds, "TYPES")
            With cbTYPE
                .DataSource = pprovds.Tables("TYPES")
                .DisplayMember = "TYPE"
                .ValueMember = "TYPE"
                .SelectedIndex = -1
            End With
            pprovda.Dispose()
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally


        End Try

       

        refreshINTERNSHIPDGV()
        cbTYPE.Focus()
    End Sub


    Function ManditoryFieldList() As Boolean

        Dim missingField() As Boolean = {False, False, False, False, False, False, False, False, False, False, False}
        Dim x As Boolean = False

        If IsNothing(cbTYPE.Text) Or cbTYPE.Text = String.Empty Then
            Label1.ForeColor = Color.Red
            missingField(0) = True
        Else
            Label1.ForeColor = Color.Black
            missingField(0) = False
        End If

        If IsNothing(txtCOMPANYNAME.Text) Or txtCOMPANYNAME.Text = String.Empty Then
            Label2.ForeColor = Color.Red
            missingField(1) = True
        Else
            Label2.ForeColor = Color.Black
            missingField(1) = False
        End If


        If IsNothing(txtADDRESS.Text) Or txtADDRESS.Text = String.Empty Then
            Label5.ForeColor = Color.Red
            missingField(2) = True
        Else
            Label5.ForeColor = Color.Black
            missingField(2) = False
        End If

        If IsNothing(txtCITY.Text) Or txtCITY.Text = String.Empty Then
            Label7.ForeColor = Color.Red
            missingField(3) = True
        Else
            Label7.ForeColor = Color.Black
            missingField(3) = False
        End If

        If IsNothing(txtPOSTAL.Text) Or txtPOSTAL.Text = String.Empty Then
            Label6.ForeColor = Color.Red
            missingField(4) = True
        Else
            Label6.ForeColor = Color.Black
            missingField(4) = False
        End If

        If IsNothing(txtCOUNTRY.Text) Or txtCOUNTRY.Text = "(   )    -" Then
            Label11.ForeColor = Color.Red
            missingField(5) = True
        Else
            Label11.ForeColor = Color.Black
            missingField(5) = False
        End If
        If IsNothing(txtCONTACTFNAME.Text) Or txtCONTACTFNAME.Text = String.Empty Then
            Label10.ForeColor = Color.Red
            missingField(6) = True
        Else
            Label10.ForeColor = Color.Black
            missingField(6) = False
        End If
        If IsNothing(txtCONTACTLNAME.Text) Or txtCONTACTLNAME.Text = String.Empty Then
            Label3.ForeColor = Color.Red
            missingField(7) = True
        Else
            Label3.ForeColor = Color.Black
            missingField(7) = False
        End If
        If IsNothing(txtPOSITION.Text) Or txtPOSITION.Text = String.Empty Then
            Label9.ForeColor = Color.Red
            missingField(8) = True
        Else
            Label9.ForeColor = Color.Black
            missingField(8) = False
        End If

        If IsNothing(txtPHONE.Text) Or txtPHONE.Text = String.Empty Then
            Label12.ForeColor = Color.Red
            missingField(9) = True
        Else
            Label12.ForeColor = Color.Black
            missingField(9) = False
        End If
        If IsNothing(txtWEBSITE.Text) Or txtWEBSITE.Text = String.Empty Then
            Label13.ForeColor = Color.Red
            missingField(10) = True
        Else
            Label13.ForeColor = Color.Black
            missingField(10) = False
        End If
       

        For i As Integer = 0 To 10
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


    Public Sub refreshINTERNSHIPDGV()
        Dim iRowCount As Integer = Nothing
        Dim iPlacementCount As Integer = Nothing
        Dim strSQL As String = "SELECT * FROM INTERNSHIP_TYPES;"
        INTERNSHIPDGV.Height = 35
        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If


            LoginDA = New SqlCeDataAdapter(strSQL, con)
            LoginDS = New DataSet
            iRowCount = LoginDA.Fill(LoginDS, "JOBS")

            INTERNSHIPDGV.Rows().Clear()
            While iPlacementCount < iRowCount

                INTERNSHIPDGV.Rows.Add(LoginDS.Tables(0).Rows(iPlacementCount).Item("ID"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("TYPE"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("COMPANYNAME"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("ADDRESS"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("CITY"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("POSTAL"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("COUNTRY"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("CONTACTFNAME"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("CONTACTLNAME"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("CONTACTPOSITION"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("TELEPHONE"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("WEBSITE"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("NOTES"))


                INTERNSHIPDGV.Rows(iPlacementCount).Selected = False
                INTERNSHIPDGV.Height += 20
                iPlacementCount = iPlacementCount + 1
            End While
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally

            con.Close()
        End Try

        INTERNSHIPDGV.Sort(INTERNSHIPDGV.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub


    Private Sub btnAddInternship_Click(sender As Object, e As EventArgs) Handles btnAddInternship.Click

        If Not (ManditoryFieldList() = True) Then


            Dim cmdSQLText As String

            If iRecordID <= 0 Then
                cmdSQLText = "INSERT INTO INTERNSHIP_TYPES ( TYPE,COMPANYNAME,ADDRESS,CITY,POSTAL,COUNTRY,CONTACTFNAME,CONTACTLNAME,CONTACTPOSITION,TELEPHONE,WEBSITE,NOTES) values ( @TYPE,@COMPANYNAME,@ADDRESS,@CITY,@POSTAL,@COUNTRY,@CONTACTFNAME,@CONTACTLNAME,@CONTACTPOSITION,@TELEPHONE,@WEBSITE,@NOTES);"

                Try
                    If con.State = 0 Then
                        con.ConnectionString = My.Settings.DBConnectionString
                        con.Open()
                    End If

                    Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                    icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                    icmd.Parameters.Clear()
                    With icmd.Parameters
                        .AddWithValue("TYPE", SqlDbType.NVarChar).Value = If(IsNothing(cbTYPE.Text) Or cbTYPE.Text = String.Empty, DBNull.Value, cbTYPE.Text.ToUpper())
                        .AddWithValue("COMPANYNAME", SqlDbType.NVarChar).Value = If(IsNothing(txtCOMPANYNAME) Or txtCOMPANYNAME.Text = String.Empty, DBNull.Value, txtCOMPANYNAME.Text.ToUpper())
                        .AddWithValue("ADDRESS", SqlDbType.NVarChar).Value = If(IsNothing(txtADDRESS.Text) Or txtADDRESS.Text = String.Empty, DBNull.Value, txtADDRESS.Text.ToUpper())
                        .AddWithValue("CITY", SqlDbType.NVarChar).Value = If(IsNothing(txtCITY.Text) Or txtCITY.Text = String.Empty, DBNull.Value, txtCITY.Text.ToUpper())
                        .AddWithValue("POSTAL", SqlDbType.NVarChar).Value = If(IsNothing(txtPOSTAL.Text) Or txtPOSTAL.Text = String.Empty, DBNull.Value, txtPOSTAL.Text.ToUpper())
                        .AddWithValue("COUNTRY", SqlDbType.NVarChar).Value = If(IsNothing(txtCOUNTRY.Text) Or txtCOUNTRY.Text = String.Empty, DBNull.Value, txtCOUNTRY.Text.ToUpper())
                        .AddWithValue("CONTACTFNAME", SqlDbType.NVarChar).Value = If(IsNothing(txtCONTACTFNAME.Text) Or txtCONTACTFNAME.Text = String.Empty, DBNull.Value, txtCONTACTFNAME.Text.ToUpper())
                        .AddWithValue("CONTACTLNAME", SqlDbType.NVarChar).Value = If(IsNothing(txtCONTACTLNAME.Text) Or txtCONTACTLNAME.Text = String.Empty, DBNull.Value, txtCONTACTLNAME.Text.ToUpper())
                        .AddWithValue("CONTACTPOSITION", SqlDbType.NVarChar).Value = If(IsNothing(txtPOSITION.Text) Or txtPOSITION.Text = String.Empty, DBNull.Value, txtPOSITION.Text.ToUpper())
                        .AddWithValue("TELEPHONE", SqlDbType.NVarChar).Value = If(IsNothing(txtPHONE.Text) Or txtPHONE.Text = String.Empty, DBNull.Value, txtPHONE.Text)
                        .AddWithValue("WEBSITE", SqlDbType.NVarChar).Value = If(IsNothing(txtWEBSITE.Text) Or txtWEBSITE.Text = String.Empty, DBNull.Value, txtWEBSITE.Text.ToUpper())
                        .AddWithValue("NOTES", SqlDbType.NVarChar).Value = If(IsNothing(txtNOTES.Text) Or txtNOTES.Text = String.Empty, DBNull.Value, txtNOTES.Text.ToUpper())

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

                cmdSQLText = "UPDATE INTERNSHIP_TYPE SET [TYPE]=@TYPE,[COMPANYNAME]=@COMPANYNAME,[ADDRESS]=@ADDRESS,[CITY]=@CITY,[POSTAL]=@POSTAL,[COUNTRY]=@COUNTRY,[CONTACTFNAME]=@CONTACTFNAME,[CONTACTLNAME]=@CONTACTLNAME,[CONTACTPHONE]=@CONTACTPOSITION,[TELEPHONE]=@TELEPHONE,[WEBSITE]=@WEBSITE,[NOTES]=@NOTES WHERE [ID]=@ID;"

                Try
                    If con.State = 0 Then
                        con.ConnectionString = My.Settings.DBConnectionString
                        con.Open()
                    End If

                    Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                    icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                    icmd.Parameters.Clear()
                    With icmd.Parameters

                        .AddWithValue("TYPE", SqlDbType.NVarChar).Value = If(IsNothing(cbTYPE.Text) Or cbTYPE.Text = String.Empty, DBNull.Value, cbTYPE.Text.ToUpper())
                        .AddWithValue("COMPANYNAME", SqlDbType.NVarChar).Value = If(IsNothing(txtCOMPANYNAME) Or txtCOMPANYNAME.Text = String.Empty, DBNull.Value, txtCOMPANYNAME.Text.ToUpper())
                        .AddWithValue("ADDRESS", SqlDbType.NVarChar).Value = If(IsNothing(txtADDRESS.Text) Or txtADDRESS.Text = String.Empty, DBNull.Value, txtADDRESS.Text.ToUpper())
                        .AddWithValue("CITY", SqlDbType.NVarChar).Value = If(IsNothing(txtCITY.Text) Or txtCITY.Text = String.Empty, DBNull.Value, txtCITY.Text.ToUpper())
                        .AddWithValue("POSTAL", SqlDbType.NVarChar).Value = If(IsNothing(txtPOSTAL.Text) Or txtPOSTAL.Text = String.Empty, DBNull.Value, txtPOSTAL.Text.ToUpper())
                        .AddWithValue("COUNTRY", SqlDbType.NVarChar).Value = If(IsNothing(txtCOUNTRY.Text) Or txtCOUNTRY.Text = String.Empty, DBNull.Value, txtCOUNTRY.Text.ToUpper())
                        .AddWithValue("CONTACTFNAME", SqlDbType.NVarChar).Value = If(IsNothing(txtCONTACTFNAME.Text) Or txtCONTACTFNAME.Text = String.Empty, DBNull.Value, txtCONTACTFNAME.Text.ToUpper())
                        .AddWithValue("CONTACTLNAME", SqlDbType.NVarChar).Value = If(IsNothing(txtCONTACTLNAME.Text) Or txtCONTACTLNAME.Text = String.Empty, DBNull.Value, txtCONTACTLNAME.Text.ToUpper())
                        .AddWithValue("CONTACTPOSITION", SqlDbType.NVarChar).Value = If(IsNothing(txtPOSITION.Text) Or txtPOSITION.Text = String.Empty, DBNull.Value, txtPOSITION.Text.ToUpper())
                        .AddWithValue("TELEPHONE", SqlDbType.NVarChar).Value = If(IsNothing(txtPHONE.Text) Or txtPHONE.Text = String.Empty, DBNull.Value, txtPHONE.Text)
                        .AddWithValue("WEBSITE", SqlDbType.NVarChar).Value = If(IsNothing(txtWEBSITE.Text) Or txtWEBSITE.Text = String.Empty, DBNull.Value, txtWEBSITE.Text.ToUpper())
                        .AddWithValue("NOTES", SqlDbType.NVarChar).Value = If(IsNothing(txtNOTES.Text) Or txtNOTES.Text = String.Empty, DBNull.Value, txtNOTES.Text.ToUpper())

                        .AddWithValue("ID", SqlDbType.Int).Value = iRecordID



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
            refreshINTERNSHIPDGV()
            INTERNSHIPDGV.Sort(INTERNSHIPDGV.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub INTERNSHIPDGV_MouseHover(sender As Object, e As EventArgs) Handles INTERNSHIPDGV.MouseHover
        INTERNSHIPDGV.Focus()
    End Sub



    Private Sub INTERNSHIPDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles INTERNSHIPDGV.CellMouseClick
        iRecordID = INTERNSHIPDGV.Item(0, INTERNSHIPDGV.CurrentRow.Index).Value

        cbTYPE.Text = If(IsDBNull(INTERNSHIPDGV.Item(1, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(1, INTERNSHIPDGV.CurrentRow.Index).Value)
        txtCOMPANYNAME.Text = If(IsDBNull(INTERNSHIPDGV.Item(2, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(2, INTERNSHIPDGV.CurrentRow.Index).Value)
        txtADDRESS.Text = If(IsDBNull(INTERNSHIPDGV.Item(3, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(3, INTERNSHIPDGV.CurrentRow.Index).Value)
        txtCITY.Text = If(IsDBNull(INTERNSHIPDGV.Item(4, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(4, INTERNSHIPDGV.CurrentRow.Index).Value)
        txtPOSTAL.Text = If(IsDBNull(INTERNSHIPDGV.Item(5, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(5, INTERNSHIPDGV.CurrentRow.Index).Value)
        txtCOUNTRY.Text = If(IsDBNull(INTERNSHIPDGV.Item(6, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(6, INTERNSHIPDGV.CurrentRow.Index).Value)
        txtCONTACTFNAME.Text = If(IsDBNull(INTERNSHIPDGV.Item(7, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(7, INTERNSHIPDGV.CurrentRow.Index).Value)
        txtCONTACTLNAME.Text = If(IsDBNull(INTERNSHIPDGV.Item(8, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(8, INTERNSHIPDGV.CurrentRow.Index).Value)
        txtPOSITION.Text = If(IsDBNull(INTERNSHIPDGV.Item(9, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(9, INTERNSHIPDGV.CurrentRow.Index).Value)
        txtPHONE.Text = If(IsDBNull(INTERNSHIPDGV.Item(10, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(10, INTERNSHIPDGV.CurrentRow.Index).Value)
        txtWEBSITE.Text = If(IsDBNull(INTERNSHIPDGV.Item(11, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(11, INTERNSHIPDGV.CurrentRow.Index).Value)
        txtNOTES.Text = If(IsDBNull(INTERNSHIPDGV.Item(12, INTERNSHIPDGV.CurrentRow.Index).Value), String.Empty, INTERNSHIPDGV.Item(12, INTERNSHIPDGV.CurrentRow.Index).Value)


    End Sub

    'Private Sub INTERNSHIPDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles INTERNSHIPDGV.CellMouseClick

    '    iRecordID = INTERNSHIPDGV.Item(0, INTERNSHIPDGV.CurrentRow.Index).Value
    '    cbTYPE.Text = INTERNSHIPDGV.Item(1, INTERNSHIPDGV.CurrentRow.Index).Value
    '    MsgBox(iRecordID)
    '    MsgBox(INTERNSHIPDGV.CurrentRow.Index)
    '    ' Dim iRowCount As Integer = Nothing
    '    ' Dim iPlacementCount As Integer = Nothing



    '    txtCOMPANYNAME.Text = INTERNSHIPDGV.Item(2, INTERNSHIPDGV.CurrentRow.Index).Value
    '    txtADDRESS.Text = INTERNSHIPDGV.Item(3, INTERNSHIPDGV.CurrentRow.Index).Value
    '    txtCITY.Text = INTERNSHIPDGV.Item(4, INTERNSHIPDGV.CurrentRow.Index).Value
    '    txtPOSTAL.Text = INTERNSHIPDGV.Item(5, INTERNSHIPDGV.CurrentRow.Index).Value
    '    txtCOUNTRY.Text = INTERNSHIPDGV.Item(6, INTERNSHIPDGV.CurrentRow.Index).Value
    '    txtCONTACTFNAME.Text = INTERNSHIPDGV.Item(7, INTERNSHIPDGV.CurrentRow.Index).Value
    '    txtCONTACTLNAME.Text = INTERNSHIPDGV.Item(8, INTERNSHIPDGV.CurrentRow.Index).Value
    '    txtPOSITION.Text = INTERNSHIPDGV.Item(9, INTERNSHIPDGV.CurrentRow.Index).Value
    '    MsgBox(iRecordID)
    '    txtPHONE.Text = INTERNSHIPDGV.Item(10, INTERNSHIPDGV.CurrentRow.Index).Value
    '    txtWEBSITE.Text = INTERNSHIPDGV.Item(11, INTERNSHIPDGV.CurrentRow.Index).Value
    '    'txtNOTES.Text = INTERNSHIPDGV.Item(12, INTERNSHIPDGV.CurrentRow.Index).Value
    '    'txtNOTES.Text = If(Not (IsNothing(INTERNSHIPDGV.Item(12, INTERNSHIPDGV.CurrentRow.Index).Value)) = String.Empty, DBNull.Value, INTERNSHIPDGV.Item(12, INTERNSHIPDGV.CurrentRow.Index).Value)
    '    MsgBox(INTERNSHIPDGV.CurrentRow.Index)
    '    If (IsNothing(INTERNSHIPDGV.Item(12, INTERNSHIPDGV.CurrentRow.Index).Value)) Then
    '        txtNOTES.Text = String.Empty
    '    Else
    '        txtNOTES = INTERNSHIPDGV.Item(12, INTERNSHIPDGV.CurrentRow.Index).Value
    '    End If

    '            'If JobsDGV.Item(2, JobsDGV.CurrentRow.Index).Value = "ADMIN" Then
    '            '    cbUserlevel.SelectedIndex = 0
    '            'Else
    '            '    cbUserlevel.SelectedIndex = 1
    '            'End If

    'End Sub


    Private Sub btnDeleteiNTERNSHIP_Click(sender As Object, e As EventArgs) Handles btnDeleteInternship.Click
        Dim cmdSQLText As String = "delete from INTERNSHIP_TYPES  WHERE [ID]=@ID;"


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


                    .AddWithValue("ID", SqlDbType.Int).Value = iRecordID



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

            refreshINTERNSHIPDGV()
            INTERNSHIPDGV.Sort(INTERNSHIPDGV.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        End If
        'clear the form
        cbTYPE.Text = String.Empty
        txtCOMPANYNAME.Text = String.Empty
        txtADDRESS.Text = String.Empty
        txtCITY.Text = String.Empty
        txtPOSTAL.Text = String.Empty
        txtCOUNTRY.Text = String.Empty
        txtCONTACTFNAME.Text = String.Empty
        txtCONTACTLNAME.Text = String.Empty
        txtPOSITION.Text = String.Empty
        txtPHONE.Text = String.Empty
        txtWEBSITE.Text = String.Empty
        txtNOTES.Text = String.Empty
    End Sub


End Class