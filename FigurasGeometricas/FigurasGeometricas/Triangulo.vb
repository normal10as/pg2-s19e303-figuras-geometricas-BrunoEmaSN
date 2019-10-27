Public Class Triangulo
    Inherits Figura
    Private _base As Single
    Private _altura As Single
    Public Property Base As Single
        Get
            Return _base
        End Get
        Set(value As Single)
            _base = value
        End Set
    End Property
    Public Property Altura As Single
        Get
            Return _altura
        End Get
        Set(value As Single)
            _altura = value
        End Set
    End Property
    Public Sub New(nombre As String, altura As Single, base As Single)
        MyBase.New(nombre)
        Me.Altura = altura
        Me.Base = base
    End Sub

    Public Overrides Function CalcaularArea() As Single
        Return Base * Altura
    End Function
End Class
