Public Class FrmChecadas


#Region "Propiedades Públicas"


    Private mDrPersonaFecha As DataRow
    Private mDrControlPrececia As DataTable


    Public WriteOnly Property DrPersonaFecha() As DataRow
        Set(ByVal value As DataRow)
            mDrPersonaFecha = value
        End Set
    End Property

    Public WriteOnly Property DrControlPre() As DataTable
        Set(ByVal value As DataTable)
            mDrControlPrececia = value
        End Set
    End Property
#End Region


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

#Region "Load"

    Private Sub FrmChecadas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        If Not mDrPersonaFecha Is Nothing Then

            Me.TextBoxIdOperario.Text = Me.mDrPersonaFecha("IdOperario")
            Me.TextBoxDescOperario.Text = Me.mDrPersonaFecha("DescOperario")
            Me.TextBoxFecha.Text = Me.mDrPersonaFecha("Fecha")
            Me.TextBoxIdOperario.Enabled = False
            Me.TextBoxDescOperario.Enabled = False
            Me.TextBoxFecha.Enabled = False

            Dim F As New Filter
            F.Add(New StringFilterItem("IdOperario", Me.mDrPersonaFecha("IdOperario")))
            F.Add(New DateFilterItem("Fecha", Me.mDrPersonaFecha("Fecha")))
            Me.GrdControlPrecencia.DataSource = New DataEngine().Filter("vJMACIControlDedicacionOperario", F)

            'Dim Usuarios = New DataEngine().RetrieveData("advOperario", "IDOperario,DescOperario", "")
            'Dim dropTipOpearario As New GridEXDropDown
            'dropTipOpearario.SetDataBinding(Usuarios, String.Empty)
            'dropTipOpearario.DisplayMember = "DescOperario"
            'dropTipOpearario.ValueMember = "IdOperario"
            'dropTipOpearario.RetrieveStructure()
            'GrdControlPrecencia.Columns("IdOperario").EditType = EditType.MultiColumnCombo
            'GrdControlPrecencia.Columns("IdOperario").DropDown = dropTipOpearario

            'Me.Grid1.ReQuery.Columns("IdOperario").DefaultValue = Me.mDrPersonaFecha("idOperario")
            'Dim ControlPresencia As New ControlPresencia()
            'Me.Grid1.ReQuery(New FilterItem("IdOperario", FilterOperator.Equal, Me.mDrPersonaFecha("idOperario"), Me.mDrPersonaFecha("Fecha")))
            'Me.Grid1.ReQuery(New FilterItem("IdOperario", FilterOperator.Equal, Me.mDrPersonaFecha("idOperario")))
            'Me.Grid1.DataSource = ControlPresencia
            'Me.ULblDescGrupoTurno.Text = Nz(Me.mDrGrupoTurno("DescGrupoTurno"), String.Empty)
            ''Me.GrdGrupoTurnoLinea.DataSource = New BE.DataEngine().Filter("vJMAGrupoTurnoLinea", New FilterItem("NGrupoTurno", FilterOperator.Equal, Me.mDrGrupoTurno("NGrupoTurno")))
            ''CType(Me.GrdGrupoTurnoLinea.DataSource, DataTable).TableName = "JMAGrupoTurnoLinea"
            'Me.GrdGrupoTurnoLinea.ReQuery(New FilterItem("NGrupoTurno", FilterOperator.Equal, Me.mDrGrupoTurno("NGrupoTurno")))
            'Me.GrdGrupoTurnoLinea.Columns("NGrupoTurno").DefaultValue = Me.mDrGrupoTurno("NGrupoTurno")
            ''EnumData.PopulateValueList("enumJMADiaSemana", Me.GrdGrupoTurnoLinea.Columns("DiaSemana"))
            'Me.GrdGrupoTurnoLinea.Columns("DiaSemana").DropDown.SetDataBinding(EnumData.EnumView("enumJMADiaSemana"), Nothing)

        End If
    End Sub

#End Region

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

#Region "Botones"

    Private Sub ButtonAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click

        SaveData()

        ''''' Recalcular las entradas y salidas
        ExpertisApp.ExecuteTask(Of ClsChecador)(AddressOf ClsChecador.ValidarChecadas, Nothing)

        '''' Procediminto para re validar las chacadas segunda validacion poner la Falta
        ExpertisApp.ExecuteTask(Of ClsChecador)(AddressOf ClsChecador.ReValidarChecadas, Nothing)

        DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub SaveData()
        Dim NuevoRegistro As New ControlPresencia

        ''''' Agregar 
        Dim DtAdd As DataTable = CType(Me.GrdControlPrecencia.DataSource, DataTable).GetChanges(DataRowState.Added)
        If Not DtAdd Is Nothing Then

            '''''' Revisar que tipo de entrada vamos a poner
            Dim dTemporal As DataTable = GrdControlPrecencia.DataSource
            Dim Entradas As Integer = dTemporal.Select("Entrada=1").Count
            Dim Salidas As Integer = dTemporal.Select("Entrada=0").Count
            If DtAdd.Rows.Count > 0 Then

                ''''' NOTA COMENTARIO
                ''''' Forzar que pongan la Fecha correcta sgun la fila seleccionada
                ''''' O dejamos que pongan la fecha que quieran y el operario
                DtAdd(0)("Fecha") = mDrPersonaFecha("Fecha")
                DtAdd(0)("IdOperario") = mDrPersonaFecha("IdOperario")

                '''''' Colocar la entrada Correcta
                If Entradas = Salidas Then
                    DtAdd(0)("Entrada") = 1
                ElseIf Entradas > Salidas Then
                    DtAdd(0)("Entrada") = 0
                ElseIf Entradas < Salidas Then
                    DtAdd(0)("Entrada") = 1
                End If

                NuevoRegistro.Validate(DtAdd)
                NuevoRegistro.Update(DtAdd)

            End If
        End If

        ''''' Actualizar 
        Dim DtUpd As DataTable = CType(Me.GrdControlPrecencia.DataSource, DataTable).GetChanges(DataRowState.Modified)
        If Not DtUpd Is Nothing Then
            If DtUpd.Rows.Count > 0 Then
                NuevoRegistro.Validate(DtUpd)
                NuevoRegistro.Update(DtUpd)
            End If
        End If

        ''''' Borrar
        ''''' Seun Yo no pueden borrar regitros 
        Dim DtDel As DataTable = CType(Me.GrdControlPrecencia.DataSource, DataTable).GetChanges(DataRowState.Deleted)

        If Not DtDel Is Nothing Then
            If DtDel.Rows.Count > 0 Then
                DtDel.RejectChanges()
                NuevoRegistro.Delete(DtDel)
            End If
        End If

    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

#Region "Frm Nuevos"

    Private Sub ButtonAltaNuevaEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAltaNuevaEntrada.Click


        Dim NuevoRegistro As New FrmAltaEntrada()
        NuevoRegistro.DrPersonaFecha = Me.mDrPersonaFecha
        NuevoRegistro.DrControlPre = Me.GrdControlPrecencia.DataSource
        NuevoRegistro.ShowDialog()

        '''''' Recalcular las entradas y salidas
        ExpertisApp.ExecuteTask(Of ClsChecador)(AddressOf ClsChecador.ValidarChecadas, Nothing)

        '''' Procediminto para re validar las chacadas segunda validacion poner la Falta
        ExpertisApp.ExecuteTask(Of ClsChecador)(AddressOf ClsChecador.ReValidarChecadas, Nothing)

        ''''''Aviso
        ExpertisApp.GenerateMessage("El Registro Se Guardado Correctamente")
        Me.Close()

    End Sub

#End Region


End Class