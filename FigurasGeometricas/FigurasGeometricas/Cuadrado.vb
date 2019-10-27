Public Class Cuadrado
    Inherits Figura
    Private _lado As Single
    Public Property Lado As Single
        Get
            Return _lado
        End Get
        Set(value As Single)
            _lado = value
        End Set
    End Property
    Public Sub New(nombre As String, lado As Single)
        MyBase.New(nombre)
        Me.Lado = lado ^ 2
    End Sub

    Public Overrides Function CalcaularArea() As Single
        Return Lado
    End Function
End Class
