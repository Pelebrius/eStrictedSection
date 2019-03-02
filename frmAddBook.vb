Public Class frmAddBook
    Dim bookId As Integer
    Public bookdt As New DataTable("Book")
    Private Sub frmAddBook_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Create columns for Book Table
        bookdt.Columns.Add("BookID", GetType(Integer))
        bookdt.Columns.Add("Title", GetType(String))
        bookdt.Columns.Add("Author", GetType(String))
        bookdt.Columns.Add("Subject", GetType(String))

        With dgvBook
            .DataSource = bookdt
            .AllowUserToAddRows = True : .AllowUserToDeleteRows = True
            .AllowUserToOrderColumns = False : .AllowUserToResizeRows = True
        End With

        With dgvBook
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

        With Me.dgvBook
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With


        'Load and Read Book XML
        'bookdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Book.xml")
        bookdt.ReadXml("Book.xml")
        dgvBook.DataSource = bookdt

        'Generate Book ID
        bookId = dgvBook.RowCount
        txtBookID.Text = bookId

        'Sort Table by most recent book
        Me.dgvBook.Sort(Me.dgvBook.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btnAddBook_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddBook.Click



        If txtBookTitle.Text = Nothing Or txtAuthor.Text = Nothing Or txtBookSubject.Text = Nothing Then
            ' Display a MsgBox asking the user to save changes or abort.
            MessageBox.Show("Cannot Add Book. Fields Left Blank.", "Blank Fields")
        ElseIf txtBookTitle.Text <> Nothing And txtAuthor.Text <> Nothing And txtBookSubject.Text <> Nothing Then
            Dim row As String()
            row = (New String() {txtBookID.Text, txtBookTitle.Text, txtAuthor.Text, txtBookSubject.Text})
            bookdt.Rows.Add(row)

            Me.dgvBook.DataSource = bookdt

            'Sort Table by most recent book
            Me.dgvBook.Sort(Me.dgvBook.Columns(0), System.ComponentModel.ListSortDirection.Descending)

            'Select most recent book
            Me.dgvBook.Rows(0).Selected = True

            'Update table on main page

            'Save Books to XML
            bookdt = CType(dgvBook.DataSource, DataTable)
            bookdt.AcceptChanges()
            'bookdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\book.xml", System.Data.XmlWriteMode.WriteSchema, False)
            bookdt.WriteXml("book.xml", System.Data.XmlWriteMode.WriteSchema, False)

            frmLauncher.bookdt.ReadXml("book.xml")

            'Clear display for new student information input
            Me.txtBookID.Text = Nothing
            Me.txtBookTitle.Text = Nothing
            bookId = dgvBook.RowCount
            Me.txtBookID.Text = bookId
            Me.txtAuthor.Text = Nothing
            Me.txtBookSubject.Text = Nothing

            'Display to user a successful addition
            MessageBox.Show("Book Successfully Added.", "Success")
        End If

    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click, Me.FormClosing, btnReturnToHome.Click

        Me.Hide()

        'Save Books to XML
        bookdt = CType(dgvBook.DataSource, DataTable)
        bookdt.AcceptChanges()
        'bookdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\book.xml", System.Data.XmlWriteMode.WriteSchema, False)
        bookdt.WriteXml("book.xml", System.Data.XmlWriteMode.WriteSchema, False)

        With frmLauncher.dgvBook
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

    End Sub

    Private Sub frmAddBook_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        'Sort Table by most recent book
        Me.dgvBook.Sort(Me.dgvBook.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub
End Class