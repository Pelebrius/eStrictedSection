Public Class frmStudentAddition
    Dim dt As New DataTable
    Dim studentid As Integer
    Dim studentdt As New DataTable("Student")
    Private Sub frmStudentAddition_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ''Make copy of launcher student table
        'Dim sourceGrid As DataGridView = frmLauncher.dgvStudent
        'Dim targetGrid As DataGridView = Me.dgvStudent

        ''Copy all rows and cells from student table.

        'Dim targetRows = New List(Of DataGridViewRow)

        'For Each sourceRow As DataGridViewRow In sourceGrid.Rows
        '    If (Not sourceRow.IsNewRow) Then

        '        Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)

        '        'The Clone method do not copy the cell values so we must do this manually.
        '        'See: https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridviewrow.clone(v=vs.110).aspx

        '        For Each cell As DataGridViewCell In sourceRow.Cells
        '            targetRow.Cells(cell.ColumnIndex).Value = cell.Value
        '        Next

        '        targetRows.Add(targetRow)
        '    End If
        'Next

        ''Clear target columns and then clone all source columns.

        'targetGrid.Columns.Clear()

        'For Each column As DataGridViewColumn In sourceGrid.Columns
        '    targetGrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
        'Next

        ''It's recommended to use the AddRange method (if available)
        ''when adding multiple items to a collection.

        'targetGrid.Rows.AddRange(targetRows.ToArray())

        'With Me.dgvStudent
        '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    .MultiSelect = False
        'End With

        ''Send copy of student table to launcher
        'Dim sourceGrid2 As DataGridView = dgvStudent
        'Dim targetgrid2 As DataGridView = frmLauncher.dgvStudent


        ''Copy all rows and cells of Student table to launcher page.

        'Dim targetRows2 = New List(Of DataGridViewRow)

        'For Each sourceRow As DataGridViewRow In sourceGrid.Rows
        '    If (Not sourceRow.IsNewRow) Then

        '        Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)

        '        'The Clone method do not copy the cell values so we must do this manually.
        '        'See: https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridviewrow.clone(v=vs.110).aspx

        '        For Each cell As DataGridViewCell In sourceRow.Cells
        '            targetRow.Cells(cell.ColumnIndex).Value = cell.Value
        '        Next

        '        targetRows2.Add(targetRow)
        '    End If
        'Next

        ''Clear target columns and then clone all source columns.

        'targetGrid.Columns.Clear()

        'For Each column As DataGridViewColumn In sourceGrid.Columns
        '    targetGrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
        'Next

        ''It's recommended to use the AddRange method (if available)
        ''when adding multiple items to a collection.

        'targetGrid.Rows.AddRange(targetRows.ToArray())




        'Create colums for student Table
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

        'Load and Read Student XML
        studentdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student - Copy.xml")
        dgvStudent.DataSource = studentdt

        'Generate Student ID
        studentid = dgvStudent.RowCount
        txtId.Text = studentid

    End Sub

    Private Sub btnAddStudent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        Dim grade As Integer
        'transferStudent = frmLauncher.studentdt
        grade = Val(Me.txtPass.Text)

        Dim row As String()
        row = (New String() {txtId.Text, txtFirstName.Text, txtLastName.Text, txtSchool.Text, grade, txtEmail.Text & "@Wiz.com"})
        studentdt.Rows.Add(row)

        dgvStudent.DataSource = studentdt

        'Clear display for new student information input
        Me.txtEmail.Text = Nothing
        Me.txtFirstName.Text = Nothing
        studentid = dgvStudent.RowCount
        Me.txtId.Text = studentid
        Me.txtLastName.Text = Nothing
        Me.txtSchool.Text = Nothing
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click, Me.FormClosing


        Me.Hide()
        frmLauncher.DataGridView2.Visible = False
        frmLauncher.dgvStudent.Visible = True
        frmLauncher.btnRedeamAfterStudent.Visible = True
        frmLauncher.btnFullRedeam.Visible = False

        'Save Students to XML
        studentdt = CType(dgvStudent.DataSource, DataTable)
        studentdt.AcceptChanges()
        studentdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student - Copy.xml", System.Data.XmlWriteMode.WriteSchema, False)

        ''Copy student table and send to launcher student table
        'Dim sourceGrid As DataGridView = dgvStudent
        'Dim targetGrid As DataGridView = frmLauncher.dgvStudent

        ''Copy all rows and cells.

        'Dim targetRows = New List(Of DataGridViewRow)

        'For Each sourceRow As DataGridViewRow In sourceGrid.Rows
        '    If (Not sourceRow.IsNewRow) Then

        '        Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)

        '        'The Clone method do not copy the cell values so we must do this manually.
        '        'See: https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridviewrow.clone(v=vs.110).aspx

        '        For Each cell As DataGridViewCell In sourceRow.Cells
        '            targetRow.Cells(cell.ColumnIndex).Value = cell.Value
        '        Next

        '        targetRows.Add(targetRow)
        '    End If
        'Next

        ''Clear target columns and then clone all source columns.

        'targetGrid.Columns.Clear()

        'For Each column As DataGridViewColumn In sourceGrid.Columns
        '    targetGrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
        'Next

        ''It's recommended to use the AddRange method (if available)
        ''when adding multiple items to a collection.

        'targetGrid.Rows.AddRange(targetRows.ToArray())

        With frmLauncher.dgvStudent
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
        frmLauncher.Show()
    End Sub

    Private Sub radFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radFirst.Click, radSecond.Click, radThird.Click, radFourth.Click, radFifth.Click, radSixth.Click, radSeventh.Click
        'Pass grade value to text box for easy access from other sub routine
        Dim radGradeClicked As RadioButton = sender
        Dim GradeClicked As Integer = Val(radGradeClicked.Tag)
        Me.txtPass.Text = GradeClicked
    End Sub
End Class