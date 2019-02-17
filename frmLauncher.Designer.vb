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
        Me.btnBookSearch = New System.Windows.Forms.Button()
        Me.btnStudentSearch = New System.Windows.Forms.Button()
        Me.btnBookTable = New System.Windows.Forms.Button()
        Me.btnStudentTable = New System.Windows.Forms.Button()
        Me.BookDataSet = New System.Data.DataSet()
        Me.StudentDataSet = New System.Data.DataSet()
        Me.btnFullRedeam = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.RedeamDataSet = New System.Data.DataSet()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.DsRedemtionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsRedeamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.btnRedeamAfterStudent = New System.Windows.Forms.Button()
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
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
        Me.txtBookSearch.Location = New System.Drawing.Point(748, 36)
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
        Me.lblPromptBook.Location = New System.Drawing.Point(621, 39)
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
        Me.lblPromptStudent.Location = New System.Drawing.Point(68, 37)
        Me.lblPromptStudent.Name = "lblPromptStudent"
        Me.lblPromptStudent.Size = New System.Drawing.Size(149, 32)
        Me.lblPromptStudent.TabIndex = 2
        Me.lblPromptStudent.Text = "Enter Student Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(First or Last)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtStudentSearch
        '
        Me.txtStudentSearch.Location = New System.Drawing.Point(218, 36)
        Me.txtStudentSearch.Name = "txtStudentSearch"
        Me.txtStudentSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStudentSearch.Size = New System.Drawing.Size(121, 20)
        Me.txtStudentSearch.TabIndex = 3
        '
        'btnBookSearch
        '
        Me.btnBookSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookSearch.Location = New System.Drawing.Point(694, 73)
        Me.btnBookSearch.Name = "btnBookSearch"
        Me.btnBookSearch.Size = New System.Drawing.Size(118, 23)
        Me.btnBookSearch.TabIndex = 4
        Me.btnBookSearch.Text = "Search Book"
        Me.btnBookSearch.UseVisualStyleBackColor = True
        Me.btnBookSearch.Visible = False
        '
        'btnStudentSearch
        '
        Me.btnStudentSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentSearch.Location = New System.Drawing.Point(144, 73)
        Me.btnStudentSearch.Name = "btnStudentSearch"
        Me.btnStudentSearch.Size = New System.Drawing.Size(118, 23)
        Me.btnStudentSearch.TabIndex = 5
        Me.btnStudentSearch.Text = "Search Student"
        Me.btnStudentSearch.UseVisualStyleBackColor = True
        Me.btnStudentSearch.Visible = False
        '
        'btnBookTable
        '
        Me.btnBookTable.Location = New System.Drawing.Point(487, 34)
        Me.btnBookTable.Name = "btnBookTable"
        Me.btnBookTable.Size = New System.Drawing.Size(84, 23)
        Me.btnBookTable.TabIndex = 8
        Me.btnBookTable.Text = "Book Table"
        Me.btnBookTable.UseVisualStyleBackColor = True
        '
        'btnStudentTable
        '
        Me.btnStudentTable.Location = New System.Drawing.Point(397, 33)
        Me.btnStudentTable.Name = "btnStudentTable"
        Me.btnStudentTable.Size = New System.Drawing.Size(84, 24)
        Me.btnStudentTable.TabIndex = 9
        Me.btnStudentTable.Text = "Student Table"
        Me.btnStudentTable.UseVisualStyleBackColor = True
        '
        'BookDataSet
        '
        Me.BookDataSet.DataSetName = "BookDataSet"
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "StudentDataSet"
        '
        'btnFullRedeam
        '
        Me.btnFullRedeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullRedeam.Location = New System.Drawing.Point(445, 171)
        Me.btnFullRedeam.Name = "btnFullRedeam"
        Me.btnFullRedeam.Size = New System.Drawing.Size(75, 23)
        Me.btnFullRedeam.TabIndex = 16
        Me.btnFullRedeam.Text = "Redeam"
        Me.btnFullRedeam.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(156, 346)
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
        Me.btnSave.Location = New System.Drawing.Point(445, 173)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(445, 211)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(425, 251)
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
        Me.MenuStrip.Size = New System.Drawing.Size(957, 29)
        Me.MenuStrip.TabIndex = 21
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.ReportToolStripMenuItem.Text = "Weekly Report"
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Location = New System.Drawing.Point(144, 306)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(108, 23)
        Me.btnAddStudent.TabIndex = 22
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnAddBook
        '
        Me.btnAddBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Location = New System.Drawing.Point(706, 306)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(108, 23)
        Me.btnAddBook.TabIndex = 23
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'dgvStudent
        '
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Location = New System.Drawing.Point(30, 102)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.Size = New System.Drawing.Size(367, 198)
        Me.dgvStudent.TabIndex = 24
        '
        'btnRedeamAfterStudent
        '
        Me.btnRedeamAfterStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRedeamAfterStudent.Location = New System.Drawing.Point(445, 137)
        Me.btnRedeamAfterStudent.Name = "btnRedeamAfterStudent"
        Me.btnRedeamAfterStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnRedeamAfterStudent.TabIndex = 25
        Me.btnRedeamAfterStudent.Text = "Redeam"
        Me.btnRedeamAfterStudent.UseVisualStyleBackColor = True
        '
        'dgvBook
        '
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Location = New System.Drawing.Point(571, 102)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.ReadOnly = True
        Me.dgvBook.Size = New System.Drawing.Size(356, 198)
        Me.dgvBook.TabIndex = 26
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.E_stricted_Section_edited_book_cover_logo
        Me.PictureBox2.Location = New System.Drawing.Point(851, 495)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(106, 91)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'frmLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BackgroundImage_Parchment
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(957, 600)
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
        Me.Controls.Add(Me.btnFullRedeam)
        Me.Controls.Add(Me.btnStudentTable)
        Me.Controls.Add(Me.btnBookTable)
        Me.Controls.Add(Me.btnStudentSearch)
        Me.Controls.Add(Me.btnBookSearch)
        Me.Controls.Add(Me.txtStudentSearch)
        Me.Controls.Add(Me.lblPromptStudent)
        Me.Controls.Add(Me.lblPromptBook)
        Me.Controls.Add(Me.txtBookSearch)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmLauncher"
        Me.Text = "E-stricted Section"
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
    Friend WithEvents btnBookSearch As System.Windows.Forms.Button
    Friend WithEvents btnStudentSearch As System.Windows.Forms.Button
    Friend WithEvents btnBookTable As System.Windows.Forms.Button
    Friend WithEvents btnStudentTable As System.Windows.Forms.Button
    Friend WithEvents BookDataSet As System.Data.DataSet
    Friend WithEvents StudentDataSet As System.Data.DataSet
    Friend WithEvents btnFullRedeam As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents RedeamDataSet As System.Data.DataSet
    Friend WithEvents DsRedemtionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsRedeamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents dgvStudent As System.Windows.Forms.DataGridView
    Friend WithEvents btnRedeamAfterStudent As System.Windows.Forms.Button
    Friend WithEvents dgvBook As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
