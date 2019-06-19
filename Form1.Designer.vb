<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 35.0!)
        Me.Label1.Location = New System.Drawing.Point(636, 357)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "01"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 35.0!)
        Me.Label2.Location = New System.Drawing.Point(833, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 76)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "01"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 25.0!)
        Me.Label3.Location = New System.Drawing.Point(535, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 55)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "班级"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 25.0!)
        Me.Label4.Location = New System.Drawing.Point(734, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 55)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "学号"
        '
        'Timer3
        '
        Me.Timer3.Interval = 350
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(1156, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 85)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(1156, 845)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(255, 85)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 25.0!)
        Me.Label5.Location = New System.Drawing.Point(734, 875)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 55)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "学号"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 25.0!)
        Me.Label6.Location = New System.Drawing.Point(535, 875)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 55)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "班级"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 35.0!)
        Me.Label7.Location = New System.Drawing.Point(833, 855)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 76)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "01"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 35.0!)
        Me.Label8.Location = New System.Drawing.Point(636, 855)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 76)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "01"
        '
        'Timer4
        '
        Me.Timer4.Interval = 200
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 24.80672!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(55, 378)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(474, 55)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Who is the lucky dog?"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 24.80672!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Crimson
        Me.Label10.Location = New System.Drawing.Point(55, 871)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(474, 55)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Who is the lucky dog?"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label10.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1509, 964)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
