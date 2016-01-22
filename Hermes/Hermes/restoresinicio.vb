Public Class restoresinicio
    Dim partes As Integer
    Dim destino As New List(Of String)
    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click

        Dim boolito As Boolean
        Dim dv As New BLL.blldv

     
        If partes < destino.Count - 1 Then
            MsgBox("Seleccione todas las partes del Backup")
            Exit Sub

        End If
        Try
            boolito = BLL.bllrestore.ejecutar_restore(destino)
            MsgBox("Restore Exitoso")
            login.Show()
            Me.Hide()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub restoresinicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        partes = InputBox("Indique Cantidad de Partes de Restore")
    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        OpenFileDialog1.Title = "Seleccionar Backup"
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.ShowDialog()

        For Each filename As String In OpenFileDialog1.FileNames
            destino.Add(filename)
        Next
    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        End

    End Sub
End Class