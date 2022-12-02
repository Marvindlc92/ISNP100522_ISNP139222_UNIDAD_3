Public Class Persona

    Private nombre As String
    Private edad As Integer

    Public Property nombrePersona As String

        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

End Class
