Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class Form3
    'Private submissions As List(Of Dictionary(Of String, String))
    Private curindex As Integer = -2
    Private endLength As Integer = 0
    Private isEditing As Boolean = False

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions()
        Await DisplaySubmission(curindex)
    End Sub

    Private Async Function LoadSubmissions() As Task
        Dim client As New HttpClient()
        Dim url As String = $"http://localhost:3000/read?id={curindex}"
        Try
            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim lengthString As String = Await response.Content.ReadAsStringAsync()
                Dim dbLength As Integer
                If Integer.TryParse(lengthString, dbLength) Then

                    'MessageBox.Show($"Length of db.json so far: {dbLength}")
                    endLength = dbLength
                    curindex = endLength - 1
                    Await DisplaySubmission(curindex)
                Else
                    MessageBox.Show("Invalid response format: not a valid integer")
                End If
            Else
                MessageBox.Show("Error with server connection!")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Function

    Private Async Function DisplaySubmission(index As Integer) As Task
        Dim client As New HttpClient()
        Dim url As String = $"http://localhost:3000/read?id={curindex}"

        Try
            Dim response As HttpResponseMessage = Await client.GetAsync(url)

            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim data As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(json)

                TextBoxSubmissionOfName.Text = data("Name")
                TextBoxSubmissionOfEmail.Text = data("Email")
                TextBoxSubmissionOfPhone.Text = data("Phone")
                TextBoxSubmissionOfGithub.Text = data("Github")
                TextBoxSubmissionOfStopwatch.Text = data("elapsedTime")
            Else
                MessageBox.Show("Error retrieving submission data!")
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

    End Function

    Private Sub SetTextBoxesReadOnly(isReadOnly As Boolean)
        TextBoxSubmissionOfName.ReadOnly = isReadOnly
        TextBoxSubmissionOfEmail.ReadOnly = isReadOnly
        TextBoxSubmissionOfPhone.ReadOnly = isReadOnly
        TextBoxSubmissionOfGithub.ReadOnly = isReadOnly
        TextBoxSubmissionOfStopwatch.ReadOnly = isReadOnly
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If curindex > 0 And curindex < endLength Then
            curindex -= 1
            Dim Task = DisplaySubmission(curindex)
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If curindex >= 0 And curindex < endLength - 1 Then
            curindex += 1
            Dim Task = DisplaySubmission(curindex)
        End If
    End Sub

    Private Async Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If endLength > 0 And curindex >= 0 And curindex < endLength Then
            Dim client As New HttpClient()
            Dim url As String = $"http://localhost:3000/delete?id={curindex}"
            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync(url)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted successfully!")
                    endLength -= 1
                    If curindex > 0 Then
                        curindex -= 1
                    End If
                    'If curindex <= endLength And curindex >= 0 Then
                    'currentIndex = dbLength - 1
                    'End If
                    If curindex >= 0 And curindex < endLength Then
                        Await DisplaySubmission(curindex)
                    Else
                        TextBoxSubmissionOfName.Clear()
                        TextBoxSubmissionOfEmail.Clear()
                        TextBoxSubmissionOfPhone.Clear()
                        TextBoxSubmissionOfGithub.Clear()
                        TextBoxSubmissionOfStopwatch.Clear()
                        MessageBox.Show("No submissions found.")
                    End If
                Else
                    MessageBox.Show("Error deleting submission!")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If isEditing Then
            ' Save the changes
            ButtonEdit.Text = "EDIT (CTRL + S)"
            isEditing = False
            SetTextBoxesReadOnly(True)
            SaveSubmission(curindex)
        Else
            ' Enable editing
            ButtonEdit.Text = "SAVE (CTRL + S)"
            isEditing = True
            SetTextBoxesReadOnly(False)
        End If
    End Sub

    Private Async Sub SaveSubmission(index As Integer)
        Dim client As New HttpClient()
        Dim url As String = $"http://localhost:3000/editAndSave?id={index}"

        Dim updatedSubmission As New Dictionary(Of String, String) From {
            {"Name", TextBoxSubmissionOfName.Text},
            {"Email", TextBoxSubmissionOfEmail.Text},
            {"Phone", TextBoxSubmissionOfPhone.Text},
            {"Github", TextBoxSubmissionOfGithub.Text},
            {"elapsedTime", TextBoxSubmissionOfStopwatch.Text}
        }

        Try
            Dim json As String = JsonConvert.SerializeObject(updatedSubmission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PutAsync(url, content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully!")
            Else
                MessageBox.Show("Error updating submission!")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Trigger the Click event of the submit button
            BtnNext.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Trigger the Click event of the submit button
            BtnPrevious.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Trigger the Click event of the submit button
            ButtonEdit.PerformClick()
        End If
        'If e.Control AndAlso e.KeyCode = Keys.S Then
        ' Trigger the Click event of the submit button
        'ButtonEdit.PerformClick()
        'End If
        If e.Control AndAlso e.KeyCode = Keys.D Then
            ' Trigger the Click event of the submit button
            ButtonDelete.PerformClick()
        End If
    End Sub
End Class
