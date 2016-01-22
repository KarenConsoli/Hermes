Public Class bllrodado
    Shared Function combo_marca_rodado() As DataSet
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select Desc_marca_rodado from rodado_marca"
            seto = data.EjecutarConsulta(consulta)
            Return seto
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Shared Function combo_tipo_rodado() As DataSet
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select Desc_tipo_rodado from rodado_tipo"
            seto = data.EjecutarConsulta(consulta)
            Return seto
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Shared Function id_marca_rodado(ByVal desc As String) As Integer
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select Id_marca_rodado from rodado_marca where Desc_marca_rodado='" & desc & "'"
            seto = data.EjecutarConsulta(consulta)
            Dim id As Integer = seto.Tables(0).Rows(0).Item(0)
            Return id
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Shared Function id_tipo_rodado(ByVal desc As String) As Integer
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select Id_tipo_rodado from rodado_tipo where Desc_tipo_rodado='" & desc & "'"
            seto = data.EjecutarConsulta(consulta)
            Dim id As Integer = seto.Tables(0).Rows(0).Item(0)
            Return id
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Shared Function nombre_marca_rodado(ByVal id As Integer) As String
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select Desc_marca_rodado from rodado_marca where Id_marca_rodado=" & id
            seto = data.EjecutarConsulta(consulta)
            consulta = seto.Tables(0).Rows(0).Item(0)
            Return consulta
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Shared Function nombre_tipo_rodado(ByVal id As Integer) As String
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select Desc_tipo_rodado  from rodado_tipo where Id_tipo_rodado=" & id
            seto = data.EjecutarConsulta(consulta)
            consulta = seto.Tables(0).Rows(0).Item(0)
            Return consulta
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
End Class
