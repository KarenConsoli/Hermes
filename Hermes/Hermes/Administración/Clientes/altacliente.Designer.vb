<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altacliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altacliente))
        Me.UsuarioGB = New System.Windows.Forms.GroupBox()
        Me.DomicilioGB = New System.Windows.Forms.GroupBox()
        Me.cmbpais = New System.Windows.Forms.ComboBox()
        Me.cmbprovincia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CalleLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmblocalidad = New System.Windows.Forms.ComboBox()
        Me.PisoLbl = New System.Windows.Forms.Label()
        Me.txtdir = New System.Windows.Forms.TextBox()
        Me.LocalidadLbl = New System.Windows.Forms.Label()
        Me.txtcp = New System.Windows.Forms.TextBox()
        Me.txtident = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TelefonosGB = New System.Windows.Forms.GroupBox()
        Me.NumeroLbl = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.datagridtels = New System.Windows.Forms.DataGridView()
        Me.NumeroCAB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.IdiomaLbl = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.CorreoElectronicoLbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.QuitarTelBtn = New System.Windows.Forms.Button()
        Me.AgregarTelBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.UsuarioGB.SuspendLayout()
        Me.DomicilioGB.SuspendLayout()
        Me.TelefonosGB.SuspendLayout()
        CType(Me.datagridtels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioGB
        '
        resources.ApplyResources(Me.UsuarioGB, "UsuarioGB")
        Me.UsuarioGB.Controls.Add(Me.DomicilioGB)
        Me.UsuarioGB.Controls.Add(Me.txtident)
        Me.UsuarioGB.Controls.Add(Me.RadioButton2)
        Me.UsuarioGB.Controls.Add(Me.TelefonosGB)
        Me.UsuarioGB.Controls.Add(Me.RadioButton1)
        Me.UsuarioGB.Controls.Add(Me.CancelarBtn)
        Me.UsuarioGB.Controls.Add(Me.AceptarBtn)
        Me.UsuarioGB.Controls.Add(Me.IdiomaLbl)
        Me.UsuarioGB.Controls.Add(Me.txtfecha)
        Me.UsuarioGB.Controls.Add(Me.txtnombre)
        Me.UsuarioGB.Controls.Add(Me.CorreoElectronicoLbl)
        Me.UsuarioGB.Name = "UsuarioGB"
        Me.UsuarioGB.TabStop = False
        '
        'DomicilioGB
        '
        resources.ApplyResources(Me.DomicilioGB, "DomicilioGB")
        Me.DomicilioGB.Controls.Add(Me.cmbpais)
        Me.DomicilioGB.Controls.Add(Me.Button2)
        Me.DomicilioGB.Controls.Add(Me.cmbprovincia)
        Me.DomicilioGB.Controls.Add(Me.Label3)
        Me.DomicilioGB.Controls.Add(Me.CalleLbl)
        Me.DomicilioGB.Controls.Add(Me.Label2)
        Me.DomicilioGB.Controls.Add(Me.cmblocalidad)
        Me.DomicilioGB.Controls.Add(Me.PisoLbl)
        Me.DomicilioGB.Controls.Add(Me.txtdir)
        Me.DomicilioGB.Controls.Add(Me.LocalidadLbl)
        Me.DomicilioGB.Controls.Add(Me.txtcp)
        Me.DomicilioGB.Name = "DomicilioGB"
        Me.DomicilioGB.TabStop = False
        '
        'cmbpais
        '
        resources.ApplyResources(Me.cmbpais, "cmbpais")
        Me.cmbpais.FormattingEnabled = True
        Me.cmbpais.Name = "cmbpais"
        '
        'cmbprovincia
        '
        resources.ApplyResources(Me.cmbprovincia, "cmbprovincia")
        Me.cmbprovincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprovincia.FormattingEnabled = True
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
        resources.ApplyResources(Me.cmblocalidad, "cmblocalidad")
        Me.cmblocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocalidad.FormattingEnabled = True
        Me.cmblocalidad.Name = "cmblocalidad"
        '
        'PisoLbl
        '
        resources.ApplyResources(Me.PisoLbl, "PisoLbl")
        Me.PisoLbl.Name = "PisoLbl"
        '
        'txtdir
        '
        resources.ApplyResources(Me.txtdir, "txtdir")
        Me.txtdir.Name = "txtdir"
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
        'txtident
        '
        resources.ApplyResources(Me.txtident, "txtident")
        Me.txtident.Name = "txtident"
        '
        'RadioButton2
        '
        resources.ApplyResources(Me.RadioButton2, "RadioButton2")
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TelefonosGB
        '
        resources.ApplyResources(Me.TelefonosGB, "TelefonosGB")
        Me.TelefonosGB.Controls.Add(Me.NumeroLbl)
        Me.TelefonosGB.Controls.Add(Me.txtnumero)
        Me.TelefonosGB.Controls.Add(Me.QuitarTelBtn)
        Me.TelefonosGB.Controls.Add(Me.AgregarTelBtn)
        Me.TelefonosGB.Controls.Add(Me.datagridtels)
        Me.TelefonosGB.Name = "TelefonosGB"
        Me.TelefonosGB.TabStop = False
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
        'datagridtels
        '
        resources.ApplyResources(Me.datagridtels, "datagridtels")
        Me.datagridtels.AllowUserToAddRows = False
        Me.datagridtels.AllowUserToDeleteRows = False
        Me.datagridtels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridtels.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroCAB})
        Me.datagridtels.Name = "datagridtels"
        Me.datagridtels.StandardTab = True
        '
        'NumeroCAB
        '
        resources.ApplyResources(Me.NumeroCAB, "NumeroCAB")
        Me.NumeroCAB.Name = "NumeroCAB"
        '
        'RadioButton1
        '
        resources.ApplyResources(Me.RadioButton1, "RadioButton1")
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'IdiomaLbl
        '
        resources.ApplyResources(Me.IdiomaLbl, "IdiomaLbl")
        Me.IdiomaLbl.Name = "IdiomaLbl"
        '
        'txtfecha
        '
        resources.ApplyResources(Me.txtfecha, "txtfecha")
        Me.txtfecha.Name = "txtfecha"
        '
        'txtnombre
        '
        resources.ApplyResources(Me.txtnombre, "txtnombre")
        Me.txtnombre.Name = "txtnombre"
        '
        'CorreoElectronicoLbl
        '
        resources.ApplyResources(Me.CorreoElectronicoLbl, "CorreoElectronicoLbl")
        Me.CorreoElectronicoLbl.Name = "CorreoElectronicoLbl"
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
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
        'altacliente
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UsuarioGB)
        Me.Name = "altacliente"
        Me.UsuarioGB.ResumeLayout(False)
        Me.UsuarioGB.PerformLayout()
        Me.DomicilioGB.ResumeLayout(False)
        Me.DomicilioGB.PerformLayout()
        Me.TelefonosGB.ResumeLayout(False)
        Me.TelefonosGB.PerformLayout()
        CType(Me.datagridtels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UsuarioGB As System.Windows.Forms.GroupBox
    Friend WithEvents DomicilioGB As System.Windows.Forms.GroupBox
    Friend WithEvents cmbprovincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CalleLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmblocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents PisoLbl As System.Windows.Forms.Label
    Friend WithEvents txtdir As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadLbl As System.Windows.Forms.Label
    Friend WithEvents txtcp As System.Windows.Forms.TextBox
    Friend WithEvents txtident As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TelefonosGB As System.Windows.Forms.GroupBox
    Friend WithEvents NumeroLbl As System.Windows.Forms.Label
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents QuitarTelBtn As System.Windows.Forms.Button
    Friend WithEvents AgregarTelBtn As System.Windows.Forms.Button
    Friend WithEvents datagridtels As System.Windows.Forms.DataGridView
    Friend WithEvents NumeroCAB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents IdiomaLbl As System.Windows.Forms.Label
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents CorreoElectronicoLbl As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbpais As System.Windows.Forms.ComboBox
End Class
