<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarCuenta))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btRegistrarUsuario = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbRespuesta = New System.Windows.Forms.TextBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SermiccsaDataSet = New Sermiccsa.sermiccsaDataSet()
        Me.cbPregunta = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbVerificarContrasena = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbContrasena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCorreo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PreguntaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.usuarioTableAdapter()
        Me.PreguntaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreguntaTableAdapter = New Sermiccsa.sermiccsaDataSetTableAdapters.preguntaTableAdapter()
        Me.PreguntaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreguntaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreguntaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreguntaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btRegistrarUsuario)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tbRespuesta)
        Me.Panel1.Controls.Add(Me.cbPregunta)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tbVerificarContrasena)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tbContrasena)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbCorreo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tbUsuario)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(265, 34)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 598)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(397, 422)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox7.TabIndex = 20
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(65, 422)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox6.TabIndex = 19
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(65, 282)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(397, 352)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(65, 352)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(397, 279)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(23, 17)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 54)
        Me.Button2.TabIndex = 15
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btRegistrarUsuario
        '
        Me.btRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btRegistrarUsuario.FlatAppearance.BorderSize = 0
        Me.btRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRegistrarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btRegistrarUsuario.ForeColor = System.Drawing.Color.White
        Me.btRegistrarUsuario.Location = New System.Drawing.Point(261, 500)
        Me.btRegistrarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.btRegistrarUsuario.Name = "btRegistrarUsuario"
        Me.btRegistrarUsuario.Size = New System.Drawing.Size(220, 49)
        Me.btRegistrarUsuario.TabIndex = 14
        Me.btRegistrarUsuario.Text = "Registrar Usuario "
        Me.btRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btRegistrarUsuario.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(427, 400)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Respuesta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(95, 400)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Elija su pregunta  de seguriad"
        '
        'tbRespuesta
        '
        Me.tbRespuesta.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsuarioBindingSource, "respuesta", True))
        Me.tbRespuesta.Location = New System.Drawing.Point(431, 427)
        Me.tbRespuesta.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRespuesta.Multiline = True
        Me.tbRespuesta.Name = "tbRespuesta"
        Me.tbRespuesta.Size = New System.Drawing.Size(267, 24)
        Me.tbRespuesta.TabIndex = 11
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "usuario"
        Me.UsuarioBindingSource.DataSource = Me.SermiccsaDataSet
        '
        'SermiccsaDataSet
        '
        Me.SermiccsaDataSet.DataSetName = "sermiccsaDataSet"
        Me.SermiccsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbPregunta
        '
        Me.cbPregunta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.UsuarioBindingSource, "id_pregunta", True))
        Me.cbPregunta.FormattingEnabled = True
        Me.cbPregunta.Location = New System.Drawing.Point(99, 426)
        Me.cbPregunta.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPregunta.Name = "cbPregunta"
        Me.cbPregunta.Size = New System.Drawing.Size(261, 24)
        Me.cbPregunta.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(427, 331)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Verifique su contraseña "
        '
        'tbVerificarContrasena
        '
        Me.tbVerificarContrasena.Location = New System.Drawing.Point(431, 357)
        Me.tbVerificarContrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.tbVerificarContrasena.Multiline = True
        Me.tbVerificarContrasena.Name = "tbVerificarContrasena"
        Me.tbVerificarContrasena.Size = New System.Drawing.Size(267, 24)
        Me.tbVerificarContrasena.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(95, 331)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ingrese su contraseña "
        '
        'tbContrasena
        '
        Me.tbContrasena.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsuarioBindingSource, "clave", True))
        Me.tbContrasena.Location = New System.Drawing.Point(99, 357)
        Me.tbContrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.tbContrasena.Multiline = True
        Me.tbContrasena.Name = "tbContrasena"
        Me.tbContrasena.Size = New System.Drawing.Size(261, 24)
        Me.tbContrasena.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(95, 258)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ingrese su correo electronico"
        '
        'tbCorreo
        '
        Me.tbCorreo.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsuarioBindingSource, "correo", True))
        Me.tbCorreo.Location = New System.Drawing.Point(99, 284)
        Me.tbCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCorreo.Multiline = True
        Me.tbCorreo.Name = "tbCorreo"
        Me.tbCorreo.Size = New System.Drawing.Size(261, 24)
        Me.tbCorreo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(427, 258)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese su nombre de usuario"
        '
        'tbUsuario
        '
        Me.tbUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsuarioBindingSource, "nombre", True))
        Me.tbUsuario.Location = New System.Drawing.Point(431, 284)
        Me.tbUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.tbUsuario.Multiline = True
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(267, 24)
        Me.tbUsuario.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(293, 42)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 158)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(276, 212)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrar Usuario "
        '
        'PreguntaBindingSource2
        '
        Me.PreguntaBindingSource2.DataMember = "pregunta"
        Me.PreguntaBindingSource2.DataSource = Me.SermiccsaDataSet
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'PreguntaBindingSource
        '
        Me.PreguntaBindingSource.DataMember = "pregunta"
        Me.PreguntaBindingSource.DataSource = Me.SermiccsaDataSet
        '
        'PreguntaTableAdapter
        '
        Me.PreguntaTableAdapter.ClearBeforeFill = True
        '
        'PreguntaBindingSource1
        '
        Me.PreguntaBindingSource1.DataMember = "pregunta"
        Me.PreguntaBindingSource1.DataSource = Me.SermiccsaDataSet
        '
        'FormAgregarCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1359, 728)
        Me.MinimumSize = New System.Drawing.Size(1359, 728)
        Me.Name = "FormAgregarCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAgregarCuenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SermiccsaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreguntaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreguntaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreguntaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btRegistrarUsuario As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbRespuesta As TextBox
    Friend WithEvents cbPregunta As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbVerificarContrasena As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbContrasena As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SermiccsaDataSet As sermiccsaDataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As sermiccsaDataSetTableAdapters.usuarioTableAdapter
    Friend WithEvents PreguntaBindingSource As BindingSource
    Friend WithEvents PreguntaTableAdapter As sermiccsaDataSetTableAdapters.preguntaTableAdapter
    Friend WithEvents PreguntaBindingSource1 As BindingSource
    Friend WithEvents PreguntaBindingSource2 As BindingSource
End Class
