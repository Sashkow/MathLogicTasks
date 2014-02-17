Public Class Others
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(808, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Хто вивчає логіку?"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 328)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(768, 400)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(808, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Екзамен"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Ivory
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(808, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(184, 32)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Чотири дівчини"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Ivory
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(808, 192)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 32)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Вихід"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(760, 280)
        Me.Label1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(768, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Таблиця істинності"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Others
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1028, 734)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Others"
        Me.Text = "Study_logic"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private gl As Global = Global.getGlobal


    Public s1, s2, s3, s4, s5, a, i As Integer
    Public L, M, G, K, p, gi, v, s, en, ge, fr, sp As Integer
    Public sMusic(3) As String
    Public sLeng(3) As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = ""
        RichTextBox1.Text += "I" & Chr(9) & "II" & Chr(9) & "III" & Chr(10)
        For s1 = 0 To 1
            For s2 = 0 To 1
                For s3 = 0 To 1
                    a = ((1 - s1) Or s3) And (1 - ((1 - s2) Or s3))
                    If a = 1 Then
                        RichTextBox1.Text += s1 & Chr(9) & s2 & Chr(9) & s3 & Chr(10)
                        If s1 Then
                            RichTextBox1.Text += "Перший вивчав математичну логіку. "
                        ElseIf s2 Then
                            RichTextBox1.Text += "Другий вивчав математичну логіку. "
                        ElseIf s3 Then
                            RichTextBox1.Text += "Третій вивчав математичну логіку. "
                        End If
                    End If
                Next
            Next
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox1.Text = ""
        RichTextBox1.Text += "I" & Chr(9) & "II" & Chr(9) & "III" & Chr(9) & "IV" & Chr(10)
        Dim a1, a2, a3, a4, a5 As Integer

        For s1 = 0 To 1
            For s2 = 0 To 1
                For s3 = 0 To 1
                    For s4 = 0 To 1
                        a1 = (1 - s1) Or s2

                        a = ((1 - s1) Or s2) And ((1 - s2) Or (s3 Or (1 - s1))) And (s4 Or (s1 And (1 - s3))) And ((1 - s4) Or s1)
                        If a = 1 Then
                            RichTextBox1.Text += s1 & Chr(9) & s2 & Chr(9) & s3 & Chr(9) & s4 & Chr(9) & a & Chr(10)
                        End If
                    Next
                Next
            Next
        Next

    End Sub
    Private Sub onlyOne(ByVal i As Integer, ByRef m As ArrayList)
        Dim j As Integer
        For j = 0 To m.Count - 1
            If i = j Then
                m(j) = 1
            Else
                m(j) = 0
            End If
        Next
    End Sub

    Private Sub fName(ByVal i As Integer)
        L = 0
        M = 0
        G = 0
        K = 0
        Select Case i
            Case 0
                L = 1
            Case 1
                M = 1
            Case 2
                G = 1
            Case 3
                K = 1
        End Select
    End Sub
    Private Sub fMusic(ByVal i As Integer)
        p = 0
        gi = 0
        v = 0
        s = 0
        Select Case i
            Case 0
                p = 1
            Case 1
                gi = 1
            Case 2
                v = 1
            Case 3
                s = 1
        End Select
    End Sub
    Private Sub fLeng(ByVal i As Integer)
        en = 0
        ge = 0
        fr = 0
        sp = 0
        Select Case i
            Case 0
                en = 1
            Case 1
                ge = 1
            Case 2
                fr = 1
            Case 3
                sp = 1
        End Select
    End Sub

    Private Sub fLogic()
        s1 = (1 - L) Or ((1 - s) And (1 - v) And (1 - en))
        s2 = (1 - M) Or ((1 - s) And (1 - v) And (1 - ge) And 1 - en)
        s3 = (1 - G) Or (fr And (1 - s))
        s4 = (1 - ge) Or (1 - v)
        's5 = (1 - gi) Or (sp)
        's4 = ((1 - v) And ge) Or (v And (1 - ge))
        s5 = (gi And sp) Or ((1 - gi) And (1 - sp))
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i, imL, imM, imJ, imK, ilL, ilM, ilJ, ilK As Integer
        Dim musicL As New ArrayList
        Dim musicM As New ArrayList
        Dim musicJ As New ArrayList
        Dim musicK As New ArrayList
        Dim lengL As New ArrayList
        Dim lengM As New ArrayList
        Dim lengJ As New ArrayList
        Dim lengK As New ArrayList
        Dim Lora(2) As Integer
        Dim Mary(2) As Integer
        Dim Jan(2) As Integer
        Dim Kate(2) As Integer
        sMusic(0) = "пианіно"
        sMusic(1) = "гитара"
        sMusic(2) = "віолончель"
        sMusic(3) = "скрипка"
        sLeng(0) = "англійська"
        sLeng(1) = "німецька"
        sLeng(2) = "французьска"
        sLeng(3) = "іспанська"

        RichTextBox1.Text = "Лариса" & Chr(9) & Chr(9) & "Марина" & Chr(9) & Chr(9) & "Жанна" & Chr(9) & Chr(9) & "Катя" & Chr(9) & Chr(9) & Chr(10)

        For i = 0 To 3
            musicL.Add(i)
            lengL.Add(i)
        Next
        For imL = 0 To musicL.Count - 1
            Lora(0) = musicL(imL)
            musicM.Clear()
            musicM.AddRange(musicL)
            musicM.RemoveAt(imL)
            For ilL = 0 To lengL.Count - 1
                Lora(1) = lengL(ilL)
                lengM.Clear()
                lengM.AddRange(lengL)
                lengM.RemoveAt(ilL)
                For imM = 0 To musicM.Count - 1
                    Mary(0) = musicM(imM)
                    musicJ.Clear()
                    musicJ.AddRange(musicM)
                    musicJ.RemoveAt(imM)
                    For ilM = 0 To lengM.Count - 1
                        Mary(1) = lengM(ilM)
                        lengJ.Clear()
                        lengJ.AddRange(lengM)
                        lengJ.RemoveAt(ilM)
                        For imJ = 0 To musicJ.Count - 1
                            Jan(0) = musicJ(imJ)
                            musicK.Clear()
                            musicK.AddRange(musicJ)
                            musicK.RemoveAt(imJ)
                            For ilJ = 0 To lengJ.Count - 1
                                Jan(1) = lengJ(ilJ)
                                lengK.Clear()
                                lengK.AddRange(lengJ)
                                lengK.RemoveAt(ilJ)
                                For imK = 0 To musicK.Count - 1
                                    Kate(0) = musicK(imK)
                                    For ilK = 0 To lengK.Count - 1
                                        Kate(1) = lengK(ilK)

                                        fName(0)
                                        fMusic(Lora(0))
                                        fLeng(Lora(1))
                                        fLogic()
                                        Lora(2) = s1 And s2 And s3 And s4 And s5

                                        fName(1)
                                        fMusic(Mary(0))
                                        fLeng(Mary(1))
                                        fLogic()
                                        Mary(2) = s1 And s2 And s3 And s4 And s5

                                        fName(2)
                                        fMusic(Jan(0))
                                        fLeng(Jan(1))
                                        fLogic()
                                        Jan(2) = s1 And s2 And s3 And s4 And s5

                                        fName(3)
                                        fMusic(Kate(0))
                                        fLeng(Kate(1))
                                        fLogic()
                                        Kate(2) = s1 And s2 And s3 And s4 And s5

                                        a = Lora(2) And Mary(2) And Jan(2) And Kate(2)
                                        If a = 1 Then
                                            RichTextBox1.Text += sMusic(Lora(0)) & Chr(9) & Chr(9) & sMusic(Mary(0)) & Chr(9) & Chr(9) & sMusic(Jan(0)) & Chr(9) & sMusic(Kate(0)) & Chr(9) & Chr(10)
                                            RichTextBox1.Text += sLeng(Lora(1)) & Chr(9) & sLeng(Mary(1)) & Chr(9) & sLeng(Jan(1)) & Chr(9) & sLeng(Kate(1)) & Chr(9) & Chr(10)
                                        End If
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next
            Next
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        gl.f7.Hide()
    End Sub

    Private Sub Others_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = gl.f0.BackColor
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Label1.Text = "Хто вивчає логіку?" & Chr(10) & "На питання:" & Chr(34) & "Хто з трьох що вчаться вивчав математичну логіку?" & Chr(34) & " отримана вірна відповідь - " & Chr(34) & "Якщо вивчав перший, то вивчав і третій, але невірно, що якщо вивчав другий, то вивчав і третій. " & Chr(34) _
        & "Хто вивчав математичну логіку?"

    End Sub


    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Label1.Text = "Екзамен" & Chr(10) & "Визначите, хто з чотирьох учнів склав іспит, якщо відомо:" & Chr(10) _
 & Chr(9) & "1. Якщо перший склав, то і другий склав." & Chr(10) _
 & Chr(9) & "2. Якщо другий склав, то третій склав або перший не склав." & Chr(10) _
 & Chr(9) & "3. Якщо четвертий не склав, то перший склав, а третій не склав." & Chr(10) _
 & Chr(9) & "4. Якщо четвертий склав, то і перший склав."
    End Sub

    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Label1.Text = "Чотири дівчини" & Chr(10) & Chr(10) & _
        "Марина, Лариса, Жанна і Катя вміють грати на різних інструментах (піаніно, віолончелі, гітарі, скрипці), але кожна тільки на одному. Вони ж знають іноземні мови (англійський, французький, німецький, іспанський), але кожна тільки одну. Відомо:" _
        & Chr(10) & "1. Дівчина, яка грає на гітарі, говорить по-іспанськи. " _
        & Chr(10) & "2. Лариса не грає ні на скрипці, ні на віолончелі і не знає англійської мови." _
        & Chr(10) & "3.	Марина не грає ні на скрипці, ні на віолончелі і не знає ні німецької, ні англійської мови. " _
        & Chr(10) & "4.	Дівчина, яка говорить по-німецьки, не грає на віолончелі." _
        & Chr(10) & "5.	Жанна знає французьку мову, але не грає на скрипці." _
& Chr(10) & "  Хто на якому інструменті грає? Хто яку знає мову? "
    End Sub
End Class
