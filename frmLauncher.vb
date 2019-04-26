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
   
    Private Sub btnBookTable_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        BookTable.Show()
    End Sub

    Private Sub btnStudentTable_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        StudentTable.Show()
    End Sub

    Private Sub frmLauncher_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Prompt user to make sure all saved changes are in fact saved
        If MessageBox.Show("Are you sure you want to leave the eStricted Section? All unsaved redemptions will be lost.", "Leaving the eStricted Section?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub frmLauncher_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'Read Book Table XML
        'Dim filePath As String = "G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Book.xml"
        Dim filePath As String = "Book.xml"
        BookDataSet.ReadXml(filePath)

        dgvBook.DataSource = BookDataSet
        dgvBook.DataMember = "book"

        With Me.dgvBook
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

        'Create columns for Book Table
        bookdt.Columns.Add("BookID", GetType(String))
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
        Dim filePath1 As String = "student.xml"
        StudentDataSet.ReadXml(filePath1)

        dgvStudent.DataSource = StudentDataSet
        dgvStudent.DataMember = "student"

        With Me.dgvStudent
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
        dt.Columns.Add("RedemptionDate", GetType(String))
        dt.Columns.Add("RedemptionID", GetType(String))
        dt.Columns.Add("BookID", GetType(String))
        dt.Columns.Add("BookTitle", GetType(String))
        dt.Columns.Add("StudentID", GetType(String))
        dt.Columns.Add("StudentName", GetType(String))

        'Load and Read Redemption XML
        'dt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Redemptions.xml")
        dt.ReadXml("Redemptions.xml")
        DataGridView3.DataSource = dt

        'Load and Read Student XML
        'studentdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml")
        studentdt.ReadXml("student.xml")
        dgvStudent.DataSource = studentdt

        'Load and Read Book XML
        'bookdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Book.xml")
        bookdt.ReadXml("Book.xml")
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
        DataGridView3.Sort(DataGridView3.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Save Redemption to XML
        dt = CType(DataGridView3.DataSource, DataTable)
        dt.AcceptChanges()
        'dt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Redemptions.xml", System.Data.XmlWriteMode.WriteSchema, False)
        dt.WriteXml("Redemptions.xml", System.Data.XmlWriteMode.WriteSchema, False)

        'Save Students to XML
        studentdt = CType(dgvStudent.DataSource, DataTable)
        studentdt.AcceptChanges()
        'studentdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml", System.Data.XmlWriteMode.WriteSchema, False)
        studentdt.WriteXml("student.xml", System.Data.XmlWriteMode.WriteSchema, False)

        'Save Books to XML
        bookdt = CType(dgvBook.DataSource, DataTable)
        bookdt.AcceptChanges()
        'bookdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\book.xml", System.Data.XmlWriteMode.WriteSchema, False)
        bookdt.WriteXml("book.xml", System.Data.XmlWriteMode.WriteSchema, False)

        'Inform user of successful saving of redemptions
        MessageBox.Show("Redemptions Saved.", "Saved Redemptions")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'Find Selected Row count
        Dim iRowIndex As Integer
        Dim total As Integer
        total = DataGridView3.RowCount - 3

        For i As Integer = 0 To Me.DataGridView3.SelectedCells.Count - 1
            iRowIndex = Me.DataGridView3.SelectedCells.Item(i).RowIndex
        Next

        'Delete Selected Record
        If DataGridView3.SelectedRows.Count > 0 And MessageBox.Show("Are you sure you want to delete this redemption?", "Delete Redemption", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If (iRowIndex) < (DataGridView3.RowCount - 1) Then
                DataGridView3.Rows.Remove(DataGridView3.SelectedRows(0))

                DataGridView3.Rows(total).Selected() = True
            End If
        End If

        'Save Redemption to XML
        dt = CType(DataGridView3.DataSource, DataTable)
        dt.AcceptChanges()
        'dt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Redemptions.xml", System.Data.XmlWriteMode.WriteSchema, False)
        dt.WriteXml("Redemptions.xml", System.Data.XmlWriteMode.WriteSchema, False)
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click, ReportToolStripMenuItem.Click
        'Load DataGridView from launcher page to Report page
        'Report.dgvReport.DataSource = DataGridView3.DataSource

        'Save Redemption to XML
        dt = CType(DataGridView3.DataSource, DataTable)
        dt.AcceptChanges()
        'dt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Redemptions.xml", System.Data.XmlWriteMode.WriteSchema, False)
        dt.WriteXml("Redemptions.xml", System.Data.XmlWriteMode.WriteSchema, False)

        Report.Show()


    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Save Redemption to XML
        dt = CType(DataGridView3.DataSource, DataTable)
        dt.AcceptChanges()
        'dt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Redemptions.xml", System.Data.XmlWriteMode.WriteSchema, False)
        dt.WriteXml("Redemptions.xml", System.Data.XmlWriteMode.WriteSchema, False)

        'Save Students to XML
        studentdt = CType(dgvStudent.DataSource, DataTable)
        studentdt.AcceptChanges()
        'studentdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml", System.Data.XmlWriteMode.WriteSchema, False)
        studentdt.WriteXml("student.xml", System.Data.XmlWriteMode.WriteSchema, False)

        'Save Books to XML
        bookdt = CType(dgvBook.DataSource, DataTable)
        bookdt.AcceptChanges()
        'bookdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\book.xml", System.Data.XmlWriteMode.WriteSchema, False)
        bookdt.WriteXml("book.xml", System.Data.XmlWriteMode.WriteSchema, False)

    End Sub

    Private Sub btnAddStudent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        'Display Add Student Form
        frmStudentAddition.Show()
        'Me.Hide()
    End Sub

    Private Sub btnRedeamAfterStudent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRedeamAfterStudent.Click

        'Order Redemption Id's in ascending order
        DataGridView3.Sort(DataGridView3.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

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
            bookID = CStr(dgvBook("BookID", selectedRowIndex1).Value)
        End If

        bookTitle = CStr(dgvBook("Title", selectedRowIndex1).Value)

        Dim id As String = Format(Date.Now(), "yyyyMMddHHmmssfff")

        Dim row As String()

        row = New String() {System.DateTime.Now.ToString("dd/MMMM/yyyy"), id, bookID, bookTitle, studentID, studentFirstName & " " & studentLastName}
        dt.Rows.Add(row)


        DataGridView3.DataSource = dt

        'Scroll to most recent redemption
        Me.DataGridView3.FirstDisplayedScrollingRowIndex = Me.DataGridView3.RowCount - 1

        'Select most recent redemption
        Me.DataGridView3.Rows(Me.DataGridView3.RowCount - 2).Selected = True
    End Sub

    Private Sub frmLauncher_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        'Call ClearTable(studentdt)
        'Call ClearTable(bookdt)

        ''Refresh Student Table
        ''Load and Read Student XML
        ''studentdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml")
        'studentdt.ReadXml("student.xml")
        'dgvStudent.DataSource = studentdt

        ''Refresh Book Table
        ''Load and Read Book XML
        ''bookdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\book.xml")
        'bookdt.ReadXml("book.xml")
        'dgvBook.DataSource = bookdt

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
        'Me.Hide()
    End Sub

    Private Sub txtStudentSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudentSearch.TextChanged

        Dim Flag As Boolean = True
        'Search Student Data Grid for imputed Name and Select it
        If Flag = True Then
            dgvStudent.ClearSelection()
            For Each row As DataGridViewRow In dgvStudent.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If Not IsNothing(cell.Value) Then
                        If cell.Value.ToString.StartsWith(txtStudentSearch.Text, StringComparison.InvariantCultureIgnoreCase) Then
                            cell.Selected = True
                            dgvStudent.CurrentCell = dgvStudent.SelectedCells(0)
                            'Exit For
                        End If
                    End If
                Next
            Next
        Else
            If txtStudentSearch.Text = "" Then
                dgvStudent.Rows(0).Selected = True
            End If
        End If
    End Sub

    Private Sub txtBookSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBookSearch.TextChanged

        Dim Flag As Boolean = True
        'Search Book Data Grid for imputed Title and Select it
        If Flag = True Then
            dgvBook.ClearSelection()
            For Each row As DataGridViewRow In dgvBook.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If Not IsNothing(cell.Value) Then
                        If cell.Value.ToString.StartsWith(txtBookSearch.Text, StringComparison.InvariantCultureIgnoreCase) Then
                            cell.Selected = True
                            dgvBook.CurrentCell = dgvBook.SelectedCells(0)
                            'Exit For
                        End If
                    End If
                Next
            Next
        Else
            If txtBookSearch.Text = "" Then
                dgvBook.Rows(0).Selected = True
            End If
        End If

    End Sub

End Class