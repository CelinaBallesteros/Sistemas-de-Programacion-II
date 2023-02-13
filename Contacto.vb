Public Class Contacto
    Inherits Persona
    Private Telefono As Integer
    Private CorreoElectronico As String

    Public Property TelefonoP() As Integer
        Get
            Return Telefono
        End Get
        Set(value As Integer)
            Telefono = value
        End Set
    End Property

    Public Property CorreoP() As String
        Get
            Return CorreoElectronico
        End Get
        Set(value As String)
            CorreoElectronico = value
        End Set
    End Property
End Class
