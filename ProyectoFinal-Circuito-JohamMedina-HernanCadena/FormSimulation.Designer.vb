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
        Dim ChartArea13 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title13 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea14 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title14 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea15 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series15 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title15 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
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
        Me.Cb_simulationType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tb_MinZ = New System.Windows.Forms.TrackBar()
        Me.Tb_MaxZ = New System.Windows.Forms.TrackBar()
        Me.L_MinZ = New System.Windows.Forms.Label()
        Me.L_MaxZ = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NUD_Z = New System.Windows.Forms.NumericUpDown()
        Me.Tb_z = New System.Windows.Forms.TextBox()
        Me.L_load = New System.Windows.Forms.Label()
        Me.Tb_v = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Tb_MinZL = New System.Windows.Forms.TrackBar()
        Me.Tb_MaxZL = New System.Windows.Forms.TrackBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.L_MaxZL = New System.Windows.Forms.Label()
        Me.L_MinZL = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NUD_ZL = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.Chart_V, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_P, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_I, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Z, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ZL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_MinZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_MaxZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Z, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_MinZL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_MaxZL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_ZL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart_V
        '
        Me.Chart_V.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ChartArea13.AxisX.Title = "Tiempo(t)"
        ChartArea13.AxisY.Title = "Voltaje(V)"
        ChartArea13.Name = "ChartArea1"
        Me.Chart_V.ChartAreas.Add(ChartArea13)
        Me.Chart_V.Location = New System.Drawing.Point(12, 399)
        Me.Chart_V.Name = "Chart_V"
        Series13.BorderWidth = 3
        Series13.ChartArea = "ChartArea1"
        Series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series13.Color = System.Drawing.Color.ForestGreen
        Series13.Name = "Series1"
        Me.Chart_V.Series.Add(Series13)
        Me.Chart_V.Size = New System.Drawing.Size(330, 250)
        Me.Chart_V.TabIndex = 0
        Me.Chart_V.Text = "Voltaje"
        Title13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title13.Name = "Title1"
        Title13.Text = "Voltaje"
        Me.Chart_V.Titles.Add(Title13)
        '
        'Chart_P
        '
        Me.Chart_P.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea14.AxisX.Title = "Tiempo(t)"
        ChartArea14.AxisY.Title = "Potencia(W)"
        ChartArea14.Name = "ChartArea1"
        Me.Chart_P.ChartAreas.Add(ChartArea14)
        Me.Chart_P.Location = New System.Drawing.Point(842, 399)
        Me.Chart_P.Name = "Chart_P"
        Series14.BorderWidth = 3
        Series14.ChartArea = "ChartArea1"
        Series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series14.Color = System.Drawing.Color.Blue
        Series14.Name = "Series1"
        Me.Chart_P.Series.Add(Series14)
        Me.Chart_P.Size = New System.Drawing.Size(330, 250)
        Me.Chart_P.TabIndex = 1
        Me.Chart_P.Text = "Potencia"
        Title14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title14.Name = "Title1"
        Title14.Text = "Potencia"
        Me.Chart_P.Titles.Add(Title14)
        '
        'Chart_I
        '
        Me.Chart_I.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        ChartArea15.AxisX.Title = "Tiempo(t)"
        ChartArea15.AxisY.Title = "Corriente(A)"
        ChartArea15.Name = "ChartArea1"
        Me.Chart_I.ChartAreas.Add(ChartArea15)
        Me.Chart_I.Location = New System.Drawing.Point(426, 399)
        Me.Chart_I.Name = "Chart_I"
        Series15.BorderWidth = 3
        Series15.ChartArea = "ChartArea1"
        Series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series15.Color = System.Drawing.Color.Red
        Series15.Name = "Series1"
        Me.Chart_I.Series.Add(Series15)
        Me.Chart_I.Size = New System.Drawing.Size(330, 250)
        Me.Chart_I.TabIndex = 2
        Me.Chart_I.Text = "Corriente"
        Title15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title15.Name = "Title1"
        Title15.Text = "Corriente"
        Me.Chart_I.Titles.Add(Title15)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(816, 370)
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
        Me.CB_Z.BackColor = System.Drawing.Color.Linen
        Me.CB_Z.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Z.FormattingEnabled = True
        Me.CB_Z.Items.AddRange(New Object() {"Resistencia", "Condensador", "Bobina"})
        Me.CB_Z.Location = New System.Drawing.Point(186, 114)
        Me.CB_Z.Name = "CB_Z"
        Me.CB_Z.Size = New System.Drawing.Size(100, 21)
        Me.CB_Z.TabIndex = 6
        '
        'CB_ZL
        '
        Me.CB_ZL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ZL.FormattingEnabled = True
        Me.CB_ZL.Items.AddRange(New Object() {"Resistencia", "Condensador", "Bobina"})
        Me.CB_ZL.Location = New System.Drawing.Point(698, 215)
        Me.CB_ZL.Name = "CB_ZL"
        Me.CB_ZL.Size = New System.Drawing.Size(100, 21)
        Me.CB_ZL.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Z"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(698, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ZL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(445, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(359, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "L"
        '
        'Bt_start
        '
        Me.Bt_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bt_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_start.Location = New System.Drawing.Point(839, 21)
        Me.Bt_start.Name = "Bt_start"
        Me.Bt_start.Size = New System.Drawing.Size(241, 50)
        Me.Bt_start.TabIndex = 12
        Me.Bt_start.Text = "SIMULAR"
        Me.Bt_start.UseVisualStyleBackColor = False
        '
        'Cb_animation
        '
        Me.Cb_animation.AutoSize = True
        Me.Cb_animation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_animation.Location = New System.Drawing.Point(914, 73)
        Me.Cb_animation.Name = "Cb_animation"
        Me.Cb_animation.Size = New System.Drawing.Size(111, 24)
        Me.Cb_animation.TabIndex = 13
        Me.Cb_animation.Text = "Animación"
        Me.Cb_animation.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(846, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "# Datos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(834, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ganancia"
        '
        'Tb_num
        '
        Me.Tb_num.Location = New System.Drawing.Point(932, 241)
        Me.Tb_num.Name = "Tb_num"
        Me.Tb_num.Size = New System.Drawing.Size(51, 20)
        Me.Tb_num.TabIndex = 16
        Me.Tb_num.Text = "100"
        Me.Tb_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_g
        '
        Me.Tb_g.Location = New System.Drawing.Point(932, 283)
        Me.Tb_g.Name = "Tb_g"
        Me.Tb_g.Size = New System.Drawing.Size(51, 20)
        Me.Tb_g.TabIndex = 17
        Me.Tb_g.Text = "10"
        Me.Tb_g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_c
        '
        Me.Tb_c.Location = New System.Drawing.Point(450, 224)
        Me.Tb_c.Name = "Tb_c"
        Me.Tb_c.Size = New System.Drawing.Size(36, 20)
        Me.Tb_c.TabIndex = 18
        Me.Tb_c.Text = "1"
        Me.Tb_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_zl
        '
        Me.Tb_zl.Location = New System.Drawing.Point(733, 271)
        Me.Tb_zl.Name = "Tb_zl"
        Me.Tb_zl.Size = New System.Drawing.Size(36, 20)
        Me.Tb_zl.TabIndex = 19
        Me.Tb_zl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_l
        '
        Me.Tb_l.Location = New System.Drawing.Point(401, 106)
        Me.Tb_l.Name = "Tb_l"
        Me.Tb_l.Size = New System.Drawing.Size(36, 20)
        Me.Tb_l.TabIndex = 20
        Me.Tb_l.Text = "1"
        Me.Tb_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cb_simulationType
        '
        Me.Cb_simulationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_simulationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_simulationType.FormattingEnabled = True
        Me.Cb_simulationType.Items.AddRange(New Object() {"PASO", "IMPULSO"})
        Me.Cb_simulationType.Location = New System.Drawing.Point(840, 200)
        Me.Cb_simulationType.Name = "Cb_simulationType"
        Me.Cb_simulationType.Size = New System.Drawing.Size(185, 24)
        Me.Cb_simulationType.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(839, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Tipo de Respuesta"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Tb_MinZ
        '
        Me.Tb_MinZ.LargeChange = 1
        Me.Tb_MinZ.Location = New System.Drawing.Point(96, 14)
        Me.Tb_MinZ.Maximum = 3
        Me.Tb_MinZ.Minimum = 1
        Me.Tb_MinZ.Name = "Tb_MinZ"
        Me.Tb_MinZ.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Tb_MinZ.Size = New System.Drawing.Size(45, 57)
        Me.Tb_MinZ.TabIndex = 5
        Me.Tb_MinZ.Value = 1
        '
        'Tb_MaxZ
        '
        Me.Tb_MaxZ.LargeChange = 1
        Me.Tb_MaxZ.Location = New System.Drawing.Point(314, 14)
        Me.Tb_MaxZ.Maximum = 3
        Me.Tb_MaxZ.Minimum = 1
        Me.Tb_MaxZ.Name = "Tb_MaxZ"
        Me.Tb_MaxZ.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Tb_MaxZ.Size = New System.Drawing.Size(45, 57)
        Me.Tb_MaxZ.TabIndex = 24
        Me.Tb_MaxZ.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.Tb_MaxZ.Value = 3
        '
        'L_MinZ
        '
        Me.L_MinZ.AutoSize = True
        Me.L_MinZ.BackColor = System.Drawing.Color.OldLace
        Me.L_MinZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_MinZ.Location = New System.Drawing.Point(203, 21)
        Me.L_MinZ.Name = "L_MinZ"
        Me.L_MinZ.Size = New System.Drawing.Size(16, 16)
        Me.L_MinZ.TabIndex = 25
        Me.L_MinZ.Text = "1"
        '
        'L_MaxZ
        '
        Me.L_MaxZ.AutoSize = True
        Me.L_MaxZ.BackColor = System.Drawing.Color.OldLace
        Me.L_MaxZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_MaxZ.Location = New System.Drawing.Point(229, 21)
        Me.L_MaxZ.Name = "L_MaxZ"
        Me.L_MaxZ.Size = New System.Drawing.Size(16, 16)
        Me.L_MaxZ.TabIndex = 26
        Me.L_MaxZ.Text = "3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(216, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "-"
        '
        'NUD_Z
        '
        Me.NUD_Z.DecimalPlaces = 1
        Me.NUD_Z.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NUD_Z.Location = New System.Drawing.Point(230, 143)
        Me.NUD_Z.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_Z.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NUD_Z.Name = "NUD_Z"
        Me.NUD_Z.Size = New System.Drawing.Size(42, 20)
        Me.NUD_Z.TabIndex = 29
        Me.NUD_Z.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'Tb_z
        '
        Me.Tb_z.Location = New System.Drawing.Point(206, 169)
        Me.Tb_z.Name = "Tb_z"
        Me.Tb_z.Size = New System.Drawing.Size(42, 20)
        Me.Tb_z.TabIndex = 30
        Me.Tb_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_load
        '
        Me.L_load.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.L_load.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_load.ForeColor = System.Drawing.SystemColors.Control
        Me.L_load.Location = New System.Drawing.Point(840, 100)
        Me.L_load.Name = "L_load"
        Me.L_load.Size = New System.Drawing.Size(240, 54)
        Me.L_load.TabIndex = 31
        Me.L_load.Text = "C:> Esperando por Simulación"
        '
        'Tb_v
        '
        Me.Tb_v.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_v.Location = New System.Drawing.Point(12, 181)
        Me.Tb_v.Name = "Tb_v"
        Me.Tb_v.Size = New System.Drawing.Size(33, 23)
        Me.Tb_v.TabIndex = 32
        Me.Tb_v.Text = "1"
        Me.Tb_v.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 19)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "V"
        '
        'Tb_MinZL
        '
        Me.Tb_MinZL.LargeChange = 1
        Me.Tb_MinZL.Location = New System.Drawing.Point(574, 142)
        Me.Tb_MinZL.Maximum = 3
        Me.Tb_MinZL.Minimum = 1
        Me.Tb_MinZL.Name = "Tb_MinZL"
        Me.Tb_MinZL.Size = New System.Drawing.Size(57, 45)
        Me.Tb_MinZL.TabIndex = 37
        Me.Tb_MinZL.Value = 1
        '
        'Tb_MaxZL
        '
        Me.Tb_MaxZL.LargeChange = 1
        Me.Tb_MaxZL.Location = New System.Drawing.Point(574, 240)
        Me.Tb_MaxZL.Maximum = 3
        Me.Tb_MaxZL.Minimum = 1
        Me.Tb_MaxZL.Name = "Tb_MaxZL"
        Me.Tb_MaxZL.Size = New System.Drawing.Size(57, 45)
        Me.Tb_MaxZL.TabIndex = 38
        Me.Tb_MaxZL.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.Tb_MaxZL.Value = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(587, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "-"
        '
        'L_MaxZL
        '
        Me.L_MaxZL.AutoSize = True
        Me.L_MaxZL.BackColor = System.Drawing.Color.OldLace
        Me.L_MaxZL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_MaxZL.Location = New System.Drawing.Point(600, 200)
        Me.L_MaxZL.Name = "L_MaxZL"
        Me.L_MaxZL.Size = New System.Drawing.Size(16, 16)
        Me.L_MaxZL.TabIndex = 40
        Me.L_MaxZL.Text = "3"
        '
        'L_MinZL
        '
        Me.L_MinZL.AutoSize = True
        Me.L_MinZL.BackColor = System.Drawing.Color.OldLace
        Me.L_MinZL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_MinZL.Location = New System.Drawing.Point(574, 200)
        Me.L_MinZL.Name = "L_MinZL"
        Me.L_MinZL.Size = New System.Drawing.Size(16, 16)
        Me.L_MinZL.TabIndex = 39
        Me.L_MinZL.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(169, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 16)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Intervalo"
        '
        'NUD_ZL
        '
        Me.NUD_ZL.DecimalPlaces = 1
        Me.NUD_ZL.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NUD_ZL.Location = New System.Drawing.Point(756, 247)
        Me.NUD_ZL.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_ZL.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NUD_ZL.Name = "NUD_ZL"
        Me.NUD_ZL.Size = New System.Drawing.Size(42, 20)
        Me.NUD_ZL.TabIndex = 44
        Me.NUD_ZL.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(74, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 18)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Minimo Z"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(297, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 18)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Maximo Z"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(569, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 18)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Maximo ZL"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(563, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 18)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Minimo ZL"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(698, 247)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 16)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Intervalo"
        '
        'FormSimulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(1184, 681)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NUD_ZL)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.L_MaxZL)
        Me.Controls.Add(Me.L_MinZL)
        Me.Controls.Add(Me.Tb_MaxZL)
        Me.Controls.Add(Me.Tb_MinZL)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Tb_v)
        Me.Controls.Add(Me.L_load)
        Me.Controls.Add(Me.Tb_z)
        Me.Controls.Add(Me.NUD_Z)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.L_MaxZ)
        Me.Controls.Add(Me.L_MinZ)
        Me.Controls.Add(Me.Tb_MaxZ)
        Me.Controls.Add(Me.Tb_MinZ)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Cb_simulationType)
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
        CType(Me.Tb_MinZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_MaxZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Z, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_MinZL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_MaxZL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_ZL, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Cb_simulationType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Tb_MinZ As TrackBar
    Friend WithEvents Tb_MaxZ As TrackBar
    Friend WithEvents L_MinZ As Label
    Friend WithEvents L_MaxZ As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NUD_Z As NumericUpDown
    Friend WithEvents Tb_z As TextBox
    Friend WithEvents L_load As Label
    Friend WithEvents Tb_v As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Tb_MinZL As TrackBar
    Friend WithEvents Tb_MaxZL As TrackBar
    Friend WithEvents Label10 As Label
    Friend WithEvents L_MaxZL As Label
    Friend WithEvents L_MinZL As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents NUD_ZL As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
End Class
