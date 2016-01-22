Public Class facturas
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
    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        Dim pantalla As New altafactura(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere crear nota de crédito?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            BLL.clsbuscar.dar_baja(datagridfacturas.CurrentRow.Cells(0).Value, "Factura")
            MsgBox("La nota de Crédito ha sido creada")
        Else
            MsgBox("Factura no moficada")
        End If
        grillaok()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere Imprimir?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            imprimir_facturas.Show()

        Else
            MsgBox("No se Imprimió")
        End If
    End Sub

    Private Sub facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grillaok()
        cargar_campos()

        Idioma.bllidioma.cambiaridioma(Me, _idioma)
    End Sub
    Public Sub grillaok()
        Dim tabla As String
        tabla = "Factura"
        Dim seto As New DataSet
        seto = BLL.clsbuscar.actualizargrilla(seto, tabla)
        Dim i As Integer
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(3) = BLL.bllenvios.nombre_cliente(row.ItemArray(3))
            seto.Tables(0).Rows(i).Item(6) = BLL.bllenvios.nombre_pp(row.ItemArray(6))
            seto.Tables(0).Rows(i).Item(7) = BLL.bllenvios.nombre_pl(row.ItemArray(7))
            i = i + 1
        Next

        datagridfacturas.DataSource = seto.Tables(0)
        datagridfacturas.Columns("id_" & tabla).Visible = False
        datagridfacturas.Columns("dvh").Visible = False
        datagridfacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridfacturas.EditMode = DataGridViewEditMode.EditProgrammatically
    End Sub
    Public Sub cargar_campos()
        Dim tabla As String
        tabla = "Factura"
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
End Class