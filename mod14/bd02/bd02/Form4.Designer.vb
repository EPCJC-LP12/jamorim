<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New bd02.Database1DataSet()
        Me.DataTable1TableAdapter = New bd02.Database1DataSetTableAdapters.DataTable1TableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataTable1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataTable1BindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Database1DataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable1BindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(74, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(35, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data:"
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = true
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.DataTable1BindingSource1
        Me.ListBox1.DisplayMember = "nome"
        Me.ListBox1.FormattingEnabled = true
        Me.ListBox1.Location = New System.Drawing.Point(83, 111)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.ValueMember = "classificacao"
        '
        'DataTable1BindingSource1
        '
        Me.DataTable1BindingSource1.DataMember = "DataTable1"
        Me.DataTable1BindingSource1.DataSource = Me.Database1DataSet
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataTable1BindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Database1DataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable1BindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet As bd02.Database1DataSet
    Friend WithEvents DataTable1TableAdapter As bd02.Database1DataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DataTable1BindingSource1 As System.Windows.Forms.BindingSource
End Class
