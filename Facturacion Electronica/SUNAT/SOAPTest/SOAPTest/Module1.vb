Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Security

Module Module1

    Sub Main()

        'Dim proxy = New beta.billService()
        'proxy.Url = "https://e-beta.sunat.gob.pe/ol-ti-itcpfegem-beta/billService?wsdl"

        Dim client = New SunatService.billServiceClient("BillServicePort")
        Dim response As Object
        Try
            ''''''''''''''''''''''''''''''''''''''''''
            'rs.Open()
            'response = rs.sendBill(zip, file, firmante)
            'rs.Close()

            Dim file() As Byte = System.IO.File.ReadAllBytes("\\192.168.0.103\c$\ExpertisDEV\Bin_SERV\RECEIPTS\sxAltunaPeru\20547600437-01-F001-05877\20547600437-01-F001-05877.ZIP")
            ''''''''''''''''''''''''''''''''''''''''''
            response = client.sendBill("20547600437-01-F001-05877.ZIP", file, "")

            
        Catch ex As Exception
            Print("SUNAT ha retornado una respuesta de error con código: |", ex.Message)
        End Try
    End Sub

End Module
