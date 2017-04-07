Public Class Vehicule
    Public _vehMat As String
    Public _vehMarque As String
    Public _vehKmCompteur As Integer

    Public Property vehMat As String
        Get
            Return _vehMat
        End Get
        Set(ByVal value As String)
            _vehMat = value
        End Set
    End Property
    Public Property vehMarque As String
        Get
            Return _vehMarque
        End Get
        Set(ByVal value As String)
            _vehMarque = value
        End Set
    End Property
    Public Property vehKmCompteur As Integer
        Get
            Return _vehKmCompteur
        End Get
        Set(ByVal value As Integer)
            _vehKmCompteur = value
        End Set
    End Property

    Public Sub New(vehMat As String, vehMarque As String, vehKmCompteur As Integer)
        _vehMat = vehMat
        _vehMarque = vehMarque
        _vehKmCompteur = vehKmCompteur
    End Sub

    Public Overrides Function ToString() As String
        Return _vehMat
    End Function
End Class
