Public Class altacrash
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
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BLL.bllcrash.buscar_lugarllegada(txtlugar.Text)


        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        If IsNumeric(txtestado.Text) Then
            MsgBox("El estado no puede tener letras")
            Exit Sub

        End If
        Dim seto As New DataSet
        seto = BLL.clsbuscar.actualizargrilla(seto, "Crash")
        Dim row As DataRow = seto.Tables(0).NewRow
        'tomar valores de los txt
        row.Item("Fecha_accidente") = txtfecha.Text
        row.Item("Id_transporte") = txtenvio.Text
        row.Item("Estado_viaje") = encrypta.encriptar(txtestado.Text)
        row.Item("Lugar_accidente") = BLL.bllcrash.id_lugar(txtlugar.Text)
        row.Item("Tipo_choque") = BLL.bllcrash.id_tipo_choque(cmbtipo.Text)
        row.Item("baja") = 0

        'agrega nueva fila en primera posicion de primera celda de seto
        seto.Tables(0).Rows.Add(row)

        BLL.clsbuscar.actualizar_datos(seto, "Crash")
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("Crash")
        dv.Recalcular_dvv("Crash")

        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Crash Agregado"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")

        Dim pantalla As New Crashs(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Dim pantalla As New Crashs(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub
    Public envio As Integer
    Public estado As String
    Public lugar As String


    Private Sub altacrash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Idioma.bllidioma.cambiaridioma(Me, _idioma)
        Dim seto As New DataSet
        seto = BLL.bllcrash.combo_tipo_crash
        For Each row As DataRow In seto.Tables(0).Rows
            cmbtipo.Items.Add(row.ItemArray(0))
        Next
        txtenvio.Text = envio
        txtestado.Text = estado
        txtlugar.Text = lugar


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pantalla As New envios1(_usuario, _idioma)
        pantalla.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        estado = txtestado.Text

        Dim pantalla As New lugarchoqueA(_usuario, _idioma)
        pantalla.estado = estado
        pantalla.envio = envio
        pantalla.Show()
        Me.Hide()
    End Sub
End Class