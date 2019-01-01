<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookTable
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
        Me.BookDataSet = New System.Data.DataSet()
        Me.btnRedeamBook = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReadXml
        '
        Me.btnReadXml.Location = New System.Drawing.Point(47, 197)
        Me.btnReadXml.Name = "btnReadXml"
        Me.btnReadXml.Size = New System.Drawing.Size(75, 23)
        Me.btnReadXml.TabIndex = 6
        Me.btnReadXml.Text = "Read XML"
        Me.btnReadXml.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(310, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'BookDataSet
        '
        Me.BookDataSet.DataSetName = "BookDataSet"
        '
        'btnRedeamBook
        '
        Me.btnRedeamBook.Location = New System.Drawing.Point(192, 197)
        Me.btnRedeamBook.Name = "btnRedeamBook"
        Me.btnRedeamBook.Size = New System.Drawing.Size(83, 23)
        Me.btnRedeamBook.TabIndex = 7
        Me.btnRedeamBook.Text = "Redeam Book"
        Me.btnRedeamBook.UseVisualStyleBackColor = True
        '
        'BookTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 261)
        Me.Controls.Add(Me.btnRedeamBook)
        Me.Controls.Add(Me.btnReadXml)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "BookTable"
        Me.Text = "Book Table"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReadXml As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BookDataSet As System.Data.DataSet
    Friend WithEvents btnRedeamBook As System.Windows.Forms.Button
End Class
