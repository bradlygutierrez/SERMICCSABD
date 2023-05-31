Public Class Usuario
    Private _idUsuario As Integer
    Private _nombre As String
    Private _correo As String
    Private _clave As String
    Private _idPregunta As Integer
    Private _respuesta As String

    Public Sub New()
    End Sub


    Public Sub New(idUsuario As Integer, nombre As String, correo As String, clave As String, idPregunta As Integer, respuesta As String)
        _idUsuario = idUsuario
        _nombre = nombre
        _correo = correo
        _clave = clave
        _idPregunta = idPregunta
        _respuesta = respuesta
    End Sub


    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _clave
        End Get
        Set(value As String)
            _clave = value
        End Set
    End Property

    Public Property IdPregunta As Integer
        Get
            Return _idPregunta
        End Get
        Set(value As Integer)
            _idPregunta = value
        End Set
    End Property

    Public Property respuesta As String
        Get
            Return _respuesta
        End Get
        Set(value As String)
            _respuesta = value
        End Set
    End Property

End Class