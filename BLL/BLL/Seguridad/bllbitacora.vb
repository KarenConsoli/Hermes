Public Class bllbitacora

    Private _desc_mov As String
    Public Property desc_mov() As String
        Get
            Return _desc_mov
        End Get
        Set(ByVal value As String)
            _desc_mov = value
        End Set
    End Property
    Private _criticidad As String
    Public Property criticidad() As String
        Get
            Return _criticidad
        End Get
        Set(ByVal value As String)
            _criticidad = value
        End Set
    End Property
    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(ByVal dec_mov As String, ByVal criticidad As String, ByVal usuario As String)
        Me.desc_mov = desc_mov
        Me.criticidad = criticidad
        Me.usuario = usuario
    End Sub

    Public Function grabar() As Boolean
        'obtengo la fecha y hora
        Dim fecha As DateTime = DateTime.Now
        fecha = Format(Now(), "yyyy/MM/dd")

        'encripto el texto
        Dim cifrar As New BLL.bllencriptar

        Dim cifrado As String = cifrar.encriptar(_desc_mov)

        'genero e inserto el registro a insertar
        Dim consulta As String = "insert into bitacora (nombre_usuario, desc_mov, criticidad, Fecha_mov, dvh) values('" & _usuario & "', '" & cifrado & "','" & _criticidad & "', '" & fecha & "', 0)"
        Dim data As New DAL.daldatos
        Try
            data.EjecutarConsulta(consulta)
            ' MsgBox("Bitácora actualizada")
        Catch ex As Exception

        End Try
        
        'calculo el  digito verificador
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        Return True
    End Function

    Public Function mostrar() As DataSet
        Dim seto As DataSet
        Dim consulta As String = "select * from Bitácora"
        Dim data As New DAL.daldatos

        seto = data.EjecutarConsulta(consulta)
        Return seto
    End Function

    Shared Function buscar_bitacora(ByVal criticidad As String, ByVal usuario As String, ByVal desde As Date, ByVal hasta As Date) As DataSet
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt
        Dim consulta As String

        If criticidad = "" And usuario = "" Then
            consulta = "SELECT * FROM bitacora where Fecha_mov between '" & desde & "' and '" & hasta & "'"
        End If
        If criticidad = "" And usuario <> "" Then
            consulta = "SELECT * FROM bitacora where nombre_usuario='" & usuario & "' and Fecha_mov between '" & desde & "' and '" & hasta & "'"
        End If
        If usuario = "" And criticidad <> "" Then
            consulta = "SELECT * FROM bitacora where criticidad='" & criticidad & "' and Fecha_mov between '" & desde & "' and '" & hasta & "'"
        End If
        If criticidad <> "" And usuario <> "" Then
            consulta = "SELECT * FROM bitacora where criticidad='" & criticidad & "' and  nombre_usuario='" & usuario & "' and Fecha_mov between '" & desde & "' and '" & hasta & "'"
        End If

        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New DAL.daldatos
        Dim seto As New DataSet
        'intentemos
        'me siento dora la exploradora
        Try
            'llamamos la funcion ejecutarconsulta dentro de la clase datos
            'siendo el parametro consulta mandado
            'y asi llenamos a seto
            seto = data.EjecutarConsulta(consulta)
        Catch ex As Exception
        End Try
        Return seto
    End Function
    Shared Function eliminar_bitacora(ByVal criticidad As String, ByVal usuario As String, ByVal desde As Date, ByVal hasta As Date) As DataSet
        'variable que guarda consulta de sql
        Dim encrypta As New BLL.bllencriptar

        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt
        Dim consulta As String

        If criticidad = "" And usuario = "" Then
            consulta = "delete FROM bitacora where Fecha_mov between '" & desde & "' and '" & hasta & "'"
        End If
        If criticidad = "" And usuario <> "" Then
            consulta = "delete FROM bitacora where nombre_usuario='" & encrypta.encriptar(usuario) & "' and Fecha_mov between '" & desde & "' and '" & hasta & "'"
        End If
        If usuario = "" And criticidad <> "" Then
            consulta = "delete FROM bitacora where criticidad='" & criticidad & "' and Fecha_mov between '" & desde & "' and '" & hasta & "'"
        End If
        If criticidad <> "" And usuario <> "" Then
            consulta = "delete FROM bitacora where criticidad='" & criticidad & "' and  nombre_usuario='" & encrypta.encriptar(usuario) & "' and Fecha_mov between '" & desde & "' and '" & hasta & "'"
        End If

        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New DAL.daldatos
        Dim seto As New DataSet
        'intentemos
        'me siento dora la exploradora
        Try
            'llamamos la funcion ejecutarconsulta dentro de la clase datos
            'siendo el parametro consulta mandado
            'y asi llenamos a seto
            seto = data.EjecutarConsulta(consulta)
        Catch ex As Exception
        End Try
        Return seto
    End Function
End Class
