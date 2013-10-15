<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database1DataSet = New bd01.Database1DataSet()
        Me.PilotosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PilotosTableAdapter = New bd01.Database1DataSetTableAdapters.PilotosTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PilotosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.PaisDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PilotosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 157)
        Me.DataGridView1.TabIndex = 0
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PilotosBindingSource
        '
        Me.PilotosBindingSource.DataMember = "Pilotos"
        Me.PilotosBindingSource.DataSource = Me.Database1DataSet
        '
        'PilotosTableAdapter
        '
        Me.PilotosTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        '
        'PaisDataGridViewTextBoxColumn
        '
        Me.PaisDataGridViewTextBoxColumn.DataPropertyName = "pais"
        Me.PaisDataGridViewTextBoxColumn.HeaderText = "pais"
        Me.PaisDataGridViewTextBoxColumn.Name = "PaisDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ver Corridas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(160, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 27)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Sair"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PilotosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet As bd01.Database1DataSet
    Friend WithEvents PilotosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PilotosTableAdapter As bd01.Database1DataSetTableAdapters.PilotosTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
