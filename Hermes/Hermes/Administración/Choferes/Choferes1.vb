Public Class Choferes1
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
    Dim encrypta As New BLL.bllencriptar






    Private Sub EliminarTelBtn_Click(sender As Object, e As EventArgs)
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            MsgBox("El dato ha sido eliminado")
        Else
            MsgBox("El dato no ha sido Borrado")
        End If
    End Sub

    Public rodado As Integer
    Public chofer As Integer
    Public cliente As String
    Public paquetes As New List(Of String)

    Private Sub Choferes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Idioma.bllidioma.cambiaridioma(Me, _idioma)
        grillaok()
        cargar_campos()

    End Sub
    Public Sub grillaok()
        Dim tabla As String
        tabla = "Chofer"
        Dim seto As New DataSet

        seto = BLL.clsbuscar.actualizargrilla(seto, tabla)



        Dim i As Integer
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            seto.Tables(0).Rows(i).Item(5) = BLL.blldomicilio.nombre_pais(row.ItemArray(5))
            seto.Tables(0).Rows(i).Item(6) = BLL.blldomicilio.nombre_provincia_string(seto.Tables(0).Rows(i).Item(5), row.ItemArray(6))
            i = i + 1
        Next
        datagridchoferes.DataSource = seto.Tables(0)
        datagridchoferes.Columns("id_" & tabla).Visible = False
        datagridchoferes.Columns("dvh").Visible = False

        datagridchoferes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridchoferes.EditMode = DataGridViewEditMode.EditProgrammatically


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

  
    Public Sub buscar_por_campo()
        Dim tabla As String
        tabla = "Chofer"
        Dim campo As String = cmbbuscar.Text
        Dim texto As String = txtbuscar.Text

        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_por_campos(tabla, campo, texto)
        datagridchoferes.DataSource = seto.Tables(0)

    End Sub

  

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pantalla As New altachofer(_usuario, _idioma)

        pantalla.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim seto As New DataSet
        Dim tabla As String = "Chofer"

        Dim i As Integer

        seto = BLL.clsbuscar.buscar_por_campos(tabla, cmbbuscar.Text, txtbuscar.Text)
        For Each row As DataRow In seto.Tables(0).Rows
            seto.Tables(0).Rows(i).Item(1) = encrypta.desencriptar(row.ItemArray(1))
            seto.Tables(0).Rows(i).Item(5) = BLL.blldomicilio.nombre_pais(row.ItemArray(5))
            seto.Tables(0).Rows(i).Item(6) = BLL.blldomicilio.nombre_provincia_string(seto.Tables(0).Rows(i).Item(5), row.ItemArray(6))
            i = i + 1
        Next
        datagridchoferes.DataSource = seto.Tables(0)
        datagridchoferes.Columns("id_" & tabla).Visible = False
        datagridchoferes.Columns("dvh").Visible = False
        datagridchoferes.DataSource = seto.Tables(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere Imprimir?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            imprimir_choferes.Show()

        Else
            MsgBox("No se Imprimió")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim op As String
        op = MessageBox.Show("¿Seguro quiere eliminar Dato?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If op = vbYes Then
            BLL.clsbuscar.dar_baja(datagridchoferes.CurrentRow.Cells(0).Value, "Chofer")
            MsgBox("El dato ha sido eliminado")
        Else
            MsgBox("El dato no ha sido Borrado")
        End If
        grillaok()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim pantalla As New modifchofer(_usuario, _idioma)

        Dim row As DataGridViewRow = datagridchoferes.CurrentRow()

        Dim value As Object = row.Cells("cuit").Value
        pantalla.txtcuit.Text = value.ToString
        value = row.Cells("nombre_chofer").Value
        pantalla.txtnombre.Text = value.ToString
        value = row.Cells("fecha_chofer").Value
        pantalla.txtfecha.Text = value.ToString
        value = row.Cells("cp_chofer").Value
        pantalla.txtcp.Text = value.ToString
        value = row.Cells("pais_chofer").Value
        pantalla.cmbpais.Text = value.ToString
        value = row.Cells("provincia_chofer").Value
        pantalla.cmbprovincia.Text = value.ToString
        value = row.Cells("Registro").Value
        pantalla.txtregistro.Text = value.ToString
        value = row.Cells("dirección_chofer").Value
        pantalla.txtdir.Text = value.ToString
        value = row.Cells("cant_viajes").Value
        pantalla.txtcant.Text = value.ToString
        value = row.Cells("baja").Value
        If value = "True" Then
            pantalla.chkbaja.Checked = True
        End If
        pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        grillaok()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim pantalla As New altaenvio(_usuario, _idioma)
        Dim row As DataGridViewRow = datagridchoferes.CurrentRow()

        Dim value As Object = row.Cells(0).Value
        pantalla.paquetes = paquetes
        pantalla.cliente = cliente
        pantalla.rodado = rodado
        pantalla.chofer = value.ToString
        pantalla.Show()

        Me.Close()
    End Sub
End Class