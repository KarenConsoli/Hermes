<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altapartida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altapartida))
        Me.DomicilioGB = New System.Windows.Forms.GroupBox()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CalleLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LocalidadCMB = New System.Windows.Forms.ComboBox()
        Me.PisoLbl = New System.Windows.Forms.Label()
        Me.PisoTxt = New System.Windows.Forms.TextBox()
        Me.LocalidadLbl = New System.Windows.Forms.Label()
        Me.CalleTxt = New System.Windows.Forms.TextBox()
        Me.NumeroTxt = New System.Windows.Forms.TextBox()
        Me.DomicilioGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'DomicilioGB
        '
        Me.DomicilioGB.Controls.Add(Me.CancelarBtn)
        Me.DomicilioGB.Controls.Add(Me.AceptarBtn)
        Me.DomicilioGB.Controls.Add(Me.ComboBox1)
        Me.DomicilioGB.Controls.Add(Me.Label3)
        Me.DomicilioGB.Controls.Add(Me.CalleLbl)
        Me.DomicilioGB.Controls.Add(Me.Label2)
        Me.DomicilioGB.Controls.Add(Me.LocalidadCMB)
        Me.DomicilioGB.Controls.Add(Me.PisoLbl)
        Me.DomicilioGB.Controls.Add(Me.PisoTxt)
        Me.DomicilioGB.Controls.Add(Me.LocalidadLbl)
        Me.DomicilioGB.Controls.Add(Me.CalleTxt)
        Me.DomicilioGB.Controls.Add(Me.NumeroTxt)
        Me.DomicilioGB.Location = New System.Drawing.Point(12, 12)
        Me.DomicilioGB.Name = "DomicilioGB"
        Me.DomicilioGB.Size = New System.Drawing.Size(257, 208)
        Me.DomicilioGB.TabIndex = 30
        Me.DomicilioGB.TabStop = False
        Me.DomicilioGB.Text = "Alta Lugar Partida"
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Image = CType(resources.GetObject("CancelarBtn.Image"), System.Drawing.Image)
        Me.CancelarBtn.Location = New System.Drawing.Point(134, 165)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(82, 24)
        Me.CancelarBtn.TabIndex = 26
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Image = CType(resources.GetObject("AceptarBtn.Image"), System.Drawing.Image)
        Me.AceptarBtn.Location = New System.Drawing.Point(46, 165)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(82, 24)
        Me.AceptarBtn.TabIndex = 25
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(88, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Provincia"
        '
        'CalleLbl
        '
        Me.CalleLbl.AutoSize = True
        Me.CalleLbl.Location = New System.Drawing.Point(25, 24)
        Me.CalleLbl.Name = "CalleLbl"
        Me.CalleLbl.Size = New System.Drawing.Size(29, 13)
        Me.CalleLbl.TabIndex = 3
        Me.CalleLbl.Text = "País"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código Postal"
        '
        'LocalidadCMB
        '
        Me.LocalidadCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LocalidadCMB.FormattingEnabled = True
        Me.LocalidadCMB.Location = New System.Drawing.Point(88, 102)
        Me.LocalidadCMB.Name = "LocalidadCMB"
        Me.LocalidadCMB.Size = New System.Drawing.Size(154, 21)
        Me.LocalidadCMB.TabIndex = 9
        '
        'PisoLbl
        '
        Me.PisoLbl.AutoSize = True
        Me.PisoLbl.Location = New System.Drawing.Point(18, 133)
        Me.PisoLbl.Name = "PisoLbl"
        Me.PisoLbl.Size = New System.Drawing.Size(52, 13)
        Me.PisoLbl.TabIndex = 5
        Me.PisoLbl.Text = "Dirección"
        '
        'PisoTxt
        '
        Me.PisoTxt.Location = New System.Drawing.Point(88, 130)
        Me.PisoTxt.Name = "PisoTxt"
        Me.PisoTxt.Size = New System.Drawing.Size(154, 20)
        Me.PisoTxt.TabIndex = 13
        '
        'LocalidadLbl
        '
        Me.LocalidadLbl.AutoSize = True
        Me.LocalidadLbl.Location = New System.Drawing.Point(17, 105)
        Me.LocalidadLbl.Name = "LocalidadLbl"
        Me.LocalidadLbl.Size = New System.Drawing.Size(53, 13)
        Me.LocalidadLbl.TabIndex = 13
        Me.LocalidadLbl.Text = "Localidad"
        '
        'CalleTxt
        '
        Me.CalleTxt.Location = New System.Drawing.Point(88, 21)
        Me.CalleTxt.Name = "CalleTxt"
        Me.CalleTxt.Size = New System.Drawing.Size(154, 20)
        Me.CalleTxt.TabIndex = 11
        '
        'NumeroTxt
        '
        Me.NumeroTxt.Location = New System.Drawing.Point(88, 76)
        Me.NumeroTxt.Name = "NumeroTxt"
        Me.NumeroTxt.Size = New System.Drawing.Size(154, 20)
        Me.NumeroTxt.TabIndex = 12
        '
        'altapartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 233)
        Me.Controls.Add(Me.DomicilioGB)
        Me.Name = "altapartida"
        Me.Text = "Alta Lugar Partida- Hermes S.R.L."
        Me.DomicilioGB.ResumeLayout(False)
        Me.DomicilioGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DomicilioGB As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CalleLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LocalidadCMB As System.Windows.Forms.ComboBox
    Friend WithEvents PisoLbl As System.Windows.Forms.Label
    Friend WithEvents PisoTxt As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadLbl As System.Windows.Forms.Label
    Friend WithEvents CalleTxt As System.Windows.Forms.TextBox
    Friend WithEvents NumeroTxt As System.Windows.Forms.TextBox
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
End Class
