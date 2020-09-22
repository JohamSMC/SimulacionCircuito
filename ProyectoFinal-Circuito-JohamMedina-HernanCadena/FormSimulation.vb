Imports System.IO

Public Class FormSimulation
    Dim pInfo As New ProcessStartInfo
    Dim p As Process
    Dim vL, vC, vV As Double
    Dim vZ, vZL As String
    Dim cant_elementos, gan As Integer
    Dim vectorV(10) As Double
    Dim vectorI(10) As Double
    Dim vectorP(10) As Double
    Dim vectorT(10) As Double
    Dim typeResponse As String
    Dim aux As Integer = 0

    Private Sub FormSimulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cb_simulationType.SelectedItem = "PASO"
        CB_Z.SelectedItem = "Resistencia"
        CB_ZL.SelectedItem = "Resistencia"
        Tb_z.Text = 1
        Tb_zl.Text = 1
        Tb_z.Enabled = False
        Tb_zl.Enabled = False

    End Sub

    Private Sub CB_Z_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Z.SelectedIndexChanged
        Select Case CB_Z.SelectedIndex
            Case 0
                PB_Z.Location = New Point(PB_Z.Location.X, 50)
                PB_Z.Image = Image.FromFile(Application.StartupPath & "\images\Z-R.png")
            Case 1
                PB_Z.Location = New Point(PB_Z.Location.X, 48)
                PB_Z.Image = Image.FromFile(Application.StartupPath & "\images\Z-C.png")
            Case 2
                PB_Z.Location = New Point(PB_Z.Location.X, 36)
                PB_Z.Image = Image.FromFile(Application.StartupPath & "\images\Z-L.png")
        End Select
    End Sub

    Private Sub CB_ZL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ZL.SelectedIndexChanged
        Select Case CB_ZL.SelectedIndex
            Case 0
                PB_ZL.Location = New Point(637, PB_ZL.Location.Y)
                PB_ZL.Image = Image.FromFile(Application.StartupPath & "\images\ZL-R.png")
            Case 1
                PB_ZL.Location = New Point(639, PB_ZL.Location.Y)
                PB_ZL.Image = Image.FromFile(Application.StartupPath & "\images\ZL-C.png")
            Case 2
                PB_ZL.Location = New Point(623, PB_ZL.Location.Y)
                PB_ZL.Image = Image.FromFile(Application.StartupPath & "\images\ZL-L.png")
        End Select
    End Sub

    Dim minZ, maxZ, minZL, maxZL As Integer
    Dim itervalZ, itervalZL As Double
    Dim ciclosZ, ciclosZL As Integer

    Function validateCircut() As Boolean
        minZ = Tb_MinZ.Value
        maxZ = Tb_MaxZ.Value
        minZL = Tb_MinZL.Value
        maxZL = Tb_MaxZL.Value
        Dim auxZ As Double = (maxZ - minZ) Mod NUD_Z.Value
        Dim auxZL As Double = (maxZL - minZL) Mod NUD_ZL.Value

        If CB_Z.Text = "Resistencia" And CB_ZL.Text = "Condensador" Then
            MsgBox("La combinación de Z = Resistencia y ZL = Condensador NO ES VALIDA!!!")
            Return False
        ElseIf CB_Z.Text = "Condensador" And CB_ZL.Text = "Condensador" Then
            MsgBox("La combinación de Z = Condensador y ZL = Condensador NO ES VALIDA!!!")
            Return False
        ElseIf CB_Z.Text = "Bobina" And CB_ZL.Text = "Condensador" Then
            MsgBox("La combinación de Z = Bobina y ZL = Condensador NO ES VALIDA!!!")
            Return False
        ElseIf CB_Z.Text = "Bobina" And CB_ZL.Text = "Bobina" Then
            MsgBox("La combinación de Z = Bobina y ZL = Bobina NO ES VALIDA!!!")
            Return False
        ElseIf Tb_MinZ.Value > Tb_MaxZ.Value Then
            MsgBox("El valor minimo de Z debe ser menor que el valor maximo Z")
            Return False
        ElseIf Tb_MinZL.Value > Tb_MaxZL.Value Then
            MsgBox("El valor minimo de ZL debe ser menor que el valor maximo ZL")
            Return False
        ElseIf Not (auxZ = 0) Then
            MsgBox("Intervalo de Elemento Z no apropiado")
            Return False
        ElseIf Not (auxZL = 0) Then
            MsgBox("Intervalo de Elemento ZL no apropiado")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bt_start.Click
        'Desactivar los botones para la simulación
        Dim c As Cursor = Me.Cursor
        disableSimulationButtons()
        Me.Cursor = Cursors.WaitCursor
        If validateCircut() Then
            Dim iteracionesTotales As Integer
            Dim iteracionActual As Integer
            Dim iteracionZ As Double
            Dim iteracionZL As Double

            'Console.WriteLine("------------------> MAX Z " & Str(maxZ))
            'Console.WriteLine("------------------> MIN Z " & Str(minZ))
            'Console.WriteLine("------------------> MAX ZL " & Str(maxZL))
            'Console.WriteLine("------------------> MIN ZL " & Str(minZL))

            If maxZ = minZ And maxZL = minZL Then
                L_load.Text = "C:> Simulación Iniciada"
                startSimulation()
                L_load.Text = "C:> Simulación 100%"
            ElseIf maxZ = minZ And Not (maxZL = minZL) Then
                ciclosZL = (Tb_MaxZL.Value - Tb_MinZL.Value) / NUD_ZL.Value
                iteracionZL = 0
                iteracionesTotales = ciclosZL + 1
                iteracionActual = 1
                For j = 0 To ciclosZL
                    Tb_zl.Text = minZL + iteracionZL
                    startSimulation()
                    iteracionZL += NUD_ZL.Value
                    iteracionActual += 1
                    L_load.Text = "C:> Simulación " & iteracionActual & " de " & iteracionesTotales
                Next
            ElseIf Not (maxZ = minZ) And maxZL = minZL Then
                ciclosZ = (Tb_MaxZ.Value - Tb_MinZ.Value) / NUD_Z.Value
                iteracionZ = 0
                iteracionesTotales = ciclosZ + 1
                iteracionActual = 1
                For j = 0 To ciclosZ
                    Tb_z.Text = minZ + iteracionZ
                    startSimulation()
                    iteracionZ += NUD_Z.Value
                    iteracionActual += 1
                    L_load.Text = "C:> Simulación " & iteracionActual & " de " & iteracionesTotales
                Next
            ElseIf Not (maxZ = minZ) And Not (maxZL = minZL) Then
                ciclosZ = (Tb_MaxZ.Value - Tb_MinZ.Value) / NUD_Z.Value
                ciclosZL = (Tb_MaxZL.Value - Tb_MinZL.Value) / NUD_ZL.Value
                iteracionZ = 0
                iteracionesTotales = (ciclosZ + 1) * (ciclosZL + 1)
                iteracionActual = 1
                For i = 0 To ciclosZ
                    Tb_z.Text = minZ + iteracionZ
                    iteracionZL = 0
                    For j = 0 To ciclosZL
                        Tb_zl.Text = minZL + iteracionZL
                        startSimulation()
                        iteracionZL += NUD_ZL.Value
                        iteracionActual += 1
                        L_load.Text = "C:> Simulación " & iteracionActual & " de " & iteracionesTotales
                    Next
                    iteracionZ += NUD_Z.Value
                Next

            End If
            L_load.Text = "C:> Simulación Terminada"
            L_load.Text += vbCrLf & "C:> Esperando por Nueva Simulación"


        End If
        'Activar Botones para Nueva Simulacion
        activateSimulationButtons()
        Me.Cursor = c
        FormSimulationHistory.MdiParent = FormMain
        FormSimulationHistory.Show()
        Me.WindowState = FormWindowState.Minimized
        FormSimulationHistory.WindowState = FormWindowState.Maximized
    End Sub

    Sub startSimulation()
        Try
            pInfo.FileName = path_Octave
            pInfo.WindowStyle = ProcessWindowStyle.Minimized
            p = Process.Start(pInfo)
            Bt_start.Enabled = True
        Catch ex As Exception
            MsgBox("No se encuentra el archivo Octave-CLI")
            Bt_start.Enabled = False
        End Try
        System.Threading.Thread.Sleep(5000)

        sendOctave("cd '" & Application.StartupPath & "'")

        aux = 0
        cleanCharts()
        vC = Tb_c.Text
        vL = Tb_l.Text
        vV = Tb_v.Text
        cant_elementos = Tb_num.Text
        gan = Tb_g.Text

        Select Case CB_ZL.SelectedIndex
            Case 0
                vZL = Tb_zl.Text
            Case 1
                vZL = "1/(" & Tb_zl.Text & "*s)"
            Case 2
                vZL = Tb_zl.Text & "*s"
        End Select

        Select Case CB_Z.SelectedIndex
            Case 0
                vZ = Tb_z.Text
            Case 1
                vZ = "1/(" & Tb_z.Text & "*s)"
            Case 2
                vZ = Tb_z.Text & "*s"
        End Select

        '-----Definir si es respuesta al PASO o IMPULSO-----
        typeResponse = ""
        If Cb_simulationType.SelectedItem = "PASO" Then
            typeResponse = "step"
        ElseIf Cb_simulationType.SelectedItem = "IMPULSO" Then
            typeResponse = "impulse"
        End If

        createOctaveFile()
        sendOctave("octaveFile")

        While Not (File.Exists(Application.StartupPath & "\i.txt"))
            System.Threading.Thread.Sleep(2000)
        End While

        closeOctave()
        loadData()

        'sendOctave("clc")
        'sendOctave("clear")
        'sendOctave("pkg load control")
        'sendOctave("s=tf{(}'s'{)};")
        'sendOctave("V=" & vC & ";")
        'sendOctave("C=" & vC & ";")
        'sendOctave("L=" & vL & ";")
        'sendOctave("Z=" & vZ & ";")
        'sendOctave("Zl=" & vZL & ";")

        'sendOctave("Z1=Zl/{(}C*s*Zl{+}1{)};")
        'sendOctave("Z2=Z{+}L*s{+}Z1;")
        'sendOctave("IZ2=V/Z2;")
        'sendOctave("VZ2=V;")
        'sendOctave("IZ1=IZ2;")
        'sendOctave("VZ1=IZ1*Z1;")
        'sendOctave("VZl=VZ1;")
        'sendOctave("IZl=VZl/Zl;")

        'sendOctave("GVZl=VZl/V;")
        'sendOctave("GIZl=IZl/IZ2;")
        'sendOctave("GPZl=GVZl*GIZl;")
        ''----------------------VOLTAJE----------------------
        'sendOctave("[v,t]=" & typeResponse & "{(}GVZl{)};")
        'sendOctave("c=length{(}t{)};")
        'sendOctave("tiempo=t{(}c{)}*1.1;")
        'sendOctave("[v,t]=" & typeResponse & "{(}GVZl,tiempo,tiempo/" & cant_elementos & "{)};")
        'sendOctave("dlmwrite{(}'" & Application.StartupPath & "\t.txt',t,'\n'{)};")
        'sendOctave("dlmwrite{(}'" & Application.StartupPath & "\v.txt',v,'\n'{)};")
        ''----------------------CORRIENTE--------------------
        'sendOctave("[i,t]=" & typeResponse & "{(}GIZl{)};")
        'sendOctave("c=length{(}t{)};")
        'sendOctave("tiempo=t{(}c{)}*1.1;")
        'sendOctave("[i,t]=" & typeResponse & "{(}GIZl,tiempo,tiempo/" & cant_elementos & "{)};")
        'sendOctave("dlmwrite{(}'" & Application.StartupPath & "\t.txt',t,'\n'{)};")
        'sendOctave("dlmwrite{(}'" & Application.StartupPath & "\i.txt',i,'\n'{)};")
        '----------------------POTENCIA---------------------
        'sendOctave("[p,t]=" & typeResponse & "{(}GPZl{)};")
        'sendOctave("c=length{(}t{)};")
        'sendOctave("tiempo=t{(}c{)}*1.1;")
        'sendOctave("[p,t]=" & typeResponse & "{(}GPZl,tiempo,tiempo/" & cant_elementos & "{)};")
        'sendOctave("dlmwrite{(}'" & Application.StartupPath & "\t.txt',t,'\n'{)};")
        'sendOctave("dlmwrite{(}'" & Application.StartupPath & "\p.txt',p,'\n'{)};")
    End Sub

    Sub createOctaveFile()
        Dim writerFile As StreamWriter
        Try
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\v.txt")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\i.txt")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\t.txt")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\octaveFile.m")
        Catch ex As Exception

        End Try

        writerFile = File.AppendText(Application.StartupPath & "\octaveFile.m")
        writerFile.Write("clc" & vbCrLf &
        "clear" & vbCrLf &
        "pkg load control" & vbCrLf &
        "s=tf('s');" & vbCrLf &
        "V=" & vV & vbCrLf &
        "C=" & vC & ";" & vbCrLf &
        "L=" & vL & ";" & vbCrLf &
        "Z=" & vZ & ";" & vbCrLf &
        "Zl=" & vZL & ";" & vbCrLf &
        "Z1=Zl/(C*s*Zl+1);" & vbCrLf &
        "Z2=Z+L*s+Z1;" & vbCrLf &
        "IZ2=V/Z2;" & vbCrLf &
        "VZ2=V;" & vbCrLf &
        "IZ1=IZ2;" & vbCrLf &
        "VZ1=IZ1*Z1;" & vbCrLf &
        "VZl=VZ1;" & vbCrLf &
        "IZl=VZl/Zl;" & vbCrLf &
        "GVZl=VZl/V;" & vbCrLf &
        "GIZl=IZl/IZ2;" & vbCrLf &
        "GPZl=GVZl*GIZl;" & vbCrLf &
        "[v,t]=" & typeResponse & "(GVZl);" & vbCrLf &
        "c=length(t);" & vbCrLf &
        "tiempo=t(c)*1.1;" & vbCrLf &
        "[v,t]=" & typeResponse & "(GVZl,tiempo,tiempo/" & cant_elementos & ");" & vbCrLf &
        "dlmwrite('" & Application.StartupPath & "\t.txt',t,'\n');" & vbCrLf &
        "dlmwrite('" & Application.StartupPath & "\v.txt',v,'\n');" & vbCrLf &
        "[i,t]=" & typeResponse & "(GIZl);" & vbCrLf &
        "c=length(t);" & vbCrLf &
        "tiempo=t(c)*1.1;" & vbCrLf &
        "[i,t]=" & typeResponse & "(GIZl,tiempo,tiempo/" & cant_elementos & ");" & vbCrLf &
        "dlmwrite('" & Application.StartupPath & "\t.txt',t,'\n');" & vbCrLf &
        "dlmwrite('" & Application.StartupPath & "\i.txt',i,'\n');")

        writerFile.Flush()
        writerFile.Close()
    End Sub

    Sub loadData()
        ReDim vectorV(cant_elementos)
        ReDim vectorI(cant_elementos)
        ReDim vectorP(cant_elementos)
        ReDim vectorT(cant_elementos)
        Dim datosV, datosI, datosT As StreamReader

        '----------------------VOLTAJE----------------------
        datosV = New StreamReader(Application.StartupPath & "\v.txt")
        For j As Integer = 0 To cant_elementos - 1
            vectorV(j) = Val(datosV.ReadLine) * gan
        Next
        datosV.Close()
        '----------------------CORRIENTE--------------------
        datosI = New StreamReader(Application.StartupPath & "\i.txt")
        For j As Integer = 0 To cant_elementos - 1
            vectorI(j) = Val(datosI.ReadLine) * gan
        Next
        datosI.Close()
        '----------------------POTENCIA---------------------
        For j As Integer = 0 To cant_elementos - 1
            vectorP(j) = vectorV(j) * vectorI(j)
        Next
        '----------------------TIEMPO-----------------------
        datosT = New StreamReader(Application.StartupPath & "\t.txt")
        For j As Integer = 0 To cant_elementos - 1
            vectorT(j) = Val(datosT.ReadLine)
        Next
        datosT.Close()

        If Cb_animation.Checked Then
            Timer1.Enabled = True
        Else
            For i As Integer = 0 To cant_elementos - 1
                plotPoints()
            Next
            Chart_V.Series(0).ToolTip = "#VAL{N2}"
            Chart_I.Series(0).ToolTip = "#VAL{N2}"
            Chart_P.Series(0).ToolTip = "#VAL{N2}"
            saveSimulationData()
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        plotPoints()
        If aux = cant_elementos Then
            Timer1.Enabled = False
            Chart_V.Series(0).ToolTip = "#VAL{N2}"
            Chart_I.Series(0).ToolTip = "#VAL{N2}"
            Chart_P.Series(0).ToolTip = "#VAL{N2}"
            saveSimulationData()
        End If
    End Sub

    Private Sub Tb_v_TextChanged(sender As Object, e As EventArgs) Handles Tb_v.TextChanged
        If Not IsNumeric(Tb_v.Text) Or Val(Tb_v.Text) < 1 Then
            Tb_v.Text = 1
        End If
    End Sub

    Private Sub Tb_z_TextChanged(sender As Object, e As EventArgs) Handles Tb_z.TextChanged
        If Not IsNumeric(Tb_z.Text) Or Val(Tb_z.Text) < 1 Then
            Tb_z.Text = 1
        End If
    End Sub

    Private Sub Tb_l_TextChanged(sender As Object, e As EventArgs) Handles Tb_l.TextChanged
        If Not IsNumeric(Tb_l.Text) Or Val(Tb_l.Text) < 1 Then
            Tb_l.Text = 1
        End If
    End Sub

    Private Sub Tb_c_TextChanged(sender As Object, e As EventArgs) Handles Tb_c.TextChanged
        If Not IsNumeric(Tb_c.Text) Or Val(Tb_c.Text) < 1 Then
            Tb_c.Text = 1
        End If
    End Sub

    Private Sub Tb_zl_TextChanged(sender As Object, e As EventArgs) Handles Tb_zl.TextChanged
        If Not IsNumeric(Tb_zl.Text) Or Val(Tb_zl.Text) < 1 Then
            Tb_zl.Text = 1
        End If
    End Sub

    Private Sub Tb_MinZ_Scroll(sender As Object, e As EventArgs) Handles Tb_MinZ.Scroll
        L_MinZ.Text = Tb_MinZ.Value.ToString
        Tb_z.Text = L_MinZ.Text
        If Tb_MinZ.Value = Tb_MaxZ.Value Then
            NUD_Z.Enabled = False
        Else
            NUD_Z.Enabled = True
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles Tb_MaxZ.Scroll
        L_MaxZ.Text = Tb_MaxZ.Value.ToString
        If Tb_MinZ.Value = Tb_MaxZ.Value Then
            NUD_Z.Enabled = False
        Else
            NUD_Z.Enabled = True
        End If
    End Sub

    Private Sub Tb_MinZL_Scroll(sender As Object, e As EventArgs) Handles Tb_MinZL.Scroll
        L_MinZL.Text = Tb_MinZL.Value.ToString
        Tb_zl.Text = L_MinZL.Text
        If Tb_MinZL.Value = Tb_MaxZL.Value Then
            NUD_ZL.Enabled = False
        Else
            NUD_ZL.Enabled = True
        End If
    End Sub

    Private Sub Tb_MaxZL_Scroll(sender As Object, e As EventArgs) Handles Tb_MaxZL.Scroll
        L_MaxZL.Text = Tb_MaxZL.Value.ToString
        If Tb_MinZL.Value = Tb_MaxZL.Value Then
            NUD_ZL.Enabled = False
        Else
            NUD_ZL.Enabled = True
        End If
    End Sub

    Sub plotPoints()
        Chart_V.Series(0).Points.AddXY(Math.Round(vectorT(aux), 2), vectorV(aux))
        Chart_I.Series(0).Points.AddXY(Math.Round(vectorT(aux), 2), vectorI(aux))
        Chart_P.Series(0).Points.AddXY(Math.Round(vectorT(aux), 2), vectorP(aux))
        aux += 1
    End Sub

    Sub cleanCharts()
        Chart_V.Series(0).Points.Clear()
        Chart_I.Series(0).Points.Clear()
        Chart_P.Series(0).Points.Clear()
    End Sub

    Sub saveSimulationData()
        FormSimulationHistory.DGV_SimulationHistory.Rows.Add()
        Dim numberRows = FormSimulationHistory.DGV_SimulationHistory.Rows.Count - 1
        FormSimulationHistory.DGV_SimulationHistory.Item(0, numberRows).Value = numberRows + 1
        FormSimulationHistory.DGV_SimulationHistory.Item(1, numberRows).Value = Tb_num.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(2, numberRows).Value = Tb_g.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(3, numberRows).Value = Cb_simulationType.Text

        FormSimulationHistory.DGV_SimulationHistory.Item(4, numberRows).Value = Tb_v.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(5, numberRows).Value = CB_Z.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(6, numberRows).Value = Tb_z.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(7, numberRows).Value = Tb_l.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(8, numberRows).Value = Tb_c.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(9, numberRows).Value = CB_ZL.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(10, numberRows).Value = Tb_zl.Text

        Dim bmpV As New Bitmap(Chart_V.Width, Chart_V.Height)
        Chart_V.DrawToBitmap(bmpV, Chart_V.DisplayRectangle)
        FormSimulationHistory.DGV_SimulationHistory.Item(11, numberRows).Value = bmpV

        Dim bmpI As New Bitmap(Chart_I.Width, Chart_I.Height)
        Chart_I.DrawToBitmap(bmpI, Chart_I.DisplayRectangle)
        FormSimulationHistory.DGV_SimulationHistory.Item(12, numberRows).Value = bmpI

        Dim bmpP As New Bitmap(Chart_P.Width, Chart_P.Height)
        Chart_P.DrawToBitmap(bmpP, Chart_P.DisplayRectangle)
        FormSimulationHistory.DGV_SimulationHistory.Item(13, numberRows).Value = bmpP

    End Sub

    Sub disableSimulationButtons()
        Bt_start.Enabled = False
        Tb_v.Enabled = False
        Tb_l.Enabled = False
        Tb_c.Enabled = False
        Cb_simulationType.Enabled = False
        Tb_num.Enabled = False
        Tb_g.Enabled = False
        Tb_MinZ.Enabled = False
        Tb_MaxZ.Enabled = False
        CB_Z.Enabled = False
        NUD_Z.Enabled = False
        Tb_MinZL.Enabled = False
        Tb_MaxZL.Enabled = False
        CB_ZL.Enabled = False
        NUD_ZL.Enabled = False
        FormMain.Bt_simulationHistory.Enabled = False
        FormMain.Bt_pathOctave.Enabled = False
        FormMain.Bt_simulation.Enabled = False
        FormMain.Bt_exit.Enabled = False

    End Sub

    Sub activateSimulationButtons()
        Bt_start.Enabled = True
        Tb_v.Enabled = True
        Tb_l.Enabled = True
        Tb_c.Enabled = True
        Cb_simulationType.Enabled = True
        Tb_num.Enabled = True
        Tb_g.Enabled = True
        Tb_MinZ.Enabled = True
        Tb_MaxZ.Enabled = True
        CB_Z.Enabled = True
        NUD_Z.Enabled = True
        Tb_MinZL.Enabled = True
        Tb_MaxZL.Enabled = True
        CB_ZL.Enabled = True
        NUD_ZL.Enabled = True
        FormMain.Bt_simulationHistory.Enabled = True
        FormMain.Bt_pathOctave.Enabled = True
        FormMain.Bt_simulation.Enabled = True
        FormMain.Bt_exit.Enabled = True
    End Sub

End Class