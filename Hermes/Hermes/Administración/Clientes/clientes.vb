Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class clientes
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
    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        Me.Hide()
        Dim altacliente As New altacliente(_usuario, _idioma)
        altacliente.Show()
    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Me.Hide()
        Dim modifcliente As New modifcliente(_usuario, _idioma)
        Dim row As DataGridViewRow = datagridclientes.CurrentRow()

        Dim value As Object = row.Cells("Ident_cliente").Value
        modifcliente.txtident.Text = value.ToString
        value = row.Cells("nombre_cliente").Value
        modifcliente.txtnombre.Text = value.ToString
        value = row.Cells("fecha_ingreso").Value
        modifcliente.txtfecha.Text = value.ToString
        value = row.Cells("cp_cliente").Value
        modifcliente.txtcp.Text = value.ToString
        value = row.Cells("pais_cliente").Value
        modifcliente.cmbpais.Text = value.ToString
        value = row.Cells("provincia_cliente").Value
        modifcliente.cmbprovincia.Text = value.ToString
        value = row.Cells("baja").Value
        If value = "True" Then
            modifcliente.chkbaja.Checked = True
        End If

        modifcliente.Show()
    End Sub

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            BLL.clsbuscar.dar_baja(datagridclientes.CurrentRow.Cells(0).Value, "Clientes")
            MsgBox("El dato ha sido eliminado")
        Else
            MsgBox("El dato no ha sido Borrado")
        End If
    End Sub

    Private Sub EliminarTelBtn_Click(sender As Object, e As EventArgs)
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            MsgBox("El dato ha sido eliminado")
        Else
            MsgBox("El dato no ha sido Borrado")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Me.Hide()
        Me.btnok.Visible = False

        Dim pantalla As New altaenvio(_usuario, _idioma)
        Dim row As DataGridViewRow = datagridclientes.CurrentRow()
        Dim value As Object = row.Cells("Id_Clientes").Value
        pantalla.cliente = BLL.bllenvios.nombre_cliente(value.ToString)

        pantalla.Show()
        Me.Close()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pantalla As New paquetes(_usuario, _idioma)
        Dim row As DataGridViewRow = datagridclientes.CurrentRow()

        Dim value As Object = row.Cells("Id_Clientes").Value
        pantalla.txtcliente.Text = value.ToString
        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere Imprimir?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            ' ''Primero declarar el "separador", el profe usó ;
            'Dim ruta As String

            ''Const separador As String = ";"

            ''    'Empieza proceso
            ''    'Nuevo streamreader para acceder y guardar en txt
            ''    Using archivo As StreamWriter = New StreamWriter(ruta)
            ''        'linea dataview
            ''        Dim linea As String = String.Empty
            ''        'Número de última columna
            ''        Dim z As Integer = datagridbitacora.ColumnCount - 1
            ''        Dim x As Integer
            ''        'Imprimir nombres de las columnas
            ''        For x = 0 To z
            ''            linea = linea & datagridbitacora.Columns(x).HeaderText & separador
            ''        Next
            ''        'Siempre sacar el último ;
            ''        linea = linea.Remove(linea.Length - 1).ToString
            ''        'Y escribirlo
            ''        archivo.WriteLine(linea)

            ''        'Serie de sentencias sólo para el datagrid
            ''        With datagridbitacora
            ''            'recorre todas las filas del grid
            ''            For fila As Integer = 0 To .RowCount - 2
            ''                linea = String.Empty
            ''                'recorrer columnas
            ''                For col As Integer = 0 To .Columns.Count - 1
            ''                    'guarda todo con separador
            ''                    'si numero= normal
            ''                    'si fecha= #
            ''                    'si texto= ''

            ''                    If IsNumeric(datagridbitacora.Item(col, fila).Value) Then
            ''                        linea = linea & .Item(col, fila).Value.ToString & separador
            ''                    ElseIf IsDate(datagridbitacora.Item(col, fila).Value) Then
            ''                        linea = linea & "#" & .Item(col, fila).Value.ToString & "#" & separador
            ''                    Else
            ''                        linea = linea & "'" & .Item(col, fila).Value.ToString & "'" & separador
            ''                    End If
            ''                Next
            ''                'Escribir la linea
            ''                With archivo
            ''                    ' eliminar ultimo ;
            ''                    linea = linea.Remove(linea.Length - 1).ToString
            ''                    'escribir 
            ''                    .WriteLine(linea.ToString)
            ''                End With
            ''            Next
            ''        End With
            ''    End Using
            ''    'error
            'Try
            '    If datagridclientes.RowCount = 0 Then Return


            '    Application.DoEvents()

            '    datagridclientes.Name = "Impresion"
            '    Dim linea As String = String.Empty
            '    'Número de última columna
            '    Dim z As Integer = datagridclientes.ColumnCount - 1
            '    Dim x As Integer
            '    'Imprimir nombres de las columnas






            '    ruta = "r:\impresion" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
            '    'ruta = Application.StartupPath & "\impresion  " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
            '    If File.Exists(ruta) Then
            '        File.Delete(ruta)
            '    End If

            '    ExportToExcel(datagridclientes, ruta)



            '    Process.Start("r:\impresion" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls")



            'Catch ex As Exception
            '    MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            'End Try
            imprimir_clientes.Show()

        Else
            MsgBox("No se Imprimió")
        End If
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
                    Dim largo As Integer
                    largo = column.HeaderText.Length

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
            .WriteLine("  <Cell ss:MergeAcross=""2"" ss:StyleID=""s91""><Data ss:Type=""String"">Clientes</Data></Cell>")
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
    Private Sub clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        grillaok()
        cargar_campos()

        Idioma.bllidioma.cambiaridioma(Me, _idioma)
    End Sub
    Public Sub grillaok()
        Dim tabla As String
        tabla = "Clientes"
        Dim seto As New DataSet

        seto = BLL.clsbuscar.actualizargrilla(seto, tabla)


        Dim i As Integer
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            seto.Tables(0).Rows(i).Item(4) = BLL.blldomicilio.nombre_pais(row.ItemArray(4))
            seto.Tables(0).Rows(i).Item(5) = BLL.blldomicilio.nombre_provincia_string(seto.Tables(0).Rows(i).Item(4), row.ItemArray(5))
            i = i + 1
        Next
        datagridclientes.DataSource = seto.Tables(0)
        datagridclientes.Columns("id_" & tabla).Visible = False
        datagridclientes.Columns("dvh").Visible = False

        datagridclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridclientes.EditMode = DataGridViewEditMode.EditProgrammatically


    End Sub
    Public Sub cargar_campos()
        Dim tabla As String
        tabla = "Clientes"
        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_campos(tabla)
        For Each item As DataColumn In seto.Tables(0).Columns
            If item.ToString <> "dvh" And item.ToString <> "baja" And (item.ToString <> "id_" & tabla) Then
                cmbbuscar.Items.Add(item.ToString)
            End If
        Next
    End Sub
    Private Sub BuscarCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbuscar.SelectedIndexChanged

    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        Dim seto As New DataSet
        Dim tabla As String = "Clientes"


        Dim i As Integer
        seto = BLL.clsbuscar.buscar_por_campos(tabla, cmbbuscar.Text, txtbuscar.Text)
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            seto.Tables(0).Rows(i).Item(4) = BLL.blldomicilio.nombre_pais(row.ItemArray(4))
            seto.Tables(0).Rows(i).Item(5) = BLL.blldomicilio.nombre_provincia_string(seto.Tables(0).Rows(i).Item(4), row.ItemArray(5))
            i = i + 1
        Next
        datagridclientes.DataSource = seto.Tables(0)
        datagridclientes.Columns("id_" & tabla).Visible = False
        datagridclientes.Columns("dvh").Visible = False

        datagridclientes.DataSource = seto.Tables(0)
    End Sub

    Private Sub GestionUsuariosGB_Enter(sender As Object, e As EventArgs) Handles GestionUsuariosGB.Enter

    End Sub
End Class