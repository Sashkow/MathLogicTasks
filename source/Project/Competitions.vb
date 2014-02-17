Public Class Competitions
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
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 680)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Розв'язати задачу"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(736, 48)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(496, 480)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(704, 184)
        Me.Label1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(736, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(496, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Таблиця істинності"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(1112, 688)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 48)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Вихід"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(736, 584)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(504, 88)
        Me.RichTextBox2.TabIndex = 22
        Me.RichTextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(728, 536)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(528, 40)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Відповідь: рядок таблиці з істинними значеннями змінних"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(552, 352)
        Me.Label4.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(384, 32)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "        Умовні позначення в таблиці"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(384, 32)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "        Умова задачі"
        '
        'Competitions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1284, 746)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Competitions"
        Me.Text = "Competitions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public gl As Global = Global.getGlobal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = ""
 RichTextBox2.Text = ""
        Dim a1, b1, c1, v1, a2, b2, c2, v2, a3, b3, c3, v3, a4, b4, c4, v4 As Integer
        RichTextBox1.Text = "A1" & Chr(9) & "A2" & Chr(9) & "B3" & Chr(9) & "B4" & Chr(9) & "C2" & Chr(9) & "V2" & Chr(9) & "V4" & Chr(9) & "y" & Chr(10)
        RichTextBox2.Text = "A1" & Chr(9) & "A2" & Chr(9) & "B3" & Chr(9) & "B4" & Chr(9) & "C2" & Chr(9) & "V2" & Chr(9) & "V4" & Chr(10)
        Dim y
        For a1 = 0 To 1
            For a2 = 0 To 1
                For b3 = 0 To 1
                    For b4 = 0 To 1
                        For c2 = 0 To 1
                            For v2 = 0 To 1
                                For v4 = 0 To 1
                                    y = (Not a1 And v2 Or a1 And Not v2) And (Not a2 And b3 Or a2 And Not b3) And (Not b4 And c2 Or b4 And Not c2) And _
                                    (a1 And Not a2 And Not a3 And Not a4 Or Not a1 And a2 And Not a3 And Not a4 Or Not a1 And Not a2 And a3 And Not a4 Or Not a1 And Not a2 And Not a3 And a4) And _
                                    (b1 And Not b2 And Not b3 And Not b4 Or Not b1 And b2 And Not b3 And Not b4 Or Not b1 And Not b2 And b3 And Not b4 Or Not b1 And Not b2 And Not b3 And b4) And _
                                    (c1 And Not c2 And Not c3 And Not c4 Or Not c1 And c2 And Not c3 And Not c4 Or Not c1 And Not c2 And c3 And Not c4 Or Not c1 And Not c2 And Not c3 And c4) And _
                                    (v1 And Not v2 And Not v3 And Not v4 Or Not v1 And v2 And Not v3 And Not v4 Or Not v1 And Not v2 And v3 And Not v4 Or Not v1 And Not v2 And Not v3 And v4) And _
                                    (a1 And Not b1 And Not c1 And Not v1 Or Not a1 And b1 And Not c1 And Not v1 Or Not a1 And Not b1 And c1 And Not v1 Or Not a1 And Not b1 And Not c1 And v1) And _
                                    (a2 And Not b2 And Not c2 And Not v2 Or Not a2 And b2 And Not c2 And Not v2 Or Not a2 And Not b2 And c2 And Not v2 Or Not a2 And Not b2 And Not c2 And v2) And _
                                    (a3 And Not b3 And Not c3 And Not v3 Or Not a3 And b3 And Not c3 And Not v3 Or Not a3 And Not b3 And c3 And Not v3 Or Not a3 And Not b3 And Not c3 And v3) And _
                                    (a4 And Not b4 And Not c4 And Not v4 Or Not a4 And b4 And Not c4 And Not v4 Or Not a4 And Not b4 And c4 And Not v4 Or Not a4 And Not b4 And Not c4 And v4)
                                    'RichTextBox1.Text += a1 & Chr(9) & b1 & Chr(9) & c1 & Chr(9) & v1 & Chr(9) & a2 & Chr(9) & b2 & Chr(9) & c2 & Chr(9) & v2 & Chr(9) & a3 & Chr(9) & b3 & Chr(9) & c3 & Chr(9) & v3 & Chr(9) & a4 & Chr(9) & b4 & Chr(9) & c4 & Chr(9) & v4 & Chr(9) & y & Chr(10)
                                    RichTextBox1.Text += a1 & Chr(9) & a2 & Chr(9) & b3 & Chr(9) & b4 & Chr(9) & c2 & Chr(9) & v2 & Chr(9) & v4 & Chr(9) & y & Chr(10)
                                    If y = 1 Then
                                        RichTextBox2.Text += a1 & Chr(9) & a2 & Chr(9) & b3 & Chr(9) & b4 & Chr(9) & c2 & Chr(9) & v2 & Chr(9) & v4 & Chr(10)
                                    End If
                                Next v4
                            Next v2
                        Next c2
                    Next b4
                Next b3
            Next a2
        Next a1
        Dim myword As String
        Dim myfont As New Font("Times new roman", 14, FontStyle.Bold)
        Dim findtext As Integer
        myword = "1" & Chr(10)
        findtext = InStr(RichTextBox1.Text, myword) - 1
        If findtext <> 0 Then
            RichTextBox1.SelectionStart = findtext - 15
            RichTextBox1.SelectionLength = 15 + Len(myword)
            RichTextBox1.SelectionFont = myfont
        End If
    End Sub

    Private Sub Competitions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "На змаганнях з легкої атлетики Андрій, Боря, Сергій і Володя посіли перші чотири місця.Та коли дівчата почали пригадувати, хто яке місце посів, думки розішлися:" & Chr(10) & _
        "Даша: Андрій був першим, а Володя - другим." & Chr(10) & _
        "Галя: Андрій був другим, а Борис - третім." & Chr(10) & _
        "Лєна: Бора був четвертим, а Сергій - другим." & Chr(10) & _
        "Ася, яка була суддею на змаганнях і добре пам'ятала, як розподілилися місця, сказала одне правильне і одне неправильне твердження." & Chr(10) & _
        "Хто з хлопців яке місце зайняв?"
                Label4.Text = "Назви змінних складаються з першої літери імені хлопця та місця, яке він посів" & Chr(10) & _
                "Наприклад С4 означатиме, що Сергій зайняв четверте місце."
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gl.f5.Hide()
        gl.f0.Show()
    End Sub

   
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class
