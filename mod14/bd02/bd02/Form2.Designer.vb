<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Database1DataSet = New bd02.Database1DataSet()
        Me.RestaurantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantesTableAdapter = New bd02.Database1DataSetTableAdapters.RestaurantesTableAdapter()
        Me.FkrestaurantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvaliacoesTableAdapter = New bd02.Database1DataSetTableAdapters.avaliacoesTableAdapter()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FkrestaurantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.RestaurantesBindingSource
        Me.ListBox1.DisplayMember = "nome"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "id"
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.FkrestaurantesBindingSource
        Me.ListBox2.DisplayMember = "texto"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(152, 40)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 1
        Me.ListBox2.ValueMember = "id_restaurante"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RestaurantesBindingSource
        '
        Me.RestaurantesBindingSource.DataMember = "Restaurantes"
        Me.RestaurantesBindingSource.DataSource = Me.Database1DataSet
        '
        'RestaurantesTableAdapter
        '
        Me.RestaurantesTableAdapter.ClearBeforeFill = True
        '
        'FkrestaurantesBindingSource
        '
        Me.FkrestaurantesBindingSource.DataMember = "fk_restaurantes"
        Me.FkrestaurantesBindingSource.DataSource = Me.RestaurantesBindingSource
        '
        'AvaliacoesTableAdapter
        '
        Me.AvaliacoesTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FkrestaurantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Database1DataSet As bd02.Database1DataSet
    Friend WithEvents RestaurantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RestaurantesTableAdapter As bd02.Database1DataSetTableAdapters.RestaurantesTableAdapter
    Friend WithEvents FkrestaurantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AvaliacoesTableAdapter As bd02.Database1DataSetTableAdapters.avaliacoesTableAdapter
End Class
