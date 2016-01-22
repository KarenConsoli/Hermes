Public Class restore2

    Dim destino As New List(Of String)
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
    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Dim boolito As Boolean

        Dim dv As New BLL.blldv
        Dim partes As Integer
        Dim cant As New BLL.bllbackup
        partes = cant.partes
        'If partes < destino.Count - 1 Then
        '    MsgBox("Seleccione todas las partes del Backup")
        '    Exit Sub

        'End If
        Try
            boolito = BLL.bllbackup.ejecutar_restore(destino)
            MsgBox("Restore Exitoso")
        Catch ex As Exception

        End Try

        Dim bita As New BLL.bllbitacora
        If boolito = True Then
            bita.usuario = _usuario
            bita.criticidad = "bajo"
            bita.desc_mov = "Restore Exitoso"
            bita.grabar()
            dv.recalcular_dvh("bitacora")
            dv.Recalcular_dvv("bitacora")
        Else
            bita.usuario = _usuario
            bita.criticidad = "Alto"
            bita.desc_mov = "Restore Fallido"
            bita.grabar()
            dv.recalcular_dvh("bitacora")
            dv.Recalcular_dvv("bitacora")
        End If




    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click

        Me.Hide()

    End Sub

    Private Sub restore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        Idioma.bllidioma.cambiaridioma(Me, _idioma)
    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        OpenFileDialog1.Title = "Seleccionar Backup"
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.ShowDialog()

        For Each filename As String In OpenFileDialog1.FileNames
            destino.Add(filename)
        Next



    End Sub

    Private Sub RutaTxt_TextChanged(sender As Object, e As EventArgs) Handles RutaTxt.TextChanged

    End Sub
End Class