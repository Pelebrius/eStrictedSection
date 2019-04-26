<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.lblReportTitle = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnNextWeek = New System.Windows.Forms.Button()
        Me.btnPriorWeek = New System.Windows.Forms.Button()
        Me.lblStartWeek = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnReturnToHome = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReport
        '
        Me.txtReport.BackColor = System.Drawing.Color.Tan
        Me.txtReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReport.Location = New System.Drawing.Point(30, 191)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = True
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReport.Size = New System.Drawing.Size(371, 393)
        Me.txtReport.TabIndex = 2
        '
        'lblReportTitle
        '
        Me.lblReportTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblReportTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportTitle.Location = New System.Drawing.Point(12, 28)
        Me.lblReportTitle.Name = "lblReportTitle"
        Me.lblReportTitle.Size = New System.Drawing.Size(409, 33)
        Me.lblReportTitle.TabIndex = 3
        Me.lblReportTitle.Text = "Weekly Report: Student Book Assignments"
        Me.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.Tan
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(12, 89)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(114, 20)
        Me.txtDate.TabIndex = 4
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBookTitle
        '
        Me.lblBookTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBookTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.Location = New System.Drawing.Point(179, 165)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(100, 23)
        Me.lblBookTitle.TabIndex = 5
        Me.lblBookTitle.Text = "Book Title"
        Me.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentName
        '
        Me.lblStudentName.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(26, 165)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(131, 23)
        Me.lblStudentName.TabIndex = 6
        Me.lblStudentName.Text = "Student Name"
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.AddStudentImage_FourHouses
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(435, 25)
        Me.MenuStrip.TabIndex = 19
        Me.MenuStrip.Text = "MenuStrip1"
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
        'dgvReport
        '
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(16, 31)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.Size = New System.Drawing.Size(35, 24)
        Me.dgvReport.TabIndex = 0
        Me.dgvReport.Visible = False
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(12, 142)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpStart.TabIndex = 20
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(222, 142)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpEnd.TabIndex = 21
        '
        'btnNextWeek
        '
        Me.btnNextWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextWeek.Location = New System.Drawing.Point(222, 113)
        Me.btnNextWeek.Name = "btnNextWeek"
        Me.btnNextWeek.Size = New System.Drawing.Size(104, 23)
        Me.btnNextWeek.TabIndex = 23
        Me.btnNextWeek.Text = "Next Week >"
        Me.btnNextWeek.UseVisualStyleBackColor = True
        '
        'btnPriorWeek
        '
        Me.btnPriorWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPriorWeek.Location = New System.Drawing.Point(107, 113)
        Me.btnPriorWeek.Name = "btnPriorWeek"
        Me.btnPriorWeek.Size = New System.Drawing.Size(105, 23)
        Me.btnPriorWeek.TabIndex = 24
        Me.btnPriorWeek.Text = "< Prior Week"
        Me.btnPriorWeek.UseVisualStyleBackColor = True
        '
        'lblStartWeek
        '
        Me.lblStartWeek.AutoSize = True
        Me.lblStartWeek.BackColor = System.Drawing.Color.Transparent
        Me.lblStartWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartWeek.Location = New System.Drawing.Point(13, 123)
        Me.lblStartWeek.Name = "lblStartWeek"
        Me.lblStartWeek.Size = New System.Drawing.Size(77, 16)
        Me.lblStartWeek.TabIndex = 25
        Me.lblStartWeek.Text = "Start Date"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(351, 123)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(72, 16)
        Me.lblEndDate.TabIndex = 26
        Me.lblEndDate.Text = "End Date"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(30, 590)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(126, 23)
        Me.btnRefresh.TabIndex = 27
        Me.btnRefresh.Text = "Refresh Report"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(275, 590)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(126, 23)
        Me.btnReset.TabIndex = 28
        Me.btnReset.Text = "Reset Report"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnReturnToHome
        '
        Me.btnReturnToHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnToHome.Location = New System.Drawing.Point(131, 60)
        Me.btnReturnToHome.Name = "btnReturnToHome"
        Me.btnReturnToHome.Size = New System.Drawing.Size(172, 23)
        Me.btnReturnToHome.TabIndex = 29
        Me.btnReturnToHome.Text = "Return to Home Page"
        Me.btnReturnToHome.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(435, 622)
        Me.Controls.Add(Me.btnReturnToHome)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartWeek)
        Me.Controls.Add(Me.btnPriorWeek)
        Me.Controls.Add(Me.btnNextWeek)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblBookTitle)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblReportTitle)
        Me.Controls.Add(Me.txtReport)
        Me.Controls.Add(Me.dgvReport)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.TopMost = True
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReport As System.Windows.Forms.TextBox
    Friend WithEvents lblReportTitle As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents lblBookTitle As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNextWeek As System.Windows.Forms.Button
    Friend WithEvents btnPriorWeek As System.Windows.Forms.Button
    Friend WithEvents lblStartWeek As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnReturnToHome As System.Windows.Forms.Button
End Class
