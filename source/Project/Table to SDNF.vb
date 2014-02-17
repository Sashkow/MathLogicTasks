Public Class Table_to_SDNF
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
        Me.Hide()
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(16, 32)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(640, 392)
        Me.RichTextBox2.TabIndex = 18
        Me.RichTextBox2.Text = ""
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 464)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(912, 72)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.Text = ""
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Ivory
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(136, 24)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 56)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = " ДКНФ"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Ivory
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(8, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 56)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "ДДНФ"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 40)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Створити "
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(648, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Таблиця істинності"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Ivory
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.Location = New System.Drawing.Point(672, 400)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(256, 40)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Вихід"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(8, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(256, 40)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Ввести"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(912, 23)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "ДДНФ або ДКНФ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Ivory
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.Location = New System.Drawing.Point(8, 80)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(256, 48)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Функціональну схему"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Ivory
        Me.Button7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.Location = New System.Drawing.Point(8, 128)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(256, 48)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "Схему перемикачів"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(664, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 184)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Побудувати"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(664, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 200)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Таблиця істинності"
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(8, 72)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(200, 24)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "Правильна таблиця"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Wheat
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Кількість рядків ( від 2 до 2^n)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Wheat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Кількість змінних n ( від 1 до 8 ) "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(232, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(32, 29)
        Me.TextBox2.TabIndex = 23
        Me.TextBox2.Text = "8"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(240, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(16, 29)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "3"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Table_to_SDNF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(936, 542)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Table_to_SDNF"
        Me.Text = "Побудова ДДНФ, ДКНФ за таблицею істнності"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '  Public gl As New Global ' why not?
    Public gl As Global = Global.getGlobal
    Dim s As String
    Dim n As Integer
    Dim m As Integer
    Dim t As Integer
    Dim a(,) As Long
    Dim b() As String
    Dim r(27) As String

    Private Sub initdim() ' анализирует условие и заполняет массивы
        Dim i As Integer
        m = Val(TextBox1.Text) + 1
        n = Val(TextBox2.Text)

        If n > 2 ^ (m - 1) Then
            MsgBox("Не можливо побудувати таблицю. Кількість комбінацій обмежена кількістю змінних. Значення буде змінено")
            n = 2 ^ (m - 1)
            TextBox2.Text = n
        End If
        t = m * n
        ReDim a(n, m)
        ReDim b(t)
        r(1) = "X"
        r(2) = "Y"
        r(3) = "Z"
        For i = 65 To 87
            r(i - 61) = Chr(i)
        Next i
    End Sub
    Sub sBin(ByVal nt As Integer)
        Dim j As Integer
        Dim StrBin As String
        Dim source As Integer
        source = nt - 1 ' перший рядок вже зайнятий
        j = m - 1
        Do While source > 0
            a(nt, j) = source Mod 2 ' 1 mod 2=1
            j = j - 1
            source = source \ 2
        Loop
        Do While j > 0
            a(nt, j) = 0
            j = j - 1
        Loop
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        initdim()
        Dim i, j, k As Integer
        Dim s1 As String
        Dim strA As New ArrayList
        'первая строка
        RichTextBox2.Text = ""
        For i = 1 To m - 1
            RichTextBox2.Text += r(i) & Chr(9)
        Next i

        RichTextBox2.Text += "F("
        For i = 1 To m - 1 '                    заповнює вираз F( )
            If i < m - 1 Then
                RichTextBox2.Text += r(i) & ", "
            Else
                RichTextBox2.Text += r(i) & ")" & Chr(10)
            End If

        Next
        If CheckBox1.Checked = False Then


            For i = 1 To n
already:
                'остальные строки
                s1 = ""
                For j = 1 To m
                    a(i, j) = Math.Round(Rnd())
                    If j <> m Then
                        s1 += Str(a(i, j))
                    End If
                Next
                'если уже существует -  переделать
                For j = 0 To strA.Count - 1
                    If strA(j) = s1 Then
                        GoTo already
                    End If
                Next
                strA.Add(s1)
                For j = 1 To m
                    RichTextBox2.Text = RichTextBox2.Text & a(i, j) & Chr(9)
                Next
                RichTextBox2.Text = RichTextBox2.Text & Chr(10)
            Next
        Else
            For i = 1 To n
                sBin(i)
            Next
            Dim x As Integer

           
            x = 0 ' текущее число
            For i = 1 To n
                Randomize()
                x = Rnd()
                If x > 0.5 Then
                    a(i, m) = 1
                Else
                    a(i, m) = 0
                End If
            Next
            For i = 1 To n
                For j = 1 To m
                    RichTextBox2.Text = RichTextBox2.Text & a(i, j) & Chr(9)
                Next
                RichTextBox2.Text = RichTextBox2.Text & Chr(10)
            Next
        End If

    End Sub
    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox2.Text = ""
        initdim()
        Dim i, j As Integer
        For i = 1 To m - 1
            RichTextBox2.Text += r(i) & Chr(9)
        Next i
        RichTextBox2.Text += "F()" & Chr(10)
        Dim stroka As String
        For i = 1 To n
            For j = 1 To m
                stroka = InputBox("Введіть символ " & Str(i) & "," & Str(j) & ")", "Введіть таблицю істинності", "0")
                If stroka = "" Then
                    Exit Sub
                ElseIf stroka <> "1" And stroka <> "0" Then
                    MsgBox("Введені некоректні данні", , "Таблиця")
                    RichTextBox2.Text = ""
                    Exit Sub
                End If

                a(i, j) = stroka


                RichTextBox2.Text += a(i, j) & Chr(9)
            Next
            RichTextBox2.Text += Chr(10)
        Next
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'СДНФ
        Dim i, j, c, p, z, l As Integer
        RichTextBox1.Text = ""
        s = ""
        j = 1
        s = s & " ( "
        For i = 1 To n
            If a(i, m) = 1 Then 'выбираем строки последний символ которых равен единице
                If s <> " ( " Then
                    s = s & " or ( " 'полученные выражения связываем дизъюнкцией (or)
                End If
                For j = 1 To m - 1
                    c += 1
                    p += 1

                    If a(i, j) = 1 Then
                        b(c) = r(p)
                    Else                       'для каждой выбраной строки записываем комбинацию переменных
                        b(c) = " not " & r(p)
                    End If
                    If j < m - 1 Then
                        s = s & b(c) & " and "  'через знаки and
                    Else
                        s = s & b(c)
                    End If
                Next j
                p = 0
                s = s & " ) "
            End If
        Next i
        RichTextBox1.Text = RichTextBox1.Text & s & Chr(13)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'СКНФ
        Dim i, j, c, p, z, l As Integer
        RichTextBox1.Text = ""
        s = ""
        j = 1
        s = s & " ( "
        For i = 1 To n
            If a(i, m) = 0 Then 'выбираем строки последний символ которых равен нулю
                If s <> " ( " Then
                    s = s & " and ( " 'полученные выражения связываем дизъюнкцией (and)
                End If
                For j = 1 To m - 1
                    c += 1
                    p += 1

                    If a(i, j) = 0 Then
                        b(c) = r(p)
                    Else                       'для каждой выбраной строки записываем комбинацию переменных
                        b(c) = " not " & r(p)
                    End If
                    If j < m - 1 Then
                        s = s & b(c) & " or "  'через знаки or
                    Else
                        s = s & b(c)
                    End If
                Next j
                p = 0
                s = s & " ) "
            End If
        Next i
        RichTextBox1.Text = RichTextBox1.Text & s & Chr(13)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        gl.f2.Hide()
        gl.f0.Show()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        gl.f1.Show()
        gl.f1.TextBox1.Text = RichTextBox1.Text
        gl.f1.Button1.PerformClick()
        gl.f1.Button2.PerformClick()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        gl.f11.Show()
        gl.f11.TextBox1.Text = RichTextBox1.Text
        gl.f11.Button1.PerformClick()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
