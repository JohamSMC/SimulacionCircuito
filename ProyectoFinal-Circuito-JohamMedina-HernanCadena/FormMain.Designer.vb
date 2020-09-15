<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Bt_exit = New System.Windows.Forms.Button()
        Me.Bt_pathOctave = New System.Windows.Forms.Button()
        Me.Bt_simulation = New System.Windows.Forms.Button()
        Me.Bt_simulationHistory = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Bt_simulationHistory)
        Me.Panel1.Controls.Add(Me.Bt_exit)
        Me.Panel1.Controls.Add(Me.Bt_pathOctave)
        Me.Panel1.Controls.Add(Me.Bt_simulation)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 450)
        Me.Panel1.TabIndex = 0
        '
        'Bt_exit
        '
        Me.Bt_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_exit.Location = New System.Drawing.Point(12, 202)
        Me.Bt_exit.Name = "Bt_exit"
        Me.Bt_exit.Size = New System.Drawing.Size(152, 36)
        Me.Bt_exit.TabIndex = 3
        Me.Bt_exit.Text = "Salir"
        Me.Bt_exit.UseVisualStyleBackColor = True
        '
        'Bt_pathOctave
        '
        Me.Bt_pathOctave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_pathOctave.Location = New System.Drawing.Point(12, 132)
        Me.Bt_pathOctave.Name = "Bt_pathOctave"
        Me.Bt_pathOctave.Size = New System.Drawing.Size(152, 64)
        Me.Bt_pathOctave.TabIndex = 2
        Me.Bt_pathOctave.Text = "Configurar Ruta Octave"
        Me.Bt_pathOctave.UseVisualStyleBackColor = True
        '
        'Bt_simulation
        '
        Me.Bt_simulation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_simulation.Location = New System.Drawing.Point(12, 20)
        Me.Bt_simulation.Name = "Bt_simulation"
        Me.Bt_simulation.Size = New System.Drawing.Size(152, 36)
        Me.Bt_simulation.TabIndex = 1
        Me.Bt_simulation.Text = "Simulador"
        Me.Bt_simulation.UseVisualStyleBackColor = True
        '
        'Bt_simulationHistory
        '
        Me.Bt_simulationHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_simulationHistory.Location = New System.Drawing.Point(12, 62)
        Me.Bt_simulationHistory.Name = "Bt_simulationHistory"
        Me.Bt_simulationHistory.Size = New System.Drawing.Size(152, 64)
        Me.Bt_simulationHistory.TabIndex = 4
        Me.Bt_simulationHistory.Text = "Historial Simulación"
        Me.Bt_simulationHistory.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulación Circuito"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bt_exit As Button
    Friend WithEvents Bt_pathOctave As Button
    Friend WithEvents Bt_simulation As Button
    Friend WithEvents Bt_simulationHistory As Button
End Class
