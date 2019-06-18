Public Class Form1
    Dim control_Timer As Timer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Class_MaxiNum(1) = 45
        Class_MaxiNum(2) = 45
        Class_MaxiNum(3) = 40
        Class_MaxiNum(4) = 43
        Class_MaxiNum(5) = 43
        Class_MaxiNum(6) = 49
        Class_MaxiNum(7) = 42
        Class_MaxiNum(8) = 46
        Class_MaxiNum(9) = 47
        Class_MaxiNum(10) = 46
        Class_MaxiNum(11) = 40
        Class_MaxiNum(12) = 38
        Me.Size = New Size(Me.Width, use_height)
        Location = New Point((Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2)
        dos(0) = New Group(Label1, Label2)
        dos(1) = New Group(Label8, Label7)
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        If Randing = False Then
            Label9.Visible = False
            Label10.Visible = False
            Randing = True
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label8.ForeColor = Color.Black
            Label7.ForeColor = Color.Black
            'dos(0) = New Group(Label1, Label2)
            'dos(1) = New Group(Label8, Label7)
            dos(0).Start()
            dos(1).Start()
        ElseIf Randing = True Then
            Label9.Text = "Who is the lucky dog?"
            Label9.Font = New Font(New FontFamily("Comic Sans MS"), Label9.Font.Size)
            Label9.Visible = True
            Timer4.Start()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Static count As Integer = 0
        count += 200
        If count >= 800 Then
            Timer4.Stop()
            dos(0).Stop()
            count = 0
        End If
    End Sub
End Class
