Imports System.Windows.Forms
Imports BLL
Imports System.Resources
Imports System.ComponentModel
Imports System.Globalization
Imports Idioma
Imports BLL.bllusuario
Imports System.Net.Mail
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO



Public Class inicio1
    Dim permisos As New BLL.bllpermisos
    Dim patentes As New BLL.bllpatentes
    Dim familia As New BLL.bllfamilia
    Dim message As New MailMessage
    Dim contraseña As String
    Dim smtp As New SmtpClient
    Dim encrypta As New BLL.bllencriptar


#Region "Propiedades"
    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _idioma As Integer
    Public Property id_idioma() As Integer
        Get
            Return _idioma
        End Get
        Set(ByVal value As Integer)
            _idioma = value
        End Set
    End Property

#End Region




    'Constructor
    Sub New(ByVal usuario As String, ByVal idioma As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.usuario = usuario
        Me.id_idioma = idioma

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub



    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub inicio_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TransportesToolStripMenuItem_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsclientes210.Click
        ' clientes.Show()
        Dim pantalla As New clientes(_usuario, _idioma)

        pantalla.Show()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs)



        Dim pantalla As New altacliente(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()
    End Sub

    Private Sub BajaToolStripMenuItem1_Click(sender As Object, e As EventArgs)


        Dim pantalla As New clientes(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs)


        Dim pantalla As New modifcliente(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ConsultarToolStripMenuItem2_Click(sender As Object, e As EventArgs)

        Dim pantalla As New clientes(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub PaqueteToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs)



        Dim pantalla As New altapaquete(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub BajaToolStripMenuItem2_Click(sender As Object, e As EventArgs)


        Dim pantalla As New paquetes(_usuario, _idioma)

        pantalla.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem2_Click(sender As Object, e As EventArgs)


        Dim pantalla As New modifpaquete(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ConsultarToolStripMenuItem3_Click(sender As Object, e As EventArgs)


        Dim pantalla As New paquetes(_usuario, _idioma)

        pantalla.Show()

    End Sub

    Private Sub ChoferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tschofer220.Click

        Dim pantalla As New Choferes1(_usuario, _idioma)

        pantalla.Show()

    End Sub

    Private Sub AltaToolStripMenuItem2_Click(sender As Object, e As EventArgs)

        Dim pantalla As New altachofer(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub BajaToolStripMenuItem3_Click(sender As Object, e As EventArgs)


        Dim pantalla As New Choferes1(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem3_Click(sender As Object, e As EventArgs)


        Dim pantalla As New modifchofer(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ConsultarToolStripMenuItem4_Click(sender As Object, e As EventArgs)

        Dim pantalla As New Choferes1(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub RodadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsrodado230.Click
        Dim pantalla As New rodados(_usuario, _idioma)

        pantalla.Show()

    End Sub

    Private Sub AltaToolStripMenuItem3_Click(sender As Object, e As EventArgs)


        Dim pantalla As New altarodado(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub BajaToolStripMenuItem4_Click(sender As Object, e As EventArgs)

        Dim pantalla As New rodados(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem4_Click(sender As Object, e As EventArgs)

        Dim pantalla As New modifrodado(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ConsultarToolStripMenuItem5_Click(sender As Object, e As EventArgs)

        Dim pantalla As New rodados(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim pantalla As New envios1(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs)


        Dim pantalla As New envios1(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs)


        Dim pantalla As New envios1(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub FacturaciónToolStripMenuItem1_Click(sender As Object, e As EventArgs)

        Dim pantalla As New altafactura(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub NotaDeCréditoToolStripMenuItem_Click(sender As Object, e As EventArgs)


        Dim pantalla As New facturas(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim pantalla As New facturas(_usuario, _idioma)

        pantalla.Show()

    End Sub

    Private Sub ChoquesToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub InformaciónEstadísticaToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AltaToolStripMenuItem7_Click(sender As Object, e As EventArgs)
        Dim pantalla As New altacrash(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub BajaToolStripMenuItem8_Click(sender As Object, e As EventArgs)
        Dim pantalla As New Crashs(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem8_Click(sender As Object, e As EventArgs)
        Dim pantalla As New modifcrash(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ConsultarToolStripMenuItem9_Click(sender As Object, e As EventArgs)
        Dim pantalla As New Crashs(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub TransportesHistóricosToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        contranshistorico.Show()

    End Sub

    Private Sub TransporToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim pantalla As New conbajasclientes(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()


    End Sub

    Private Sub ChoquesToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim pantalla As New conbajascrash(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()
    End Sub

    Private Sub PauetesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim pantalla As New conbajaspaquetes(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub RodadosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim pantalla As New conbajasrodados(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub TransportesHistóricosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim pantalla As New conbajastransportes(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub TransporteToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles tsorden1.CheckedChanged
        tsorden1.ForeColor = Color.Black
    End Sub

    Private Sub TransporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsorden1.Click
        'envios1.Show()

        Dim pantalla As New envios1(_usuario, _idioma)

        pantalla.Show()
    End Sub

    Private Sub BitácoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsbitacora710.Click
        Dim pantalla As New bitacora(_usuario, _idioma)

        pantalla.Show()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsbackup720.Click
        Dim pantalla As New backup(_usuario, _idioma)

        pantalla.Show()

    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsrestore730.Click
        Dim pantalla As New restore2(_usuario, _idioma)


        pantalla.Show()

    End Sub

    Private Sub AltaToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        Dim pantalla As New altausuario(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub BajaToolStripMenuItem5_Click(sender As Object, e As EventArgs)
        Dim pantalla As New usuarios(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem5_Click(sender As Object, e As EventArgs)
        Dim pantalla As New modifusuario(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ConsultarToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        Dim pantalla As New usuarios(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub PatentesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AltaToolStripMenuItem5_Click(sender As Object, e As EventArgs)
        Dim pantalla As New altafamilia(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub BajaToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        Dim pantalla As New familias(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        Dim pantalla As New modiffamilia(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub ConsultarToolStripMenuItem7_Click(sender As Object, e As EventArgs)
        Dim pantalla As New familias(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub BajaToolStripMenuItem7_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AltaToolStripMenuItem6_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsdioma.Click


    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tssalir.Click
        End

    End Sub

    Private Sub FacturaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsfacturacion.Click
        tsfacturacion.ForeColor = Color.Black

    End Sub

    Private Sub BajasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub inicio_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized







        'Dim idioma_detectado As Integer = BLL.blldetidioma.DetectarIdioma(_usuario)

        If _idioma = 1 Then

            Idioma.bllidioma.cambiaridioma(Me, _idioma)

        End If

        If _idioma = 2 Then

            Idioma.bllidioma.cambiaridioma(Me, _idioma)

        End If

        '*******************Cargo la Pantalla************************
        'cargo el usuario
        patentes.usuario = _usuario
        familia.usuario = patentes.usuario

        'cargo las patentes del usuario_patentes
        patentes.permisos()
        permisos.PatentesUsuario = patentes.seto

        'cargo las patentes del usuario por su familia
        familia.permisos()
        permisos.FamiliaPatente = familia.seto


        'habilito patentes
        tsorden1.Enabled = permisos.permiso(1)
        tsclientes210.Enabled = permisos.permiso(210)
        tschofer220.Enabled = permisos.permiso(220)
        tsrodado230.Enabled = permisos.permiso(230)
        'tschofrodasignar241.Enabled = permisos.permiso(241)
        'tschofrodver242.Enabled = permisos.permiso(242)
        'tsrutasgestion310.Enabled = permisos.permiso(310)
        'tsrodrutasignar321.Enabled = permisos.permiso(321)
        'tsrodrutver322.Enabled = permisos.permiso(322)
        tsfacturaciongestion410.Enabled = permisos.permiso(410)
        'tschoque510.Enabled = permisos.permiso(510)
        'tsbajasclientes521.Enabled = permisos.permiso(521)
        'tsbajaschoques522.Enabled = permisos.permiso(522)
        'tsbajaspaquetes523.Enabled = permisos.permiso(523)
        'tsbajasrodados524.Enabled = permisos.permiso(524)
        'tsbajastransportes525.Enabled = permisos.permiso(525)
        'tstranshist530.Enabled = permisos.permiso(530)
        tsusuarios610.Enabled = permisos.permiso(610)
        tsfamilias620.Enabled = permisos.permiso(620)
        tsbitacora710.Enabled = permisos.permiso(710)
        tsbackup720.Enabled = permisos.permiso(720)
        tsrestore730.Enabled = permisos.permiso(730)
        tses810.Enabled = permisos.permiso(810)
        tsen820.Enabled = permisos.permiso(820)
        tspass830.Enabled = permisos.permiso(830)

    End Sub

    Private Sub GestiónToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GestiónToolStripMenuItem1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub GestiónToolStripMenuItem2_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub StatusStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip.ItemClicked

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AdministraciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        tsadmin.ForeColor = Color.Black




    End Sub

    Private Sub SeguridadToolStripMenuItem_Click(sender As Object, e As EventArgs)
        tsseguridad.ForeColor = Color.Black

    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        tsopciones.ForeColor = Color.Black

    End Sub

    Private Sub GestiónToolStripMenuItem3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PaquetesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim pantalla As New cliente_paquete(_usuario, _idioma)
        'pantalla.MdiParent = Me
        'pantalla.Show()

    End Sub

    Private Sub GestiónToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles tsfacturaciongestion410.Click
        Dim pantalla As New facturas(_usuario, _idioma)
        pantalla.Show()


    End Sub

    Private Sub GestiónToolStripMenuItem5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GestiónToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        Dim pantalla As New usuarios(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub GestiónToolStripMenuItem7_Click(sender As Object, e As EventArgs)
        Dim pantalla As New familias(_usuario, _idioma)
        pantalla.MdiParent = Me
        pantalla.Show()

    End Sub

    Private Sub AdministraciónToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles tsadmin.Click

    End Sub

    Private Sub AsginarToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GestiónToolStripMenuItem8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GestiónToolStripMenuItem9_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DenegarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GestiónToolStripMenuItem6_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub AsignarRodadosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GestiónToolStripMenuItem7_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub AsignarRodadoToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AsginarChoferARodadoToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AsignarToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GestiónToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub AsignarToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripStatusLabel_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel.Click

    End Sub

    Private Sub EspañolArgentinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tses810.Click
        Dim idiomas As New Idioma.bllidioma
        Me._idioma = 1
        idiomas.id_idioma = _idioma
        Idioma.bllidioma.cambiaridioma(Me, idiomas.id_idioma)


        Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Maximized



    End Sub

    Private Sub tspermisos_Click(sender As Object, e As EventArgs) Handles tspermisos.Click

    End Sub

    Private Sub tsen_Click(sender As Object, e As EventArgs) Handles tsen820.Click
        Dim idiomas As New Idioma.bllidioma
        Me._idioma = 2
        idiomas.id_idioma = _idioma
        Idioma.bllidioma.cambiaridioma(Me, idiomas.id_idioma)

        Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Maximized




    End Sub

    Private Sub tsusuarios_Click(sender As Object, e As EventArgs) Handles tsusuarios610.Click
        ' usuarios.Show()
        Dim pantalla As New usuarios(_usuario, _idioma)
        pantalla.Show()

    End Sub

    Private Sub tsfamilias_Click(sender As Object, e As EventArgs) Handles tsfamilias620.Click
        Dim pantalla As New familias(_usuario, _idioma)

        pantalla.Show()
    End Sub

    Private Sub tsopciones_Click(sender As Object, e As EventArgs) Handles tsopciones.Click

    End Sub

    Private Sub tspass830_Click(sender As Object, e As EventArgs) Handles tspass830.Click
        Dim op As String
        contraseña = BLL.bllusuario.pass()
        Dim dv As New BLL.blldv
        Dim mail As String
        Dim bita As New BLL.bllbitacora
        mail = BLL.bllusuario.mail_usuario(_usuario)
        op = MessageBox.Show("¿Seguro quiere cambiar la Contraseña?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            Try
                Const ruta As String = "d:\archivo.txt"
                Using archivo As StreamWriter = New StreamWriter(ruta)
                    'linea dataview
                    Dim linea As String = String.Empty
                    linea = "Nueva Contraseña de Usuario Hermes S.R.L."
                    archivo.WriteLine(linea)

                    'message.From = New MailAddress(txtmail.Text)


                    'message.To.Add(txtmail.Text)

                    'message.Body = "Su Contraseña es: " & contraseña
                    linea = "Su Contraseña es: " & contraseña.ToString
                    archivo.WriteLine(linea)
                    'message.Subject = "Nueva Contraseña de Usuario Hermes S.R.L."
                    'message.From = New MailAddress(mail)

                    'message.To.Add(mail)

                    'message.Body = "Su Contraseña es: " & contraseña

                    'message.Subject = "Nueva Contraseña de Usuario Hermes S.R.L."

                    'message.Priority = MailPriority.Normal

                    'smtp.EnableSsl = True

                    'smtp.Port = "587"

                    'smtp.Host = "smtp.live.com"

                    'smtp.Credentials = New Net.NetworkCredential("kbc_95@hotmail.com", "1995_morgan")

                    'smtp.Send(message)
                    'MsgBox(" Contraseña nueva enviada a su Mail")
                End Using

                Process.Start(ruta)
                Dim seto As New DataSet
                Dim id_usuario As Integer
                id_usuario = BLL.bllusuario.id_usuario(_usuario)
                seto = BLL.clsbuscar.buscar_tabla_usuario(id_usuario)

                Dim row As DataRow = seto.Tables(0).Rows(0)
                'tomar valores de los txt

                If _usuario = row.Item(1).ToString Then
                    row.Item(2) = encrypta.EncriptadoPermanente(contraseña)
                End If
                MsgBox(seto.Tables(0).Rows(0).Item(5).ToString)
                BLL.clsbuscar.actualizar_datos(seto, "Usuarios")

                dv.recalcular_dvh("Usuarios")
                dv.Recalcular_dvv("Usuarios")


               
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            'bitácora
           
        Else
            MsgBox("La contraseña no ha sido Cambiada")
        End If

        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Contraseña Reseteada"
        bita.grabar()
        
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
    End Sub

    Private Sub ChoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChoqueToolStripMenuItem.Click
        Dim pantalla As New Crashs(_usuario, _idioma)

        pantalla.Show()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("D:\##Chicos\Hermes\Hermes\Hermes\Manual de Usuario.pdf")
    End Sub
End Class
