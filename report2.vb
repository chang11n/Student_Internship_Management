Imports System.Configuration
Imports System.Data.SqlServerCe
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.Reporting.WinForms


Public Class report2


    Private con As New SqlCeConnection
    Private Shared ConnectionString As String

    Dim SearchArray(3) As String
    Dim SearchString As String


    Private Sub report2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.Visible = False
        ReportViewer1.SendToBack()

        Try
            If con.State = 0 Then
                con.ConnectionString = My.Settings.DBConnectionString
                con.Open()
            End If

            '*************** LOADING EMPOLYER LIST from Empolyer table
            Dim strSQL As String = "select distinct COMPANYNAME from INTERNSHIP_TYPES ORDER BY COMPANYNAME ASC;"

            Dim employerda As New SqlCeDataAdapter(strSQL, con)
            Dim employerds As New DataSet
            employerda.Fill(employerds, "INTERNSHIP_TYPES")
            With cbSearchCompany
                .DataSource = employerds.Tables("INTERNSHIP_TYPES")
                .DisplayMember = "COMPANYNAME"
                .ValueMember = "COMPANYNAME"
                .SelectedIndex = -1
            End With
            employerda.Dispose()

            '*************** loading city list from empolyer table
            Dim strsql2 As String = "select distinct city from internship_types order by city asc;"

            Dim employercityda As New SqlCeDataAdapter(strsql2, con)
            Dim employercityds As New DataSet
            employercityda.Fill(employercityds, "internship_types")
            With cbSearchCity
                .DataSource = employercityds.Tables("internship_types")
                .DisplayMember = "city"
                .ValueMember = "city"
                .SelectedIndex = -1
            End With
            employercityda.Dispose()

            '*************** loading position list from jobs table
            Dim strsql3 As String = "select distinct position from jobs order by position asc;"

            Dim positionda As New SqlCeDataAdapter(strsql3, con)
            Dim positionds As New DataSet
            positionda.Fill(positionds, "jobs")
            With cbSearchPosition
                .DataSource = positionds.Tables("jobs")
                .DisplayMember = "position"
                .ValueMember = "position"
                .SelectedIndex = -1
            End With
            positionda.Dispose()

        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)

        Finally

        End Try

    End Sub


    Private Sub cbSearchCompany_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbSearchCompany.SelectionChangeCommitted
        SearchArray(0) = " AND INTERNSHIP_TYPES.COMPANYNAME ='" & cbSearchCompany.Text & "' "
    End Sub

    Private Sub cbSearchCity_LostFocus(sender As Object, e As EventArgs) Handles cbSearchCity.LostFocus
        SearchArray(1) = " AND INTERNSHIP_TYPES.CITY ='" & cbSearchCity.Text & "' "
    End Sub


    Private Sub cbSearchPosition_LostFocus(sender As Object, e As EventArgs) Handles cbSearchPosition.LostFocus
        SearchArray(2) = " AND JOBS.POSITION ='" & cbSearchPosition.Text & "' "
    End Sub



    Private Sub btnSearchReportsEmployer_Click(sender As Object, e As EventArgs) Handles btnSearchReportsEmployer.Click
        'if there is some value in SearchArray(0) that means we need a WHERE in our query
        SearchString = " SELECT INTERNSHIP_TYPES.COMPANYNAME, INTERNSHIP_TYPES.ADDRESS, INTERNSHIP_TYPES.CITY, INTERNSHIP_TYPES.COUNTRY, INTERNSHIP_TYPES.CONTACTFNAME, INTERNSHIP_TYPES.CONTACTLNAME, INTERNSHIP_TYPES.TELEPHONE, INTERNSHIP_TYPES.WEBSITE, JOBS.POSITION FROM INTERNSHIP_TYPES, JOBS WHERE INTERNSHIP_TYPES.ID = JOBS.CID"


        'SearchString = " SELECT INTERNSHIP_TYPES.COMPANYNAME AS COMPANYNAME, INTERNSHIP_TYPES.ADDRESS AS ADDRESS, INTERNSHIP_TYPES.CITY AS CITY, INTERNSHIP_TYPES.COUNTRY AS COUNTRY, " _
        '  + " INTERNSHIP_TYPES.CONTACTFNAME AS CONTACTFNAME , INTERNSHIP_TYPES.CONTACTLNAME AS CONTACTLNAME, INTERNSHIP_TYPES.TELEPHONE AS TELEPHONE, " _
        '  + "  INTERNSHIP_TYPES.WEBSITE AS WEBSITE, JOBS.POSITION AS POSITION FROM INTERNSHIP_TYPES INNER JOIN JOBS ON INTERNSHIP_TYPES.ID = JOBS.CID"

        'If Not (IsNothing(SearchArray(0))) Then
        '    SearchString &= " where "

        '    For i = 0 To 2
        '        MessageBox.Show(SearchString)
        '        SearchString &= SearchArray(i)
        '        If Not (IsNothing(SearchArray(i + 1))) Then SearchString &= " AND "

        '    Next
        'End If

        For i = 0 To 3
         
            If Not (IsNothing(SearchArray(i))) Then SearchString &= SearchArray(i)
        Next

        SearchString &= " ORDER BY INTERNSHIP_TYPES.COMPANYNAME ASC;"

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
            '  MessageBox.Show(iRecordCount)
            If iRecordCount > 0 Then
                Reportds.DataSetName = "Dataset2"
                Reportds.Tables(0).TableName = "DataTable2"

                Me.DataTable2BindingSource.DataSource = Reportds

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

    'Private Sub rbGPA1_Click(sender As Object, e As EventArgs) Handles rbGPA1.Click
    '    If rbGPA1.Checked = True Then
    '        SearchArray(3) = " AGV(GPA) "

    '    End If
    'End Sub


    Private Sub MyBase_KeyDown(Sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub


End Class