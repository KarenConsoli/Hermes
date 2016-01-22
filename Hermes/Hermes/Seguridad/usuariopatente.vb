Imports BLL

Public Class usuariopatente
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

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        checknoasig.Items.Clear()
        checkasig.Items.Clear()
        checkneg.Items.Clear()

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

    Private Sub usuariopatente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Idioma.bllidioma.cambiaridioma(Me, id_idioma)


    End Sub
    Public Sub grillaok()

        'Patentes Negadas Cargadas para Asignar o Des-Negar

        Dim patentes_negadas As New DataSet
        patentes_negadas = BLL.bllpatentes.patentes_negadas(id_usuario)

        For Each fila As DataRow In patentes_negadas.Tables(0).Rows()
            checkneg.Items.Add(fila.ItemArray(0) & "-" & fila.ItemArray(1))
        Next


        'Patentes NO Asignadas que NO son partes de la Familia
        Dim patentes_sin_asignar As New DataSet
        Dim familias_usuario As New DataSet
        familias_usuario = BLL.bllfamilia.familias_de_usuario(id_usuario)


        ' genera variable id_familia para poder cargar los diferentes id´s y asi cargar las patentes
        Dim id_familia As New List(Of String)
        For Each fila As DataRow In familias_usuario.Tables(0).Rows()
            id_familia.Add(fila.ItemArray(0))
        Next
        patentes_sin_asignar = BLL.bllfamilia.patentes_nofamilia(id_familia, id_usuario)

        For Each filita As DataRow In patentes_sin_asignar.Tables(0).Rows()
            checknoasig.Items.Add(filita.ItemArray(0) & "-" & filita.ItemArray(1))

        Next


        'Dim patentes_activadas As New DataSet
        'patentes_activadas = BLL.bllpatentes.patentes_activadas(id_usuario)

        'For Each fila As DataRow In patentes_activadas.Tables(0).Rows()
        '    datagridnegar.Items.Add(fila.ItemArray(0) & "-" & fila.ItemArray(1))
        'Next


        'Patentes Que son parte de la familia
        id_familia.Clear()

        Dim patentes_asignadas As New DataSet
        For Each fila As DataRow In familias_usuario.Tables(0).Rows()
            id_familia.Add(fila.ItemArray(0))
        Next

        patentes_asignadas = BLL.bllfamilia.patentes_dentro_usuariofamilia(id_familia, id_usuario)

        For Each filita As DataRow In patentes_asignadas.Tables(0).Rows()
            checkasig.Items.Add(filita.ItemArray(0) & "-" & filita.ItemArray(1))

        Next






    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Dim pantalla As New usuarios(_usuario, _idioma)
        pantalla.Show()

        Me.Hide()

    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        'Dim dv As New BLL.blldv


        'For Each item As Object In checknoasig.CheckedItems
        '    Dim itemcito As Integer
        '    itemcito = Val(item.ToString)
        '    BLL.bllpatentes.asignar_patente_usuario(itemcito, id_usuario)
        '    dv.recalcular_dvh("usuariopatente")
        '    dv.Recalcular_dvv("usuariopatente")
        'Next

        'For Each item As Object In checkneg.CheckedItems()
        '    Dim itemcito As Integer
        '    itemcito = Val(item.ToString)
        '    BLL.bllpatentes.desnegar_patente(itemcito, id_usuario)
        '    dv.recalcular_dvh("usuariopatente")
        '    dv.Recalcular_dvv("usuariopatente")
        'Next

        'For Each item As Object In checkneg.CheckedItems()
        '    Dim itemcito As Integer
        '    itemcito = Val(item.ToString)
        '    BLL.bllpatentes.asignar_patente_neg_usuario(itemcito, id_usuario)
        '    dv.recalcular_dvh("usuariopatente")
        '    dv.Recalcular_dvv("usuariopatente")
        'Next

        'For Each item As Object In checkasig.CheckedItems()
        '    Dim itemcito As Integer
        '    itemcito = Val(item.ToString)

        '    If itemcito = "610" Or itemcito = "620" Then
        '        Dim esenciales As DataSet
        '        esenciales = BLL.bllpatentes.usuarios_patentes_esenciales
        '        For i As Integer = 0 To esenciales.Tables(0).Rows.Count - 1
        '            MsgBox(esenciales.Tables(0).Rows(i).Item(0) & id_usuario)
        '            If esenciales.Tables(0).Rows(i).Item(0) = id_usuario And esenciales.Tables(0).Rows.Count - 1 = 1 Then
        '                MsgBox("No se puede eliminar. Último Usuario con Patentes Esenciales")
        '                Exit Sub
        '            End If

        '        Next

        '    End If
        '    BLL.bllpatentes.neg_patente_usuario(itemcito, id_usuario)
        '    dv.recalcular_dvh("usuariopatente")
        '    dv.Recalcular_dvv("usuariopatente")
        'Next

        checknoasig.Items.Clear()
        checkasig.Items.Clear()
        checkneg.Items.Clear()
        txtusuario.Text = ""

        Dim dv As New BLL.blldv
        'Bitácora
        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Patentes Cambiadas"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        Me.Hide()
        Dim usuarios As New usuarios(_usuario, _idioma)
        usuarios.Show()

    End Sub

    Private Sub cmbbuscar_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DenPatentesGB_Enter(sender As Object, e As EventArgs) Handles DenPatentesGB.Enter

    End Sub

    Private Sub PanelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles PanelSuperior.Paint

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub datagridasignar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles checknoasig.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dv As New blldv

        For Each item As Object In checknoasig.CheckedItems()
            Dim itemcito As Integer
            itemcito = Val(item.ToString)

            If itemcito = "610" Or itemcito = "620" Then
                Dim esenciales As DataSet
                esenciales = BLL.bllpatentes.usuarios_patentes_esenciales
                For i As Integer = 0 To esenciales.Tables(0).Rows.Count - 1
                    MsgBox(esenciales.Tables(0).Rows(i).Item(0) & id_usuario)
                    If esenciales.Tables(0).Rows(i).Item(0) = id_usuario And esenciales.Tables(0).Rows.Count - 1 = 1 Then
                        MsgBox("No se puede eliminar. Último Usuario con Patentes Esenciales")
                        Exit Sub
                    End If

                Next

            End If
            BLL.bllpatentes.neg_patente_usuario(itemcito, id_usuario)
          
        Next
        dv.recalcular_dvh("usuariopatente")
        dv.Recalcular_dvv("usuariopatente")
        checknoasig.Items.Clear()
        checkasig.Items.Clear()
        checkneg.Items.Clear()
        grillaok()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dv As New BLL.blldv


        For Each item As Object In checknoasig.CheckedItems
            Dim itemcito As Integer
            itemcito = Val(item.ToString)
            BLL.bllpatentes.asignar_patente_usuario(itemcito, id_usuario)
            dv.recalcular_dvh("usuariopatente")
            dv.Recalcular_dvv("usuariopatente")
        Next
        checknoasig.Items.Clear()
        checkasig.Items.Clear()
        checkneg.Items.Clear()
        grillaok()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dv As New blldv

        For Each item As Object In checkneg.CheckedItems()
            Dim itemcito As Integer
            itemcito = Val(item.ToString)
            BLL.bllpatentes.desnegar_patente(itemcito, id_usuario)
            dv.recalcular_dvh("usuariopatente")
            dv.Recalcular_dvv("usuariopatente")
        Next
        checknoasig.Items.Clear()
        checkasig.Items.Clear()
        checkneg.Items.Clear()
        grillaok()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dv As New BLL.blldv


        For Each item As Object In checkneg.CheckedItems
            Dim itemcito As Integer
            itemcito = Val(item.ToString)
            BLL.bllpatentes.asignar_patente_usuario(itemcito, id_usuario)
            dv.recalcular_dvh("usuariopatente")
            dv.Recalcular_dvv("usuariopatente")
        Next
        checknoasig.Items.Clear()
        checkasig.Items.Clear()
        checkneg.Items.Clear()
        grillaok()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dv As New blldv

        For Each item As Object In checkasig.CheckedItems()
            Dim itemcito As Integer
            itemcito = Val(item.ToString)

            If itemcito = "610" Or itemcito = "620" Then
                Dim esenciales As DataSet
                esenciales = BLL.bllpatentes.usuarios_patentes_esenciales
                For i As Integer = 0 To esenciales.Tables(0).Rows.Count - 1
                    MsgBox(esenciales.Tables(0).Rows(i).Item(0) & id_usuario)
                    If esenciales.Tables(0).Rows(i).Item(0) = id_usuario And esenciales.Tables(0).Rows.Count - 1 = 1 Then
                        MsgBox("No se puede eliminar. Último Usuario con Patentes Esenciales")
                        Exit Sub
                    End If

                Next

            End If
            BLL.bllpatentes.neg_patente_usuario(itemcito, id_usuario)
            dv.recalcular_dvh("usuariopatente")
            dv.Recalcular_dvv("usuariopatente")
        Next
        checknoasig.Items.Clear()
        checkasig.Items.Clear()
        checkneg.Items.Clear()
        grillaok()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dv As New BLL.blldv


        For Each item As Object In checkasig.CheckedItems
            Dim itemcito As Integer
            itemcito = Val(item.ToString)
            BLL.bllpatentes.desasignar_patente_usuario(itemcito, id_usuario)
            dv.recalcular_dvh("usuariopatente")
            dv.Recalcular_dvv("usuariopatente")
        Next
        checknoasig.Items.Clear()
        checkasig.Items.Clear()
        checkneg.Items.Clear()
        grillaok()
    
    End Sub

End Class