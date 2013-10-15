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
        Me.PilotosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New bd01.Database1DataSet()
        Me.CorridasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PilotosTableAdapter = New bd01.Database1DataSetTableAdapters.PilotosTableAdapter()
        Me.CorridasTableAdapter = New bd01.Database1DataSetTableAdapters.CorridasTableAdapter()
        Me.FKpilotoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassificacaoTableAdapter = New bd01.Database1DataSetTableAdapters.classificacaoTableAdapter()
        Me.FKpilotoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKpilotoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PilotosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorridasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKpilotoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKpilotoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKpilotoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.FKpilotoBindingSource2
        Me.ListBox1.DisplayMember = "id_corrida"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(152, 71)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "id"
        '
        'PilotosBindingSource
        '
        Me.PilotosBindingSource.DataMember = "Pilotos"
        Me.PilotosBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CorridasBindingSource
        '
        Me.CorridasBindingSource.DataMember = "Corridas"
        Me.CorridasBindingSource.DataSource = Me.Database1DataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PilotosBindingSource
        Me.ComboBox1.DisplayMember = "nome"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "id"
        '
        'PilotosTableAdapter
        '
        Me.PilotosTableAdapter.ClearBeforeFill = True
        '
        'CorridasTableAdapter
        '
        Me.CorridasTableAdapter.ClearBeforeFill = True
        '
        'FKpilotoBindingSource
        '
        Me.FKpilotoBindingSource.DataMember = "FK_piloto"
        Me.FKpilotoBindingSource.DataSource = Me.PilotosBindingSource
        '
        'ClassificacaoTableAdapter
        '
        Me.ClassificacaoTableAdapter.ClearBeforeFill = True
        '
        'FKpilotoBindingSource1
        '
        Me.FKpilotoBindingSource1.DataMember = "FK_piloto"
        Me.FKpilotoBindingSource1.DataSource = Me.PilotosBindingSource
        '
        'FKpilotoBindingSource2
        '
        Me.FKpilotoBindingSource2.DataMember = "FK_piloto"
        Me.FKpilotoBindingSource2.DataSource = Me.PilotosBindingSource
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 261)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PilotosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorridasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKpilotoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKpilotoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKpilotoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Database1DataSet As bd01.Database1DataSet
    Friend WithEvents PilotosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PilotosTableAdapter As bd01.Database1DataSetTableAdapters.PilotosTableAdapter
    Friend WithEvents CorridasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CorridasTableAdapter As bd01.Database1DataSetTableAdapters.CorridasTableAdapter
    Friend WithEvents FKpilotoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassificacaoTableAdapter As bd01.Database1DataSetTableAdapters.classificacaoTableAdapter
    Friend WithEvents FKpilotoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FKpilotoBindingSource2 As System.Windows.Forms.BindingSource
End Class
