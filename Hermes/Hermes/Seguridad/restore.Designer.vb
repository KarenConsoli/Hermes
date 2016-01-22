<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class restore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(restore))
        Me.BackupGB = New System.Windows.Forms.GroupBox()
        Me.RutaTxt = New System.Windows.Forms.TextBox()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.DestinoLbl = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.BackupGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackupGB
        '
        resources.ApplyResources(Me.BackupGB, "BackupGB")
        Me.BackupGB.Controls.Add(Me.RutaTxt)
        Me.BackupGB.Controls.Add(Me.AceptarBtn)
        Me.BackupGB.Controls.Add(Me.BuscarBtn)
        Me.BackupGB.Controls.Add(Me.CancelarBtn)
        Me.BackupGB.Controls.Add(Me.DestinoLbl)
        Me.BackupGB.Name = "BackupGB"
        Me.BackupGB.TabStop = False
        '
        'RutaTxt
        '
        resources.ApplyResources(Me.RutaTxt, "RutaTxt")
        Me.RutaTxt.Name = "RutaTxt"
        Me.RutaTxt.ReadOnly = True
        '
        'BuscarBtn
        '
        resources.ApplyResources(Me.BuscarBtn, "BuscarBtn")
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'DestinoLbl
        '
        resources.ApplyResources(Me.DestinoLbl, "DestinoLbl")
        Me.DestinoLbl.Name = "DestinoLbl"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")
        '
        'AceptarBtn
        '
        resources.ApplyResources(Me.AceptarBtn, "AceptarBtn")
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        resources.ApplyResources(Me.CancelarBtn, "CancelarBtn")
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'restore
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BackupGB)
        Me.Name = "restore"
        Me.BackupGB.ResumeLayout(False)
        Me.BackupGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackupGB As System.Windows.Forms.GroupBox
    Friend WithEvents RutaTxt As System.Windows.Forms.TextBox
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents DestinoLbl As System.Windows.Forms.Label
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
