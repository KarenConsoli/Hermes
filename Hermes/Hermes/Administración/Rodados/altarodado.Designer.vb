<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altarodado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altarodado))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'txtcapacidad
        '
        resources.ApplyResources(Me.txtcapacidad, "txtcapacidad")
        Me.txtcapacidad.Name = "txtcapacidad"
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        resources.ApplyResources(Me.cmbtipo, "cmbtipo")
        Me.cmbtipo.Name = "cmbtipo"
        '
        'cmbmarca
        '
        Me.cmbmarca.FormattingEnabled = True
        resources.ApplyResources(Me.cmbmarca, "cmbmarca")
        Me.cmbmarca.Name = "cmbmarca"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'txtanio
        '
        resources.ApplyResources(Me.txtanio, "txtanio")
        Me.txtanio.Name = "txtanio"
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
        'txtmodelo
        '
        resources.ApplyResources(Me.txtmodelo, "txtmodelo")
        Me.txtmodelo.Name = "txtmodelo"
        '
        'txtchasis
        '
        resources.ApplyResources(Me.txtchasis, "txtchasis")
        Me.txtchasis.Name = "txtchasis"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtmotor
        '
        resources.ApplyResources(Me.txtmotor, "txtmotor")
        Me.txtmotor.Name = "txtmotor"
        '
        'txtdominio
        '
        resources.ApplyResources(Me.txtdominio, "txtdominio")
        Me.txtdominio.Name = "txtdominio"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'altarodado
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "altarodado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtanio As System.Windows.Forms.TextBox
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmarca As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcapacidad As System.Windows.Forms.TextBox
End Class
