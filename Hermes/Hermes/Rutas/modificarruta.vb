Public Class modificarruta

    Private Sub AgregarTelBtn_Click(sender As Object, e As EventArgs)
        modifpartida.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        modifllegada.Show()
        Me.Hide()

    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs)
        rutas.Show()
        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs)
        rutas.Show()

        Me.Hide()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub modificarruta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub AceptarBtn_Click_1(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        rutas.Show()
        Me.Hide()
    End Sub

    Private Sub CancelarBtn_Click_1(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        rutas.Show()
        Me.Hide()
    End Sub
End Class