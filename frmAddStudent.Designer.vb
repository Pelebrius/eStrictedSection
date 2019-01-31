<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentAddition
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentAddition))
        Me.StudentDataSet = New System.Data.DataSet()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtSchool = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblSchool = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.grpGrade = New System.Windows.Forms.GroupBox()
        Me.radSeventh = New System.Windows.Forms.RadioButton()
        Me.radSixth = New System.Windows.Forms.RadioButton()
        Me.radFifth = New System.Windows.Forms.RadioButton()
        Me.radFourth = New System.Windows.Forms.RadioButton()
        Me.radThird = New System.Windows.Forms.RadioButton()
        Me.radSecond = New System.Windows.Forms.RadioButton()
        Me.radFirst = New System.Windows.Forms.RadioButton()
        Me.lblCurrentStudents = New System.Windows.Forms.Label()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbSchool = New System.Windows.Forms.ComboBox()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGrade.SuspendLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "StudentDataSet"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(81, 32)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(81, 115)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(81, 141)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 4
        '
        'txtSchool
        '
        Me.txtSchool.Location = New System.Drawing.Point(81, 167)
        Me.txtSchool.Name = "txtSchool"
        Me.txtSchool.Size = New System.Drawing.Size(100, 20)
        Me.txtSchool.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEmail.Location = New System.Drawing.Point(81, 195)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 7
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(9, 35)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(72, 13)
        Me.lblId.TabIndex = 8
        Me.lblId.Text = "Student ID:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(9, 118)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(71, 13)
        Me.lblFirstName.TabIndex = 9
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(9, 144)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(71, 13)
        Me.lblLastName.TabIndex = 10
        Me.lblLastName.Text = "Last Name:"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.BackColor = System.Drawing.Color.Transparent
        Me.lblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(9, 74)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(37, 13)
        Me.lblGrade.TabIndex = 11
        Me.lblGrade.Text = "Year:"
        '
        'lblSchool
        '
        Me.lblSchool.AutoSize = True
        Me.lblSchool.BackColor = System.Drawing.Color.Transparent
        Me.lblSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchool.Location = New System.Drawing.Point(9, 170)
        Me.lblSchool.Name = "lblSchool"
        Me.lblSchool.Size = New System.Drawing.Size(50, 13)
        Me.lblSchool.TabIndex = 12
        Me.lblSchool.Text = "School:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(9, 198)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 13)
        Me.lblEmail.TabIndex = 13
        Me.lblEmail.Text = "E-Mail:"
        '
        'grpGrade
        '
        Me.grpGrade.BackColor = System.Drawing.Color.Transparent
        Me.grpGrade.Controls.Add(Me.radSeventh)
        Me.grpGrade.Controls.Add(Me.radSixth)
        Me.grpGrade.Controls.Add(Me.radFifth)
        Me.grpGrade.Controls.Add(Me.radFourth)
        Me.grpGrade.Controls.Add(Me.radThird)
        Me.grpGrade.Controls.Add(Me.radSecond)
        Me.grpGrade.Controls.Add(Me.radFirst)
        Me.grpGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGrade.Location = New System.Drawing.Point(54, 55)
        Me.grpGrade.Name = "grpGrade"
        Me.grpGrade.Size = New System.Drawing.Size(419, 55)
        Me.grpGrade.TabIndex = 14
        Me.grpGrade.TabStop = False
        Me.grpGrade.Text = "Select Year:"
        '
        'radSeventh
        '
        Me.radSeventh.AutoSize = True
        Me.radSeventh.Location = New System.Drawing.Point(343, 19)
        Me.radSeventh.Name = "radSeventh"
        Me.radSeventh.Size = New System.Drawing.Size(72, 17)
        Me.radSeventh.TabIndex = 7
        Me.radSeventh.TabStop = True
        Me.radSeventh.Tag = "7"
        Me.radSeventh.Text = "Seventh"
        Me.radSeventh.UseVisualStyleBackColor = True
        '
        'radSixth
        '
        Me.radSixth.AutoSize = True
        Me.radSixth.Location = New System.Drawing.Point(289, 19)
        Me.radSixth.Name = "radSixth"
        Me.radSixth.Size = New System.Drawing.Size(53, 17)
        Me.radSixth.TabIndex = 6
        Me.radSixth.TabStop = True
        Me.radSixth.Tag = "6"
        Me.radSixth.Text = "Sixth"
        Me.radSixth.UseVisualStyleBackColor = True
        '
        'radFifth
        '
        Me.radFifth.AutoSize = True
        Me.radFifth.Location = New System.Drawing.Point(238, 19)
        Me.radFifth.Name = "radFifth"
        Me.radFifth.Size = New System.Drawing.Size(50, 17)
        Me.radFifth.TabIndex = 5
        Me.radFifth.TabStop = True
        Me.radFifth.Tag = "5"
        Me.radFifth.Text = "Fifth"
        Me.radFifth.UseVisualStyleBackColor = True
        '
        'radFourth
        '
        Me.radFourth.AutoSize = True
        Me.radFourth.Location = New System.Drawing.Point(177, 19)
        Me.radFourth.Name = "radFourth"
        Me.radFourth.Size = New System.Drawing.Size(61, 17)
        Me.radFourth.TabIndex = 3
        Me.radFourth.TabStop = True
        Me.radFourth.Tag = "4"
        Me.radFourth.Text = "Fourth"
        Me.radFourth.UseVisualStyleBackColor = True
        '
        'radThird
        '
        Me.radThird.AutoSize = True
        Me.radThird.Location = New System.Drawing.Point(122, 19)
        Me.radThird.Name = "radThird"
        Me.radThird.Size = New System.Drawing.Size(54, 17)
        Me.radThird.TabIndex = 2
        Me.radThird.TabStop = True
        Me.radThird.Tag = "3"
        Me.radThird.Text = "Third"
        Me.radThird.UseVisualStyleBackColor = True
        '
        'radSecond
        '
        Me.radSecond.AutoSize = True
        Me.radSecond.Location = New System.Drawing.Point(54, 19)
        Me.radSecond.Name = "radSecond"
        Me.radSecond.Size = New System.Drawing.Size(68, 17)
        Me.radSecond.TabIndex = 1
        Me.radSecond.TabStop = True
        Me.radSecond.Tag = "2"
        Me.radSecond.Text = "Second"
        Me.radSecond.UseVisualStyleBackColor = True
        '
        'radFirst
        '
        Me.radFirst.AutoSize = True
        Me.radFirst.Location = New System.Drawing.Point(4, 19)
        Me.radFirst.Name = "radFirst"
        Me.radFirst.Size = New System.Drawing.Size(49, 17)
        Me.radFirst.TabIndex = 0
        Me.radFirst.TabStop = True
        Me.radFirst.Tag = "1"
        Me.radFirst.Text = "First"
        Me.radFirst.UseVisualStyleBackColor = True
        '
        'lblCurrentStudents
        '
        Me.lblCurrentStudents.AutoSize = True
        Me.lblCurrentStudents.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentStudents.Location = New System.Drawing.Point(9, 223)
        Me.lblCurrentStudents.Name = "lblCurrentStudents"
        Me.lblCurrentStudents.Size = New System.Drawing.Size(125, 16)
        Me.lblCurrentStudents.TabIndex = 15
        Me.lblCurrentStudents.Text = "Current Students:"
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Location = New System.Drawing.Point(356, 193)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(97, 23)
        Me.btnAddStudent.TabIndex = 16
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'dgvStudent
        '
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Location = New System.Drawing.Point(12, 241)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.Size = New System.Drawing.Size(461, 168)
        Me.dgvStudent.TabIndex = 17
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.AddStudentImage_FourHouses
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 25)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(55, 21)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(81, -11)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(11, 20)
        Me.txtPass.TabIndex = 20
        Me.txtPass.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.HogwartsCrest
        Me.PictureBox1.Location = New System.Drawing.Point(213, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'cmbSchool
        '
        Me.cmbSchool.FormattingEnabled = True
        Me.cmbSchool.Items.AddRange(New Object() {"Hogwarts", "Beauxbatons", "Castelobruxo", "Durmstrang", "Ilvermorny", "Mahoutokoro", "Uagadou"})
        Me.cmbSchool.Location = New System.Drawing.Point(81, 166)
        Me.cmbSchool.Name = "cmbSchool"
        Me.cmbSchool.Size = New System.Drawing.Size(100, 21)
        Me.cmbSchool.TabIndex = 23
        '
        'frmStudentAddition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 425)
        Me.Controls.Add(Me.cmbSchool)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.lblCurrentStudents)
        Me.Controls.Add(Me.grpGrade)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblSchool)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSchool)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtPass)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmStudentAddition"
        Me.Text = "Add Student"
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGrade.ResumeLayout(False)
        Me.grpGrade.PerformLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentDataSet As System.Data.DataSet
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtSchool As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents lblSchool As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents grpGrade As System.Windows.Forms.GroupBox
    Friend WithEvents radSeventh As System.Windows.Forms.RadioButton
    Friend WithEvents radSixth As System.Windows.Forms.RadioButton
    Friend WithEvents radFifth As System.Windows.Forms.RadioButton
    Friend WithEvents radFourth As System.Windows.Forms.RadioButton
    Friend WithEvents radThird As System.Windows.Forms.RadioButton
    Friend WithEvents radSecond As System.Windows.Forms.RadioButton
    Friend WithEvents radFirst As System.Windows.Forms.RadioButton
    Friend WithEvents lblCurrentStudents As System.Windows.Forms.Label
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents dgvStudent As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbSchool As System.Windows.Forms.ComboBox
End Class
