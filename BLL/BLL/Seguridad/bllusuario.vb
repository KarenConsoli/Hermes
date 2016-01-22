Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Public Class bllusuario
    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _contraseña As String
    Public Property contraseña() As String
        Get
            Return _contraseña
        End Get
        Set(ByVal value As String)
            _contraseña = value
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

    Private _idioma As Integer
    Public Property idioma() As Integer
        Get
            Return _idioma
        End Get
        Set(ByVal value As Integer)
            _idioma = value
        End Set
    End Property



    Sub New()

    End Sub

    'Metodo que devuelve verdadero si existe el usuario en DB y si no esta bloqueado
    'Retorna true si existe, o false si no existe
    Public Function existe() As Boolean

        Dim respuesta As Boolean
        Dim seto As New DataSet


        'objeto de datos
        Dim data As New DAL.daldatos


        'genero la consulta sql
        Dim consulta As String = "select nombre_usuario, bloq, baja from Usuarios where nombre_usuario= '" & _usuario & "'"


        Try
            'controlo si el query no trajo nada o si el segundo campo (bloqueo) es true (esta bloqueado)
            seto = data.EjecutarConsulta(consulta)

            If (seto.Tables(0).Rows(0).Item(0)) = Nothing Or (seto.Tables(0).Rows(0).Item(1)) = "True" Or (seto.Tables(0).Rows(0).Item(2)) = "True" Then
                MsgBox("Usuario Bloqueado/No Existe/Dado de Baja")
                Return False
            Else
                Return True
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return respuesta
    End Function

    'metodo que compara la contraseña 
    'Retorna true si existe, o false si no existe
    Public Function comprobar() As Boolean

        Dim consulta As String
        Dim data As New DAL.daldatos
        Dim seto As New DataSet
        Dim contraseña As String
        Dim respuesta As Boolean

        consulta = "select contraseña_usuario from Usuarios where nombre_usuario ='" & _usuario & "'"

        Try
            seto = data.EjecutarConsulta(consulta)
            contraseña = seto.Tables(0).Rows(0).Item(0).ToString
            'valido contraseña
            If contraseña = _contraseña Then
                MsgBox("Contraseña Correcta")
                respuesta = True
            Else
                respuesta = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




        Return respuesta
    End Function


    'Metodo que pone el contador a cero y retorna el id
    Public Function ContadorCero() As Integer
        Dim id As Integer
        Dim seto As New DataSet

        'genero un objeto para los datos 
        Dim data As New DAL.daldatos


        'genero la consulta para traer el id y el contador
        Dim consulta As String
        consulta = "select id_Usuarios, cant_inicios from Usuarios where nombre_usuario='" & _usuario & "'"
        Try
            seto = data.EjecutarConsulta(consulta)
            id = seto.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        'pregunto si el contador no esta en cero ya
        If seto.Tables(0).Rows(0).Item(1) > 0 Then
            'genero la consulta para poner el contador en cero
            consulta = "update Usuarios set cant_inicios = 0 where id_Usuarios=" & id

            Try
                seto = data.EjecutarConsulta(consulta)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        'calculo digito verificador y le paso la tabla a calcular el ultimo registro
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("Usuarios")
        dv.Recalcular_dvv("Usuarios")

        Return id
    End Function

    Shared Function pass() As String
        Dim Chares As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890~!@#$%^&*()_-+={}[]\|:;<>,.?/"
        Dim Rnd As New Random
        Dim builder As New StringBuilder
        Dim ch As Char

        For i As Integer = 1 To 10
            ch = Chares(Rnd.Next(0, Chares.Length))
            builder.Append(ch)
        Next

        Return builder.ToString
    End Function

    Shared Function ver_telefonos(ByVal id As Integer) As DataSet
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = "select * from Tel_Usuarios where id_usuario=" & id
        seto = data.EjecutarConsulta(consulta)
        Return seto

    End Function

    Shared Function id_usuario(ByVal usuario As String) As Integer
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = "Select Id_Usuarios from Usuarios where nombre_usuario='" & usuario & "'"
        seto = data.EjecutarConsulta(consulta)
        Dim id As Integer = seto.Tables(0).Rows(0).Item(0)
        Return id
    End Function
    Shared Function cargar_usuarios() As DataSet
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = "Select nombre_usuario from Usuarios"
        seto = data.EjecutarConsulta(consulta)

        Return seto
    End Function
    Shared Function mail_usuario(ByVal usuario As String) As String
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "Select mail from Usuarios where nombre_usuario='" & usuario & "'"
            seto = data.EjecutarConsulta(consulta)
            Dim mail As String = seto.Tables(0).Rows(0).Item(0)
            Return mail

        Catch ex As Exception
            MsgBox("Usted no tiene Mail Registrado")
        End Try

   
    End Function
End Class
