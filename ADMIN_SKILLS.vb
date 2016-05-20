Imports System.Configuration
Imports System.Data.SqlServerCe
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography


Public Class ADMIN_SKILLS
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
        cbCATEGORY.Focus()
    End Sub
    Public Sub refreshUserDGV()
        Dim iRowCount As Integer = Nothing
        Dim iPlacementCount As Integer = Nothing
        Dim strSQL As String = "SELECT * FROM SKILLS;"
        SkillsDGV.Height = 35
        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If


            LoginDA = New SqlCeDataAdapter(strSQL, con)
            LoginDS = New DataSet
            iRowCount = LoginDA.Fill(LoginDS, "SKILLS")

            SkillsDGV.Rows().Clear()
            While iPlacementCount < iRowCount

                SkillsDGV.Rows.Add(LoginDS.Tables(0).Rows(iPlacementCount).Item("SKILL_ID"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("CATEGORY"),
                                 LoginDS.Tables(0).Rows(iPlacementCount).Item("SKILL"))


                SkillsDGV.Rows(iPlacementCount).Selected = False
                SkillsDGV.Height += 20
                iPlacementCount = iPlacementCount + 1
            End While
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally

            con.Close()
        End Try
        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If

            'preload Country comboboxes
            'define the SQL query that will populate the drop down box
            strSQL = "select distinct CATEGORY from SKILLS ORDER BY CATEGORY ASC;"

            Dim pprovda As New SqlCeDataAdapter(strSQL, con)
            Dim pprovds As New DataSet
            pprovda.Fill(pprovds, "CATEGORIES")
            With cbCATEGORY
                .DataSource = pprovds.Tables("CATEGORIES")
                .DisplayMember = "CATEGORY"
                .ValueMember = "CATEGORY"
                .SelectedIndex = -1
            End With
            pprovda.Dispose()
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally


        End Try
        SkillsDGV.Sort(SkillsDGV.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub


    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim cmdSQLText As String


        If iRecordID <= 0 Then
            cmdSQLText = "INSERT INTO SKILLS (CATEGORY,SKILL) values (@CATEGORY,@SKILL);"

            Try
                If con.State = 0 Then
                    con.ConnectionString = My.Settings.DBConnectionString
                    con.Open()
                End If

                Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear()
                With icmd.Parameters
                    
                    .AddWithValue("CATEGORY", SqlDbType.NVarChar).Value = If(IsNothing(cbCATEGORY.Text) Or cbCATEGORY.Text = String.Empty, DBNull.Value, cbCATEGORY.Text.ToUpper())
                    .AddWithValue("SKILL", SqlDbType.NVarChar).Value = If(IsNothing(txtSKILL) Or txtSKILL.Text = String.Empty, DBNull.Value, txtSKILL.Text.ToUpper())
                    
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
            cmdSQLText = "UPDATE SKILLS SET [CATEGORY]=@CATEGORY,[SKILL]=@SKILL WHERE [SKILL_ID]=@SKILL_ID;"

            Try
                If con.State = 0 Then
                    con.ConnectionString = My.Settings.DBConnectionString
                    con.Open()
                End If

                Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear()
                With icmd.Parameters

                    .AddWithValue("CATEGORY", SqlDbType.NVarChar).Value = If(IsNothing(cbCATEGORY.Text) Or cbCATEGORY.Text = String.Empty, DBNull.Value, cbCATEGORY.Text.ToUpper())
                    .AddWithValue("SKILL", SqlDbType.NVarChar).Value = If(IsNothing(txtSKILL) Or txtSKILL.Text = String.Empty, DBNull.Value, txtSKILL.Text.ToUpper())

                    .AddWithValue("SKILL_ID", SqlDbType.Int).Value = iRecordID



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
        SkillsDGV.Sort(SkillsDGV.Columns(1), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub UserDGV_MouseHover(sender As Object, e As EventArgs) Handles SkillsDGV.MouseHover
        SkillsDGV.Focus()
    End Sub


    Private Sub UserDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SkillsDGV.CellMouseClick

        iRecordID = SkillsDGV.Item(0, SkillsDGV.CurrentRow.Index).Value


        cbCATEGORY.Text = SkillsDGV.Item(1, SkillsDGV.CurrentRow.Index).Value

        txtSKILL.Text = SkillsDGV.Item(2, SkillsDGV.CurrentRow.Index).Value


    End Sub


    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim cmdSQLText As String = "delete from SKILLS  WHERE [SKILL_ID]=@SKILL_ID;"


        Dim result As Integer = MessageBox.Show("Are You Sure?", "Delete User", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cancel pressed")
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


                    .AddWithValue("SKILL_ID", SqlDbType.Int).Value = iRecordID



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
            SkillsDGV.Sort(SkillsDGV.Columns(2), System.ComponentModel.ListSortDirection.Descending)
        End If
        'clear the form
        cbCATEGORY.Text = String.Empty
        txtSKILL.Text = String.Empty
       
    End Sub

    
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class