Imports DAL

Public Class blldetidioma
    Public Shared Function DetectarIdioma(ByVal usuario As String) As Integer
        Dim datos As New DAL.daldatos
        Dim seto As New DataSet

        Dim ConsultaIdiomaUsu As String = "SELECT id_idioma FROM Usuarios WHERE nombre_usuario= '" & usuario & "'"

        seto = datos.EjecutarConsulta(ConsultaIdiomaUsu)

        Dim CodIdioma As Integer = seto.Tables(0).Rows(0).Item(0)


        Return CodIdioma

    End Function
    Shared Function idioma() As DataSet
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = "select nombre from Idioma "
        seto = data.EjecutarConsulta(consulta)

        Return seto

    End Function
    Shared Function nombre_idioma(ByVal idioma As Integer) As String
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = "select nombre from Idioma where id_idioma=" & idioma
        seto = data.EjecutarConsulta(consulta)
        Dim nombre As String
        nombre = seto.Tables(0).Rows(0).Item(0)
        Return nombre
    End Function

    Shared Function id_idioma(ByVal idioma As String) As String
        Dim seto As New DataSet
        Dim data As New DAL.daldatos
        Dim consulta As String = "select id_idioma from Idioma where nombre='" & idioma & "'"
        seto = data.EjecutarConsulta(consulta)
        Dim idio As String
        idio = seto.Tables(0).Rows(0).Item(0)
        Return idio

    End Function
End Class
