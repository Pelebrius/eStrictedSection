'Riley Smith
'1/1/19
'Redemtion
Public Class Redemtion

    Private Sub Redemtion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim filePath As String = "G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\Redemption.xml"
        RedeamDataSet.ReadXml(filePath)

        DataGridView3.DataSource = RedeamDataSet
        DataGridView3.DataMember = "redemptionXML"

        With Me.DataGridView3
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
    End Sub
End Class