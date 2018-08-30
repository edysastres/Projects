Imports System.Runtime.InteropServices

Public Class ReportPrinter
    ' Declaraciones API Win32 y la estructura del documento:
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
    Structure DOCINFOW
        <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
    End Structure

    <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As Long) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="WritePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
    End Function

    <DllImport("kernel32.dll", EntryPoint:="GetLastError", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function GetLastError() As Int32
    End Function


    ' SendBytesToPrinter()
    ' Esta función envía una secuencia de bytes a la impresora.
    ' Regresa False si hay un error.
    Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
        Dim hPrinter As IntPtr      ' El handle de la impresora.
        Dim dwError As Int32        ' El último error en caso de falla.
        Dim di As DOCINFOW          ' Describe el documento (nombre, puerto, tipo de dato).
        Dim dwWritten As Int32      ' El número de bytes impreso con WritePrinter().
        Dim bSuccess As Boolean     ' Bandera de estado.

        'Configuramos la estructura DOCINFO.
        With di
            .pDocName = "Etiquetas: "
            .pOutputFile = vbNullString
            .pDataType = "RAW"
        End With

        ' Se inicializa con False, en caso de terminar correctamente la cambiaremos a True.
        bSuccess = False

        If OpenPrinter(szPrinterName, hPrinter, 0) Then

            If StartDocPrinter(hPrinter, 1, di) Then

                If StartPagePrinter(hPrinter) Then
                    ' Escribimos los bytes leidos en la impresora.
                    bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                    EndPagePrinter(hPrinter)
                End If

                EndDocPrinter(hPrinter)
            End If

            ClosePrinter(hPrinter)
        End If
        ' Si hubo error, GetLastError proporciona más información
        If bSuccess = False Then
            dwError = GetLastError()
        End If

        Return bSuccess
    End Function

    ' SendFileToPrinter()
    ' Esta función lee el contenido de un archivo y lo envía a la impresora.
    ' Regresa False si hay un error.
    Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
        ' Abrimos el archivo.
        Dim fs As New FileStream(szFileName, FileMode.Open)
        ' Creamos el lector BinaryReader para el archivo.
        Dim br As New BinaryReader(fs)
        'Declaramos una matriz de bytes para el contenido del archivo.
        Dim bytes(fs.Length) As Byte
        Dim bSuccess As Boolean
        ' Definimos el apuntador a los datos de memoria no administrados.
        Dim pUnmanagedBytes As IntPtr

        ' Read the contents of the file into the array.
        bytes = br.ReadBytes(fs.Length)
        ' Usamos memoria no administrada para esos bytes.
        pUnmanagedBytes = Marshal.AllocCoTaskMem(fs.Length)
        ' Copiamos la matriz de bytes de memoria administrada a memoria no administrada.
        Marshal.Copy(bytes, 0, pUnmanagedBytes, fs.Length)
        ' Enviamos los bytes a la impresora.
        bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, fs.Length)
        ' Liberamos los bytes de la memoria.
        Marshal.FreeCoTaskMem(pUnmanagedBytes)
        br.Close()
        fs.Close()
        Return bSuccess
    End Function

    ' Esta función envía una cadena de texto a la impresora.
    Public Shared Sub SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String)
        Dim pBytes As IntPtr
        Dim dwCount As Int32 = szString.Length()
        ' Longuitud de la cadena de caracteres.
        pBytes = Marshal.StringToCoTaskMemAnsi(szString)
        ' Envía la cadena de caracteres a la impresora.
        SendBytesToPrinter(szPrinterName, pBytes, dwCount)
        Marshal.FreeCoTaskMem(pBytes)
    End Sub

End Class
