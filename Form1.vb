Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Trigger the Click event of the submit button
            Button1.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Trigger the Click event of the submit button
            Button2.PerformClick()
        End If
    End Sub
End Class
