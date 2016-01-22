Imports BLL.bllfamilia
Imports BLL.bllencriptar

Public Class usuariofamilia
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
    Dim encrypta As New BLL.bllencriptar


    Private Sub UsuarioLbl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles PanelSuperior.Paint

    End Sub

    Private Sub usuariofamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        Idioma.bllidioma.cambiaridioma(Me, _idioma)

    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        datagridfamilia.Items.Clear()

        Try
            Dim seto As New DataSet
            Dim cifrado As String
            Dim usuario As String
            cifrado = encrypta.encriptar(txtusuario.Text)
            usuario = cifrado.ToString
            seto = BLL.clsbuscar.buscar_usuario(usuario)
            id_usuario = seto.Tables(0).Rows(0).Item(1)

            grillaok()
        Catch ex As Exception
            MsgBox("Usuario NO Existe")
        End Try
    End Sub
    Public Sub grillaok()
        datagridfamiliaasig.Items.Clear()
        datagridfamilia.Items.Clear()

        Dim nofamilias_usuario As New DataSet
        nofamilias_usuario = BLL.bllfamilia.nofamilias_de_usuario(id_usuario)
        For Each fila As DataRow In nofamilias_usuario.Tables(0).Rows
            datagridfamilia.Items.Add(fila.ItemArray(0) & "-" & fila.ItemArray(1))
        Next

        Dim familias_usuario As New DataSet
        familias_usuario = BLL.bllfamilia.nombre_familias_de_usuario(id_usuario)
        For Each fila As DataRow In familias_usuario.Tables(0).Rows
            datagridfamiliaasig.Items.Add(fila.ItemArray(0) & "-" & fila.ItemArray(1))
        Next

    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Dim dv As New BLL.blldv
      
        For Each item As Object In datagridfamilia.CheckedItems
            Dim itemcito As Integer
            itemcito = Val(item.ToString)
            BLL.bllfamilia.asignar_familia(id_usuario, itemcito)
            dv.recalcular_dvh("usuariofamilia")
            dv.Recalcular_dvv("usuariofamilia")
        Next
        For Each item As Object In datagridfamiliaasig.CheckedItems
            Dim itemcito As Integer
            itemcito = Val(item.ToString)
            BLL.bllfamilia.negar_familia(id_usuario, itemcito)
            dv.recalcular_dvh("usuariofamilia")
            dv.Recalcular_dvv("usuariofamilia")
        Next
        datagridfamiliaasig.Items.Clear()
        datagridfamilia.Items.Clear()
        txtusuario.Text = ""
        Me.Hide()
        Dim pantalla As New usuarios(_usuario, _idioma)
        'Bitácora
        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Familias Cambiadas"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        pantalla.Show()
    End Sub

    Private Sub datagridfamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles datagridfamilia.SelectedIndexChanged

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Dim pantalla As New usuarios(_usuario, _idioma)
        pantalla.Show()

        Me.Hide()

    End Sub
End Class