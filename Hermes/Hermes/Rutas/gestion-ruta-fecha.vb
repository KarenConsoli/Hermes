Public Class gestionruta_fecha

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ruta_fecha.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
   Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            MsgBox("El dato ha sido eliminado")
        Else
            MsgBox("El dato no ha sido Borrado")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
   
    End Sub
End Class