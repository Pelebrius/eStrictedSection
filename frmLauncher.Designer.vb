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
        Me.dsRedemtion = New WindowsApplication1.dsRedemtion()
        Me.DsRedemtionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsRedeamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedeamDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRedemtion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRedemtionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRedeamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBookSearch
        '
        Me.txtBookSearch.Location = New System.Drawing.Point(156, 31)
        Me.txtBookSearch.Name = "txtBookSearch"
        Me.txtBookSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBookSearch.Size = New System.Drawing.Size(138, 20)
        Me.txtBookSearch.TabIndex = 0
        '
        'lblPromptBook
        '
        Me.lblPromptBook.AutoSize = True
        Me.lblPromptBook.Location = New System.Drawing.Point(66, 34)
        Me.lblPromptBook.Name = "lblPromptBook"
        Me.lblPromptBook.Size = New System.Drawing.Size(85, 13)
        Me.lblPromptBook.TabIndex = 1
        Me.lblPromptBook.Text = "Enter book Title:"
        '
        'lblPromptStudent
        '
        Me.lblPromptStudent.AutoSize = True
        Me.lblPromptStudent.Location = New System.Drawing.Point(652, 34)
        Me.lblPromptStudent.Name = "lblPromptStudent"
        Me.lblPromptStudent.Size = New System.Drawing.Size(102, 13)
        Me.lblPromptStudent.TabIndex = 2
        Me.lblPromptStudent.Text = "Enter student name:"
        '
        'txtStudentSearch
        '
        Me.txtStudentSearch.Location = New System.Drawing.Point(760, 31)
        Me.txtStudentSearch.Name = "txtStudentSearch"
        Me.txtStudentSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStudentSearch.Size = New System.Drawing.Size(121, 20)
        Me.txtStudentSearch.TabIndex = 3
        '
        'btnBookSearch
        '
        Me.btnBookSearch.Location = New System.Drawing.Point(146, 98)
        Me.btnBookSearch.Name = "btnBookSearch"
        Me.btnBookSearch.Size = New System.Drawing.Size(96, 23)
        Me.btnBookSearch.TabIndex = 4
        Me.btnBookSearch.Text = "Search Book"
        Me.btnBookSearch.UseVisualStyleBackColor = True
        '
        'btnStudentSearch
        '
        Me.btnStudentSearch.Location = New System.Drawing.Point(731, 98)
        Me.btnStudentSearch.Name = "btnStudentSearch"
        Me.btnStudentSearch.Size = New System.Drawing.Size(96, 23)
        Me.btnStudentSearch.TabIndex = 5
        Me.btnStudentSearch.Text = "Search Student"
        Me.btnStudentSearch.UseVisualStyleBackColor = True
        '
        'lblBookResult
        '
        Me.lblBookResult.Location = New System.Drawing.Point(66, 54)
        Me.lblBookResult.Name = "lblBookResult"
        Me.lblBookResult.Size = New System.Drawing.Size(260, 41)
        Me.lblBookResult.TabIndex = 6
        Me.lblBookResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentResult
        '
        Me.lblStudentResult.Location = New System.Drawing.Point(652, 54)
        Me.lblStudentResult.Name = "lblStudentResult"
        Me.lblStudentResult.Size = New System.Drawing.Size(260, 41)
        Me.lblStudentResult.TabIndex = 7
        Me.lblStudentResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBookTable
        '
        Me.btnBookTable.Location = New System.Drawing.Point(403, 24)
        Me.btnBookTable.Name = "btnBookTable"
        Me.btnBookTable.Size = New System.Drawing.Size(75, 23)
        Me.btnBookTable.TabIndex = 8
        Me.btnBookTable.Text = "Book Table"
        Me.btnBookTable.UseVisualStyleBackColor = True
        '
        'btnStudentTable
        '
        Me.btnStudentTable.Location = New System.Drawing.Point(494, 24)
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
        Me.btnReadXml.Location = New System.Drawing.Point(111, 331)
        Me.btnReadXml.Name = "btnReadXml"
        Me.btnReadXml.Size = New System.Drawing.Size(107, 23)
        Me.btnReadXml.TabIndex = 11
        Me.btnReadXml.Text = "Refresh Book List"
        Me.btnReadXml.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(356, 191)
        Me.DataGridView1.TabIndex = 10
        '
        'btnReadXML2
        '
        Me.btnReadXML2.Location = New System.Drawing.Point(731, 331)
        Me.btnReadXML2.Name = "btnReadXML2"
        Me.btnReadXML2.Size = New System.Drawing.Size(111, 23)
        Me.btnReadXML2.TabIndex = 14
        Me.btnReadXML2.Text = "Refresh Student List"
        Me.btnReadXML2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(605, 134)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(367, 191)
        Me.DataGridView2.TabIndex = 13
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "StudentDataSet"
        '
        'btnFullRedeam
        '
        Me.btnFullRedeam.Location = New System.Drawing.Point(443, 179)
        Me.btnFullRedeam.Name = "btnFullRedeam"
        Me.btnFullRedeam.Size = New System.Drawing.Size(75, 23)
        Me.btnFullRedeam.TabIndex = 16
        Me.btnFullRedeam.Text = "Redeam"
        Me.btnFullRedeam.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(217, 360)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(559, 191)
        Me.DataGridView3.TabIndex = 17
        '
        'RedeamDataSet
        '
        Me.RedeamDataSet.DataSetName = "RedeamDataSet"
        '
        'dsRedemtion
        '
        Me.dsRedemtion.DataSetName = "dsRedemtion"
        Me.dsRedemtion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsRedemtionBindingSource
        '
        Me.DsRedemtionBindingSource.AllowNew = True
        Me.DsRedemtionBindingSource.DataSource = Me.dsRedemtion
        Me.DsRedemtionBindingSource.Position = 0
        '
        'dsRedeamBindingSource
        '
        Me.dsRedeamBindingSource.AllowNew = True
        Me.dsRedeamBindingSource.DataSource = Me.RedeamDataSet
        Me.dsRedeamBindingSource.Position = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(443, 217)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(443, 255)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 19
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'frmLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 612)
        Me.Controls.Add(Me.btnLoad)
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
        Me.Name = "frmLauncher"
        Me.Text = "Restricted Section"
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RedeamDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsRedemtion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRedemtionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsRedeamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dsRedemtion As WindowsApplication1.dsRedemtion
    Friend WithEvents DsRedemtionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsRedeamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
End Class
