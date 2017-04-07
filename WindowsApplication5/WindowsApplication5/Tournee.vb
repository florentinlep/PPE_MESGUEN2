Public Class Tournee
    Public _trnNum As Integer
    Public _chfId As Integer
    Public _vehMat As String
    Public _trnDepChf As String

    Public Property trnNum As Integer
        Get
            Return _trnNum
        End Get
        Set(ByVal value As Integer)
            _trnNum = value
        End Set
    End Property
    Public Property chfId As Integer
        Get
            Return _chfId
        End Get
        Set(ByVal value As Integer)
            _chfId = value
        End Set
    End Property
    Public Property vehMat As String
        Get
            Return _vehMat
        End Get
        Set(ByVal value As String)
            _vehMat = value
        End Set
    End Property
    Public Property trnDepChf As String
        Get
            Return _trnDepChf
        End Get
        Set(ByVal value As String)
            _trnDepChf = value
        End Set
    End Property

    Public Sub New(trnNum As Integer, chfId As String, vehMat As String, trnDepChf As String)
        _trnNum = trnNum
        _chfId = chfId
        _vehMat = vehMat
        _trnDepChf = trnDepChf
    End Sub

    Public Overrides Function ToString() As String
        Return _trnNum
    End Function
End Class
