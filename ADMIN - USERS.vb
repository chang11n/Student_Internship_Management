Imports System.Configuration
Imports System.Data.SqlServerCe
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography


Public Class ADMIN___USERS
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
        refreshUserDGV()
        txtUSERNAME.Focus()
    End Sub
    Public Sub refreshUserDGV()
        Dim iRowCount As Integer = Nothing
        Dim iPlacementCount As Integer = Nothing
        Dim strSQL As String = "SELECT SID, USERNAME,USERTYPE FROM USERS;"
        UserDGV.Height = 35
        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If


            LoginDA = New SqlCeDataAdapter(strSQL, con)
            LoginDS = New DataSet
            iRowCount = LoginDA.Fill(LoginDS, "USERS")

            UserDGV.Rows().Clear()
            While iPlacementCount < iRowCount

                UserDGV.Rows.Add(LoginDS.Tables(0).Rows(iPlacementCount).Item("SID"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("USERNAME"),
                                 LoginDS.Tables(0).Rows(iPlacementCount).Item("USERTYPE"))


                UserDGV.Rows(iPlacementCount).Selected = False
                UserDGV.Height += 20
                iPlacementCount = iPlacementCount + 1
            End While
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally

            con.Close()
        End Try

        UserDGV.Sort(UserDGV.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub


    Function ManditoryFieldList() As Boolean

        Dim missingField() As Boolean = {False, False, False}
        Dim x As Boolean = False

        If IsNothing(txtUSERNAME.Text) Or txtUSERNAME.Text = String.Empty Then
            Label1.ForeColor = Color.Red
            missingField(0) = True
        Else
            Label1.ForeColor = Color.Black
            missingField(0) = False
        End If

        If IsNothing(txtPASSWORD.Text) Or txtPASSWORD.Text = String.Empty Then
            Label2.ForeColor = Color.Red
            missingField(1) = True
        Else
            Label2.ForeColor = Color.Black
            missingField(1) = False
        End If


        If IsNothing(cbUserlevel.Text) Or cbUserlevel.Text = String.Empty Then
            Label3.ForeColor = Color.Red
            missingField(2) = True
        Else
            Label3.ForeColor = Color.Black
            missingField(2) = False
        End If

        For i As Integer = 0 To 2
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


    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        If Not (ManditoryFieldList() = True) Then

        End If
        Dim cmdSQLText As String

        If iRecordID <= 0 Then
            cmdSQLText = "INSERT INTO USERS (USERNAME,PASSWORD,USERTYPE,SID) values (@USERNAME,@PASSWORD,@USERTYPE,@SID);"

            Try
                If con.State = 0 Then
                    con.ConnectionString = My.Settings.DBConnectionString
                    con.Open()
                End If

                Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear()
                With icmd.Parameters
                    .AddWithValue("USERNAME", SqlDbType.NVarChar).Value = If(IsNothing(txtUSERNAME.Text) Or txtUSERNAME.Text = String.Empty, DBNull.Value, txtUSERNAME.Text)
                    .AddWithValue("SID", SqlDbType.NVarChar).Value = If(IsNothing(cbUserlevel.Text) Or cbUserlevel.Text = String.Empty, DBNull.Value, txtSID.Text)
                    .AddWithValue("PASSWORD", SqlDbType.NVarChar).Value = If(IsNothing(txtPASSWORD) Or txtPASSWORD.Text = String.Empty, DBNull.Value, txtPASSWORD.Text)
                    .AddWithValue("USERTYPE", SqlDbType.NVarChar).Value = If(IsNothing(cbUserlevel.Text) Or cbUserlevel.Text = String.Empty, DBNull.Value, cbUserlevel.Text)

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
            cmdSQLText = "UPDATE USERS SET [USERNAME]=@USERNAME,[PASSWORD]=@PASSWORD,[USERTYPE]=@USERTYPE ,[SID]=@SID WHERE [ID]=@ID;"

            Try
                If con.State = 0 Then
                    con.ConnectionString = My.Settings.DBConnectionString
                    con.Open()
                End If

                Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear()
                With icmd.Parameters

                    .AddWithValue("USERNAME", SqlDbType.NVarChar).Value = If(IsNothing(txtUSERNAME.Text) Or txtUSERNAME.Text = String.Empty, DBNull.Value, txtUSERNAME.Text)
                    .AddWithValue("PASSWORD", SqlDbType.NVarChar).Value = If(IsNothing(txtPASSWORD) Or txtPASSWORD.Text = String.Empty, DBNull.Value, txtPASSWORD.Text)
                    .AddWithValue("USERTYPE", SqlDbType.NVarChar).Value = If(IsNothing(cbUserlevel.Text) Or cbUserlevel.Text = String.Empty, DBNull.Value, cbUserlevel.Text)
                    .AddWithValue("SID", SqlDbType.NVarChar).Value = If(IsNothing(txtSID.Text) Or txtSID.Text = String.Empty, DBNull.Value, txtSID.Text)

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
        refreshUserDGV()
        UserDGV.Sort(UserDGV.Columns(1), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub UserDGV_MouseHover(sender As Object, e As EventArgs) Handles UserDGV.MouseHover
        UserDGV.Focus()
    End Sub


    Private Sub UserDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDGV.CellMouseClick

        iRecordID = UserDGV.Item(0, UserDGV.CurrentRow.Index).Value
        txtSID.Text = UserDGV.Item(0, UserDGV.CurrentRow.Index).Value
        txtUSERNAME.Text = UserDGV.Item(1, UserDGV.CurrentRow.Index).Value
        txtPASSWORD.Text = UserDGV.Item(2, UserDGV.CurrentRow.Index).Value

        '  MsgBox(Me.UserDGV.CurrentCell.RowIndex)
        If UserDGV.Item(2, UserDGV.CurrentRow.Index).Value = "ADMIN" Then
            cbUserlevel.SelectedIndex = 0
        Else
            cbUserlevel.SelectedIndex = 1
        End If


    End Sub


    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim cmdSQLText As String = "delete from USERS  WHERE [SID]=@SID;"


        Dim result As Integer = MessageBox.Show("Are You Sure?", "Delete User", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            ' MessageBox.Show("Cancel pressed")
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


                    .AddWithValue("SID", SqlDbType.Int).Value = iRecordID



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

            refreshUserDGV()
            UserDGV.Sort(UserDGV.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        End If
        'clear the form
        txtUSERNAME.Text = String.Empty
        txtPASSWORD.Text = String.Empty
        cbUserlevel.SelectedIndex = -1
        txtSID.Text = String.Empty

    End Sub

  
End Class