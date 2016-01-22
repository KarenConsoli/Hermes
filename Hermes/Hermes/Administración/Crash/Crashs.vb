Public Class Crashs
    Dim var As Integer
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

    Private Sub frmusuarios_Enter(sender As Object, e As EventArgs) Handles frmusuarios.Enter

    End Sub

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            BLL.clsbuscar.dar_baja(datagridcrash.CurrentRow.Cells(0).Value, "Crash")
            MsgBox("El dato ha sido eliminado")
        Else
            MsgBox("El dato no ha sido Borrado")
        End If
        grillaok()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Me.Hide()
    End Sub

    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        Dim pantalla As New altacrash(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Dim pantalla As New modifcrash(_usuario, _idioma)

        Dim row As DataGridViewRow = datagridcrash.CurrentRow()

        Dim value As Object = row.Cells("id_Crash").Value
        pantalla.id = value.ToString
        value = row.Cells("id_transporte").Value
        pantalla.envio = value.ToString
        value = row.Cells("Estado_viaje").Value
        pantalla.estado = value.ToString
        value = row.Cells("Lugar_accidente").Value
        pantalla.lugar = value.ToString
    

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub Crashs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grillaok()
        cargar_campos()

        Idioma.bllidioma.cambiaridioma(Me, _idioma)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere Imprimir?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            imprimir_crashs.Show()
            Exit Sub

        Else
            MsgBox("No se Imprimió")
        End If
    End Sub
    Public Sub grillaok()
        Dim tabla As String
        tabla = "Crash"
        Dim seto As New DataSet

        seto = BLL.clsbuscar.actualizargrilla(seto, tabla)



        Dim i As Integer
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(3) = encrypta.desencriptar(row.ItemArray(3))
            seto.Tables(0).Rows(i).Item(4) = BLL.bllcrash.nombre_lugar(row.ItemArray(4))
            seto.Tables(0).Rows(i).Item(5) = BLL.bllcrash.nombre_tipo_choque(row.ItemArray(5))
            i = i + 1
        Next
        datagridcrash.DataSource = seto.Tables(0)
        datagridcrash.Columns("id_" & tabla).Visible = False
        datagridcrash.Columns("dvh").Visible = False

        datagridcrash.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridcrash.EditMode = DataGridViewEditMode.EditProgrammatically


    End Sub
    Public Sub cargar_campos()
        Dim tabla As String
        tabla = "Crash"
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
        seto = BLL.clsbuscar.buscar_por_campos("Crash", cmbbuscar.Text, txtbuscar.Text)
        Dim i As Integer

        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(3) = encrypta.desencriptar(row.ItemArray(3))
            seto.Tables(0).Rows(i).Item(4) = BLL.bllcrash.nombre_lugar(row.ItemArray(4))
            seto.Tables(0).Rows(i).Item(5) = BLL.bllcrash.nombre_tipo_choque(row.ItemArray(5))
            i = i + 1
        Next
        datagridcrash.DataSource = seto.Tables(0)
        datagridcrash.Columns("id_Crash").Visible = False
        datagridcrash.Columns("dvh").Visible = False

    End Sub
End Class