Public Class modifrodado
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

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        For Each Con As Control In Me.Controls
            If (TypeOf Con Is TextBox) Then
                If Not IsNumeric(Con.Text) Then
                    MsgBox("Debe completar correctamente el formulario")
                    Exit Sub

                End If

            End If

        Next
        Dim id_marca As Integer = BLL.bllrodado.id_marca_rodado(cmbmarca.Text)
        Dim id_tipo As Integer = BLL.bllrodado.id_tipo_rodado(cmbtipo.Text)
        Dim seto As New DataSet


        seto = BLL.clsbuscar.buscar_tabla_por_id("Rodado", txtid.Text)
        Dim baja As Integer
        If chkbaja.Checked = True Then
            baja = 1
        Else
            baja = 0
        End If
        Dim row As DataRow = seto.Tables(0).Rows(0)
        'tomar valores de los txt
        If txtid.Text = row.Item(0).ToString Then
            'tomar valores de los txt
            row.Item(1) = encrypta.encriptar(txtdominio.Text)
            row.Item(2) = txtmotor.Text
            row.Item(3) = txtchasis.Text
            row.Item(4) = id_marca
            row.Item(5) = txtmodelo.Text
            row.Item(6) = txtanio.Text
            row.Item(7) = txtcapacidad.Text
            row.Item(8) = id_tipo
            row.Item(9) = 0
        End If


        BLL.clsbuscar.actualizar_datos(seto, "Rodado")
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("Rodado")
        dv.Recalcular_dvv("Rodado")

        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Rodado Editado"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        Dim pantalla As New rodados(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Dim pantalla As New rodados(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub AgregarTelBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub altarodado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Idioma.bllidioma.cambiaridioma(Me, _idioma)

        Dim seto As New DataSet

        seto = BLL.bllrodado.combo_marca_rodado

        For Each row As DataRow In seto.Tables(0).Rows
            cmbmarca.Items.Add(row.ItemArray(0))
        Next

        seto = BLL.bllrodado.combo_tipo_rodado

        For Each row As DataRow In seto.Tables(0).Rows
            cmbtipo.Items.Add(row.ItemArray(0))
        Next
    End Sub
End Class