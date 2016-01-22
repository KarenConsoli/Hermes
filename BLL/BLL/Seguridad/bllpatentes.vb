Public Class bllpatentes
    Inherits bllpermisos

    'Metodo que retorna un listado de las patentes
    Public Function Listar() As DataSet
        'Return MyBase.listar()
        Dim seto As New DataSet
        Dim data As New DAL.daldatos

        'creo la consulta 
        Dim consulta As String
        consulta = "select id_pat, desc_pat from Patentes"

      
        seto = data.EjecutarConsulta(consulta)
        Return seto
    End Function


    'Metodo que completa la tabla patentes usuario de permisos
    Public Sub permisos()
        'creo la consulta 
        Dim consulta As String
        consulta = "select Id_pat, negado, asignado from usuariopatente up, Usuarios u where up.id_usuario = u.Id_Usuarios and u.nombre_usuario= '" & _usuario & "'"

        'Instancio la capa de datos
        Dim data As New DAL.daldatos

        _seto = data.EjecutarConsulta(consulta)

    End Sub


    'COMIENZAN LOS AHRED FUNCTION PARA LLENAR DATAGRID'S

    'Consulta cuales son las patentes negadas del usuario mandado
    Shared Function patentes_negadas(ByVal id_usuario As Integer) As DataSet
        'creo la consulta 
        Dim consulta As String
        Dim permisos As New bllpermisos
        Dim setito As New DataSet

        consulta = "SELECT id_pat, desc_pat FROM Patentes WHERE id_pat IN (SELECT Id_pat FROM usuariopatente WHERE id_usuario= " & id_usuario & " AND negado = 1)"

        'Instancio la capa de datos
        Dim data As New DAL.daldatos

        setito = data.EjecutarConsulta(consulta)
        Return setito

    End Function


    'Consulta cuales son las patentes que están que el usuario puede asignar porque no estan negadas, no necesariamente activadas
    Shared Function patentes_activadas(ByVal id_usuario As Integer) As DataSet
        'creo la consulta 
        Dim consulta As String
        Dim permisos As New bllpermisos
        Dim setito As New DataSet

        consulta = "SELECT p.id_pat, p.desc_pat FROM Patentes p WHERE p.id_pat IN (SELECT up.Id_pat FROM usuariopatente up WHERE up.id_usuario= " & id_usuario & " AND up.negado = 0 and up.asignado = 1)"

        'Instancio la capa de datos
        Dim data As New DAL.daldatos

        setito = data.EjecutarConsulta(consulta)
        Return setito

    End Function

    'Consulta para asginar patente a usuario
    Shared Sub asignar_patente_usuario(ByVal id_pat As Integer, ByVal id_usuario As Integer)
        Dim consulta As String
        Dim seto As New DataSet

        Dim data As New DAL.daldatos
        Try
           
            consulta = "select * from usuariopatente where id_usuario= " & id_usuario & " and id_pat=" & id_pat
            seto = data.EjecutarConsulta(consulta)
            If Not IsDBNull(seto.Tables(0).Rows(0).Item(0)) Then
                consulta = "update usuariopatente set negado = 0, asignado = 1 where id_usuario=" & id_usuario & " and Id_pat= " & id_pat
            End If



            MsgBox("Patente Asignada: " & id_pat)

        Catch ex As Exception
            consulta = "insert into usuariopatente (id_usuario, id_pat, negado, asignado) values (" & id_usuario & ", " & id_pat & " , 0, 1)"

        End Try
        Try
            seto = data.EjecutarConsulta(consulta)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
    Shared Sub desasignar_patente_usuario(ByVal id_pat As Integer, ByVal id_usuario As Integer)
        Try
            Dim seto As New DataSet
            Dim consulta As String
            Dim data As New DAL.daldatos
            consulta = "select id_pat from usuariopatente where id_usuario= " & id_usuario & " and id_pat=" & id_pat
            seto = data.EjecutarConsulta(consulta)
            If seto.Tables(0).Rows(0).Item(0) = Nothing Then
                consulta = "insert into usuariopatente (id_usuario, id_pat, negado, asignado) values (" & id_usuario & ", " & id_pat & " , 0, 0)"

            Else
                consulta = "update usuariopatente set negado = 0, asignado= 0 where id_usuario=" & id_usuario & " and Id_pat= " & id_pat

            End If

            MsgBox("Patente Des-Asignada: " & id_pat)
            seto = data.EjecutarConsulta(consulta)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    'consulta para asignar de vuelta una patente que fue negada
    Shared Sub asignar_patente_neg_usuario(ByVal id_pat As Integer, ByVal id_usuario As Integer)
        Try
            Dim seto As New DataSet
            Dim consulta As String
            Dim data As New DAL.daldatos
            consulta = "select id_pat from usuariopatente where id_usuario= " & id_usuario & " and  id_pat=" & id_pat
            seto = data.EjecutarConsulta(consulta)
            If seto.Tables(0).Rows(0).Item(0) = Nothing Then
                consulta = "insert into usuariopatente (id_usuario, id_pat, negado) values (" & id_usuario & ", " & id_pat & " , 0)"

            Else
                consulta = "update usuariopatente set negado = 0 where id_usuario=" & id_usuario & " and Id_pat= " & id_pat

            End If
            MsgBox("Patente Negada Asignada: " & id_pat)
            seto = data.EjecutarConsulta(consulta)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
    'consulta para desnegar de vuelta una patente que fue negada
    Shared Sub desnegar_patente(ByVal id_pat As Integer, ByVal id_usuario As Integer)
        Try
            Dim seto As New DataSet
            Dim consulta As String
            Dim data As New DAL.daldatos
            consulta = "select id_pat from usuariopatente where id_usuario= " & id_usuario & " and  id_pat=" & id_pat
            seto = data.EjecutarConsulta(consulta)
            If seto.Tables(0).Rows(0).Item(0) = Nothing Then
                consulta = "insert into usuariopatente (id_usuario, id_pat, negado, asignado) values (" & id_usuario & ", " & id_pat & " , 0, 0)"

            Else
                consulta = "update usuariopatente set negado = 0, asignado =0 where id_usuario=" & id_usuario & " and Id_pat= " & id_pat

            End If
            MsgBox("Patente Des-Negada: " & id_pat)
            seto = data.EjecutarConsulta(consulta)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    'Consulta para Negar Patente
    Shared Sub neg_patente_usuario(ByVal id_pat As Integer, ByVal id_usuario As Integer)
        Try
            Dim seto As New DataSet
            Dim consulta As String
            Dim data As New DAL.daldatos
            consulta = "select id_pat from usuariopatente where id_pat=" & id_pat & " and id_usuario=" & id_usuario
            seto = data.EjecutarConsulta(consulta)
         
            If seto.Tables(0).Rows.Count = 0 Then
                consulta = "insert into usuariopatente (id_usuario, id_pat, negado, asignado) values (" & id_usuario & ", " & id_pat & " , 1, 0)"


            Else

                consulta = "update usuariopatente set  negado = 1, asignado= 0 where id_usuario=" & id_usuario & " and Id_pat= " & id_pat

            End If
            MsgBox("Patente Negada : " & id_pat)
            seto = data.EjecutarConsulta(consulta)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Shared Function patentes_asignadas(ByVal id_usuario As Integer, ByVal id_familia As List(Of String)) As DataSet

        Dim setito As New DataSet
        Dim consulta As String
        Try
            If id_familia.Count > 0 Then
                consulta = "SELECT id_pat, desc_pat FROM Patentes p  WHERE id_pat in(SELECT up.Id_pat from usuariopatente up WHERE up.id_usuario=" & id_usuario & " and up.negado = 0 ) or id_pat not in (SELECT up.Id_pat from usuariopatente up WHERE up.id_usuario=" & id_usuario & " and up.negado = 1) and id_pat in ("
                For k As Integer = 0 To id_familia.Count - 1
                    If k = 0 Then
                        consulta += String.Concat("SELECT  pf.Id_pat from patentefamilia pf, usuariopatente up WHERE pf.id_fam = " & id_familia(k))
                    Else
                        consulta += String.Concat(" union SELECT  pf.Id_pat from patentefamilia pf, usuariopatente up WHERE pf.id_fam =" & id_familia(k))
                    End If

                Next

                consulta += String.Concat(" )")

            Else
                consulta = "SELECT id_pat, desc_pat FROM Patentes p  WHERE id_pat in(SELECT up.Id_pat from usuariopatente up WHERE up.id_usuario=" & id_usuario & " and up.negado = 0 ) or id_pat not in (SELECT up.Id_pat from usuariopatente up WHERE up.id_usuario=" & id_usuario & "and up.negado = 1)"
            End If


            Dim data As New DAL.daldatos
            setito = data.EjecutarConsulta(consulta)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return setito
    End Function
    Shared Function usuarios_patentes_esenciales() As DataSet
        'creo la consulta 
        Dim consulta As String
        Dim permisos As New bllpermisos
        Dim setito As New DataSet

        consulta = "select id_Usuarios from Usuarios where baja = 0 and id_Usuarios in (Select id_usuario from usuariopatente where id_pat=610 or id_pat=620 and negado= 0 and asignado=1)or id_Usuarios in (select id_usuario from usuariofamilia where id_fam in ( select id_fam from patentefamilia where id_pat=610 or id_pat = 620)) "

        'Instancio la capa de datos
        Dim data As New DAL.daldatos

        setito = data.EjecutarConsulta(consulta)
        Return setito

    End Function
End Class
