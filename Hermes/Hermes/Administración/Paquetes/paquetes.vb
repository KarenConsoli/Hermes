Public Class paquetes
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
    Private Sub paquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grillaok()
        cargar_campos()

    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Dim pantalla As New modifpaquete(_usuario, _idioma)

        Dim row As DataGridViewRow = datagridpaquetes.CurrentRow()
        Dim value As Object = row.Cells("Id_Paquete").Value
        pantalla.txtid.Text = value.ToString
        value = row.Cells("id_cliente").Value
        pantalla.txtcliente.Text = value.ToString
        value = row.Cells("nombre_paquete").Value
        pantalla.txtnombre.Text = value.ToString
        value = row.Cells("Desc_paquete").Value
        pantalla.txtdesc.Text = value.ToString
        value = row.Cells("Peso_paquete").Value
        pantalla.txtpeso.Text = value.ToString
        value = row.Cells("Volumen_paquete").Value
        pantalla.txtvolumen.Text = value.ToString
        value = row.Cells("Altura_paquete").Value
        pantalla.txtaltura.Text = value.ToString
        value = row.Cells("Ancho_paquete").Value
        pantalla.txtancho.Text = value.ToString
        value = row.Cells("Bulto_paquete").Value
        pantalla.txtbultos.Text = value.ToString
        value = row.Cells("precio").Value
        pantalla.txtprecio.Text = value.ToString

        value = row.Cells("baja").Value
        If value = "True" Then
            pantalla.chkbaja.Checked = True
        End If


        pantalla.Show()
        Me.Hide()

    End Sub
    Public cliente As String
    Public paquetes As List(Of String)
    Public chofer As Integer
    Public rodado As Integer
    Public lp As String
    Public ll As String
    Public remito As Integer
    Public id As Integer
    Public km As Integer


    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        Dim pantalla As New altapaquete(_usuario, _idioma)
        pantalla.txtcliente.Text = Me.txtcliente.Text
       
        pantalla.Show()
        Me.Hide()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Me.Hide()
    End Sub

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            BLL.clsbuscar.dar_baja(datagridpaquetes.CurrentRow.Cells(0).Value, "Paquete")
            MsgBox("El dato ha sido eliminado")

        Else
            MsgBox("El dato no ha sido Borrado")
        End If
        grillaok()

    End Sub
    Public Sub grillaok()
        Dim tabla As String
        tabla = "Paquete"
        Dim seto As New DataSet
        Dim i As Integer
        seto = BLL.clsbuscar.buscar_por_campos(tabla, lblcliente.Text, txtcliente.Text)

        datagridpaquetes.DataSource = seto.Tables(0)
        datagridpaquetes.Columns("id_" & tabla).Visible = False
        datagridpaquetes.Columns("dvh").Visible = False

        datagridpaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridpaquetes.EditMode = DataGridViewEditMode.EditProgrammatically


    End Sub
    Public Sub cargar_campos()
        Dim tabla As String
        tabla = "Paquete"
        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_campos(tabla)
        For Each item As DataColumn In seto.Tables(0).Columns
            If item.ToString <> "dvh" And item.ToString <> "baja" And (item.ToString <> "id_" & tabla) Then
                cmbbuscar.Items.Add(item.ToString)
            End If
        Next
    End Sub

    Private Sub RecargarBtn_Click(sender As Object, e As EventArgs) Handles RecargarBtn.Click
        grillaok()

    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        Dim seto As New DataSet
        Dim tabla As String = "Paquete"




        seto = BLL.clsbuscar.buscar_por_campos(tabla, cmbbuscar.Text, txtbuscar.Text)
        datagridpaquetes.DataSource = seto.Tables(0)
        datagridpaquetes.Columns("id_" & tabla).Visible = False
        datagridpaquetes.Columns("dvh").Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Me.btnok.Visible = False

        Dim pantalla As New altaenvio(_usuario, _idioma)
        For Each row As DataGridViewRow In datagridpaquetes.Rows
            If row.Cells(0).Selected = True Then
                pantalla.paquetes.Add(row.Cells(0).Value & "-" & row.Cells(2).Value)
            End If
        Next
        pantalla.cliente = BLL.bllenvios.nombre_cliente(Me.txtcliente.Text)
        pantalla.Show()
        Me.Close()

    End Sub

    Private Sub frmusuarios_Enter(sender As Object, e As EventArgs) Handles frmusuarios.Enter

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim pantalla As New modifenvio(_usuario, _idioma)
        For Each row As DataGridViewRow In datagridpaquetes.Rows
            If row.Cells(0).Selected = True Then
                pantalla.paquetes.Add(row.Cells(0).Value & "-" & row.Cells(2).Value)
            End If
        Next
        pantalla.cliente = BLL.bllenvios.nombre_cliente(Me.txtcliente.Text)
        pantalla.chofer = chofer
        pantalla.rodado = rodado
        pantalla.lp = lp
        pantalla.ll = ll
        pantalla.remito = remito
        pantalla.km = km
        pantalla.id = id

        pantalla.Show()
        Me.Close()
    End Sub

    Private Sub OperacionGB_Enter(sender As Object, e As EventArgs) Handles OperacionGB.Enter

    End Sub
End Class