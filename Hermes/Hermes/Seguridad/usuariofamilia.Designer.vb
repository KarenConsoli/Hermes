<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuariofamilia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuariofamilia))
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.FamiliaGB = New System.Windows.Forms.GroupBox()
        Me.datagridfamilia = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datagridfamiliaasig = New System.Windows.Forms.CheckedListBox()
        Me.PanelSuperior.SuspendLayout()
        Me.FamiliaGB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        resources.ApplyResources(Me.PanelSuperior, "PanelSuperior")
        Me.PanelSuperior.Controls.Add(Me.GroupBox1)
        Me.PanelSuperior.Controls.Add(Me.txtusuario)
        Me.PanelSuperior.Controls.Add(Me.BuscarBtn)
        Me.PanelSuperior.Controls.Add(Me.Label1)
        Me.PanelSuperior.Controls.Add(Me.CancelarBtn)
        Me.PanelSuperior.Controls.Add(Me.AceptarBtn)
        Me.PanelSuperior.Controls.Add(Me.FamiliaGB)
        Me.PanelSuperior.Name = "PanelSuperior"
        '
        'txtusuario
        '
        resources.ApplyResources(Me.txtusuario, "txtusuario")
        Me.txtusuario.Name = "txtusuario"
        '
        'BuscarBtn
        '
        resources.ApplyResources(Me.BuscarBtn, "BuscarBtn")
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
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
        'FamiliaGB
        '
        Me.FamiliaGB.Controls.Add(Me.datagridfamilia)
        resources.ApplyResources(Me.FamiliaGB, "FamiliaGB")
        Me.FamiliaGB.Name = "FamiliaGB"
        Me.FamiliaGB.TabStop = False
        '
        'datagridfamilia
        '
        Me.datagridfamilia.FormattingEnabled = True
        resources.ApplyResources(Me.datagridfamilia, "datagridfamilia")
        Me.datagridfamilia.Name = "datagridfamilia"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.datagridfamiliaasig)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'datagridfamiliaasig
        '
        Me.datagridfamiliaasig.FormattingEnabled = True
        resources.ApplyResources(Me.datagridfamiliaasig, "datagridfamiliaasig")
        Me.datagridfamiliaasig.Name = "datagridfamiliaasig"
        '
        'usuariofamilia
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelSuperior)
        Me.Name = "usuariofamilia"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        Me.FamiliaGB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelSuperior As System.Windows.Forms.Panel
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents FamiliaGB As System.Windows.Forms.GroupBox
    Friend WithEvents datagridfamilia As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents datagridfamiliaasig As System.Windows.Forms.CheckedListBox
End Class
