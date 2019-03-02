<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLauncher
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
        Me.components = New System.ComponentModel.Container()
        Me.txtBookSearch = New System.Windows.Forms.TextBox()
        Me.lblPromptBook = New System.Windows.Forms.Label()
        Me.lblPromptStudent = New System.Windows.Forms.Label()
        Me.txtStudentSearch = New System.Windows.Forms.TextBox()
        Me.BookDataSet = New System.Data.DataSet()
        Me.StudentDataSet = New System.Data.DataSet()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.RedeamDataSet = New System.Data.DataSet()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.DsRedemtionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsRedeamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.btnRedeamAfterStudent = New System.Windows.Forms.Button()
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblStudentTable = New System.Windows.Forms.Label()
        Me.lblBookTable = New System.Windows.Forms.Label()
        Me.lbleStrictedSection = New System.Windows.Forms.Label()
        Me.lblRedemptions = New System.Windows.Forms.Label()
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedeamDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRedemtionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRedeamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBookSearch
        '
        Me.txtBookSearch.Location = New System.Drawing.Point(799, 38)
        Me.txtBookSearch.Name = "txtBookSearch"
        Me.txtBookSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBookSearch.Size = New System.Drawing.Size(138, 20)
        Me.txtBookSearch.TabIndex = 0
        '
        'lblPromptBook
        '
        Me.lblPromptBook.AutoSize = True
        Me.lblPromptBook.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptBook.Location = New System.Drawing.Point(672, 41)
        Me.lblPromptBook.Name = "lblPromptBook"
        Me.lblPromptBook.Size = New System.Drawing.Size(122, 16)
        Me.lblPromptBook.TabIndex = 1
        Me.lblPromptBook.Text = "Enter book Title:"
        '
        'lblPromptStudent
        '
        Me.lblPromptStudent.AutoSize = True
        Me.lblPromptStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptStudent.Location = New System.Drawing.Point(27, 39)
        Me.lblPromptStudent.Name = "lblPromptStudent"
        Me.lblPromptStudent.Size = New System.Drawing.Size(149, 32)
        Me.lblPromptStudent.TabIndex = 2
        Me.lblPromptStudent.Text = "Enter Student Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(First or Last)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtStudentSearch
        '
        Me.txtStudentSearch.Location = New System.Drawing.Point(182, 39)
        Me.txtStudentSearch.Name = "txtStudentSearch"
        Me.txtStudentSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStudentSearch.Size = New System.Drawing.Size(121, 20)
        Me.txtStudentSearch.TabIndex = 3
        '
        'BookDataSet
        '
        Me.BookDataSet.DataSetName = "BookDataSet"
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "StudentDataSet"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(149, 341)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(662, 240)
        Me.DataGridView3.TabIndex = 17
        '
        'RedeamDataSet
        '
        Me.RedeamDataSet.DataSetName = "NewDataSet"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(445, 168)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(445, 206)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(425, 246)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(117, 23)
        Me.btnReport.TabIndex = 20
        Me.btnReport.Text = "Weekly Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.AddStudentImage_FourHouses
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(967, 29)
        Me.MenuStrip.TabIndex = 21
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.ReportToolStripMenuItem.Text = "Weekly Report"
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Location = New System.Drawing.Point(144, 301)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(108, 23)
        Me.btnAddStudent.TabIndex = 22
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnAddBook
        '
        Me.btnAddBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Location = New System.Drawing.Point(706, 301)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(108, 23)
        Me.btnAddBook.TabIndex = 23
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'dgvStudent
        '
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Location = New System.Drawing.Point(30, 99)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.Size = New System.Drawing.Size(354, 198)
        Me.dgvStudent.TabIndex = 24
        '
        'btnRedeamAfterStudent
        '
        Me.btnRedeamAfterStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRedeamAfterStudent.Location = New System.Drawing.Point(445, 132)
        Me.btnRedeamAfterStudent.Name = "btnRedeamAfterStudent"
        Me.btnRedeamAfterStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnRedeamAfterStudent.TabIndex = 25
        Me.btnRedeamAfterStudent.Text = "Redeam"
        Me.btnRedeamAfterStudent.UseVisualStyleBackColor = True
        '
        'dgvBook
        '
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Location = New System.Drawing.Point(583, 97)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.Size = New System.Drawing.Size(354, 198)
        Me.dgvBook.TabIndex = 26
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.E_stricted_Section_edited_book_cover_logo
        Me.PictureBox2.Location = New System.Drawing.Point(851, 490)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(106, 91)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'lblStudentTable
        '
        Me.lblStudentTable.AutoSize = True
        Me.lblStudentTable.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentTable.Location = New System.Drawing.Point(154, 76)
        Me.lblStudentTable.Name = "lblStudentTable"
        Me.lblStudentTable.Size = New System.Drawing.Size(82, 20)
        Me.lblStudentTable.TabIndex = 29
        Me.lblStudentTable.Text = "Students"
        '
        'lblBookTable
        '
        Me.lblBookTable.AutoSize = True
        Me.lblBookTable.BackColor = System.Drawing.Color.Transparent
        Me.lblBookTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTable.Location = New System.Drawing.Point(725, 76)
        Me.lblBookTable.Name = "lblBookTable"
        Me.lblBookTable.Size = New System.Drawing.Size(59, 20)
        Me.lblBookTable.TabIndex = 30
        Me.lblBookTable.Text = "Books"
        '
        'lbleStrictedSection
        '
        Me.lbleStrictedSection.AutoSize = True
        Me.lbleStrictedSection.BackColor = System.Drawing.Color.Transparent
        Me.lbleStrictedSection.Font = New System.Drawing.Font("PMingLiU-ExtB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleStrictedSection.Location = New System.Drawing.Point(345, 38)
        Me.lbleStrictedSection.Name = "lbleStrictedSection"
        Me.lbleStrictedSection.Size = New System.Drawing.Size(292, 32)
        Me.lbleStrictedSection.TabIndex = 31
        Me.lbleStrictedSection.Text = "The eStricted Section"
        '
        'lblRedemptions
        '
        Me.lblRedemptions.AutoSize = True
        Me.lblRedemptions.BackColor = System.Drawing.Color.Transparent
        Me.lblRedemptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRedemptions.Location = New System.Drawing.Point(399, 314)
        Me.lblRedemptions.Name = "lblRedemptions"
        Me.lblRedemptions.Size = New System.Drawing.Size(171, 20)
        Me.lblRedemptions.TabIndex = 32
        Me.lblRedemptions.Text = "eBook Redemptions"
        '
        'frmLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BackgroundImage_Parchment
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(967, 600)
        Me.Controls.Add(Me.lblRedemptions)
        Me.Controls.Add(Me.lbleStrictedSection)
        Me.Controls.Add(Me.lblBookTable)
        Me.Controls.Add(Me.lblStudentTable)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dgvBook)
        Me.Controls.Add(Me.btnRedeamAfterStudent)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.txtStudentSearch)
        Me.Controls.Add(Me.lblPromptStudent)
        Me.Controls.Add(Me.lblPromptBook)
        Me.Controls.Add(Me.txtBookSearch)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmLauncher"
        Me.Text = "eStricted Section"
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RedeamDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRedemtionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsRedeamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBookSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblPromptBook As System.Windows.Forms.Label
    Friend WithEvents lblPromptStudent As System.Windows.Forms.Label
    Friend WithEvents txtStudentSearch As System.Windows.Forms.TextBox
    Friend WithEvents BookDataSet As System.Data.DataSet
    Friend WithEvents StudentDataSet As System.Data.DataSet
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents RedeamDataSet As System.Data.DataSet
    Friend WithEvents DsRedemtionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsRedeamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents dgvStudent As System.Windows.Forms.DataGridView
    Friend WithEvents btnRedeamAfterStudent As System.Windows.Forms.Button
    Friend WithEvents dgvBook As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblStudentTable As System.Windows.Forms.Label
    Friend WithEvents lblBookTable As System.Windows.Forms.Label
    Friend WithEvents lbleStrictedSection As System.Windows.Forms.Label
    Friend WithEvents lblRedemptions As System.Windows.Forms.Label
End Class
