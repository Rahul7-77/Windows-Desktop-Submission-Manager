Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class Form2
    Private stopwatch As Stopwatch = New Stopwatch()

    Private Sub Form2(sender As Object, e As EventArgs) Handles MyBase.Load

        stopwatch.Start()
        TimerStopwatch.Start()
        LabelElapsedTime.Text = "00:00:00"
        BtnToggleStopwatch.Text = "PAUSE (CTRL + T)"
    End Sub

    Private Sub BtnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles BtnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            TimerStopwatch.Stop()
            BtnToggleStopwatch.Text = "RESUME (CTRL + T)"
        Else
            stopwatch.Start()
            TimerStopwatch.Start()
            BtnToggleStopwatch.Text = "PAUSE (CTRL + T)"
        End If
    End Sub

    Private Sub TimerStopwatch_Tick(sender As Object, e As EventArgs) Handles TimerStopwatch.Tick
        LabelElapsedTime.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub
    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Name As String = TextBoxOfName.Text
        Dim email As String = TextBoxOfEmail.Text
        Dim phoneNum As String = TextBoxOfPhone.Text
        Dim Github As String = TextBoxOfGithub.Text
        Dim elapsedTime As String = stopwatch.Elapsed.ToString("hh\:mm\:ss")

        Dim data As New Dictionary(Of String, String) From {
            {"Name", Name},
            {"email", email},
            {"phoneNum", phoneNum},
            {"Github", Github},
            {"elapsedTime", elapsedTime}
        }

        Dim json As String = JsonConvert.SerializeObject(data)
        'MessageBox.Show(json)

        Dim client As New HttpClient()

        Dim url As String = "http://localhost:3000/submit"

        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Data submitted successfully!")
                TextBoxOfName.Text = ""
                TextBoxOfEmail.Text = ""
                TextBoxOfPhone.Text = ""
                TextBoxOfGithub.Text = ""
                stopwatch.Reset()
                LabelElapsedTime.Text = "00:00:00"
                stopwatch.Start()
            Else
                MessageBox.Show("Error submitting data!")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Button3.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.T Then
            BtnToggleStopwatch.PerformClick()
        End If
    End Sub

End Class

