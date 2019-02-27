Public Class StudentTable

    Private Sub StudentTable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim filePath As String = "G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml"
        StudentDataSet.ReadXml(filePath)

        DataGridView1.DataSource = StudentDataSet
        DataGridView1.DataMember = "student"

        With Me.DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click, Me.FormClosing
        Me.Hide()
    End Sub
End Class