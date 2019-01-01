<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentTable
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
        Me.btnReadXml = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentDataSet = New System.Data.DataSet()
        Me.btnRedeamStudent = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReadXml
        '
        Me.btnReadXml.Location = New System.Drawing.Point(39, 199)
        Me.btnReadXml.Name = "btnReadXml"
        Me.btnReadXml.Size = New System.Drawing.Size(75, 23)
        Me.btnReadXml.TabIndex = 8
        Me.btnReadXml.Text = "Read XML"
        Me.btnReadXml.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(310, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "StudentDataSet"
        '
        'btnRedeamStudent
        '
        Me.btnRedeamStudent.Location = New System.Drawing.Point(200, 199)
        Me.btnRedeamStudent.Name = "btnRedeamStudent"
        Me.btnRedeamStudent.Size = New System.Drawing.Size(102, 23)
        Me.btnRedeamStudent.TabIndex = 9
        Me.btnRedeamStudent.Text = "Redeam Student"
        Me.btnRedeamStudent.UseVisualStyleBackColor = True
        '
        'StudentTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 261)
        Me.Controls.Add(Me.btnRedeamStudent)
        Me.Controls.Add(Me.btnReadXml)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "StudentTable"
        Me.Text = "Student Table"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReadXml As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StudentDataSet As System.Data.DataSet
    Friend WithEvents btnRedeamStudent As System.Windows.Forms.Button
End Class
