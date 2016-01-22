Imports System.Net.Mail
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class altausuario
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
    Private _id_usuario As Integer
    Public Property id_usuario() As Integer
        Get

            Return _id_usuario
        End Get
        Set(ByVal value As Integer)
            _id_usuario = value
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

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        For Each Con As Control In Me.Controls
            If (TypeOf Con Is TextBox) Then


                If Con.Text = String.Empty Then
                    MsgBox("Debe completar el formulario")
                    Exit Sub
                End If
                If Con.Name = "txtusuario" And Con.Text.Length < 5 Or Con.Text.Length > 15 Then
                    MsgBox("El Usuario es muy largo o muy corto")
                    Exit Sub
                End If
                If Con.Name = "txtcontraseña" And Con.Text.Length < 10 Or Con.Text.Length > 15 Then
                    MsgBox("El Usuario es muy largo o muy corto")
                    Exit Sub
                End If
                If Con.Name = "txtnombre" And IsNumeric(Con.Text) Then
                    MsgBox("El nombre no puede tener Números")
                    Exit Sub

                End If

                If Con.Name = "txtapellido" And IsNumeric(Con.Text) Then
                    MsgBox("El nombre no puede tener Números")
                    Exit Sub

                End If
                If Con.Name = "txtident" And Not IsNumeric(Con.Text) Then
                    MsgBox("La identificación no puede tener letras")
                    Exit Sub

                End If


            End If

        Next

        Try
            Const ruta As String = "d:\archivo.txt"
            Using archivo As StreamWriter = New StreamWriter(ruta)
                'linea dataview
                Dim linea As String = String.Empty
                linea = "Nueva Contraseña de Usuario Hermes S.R.L."
                archivo.WriteLine(linea)

                'message.From = New MailAddress(txtmail.Text)
                linea = "Su Mail es: " & txtmail.Text
                archivo.WriteLine(linea)
                'message.To.Add(txtmail.Text)

                'message.Body = "Su Contraseña es: " & contraseña
                linea = "Su Contraseña es: " & contraseña.ToString
                archivo.WriteLine(linea)
                'message.Subject = "Nueva Contraseña de Usuario Hermes S.R.L."

                'message.Priority = MailPriority.Normal

                'smtp.EnableSsl = True

                'smtp.Port = "587"

                'smtp.Host = "smtp.live.com"

                'smtp.Credentials = New Net.NetworkCredential("kbc_95@hotmail.com", "1995_morgan")

                'smtp.Send(message)
                'MsgBox("Mail enviado")
            End Using
            Process.Start(ruta)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim cifrado As String
        cifrado = encrypta.encriptar(txtusuario.Text)
        Dim id_pais As Integer
        Dim id_provincia As Integer
        id_pais = BLL.blldomicilio.id_pais(cmbpais.Text)
        id_provincia = BLL.blldomicilio.id_provincia(cmbprovincia.Text)
        Dim activo As Integer
        Dim bloq As Integer
        Dim idioma As Integer = BLL.blldetidioma.id_idioma(txtidioma.Text)




        If chkdesactivar.Checked = True Then
            activo = 0
        Else
            activo = 1
        End If

        If chkdesbloquear.Checked = True Then
            bloq = 0
        Else
            bloq = 1
        End If



        Dim seto As New DataSet
        seto = BLL.clsbuscar.actualizargrilla(seto, "Usuarios")
        Dim row As DataRow = seto.Tables(0).NewRow
        'tomar valores de los txt
        row.Item(1) = cifrado
        row.Item(2) = encrypta.EncriptadoPermanente(contraseña)
        row.Item(3) = txtmail.Text
        row.Item(4) = txtnombre.Text
        row.Item(5) = txtapellido.Text
        row.Item(6) = txtfecha.Text
        row.Item(7) = id_pais
        row.Item(8) = id_provincia
        row.Item(9) = idioma
        row.Item(10) = txtcp.Text
        row.Item(11) = txtdireccion.Text
        row.Item(12) = activo
        row.Item(13) = bloq
        row.Item(14) = txtcant.Text
        'agrega nueva fila en primera posicion de primera celda de seto
        seto.Tables(0).Rows.Add(row)

        BLL.clsbuscar.actualizar_datos(seto, "Usuarios")
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("Usuarios")
        dv.Recalcular_dvv("Usuarios")
        Dim id_usuario As Integer
        id_usuario = BLL.bllusuario.id_usuario(cifrado)
        seto = BLL.clsbuscar.actualizargrilla(seto, "Tel_Usuarios")
        For Each fila As DataGridViewRow In datagridtels.Rows

            Dim rowito As DataRow = seto.Tables(0).NewRow
            rowito.Item(1) = id_usuario
            If fila.Cells(0).Value > 0 Then
                rowito.Item(2) = fila.Cells(0).Value
                seto.Tables(0).Rows.Add(rowito)
                BLL.clsbuscar.actualizar_datos(seto, "Tel_Usuarios")

            End If



        Next
        'bitácora
        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Usuario Agregado"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        Me.Hide()
        Dim usuarios As New usuarios(_usuario, _idioma)
        usuarios.Show()



    End Sub

    Private Sub frmaltausuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        Dim seto As New DataSet

        seto = BLL.blldetidioma.idioma()
        For Each row As DataRow In seto.Tables(0).Rows
            txtidioma.Items.Add(row.ItemArray(0))
        Next
        seto = BLL.blldomicilio.paises
        For Each row As DataRow In seto.Tables(0).Rows
            cmbpais.Items.Add(row.ItemArray(0))
        Next

        contraseña = BLL.bllusuario.pass()


    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Dim pantalla As New usuarios(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub
 
    Private Sub cmbprovincia_Click(sender As Object, e As EventArgs) Handles cmbprovincia.Click

    End Sub

    Private Sub cmbprovincia_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles cmbprovincia.ContextMenuStripChanged
        
    End Sub

    Private Sub txtprovincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbprovincia.SelectedIndexChanged

    End Sub
    Public Sub idioma()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim seto As New DataSet
        Dim provincia As Integer = BLL.blldomicilio.id_provincia(cmbprovincia.Text)
        seto = BLL.blldomicilio.localildad(Val(txtcp.Text), provincia)
        For Each row As DataRow In seto.Tables(0).Rows
            cmblocalidad.Items.Add(row.ItemArray(0))
        Next
    End Sub

    Private Sub TelefonosDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub AgregarTelBtn_Click(sender As Object, e As EventArgs) Handles AgregarTelBtn.Click
        datagridtels.Rows.Add(txtnumero.Text)
        txtnumero.Clear()

    End Sub

    Private Sub UsuarioGB_Enter(sender As Object, e As EventArgs) Handles UsuarioGB.Enter

    End Sub

    Private Sub QuitarTelBtn_Click(sender As Object, e As EventArgs) Handles QuitarTelBtn.Click
        datagridtels.Rows.Remove(datagridtels.CurrentRow)
        txtnumero.Clear()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpais.SelectedIndexChanged
        Dim seto As New DataSet
        seto = BLL.blldomicilio.provincia(cmbpais.Text)
        For Each row As DataRow In seto.Tables(0).Rows
            cmbprovincia.Items.Add(row.ItemArray(0))
        Next
    End Sub

    Private Sub cmblocalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblocalidad.SelectedIndexChanged

    End Sub
End Class