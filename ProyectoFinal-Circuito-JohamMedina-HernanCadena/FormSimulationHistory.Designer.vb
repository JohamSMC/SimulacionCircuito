<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSimulationHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGV_SimulationHistory = New System.Windows.Forms.DataGridView()
        Me.NumeroElementos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ganancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoRespuesta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorVoltaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElementoZ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorZ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElementoZL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorZL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraficaVoltaje = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GraficaCorriente = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GraficaPotencia = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DGV_SimulationHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_SimulationHistory
        '
        Me.DGV_SimulationHistory.AllowUserToAddRows = False
        Me.DGV_SimulationHistory.AllowUserToDeleteRows = False
        Me.DGV_SimulationHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_SimulationHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_SimulationHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_SimulationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SimulationHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroElementos, Me.Ganancia, Me.TipoRespuesta, Me.ValorVoltaje, Me.ElementoZ, Me.ValorZ, Me.ValorL, Me.ValorC, Me.ElementoZL, Me.ValorZL, Me.GraficaVoltaje, Me.GraficaCorriente, Me.GraficaPotencia})
        Me.DGV_SimulationHistory.Location = New System.Drawing.Point(12, 12)
        Me.DGV_SimulationHistory.Name = "DGV_SimulationHistory"
        Me.DGV_SimulationHistory.ReadOnly = True
        Me.DGV_SimulationHistory.Size = New System.Drawing.Size(1160, 657)
        Me.DGV_SimulationHistory.TabIndex = 0
        '
        'NumeroElementos
        '
        Me.NumeroElementos.HeaderText = "Numero de Elementos"
        Me.NumeroElementos.Name = "NumeroElementos"
        Me.NumeroElementos.ReadOnly = True
        Me.NumeroElementos.Width = 124
        '
        'Ganancia
        '
        Me.Ganancia.HeaderText = "Ganancia"
        Me.Ganancia.Name = "Ganancia"
        Me.Ganancia.ReadOnly = True
        Me.Ganancia.Width = 78
        '
        'TipoRespuesta
        '
        Me.TipoRespuesta.HeaderText = "Tipo de Respuesta"
        Me.TipoRespuesta.Name = "TipoRespuesta"
        Me.TipoRespuesta.ReadOnly = True
        Me.TipoRespuesta.Width = 112
        '
        'ValorVoltaje
        '
        Me.ValorVoltaje.HeaderText = "Valor del Voltaje"
        Me.ValorVoltaje.Name = "ValorVoltaje"
        Me.ValorVoltaje.ReadOnly = True
        Me.ValorVoltaje.Width = 99
        '
        'ElementoZ
        '
        Me.ElementoZ.HeaderText = "Elemento Z"
        Me.ElementoZ.Name = "ElementoZ"
        Me.ElementoZ.ReadOnly = True
        Me.ElementoZ.Width = 79
        '
        'ValorZ
        '
        Me.ValorZ.HeaderText = "Valor Z"
        Me.ValorZ.Name = "ValorZ"
        Me.ValorZ.ReadOnly = True
        Me.ValorZ.Width = 61
        '
        'ValorL
        '
        Me.ValorL.HeaderText = "Valor L"
        Me.ValorL.Name = "ValorL"
        Me.ValorL.ReadOnly = True
        Me.ValorL.Width = 60
        '
        'ValorC
        '
        Me.ValorC.HeaderText = "Valor C"
        Me.ValorC.Name = "ValorC"
        Me.ValorC.ReadOnly = True
        Me.ValorC.Width = 61
        '
        'ElementoZL
        '
        Me.ElementoZL.HeaderText = "Elemento ZL"
        Me.ElementoZL.Name = "ElementoZL"
        Me.ElementoZL.ReadOnly = True
        Me.ElementoZL.Width = 85
        '
        'ValorZL
        '
        Me.ValorZL.HeaderText = "Valor ZL"
        Me.ValorZL.Name = "ValorZL"
        Me.ValorZL.ReadOnly = True
        Me.ValorZL.Width = 67
        '
        'GraficaVoltaje
        '
        Me.GraficaVoltaje.HeaderText = "Grafica Voltaje"
        Me.GraficaVoltaje.Name = "GraficaVoltaje"
        Me.GraficaVoltaje.ReadOnly = True
        Me.GraficaVoltaje.Width = 74
        '
        'GraficaCorriente
        '
        Me.GraficaCorriente.HeaderText = "Grafica Corriente"
        Me.GraficaCorriente.Name = "GraficaCorriente"
        Me.GraficaCorriente.ReadOnly = True
        Me.GraficaCorriente.Width = 83
        '
        'GraficaPotencia
        '
        Me.GraficaPotencia.HeaderText = "Grafica de Potencia"
        Me.GraficaPotencia.Name = "GraficaPotencia"
        Me.GraficaPotencia.ReadOnly = True
        Me.GraficaPotencia.Width = 96
        '
        'FormSimulationHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 681)
        Me.Controls.Add(Me.DGV_SimulationHistory)
        Me.Name = "FormSimulationHistory"
        Me.Text = "Historial Simulaciones"
        CType(Me.DGV_SimulationHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_SimulationHistory As DataGridView
    Friend WithEvents NumeroElementos As DataGridViewTextBoxColumn
    Friend WithEvents Ganancia As DataGridViewTextBoxColumn
    Friend WithEvents TipoRespuesta As DataGridViewTextBoxColumn
    Friend WithEvents ValorVoltaje As DataGridViewTextBoxColumn
    Friend WithEvents ElementoZ As DataGridViewTextBoxColumn
    Friend WithEvents ValorZ As DataGridViewTextBoxColumn
    Friend WithEvents ValorL As DataGridViewTextBoxColumn
    Friend WithEvents ValorC As DataGridViewTextBoxColumn
    Friend WithEvents ElementoZL As DataGridViewTextBoxColumn
    Friend WithEvents ValorZL As DataGridViewTextBoxColumn
    Friend WithEvents GraficaVoltaje As DataGridViewImageColumn
    Friend WithEvents GraficaCorriente As DataGridViewImageColumn
    Friend WithEvents GraficaPotencia As DataGridViewImageColumn
End Class
