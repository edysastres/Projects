Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class GestorCorreoMX

    Public Shared Function EnviarCorreos(ByVal emails As List(Of DatosEmailMX)) As LogProcess
        Dim Log As New LogProcess
        Dim enviados As New List(Of CreateElement)
        Dim errores As New List(Of ClassErrors)

        Dim data As New Solmicro.Expertis.Business.General.Correos.DataCorreos
        data.IDUsuario = ExpertisApp.Token.UserID
        Dim smtp As SmtpServerInfo = ExpertisApp.ExecuteTask(Of Solmicro.Expertis.Business.General.Correos.DataCorreos, SmtpServerInfo)(AddressOf Solmicro.Expertis.Business.General.Correos.LoadSmtpServerInfo, data)
        If Not smtp Is Nothing Then

            Dim client As SmtpClient = New SmtpClient(smtp.SmtpServerName, smtp.SmtpServerPort)
            client.EnableSsl = smtp.UseSSL
            '//Se habilita Ssl solo si el puerto es el indicado            
            'client.EnableSsl = (smtp.SmtpServerPort = 465 Or smtp.SmtpServerPort = 587)

            '//
            If Length(smtp.SmtpServerName) > 0 Then
                client.Credentials = New System.Net.NetworkCredential(smtp.UserName, smtp.UserPassword)
            End If

            For Each email As DatosEmailMX In emails
                Dim mail As New MailMessage

                For Each destinatario As String In email.ListaDestinatarios
                    mail.To.Add(destinatario)
                Next
                mail.From = New MailAddress(smtp.UserMail)
                mail.Subject = email.Asunto
                mail.Body = email.Mensaje
                For Each fichero As String In email.FicherosAdjuntos
                    mail.Attachments.Add(New Net.Mail.Attachment(fichero))
                Next
                'mail.BodyEncoding = System.Text.Encoding.Default

                Try
                    client.Send(mail)

                    Dim enviado As New CreateElement
                    enviado.IDElement = email.IDDocumento
                    enviado.NElement = email.NumeroDocumento
                    enviados.Add(enviado)
                Catch ex As SmtpException
                    Dim [error] As New ClassErrors
                    [error].Elements = email.NumeroDocumento
                    If Not ex.InnerException Is Nothing Then
                        [error].MessageError = ex.InnerException.Message
                    Else
                        [error].MessageError = ex.Message
                    End If
                    errores.Add([error])
                End Try
                If Not mail Is Nothing Then
                    mail.Dispose()
                End If
            Next
        End If

        Log.CreatedElements = enviados.ToArray()
        Log.Errors = errores.ToArray()

        Return Log
    End Function

    Public Shared Sub EscribirLogErrores(ByVal errores As List(Of ClassErrors))
        If errores.Count > 0 Then
            Dim filename As String = IO.Path.Combine(ExpertisApp.Path, "LogEnvioEmail.txt")
            Dim sw As IO.StreamWriter = New IO.StreamWriter(filename, False)
            Dim sb As New System.Text.StringBuilder
            For Each e As ClassErrors In errores
                sb.AppendLine(String.Format("{0} Documento {1}", Now.ToString("dd/MM/yyyy HH:mm"), e.Elements))
                sb.AppendLine(String.Format("{0} Error:  {1}", Now.ToString("dd/MM/yyyy HH:mm"), e.MessageError))
                sb.AppendLine()
            Next
            sw.WriteLine(sb.ToString())
            sw.Flush()
            sw.Close()
        End If
    End Sub

    Public Shared Function FormatearTexto(ByVal data As ParametrosFormatearTexto) As String
        Dim texto As String = data.Texto
        If Length(texto) > 0 Then
            Dim valores_texto As DataTable = data.Valores
            If valores_texto.Rows.Count > 0 Then
                Dim campos As MatchCollection = Regex.Matches(texto, "{(.*?)}")
                If campos.Count > 0 Then
                    For Each campo As Match In campos
                        If campo.Groups.Count > 1 Then
                            If campo.Groups(0).Success Then

                                Dim texto1 As String = campo.Groups(0).Value
                                Dim valor1 As String = Nothing

                                If campo.Groups(1).Success Then
                                    Dim nombre_campo As String = campo.Groups(1).Value
                                    If valores_texto.Columns.Contains(nombre_campo) Then
                                        If Length(valores_texto.Rows(0)(nombre_campo)) > 0 Then
                                            Dim aux As String = valores_texto.Rows(0)(nombre_campo)
                                            aux = aux.Replace(vbTab, "")
                                            valor1 = aux.Replace(vbNewLine, "")
                                        End If
                                    End If
                                End If

                                texto = texto.Replace(texto1, valor1)

                            End If
                        End If
                    Next
                End If
            End If
        End If
        Return texto
    End Function
End Class

Public Class ParametrosFormatearTexto
    Public Texto As String
    Public Valores As DataTable
End Class
