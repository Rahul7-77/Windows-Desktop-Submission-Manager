<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Button3 = New Button()
        TextBoxOfName = New TextBox()
        TextBoxOfEmail = New TextBox()
        TextBoxOfPhone = New TextBox()
        TextBoxOfGithub = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        BtnToggleStopwatch = New Button()
        LabelElapsedTime = New Label()
        TimerStopwatch = New Timer(components)
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.GradientActiveCaption
        Button3.Location = New Point(261, 392)
        Button3.Name = "Button3"
        Button3.Size = New Size(325, 66)
        Button3.TabIndex = 0
        Button3.Text = "SUBMIT (CTRL + S)"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBoxOfName
        ' 
        TextBoxOfName.Location = New Point(376, 92)
        TextBoxOfName.Name = "TextBoxOfName"
        TextBoxOfName.Size = New Size(346, 31)
        TextBoxOfName.TabIndex = 1
        ' 
        ' TextBoxOfEmail
        ' 
        TextBoxOfEmail.Location = New Point(376, 153)
        TextBoxOfEmail.Name = "TextBoxOfEmail"
        TextBoxOfEmail.Size = New Size(346, 31)
        TextBoxOfEmail.TabIndex = 2
        ' 
        ' TextBoxOfPhone
        ' 
        TextBoxOfPhone.Location = New Point(376, 211)
        TextBoxOfPhone.Name = "TextBoxOfPhone"
        TextBoxOfPhone.Size = New Size(346, 31)
        TextBoxOfPhone.TabIndex = 3
        ' 
        ' TextBoxOfGithub
        ' 
        TextBoxOfGithub.Location = New Point(376, 274)
        TextBoxOfGithub.Name = "TextBoxOfGithub"
        TextBoxOfGithub.Size = New Size(346, 31)
        TextBoxOfGithub.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(237, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 28)
        Label1.TabIndex = 5
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(232, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 28)
        Label2.TabIndex = 6
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(232, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 28)
        Label3.TabIndex = 7
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(232, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 56)
        Label4.TabIndex = 8
        Label4.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' BtnToggleStopwatch
        ' 
        BtnToggleStopwatch.BackColor = SystemColors.Info
        BtnToggleStopwatch.Font = New Font("Segoe UI", 10F)
        BtnToggleStopwatch.Location = New Point(164, 325)
        BtnToggleStopwatch.Name = "BtnToggleStopwatch"
        BtnToggleStopwatch.Size = New Size(183, 47)
        BtnToggleStopwatch.TabIndex = 9
        BtnToggleStopwatch.Text = "PAUSE (CTRL + T)"
        BtnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' LabelElapsedTime
        ' 
        LabelElapsedTime.AutoSize = True
        LabelElapsedTime.Font = New Font("Segoe UI", 10F)
        LabelElapsedTime.Location = New Point(376, 334)
        LabelElapsedTime.Name = "LabelElapsedTime"
        LabelElapsedTime.Size = New Size(86, 28)
        LabelElapsedTime.TabIndex = 10
        LabelElapsedTime.Text = "00:00:00"
        ' 
        ' TimerStopwatch
        ' 
        TimerStopwatch.Interval = 1000
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(217, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(521, 32)
        Label5.TabIndex = 11
        Label5.Text = "Rahul Dasari, Slidely Task 2 - Create Submission"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(837, 484)
        Controls.Add(Label5)
        Controls.Add(LabelElapsedTime)
        Controls.Add(BtnToggleStopwatch)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBoxOfGithub)
        Controls.Add(TextBoxOfPhone)
        Controls.Add(TextBoxOfEmail)
        Controls.Add(TextBoxOfName)
        Controls.Add(Button3)
        KeyPreview = True
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents TextBoxOfName As TextBox
    Friend WithEvents TextBoxOfEmail As TextBox
    Friend WithEvents TextBoxOfPhone As TextBox
    Friend WithEvents TextBoxOfGithub As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnToggleStopwatch As Button
    Friend WithEvents LabelElapsedTime As Label
    Friend WithEvents TimerStopwatch As Timer
    Friend WithEvents Label5 As Label
End Class
