Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text.RegularExpressions



Public Class altacliente
#Region "Propiedades"
    Dim encrypta As New BLL.bllencriptar

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
       

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Elija un Identificador")
            txtident.Focus()

            Exit Sub

        End If
        If IsNumeric(txtnombre.Text) Then
            MsgBox("Ingrese Nombre y Apellido Correcto")
            txtnombre.Focus()
            Exit Sub
        End If
        Dim id_pais As Integer
        Dim id_provincia As Integer
        id_pais = BLL.blldomicilio.id_pais(cmbpais.Text)
        id_provincia = BLL.blldomicilio.id_provincia(cmbprovincia.Text)
       
    

        Dim seto As New DataSet
        seto = BLL.clsbuscar.actualizargrilla(seto, "Clientes")
        Dim row As DataRow = seto.Tables(0).NewRow
        'tomar valores de los txt
        row.Item(1) = encrypta.encriptar(txtident.Text)
        row.Item(2) = txtnombre.Text
        row.Item(3) = txtfecha.Text
        row.Item(4) = id_pais
        row.Item(5) = id_provincia
        row.Item(6) = txtcp.Text
        row.Item(7) = txtdir.Text
        'agrega nueva fila en primera posicion de primera celda de seto
        seto.Tables(0).Rows.Add(row)

        BLL.clsbuscar.actualizar_datos(seto, "Clientes")
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("Clientes")
        dv.Recalcular_dvv("Clientes")
        Dim id_cliente As Integer
        id_cliente = BLL.clsbuscar.buscar_cliente(txtnombre.Text)
        seto = BLL.clsbuscar.actualizargrilla(seto, "cliente_tel")
        For Each fila As DataGridViewRow In datagridtels.Rows
            Dim rowito As DataRow = seto.Tables(0).NewRow
            rowito.Item(1) = id_cliente
            If fila.Cells(0).Value > 0 Then
                rowito.Item(2) = fila.Cells(0).Value
                seto.Tables(0).Rows.Add(rowito)
                BLL.clsbuscar.actualizar_datos(seto, "cliente_tel")

            End If

        Next

        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Cliente Agregado"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
        'Dim op As String
        'op = MessageBox.Show("¿Desea Imprimir Nuevo usuario?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'If op = vbYes Then

        '    Dim tabla As String = "Clientes"
        '    seto = BLL.clsbuscar.ultimo_registro(tabla)
        '    Dim nuevo As New DataGridView
        '    nuevo.DataSource = seto.Tables(0)
        '    Dim ruta As String



        '    If nuevo.RowCount = 0 Then Return


        '    Application.DoEvents()

        '    nuevo.Name = "Impresion"
        '    Dim linea As String = String.Empty
        '    'Número de última columna
        '    Dim z As Integer = nuevo.ColumnCount - 1
        '    Dim x As Integer
        '    'Imprimir nombres de las columnas






        '    ruta = "r:\impresion" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
        '    'ruta = Application.StartupPath & "\impresion  " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
        '    If File.Exists(ruta) Then
        '        File.Delete(ruta)
        '    End If

        '    ExportToExcel(nuevo, ruta)



        '    Process.Start("r:\impresion" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls")


        'Else

        'End If
        Dim clientes As New clientes(_usuario, _idioma)
        clientes.Show()
        Me.Hide()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Dim clientes As New clientes(_usuario, _idioma)
        clientes.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Dim pantalla As New cliente_paquete(_usuario, _idioma)

        'pantalla.Show()
        'Me.Hide()

    End Sub

    Private Sub altacliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Idioma.bllidioma.cambiaridioma(Me, _idioma)
        Dim seto As New DataSet

        seto = BLL.blldomicilio.paises
        For Each row As DataRow In seto.Tables(0).Rows
            cmbpais.Items.Add(row.ItemArray(0))
        Next

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim seto As New DataSet
        Dim provincia As Integer = BLL.blldomicilio.id_provincia(cmbprovincia.Text)
        seto = BLL.blldomicilio.localildad(Val(txtcp.Text), provincia)
        For Each row As DataRow In seto.Tables(0).Rows
            cmblocalidad.Items.Add(row.ItemArray(0))
        Next
    End Sub

    Private Sub AgregarTelBtn_Click(sender As Object, e As EventArgs) Handles AgregarTelBtn.Click
        If Not IsNumeric(txtnumero.Text) Then
            MsgBox("Ingrese bien el número de teléfono")
            Exit Sub
        End If
        datagridtels.Rows.Add(txtnumero.Text)
        txtnumero.Clear()
    End Sub

    Private Sub UsuarioGB_Enter(sender As Object, e As EventArgs) Handles UsuarioGB.Enter
        Dim fecha As DateTime = DateTime.Now
        txtfecha.Text = fecha.ToString

    End Sub
    Private Sub ExportToExcel(ByVal DGV As DataGridView, ByVal ruta As String)
        Dim fs As New StreamWriter(ruta, False)
        With fs
            .WriteLine("<?xml version=""1.0""?>")
            .WriteLine("<?mso-application progid=""Excel.Sheet""?>")
            .WriteLine("<Workbook xmlns=""urn:schemas-microsoft-com:office:spreadsheet"">")

            .WriteLine("    <Styles>")
            .WriteLine("        <Style ss:ID=""hdr"">")
            .WriteLine("            <Alignment ss:Horizontal=""Center""/>")
            .WriteLine("            <Borders>")
            .WriteLine("                <Border ss:Position=""Left"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Right"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Top"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("            </Borders>")
            .WriteLine("            <Font ss:FontName=""Calibri"" ss:Size=""11"" ss:Bold=""1""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("        <Style ss:ID=""ksg"">")
            .WriteLine("            <Alignment ss:Vertical=""Bottom""/>")
            .WriteLine("            <Borders/>")
            .WriteLine("            <Font ss:FontName=""Calibri""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("        <Style ss:ID=""isi"">")
            .WriteLine("            <Borders>")
            .WriteLine("                <Border ss:Position=""Bottom"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Left"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Right"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Top"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("            </Borders>")
            .WriteLine("            <Font ss:FontName=""Calibri"" ss:Size=""10""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("        <Style ss:ID=""s63"">")
            .WriteLine("                <Alignment ss:Horizontal=""Center"" ss:Vertical=""Bottom""/>")
            .WriteLine("                <NumberFormat ss:Format=""General Date""/>")
            .WriteLine("        </Style>")
            .WriteLine("        <Style ss:ID=""s91"">")
            .WriteLine("                <Alignment ss:Horizontal=""Center"" ss:Vertical=""Bottom""/>")
            .WriteLine("                <Font ss:FontName=""Arial"" ss:Size=""16"" ss:Color=""#000000"" ss:Bold=""1"" ss:Italic=""1""/>")
            .WriteLine("        </Style>")
            .WriteLine("        <Style ss:ID=""s95"">")
            .WriteLine("                <Alignment ss:Horizontal=""Center"" ss:Vertical=""Bottom""/>")
            .WriteLine("                <Font ss:FontName=""Arial"" ss:Size=""26"" ss:Color=""#000000"" ss:Bold=""1"" ss:Italic=""1""/>")
            .WriteLine("        </Style>")
            .WriteLine("    </Styles>")
            If DGV.Name = "Impresion" Then
                .WriteLine("    <Worksheet ss:Name=""Impresion"">") 'SET NAMA SHEET
                .WriteLine("        <Table>")

                For Each column As DataGridViewColumn In DGV.Columns

                    .WriteLine("            <Column ss:Width=""100""/>") 'No
                Next

            End If
            .WriteLine("<Column ss:AutoFitWidth=""0"" ss:Width=""64.5""/>")
            .WriteLine(" <Column ss:Width=""77.25"" ss:Span=""2""/>")
            .WriteLine("<Row ss:AutoFitHeight=""0"" ss:Height=""33"">")
            .WriteLine("  <Cell ss:MergeAcross=""2"" ss:StyleID=""s95""><Data ss:Type=""String"">Hermes S.R.L.</Data></Cell>")
            .WriteLine(" </Row>")
            .WriteLine(" <Row>")
            .WriteLine(" <Cell ss:StyleID=""s63""><Data ss:Type=""String"">Fecha: </Data></Cell>")
            .WriteLine("  <Cell ss:StyleID=""s63"" ss:Formula=""=NOW()""><Data ss:Type=""DateTime"">2015-11-04T00:38:18.790</Data></Cell>")
            .WriteLine("</Row>")
            .WriteLine(" <Row>")
            .WriteLine(" <Cell><Data ss:Type=""String"">Usuario:</Data></Cell>")
            .WriteLine(" <Cell><Data ss:Type=""String"">" & encrypta.desencriptar(_usuario) & "</Data></Cell>")
            .WriteLine(" </Row>")
            .WriteLine("<Row ss:Index=""5"" ss:AutoFitHeight=""0"" ss:Height=""21"" > ")
            .WriteLine("  <Cell ss:MergeAcross=""2"" ss:StyleID=""s91""><Data ss:Type=""String"">Nuevo Cliente</Data></Cell>")
            .WriteLine("</Row>")
            'AUTO SET HEADER
            .WriteLine("            <Row ss:StyleID=""ksg"">")
            For i As Integer = 0 To DGV.Columns.Count - 1 'SET HEADER
                Application.DoEvents()
                .WriteLine("            <Cell ss:StyleID=""hdr"">")
                .WriteLine("                <Data ss:Type=""String"">{0}</Data>", DGV.Columns.Item(i).HeaderText)
                .WriteLine("            </Cell>")
            Next
            .WriteLine("            </Row>")
            For intRow As Integer = 0 To DGV.RowCount - 2
                Application.DoEvents()
                .WriteLine("        <Row ss:StyleID=""ksg"" ss:utoFitHeight =""0"">")
                For intCol As Integer = 0 To DGV.Columns.Count - 1
                    Application.DoEvents()
                    .WriteLine("        <Cell ss:StyleID=""isi"">")
                    .WriteLine("            <Data ss:Type=""String"">{0}</Data>", DGV.Rows(intRow).Cells(intCol).Value.ToString)
                    .WriteLine("        </Cell>")
                Next
                .WriteLine("        </Row>")
            Next
            .WriteLine("        </Table>")
            .WriteLine("    </Worksheet>")
            .WriteLine("</Workbook>")
            .Close()
        End With
    End Sub

    Private Sub cmbpais_Click(sender As Object, e As EventArgs) Handles cmbpais.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpais.SelectedIndexChanged
        Dim seto As New DataSet
        seto = BLL.blldomicilio.provincia(cmbpais.Text)
        For Each row As DataRow In seto.Tables(0).Rows
            cmbprovincia.Items.Add(row.ItemArray(0))
        Next
    End Sub

    Private Sub cmbprovincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbprovincia.SelectedIndexChanged

    End Sub

    Private Sub txtident_TextChanged(sender As Object, e As EventArgs) Handles txtident.TextChanged

    End Sub

    Private Sub cmblocalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblocalidad.SelectedIndexChanged

    End Sub
End Class