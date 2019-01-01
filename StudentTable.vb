Public Class StudentTable
    Private Sub btnReadXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadXml.Click
        Dim filePath As String = "G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml"
        StudentDataSet.ReadXml(filePath)

        DataGridView1.DataSource = StudentDataSet
        DataGridView1.DataMember = "student"

        With Me.DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
    End Sub

    Private Sub btnRedeamStudent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRedeamStudent.Click

        Dim selectedRowCount As Integer = _
DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        Dim selectedRowIndex As Integer
        Dim studentFirstName As String
        Dim studentLastName As String


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
            studentFirstName = CStr(DataGridView1("First Name", selectedRowIndex).Value)
            studentLastName = CStr(DataGridView1("Last Name", selectedRowIndex).Value)
            MessageBox.Show(studentFirstName & " " & studentLastName, "Student Selected")
        End If

    End Sub
End Class