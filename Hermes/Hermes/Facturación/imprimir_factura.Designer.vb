<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imprimir_factura
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Campo = New Hermes.Campo()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New Hermes.CampoTableAdapters.FacturaTableAdapter()
        Me.transporte_paqueteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.transporte_paqueteTableAdapter = New Hermes.CampoTableAdapters.transporte_paqueteTableAdapter()
        CType(Me.Campo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transporte_paqueteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Factura"
        ReportDataSource1.Value = Me.FacturaBindingSource
        ReportDataSource2.Name = "transporte_paquete"
        ReportDataSource2.Value = Me.transporte_paqueteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hermes.Factura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(741, 375)
        Me.ReportViewer1.TabIndex = 0
        '
        'Campo
        '
        Me.Campo.DataSetName = "Campo"
        Me.Campo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.Campo
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'transporte_paqueteBindingSource
        '
        Me.transporte_paqueteBindingSource.DataMember = "transporte_paquete"
        Me.transporte_paqueteBindingSource.DataSource = Me.Campo
        '
        'transporte_paqueteTableAdapter
        '
        Me.transporte_paqueteTableAdapter.ClearBeforeFill = True
        '
        'imprimir_factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 375)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "imprimir_factura"
        Me.Text = "Imprimir"
        CType(Me.Campo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transporte_paqueteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Campo As Hermes.Campo
    Friend WithEvents transporte_paqueteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaTableAdapter As Hermes.CampoTableAdapters.FacturaTableAdapter
    Friend WithEvents transporte_paqueteTableAdapter As Hermes.CampoTableAdapters.transporte_paqueteTableAdapter
End Class
