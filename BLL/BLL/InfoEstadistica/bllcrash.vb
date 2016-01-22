Public Class bllcrash
    Shared Function combo_tipo_crash() As DataSet
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select desc_tipochoque from crash_tipochoque"
            seto = data.EjecutarConsulta(consulta)
            Return seto
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Shared Function id_tipo_choque(ByVal desc As String) As Integer
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select id_tipochoque from crash_tipochoque where desc_tipochoque='" & desc & "'"
            seto = data.EjecutarConsulta(consulta)
            Dim id As Integer = seto.Tables(0).Rows(0).Item(0)
            Return id
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Shared Function nombre_tipo_choque(ByVal id As Integer) As String
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select desc_tipochoque from crash_tipochoque where id_tipochoque= " & id
            seto = data.EjecutarConsulta(consulta)
            consulta = seto.Tables(0).Rows(0).Item(0)
            Return consulta
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Shared Sub buscar_lugarllegada(ByVal nombre As String)
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT * FROM crash_lugarchoque where nombre='" & nombre & "'"
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
    Shared Function id_lugar(ByVal nombre As String) As Integer
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT id_crash_lugarchoque FROM crash_lugarchoque where nombre='" & nombre & "'"
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
    Shared Function nombre_lugar(ByVal id As Integer) As String
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "SELECT nombre FROM crash_lugarchoque where id_crash_lugarchoque=" & id
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
End Class
