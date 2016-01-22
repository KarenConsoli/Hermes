<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imprimir_crashs
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Campo = New Hermes.Campo()
        Me.CrashBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CrashTableAdapter = New Hermes.CampoTableAdapters.CrashTableAdapter()
        CType(Me.Campo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrashBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Crashs"
        ReportDataSource1.Value = Me.CrashBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hermes.Crash.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(554, 341)
        Me.ReportViewer1.TabIndex = 0
        '
        'Campo
        '
        Me.Campo.DataSetName = "Campo"
        Me.Campo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CrashBindingSource
        '
        Me.CrashBindingSource.DataMember = "Crash"
        Me.CrashBindingSource.DataSource = Me.Campo
        '
        'CrashTableAdapter
        '
        Me.CrashTableAdapter.ClearBeforeFill = True
        '
        'imprimir_crashs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 341)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "imprimir_crashs"
        Me.Text = "Imprimir"
        CType(Me.Campo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrashBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CrashBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Campo As Hermes.Campo
    Friend WithEvents CrashTableAdapter As Hermes.CampoTableAdapters.CrashTableAdapter
End Class
