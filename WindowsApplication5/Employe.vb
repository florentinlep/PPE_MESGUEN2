Public Class Employe
    Public _emplId As Integer
    Public _emplNom As String
    Public _emplPrenom As String
    Public _emplGPS As String

    Public Property emplId As Integer
        Get
            Return _emplId
        End Get
        Set(ByVal value As Integer)
            _emplId = value
        End Set
    End Property
    Public Property emplNom As String
        Get
            Return _emplNom
        End Get
        Set(ByVal value As String)
            _emplNom = value
        End Set
    End Property
    Public Property emplPrenom As String
        Get
            Return _emplPrenom
        End Get
        Set(ByVal value As String)
            _emplPrenom = value
        End Set
    End Property
    Public Property emplGPS As String
        Get
            Return _emplGPS
        End Get
        Set(ByVal value As String)
            _emplGPS = value
        End Set
    End Property

    Public Sub New(emplId As Integer, emplNom As String, emplPrenom As String, emplGPS As String)
        _emplId = emplId
        _emplNom = emplNom
        _emplPrenom = emplPrenom
        _emplGPS = emplGPS
    End Sub

    Public Function getEmplGPS(ByVal index As Integer) As String
        Dim coord = Split(_emplGPS, ",")
        Return coord(index)
    End Function

    Public Overrides Function ToString() As String
        Return _emplNom & " " & _emplPrenom
    End Function
End Class
