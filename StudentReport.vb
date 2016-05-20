Imports System.Configuration
Imports System.Data.SqlServerCe
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.Reporting.WinForms




Public Class StudentReport

    Private con As New SqlCeConnection
    Private Shared ConnectionString As String

    Dim SearchArray(7) As String
    Dim SearchString As String


    Private Sub reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.Visible = False
        ReportViewer1.SendToBack()
        
        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If



            ' *************** loading country list from country talbe
            Dim strsql As String = "select * from country order by name asc;"

            Dim pprovda As New SqlCeDataAdapter(strsql, con)
            Dim pprovds As New DataSet
            pprovda.Fill(pprovds, "country")
            With cbSearchCountry
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

    End Sub




    Private Sub cbSearchCountry_SelectionChangeCommittedd(sender As Object, e As EventArgs) Handles cbSearchCountry.SelectionChangeCommitted
        SearchArray(0) = " EduHistory.COUNTRY ='" & cbSearchCountry.Text & "' "
    End Sub


    Private Sub cbEmployed_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEmployed.SelectedValueChanged
        SearchArray(0) = " Emphist.Intern_Status ='" & cbEmployed.Text & "' "
    End Sub


    Private Sub cbPaid_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPaid.SelectedValueChanged

        If cbPaid.Text = "PAID" Then
            SearchArray(2) = " Emphist.Emp_Salary > 0 "
        Else
            SearchArray(2) = " Emphist.Emp_Salary = 0 "

        End If
    End Sub

    Private Sub cbRegYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRegYear.SelectedIndexChanged
        SearchArray(3) = " (DATEPART(yyyy, EduHistory.GRADDATE) ='" & cbRegYear.Text & "' ) "
    End Sub

    Private Sub cbDegree_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDegree.SelectedIndexChanged
        SearchArray(4) = " EduHistory.DEGREE ='" & cbDegree.Text & "'  "
    End Sub

    Private Sub cbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGender.SelectedIndexChanged
        SearchArray(5) = " personal.Gender ='" & cbGender.Text & "' "
    End Sub


    Private Sub btnSearchReportsStudents_Click(sender As Object, e As EventArgs) Handles btnSearchReportStudents.Click
        'if there is some value in SearchArray(0) that means we need a WHERE in our query

       
        'SearchString = " select personal.SID, personal.F_Name, personal.L_Name, personal.Gender, personal.Email, personal.Phone, personal.Status, EduHistory.DEGREE, EduHistory.GPA, EduHistory.MAJOR, EduHistory.UNIVERSITY, EduHistory.GRADDATE, EduHistory.COUNTRY, Emphist.Intern_Status, Emphist.Emp_Salary from personal, Emphist WHERE personal.SID = Emphist.SID"

        SearchString = "SELECT personal.SID, personal.F_Name AS F_Name, personal.L_Name AS L_Name, personal.Gender AS Gender, personal.Email AS Email, personal.Phone AS Phone, personal.Status AS Status, EduHistory.DEGREE AS DEGREE, EduHistory.GPA AS GPA, EduHistory.MAJOR AS MAJOR, EduHistory.UNIVERSITY AS UNIVERSITY, EduHistory.GRADDATE AS GRADDATE, " _
                        + "EduHistory.COUNTRY AS COUNTRY, Emphist.Intern_Status AS Intern_Status, Emphist.Emp_Salary AS Salary FROM personal INNER JOIN EduHistory ON personal.SID = EduHistory.SID INNER JOIN Emphist ON EduHistory.SID = Emphist.SID WHERE"


        'If Not (IsNothing(SearchArray(0))) Then
        '    SearchString &= " WHERE "
        '    MessageBox.Show(SearchString)

        '    For i = 0 To 6
        '        SearchString &= SearchArray(i)
        '        If Not (IsNothing(SearchArray(i + 1))) Then SearchString &= " AND "
        '        MessageBox.Show(SearchString)
        '    Next
        'End If

        For i = 0 To 6

            If Not (IsNothing(SearchArray(i))) Then SearchString &= SearchArray(i)
        Next




        SearchString &= " ORDER BY personal.SID ASC;"

        ReportViewer1.Visible = True
        ReportViewer1.BringToFront()

        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If



            Dim strSQL As String = SearchString
            Dim iRecordCount As Integer
            Dim Reportda As New SqlCeDataAdapter(strSQL, con)
            Dim Reportds As New DataSet
            iRecordCount = Reportda.Fill(Reportds)

            If iRecordCount > 0 Then
                Reportds.DataSetName = "Dataset3"
                Reportds.Tables(0).TableName = "DataTable1"

                Me.DataTable1BindingSource.DataSource = Reportds

                Me.ReportViewer1.RefreshReport()
                Reportda.Dispose()
            Else
                MsgBox("Sorry, nothing to report.")
                ReportViewer1.Visible = False
                ReportViewer1.SendToBack()

            End If

        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally

        End Try
    End Sub

    'Private Sub rbgpa1_click(sender As Object, e As EventArgs) Handles rbGPA1.Click
    '    If rbgpa1.checked = True Then
    '        searcharray(3) = " agv(gpa) "

    '    End If
    'End Sub


    Private Sub MyBase_KeyDown(Sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub

   
End Class