Public Class blllogin
    Dim bita As New BLL.bllbitacora
    Dim encrypta As New BLL.bllencriptar

#Region "Propiedades"

    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Sub New()

    End Sub
#End Region

#Region "Metodos"

    'Metodo que comprueba y carga el nombre del usuario
    Public Function Iniciar() As Boolean

        'creo un objeto usuario y cargo el nombre
        Dim usuarito As New bllusuario
        usuarito.usuario = _usuario

        'controla que el usuario exista y no este bloqueado
        Dim respuesta As Boolean
        If usuarito.existe = True Then
            respuesta = True

        Else
            respuesta = False

        End If
        Return respuesta
    End Function

    'metodo para terminar de loguear al usuario
    Public Function cargar(ByVal contraseña As String) As Boolean
        Dim respuesta As Boolean
        'creo un objeto usuario
        Dim usuarito As New bllusuario
        usuarito.usuario = _usuario

        usuarito.contraseña = contraseña

        'compruebo contraseña 
        Dim rta As Boolean
        rta = usuarito.comprobar()
        If rta = False Then
            MsgBox("El usuario y la contraseña no concuerdan")
            Dim dv As New BLL.blldv

            bita.usuario = _usuario
            bita.criticidad = "Medio"
            bita.desc_mov = "Contraseña Incorrecta"
            bita.grabar()
            dv.recalcular_dvh("bitacora")

            dv.Recalcular_dvv("bitacora")
            Dim data As New DAL.daldatos
            Dim seto As New DataSet

            Dim consulta As String = "Update Usuarios set cant_inicios=cant_inicios+1 where nombre_usuario='" & _usuario & "'"
            data.EjecutarConsulta(consulta)
            consulta = "Select cant_inicios from Usuarios where nombre_usuario='" & _usuario & "'"
            seto = data.EjecutarConsulta(consulta)
            Dim cant_inicios As Integer
            cant_inicios = seto.Tables(0).Rows(0).Item(0)
            If cant_inicios > 3 Then
                consulta = "Update Usuarios set bloq=1 where nombre_usuario='" & _usuario & "'"
                data.EjecutarConsulta(consulta)
                MsgBox("El usuario: " & encrypta.desencriptar(_usuario) & " ha superado los 3 intentos de inicio. Se ha bloquedo")
            End If
            respuesta = False
        Else
            'si la contraseña es correcta
            Dim dv As New BLL.blldv

            bita.usuario = _usuario
            bita.criticidad = "bajo"
            bita.desc_mov = "Contraseña Correcta"
            bita.grabar()
            dv.recalcular_dvh("bitacora")
            dv.Recalcular_dvv("bitacora")

            MsgBox("Bienvenido")
            dv.recalcular_dvh("Usuarios")
            dv.Recalcular_dvv("Usuarios")
            dv.recalcular_dvh("bitacora")
            dv.Recalcular_dvv("bitacora")
    
            'pongo el contador a cero y capturo el id para grabarlo en bitacora
            Dim id As Integer
            id = usuarito.ContadorCero()
            respuesta = True
        End If

        Return respuesta
    End Function

#End Region


End Class
