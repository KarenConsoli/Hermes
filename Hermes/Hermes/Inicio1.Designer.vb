<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio1))
        Me.tspermisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsusuarios610 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsfamilias620 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsseguridad = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbitacora710 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbackup720 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsrestore730 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsopciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsdioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.tses810 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsen820 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspass830 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsorden1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsadmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsclientes210 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tschofer220 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsrodado230 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsfacturacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsfacturaciongestion410 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tspermisos
        '
        Me.tspermisos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsusuarios610, Me.tsfamilias620})
        Me.tspermisos.Name = "tspermisos"
        resources.ApplyResources(Me.tspermisos, "tspermisos")
        '
        'tsusuarios610
        '
        Me.tsusuarios610.Name = "tsusuarios610"
        resources.ApplyResources(Me.tsusuarios610, "tsusuarios610")
        '
        'tsfamilias620
        '
        Me.tsfamilias620.Name = "tsfamilias620"
        resources.ApplyResources(Me.tsfamilias620, "tsfamilias620")
        '
        'tsseguridad
        '
        Me.tsseguridad.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbitacora710, Me.tsbackup720, Me.tsrestore730})
        Me.tsseguridad.Name = "tsseguridad"
        resources.ApplyResources(Me.tsseguridad, "tsseguridad")
        '
        'tsbitacora710
        '
        Me.tsbitacora710.Name = "tsbitacora710"
        resources.ApplyResources(Me.tsbitacora710, "tsbitacora710")
        '
        'tsbackup720
        '
        Me.tsbackup720.Name = "tsbackup720"
        resources.ApplyResources(Me.tsbackup720, "tsbackup720")
        '
        'tsrestore730
        '
        Me.tsrestore730.Name = "tsrestore730"
        resources.ApplyResources(Me.tsrestore730, "tsrestore730")
        '
        'tsopciones
        '
        Me.tsopciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsdioma, Me.tspass830, Me.AyudaToolStripMenuItem, Me.tssalir})
        Me.tsopciones.Name = "tsopciones"
        resources.ApplyResources(Me.tsopciones, "tsopciones")
        '
        'tsdioma
        '
        Me.tsdioma.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tses810, Me.tsen820})
        Me.tsdioma.Name = "tsdioma"
        resources.ApplyResources(Me.tsdioma, "tsdioma")
        '
        'tses810
        '
        Me.tses810.Name = "tses810"
        resources.ApplyResources(Me.tses810, "tses810")
        '
        'tsen820
        '
        Me.tsen820.Name = "tsen820"
        resources.ApplyResources(Me.tsen820, "tsen820")
        '
        'tspass830
        '
        Me.tspass830.Name = "tspass830"
        resources.ApplyResources(Me.tspass830, "tspass830")
        '
        'tssalir
        '
        Me.tssalir.Name = "tssalir"
        resources.ApplyResources(Me.tssalir, "tssalir")
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        resources.ApplyResources(Me.StatusStrip, "StatusStrip")
        Me.StatusStrip.Name = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        resources.ApplyResources(Me.ToolStripStatusLabel, "ToolStripStatusLabel")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsorden1, Me.tsadmin, Me.tsfacturacion, Me.tspermisos, Me.tsseguridad, Me.tsopciones})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        '
        'tsorden1
        '
        Me.tsorden1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsorden1.Name = "tsorden1"
        resources.ApplyResources(Me.tsorden1, "tsorden1")
        '
        'tsadmin
        '
        Me.tsadmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsclientes210, Me.tschofer220, Me.tsrodado230, Me.ChoqueToolStripMenuItem})
        Me.tsadmin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsadmin.Name = "tsadmin"
        resources.ApplyResources(Me.tsadmin, "tsadmin")
        '
        'tsclientes210
        '
        Me.tsclientes210.BackColor = System.Drawing.SystemColors.Control
        Me.tsclientes210.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsclientes210.Name = "tsclientes210"
        resources.ApplyResources(Me.tsclientes210, "tsclientes210")
        '
        'tschofer220
        '
        Me.tschofer220.BackColor = System.Drawing.SystemColors.Control
        Me.tschofer220.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tschofer220.Name = "tschofer220"
        resources.ApplyResources(Me.tschofer220, "tschofer220")
        '
        'tsrodado230
        '
        Me.tsrodado230.BackColor = System.Drawing.SystemColors.Control
        Me.tsrodado230.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsrodado230.Name = "tsrodado230"
        resources.ApplyResources(Me.tsrodado230, "tsrodado230")
        '
        'ChoqueToolStripMenuItem
        '
        Me.ChoqueToolStripMenuItem.Name = "ChoqueToolStripMenuItem"
        resources.ApplyResources(Me.ChoqueToolStripMenuItem, "ChoqueToolStripMenuItem")
        '
        'tsfacturacion
        '
        Me.tsfacturacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsfacturaciongestion410})
        Me.tsfacturacion.Name = "tsfacturacion"
        resources.ApplyResources(Me.tsfacturacion, "tsfacturacion")
        '
        'tsfacturaciongestion410
        '
        Me.tsfacturaciongestion410.Name = "tsfacturaciongestion410"
        resources.ApplyResources(Me.tsfacturaciongestion410, "tsfacturaciongestion410")
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        resources.ApplyResources(Me.AyudaToolStripMenuItem, "AyudaToolStripMenuItem")
        '
        'inicio1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "inicio1"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents tspermisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsusuarios610 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsfamilias620 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsseguridad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbitacora710 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbackup720 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsrestore730 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsopciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsdioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tses810 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsen820 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspass830 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsorden1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsadmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsclientes210 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tschofer220 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsrodado230 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsfacturacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsfacturaciongestion410 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ChoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
