<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsorden1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsadmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsclientes210 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tschofer220 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsrodado230 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tschofrod = New System.Windows.Forms.ToolStripMenuItem()
        Me.tschofrodasignar241 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tschofrodver242 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsfacturacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsfacturaciongestion410 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsinfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tschoque510 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbajas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbajasclientes521 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbajaschoques522 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbajaspaquetes523 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbajasrodados524 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbajastransportes525 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstranshist530 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 299)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(931, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(79, 17)
        Me.ToolStripStatusLabel.Text = "Hermes S.R.L."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsorden1, Me.tsadmin, Me.tsfacturacion, Me.tsinfo, Me.tspermisos, Me.tsseguridad, Me.tsopciones})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(931, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsorden1
        '
        Me.tsorden1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsorden1.Name = "tsorden1"
        Me.tsorden1.Size = New System.Drawing.Size(100, 20)
        Me.tsorden1.Text = "Orden de Envío"
        '
        'tsadmin
        '
        Me.tsadmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsclientes210, Me.tschofer220, Me.tsrodado230, Me.tschofrod})
        Me.tsadmin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsadmin.Name = "tsadmin"
        Me.tsadmin.Size = New System.Drawing.Size(100, 20)
        Me.tsadmin.Text = "Administración"
        '
        'tsclientes210
        '
        Me.tsclientes210.BackColor = System.Drawing.SystemColors.Control
        Me.tsclientes210.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsclientes210.Name = "tsclientes210"
        Me.tsclientes210.Size = New System.Drawing.Size(186, 22)
        Me.tsclientes210.Text = "Clientes"
        '
        'tschofer220
        '
        Me.tschofer220.BackColor = System.Drawing.SystemColors.Control
        Me.tschofer220.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tschofer220.Name = "tschofer220"
        Me.tschofer220.Size = New System.Drawing.Size(186, 22)
        Me.tschofer220.Text = "Chofer"
        '
        'tsrodado230
        '
        Me.tsrodado230.BackColor = System.Drawing.SystemColors.Control
        Me.tsrodado230.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsrodado230.Name = "tsrodado230"
        Me.tsrodado230.Size = New System.Drawing.Size(186, 22)
        Me.tsrodado230.Text = "Rodado"
        '
        'tschofrod
        '
        Me.tschofrod.BackColor = System.Drawing.SystemColors.Control
        Me.tschofrod.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tschofrodasignar241, Me.tschofrodver242})
        Me.tschofrod.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tschofrod.Name = "tschofrod"
        Me.tschofrod.Size = New System.Drawing.Size(186, 22)
        Me.tschofrod.Text = "Choferes por Rodado"
        '
        'tschofrodasignar241
        '
        Me.tschofrodasignar241.Name = "tschofrodasignar241"
        Me.tschofrodasignar241.Size = New System.Drawing.Size(114, 22)
        Me.tschofrodasignar241.Text = "Asignar"
        '
        'tschofrodver242
        '
        Me.tschofrodver242.Name = "tschofrodver242"
        Me.tschofrodver242.Size = New System.Drawing.Size(114, 22)
        Me.tschofrodver242.Text = "Ver"
        '
        'tsfacturacion
        '
        Me.tsfacturacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsfacturaciongestion410})
        Me.tsfacturacion.Name = "tsfacturacion"
        Me.tsfacturacion.Size = New System.Drawing.Size(81, 20)
        Me.tsfacturacion.Text = "Facturación"
        '
        'tsfacturaciongestion410
        '
        Me.tsfacturaciongestion410.Name = "tsfacturaciongestion410"
        Me.tsfacturaciongestion410.Size = New System.Drawing.Size(114, 22)
        Me.tsfacturaciongestion410.Text = "Gestión"
        '
        'tsinfo
        '
        Me.tsinfo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tschoque510, Me.tsbajas, Me.tstranshist530})
        Me.tsinfo.Name = "tsinfo"
        Me.tsinfo.Size = New System.Drawing.Size(142, 20)
        Me.tsinfo.Text = "Información Estadística"
        '
        'tschoque510
        '
        Me.tschoque510.Name = "tschoque510"
        Me.tschoque510.Size = New System.Drawing.Size(191, 22)
        Me.tschoque510.Text = "Choques"
        '
        'tsbajas
        '
        Me.tsbajas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbajasclientes521, Me.tsbajaschoques522, Me.tsbajaspaquetes523, Me.tsbajasrodados524, Me.tsbajastransportes525})
        Me.tsbajas.Name = "tsbajas"
        Me.tsbajas.Size = New System.Drawing.Size(191, 22)
        Me.tsbajas.Text = "Bajas"
        '
        'tsbajasclientes521
        '
        Me.tsbajasclientes521.Name = "tsbajasclientes521"
        Me.tsbajasclientes521.Size = New System.Drawing.Size(135, 22)
        Me.tsbajasclientes521.Text = "Clientes"
        '
        'tsbajaschoques522
        '
        Me.tsbajaschoques522.Name = "tsbajaschoques522"
        Me.tsbajaschoques522.Size = New System.Drawing.Size(135, 22)
        Me.tsbajaschoques522.Text = "Choques"
        '
        'tsbajaspaquetes523
        '
        Me.tsbajaspaquetes523.Name = "tsbajaspaquetes523"
        Me.tsbajaspaquetes523.Size = New System.Drawing.Size(135, 22)
        Me.tsbajaspaquetes523.Text = "Paquetes"
        '
        'tsbajasrodados524
        '
        Me.tsbajasrodados524.Name = "tsbajasrodados524"
        Me.tsbajasrodados524.Size = New System.Drawing.Size(135, 22)
        Me.tsbajasrodados524.Text = "Rodados"
        '
        'tsbajastransportes525
        '
        Me.tsbajastransportes525.Name = "tsbajastransportes525"
        Me.tsbajastransportes525.Size = New System.Drawing.Size(135, 22)
        Me.tsbajastransportes525.Text = "Transportes"
        '
        'tstranshist530
        '
        Me.tstranshist530.Name = "tstranshist530"
        Me.tstranshist530.Size = New System.Drawing.Size(191, 22)
        Me.tstranshist530.Text = "Transportes Históricos"
        '
        'tspermisos
        '
        Me.tspermisos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsusuarios610, Me.tsfamilias620})
        Me.tspermisos.Name = "tspermisos"
        Me.tspermisos.Size = New System.Drawing.Size(67, 20)
        Me.tspermisos.Text = "Permisos"
        '
        'tsusuarios610
        '
        Me.tsusuarios610.Name = "tsusuarios610"
        Me.tsusuarios610.Size = New System.Drawing.Size(119, 22)
        Me.tsusuarios610.Text = "Usuarios"
        '
        'tsfamilias620
        '
        Me.tsfamilias620.Name = "tsfamilias620"
        Me.tsfamilias620.Size = New System.Drawing.Size(119, 22)
        Me.tsfamilias620.Text = "Familias"
        '
        'tsseguridad
        '
        Me.tsseguridad.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbitacora710, Me.tsbackup720, Me.tsrestore730})
        Me.tsseguridad.Name = "tsseguridad"
        Me.tsseguridad.Size = New System.Drawing.Size(72, 20)
        Me.tsseguridad.Text = "Seguridad"
        '
        'tsbitacora710
        '
        Me.tsbitacora710.Name = "tsbitacora710"
        Me.tsbitacora710.Size = New System.Drawing.Size(117, 22)
        Me.tsbitacora710.Text = "Bitácora"
        '
        'tsbackup720
        '
        Me.tsbackup720.Name = "tsbackup720"
        Me.tsbackup720.Size = New System.Drawing.Size(117, 22)
        Me.tsbackup720.Text = "Backup"
        '
        'tsrestore730
        '
        Me.tsrestore730.Name = "tsrestore730"
        Me.tsrestore730.Size = New System.Drawing.Size(117, 22)
        Me.tsrestore730.Text = "Restore"
        '
        'tsopciones
        '
        Me.tsopciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsdioma, Me.tspass830, Me.tssalir})
        Me.tsopciones.Name = "tsopciones"
        Me.tsopciones.ShowShortcutKeys = False
        Me.tsopciones.Size = New System.Drawing.Size(69, 20)
        Me.tsopciones.Text = "Opciones"
        '
        'tsdioma
        '
        Me.tsdioma.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tses810, Me.tsen820})
        Me.tsdioma.Name = "tsdioma"
        Me.tsdioma.Size = New System.Drawing.Size(182, 22)
        Me.tsdioma.Text = "Cambiar Idioma"
        '
        'tses810
        '
        Me.tses810.Name = "tses810"
        Me.tses810.Size = New System.Drawing.Size(107, 22)
        Me.tses810.Text = "es-AR"
        '
        'tsen820
        '
        Me.tsen820.Name = "tsen820"
        Me.tsen820.Size = New System.Drawing.Size(107, 22)
        Me.tsen820.Text = "en-EN"
        '
        'tspass830
        '
        Me.tspass830.Name = "tspass830"
        Me.tspass830.Size = New System.Drawing.Size(182, 22)
        Me.tspass830.Text = "Cambiar Contraseña"
        '
        'tssalir
        '
        Me.tssalir.Name = "tssalir"
        Me.tssalir.Size = New System.Drawing.Size(182, 22)
        Me.tssalir.Text = "Salir"
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(931, 321)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "inicio"
        Me.Text = "Inicio - Hermes S.R.L."
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsadmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsorden1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsfacturacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsinfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsseguridad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsclientes210 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tschofer220 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsrodado230 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tschoque510 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbajas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbajasclientes521 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbajaschoques522 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbajaspaquetes523 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbajasrodados524 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbajastransportes525 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstranshist530 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbitacora710 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbackup720 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsrestore730 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsopciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsdioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsfacturaciongestion410 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspermisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsusuarios610 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsfamilias620 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tschofrod As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tschofrodasignar241 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tschofrodver242 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tses810 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsen820 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspass830 As System.Windows.Forms.ToolStripMenuItem

End Class
