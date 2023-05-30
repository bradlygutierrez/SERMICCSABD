<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeneficiarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoinicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProyectoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SermiccsaDataSet = New Sermiccsa.sermiccsaDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectoTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.proyectoTableAdapter()
        Me.BeneficiarioTableAdapter1 = New Sermiccsa.sermiccsaDataSetTableAdapters.beneficiarioTableAdapter()
        Me.TableAdapterManager = New Sermiccsa.sermiccsaDataSetTableAdapters.TableAdapterManager()
        Me.ProyectoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(143, 164)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 416)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdusuarioDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechainicioDataGridViewTextBoxColumn, Me.BeneficiarioDataGridViewTextBoxColumn, Me.PresupuestoinicialDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProyectoBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1052, 416)
        Me.DataGridView1.TabIndex = 0
        '
        'IdusuarioDataGridViewTextBoxColumn
        '
        Me.IdusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.IdusuarioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.IdusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario"
        Me.IdusuarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdusuarioDataGridViewTextBoxColumn.Name = "IdusuarioDataGridViewTextBoxColumn"
        Me.IdusuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdusuarioDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.NombreDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DescripcionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 125
        '
        'FechainicioDataGridViewTextBoxColumn
        '
        Me.FechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.FechainicioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechainicioDataGridViewTextBoxColumn.HeaderText = "fecha_inicio"
        Me.FechainicioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechainicioDataGridViewTextBoxColumn.Name = "FechainicioDataGridViewTextBoxColumn"
        Me.FechainicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechainicioDataGridViewTextBoxColumn.Width = 125
        '
        'BeneficiarioDataGridViewTextBoxColumn
        '
        Me.BeneficiarioDataGridViewTextBoxColumn.DataPropertyName = "beneficiario"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.BeneficiarioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.BeneficiarioDataGridViewTextBoxColumn.HeaderText = "beneficiario"
        Me.BeneficiarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BeneficiarioDataGridViewTextBoxColumn.Name = "BeneficiarioDataGridViewTextBoxColumn"
        Me.BeneficiarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.BeneficiarioDataGridViewTextBoxColumn.Width = 125
        '
        'PresupuestoinicialDataGridViewTextBoxColumn
        '
        Me.PresupuestoinicialDataGridViewTextBoxColumn.DataPropertyName = "presupuesto_inicial"
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.PresupuestoinicialDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PresupuestoinicialDataGridViewTextBoxColumn.HeaderText = "presupuesto_inicial"
        Me.PresupuestoinicialDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PresupuestoinicialDataGridViewTextBoxColumn.Name = "PresupuestoinicialDataGridViewTextBoxColumn"
        Me.PresupuestoinicialDataGridViewTextBoxColumn.ReadOnly = True
        Me.PresupuestoinicialDataGridViewTextBoxColumn.Width = 125
        '
        'ProyectoBindingSource1
        '
        Me.ProyectoBindingSource1.DataMember = "proyecto"
        Me.ProyectoBindingSource1.DataSource = Me.SermiccsaDataSet
        '
        'SermiccsaDataSet
        '
        Me.SermiccsaDataSet.DataSetName = "sermiccsaDataSet"
        Me.SermiccsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1100, 89)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 39)
        Me.Button1.TabIndex = 18
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1049, 89)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 39)
        Me.Button2.TabIndex = 19
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox1.Location = New System.Drawing.Point(143, 89)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(400, 39)
        Me.TextBox1.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(543, 89)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 39)
        Me.Button3.TabIndex = 21
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(1152, 89)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(43, 39)
        Me.Button5.TabIndex = 22
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(1152, 617)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(43, 39)
        Me.Button4.TabIndex = 23
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(896, 617)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(1)
        Me.Label1.Size = New System.Drawing.Size(255, 39)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Imprimir Presupuesto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProyectoBindingSource
        '
        Me.ProyectoBindingSource.DataMember = "proyecto"
        Me.ProyectoBindingSource.DataSource = Me.SermiccsaDataSet
        '
        'ProyectoTableAdapter
        '
        Me.ProyectoTableAdapter.ClearBeforeFill = True
        '
        'BeneficiarioTableAdapter1
        '
        Me.BeneficiarioTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.beneficiarioTableAdapter = Me.BeneficiarioTableAdapter1
        Me.TableAdapterManager.etapaTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.gastoTableAdapter = Nothing
        Me.TableAdapterManager.preguntaTableAdapter = Nothing
        Me.TableAdapterManager.proyectoTableAdapter = Me.ProyectoTableAdapter
        Me.TableAdapterManager.rubroTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sermiccsa.sermiccsaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'ProyectoBindingSource2
        '
        Me.ProyectoBindingSource2.DataMember = "proyecto"
        Me.ProyectoBindingSource2.DataSource = Me.SermiccsaDataSet
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 681)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1359, 728)
        Me.MinimumSize = New System.Drawing.Size(1359, 728)
        Me.Name = "FormPrincipal"
        Me.Text = "FormPrincipal"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SermiccsaDataSet As sermiccsaDataSet
    Friend WithEvents ProyectoBindingSource As BindingSource
    Friend WithEvents ProyectoTableAdapter As sermiccsaDataSetTableAdapters.proyectoTableAdapter
    Friend WithEvents BeneficiarioTableAdapter1 As sermiccsaDataSetTableAdapters.beneficiarioTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProyectoBindingSource1 As BindingSource
    Friend WithEvents TableAdapterManager As sermiccsaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProyectoBindingSource2 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdusuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewButtonColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechainicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeneficiarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PresupuestoinicialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
