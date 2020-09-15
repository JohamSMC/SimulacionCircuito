Module Module1
    Public path_Octave As String = ""

    Public Sub sendOctave(cadena As String)
        AppActivate(path_Octave)
        SendKeys.SendWait(cadena & Chr(13))
        System.Threading.Thread.Sleep(10)
    End Sub

    Public Sub closeOctave()
        Try
            sendOctave("exit")
        Catch ex As Exception
        End Try
    End Sub
End Module
