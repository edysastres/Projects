Module Module1
    Sub Main()
        Dim tipoMoto As String = "campo"
        Dim numruedas As Integer = 2

        Dim miFabrica As IFactory = New FactoryImp

        Dim miMoto As IMoto = miFabrica.CreaMoto(tipoMoto, numruedas)
        Console.WriteLine("Mi moto tiene " & miMoto.getRuedas() & " ruedas")
        Console.ReadLine()
    End Sub
End Module
