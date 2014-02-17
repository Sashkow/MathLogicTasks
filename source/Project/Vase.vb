Public Class Vase
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
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Vase))
        Me.Button1 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 680)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Розв'язати задачу"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(704, 56)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(400, 448)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(704, 544)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(400, 88)
        Me.RichTextBox2.TabIndex = 2
        Me.RichTextBox2.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(656, 184)
        Me.Label1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(1128, 680)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 48)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Вихід"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(704, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Таблиця істинності"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(704, 512)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Відповідь"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(392, 176)
        Me.Label4.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(656, 32)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "        Умова задачі"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(392, 32)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "        Умовні позначення в таблиці"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 480)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(384, 32)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Формалізована умова  задачі"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(0, 512)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.Size = New System.Drawing.Size(656, 88)
        Me.RichTextBox3.TabIndex = 31
        Me.RichTextBox3.Text = " a = ((g And w5 Or g1 And v5) And (f And w3 Or f1 And v3)  And (g1 And w4  Or g A" & _
        "nd v4) And (f And g1 Or f1 And g) And (v3 And w4 And w5 Or w3 And v4 And w5 Or w" & _
        "3 And w4 And v5))"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(392, 240)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(288, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Vase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1284, 778)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Vase"
        Me.Text = "Антикварна ваза"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public gl As Global = Global.getGlobal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Dim g, f, v3, v4, v5, f1, g1, w3, w4, w5, a As Byte
        RichTextBox1.Text = "G " & Chr(9) & "F " & Chr(9) & "V3 " & Chr(9) & "V4 " & Chr(9) & "V5 " & Chr(9) & "A " & Chr(10)
        For g = 0 To 1 Step 1
            For f = 0 To 1 Step 1
                For v3 = 0 To 1 Step 1
                    For v4 = 0 To 1 Step 1
                        For v5 = 0 To 1 Step 1
                            f1 = Not f
                            g1 = Not g
                            w3 = Not v3
                            w4 = Not v4
                            w5 = Not v5
                            a = ((g And w5 Or g1 And v5) And (f And w3 Or f1 And v3) _
                            And (g1 And w4 Or g And v4) And (f And g1 Or f1 And g) _
                            And (v3 And w4 And w5 Or w3 And v4 And w5 Or w3 And w4 And v5))
                            RichTextBox1.Text += g & Chr(9) & f & Chr(9) & v3 & Chr(9) & v4 & Chr(9) & v5 & Chr(9) & a & Chr(10)
                            If a = 1 Then
                                If g = 1 Then
                                    RichTextBox2.Text += "Вазу зроблено в Греції. "
                                ElseIf f = 1 Then
                                    RichTextBox2.Text += "Вазу зроблено у Финикії. "
                                ElseIf v3 = 1 Then
                                    RichTextBox2.Text += "Вазу зроблено у третьому сторіччі. "
                                ElseIf v4 = 1 Then
                                    RichTextBox2.Text += "Вазу зроблено в четвертому сторіччі. "
                                End If
                                If v5 = 1 Then
                                    RichTextBox2.Text += "Вазу зроблено в п'ятому сторіччі. "
                                End If
                            End If
                        Next v5
                    Next v4
                Next v3
            Next f
        Next g
        Dim myword As String
        Dim myfont As New Font("Times new roman", 14, FontStyle.Bold)
        Dim findtext As Integer
        myword = "1" & Chr(10)
        findtext = InStr(RichTextBox1.Text, myword) - 1
        If findtext <> 0 Then
            RichTextBox1.SelectionStart = findtext - 10
            RichTextBox1.SelectionLength = 10 + Len(myword)
            RichTextBox1.SelectionFont = myfont

            'RichTextBox1.SelectionLength = 0 
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gl.f4.Hide()
    End Sub

    Private Sub Vase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Олексій, Боря і Гриша знайшли посудину. Подивившись дивовижну знахідку, кожний висунув по два припущення:" & Chr(10) & _
"  Олексій. Ця посудина грецька і виготовлена у V сторіччі." & Chr(10) & _
"  Боря. Ця посудина фінікійська і виготовлена у III сторіччі." & Chr(10) & _
"  Гриша. Ця посудина не грецька і виготовлена у IV сторіччі." & Chr(10) & _
"Вчитель  історії сказав хлопцям, що кожен правий лише в одному з його припущень." & Chr(10) & _
"   Де і в якому сторіччі виготовлено посудину?" & Chr(10)
        Label4.Text = "G - Ця посудина грецька" & Chr(10) & _
        "F - Ця посудина фінікійська " & Chr(10) & _
        "V3 - Ця посудина виготовлена у III сторіччі " & Chr(10) & _
"V4 - Ця посудина виготовлена у IV сторіччі " & Chr(10) & _
"V5 - Ця посудина виготовлена у V сторіччі " & Chr(10) & _
"A - Відповідь"

    End Sub

    
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

End Class
