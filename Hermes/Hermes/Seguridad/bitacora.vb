Imports Microsoft.Reporting.WinForms

Imports System.IO



Public Class bitacora
    Dim encrypta As New BLL.bllencriptar
    Dim seto As New DataSet


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
    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs)

        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere Imprimir?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
          

        Else
            MsgBox("No se Imprimió")
        End If
    End Sub

    Private Sub conbitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Idioma.bllidioma.cambiaridioma(Me, id_idioma)
        grillaok()
        cargar_usuarios()


    End Sub
    Public Sub grillaok()
        Dim tabla As String
        tabla = "bitacora"

        Dim i As Integer = 0
        seto = BLL.clsbuscar.actualizargrilla(seto, tabla)
        For Each row As DataRow In seto.Tables(0).Rows

            seto.Tables(0).Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            seto.Tables(0).Rows(i).Item(2) = encrypta.desencriptar(row.ItemArray(2))
            i = i + 1
        Next
        datagridbitacora.DataSource = seto.Tables(0)
        datagridbitacora.Columns("id_" & tabla).Visible = False
        datagridbitacora.Columns("dvh").Visible = False

        Dim rds As ReportDataSource = New ReportDataSource()
        rds.Name = "seto_bitacora"
        rds.Value = seto.Tables(0)
        imprimir_bitacora.ReportViewer1.LocalReport.DataSources.Clear()
        imprimir_bitacora.ReportViewer1.LocalReport.DataSources.Add(rds)
        imprimir_bitacora.ReportViewer1.LocalReport.ReportPath = "D:\##Chicos\Hermes\Hermes\Hermes\Seguridad\bitacora.rdlc"
        imprimir_bitacora.ReportViewer1.LocalReport.Refresh()
        datagridbitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub
    'Public Sub cargar_campos()
    '    Dim tabla As String
    '    tabla = "bitacora"
    '    Dim seto As New DataSet
    '    seto = BLL.clsbuscar.buscar_campos(tabla)
    '    For Each item As DataColumn In seto.Tables(0).Columns
    '        If item.ToString <> "dvh" Then
    '            cmbbuscar.Items.Add(item.ToString)
    '        End If
    '    Next
    'End Sub
    Public Sub cargar_usuarios()
        Dim seto As New DataSet
        seto = BLL.bllusuario.cargar_usuarios()
        For Each row As DataRow In seto.Tables(0).Rows
            cmbusuario.Items.Add(encrypta.desencriptar(row.ItemArray(0)))
        Next
    End Sub

    Public Sub buscar_por_campo()

        Dim criticidad As String = cmbcriticidad.Text

        Dim usuario As String = cmbusuario.Text
        If usuario <> "" Then
            usuario = encrypta.encriptar(usuario)
        End If
        Dim i As Integer


        seto = BLL.bllbitacora.buscar_bitacora(criticidad, usuario, txtdesde.Text, txthasta.Text)
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            seto.Tables(0).Rows(i).Item(2) = encrypta.desencriptar(row.ItemArray(2))
            i = i + 1
        Next
        Dim rds As ReportDataSource = New ReportDataSource()
        rds.Name = "seto_bitacora"
        rds.Value = seto.Tables(0)
        imprimir_bitacora.ReportViewer1.LocalReport.DataSources.Clear()
        imprimir_bitacora.ReportViewer1.LocalReport.DataSources.Add(rds)
        imprimir_bitacora.ReportViewer1.LocalReport.ReportPath = "D:\##Chicos\Hermes\Hermes\Hermes\Seguridad\bitacora.rdlc"
        imprimir_bitacora.ReportViewer1.LocalReport.Refresh()
        datagridbitacora.DataSource = seto.Tables(0)

    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs)
        buscar_por_campo()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        grillaok()

    End Sub

    Private Sub frmusuarios_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        eliminar_por_campo()
        MsgBox("Datos Eliminados")

    End Sub
    Public Sub eliminar_por_campo()
        Dim criticidad As String = cmbcriticidad.Text
        Dim usuario As String = cmbusuario.Text
        BLL.bllbitacora.eliminar_bitacora(criticidad, usuario, txtdesde.Text, txthasta.Text)
        grillaok()


    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ' ''Primero declarar el "separador", el profe usó ;
        'Dim ruta As String

        ''Const separador As String = ";"

        ''    'Empieza proceso
        ''    'Nuevo streamreader para acceder y guardar en txt
        ''    Using archivo As StreamWriter = New StreamWriter(ruta)
        '        'linea dataview
        '        Dim linea As String = String.Empty
        '        'Número de última columna
        '        Dim z As Integer = datagridbitacora.ColumnCount - 1
        '        Dim x As Integer
        '        'Imprimir nombres de las columnas
        '        For x = 0 To z
        '            linea = linea & datagridbitacora.Columns(x).HeaderText & separador
        '        Next
        '        'Siempre sacar el último ;
        '        linea = linea.Remove(linea.Length - 1).ToString
        '        'Y escribirlo
        '        archivo.WriteLine(linea)

        '        'Serie de sentencias sólo para el datagrid
        '        With datagridbitacora
        '            'recorre todas las filas del grid
        '            For fila As Integer = 0 To .RowCount - 2
        '                linea = String.Empty
        '                'recorrer columnas
        '                For col As Integer = 0 To .Columns.Count - 1
        '                    'guarda todo con separador
        '                    'si numero= normal
        '                    'si fecha= #
        '                    'si texto= ''

        '                    If IsNumeric(datagridbitacora.Item(col, fila).Value) Then
        '                        linea = linea & .Item(col, fila).Value.ToString & separador
        '                    ElseIf IsDate(datagridbitacora.Item(col, fila).Value) Then
        '                        linea = linea & "#" & .Item(col, fila).Value.ToString & "#" & separador
        '                    Else
        '                        linea = linea & "'" & .Item(col, fila).Value.ToString & "'" & separador
        '                    End If
        '                Next
        '                'Escribir la linea
        '                With archivo
        '                    ' eliminar ultimo ;
        '                    linea = linea.Remove(linea.Length - 1).ToString
        '                    'escribir 
        '                    .WriteLine(linea.ToString)
        '                End With
        '            Next
        '        End With
        '    End Using
        ''    'error
        'Try
        '    If datagridbitacora.RowCount = 0 Then Return


        '    Application.DoEvents()

        '    datagridbitacora.Name = "Impresion"
        '    Dim linea As String = String.Empty
        '    'Número de última columna
        '    Dim z As Integer = datagridbitacora.ColumnCount - 1
        '    Dim x As Integer
        '    'Imprimir nombres de las columnas






        '    ruta = "d:\impresion" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
        '    'ruta = Application.StartupPath & "\impresion  " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
        '    If File.Exists(ruta) Then
        '        File.Delete(ruta)
        '    End If

        '    ExportToExcel(datagridbitacora, ruta)



        '    Process.Start("d:\impresion" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls")



        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        'End Try
        imprimir_bitacora.Show()

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

                    .WriteLine("            <Column ss:Width=""50""/>") 'No
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
            .WriteLine("  <Cell ss:MergeAcross=""2"" ss:StyleID=""s91""><Data ss:Type=""String"">Bitácora</Data></Cell>")
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
    Private Sub CancelarBtn_Click_1(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Hide()

    End Sub

    Private Sub BuscarBtn_Click_1(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        buscar_por_campo()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        grillaok()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        eliminar_por_campo()
        Dim dv As New BLL.blldv

        'bitácora
        Dim bita As New BLL.bllbitacora
        bita.usuario = _usuario
        bita.criticidad = "bajo"
        bita.desc_mov = "Bitácora Limpiada"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")
    End Sub
End Class