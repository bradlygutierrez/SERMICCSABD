﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnadirRubro
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
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.RubroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SermiccsaDataSet = New Sermiccsa.sermiccsaDataSet()
        Me.txt_idRubro = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_idRubro = New System.Windows.Forms.Label()
        Me.labelContador = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RubroTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.rubroTableAdapter()
        CType(Me.RubroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.RubroBindingSource, "nombre", True))
        Me.txt_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RubroBindingSource, "nombre", True))
        Me.txt_nombre.Location = New System.Drawing.Point(246, 192)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(263, 22)
        Me.txt_nombre.TabIndex = 61
        '
        'RubroBindingSource
        '
        Me.RubroBindingSource.DataMember = "rubro"
        Me.RubroBindingSource.DataSource = Me.SermiccsaDataSet
        '
        'SermiccsaDataSet
        '
        Me.SermiccsaDataSet.DataSetName = "sermiccsaDataSet"
        Me.SermiccsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_idRubro
        '
        Me.txt_idRubro.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.RubroBindingSource, "id_rubro", True))
        Me.txt_idRubro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RubroBindingSource, "id_rubro", True))
        Me.txt_idRubro.Location = New System.Drawing.Point(246, 113)
        Me.txt_idRubro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_idRubro.Name = "txt_idRubro"
        Me.txt_idRubro.Size = New System.Drawing.Size(261, 22)
        Me.txt_idRubro.TabIndex = 60
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.White
        Me.lbl_nombre.Location = New System.Drawing.Point(157, 192)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(81, 25)
        Me.lbl_nombre.TabIndex = 59
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_idRubro
        '
        Me.lbl_idRubro.AutoSize = True
        Me.lbl_idRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idRubro.ForeColor = System.Drawing.Color.White
        Me.lbl_idRubro.Location = New System.Drawing.Point(157, 113)
        Me.lbl_idRubro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_idRubro.Name = "lbl_idRubro"
        Me.lbl_idRubro.Size = New System.Drawing.Size(36, 25)
        Me.lbl_idRubro.TabIndex = 58
        Me.lbl_idRubro.Text = "ID "
        '
        'labelContador
        '
        Me.labelContador.AutoSize = True
        Me.labelContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelContador.ForeColor = System.Drawing.Color.White
        Me.labelContador.Location = New System.Drawing.Point(285, 326)
        Me.labelContador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelContador.Name = "labelContador"
        Me.labelContador.Size = New System.Drawing.Size(90, 24)
        Me.labelContador.TabIndex = 65
        Me.labelContador.Text = "10 de 56"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Black
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSiguiente.Location = New System.Drawing.Point(407, 315)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(100, 41)
        Me.btnSiguiente.TabIndex = 64
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Black
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAnterior.Location = New System.Drawing.Point(161, 315)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(100, 41)
        Me.btnAnterior.TabIndex = 63
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-127, -161)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 25)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Saldo Disponible"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(285, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 32)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Rubros"
        '
        'RubroTableAdapter
        '
        Me.RubroTableAdapter.ClearBeforeFill = True
        '
        'FormAnadirRubro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(672, 420)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelContador)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_idRubro)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_idRubro)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormAnadirRubro"
        Me.Text = "FormAniadirRubro"
        CType(Me.RubroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_idRubro As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_idRubro As Label
    Friend WithEvents labelContador As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SermiccsaDataSet As sermiccsaDataSet
    Friend WithEvents RubroBindingSource As BindingSource
    Friend WithEvents RubroTableAdapter As sermiccsaDataSetTableAdapters.rubroTableAdapter
End Class
