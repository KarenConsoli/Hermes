Public Class imprimir_crashs
    Dim encrypta As New BLL.bllencriptar
    Private Sub imprimir_crashs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Campo.Crash' Puede moverla o quitarla según sea necesario.
        Me.CrashTableAdapter.Fill(Me.Campo.Crash)
        Dim i As Integer
        For Each row As DataRow In Me.Campo.Crash.Rows
            Me.Campo.Crash.Rows(i).Item(3) = encrypta.desencriptar(row.ItemArray(3))
            Me.Campo.Crash.Rows(i).Item(4) = BLL.bllcrash.nombre_lugar(row.ItemArray(4))
            Me.Campo.Crash.Rows(i).Item(5) = BLL.bllcrash.nombre_tipo_choque(row.ItemArray(5))
            i = i + 1
        Next
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class