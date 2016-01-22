
Public Class modiffamilia
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

#End Region
    'Constructor
    Sub New(ByVal usuario As String, ByVal idioma As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.usuario = usuario
        Me.id_idioma = idioma

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs)
        Dim pantalla As New familias(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs)
        Dim pantalla As New familias(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub AceptarBtn_Click_1(sender As Object, e As EventArgs)
        Dim pantalla As New familias(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click_1(sender As Object, e As EventArgs)
        Dim pantalla As New familias(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub modiffamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        grillaok()

    End Sub
    Public Sub grillaok()
        Dim id_familia As Integer

        Dim seto As New DataSet

        id_familia = BLL.bllfamilia.id_familia(txtnombre.Text)

        seto = BLL.bllfamilia.familiapatente_nopatente(id_familia)
        For Each row As DataRow In seto.Tables(0).Rows
            datagridnopatentes.Items.Add(row.ItemArray(0) & "-" & row.ItemArray(1))
        Next

        seto = BLL.bllfamilia.familiapatente_patente(id_familia)
        For Each row As DataRow In seto.Tables(0).Rows
            datagridpatentes.Items.Add(row.ItemArray(0) & "-" & row.ItemArray(1))
        Next

        seto = BLL.bllfamilia.familiapatente_nousuarios(id_familia)
        For Each row As DataRow In seto.Tables(0).Rows
            datagridnousuarios.Items.Add(encrypta.desencriptar(row.ItemArray(0)))
        Next

        seto = BLL.bllfamilia.familiapatente_usuarios(id_familia)
        For Each row As DataRow In seto.Tables(0).Rows
            datagridusuarios.Items.Add(encrypta.desencriptar(row.ItemArray(0)))
        Next





    End Sub

    Private Sub AceptarBtn_Click_2(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Dim id_familia As Integer
        Dim dv As New BLL.blldv

        id_familia = BLL.bllfamilia.id_familia(txtnombre.Text)

        For Each item As Object In datagridnousuarios.CheckedItems
            BLL.bllfamilia.familia_nousuarioasignar(id_familia, BLL.bllusuario.id_usuario(encrypta.encriptar(item.ToString)))
            dv.recalcular_dvh("usuariofamilia")
            dv.Recalcular_dvv("usuariofamilia")
            MsgBox("Usuario: " & item.ToString & " Asignado a Familia: " & id_familia)
        Next

        For Each item As Object In datagridusuarios.CheckedItems()
            BLL.bllfamilia.familia_usuarionegar(id_familia, BLL.bllusuario.id_usuario(encrypta.encriptar(item.ToString)))
            dv.recalcular_dvh("usuariofamilia")
            dv.Recalcular_dvv("usuariofamilia")
            MsgBox("Usuario: " & item.ToString & " Eliminado de Familia: " & id_familia)
        Next


        For Each item As Object In datagridnopatentes.CheckedItems
            BLL.bllfamilia.familia_nopatenteasignar(id_familia, Val(item.ToString))
            dv.recalcular_dvh("patentefamilia")
            dv.Recalcular_dvv("patentefamilia")
        Next

        For Each item As Object In datagridpatentes.CheckedItems
            BLL.bllfamilia.familia_patentenegar(id_familia, Val(item.ToString))
            dv.recalcular_dvh("patentefamilia")
            dv.Recalcular_dvv("patentefamilia")
        Next
        'bitácora

        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_tabla_usuario(id_familia)

        Dim row As DataRow = seto.Tables(0).Rows(0)
        'tomar valores de los txt
        Dim baja As Integer
        If chkbaja.Checked = True Then
            baja = 1
        Else
            baja = 0
        End If

        If txtnombre.Text = row.Item(1).ToString Then
            row.Item(3) = baja
        End If

        BLL.clsbuscar.actualizar_datos(seto, "Familia")

        dv.recalcular_dvh("Familia")
        dv.Recalcular_dvv("Familia")

        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Familia Modificada"
        bita.grabar()
        Me.Hide()
        Dim pantalla As New familias(_usuario, _idioma)
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")

        pantalla.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        datagridnousuarios.Items.Clear()

        Dim seto As New DataSet
        seto = BLL.clsbuscar.actualizargrilla(seto, "Usuarios")
        Dim i As Integer = 0

        For Each fila As DataRow In seto.Tables(0).Rows()
            If seto.Tables(0).Rows(i).Item(1) = encrypta.encriptar(txtnousuario.Text) Then
                datagridnousuarios.Items.Add(encrypta.desencriptar(fila.ItemArray(1)))
            End If
            i = i + 1
        Next

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        datagridnousuarios.Items.Clear()

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        datagridnopatentes.Items.Clear()

        Dim seto As New DataSet

        Dim i As Integer = 0


        seto = BLL.clsbuscar.actualizargrilla(seto, "Patentes")
        i = 0
        For Each fila As DataRow In seto.Tables(0).Rows()
            If seto.Tables(0).Rows(i).Item(0) = txtnopatente.Text Then
                datagridnopatentes.Items.Add(fila.ItemArray(0) & "-" & fila.ItemArray(1))
            End If
            i = i + 1
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        grillaok()


    End Sub

    Private Sub CancelarBtn_Click_2(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Hide()
        Dim pantalla As New familias(_usuario, _idioma)

        pantalla.Show()
    End Sub
End Class