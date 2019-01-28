Public Class Report
    Private Sub Report_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtDate.Text = Now.Date

        'Order incoming Data Table
        dgvReport.Sort(dgvReport.Columns(4), System.ComponentModel.ListSortDirection.Ascending)

        'Report information in text box
        'Only one name for redeamed books
        Dim lbl As New Label
        Dim currentName As String = Nothing
        Dim newName As String

        For Each row As DataGridViewRow In dgvReport.Rows
            If Not row.IsNewRow Then

                newName = (row.Cells("StudentName").Value.ToString)

                If Equals(currentName, newName) = True Then
                    Me.txtReport.AppendText(vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                Else
                    Me.txtReport.AppendText(row.Cells("StudentName").Value.ToString & Environment.NewLine)
                    Me.txtReport.AppendText(vbTab & row.Cells("BookTitle").Value.ToString & Environment.NewLine)
                End If

                currentName = newName
            End If
        Next
    End Sub


End Class