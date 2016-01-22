Imports System.Net.Mail
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class modifusuario
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
    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs)
        Dim pantalla As New usuarios(_usuario, _idioma)

        pantalla.Show()

        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs)
        Dim pantalla As New usuarios(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim pantalla As New usuarios(_usuario, _idioma)

        pantalla.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim pantalla As New usuarios(_usuario, _idioma)

        pantalla.Show()

    End Sub

    Private Sub modifusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        

        Dim provincia As Integer = BLL.blldomicilio.id_provincia(cmbprovincia.Text)
        seto = BLL.blldomicilio.localildad(Val(txtcp.Text), provincia)
        For Each row As DataRow In seto.Tables(0).Rows
            cmblocalidad.Items.Add(row.ItemArray(0))
        Next


        Dim id_usuario As Integer
        Dim cifrado As String
        cifrado = encrypta.encriptar(txtusuario.Text)
        id_usuario = BLL.bllusuario.id_usuario(cifrado)

        seto = BLL.bllusuario.ver_telefonos(id_usuario)
        datagridtels.DataSource = seto.Tables(0)

        Idioma.bllidioma.cambiaridioma(Me, id_idioma)
    End Sub

    Private Sub AceptarBtn_Click_1(sender As Object, e As EventArgs) Handles AceptarBtn.Click
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
        Dim baja As Integer




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

        If chkbaja.Checked = True Then
            baja = 1
        Else
            baja = 0
        End If
        Dim id_usuario As Integer
        cifrado = encrypta.encriptar(txtusuario.Text)
        id_usuario = BLL.bllusuario.id_usuario(cifrado)

        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_tabla_usuario(id_usuario)

        Dim row As DataRow = seto.Tables(0).Rows(0)
        'tomar valores de los txt

        If cifrado = row.Item(1).ToString Then
            Dim op As String
            op = MessageBox.Show("¿Desea cambiar la Contraseña del Usuario?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If op = vbYes Then
                row.Item(2) = encrypta.EncriptadoPermanente(contraseña)
                MsgBox("Contraseña Cambiada")
            Else
                MsgBox("No se cambió la cotraseña")
            End If
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
            row.Item(15) = baja
        End If
        MsgBox(seto.Tables(0).Rows(0).Item(2).ToString)
        BLL.clsbuscar.actualizar_datos(seto, "Usuarios")
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("Usuarios")
        dv.Recalcular_dvv("Usuarios")
        

        id_usuario = BLL.bllusuario.id_usuario(_usuario)
        seto = BLL.clsbuscar.buscar_tabla_usuario(id_usuario)

        'Dim row As DataRow = seto.Tables(0).Rows(0)
        'tomar valores de los txt



        'seto = BLL.bllusuario.ver_telefonos(id_usuario)
        'Dim rowito As DataRow = seto.Tables(0).Rows(0)
        'For Each fila As DataGridViewRow In datagridtels.Rows
        '    For Each rows As DataRow In seto.Tables(0).Rows
        '        rows.Item(1) = id_usuario
        '        If fila.Cells(2).Value > 0 Then
        '            rows.Item(2) = fila.Cells(2).Value
        '            BLL.clsbuscar.actualizar_datos(seto, "Tel_Usuarios")
        '            dv.calcular("Tel_Usuarios")
        '        End If
        '    Next
        'Next
        'bitácora

        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Usuario Modificado"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        Me.Hide()
        Dim pantalla As New usuarios(_usuario, _idioma)

        pantalla.Show()

    End Sub

    Private Sub cmbprovincia_Click(sender As Object, e As EventArgs) Handles cmbprovincia.Click
      
    End Sub

    Private Sub cmbprovincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbprovincia.SelectedIndexChanged

    End Sub

    Private Sub cmblocalidad_Click(sender As Object, e As EventArgs) Handles cmblocalidad.Click
      
    End Sub

    Private Sub cmblocalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblocalidad.SelectedIndexChanged

    End Sub

    Private Sub AgregarTelBtn_Click(sender As Object, e As EventArgs) Handles AgregarTelBtn.Click
       
        datagridtels.Rows.Add(txtnumero.Text)
        txtnumero.Clear()
    End Sub

    Private Sub QuitarTelBtn_Click(sender As Object, e As EventArgs) Handles QuitarTelBtn.Click
        datagridtels.Rows.Remove(datagridtels.CurrentRow)
        txtnumero.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim seto As New DataSet
        Dim provincia As Integer = BLL.blldomicilio.id_provincia(cmbprovincia.Text)
        seto = BLL.blldomicilio.localildad(Val(txtcp.Text), provincia)
        For Each row As DataRow In seto.Tables(0).Rows
            cmblocalidad.Items.Add(row.ItemArray(0))
        Next
    End Sub

    Private Sub datagridtels_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridtels.CellContentClick
        txtnumero.Text = datagridtels.Rows(e.RowIndex).Cells(2).Value.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'Dim row As DataGridViewRow = datagridtels.CurrentRow
        'row.Cells(2).Value = txtnumero.Text
        'datagridtels.Refresh()

    End Sub

    Private Sub CancelarBtn_Click_1(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Dim pantalla As New usuarios(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpais.SelectedIndexChanged
        Dim seto As New DataSet
        seto = BLL.blldomicilio.provincia(cmbpais.Text)
        For Each row As DataRow In seto.Tables(0).Rows
            cmbprovincia.Items.Add(row.ItemArray(0))
        Next
    End Sub

    Private Sub UsuarioGB_Enter(sender As Object, e As EventArgs) Handles UsuarioGB.Enter

    End Sub
End Class