Public Class blldomicilio
    Shared Function provincia(ByVal pais As String) As DataSet
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select pro.Nombre_provincia from Pais p , Provincia pro where  p.Id_pais=pro.Id_pais and p.Nombre='" & pais & "'"
            seto = data.EjecutarConsulta(consulta)
            MsgBox("Pais Buscado")
            Return seto
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Shared Function nombre_provincia(ByVal pais As String, ByVal id_provincia As Integer) As DataSet
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select pro.Nombre_provincia from Pais p , Provincia pro where  p.Id_pais=pro.Id_pais  and pro.Id_povincia= " & id_provincia & "and p.Nombre='" & pais & "'"
            seto = data.EjecutarConsulta(consulta)
            MsgBox("Pais Buscado")
            Return seto
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Shared Function nombre_provincia_string(ByVal pais As String, ByVal id_provincia As Integer) As String
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select pro.Nombre_provincia from Pais p , Provincia pro where  p.Id_pais=pro.Id_pais  and pro.Id_povincia= " & id_provincia & "and p.Nombre='" & pais & "'"
            seto = data.EjecutarConsulta(consulta)
            consulta = seto.Tables(0).Rows(0).Item(0)
            Return consulta
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Shared Function pais(ByVal id As String) As DataSet
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select Nombre from Pais where Id_pais='" & id & "'"
            seto = data.EjecutarConsulta(consulta)
            Return seto
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Shared Function nombre_pais(ByVal id As String) As String
        Try

            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select Nombre from Pais where Id_pais='" & id & "'"
            seto = data.EjecutarConsulta(consulta)
            consulta = seto.Tables(0).Rows(0).Item(0)
            Return consulta
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
  
    Shared Function localildad(ByVal cp As Integer, ByVal id As Integer) As DataSet
        Try
            Dim seto As New DataSet
            Dim data As New DAL.daldatos
            Dim consulta As String = "select localidad from CP where cp=" & cp & " and provincia=" & id
            seto = data.EjecutarConsulta(consulta)
            MsgBox("Código Postal Buscado")
            Return seto
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Shared Function id_pais(ByVal pais As String) As Integer
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = "Select Id_pais from Pais where Nombre= '" & pais & "'"
        seto = data.EjecutarConsulta(consulta)
        Dim id As Integer = seto.Tables(0).Rows(0).Item(0)
        Return id
    End Function

    Shared Function id_provincia(ByVal provincia As String) As Integer
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = "Select Id_povincia from Provincia where Nombre_provincia='" & provincia & "'"
        seto = data.EjecutarConsulta(consulta)
        Dim id As Integer = seto.Tables(0).Rows(0).Item(0)
        Return id
    End Function
    Shared Function paises() As DataSet
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = "select Nombre from Pais "
        seto = data.EjecutarConsulta(consulta)
        Return seto

    End Function
End Class
