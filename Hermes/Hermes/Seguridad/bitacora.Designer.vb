<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bitacora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bitacora))
        Me.frmusuarios = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbusuario = New System.Windows.Forms.ComboBox()
        Me.txthasta = New System.Windows.Forms.DateTimePicker()
        Me.txtdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.cmbcriticidad = New System.Windows.Forms.ComboBox()
        Me.BuscarPorLbl = New System.Windows.Forms.Label()
        Me.IgualLbl = New System.Windows.Forms.Label()
        Me.RegistrosGB = New System.Windows.Forms.GroupBox()
        Me.datagridbitacora = New System.Windows.Forms.DataGridView()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.frmusuarios.SuspendLayout()
        Me.RegistrosGB.SuspendLayout()
        CType(Me.datagridbitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmusuarios
        '
        Me.frmusuarios.Controls.Add(Me.Button2)
        Me.frmusuarios.Controls.Add(Me.Button3)
        Me.frmusuarios.Controls.Add(Me.cmbusuario)
        Me.frmusuarios.Controls.Add(Me.txthasta)
        Me.frmusuarios.Controls.Add(Me.txtdesde)
        Me.frmusuarios.Controls.Add(Me.Label2)
        Me.frmusuarios.Controls.Add(Me.Label1)
        Me.frmusuarios.Controls.Add(Me.Button1)
        Me.frmusuarios.Controls.Add(Me.CancelarBtn)
        Me.frmusuarios.Controls.Add(Me.cmbcriticidad)
        Me.frmusuarios.Controls.Add(Me.BuscarPorLbl)
        Me.frmusuarios.Controls.Add(Me.IgualLbl)
        Me.frmusuarios.Controls.Add(Me.RegistrosGB)
        Me.frmusuarios.Controls.Add(Me.BuscarBtn)
        resources.ApplyResources(Me.frmusuarios, "frmusuarios")
        Me.frmusuarios.Name = "frmusuarios"
        Me.frmusuarios.TabStop = False
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbusuario
        '
        Me.cmbusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbusuario.FormattingEnabled = True
        resources.ApplyResources(Me.cmbusuario, "cmbusuario")
        Me.cmbusuario.Name = "cmbusuario"
        '
        'txthasta
        '
        resources.ApplyResources(Me.txthasta, "txthasta")
        Me.txthasta.Name = "txthasta"
        '
        'txtdesde
        '
        resources.ApplyResources(Me.txtdesde, "txtdesde")
        Me.txtdesde.Name = "txtdesde"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        resources.ApplyResources(Me.CancelarBtn, "CancelarBtn")
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'cmbcriticidad
        '
        Me.cmbcriticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcriticidad.FormattingEnabled = True
        Me.cmbcriticidad.Items.AddRange(New Object() {resources.GetString("cmbcriticidad.Items"), resources.GetString("cmbcriticidad.Items1"), resources.GetString("cmbcriticidad.Items2")})
        resources.ApplyResources(Me.cmbcriticidad, "cmbcriticidad")
        Me.cmbcriticidad.Name = "cmbcriticidad"
        '
        'BuscarPorLbl
        '
        resources.ApplyResources(Me.BuscarPorLbl, "BuscarPorLbl")
        Me.BuscarPorLbl.Name = "BuscarPorLbl"
        '
        'IgualLbl
        '
        resources.ApplyResources(Me.IgualLbl, "IgualLbl")
        Me.IgualLbl.Name = "IgualLbl"
        '
        'RegistrosGB
        '
        Me.RegistrosGB.Controls.Add(Me.datagridbitacora)
        resources.ApplyResources(Me.RegistrosGB, "RegistrosGB")
        Me.RegistrosGB.Name = "RegistrosGB"
        Me.RegistrosGB.TabStop = False
        '
        'datagridbitacora
        '
        Me.datagridbitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.datagridbitacora, "datagridbitacora")
        Me.datagridbitacora.Name = "datagridbitacora"
        '
        'BuscarBtn
        '
        resources.ApplyResources(Me.BuscarBtn, "BuscarBtn")
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'bitacora
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.frmusuarios)
        Me.Name = "bitacora"
        Me.frmusuarios.ResumeLayout(False)
        Me.frmusuarios.PerformLayout()
        Me.RegistrosGB.ResumeLayout(False)
        CType(Me.datagridbitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmusuarios As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
    Friend WithEvents txthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents cmbcriticidad As System.Windows.Forms.ComboBox
    Friend WithEvents BuscarPorLbl As System.Windows.Forms.Label
    Friend WithEvents IgualLbl As System.Windows.Forms.Label
    Friend WithEvents RegistrosGB As System.Windows.Forms.GroupBox
    Friend WithEvents datagridbitacora As System.Windows.Forms.DataGridView
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
End Class
