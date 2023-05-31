<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIniciarSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIniciarSesion))
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbSalir = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btIniciarSesion = New System.Windows.Forms.Button()
        Me.tbContrasena = New System.Windows.Forms.TextBox()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(869, 309)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(307, 29)
        Me.LinkLabel3.TabIndex = 21
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "¿Olvidaste tu contraseña?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(732, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(504, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "_______________________________________________________________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(732, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(504, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "_______________________________________________________________________"
        '
        'lbSalir
        '
        Me.lbSalir.AutoSize = True
        Me.lbSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbSalir.LinkColor = System.Drawing.Color.Red
        Me.lbSalir.Location = New System.Drawing.Point(989, 442)
        Me.lbSalir.Name = "lbSalir"
        Me.lbSalir.Size = New System.Drawing.Size(85, 29)
        Me.lbSalir.TabIndex = 18
        Me.lbSalir.TabStop = True
        Me.lbSalir.Text = "« Salir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(853, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(323, 65)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Bienvenido"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(847, 366)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(353, 29)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "¿No tienes cuenta? Registrate"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btIniciarSesion)
        Me.Panel1.Controls.Add(Me.tbContrasena)
        Me.Panel1.Controls.Add(Me.tbUsuario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(104, 126)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 431)
        Me.Panel1.TabIndex = 15
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(180, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(171, 158)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(124, 293)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.MaximumSize = New System.Drawing.Size(32, 30)
        Me.PictureBox2.MinimumSize = New System.Drawing.Size(32, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(124, 208)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(24, 24)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(24, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btIniciarSesion
        '
        Me.btIniciarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btIniciarSesion.FlatAppearance.BorderSize = 0
        Me.btIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btIniciarSesion.ForeColor = System.Drawing.Color.White
        Me.btIniciarSesion.Location = New System.Drawing.Point(163, 364)
        Me.btIniciarSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btIniciarSesion.Name = "btIniciarSesion"
        Me.btIniciarSesion.Size = New System.Drawing.Size(213, 41)
        Me.btIniciarSesion.TabIndex = 4
        Me.btIniciarSesion.Text = "Iniciar Sesion"
        Me.btIniciarSesion.UseVisualStyleBackColor = False
        '
        'tbContrasena
        '
        Me.tbContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContrasena.Location = New System.Drawing.Point(161, 289)
        Me.tbContrasena.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbContrasena.Multiline = True
        Me.tbContrasena.Name = "tbContrasena"
        Me.tbContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbContrasena.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbContrasena.Size = New System.Drawing.Size(229, 38)
        Me.tbContrasena.TabIndex = 3
        '
        'tbUsuario
        '
        Me.tbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(161, 204)
        Me.tbUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbUsuario.Multiline = True
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(229, 38)
        Me.tbUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(157, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingresar Contraseña "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(157, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar Usuario"
        '
        'FormIniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 681)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormIniciarSesion"
        Me.Text = "FormIniciarSesion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbSalir As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btIniciarSesion As Button
    Friend WithEvents tbContrasena As TextBox
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
