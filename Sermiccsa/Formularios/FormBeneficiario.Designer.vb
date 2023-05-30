<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBeneficiario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tbIdBeneficiario = New System.Windows.Forms.TextBox()
        Me.BeneficiarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SermiccsaDataSet = New Sermiccsa.sermiccsaDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_idBeneficiario = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lbl_identificacion = New System.Windows.Forms.Label()
        Me.BeneficiarioTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.beneficiarioTableAdapter()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.labelContador = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.BeneficiarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbIdBeneficiario
        '
        Me.tbIdBeneficiario.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbIdBeneficiario.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BeneficiarioBindingSource, "id_beneficiario", True))
        Me.tbIdBeneficiario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiarioBindingSource, "id_beneficiario", True))
        Me.tbIdBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdBeneficiario.Location = New System.Drawing.Point(182, 92)
        Me.tbIdBeneficiario.Margin = New System.Windows.Forms.Padding(4)
        Me.tbIdBeneficiario.Name = "tbIdBeneficiario"
        Me.tbIdBeneficiario.Size = New System.Drawing.Size(292, 19)
        Me.tbIdBeneficiario.TabIndex = 25
        '
        'BeneficiarioBindingSource
        '
        Me.BeneficiarioBindingSource.DataMember = "beneficiario"
        Me.BeneficiarioBindingSource.DataSource = Me.SermiccsaDataSet
        '
        'SermiccsaDataSet
        '
        Me.SermiccsaDataSet.DataSetName = "sermiccsaDataSet"
        Me.SermiccsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label3.Location = New System.Drawing.Point(-99, 287)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Etapa:"
        '
        'lbl_idBeneficiario
        '
        Me.lbl_idBeneficiario.AutoSize = True
        Me.lbl_idBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idBeneficiario.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lbl_idBeneficiario.Location = New System.Drawing.Point(28, 92)
        Me.lbl_idBeneficiario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_idBeneficiario.Name = "lbl_idBeneficiario"
        Me.lbl_idBeneficiario.Size = New System.Drawing.Size(118, 20)
        Me.lbl_idBeneficiario.TabIndex = 23
        Me.lbl_idBeneficiario.Text = "Id Beneficiario: "
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(89, 24)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(343, 26)
        Me.lblTitulo.TabIndex = 22
        Me.lblTitulo.Text = "FORMULARIO BENEFICIARIO"
        '
        'tbNombre
        '
        Me.tbNombre.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BeneficiarioBindingSource, "nombre", True))
        Me.tbNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiarioBindingSource, "nombre", True))
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(182, 142)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(292, 19)
        Me.tbNombre.TabIndex = 27
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lbl_nombre.Location = New System.Drawing.Point(28, 142)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(73, 20)
        Me.lbl_nombre.TabIndex = 26
        Me.lbl_nombre.Text = "Nombre: "
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BeneficiarioBindingSource, "identificacion", True))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiarioBindingSource, "identificacion", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(182, 196)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(292, 19)
        Me.TextBox2.TabIndex = 29
        '
        'lbl_identificacion
        '
        Me.lbl_identificacion.AutoSize = True
        Me.lbl_identificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_identificacion.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lbl_identificacion.Location = New System.Drawing.Point(28, 196)
        Me.lbl_identificacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_identificacion.Name = "lbl_identificacion"
        Me.lbl_identificacion.Size = New System.Drawing.Size(111, 20)
        Me.lbl_identificacion.TabIndex = 28
        Me.lbl_identificacion.Text = "Identificacion: "
        '
        'BeneficiarioTableAdapter
        '
        Me.BeneficiarioTableAdapter.ClearBeforeFill = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Black
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Location = New System.Drawing.Point(348, 237)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(65, 29)
        Me.btnEliminar.TabIndex = 72
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'labelContador
        '
        Me.labelContador.AutoSize = True
        Me.labelContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelContador.ForeColor = System.Drawing.Color.White
        Me.labelContador.Location = New System.Drawing.Point(227, 288)
        Me.labelContador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelContador.Name = "labelContador"
        Me.labelContador.Size = New System.Drawing.Size(49, 13)
        Me.labelContador.TabIndex = 71
        Me.labelContador.Text = "10 de 56"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Black
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSiguiente.Location = New System.Drawing.Point(348, 279)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(65, 29)
        Me.btnSiguiente.TabIndex = 70
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Black
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAnterior.Location = New System.Drawing.Point(103, 279)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(65, 29)
        Me.btnAnterior.TabIndex = 69
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Black
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(103, 237)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(65, 29)
        Me.btnEditar.TabIndex = 68
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Black
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.Location = New System.Drawing.Point(224, 237)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(65, 29)
        Me.btnGuardar.TabIndex = 67
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'FormBeneficiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 341)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.labelContador)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lbl_identificacion)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.tbIdBeneficiario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_idBeneficiario)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FormBeneficiario"
        Me.Text = "Formulario Beneficiario"
        CType(Me.BeneficiarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbIdBeneficiario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_idBeneficiario As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbl_identificacion As Label
    Friend WithEvents SermiccsaDataSet As sermiccsaDataSet
    Friend WithEvents BeneficiarioBindingSource As BindingSource
    Friend WithEvents BeneficiarioTableAdapter As sermiccsaDataSetTableAdapters.beneficiarioTableAdapter
    Friend WithEvents btnEliminar As Button
    Friend WithEvents labelContador As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
End Class
