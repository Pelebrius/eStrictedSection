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
        Me.lblBookResult = New System.Windows.Forms.Label()
        Me.lblStudentResult = New System.Windows.Forms.Label()
        Me.btnBookTable = New System.Windows.Forms.Button()
        Me.btnStudentTable = New System.Windows.Forms.Button()
        Me.BookDataSet = New System.Data.DataSet()
        Me.btnReadXml = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnReadXML2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
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
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedeamDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRedemtionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRedeamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBookSearch
        '
        Me.txtBookSearch.Location = New System.Drawing.Point(716, 31)
        Me.txtBookSearch.Name = "txtBookSearch"
        Me.txtBookSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBookSearch.Size = New System.Drawing.Size(138, 20)
        Me.txtBookSearch.TabIndex = 0
        '
        'lblPromptBook
        '
        Me.lblPromptBook.AutoSize = True
        Me.lblPromptBook.Location = New System.Drawing.Point(626, 34)
        Me.lblPromptBook.Name = "lblPromptBook"
        Me.lblPromptBook.Size = New System.Drawing.Size(85, 13)
        Me.lblPromptBook.TabIndex = 1
        Me.lblPromptBook.Text = "Enter book Title:"
        '
        'lblPromptStudent
        '
        Me.lblPromptStudent.AutoSize = True
        Me.lblPromptStudent.Location = New System.Drawing.Point(77, 34)
        Me.lblPromptStudent.Name = "lblPromptStudent"
        Me.lblPromptStudent.Size = New System.Drawing.Size(102, 13)
        Me.lblPromptStudent.TabIndex = 2
        Me.lblPromptStudent.Text = "Enter student name:"
        '
        'txtStudentSearch
        '
        Me.txtStudentSearch.Location = New System.Drawing.Point(185, 31)
        Me.txtStudentSearch.Name = "txtStudentSearch"
        Me.txtStudentSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStudentSearch.Size = New System.Drawing.Size(121, 20)
        Me.txtStudentSearch.TabIndex = 3
        '
        'btnBookSearch
        '
        Me.btnBookSearch.Location = New System.Drawing.Point(706, 98)
        Me.btnBookSearch.Name = "btnBookSearch"
        Me.btnBookSearch.Size = New System.Drawing.Size(96, 23)
        Me.btnBookSearch.TabIndex = 4
        Me.btnBookSearch.Text = "Search Book"
        Me.btnBookSearch.UseVisualStyleBackColor = True
        '
        'btnStudentSearch
        '
        Me.btnStudentSearch.Location = New System.Drawing.Point(156, 98)
        Me.btnStudentSearch.Name = "btnStudentSearch"
        Me.btnStudentSearch.Size = New System.Drawing.Size(96, 23)
        Me.btnStudentSearch.TabIndex = 5
        Me.btnStudentSearch.Text = "Search Student"
        Me.btnStudentSearch.UseVisualStyleBackColor = True
        '
        'lblBookResult
        '
        Me.lblBookResult.Location = New System.Drawing.Point(626, 54)
        Me.lblBookResult.Name = "lblBookResult"
        Me.lblBookResult.Size = New System.Drawing.Size(260, 41)
        Me.lblBookResult.TabIndex = 6
        Me.lblBookResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentResult
        '
        Me.lblStudentResult.Location = New System.Drawing.Point(77, 54)
        Me.lblStudentResult.Name = "lblStudentResult"
        Me.lblStudentResult.Size = New System.Drawing.Size(260, 41)
        Me.lblStudentResult.TabIndex = 7
        Me.lblStudentResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBookTable
        '
        Me.btnBookTable.Location = New System.Drawing.Point(478, 31)
        Me.btnBookTable.Name = "btnBookTable"
        Me.btnBookTable.Size = New System.Drawing.Size(75, 23)
        Me.btnBookTable.TabIndex = 8
        Me.btnBookTable.Text = "Book Table"
        Me.btnBookTable.UseVisualStyleBackColor = True
        '
        'btnStudentTable
        '
        Me.btnStudentTable.Location = New System.Drawing.Point(388, 31)
        Me.btnStudentTable.Name = "btnStudentTable"
        Me.btnStudentTable.Size = New System.Drawing.Size(84, 23)
        Me.btnStudentTable.TabIndex = 9
        Me.btnStudentTable.Text = "Student Table"
        Me.btnStudentTable.UseVisualStyleBackColor = True
        '
        'BookDataSet
        '
        Me.BookDataSet.DataSetName = "BookDataSet"
        '
        'btnReadXml
        '
        Me.btnReadXml.Location = New System.Drawing.Point(657, 331)
        Me.btnReadXml.Name = "btnReadXml"
        Me.btnReadXml.Size = New System.Drawing.Size(107, 23)
        Me.btnReadXml.TabIndex = 11
        Me.btnReadXml.Text = "Refresh Book List"
        Me.btnReadXml.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(571, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(356, 191)
        Me.DataGridView1.TabIndex = 10
        '
        'btnReadXML2
        '
        Me.btnReadXML2.Location = New System.Drawing.Point(200, 331)
        Me.btnReadXML2.Name = "btnReadXML2"
        Me.btnReadXML2.Size = New System.Drawing.Size(111, 23)
        Me.btnReadXML2.TabIndex = 14
        Me.btnReadXML2.Text = "Refresh Student List"
        Me.btnReadXML2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(30, 134)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(367, 191)
        Me.DataGridView2.TabIndex = 13
        Me.DataGridView2.Visible = False
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "StudentDataSet"
        '
        'btnFullRedeam
        '
        Me.btnFullRedeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullRedeam.Location = New System.Drawing.Point(445, 160)
        Me.btnFullRedeam.Name = "btnFullRedeam"
        Me.btnFullRedeam.Size = New System.Drawing.Size(75, 23)
        Me.btnFullRedeam.TabIndex = 16
        Me.btnFullRedeam.Text = "Redeam"
        Me.btnFullRedeam.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(200, 360)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(564, 229)
        Me.DataGridView3.TabIndex = 17
        '
        'RedeamDataSet
        '
        Me.RedeamDataSet.DataSetName = "NewDataSet"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(445, 198)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(445, 236)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(445, 274)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 20
        Me.btnReport.Text = "Report"
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
        Me.btnAddStudent.Location = New System.Drawing.Point(71, 331)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(108, 23)
        Me.btnAddStudent.TabIndex = 22
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnAddBook
        '
        Me.btnAddBook.Location = New System.Drawing.Point(778, 331)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(108, 23)
        Me.btnAddBook.TabIndex = 23
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'dgvStudent
        '
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Location = New System.Drawing.Point(30, 126)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.ReadOnly = True
        Me.dgvStudent.Size = New System.Drawing.Size(367, 198)
        Me.dgvStudent.TabIndex = 24
        '
        'btnRedeamAfterStudent
        '
        Me.btnRedeamAfterStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRedeamAfterStudent.Location = New System.Drawing.Point(445, 162)
        Me.btnRedeamAfterStudent.Name = "btnRedeamAfterStudent"
        Me.btnRedeamAfterStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnRedeamAfterStudent.TabIndex = 25
        Me.btnRedeamAfterStudent.Text = "Redeam"
        Me.btnRedeamAfterStudent.UseVisualStyleBackColor = True
        '
        'dgvBook
        '
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Location = New System.Drawing.Point(571, 134)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.ReadOnly = True
        Me.dgvBook.Size = New System.Drawing.Size(356, 191)
        Me.dgvBook.TabIndex = 26
        '
        'frmLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BackgroundImage_Parchment
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(957, 600)
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
        Me.Controls.Add(Me.btnReadXML2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btnReadXml)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnStudentTable)
        Me.Controls.Add(Me.btnBookTable)
        Me.Controls.Add(Me.lblStudentResult)
        Me.Controls.Add(Me.lblBookResult)
        Me.Controls.Add(Me.btnStudentSearch)
        Me.Controls.Add(Me.btnBookSearch)
        Me.Controls.Add(Me.txtStudentSearch)
        Me.Controls.Add(Me.lblPromptStudent)
        Me.Controls.Add(Me.lblPromptBook)
        Me.Controls.Add(Me.txtBookSearch)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmLauncher"
        Me.Text = "Restricted Section"
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RedeamDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRedemtionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsRedeamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBookSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblPromptBook As System.Windows.Forms.Label
    Friend WithEvents lblPromptStudent As System.Windows.Forms.Label
    Friend WithEvents txtStudentSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnBookSearch As System.Windows.Forms.Button
    Friend WithEvents btnStudentSearch As System.Windows.Forms.Button
    Friend WithEvents lblBookResult As System.Windows.Forms.Label
    Friend WithEvents lblStudentResult As System.Windows.Forms.Label
    Friend WithEvents btnBookTable As System.Windows.Forms.Button
    Friend WithEvents btnStudentTable As System.Windows.Forms.Button
    Friend WithEvents BookDataSet As System.Data.DataSet
    Friend WithEvents btnReadXml As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnReadXML2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
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
End Class
