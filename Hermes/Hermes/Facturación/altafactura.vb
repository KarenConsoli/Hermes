Public Class altafactura
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
    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs)
        Dim pantalla As New facturas(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs)
        Dim pantalla As New facturas(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()

    End Sub
    Public fechallegada As Date
    Public fechapartida As Date
    Private Sub altafactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Idioma.bllidioma.cambiaridioma(Me, _idioma)
    End Sub

    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtpkm.TextChanged
        Dim total_paquetes As Integer
        Dim subtotal As Integer
        For Each row As DataGridViewRow In datagridpaquetes.Rows
            total_paquetes = Convert.ToInt32(row.Cells(2).Value) + total_paquetes

        Next
        subtotal = total_paquetes + (txtkm.Text * txtpkm.Text)
        txtsubtotal.Text = subtotal

        txttotal.Text = ((subtotal * 21) / 100) + subtotal

    End Sub

    Private Sub txtsubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtsubtotal.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pantalla As New envios1(_usuario, _idioma)
        pantalla.Show()
        Me.Close()

    End Sub

    Private Sub AceptarBtn_Click_1(sender As Object, e As EventArgs) Handles AceptarBtn.Click
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

        
            End If

        Next
        Dim seto As New DataSet
        seto = BLL.clsbuscar.actualizargrilla(seto, "Factura")
        Dim row As DataRow = seto.Tables(0).NewRow
        'tomar valores de los txt
        row.Item("Fecha_actual") = txtfecha.Text
        row.Item("Id_transporte") = txttransporte.Text
        row.Item("id_cliente") = BLL.bllenvios.id_cliente(txtcliente.Text)
        row.Item("Id_rodado") = txtrodado.Text
        row.Item("Id_chofer") = txtchofer.Text
        row.Item("Punto_partida") = BLL.bllenvios.id_pp(txtlp.Text)
        row.Item("Punto_llegada") = BLL.bllenvios.id_pl(txtll.Text)
        row.Item("Fecha_salida") = txtfp.Text
        row.Item("Fecha_llegada") = txtfl.Text
        row.Item("km") = txtkm.Text
        row.Item("remito") = txtremito.Text
        row.Item("precioxkm") = txtpkm.Text
        row.Item("St_factura") = txtsubtotal.Text
        row.Item("Iva_factura") = Val(txtiva.Text)
        row.Item("Total_factura") = Convert.ToInt32(txttotal.Text)
        row.Item("baja") = 0

        'agrega nueva fila en primera posicion de primera celda de seto
        seto.Tables(0).Rows.Add(row)

        BLL.clsbuscar.actualizar_datos(seto, "Factura")
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("Factura")
        dv.Recalcular_dvv("Factura")

        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Factura Agregado"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        'Dim op As String
        'op = MessageBox.Show("Desea Imprimir Factura?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'If op = vbYes Then
        '    imprimir_factura.Show()
        '    Exit Sub

        'Else
        '    MsgBox("No se imprimió Factura")
        'End If
        Dim pantallas As New facturas(_usuario, _idioma)
        pantallas.Show()
        Me.Close()


    End Sub
End Class