Public Class Persona
    Private Nombre As String
    Private ApPaterno As String
    Private ApMaterno As String
    Private FNacimiento As Date
    Public Property NombreP() As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property ApPaternoP() As String
        Get
            Return ApPaterno
        End Get
        Set(value As String)
            ApPaterno = value
        End Set
    End Property

    Public Property ApMaternoP() As String
        Get
            Return ApMaterno
        End Get
        Set(value As String)
            ApMaterno = value
        End Set
    End Property

    Public Property FNacimientoP() As Date
        Get
            Return FNacimiento
        End Get
        Set(value As Date)
            FNacimiento = value
        End Set
    End Property

    Public Sub Persona(ByVal Nombre1 As String, ByVal ApPaterno1 As String, ByVal ApMaterno1 As String, ByVal FNacimiento1 As Date)
        Nombre = Nombre1
        ApMaterno = ApMaterno1
        ApPaterno = ApPaterno1
        FNacimiento = FNacimiento1
    End Sub

End Class
