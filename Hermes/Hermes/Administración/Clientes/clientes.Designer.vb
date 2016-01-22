<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clientes))
        Me.GestionUsuariosGB = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.OperacionGB = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.AgregarBtn = New System.Windows.Forms.Button()
        Me.ModificarBtn = New System.Windows.Forms.Button()
        Me.EliminarBtn = New System.Windows.Forms.Button()
        Me.cmbbuscar = New System.Windows.Forms.ComboBox()
        Me.BuscarPorLbl = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.IgualLbl = New System.Windows.Forms.Label()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.RegistrosGB = New System.Windows.Forms.GroupBox()
        Me.datagridclientes = New System.Windows.Forms.DataGridView()
        Me.GestionUsuariosGB.SuspendLayout()
        Me.OperacionGB.SuspendLayout()
        Me.RegistrosGB.SuspendLayout()
        CType(Me.datagridclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GestionUsuariosGB
        '
        Me.GestionUsuariosGB.Controls.Add(Me.Button6)
        Me.GestionUsuariosGB.Controls.Add(Me.OperacionGB)
        Me.GestionUsuariosGB.Controls.Add(Me.cmbbuscar)
        Me.GestionUsuariosGB.Controls.Add(Me.BuscarPorLbl)
        Me.GestionUsuariosGB.Controls.Add(Me.txtbuscar)
        Me.GestionUsuariosGB.Controls.Add(Me.IgualLbl)
        Me.GestionUsuariosGB.Controls.Add(Me.BuscarBtn)
        Me.GestionUsuariosGB.Controls.Add(Me.RegistrosGB)
        resources.ApplyResources(Me.GestionUsuariosGB, "GestionUsuariosGB")
        Me.GestionUsuariosGB.Name = "GestionUsuariosGB"
        Me.GestionUsuariosGB.TabStop = False
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'OperacionGB
        '
        Me.OperacionGB.Controls.Add(Me.Button3)
        Me.OperacionGB.Controls.Add(Me.Button2)
        Me.OperacionGB.Controls.Add(Me.btnok)
        Me.OperacionGB.Controls.Add(Me.AgregarBtn)
        Me.OperacionGB.Controls.Add(Me.ModificarBtn)
        Me.OperacionGB.Controls.Add(Me.EliminarBtn)
        resources.ApplyResources(Me.OperacionGB, "OperacionGB")
        Me.OperacionGB.Name = "OperacionGB"
        Me.OperacionGB.TabStop = False
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
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
        'BuscarBtn
        '
        resources.ApplyResources(Me.BuscarBtn, "BuscarBtn")
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'RegistrosGB
        '
        Me.RegistrosGB.Controls.Add(Me.datagridclientes)
        resources.ApplyResources(Me.RegistrosGB, "RegistrosGB")
        Me.RegistrosGB.Name = "RegistrosGB"
        Me.RegistrosGB.TabStop = False
        '
        'datagridclientes
        '
        Me.datagridclientes.AllowUserToAddRows = False
        Me.datagridclientes.AllowUserToDeleteRows = False
        Me.datagridclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridclientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        resources.ApplyResources(Me.datagridclientes, "datagridclientes")
        Me.datagridclientes.Name = "datagridclientes"
        Me.datagridclientes.ReadOnly = True
        '
        'clientes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GestionUsuariosGB)
        Me.Name = "clientes"
        Me.GestionUsuariosGB.ResumeLayout(False)
        Me.GestionUsuariosGB.PerformLayout()
        Me.OperacionGB.ResumeLayout(False)
        Me.RegistrosGB.ResumeLayout(False)
        CType(Me.datagridclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GestionUsuariosGB As System.Windows.Forms.GroupBox
    Friend WithEvents OperacionGB As System.Windows.Forms.GroupBox
    Friend WithEvents AgregarBtn As System.Windows.Forms.Button
    Friend WithEvents ModificarBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents cmbbuscar As System.Windows.Forms.ComboBox
    Friend WithEvents BuscarPorLbl As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents IgualLbl As System.Windows.Forms.Label
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents RegistrosGB As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents datagridclientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnok As System.Windows.Forms.Button
End Class
