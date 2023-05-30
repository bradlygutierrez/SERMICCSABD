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
        Me.cbBeneficiario = New System.Windows.Forms.ComboBox()
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
        Me.tbNombreGasto = New System.Windows.Forms.TextBox()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.lblNombreGasto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GastoTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.gastoTableAdapter()
        Me.FacturaTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.facturaTableAdapter()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.GastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(623, 471)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 18)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "No. Registro"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(726, 463)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 31)
        Me.Button6.TabIndex = 72
        Me.Button6.Text = "Siguiente"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button7.Location = New System.Drawing.Point(538, 463)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(83, 31)
        Me.Button7.TabIndex = 71
        Me.Button7.Text = "Anterior"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(769, 413)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 31)
        Me.Button5.TabIndex = 70
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(680, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 31)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(496, 413)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 31)
        Me.Button3.TabIndex = 68
        Me.Button3.Text = "Editar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(587, 413)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 31)
        Me.Button4.TabIndex = 67
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'cbBeneficiario
        '
        Me.cbBeneficiario.FormattingEnabled = True
        Me.cbBeneficiario.Location = New System.Drawing.Point(602, 299)
        Me.cbBeneficiario.Name = "cbBeneficiario"
        Me.cbBeneficiario.Size = New System.Drawing.Size(248, 21)
        Me.cbBeneficiario.TabIndex = 34
        '
        'cbRubro
        '
        Me.cbRubro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "id_rubro", True))
        Me.cbRubro.FormattingEnabled = True
        Me.cbRubro.Location = New System.Drawing.Point(602, 341)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(247, 21)
        Me.cbRubro.TabIndex = 25
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
        Me.Label13.Location = New System.Drawing.Point(506, 338)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Rubro:"
        '
        'tbIR
        '
        Me.tbIR.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.FacturaBindingSource, "cantidad_ir", True))
        Me.tbIR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "cantidad_ir", True))
        Me.tbIR.Location = New System.Drawing.Point(602, 257)
        Me.tbIR.Multiline = True
        Me.tbIR.Name = "tbIR"
        Me.tbIR.Size = New System.Drawing.Size(247, 20)
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
        Me.lblIR.Location = New System.Drawing.Point(506, 257)
        Me.lblIR.Name = "lblIR"
        Me.lblIR.Size = New System.Drawing.Size(30, 20)
        Me.lblIR.TabIndex = 20
        Me.lblIR.Text = "IR:"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(602, 217)
        Me.tbTotal.Multiline = True
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(247, 20)
        Me.tbTotal.TabIndex = 19
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblTotal.Location = New System.Drawing.Point(506, 215)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(48, 20)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "Total:"
        '
        'tbIVA
        '
        Me.tbIVA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "iva", True))
        Me.tbIVA.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.FacturaBindingSource, "iva", True))
        Me.tbIVA.Location = New System.Drawing.Point(602, 172)
        Me.tbIVA.Multiline = True
        Me.tbIVA.Name = "tbIVA"
        Me.tbIVA.Size = New System.Drawing.Size(247, 20)
        Me.tbIVA.TabIndex = 17
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVA.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblIVA.Location = New System.Drawing.Point(506, 168)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(40, 20)
        Me.lblIVA.TabIndex = 16
        Me.lblIVA.Text = "IVA:"
        '
        'tbSubtotal
        '
        Me.tbSubtotal.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.FacturaBindingSource, "subtotal", True))
        Me.tbSubtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "subtotal", True))
        Me.tbSubtotal.Location = New System.Drawing.Point(602, 126)
        Me.tbSubtotal.Multiline = True
        Me.tbSubtotal.Name = "tbSubtotal"
        Me.tbSubtotal.Size = New System.Drawing.Size(248, 20)
        Me.tbSubtotal.TabIndex = 15
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblSubtotal.Location = New System.Drawing.Point(506, 126)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(73, 20)
        Me.lblSubtotal.TabIndex = 14
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblBeneficiario
        '
        Me.lblBeneficiario.AutoSize = True
        Me.lblBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeneficiario.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblBeneficiario.Location = New System.Drawing.Point(506, 299)
        Me.lblBeneficiario.Name = "lblBeneficiario"
        Me.lblBeneficiario.Size = New System.Drawing.Size(96, 20)
        Me.lblBeneficiario.TabIndex = 12
        Me.lblBeneficiario.Text = "Beneficiario:"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.GastoBindingSource, "descripcion", True))
        Me.tbDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "descripcion", True))
        Me.tbDescripcion.Location = New System.Drawing.Point(222, 256)
        Me.tbDescripcion.Multiline = True
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(248, 63)
        Me.tbDescripcion.TabIndex = 11
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblDescripcion.Location = New System.Drawing.Point(115, 257)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(96, 20)
        Me.lblDescripcion.TabIndex = 10
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'tbReferencia
        '
        Me.tbReferencia.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.FacturaBindingSource, "referencia", True))
        Me.tbReferencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "referencia", True))
        Me.tbReferencia.Location = New System.Drawing.Point(222, 215)
        Me.tbReferencia.Multiline = True
        Me.tbReferencia.Name = "tbReferencia"
        Me.tbReferencia.Size = New System.Drawing.Size(248, 20)
        Me.tbReferencia.TabIndex = 9
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferencia.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblReferencia.Location = New System.Drawing.Point(115, 213)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(91, 20)
        Me.lblReferencia.TabIndex = 8
        Me.lblReferencia.Text = "Referencia:"
        '
        'cbEtapa
        '
        Me.cbEtapa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.GastoBindingSource, "id_etapa", True))
        Me.cbEtapa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GastoBindingSource, "id_etapa", True))
        Me.cbEtapa.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.GastoBindingSource, "id_etapa", True))
        Me.cbEtapa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "id_etapa", True))
        Me.cbEtapa.FormattingEnabled = True
        Me.cbEtapa.Location = New System.Drawing.Point(222, 170)
        Me.cbEtapa.Name = "cbEtapa"
        Me.cbEtapa.Size = New System.Drawing.Size(248, 21)
        Me.cbEtapa.TabIndex = 7
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblFecha.Location = New System.Drawing.Point(115, 341)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(58, 20)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Fecha:"
        '
        'tbNombreGasto
        '
        Me.tbNombreGasto.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.GastoBindingSource, "nombre", True))
        Me.tbNombreGasto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "nombre", True))
        Me.tbNombreGasto.Location = New System.Drawing.Point(222, 126)
        Me.tbNombreGasto.Multiline = True
        Me.tbNombreGasto.Name = "tbNombreGasto"
        Me.tbNombreGasto.Size = New System.Drawing.Size(247, 20)
        Me.tbNombreGasto.TabIndex = 3
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblEtapa.Location = New System.Drawing.Point(115, 170)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(56, 20)
        Me.lblEtapa.TabIndex = 2
        Me.lblEtapa.Text = "Etapa:"
        '
        'lblNombreGasto
        '
        Me.lblNombreGasto.AutoSize = True
        Me.lblNombreGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreGasto.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblNombreGasto.Location = New System.Drawing.Point(78, 124)
        Me.lblNombreGasto.Name = "lblNombreGasto"
        Me.lblNombreGasto.Size = New System.Drawing.Size(138, 20)
        Me.lblNombreGasto.TabIndex = 1
        Me.lblNombreGasto.Text = "Nombre del gasto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(374, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 31)
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
        Me.MonthCalendar1.Location = New System.Drawing.Point(222, 341)
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
        Me.btnVolver.Location = New System.Drawing.Point(71, 40)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(50, 55)
        Me.btnVolver.TabIndex = 75
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(218, 512)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 18)
        Me.Label6.TabIndex = 76
        '
        'FormGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 561)
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
        Me.Controls.Add(Me.cbBeneficiario)
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
        Me.Controls.Add(Me.tbNombreGasto)
        Me.MaximumSize = New System.Drawing.Size(1024, 600)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "FormGasto"
        Me.Text = "FormGasto"
        CType(Me.GastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents tbNombreGasto As TextBox
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
    Friend WithEvents cbBeneficiario As ComboBox
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
End Class
