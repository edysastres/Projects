Public Class ApplicationJMAHelper

    Public Shared Function GetApplicationDocumentsPath(ByVal DocName As String, ByVal CounterID As String, ByVal IsApproved As Boolean, ByVal DocDate As DateTime) As String
        Dim ruta As String = Environment.GetFolderPath(Environment.CurrentDirectory)
        Dim Path As String = ruta & "/RECEIPTS/" & DocDate.Year & "/" & DocDate.Month & "/" & CounterID

        If (IsApproved) Then
            Path = Path + "/APPROVED/"
        Else
            Path = Path + "/REQUEST/"
        End If
        If Not (Directory.Exists(Path)) Then
            Directory.CreateDirectory(Path)
        End If
        Path = Path + DocName

        Return Path
    End Function

    Public Shared Function GetApplicationDocumentsPath(ByVal DocName As String, ByVal CounterID As String, ByVal IsApproved As Boolean) As String
        Dim ruta As String = Environment.GetFolderPath(Environment.CurrentDirectory)
        Dim Path As String = ruta & "/RECEIPTS/" & Today.Year & "/" & Today.Month & "/" & CounterID

        If (IsApproved) Then
            Path = Path + "/APPROVED/"
        Else
            Path = Path + "/REQUEST/"
        End If
        If Not (Directory.Exists(Path)) Then
            Directory.CreateDirectory(Path)
        End If
        Path = Path + DocName

        Return Path
    End Function

    Public Shared Function GetServerDocumentsPath(ByVal DocName As String, ByVal CounterID As String, ByVal IsApproved As Boolean, ByVal DocDate As DateTime) As String
        Dim ruta As String = New Parametro().LeerParametro("JMA_SF")
        If Length(ruta) > 0 Then
            If IO.Directory.Exists(ruta) Then
                Dim Path As String = ruta & "/RECEIPTS/" & DocDate.Year & "/" & DocDate.Month & "/" & CounterID
                If (IsApproved) Then
                    Path = Path + "/APPROVED/"
                Else
                    Path = Path + "/REQUEST/"
                End If
                If Not (Directory.Exists(Path)) Then
                    Directory.CreateDirectory(Path)
                End If
                Path = Path + DocName
                Return Path
            Else
                ApplicationService.GenerateError(String.Format("No existe la carpeta {0}", ruta))
            End If
        Else
            ApplicationService.GenerateError("El parámetro 'JMA_SF' no tiene valor.")
        End If
        Return ruta
    End Function

    Public Shared Function GetServerDocumentsPath(ByVal DocName As String, ByVal CounterID As String, ByVal IsApproved As Boolean) As String
        Dim ruta As String = New Parametro().LeerParametro("JMA_SF")
        If Length(ruta) > 0 Then
            If IO.Directory.Exists(ruta) Then
                Dim Path As String = ruta & "/RECEIPTS/" & Today.Year & "/" & Today.Month & "/" & CounterID
                If (IsApproved) Then
                    Path = Path + "/APPROVED/"
                Else
                    Path = Path + "/REQUEST/"
                End If
                If Not (Directory.Exists(Path)) Then
                    Directory.CreateDirectory(Path)
                End If
                Path = Path + DocName
                Return Path
            Else
                ApplicationService.GenerateError(String.Format("No existe la carpeta {0}", ruta))
            End If
        Else
            ApplicationService.GenerateError("El parámetro 'JMA_SF' no tiene valor.")
        End If
        Return ruta
    End Function

End Class
