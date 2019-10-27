Imports FigurasGeometricas
Module RectanguloTest
    Sub Rectangulo()
        Dim rectangulo1 As New Rectangulo("Rectangulo", 8, 16)
        Console.WriteLine("Nombre: " & rectangulo1.Nombre)
        Console.WriteLine("Area: " & rectangulo1.CalcaularArea)
    End Sub
End Module
