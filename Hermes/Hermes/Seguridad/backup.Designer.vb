<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(backup))
        Me.BackupGB = New System.Windows.Forms.GroupBox()
        Me.RutaTxt = New System.Windows.Forms.TextBox()
        Me.partessel = New System.Windows.Forms.NumericUpDown()
        Me.VolumenLbl = New System.Windows.Forms.Label()
        Me.DestinoLbl = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.BackupGB.SuspendLayout()
        CType(Me.partessel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackupGB
        '
        resources.ApplyResources(Me.BackupGB, "BackupGB")
        Me.BackupGB.Controls.Add(Me.RutaTxt)
        Me.BackupGB.Controls.Add(Me.partessel)
        Me.BackupGB.Controls.Add(Me.BuscarBtn)
        Me.BackupGB.Controls.Add(Me.VolumenLbl)
        Me.BackupGB.Controls.Add(Me.DestinoLbl)
        Me.BackupGB.Name = "BackupGB"
        Me.BackupGB.TabStop = False
        '
        'RutaTxt
        '
        resources.ApplyResources(Me.RutaTxt, "RutaTxt")
        Me.RutaTxt.Name = "RutaTxt"
        '
        'partessel
        '
        resources.ApplyResources(Me.partessel, "partessel")
        Me.partessel.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.partessel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.partessel.Name = "partessel"
        Me.partessel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'VolumenLbl
        '
        resources.ApplyResources(Me.VolumenLbl, "VolumenLbl")
        Me.VolumenLbl.Name = "VolumenLbl"
        '
        'DestinoLbl
        '
        resources.ApplyResources(Me.DestinoLbl, "DestinoLbl")
        Me.DestinoLbl.Name = "DestinoLbl"
        '
        'SaveFileDialog1
        '
        resources.ApplyResources(Me.SaveFileDialog1, "SaveFileDialog1")
        '
        'FolderBrowserDialog1
        '
        resources.ApplyResources(Me.FolderBrowserDialog1, "FolderBrowserDialog1")
        '
        'BuscarBtn
        '
        resources.ApplyResources(Me.BuscarBtn, "BuscarBtn")
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.UseVisualStyleBackColor = True
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
        'backup
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BackupGB)
        Me.Controls.Add(Me.AceptarBtn)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Name = "backup"
        Me.BackupGB.ResumeLayout(False)
        Me.BackupGB.PerformLayout()
        CType(Me.partessel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackupGB As System.Windows.Forms.GroupBox
    Friend WithEvents RutaTxt As System.Windows.Forms.TextBox
    Friend WithEvents partessel As System.Windows.Forms.NumericUpDown
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents VolumenLbl As System.Windows.Forms.Label
    Friend WithEvents DestinoLbl As System.Windows.Forms.Label
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
