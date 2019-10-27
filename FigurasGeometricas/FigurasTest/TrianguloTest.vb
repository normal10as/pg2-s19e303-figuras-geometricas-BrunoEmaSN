Imports FigurasGeometricas
Module TrianguloTest
    Sub Triangulo()
        Dim triangulo1 As New Triangulo("Triangulo", 3.2, 6.4)
        Console.WriteLine("Nombre: " & triangulo1.Nombre)
        Console.WriteLine("Area: " & triangulo1.CalcaularArea)
    End Sub
End Module
