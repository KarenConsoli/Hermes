Public Class familias
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
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim pantalla As New inicio1(_usuario, _idioma)
        pantalla.Close()

        Dim pantalla1 As New inicio1(_usuario, _idioma)
        pantalla1.Show()


        Me.Hide()
        
    End Sub

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            MsgBox("El dato ha sido eliminado")
            BLL.clsbuscar.dar_baja(datagridfamilias.CurrentRow.Cells(0).Value, "Familia")
            Dim dv As New BLL.blldv

            Dim bita As New BLL.bllbitacora
            bita.usuario = _usuario
            bita.criticidad = "bajo"
            bita.desc_mov = "Familia Agregada"
            bita.grabar()
            dv.recalcular_dvh("bitacora")
            dv.Recalcular_dvv("bitacora")
            datagridfamilias.Refresh()
            Dim usuario As Integer
            usuario = BLL.bllusuario.id_usuario(_usuario)
            BLL.bllfamilia.negar_familia(usuario, datagridfamilias.CurrentRow.Cells(0).Value)
            dv.recalcular_dvh("usuariofamilia")
            dv.Recalcular_dvv("usuariofamilia")
        Else
            MsgBox("El dato no ha sido Borrado")
        End If
        grillaok()

    End Sub

    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        Dim pantalla As New altafamilia(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Dim row As DataGridViewRow = datagridfamilias.CurrentRow
        Dim modiffamilia As New modiffamilia(_usuario, _idioma)
        Dim value As Object = row.Cells("nombre_familia").Value
        modiffamilia.txtnombre.Text = value.ToString
        value = row.Cells("baja").Value
        If value = "True" Then
            modiffamilia.chkbaja.Checked = True
        End If

        modiffamilia.Show()
        Me.Hide()

    End Sub

    Private Sub familias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Idioma.bllidioma.cambiaridioma(Me, id_idioma)
      
        grillaok()
        cargar_campos()
    End Sub
    Public Sub grillaok()
        Dim tabla As String
        tabla = "Familia"
      
        Dim seto As New DataSet
        Dim i As Integer = 0
        seto = BLL.clsbuscar.actualizargrilla(seto, tabla)
      
        datagridfamilias.DataSource = seto.Tables(0)
        datagridfamilias.Columns("dvh").Visible = False
        datagridfamilias.Columns("id_" & tabla).Visible = False
        datagridfamilias.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub
    Public Sub cargar_campos()
        Dim tabla As String
        tabla = "Familia"
        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_campos(tabla)
        For Each item As DataColumn In seto.Tables(0).Columns
            If item.ToString <> "dvh" And item.ToString <> "baja" And (item.ToString <> "id_" & tabla) Then
                cmbbuscar.Items.Add(item.ToString)
            End If
        Next
    End Sub

    Public Sub buscar_por_campo()
        Dim tabla As String
        tabla = "Familia"
        Dim campo As String = cmbbuscar.Text
        Dim texto As String = txtbuscar.Text
      
        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_por_campos(tabla, campo, texto)
        datagridfamilias.DataSource = seto.Tables(0)

    End Sub
End Class