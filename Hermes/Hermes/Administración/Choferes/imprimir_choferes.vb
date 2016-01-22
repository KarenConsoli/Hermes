Public Class imprimir_choferes
    Dim encrypta As New BLL.bllencriptar

    Private Sub imprimir_choferes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Campo.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.Campo.Chofer)

        Dim i As Integer
        For Each row As DataRow In Me.Campo.Chofer.Rows
            Me.Campo.Chofer.Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            Me.Campo.Chofer.Rows(i).Item(5) = BLL.blldomicilio.nombre_pais(row.ItemArray(5))
            Me.Campo.Chofer.Rows(i).Item(6) = BLL.blldomicilio.nombre_provincia_string(Me.Campo.Chofer.Rows(i).Item(5), row.ItemArray(6))
            i = i + 1
        Next
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class