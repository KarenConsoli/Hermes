
Imports System.Xml
Imports System.Text
Imports System.Text.RegularExpressions


Public Class altaenvio
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
    'Dim transporte As New clstransportes

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim pantalla As New clientes(_usuario, _idioma)
        pantalla.btnok.Visible = True
        Me.Close()

        pantalla.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)






    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        For Each Con As Control In Me.Controls
            If (TypeOf Con Is TextBox) Then


                If Con.Text = String.Empty Then
                    MsgBox("Debe completar el formulario")
                    Exit Sub
                End If
                If Con.Name = "txtusuario" And Con.Text.Length < 5 Or Con.Text.Length > 15 Then
                    MsgBox("El Usuario es muy largo o muy corto")
                    Exit Sub
                End If
                If Con.Name = "txtcontraseña" And Con.Text.Length < 10 Or Con.Text.Length > 15 Then
                    MsgBox("El Usuario es muy largo o muy corto")
                    Exit Sub
                End If
                If Con.Name = "txtnombre" And IsNumeric(Con.Text) Then
                    MsgBox("El nombre no puede tener Números")
                    Exit Sub

                End If

                If Con.Name = "txtapellido" And IsNumeric(Con.Text) Then
                    MsgBox("El nombre no puede tener Números")
                    Exit Sub

                End If
                If Con.Name = "txtident" And Not IsNumeric(Con.Text) Then
                    MsgBox("La identificación no puede tener letras")
                    Exit Sub

                End If
                If Con.Name = "txtremito" And Not IsNumeric(Con.Text) Then
                    MsgBox("El remito no puede tener letras")
                    Exit Sub

                End If
                If Con.Name = "txtkm" And Not IsNumeric(Con.Text) Then
                    MsgBox("La Cantidad de Kilómetros no puede tener letras")
                    Exit Sub

                End If
                Dim Cuit As New Regex("(30|33)[-]([0-9]{8})[-]([0-9]{1})")


                If Con.Name = "txticuit" And Not IsNumeric(Con.Text) Then
                    MsgBox("El CUIT no puede tener letras")
                    Exit Sub

                End If
                If Con.Name = "txtcuit" Or Con.Name = "txtident" And Not Cuit.IsMatch(Con.Text) Then
                    MsgBox("El CUIT no está bien escrito")
                    Exit Sub
                End If
            End If

        Next
        Dim seto As New DataSet
        seto = BLL.clsbuscar.actualizargrilla(seto, "Transportes")
        Dim row As DataRow = seto.Tables(0).NewRow
        'tomar valores de los txt
        row.Item(1) = BLL.bllenvios.id_cliente(txtcliente.Text)
        row.Item(2) = txtrodado.Text
        row.Item(3) = txtchofer.Text
        row.Item(4) = BLL.bllenvios.id_pp(txtlp.Text)
        row.Item(5) = BLL.bllenvios.id_pl(txtll.Text)
        row.Item(6) = txtfp.Text
        row.Item(7) = txtfl.Text
        row.Item(8) = txtkm.Text
        row.Item(9) = txtremito.Text
        row.Item(10) = 0

        'agrega nueva fila en primera posicion de primera celda de seto
        seto.Tables(0).Rows.Add(row)

        BLL.clsbuscar.actualizar_datos(seto, "Transportes")
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("Transportes")
        dv.Recalcular_dvv("Transportes")

        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Transporte Agregado"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")


        For Each item As String In lstpaquetes.Items
            Dim id As Integer = BLL.bllenvios.id_transporte(txtremito.Text)
            seto = BLL.clsbuscar.actualizargrilla(seto, "transporte_paquete")
            row = seto.Tables(0).NewRow
            'tomar valores de los txt
            row.Item(1) = id
            row.Item(2) = Val(item)

            'agrega nueva fila en primera posicion de primera celda de seto
            seto.Tables(0).Rows.Add(row)
            BLL.clsbuscar.actualizar_datos(seto, "transporte_paquete")




            bita.usuario = _usuario
            bita.criticidad = "bajo"
            bita.desc_mov = "Transporte-Paquete Agregado"
            bita.grabar()
            dv.recalcular_dvh("bitacora")
            dv.Recalcular_dvv("bitacora")
        Next
       

        Dim pantalla As New envios1(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Dim pantalla As New envios1(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub
    Public rodado As Integer
    Public chofer As Integer
    Public cliente As String
    Public paquetes As New List(Of String)
    Public ll As String
    Public lp As String
    Private Sub altaenvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idiomas As New Idioma.bllidioma
        Idioma.bllidioma.cambiaridioma(Me, _idioma)

        'Try
        '    Dim archivo As New System.IO.FileStream("r:\xml.xml", IO.FileMode.Open)
        '    Dim formateador As New Serialization.XmlSerializer(transporte.GetType)
        '    transporte = formateador.Deserialize(archivo)
        '    txtcliente.Text = transporte.cliente
        '    txtchofer.Text = transporte.chofer
        '    txtfl.Text = transporte.fl
        '    txtfp.Text = transporte.fp
        '    txtrodado.Text = transporte.rodado
        '    lstpaquetes.Items.Add(transporte.paquete1)
        '    lstpaquetes.Items.Add(transporte.paquete2)
        '    lstpaquetes.Items.Add(transporte.paquete3)
        '    lstpaquetes.Items.Add(transporte.paquete4)
        '    lstpaquetes.Items.Add(transporte.paquete5)
        '    txtll.Text = transporte.ll
        '    txtlp.Text = transporte.lp
        '    archivo.Close()
        'Catch ex As Exception
        '    Exit Sub

        'End Try
        
        txtcliente.Text = cliente
        For Each item As String In paquetes
            lstpaquetes.Items.Add(item)
        Next

        txtrodado.Text = rodado
        txtchofer.Text = chofer
        txtll.Text = ll
        txtlp.Text = lp

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pantalla As New rodados(_usuario, _idioma)


        'transporte.cliente = txtcliente.Text
        paquetes.Clear()

        For Each item As String In lstpaquetes.Items
            paquetes.Add(item)
        Next
        'For i As Integer = 0 To lstpaquetes.Items.Count - 1
        '    If i = 0 Then
        '        transporte.paquete1 = lstpaquetes.Items(i).ToString

        '    End If
        '    If i = 1 Then
        '        transporte.paquete2 = lstpaquetes.Items(i).ToString

        '    End If
        '    If i = 2 Then
        '        transporte.paquete3 = lstpaquetes.Items(i).ToString

        '    End If
        '    If i = 3 Then
        '        transporte.paquete4 = lstpaquetes.Items(i).ToString

        '    End If
        '    If i = 4 Then
        '        transporte.paquete5 = lstpaquetes.Items(i).ToString

        '    End If
        'Next

        pantalla.Show()
        pantalla.cliente = cliente
        pantalla.paquetes = paquetes
        pantalla.btnok.Visible = True
        'Dim altaenvio As New altaenvio(_usuario, _idioma)
        'Dim archivo As New System.IO.FileStream("r:\xml.xml", IO.FileMode.Create)
        'Dim formateador As New Serialization.XmlSerializer(transporte.GetType)
        'formateador.Serialize(archivo, transporte)
        'archivo.Close()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim pantalla As New paquetes(_usuario, _idioma)

        pantalla.txtcliente.Text = BLL.bllenvios.id_cliente(Me.txtcliente.Text)
        pantalla.btnok.Visible = True

        pantalla.Show()
        Me.Close()

    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pantalla As New Choferes1(_usuario, _idioma)

        paquetes.Clear()

        For Each item As String In lstpaquetes.Items
            paquetes.Add(item)
        Next


        pantalla.cliente = cliente
        pantalla.paquetes = paquetes
        pantalla.rodado = rodado

        pantalla.btnok.Visible = True
        pantalla.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pantalla As New lugar_partida(_usuario, _idioma)

        paquetes.Clear()

        For Each item As String In lstpaquetes.Items
            paquetes.Add(item)
        Next


        pantalla.cliente = cliente
        pantalla.paquetes = paquetes
        pantalla.rodado = rodado
        pantalla.chofer = chofer
        pantalla.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pantalla As New lugar_llegada(_usuario, _idioma)

        paquetes.Clear()

        For Each item As String In lstpaquetes.Items
            paquetes.Add(item)
        Next


        pantalla.cliente = cliente
        pantalla.paquetes = paquetes
        pantalla.rodado = rodado
        pantalla.chofer = chofer
        pantalla.lp = lp
        pantalla.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        BLL.bllenvios.buscar_lugarpartida(txtlp.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BLL.bllenvios.buscar_lugarllegada(txtll.Text)
    End Sub
End Class