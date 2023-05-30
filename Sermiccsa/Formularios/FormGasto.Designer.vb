<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGasto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGasto))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.GastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SermiccsaDataSet = New Sermiccsa.sermiccsaDataSet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbIR = New System.Windows.Forms.TextBox()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblIR = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tbIVA = New System.Windows.Forms.TextBox()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.tbSubtotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblBeneficiario = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.tbReferencia = New System.Windows.Forms.TextBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.cbEtapa = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.lblNombreGasto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GastoTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.gastoTableAdapter()
        Me.FacturaTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.facturaTableAdapter()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BeneficiarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeneficiarioTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.beneficiarioTableAdapter()
        Me.RubroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RubroTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.rubroTableAdapter()
        Me.GastoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.FacturaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EtapaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EtapaTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.etapaTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.GastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RubroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtapaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(831, 580)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 24)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "No. Registro"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(968, 570)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 38)
        Me.Button6.TabIndex = 72
        Me.Button6.Text = "Siguiente"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button7.Location = New System.Drawing.Point(717, 570)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(111, 38)
        Me.Button7.TabIndex = 71
        Me.Button7.Text = "Anterior"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(1025, 508)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(111, 38)
        Me.Button5.TabIndex = 70
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(907, 508)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 38)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(661, 508)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 38)
        Me.Button3.TabIndex = 68
        Me.Button3.Text = "Editar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(783, 508)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 38)
        Me.Button4.TabIndex = 67
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'cbRubro
        '
        Me.cbRubro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "id_rubro", True))
        Me.cbRubro.DataSource = Me.RubroBindingSource
        Me.cbRubro.DisplayMember = "nombre"
        Me.cbRubro.FormattingEnabled = True
        Me.cbRubro.Location = New System.Drawing.Point(803, 420)
        Me.cbRubro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(328, 24)
        Me.cbRubro.TabIndex = 25
        Me.cbRubro.ValueMember = "nombre"
        '
        'GastoBindingSource
        '
        Me.GastoBindingSource.DataMember = "gasto"
        Me.GastoBindingSource.DataSource = Me.SermiccsaDataSet
        '
        'SermiccsaDataSet
        '
        Me.SermiccsaDataSet.DataSetName = "sermiccsaDataSet"
        Me.SermiccsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label13.Location = New System.Drawing.Point(675, 416)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 25)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Rubro:"
        '
        'tbIR
        '
        Me.tbIR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource1, "id_factura", True))
        Me.tbIR.Location = New System.Drawing.Point(803, 316)
        Me.tbIR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbIR.Multiline = True
        Me.tbIR.Name = "tbIR"
        Me.tbIR.Size = New System.Drawing.Size(328, 24)
        Me.tbIR.TabIndex = 21
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "factura"
        Me.FacturaBindingSource.DataSource = Me.SermiccsaDataSet
        '
        'lblIR
        '
        Me.lblIR.AutoSize = True
        Me.lblIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIR.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblIR.Location = New System.Drawing.Point(675, 316)
        Me.lblIR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIR.Name = "lblIR"
        Me.lblIR.Size = New System.Drawing.Size(36, 25)
        Me.lblIR.TabIndex = 20
        Me.lblIR.Text = "IR:"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(803, 267)
        Me.tbTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbTotal.Multiline = True
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(328, 24)
        Me.tbTotal.TabIndex = 19
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotal.Location = New System.Drawing.Point(675, 265)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(62, 25)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "Total:"
        '
        'tbIVA
        '
        Me.tbIVA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource1, "iva", True))
        Me.tbIVA.Location = New System.Drawing.Point(803, 212)
        Me.tbIVA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbIVA.Multiline = True
        Me.tbIVA.Name = "tbIVA"
        Me.tbIVA.Size = New System.Drawing.Size(328, 24)
        Me.tbIVA.TabIndex = 17
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVA.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblIVA.Location = New System.Drawing.Point(675, 207)
        Me.lblIVA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(51, 25)
        Me.lblIVA.TabIndex = 16
        Me.lblIVA.Text = "IVA:"
        '
        'tbSubtotal
        '
        Me.tbSubtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource1, "subtotal", True))
        Me.tbSubtotal.Location = New System.Drawing.Point(803, 155)
        Me.tbSubtotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbSubtotal.Multiline = True
        Me.tbSubtotal.Name = "tbSubtotal"
        Me.tbSubtotal.Size = New System.Drawing.Size(329, 24)
        Me.tbSubtotal.TabIndex = 15
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblSubtotal.Location = New System.Drawing.Point(675, 155)
        Me.lblSubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(90, 25)
        Me.lblSubtotal.TabIndex = 14
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblBeneficiario
        '
        Me.lblBeneficiario.AutoSize = True
        Me.lblBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeneficiario.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblBeneficiario.Location = New System.Drawing.Point(675, 368)
        Me.lblBeneficiario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBeneficiario.Name = "lblBeneficiario"
        Me.lblBeneficiario.Size = New System.Drawing.Size(119, 25)
        Me.lblBeneficiario.TabIndex = 12
        Me.lblBeneficiario.Text = "Beneficiario:"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "descripcion", True))
        Me.tbDescripcion.Location = New System.Drawing.Point(296, 315)
        Me.tbDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDescripcion.Multiline = True
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(329, 77)
        Me.tbDescripcion.TabIndex = 11
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblDescripcion.Location = New System.Drawing.Point(153, 316)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(120, 25)
        Me.lblDescripcion.TabIndex = 10
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'tbReferencia
        '
        Me.tbReferencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "id_factura", True))
        Me.tbReferencia.Location = New System.Drawing.Point(296, 265)
        Me.tbReferencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbReferencia.Multiline = True
        Me.tbReferencia.Name = "tbReferencia"
        Me.tbReferencia.Size = New System.Drawing.Size(329, 24)
        Me.tbReferencia.TabIndex = 9
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferencia.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblReferencia.Location = New System.Drawing.Point(153, 262)
        Me.lblReferencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(111, 25)
        Me.lblReferencia.TabIndex = 8
        Me.lblReferencia.Text = "Referencia:"
        '
        'cbEtapa
        '
        Me.cbEtapa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource1, "id_etapa", True))
        Me.cbEtapa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EtapaBindingSource, "id_proyecto", True))
        Me.cbEtapa.DataSource = Me.EtapaBindingSource
        Me.cbEtapa.DisplayMember = "nombre"
        Me.cbEtapa.FormattingEnabled = True
        Me.cbEtapa.Location = New System.Drawing.Point(296, 209)
        Me.cbEtapa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbEtapa.Name = "cbEtapa"
        Me.cbEtapa.Size = New System.Drawing.Size(329, 24)
        Me.cbEtapa.TabIndex = 7
        Me.cbEtapa.ValueMember = "id_proyecto"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblFecha.Location = New System.Drawing.Point(153, 420)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(73, 25)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Fecha:"
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblEtapa.Location = New System.Drawing.Point(153, 209)
        Me.lblEtapa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(69, 25)
        Me.lblEtapa.TabIndex = 2
        Me.lblEtapa.Text = "Etapa:"
        '
        'lblNombreGasto
        '
        Me.lblNombreGasto.AutoSize = True
        Me.lblNombreGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreGasto.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblNombreGasto.Location = New System.Drawing.Point(104, 153)
        Me.lblNombreGasto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreGasto.Name = "lblNombreGasto"
        Me.lblNombreGasto.Size = New System.Drawing.Size(171, 25)
        Me.lblNombreGasto.TabIndex = 1
        Me.lblNombreGasto.Text = "Nombre del gasto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(499, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORMULARIO GASTO"
        '
        'GastoTableAdapter
        '
        Me.GastoTableAdapter.ClearBeforeFill = True
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.FacturaBindingSource, "fecha_pago", True))
        Me.MonthCalendar1.Location = New System.Drawing.Point(296, 420)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 74
        '
        'btnVolver
        '
        Me.btnVolver.BackgroundImage = CType(resources.GetObject("btnVolver.BackgroundImage"), System.Drawing.Image)
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVolver.Location = New System.Drawing.Point(95, 49)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(67, 68)
        Me.btnVolver.TabIndex = 75
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(291, 630)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 24)
        Me.Label6.TabIndex = 76
        '
        'BeneficiarioBindingSource
        '
        Me.BeneficiarioBindingSource.DataMember = "beneficiario"
        Me.BeneficiarioBindingSource.DataSource = Me.SermiccsaDataSet
        '
        'BeneficiarioTableAdapter
        '
        Me.BeneficiarioTableAdapter.ClearBeforeFill = True
        '
        'RubroBindingSource
        '
        Me.RubroBindingSource.DataMember = "rubro"
        Me.RubroBindingSource.DataSource = Me.SermiccsaDataSet
        '
        'RubroTableAdapter
        '
        Me.RubroTableAdapter.ClearBeforeFill = True
        '
        'GastoBindingSource1
        '
        Me.GastoBindingSource1.DataMember = "gasto"
        Me.GastoBindingSource1.DataSource = Me.SermiccsaDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiarioBindingSource, "nombre", True))
        Me.ComboBox2.DataSource = Me.BeneficiarioBindingSource
        Me.ComboBox2.DisplayMember = "nombre"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(803, 368)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(333, 24)
        Me.ComboBox2.TabIndex = 78
        Me.ComboBox2.ValueMember = "nombre"
        '
        'FacturaBindingSource1
        '
        Me.FacturaBindingSource1.DataMember = "factura"
        Me.FacturaBindingSource1.DataSource = Me.SermiccsaDataSet
        '
        'FacturaBindingSource2
        '
        Me.FacturaBindingSource2.DataMember = "factura"
        Me.FacturaBindingSource2.DataSource = Me.SermiccsaDataSet
        '
        'EtapaBindingSource
        '
        Me.EtapaBindingSource.DataMember = "etapa"
        Me.EtapaBindingSource.DataSource = Me.SermiccsaDataSet
        '
        'EtapaTableAdapter
        '
        Me.EtapaTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "nombre", True))
        Me.TextBox1.Location = New System.Drawing.Point(295, 157)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(330, 22)
        Me.TextBox1.TabIndex = 79
        '
        'FormGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 681)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.cbRubro)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.cbEtapa)
        Me.Controls.Add(Me.tbSubtotal)
        Me.Controls.Add(Me.lblReferencia)
        Me.Controls.Add(Me.tbIVA)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblNombreGasto)
        Me.Controls.Add(Me.tbReferencia)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.tbIR)
        Me.Controls.Add(Me.lblBeneficiario)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblEtapa)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblIR)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(1359, 728)
        Me.MinimumSize = New System.Drawing.Size(1359, 728)
        Me.Name = "FormGasto"
        Me.Text = "FormGasto"
        CType(Me.GastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RubroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtapaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblEtapa As Label
    Friend WithEvents lblNombreGasto As Label
    Friend WithEvents cbEtapa As ComboBox
    Friend WithEvents cbRubro As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbIR As TextBox
    Friend WithEvents lblIR As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents tbIVA As TextBox
    Friend WithEvents lblIVA As Label
    Friend WithEvents tbSubtotal As TextBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblBeneficiario As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents tbReferencia As TextBox
    Friend WithEvents lblReferencia As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents SermiccsaDataSet As sermiccsaDataSet
    Friend WithEvents GastoBindingSource As BindingSource
    Friend WithEvents GastoTableAdapter As sermiccsaDataSetTableAdapters.gastoTableAdapter
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As sermiccsaDataSetTableAdapters.facturaTableAdapter
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents BeneficiarioBindingSource As BindingSource
    Friend WithEvents BeneficiarioTableAdapter As sermiccsaDataSetTableAdapters.beneficiarioTableAdapter
    Friend WithEvents RubroBindingSource As BindingSource
    Friend WithEvents RubroTableAdapter As sermiccsaDataSetTableAdapters.rubroTableAdapter
    Friend WithEvents GastoBindingSource1 As BindingSource
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents FacturaBindingSource1 As BindingSource
    Friend WithEvents FacturaBindingSource2 As BindingSource
    Friend WithEvents EtapaBindingSource As BindingSource
    Friend WithEvents EtapaTableAdapter As sermiccsaDataSetTableAdapters.etapaTableAdapter
    Friend WithEvents TextBox1 As TextBox
End Class
