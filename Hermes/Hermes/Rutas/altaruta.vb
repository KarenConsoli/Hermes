Public Class altaruta

    Private Sub AgregarTelBtn_Click(sender As Object, e As EventArgs) Handles AgregarTelBtn.Click
        altapartida.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        altallegada.Show()
        Me.Hide()

    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        rutas.Show()
        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        rutas.Show()
        Me.Hide()

    End Sub
End Class