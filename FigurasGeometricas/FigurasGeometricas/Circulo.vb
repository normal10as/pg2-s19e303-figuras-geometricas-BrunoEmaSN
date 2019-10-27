Imports System.Math
Public Class Circulo
    Inherits Figura
    Private _radio As Single
    Public Property Radio As Single
        Get
            Return _radio
        End Get
        Set(value As Single)
            _radio = value
        End Set
    End Property
    Public Sub New(nombre As String, radio As Single)
        MyBase.New(nombre)
        Me.Radio = PI * radio ^ 2
    End Sub

    Public Overrides Function CalcaularArea() As Single
        Return Radio
    End Function
End Class
