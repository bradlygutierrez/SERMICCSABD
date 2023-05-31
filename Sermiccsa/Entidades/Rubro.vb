Public Class Rubro
    Private _idRubro As Integer
    Private _nombre As String

    Public Sub New()

    End Sub

    Public Sub New(idRubro As Integer, nombre As String)
        _idRubro = idRubro
        _nombre = nombre
    End Sub

    Public Property IdRubro As Integer
        Get
            Return _idRubro
        End Get
        Set(value As Integer)
            _idRubro = value
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
End Class
