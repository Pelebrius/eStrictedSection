Public Class frmAddBook
    Dim bookId As Integer
    Public bookdt As New DataTable("Book")
    Private Sub frmAddBook_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        With dgvBook
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

        'Load and Read Book XML
        bookdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Book - Copy.xml")
        dgvBook.DataSource = bookdt

        'Generate Book ID
        bookId = dgvBook.RowCount
        txtBookID.Text = bookId
    End Sub

    Private Sub btnAddBook_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddBook.Click

        If txtBookTitle.Text = Nothing Or txtAuthor.Text = Nothing Or txtBookSubject.Text = Nothing Then
            ' Display a MsgBox asking the user to save changes or abort.
            If MessageBox.Show("Fileds have been left blank. Are you sure you want to continue adding this book?", "Blank Fields", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                Dim row As String()
                row = (New String() {txtBookID.Text, txtBookTitle.Text, txtAuthor.Text, txtBookSubject.Text})
                bookdt.Rows.Add(row)

                dgvBook.DataSource = bookdt

                'Clear display for new student information input
                Me.txtBookID.Text = Nothing
                Me.txtBookTitle.Text = Nothing
                bookId = dgvBook.RowCount
                Me.txtBookID.Text = bookId
                Me.txtAuthor.Text = Nothing
                Me.txtBookSubject.Text = Nothing
            End If
        Else
            Dim row As String()
            row = (New String() {txtBookID.Text, txtBookTitle.Text, txtAuthor.Text, txtBookSubject.Text})
            bookdt.Rows.Add(row)

            dgvBook.DataSource = bookdt

            'Clear display for new student information input
            Me.txtBookID.Text = Nothing
            Me.txtBookTitle.Text = Nothing
            bookId = dgvBook.RowCount
            Me.txtBookID.Text = bookId
            Me.txtAuthor.Text = Nothing
            Me.txtBookSubject.Text = Nothing
        End If

    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click, Me.FormClosing
        'Save Books to XML
        bookdt = CType(dgvBook.DataSource, DataTable)
        bookdt.AcceptChanges()
        bookdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\book - Copy.xml", System.Data.XmlWriteMode.WriteSchema, False)

        With frmLauncher.dgvBook
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

        frmLauncher.Show()
    End Sub
End Class