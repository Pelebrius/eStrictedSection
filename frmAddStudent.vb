Imports System.Text.RegularExpressions

Public Class frmStudentAddition
    Dim dt As New DataTable
    Dim studentid As Integer
    Dim studentdt As New DataTable("Student")
    Private Sub frmStudentAddition_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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

        If txtFirstName.Text = Nothing Or txtLastName.Text = Nothing Or cmbSchool.Text = Nothing Or txtEmail.Text = Nothing Or txtPass.Text = Nothing Then
            ' Display a MsgBox asking the user to save changes or abort.
            If MessageBox.Show("Fileds have been left blank. Are you sure you want to continue adding this student?", "Blank Fields", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim grade As Integer
                grade = Val(Me.txtPass.Text)

                Dim row As String()
                row = (New String() {txtId.Text, txtFirstName.Text, txtLastName.Text, cmbSchool.Text, grade, txtEmail.Text})
                studentdt.Rows.Add(row)

                dgvStudent.DataSource = studentdt

                'Clear display for new student information input
                Me.txtEmail.Text = Nothing
                Me.txtFirstName.Text = Nothing
                studentid = dgvStudent.RowCount
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
            End If
        Else
            Dim grade As Integer
            grade = Val(Me.txtPass.Text)

            Dim row As String()
            row = (New String() {txtId.Text, txtFirstName.Text, txtLastName.Text, cmbSchool.Text, grade, txtEmail.Text})
            studentdt.Rows.Add(row)

            dgvStudent.DataSource = studentdt

            'Clear display for new student information input
            Me.txtEmail.Text = Nothing
            Me.txtFirstName.Text = Nothing
            studentid = dgvStudent.RowCount
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
        End If


    End Sub

    'Private Sub HomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click, Me.FormClosing
    Private Sub HomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click, Me.FormClosing

        Me.Hide()

        'Save Students to XML
        studentdt = CType(dgvStudent.DataSource, DataTable)
        studentdt.AcceptChanges()
        studentdt.WriteXml("G:\FBLA Coding\FBLA 2018 Coding and Programming\FBLA 2018 Coding and Programming\student - Copy.xml", System.Data.XmlWriteMode.WriteSchema, False)

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
    Private Sub txtemail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        'Determine whether entered E-mail is valid (with @ symbol)
        Dim email As String = txtEmail.Text
        If EmailAddressCheck(email) = False Then

            Dim result As DialogResult _
            = MessageBox.Show("The email address you entered is not valid." & _
                                       " Do you want to re-enter it?", "Invalid Email Address", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If

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


End Class