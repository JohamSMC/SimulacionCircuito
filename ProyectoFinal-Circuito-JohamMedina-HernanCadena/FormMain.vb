Imports System.IO

Public Class FormMain
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Bt_exit.Click
        End
    End Sub

    Private Sub Bt_pathOctave_Click(sender As Object, e As EventArgs) Handles Bt_pathOctave.Click
        MsgBox("Seleccione ruta de instalación de Octave", MsgBoxStyle.OkOnly)
        Dim folder As New FolderBrowserDialog
        Dim ruta As String = ""
        If folder.ShowDialog() = DialogResult.OK Then
            ruta = folder.SelectedPath & "\mingw64\bin\octave-cli.exe"
            MsgBox(ruta)
            MsgBox(Application.StartupPath & "\ruta.txt")
            Try
                Dim escritor As StreamWriter
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\ruta.txt")
                escritor = File.AppendText(Application.StartupPath & "\ruta.txt")
                escritor.Write(ruta)
                escritor.Flush()
                escritor.Close()
            Catch ex As Exception
                MsgBox("Error con la ruta de OCTAVE, por favor intente otra vez")
            End Try
        End If
        Bt_simulation.Enabled = True
        Bt_simulationHistory.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bt_simulation.Click
        FormSimulation.MdiParent = Me
        FormSimulation.Show()
        FormSimulation.WindowState = FormWindowState.Maximized
        FormSimulationHistory.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Bt_simulationHistory_Click(sender As Object, e As EventArgs) Handles Bt_simulationHistory.Click
        FormSimulationHistory.MdiParent = Me
        FormSimulationHistory.Show()
        FormSimulationHistory.WindowState = FormWindowState.Maximized
        FormSimulation.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bt_simulation.Enabled = False
        'Bt_simulationHistory.Enabled = False
    End Sub
End Class
