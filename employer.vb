Imports System.Configuration
Imports System.Data.SqlServerCe
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions


Public Class employer
    Private con As New SqlCeConnection
    Private Shared ConnectionString As String
    Dim iRecordID As Integer = 0
    Private Sub employer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'preload the country dropdown

        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If

            'preload Country comboboxes
            'define the SQL query that will populate the drop down box
            Dim strSQL As String = "select * from country ORDER BY name ASC;"

            Dim pprovda As New SqlCeDataAdapter(strSQL, con)
            Dim pprovds As New DataSet
            pprovda.Fill(pprovds, "country")
            With cbxEMP_Country
                .DataSource = pprovds.Tables("country")
                .DisplayMember = "name"
                .ValueMember = "name"
                .SelectedIndex = -1
            End With
            pprovda.Dispose()
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally


        End Try

        btnUPDATE.Visible = False

    End Sub









    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)

        If emailAddressMatch.Success Then
            Return True
        Else : Return False
        End If

    End Function


    Private Sub txtCon_Email_Validated(sender As Object, e As EventArgs) Handles txtCon_Email.Validated
        If EmailAddressCheck(txtCon_Email.Text) = False Then
            txtCon_Email.Focus()
            MessageBox.Show("Please Enter A Valid Email!")
            txtCon_Email.Clear()

        End If
    End Sub


    Private Sub subSave()
        Dim cmdSQLText As String


        If iRecordID <= 0 Then
            cmdSQLText = "INSERT INTO Empolyer (Emp_Code,Emp_Name,Emp_Address,Emp_City,Emp_Country,Con_Fname,Con_Lname,Con_Position,Con_Phone,Con_Email,Emp_Website,Emp_PostCode) values (@Emp_Code,@Emp_Name,@Emp_Address,@Emp_City,@Emp_Country,@Con_Fname,@Con_Lname,@Con_Position,@Con_Phone,@Con_Email,@Emp_Website,@Emp_PostCode);"

            Try
                If con.State = 0 Then
                    con.ConnectionString = My.Settings.DBConnectionString
                    con.Open()
                End If

                Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear()
                With icmd.Parameters

                    .AddWithValue("Emp_Code", SqlDbType.NVarChar).Value = If(IsNothing(txtEMP_Code.Text) Or txtEMP_Code.Text = String.Empty, DBNull.Value, txtEMP_Code.Text)
                    .AddWithValue("Emp_Name", SqlDbType.NVarChar).Value = If(IsNothing(txtEMP_Name.Text) Or txtEMP_Name.Text = String.Empty, DBNull.Value, txtEMP_Name.Text)
                    .AddWithValue("Emp_Address", SqlDbType.NVarChar).Value = If(IsNothing(txtEMP_Address.Text) Or txtEMP_Address.Text = String.Empty, DBNull.Value, txtEMP_Address.Text)
                    .AddWithValue("Emp_City", SqlDbType.NVarChar).Value = If(IsNothing(cbxEMP_City.Text) Or cbxEMP_City.Text = String.Empty, DBNull.Value, cbxEMP_City.Text)
                    .AddWithValue("Emp_Country", SqlDbType.NVarChar).Value = If(IsNothing(cbxEMP_Country.Text) Or cbxEMP_Country.Text = String.Empty, DBNull.Value, cbxEMP_Country.Text)
                    .AddWithValue("Con_Fname", SqlDbType.NVarChar).Value = If(IsNothing(txtCon_Fname.Text) Or txtCon_Fname.Text = String.Empty, DBNull.Value, txtCon_Fname.Text)
                    .AddWithValue("Con_Lname", SqlDbType.NVarChar).Value = If(IsNothing(txtCon_Lname.Text) Or txtCon_Lname.Text = String.Empty, DBNull.Value, txtCon_Lname.Text)
                    .AddWithValue("Con_Position", SqlDbType.NVarChar).Value = If(IsNothing(txtCon_Position.Text) Or txtCon_Position.Text = String.Empty, DBNull.Value, txtCon_Position.Text)
                    .AddWithValue("Con_Phone", SqlDbType.NVarChar).Value = If(IsNothing(txtCon_Phone.Text) Or txtCon_Phone.Text = String.Empty, DBNull.Value, txtCon_Phone.Text)
                    .AddWithValue("Con_Email", SqlDbType.NVarChar).Value = If(IsNothing(txtCon_Email.Text) Or txtCon_Email.Text = String.Empty, DBNull.Value, txtCon_Email.Text)
                    .AddWithValue("Emp_Website", SqlDbType.NVarChar).Value = If(IsNothing(txtEMP_Web.Text) Or txtEMP_Web.Text = String.Empty, DBNull.Value, txtEMP_Web.Text)
                    .AddWithValue("Emp_PostCode", SqlDbType.NVarChar).Value = If(IsNothing(txtEMP_PostCode.Text) Or txtEMP_PostCode.Text = String.Empty, DBNull.Value, txtEMP_PostCode.Text)
                End With

                icmd.CommandText = cmdSQLText
                Dim iRowsAffected As Integer
                iRowsAffected = icmd.ExecuteNonQuery()
                If iRowsAffected > 0 Then
                    MessageBox.Show(iRowsAffected & " record updated.")
                Else : MessageBox.Show("NO records updated")

                End If

                icmd.Parameters.Clear() 'get the ID of the last record written so we can save it to the service plan table
                icmd.CommandText = "Select @@Identity"
                iRecordID = icmd.ExecuteScalar 'The ID will be returned.           

                icmd.Parameters.Clear()
                icmd.Dispose()

            Catch ex2 As Exception
                MessageBox.Show(ex2.Message)

            Finally
                btnSAVE.Visible = False
                btnUPDATE.Visible = True
                con.Close()
            End Try
        Else
            cmdSQLText = "UPDATE Empolyer SET [Emp_Code]=@Emp_Code,[Emp_Name]=@Emp_Name,[Emp_Address]=@Emp_Address,[Emp_City]=@Emp_City,[Emp_Country]=@Emp_Country,[Con_Fname]=@Con_Fname,[Con_Lname]=@Con_Lname,[Con_Position]=@Con_Position,[Con_Phone]=@Con_Phone,[Con_Email]=@Con_Email,[Emp_Website]=@Emp_Website,[Emp_PostCode]=@Emp_PostCode  WHERE [ID]=@ID;"
            'cmdSQLText = "UPDATE Empolyer SET [Emp_Code]=@Emp_Code,[Emp_Name]=@Emp_Name,[Emp_Address]=@Emp_Address,[Emp_City]=@Emp_City,[Emp_Country]=@Emp_Country,[Con_Fname]=@Con_Fname,[Con_Lname]=@Con_Lname,[Con_Position]=@Con_Position,[Con_Phone]=@Con_Phone,[Con_Email]=@Con_Email,[Emp_Website]=@Emp_Website,[Emp_PostCode]=@Emp_PostCode  WHERE [ID]=@ID;"

            Try
                If con.State = 0 Then
                    con.ConnectionString = My.Settings.DBConnectionString
                    con.Open()
                End If

                Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear()
                With icmd.Parameters

                    .AddWithValue("Emp_Code", SqlDbType.NVarChar).Value = If(IsNothing(txtEMP_Code.Text) Or txtEMP_Code.Text = String.Empty, DBNull.Value, txtEMP_Code.Text)
                    .AddWithValue("Emp_Name", SqlDbType.NVarChar).Value = If(IsNothing(txtEMP_Name.Text) Or txtEMP_Name.Text = String.Empty, DBNull.Value, txtEMP_Name.Text)
                    .AddWithValue("Emp_Address", SqlDbType.NVarChar).Value = If(IsNothing(txtEMP_Address.Text) Or txtEMP_Address.Text = String.Empty, DBNull.Value, txtEMP_Address.Text)
                    .AddWithValue("Emp_City", SqlDbType.NVarChar).Value = If(IsNothing(cbxEMP_City.Text) Or cbxEMP_City.Text = String.Empty, DBNull.Value, cbxEMP_City.Text)
                    .AddWithValue("Emp_Country", SqlDbType.NVarChar).Value = If(IsNothing(cbxEMP_Country.Text) Or cbxEMP_Country.Text = String.Empty, DBNull.Value, cbxEMP_Country.Text)
                    .AddWithValue("Con_Fname", SqlDbType.NVarChar).Value = If(IsNothing(txtCon_Fname.Text) Or txtCon_Fname.Text = String.Empty, DBNull.Value, txtCon_Fname.Text)
                    .AddWithValue("Con_Lname", SqlDbType.NVarChar).Value = If(IsNothing(txtCon_Lname.Text) Or txtCon_Lname.Text = String.Empty, DBNull.Value, txtCon_Lname.Text)
                    .AddWithValue("Con_Position", SqlDbType.NVarChar).Value = If(IsNothing(txtCon_Position.Text) Or txtCon_Position.Text = String.Empty, DBNull.Value, txtCon_Position.Text)
                    .AddWithValue("Con_Phone", SqlDbType.NVarChar).Value = If(IsNothing(txtCon_Phone.Text) Or txtCon_Phone.Text = String.Empty, DBNull.Value, txtCon_Phone.Text)
                    .AddWithValue("Con_Email", SqlDbType.NVarChar).Value = If(IsNothing(txtCon_Email.Text) Or txtCon_Email.Text = String.Empty, DBNull.Value, txtCon_Email.Text)
                    .AddWithValue("Emp_Website", SqlDbType.NVarChar).Value = If(IsNothing(txtEMP_Web.Text) Or txtEMP_Web.Text = String.Empty, DBNull.Value, txtEMP_Web.Text)
                    .AddWithValue("Emp_PostCode", SqlDbType.NVarChar).Value = If(IsNothing(txtEMP_PostCode.Text) Or txtEMP_PostCode.Text = String.Empty, DBNull.Value, txtEMP_PostCode.Text)
                    .AddWithValue("ID", SqlDbType.Int).Value = iRecordID
                End With

                icmd.CommandText = cmdSQLText

                Dim iRowsAffected As Integer = icmd.ExecuteNonQuery()
                If iRowsAffected > 0 Then
                    MessageBox.Show(iRowsAffected & " record updated.")
                Else : MessageBox.Show("NO records updated")

                End If
                icmd.Parameters.Clear() 'get the ID of the last record written so we can save it to the service plan table

                icmd.Dispose()

            Catch ex2 As Exception
                MessageBox.Show(ex2.Message)

            Finally
                con.Close()
            End Try
        End If
    End Sub


    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        subSave()
    End Sub


    Private Sub txtEMP_Code_LostFocus(sender As Object, e As EventArgs) Handles txtEMP_Code.LostFocus


        If txtEMP_Code.TextLength < 4 Or txtEMP_Code.TextLength > 4 Then
            txtEMP_Code.BackColor = Color.Red

            txtEMP_Code.Focus()
        Else
            txtEMP_Code.BackColor = Color.White
            ''****************************************************************************************************************
            ''this module of code reads responds to the txtEMP_Code.LostFocus() trigger. 
            ''Once we have either entered or hit tab, the trigger is fired, and the record for that student is 
            ''loaded if it exists. If no records exist, then it is assumed that this is a new entry. 
            ''set a record counter to 0 
            Dim intRecordCount As Integer = 0
            ''if the database connection is closed, then open it and prepare to read.

            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If

            '' define the SQL query to read the data for the student, based on the SID primary key. 

            Dim strSQL As String
            strSQL = "SELECT * FROM Empolyer WHERE Emp_Code='" & txtEMP_Code.Text & "';"
            MessageBox.Show(strSQL)

            '' create an SQL data adapter 
            Dim EmployerDA As New SqlCeDataAdapter(strSQL, con)

            ''dimension our data set 
            Dim EmployerDS As New DataSet
            ''fill the dataset using our data adapter and record the record count 
            intRecordCount = EmployerDA.Fill(EmployerDS, "Employer")
            ''dispose of the data adapter (garbage disposal) 
            EmployerDA.Dispose()
            ''close the connection to the database 
            con.Close()
            '' if a record exists, then populate the form, otherwise it is a new entry into the system. 

            'grab the old Record ID so should an update occur, we can deal with it properly.
              If intRecordCount > 0 Then 'show all data in the form 
                iRecordID = EmployerDS.Tables(0).Rows(0).Item(12)

                btnSAVE.Visible = False
                btnUPDATE.Visible = True
                ' You will have to grab all the form data using the query, and 
                ' grabbing data from all tables to populate 
                ' all of the controls related to the student. 


                txtEMP_Name.Text = EmployerDS.Tables(0).Rows(0).Item(1)
                txtEMP_Address.Text = EmployerDS.Tables(0).Rows(0).Item(2)
                cbxEMP_City.Text = EmployerDS.Tables(0).Rows(0).Item(3)
                cbxEMP_Country.Text = EmployerDS.Tables(0).Rows(0).Item(4)
                txtCon_Fname.Text = EmployerDS.Tables(0).Rows(0).Item(5)
                txtCon_Lname.Text = EmployerDS.Tables(0).Rows(0).Item(6)
                txtCon_Position.Text = EmployerDS.Tables(0).Rows(0).Item(7)
                txtCon_Phone.Text = EmployerDS.Tables(0).Rows(0).Item(8)
                txtCon_Email.Text = EmployerDS.Tables(0).Rows(0).Item(9)
                txtEMP_Web.Text = EmployerDS.Tables(0).Rows(0).Item(10)
                txtEMP_PostCode.Text = EmployerDS.Tables(0).Rows(0).Item(11)


            Else
                Console.WriteLine("no records found")
                ' no record exists, so assume they are creating a new record and do nothing. 

            End If
        End If
    End Sub


    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        subSave()
    End Sub


    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        'this button clears the form and sets it up for a new student entry
        iRecordID = -1

        txtEMP_Code.Text = String.Empty
        txtEMP_Name.Text = String.Empty
        txtEMP_Address.Text = String.Empty
        cbxEMP_City.Text = String.Empty
        ' DGV_Grad.Rows.Clear()
        ' DGV_Undergrad.Rows.Clear()
        cbxEMP_Country.Text = String.Empty
        txtCon_Fname.Text = String.Empty
        txtCon_Lname.Text = String.Empty
        txtCon_Position.Text = String.Empty
        txtCon_Phone.Text = String.Empty
        txtCon_Email.Text = String.Empty
        txtEMP_Web.Text = String.Empty
        txtEMP_PostCode.Text = String.Empty

        btnSAVE.Visible = True
        btnUPDATE.Visible = False


    End Sub

   
End Class