Public Class usuarios
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


   'Constructor
    Sub New(ByVal usuario As String, ByVal idioma As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.usuario = usuario
        Me.id_idioma = idioma

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
#End Region
    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        Idioma.bllidioma.cambiaridioma(Me, _idioma)
        grillaok()
        cargar_campos()


    End Sub

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            BLL.clsbuscar.dar_baja(Convert.ToInt32(datagridusuarios.CurrentRow.Cells(0).Value), "Usuarios")
            Dim bita As New BLL.bllbitacora
            Dim dv As New BLL.blldv
            Dim ok As Integer
            ok = datagridusuarios.RowCount - 1

            grillaok()
            If datagridusuarios.RowCount - 1 = ok Then
                MsgBox("El dato no ha sido Borrado")
                Exit Sub

            End If
            bita.usuario = _usuario
            bita.criticidad = "bajo"
            bita.desc_mov = "Usuario Eliminado"
            bita.grabar()
            dv.recalcular_dvh("bitacora")
            MsgBox("El dato ha sido eliminado")
        Else
            MsgBox("El dato no ha sido Borrado")
        End If
        grillaok()

    End Sub

    Private Sub EliminarTelBtn_Click(sender As Object, e As EventArgs)
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            BLL.clsbuscar.eliminar_telefonos_usuarios(datagridusuarios.CurrentRow.Cells(0).Value)
            MsgBox("El dato ha sido eliminado")
        Else
            MsgBox("El dato no ha sido Borrado")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim pantalla As New inicio1(_usuario, _idioma)
        pantalla.Close()
        Dim pantalla1 As New inicio1(_usuario, _idioma)
        pantalla1.Show()


   
        Me.Hide()

    End Sub

    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        Dim pantalla As New altausuario(_usuario, _idioma)
        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Dim row As DataGridViewRow = datagridusuarios.CurrentRow
        Dim modifusuario As New modifusuario(_usuario, _idioma)
        
        Dim value As Object = row.Cells("nombre_usuario").Value
        modifusuario.txtusuario.Text = value.ToString
        value = row.Cells("mail").Value
        modifusuario.txtmail.Text = value.ToString
        value = row.Cells("nombre_usu").Value
        modifusuario.txtnombre.Text = value.ToString
        value = row.Cells("apellido_usu").Value
        modifusuario.txtapellido.Text = value.ToString
        value = row.Cells("fecha_ingreso").Value
        modifusuario.txtfecha.Text = value.ToString
        value = row.Cells("cp_usuario").Value
        modifusuario.txtcp.Text = value.ToString
        value = row.Cells("dirección_usuario").Value
        modifusuario.txtdireccion.Text = value.ToString
        value = row.Cells("activo").Value
        If value = "True" Then
            modifusuario.chkdesactivar.Checked = True
        End If
        value = row.Cells("bloq").Value
        If value = "True" Then
            modifusuario.chkdesbloquear.Checked = True
        End If
        value = row.Cells("cant_inicios").Value
        modifusuario.txtcant.Text = value.ToString
        value = row.Cells("baja").Value
        If value = "True" Then
            modifusuario.chkbaja.Checked = True
        End If
        modifusuario.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As DataGridViewRow = datagridusuarios.CurrentRow

        Dim value As Object = row.Cells("nombre_usuario").Value
        Dim usuariopatente As New usuariopatente(_usuario, _idioma)
        usuariopatente.Show()
        usuariopatente.txtusuario.Text = value.ToString

        Me.Hide()


    End Sub

    Public Sub grillaok()
        Dim tabla As String
        tabla = "Usuarios"
        Dim seto As New DataSet
        Dim i As Integer
        seto = BLL.clsbuscar.actualizargrilla(seto, tabla)
      

       
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            seto.Tables(0).Rows(i).Item(7) = BLL.blldomicilio.nombre_pais(row.ItemArray(7))
            seto.Tables(0).Rows(i).Item(8) = BLL.blldomicilio.nombre_provincia_string(seto.Tables(0).Rows(i).Item(7), row.ItemArray(8))
            seto.Tables(0).Rows(i).Item(9) = BLL.blldetidioma.nombre_idioma(row.ItemArray(9))
            i = i + 1
        Next

        datagridusuarios.DataSource = seto.Tables(0)
        datagridusuarios.Columns("id_" & tabla).Visible = False
        datagridusuarios.Columns("dvh").Visible = False
        datagridusuarios.Columns("contraseña_usuario").Visible = False
        datagridusuarios.Columns("baja").Visible = False
        datagridusuarios.Columns("cant_inicios").Visible = False
 

        datagridusuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        
   
    End Sub
    Public Sub cargar_campos()
        Dim tabla As String
        tabla = "Usuarios"
        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_campos(tabla)
        For Each item As DataColumn In seto.Tables(0).Columns
            If item.ToString <> "dvh" And item.ToString <> "id_idioma" And item.ToString <> "cant_inicios" And item.ToString <> "id_provincia" And item.ToString <> "id_pais" And item.ToString <> "id_" & tabla And item.ToString <> "Id_" & tabla And item.ToString <> "baja" And (item.ToString <> "id_" & tabla) Then
                cmbbuscar.Items.Add(item.ToString)
            End If
        Next
    End Sub

    Public Sub buscar_por_campo()
        Dim tabla As String
        tabla = "Usuarios"
        Dim campo As String = cmbbuscar.Text
        Dim texto As String = txtbuscar.Text
        If campo = "nombre_usuario" Then
            Dim cifrado As String
            cifrado = encrypta.encriptar(txtbuscar.Text)
            texto = cifrado.ToString
        End If
        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_por_campos(tabla, campo, texto)
        datagridusuarios.DataSource = seto.Tables(0)

    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        buscar_por_campo()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        grillaok()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim row As DataGridViewRow = datagridusuarios.CurrentRow

        Dim value As Object = row.Cells("nombre_usuario").Value
        Dim usuariofamilia As New usuariofamilia(_usuario, _idioma)
        usuariofamilia.txtusuario.Text = value.ToString
        usuariofamilia.Show()
        Me.Hide()
    End Sub

    Private Sub RegistrosGB_Enter(sender As Object, e As EventArgs) Handles RegistrosGB.Enter

    End Sub

    Private Sub GestionUsuariosGB_Enter(sender As Object, e As EventArgs) Handles GestionUsuariosGB.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        imprimir_usuarios.UsuariosTableAdapter.Fill(imprimir_usuarios.Campo.Usuarios)
        imprimir_usuarios.ReportViewer1.LocalReport.Refresh()
        imprimir_usuarios.Show()
    End Sub
End Class