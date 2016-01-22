Public Class imprimir_factura

    Private Sub imprimir_factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Campo.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.Campo.Factura)
        'TODO: esta línea de código carga datos en la tabla 'Campo.transporte_paquete' Puede moverla o quitarla según sea necesario.
        Me.transporte_paqueteTableAdapter.Fill(Me.Campo.transporte_paquete)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class