<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifrodado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modifrodado))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkbaja = New System.Windows.Forms.CheckBox()
        Me.txtcapacidad = New System.Windows.Forms.TextBox()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.cmbmarca = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtanio = New System.Windows.Forms.TextBox()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.txtchasis = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmotor = New System.Windows.Forms.TextBox()
        Me.txtdominio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkbaja)
        Me.GroupBox1.Controls.Add(Me.txtcapacidad)
        Me.GroupBox1.Controls.Add(Me.cmbtipo)
        Me.GroupBox1.Controls.Add(Me.cmbmarca)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtanio)
        Me.GroupBox1.Controls.Add(Me.CancelarBtn)
        Me.GroupBox1.Controls.Add(Me.AceptarBtn)
        Me.GroupBox1.Controls.Add(Me.txtmodelo)
        Me.GroupBox1.Controls.Add(Me.txtchasis)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtmotor)
        Me.GroupBox1.Controls.Add(Me.txtdominio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 282)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Rodado"
        '
        'chkbaja
        '
        Me.chkbaja.AutoSize = True
        Me.chkbaja.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkbaja.Location = New System.Drawing.Point(106, 234)
        Me.chkbaja.Name = "chkbaja"
        Me.chkbaja.Size = New System.Drawing.Size(47, 17)
        Me.chkbaja.TabIndex = 46
        Me.chkbaja.Text = "Baja"
        Me.chkbaja.UseVisualStyleBackColor = True
        '
        'txtcapacidad
        '
        Me.txtcapacidad.Location = New System.Drawing.Point(106, 181)
        Me.txtcapacidad.Name = "txtcapacidad"
        Me.txtcapacidad.Size = New System.Drawing.Size(128, 20)
        Me.txtcapacidad.TabIndex = 37
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Location = New System.Drawing.Point(106, 207)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(128, 21)
        Me.cmbtipo.TabIndex = 45
        '
        'cmbmarca
        '
        Me.cmbmarca.FormattingEnabled = True
        Me.cmbmarca.Location = New System.Drawing.Point(106, 101)
        Me.cmbmarca.Name = "cmbmarca"
        Me.cmbmarca.Size = New System.Drawing.Size(128, 21)
        Me.cmbmarca.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(8, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Marca de Rodado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(17, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Tipo de Rodado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(43, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Capacidad"
        '
        'txtanio
        '
        Me.txtanio.Location = New System.Drawing.Point(106, 155)
        Me.txtanio.Name = "txtanio"
        Me.txtanio.Size = New System.Drawing.Size(128, 20)
        Me.txtanio.TabIndex = 40
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Image = CType(resources.GetObject("CancelarBtn.Image"), System.Drawing.Image)
        Me.CancelarBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CancelarBtn.Location = New System.Drawing.Point(138, 252)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(82, 24)
        Me.CancelarBtn.TabIndex = 39
        Me.CancelarBtn.Text = "&Cancelar"
        Me.CancelarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Image = CType(resources.GetObject("AceptarBtn.Image"), System.Drawing.Image)
        Me.AceptarBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AceptarBtn.Location = New System.Drawing.Point(39, 252)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(82, 24)
        Me.AceptarBtn.TabIndex = 38
        Me.AceptarBtn.Text = "&Aceptar"
        Me.AceptarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(106, 128)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(128, 20)
        Me.txtmodelo.TabIndex = 36
        '
        'txtchasis
        '
        Me.txtchasis.Location = New System.Drawing.Point(106, 76)
        Me.txtchasis.Name = "txtchasis"
        Me.txtchasis.Size = New System.Drawing.Size(128, 20)
        Me.txtchasis.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(54, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Modelo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(70, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Año"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(43, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Nº Chasis"
        '
        'txtmotor
        '
        Me.txtmotor.Location = New System.Drawing.Point(106, 50)
        Me.txtmotor.Name = "txtmotor"
        Me.txtmotor.Size = New System.Drawing.Size(128, 20)
        Me.txtmotor.TabIndex = 6
        '
        'txtdominio
        '
        Me.txtdominio.Location = New System.Drawing.Point(106, 26)
        Me.txtdominio.Name = "txtdominio"
        Me.txtdominio.Size = New System.Drawing.Size(128, 20)
        Me.txtdominio.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(47, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nº Motor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(36, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nº Dominio"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(302, 85)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(128, 20)
        Me.txtid.TabIndex = 7
        Me.txtid.Visible = False
        '
        'modifrodado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 299)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "modifrodado"
        Me.Text = "Modificar Rodado- Hermes S.R.L."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcapacidad As System.Windows.Forms.TextBox
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmarca As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtanio As System.Windows.Forms.TextBox
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents txtmodelo As System.Windows.Forms.TextBox
    Friend WithEvents txtchasis As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtmotor As System.Windows.Forms.TextBox
    Friend WithEvents txtdominio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkbaja As System.Windows.Forms.CheckBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
End Class
