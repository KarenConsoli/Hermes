<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class envios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(envios))
        Me.frmusuarios = New System.Windows.Forms.GroupBox()
        Me.OperacionGB = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IgualLbl = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.BuscarPorLbl = New System.Windows.Forms.Label()
        Me.cmbbuscar = New System.Windows.Forms.ComboBox()
        Me.RegistrosGB = New System.Windows.Forms.GroupBox()
        Me.datagridenvios = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RecargarBtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AgregarBtn = New System.Windows.Forms.Button()
        Me.ModificarBtn = New System.Windows.Forms.Button()
        Me.EliminarBtn = New System.Windows.Forms.Button()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.frmusuarios.SuspendLayout()
        Me.OperacionGB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.RegistrosGB.SuspendLayout()
        CType(Me.datagridenvios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmusuarios
        '
        resources.ApplyResources(Me.frmusuarios, "frmusuarios")
        Me.frmusuarios.Controls.Add(Me.OperacionGB)
        Me.frmusuarios.Controls.Add(Me.GroupBox1)
        Me.frmusuarios.Controls.Add(Me.Button6)
        Me.frmusuarios.Controls.Add(Me.RegistrosGB)
        Me.frmusuarios.Name = "frmusuarios"
        Me.frmusuarios.TabStop = False
        '
        'OperacionGB
        '
        resources.ApplyResources(Me.OperacionGB, "OperacionGB")
        Me.OperacionGB.Controls.Add(Me.Button2)
        Me.OperacionGB.Controls.Add(Me.btnok)
        Me.OperacionGB.Controls.Add(Me.Button1)
        Me.OperacionGB.Controls.Add(Me.RecargarBtn)
        Me.OperacionGB.Controls.Add(Me.Button3)
        Me.OperacionGB.Controls.Add(Me.AgregarBtn)
        Me.OperacionGB.Controls.Add(Me.ModificarBtn)
        Me.OperacionGB.Controls.Add(Me.EliminarBtn)
        Me.OperacionGB.Name = "OperacionGB"
        Me.OperacionGB.TabStop = False
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnok
        '
        resources.ApplyResources(Me.btnok, "btnok")
        Me.btnok.Name = "btnok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.BuscarBtn)
        Me.GroupBox1.Controls.Add(Me.IgualLbl)
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Controls.Add(Me.BuscarPorLbl)
        Me.GroupBox1.Controls.Add(Me.cmbbuscar)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'IgualLbl
        '
        resources.ApplyResources(Me.IgualLbl, "IgualLbl")
        Me.IgualLbl.Name = "IgualLbl"
        '
        'txtbuscar
        '
        resources.ApplyResources(Me.txtbuscar, "txtbuscar")
        Me.txtbuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtbuscar.Name = "txtbuscar"
        '
        'BuscarPorLbl
        '
        resources.ApplyResources(Me.BuscarPorLbl, "BuscarPorLbl")
        Me.BuscarPorLbl.Name = "BuscarPorLbl"
        '
        'cmbbuscar
        '
        resources.ApplyResources(Me.cmbbuscar, "cmbbuscar")
        Me.cmbbuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbuscar.FormattingEnabled = True
        Me.cmbbuscar.Name = "cmbbuscar"
        '
        'RegistrosGB
        '
        resources.ApplyResources(Me.RegistrosGB, "RegistrosGB")
        Me.RegistrosGB.Controls.Add(Me.datagridenvios)
        Me.RegistrosGB.Name = "RegistrosGB"
        Me.RegistrosGB.TabStop = False
        '
        'datagridenvios
        '
        resources.ApplyResources(Me.datagridenvios, "datagridenvios")
        Me.datagridenvios.AllowUserToAddRows = False
        Me.datagridenvios.AllowUserToDeleteRows = False
        Me.datagridenvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridenvios.Name = "datagridenvios"
        Me.datagridenvios.ReadOnly = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RecargarBtn
        '
        resources.ApplyResources(Me.RecargarBtn, "RecargarBtn")
        Me.RecargarBtn.Name = "RecargarBtn"
        Me.RecargarBtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
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
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'envios
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.frmusuarios)
        Me.Name = "envios"
        Me.frmusuarios.ResumeLayout(False)
        Me.OperacionGB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.RegistrosGB.ResumeLayout(False)
        CType(Me.datagridenvios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmusuarios As System.Windows.Forms.GroupBox
    Friend WithEvents cmbbuscar As System.Windows.Forms.ComboBox
    Friend WithEvents BuscarPorLbl As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents IgualLbl As System.Windows.Forms.Label
    Friend WithEvents RegistrosGB As System.Windows.Forms.GroupBox
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents datagridenvios As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OperacionGB As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RecargarBtn As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AgregarBtn As System.Windows.Forms.Button
    Friend WithEvents ModificarBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
