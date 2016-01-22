<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paquetes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paquetes))
        Me.frmusuarios = New System.Windows.Forms.GroupBox()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.OperacionGB = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.RecargarBtn = New System.Windows.Forms.Button()
        Me.AgregarBtn = New System.Windows.Forms.Button()
        Me.ModificarBtn = New System.Windows.Forms.Button()
        Me.EliminarBtn = New System.Windows.Forms.Button()
        Me.cmbbuscar = New System.Windows.Forms.ComboBox()
        Me.BuscarPorLbl = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.IgualLbl = New System.Windows.Forms.Label()
        Me.RegistrosGB = New System.Windows.Forms.GroupBox()
        Me.datagridpaquetes = New System.Windows.Forms.DataGridView()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.frmusuarios.SuspendLayout()
        Me.OperacionGB.SuspendLayout()
        Me.RegistrosGB.SuspendLayout()
        CType(Me.datagridpaquetes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmusuarios
        '
        Me.frmusuarios.Controls.Add(Me.txtcliente)
        Me.frmusuarios.Controls.Add(Me.lblcliente)
        Me.frmusuarios.Controls.Add(Me.Button6)
        Me.frmusuarios.Controls.Add(Me.OperacionGB)
        Me.frmusuarios.Controls.Add(Me.cmbbuscar)
        Me.frmusuarios.Controls.Add(Me.BuscarPorLbl)
        Me.frmusuarios.Controls.Add(Me.txtbuscar)
        Me.frmusuarios.Controls.Add(Me.IgualLbl)
        Me.frmusuarios.Controls.Add(Me.RegistrosGB)
        Me.frmusuarios.Controls.Add(Me.BuscarBtn)
        resources.ApplyResources(Me.frmusuarios, "frmusuarios")
        Me.frmusuarios.Name = "frmusuarios"
        Me.frmusuarios.TabStop = False
        '
        'txtcliente
        '
        resources.ApplyResources(Me.txtcliente, "txtcliente")
        Me.txtcliente.Name = "txtcliente"
        '
        'lblcliente
        '
        resources.ApplyResources(Me.lblcliente, "lblcliente")
        Me.lblcliente.Name = "lblcliente"
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'OperacionGB
        '
        Me.OperacionGB.Controls.Add(Me.Button1)
        Me.OperacionGB.Controls.Add(Me.btnok)
        Me.OperacionGB.Controls.Add(Me.RecargarBtn)
        Me.OperacionGB.Controls.Add(Me.AgregarBtn)
        Me.OperacionGB.Controls.Add(Me.ModificarBtn)
        Me.OperacionGB.Controls.Add(Me.EliminarBtn)
        resources.ApplyResources(Me.OperacionGB, "OperacionGB")
        Me.OperacionGB.Name = "OperacionGB"
        Me.OperacionGB.TabStop = False
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnok
        '
        resources.ApplyResources(Me.btnok, "btnok")
        Me.btnok.Name = "btnok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'RecargarBtn
        '
        resources.ApplyResources(Me.RecargarBtn, "RecargarBtn")
        Me.RecargarBtn.Name = "RecargarBtn"
        Me.RecargarBtn.UseVisualStyleBackColor = True
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
        'cmbbuscar
        '
        Me.cmbbuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cmbbuscar, "cmbbuscar")
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
        Me.txtbuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        resources.ApplyResources(Me.txtbuscar, "txtbuscar")
        Me.txtbuscar.Name = "txtbuscar"
        '
        'IgualLbl
        '
        resources.ApplyResources(Me.IgualLbl, "IgualLbl")
        Me.IgualLbl.Name = "IgualLbl"
        '
        'RegistrosGB
        '
        Me.RegistrosGB.Controls.Add(Me.datagridpaquetes)
        resources.ApplyResources(Me.RegistrosGB, "RegistrosGB")
        Me.RegistrosGB.Name = "RegistrosGB"
        Me.RegistrosGB.TabStop = False
        '
        'datagridpaquetes
        '
        Me.datagridpaquetes.AllowUserToAddRows = False
        Me.datagridpaquetes.AllowUserToDeleteRows = False
        Me.datagridpaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.datagridpaquetes, "datagridpaquetes")
        Me.datagridpaquetes.Name = "datagridpaquetes"
        Me.datagridpaquetes.ReadOnly = True
        '
        'BuscarBtn
        '
        resources.ApplyResources(Me.BuscarBtn, "BuscarBtn")
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'paquetes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.frmusuarios)
        Me.Name = "paquetes"
        Me.frmusuarios.ResumeLayout(False)
        Me.frmusuarios.PerformLayout()
        Me.OperacionGB.ResumeLayout(False)
        Me.RegistrosGB.ResumeLayout(False)
        CType(Me.datagridpaquetes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmusuarios As System.Windows.Forms.GroupBox
    Friend WithEvents OperacionGB As System.Windows.Forms.GroupBox
    Friend WithEvents AgregarBtn As System.Windows.Forms.Button
    Friend WithEvents ModificarBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents cmbbuscar As System.Windows.Forms.ComboBox
    Friend WithEvents BuscarPorLbl As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents IgualLbl As System.Windows.Forms.Label
    Friend WithEvents RegistrosGB As System.Windows.Forms.GroupBox
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents datagridpaquetes As System.Windows.Forms.DataGridView
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents lblcliente As System.Windows.Forms.Label
    Friend WithEvents RecargarBtn As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
