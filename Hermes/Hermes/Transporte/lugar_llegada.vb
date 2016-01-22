Public Class lugar_llegada
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
    Private Sub lugar_partida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim seto As New DataSet
        seto = BLL.blldomicilio.paises
        For Each row As DataRow In seto.Tables(0).Rows
            cmbpais.Items.Add(row.ItemArray(0))
        Next

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
    Public rodado As Integer
    Public chofer As Integer
    Public cliente As String
    Public lp As String
    Public paquetes As New List(Of String)
    Private Sub DomicilioGB_Enter(sender As Object, e As EventArgs) Handles DomicilioGB.Enter

    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click

        Dim seto As New DataSet
        seto = BLL.clsbuscar.actualizargrilla(seto, "punto_llegada")
        Dim row As DataRow = seto.Tables(0).NewRow
        'tomar valores de los txt
        row.Item(1) = txtnombre.Text
        row.Item(2) = BLL.blldomicilio.id_pais(cmbpais.Text)
        row.Item(3) = BLL.blldomicilio.id_provincia(cmbprovincia.Text)
        row.Item(4) = txtcp.Text
        row.Item(5) = txtdir.Text
        'agrega nueva fila en primera posicion de primera celda de seto
        seto.Tables(0).Rows.Add(row)

        BLL.clsbuscar.actualizar_datos(seto, "punto_llegada")
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("punto_llegada")
        dv.Recalcular_dvv("punto_llegada")

        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Lugar Llegada Agregado"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        Dim pantalla As New altaenvio(_usuario, _idioma)
        pantalla.cliente = cliente
        pantalla.paquetes = paquetes
        pantalla.chofer = chofer
        pantalla.rodado = rodado
        pantalla.lp = lp
        pantalla.ll = txtnombre.Text

        pantalla.Show()

        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class