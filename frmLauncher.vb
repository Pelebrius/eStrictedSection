'Riley Smith
'12/30/18
'Launcher
Imports System.Xml
Public Class frmLauncher
    Dim studentFirstName As String
    Dim studentLastName As String
    Dim selectedRowIndex As Integer
    Dim dt As New DataTable("Redemptions")



    Private Sub btnBookSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBookSearch.Click
        'Search Book Titles
        Dim xmlFile As XmlReader
        xmlFile = XmlReader.Create("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\BookTest.xml", New XmlReaderSettings())
        Dim ds As New DataSet
        Dim dv As DataView
        ds.ReadXml(xmlFile)

        dv = New DataView(ds.Tables(0))
        dv.Sort = "Title"
        Dim index As Integer = dv.Find(txtBookSearch.Text)
        lblBookResult.Text = txtBookSearch.Text

        If index = -1 Then
            Me.lblBookResult.Text = ("Item Not Found")
        Else
            Me.lblBookResult.Text = (dv(index)("Title").ToString())
        End If

        'Dim temp As Integer = 0
        'For i As Integer = 0 To gv.RowCount - 1
        '    For j As Integer = 0 To gv.ColumnCount - 1
        '        If gv.Rows(i).Cells(j).Value.ToString = txtBookSearch.Text Then
        '            MsgBox("Item found")
        '            temp = 1
        '        End If
        '    Next
        'Next
        'If temp = 0 Then
        '    MsgBox("Item not found")
        'End If
    End Sub

    Private Sub btnStudentSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStudentSearch.Click
        'Search Student First Names
        Dim xmlFile As XmlReader
        Dim filePath As String = "G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\studentTest.xml"
        xmlFile = XmlReader.Create("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\studentTest.xml", New XmlReaderSettings())
        Dim ds As New DataSet
        Dim dv As DataView
        ds.ReadXml(xmlFile)

        dv = New DataView(ds.Tables(0))
        dv.Sort = "First Name"
        'Dim index As Integer = dv.Find(Me.txtBookSearch)
        Dim index As Integer = dv.Find(txtStudentSearch.Text)
        lblStudentResult.Text = txtStudentSearch.Text

        If index = -1 Then
            Me.lblStudentResult.Text = ("Item Not Found")
        Else
            Me.lblStudentResult.Text = (dv(index)("First Name").ToString() & "  " & dv(index)("Last Name").ToString())
        End If

    End Sub

    Private Sub btnBookTable_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBookTable.Click
        BookTable.Show()
    End Sub

    Private Sub btnStudentTable_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStudentTable.Click
        StudentTable.Show()
    End Sub
    Private Sub frmLauncher_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Read Book Table XML
        Dim filePath As String = "G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Book.xml"
        BookDataSet.ReadXml(filePath)

        DataGridView1.DataSource = BookDataSet
        DataGridView1.DataMember = "book"

        With Me.DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

        'Read Student Table XML
        Dim filePath1 As String = "G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml"
        StudentDataSet.ReadXml(filePath1)

        DataGridView2.DataSource = StudentDataSet
        DataGridView2.DataMember = "student"

        With Me.DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

        'Creating Columns for Redemption Table
        dt.Columns.Add("RedemptionID", GetType(String))
        dt.Columns.Add("BookID", GetType(String))
        dt.Columns.Add("BookTitle", GetType(String))
        dt.Columns.Add("StudentID", GetType(String))
        dt.Columns.Add("StudentName", GetType(String))

        'Load and Read Redemption XML
        dt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Redemptions.xml")
        DataGridView3.DataSource = dt


        With Me.DataGridView3
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

        With DataGridView3
            .DataSource = dt
            .AllowUserToAddRows = True : .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False : .AllowUserToResizeRows = True
        End With

        'AutoSelect First Row
        DataGridView3.Rows(0).Selected = True

    End Sub

    Private Sub btnFullRedeam_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFullRedeam.Click
        'New Total value of rows

        'Gather Student Name from Selected Student Table
        Dim selectedRowCount As Integer = _
DataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim studentID As Integer

        If selectedRowCount > 0 Then

            Dim sb As New System.Text.StringBuilder()

            Dim i As Integer
            For i = 0 To selectedRowCount - 1

                sb.Append("Row: ")
                sb.Append(DataGridView2.SelectedRows(i).Index.ToString())
                sb.Append(Environment.NewLine)
                'MessageBox.Show(DataGridView1.Rows(i).Cells(1).Value)
                selectedRowIndex = DataGridView2.SelectedRows(i).Index()
            Next i
            sb.Append("Total: " + selectedRowCount.ToString())
            studentFirstName = CStr(DataGridView2("First Name", selectedRowIndex).Value)
            studentLastName = CStr(DataGridView2("Last Name", selectedRowIndex).Value)
            studentID = CStr(DataGridView2("Student ID", selectedRowIndex).Value)
        End If

        'Gather Title from Selected Book Table
        Dim selectedRowCount1 As Integer = _
DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        Dim selectedRowIndex1 As Integer
        Dim bookTitle As String
        Dim bookID As Integer

        If selectedRowCount1 > 0 Then

            Dim sb As New System.Text.StringBuilder()

            Dim i As Integer
            For i = 0 To selectedRowCount1 - 1

                sb.Append("Row: ")
                sb.Append(DataGridView1.SelectedRows(i).Index.ToString())
                sb.Append(Environment.NewLine)
                'MessageBox.Show(DataGridView1.Rows(i).Cells(1).Value)
                selectedRowIndex1 = DataGridView1.SelectedRows(i).Index()
            Next i
            sb.Append("Total: " + selectedRowCount1.ToString())
            bookTitle = CStr(DataGridView1("Title", selectedRowIndex1).Value)
            bookID = CStr(DataGridView1("BookId", selectedRowIndex1).Value)
        End If

        bookTitle = CStr(DataGridView1("Title", selectedRowIndex1).Value)

        Dim id As String = Format(Date.Now(), "yyyyMMddHHmmssfff")

        Dim row As String()

        row = New String() {id, bookID, bookTitle, studentID, studentFirstName & " " & studentLastName}
        dt.Rows.Add(row)

        'Dim reportString As String
        'Dim length As Integer



        'Dim lastStudentFirstName As String

        'Equals(lastStudentFirstName, studentFirstName)


        'reportString = studentFirstName & " " & studentLastName

        'Report.lblReport1.Text = reportString & " "

        'length = reportString.Length - 1

        'If studentFirstName = studentFirstName Then
        '    reportString = reportString.Insert(length, bookTitle)
        '    Report.lblReport1.Text = vbCrLf & bookTitle
        'Else
        '    Report.lblReport1.Text = vbCrLf
        'End If


        DataGridView3.DataSource = dt
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Save to XML
        dt = CType(DataGridView3.DataSource, DataTable)
        dt.AcceptChanges()
        dt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Redemptions.xml", System.Data.XmlWriteMode.WriteSchema, False)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'Delete Selected Record
        If DataGridView3.SelectedRows.Count > 0 Then
            DataGridView3.Rows.Remove(DataGridView3.SelectedRows(0))
            DataGridView3.Rows(0).Selected = True
        Else
            MessageBox.Show("Select 1 row before you hit delete")
        End If
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Report.dgvReport.DataSource = DataGridView3.DataSource
        Report.Show()
       
    End Sub
End Class