Imports System.Configuration
Imports System.Data.SqlServerCe
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class survey

    Public _adminlevel As String

    Public Property adminlevel() As String   ' basically passing the admin level from the login.vb
        Get
            Return _adminlevel
        End Get
        Set(ByVal Value As String)
            _adminlevel = Value

        End Set
    End Property

    'USER LOGIN DATASET
    Private LoginDA As SqlCeDataAdapter
    Private LoginDS As DataSet

    'WORKING HISTORY DATASET
    Private EmpHistDA As SqlCeDataAdapter
    Private EmpHistDS As DataSet

    'EDUCATION HISTORY DATASET
    Private EduHistDA As SqlCeDataAdapter
    Private EduHistDS As DataSet

    'CONNECT TO INTERNSHIP_SYS.SDF DATABASE
    Private con As New SqlCeConnection
    Private Shared ConnectionString As String

    Dim iRecordID As Integer = 0


    'WHEN SURVERY.VB LOAD....
    Private Sub survey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MAKE LABLE lblCopyPlacementMessage invisible
        lblCopyPlacementMessage.Visible = False

        '***************************

        'If Me.adminlevel = "ADMIN" Then
        '    btnHIRE.Visible = True
        '    btnAddPlacement.Visible = True

        'Else
        '    btnHIRE.Visible = False
        '    btnAddPlacement.Visible = False
        'End If


        'SET the working experience form DISABLE 
        GroupBox2.Enabled = False
        'SET JOB STARTDATE
        dtpStartDate.Format = DateTimePickerFormat.Custom
        dtpStartDate.CustomFormat = " "
        dtpStartDate.Value = Date.FromOADate(0)
        dtpStartDate.Enabled = False
        'SET EDUCATION STARTDATE
        dtpEdDate.Format = DateTimePickerFormat.Custom
        dtpEdDate.CustomFormat = " "
        dtpEdDate.Value = Date.FromOADate(0)
        dtpEdDate.Enabled = True

        'TODO: This line of code loads data into the 'Internship_sysDataSet.Empolyer' table. You can move, or remove it, as needed.
        ' Me.EmpolyerTableAdapter.Fill(Me.Internship_sysDataSet.Empolyer)
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
            With cbxCountry
                .DataSource = pprovds.Tables("country")
                .DisplayMember = "name"
                .ValueMember = "name"
                .SelectedIndex = -1
            End With
            pprovda.Dispose()

            'preloading the internship dropdown table
            strSQL = "select TYPE from INTERNSHIPS ORDER BY TYPE ASC;"
            Dim inttypeda As New SqlCeDataAdapter(strSQL, con)
            Dim inttypeds As New DataSet
            inttypeda.Fill(inttypeds, "Internships")
            With cbInternshipType
                .DataSource = inttypeds.Tables("Internships")
                .DisplayMember = "TYPE"
                .ValueMember = "TYPE"
                .SelectedIndex = -1
            End With
            inttypeda.Dispose()



        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally

        End Try



        btnUPDATE.Visible = False
        Personal_info.Enabled = False
        Edu_Trainging.Enabled = False
        GroupBox2.Enabled = False
        Experience.Enabled = False
    End Sub



    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)

        If emailAddressMatch.Success Then
            Return True
        Else : Return False
        End If

    End Function


    Private Sub txtEmail_Validated(sender As Object, e As EventArgs) Handles txtEmail.Validated
        If EmailAddressCheck(txtEmail.Text) = False Then
            txtEmail.Focus()
            MessageBox.Show("Please Enter A Valid Email!")
            txtEmail.Clear()

        End If

    End Sub




    Private Sub subSave()
        Dim cmdSQLText As String

        If iRecordID <= 0 Then
            cmdSQLText = "INSERT INTO personal (SID,Semesta,F_Name,M_Name,L_Name,Email,Phone,Status,Gender,Year,Country,Internstatus) values (@SID,@Semesta,@F_Name,@M_Name,@L_Name,@Email,@Phone,@Status,@Gender,@Year,@Country,@Internstatus);"

            Try
                If con.State = 0 Then
                    con.ConnectionString = My.Settings.DBConnectionString
                    con.Open()
                End If

                Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear() 'clear the form

                With icmd.Parameters
                    .AddWithValue("SID", SqlDbType.NVarChar).Value = If(IsNothing(txtSID.Text) Or txtSID.Text = String.Empty, DBNull.Value, txtSID.Text)
                    .AddWithValue("Semesta", SqlDbType.NVarChar).Value = If(IsNothing(cbxSemReg.Text) Or cbxSemReg.Text = String.Empty, DBNull.Value, cbxSemReg.Text)
                    .AddWithValue("F_Name", SqlDbType.NVarChar).Value = If(IsNothing(txtFName.Text) Or txtFName.Text = String.Empty, DBNull.Value, txtFName.Text.ToUpper())
                    .AddWithValue("M_Name", SqlDbType.NVarChar).Value = If(IsNothing(txtMName.Text) Or txtMName.Text = String.Empty, DBNull.Value, txtMName.Text.ToUpper())
                    .AddWithValue("L_Name", SqlDbType.NVarChar).Value = If(IsNothing(txtLName.Text) Or txtLName.Text = String.Empty, DBNull.Value, txtLName.Text.ToUpper())
                    .AddWithValue("Email", SqlDbType.NVarChar).Value = If(IsNothing(txtEmail.Text) Or txtEmail.Text = String.Empty, DBNull.Value, txtEmail.Text.ToUpper())
                    .AddWithValue("Phone", SqlDbType.NVarChar).Value = If(IsNothing(txtPhone.Text) Or txtPhone.Text = String.Empty, DBNull.Value, txtPhone.Text)
                    .AddWithValue("Status", SqlDbType.NVarChar).Value = If(IsNothing(cbxStatus.Text) Or cbxStatus.Text = String.Empty, DBNull.Value, cbxStatus.Text.ToUpper())
                    .AddWithValue("Gender", SqlDbType.NVarChar).Value = If(IsNothing(cbxGender.Text) Or cbxGender.Text = String.Empty, DBNull.Value, cbxGender.Text.ToUpper())
                    .AddWithValue("Year", SqlDbType.NVarChar).Value = If(IsNothing(txtYearReg.Text) Or txtYearReg.Text = String.Empty, DBNull.Value, txtYearReg.Text)
                    .AddWithValue("Country", SqlDbType.NVarChar).Value = If(IsNothing(cbxCountry.Text) Or cbxCountry.Text = String.Empty, DBNull.Value, cbxCountry.Text.ToUpper())
                    .AddWithValue("Internstatus", SqlDbType.NVarChar).Value = If((CheckBox1.Checked = True), "AVAILABLE", "HIRED")

                End With


                icmd.CommandText = cmdSQLText
                Dim iRowsAffected As Integer
                iRowsAffected = icmd.ExecuteNonQuery()
                If iRowsAffected > 0 Then
                    MessageBox.Show(iRowsAffected & " record updated.")
                Else : MessageBox.Show("NO records updated")

                End If

                icmd.Parameters.Clear() 'get the ID of the last record written so we can save it to the table
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
            cmdSQLText = "UPDATE personal SET [SID]=@SID,[Semesta]=@Semesta,[F_Name]=@F_Name,[M_Name]=@M_Name,[L_Name]=@L_Name,[Email]=@Email,[Phone]=@Phone,[Status]=@Status,[Gender]=@Gender,[Year]=@Year,[Country]=@Country,[Internstatus]=@Internstatus WHERE [ID]=@ID;"

            Try
                If con.State = 0 Then
                    con.ConnectionString = My.Settings.DBConnectionString
                    con.Open()
                End If

                Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear()
                With icmd.Parameters

                    .AddWithValue("SID", SqlDbType.NVarChar).Value = If(IsNothing(txtSID.Text) Or txtSID.Text = String.Empty, DBNull.Value, txtSID.Text)
                    .AddWithValue("Semesta", SqlDbType.NVarChar).Value = If(IsNothing(cbxSemReg.Text) Or cbxSemReg.Text = String.Empty, DBNull.Value, cbxSemReg.Text)
                    .AddWithValue("F_Name", SqlDbType.NVarChar).Value = If(IsNothing(txtFName.Text) Or txtFName.Text = String.Empty, DBNull.Value, txtFName.Text.ToUpper())
                    .AddWithValue("M_Name", SqlDbType.NVarChar).Value = If(IsNothing(txtMName.Text) Or txtMName.Text = String.Empty, DBNull.Value, txtMName.Text.ToUpper())
                    .AddWithValue("L_Name", SqlDbType.NVarChar).Value = If(IsNothing(txtLName.Text) Or txtLName.Text = String.Empty, DBNull.Value, txtLName.Text.ToUpper())
                    .AddWithValue("Email", SqlDbType.NVarChar).Value = If(IsNothing(txtEmail.Text) Or txtEmail.Text = String.Empty, DBNull.Value, txtEmail.Text.ToUpper())
                    .AddWithValue("Phone", SqlDbType.NVarChar).Value = If(IsNothing(txtPhone.Text) Or txtPhone.Text = String.Empty, DBNull.Value, txtPhone.Text)
                    .AddWithValue("Status", SqlDbType.NVarChar).Value = If(IsNothing(cbxStatus.Text) Or cbxStatus.Text = String.Empty, DBNull.Value, cbxStatus.Text.ToUpper())
                    .AddWithValue("Gender", SqlDbType.NVarChar).Value = If(IsNothing(cbxGender.Text) Or cbxGender.Text = String.Empty, DBNull.Value, cbxGender.Text.ToUpper())
                    .AddWithValue("Year", SqlDbType.NVarChar).Value = If(IsNothing(txtYearReg.Text) Or txtYearReg.Text = String.Empty, DBNull.Value, txtYearReg.Text)
                    .AddWithValue("Country", SqlDbType.NVarChar).Value = If(IsNothing(cbxCountry.Text) Or cbxCountry.Text = String.Empty, DBNull.Value, cbxCountry.Text.ToUpper())
                    .AddWithValue("Internstatus", SqlDbType.NVarChar).Value = If((CheckBox1.Checked = True), "AVAILABLE", "HIRED")

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


    End Sub

    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        If Not (ManditoryFieldList() = True) Then
            subSave()
        Else
            MsgBox("Please complete the missing information before saving.")
        End If

    End Sub



    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        If Not (ManditoryFieldList() = True) Then
            subSave()
        Else
            MsgBox("Please complete the missing information before saving.")

        End If

    End Sub

    'ManditoryFieldList returns true if manditory fields are missing, false otherwise.
    ' using an array of false fields, it will place a true only if the field is not completed.
    ' if field is incomplete turn the label to red, otherwise turn label to black.
    ' loop through the array, and if any errors still exist, then dont allow the SAVE to occur
    Function ManditoryFieldList() As Boolean

        Dim missingField() As Boolean = {False, False, False, False, False, False, False, False, False, False}
        Dim x As Boolean = False

        If IsNothing(cbxSemReg.Text) Or cbxSemReg.Text = String.Empty Then
            lblSemReg.ForeColor = Color.Red
            missingField(0) = True
        Else
            lblSemReg.ForeColor = Color.Black
            missingField(0) = False
        End If

        If IsNothing(txtYearReg.Text) Or txtYearReg.Text = String.Empty Then
            lblYearReg.ForeColor = Color.Red
            missingField(1) = True
        Else
            lblYearReg.ForeColor = Color.Black
            missingField(1) = False
        End If


        If IsNothing(txtFName.Text) Or txtFName.Text = String.Empty Then
            lblFName.ForeColor = Color.Red
            missingField(2) = True
        Else
            lblFName.ForeColor = Color.Black
            missingField(2) = False
        End If

        If IsNothing(txtLName.Text) Or txtLName.Text = String.Empty Then
            lblLName.ForeColor = Color.Red
            missingField(4) = True
        Else
            lblLName.ForeColor = Color.Black
            missingField(4) = False
        End If

        If IsNothing(txtEmail.Text) Or txtEmail.Text = String.Empty Then
            lblEmail.ForeColor = Color.Red
            missingField(5) = True
        Else
            lblEmail.ForeColor = Color.Black
            missingField(5) = False
        End If

        If IsNothing(txtPhone.Text) Or txtPhone.Text = "(   )    -" Then
            lblPhone.ForeColor = Color.Red
            missingField(6) = True
        Else
            lblPhone.ForeColor = Color.Black
            missingField(6) = False
        End If
        If IsNothing(cbxCountry.Text) Or cbxCountry.Text = String.Empty Then
            lblCountry.ForeColor = Color.Red
            missingField(7) = True
        Else
            lblCountry.ForeColor = Color.Black
            missingField(7) = False
        End If
        If IsNothing(cbxStatus.Text) Or cbxStatus.Text = String.Empty Then
            lblStatus.ForeColor = Color.Red
            missingField(8) = True
        Else
            lblStatus.ForeColor = Color.Black
            missingField(8) = False
        End If
        If IsNothing(cbxGender.Text) Or cbxGender.Text = String.Empty Then
            lblGender.ForeColor = Color.Red
            missingField(9) = True
        Else
            lblGender.ForeColor = Color.Black
            missingField(9) = False
        End If

        For i As Integer = 0 To 9
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






    Private Sub txtSID_LostFocus(sender As Object, e As EventArgs) Handles txtSID.LostFocus

        'check the SID length 
        If Not (txtSID.TextLength) = 9 Then
            txtSID.BackColor = Color.Red

            txtSID.Focus() 'if the SID !=9 then focus on txtSID 
        Else

            'SET EDUCATION & TRAINING GROUPBOX ENABLED
            Edu_Trainging.Enabled = True
            Experience.Enabled = True
            Personal_info.Enabled = True
            txtSID.BackColor = Color.White
            ''****************************************************************************************************************
            ''this module of code reads responds to the txtSID.LostFocus() trigger. 
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
            strSQL = "SELECT * FROM personal  WHERE SID='" & txtSID.Text & "';"


            '' create an SQL data adapter 
            Dim PersonalDA As New SqlCeDataAdapter(strSQL, con)

            ''dimension our data set 
            Dim PersonalDS As New DataSet
            ''fill the dataset using our data adapter and record the record count 
            intRecordCount = PersonalDA.Fill(PersonalDS, "personal")
            ''dispose of the data adapter (garbage disposal) 
            PersonalDA.Dispose()
            ''close the connection to the database 
            con.Close()

            '' if a record exists, then populate the form, otherwise it is a new entry into the system. 
            If intRecordCount > 0 Then 'show all data in the form 
                MainForm.StatusBar1.Text = "Records Found..."
                btnSAVE.Visible = False
                btnUPDATE.Visible = True
                ' You will have to grab all the form data using the query, and 
                ' grabbing data from all tables to populate 
                ' all of the controls related to the student. 
                iRecordID = PersonalDS.Tables(0).Rows(0).Item(11)

                cbxSemReg.Text = PersonalDS.Tables(0).Rows(0).Item(1)
                txtFName.Text = PersonalDS.Tables(0).Rows(0).Item(2)
                txtMName.Text = If(IsDBNull(PersonalDS.Tables(0).Rows(0).Item(3)), String.Empty, PersonalDS.Tables(0).Rows(0).Item(3))
                txtLName.Text = PersonalDS.Tables(0).Rows(0).Item(4)
                txtEmail.Text = PersonalDS.Tables(0).Rows(0).Item(5)
                txtPhone.Text = PersonalDS.Tables(0).Rows(0).Item(6)
                cbxStatus.Text = PersonalDS.Tables(0).Rows(0).Item(7)

                'check what the (checkbox)internship status is: "NULL";"AVAILABLE";"HIRED"
                If IsDBNull(PersonalDS.Tables(0).Rows(0).Item(12)) Then
                    CheckBox1.Checked = True    'AVAILABLE
                    CheckBox2.Checked = False      'HIRED
                ElseIf PersonalDS.Tables(0).Rows(0).Item(12) = "HIRED" Then
                    CheckBox1.Checked = False   'AVAILABLE
                    CheckBox2.Checked = True   'HIRED
                Else  'ElseIf PersonalDS.Tables(0).Rows(0).Item(12) = "AVAILABLE" Then
                    CheckBox1.Checked = True    'AVAILABLE
                    CheckBox2.Checked = False      'HIRED
                End If
                cbxGender.Text = PersonalDS.Tables(0).Rows(0).Item(8)
                txtYearReg.Text = PersonalDS.Tables(0).Rows(0).Item(9)
                cbxCountry.Text = PersonalDS.Tables(0).Rows(0).Item(10)

                If IsNothing(PersonalDS.Tables(0).Rows(0).Item("Internstatus")) Then
                    CheckBox1.Checked = True
                    CheckBox2.Checked = False
                End If

                'grab all data from Edu_Training Table
                'DataGridView1.Rows.Add()
                'DataGridView1.Item(0, 
                refreshEmpHistDGV()
                refreshDGV_Undergrad()
            Else

                '**********************************************??????????????????????????????
                MainForm.StatusBar1.Text = "No Records Found..."
                ' no record exists, so assume users are creating a new record and do nothing. 
            End If
        End If
    End Sub



    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click

        'this button clears the form and sets it up for a new student entry
        iRecordID = -1 'set iRecord = no record ID
        txtFName.Text = String.Empty
        txtLName.Text = String.Empty
        txtMName.Text = String.Empty


        EmpHistDGV.Rows().Clear()
        'DGV_Grad.Rows.Clear()
        DGV_Undergrad.Rows.Clear()

        cbxCountry.Text = String.Empty
        txtEmail.Text = String.Empty
        txtPhone.Text = String.Empty
        txtSID.Text = String.Empty
        txtYearReg.Text = String.Empty

        cbxGender.Text = String.Empty
        cbxSemReg.Text = String.Empty
        cbxStatus.Text = String.Empty

        btnSAVE.Visible = True
        btnUPDATE.Visible = False
        DGV_Undergrad.Rows().Clear()
        EmpHistDGV.Rows().Clear()

    End Sub




    Public Sub refreshDGV_Undergrad()
        Dim iRowCount As Integer = Nothing
        Dim iPlacementCount As Integer = Nothing
        Dim strSQL As String = " SELECT * FROM EduHistory WHERE SID=" & txtSID.Text & " ORDER BY GRADDATE DESC;"

        DGV_Undergrad.Height = 35
        EduHistDA = New SqlCeDataAdapter(strSQL, con)
        EduHistDS = New DataSet
        iRowCount = EduHistDA.Fill(EduHistDS, "EduHist")
        DGV_Undergrad.Rows().Clear()

        While iPlacementCount < iRowCount

            DGV_Undergrad.Rows.Add(
                                EduHistDS.Tables(0).Rows(iPlacementCount).Item("DEGREE"),
                                EduHistDS.Tables(0).Rows(iPlacementCount).Item("MAJOR"),
                                EduHistDS.Tables(0).Rows(iPlacementCount).Item("GPA"),
                                EduHistDS.Tables(0).Rows(iPlacementCount).Item("UNIVERSITY"),
                                EduHistDS.Tables(0).Rows(iPlacementCount).Item("COUNTRY"),
                                EduHistDS.Tables(0).Rows(iPlacementCount).Item("GRADDATE"))

            DGV_Undergrad.Rows(iPlacementCount).Selected = False
            DGV_Undergrad.Height += 20
            iPlacementCount = iPlacementCount + 1
        End While
        con.Close()  'get in, get info, get out.
        DGV_Undergrad.Sort(DGV_Undergrad.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub


    Public Sub refreshEmpHistDGV() ' populate a DGV from EmpHist table
        Dim iRowCount As Integer = Nothing
        Dim iPlacementCount As Integer = Nothing
        Dim strSQL As String = "SELECT * from Emphist where SID=" & txtSID.Text & " ORDER BY WID DESC;"

        'EmpHistDGV.Height = 35
        EmpHistDA = New SqlCeDataAdapter(strSQL, con)
        EmpHistDS = New DataSet
        iRowCount = EmpHistDA.Fill(EmpHistDS, "EmpHist")
        If iRowCount = 0 Then
            CheckBox1.Checked = True
            CheckBox2.Checked = False

        End If
        EmpHistDGV.Rows().Clear()
        While iPlacementCount < iRowCount

            EmpHistDGV.Rows.Add(
                             EmpHistDS.Tables(0).Rows(iPlacementCount).Item("CurrentEmployer"),
                             EmpHistDS.Tables(0).Rows(iPlacementCount).Item("Emp_Location"),
                             EmpHistDS.Tables(0).Rows(iPlacementCount).Item("StartDate"),
                             EmpHistDS.Tables(0).Rows(iPlacementCount).Item("EndDate"),
                             EmpHistDS.Tables(0).Rows(iPlacementCount).Item("Emp_Title"),
                             EmpHistDS.Tables(0).Rows(iPlacementCount).Item("Duties"),
                             EmpHistDS.Tables(0).Rows(iPlacementCount).Item("Intern_Status"),
                             EmpHistDS.Tables(0).Rows(iPlacementCount).Item("Emp_Salary"),
                             EmpHistDS.Tables(0).Rows(iPlacementCount).Item("WID")
                             )


            EmpHistDGV.Rows(iPlacementCount).Selected = False
            EmpHistDGV.Height += 20
            iPlacementCount = iPlacementCount + 1
        End While
        con.Close()  'get in, get info, get out.
        ' EmpHistDGV.Sort(EmpHistDGV.Columns(3), System.ComponentModel.ListSortDirection.Descending)
    End Sub


    Private Sub btnSaveEd_Click(sender As Object, e As EventArgs) Handles btnSaveEd.Click
        If  cbDegree.Text = String.Empty Or txtMajor.Text = String.Empty Or txtGPA.Text = String.Empty Or cbUniversity.Text = String.Empty Then
            MsgBox("Incorrect or Incomplete Data Entered....")
        Else

            If dtpEdDate.Value = Date.FromOADate(0) Then

                MsgBox("Please Enter a Date")
            Else


                Dim cmdSQLText As String
                cmdSQLText = "INSERT INTO EduHistory (SID,DEGREE,GPA,MAJOR,UNIVERSITY,COUNTRY,GRADDATE) values (@SID,@DEGREE,@GPA,@MAJOR,@UNIVERSITY,@COUNTRY,@GRADDATE);"

                Try
                    If con.State = 0 Then
                        con.ConnectionString = My.Settings.DBConnectionString
                        con.Open()
                    End If

                    Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                    icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                    icmd.Parameters.Clear()
                    With icmd.Parameters
                        .AddWithValue("SID", SqlDbType.NVarChar).Value = txtSID.Text
                        .AddWithValue("DEGREE", SqlDbType.NVarChar).Value = If(IsNothing(cbDegree.Text) Or cbDegree.Text = String.Empty, DBNull.Value, cbDegree.Text.ToUpper())
                        .AddWithValue("GPA", SqlDbType.NVarChar).Value = If(IsNothing(txtGPA.Text) Or txtGPA.Text = String.Empty, DBNull.Value, txtGPA.Text)
                        .AddWithValue("MAJOR", SqlDbType.NVarChar).Value = If(IsNothing(txtMajor.Text) Or txtMajor.Text = String.Empty, DBNull.Value, txtMajor.Text.ToUpper())

                        .AddWithValue("UNIVERSITY", SqlDbType.NVarChar).Value = If(IsNothing(cbUniversity.Text) Or cbUniversity.Text = String.Empty, DBNull.Value, cbUniversity.Text.ToUpper())
                        .AddWithValue("COUNTRY", SqlDbType.NVarChar).Value = If(IsNothing(txtCountry.Text) Or txtCountry.Text = String.Empty, DBNull.Value, txtCountry.Text.ToUpper())

                        .AddWithValue("GRADDATE", SqlDbType.DateTime).Value = If(IsNothing(dtpEdDate.Text) Or dtpEdDate.Text = String.Empty, DBNull.Value, dtpEdDate.Text)

                    End With

                    icmd.CommandText = cmdSQLText
                    Dim iRowsAffected As Integer
                    iRowsAffected = icmd.ExecuteNonQuery()
                    MainForm.StatusBar1.Text = iRowsAffected & " record updated."


                    'icmd.Parameters.Clear() 'get the ID of the last record written so we can save it to the service plan table
                    'icmd.CommandText = "Select @@Identity"
                    'iRecordID = icmd.ExecuteScalar 'The ID will be returned.           

                    icmd.Parameters.Clear()
                    icmd.Dispose()

                Catch ex2 As Exception
                    MessageBox.Show(ex2.Message)

                Finally
                    cbDegree.SelectedIndex = -1
                    txtMajor.Text = String.Empty
                    txtGPA.Text = String.Empty
                    cbUniversity.Text = String.Empty
                    txtCountry.Text = String.Empty
                    con.Close()
                End Try

                refreshDGV_Undergrad()
            End If
        End If

    End Sub



    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click

        Dim result As Integer = MessageBox.Show("Are You Sure?", "Make Student Available?", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim iRowsAffected As Integer
            CheckBox2.Checked = False
            If Not (IsNothing(txtSID.Text) Or (txtSID.Text = String.Empty)) Then


                'uncheck the HIRED checkbox cuz the student is now   available.
                CheckBox1.Checked = False
                Dim cmdSQLText As String = "UPDATE EmpHist SET [EndDate]=@EndDate,[Intern_Status]=@Intern_Status WHERE  [SID]=@SID;"

                Try
                    If con.State = 0 Then
                        con.ConnectionString = My.Settings.DBConnectionString
                        con.Open()
                    End If

                    Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                    icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                    icmd.Parameters.Clear()
                    With icmd.Parameters
                        .AddWithValue("EndDate", SqlDbType.DateTime).Value = DateTime.Now() 'if user checks AVAILABLE then write the current date as the EndDate for the placement
                        .AddWithValue("Intern_Status", SqlDbType.NVarChar).Value = "AVAILABLE"
                        .AddWithValue("SID", SqlDbType.NVarChar).Value = txtSID.Text

                    End With

                    icmd.CommandText = cmdSQLText

                    iRowsAffected = icmd.ExecuteNonQuery()
                    If iRowsAffected > 0 Then
                        MessageBox.Show(iRowsAffected & " record updated.")
                    Else : MessageBox.Show("NO records updated")

                    End If

                    'icmd.Parameters.Clear()
                    'icmd.CommandText = "Select @@Identity"
                    'iRecordID = icmd.ExecuteScalar 'The ID will be returned.           

                    icmd.Parameters.Clear()
                    icmd.Dispose()

                Catch ex2 As Exception
                    MessageBox.Show(ex2.Message)

                Finally

                    con.Close()
                End Try
                If iRowsAffected > 0 Then
                    cmdSQLText = "UPDATE personal SET [Internstatus]=@Internstatus WHERE [SID]=@SID;"

                    Try
                        If con.State = 0 Then
                            con.ConnectionString = My.Settings.DBConnectionString
                            con.Open()
                        End If

                        Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                        icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                        icmd.Parameters.Clear()
                        With icmd.Parameters
                            .AddWithValue("Internstatus", SqlDbType.NVarChar).Value = "AVAILABLE"
                            .AddWithValue("SID", SqlDbType.NVarChar).Value = txtSID.Text
                        End With

                        icmd.CommandText = cmdSQLText
                        iRowsAffected = 0
                        iRowsAffected = icmd.ExecuteNonQuery()
                        MainForm.StatusBar1.Text = iRowsAffected & " record(s) updated."

                        'icmd.Parameters.Clear()
                        'icmd.CommandText = "Select @@Identity"
                        'iRecordID = icmd.ExecuteScalar 'The ID will be returned.           

                        icmd.Parameters.Clear()
                        icmd.Dispose()

                    Catch ex2 As Exception
                        MessageBox.Show(ex2.Message)

                    Finally

                        con.Close()
                    End Try
                End If
                CheckBox1.Checked = True
            Else
                CheckBox2.Checked = False
            End If
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Not (IsNothing(txtSID.Text) Or (txtSID.Text = String.Empty)) Then


            'uncheck the AVAILABLE checkbox cuz the student no longer  available.
            CheckBox1.Checked = False

        Else
            CheckBox2.Checked = False
        End If

    End Sub



    Private Sub btnHIRE_Click(sender As Object, e As EventArgs) Handles btnHIRE.Click
        lblCopyPlacementMessage.Visible = True

        'update the TAB1 WorkExperience Groupbox fields
        cbEmployer.Text = txtCOMPANY.Text
        txtLocation.Text = txtCCITY.Text
        txtTitle.Text = txtJOBPOSITION.Text
        txtDuties.Text = txtJOBRESPONSIBILITIES.Text
        txtSalary.Text = txtJOBSALARY.Text

        GroupBox2.Enabled = True
        cbEmployer.Enabled = False
        txtLocation.Enabled = False
        txtTitle.Enabled = False
        txtDuties.Enabled = False
        txtSalary.Enabled = False
        dtpStartDate.Enabled = True
    End Sub


    Public Sub refreshJobDGV()
        Dim iRowCount As Integer = Nothing
        Dim iPlacementCount As Integer = Nothing
        Dim strSQL As String = "SELECT * FROM JOBS where INTERNSHIP_TYPE='" & cbInternshipType.Text & "' order by INTERNSHIP_TYPE ASC;"

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
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("DESCRIPTION"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("RESPONSIBILITIES"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("REQUIREMENTS"),
                                LoginDS.Tables(0).Rows(iPlacementCount).Item("SALARY"))


                JobsDGV.Rows(iPlacementCount).Selected = False
                JobsDGV.Height += 40
                iPlacementCount = iPlacementCount + 1
            End While
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally

            con.Close()
        End Try

        JobsDGV.Sort(JobsDGV.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub





    Private Sub JobsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles JobsDGV.CellMouseClick
        Dim iRowCount As Integer = Nothing
        Dim iPlacementCount As Integer = Nothing
        ' MsgBox(iRecordID)
        iRecordID = JobsDGV.Item(0, JobsDGV.CurrentRow.Index).Value

        Dim strSQL As String = "SELECT JOBS.JID, JOBS.JOBGROUP, JOBS.POSITION, JOBS.DESCRIPTION, JOBS.RESPONSIBILITIES, JOBS.REQUIREMENTS, JOBS.SALARY, JOBS.INTERNSHIP_TYPE, JOBS.CID, " _
        + " INTERNSHIP_TYPES.TYPE, INTERNSHIP_TYPES.COMPANYNAME, INTERNSHIP_TYPES.ADDRESS, INTERNSHIP_TYPES.CITY, INTERNSHIP_TYPES.POSTAL," _
        + " INTERNSHIP_TYPES.COUNTRY, INTERNSHIP_TYPES.CONTACTFNAME, INTERNSHIP_TYPES.CONTACTLNAME, INTERNSHIP_TYPES.CONTACTPOSITION," _
        + " INTERNSHIP_TYPES.TELEPHONE, INTERNSHIP_TYPES.WEBSITE, INTERNSHIP_TYPES.NOTES " _
        + " FROM JOBS LEFT OUTER JOIN  INTERNSHIP_TYPES ON JOBS.CID = INTERNSHIP_TYPES.ID where JOBS.JID=" & iRecordID & ";"


        JobsDGV.Height = 35
        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If


            LoginDA = New SqlCeDataAdapter(strSQL, con)
            LoginDS = New DataSet
            iRowCount = LoginDA.Fill(LoginDS, "JOBS")


        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally

            con.Close()
        End Try


        txtJOBTYPE.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(7)), String.Empty, LoginDS.Tables(0).Rows(0).Item(7))
        txtJOBGROUP.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(1)), String.Empty, LoginDS.Tables(0).Rows(0).Item(1))
        txtJOBDESCRIPTION.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(3)), String.Empty, LoginDS.Tables(0).Rows(0).Item(3))
        txtJOBPOSITION.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(2)), String.Empty, LoginDS.Tables(0).Rows(0).Item(2))
        txtJOBREQUIREMENTS.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(5)), String.Empty, LoginDS.Tables(0).Rows(0).Item(5))
        txtJOBRESPONSIBILITIES.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(4)), String.Empty, LoginDS.Tables(0).Rows(0).Item(4))
        txtJOBSALARY.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(6)), String.Empty, LoginDS.Tables(0).Rows(0).Item(6))
        txtJOBTYPE.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(7)), String.Empty, LoginDS.Tables(0).Rows(0).Item(7))
        txtCOMPANY.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(10)), String.Empty, LoginDS.Tables(0).Rows(0).Item(10))
        txtWEBSITE.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(19)), String.Empty, LoginDS.Tables(0).Rows(0).Item(19))
        txtTELEPHONE.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(18)), String.Empty, LoginDS.Tables(0).Rows(0).Item(18))
        txtCFNAME.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(15)), String.Empty, LoginDS.Tables(0).Rows(0).Item(15))
        txtCLNAME.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(16)), String.Empty, LoginDS.Tables(0).Rows(0).Item(16))
        txtPOSITION.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(17)), String.Empty, LoginDS.Tables(0).Rows(0).Item(17))
        txtCEMAIL.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(9)), String.Empty, LoginDS.Tables(0).Rows(0).Item(9))
        txtCADDRESS.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(11)), String.Empty, LoginDS.Tables(0).Rows(0).Item(11))
        txtCCITY.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(12)), String.Empty, LoginDS.Tables(0).Rows(0).Item(12))
        txtCPOSTAL.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(13)), String.Empty, LoginDS.Tables(0).Rows(0).Item(13))
        txtCCOUNTRY.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(14)), String.Empty, LoginDS.Tables(0).Rows(0).Item(14))
        txtCNOTES.Text = If(IsDBNull(LoginDS.Tables(0).Rows(0).Item(20)), String.Empty, LoginDS.Tables(0).Rows(0).Item(20))


    End Sub



    Private Sub cbInternshipType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbInternshipType.SelectedIndexChanged

        refreshJobDGV()
    End Sub




    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click

        ' DELETE FROM personal  Sql not support DEL JOIN table
        'Dim cmdSQLText As String = "delete from personal AS p1 LEFT JOIN Emphist AS e1 ON p1.SID=e1.SID WHERE [p1.SID]=@SID;"
        Dim cmdSQLText As String = "delete  from personal WHERE [SID]=@SID;"


        Dim result As Integer = MessageBox.Show("Are You Sure?", "Delete Student", MessageBoxButtons.YesNoCancel)
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

                    .AddWithValue("SID", SqlDbType.NVarChar).Value = txtSID.Text

                End With


                icmd.CommandText = cmdSQLText

                Dim iRowsAffected As Integer = icmd.ExecuteNonQuery()

                ' DELETE FROM Emphist Sql not support DEL JOIN table
                cmdSQLText = "delete from Emphist WHERE [SID]=@SID;"
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear()
                With icmd.Parameters


                    .AddWithValue("SID", SqlDbType.NVarChar).Value = txtSID.Text

                End With


                icmd.CommandText = cmdSQLText

                iRowsAffected = icmd.ExecuteNonQuery()

                ' DELETE FROM EduHistory
                cmdSQLText = "delete from EduHistory WHERE [SID]=@SID;"
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear()
                With icmd.Parameters

                    .AddWithValue("SID", SqlDbType.NVarChar).Value = txtSID.Text

                End With


                icmd.CommandText = cmdSQLText

                iRowsAffected = icmd.ExecuteNonQuery()
                MainForm.StatusBar1.Text = iRowsAffected & " student deleted."

                'CLEAR FORM
                btnClearForm_Click(Me, e)


                icmd.Parameters.Clear()

                icmd.Dispose()

            Catch ex2 As Exception
                MessageBox.Show(ex2.Message)

            Finally
                con.Close()
            End Try

        End If


    End Sub
    Private Sub MyBase_KeyDown(Sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub






    Private Sub btnAddPlacement_Click(sender As Object, e As EventArgs) Handles btnAddPlacement.Click

        If dtpStartDate.Value = Date.FromOADate(0) Then

            MsgBox("Please Enter a Start Date")
        Else


            Dim cmdSQLText As String = "INSERT INTO Emphist (SID,CurrentEmployer,Emp_Location,StartDate," _
               + "Emp_Title,Duties,Intern_Status,Emp_Salary) values (@SID,@CurrentEmployer,@Emp_Location,@StartDate," _
               + " @Emp_Title,@Duties, @Intern_Status,@Emp_Salary);"

            Try
                If con.State = 0 Then
                    con.ConnectionString = My.Settings.DBConnectionString
                    con.Open()
                End If

                Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                icmd.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd.Parameters.Clear()
                With icmd.Parameters
                    .AddWithValue("SID", SqlDbType.NVarChar).Value = If(IsNothing(txtSID.Text) Or txtSID.Text = String.Empty, DBNull.Value, txtSID.Text)
                    .AddWithValue("CurrentEmployer", SqlDbType.NVarChar).Value = If(IsNothing(cbEmployer.Text) Or cbEmployer.Text = String.Empty, DBNull.Value, cbEmployer.Text.ToUpper())
                    .AddWithValue("Emp_Location", SqlDbType.NVarChar).Value = If(IsNothing(txtLocation.Text) Or txtLocation.Text = String.Empty, DBNull.Value, txtLocation.Text.ToUpper())
                    .AddWithValue("StartDate", SqlDbType.DateTime).Value = If(IsNothing(dtpStartDate.Text) Or dtpStartDate.Text = String.Empty, DBNull.Value, dtpStartDate.Value)
                    .AddWithValue("Emp_Title", SqlDbType.NVarChar).Value = If(IsNothing(txtTitle.Text) Or txtTitle.Text = String.Empty, DBNull.Value, txtTitle.Text.ToUpper())
                    .AddWithValue("Duties", SqlDbType.NVarChar).Value = If(IsNothing(txtDuties.Text) Or txtDuties.Text = String.Empty, DBNull.Value, txtDuties.Text.ToUpper())
                    .AddWithValue("Intern_Status", SqlDbType.NVarChar).Value = If((CheckBox1.Checked = True), "AVAILABLE", "HIRED")
                    .AddWithValue("Emp_Salary", SqlDbType.NVarChar).Value = If(IsNothing(txtSalary.Text) Or txtSalary.Text = String.Empty, DBNull.Value, txtSalary.Text)

                End With

                icmd.CommandText = cmdSQLText
                Dim iRowsAffected As Integer
                iRowsAffected = icmd.ExecuteNonQuery()
                MainForm.StatusBar1.Text = iRowsAffected & " record(s) updated."

                icmd.Parameters.Clear()
                icmd.CommandText = "Select @@Identity"
                iRecordID = icmd.ExecuteScalar 'The ID will be returned.           

                icmd.Parameters.Clear()
                icmd.Dispose()

                'also update personal table with Intern_status

                cmdSQLText = "Update personal SET [Internstatus]=@Internstatus where [SID]=@SID"



                Dim icmd2 As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
                icmd2.CommandType = CommandType.Text ' The default is CommandType.Text
                icmd2.Parameters.Clear()
                With icmd2.Parameters
                    .AddWithValue("Internstatus", SqlDbType.NVarChar).Value = If((CheckBox1.Checked = True), "AVAILABLE", "HIRED")
                    .AddWithValue("SID", SqlDbType.NVarChar).Value = If(IsNothing(txtSID.Text) Or txtSID.Text = String.Empty, DBNull.Value, txtSID.Text)

                End With

                icmd2.CommandText = cmdSQLText
                'Dim iRowsAffected As Integer
                iRowsAffected = icmd2.ExecuteNonQuery()
                MainForm.StatusBar1.Text = iRowsAffected & " record(s) updated."


                icmd2.Parameters.Clear()
                icmd2.CommandText = "Select @@Identity"
                iRecordID = icmd2.ExecuteScalar 'The ID will be returned.           

                icmd2.Parameters.Clear()
                icmd2.Dispose()
            Catch ex2 As Exception
                MessageBox.Show(ex2.Message)

            Finally

                con.Close()
                CheckBox1.Checked = False
                CheckBox2.Checked = True
            End Try
            GroupBox2.Enabled = False
        End If
        refreshDGV_Undergrad()
        refreshEmpHistDGV()
        DGV_Undergrad.Sort(DGV_Undergrad.Columns(0), System.ComponentModel.ListSortDirection.Descending)

    End Sub





    Private Sub dtpStartDate_MouseHover(sender As Object, e As EventArgs) Handles dtpStartDate.MouseHover
        dtpStartDate.Format = DateTimePickerFormat.Custom
        dtpStartDate.CustomFormat = "dd/MM/yyyy"
        dtpStartDate.Value = Date.Now()
        dtpStartDate.Enabled = True
    End Sub

    Private Sub dtpEdDate_MouseHover(sender As Object, e As EventArgs) Handles dtpEdDate.MouseHover
        dtpEdDate.Format = DateTimePickerFormat.Custom
        dtpEdDate.CustomFormat = "dd/MM/yyyy"
        dtpEdDate.Value = Date.Now()
        dtpEdDate.Enabled = True

    End Sub



    Private Sub txtGPA_LostFocus(sender As Object, e As EventArgs) Handles txtGPA.LostFocus
        If Not (IsNumeric(txtGPA.Text)) Then
            MsgBox("GPA is NonNumeric Input")
        End If
    End Sub

    'DELETD EDU RECORD 
    'Private Sub btnDeleteEd_Click(sender As Object, e As EventArgs) Handles btnDeleteEd.Click


    'Dim cmdSQLText As String = "delete SID,DEGREE,GPA,MAJOR,UNIVERSITY,COUNTRY,GRADDATE from EduHistory WHERE [SID]=@SID;"

    'Dim result As Integer = MessageBox.Show("Are You Sure?", "Delete User", MessageBoxButtons.YesNoCancel)
    '    If result = DialogResult.Cancel Then
    '        MessageBox.Show("Cancel pressed")
    '    ElseIf result = DialogResult.No Then

    '    ElseIf result = DialogResult.Yes Then


    '        Try
    '            If con.State = 0 Then
    '                con.ConnectionString = My.Settings.DBConnectionString
    '                con.Open()
    '            End If

    'Dim icmd As SqlCeCommand = New SqlCeCommand(cmdSQLText, con)
    '            icmd.CommandType = CommandType.Text ' The default is CommandType.Text
    '            icmd.Parameters.Clear()
    '            With icmd.Parameters


    '                .AddWithValue("ID", SqlDbType.Int).Value = iRecordID



    '            End With


    '            icmd.CommandText = cmdSQLText

    'Dim iRowsAffected As Integer = icmd.ExecuteNonQuery()

    '            MainForm.StatusBar1.Text = iRowsAffected & " The dducation Record deleted."


    '            icmd.Parameters.Clear()

    '            icmd.Dispose()

    '        Catch ex2 As Exception
    '            MessageBox.Show(ex2.Message)

    '        Finally
    '            con.Close()
    '        End Try

    '        refreshDGV_Undergrad()
    '        DGV_Undergrad.Sort(DGV_Undergrad.Columns(1), System.ComponentModel.ListSortDirection.Descending)
    '    End If
    ''clear the form
    '    cbDegree.Text = String.Empty
    '    txtMajor.Text = String.Empty
    '    txtGPA.Text = String.Empty
    '    cbUniversity.Text = String.Empty
    '    txtCountry.Text = String.Empty
    '    dtpEdDate.Text = String.Empty

    'End Sub


End Class




