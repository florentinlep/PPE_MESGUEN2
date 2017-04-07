Public Class Lieu
    Public _lieuId As Integer
    Public _lieuNom As String
    Public _comId As String
    Public _lieuGps As String

    Public Property lieuId As Integer
        Get
            Return _lieuId
        End Get
        Set(ByVal value As Integer)
            _lieuId = value
        End Set
    End Property
    Public Property lieuNom As String
        Get
            Return _lieuNom
        End Get
        Set(ByVal value As String)
            _lieuNom = value
        End Set
    End Property
    Public Property comId As String
        Get
            Return _comId
        End Get
        Set(ByVal value As String)
            _comId = value
        End Set
    End Property
    Public Property lieuGps As String
        Get
            Return _lieuGps
        End Get
        Set(ByVal value As String)
            _lieuGps = value
        End Set
    End Property

    Public Sub New(lieuId As Integer, lieuNom As String, comId As String, lieuGps As String)
        _lieuId = lieuId
        _lieuNom = lieuNom
        _comId = comId
        _lieuGps = lieuGps
    End Sub

    Public Overrides Function ToString() As String
        Return _lieuNom
    End Function
End Class
