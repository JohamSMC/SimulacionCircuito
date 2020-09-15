<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSimulation
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSimulation))
        Me.Chart_V = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart_P = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart_I = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PB_Z = New System.Windows.Forms.PictureBox()
        Me.PB_ZL = New System.Windows.Forms.PictureBox()
        Me.CB_Z = New System.Windows.Forms.ComboBox()
        Me.CB_ZL = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bt_start = New System.Windows.Forms.Button()
        Me.Cb_animation = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tb_num = New System.Windows.Forms.TextBox()
        Me.Tb_g = New System.Windows.Forms.TextBox()
        Me.Tb_c = New System.Windows.Forms.TextBox()
        Me.Tb_zl = New System.Windows.Forms.TextBox()
        Me.Tb_l = New System.Windows.Forms.TextBox()
        Me.Tb_z = New System.Windows.Forms.TextBox()
        Me.Cb_simulationType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Chart_V, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_P, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_I, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Z, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ZL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart_V
        '
        Me.Chart_V.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart_V.ChartAreas.Add(ChartArea1)
        Me.Chart_V.Location = New System.Drawing.Point(12, 399)
        Me.Chart_V.Name = "Chart_V"
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.ForestGreen
        Series1.Name = "Series1"
        Me.Chart_V.Series.Add(Series1)
        Me.Chart_V.Size = New System.Drawing.Size(330, 250)
        Me.Chart_V.TabIndex = 0
        Me.Chart_V.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Voltaje"
        Me.Chart_V.Titles.Add(Title1)
        '
        'Chart_P
        '
        Me.Chart_P.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.Chart_P.ChartAreas.Add(ChartArea2)
        Me.Chart_P.Location = New System.Drawing.Point(742, 399)
        Me.Chart_P.Name = "Chart_P"
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.Blue
        Series2.Name = "Series1"
        Me.Chart_P.Series.Add(Series2)
        Me.Chart_P.Size = New System.Drawing.Size(330, 250)
        Me.Chart_P.TabIndex = 1
        Me.Chart_P.Text = "Chart2"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "Potencia"
        Me.Chart_P.Titles.Add(Title2)
        '
        'Chart_I
        '
        Me.Chart_I.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        ChartArea3.Name = "ChartArea1"
        Me.Chart_I.ChartAreas.Add(ChartArea3)
        Me.Chart_I.Location = New System.Drawing.Point(376, 399)
        Me.Chart_I.Name = "Chart_I"
        Series3.BorderWidth = 3
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Color = System.Drawing.Color.Red
        Series3.Name = "Series1"
        Me.Chart_I.Series.Add(Series3)
        Me.Chart_I.Size = New System.Drawing.Size(330, 250)
        Me.Chart_I.TabIndex = 2
        Me.Chart_I.Text = "Chart3"
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.Text = "Corriente"
        Me.Chart_I.Titles.Add(Title3)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 370)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PB_Z
        '
        Me.PB_Z.Image = CType(resources.GetObject("PB_Z.Image"), System.Drawing.Image)
        Me.PB_Z.Location = New System.Drawing.Point(147, 50)
        Me.PB_Z.Name = "PB_Z"
        Me.PB_Z.Size = New System.Drawing.Size(150, 60)
        Me.PB_Z.TabIndex = 4
        Me.PB_Z.TabStop = False
        '
        'PB_ZL
        '
        Me.PB_ZL.Image = CType(resources.GetObject("PB_ZL.Image"), System.Drawing.Image)
        Me.PB_ZL.Location = New System.Drawing.Point(637, 149)
        Me.PB_ZL.Name = "PB_ZL"
        Me.PB_ZL.Size = New System.Drawing.Size(55, 120)
        Me.PB_ZL.TabIndex = 5
        Me.PB_ZL.TabStop = False
        '
        'CB_Z
        '
        Me.CB_Z.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Z.FormattingEnabled = True
        Me.CB_Z.Items.AddRange(New Object() {"Resistencia", "Condensador", "Bobina"})
        Me.CB_Z.Location = New System.Drawing.Point(265, 106)
        Me.CB_Z.Name = "CB_Z"
        Me.CB_Z.Size = New System.Drawing.Size(85, 21)
        Me.CB_Z.TabIndex = 6
        '
        'CB_ZL
        '
        Me.CB_ZL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ZL.FormattingEnabled = True
        Me.CB_ZL.Items.AddRange(New Object() {"Resistencia", "Condensador", "Bobina"})
        Me.CB_ZL.Location = New System.Drawing.Point(701, 241)
        Me.CB_ZL.Name = "CB_ZL"
        Me.CB_ZL.Size = New System.Drawing.Size(85, 21)
        Me.CB_ZL.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Z"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(698, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ZL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(445, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(359, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "L"
        '
        'Bt_start
        '
        Me.Bt_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_start.Location = New System.Drawing.Point(843, 21)
        Me.Bt_start.Name = "Bt_start"
        Me.Bt_start.Size = New System.Drawing.Size(172, 50)
        Me.Bt_start.TabIndex = 12
        Me.Bt_start.Text = "SIMULAR"
        Me.Bt_start.UseVisualStyleBackColor = True
        '
        'Cb_animation
        '
        Me.Cb_animation.AutoSize = True
        Me.Cb_animation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_animation.Location = New System.Drawing.Point(843, 86)
        Me.Cb_animation.Name = "Cb_animation"
        Me.Cb_animation.Size = New System.Drawing.Size(111, 24)
        Me.Cb_animation.TabIndex = 13
        Me.Cb_animation.Text = "Animación"
        Me.Cb_animation.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(841, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "#"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(837, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "G"
        '
        'Tb_num
        '
        Me.Tb_num.Location = New System.Drawing.Point(886, 192)
        Me.Tb_num.Name = "Tb_num"
        Me.Tb_num.Size = New System.Drawing.Size(100, 20)
        Me.Tb_num.TabIndex = 16
        '
        'Tb_g
        '
        Me.Tb_g.Location = New System.Drawing.Point(886, 234)
        Me.Tb_g.Name = "Tb_g"
        Me.Tb_g.Size = New System.Drawing.Size(100, 20)
        Me.Tb_g.TabIndex = 17
        '
        'Tb_c
        '
        Me.Tb_c.Location = New System.Drawing.Point(450, 224)
        Me.Tb_c.Name = "Tb_c"
        Me.Tb_c.Size = New System.Drawing.Size(36, 20)
        Me.Tb_c.TabIndex = 18
        '
        'Tb_zl
        '
        Me.Tb_zl.Location = New System.Drawing.Point(701, 215)
        Me.Tb_zl.Name = "Tb_zl"
        Me.Tb_zl.Size = New System.Drawing.Size(36, 20)
        Me.Tb_zl.TabIndex = 19
        '
        'Tb_l
        '
        Me.Tb_l.Location = New System.Drawing.Point(401, 106)
        Me.Tb_l.Name = "Tb_l"
        Me.Tb_l.Size = New System.Drawing.Size(36, 20)
        Me.Tb_l.TabIndex = 20
        '
        'Tb_z
        '
        Me.Tb_z.Location = New System.Drawing.Point(206, 107)
        Me.Tb_z.Name = "Tb_z"
        Me.Tb_z.Size = New System.Drawing.Size(36, 20)
        Me.Tb_z.TabIndex = 21
        '
        'Cb_simulationType
        '
        Me.Cb_simulationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_simulationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_simulationType.FormattingEnabled = True
        Me.Cb_simulationType.Items.AddRange(New Object() {"PASO", "IMPULSO"})
        Me.Cb_simulationType.Location = New System.Drawing.Point(843, 149)
        Me.Cb_simulationType.Name = "Cb_simulationType"
        Me.Cb_simulationType.Size = New System.Drawing.Size(185, 24)
        Me.Cb_simulationType.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(842, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Tipo de Respuesta"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'FormSimulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 681)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Cb_simulationType)
        Me.Controls.Add(Me.Tb_z)
        Me.Controls.Add(Me.Tb_l)
        Me.Controls.Add(Me.Tb_zl)
        Me.Controls.Add(Me.Tb_c)
        Me.Controls.Add(Me.Tb_g)
        Me.Controls.Add(Me.Tb_num)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cb_animation)
        Me.Controls.Add(Me.Bt_start)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_ZL)
        Me.Controls.Add(Me.CB_Z)
        Me.Controls.Add(Me.PB_ZL)
        Me.Controls.Add(Me.Chart_I)
        Me.Controls.Add(Me.Chart_P)
        Me.Controls.Add(Me.Chart_V)
        Me.Controls.Add(Me.PB_Z)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormSimulation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSimulation"
        CType(Me.Chart_V, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_P, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_I, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Z, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ZL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart_V As DataVisualization.Charting.Chart
    Friend WithEvents Chart_P As DataVisualization.Charting.Chart
    Friend WithEvents Chart_I As DataVisualization.Charting.Chart
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PB_Z As PictureBox
    Friend WithEvents PB_ZL As PictureBox
    Friend WithEvents CB_Z As ComboBox
    Friend WithEvents CB_ZL As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Bt_start As Button
    Friend WithEvents Cb_animation As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Tb_num As TextBox
    Friend WithEvents Tb_g As TextBox
    Friend WithEvents Tb_c As TextBox
    Friend WithEvents Tb_zl As TextBox
    Friend WithEvents Tb_l As TextBox
    Friend WithEvents Tb_z As TextBox
    Friend WithEvents Cb_simulationType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
End Class
