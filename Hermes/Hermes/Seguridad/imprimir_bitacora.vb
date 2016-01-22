Public Class imprimir_bitacora
    Dim encrypta As New BLL.bllencriptar

    Private Sub imprimir_bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Campo.bitacora' Puede moverla o quitarla según sea necesario.
        Me.bitacoraTableAdapter.Fill(Me.Campo.bitacora)
        Dim i As Integer = 0

        For Each row As DataRow In Me.Campo.bitacora.Rows

            Me.Campo.bitacora.Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            Me.Campo.bitacora.Rows(i).Item(2) = encrypta.desencriptar(row.ItemArray(2))
            i = i + 1
        Next
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class