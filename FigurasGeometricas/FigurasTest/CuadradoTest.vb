Imports FigurasGeometricas
Module CuadradoTest
    Sub Cuadrado()
        Dim cuadrado1 As New Cuadrado("Cuadrado", 4)
        Console.WriteLine("Nombre: " & cuadrado1.Nombre)
        Console.WriteLine("Area: " & cuadrado1.CalcaularArea)
    End Sub
End Module
