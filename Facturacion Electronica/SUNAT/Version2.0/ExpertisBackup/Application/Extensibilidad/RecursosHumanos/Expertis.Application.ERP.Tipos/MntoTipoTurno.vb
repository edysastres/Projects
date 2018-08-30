Public Class MntoTipoTurno
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents PicCabecera As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblFwiIDTipoTurno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridLinea As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents txtIDTipoTurno As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDescTipoTurno As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridLinea_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoTipoTurno))
        Me.GridLinea = New Solmicro.Expertis.Engine.UI.Grid
        Me.PicCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblFwiIDTipoTurno = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDTipoTurno = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTipoTurno = New Solmicro.Expertis.Engine.UI.TextBox
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.GridLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PicCabecera.suspendlayout()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 42)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.GridLinea)
        Me.MainPanel.Controls.Add(Me.PicCabecera)
        Me.MainPanel.Size = New System.Drawing.Size(885, 468)
        '
        'GridLinea
        '
        Me.GridLinea.AutoEdit = True
        GridLinea_DesignTimeLayout.LayoutString = resources.GetString("GridLinea_DesignTimeLayout.LayoutString")
        Me.GridLinea.DesignTimeLayout = GridLinea_DesignTimeLayout
        Me.GridLinea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridLinea.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridLinea.EntityName = "TipoTurnoLinea"
        Me.GridLinea.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridLinea.Location = New System.Drawing.Point(0, 32)
        Me.GridLinea.Name = "GridLinea"
        Me.GridLinea.PrimaryDataFields = "IDTipoTurno"
        Me.GridLinea.SecondaryDataFields = "IDTipoTurno"
        Me.GridLinea.Size = New System.Drawing.Size(885, 436)
        Me.GridLinea.TabIndex = 4
        Me.GridLinea.ViewName = "vJMATipoTurnoLinea"
        '
        'PicCabecera
        '
        Me.PicCabecera.Controls.Add(Me.lblFwiIDTipoTurno)
        Me.PicCabecera.Controls.Add(Me.txtIDTipoTurno)
        Me.PicCabecera.Controls.Add(Me.txtDescTipoTurno)
        Me.PicCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PicCabecera.Name = "PicCabecera"
        Me.PicCabecera.Size = New System.Drawing.Size(885, 32)
        Me.PicCabecera.TabIndex = 5
        '
        'lblFwiIDTipoTurno
        '
        Me.lblFwiIDTipoTurno.Location = New System.Drawing.Point(8, 4)
        Me.lblFwiIDTipoTurno.Name = "lblFwiIDTipoTurno"
        Me.lblFwiIDTipoTurno.Size = New System.Drawing.Size(67, 13)
        Me.lblFwiIDTipoTurno.TabIndex = 0
        Me.lblFwiIDTipoTurno.Text = "Tipo Turno"
        '
        'txtIDTipoTurno
        '
        Me.TryDataBinding(txtIDTipoTurno, New System.Windows.Forms.Binding("Text", Me, "IDTipoTurno", True))
        Me.txtIDTipoTurno.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDTipoTurno.Location = New System.Drawing.Point(80, 4)
        Me.txtIDTipoTurno.Name = "txtIDTipoTurno"
        Me.txtIDTipoTurno.Size = New System.Drawing.Size(110, 21)
        Me.txtIDTipoTurno.TabIndex = 0
        '
        'txtDescTipoTurno
        '
        Me.TryDataBinding(txtDescTipoTurno, New System.Windows.Forms.Binding("Text", Me, "DescTipoTurno", True))
        Me.txtDescTipoTurno.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTipoTurno.Location = New System.Drawing.Point(193, 4)
        Me.txtDescTipoTurno.Name = "txtDescTipoTurno"
        Me.txtDescTipoTurno.Size = New System.Drawing.Size(489, 21)
        Me.txtDescTipoTurno.TabIndex = 1
        '
        'MntoTipoTurno
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(893, 541)
        Me.EntityName = "TipoTurno"
        Me.Name = "MntoTipoTurno"
        Me.NavigationFields = "IDTipoTurno"
        Me.NoEditableControls = New Solmicro.Expertis.Engine.UI.NoEditableControls(New System.Windows.Forms.Control() {Me.txtIDTipoTurno})
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.GridLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PicCabecera.ResumeLayout(False)
        Me.PicCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region



  
    Private Sub GridLinea_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridLinea.AddingRecord
        Dim IntRegistro As Integer = CInt(Me.GridLinea.DataSource.rows.count) '(From Dr As DataRow In CType(Me.GridLinea.DataSource, DataTable).Rows Where Dr("DiaSemana") = Me.GridLinea.GetValue("DiaSemana")).Count)
        If IntRegistro >= 1 Then
            ExpertisApp.GenerateMessage("No puedes meter 2 filas", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Exclamation)
            e.Cancel = True
            'Me.cancel = True

        End If

    End Sub



    ''''''''''''    Horarios
    ''''''''''''08:0//17:0   	WORKING HOURS FROM 08:00 AM TO 05:00 PM 	Comida 60, Descanso 0 
    ''''''''''''08:0//12:3   	WORKING HOURS FROM 08:00 AM TO 12:30 PM	    Comida 30, Descanso 0 
    ''''''''''''09:3//18:3   	WORKING HOURS FROM 09:30 AM TO 06:30 PM	    Comida 60, Descanso 0
    ''''''''''''06:0//15:0    	WORKING HOURS FROM 06:00 AM TO 03:00 PM	    Comida 60, Descanso 0

    ''''''''''''  Grupos a Crear
    ''''''''''''STANDARD SHIFT 		    08:0//17:0 	Lunes a Viernes
    ''''''''''''PART TIME SHIFT		    08:0//12:3	Lunes a Viernes
    ''''''''''''TECH SUPPORT SHIFT		09:3//18:3	Lunes a Viernes
    ''''''''''''CLIMATE SHIFT			06:0//15:0	Lunes a Viernes

    '''''''''''' Personas y Turno
    ''''''''''''URBIETA, EDUARDO		STANDARD SHIFT
    ''''''''''''MORAIS, GABRIELA		STANDARD SHIFT
    ''''''''''''MARTINEAU, DAVID		TECH SUPPORT SHIFT
    ''''''''''''ROCHEFORT, LYNN		
    ''''''''''''PANTOJA, NOEMI		    CLIMATE SHIFT
    ''''''''''''TORRES, DANIEL	    	CLIMATE SHIFT
    ''''''''''''COLON, YASHIRA	    	CLIMATE SHIFT
    ''''''''''''EL HARIF, AMINE	        STANDARD SHIFT














End Class
