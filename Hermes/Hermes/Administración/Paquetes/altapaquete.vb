Public Class altapaquete
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
        'Dim pantalla As New cliente_paquete(_usuario, _idioma)

        'pantalla.Show()
        'Me.Hide()
        For Each Con As Control In Me.Controls
            If (TypeOf Con Is TextBox) Then
                If Con.Text = String.Empty Then
                    MsgBox("Debe completar el formulario")
                    Exit Sub

                End If
                If Not Con.Name = "txtnombre" And Not IsNumeric(Con.Text) Then
                    MsgBox("Complete correctamente el formulario")
                    Exit Sub

                End If
                If Con.Name = "txtnombre" And IsNumeric(Con.Text) Then
                    MsgBox("El nombre no puede tener Números")
                    Exit Sub

                End If


            End If

        Next
        Dim seto As New DataSet
        seto = BLL.clsbuscar.actualizargrilla(seto, "Paquete")
        Dim row As DataRow = seto.Tables(0).NewRow
        'tomar valores de los txt
        row.Item(1) = txtcliente.Text
        row.Item(2) = txtnombre.Text
        row.Item(3) = txtdesc.Text
        row.Item(4) = txtpeso.Text
        row.Item(5) = txtvolumen.Text
        row.Item(6) = txtaltura.Text
        row.Item(7) = txtancho.Text
        row.Item(8) = txtbultos.Text
        row.Item(9) = txtprecio.Text
        row.Item(10) = 0
        'agrega nueva fila en primera posicion de primera celda de seto
        seto.Tables(0).Rows.Add(row)

        BLL.clsbuscar.actualizar_datos(seto, "Paquete")
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("Paquete")
        dv.Recalcular_dvv("Paquete")

        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Paquete Agregado"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        Dim pantalla As New paquetes(_usuario, _idioma)
        pantalla.txtcliente.Text = Me.txtcliente.Text
        pantalla.Show()

        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Dim pantalla As New paquetes(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub altapaquete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Idioma.bllidioma.cambiaridioma(Me, _idioma)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class