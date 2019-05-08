Imports System.Text.RegularExpressions

Public Class frmStudentAddition
    Dim dt As New DataTable
    Dim studentid As Integer
    Dim studentdt As New DataTable("Student")
    Private Sub frmStudentAddition_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Create colums for student Table
        studentdt.Columns.Add("Student ID", GetType(Integer))
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

        With Me.dgvStudent
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

        'Load and Read Student XML
        'studentdt.ReadXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml")
        studentdt.ReadXml("student.xml")
        dgvStudent.DataSource = studentdt

        'Generate Student ID
        studentid = Val(dgvStudent.RowCount)
        txtId.Text = studentid

        'Sort Table by most recent student
        Me.dgvStudent.Sort(Me.dgvStudent.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btnAddStudent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click

        If txtFirstName.Text = Nothing Or txtLastName.Text = Nothing Or cmbSchool.Text = Nothing Or txtEmail.Text = Nothing Or txtPass.Text = Nothing Then
            ' Display a MsgBox asking the user to save changes or abort.
            MessageBox.Show("Cannot Add Student. Fields Left Blank.", "Blank Fields")
        ElseIf txtFirstName.Text <> Nothing And txtLastName.Text <> Nothing And cmbSchool.Text <> Nothing And txtEmail.Text <> Nothing And txtPass.Text <> Nothing Then
            Dim grade As Integer
            grade = Val(Me.txtPass.Text)

            Dim row As String()
            row = (New String() {txtId.Text, txtFirstName.Text, txtLastName.Text, cmbSchool.Text, grade, txtEmail.Text})
            studentdt.Rows.Add(row)

            Me.dgvStudent.DataSource = studentdt

            'Sort Table by most recent student
            Me.dgvStudent.Sort(Me.dgvStudent.Columns(0), System.ComponentModel.ListSortDirection.Descending)

            'Select most recent student
            Me.dgvStudent.Rows(0).Selected = True

            'Update table on main page

            'Save Students to XML
            studentdt = CType(dgvStudent.DataSource, DataTable)
            studentdt.AcceptChanges()
            'studentdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml", System.Data.XmlWriteMode.WriteSchema, False)
            studentdt.WriteXml("student.xml", System.Data.XmlWriteMode.WriteSchema, False)

            Call ClearTable(frmLauncher.studentdt)

            frmLauncher.studentdt.ReadXml("student.xml")

            'Clear display for new student information input
            Me.txtEmail.Text = Nothing
            Me.txtFirstName.Text = Nothing
            studentid = Val(dgvStudent.RowCount)
            Me.txtId.Text = studentid
            Me.txtLastName.Text = Nothing
            Me.cmbSchool.Text = Nothing
            Me.radFirst.Checked = False
            Me.radSecond.Checked = False
            Me.radThird.Checked = False
            Me.radFourth.Checked = False
            Me.radFifth.Checked = False
            Me.radSixth.Checked = False
            Me.radSeventh.Checked = False

            'Select most recent student
            Me.dgvStudent.Rows(0).Selected = True

            'Display to user a successful addition
            MessageBox.Show("Student Successfully Added.", "Success")

        End If

    End Sub

    'Private Sub HomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click, Me.FormClosing
    Private Sub HomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click, Me.FormClosing, btnReturnToHome.Click

        Me.Hide()

        'Save Students to XML
        studentdt = CType(dgvStudent.DataSource, DataTable)
        studentdt.AcceptChanges()
        'studentdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student.xml", System.Data.XmlWriteMode.WriteSchema, False)
        studentdt.WriteXml("student.xml", System.Data.XmlWriteMode.WriteSchema, False)

        With frmLauncher.dgvStudent
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

    End Sub

    Private Sub radFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radFirst.Click, radSecond.Click, radThird.Click, radFourth.Click, radFifth.Click, radSixth.Click, radSeventh.Click
        'Pass grade value to text box for easy access from other sub routine
        Dim radGradeClicked As RadioButton = sender
        Dim GradeClicked As Integer = Val(radGradeClicked.Tag)
        Me.txtPass.Text = GradeClicked
    End Sub
    Private Sub txtemail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        'Determine whether entered E-mail is valid (with @ symbol)
        Dim email As String = txtEmail.Text
        If EmailAddressCheck(email) = False Then

            Dim result As DialogResult _
            = MessageBox.Show("The email address you entered is not valid.", "Invalid Email Address")
            e.Cancel = True
        End If

    End Sub

    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" & _
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True

        Else
            EmailAddressCheck = False

        End If
    End Function

    Private Sub frmStudentAddition_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        'Sort Table by most recent student
        Me.dgvStudent.Sort(Me.dgvStudent.Columns(0), System.ComponentModel.ListSortDirection.Descending)
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
End Class