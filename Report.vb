Public Class Report
    Dim dt As New DataTable("Redemptions")
    Private Sub Report_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.txtDate.Text = System.DateTime.Now.ToString("dd/MMMM/yyyy")

        'Alter date so proper dates can be displayed in the report
        Dim startDay As Date
        Dim endDay As Date

        startDay = dtpStart.Value.AddDays(-1)

        dtpStart.Value = startDay

        endDay = dtpEnd.Value.AddDays(6)

        dtpEnd.Value = endDay


        'Creating Columns for Redemption Table
        dt.Columns.Add("RedemptionDate", GetType(String))
        dt.Columns.Add("RedemptionID", GetType(String))
        dt.Columns.Add("BookID", GetType(String))
        dt.Columns.Add("BookTitle", GetType(String))
        dt.Columns.Add("StudentID", GetType(String))
        dt.Columns.Add("StudentName", GetType(String))

        'dt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Redemptions.xml")
        dt.ReadXml("Redemptions.xml")

        dgvReport.DataSource = dt


        Me.txtReport.Text = Nothing

        dtpStart.CustomFormat = "dd/MM/yy"
        dtpEnd.CustomFormat = "dd/MM/yy"



        Dim vue As New DataView(dt)
        'This also works if you make TB1 = DTP1   vue.RowFilter = "date > #" & TextBox1.Text & "# and date < #" & TextBox2.Text & "#"
        vue.RowFilter = "RedemptionDate >= #" & dtpStart.Value & "# and RedemptionDate <= #" & dtpEnd.Value & "#"
        dgvReport.DataSource = vue

        'vue.RowFilter = "date > #" & DateTimePicker1.Value.ToShortDate & "# and date < #" & DateTimePicker2.Value.ToShortDate & "#"
        ' Does not work, has the error 'To short is not a member of date' 

        'Order incoming Data Table
        dgvReport.Sort(dgvReport.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

        'Report information in text box
        'Only one name for redeamed books
        Dim lbl As New Label
        Dim currentName As String = Nothing
        Dim newName As String

        For Each row As DataGridViewRow In dgvReport.Rows
            If Not row.IsNewRow Then

                newName = (row.Cells("StudentName").Value.ToString)

                If Equals(currentName, newName) = True Then
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                Else
                    Me.txtReport.AppendText(row.Cells("StudentName").Value.ToString & Environment.NewLine)
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                End If

                currentName = newName
            End If
        Next


    End Sub
    Private Sub HomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click, Me.FormClosing, btnReturnToHome.Click
        Me.Hide()
        frmLauncher.DataGridView3.Sort(frmLauncher.DataGridView3.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        frmLauncher.Show()
    End Sub

    Private Sub btnWeeklyReport_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Me.txtReport.Text = Nothing

        dtpStart.CustomFormat = "dd/MM/yy"
        dtpEnd.CustomFormat = "dd/MM/yy"



        Dim vue As New DataView(dt)
        'This also works if you make TB1 = DTP1   vue.RowFilter = "date > #" & TextBox1.Text & "# and date < #" & TextBox2.Text & "#"
        vue.RowFilter = "RedemptionDate >= #" & dtpStart.Value & "# and RedemptionDate <= #" & dtpEnd.Value & "#"
        dgvReport.DataSource = vue

        'vue.RowFilter = "date > #" & DateTimePicker1.Value.ToShortDate & "# and date < #" & DateTimePicker2.Value.ToShortDate & "#"
        ' Does not work, has the error 'To short is not a member of date' 

        'Order incoming Data Table
        dgvReport.Sort(dgvReport.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

        'Report information in text box
        'Only one name for redeamed books
        Dim lbl As New Label
        Dim currentName As String = Nothing
        Dim newName As String


        For Each row As DataGridViewRow In dgvReport.Rows
            If Not row.IsNewRow Then

                newName = (row.Cells("StudentName").Value.ToString)

                If Equals(currentName, newName) = True Then
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                Else
                    Me.txtReport.AppendText(row.Cells("StudentName").Value.ToString & Environment.NewLine)
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                End If

                currentName = newName
            End If
        Next
    End Sub

    Private Sub btnNextWeek_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNextWeek.Click
        Me.txtReport.Text = Nothing

        'Display Records one week later
        Dim startDay As Date
        Dim endDay As Date

        startDay = dtpStart.Value.AddDays(6)

        dtpStart.Value = startDay

        endDay = dtpEnd.Value.AddDays(6)

        dtpEnd.Value = endDay


        dtpStart.CustomFormat = "dd/MM/yy"
        dtpEnd.CustomFormat = "dd/MM/yy"



        Dim vue As New DataView(dt)
        'This also works if you make TB1 = DTP1   vue.RowFilter = "date > #" & TextBox1.Text & "# and date < #" & TextBox2.Text & "#"
        vue.RowFilter = "RedemptionDate >= #" & dtpStart.Value & "# and RedemptionDate <= #" & dtpEnd.Value & "#"
        dgvReport.DataSource = vue


        'Order incoming Data Table
        dgvReport.Sort(dgvReport.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

        'Report information in text box
        'Only one name for redeamed books
        Dim lbl As New Label
        Dim currentName As String = Nothing
        Dim newName As String


        For Each row As DataGridViewRow In dgvReport.Rows
            If Not row.IsNewRow Then

                newName = (row.Cells("StudentName").Value.ToString)

                If Equals(currentName, newName) = True Then
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                Else
                    Me.txtReport.AppendText(row.Cells("StudentName").Value.ToString & Environment.NewLine)
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                End If

                currentName = newName
            End If
        Next
    End Sub

    Private Sub btnPriorWeek_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPriorWeek.Click

        Me.txtReport.Text = Nothing

        'Display Records one week prior
        Dim startDay As Date
        Dim endDay As Date


        startDay = dtpStart.Value.AddDays(-6)

        dtpStart.Value = startDay


        endDay = dtpEnd.Value.AddDays(-6)

        dtpEnd.Value = endDay


        dtpStart.CustomFormat = "dd/MM/yy"
        dtpEnd.CustomFormat = "dd/MM/yy"



        Dim vue As New DataView(dt)
        'This also works if you make TB1 = DTP1   vue.RowFilter = "date > #" & TextBox1.Text & "# and date < #" & TextBox2.Text & "#"
        vue.RowFilter = "RedemptionDate >= #" & dtpStart.Value & "# and RedemptionDate <= #" & dtpEnd.Value & "#"
        dgvReport.DataSource = vue

        'vue.RowFilter = "date > #" & DateTimePicker1.Value.ToShortDate & "# and date < #" & DateTimePicker2.Value.ToShortDate & "#"
        ' Does not work, has the error 'To short is not a member of date' 

        'Order incoming Data Table
        dgvReport.Sort(dgvReport.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

        'Report information in text box
        'Only one name for redeamed books
        Dim lbl As New Label
        Dim currentName As String = Nothing
        Dim newName As String


        For Each row As DataGridViewRow In dgvReport.Rows
            If Not row.IsNewRow Then

                newName = (row.Cells("StudentName").Value.ToString)

                If Equals(currentName, newName) = True Then
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                Else
                    Me.txtReport.AppendText(row.Cells("StudentName").Value.ToString & Environment.NewLine)
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                End If

                currentName = newName
            End If
        Next
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        Me.txtReport.Text = Nothing

        dtpStart.CustomFormat = "dd/MM/yy"
        dtpEnd.CustomFormat = "dd/MM/yy"



        Dim vue As New DataView(dt)
        'This also works if you make TB1 = DTP1   vue.RowFilter = "date > #" & TextBox1.Text & "# and date < #" & TextBox2.Text & "#"
        vue.RowFilter = "RedemptionDate >= #" & dtpStart.Value & "# and RedemptionDate <= #" & dtpEnd.Value & "#"
        dgvReport.DataSource = vue

        'vue.RowFilter = "date > #" & DateTimePicker1.Value.ToShortDate & "# and date < #" & DateTimePicker2.Value.ToShortDate & "#"
        ' Does not work, has the error 'To short is not a member of date' 

        'Order incoming Data Table
        dgvReport.Sort(dgvReport.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

        'Report information in text box
        'Only one name for redeamed books
        Dim lbl As New Label
        Dim currentName As String = Nothing
        Dim newName As String


        For Each row As DataGridViewRow In dgvReport.Rows
            If Not row.IsNewRow Then

                newName = (row.Cells("StudentName").Value.ToString)

                If Equals(currentName, newName) = True Then
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                Else
                    Me.txtReport.AppendText(row.Cells("StudentName").Value.ToString & Environment.NewLine)
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                End If

                currentName = newName
            End If
        Next
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Me.txtReport.Text = Nothing


        Dim startDay As Date
        Dim endDay As Date

        dtpStart.Value = DateTime.Now

        startDay = dtpStart.Value.AddDays(-1)

        dtpStart.Value = startDay

        dtpEnd.Value = DateTime.Now

        endDay = dtpEnd.Value.AddDays(6)

        dtpEnd.Value = endDay

        dtpStart.CustomFormat = "dd/MM/yy"
        dtpEnd.CustomFormat = "dd/MM/yy"

        Dim vue As New DataView(dt)
        'This also works if you make TB1 = DTP1   vue.RowFilter = "date > #" & TextBox1.Text & "# and date < #" & TextBox2.Text & "#"
        vue.RowFilter = "RedemptionDate >= #" & dtpStart.Value & "# and RedemptionDate <= #" & dtpEnd.Value & "#"
        dgvReport.DataSource = vue

        'Order incoming Data Table
        dgvReport.Sort(dgvReport.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

        'Report information in text box
        'Only one name for redeamed books
        Dim lbl As New Label
        Dim currentName As String = Nothing
        Dim newName As String

        For Each row As DataGridViewRow In dgvReport.Rows
            If Not row.IsNewRow Then

                newName = (row.Cells("StudentName").Value.ToString)

                If Equals(currentName, newName) = True Then
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                Else
                    Me.txtReport.AppendText(row.Cells("StudentName").Value.ToString & Environment.NewLine)
                    Me.txtReport.AppendText(vbTab & vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                End If

                currentName = newName
            End If
        Next
    End Sub
End Class

