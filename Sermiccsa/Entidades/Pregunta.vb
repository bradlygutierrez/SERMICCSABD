Public Class Pregunta

    Private _idPregunta As Integer
    Private _preguntaTexto As String


    Public Sub New()
    End Sub


    Public Sub New(idPregunta As Integer, preguntaTexto As String)
        _idPregunta = idPregunta
        _preguntaTexto = preguntaTexto
    End Sub


    Public Property IdPregunta As Integer
        Get
            Return _idPregunta
        End Get
        Set(value As Integer)
            _idPregunta = value
        End Set
    End Property

    Public Property PreguntaTexto As String
        Get
            Return _preguntaTexto
        End Get
        Set(value As String)
            _preguntaTexto = value
        End Set
    End Property
End Class