Imports BLL

Public Class login
    Private _usuario As String
    Dim usuarito As New BLL.blllogin
    Dim cifrar As New BLL.bllencriptar
    Dim encrypta As New BLL.bllencriptar
    Dim bita As New BLL.bllbitacora
    Dim dvh As New BLL.blldv


    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property


    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click

        'ciframos el nombre del usuario
        Dim cifrado As String
        cifrado = encrypta.encriptar(txtusuario.Text)
        Me.usuario = cifrado.ToString

        'paso el nombre al objeto 
        usuarito.usuario = cifrado
       
        'usuarito.usuario = txtusuario.Text
        txt1.Text = cifrado.ToString
        Dim dv As New BLL.blldv

        'respuesta ante la existencia o no del usuario
        If usuarito.Iniciar = True Then
            bita.usuario = cifrado
            bita.criticidad = "bajo"
            bita.desc_mov = "Usuario Correcto"
            dv.recalcular_dvh("bitacora")
            dv.Recalcular_dvv("bitacora")

       
        Else
            MsgBox("El usuario ingresado, no puede utilizar el sistema. Verifique el usuario ingresado")
            txtusuario.Focus()
            bita.usuario = cifrado
            bita.criticidad = "Medio"
            bita.desc_mov = "Usuario Incorrecto"
            bita.grabar()
            dv.recalcular_dvh("bitacora")
            dv.Recalcular_dvv("bitacora")
     
            Exit Sub

        End If
        'cifro y cargo la contraseña
        cifrado = cifrar.EncriptadoPermanente(txtcontraseña.Text)
        txt2.Text = cifrado.ToString
        'usuarito.usuario = txtusuario.Text

        'valido contraseña e ingreso al sistema
        Try
            Dim hilo As Boolean
            hilo = usuarito.cargar(cifrado)
            Dim idiomas As Integer = BLL.blldetidioma.DetectarIdioma(_usuario)

            dv.recalcular_dvh("Usuarios")
            dv.Recalcular_dvv("Usuarios")
            dv.recalcular_dvh("bitacora")
            dv.Recalcular_dvv("bitacora")


            If hilo = True Then
                Dim pantalla As New inicio1(_usuario, idiomas)

                pantalla.Show()

                Me.Hide()
            End If







        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'inicio.Show()
    End Sub

    Private Sub txtusuario_AcceptsTabChanged(sender As Object, e As EventArgs) Handles txtusuario.AcceptsTabChanged

    End Sub

    Private Sub txtusuario_Click(sender As Object, e As EventArgs) Handles txtusuario.Click

    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub txtcontraseña_Click(sender As Object, e As EventArgs) Handles txtcontraseña.Click

    End Sub

    Private Sub txtcontraseña_TextChanged(sender As Object, e As EventArgs) Handles txtcontraseña.TextChanged



    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Start()
        Dim dv As New BLL.blldv
        Try

            dv.verficar_integridad()

        Catch ex As Exception

            restoresinicio.Show()
            Me.Hide()


        End Try


    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    '    'PictureBox2.Image.RotateFlip(RotateFlipType.Rotate90FlipX)

    '    '    PictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipX)

    '    '    PictureBox2.Image.RotateFlip(RotateFlipType.Rotate270FlipX)


    'End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        End

    End Sub
End Class
