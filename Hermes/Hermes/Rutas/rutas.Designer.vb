<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rutas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rutas))
        Me.frmusuarios = New System.Windows.Forms.GroupBox()
        Me.OperacionGB = New System.Windows.Forms.GroupBox()
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PrimeroBtn = New System.Windows.Forms.Button()
        Me.UltimoBtn = New System.Windows.Forms.Button()
        Me.SiguienteBtn = New System.Windows.Forms.Button()
        Me.RecargarBtn = New System.Windows.Forms.Button()
        Me.AnteriorBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AgregarBtn = New System.Windows.Forms.Button()
        Me.ModificarBtn = New System.Windows.Forms.Button()
        Me.EliminarBtn = New System.Windows.Forms.Button()
        Me.PuntoLlegadaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.frmusuarios.SuspendLayout()
        Me.OperacionGB.SuspendLayout()
        Me.RegistrosGB.SuspendLayout()
        CType(Me.UsuarioDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntoLlegadaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmusuarios
        '
        Me.frmusuarios.Controls.Add(Me.Button6)
        Me.frmusuarios.Controls.Add(Me.PrimeroBtn)
        Me.frmusuarios.Controls.Add(Me.UltimoBtn)
        Me.frmusuarios.Controls.Add(Me.SiguienteBtn)
        Me.frmusuarios.Controls.Add(Me.RecargarBtn)
        Me.frmusuarios.Controls.Add(Me.AnteriorBtn)
        Me.frmusuarios.Controls.Add(Me.OperacionGB)
        Me.frmusuarios.Controls.Add(Me.BuscarCmb)
        Me.frmusuarios.Controls.Add(Me.BuscarPorLbl)
        Me.frmusuarios.Controls.Add(Me.BusquedaTxt)
        Me.frmusuarios.Controls.Add(Me.IgualLbl)
        Me.frmusuarios.Controls.Add(Me.RegistrosGB)
        Me.frmusuarios.Controls.Add(Me.BuscarBtn)
        Me.frmusuarios.Location = New System.Drawing.Point(12, 12)
        Me.frmusuarios.Name = "frmusuarios"
        Me.frmusuarios.Size = New System.Drawing.Size(486, 553)
        Me.frmusuarios.TabIndex = 77
        Me.frmusuarios.TabStop = False
        Me.frmusuarios.Text = "Gestion de Rutas"
        '
        'OperacionGB
        '
        Me.OperacionGB.Controls.Add(Me.Button2)
        Me.OperacionGB.Controls.Add(Me.Button1)
        Me.OperacionGB.Controls.Add(Me.AgregarBtn)
        Me.OperacionGB.Controls.Add(Me.ModificarBtn)
        Me.OperacionGB.Controls.Add(Me.EliminarBtn)
        Me.OperacionGB.Location = New System.Drawing.Point(14, 66)
        Me.OperacionGB.Name = "OperacionGB"
        Me.OperacionGB.Size = New System.Drawing.Size(459, 61)
        Me.OperacionGB.TabIndex = 56
        Me.OperacionGB.TabStop = False
        Me.OperacionGB.Text = "Operaciones"
        '
        'BuscarCmb
        '
        Me.BuscarCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BuscarCmb.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarCmb.FormattingEnabled = True
        Me.BuscarCmb.Location = New System.Drawing.Point(100, 31)
        Me.BuscarCmb.Name = "BuscarCmb"
        Me.BuscarCmb.Size = New System.Drawing.Size(94, 23)
        Me.BuscarCmb.TabIndex = 0
        '
        'BuscarPorLbl
        '
        Me.BuscarPorLbl.AutoSize = True
        Me.BuscarPorLbl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarPorLbl.Location = New System.Drawing.Point(27, 36)
        Me.BuscarPorLbl.Name = "BuscarPorLbl"
        Me.BuscarPorLbl.Size = New System.Drawing.Size(67, 15)
        Me.BuscarPorLbl.TabIndex = 41
        Me.BuscarPorLbl.Text = "Buscar por"
        '
        'BusquedaTxt
        '
        Me.BusquedaTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BusquedaTxt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusquedaTxt.Location = New System.Drawing.Point(251, 31)
        Me.BusquedaTxt.Name = "BusquedaTxt"
        Me.BusquedaTxt.Size = New System.Drawing.Size(122, 23)
        Me.BusquedaTxt.TabIndex = 1
        '
        'IgualLbl
        '
        Me.IgualLbl.AutoSize = True
        Me.IgualLbl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IgualLbl.Location = New System.Drawing.Point(200, 34)
        Me.IgualLbl.Name = "IgualLbl"
        Me.IgualLbl.Size = New System.Drawing.Size(45, 15)
        Me.IgualLbl.TabIndex = 43
        Me.IgualLbl.Text = "igual a"
        '
        'RegistrosGB
        '
        Me.RegistrosGB.Controls.Add(Me.UsuarioDG)
        Me.RegistrosGB.Location = New System.Drawing.Point(11, 133)
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
        Me.UsuarioDG.AutoGenerateColumns = False
        Me.UsuarioDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuarioDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodUsuCAB, Me.UsuarioCAB, Me.ApellidoCAB, Me.NombreCAB, Me.CorreoCAB, Me.EdadCAB})
        Me.UsuarioDG.DataSource = Me.PuntoLlegadaBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsuarioDG.DefaultCellStyle = DataGridViewCellStyle3
        Me.UsuarioDG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsuarioDG.Location = New System.Drawing.Point(3, 16)
        Me.UsuarioDG.MultiSelect = False
        Me.UsuarioDG.Name = "UsuarioDG"
        Me.UsuarioDG.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UsuarioDG.RowsDefaultCellStyle = DataGridViewCellStyle4
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
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(391, 511)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(82, 32)
        Me.Button6.TabIndex = 42
        Me.Button6.Text = "Salir"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PrimeroBtn
        '
        Me.PrimeroBtn.Image = CType(resources.GetObject("PrimeroBtn.Image"), System.Drawing.Image)
        Me.PrimeroBtn.Location = New System.Drawing.Point(159, 511)
        Me.PrimeroBtn.Name = "PrimeroBtn"
        Me.PrimeroBtn.Size = New System.Drawing.Size(32, 32)
        Me.PrimeroBtn.TabIndex = 69
        Me.PrimeroBtn.UseVisualStyleBackColor = True
        '
        'UltimoBtn
        '
        Me.UltimoBtn.Image = CType(resources.GetObject("UltimoBtn.Image"), System.Drawing.Image)
        Me.UltimoBtn.Location = New System.Drawing.Point(306, 511)
        Me.UltimoBtn.Name = "UltimoBtn"
        Me.UltimoBtn.Size = New System.Drawing.Size(32, 32)
        Me.UltimoBtn.TabIndex = 72
        Me.UltimoBtn.UseVisualStyleBackColor = True
        '
        'SiguienteBtn
        '
        Me.SiguienteBtn.Image = CType(resources.GetObject("SiguienteBtn.Image"), System.Drawing.Image)
        Me.SiguienteBtn.Location = New System.Drawing.Point(268, 511)
        Me.SiguienteBtn.Name = "SiguienteBtn"
        Me.SiguienteBtn.Size = New System.Drawing.Size(32, 32)
        Me.SiguienteBtn.TabIndex = 71
        Me.SiguienteBtn.UseVisualStyleBackColor = True
        '
        'RecargarBtn
        '
        Me.RecargarBtn.Image = CType(resources.GetObject("RecargarBtn.Image"), System.Drawing.Image)
        Me.RecargarBtn.Location = New System.Drawing.Point(232, 511)
        Me.RecargarBtn.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.RecargarBtn.Name = "RecargarBtn"
        Me.RecargarBtn.Size = New System.Drawing.Size(32, 32)
        Me.RecargarBtn.TabIndex = 68
        Me.RecargarBtn.UseVisualStyleBackColor = True
        '
        'AnteriorBtn
        '
        Me.AnteriorBtn.Image = CType(resources.GetObject("AnteriorBtn.Image"), System.Drawing.Image)
        Me.AnteriorBtn.Location = New System.Drawing.Point(194, 511)
        Me.AnteriorBtn.Name = "AnteriorBtn"
        Me.AnteriorBtn.Size = New System.Drawing.Size(32, 32)
        Me.AnteriorBtn.TabIndex = 70
        Me.AnteriorBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(241, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 24)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Fechas"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(321, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Seleccionar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AgregarBtn
        '
        Me.AgregarBtn.Image = CType(resources.GetObject("AgregarBtn.Image"), System.Drawing.Image)
        Me.AgregarBtn.Location = New System.Drawing.Point(7, 22)
        Me.AgregarBtn.Name = "AgregarBtn"
        Me.AgregarBtn.Size = New System.Drawing.Size(67, 24)
        Me.AgregarBtn.TabIndex = 3
        Me.AgregarBtn.Text = "Nuevo"
        Me.AgregarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AgregarBtn.UseVisualStyleBackColor = True
        '
        'ModificarBtn
        '
        Me.ModificarBtn.Image = CType(resources.GetObject("ModificarBtn.Image"), System.Drawing.Image)
        Me.ModificarBtn.Location = New System.Drawing.Point(80, 22)
        Me.ModificarBtn.Name = "ModificarBtn"
        Me.ModificarBtn.Size = New System.Drawing.Size(76, 24)
        Me.ModificarBtn.TabIndex = 4
        Me.ModificarBtn.Text = "Modificar "
        Me.ModificarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ModificarBtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        Me.EliminarBtn.Image = CType(resources.GetObject("EliminarBtn.Image"), System.Drawing.Image)
        Me.EliminarBtn.Location = New System.Drawing.Point(162, 22)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(73, 24)
        Me.EliminarBtn.TabIndex = 5
        Me.EliminarBtn.Text = "Eliminar"
        Me.EliminarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarBtn.Image = CType(resources.GetObject("BuscarBtn.Image"), System.Drawing.Image)
        Me.BuscarBtn.Location = New System.Drawing.Point(379, 26)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(79, 34)
        Me.BuscarBtn.TabIndex = 2
        Me.BuscarBtn.Text = "&Buscar"
        Me.BuscarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'rutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 574)
        Me.Controls.Add(Me.frmusuarios)
        Me.Name = "rutas"
        Me.Text = "Gestión Rutas- Hermes S.R.L."
        Me.frmusuarios.ResumeLayout(False)
        Me.frmusuarios.PerformLayout()
        Me.OperacionGB.ResumeLayout(False)
        Me.RegistrosGB.ResumeLayout(False)
        CType(Me.UsuarioDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntoLlegadaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmusuarios As System.Windows.Forms.GroupBox
    Friend WithEvents PrimeroBtn As System.Windows.Forms.Button
    Friend WithEvents UltimoBtn As System.Windows.Forms.Button
    Friend WithEvents SiguienteBtn As System.Windows.Forms.Button
    Friend WithEvents RecargarBtn As System.Windows.Forms.Button
    Friend WithEvents AnteriorBtn As System.Windows.Forms.Button
    Friend WithEvents OperacionGB As System.Windows.Forms.GroupBox
    Friend WithEvents AgregarBtn As System.Windows.Forms.Button
    Friend WithEvents ModificarBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
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
    Friend WithEvents PuntoLlegadaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdPuntoLlegadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdpaispuntollegadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdprovinciapuntollegadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CppuntollegadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirpuntollegadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
