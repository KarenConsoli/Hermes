<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuariopatente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuariopatente))
        Me.PatentesGB = New System.Windows.Forms.GroupBox()
        Me.checknoasig = New System.Windows.Forms.CheckedListBox()
        Me.DenPatentesGB = New System.Windows.Forms.GroupBox()
        Me.checkasig = New System.Windows.Forms.CheckedListBox()
        Me.UsuarioLbl = New System.Windows.Forms.Label()
        Me.PatNegadasGB = New System.Windows.Forms.GroupBox()
        Me.checkneg = New System.Windows.Forms.CheckedListBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.PatentesGB.SuspendLayout()
        Me.DenPatentesGB.SuspendLayout()
        Me.PatNegadasGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'PatentesGB
        '
        resources.ApplyResources(Me.PatentesGB, "PatentesGB")
        Me.PatentesGB.Controls.Add(Me.checknoasig)
        Me.PatentesGB.Name = "PatentesGB"
        Me.PatentesGB.TabStop = False
        '
        'checknoasig
        '
        resources.ApplyResources(Me.checknoasig, "checknoasig")
        Me.checknoasig.FormattingEnabled = True
        Me.checknoasig.Name = "checknoasig"
        '
        'DenPatentesGB
        '
        resources.ApplyResources(Me.DenPatentesGB, "DenPatentesGB")
        Me.DenPatentesGB.Controls.Add(Me.checkasig)
        Me.DenPatentesGB.Name = "DenPatentesGB"
        Me.DenPatentesGB.TabStop = False
        '
        'checkasig
        '
        resources.ApplyResources(Me.checkasig, "checkasig")
        Me.checkasig.FormattingEnabled = True
        Me.checkasig.Name = "checkasig"
        '
        'UsuarioLbl
        '
        resources.ApplyResources(Me.UsuarioLbl, "UsuarioLbl")
        Me.UsuarioLbl.Name = "UsuarioLbl"
        '
        'PatNegadasGB
        '
        resources.ApplyResources(Me.PatNegadasGB, "PatNegadasGB")
        Me.PatNegadasGB.Controls.Add(Me.checkneg)
        Me.PatNegadasGB.Name = "PatNegadasGB"
        Me.PatNegadasGB.TabStop = False
        '
        'checkneg
        '
        resources.ApplyResources(Me.checkneg, "checkneg")
        Me.checkneg.FormattingEnabled = True
        Me.checkneg.Name = "checkneg"
        '
        'txtusuario
        '
        resources.ApplyResources(Me.txtusuario, "txtusuario")
        Me.txtusuario.Name = "txtusuario"
        '
        'PanelSuperior
        '
        resources.ApplyResources(Me.PanelSuperior, "PanelSuperior")
        Me.PanelSuperior.Name = "PanelSuperior"
        '
        'BuscarBtn
        '
        resources.ApplyResources(Me.BuscarBtn, "BuscarBtn")
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        resources.ApplyResources(Me.CancelarBtn, "CancelarBtn")
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        resources.ApplyResources(Me.AceptarBtn, "AceptarBtn")
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'usuariopatente
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.PatNegadasGB)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Controls.Add(Me.BuscarBtn)
        Me.Controls.Add(Me.PatentesGB)
        Me.Controls.Add(Me.UsuarioLbl)
        Me.Controls.Add(Me.DenPatentesGB)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Name = "usuariopatente"
        Me.PatentesGB.ResumeLayout(False)
        Me.DenPatentesGB.ResumeLayout(False)
        Me.PatNegadasGB.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PatentesGB As System.Windows.Forms.GroupBox
    Friend WithEvents checknoasig As System.Windows.Forms.CheckedListBox
    Friend WithEvents DenPatentesGB As System.Windows.Forms.GroupBox
    Friend WithEvents checkasig As System.Windows.Forms.CheckedListBox
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents UsuarioLbl As System.Windows.Forms.Label
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents PatNegadasGB As System.Windows.Forms.GroupBox
    Friend WithEvents checkneg As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Public WithEvents PanelSuperior As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
End Class
