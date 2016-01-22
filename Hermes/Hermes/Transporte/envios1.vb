Imports System.Resources
Imports Microsoft.Reporting.WinForms

Public Class envios1
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
    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim pantalla As New altaenvio(_usuario, _idioma)
        pantalla.Show()



    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim pantalla As New modifenvio(_usuario, _idioma)

        pantalla.Show()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Me.Hide()

    End Sub

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs)
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            MsgBox("El dato ha sido eliminado")
        Else
            MsgBox("El dato no ha sido Borrado")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere Imprimir?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            MsgBox("Imprimiendo...")
        Else
            MsgBox("No se Imprimió")
        End If
    End Sub

    Private Sub envios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grillaok()
        cargar_campos()

        Idioma.bllidioma.cambiaridioma(Me, _idioma)
    End Sub
    Public Sub grillaok()
        Dim seto As New DataSet
        Dim tabla As String
        tabla = "Transportes"

        seto = BLL.clsbuscar.actualizargrilla(seto, tabla)
        Dim i As Integer
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(1) = BLL.bllenvios.nombre_cliente(row.ItemArray(1))
            seto.Tables(0).Rows(i).Item(4) = BLL.bllenvios.nombre_pp(row.ItemArray(4))
            seto.Tables(0).Rows(i).Item(5) = BLL.bllenvios.nombre_pl(row.ItemArray(5))
            i = i + 1
        Next

        datagridenvios.DataSource = seto.Tables(0)
        datagridenvios.Columns("id_" & tabla).Visible = False
        datagridenvios.Columns("dvh").Visible = False
        datagridenvios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridenvios.EditMode = DataGridViewEditMode.EditProgrammatically
    End Sub
    Public Sub cargar_campos()
        Dim tabla As String
        tabla = "Transportes"
        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_campos(tabla)
        For Each item As DataColumn In seto.Tables(0).Columns
            If item.ToString <> "dvh" And item.ToString <> "baja" And (item.ToString <> "id_" & tabla) Then
                cmbbuscar.Items.Add(item.ToString)
            End If
        Next
    End Sub
    Private Sub frmusuarios_Enter(sender As Object, e As EventArgs) Handles frmusuarios.Enter

    End Sub

    Private Sub RecargarBtn_Click(sender As Object, e As EventArgs)
        grillaok()

    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click

        Dim seto As New DataSet
        Dim tabla As String = "Transportes"
        Dim i As Integer

        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(1) = BLL.bllenvios.nombre_cliente(row.ItemArray(1))
            seto.Tables(0).Rows(i).Item(2) = BLL.bllenvios.nombre_paquete(row.ItemArray(2))
            seto.Tables(0).Rows(i).Item(3) = BLL.bllenvios.nombre_pp(row.ItemArray(3))
            seto.Tables(0).Rows(i).Item(4) = BLL.bllenvios.nombre_pl(row.ItemArray(4))
            i = i + 1
        Next


        seto = BLL.clsbuscar.buscar_por_campos(tabla, cmbbuscar.Text, txtbuscar.Text)
        datagridenvios.DataSource = seto.Tables(0)
        datagridenvios.Columns("id_" & tabla).Visible = False
        datagridenvios.Columns("dvh").Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim pantalla As New ver_paquetes(_usuario, _idioma)

        Dim row As DataGridViewRow = datagridenvios.CurrentRow()

        Dim value As Object = row.Cells("id_Transportes").Value
        pantalla.txtid.Text = value.ToString
        pantalla.Show()

    End Sub

    Private Sub ModificarBtn_Click_1(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Dim pantalla As New modifenvio(_usuario, _idioma)

        Dim row As DataGridViewRow = datagridenvios.CurrentRow()

        Dim value As Object = row.Cells("id_Transportes").Value
        pantalla.id = value.ToString
        value = row.Cells("Id_cliente").Value
        pantalla.cliente = value.ToString
        value = row.Cells("Id_rodado").Value
        pantalla.rodado = value.ToString
        value = row.Cells("Id_chofer").Value
        pantalla.chofer = value.ToString
        value = row.Cells("id_punto_partida").Value
        pantalla.lp = value.ToString
        value = row.Cells("id_punto_llegada").Value
        pantalla.ll = value.ToString

        value = row.Cells("km").Value
        pantalla.km = value.ToString
        value = row.Cells("remito").Value
        pantalla.remito = value.ToString
        value = row.Cells("baja").Value
        If value = "True" Then
            pantalla.chkbaja.Checked = True
        End If


        pantalla.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarBtn_Click_1(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            BLL.clsbuscar.dar_baja(datagridenvios.CurrentRow.Cells(0).Value, "Transportes")
            MsgBox("El dato ha sido eliminado")
            Dim op2 As String
            op2 = MessageBox.Show("¿Elimina el envío por un choque?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If op = vbYes Then
                Dim pantalla As New altacrash(_usuario, _idioma)
                Dim row As DataGridViewRow = datagridenvios.CurrentRow()
                Dim value As Object = row.Cells("id_Transportes").Value
                pantalla.envio = value.ToString

                pantalla.Show()
                Me.Close()
                Exit Sub

            End If

        Else
            MsgBox("El dato no ha sido Borrado")
        End If
        grillaok()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        imprimir_envios.TransportesTableAdapter.Fill(imprimir_usuarios.Campo.Transportes)
        imprimir_envios.ReportViewer1.LocalReport.Refresh()
        imprimir_envios.Show()

    End Sub

    Private Sub RecargarBtn_Click_1(sender As Object, e As EventArgs)
        grillaok()

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs)
        Dim pantalla As New altafactura(_usuario, _idioma)

        Dim row As DataGridViewRow = datagridenvios.CurrentRow()

        Dim value As Object = row.Cells("id_Transportes").Value
        pantalla.txttransporte.Text = value.ToString
        value = row.Cells("Id_cliente").Value
        pantalla.txtcliente.Text = value.ToString
        value = row.Cells("Id_rodado").Value
        pantalla.txtrodado.Text = value.ToString
        value = row.Cells("Id_chofer").Value
        pantalla.txtchofer.Text = value.ToString
        value = row.Cells("id_punto_partida").Value
        pantalla.txtlp.Text = value.ToString
        value = row.Cells("id_punto_llegada").Value
        pantalla.txtll.Text = value.ToString
        value = row.Cells("fecha_partida").Value
        pantalla.txtfp.Text = value.ToString
        value = row.Cells("fecha_llegada").Value
        pantalla.txtfl.Text = value.ToString
        value = row.Cells("km").Value
        pantalla.txtkm.Text = value.ToString
        value = row.Cells("remito").Value
        pantalla.txtremito.Text = value.ToString
        value = row.Cells("id_Transportes").Value
        pantalla.txttransporte.Text = value.ToString
        Dim seto As New DataSet
        seto = BLL.bllenvios.ver_paquetes(value)
        pantalla.datagridpaquetes.DataSource = seto.Tables(0)


        pantalla.Show()
        Me.Hide()
    End Sub

    Private Sub AgregarBtn_Click_1(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        Dim pantalla As New altaenvio(_usuario, _idioma)
        pantalla.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pantalla As New ver_paquetes(_usuario, _idioma)

        Dim row As DataGridViewRow = datagridenvios.CurrentRow()

        Dim value As Object = row.Cells("id_Transportes").Value
        pantalla.txtid.Text = value.ToString
        pantalla.Show()

    End Sub

    Private Sub OperacionGB_Enter(sender As Object, e As EventArgs) Handles OperacionGB.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim pantalla As New altacrash(_usuario, _idioma)
        Dim row As DataGridViewRow = datagridenvios.CurrentRow()
        Dim value As Object = row.Cells("id_Transportes").Value
        pantalla.envio = value.ToString

        pantalla.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        imprimir_envios.TransportesTableAdapter.Fill(imprimir_usuarios.Campo.Transportes)
        imprimir_envios.ReportViewer1.LocalReport.Refresh()
        imprimir_envios.Show()
    End Sub

    Private Sub btnok_Click_1(sender As Object, e As EventArgs) Handles btnok.Click
        Dim pantalla As New altafactura(_usuario, _idioma)

        Dim row As DataGridViewRow = datagridenvios.CurrentRow()

        Dim value As Object = row.Cells("id_Transportes").Value
        pantalla.txttransporte.Text = value.ToString
        value = row.Cells("Id_cliente").Value
        pantalla.txtcliente.Text = value.ToString
        value = row.Cells("Id_rodado").Value
        pantalla.txtrodado.Text = value.ToString
        value = row.Cells("Id_chofer").Value
        pantalla.txtchofer.Text = value.ToString
        value = row.Cells("id_punto_partida").Value
        pantalla.txtlp.Text = value.ToString
        value = row.Cells("id_punto_llegada").Value
        pantalla.txtll.Text = value.ToString
        value = row.Cells("fecha_partida").Value
        pantalla.txtfp.Text = value.ToString
        value = row.Cells("fecha_llegada").Value
        pantalla.txtfl.Text = value.ToString
        value = row.Cells("km").Value
        pantalla.txtkm.Text = value.ToString
        value = row.Cells("remito").Value
        pantalla.txtremito.Text = value.ToString
        value = row.Cells("id_Transportes").Value
        pantalla.txttransporte.Text = value.ToString
        Dim seto As New DataSet
        seto = BLL.bllenvios.ver_paquetes(value)
        pantalla.datagridpaquetes.DataSource = seto.Tables(0)


        pantalla.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        grillaok()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pantalla As New altacrash(_usuario, _idioma)
        Dim row As DataGridViewRow = datagridenvios.CurrentRow()
        Dim value As Object = row.Cells("id_Transportes").Value
        pantalla.envio = value.ToString

        pantalla.Show()
        Me.Close()
    End Sub
End Class