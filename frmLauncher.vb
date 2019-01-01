'Riley Smith
'12/30/18
'Launcher
Imports System.Xml
Public Class frmLauncher
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


    End Sub

    Private Sub btnRedeamBook_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRedeamBook.Click
        'Selection of Book in Table
        Dim selectedRowCount As Integer = _
DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        Dim selectedRowIndex As Integer
        Dim testValue2 As String

        If selectedRowCount > 0 Then

            Dim sb As New System.Text.StringBuilder()

            Dim i As Integer
            For i = 0 To selectedRowCount - 1

                sb.Append("Row: ")
                sb.Append(DataGridView1.SelectedRows(i).Index.ToString())
                sb.Append(Environment.NewLine)
                'MessageBox.Show(DataGridView1.Rows(i).Cells(1).Value)
                selectedRowIndex = DataGridView1.SelectedRows(i).Index()
            Next i
            sb.Append("Total: " + selectedRowCount.ToString())
            MessageBox.Show(sb.ToString(), "Selected Rows")
            testValue2 = CStr(DataGridView1("Title", selectedRowIndex).Value)
            MessageBox.Show(testValue2, "Book Selected")
        End If

    End Sub
    Private Sub frmLauncher_Load_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Read Student Table XML
        Dim filePath As String = "G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml"
        StudentDataSet.ReadXml(filePath)

        DataGridView2.DataSource = StudentDataSet
        DataGridView2.DataMember = "student"

        With Me.DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
    End Sub

    Private Sub btnRedeamStudent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRedeamStudent.Click
        'Selection of Student in Table
        Dim selectedRowCount As Integer = _
DataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected)

        Dim selectedRowIndex As Integer
        Dim studentFirstName As String
        Dim studentLastName As String


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
            MessageBox.Show(sb.ToString(), "Selected Rows")
            studentFirstName = CStr(DataGridView2("First Name", selectedRowIndex).Value)
            studentLastName = CStr(DataGridView2("Last Name", selectedRowIndex).Value)
            MessageBox.Show(studentFirstName & " " & studentLastName, "Student Selected")
        End If

    End Sub

End Class