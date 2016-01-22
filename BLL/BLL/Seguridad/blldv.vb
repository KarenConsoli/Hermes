Public Class blldv
    'metodo para calcular el dv
    Public Function calcular(ByVal tabla As String) As Integer
        Dim boolito As Boolean
        'establecemos conexion y realizamos la consulta, no debuelve el ultimo registro en un data table
        Dim data As New DAL.daldatos


        Dim consulta As String = "select top 1 * from " & tabla & " order by id_" & tabla & " desc"
        Dim seto As New DataSet
        seto = data.EjecutarConsulta(consulta)

        'recorremos la fila para obtener el dv
        Dim campo As Double = 0
        Dim dv As Long = 0
        Dim resto As Integer = 0
        Dim texto As String
        Dim dvactual As Double
        Dim columnita As Integer = seto.Tables(0).Columns.Count
        If IsDBNull(seto.Tables(0).Rows(0).Item("dvh")) Then
            dvactual = 0
        Else
            dvactual = seto.Tables(0).Rows(0).Item("dvh")
        End If

        Dim suma, ancho, valor As Integer
        Dim id As String = seto.Tables(0).Rows(0).Item("id_" & tabla)
        For i As Integer = 0 To columnita - 1 'ciclo para recorrer los campos
            suma = 0

            If DBNull.Value.Equals(seto.Tables(0).Rows(0).Item(i)) Then
                texto = ""
            Else
                texto = seto.Tables(0).Rows(0).Item(i)
            End If

            ancho = Len(texto)
            For a As Integer = 1 To ancho 'ciclo para recorrer cada cada caracter del campo
                valor = Asc(Mid(texto, a, 1))
                valor = valor * (a)
                suma = suma + valor
            Next
            campo = suma * 13
            dv = dv + campo
        Next

        'llamo a la funcion insertar para grabar el dvh

        boolito = insertar_dvh(tabla, dv, id)
        resto = dv - dvactual

        updetear_dvv(tabla, resto)

        Return resto
    End Function

    Public Function insertar_dvh(ByVal tabla As String, ByVal dv As Long, ByVal id As String) As Boolean
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "UPDATE " & tabla & " SET dvh = " & dv & " WHERE id_" & tabla & " = " & id

        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New DAL.daldatos


        'intentemos
        'me siento dora la exploradora
        Try
            'llamamos la funcion ejecutarconsulta dentro de la clase datos
            'siendo el parametro consulta mandado
            'y asi llenamos a seto
            data.EjecutarConsulta(consulta)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return True
    End Function
    Public Function insertar_dvv(ByVal tabla As String, ByVal dv As Long) As Boolean
        'variable que guarda consulta de sql
        'claro selecciona de la tabla lista, donde el campo codigo sea igual al codigo ingresado en el txt

        Dim consulta = "Update DVV set dvv=" & dv & " where tabla='" & tabla & "' "

        'creamos una variable oDatos ligandola a la capa de datos
        Dim data As New DAL.daldatos


        'intentemos
        'me siento dora la exploradora
        Try
            'llamamos la funcion ejecutarconsulta dentro de la clase datos
            'siendo el parametro consulta mandado
            'y asi llenamos a seto
            data.EjecutarConsulta(consulta)
            'MsgBox("Se insertó DVV")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return True
    End Function
    Public Sub Recalcular_dvv(ByVal tabla As String)
        'establecemos conexion y realizamos la consulta, no debuelve el ultimo registro en un data table
        Dim data As New DAL.daldatos
        Dim dvv As Long = 0


        Dim consulta As String = "select * from " & tabla
        Dim seto As New DataSet
        seto = data.EjecutarConsulta(consulta)

        Dim campo As Double = 0
        Dim dv As Integer = 0
        Dim resto As Integer = 0
        Dim texto As String

        For i = 0 To seto.Tables(0).Rows.Count - 1
            Dim columnita As Integer = seto.Tables(0).Columns.Count
            Dim dvactual As Double
            If IsDBNull(seto.Tables(0).Rows(i).Item("dvh")) Then
                dvactual = 0
            Else
                dvactual = seto.Tables(0).Rows(i).Item("dvh")
            End If
            Dim suma, ancho, valor As Integer

            Dim id As String = seto.Tables(0).Rows(i).Item("id_" & tabla)

            For k As Integer = 0 To columnita - 2 'ciclo para recorrer los campos
                suma = 0

                If DBNull.Value.Equals(seto.Tables(0).Rows(i).Item(k)) Or IsDate(seto.Tables(0).Rows(i).Item(k)) Then
                    texto = ""
                Else
                    texto = seto.Tables(0).Rows(i).Item(k)
                End If

                ancho = Len(texto)
                For a As Integer = 1 To ancho 'ciclo para recorrer cada cada caracter del campo
                    valor = Asc(Mid(texto, a, 1))
                    valor = valor * (a)
                    suma += valor
                Next
                campo = suma * 13
                dv += campo


            Next
            'MsgBox(dv)
            dvv = dvv + dv

        Next
        Dim boolito As Boolean

        Try

            boolito = insertar_dvv(tabla, dvv)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       



    End Sub
    Public Sub updetear_dvv(ByVal tabla As String, ByVal resto As Double)
        'creo el objeto de datos
        Dim data As New DAL.daldatos
        Dim seto As New DataSet




        'seleccionar el último DVV
        Dim consulta As String = "select dvv from DVV where tabla='" & tabla & "'"

        'ejecuto
        Try
            seto = data.EjecutarConsulta(consulta)
        Catch ex As Exception

        End Try

        Dim dvv_anterior As Long

        If IsDBNull(seto.Tables(0).Rows(0).Item(0)) Then
            dvv_anterior = 0
        Else
            dvv_anterior = seto.Tables(0).Rows(0).Item(0)
        End If

        Dim dvv_nuevo = dvv_anterior + resto

        'seleccionar el último DVV
        consulta = "update DVV set dvv= " & dvv_nuevo & " where tabla ='" & tabla & "'"

        'ejecuto
        Try
            seto = data.EjecutarConsulta(consulta)
            'MsgBox("Dvv Updeteado")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub
    Public Sub recalcular_dvh(ByVal tabla As String)
        Dim boolito As Boolean
        'establecemos conexion y realizamos la consulta, no debuelve el ultimo registro en un data table
        Dim data As New DAL.daldatos


        Dim consulta As String = "select * from " & tabla
        Dim seto As New DataSet
        seto = data.EjecutarConsulta(consulta)


        Dim campo As Double = 0
        Dim dv As Integer = 0
        Dim resto As Integer = 0
        Dim texto As String

        For i = 0 To seto.Tables(0).Rows.Count - 1
            Dim columnita As Integer = seto.Tables(0).Columns.Count
            Dim dvactual As Double
            If IsDBNull(seto.Tables(0).Rows(i).Item("dvh")) Then
                dvactual = 0
            Else
                dvactual = seto.Tables(0).Rows(i).Item("dvh")
            End If

            Dim suma, ancho, valor As Integer

            Dim id As String = seto.Tables(0).Rows(i).Item("id_" & tabla)

            For k As Integer = 0 To columnita - 2 'ciclo para recorrer los campos
                suma = 0

                If IsDBNull(seto.Tables(0).Rows(i).Item(k)) Or IsDate(seto.Tables(0).Rows(i).Item(k)) Then
                    texto = ""
                Else

                    texto = seto.Tables(0).Rows(i).Item(k)
                End If

                ancho = Len(texto)

                For a As Integer = 1 To ancho 'ciclo para recorrer cada cada caracter del campo
                    valor = Asc(Mid(texto, a, 1))
                    valor = valor * (a)
                    suma += valor
                Next
                campo = suma * 13
                dv += campo


            Next

            Try
                boolito = insertar_dvh(tabla, dv, id)

            Catch ex As Exception
                ' MsgBox(ex.ToString)
            End Try
        Next



        Return
    End Sub

    Public Sub verficar_integridad()
        verficar_dvv("bitacora")
        verficar_dvv("Chofer")
        verficar_dvv("clientepaquete")
        verficar_dvv("Clientes")
        verficar_dvv("Crash")
        verficar_dvv("Factura")
        verficar_dvv("Paquete")
        verficar_dvv("patentefamilia")
        verficar_dvv("punto_llegada")
        verficar_dvv("punto_partida")
        verficar_dvv("Rodado")
        verficar_dvv("Transportes")
        verficar_dvv("usuariofamilia")
        verficar_dvv("usuariopatente")
        verficar_dvv("Usuarios")


        'recalcular_dvh("bitacora")
        'recalcular_dvh("Chofer")
        'recalcular_dvh("clientepaquete")
        'recalcular_dvh("Clientes")
        'recalcular_dvh("Crash")
        'recalcular_dvh("Factura")
        'recalcular_dvh("Paquete")
        'recalcular_dvh("patentefamilia")
        'recalcular_dvh("punto_llegada")
        'recalcular_dvh("punto_partida")
        'recalcular_dvh("Rodado")
        'recalcular_dvh("Transportes")
        'recalcular_dvh("usuariofamilia")
        'recalcular_dvh("usuariopatente")
        'recalcular_dvh("Usuarios")


        'Recalcular_dvv("bitacora")
        'Recalcular_dvv("Chofer")
        'Recalcular_dvv("clientepaquete")
        'Recalcular_dvv("Clientes")
        'Recalcular_dvv("Crash")
        'Recalcular_dvv("Factura")
        'Recalcular_dvv("Paquete")
        'Recalcular_dvv("patentefamilia")
        'Recalcular_dvv("punto_llegada")
        'Recalcular_dvv("punto_partida")
        'Recalcular_dvv("Rodado")
        'Recalcular_dvv("Transportes")
        'Recalcular_dvv("usuariofamilia")
        'Recalcular_dvv("usuariopatente")
        'Recalcular_dvv("Usuarios")

    End Sub
    Public Function verficar_dvv(ByVal tabla As String) As Boolean



        'establecemos conexion y realizamos la consulta, no debuelve el ultimo registro en un data table
        Dim data As New DAL.daldatos
        Dim dvv As Long = 0


        Dim consulta As String = "select * from " & tabla
        Dim seto As New DataSet
        seto = data.EjecutarConsulta(consulta)
       
        Dim campo As Double = 0
        Dim dv As Long = 0
        Dim resto As Integer = 0
        Dim texto As String

        For i = 0 To seto.Tables(0).Rows.Count - 1
            Dim columnita As Integer = seto.Tables(0).Columns.Count
            Dim dvactual As Double
            If IsDBNull(seto.Tables(0).Rows(i).Item("dvh")) Then
                dvactual = 0
            Else
                dvactual = seto.Tables(0).Rows(i).Item("dvh")
            End If
            Dim suma, ancho, valor As Integer

            Dim id As String = seto.Tables(0).Rows(i).Item("id_" & tabla)

            For k As Integer = 0 To columnita - 2 'ciclo para recorrer los campos
                suma = 0

                If DBNull.Value.Equals(seto.Tables(0).Rows(i).Item(k)) Or IsDate(seto.Tables(0).Rows(i).Item(k)) Then
                    texto = ""
                Else
                    texto = seto.Tables(0).Rows(i).Item(k)
                End If

                ancho = Len(texto)
                For a As Integer = 1 To ancho 'ciclo para recorrer cada cada caracter del campo
                    valor = Asc(Mid(texto, a, 1))
                    valor = valor * (a)
                    suma += valor
                Next
                campo = suma * 13
                dv += campo


            Next
            'MsgBox(dv)
            dvv = dvv + dv

        Next
        Dim boolito As Boolean
       
        Try



            consulta = "select dvv from DVV where tabla='" & tabla & "'"
            seto = data.EjecutarConsulta(consulta)

            If seto.Tables(0).Rows(0).Item(0) = dvv Then
                boolito = True
            Else
                boolito = False
                MsgBox("Error de Integridad en la Tabla: " & tabla)
                recalcular_dvh(tabla)
                MsgBox("Dígitos Verificadores Horizontales Recalculados")
                Recalcular_dvv(tabla)
                MsgBox("Dígitos Verificadores Verticales Recalculados")
            End If
        Catch ex As Exception
            MsgBox("Base de datos no cargada")
        End Try

        Return boolito

    End Function
    Public Sub salir()
        'recalcular_dvh("bitacora")
        'recalcular_dvh("Chofer")
        'recalcular_dvh("clientepaquete")
        'recalcular_dvh("Clientes")
        'recalcular_dvh("Crash")
        'recalcular_dvh("Factura")
        'recalcular_dvh("Paquete")
        'recalcular_dvh("patentefamilia")
        'recalcular_dvh("punto_llegada")
        'recalcular_dvh("punto_partida")
        'recalcular_dvh("Rodado")
        'recalcular_dvh("Transportes")
        'recalcular_dvh("usuariofamilia")
        'recalcular_dvh("usuariopatente")
        'recalcular_dvh("Usuarios")


        'Recalcular_dvv("bitacora")
        'Recalcular_dvv("Chofer")
        'Recalcular_dvv("clientepaquete")
        'Recalcular_dvv("Clientes")
        'Recalcular_dvv("Crash")
        'Recalcular_dvv("Factura")
        'Recalcular_dvv("Paquete")
        'Recalcular_dvv("patentefamilia")
        'Recalcular_dvv("punto_llegada")
        'Recalcular_dvv("punto_partida")
        'Recalcular_dvv("Rodado")
        'Recalcular_dvv("Transportes")
        'Recalcular_dvv("usuariofamilia")
        'Recalcular_dvv("usuariopatente")
        'Recalcular_dvv("Usuarios")
    End Sub
End Class
