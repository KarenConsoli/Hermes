Imports DAL

Public Class clsbuscar
    Shared Function actualizargrilla(ByRef seto As DataSet, ByVal tabla As String) As DataSet
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT * FROM " & tabla
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New daldatos

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

    Shared Function buscar_usuario(ByVal usuario As String) As DataSet
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT nombre_usuario, Id_Usuarios FROM Usuarios where nombre_usuario='" & usuario & "'"
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New daldatos
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
    Shared Function buscar_campos(ByVal tabla As String) As DataSet
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT * FROM " & tabla
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New daldatos
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
    Shared Function buscar_por_campos(ByVal tabla As String, ByVal campo As String, ByVal texto As String) As DataSet
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT * FROM " & tabla & " where " & campo & " ='" & texto & "'"
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New daldatos
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
    'Shared Function insertar_usuario(ByVal usuario As String, ByVal pass As String, ByVal mail As String, ByVal nombre As String, ByVal apellido As String, ByVal fecha As Date, ByVal pais As Integer, ByVal provincia As Integer, ByVal idioma As Integer, ByVal cp As Integer, ByVal direccion As String, ByVal activo As Integer, ByVal bloq As Integer, ByVal cant As Integer) As DataSet
    Shared Sub actualizar_datos(ByVal seto As DataSet, ByVal tabla As String)

        Try

            Dim data As New DAL.daldatos
            'Dim consulta As String = "insert into Usuarios(nombre_usuario, contraseña_usuario, mail, nombre_usu, apellido_usu, fecha_ingreso, id_pais, id_provincia, id_idioma, cp_usuario, dirección_usuario, activo, bloq, cant_inicios) values ('" & usuario & "', '" & pass & "', '" & mail & "','" & nombre & "', '" & apellido & "', '" & fecha & "', " & pais & ", " & provincia & "," & idioma & "," & cp & ",'" & direccion & "'," & activo & "," & bloq & ", " & cant & ")"
            Dim consulta As String = "select * from " & tabla
            'seto = data.EjecutarConsulta(consulta)
            Dim dv As New BLL.blldv
            dv.recalcular_dvh(tabla)
            dv.Recalcular_dvv(tabla)
            data.builder(consulta, seto)
            MsgBox("Dato Actualizado")

        Catch ex As Exception

        End Try


    End Sub
    Shared Function buscar_tabla_usuario(ByVal id As Integer) As DataSet
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt
        Dim seto As New DataSet
        Dim consulta = "SELECT * FROM Usuarios where Id_Usuarios=" & id
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New daldatos

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
    Shared Sub dar_baja(ByVal id As Integer, ByVal tabla As String)
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt
        Dim seto As New DataSet
        Dim consulta As String
        Dim data As New DAL.daldatos

        If tabla = "Usuarios" Then
            seto = BLL.bllpatentes.usuarios_patentes_esenciales
            MsgBox(seto.Tables(0).Rows.Count)

            For i As Integer = 0 To seto.Tables(0).Rows.Count
                If seto.Tables(0).Rows(i).Item(0) = id And seto.Tables(0).Rows.Count = 1 Then
                    MsgBox("No se puede eliminar. Último Usuario con Patentes Esenciales")
                    Exit Sub
                Else
                    consulta = "Update " & tabla & " set baja= 1 where id_" & tabla & "=" & id
                    seto = data.EjecutarConsulta(consulta)
                    Exit Sub
                End If
            Next
        


        End If

        'creamos una variable oDatos ligandola a la capa de datos
        consulta = "Update " & tabla & " set baja= 1 where id_" & tabla & "=" & id

        'intentemos
        'me siento dora la exploradora
        Try
            'llamamos la funcion ejecutarconsulta dentro de la clase datos
            'siendo el parametro consulta mandado
            'y asi llenamos a seto
            seto = data.EjecutarConsulta(consulta)
        Catch ex As Exception
        End Try

    End Sub
    Shared Sub eliminar_telefonos_usuarios(ByVal id As Integer)
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt
        Dim seto As New DataSet
        Dim consulta = "delete from Tel_Usuarios where id_usuario = " & id
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New daldatos

        'intentemos
        'me siento dora la exploradora
        Try
            'llamamos la funcion ejecutarconsulta dentro de la clase datos
            'siendo el parametro consulta mandado
            'y asi llenamos a seto
            seto = data.EjecutarConsulta(consulta)
        Catch ex As Exception
        End Try

    End Sub
    Shared Function buscar_cliente(ByVal cliente As String) As Integer
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT Id_Clientes FROM Clientes where nombre_cliente='" & cliente & "'"
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New daldatos
        Dim seto As New DataSet
        Dim id As Integer
        'intentemos
        'me siento dora la exploradora
        Try
            'llamamos la funcion ejecutarconsulta dentro de la clase datos
            'siendo el parametro consulta mandado
            'y asi llenamos a seto
            seto = data.EjecutarConsulta(consulta)

            id = seto.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
        End Try
        Return id
    End Function

    Shared Function buscar_chofer(ByVal chofer As String) As Integer
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT Id_Chofer FROM Chofer where nombre_chofer='" & chofer & "'"
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New daldatos
        Dim seto As New DataSet
        Dim id As Integer
        'intentemos
        'me siento dora la exploradora
        Try
            'llamamos la funcion ejecutarconsulta dentro de la clase datos
            'siendo el parametro consulta mandado
            'y asi llenamos a seto
            seto = data.EjecutarConsulta(consulta)

            id = seto.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
        End Try
        Return id
    End Function
    
    Shared Function buscar_tabla_por_id(ByVal tabla As String, ByVal id As Integer) As DataSet
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT * FROM " & tabla & " where id_" & tabla & "=" & id & ""
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New daldatos
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
    Shared Function ultimo_registro(ByVal tabla As String) As DataSet
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "select top 1 * from " & tabla & " order by id_" & tabla & " desc"
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New daldatos
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
