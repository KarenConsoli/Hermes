<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altausuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altausuario))
        Me.DatosGB = New System.Windows.Forms.GroupBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.FechaNacLbl = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.ApellidoLbl = New System.Windows.Forms.Label()
        Me.NombreLbl = New System.Windows.Forms.Label()
        Me.DomicilioGB = New System.Windows.Forms.GroupBox()
        Me.cmbpais = New System.Windows.Forms.ComboBox()
        Me.cmbprovincia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CalleLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmblocalidad = New System.Windows.Forms.ComboBox()
        Me.PisoLbl = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.LocalidadLbl = New System.Windows.Forms.Label()
        Me.txtcp = New System.Windows.Forms.TextBox()
        Me.TelefonosGB = New System.Windows.Forms.GroupBox()
        Me.datagridtels = New System.Windows.Forms.DataGridView()
        Me.Tel_Usuarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroLbl = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.UsuarioGB = New System.Windows.Forms.GroupBox()
        Me.txtidioma = New System.Windows.Forms.ComboBox()
        Me.IdiomaLbl = New System.Windows.Forms.Label()
        Me.chkdesactivar = New System.Windows.Forms.CheckBox()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.chkdesbloquear = New System.Windows.Forms.CheckBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcant = New System.Windows.Forms.TextBox()
        Me.UsuarioLbl = New System.Windows.Forms.Label()
        Me.CorreoElectronicoLbl = New System.Windows.Forms.Label()
        Me.QuitarTelBtn = New System.Windows.Forms.Button()
        Me.AgregarTelBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.DatosGB.SuspendLayout()
        Me.DomicilioGB.SuspendLayout()
        Me.TelefonosGB.SuspendLayout()
        CType(Me.datagridtels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsuarioGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatosGB
        '
        Me.DatosGB.Controls.Add(Me.txtfecha)
        Me.DatosGB.Controls.Add(Me.FechaNacLbl)
        Me.DatosGB.Controls.Add(Me.txtapellido)
        Me.DatosGB.Controls.Add(Me.txtnombre)
        Me.DatosGB.Controls.Add(Me.ApellidoLbl)
        Me.DatosGB.Controls.Add(Me.NombreLbl)
        resources.ApplyResources(Me.DatosGB, "DatosGB")
        Me.DatosGB.Name = "DatosGB"
        Me.DatosGB.TabStop = False
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        resources.ApplyResources(Me.txtfecha, "txtfecha")
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Value = New Date(2013, 7, 22, 0, 0, 0, 0)
        '
        'FechaNacLbl
        '
        resources.ApplyResources(Me.FechaNacLbl, "FechaNacLbl")
        Me.FechaNacLbl.Name = "FechaNacLbl"
        '
        'txtapellido
        '
        resources.ApplyResources(Me.txtapellido, "txtapellido")
        Me.txtapellido.Name = "txtapellido"
        '
        'txtnombre
        '
        resources.ApplyResources(Me.txtnombre, "txtnombre")
        Me.txtnombre.Name = "txtnombre"
        '
        'ApellidoLbl
        '
        resources.ApplyResources(Me.ApellidoLbl, "ApellidoLbl")
        Me.ApellidoLbl.Name = "ApellidoLbl"
        '
        'NombreLbl
        '
        resources.ApplyResources(Me.NombreLbl, "NombreLbl")
        Me.NombreLbl.Name = "NombreLbl"
        '
        'DomicilioGB
        '
        Me.DomicilioGB.Controls.Add(Me.cmbpais)
        Me.DomicilioGB.Controls.Add(Me.Button2)
        Me.DomicilioGB.Controls.Add(Me.cmbprovincia)
        Me.DomicilioGB.Controls.Add(Me.Label3)
        Me.DomicilioGB.Controls.Add(Me.CalleLbl)
        Me.DomicilioGB.Controls.Add(Me.Label2)
        Me.DomicilioGB.Controls.Add(Me.cmblocalidad)
        Me.DomicilioGB.Controls.Add(Me.PisoLbl)
        Me.DomicilioGB.Controls.Add(Me.txtdireccion)
        Me.DomicilioGB.Controls.Add(Me.LocalidadLbl)
        Me.DomicilioGB.Controls.Add(Me.txtcp)
        resources.ApplyResources(Me.DomicilioGB, "DomicilioGB")
        Me.DomicilioGB.Name = "DomicilioGB"
        Me.DomicilioGB.TabStop = False
        '
        'cmbpais
        '
        Me.cmbpais.FormattingEnabled = True
        resources.ApplyResources(Me.cmbpais, "cmbpais")
        Me.cmbpais.Name = "cmbpais"
        '
        'cmbprovincia
        '
        Me.cmbprovincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprovincia.FormattingEnabled = True
        resources.ApplyResources(Me.cmbprovincia, "cmbprovincia")
        Me.cmbprovincia.Name = "cmbprovincia"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'CalleLbl
        '
        resources.ApplyResources(Me.CalleLbl, "CalleLbl")
        Me.CalleLbl.Name = "CalleLbl"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'cmblocalidad
        '
        Me.cmblocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocalidad.FormattingEnabled = True
        resources.ApplyResources(Me.cmblocalidad, "cmblocalidad")
        Me.cmblocalidad.Name = "cmblocalidad"
        '
        'PisoLbl
        '
        resources.ApplyResources(Me.PisoLbl, "PisoLbl")
        Me.PisoLbl.Name = "PisoLbl"
        '
        'txtdireccion
        '
        resources.ApplyResources(Me.txtdireccion, "txtdireccion")
        Me.txtdireccion.Name = "txtdireccion"
        '
        'LocalidadLbl
        '
        resources.ApplyResources(Me.LocalidadLbl, "LocalidadLbl")
        Me.LocalidadLbl.Name = "LocalidadLbl"
        '
        'txtcp
        '
        resources.ApplyResources(Me.txtcp, "txtcp")
        Me.txtcp.Name = "txtcp"
        '
        'TelefonosGB
        '
        Me.TelefonosGB.Controls.Add(Me.datagridtels)
        Me.TelefonosGB.Controls.Add(Me.NumeroLbl)
        Me.TelefonosGB.Controls.Add(Me.txtnumero)
        Me.TelefonosGB.Controls.Add(Me.QuitarTelBtn)
        Me.TelefonosGB.Controls.Add(Me.AgregarTelBtn)
        resources.ApplyResources(Me.TelefonosGB, "TelefonosGB")
        Me.TelefonosGB.Name = "TelefonosGB"
        Me.TelefonosGB.TabStop = False
        '
        'datagridtels
        '
        Me.datagridtels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridtels.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tel_Usuarios})
        resources.ApplyResources(Me.datagridtels, "datagridtels")
        Me.datagridtels.Name = "datagridtels"
        '
        'Tel_Usuarios
        '
        resources.ApplyResources(Me.Tel_Usuarios, "Tel_Usuarios")
        Me.Tel_Usuarios.Name = "Tel_Usuarios"
        '
        'NumeroLbl
        '
        resources.ApplyResources(Me.NumeroLbl, "NumeroLbl")
        Me.NumeroLbl.Name = "NumeroLbl"
        '
        'txtnumero
        '
        resources.ApplyResources(Me.txtnumero, "txtnumero")
        Me.txtnumero.Name = "txtnumero"
        '
        'UsuarioGB
        '
        Me.UsuarioGB.Controls.Add(Me.TelefonosGB)
        Me.UsuarioGB.Controls.Add(Me.DomicilioGB)
        Me.UsuarioGB.Controls.Add(Me.CancelarBtn)
        Me.UsuarioGB.Controls.Add(Me.txtidioma)
        Me.UsuarioGB.Controls.Add(Me.AceptarBtn)
        Me.UsuarioGB.Controls.Add(Me.IdiomaLbl)
        Me.UsuarioGB.Controls.Add(Me.chkdesactivar)
        Me.UsuarioGB.Controls.Add(Me.txtmail)
        Me.UsuarioGB.Controls.Add(Me.chkdesbloquear)
        Me.UsuarioGB.Controls.Add(Me.txtusuario)
        Me.UsuarioGB.Controls.Add(Me.Label4)
        Me.UsuarioGB.Controls.Add(Me.txtcant)
        Me.UsuarioGB.Controls.Add(Me.UsuarioLbl)
        Me.UsuarioGB.Controls.Add(Me.CorreoElectronicoLbl)
        Me.UsuarioGB.Controls.Add(Me.DatosGB)
        resources.ApplyResources(Me.UsuarioGB, "UsuarioGB")
        Me.UsuarioGB.Name = "UsuarioGB"
        Me.UsuarioGB.TabStop = False
        '
        'txtidioma
        '
        Me.txtidioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtidioma.FormattingEnabled = True
        resources.ApplyResources(Me.txtidioma, "txtidioma")
        Me.txtidioma.Name = "txtidioma"
        '
        'IdiomaLbl
        '
        resources.ApplyResources(Me.IdiomaLbl, "IdiomaLbl")
        Me.IdiomaLbl.Name = "IdiomaLbl"
        '
        'chkdesactivar
        '
        resources.ApplyResources(Me.chkdesactivar, "chkdesactivar")
        Me.chkdesactivar.Name = "chkdesactivar"
        Me.chkdesactivar.UseVisualStyleBackColor = True
        '
        'txtmail
        '
        resources.ApplyResources(Me.txtmail, "txtmail")
        Me.txtmail.Name = "txtmail"
        '
        'chkdesbloquear
        '
        resources.ApplyResources(Me.chkdesbloquear, "chkdesbloquear")
        Me.chkdesbloquear.Name = "chkdesbloquear"
        Me.chkdesbloquear.UseVisualStyleBackColor = True
        '
        'txtusuario
        '
        resources.ApplyResources(Me.txtusuario, "txtusuario")
        Me.txtusuario.Name = "txtusuario"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtcant
        '
        resources.ApplyResources(Me.txtcant, "txtcant")
        Me.txtcant.Name = "txtcant"
        '
        'UsuarioLbl
        '
        resources.ApplyResources(Me.UsuarioLbl, "UsuarioLbl")
        Me.UsuarioLbl.Name = "UsuarioLbl"
        '
        'CorreoElectronicoLbl
        '
        resources.ApplyResources(Me.CorreoElectronicoLbl, "CorreoElectronicoLbl")
        Me.CorreoElectronicoLbl.Name = "CorreoElectronicoLbl"
        '
        'QuitarTelBtn
        '
        resources.ApplyResources(Me.QuitarTelBtn, "QuitarTelBtn")
        Me.QuitarTelBtn.Name = "QuitarTelBtn"
        Me.QuitarTelBtn.UseVisualStyleBackColor = True
        '
        'AgregarTelBtn
        '
        resources.ApplyResources(Me.AgregarTelBtn, "AgregarTelBtn")
        Me.AgregarTelBtn.Name = "AgregarTelBtn"
        Me.AgregarTelBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        resources.ApplyResources(Me.CancelarBtn, "CancelarBtn")
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        resources.ApplyResources(Me.AceptarBtn, "AceptarBtn")
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'altausuario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UsuarioGB)
        Me.Name = "altausuario"
        Me.DatosGB.ResumeLayout(False)
        Me.DatosGB.PerformLayout()
        Me.DomicilioGB.ResumeLayout(False)
        Me.DomicilioGB.PerformLayout()
        Me.TelefonosGB.ResumeLayout(False)
        Me.TelefonosGB.PerformLayout()
        CType(Me.datagridtels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsuarioGB.ResumeLayout(False)
        Me.UsuarioGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatosGB As System.Windows.Forms.GroupBox
    Friend WithEvents DomicilioGB As System.Windows.Forms.GroupBox
    Friend WithEvents cmbprovincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CalleLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmblocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents PisoLbl As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadLbl As System.Windows.Forms.Label
    Friend WithEvents txtcp As System.Windows.Forms.TextBox
    Friend WithEvents txtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TelefonosGB As System.Windows.Forms.GroupBox
    Friend WithEvents NumeroLbl As System.Windows.Forms.Label
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents QuitarTelBtn As System.Windows.Forms.Button
    Friend WithEvents AgregarTelBtn As System.Windows.Forms.Button
    Friend WithEvents FechaNacLbl As System.Windows.Forms.Label
    Friend WithEvents txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoLbl As System.Windows.Forms.Label
    Friend WithEvents NombreLbl As System.Windows.Forms.Label
    Friend WithEvents UsuarioGB As System.Windows.Forms.GroupBox
    Friend WithEvents txtidioma As System.Windows.Forms.ComboBox
    Friend WithEvents IdiomaLbl As System.Windows.Forms.Label
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents UsuarioLbl As System.Windows.Forms.Label
    Friend WithEvents CorreoElectronicoLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcant As System.Windows.Forms.TextBox
    Friend WithEvents chkdesbloquear As System.Windows.Forms.CheckBox
    Friend WithEvents chkdesactivar As System.Windows.Forms.CheckBox
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents datagridtels As System.Windows.Forms.DataGridView
    Friend WithEvents Tel_Usuarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbpais As System.Windows.Forms.ComboBox
End Class
