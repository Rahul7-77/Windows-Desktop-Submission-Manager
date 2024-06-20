<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        BtnPrevious = New Button()
        BtnNext = New Button()
        TextBoxSubmissionOfName = New TextBox()
        TextBoxSubmissionOfEmail = New TextBox()
        TextBoxSubmissionOfPhone = New TextBox()
        TextBoxSubmissionOfGithub = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBoxSubmissionOfStopwatch = New TextBox()
        ButtonDelete = New Button()
        ButtonEdit = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' BtnPrevious
        ' 
        BtnPrevious.BackColor = SystemColors.Info
        BtnPrevious.Location = New Point(212, 391)
        BtnPrevious.Name = "BtnPrevious"
        BtnPrevious.Size = New Size(148, 69)
        BtnPrevious.TabIndex = 1
        BtnPrevious.Text = "PREVIOUS " & vbCrLf & "(CTRL + P)"
        BtnPrevious.UseVisualStyleBackColor = False
        ' 
        ' BtnNext
        ' 
        BtnNext.BackColor = SystemColors.GradientActiveCaption
        BtnNext.Location = New Point(395, 391)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(161, 69)
        BtnNext.TabIndex = 2
        BtnNext.Text = "NEXT" & vbCrLf & "(CTRL + N)"
        BtnNext.UseVisualStyleBackColor = False
        ' 
        ' TextBoxSubmissionOfName
        ' 
        TextBoxSubmissionOfName.Location = New Point(409, 91)
        TextBoxSubmissionOfName.Name = "TextBoxSubmissionOfName"
        TextBoxSubmissionOfName.ReadOnly = True
        TextBoxSubmissionOfName.Size = New Size(295, 31)
        TextBoxSubmissionOfName.TabIndex = 3
        ' 
        ' TextBoxSubmissionOfEmail
        ' 
        TextBoxSubmissionOfEmail.Location = New Point(409, 150)
        TextBoxSubmissionOfEmail.Name = "TextBoxSubmissionOfEmail"
        TextBoxSubmissionOfEmail.ReadOnly = True
        TextBoxSubmissionOfEmail.Size = New Size(295, 31)
        TextBoxSubmissionOfEmail.TabIndex = 4
        ' 
        ' TextBoxSubmissionOfPhone
        ' 
        TextBoxSubmissionOfPhone.Location = New Point(409, 210)
        TextBoxSubmissionOfPhone.Name = "TextBoxSubmissionOfPhone"
        TextBoxSubmissionOfPhone.ReadOnly = True
        TextBoxSubmissionOfPhone.Size = New Size(295, 31)
        TextBoxSubmissionOfPhone.TabIndex = 5
        ' 
        ' TextBoxSubmissionOfGithub
        ' 
        TextBoxSubmissionOfGithub.Location = New Point(409, 270)
        TextBoxSubmissionOfGithub.Name = "TextBoxSubmissionOfGithub"
        TextBoxSubmissionOfGithub.ReadOnly = True
        TextBoxSubmissionOfGithub.Size = New Size(295, 31)
        TextBoxSubmissionOfGithub.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(250, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 28)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(250, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 28)
        Label2.TabIndex = 8
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(225, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 28)
        Label3.TabIndex = 9
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(225, 261)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 50)
        Label4.TabIndex = 10
        Label4.Text = "Github  Link " & vbCrLf & "For Task - 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(225, 335)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 25)
        Label5.TabIndex = 11
        Label5.Text = "Stopwatch time"
        ' 
        ' TextBoxSubmissionOfStopwatch
        ' 
        TextBoxSubmissionOfStopwatch.Location = New Point(409, 329)
        TextBoxSubmissionOfStopwatch.Name = "TextBoxSubmissionOfStopwatch"
        TextBoxSubmissionOfStopwatch.ReadOnly = True
        TextBoxSubmissionOfStopwatch.Size = New Size(295, 31)
        TextBoxSubmissionOfStopwatch.TabIndex = 12
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.BackColor = SystemColors.ButtonFace
        ButtonDelete.Location = New Point(12, 391)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(158, 69)
        ButtonDelete.TabIndex = 13
        ButtonDelete.Text = "DELETE " & vbCrLf & "(CTRL + D)"
        ButtonDelete.UseVisualStyleBackColor = False
        ' 
        ' ButtonEdit
        ' 
        ButtonEdit.BackColor = SystemColors.ControlLight
        ButtonEdit.Location = New Point(598, 391)
        ButtonEdit.Name = "ButtonEdit"
        ButtonEdit.Size = New Size(158, 69)
        ButtonEdit.TabIndex = 14
        ButtonEdit.Text = "EDIT " & vbCrLf & "(CTRL + S)"
        ButtonEdit.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(205, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(503, 32)
        Label6.TabIndex = 15
        Label6.Text = "Rahul Dasari, Slidely Task 2 - View Submission"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 496)
        Controls.Add(Label6)
        Controls.Add(ButtonEdit)
        Controls.Add(ButtonDelete)
        Controls.Add(TextBoxSubmissionOfStopwatch)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBoxSubmissionOfGithub)
        Controls.Add(TextBoxSubmissionOfPhone)
        Controls.Add(TextBoxSubmissionOfEmail)
        Controls.Add(TextBoxSubmissionOfName)
        Controls.Add(BtnNext)
        Controls.Add(BtnPrevious)
        KeyPreview = True
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents TextBoxSubmissionOfName As TextBox
    Friend WithEvents TextBoxSubmissionOfEmail As TextBox
    Friend WithEvents TextBoxSubmissionOfPhone As TextBox
    Friend WithEvents TextBoxSubmissionOfGithub As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxSubmissionOfStopwatch As TextBox
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents Label6 As Label
End Class
