<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBook
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
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookSubject = New System.Windows.Forms.TextBox()
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.lblCurrentBooks = New System.Windows.Forms.Label()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.BackColor = System.Drawing.Color.Transparent
        Me.lblBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.Location = New System.Drawing.Point(12, 30)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(57, 13)
        Me.lblBookID.TabIndex = 0
        Me.lblBookID.Text = "Book ID:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 58)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(69, 13)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Book Title:"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.BackColor = System.Drawing.Color.Transparent
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(12, 85)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(48, 13)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "Author:"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(12, 111)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(87, 13)
        Me.lblSubject.TabIndex = 3
        Me.lblSubject.Text = "Book Subject:"
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(98, 30)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.ReadOnly = True
        Me.txtBookID.Size = New System.Drawing.Size(100, 20)
        Me.txtBookID.TabIndex = 4
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(98, 55)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtBookTitle.TabIndex = 5
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(98, 82)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(100, 20)
        Me.txtAuthor.TabIndex = 6
        '
        'txtBookSubject
        '
        Me.txtBookSubject.Location = New System.Drawing.Point(98, 108)
        Me.txtBookSubject.Name = "txtBookSubject"
        Me.txtBookSubject.Size = New System.Drawing.Size(100, 20)
        Me.txtBookSubject.TabIndex = 7
        '
        'dgvBook
        '
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Location = New System.Drawing.Point(12, 158)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.Size = New System.Drawing.Size(463, 150)
        Me.dgvBook.TabIndex = 8
        '
        'lblCurrentBooks
        '
        Me.lblCurrentBooks.AutoSize = True
        Me.lblCurrentBooks.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentBooks.Location = New System.Drawing.Point(12, 136)
        Me.lblCurrentBooks.Name = "lblCurrentBooks"
        Me.lblCurrentBooks.Size = New System.Drawing.Size(109, 16)
        Me.lblCurrentBooks.TabIndex = 9
        Me.lblCurrentBooks.Text = "Current Books:"
        '
        'btnAddBook
        '
        Me.btnAddBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Location = New System.Drawing.Point(384, 129)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(83, 23)
        Me.btnAddBook.TabIndex = 10
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.AddStudentImage_FourHouses
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(486, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.BookLayout
        Me.PictureBox1.Location = New System.Drawing.Point(204, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frmAddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BackgroundImage_Parchment
        Me.ClientSize = New System.Drawing.Size(486, 324)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.lblCurrentBooks)
        Me.Controls.Add(Me.dgvBook)
        Me.Controls.Add(Me.txtBookSubject)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtBookTitle)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblBookID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAddBook"
        Me.Text = "Add Book"
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBookID As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents txtBookID As System.Windows.Forms.TextBox
    Friend WithEvents txtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtBookSubject As System.Windows.Forms.TextBox
    Friend WithEvents dgvBook As System.Windows.Forms.DataGridView
    Friend WithEvents lblCurrentBooks As System.Windows.Forms.Label
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
