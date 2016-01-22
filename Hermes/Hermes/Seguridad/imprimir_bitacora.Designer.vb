<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imprimir_bitacora
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
        Me.bitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Campo = New Hermes.Campo()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bitacoraTableAdapter = New Hermes.CampoTableAdapters.bitacoraTableAdapter()
        CType(Me.bitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Campo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bitacoraBindingSource
        '
        Me.bitacoraBindingSource.DataMember = "bitacora"
        Me.bitacoraBindingSource.DataSource = Me.Campo
        '
        'Campo
        '
        Me.Campo.DataSetName = "Campo"
        Me.Campo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hermes.bitacora.rdlc"
        Me.ReportViewer1.LocalReport.ReportPath = ""
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(569, 332)
        Me.ReportViewer1.TabIndex = 0
        '
        'bitacoraTableAdapter
        '
        Me.bitacoraTableAdapter.ClearBeforeFill = True
        '
        'imprimir_bitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 332)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "imprimir_bitacora"
        Me.Text = "Imprimir"
        CType(Me.bitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Campo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents bitacoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Campo As Hermes.Campo
    Friend WithEvents bitacoraTableAdapter As Hermes.CampoTableAdapters.bitacoraTableAdapter
End Class
