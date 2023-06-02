<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarEtapa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNumeroEtapa = New System.Windows.Forms.TextBox()
        Me.EtapaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SermiccsaDataSet = New Sermiccsa.sermiccsaDataSet()
        Me.tbNombreEtapa = New System.Windows.Forms.TextBox()
        Me.tbPresupuesto = New System.Windows.Forms.TextBox()
        Me.btAgregarEtapa = New System.Windows.Forms.Button()
        Me.EtapaTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.etapaTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        CType(Me.EtapaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(155, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Agregar Etapa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(43, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Numero de etapa: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(41, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre de la etapa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(43, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Presupuesto:"
        '
        'tbNumeroEtapa
        '
        Me.tbNumeroEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNumeroEtapa.Location = New System.Drawing.Point(254, 93)
        Me.tbNumeroEtapa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbNumeroEtapa.Name = "tbNumeroEtapa"
        Me.tbNumeroEtapa.Size = New System.Drawing.Size(233, 27)
        Me.tbNumeroEtapa.TabIndex = 11
        '
        'EtapaBindingSource
        '
        Me.EtapaBindingSource.DataMember = "etapa"
        Me.EtapaBindingSource.DataSource = Me.SermiccsaDataSet
        '
        'SermiccsaDataSet
        '
        Me.SermiccsaDataSet.DataSetName = "sermiccsaDataSet"
        Me.SermiccsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbNombreEtapa
        '
        Me.tbNombreEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreEtapa.Location = New System.Drawing.Point(254, 145)
        Me.tbNombreEtapa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbNombreEtapa.Name = "tbNombreEtapa"
        Me.tbNombreEtapa.Size = New System.Drawing.Size(233, 27)
        Me.tbNombreEtapa.TabIndex = 12
        '
        'tbPresupuesto
        '
        Me.tbPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPresupuesto.Location = New System.Drawing.Point(254, 208)
        Me.tbPresupuesto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbPresupuesto.Name = "tbPresupuesto"
        Me.tbPresupuesto.Size = New System.Drawing.Size(233, 27)
        Me.tbPresupuesto.TabIndex = 13
        '
        'btAgregarEtapa
        '
        Me.btAgregarEtapa.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btAgregarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAgregarEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregarEtapa.ForeColor = System.Drawing.Color.White
        Me.btAgregarEtapa.Location = New System.Drawing.Point(214, 337)
        Me.btAgregarEtapa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btAgregarEtapa.Name = "btAgregarEtapa"
        Me.btAgregarEtapa.Size = New System.Drawing.Size(100, 34)
        Me.btAgregarEtapa.TabIndex = 14
        Me.btAgregarEtapa.Text = "Agregar"
        Me.btAgregarEtapa.UseVisualStyleBackColor = False
        '
        'EtapaTableAdapter
        '
        Me.EtapaTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(43, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Descripción:"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescripcion.Location = New System.Drawing.Point(254, 266)
        Me.tbDescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(233, 27)
        Me.tbDescripcion.TabIndex = 17
        '
        'FormAgregarEtapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 421)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btAgregarEtapa)
        Me.Controls.Add(Me.tbPresupuesto)
        Me.Controls.Add(Me.tbNombreEtapa)
        Me.Controls.Add(Me.tbNumeroEtapa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormAgregarEtapa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAgregarEtapa"
        CType(Me.EtapaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNumeroEtapa As TextBox
    Friend WithEvents tbNombreEtapa As TextBox
    Friend WithEvents tbPresupuesto As TextBox
    Friend WithEvents btAgregarEtapa As Button
    Friend WithEvents SermiccsaDataSet As sermiccsaDataSet
    Friend WithEvents EtapaBindingSource As BindingSource
    Friend WithEvents EtapaTableAdapter As sermiccsaDataSetTableAdapters.etapaTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDescripcion As TextBox
End Class
