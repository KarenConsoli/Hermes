Public Class imprimir_clientes
    Dim encrypta As New BLL.bllencriptar

    Private Sub imprimir_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Campo.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Campo.Clientes)
        Dim i As Integer
        For Each row As DataRow In Me.Campo.Clientes.Rows
            Me.Campo.Clientes.Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            Me.Campo.Clientes.Rows(i).Item(4) = BLL.blldomicilio.nombre_pais(row.ItemArray(4))
            Me.Campo.Clientes.Rows(i).Item(5) = BLL.blldomicilio.nombre_provincia_string(Me.Campo.Clientes.Rows(i).Item(4), row.ItemArray(5))
            i = i + 1
        Next
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class