Public Class SDNF_to_table
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        ' objScript.Language = "VBScript"
        ' engine = Microsoft.JScript.Vsa.VsaEngine.CreateEngine


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
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 32)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1216, 48)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(16, 128)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(976, 400)
        Me.RichTextBox2.TabIndex = 1
        Me.RichTextBox2.Text = ""
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1216, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Логічний вираз"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(976, 40)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Таблиця істинності"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(1008, 480)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 56)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Вихід"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1000, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 96)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Таблиця істинності:"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(8, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(192, 40)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Вивести рядки, в яких F()=1"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(8, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(200, 24)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Вивести всі рядки"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1000, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 216)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Побудувати"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 56)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Таблицю істинності"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Ivory
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(8, 88)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 56)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Функціональну схему"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Ivory
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(8, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 56)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Схему перемикачів"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(1008, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 40)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Кількість змінних повинна бути <=5"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SDNF_to_table
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1232, 542)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "SDNF_to_table"
        Me.Text = "Побудова таблиці істинності за логічним виразом"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public gl As Global = Global.getGlobal

    Dim table(,) As Integer
    Dim var() As String '
    Dim s As String
    'Dim objScript As New MSScriptControl.ScriptControl
    'Dim engine As Microsoft.JScript.Vsa.VsaEngine
    Dim r As Integer
    Dim i As Integer
    Dim l As Integer
    Dim b() As String
    Dim nv As Integer

    Sub sBin(ByVal nt As Integer)
        Dim j As Integer
        Dim StrBin As String
        Dim source As Integer
        source = nt - 1 ' перший рядок вже зайнятий
        j = nv
        Do While source > 0
            table(nt, j) = source Mod 2 ' 1 mod 2=1
            j = j - 1
            source = source \ 2
        Loop
        Do While j > 0
            table(nt, j) = 0
            j = j - 1
        Loop
    End Sub
    Function findC(ByVal s As String) As Integer
        Dim c As Integer
        c = 0
        l = Len(s)
        For i = 1 To l
            If Mid(s, i, 1) = " " Then
                c = c + 1
            End If
        Next i
        c = c + 1
        findC = c
    End Function

    Public Function testArray(ByVal ch As String) As Integer
        Dim i As Integer
        testArray = 0
        For i = 1 To nv
            If ch = var(i) Then
                testArray = 1
                Exit For
            End If
        Next i
    End Function

    Function ansver(ByVal nt As Integer) As Integer
        Dim j As Integer
        For j = 1 To nv
            gl.objByName(var(j)).value = table(nt, j)          ' задається властивість value
        Next j
        ansver = gl.place()
    End Function
    Sub first()
        Dim c, i, j, k, k1 As Integer
        Dim ch$ = ""
        nv = 0
        s = RichTextBox1.Text
        ReDim var(s.Length)
        c = findC(s)
        k = 1
        For i = 1 To c
            Do While Mid(s, k, 1) <> " " And k <= s.Length
                ch += Mid(s, k, 1)
                k = k + 1
                If k > 100000 Then
                    End
                End If
            Loop
            k = k + 1
            If (ch <> "" AndAlso ch <> "and" AndAlso ch <> "or" AndAlso ch <> "not" AndAlso ch <> "(" AndAlso ch <> ")") Then
                If testArray(ch) = 0 Then
                    nv = nv + 1
                    'Print(nv, ch)
                    var(nv) = ch
                End If
            End If
            ch = ""
        Next i

    End Sub

    Public Function CheckSpace(ByVal s As String) As String
        s = s.Replace("(", " ( ")
        s = s.Replace("  ", " ")
        s = s.Replace(")", " ) ")
        s = s.Replace("  ", " ")
        s = s.Replace("  ", " ")
        s = s.Replace("  ", " ")
        s = s.Trim
        Return s
    End Function
    Sub MakeTable(ByRef Bar As ProgressBar)
        RichTextBox2.Clear()
        Dim i, j As Integer
        Try
            RichTextBox1.Text = LCase(CheckSpace(RichTextBox1.Text))
            gl.readStr(RichTextBox1.Text)

            first() '                           визначає змінні
            var(nv + 1) = "F("
            For i = 1 To nv '                    заповнює вираз F( )
                If i < nv Then
                    var(nv + 1) += var(i) & ", "
                Else
                    var(nv + 1) += var(i) & ")"
                End If

            Next
            For i = 1 To nv + 1
                RichTextBox2.Text &= var(i) & Chr(9) ' вивододить перший рядок на екран
            Next i
            RichTextBox2.Text &= Chr(10)
            table = Nothing
            ReDim table(2 ^ nv, nv + 1) ' масив з таблицею (значеннями)
            If Not (Bar Is Nothing) Then
                Bar.Maximum = (2 ^ nv) * nv
                Bar.Value = 0
            End If
            For i = 1 To 2 ^ nv
                sBin(i)
                table(i, nv + 1) = ansver(i)
                For j = 1 To nv + 1
                    If Not (Bar Is Nothing) Then
                        Bar.Value += 1
                    End If
                    If RadioButton2.Checked = True Then
                        If table(i, nv + 1) = 1 Then
                            RichTextBox2.Text = RichTextBox2.Text & Str(table(i, j)) & Chr(9)
                        End If
                    Else
                        RichTextBox2.Text = RichTextBox2.Text & Str(table(i, j)) & Chr(9)
                    End If
                Next j
                If RadioButton2.Checked = True Then
                    If table(i, nv + 1) = 1 Then
                        RichTextBox2.Text = RichTextBox2.Text & Chr(13)
                    End If
                Else
                    RichTextBox2.Text = RichTextBox2.Text & Chr(13)
                End If
            Next i
        Catch
            Return
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gl.f3.Hide()
        ' gl.f0.show()
    End Sub


   

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        gl.f1.Show()
        gl.f1.TextBox1.Text = RichTextBox1.Text
        gl.f1.Button1.PerformClick()
        gl.f1.Button2.PerformClick()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MakeTable(Nothing)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        gl.f11.Show()
        gl.f11.TextBox1.Text = RichTextBox1.Text
        gl.f11.Button1.PerformClick()
        gl.f1.Button2.PerformClick()


    End Sub
End Class
