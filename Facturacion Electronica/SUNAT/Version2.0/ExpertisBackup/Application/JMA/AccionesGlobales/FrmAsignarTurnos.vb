Public Class FrmAsignarTurnos



    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

#Region " Botones "

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click

        If Length(AdvSearchGurpoTurno.Text) = 0 Or Length(AdvSearchOperario.Text) = 0 Then
            ExpertisApp.GenerateMessage("Para poder continuar completa la Informacion Faltante", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Length(CalendarBoxInicio.Value) = 0 Or Length(CalendarBoxFin.Value) = 0 Then
            ExpertisApp.GenerateMessage("Para poder continuar Ingresa las Fechas.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'If CalendarBoxInicio.Value < Today Then
        '    CalendarBoxInicio.Value = Today
        'End If

        If CalendarBoxInicio.Value > CalendarBoxFin.Value Then
            ExpertisApp.GenerateMessage("Revisa las Fechas, El rango de Fechas no esta correcto", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim Parametros As New ClsProcesosRecursosHumanos.ParametrosAsignarTurnos()
        Parametros.Fehaincio = CDate(CalendarBoxInicio.Text)
        Parametros.FehaFin = CDate(CalendarBoxFin.Text)
        Parametros.GrupoTurno = AdvSearchGurpoTurno.Text
        Parametros.IDoperario = AdvSearchOperario.Text

        ExpertisApp.ExecuteTask(Of ClsProcesosRecursosHumanos.ParametrosAsignarTurnos)(AddressOf ClsProcesosRecursosHumanos.AsignarTurnos, Parametros)

        ExpertisApp.GenerateMessage("Turno Asignado Correctamnte", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Exclamation)

        Me.Close()
    End Sub

#End Region

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

#Region " Actualizar Campos "


    Private Sub AdvSearchGurpoTurno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvSearchGurpoTurno.TextChanged
        UnderLineLabelGrupoTurno.Text = AdvSearchGurpoTurno.Value
    End Sub

    Private Sub AdvSearchOperario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvSearchOperario.TextChanged
        UnderLineLabelOperario.Text = AdvSearchOperario.SelectedRow(1).ToString

        Dim strViewName As String = "vJMAObtenerTurnoActual"
        Dim oFltr As New Filter
        oFltr.Add(New StringFilterItem("IdOperario", FilterOperator.Equal, AdvSearchOperario.Text))

        Dim dtLineas As DataTable
        dtLineas = New BE.DataEngine().Filter(strViewName, oFltr, , "Fecha desc")

        If dtLineas.Rows.Count > 0 Then
            LabelTurnoActual.Text = "Turno Actual: " + dtLineas.Rows(0)(4).ToString
        Else : LabelTurnoActual.Text = ""
        End If


    End Sub

#End Region

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

#Region " Load Form "

    Private Sub FrmAsignarTurnos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CalendarBoxInicio.Value = Today
    End Sub

#End Region

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

End Class