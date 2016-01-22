Public Class imprimir_rodados
    Dim encrypta As New BLL.bllencriptar

    Private Sub imprimir_rodados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Campo.Rodado' Puede moverla o quitarla según sea necesario.
        Me.RodadoTableAdapter.Fill(Me.Campo.Rodado)

        Dim i As Integer
        For Each row As DataRow In Me.Campo.Rodado.Rows
            Me.Campo.Rodado.Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            Me.Campo.Rodado.Rows(i).Item(4) = BLL.bllrodado.nombre_marca_rodado(row.ItemArray(4))
            Me.Campo.Rodado.Rows(i).Item(8) = BLL.bllrodado.nombre_tipo_rodado(row.ItemArray(8))

            i = i + 1
        Next
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class