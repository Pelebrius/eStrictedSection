
Public Class BookTable

    Private Sub btnReadXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadXml.Click
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
End Class