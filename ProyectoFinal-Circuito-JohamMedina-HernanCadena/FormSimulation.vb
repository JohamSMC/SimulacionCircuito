Imports System.IO

Public Class FormSimulation
    Dim pInfo As New ProcessStartInfo
    Dim p As Process
    Dim vL, vC As Double
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bt_start.Click
        Try
            pInfo.FileName = path_Octave
            pInfo.WindowStyle = ProcessWindowStyle.Minimized
            p = Process.Start(pInfo)
            Bt_start.Enabled = True
        Catch ex As Exception
            MsgBox("No se encuentra el archivo Octave-CLI")
            Bt_start.Enabled = False
        End Try
        System.Threading.Thread.Sleep(3000)

        sendOctave("cd '" & Application.StartupPath & "'")

        aux = 0
        cleanCharts()
        vC = Tb_c.Text
        vL = Tb_l.Text

        Select Case CB_ZL.SelectedIndex
            Case 0
                vZL = Tb_zl.Text
            Case 1
                vZL = "1/{(}" & Tb_zl.Text & "*s{)}"
            Case 2
                vZL = Tb_zl.Text & "*s"
        End Select

        Select Case CB_Z.SelectedIndex
            Case 0
                'vZ = Tb_z.Text
            Case 1
                'vZ = "1/{(}" & Tb_z.Text & "*s{)}"
            Case 2
                'vZ = Tb_z.Text & "*s"
        End Select

        cant_elementos = Tb_num.Text
        gan = Tb_g.Text

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

        End While

        closeOctave()
        loadData()

        'sendOctave("clc")
        'sendOctave("clear")
        'sendOctave("pkg load control")
        'sendOctave("s=tf{(}'s'{)};")
        'sendOctave("V=1;")  'Revisión porqué 1
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
        "V=1;" & vbCrLf &
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

    Private Sub Tb_MinZ_Scroll(sender As Object, e As EventArgs) Handles Tb_MinZ.Scroll
        L_MinZ.Text = Tb_MinZ.Value.ToString
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles Tb_MaxZ.Scroll
        L_MaxZ.Text = Tb_MaxZ.Value.ToString
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
        FormSimulationHistory.DGV_SimulationHistory.Item(0, numberRows).Value = Tb_num.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(1, numberRows).Value = Tb_g.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(2, numberRows).Value = Cb_simulationType.Text

        FormSimulationHistory.DGV_SimulationHistory.Item(3, numberRows).Value = CB_Z.Text
        'FormSimulationHistory.DGV_SimulationHistory.Item(4, numberRows).Value = Tb_z.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(5, numberRows).Value = Tb_l.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(6, numberRows).Value = Tb_c.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(7, numberRows).Value = CB_ZL.Text
        FormSimulationHistory.DGV_SimulationHistory.Item(8, numberRows).Value = Tb_zl.Text

        Dim bmpV As New Bitmap(Chart_V.Width, Chart_V.Height)
        Chart_V.DrawToBitmap(bmpV, Chart_V.DisplayRectangle)
        FormSimulationHistory.DGV_SimulationHistory.Item(9, numberRows).Value = bmpV

        Dim bmpI As New Bitmap(Chart_I.Width, Chart_I.Height)
        Chart_I.DrawToBitmap(bmpI, Chart_I.DisplayRectangle)
        FormSimulationHistory.DGV_SimulationHistory.Item(10, numberRows).Value = bmpI

        Dim bmpP As New Bitmap(Chart_P.Width, Chart_P.Height)
        Chart_P.DrawToBitmap(bmpP, Chart_P.DisplayRectangle)
        FormSimulationHistory.DGV_SimulationHistory.Item(11, numberRows).Value = bmpP

    End Sub

End Class