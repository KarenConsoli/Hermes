Public Class bllfamilia
    Inherits bllpermisos


    'Metodo que completa la table de permisos por la familia
    Public Sub permisos()
        'creo la consulta
        Dim consulta As String
        consulta = "select p.id_pat from Patentes p inner join patentefamilia f on p.id_pat=f.Id_pat inner join Familia fa on f.Id_fam=fa.Id_Familia inner join usuariofamilia uf on fa.Id_Familia=uf.Id_fam inner join Usuarios u on uf.Id_usuario=u.Id_Usuarios where u.nombre_usuario='" & _usuario & "'"
        Dim data As New DAL.daldatos

        _seto = data.EjecutarConsulta(consulta)
    End Sub
    Shared Function usuario_familia(ByRef setito As DataSet) As DataSet
        'creo la consulta
        Dim permisos As New bllpermisos

        Dim consulta As String
        consulta = "select p.id_pat from Patentes p inner join patentefamilia f on p.id_pat=f.Id_pat inner join Familia fa on f.Id_fam=fa.Id_Familia inner join usuariofamilia uf on fa.Id_Familia=uf.Id_fam inner join Usuarios u on uf.Id_usuario=u.Id_Usuarios where u.nombre_usuario='" & permisos.usuario & "'"
        Dim data As New DAL.daldatos
        setito = data.EjecutarConsulta(consulta)
        Return setito
    End Function

    'Patentes que no son de la familia del Usuario
    Shared Function patentes_nofamilia(ByVal id_familia As List(Of String), ByVal id_usuario As Integer) As DataSet
        'creo la consulta
        Dim permisos As New bllpermisos
        Dim setito As New DataSet

        Try
            Dim consulta As String = "SELECT p.id_pat, p.desc_pat FROM Patentes p WHERE p.id_pat not  in (SELECT up.Id_pat FROM usuariopatente up WHERE up.id_usuario= " & id_usuario & " and asignado=1 or negado = 1 "
            For k As Integer = 0 To id_familia.Count - 1
                consulta += String.Concat(" union SELECT  pf.Id_pat from patentefamilia pf WHERE pf.Id_fam = " & id_familia(k))
            Next

            consulta += String.Concat(" )")

            Dim data As New DAL.daldatos
            setito = data.EjecutarConsulta(consulta)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return setito
    End Function

    Shared Function patentes_dentro_usuariofamilia(ByVal id_familia As List(Of String), ByVal id_usuario As Integer) As DataSet
        'creo la consulta
        Dim permisos As New bllpermisos
        Dim setito As New DataSet

        Try
            Dim consulta As String = "SELECT id_pat, desc_pat FROM Patentes WHERE id_pat in(SELECT up.Id_pat from usuariopatente up WHERE  up.asignado = 1 and negado = 0 and up.Id_usuario= " & id_usuario
            For k As Integer = 0 To id_familia.Count - 1
                consulta += String.Concat(" union SELECT  pf.Id_pat from patentefamilia pf WHERE pf.Id_fam = " & id_familia(k))
            Next

            consulta += String.Concat(" )")

            Dim data As New DAL.daldatos
            setito = data.EjecutarConsulta(consulta)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return setito
    End Function
    Shared Function familias_de_usuario(ByVal id_usuario As Integer) As DataSet
        Dim permisos As New bllpermisos
        Dim setito As New DataSet

        Dim consulta As String
        consulta = "select id_fam from usuariofamilia WHERE Id_usuario=" & id_usuario
        Dim data As New DAL.daldatos
        setito = data.EjecutarConsulta(consulta)

        Return setito
    End Function

    Shared Function patentes_familia(ByVal id_usuario As Integer) As DataSet
        Dim permisos As New bllpermisos
        Dim setito As New DataSet

        Dim consulta As String
        consulta = "select p.id_pat, p.desc_pat from Patentes p inner join patentefamilia f on p.id_pat=f.Id_pat inner join Familia fa on f.Id_fam=fa.Id_Familia inner join usuariofamilia uf on fa.Id_Familia=uf.Id_fam inner join Usuarios u on uf.Id_usuario=u.Id_Usuarios where u.Id_Usuarios=" & id_usuario
        Dim data As New DAL.daldatos
        setito = data.EjecutarConsulta(consulta)

        Return setito
    End Function
    Shared Function nofamilias_de_usuario(ByVal id_usuario As Integer) As DataSet
        Dim permisos As New bllpermisos
        Dim setito As New DataSet

        Dim consulta As String
        consulta = "select Id_Familia, nombre_familia  from Familia where Id_Familia not in (select id_fam from usuariofamilia where Id_usuario= " & id_usuario & ")"
        Dim data As New DAL.daldatos
        setito = data.EjecutarConsulta(consulta)

        Return setito
    End Function
    Shared Function asignar_familia(ByVal id_usuario As Integer, ByVal id_familia As Integer) As DataSet

        Dim setito As New DataSet

        Dim consulta As String
        consulta = "insert into usuariofamilia (Id_usuario, Id_fam) values (" & id_usuario & ", " & id_familia & " )"
        Dim data As New DAL.daldatos
        setito = data.EjecutarConsulta(consulta)
        MsgBox("Familia Asignada:" & id_familia)
        Return setito
    End Function

    Shared Function nombre_familias_de_usuario(ByVal id_usuario As Integer) As DataSet
        Dim permisos As New bllpermisos
        Dim setito As New DataSet

        Dim consulta As String
        consulta = "select uf.id_fam, f.nombre_familia from usuariofamilia uf, Familia f WHERE uf.Id_usuario =" & id_usuario & "and uf.id_fam=f.Id_Familia"
        Dim data As New DAL.daldatos
        setito = data.EjecutarConsulta(consulta)

        Return setito
    End Function
    Shared Function negar_familia(ByVal id_usuario As Integer, ByVal id_familia As Integer) As DataSet

        Dim setito As New DataSet

        Dim consulta As String
        consulta = "delete from usuariofamilia where Id_usuario=" & id_usuario & " and Id_fam=" & id_familia
        Dim data As New DAL.daldatos
        setito = data.EjecutarConsulta(consulta)
        MsgBox("Familia Negada:" & id_familia)
        Return setito
    End Function
    Shared Function alta_familia(ByVal desc As String) As Integer
        Dim setito As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = "insert into Familia (nombre_familia) values ('" & desc & "' )"
        setito = data.EjecutarConsulta(consulta)
        MsgBox("Familia Agregada: " & desc)
        consulta = "select id_Familia from Familia where nombre_familia='" & desc & "'"
        setito = data.EjecutarConsulta(consulta)
        Dim id_familia As Integer
        id_familia = setito.Tables(0).Rows(0).Item(0)
        Return id_familia
    End Function
    Shared Sub alta_familia_usuario(ByVal usuario As Integer, ByVal id_familia As Integer)
        Dim setito As New DataSet
        Dim data As New DAL.daldatos

        Dim consulta As String = "insert into usuariofamilia (Id_usuario, id_fam) values(" & usuario & ", " & id_familia & " )"
        setito = data.EjecutarConsulta(consulta)
        MsgBox("Usuario Agregada a familia: " & usuario)
    End Sub
    Shared Sub alta_familia_patente(ByVal patente As Integer, ByVal id_familia As Integer)
        Dim setito As New DataSet
        Dim data As New DAL.daldatos

        Dim consulta As String = "insert into patentefamilia (id_pat, id_fam) values (" & patente & ", " & id_familia & " )"
        setito = data.EjecutarConsulta(consulta)
        MsgBox("Patente Agregada a familia: " & patente)
    End Sub

    Shared Function familiapatente_nousuarios(ByVal id_fam As Integer) As DataSet
        Dim data As New DAL.daldatos
        Dim seto As New DataSet
        Dim consulta As String = "select nombre_usuario from Usuarios where Id_Usuarios not in (select id_usuario from usuariofamilia where id_fam = " & id_fam & " )"
        seto = data.EjecutarConsulta(consulta)
        Return seto
    End Function
    Shared Function familiapatente_nopatente(ByVal id_fam As Integer) As DataSet
        Dim data As New DAL.daldatos
        Dim seto As New DataSet
        Dim consulta As String = "select id_pat, desc_pat  from Patentes where id_pat not in (select id_pat from patentefamilia where id_fam=" & id_fam & ")"
        seto = data.EjecutarConsulta(consulta)
        Return seto
    End Function
    Shared Function familiapatente_usuarios(ByVal id_fam As Integer) As DataSet
        Dim data As New DAL.daldatos
        Dim seto As New DataSet
        Dim consulta As String = "select nombre_usuario from Usuarios where Id_Usuarios in (select id_usuario from usuariofamilia where id_fam = " & id_fam & " )"
        seto = data.EjecutarConsulta(consulta)
        Return seto
    End Function
    Shared Function familiapatente_patente(ByVal id_fam As Integer) As DataSet
        Dim data As New DAL.daldatos
        Dim seto As New DataSet
        Dim consulta As String = "select id_pat, desc_pat  from Patentes where id_pat in (select id_pat from patentefamilia where id_fam=" & id_fam & ")"
        seto = data.EjecutarConsulta(consulta)
        Return seto
    End Function
    Shared Function id_familia(ByVal familia As String) As Integer
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = "Select Id_Familia from Familia where nombre_familia='" & familia & "'"
        seto = data.EjecutarConsulta(consulta)
        Dim id As Integer = seto.Tables(0).Rows(0).Item(0)
        Return id
    End Function

    Shared Sub familia_nopatenteasignar(ByVal id As Integer, ByVal patente As Integer)
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = " insert into patentefamilia (id_pat, id_fam) values (" & patente & "," & id & ")"
        seto = data.EjecutarConsulta(consulta)
        MsgBox("Patente " & patente & " asignada a familia " & id)

    End Sub
    Shared Sub familia_patentenegar(ByVal id As Integer, ByVal patente As Integer)
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = " delete from patentefamilia where id_pat=" & patente & " and id_fam=" & id
        seto = data.EjecutarConsulta(consulta)
        MsgBox("Patente " & patente & " Negada a familia " & id)

    End Sub
    Shared Sub familia_nousuarioasignar(ByVal id As Integer, ByVal usuario As Integer)
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = " insert into usuariofamilia (id_usuario, id_fam) values (" & usuario & "," & id & ")"
        seto = data.EjecutarConsulta(consulta)


    End Sub
    Shared Sub familia_usuarionegar(ByVal id As Integer, ByVal usuario As Integer)
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = " delete from usuariofamilia where id_usuario=" & usuario & " and id_fam=" & id
        seto = data.EjecutarConsulta(consulta)


    End Sub
End Class
