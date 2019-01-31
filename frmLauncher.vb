'Riley Smith
'12/30/18
'Launcher
Imports System.Xml
Public Class frmLauncher
    Dim studentFirstName As String
    Dim studentLastName As String
    Dim selectedRowIndex As Integer
    Dim dt As New DataTable("Redemptions")
    Public studentdt As New DataTable("Student")
    Public bookdt As New DataTable("Book")
    Const FLAG As Integer = 1
   
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

    Private Sub frmLauncher_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Prompt user to make sure all saved changes are in fact saved
        If MessageBox.Show("Are you sure you want to close this application? All unsaved redemptions will be lost", "Leaving the Restricted Section?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub frmLauncher_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load




            'Read Book Table XML
        Dim filePath As String = "G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Book - Copy.xml"
            BookDataSet.ReadXml(filePath)

            DataGridView1.DataSource = BookDataSet
            DataGridView1.DataMember = "book"

            With Me.DataGridView1
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = False
            End With

        'Create columns for Book Table
        bookdt.Columns.Add("BookId", GetType(String))
        bookdt.Columns.Add("Title", GetType(String))
        bookdt.Columns.Add("Author", GetType(String))
        bookdt.Columns.Add("Subject", GetType(String))

        With dgvBook
            .DataSource = bookdt
            .AllowUserToAddRows = True : .AllowUserToDeleteRows = True
            .AllowUserToOrderColumns = False : .AllowUserToResizeRows = True

        End With

            'Read Student Table XML
            'Dim filePath1 As String = "G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml"
            Dim filePath1 As String = "G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student - Copy.xml"
            StudentDataSet.ReadXml(filePath1)

            DataGridView2.DataSource = StudentDataSet
            DataGridView2.DataMember = "student"

            With Me.DataGridView2
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = False
        End With

        'Create columns for Student Table
        studentdt.Columns.Add("Student ID", GetType(String))
        studentdt.Columns.Add("First Name", GetType(String))
        studentdt.Columns.Add("Last Name", GetType(String))
        studentdt.Columns.Add("School", GetType(String))
        studentdt.Columns.Add("Grade", GetType(String))
        studentdt.Columns.Add("E-Mail", GetType(String))


        With dgvStudent
            .DataSource = studentdt
            .AllowUserToAddRows = True : .AllowUserToDeleteRows = True
            .AllowUserToOrderColumns = False : .AllowUserToResizeRows = True

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

        'Load and Read Student XML
        studentdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student - Copy.xml")
        dgvStudent.DataSource = studentdt

        'Load and Read Book XML
        bookdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Book - Copy.xml")
        dgvBook.DataSource = bookdt

        'Redemption Table (Select only One row)
            With Me.DataGridView3
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = False
            End With

            With DataGridView3
                .DataSource = dt
                .AllowUserToAddRows = True : .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False : .AllowUserToResizeRows = True
            End With

        'Allow only one row selection Student Table

        With Me.dgvStudent
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

        'Allow only one row selection Book Table
        With Me.dgvBook
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With


            'AutoSelect First Row
            DataGridView3.Rows(0).Selected = True

        'Order Redemption Id's in ascending order
        DataGridView3.Sort(DataGridView3.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

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
        id = id.Remove(0, 5)

        Dim row As String()

        row = New String() {id, bookID, bookTitle, studentID, studentFirstName & " " & studentLastName}
        dt.Rows.Add(row)


        DataGridView3.DataSource = dt
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Save to XML
        dt = CType(DataGridView3.DataSource, DataTable)
        dt.AcceptChanges()
        dt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Redemptions.xml", System.Data.XmlWriteMode.WriteSchema, False)


        'studentdt = CType(dgvStudent.DataSource, DataTable)
        'studentdt.AcceptChanges()
        'studentdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student - Copy.xml", System.Data.XmlWriteMode.WriteSchema, False)
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

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'Save Redemption to XML
        dt = CType(DataGridView3.DataSource, DataTable)
        dt.AcceptChanges()
        dt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Redemptions.xml", System.Data.XmlWriteMode.WriteSchema, False)

        'studentdt = CType(dgvStudent.DataSource, DataTable)
        'studentdt.AcceptChanges()
        'studentdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student - Copy.xml", System.Data.XmlWriteMode.WriteSchema, False)
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        Report.dgvReport.DataSource = DataGridView3.DataSource
        Report.Show()
        'Me.Hide()
    End Sub

    Private Sub btnAddStudent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        frmStudentAddition.Show()
        Me.Hide()
    End Sub

    Private Sub btnRedeamAfterStudent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRedeamAfterStudent.Click

        'Gather Student Name from Selected Student Table
        Dim selectedRowCount As Integer = _
dgvStudent.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim studentID As Integer

        If selectedRowCount > 0 Then

            Dim sb As New System.Text.StringBuilder()

            Dim i As Integer
            For i = 0 To selectedRowCount - 1

                sb.Append("Row: ")
                sb.Append(dgvStudent.SelectedRows(i).Index.ToString())
                sb.Append(Environment.NewLine)
                'MessageBox.Show(DataGridView1.Rows(i).Cells(1).Value)
                selectedRowIndex = dgvStudent.SelectedRows(i).Index()
            Next i
            sb.Append("Total: " + selectedRowCount.ToString())
            studentFirstName = CStr(dgvStudent("First Name", selectedRowIndex).Value)
            studentLastName = CStr(dgvStudent("Last Name", selectedRowIndex).Value)
            studentID = CStr(dgvStudent("Student ID", selectedRowIndex).Value)
        End If

        'Gather Title from Selected Book Table
        Dim selectedRowCount1 As Integer = _
dgvBook.Rows.GetRowCount(DataGridViewElementStates.Selected)

        Dim selectedRowIndex1 As Integer
        Dim bookTitle As String
        Dim bookID As Integer

        If selectedRowCount1 > 0 Then

            Dim sb As New System.Text.StringBuilder()

            Dim i As Integer
            For i = 0 To selectedRowCount1 - 1

                sb.Append("Row: ")
                sb.Append(dgvBook.SelectedRows(i).Index.ToString())
                sb.Append(Environment.NewLine)
                'MessageBox.Show(DataGridView1.Rows(i).Cells(1).Value)
                selectedRowIndex1 = dgvBook.SelectedRows(i).Index()
            Next i
            sb.Append("Total: " + selectedRowCount1.ToString())
            bookTitle = CStr(dgvBook("Title", selectedRowIndex1).Value)
            bookID = CStr(dgvBook("BookId", selectedRowIndex1).Value)
        End If

        bookTitle = CStr(dgvBook("Title", selectedRowIndex1).Value)

        Dim id As String = Format(Date.Now(), "yyyyMMddHHmmssfff")
        id = id.Remove(14, 3)

        Dim row As String()

        row = New String() {id, bookID, bookTitle, studentID, studentFirstName & " " & studentLastName}
        dt.Rows.Add(row)


        DataGridView3.DataSource = dt
    End Sub

    Private Sub frmLauncher_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        Call ClearTable(studentdt)
        Call ClearTable(bookdt)

        'Refresh Student Table
        'Load and Read Student XML
        studentdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student - Copy.xml")
        dgvStudent.DataSource = studentdt

        'Refresh Book Table
        'Load and Read Book XML
        bookdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\book - Copy.xml")
        dgvBook.DataSource = bookdt

    End Sub
    Sub ClearTable(ByVal table As DataTable)
        Try
            table.Clear()
        Catch e As DataException
            ' Process exception and return.
            Console.WriteLine("Exception of type {0} occurred.", _
              e.GetType().ToString())
        End Try
    End Sub

    Private Sub btnAddBook_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddBook.Click
        frmAddBook.Show()
        Me.Hide()
    End Sub
End Class