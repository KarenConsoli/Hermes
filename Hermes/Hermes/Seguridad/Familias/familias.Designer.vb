<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class familias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(familias))
        Me.RegistrosGB = New System.Windows.Forms.GroupBox()
        Me.datagridfamilias = New System.Windows.Forms.DataGridView()
        Me.frmusuarios = New System.Windows.Forms.GroupBox()
        Me.OperacionGB = New System.Windows.Forms.GroupBox()
        Me.cmbbuscar = New System.Windows.Forms.ComboBox()
        Me.BuscarPorLbl = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.IgualLbl = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.AgregarBtn = New System.Windows.Forms.Button()
        Me.ModificarBtn = New System.Windows.Forms.Button()
        Me.EliminarBtn = New System.Windows.Forms.Button()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.RegistrosGB.SuspendLayout()
        CType(Me.datagridfamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmusuarios.SuspendLayout()
        Me.OperacionGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegistrosGB
        '
        resources.ApplyResources(Me.RegistrosGB, "RegistrosGB")
        Me.RegistrosGB.Controls.Add(Me.datagridfamilias)
        Me.RegistrosGB.Name = "RegistrosGB"
        Me.RegistrosGB.TabStop = False
        '
        'datagridfamilias
        '
        resources.ApplyResources(Me.datagridfamilias, "datagridfamilias")
        Me.datagridfamilias.AllowUserToAddRows = False
        Me.datagridfamilias.AllowUserToDeleteRows = False
        Me.datagridfamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridfamilias.Name = "datagridfamilias"
        Me.datagridfamilias.ReadOnly = True
        '
        'frmusuarios
        '
        resources.ApplyResources(Me.frmusuarios, "frmusuarios")
        Me.frmusuarios.Controls.Add(Me.Button6)
        Me.frmusuarios.Controls.Add(Me.OperacionGB)
        Me.frmusuarios.Controls.Add(Me.cmbbuscar)
        Me.frmusuarios.Controls.Add(Me.BuscarPorLbl)
        Me.frmusuarios.Controls.Add(Me.txtbuscar)
        Me.frmusuarios.Controls.Add(Me.IgualLbl)
        Me.frmusuarios.Controls.Add(Me.RegistrosGB)
        Me.frmusuarios.Controls.Add(Me.BuscarBtn)
        Me.frmusuarios.Name = "frmusuarios"
        Me.frmusuarios.TabStop = False
        '
        'OperacionGB
        '
        resources.ApplyResources(Me.OperacionGB, "OperacionGB")
        Me.OperacionGB.Controls.Add(Me.AgregarBtn)
        Me.OperacionGB.Controls.Add(Me.ModificarBtn)
        Me.OperacionGB.Controls.Add(Me.EliminarBtn)
        Me.OperacionGB.Name = "OperacionGB"
        Me.OperacionGB.TabStop = False
        '
        'cmbbuscar
        '
        resources.ApplyResources(Me.cmbbuscar, "cmbbuscar")
        Me.cmbbuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbuscar.FormattingEnabled = True
        Me.cmbbuscar.Name = "cmbbuscar"
        '
        'BuscarPorLbl
        '
        resources.ApplyResources(Me.BuscarPorLbl, "BuscarPorLbl")
        Me.BuscarPorLbl.Name = "BuscarPorLbl"
        '
        'txtbuscar
        '
        resources.ApplyResources(Me.txtbuscar, "txtbuscar")
        Me.txtbuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtbuscar.Name = "txtbuscar"
        '
        'IgualLbl
        '
        resources.ApplyResources(Me.IgualLbl, "IgualLbl")
        Me.IgualLbl.Name = "IgualLbl"
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'AgregarBtn
        '
        resources.ApplyResources(Me.AgregarBtn, "AgregarBtn")
        Me.AgregarBtn.Name = "AgregarBtn"
        Me.AgregarBtn.UseVisualStyleBackColor = True
        '
        'ModificarBtn
        '
        resources.ApplyResources(Me.ModificarBtn, "ModificarBtn")
        Me.ModificarBtn.Name = "ModificarBtn"
        Me.ModificarBtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        resources.ApplyResources(Me.EliminarBtn, "EliminarBtn")
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'BuscarBtn
        '
        resources.ApplyResources(Me.BuscarBtn, "BuscarBtn")
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'familias
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.frmusuarios)
        Me.Name = "familias"
        Me.RegistrosGB.ResumeLayout(False)
        CType(Me.datagridfamilias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmusuarios.ResumeLayout(False)
        Me.frmusuarios.PerformLayout()
        Me.OperacionGB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RegistrosGB As System.Windows.Forms.GroupBox
    Friend WithEvents frmusuarios As System.Windows.Forms.GroupBox
    Friend WithEvents OperacionGB As System.Windows.Forms.GroupBox
    Friend WithEvents AgregarBtn As System.Windows.Forms.Button
    Friend WithEvents ModificarBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents cmbbuscar As System.Windows.Forms.ComboBox
    Friend WithEvents BuscarPorLbl As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents IgualLbl As System.Windows.Forms.Label
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents datagridfamilias As System.Windows.Forms.DataGridView
End Class
