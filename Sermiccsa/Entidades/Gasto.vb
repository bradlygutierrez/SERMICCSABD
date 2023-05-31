Public Class Gasto

    Private _idGasto As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _idEtapa As Integer
    Private _idRubro As Integer
    Private _idBeneficiario As Integer
    Private _idFactura As Integer


    Public Sub New()
    End Sub


    Public Sub New(idGasto As Integer, nombre As String, descripcion As String, idEtapa As Integer, idRubro As Integer, idBeneficiario As Integer, idFactura As Integer)
        _idGasto = idGasto
        _nombre = nombre
        _descripcion = descripcion
        _idEtapa = idEtapa
        _idRubro = idRubro
        _idBeneficiario = idBeneficiario
        _idFactura = idFactura
    End Sub


    Public Property IdGasto As Integer
        Get
            Return _idGasto
        End Get
        Set(value As Integer)
            _idGasto = value
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property IdEtapa As Integer
        Get
            Return _idEtapa
        End Get
        Set(value As Integer)
            _idEtapa = value
        End Set
    End Property

    Public Property IdRubro As Integer
        Get
            Return _idRubro
        End Get
        Set(value As Integer)
            _idRubro = value
        End Set
    End Property

    Public Property IdBeneficiario As Integer
        Get
            Return _idBeneficiario
        End Get
        Set(value As Integer)
            _idBeneficiario = value
        End Set
    End Property

    Public Property IdFactura As Integer
        Get
            Return _idFactura
        End Get
        Set(value As Integer)
            _idFactura = value
        End Set
    End Property
End Class
