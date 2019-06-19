Public Class Group
    Public Property [Class] As Label
    Public Property Num As Label
    Dim WithEvents timer1 As Timer = New Timer
    Dim WithEvents timer2 As Timer = New Timer
    Dim WithEvents timer3 As Timer = New Timer With {.Interval = 350}
    Dim control_Timer As Timer
    Public finshed As Boolean = False
    Public Sub New(class_label As Label, num_label As Label)
        [Class] = class_label
        Num = num_label
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        Dim r_class As Random = New Random()
        [Class].Text = num_format(r_class.Next(1, 13))
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        Dim r_num As Random = New Random()
        Num.Text = num_format(r_num.Next(1, Class_MaxiNum(Val([Class].Text))) + 1)
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles timer3.Tick

        If control_Timer.Interval >= 600 Then
            control_Timer.Stop()

            If control_Timer Is timer1 Then
                [Class].ForeColor = Color.Red
            End If
            If control_Timer Is timer2 Then
                Num.ForeColor = Color.Red
                If Me Is dos(0) And finshed = False Then
                    dos(1).Stop()
                    finshed = True
                    Form1.Label10.Visible = True
                    Form1.Label10.Text = "Who is the lucky dog?"
                    Form1.Label10.Font = New Font(New FontFamily("Comic Sans MS"), Form1.Label9.Font.Size)
                    If use_height = ONE_HEIGHT Then
                        Randing = False
                    End If
                End If
                If Me Is dos(1) Then
                    Randing = False
                    Form1.Label10.Text = "恭喜！"
                    Form1.Label10.Font = New Font(New FontFamily("黑体"), Form1.Label9.Font.Size)
                End If
                timer3.Stop()
                Form1.Label9.Text = "恭喜！"
                Form1.Label9.Font = New Font(New FontFamily("黑体"), Form1.Label9.Font.Size)

            End If
            control_Timer = timer2
        Else
            control_Timer.Interval += 50
        End If
    End Sub
    Public Sub Start()
        finshed = False
        timer1.Interval = 50
        timer1.Enabled = True
        timer2.Interval = 50
        timer2.Enabled = True
        timer3.Interval = 350
    End Sub

    Public Sub [Stop]()
        control_Timer = timer1
        timer3.Start()
    End Sub
    Public Function num_format(num As Integer) As String
        If num < 10 Then
            num_format = "0" + CStr(num)
        Else
            num_format = CStr(num)
        End If
    End Function
End Class
