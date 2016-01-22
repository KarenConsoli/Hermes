Imports System.Text.RegularExpressions

Public Class modifcliente
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
        Dim id_pais As Integer
        Dim id_provincia As Integer
        id_pais = BLL.blldomicilio.id_pais(cmbpais.Text)
        id_provincia = BLL.blldomicilio.id_provincia(cmbprovincia.Text)


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

        If txtnombre.Text = "" Or txtident.Text = "" Then
            MsgBox("Complete el formulario")
            txtident.Focus()
        End If
        Dim id_cliente As Integer = BLL.clsbuscar.buscar_cliente(txtnombre.Text)

        Dim seto As New DataSet
        seto = BLL.clsbuscar.buscar_tabla_por_id("Clientes", id_cliente)
        Dim baja As Integer
        If chkbaja.Checked = True Then
            baja = 1
        Else
            baja = 0
        End If
        Dim row As DataRow = seto.Tables(0).Rows(0)
        'tomar valores de los txt
        If txtnombre.Text = row.Item(2).ToString Then
            'tomar valores de los txt
            row.Item(1) = encrypta.encriptar(txtident.Text)
            row.Item(2) = txtnombre.Text
            row.Item(3) = txtfecha.Text
            row.Item(4) = id_pais
            row.Item(5) = id_provincia
            row.Item(6) = txtcp.Text
            row.Item(7) = txtdir.Text
            row.Item(7) = txtdir.Text
            row.Item(8) = baja
        End If


        BLL.clsbuscar.actualizar_datos(seto, "Clientes")
        Dim dv As New BLL.blldv
        dv.recalcular_dvh("Clientes")
        dv.Recalcular_dvv("Clientes")

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
        bita.desc_mov = "Cliente Editado"
        bita.grabar()
        dv.recalcular_dvh("bitacora")
        dv.Recalcular_dvv("bitacora")

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
        Dim seto As New DataSet
        seto = BLL.blldomicilio.provincia(cmbpais.Text)
        For Each row As DataRow In seto.Tables(0).Rows
            cmbprovincia.Items.Add(row.ItemArray(0))
        Next
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
        datagridtels.Rows.Add(txtnumero.Text)
        txtnumero.Clear()
    End Sub

    Private Sub UsuarioGB_Enter(sender As Object, e As EventArgs) Handles UsuarioGB.Enter
        Dim fecha As DateTime = DateTime.Now
        txtfecha.Text = fecha.ToString

    End Sub

    Private Sub cmbpais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpais.SelectedIndexChanged
        Dim seto As New DataSet
        seto = BLL.blldomicilio.provincia(cmbpais.Text)
        For Each row As DataRow In seto.Tables(0).Rows
            cmbprovincia.Items.Add(row.ItemArray(0))
        Next
    End Sub
End Class