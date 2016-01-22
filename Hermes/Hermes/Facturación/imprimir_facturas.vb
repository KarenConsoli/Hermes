Public Class imprimir_facturas

    Private Sub imprimir_facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Campo.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.Campo.Factura)
        Dim i As Integer
        For Each row As DataRow In Me.Campo.Factura.Rows
            Me.Campo.Factura.Rows(i).Item(3) = BLL.bllenvios.nombre_cliente(row.ItemArray(3))
            Me.Campo.Factura.Rows(i).Item(6) = BLL.bllenvios.nombre_pp(row.ItemArray(6))
            Me.Campo.Factura.Rows(i).Item(7) = BLL.bllenvios.nombre_pl(row.ItemArray(7))
            i = i + 1
        Next
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class