<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contranshistorico
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(contranshistorico))
        Me.frmusuarios = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PrimeroBtn = New System.Windows.Forms.Button()
        Me.UltimoBtn = New System.Windows.Forms.Button()
        Me.SiguienteBtn = New System.Windows.Forms.Button()
        Me.RecargarBtn = New System.Windows.Forms.Button()
        Me.AnteriorBtn = New System.Windows.Forms.Button()
        Me.BuscarCmb = New System.Windows.Forms.ComboBox()
        Me.BuscarPorLbl = New System.Windows.Forms.Label()
        Me.BusquedaTxt = New System.Windows.Forms.TextBox()
        Me.IgualLbl = New System.Windows.Forms.Label()
        Me.RegistrosGB = New System.Windows.Forms.GroupBox()
        Me.UsuarioDG = New System.Windows.Forms.DataGridView()
        Me.CodUsuCAB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioCAB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoCAB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCAB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoCAB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadCAB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.frmusuarios.SuspendLayout()
        Me.RegistrosGB.SuspendLayout()
        CType(Me.UsuarioDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmusuarios
        '
        Me.frmusuarios.Controls.Add(Me.Button3)
        Me.frmusuarios.Controls.Add(Me.Button6)
        Me.frmusuarios.Controls.Add(Me.PrimeroBtn)
        Me.frmusuarios.Controls.Add(Me.UltimoBtn)
        Me.frmusuarios.Controls.Add(Me.SiguienteBtn)
        Me.frmusuarios.Controls.Add(Me.RecargarBtn)
        Me.frmusuarios.Controls.Add(Me.AnteriorBtn)
        Me.frmusuarios.Controls.Add(Me.BuscarCmb)
        Me.frmusuarios.Controls.Add(Me.BuscarPorLbl)
        Me.frmusuarios.Controls.Add(Me.BusquedaTxt)
        Me.frmusuarios.Controls.Add(Me.IgualLbl)
        Me.frmusuarios.Controls.Add(Me.RegistrosGB)
        Me.frmusuarios.Controls.Add(Me.BuscarBtn)
        Me.frmusuarios.Location = New System.Drawing.Point(12, 12)
        Me.frmusuarios.Name = "frmusuarios"
        Me.frmusuarios.Size = New System.Drawing.Size(486, 492)
        Me.frmusuarios.TabIndex = 78
        Me.frmusuarios.TabStop = False
        Me.frmusuarios.Text = "Consulta Transportes Históricos"
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(391, 455)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(82, 24)
        Me.Button6.TabIndex = 79
        Me.Button6.Text = "Salir"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PrimeroBtn
        '
        Me.PrimeroBtn.Image = CType(resources.GetObject("PrimeroBtn.Image"), System.Drawing.Image)
        Me.PrimeroBtn.Location = New System.Drawing.Point(14, 444)
        Me.PrimeroBtn.Name = "PrimeroBtn"
        Me.PrimeroBtn.Size = New System.Drawing.Size(32, 32)
        Me.PrimeroBtn.TabIndex = 69
        Me.PrimeroBtn.UseVisualStyleBackColor = True
        '
        'UltimoBtn
        '
        Me.UltimoBtn.Image = CType(resources.GetObject("UltimoBtn.Image"), System.Drawing.Image)
        Me.UltimoBtn.Location = New System.Drawing.Point(161, 444)
        Me.UltimoBtn.Name = "UltimoBtn"
        Me.UltimoBtn.Size = New System.Drawing.Size(32, 32)
        Me.UltimoBtn.TabIndex = 72
        Me.UltimoBtn.UseVisualStyleBackColor = True
        '
        'SiguienteBtn
        '
        Me.SiguienteBtn.Image = CType(resources.GetObject("SiguienteBtn.Image"), System.Drawing.Image)
        Me.SiguienteBtn.Location = New System.Drawing.Point(123, 444)
        Me.SiguienteBtn.Name = "SiguienteBtn"
        Me.SiguienteBtn.Size = New System.Drawing.Size(32, 32)
        Me.SiguienteBtn.TabIndex = 71
        Me.SiguienteBtn.UseVisualStyleBackColor = True
        '
        'RecargarBtn
        '
        Me.RecargarBtn.Image = CType(resources.GetObject("RecargarBtn.Image"), System.Drawing.Image)
        Me.RecargarBtn.Location = New System.Drawing.Point(87, 444)
        Me.RecargarBtn.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.RecargarBtn.Name = "RecargarBtn"
        Me.RecargarBtn.Size = New System.Drawing.Size(32, 32)
        Me.RecargarBtn.TabIndex = 68
        Me.RecargarBtn.UseVisualStyleBackColor = True
        '
        'AnteriorBtn
        '
        Me.AnteriorBtn.Image = CType(resources.GetObject("AnteriorBtn.Image"), System.Drawing.Image)
        Me.AnteriorBtn.Location = New System.Drawing.Point(49, 444)
        Me.AnteriorBtn.Name = "AnteriorBtn"
        Me.AnteriorBtn.Size = New System.Drawing.Size(32, 32)
        Me.AnteriorBtn.TabIndex = 70
        Me.AnteriorBtn.UseVisualStyleBackColor = True
        '
        'BuscarCmb
        '
        Me.BuscarCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BuscarCmb.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarCmb.FormattingEnabled = True
        Me.BuscarCmb.Location = New System.Drawing.Point(81, 31)
        Me.BuscarCmb.Name = "BuscarCmb"
        Me.BuscarCmb.Size = New System.Drawing.Size(94, 23)
        Me.BuscarCmb.TabIndex = 0
        '
        'BuscarPorLbl
        '
        Me.BuscarPorLbl.AutoSize = True
        Me.BuscarPorLbl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarPorLbl.Location = New System.Drawing.Point(8, 36)
        Me.BuscarPorLbl.Name = "BuscarPorLbl"
        Me.BuscarPorLbl.Size = New System.Drawing.Size(67, 15)
        Me.BuscarPorLbl.TabIndex = 41
        Me.BuscarPorLbl.Text = "Buscar por"
        '
        'BusquedaTxt
        '
        Me.BusquedaTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BusquedaTxt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusquedaTxt.Location = New System.Drawing.Point(232, 31)
        Me.BusquedaTxt.Name = "BusquedaTxt"
        Me.BusquedaTxt.Size = New System.Drawing.Size(122, 23)
        Me.BusquedaTxt.TabIndex = 1
        '
        'IgualLbl
        '
        Me.IgualLbl.AutoSize = True
        Me.IgualLbl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IgualLbl.Location = New System.Drawing.Point(181, 34)
        Me.IgualLbl.Name = "IgualLbl"
        Me.IgualLbl.Size = New System.Drawing.Size(45, 15)
        Me.IgualLbl.TabIndex = 43
        Me.IgualLbl.Text = "igual a"
        '
        'RegistrosGB
        '
        Me.RegistrosGB.Controls.Add(Me.UsuarioDG)
        Me.RegistrosGB.Location = New System.Drawing.Point(11, 66)
        Me.RegistrosGB.Name = "RegistrosGB"
        Me.RegistrosGB.Size = New System.Drawing.Size(465, 375)
        Me.RegistrosGB.TabIndex = 67
        Me.RegistrosGB.TabStop = False
        Me.RegistrosGB.Text = "Registros"
        '
        'UsuarioDG
        '
        Me.UsuarioDG.AllowUserToAddRows = False
        Me.UsuarioDG.AllowUserToDeleteRows = False
        Me.UsuarioDG.AllowUserToResizeColumns = False
        Me.UsuarioDG.AllowUserToResizeRows = False
        Me.UsuarioDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuarioDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodUsuCAB, Me.UsuarioCAB, Me.ApellidoCAB, Me.NombreCAB, Me.CorreoCAB, Me.EdadCAB})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsuarioDG.DefaultCellStyle = DataGridViewCellStyle1
        Me.UsuarioDG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsuarioDG.Location = New System.Drawing.Point(3, 16)
        Me.UsuarioDG.MultiSelect = False
        Me.UsuarioDG.Name = "UsuarioDG"
        Me.UsuarioDG.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UsuarioDG.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.UsuarioDG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UsuarioDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsuarioDG.Size = New System.Drawing.Size(459, 356)
        Me.UsuarioDG.StandardTab = True
        Me.UsuarioDG.TabIndex = 7
        '
        'CodUsuCAB
        '
        Me.CodUsuCAB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodUsuCAB.DataPropertyName = "CodUsu"
        Me.CodUsuCAB.HeaderText = "Código"
        Me.CodUsuCAB.Name = "CodUsuCAB"
        Me.CodUsuCAB.ReadOnly = True
        Me.CodUsuCAB.Visible = False
        Me.CodUsuCAB.Width = 70
        '
        'UsuarioCAB
        '
        Me.UsuarioCAB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UsuarioCAB.DataPropertyName = "Usuario"
        Me.UsuarioCAB.HeaderText = "Usuario"
        Me.UsuarioCAB.Name = "UsuarioCAB"
        Me.UsuarioCAB.ReadOnly = True
        '
        'ApellidoCAB
        '
        Me.ApellidoCAB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ApellidoCAB.DataPropertyName = "Apellido"
        Me.ApellidoCAB.HeaderText = "Apellido"
        Me.ApellidoCAB.Name = "ApellidoCAB"
        Me.ApellidoCAB.ReadOnly = True
        '
        'NombreCAB
        '
        Me.NombreCAB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NombreCAB.DataPropertyName = "Nombre"
        Me.NombreCAB.HeaderText = "Nombre"
        Me.NombreCAB.Name = "NombreCAB"
        Me.NombreCAB.ReadOnly = True
        Me.NombreCAB.Width = 105
        '
        'CorreoCAB
        '
        Me.CorreoCAB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CorreoCAB.DataPropertyName = "CorreoElectronico"
        Me.CorreoCAB.HeaderText = "Correo Electronico"
        Me.CorreoCAB.Name = "CorreoCAB"
        Me.CorreoCAB.ReadOnly = True
        Me.CorreoCAB.Width = 148
        '
        'EdadCAB
        '
        Me.EdadCAB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EdadCAB.DataPropertyName = "Edad"
        Me.EdadCAB.HeaderText = "Edad"
        Me.EdadCAB.Name = "EdadCAB"
        Me.EdadCAB.ReadOnly = True
        Me.EdadCAB.Width = 65
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarBtn.Image = CType(resources.GetObject("BuscarBtn.Image"), System.Drawing.Image)
        Me.BuscarBtn.Location = New System.Drawing.Point(360, 26)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(79, 34)
        Me.BuscarBtn.TabIndex = 2
        Me.BuscarBtn.Text = "&Buscar"
        Me.BuscarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.Location = New System.Drawing.Point(305, 455)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 83
        Me.Button3.Text = "Imprimir"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'contranshistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 507)
        Me.Controls.Add(Me.frmusuarios)
        Me.Name = "contranshistorico"
        Me.Text = "Consultar Transportes Históricos- Hermes S.R.L."
        Me.frmusuarios.ResumeLayout(False)
        Me.frmusuarios.PerformLayout()
        Me.RegistrosGB.ResumeLayout(False)
        CType(Me.UsuarioDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmusuarios As System.Windows.Forms.GroupBox
    Friend WithEvents PrimeroBtn As System.Windows.Forms.Button
    Friend WithEvents UltimoBtn As System.Windows.Forms.Button
    Friend WithEvents SiguienteBtn As System.Windows.Forms.Button
    Friend WithEvents RecargarBtn As System.Windows.Forms.Button
    Friend WithEvents AnteriorBtn As System.Windows.Forms.Button
    Friend WithEvents BuscarCmb As System.Windows.Forms.ComboBox
    Friend WithEvents BuscarPorLbl As System.Windows.Forms.Label
    Friend WithEvents BusquedaTxt As System.Windows.Forms.TextBox
    Friend WithEvents IgualLbl As System.Windows.Forms.Label
    Friend WithEvents RegistrosGB As System.Windows.Forms.GroupBox
    Friend WithEvents UsuarioDG As System.Windows.Forms.DataGridView
    Friend WithEvents CodUsuCAB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioCAB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoCAB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreCAB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorreoCAB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EdadCAB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
