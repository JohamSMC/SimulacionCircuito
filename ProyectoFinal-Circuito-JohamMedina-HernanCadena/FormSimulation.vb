Public Class FormSimulation
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
End Class