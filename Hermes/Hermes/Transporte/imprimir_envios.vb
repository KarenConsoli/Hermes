Public Class imprimir_envios

    Private Sub imprimir_envios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Campo.Transportes' Puede moverla o quitarla según sea necesario.
        Me.TransportesTableAdapter.Fill(Me.Campo.Transportes)
        Dim i As Integer
        For Each row As DataRow In Me.Campo.Transportes.Rows
            Me.Campo.Transportes.Rows(i).Item(1) = BLL.bllenvios.nombre_cliente(row.ItemArray(1))
            Me.Campo.Transportes.Rows(i).Item(4) = BLL.bllenvios.nombre_pp(row.ItemArray(4))
            Me.Campo.Transportes.Rows(i).Item(5) = BLL.bllenvios.nombre_pl(row.ItemArray(5))
            i = i + 1
        Next
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class