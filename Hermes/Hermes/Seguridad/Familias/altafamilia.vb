
Public Class altafamilia
    Dim encrypta As New BLL.bllencriptar
    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs)
        Dim pantalla As New familias(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub
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
    Private Sub AceptarBtn_Click_1(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Dim id_familia As Integer
        Dim dv As New BLL.blldv

        id_familia = BLL.bllfamilia.alta_familia(txtnombre.Text)
        dv.recalcular_dvh("Familia")
        dv.Recalcular_dvv("Familia")
        For Each item As Object In datagridusuarios.CheckedItems
            Dim itemcito As Integer
            itemcito = BLL.bllusuario.id_usuario(encrypta.encriptar(item.ToString))
            BLL.bllfamilia.alta_familia_usuario(itemcito, id_familia)
            dv.recalcular_dvh("usuariofamilia")
            dv.Recalcular_dvv("usuariofamilia")
        Next
        For Each item As Object In datagridpatentes.CheckedItems
            Dim itemcito As Integer
            itemcito = Val(item.ToString)
            BLL.bllfamilia.alta_familia_patente(itemcito, id_familia)
            dv.recalcular_dvh("patentefamilia")
            dv.Recalcular_dvv("patentefamilia")
        Next
        'bitácora
        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Familia Agregada"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
  Me.Hide()
        Dim pantalla As New familias(_usuario, _idioma)

        pantalla.Show()


    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Hide()
        Dim pantalla As New familias(_usuario, _idioma)

        pantalla.Show()
    End Sub


    Private Sub altafamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        Idioma.bllidioma.cambiaridioma(Me, id_idioma)
        grillaok()
    End Sub
    Public Sub grillaok()
        Dim seto As New DataSet
        Dim i As Integer
        seto = BLL.clsbuscar.actualizargrilla(seto, "Usuarios")
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
       
            datagridusuarios.Items.Add(seto.Tables(0).Rows(i).Item(1))
            If seto.Tables(0).Rows(i).Item("baja").ToString = "True" Then
                seto.Tables(0).Rows(i).Delete()
            End If
            i = i + 1
        Next
        i = 0
        seto = BLL.clsbuscar.actualizargrilla(seto, "Patentes")
        For Each row As DataRow In seto.Tables(0).Rows
            datagridpatentes.Items.Add(seto.Tables(0).Rows(i).Item(0) & " - " & seto.Tables(0).Rows(i).Item(1))
            i = i + 1
        Next



        datagridusuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        datagridusuarios.Items.Clear()

        Dim seto As New DataSet
        seto = BLL.clsbuscar.actualizargrilla(seto, "Usuarios")
        Dim i As Integer = 0

        For Each fila As DataRow In seto.Tables(0).Rows()
            If seto.Tables(0).Rows(i).Item(1) = encrypta.encriptar(txtusuario.Text) Then
                datagridusuarios.Items.Add(encrypta.desencriptar(fila.ItemArray(1)))
            End If
            i = i + 1
        Next


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        datagridpatentes.Items.Clear()

        Dim seto As New DataSet

        Dim i As Integer = 0


        seto = BLL.clsbuscar.actualizargrilla(seto, "Patentes")
        i = 0
        For Each fila As DataRow In seto.Tables(0).Rows()
            If seto.Tables(0).Rows(i).Item(0) = txtpatente.Text Then
                datagridpatentes.Items.Add(fila.ItemArray(0) & "-" & fila.ItemArray(1))
            End If
            i = i + 1
        Next
    End Sub
End Class