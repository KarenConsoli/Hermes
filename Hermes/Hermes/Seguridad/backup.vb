Public Class backup

    Dim destino As String

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
    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click

        Me.Hide()

    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Dim partes As Integer
        partes = partessel.Text
        Dim boolito As Boolean
        Dim cant As New BLL.bllbackup
        cant.partes = partessel.Text
        Try
            boolito = BLL.bllbackup.crear_backup(destino, partes)
            'boolito = BLL.bllbackup.crear_backup(RutaTxt.Text, partes)
            Dim dv As New BLL.blldv
            If boolito = True Then
                'bitácora
                Dim bita As New BLL.bllbitacora
                bita.usuario = _usuario
                bita.criticidad = "bajo"
                bita.desc_mov = "Backup Exitoso"
                bita.grabar()
                dv.recalcular_dvh("bitacora")
                dv.Recalcular_dvv("bitacora")
                MsgBox("Backup Exitoso")
            Else
                'bitácora
                Dim bita As New BLL.bllbitacora
                bita.usuario = _usuario
                bita.criticidad = "Alto"
                bita.desc_mov = "Backup Fallido"

                bita.grabar()
                dv.recalcular_dvh("bitacora")
                dv.Recalcular_dvv("bitacora")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al crear Backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Hide()

    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        FolderBrowserDialog1.Description = "Seleccione donde guardar el Backup"
        FolderBrowserDialog1.ShowDialog()

        destino = FolderBrowserDialog1.SelectedPath.ToString
        RutaTxt.Text = destino


    End Sub

    Private Sub backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
        Idioma.bllidioma.cambiaridioma(Me, id_idioma)
    End Sub

    Private Sub partessel_ValueChanged(sender As Object, e As EventArgs) Handles partessel.ValueChanged

    End Sub

    Private Sub RutaTxt_TextChanged(sender As Object, e As EventArgs) Handles RutaTxt.TextChanged

    End Sub
End Class