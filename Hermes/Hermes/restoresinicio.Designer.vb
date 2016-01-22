<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class restoresinicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(restoresinicio))
        Me.BackupGB = New System.Windows.Forms.GroupBox()
        Me.RutaTxt = New System.Windows.Forms.TextBox()
        Me.DestinoLbl = New System.Windows.Forms.Label()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackupGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackupGB
        '
        Me.BackupGB.Controls.Add(Me.RutaTxt)
        Me.BackupGB.Controls.Add(Me.AceptarBtn)
        Me.BackupGB.Controls.Add(Me.BuscarBtn)
        Me.BackupGB.Controls.Add(Me.CancelarBtn)
        Me.BackupGB.Controls.Add(Me.DestinoLbl)
        Me.BackupGB.Location = New System.Drawing.Point(12, 12)
        Me.BackupGB.Name = "BackupGB"
        Me.BackupGB.Size = New System.Drawing.Size(420, 92)
        Me.BackupGB.TabIndex = 13
        Me.BackupGB.TabStop = False
        Me.BackupGB.Text = "Restore"
        '
        'RutaTxt
        '
        Me.RutaTxt.Location = New System.Drawing.Point(95, 27)
        Me.RutaTxt.Name = "RutaTxt"
        Me.RutaTxt.ReadOnly = True
        Me.RutaTxt.Size = New System.Drawing.Size(284, 20)
        Me.RutaTxt.TabIndex = 0
        Me.RutaTxt.Text = "c:\Program Files\Microsoft SQL Server\MSSQL11.KAREN\MSSQL\Backup\"
        '
        'DestinoLbl
        '
        Me.DestinoLbl.AutoSize = True
        Me.DestinoLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DestinoLbl.Location = New System.Drawing.Point(9, 30)
        Me.DestinoLbl.Name = "DestinoLbl"
        Me.DestinoLbl.Size = New System.Drawing.Size(43, 13)
        Me.DestinoLbl.TabIndex = 2
        Me.DestinoLbl.Text = "Destino"
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Image = CType(resources.GetObject("AceptarBtn.Image"), System.Drawing.Image)
        Me.AceptarBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AceptarBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AceptarBtn.Location = New System.Drawing.Point(121, 53)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(82, 24)
        Me.AceptarBtn.TabIndex = 12
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Image = CType(resources.GetObject("BuscarBtn.Image"), System.Drawing.Image)
        Me.BuscarBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BuscarBtn.Location = New System.Drawing.Point(385, 20)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(29, 32)
        Me.BuscarBtn.TabIndex = 1
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Image = CType(resources.GetObject("CancelarBtn.Image"), System.Drawing.Image)
        Me.CancelarBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CancelarBtn.Location = New System.Drawing.Point(209, 53)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(82, 24)
        Me.CancelarBtn.TabIndex = 13
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'restoresinicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 118)
        Me.Controls.Add(Me.BackupGB)
        Me.Name = "restoresinicio"
        Me.Text = "restoresinicio"
        Me.BackupGB.ResumeLayout(False)
        Me.BackupGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackupGB As System.Windows.Forms.GroupBox
    Friend WithEvents RutaTxt As System.Windows.Forms.TextBox
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents DestinoLbl As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
