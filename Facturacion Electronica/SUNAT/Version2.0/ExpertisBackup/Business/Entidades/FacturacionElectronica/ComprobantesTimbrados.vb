Public Class ComprobantesTimbrados

#Region "Constructor"

    Inherits Solmicro.Expertis.Engine.BE.BusinessHelper

    Public Sub New()
        MyBase.New(cnEntidad)
    End Sub

    ''' <summary>
    ''' Establezca el nombre de la tabla que corresponde con esta Entidad
    ''' </summary>
    ''' <remarks>NO SE OLVIDE DE CAMBIAR EL NOMBRE DE TABLA</remarks>
    Private Const cnEntidad As String = "tbJMAComprobantesTimbrados"

#End Region

#Region "Eventos Entidad"

    ''' <summary>
    ''' Evento para establecer las tareas necesarias para valores por defecto para un nuevo registro de la entidad
    ''' </summary>
    ''' <param name="addnewProcess"></param>
    ''' <remarks>BORRAR PROCESO SI NO SE INSERTA NINGUNA TAREA</remarks>
    Protected Overrides Sub RegisterAddnewTasks(ByVal addnewProcess As Solmicro.Expertis.Engine.BE.BusinessProcesses.Process)
        addnewProcess.AddTask(Of Object)(AddressOf FeedbackRegistro)
        MyBase.RegisterAddnewTasks(addnewProcess)
    End Sub

    ''' <summary>
    ''' Evento para establecer las tareas necesarias para validar los datos previo a su inserción o modificación de datos la entidad
    ''' </summary>
    ''' <param name="validateProcess"></param>
    ''' <remarks>BORRAR PROCESO SI NO SE INSERTA NINGUNA TAREA</remarks>
    Protected Overrides Sub RegisterValidateTasks(ByVal validateProcess As Solmicro.Expertis.Engine.BE.BusinessProcesses.Process)
        validateProcess.AddTask(Of DataRow)(AddressOf ValidarCamposNulos)
        MyBase.RegisterValidateTasks(validateProcess)
    End Sub

    ''' <summary>
    ''' Evento para establecer las tareas necesarias para llevar a cabo establecimiento de datos, grabado en otras tablas.
    ''' Previo a la inserción o modificación de datos de la entidad
    ''' </summary>
    ''' <param name="updateProcess"></param>
    ''' <remarks>BORRAR PROCESO SI NO SE INSERTA NINGUNA TAREA</remarks>
    'Protected Overrides Sub RegisterUpdateTasks(ByVal updateProcess As Solmicro.Expertis.Engine.BE.BusinessProcesses.Process)
    '    MyBase.RegisterUpdateTasks(updateProcess)
    'End Sub

    ''' <summary>
    ''' Evento para establecer las tareas necesarias tanto de validación como de actualizaciones, previo al borrado de datos de la entidad
    ''' </summary>
    ''' <param name="deleteProcess"></param>
    ''' <remarks>BORRAR PROCESO SI NO SE INSERTA NINGUNA TAREA</remarks>
    'Protected Overrides Sub RegisterDeleteTasks(ByVal deleteProcess As Solmicro.Expertis.Engine.BE.BusinessProcesses.Process)
    '    MyBase.RegisterDeleteTasks(deleteProcess)
    'End Sub
	
	''' <summary>
    ''' Evento para establecer las reglas de negocio necesarias para esta entidad
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>BORRAR PROCESO SI NO SE INSERTA NINGUNA TAREA</remarks>
    'Public Overrides Function GetBusinessRules() As Solmicro.Expertis.Engine.BE.BusinessRules
    '    Dim oBrl As New BusinessRules
    '    Return oBrl
    'End Function
	
#End Region

#Region "Funciones Públicas"

    'Tareas de nuevo registro

    <Task()> Public Shared Sub FeedbackRegistro(ByVal data As Object, ByVal services As ServiceProvider)
        MsgBox("El registro fue insertado correctamente", MsgBoxStyle.OkOnly, "Registro insertado")
    End Sub

    'Tareas de validación

    <Task()> Public Shared Sub ValidarCamposNulos(ByVal data As DataRow, ByVal services As ServiceProvider)
        If (Length(data("IDComprobante")) = 0) Then
            ApplicationService.GenerateError("El ID de comprobante no fue especificado, favor de comprobarlo.")
        End If

        If (Length(data("IDFactura")) = 0) Then
            ApplicationService.GenerateError("El ID de la factura no se especificó, favor de comprobarlo.")
        End If

        If (Length(data("NComprobante")) = 0) Then
            ApplicationService.GenerateError("El número de comprobante no fue especificado, favor de revisarlo.")
        End If

        If (Length(data("IDContador")) = 0) Then
            ApplicationService.GenerateError("El identificador del contador no fue especificado, favor de revisarlo.")
        End If

    End Sub

#End Region

End Class