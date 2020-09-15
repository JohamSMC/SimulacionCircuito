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
        Me.Chart_W = New System.Windows.Forms.DataVisualization.Charting.Chart()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tb_num = New System.Windows.Forms.TextBox()
        Me.Tb_g = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.Chart_V, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_W, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Series1.ChartArea = "ChartArea1"
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
        'Chart_W
        '
        Me.Chart_W.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.Chart_W.ChartAreas.Add(ChartArea2)
        Me.Chart_W.Location = New System.Drawing.Point(742, 399)
        Me.Chart_W.Name = "Chart_W"
        Series2.ChartArea = "ChartArea1"
        Series2.Name = "Series1"
        Me.Chart_W.Series.Add(Series2)
        Me.Chart_W.Size = New System.Drawing.Size(330, 250)
        Me.Chart_W.TabIndex = 1
        Me.Chart_W.Text = "Chart2"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "Potencia"
        Me.Chart_W.Titles.Add(Title2)
        '
        'Chart_I
        '
        Me.Chart_I.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        ChartArea3.Name = "ChartArea1"
        Me.Chart_I.ChartAreas.Add(ChartArea3)
        Me.Chart_I.Location = New System.Drawing.Point(376, 399)
        Me.Chart_I.Name = "Chart_I"
        Series3.ChartArea = "ChartArea1"
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
        Me.PictureBox1.Size = New System.Drawing.Size(750, 370)
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
        Me.CB_Z.Items.AddRange(New Object() {"R", "C", "L"})
        Me.CB_Z.Location = New System.Drawing.Point(265, 106)
        Me.CB_Z.Name = "CB_Z"
        Me.CB_Z.Size = New System.Drawing.Size(32, 21)
        Me.CB_Z.TabIndex = 6
        '
        'CB_ZL
        '
        Me.CB_ZL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ZL.FormattingEnabled = True
        Me.CB_ZL.Items.AddRange(New Object() {"RL", "CL", "LL"})
        Me.CB_ZL.Location = New System.Drawing.Point(701, 241)
        Me.CB_ZL.Name = "CB_ZL"
        Me.CB_ZL.Size = New System.Drawing.Size(32, 21)
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(843, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "SIMULAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(843, 86)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(111, 24)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Animación"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(843, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "#"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(839, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "G"
        '
        'Tb_num
        '
        Me.Tb_num.Location = New System.Drawing.Point(888, 136)
        Me.Tb_num.Name = "Tb_num"
        Me.Tb_num.Size = New System.Drawing.Size(100, 20)
        Me.Tb_num.TabIndex = 16
        '
        'Tb_g
        '
        Me.Tb_g.Location = New System.Drawing.Point(888, 178)
        Me.Tb_g.Name = "Tb_g"
        Me.Tb_g.Size = New System.Drawing.Size(100, 20)
        Me.Tb_g.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(450, 224)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(36, 20)
        Me.TextBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(701, 215)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(36, 20)
        Me.TextBox2.TabIndex = 19
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(401, 106)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(36, 20)
        Me.TextBox3.TabIndex = 20
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(206, 107)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(36, 20)
        Me.TextBox4.TabIndex = 21
        '
        'FormSimulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 681)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Tb_g)
        Me.Controls.Add(Me.Tb_num)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_ZL)
        Me.Controls.Add(Me.CB_Z)
        Me.Controls.Add(Me.PB_ZL)
        Me.Controls.Add(Me.Chart_I)
        Me.Controls.Add(Me.Chart_W)
        Me.Controls.Add(Me.Chart_V)
        Me.Controls.Add(Me.PB_Z)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormSimulation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSimulation"
        CType(Me.Chart_V, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_W, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_I, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Z, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ZL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart_V As DataVisualization.Charting.Chart
    Friend WithEvents Chart_W As DataVisualization.Charting.Chart
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
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Tb_num As TextBox
    Friend WithEvents Tb_g As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
