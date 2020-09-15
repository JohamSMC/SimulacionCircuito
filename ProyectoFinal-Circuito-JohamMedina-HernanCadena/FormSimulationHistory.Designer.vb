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
        Me.Z = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraficaVoltaje = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GraficaCorriente = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GraficaPotencia = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DGV_SimulationHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_SimulationHistory
        '
        Me.DGV_SimulationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SimulationHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Z, Me.L, Me.C, Me.ZL, Me.GraficaVoltaje, Me.GraficaCorriente, Me.GraficaPotencia})
        Me.DGV_SimulationHistory.Location = New System.Drawing.Point(12, 12)
        Me.DGV_SimulationHistory.Name = "DGV_SimulationHistory"
        Me.DGV_SimulationHistory.Size = New System.Drawing.Size(1060, 657)
        Me.DGV_SimulationHistory.TabIndex = 0
        '
        'Z
        '
        Me.Z.HeaderText = "Z"
        Me.Z.Name = "Z"
        '
        'L
        '
        Me.L.HeaderText = "L"
        Me.L.Name = "L"
        '
        'C
        '
        Me.C.HeaderText = "C"
        Me.C.Name = "C"
        '
        'ZL
        '
        Me.ZL.HeaderText = "ZL"
        Me.ZL.Name = "ZL"
        '
        'GraficaVoltaje
        '
        Me.GraficaVoltaje.HeaderText = "Grafica Voltaje"
        Me.GraficaVoltaje.Name = "GraficaVoltaje"
        '
        'GraficaCorriente
        '
        Me.GraficaCorriente.HeaderText = "Grafica Corriente"
        Me.GraficaCorriente.Name = "GraficaCorriente"
        '
        'GraficaPotencia
        '
        Me.GraficaPotencia.HeaderText = "Grafica de Potencia"
        Me.GraficaPotencia.Name = "GraficaPotencia"
        '
        'FormSimulationHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 681)
        Me.Controls.Add(Me.DGV_SimulationHistory)
        Me.Name = "FormSimulationHistory"
        Me.Text = "Historial Simulaciones"
        CType(Me.DGV_SimulationHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_SimulationHistory As DataGridView
    Friend WithEvents Z As DataGridViewTextBoxColumn
    Friend WithEvents L As DataGridViewTextBoxColumn
    Friend WithEvents C As DataGridViewTextBoxColumn
    Friend WithEvents ZL As DataGridViewTextBoxColumn
    Friend WithEvents GraficaVoltaje As DataGridViewImageColumn
    Friend WithEvents GraficaCorriente As DataGridViewImageColumn
    Friend WithEvents GraficaPotencia As DataGridViewImageColumn
End Class
