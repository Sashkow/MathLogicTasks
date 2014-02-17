Public Class study_logic
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(24, 640)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Розв'язати задачу"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(688, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Умова задачі "
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(696, 144)
        Me.Label2.TabIndex = 4
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(800, 520)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(400, 88)
        Me.RichTextBox2.TabIndex = 5
        Me.RichTextBox2.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(800, 488)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Відповідь"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, -41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(400, 37)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Таблиця істинності"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(800, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(400, 32)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Таблиця істинності"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(800, 56)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(400, 424)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(1032, 640)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 48)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Вихід"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(696, 112)
        Me.Label5.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(696, 32)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Умовні позначення"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(696, 32)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Формалізована умова"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 200.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(472, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(216, 440)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "?"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.AntiqueWhite
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(8, 408)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox4.Size = New System.Drawing.Size(648, 80)
        Me.RichTextBox4.TabIndex = 47
        Me.RichTextBox4.Text = "a = (Not s1 Or s3) And Not (Not s2 Or s3)"
        '
        'study_logic
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1224, 718)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "study_logic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Хто вивчає логіку?"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private gl As Global = Global.getGlobal
    Public s1, s2, s3, s4, s5, a, i As Integer

       


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = ""
        RichTextBox1.Text += "I" & Chr(9) & "II" & Chr(9) & "III" & Chr(9) & "F()" & Chr(10)
        For s1 = 0 To 1
            For s2 = 0 To 1
                For s3 = 0 To 1
                    a = ((1 - s1) Or s3) And (1 - ((1 - s2) Or s3))
                    RichTextBox1.Text += s1 & Chr(9) & s2 & Chr(9) & s3 & Chr(9) & a & Chr(10)
                    If a = 1 Then

                        If s1 Then
                            RichTextBox2.Text += "Перший вивчав математичну логіку. "
                        ElseIf s2 Then
                            RichTextBox2.Text += "Другий вивчав математичну логіку. "
                        ElseIf s3 Then
                            RichTextBox2.Text += "Третій вивчав математичну логіку. "
                        End If
                    End If
                Next
            Next
        Next
        Dim myword As String
        Dim myfont As New Font("Times new roman", 14, FontStyle.Bold)
        Dim findtext As Integer
        myword = "1" & Chr(10)
        findtext = InStr(RichTextBox1.Text, myword) - 1
        If findtext <> 0 Then
            RichTextBox1.SelectionStart = findtext - 6
            RichTextBox1.SelectionLength = 6 + Len(myword)
            RichTextBox1.SelectionFont = myfont
        End If
    End Sub

    Private Sub study_logic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "Хто вивчає логіку?" & Chr(10) & "На питання:" & Chr(34) & "Хто з трьох що вчаться вивчав математичну логіку?" & Chr(34) & " отримана вірна відповідь - " & Chr(34) & "Якщо вивчав перший, то вивчав і третій, але невірно, що якщо вивчав другий, то вивчав і третій. " & Chr(34) _
               & "Хто вивчав математичну логіку?"
        Label5.Text = " I - перший учень вивчає логіку" & Chr(10) & " ІІ - другий учень вивчає логіку" & Chr(10) & " ІІІ - третій учень вивчає логіку "
        Me.BackColor = gl.f0.BackColor
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gl.f7.Hide()
        gl.f0.Show()
    End Sub


   
End Class
