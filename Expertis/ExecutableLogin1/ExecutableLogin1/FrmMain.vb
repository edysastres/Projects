Public Class FrmMain

    Private Sub FrmMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        ExpertisApp.CloseSession()
    End Sub

    Private Sub FrmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ExpertisApp.Open()
        Login()
    End Sub

    Private Sub Login()
        Dim Aut As New AuthenticationInfo
        Aut.Authentication = AuthenticationMode.ExpertisAuthentication
        Aut.UserName = "u.test"
        Aut.Pwd = "u.test"
        Dim ClsApp As New ApplicationService
        Dim Tok As TokenInfo = ClsApp.Login(Aut, "PROGRAMADOR-B4.altuna.corp", System.Guid.Empty, "Login")
        ExpertisApp.GetSessionDescriptor(SessionInfo.All)
        ExpertisApp.CheckBusinessVersion()
        System.Runtime.Remoting.Messaging.CallContext.SetData(SessionInformation.SessionSlot, New SessionInformation(Tok.Token))
    End Sub

    'Private Sub Login()
    '    Dim Aut As New AuthenticationInfo
    '    Aut.Authentication = AuthenticationMode.WindowsAuthentication
    '    Aut.UserName = "ALTUNA\AR.HERNANDEZ"
    '    Aut.Pwd = "PARAMETRO_VUESTRO_PASSWORD"
    '    Dim ClsApp As New ApplicationService
    '    Dim Tok As TokenInfo = ClsApp.Login(Aut, "PROGRAMADOR-B4.altuna.corp", System.Guid.Empty, "Login")
    '    ExpertisApp.GetSessionDescriptor(SessionInfo.All)
    '    ExpertisApp.CheckBusinessVersion()
    '    System.Runtime.Remoting.Messaging.CallContext.SetData(SessionInformation.SessionSlot, New SessionInformation(Tok.Token))
    'End Sub

End Class