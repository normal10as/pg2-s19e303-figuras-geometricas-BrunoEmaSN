Public MustInherit Class Figura
    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
    Public MustOverride Function CalcaularArea() As Single
End Class
