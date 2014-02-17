Public Class four
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(1032, 632)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 48)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Вихід"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 336)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(912, 264)
        Me.RichTextBox1.TabIndex = 18
        Me.RichTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(488, 32)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Відповідь"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1024, 248)
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
        Me.Button1.Location = New System.Drawing.Point(24, 632)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 48)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Розв'язати задачу"
        '
        'four
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1224, 710)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "four"
        Me.Text = "Чотири дівчини"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private gl As Global = Global.getGlobal
    Public s1, s2, s3, s4, s5, a, i As Integer
    Public L, M, G, K, p, gi, v, s, en, ge, fr, sp As Integer
    Public sMusic(3) As String
    Public sLang(3) As String
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
    Private Sub fLang(ByVal i As Integer)
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

    Private Sub four_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = gl.f0.BackColor
        Label2.Text = "Марина, Лариса, Жанна і Катя вміють грати на різних інструментах (піаніно, віолончелі, гітарі, скрипці), але кожна тільки на одному. Вони ж знають іноземні мови (англійський, французький, німецький, іспанський), але кожна тільки одну. Відомо:" _
        & Chr(10) & "1. Дівчина, яка грає на гітарі, говорить по-іспанськи. " _
        & Chr(10) & "2. Лариса не грає ні на скрипці, ні на віолончелі і не знає англійської мови." _
        & Chr(10) & "3.	Марина не грає ні на скрипці, ні на віолончелі і не знає ні німецької, ні англійської мови. " _
        & Chr(10) & "4.	Дівчина, яка говорить по-німецьки, не грає на віолончелі." _
        & Chr(10) & "5.	Жанна знає французьку мову, але не грає на скрипці." _
& Chr(10) & "  Хто на якому інструменті грає? Хто яку знає мову? "
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, imL, imM, imJ, imK, ilL, ilM, ilJ, ilK As Integer
        Dim musicL As New ArrayList
        Dim musicM As New ArrayList
        Dim musicJ As New ArrayList
        Dim musicK As New ArrayList
        Dim LangL As New ArrayList
        Dim LangM As New ArrayList
        Dim LangJ As New ArrayList
        Dim LangK As New ArrayList
        Dim Lora(2) As Integer
        Dim Mary(2) As Integer
        Dim Jan(2) As Integer
        Dim Kate(2) As Integer
        sMusic(0) = "пианіно"
        sMusic(1) = "гитара"
        sMusic(2) = "віолончель"
        sMusic(3) = "скрипка"
        sLang(0) = "англійська"
        sLang(1) = "німецька"
        sLang(2) = "французьска"
        sLang(3) = "іспанська"

        RichTextBox1.Text = "Лариса" & Chr(9) & Chr(9) & "Марина" & Chr(9) & Chr(9) & "Жанна" & Chr(9) & Chr(9) & "Катя" & Chr(9) & Chr(9) & Chr(10)

        For i = 0 To 3
            musicL.Add(i)
            LangL.Add(i)
        Next
        For imL = 0 To musicL.Count - 1
            Lora(0) = musicL(imL)
            musicM.Clear()
            musicM.AddRange(musicL)
            musicM.RemoveAt(imL)
            For ilL = 0 To LangL.Count - 1
                Lora(1) = LangL(ilL)
                LangM.Clear()
                LangM.AddRange(LangL)
                LangM.RemoveAt(ilL)
                For imM = 0 To musicM.Count - 1
                    Mary(0) = musicM(imM)
                    musicJ.Clear()
                    musicJ.AddRange(musicM)
                    musicJ.RemoveAt(imM)
                    For ilM = 0 To LangM.Count - 1
                        Mary(1) = LangM(ilM)
                        LangJ.Clear()
                        LangJ.AddRange(LangM)
                        LangJ.RemoveAt(ilM)
                        For imJ = 0 To musicJ.Count - 1
                            Jan(0) = musicJ(imJ)
                            musicK.Clear()
                            musicK.AddRange(musicJ)
                            musicK.RemoveAt(imJ)
                            For ilJ = 0 To LangJ.Count - 1
                                Jan(1) = LangJ(ilJ)
                                LangK.Clear()
                                LangK.AddRange(LangJ)
                                LangK.RemoveAt(ilJ)
                                For imK = 0 To musicK.Count - 1
                                    Kate(0) = musicK(imK)
                                    For ilK = 0 To LangK.Count - 1
                                        Kate(1) = LangK(ilK)

                                        fName(0)
                                        fMusic(Lora(0))
                                        fLang(Lora(1))
                                        fLogic()
                                        Lora(2) = s1 And s2 And s3 And s4 And s5

                                        fName(1)
                                        fMusic(Mary(0))
                                        fLang(Mary(1))
                                        fLogic()
                                        Mary(2) = s1 And s2 And s3 And s4 And s5

                                        fName(2)
                                        fMusic(Jan(0))
                                        fLang(Jan(1))
                                        fLogic()
                                        Jan(2) = s1 And s2 And s3 And s4 And s5

                                        fName(3)
                                        fMusic(Kate(0))
                                        fLang(Kate(1))
                                        fLogic()
                                        Kate(2) = s1 And s2 And s3 And s4 And s5

                                        a = Lora(2) And Mary(2) And Jan(2) And Kate(2)
                                        If a = 1 Then
                                            RichTextBox1.Text += sMusic(Lora(0)) & Chr(9) & Chr(9) & sMusic(Mary(0)) & Chr(9) & Chr(9) & sMusic(Jan(0)) & Chr(9) & Chr(9) & sMusic(Kate(0)) & Chr(9) & Chr(10)
                                            RichTextBox1.Text += sLang(Lora(1)) & Chr(9) & Chr(9) & sLang(Mary(1)) & Chr(9) & Chr(9) & sLang(Jan(1)) & Chr(9) & sLang(Kate(1)) & Chr(9) & Chr(10)
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gl.f9.Hide()
        gl.f0.Show()
    End Sub
End Class
