Public Class bllenvios
    Shared Function id_cliente(ByVal cliente As String) As Integer
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT Id_Clientes FROM Clientes where nombre_cliente='" & cliente & "'"
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New DAL.daldatos
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
    Shared Function nombre_cliente(ByVal id As Integer) As String
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT nombre_cliente FROM Clientes where Id_Clientes=" & id
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

            consulta = seto.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
        End Try
        Return consulta
    End Function
    Shared Function id_paquete(ByVal nombre As String) As Integer
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT Id_Paquete FROM Paquete where nombre_paquete='" & nombre & "'"
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New DAL.daldatos
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
    Shared Function nombre_paquete(ByVal id As Integer) As String
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT nombre_paquete FROM Paquete where id_cliente=" & id
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

            consulta = seto.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
        End Try
        Return consulta
    End Function
    Shared Function id_pp(ByVal nombre As String) As Integer
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT id_punto_partida FROM punto_partida where nombre_pp='" & nombre & "'"
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New DAL.daldatos
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
    Shared Function nombre_pp(ByVal id As Integer) As String
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT nombre_pp FROM punto_partida where id_punto_partida=" & id
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

            consulta = seto.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
        End Try
        Return consulta
    End Function

    Shared Function id_pl(ByVal nombre As String) As Integer
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT id_punto_llegada FROM punto_llegada where nombre_pl='" & nombre & "'"
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New DAL.daldatos
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
    Shared Function nombre_pl(ByVal id As Integer) As String
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT nombre_pl FROM punto_llegada where id_punto_llegada=" & id
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

            consulta = seto.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
        End Try
        Return consulta
    End Function
    Shared Function id_transporte(ByVal remito As Integer) As Integer
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT id_transportes FROM Transportes where remito=" & remito
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New DAL.daldatos
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
    Shared Sub buscar_lugarpartida(ByVal nombre As String)
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT  * FROM punto_partida where nombre_pp='" & nombre & "'"
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

            If IsDBNull(seto.Tables(0).Rows(0).Item(0)) Then
                MsgBox("Lugar No encontrado. Ingrese Nuevo Lugar")
            Else
                MsgBox("Lugar Encontrado")
            End If
        Catch ex As Exception
            MsgBox("Lugar No encontrado. Ingrese Nuevo Lugar")
        End Try

    End Sub
    Shared Sub buscar_lugarllegada(ByVal nombre As String)
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT * FROM punto_llegada where nombre_pl='" & nombre & "'"
        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New DAL.daldatos
        Dim seto As New DataSet
        Dim id As Integer
        'intentemos
        'me siento dora la exploradora
        Try
            'llamamos la funcion ejecutarconsulta dentro de la clase datos
            'siendo el parametro consulta mandado
            'y asi llenamos a seto
            seto = data.EjecutarConsulta(consulta)
            If IsDBNull(seto.Tables(0).Rows(0).Item(0)) Then
                MsgBox("Lugar No encontrado. Ingrese Nuevo Lugar")
            Else
                MsgBox("Lugar Encontrado")
            End If


        Catch ex As Exception

        End Try

    End Sub
    Shared Sub baja_transporte_paquete(ByVal id As Integer)
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "delete from transporte_paquete where id_transporte=" & id
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

    End Sub
    Shared Function ver_paquetes(ByVal id As Integer) As DataSet
        Dim data As New DAL.daldatos
        Dim seto As New DataSet
        Dim consulta As String = "select id_paquete, nombre_paquete, precio from Paquete where id_paquete in (select id_paquete from transporte_paquete where id_transporte= " & id & ")"
        seto = data.EjecutarConsulta(consulta)
        Return seto

    End Function
End Class
