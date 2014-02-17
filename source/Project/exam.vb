Public Class exam
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(exam))
        Me.Button2 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(1016, 632)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 48)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Вихід"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(800, 48)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(400, 424)
        Me.RichTextBox1.TabIndex = 18
        Me.RichTextBox1.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(800, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(400, 32)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Таблиця істинності"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(800, 480)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 32)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Відповідь"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(704, 272)
        Me.Label2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 32)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Умова задачі "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 648)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 48)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Розв'язати задачу"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(800, 520)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(400, 88)
        Me.Label4.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 488)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(696, 32)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Формалізована умова"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(696, 32)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Умовні позначення"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(696, 112)
        Me.Label5.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(800, 568)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 104)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.AntiqueWhite
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(0, 528)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox4.Size = New System.Drawing.Size(768, 80)
        Me.RichTextBox4.TabIndex = 47
        Me.RichTextBox4.Text = "a = (Not s1 Or s2) And (Not s2 Or (s3 Or Not s1)) And (s4 Or (s1 And Not s3)) And" & _
        " (Not s4 Or s1)"
        '
        'exam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1224, 718)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "exam"
        Me.Text = "Екзамен"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private gl As Global = Global.getGlobal
    Public s1, s2, s3, s4, s5, a, i As Integer
    
    Private Sub exam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = gl.f0.BackColor
        Label2.Text = "Екзамен" & Chr(10) & "Визначите, хто з чотирьох учнів склав іспит, якщо відомо:" & Chr(10) _
& Chr(9) & "1. Якщо перший склав, то і другий склав." & Chr(10) _
& Chr(9) & "2. Якщо другий склав, то третій склав або перший не склав." & Chr(10) _
& Chr(9) & "3. Якщо четвертий не склав, то перший склав, а третій не склав." & Chr(10) _
& Chr(9) & "4. Якщо четвертий склав, то і перший склав."
        Label5.Text = " І - перший склав іспит" & Chr(10) & " ІІ - другий склав іспит" & Chr(10) & " ІІІ - третій склав іспит" & Chr(10) & " ІV - четвертий склав іспит"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = ""
        Label4.Text = ""
        RichTextBox1.Text += "I" & Chr(9) & "II" & Chr(9) & "III" & Chr(9) & "IV" & Chr(9) & "F()" & Chr(10)
        Dim a1, a2, a3, a4, a5 As Integer

        For s1 = 0 To 1
            For s2 = 0 To 1
                For s3 = 0 To 1
                    For s4 = 0 To 1
                        a1 = (1 - s1) Or s2

                        a = ((1 - s1) Or s2) And ((1 - s2) Or (s3 Or (1 - s1))) And (s4 Or (s1 And (1 - s3))) And ((1 - s4) Or s1)
                        a = (Not s1 Or s2) And (Not s2 Or (s3 Or Not s1)) And (s4 Or (s1 And Not s3)) And (Not s4 Or s1)
                        RichTextBox1.Text += s1 & Chr(9) & s2 & Chr(9) & s3 & Chr(9) & s4 & Chr(9) & a & Chr(10)
                        If a = 1 Then
                        End If
                    Next
                Next
            Next
        Next
        Label4.Text += "Всі склали екзамен"
        Dim myword As String
        Dim myfont As New Font("Times new roman", 14, FontStyle.Bold)
        Dim findtext As Integer
        myword = "1" & Chr(10)
        findtext = InStr(RichTextBox1.Text, myword) - 1
        If findtext <> 0 Then
            RichTextBox1.SelectionStart = findtext - 8
            RichTextBox1.SelectionLength = 8 + Len(myword)
            RichTextBox1.SelectionFont = myfont
        End If
        PictureBox1.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gl.f8.Hide()
        gl.f0.Show()
    End Sub

    
End Class
