Imports FigurasGeometricas
Module CirculoTest
    Sub Circulo()
        Dim circulo1 As New Circulo("Circulo", 10)
        Console.WriteLine("Nombre: " & circulo1.Nombre)
        Console.WriteLine("Area: " & circulo1.CalcaularArea)
    End Sub
End Module
