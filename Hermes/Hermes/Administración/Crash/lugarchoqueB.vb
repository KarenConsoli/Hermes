Public Class lugarchoqueB
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
        Dim pantalla As New modifcrash(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Dim pantalla As New modifcrash(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub lugarchoqueB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Idioma.bllidioma.cambiaridioma(Me, _idioma)
    End Sub
End Class