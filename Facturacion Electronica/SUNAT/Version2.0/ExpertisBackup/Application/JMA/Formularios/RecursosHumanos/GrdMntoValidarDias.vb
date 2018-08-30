Imports Janus.Windows.GridEX

Public Class GrdMntoValidarDias

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

#Region "Load"

    Private Sub GrdMntoValidarDias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub LoadData()

        ''''' Enumerado 
        EnumData.PopulateValueList("enumJMATipoDia", Me.Grid.Columns("TipoDia"))

        '''''' Operario
        'Dim Usuarios = New DataEngine().RetrieveData("advOperario", "IDOperario,DescOperario", "")
        'Dim dropTipOpearario As New GridEXDropDown
        'dropTipOpearario.SetDataBinding(Usuarios, String.Empty)
        'dropTipOpearario.DisplayMember = "DescOperario"
        'dropTipOpearario.ValueMember = "IdOperario"
        'dropTipOpearario.RetrieveStructure()
        'Grid.Columns("IdOperario").EditType = EditType.MultiColumnCombo
        'Grid.Columns("IdOperario").DropDown = dropTipOpearario

    End Sub



#End Region

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

End Class