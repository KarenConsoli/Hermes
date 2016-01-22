Public Class lugarchoqueA
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
    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Dim seto As New DataSet
        seto = BLL.clsbuscar.actualizargrilla(seto, "crash_lugarchoque")
        Dim row As DataRow = seto.Tables(0).NewRow
        'tomar valores de los txt
        row.Item(1) = txtnombre.Text
        row.Item(2) = BLL.blldomicilio.id_pais(cmbpais.Text)
        row.Item(3) = BLL.blldomicilio.id_provincia(cmbprovincia.Text)
        row.Item(4) = txtcp.Text
        row.Item(5) = txtdir.Text
        'agrega nueva fila en primera posicion de primera celda de seto
        seto.Tables(0).Rows.Add(row)

        BLL.clsbuscar.actualizar_datos(seto, "crash_lugarchoque")
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("crash_lugarchoque")
        dv.Recalcular_dvv("crash_lugarchoque")

        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Lugar Choque Agregado"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")

        Dim pantalla As New altacrash(_usuario, _idioma)
        pantalla.envio = envio
        pantalla.estado = estado
        pantalla.lugar = txtnombre.text

        pantalla.Show()
        Me.Hide()

    End Sub
    Public envio As Integer
    Public estado As String

    Private Sub lugarchoqueA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        Idioma.bllidioma.cambiaridioma(Me, _idioma)
        Dim seto As New DataSet
        seto = BLL.blldomicilio.paises
        For Each row As DataRow In seto.Tables(0).Rows
            cmbpais.Items.Add(row.ItemArray(0))
        Next
    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Dim pantalla As New altacrash(_usuario, _idioma)

        pantalla.Show()
    End Sub

    Private Sub cp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbprovincia.SelectedIndexChanged

    End Sub

    Private Sub cmbpais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpais.SelectedIndexChanged
        Dim seto As New DataSet
        seto = BLL.blldomicilio.provincia(cmbpais.Text)
        For Each row As DataRow In seto.Tables(0).Rows
            cmbprovincia.Items.Add(row.ItemArray(0))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim seto As New DataSet
        Dim provincia As Integer = BLL.blldomicilio.id_provincia(cmbprovincia.Text)
        seto = BLL.blldomicilio.localildad(Val(txtcp.Text), provincia)
        For Each row As DataRow In seto.Tables(0).Rows
            cmblocalidad.Items.Add(row.ItemArray(0))
        Next
    End Sub
End Class