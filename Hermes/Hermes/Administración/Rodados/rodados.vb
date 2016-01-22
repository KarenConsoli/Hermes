Imports System.Xml
Imports System.Text

Public Class rodados
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
    Dim encrypta As New BLL.bllencriptar

    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        Dim pantalla As New altarodado(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Dim pantalla As New modifrodado(_usuario, _idioma)

        Dim row As DataGridViewRow = datagridrodados.CurrentRow()

        Dim value As Object = row.Cells("dom_rodado").Value
        pantalla.txtdominio.Text = value.ToString
        value = row.Cells("Id_Rodado").Value
        pantalla.txtid.Text = value.ToString
        value = row.Cells("motor_rodado").Value
        pantalla.txtmotor.Text = value.ToString
        value = row.Cells("chasis_rodado").Value
        pantalla.txtchasis.Text = value.ToString
        value = row.Cells("modelo_rodado").Value
        pantalla.txtmodelo.Text = value.ToString
        value = row.Cells("año_rodado").Value
        pantalla.txtanio.Text = value.ToString
        value = row.Cells("capacidad_rodado").Value
        pantalla.txtcapacidad.Text = value.ToString
        value = row.Cells("baja").Value
        If value = "True" Then
            pantalla.chkbaja.Checked = True
        End If


        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            BLL.clsbuscar.dar_baja(datagridrodados.CurrentRow.Cells(0).Value, "Rodado")
            MsgBox("El dato ha sido eliminado")
        Else
            MsgBox("El dato no ha sido Borrado")
        End If
        grillaok()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Me.Hide()

    End Sub
  
    Public cliente As String
    Public paquetes As New List(Of String)
  
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere Imprimir?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            imprimir_rodados.Show()
            Exit Sub
        Else
            MsgBox("No se Imprimió")
        End If
    End Sub
 

    Private Sub rodados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Idioma.bllidioma.cambiaridioma(Me, _idioma)
        grillaok()
        cargar_campos()



    End Sub
    Public Sub grillaok()
        Dim tabla As String
        tabla = "Rodado"
        Dim seto As New DataSet

        seto = BLL.clsbuscar.actualizargrilla(seto, tabla)



        Dim i As Integer
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            seto.Tables(0).Rows(i).Item(4) = BLL.bllrodado.nombre_marca_rodado(row.ItemArray(4))
            seto.Tables(0).Rows(i).Item(8) = BLL.bllrodado.nombre_tipo_rodado(row.ItemArray(8))

            i = i + 1
        Next
        datagridrodados.DataSource = seto.Tables(0)
        datagridrodados.Columns("id_" & tabla).Visible = False
        datagridrodados.Columns("dvh").Visible = False

        datagridrodados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridrodados.EditMode = DataGridViewEditMode.EditProgrammatically


    End Sub
    Public Sub cargar_campos()
        Dim tabla As String
        tabla = "Rodado"
        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_campos(tabla)
        For Each item As DataColumn In seto.Tables(0).Columns
            If item.ToString <> "dvh" And item.ToString <> "baja" And (item.ToString <> "id_" & tabla) Then
                cmbbuscar.Items.Add(item.ToString)
            End If
        Next
    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        Dim seto As New DataSet
        Dim tabla As String = "Rodado"
        Dim i As Integer



        seto = BLL.clsbuscar.buscar_por_campos(tabla, cmbbuscar.Text, txtbuscar.Text)
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            seto.Tables(0).Rows(i).Item(4) = BLL.bllrodado.nombre_marca_rodado(row.ItemArray(4))
            seto.Tables(0).Rows(i).Item(8) = BLL.bllrodado.nombre_tipo_rodado(row.ItemArray(8))

            i = i + 1
        Next
        datagridrodados.DataSource = seto.Tables(0)
        datagridrodados.Columns("id_" & tabla).Visible = False
        datagridrodados.Columns("dvh").Visible = False
    End Sub

    Private Sub frmusuarios_Enter(sender As Object, e As EventArgs) Handles frmusuarios.Enter

    End Sub

    Private Sub RecargarBtn_Click(sender As Object, e As EventArgs) Handles RecargarBtn.Click
        grillaok()

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim pantalla As New altaenvio(_usuario, _idioma)
        Dim row As DataGridViewRow = datagridrodados.CurrentRow()

        Dim value As Object = row.Cells(0).Value
        pantalla.paquetes = paquetes
        pantalla.cliente = cliente
        pantalla.rodado = value.ToString
        pantalla.Show()

        Me.Close()
    End Sub
End Class