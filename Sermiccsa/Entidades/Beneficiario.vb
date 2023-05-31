Public Class Beneficiario
    Private _Id_beneficiario As Integer
    Private _nombre As String
    Private _identificacion As String

    Public Sub New()

    End Sub


    Public Sub New(idBeneficiario As Integer, nombre As String, identificacion As String)
        _Id_beneficiario = idBeneficiario
        _nombre = nombre
        _identificacion = identificacion
    End Sub


    Public Property Id_beneficiario As Integer
        Get
            Return _Id_beneficiario
        End Get
        Set(value As Integer)
            _Id_beneficiario = value
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

    Public Property Identificacion As String
        Get
            Return _identificacion
        End Get
        Set(value As String)
            _identificacion = value
        End Set
    End Property
End Class
