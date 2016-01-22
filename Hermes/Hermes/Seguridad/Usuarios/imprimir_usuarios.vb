Public Class imprimir_usuarios
    Dim encrypta As New BLL.bllencriptar

    Private Sub imprimir_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Campo.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.Campo.Usuarios)
        Dim i As Integer

        For Each row As DataRow In Me.Campo.Usuarios.Rows
            Me.Campo.Usuarios.Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            Me.Campo.Usuarios.Rows(i).Item(7) = BLL.blldomicilio.nombre_pais(row.ItemArray(7))
            Me.Campo.Usuarios.Rows(i).Item(8) = BLL.blldomicilio.nombre_provincia_string(Me.Campo.Usuarios.Rows(i).Item(7), row.ItemArray(8))
            Me.Campo.Usuarios.Rows(i).Item(9) = BLL.blldetidioma.nombre_idioma(row.ItemArray(9))
            i = i + 1
        Next
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class