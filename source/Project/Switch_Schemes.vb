
Public Class Switch_Schemes
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(200, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(797, 29)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "s1 and (not(s2 or s) or s3)"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Логічний вираз"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 48)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Вхідні параметри"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(776, 464)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 48)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Вихід"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1000, 96)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 40)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Вираз після застосування формул де Моргана"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 40)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Вираз після групування однотипних операцій"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(232, 56)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(763, 29)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(232, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(763, 29)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(8, 248)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 272)
        Me.Panel1.TabIndex = 9
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Panel2)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 152)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(992, 88)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Значення суджень"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Location = New System.Drawing.Point(8, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(976, 64)
        Me.Panel2.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(768, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 216)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Побудувати"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 56)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Схему перемикачів"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Ivory
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(8, 88)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(216, 56)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Схему, враховуючи значення суджень"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Ivory
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(8, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(216, 56)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Таблицю істинності"
        '
        'Switch_Schemes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1000, 534)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Switch_Schemes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Схеми перемикачів"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public gl As Global = Global.getGlobal
    Const L = 120
    Const W = 60
    Dim var As New ArrayList
    Public mypanel As ValuesOfJujment
    Shared NameValue As New Hashtable

    Public Class SchemeExeption
        Inherits Exception
        Private m_massage As String

        Public Property massage() As String
            Get
                Return m_massage
            End Get
            Set(ByVal Value As String)
                m_massage = Value
            End Set
        End Property
        Public Sub New(ByVal massage As String)
            Me.massage = massage
        End Sub
    End Class

    Public Class ValuesOfJujment
        Inherits System.Windows.forms.Panel
        Dim v As ArrayList
        Public Sub New(ByVal VArray As ArrayList)

            Me.Name = "mypanel"
            Me.Location = New System.Drawing.Point(1, 1)
            Me.Size = New System.Drawing.Size(727, 60)
            Me.AutoScroll = True
            Me.Anchor = AnchorStyles.Right Or AnchorStyles.Left

            AddTextAndLabel(VArray)
        End Sub
        Sub AddTextAndLabel(ByVal Av As ArrayList)
            Dim t As New System.Windows.Forms.TextBox
            Dim l As System.Windows.Forms.Label
            Dim a As String
            Dim CLocation As Integer
            CLocation = 0
            For Each a In Av
                l = New System.Windows.Forms.Label
                l.Text = a
                l.Location = New System.Drawing.Point(8 + CLocation, 8)
                l.Size = New Size(56, 24)
                l.RightToLeft = RightToLeft.Yes
                Me.Controls.Add(l)
                t = New System.Windows.Forms.TextBox
                t.Text = "0"
                t.Location = New System.Drawing.Point(64 + CLocation, 8)
                t.Size = New Size(16, 26)
                Me.Controls.Add(t)
                CLocation += 72
            Next
        End Sub
    End Class


    Public Class draw_Panel

        Inherits System.Windows.forms.Panel
        ' private 
        Dim in1 As operand
        Dim li, wi As Integer

        Public Sub New(ByVal init As operand, ByVal x1 As Long, ByVal y1 As Long)
            in1 = init
            li = x1
            wi = y1
            Me.Location = New System.Drawing.Point(10, 10)
            Me.Size = New System.Drawing.Size(x1, y1)
            'Me.BackColor = Color.Wheat
        End Sub
        Sub DrawRectangle(ByVal DRArray As ArrayList)
            Dim a As operand
            Dim g As Graphics = CreateGraphics()
            For Each a In DRArray
                If a.brackets = True Then
                    DrawRectangle(a.ref)
                End If
                If a.brackets = False Then
                    g.DrawRectangle(New Pen(Color.Brown), a.X, a.Y, a.Length, a.Width)
                    g.DrawString(a.content, New Font("Tahoma", 8), New SolidBrush(Color.Black), a.X, a.Y)
                End If
            Next
        End Sub
        Sub DrawElement(ByVal DRArray As ArrayList)
            Dim a As operand
            Dim g As Graphics = CreateGraphics()
            Dim r As Integer = 25
            Dim BrownPen As New Pen(Color.Brown, 2)
            Dim BlackPen As New Pen(Color.Black, 2)
            Dim RedPen As New Pen(Color.Red, 2)

            For Each a In DRArray
                If a.brackets = True Then
                    DrawElement(a.ref)
                End If

                If a.brackets = False Then


                    If a.IntermediateValue = False Then
                        g.DrawLine(BrownPen, a.X, CType(Math.Round(a.Y + (a.Width / 2)), Single), a.X + a.Length, CType(Math.Round(a.Y + (a.Width / 2)), Single))
                        g.DrawLine(New Pen(Color.AntiqueWhite, 2), CType(Math.Round(a.X + (a.Length / 2) - r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single))
                        If a.denial = False Then
                            If a.Value = 0 Then
                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) - r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2) - r), Single)) '/
                            ElseIf a.Value = 1 Then
                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) - r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single)) '_
                            End If
                            'g.DrawLine(BrownPen, CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2) - (r / 2)), Single))
                        ElseIf a.denial = True Then
                            If a.Value = 0 Then
                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2) - (r / 2)), Single) - 3) ' |
                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) - r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single) + 5, CType(Math.Round(a.Y + (a.Width / 2) - (r / 2)), Single)) '/
                            ElseIf a.Value = 1 Then
                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2) - (r / 2)), Single) - 3) ' |
                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) - r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2) - r), Single)) '/
                            End If

                        End If
                    Else
                        ' the same but color
                        g.DrawLine(RedPen, a.X, CType(Math.Round(a.Y + (a.Width / 2)), Single), a.X + a.Length, CType(Math.Round(a.Y + (a.Width / 2)), Single))
                        g.DrawLine(New Pen(Color.AntiqueWhite, 2), CType(Math.Round(a.X + (a.Length / 2) - r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single))
                        If a.denial = False Then

                            If NameValue(a.content) = 0 Then
                                g.DrawLine(BrownPen, CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), a.X + a.Length, CType(Math.Round(a.Y + (a.Width / 2)), Single))
                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) - r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2) - r), Single)) '/
                            ElseIf NameValue(a.content) = 1 Then
                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) - r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single)) '_
                            End If
                            'g.DrawLine(redPen, CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2) - (r / 2)), Single))
                        ElseIf a.denial = True Then
                            If a.Value = 0 Then

                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2) - (r / 2)), Single) - 3) ' |
                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) - r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single) + 5, CType(Math.Round(a.Y + (a.Width / 2) - (r / 2)), Single)) '/
                            ElseIf a.Value = 1 Then
                                g.DrawLine(BrownPen, CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), a.X + a.Length, CType(Math.Round(a.Y + (a.Width / 2)), Single))
                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2) - (r / 2)), Single) - 3) ' |
                                'g.DrawLine(BrownPen, CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), a.X + a.Length, CType(Math.Round(a.Y + (a.Width / 2)), Single))
                                g.DrawLine(BlackPen, CType(Math.Round(a.X + (a.Length / 2) - r), Single), CType(Math.Round(a.Y + (a.Width / 2)), Single), CType(Math.Round(a.X + (a.Length / 2) + r), Single), CType(Math.Round(a.Y + (a.Width / 2) - r), Single)) '/
                            End If

                        End If
                    End If
                    'g.DrawEllipse(New Pen(Color.Brown, 2), CType(Math.Round(a.X + (a.Length / 2) - r), Single), CType(Math.Round(a.Y + (a.Width / 2) - r), Single), 2 * r, 2 * r)
                    g.DrawString(a.content, New Font("Tahoma", Math.Round(r * 3 / 5)), New SolidBrush(Color.Black), CType(Math.Round(a.X + (a.Length / 2) - 1.5 * r), Single), CType(Math.Round(a.Y + (a.Width / 2) - 1.5 * r), Single))
                End If
            Next
        End Sub
        Sub VerticalLines(ByVal DRArray As ArrayList)
            Dim i As Integer
            Dim g As Graphics = CreateGraphics()
            For i = 0 To DRArray.Count - 1

                If DRArray(i).operation = _operation.dis Then
                    If DRArray(i).intermediatevalue = False Then

                        g.DrawLine(New Pen(Color.Brown, 2), DRArray(i).x, CType(Math.Round(DRArray(i).y + (DRArray(i).width / 2)), Single), DRArray(i + 1).x, CType(Math.Round(DRArray(i + 1).y + (DRArray(i + 1).width / 2)), Single))
                        g.DrawLine(New Pen(Color.Brown, 2), DRArray(i).x + DRArray(i).length, CType(Math.Round(DRArray(i).y + (DRArray(i).width / 2)), Single), DRArray(i + 1).x + DRArray(i + 1).length, CType(Math.Round(DRArray(i + 1).y + (DRArray(i + 1).width / 2)), Single))
                    Else
                        If CheckTrue(DRArray) = True Then
                            g.DrawLine(New Pen(Color.Red, 2), DRArray(i).x, CType(Math.Round(DRArray(i).y + (DRArray(i).width / 2)), Single), DRArray(i + 1).x, CType(Math.Round(DRArray(i + 1).y + (DRArray(i + 1).width / 2)), Single))
                            g.DrawLine(New Pen(Color.Red, 2), DRArray(i).x + DRArray(i).length, CType(Math.Round(DRArray(i).y + (DRArray(i).width / 2)), Single), DRArray(i + 1).x + DRArray(i + 1).length, CType(Math.Round(DRArray(i + 1).y + (DRArray(i + 1).width / 2)), Single))

                        ElseIf DRArray(i).OuterValue = False Then
                            g.DrawLine(New Pen(Color.Red, 2), DRArray(i).x, CType(Math.Round(DRArray(i).y + (DRArray(i).width / 2)), Single), DRArray(i + 1).x, CType(Math.Round(DRArray(i + 1).y + (DRArray(i + 1).width / 2)), Single))
                            g.DrawLine(New Pen(Color.Brown, 2), DRArray(i).x + DRArray(i).length, CType(Math.Round(DRArray(i).y + (DRArray(i).width / 2)), Single), DRArray(i + 1).x + DRArray(i + 1).length, CType(Math.Round(DRArray(i + 1).y + (DRArray(i + 1).width / 2)), Single))
                        Else
                            g.DrawLine(New Pen(Color.Red, 2), DRArray(i).x, CType(Math.Round(DRArray(i).y + (DRArray(i).width / 2)), Single), DRArray(i + 1).x, CType(Math.Round(DRArray(i + 1).y + (DRArray(i + 1).width / 2)), Single))
                            g.DrawLine(New Pen(Color.Red, 2), DRArray(i).x + DRArray(i).length, CType(Math.Round(DRArray(i).y + (DRArray(i).width / 2)), Single), DRArray(i + 1).x + DRArray(i + 1).length, CType(Math.Round(DRArray(i + 1).y + (DRArray(i + 1).width / 2)), Single))
                        End If
                    End If
                End If
                If DRArray(i).brackets Then
                    VerticalLines(DRArray(i).ref)
                End If

            Next
        End Sub
        Function CheckTrue(ByVal CTArray As ArrayList) As Boolean
            Dim a As operand

            For Each a In CTArray
                    If a.OuterValue = True Then
                        Return True
                    End If
            Next
            Return False
        End Function
        Sub DrawClamp(ByVal DRArray As ArrayList)
            Dim g As Graphics = CreateGraphics()
            Dim r As Integer = 5
            Dim BrownPen As New Pen(Color.Brown, 2)
            Dim BlackPen As New Pen(Color.Black, 2)
            If initial.OuterValue = True Then
                BrownPen.Color = Color.Red
            Else
                BrownPen.Color = Color.Brown
            End If
            Dim Line11_x1, Line11_y1, Line11_x2, Line11_y2, Circle1_x, Circle1_y, _
            Line21_x1, Line21_y1, Line21_x2, Line21_y2 As Integer

            Dim Line12_x1, Line12_y1, middle, Line12_x2, d, Line12_y2, Circle2_x, Circle2_y, Circle_width, _
             Circle_height, Line22_x1, Line22_y1, Line22_x2, Line22_y2 As Integer
            middle = CType(Math.Round(W / 2), Integer)
            d = 1
            Line11_x1 = Line11_x2 + 3 + 2 * r
            Line11_y1 = CType(Math.Round(in1.Width / 2), Single) - middle + in1.Y + middle
            Line11_x2 = in1.ref(0).x
            Line11_y2 = Line11_y1
            Circle1_x = Line11_x1 - d - 2 * r
            Circle1_y = Line11_y1 - r '!
            Circle_width = 2 * r
            Circle_height = 2 * r
            Line21_x1 = Circle1_x - 3
            Line21_y1 = Line11_y1 + r + 3
            Line21_x2 = Circle1_x + 2 * r + 3
            Line21_y2 = Line11_y1 - r - 3
            g.DrawLine(New Pen(Color.Red, 2), Line11_x1, Line11_y1, Line11_x2, Line11_y2)
            g.DrawEllipse(New Pen(Color.Red, 2), Circle1_x, Circle1_y, Circle_width, Circle_height)
            g.DrawLine(New Pen(Color.Red, 2), Line21_x1, Line21_y1, Line21_x2, Line21_y2)

            Line12_x1 = in1.ref(in1.ref.Count - 1).x + in1.ref(in1.ref.Count - 1).length
            Line12_y1 = CType(Math.Round(in1.Width / 2), Single) - middle + in1.Y + middle
            Line12_x2 = Line12_x1 + in1.X - d - 2 * r
            Line12_y2 = Line12_y1
            Circle2_x = Line12_x2 - d  '!
            Circle2_y = Line12_y1 - r
            Circle_width = 2 * r
            Circle_height = 2 * r
            Line22_x1 = Line12_x2 - 3
            Line22_y1 = Line12_y1 + r + 3
            Line22_x2 = Line12_x2 + 2 * r + 3
            Line22_y2 = Line12_y1 - r - 3
            g.DrawLine(BrownPen, Line12_x1, Line12_y1, Line12_x2, Line12_y2)
            g.DrawEllipse(BrownPen, Circle2_x, Circle2_y, Circle_width, Circle_height)
            g.DrawLine(BrownPen, Line22_x1, Line22_y1, Line22_x2, Line22_y2)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            DrawElement(in1.ref)
            VerticalLines(in1.ref)
            DrawClamp(in1.ref)
            'DrawRectangle(in1.ref)
        End Sub
    End Class

    'Dim words As String = "not(   a or b and (s and s1 or    not s2) and c or not( a or v and n)) or c"
    'Dim words As String = "not( a and ((s and s1) or not s2) or ( s and s1)  )"
    ' Dim words As String = "s1 and (not(s2 or s) or s3)"
    'Dim words As String = "s3 and (s1 or s2) or s4 or ( s5 and s6 )"
    Dim words As String = "a and ( b or c) and ((b or a) or ( c and(a or b)))"
    Dim op As operand
    Dim operands As New ArrayList
    Shared initial As operand

    Enum _operation
        con = 0
        dis = 1
        none = 2
    End Enum
    'begin
    Dim __operation() As String = {"and", "or", ""}
    Dim __notop() As String = {"", "not"}
    Dim debug As Integer = 0
    Public Function notop(ByVal b As Boolean) As String
        If b Then Return "not" Else Return ""
    End Function
    'end

    Public Class operand
        Private m_denial As Boolean
        Private m_brackets As Boolean
        Private m_operation As _operation
        Private m_content As String
        Private m_ref As ArrayList
        Private m_X As Long
        Private m_y As Long
        Private m_Length As Long
        Private m_Width As Long
        Private m_Value As Byte
        Private m_OuterValue As Boolean
        Private m_IntermediateValue As Boolean

        Public Property denial() As Boolean
            Get
                Return m_denial
            End Get
            Set(ByVal Value As Boolean)
                m_denial = Value
            End Set
        End Property
        Public Property brackets() As Boolean
            Get
                Return m_brackets
            End Get
            Set(ByVal Value As Boolean)
                m_brackets = Value
            End Set
        End Property
        Public Property operation() As _operation
            Get
                Return m_operation
            End Get
            Set(ByVal Value As _operation)
                m_operation = Value
            End Set
        End Property
        Public Property content() As String
            Get
                Return m_content
            End Get
            Set(ByVal Value As String)
                m_content = Value
            End Set
        End Property
        Public Property ref() As ArrayList
            Get
                Return m_ref
            End Get
            Set(ByVal Value As ArrayList)
                m_ref = Value
            End Set
        End Property
        Public Property X() As Long
            Get
                Return m_X
            End Get
            Set(ByVal Value As Long)
                m_X = Value
            End Set
        End Property
        Public Property Y() As Long
            Get
                Return m_y
            End Get
            Set(ByVal Value As Long)
                m_y = Value
            End Set
        End Property
        Public Property Length() As Long
            Get
                Return m_Length
            End Get
            Set(ByVal Value As Long)
                m_Length = Value
            End Set
        End Property
        Public Property Width() As Long
            Get
                Return m_Width
            End Get
            Set(ByVal Value As Long)
                m_Width = Value
            End Set
        End Property
        Public Property Value() As Byte
            Get
                Return m_Value
            End Get
            Set(ByVal Value As Byte)
                m_Value = Value
            End Set
        End Property
        Public Property OuterValue() As Boolean
            Get
                Return m_OuterValue
            End Get
            Set(ByVal Value As Boolean)
                m_OuterValue = Value
            End Set
        End Property
        Public Property IntermediateValue() As Boolean
            Get
                Return m_IntermediateValue
            End Get
            Set(ByVal Value As Boolean)
                m_IntermediateValue = Value
            End Set
        End Property
        Public Sub New()
            m_ref = New ArrayList
        End Sub
    End Class

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

    Public Sub divide(ByRef s As String, ByRef CurArray As ArrayList)
        Dim split As String() = s.Split(" ")
        Dim w As String, name As String
        Dim i, br, k, j
        Dim FinishId As Integer
        Dim o As operand
        i = 0
        br = 0

        Do While i < split.Length '' ?? why not length-1

            w = split(i)

            ' Console.WriteLine(w)
            If br = 0 Then
                If w.ToLower().Equals("not") Then
                    op.denial = True
                End If

                If w <> "(" And w <> ")" And w <> "not" And w <> "and" And w <> "or" And w <> "" Then
                    If op.content = "" Then
                        op.content = w

                    Else
                        Throw New SchemeExeption("У виразі відсутня логічна операція між судженнями")
                    End If
                End If
                If w.ToLower().Equals("and") Then
                    op.operation = _operation.con
                    CurArray.Add(op)

                    op = New operand
                End If
                If w.ToLower() = "or" Then
                    op.operation = _operation.dis
                    CurArray.Add(op)
                    op = New operand

                End If
            End If
            If w = "(" Then
                op.brackets = True
                '   name = "("
                name = " "

                br = 1
                k = 1

                Do While k > 0 And i <= split.Length - 1
                    i += 1
                    '   Console.WriteLine(split(i))

                    If Not (k = 1 And split(i) = ")") Then
                        name = name & " " & split(i)
                    End If

                    If split(i) = "(" Then
                        k += 1
                    End If
                    If split(i) = ")" Then
                        k -= 1
                    End If
                    If k <> 0 And i >= split.Length - 1 Then
                        Console.WriteLine(" ')' error")
                        Console.ReadLine()
                        Exit Sub
                    End If
                Loop
                '     name = name.Substring(0, name.Length - 2)
                If op.content = "" Then
                    op.content = name.Trim
                Else
                    Throw New SchemeExeption("У виразі відсутня логічна операція між судженнями")
                End If


                'Console.WriteLine(name)
                'Console.WriteLine(k)

                br = 0
            End If
            If i = split.Length - 1 Then
                op.operation = _operation.none ' addind last element
                CurArray.Add(op)
                op = New operand

            End If
            i += 1
        Loop
        i = 0
        Do While i < CurArray.Count
            If CurArray(i).brackets = True Then
                divide(CurArray(i).content, CurArray(i).ref)
                checkbrackets(CurArray(i))
                If debug = 1 Then
                    Console.WriteLine(CurArray(i).content & " " & CurArray(i).ref.count)
                    For j = 0 To CurArray(i).ref.count - 1
                        Console.WriteLine(CurArray(i).ref(j).content & " op=" & CurArray(i).ref(j).operation & " not=" & notop(0 - CurArray(i).ref(j).denial))
                    Next j
                End If
            End If
            ' begin
            Dim denial As Integer
            For Each o In CurArray(i).ref
                '   CurArray(i).content = ""
                denial = o.denial
                denial = Math.Abs(denial)
                If o.brackets = True Then
                    '       CurArray(i).content &= " " & __notop(denial) & " ( " & o.content & ")" & " " & __operation(CurArray(i).operation) & " "
                Else
                    '     CurArray(i).content &= " " & __notop(denial) & " " & o.content & " " & __operation(CurArray(i).operation) & " "
                End If
                ' CurArray(i).content = CheckSpace(CurArray(i).content)
                ' end

            Next
            i += 1


        Loop
    End Sub

    Public Sub checkbrackets(ByRef OldOp As operand)
        Dim NewArray As New ArrayList
        Dim length
        Dim i, start As Integer
        Dim opera As _operation
        Dim NewOp As operand
        If OldOp.ref.Count < 3 Then
            Exit Sub
        End If
        opera = OldOp.ref(0).operation
        i = 1
        While (i < OldOp.ref.Count - 1 AndAlso opera = OldOp.ref(i).operation) ''
            i += i
        End While

        If i = OldOp.ref.Count Then
            Exit Sub
        End If

        For i = 0 To OldOp.ref.Count - 1
            If OldOp.ref(i).operation = _operation.con Then
                start = i
                length = 1
                i += 1
                While (i < OldOp.ref.Count)
                    If OldOp.ref(i).operation = _operation.con Then
                        length += 1
                    Else
                        length += 1
                        '  b = enum1.MoveNext()
                        Exit While
                    End If
                    i += 1
                End While


                NewOp = conjunction(OldOp.ref, start, length)
                ' Console.WriteLine(i & " " & length)
                NewArray.Add(NewOp)
            Else
                NewArray.Add(OldOp.ref(i))
            End If
        Next i
        OldOp.ref = NewArray
        Dim oo As operand
        Dim d As Integer
        OldOp.content = ""
        For Each oo In OldOp.ref
            d = oo.denial
            d = Math.Abs(d)
            If oo.brackets = True Then
                OldOp.content &= " " & __notop(d) & " ( " & oo.content & " ) " & __operation(oo.operation)
            Else
                OldOp.content &= " " & __notop(d) & " " & oo.content & " " & __operation(oo.operation)
            End If
        Next
        Console.WriteLine("! " & OldOp.content)
        ' todo change content
    End Sub

    Function conjunction(ByVal NewRef As ArrayList, ByVal start As Integer, ByVal length As Integer) As operand
        Dim NewName As String = ""
        Dim NewOp As New operand
        Dim denial As Integer
        Dim i As Integer
        NewOp.operation = NewRef(start + length - 1).operation
        NewRef(start + length - 1).operation = _operation.none
        For i = start To start + length - 1
            If NewRef(i).brackets = True Then
                NewName &= " " & notop(NewRef(i).denial) & " ( " & NewRef(i).content & " ) " & __operation(NewRef(i).operation)
            Else
                NewName &= " " & notop(NewRef(i).denial) & " " & NewRef(i).content & " " & __operation(NewRef(i).operation)
            End If
        Next
        NewOp.brackets = True
        NewOp.content = CheckSpace(NewName)
        If debug = 1 Then
            Console.WriteLine("Newname=" & NewOp.content)
        End If
        NewOp.denial = False
        For i = start To start + length - 1
            NewOp.ref.Add(NewRef(i))
        Next
        Return NewOp
    End Function

    Sub Morgan(ByRef curarray As ArrayList) ' not(a or b)=(not a and not b)
        Dim victim, Rvictim, Cvictim, qvictim, a, b As operand
        Dim i, denial As Integer

        i = 0
        While (i < curarray.Count) 'For Each victim In curarray
            If debug = 2 Then
                Console.WriteLine("before " & curarray(i).content)
            End If
            If curarray(i).denial = True And curarray(i).brackets = True Then

                For Each Rvictim In curarray(i).ref
                    If Rvictim.operation = _operation.con Then
                        Rvictim.operation = _operation.dis
                    ElseIf Rvictim.operation = _operation.dis Then
                        Rvictim.operation = _operation.con
                    End If
                    If Rvictim.denial = True Then
                        Rvictim.denial = False
                    ElseIf Rvictim.denial = False Then
                        Rvictim.denial = True
                    End If


                Next

                curarray(i).denial = False
                'i = curarray.IndexOf(curarray(i))
                'curarray.RemoveRange(i, 1)
                'curarray.InsertRange(i, curarray(i).ref)
                'For Each Cvictim In curarray
                'checkbrackets(Cvictim)
                'Next


            End If
            '            curarray(i).denial = False
            If curarray(i).ref.Count > 0 Then '
                Morgan(curarray(i).ref)
            End If
            If curarray(i).ref.count <> 0 Then
                curarray(i).content = ""

                For Each qvictim In curarray(i).ref
                    If qvictim.brackets = True Then
                        curarray(i).content &= " " & notop(qvictim.denial) & " ( " & qvictim.content & " ) " & __operation(qvictim.operation)
                    Else
                        curarray(i).content &= " " & notop(qvictim.denial) & " " & qvictim.content & " " & __operation(qvictim.operation)
                    End If
                Next
                curarray(i).content = CheckSpace(curarray(i).content)
            End If
            If debug = 2 Then
                Console.WriteLine("after " & curarray(i).content)
            End If


            i += 1
        End While



    End Sub

    Function output(ByVal OArray As ArrayList) As String
        Dim Newstring As String
        Dim o0 As operand
        Dim denial As Integer
        For Each o0 In OArray
            denial = o0.denial
            denial = Math.Abs(denial)
            If o0.brackets = True Then
                Newstring &= " " & __notop(denial) & " ( " & o0.content & " ) " & __operation(o0.operation)
            Else
                Newstring &= " " & __notop(denial) & " " & o0.content & " " & __operation(o0.operation)
            End If
        Next
        Newstring = CheckSpace(Newstring)
        Return Newstring
    End Function

    Function MakeInitialOperand(ByVal ops As ArrayList) As operand
        Dim initial As New operand
        Dim o As operand
        For Each o In ops
            initial.brackets = False
            initial.content = ""
            initial.denial = False
            initial.operation = _operation.none
            initial.ref.Add(o)
        Next
        Return initial
    End Function

    Sub arrange(ByVal AArray As ArrayList)


        Dim a As operand
        Static Dim XB, YB, LengthB, WidthB As Long
        Dim i As Integer
        Const l = 1
        Const w = 1
        Static Dim f As Long


        For Each a In AArray
            If a.brackets = True Then
                arrange(a.ref)
            End If
        Next

        If f = 0 Then
            f = 1
            LengthB = l
            WidthB = w
            AArray(0).X = 0
            AArray(0).Y = 0
            AArray(0).Length = l
            AArray(0).Width = w

            i = 1
        Else
            i = 0
        End If


        Do While i <= AArray.Count - 1
            If AArray(i).brackets = False Then
                If AArray(0).operation = _operation.con Then
                    AArray(i).X = XB + LengthB
                    AArray(i).Y = YB
                    AArray(i).Length = l
                    AArray(i).Width = WidthB
                    LengthB += l

                End If
                If AArray(0).operation = _operation.dis Then
                    AArray(i).X = XB
                    AArray(i).Y = YB + WidthB
                    AArray(i).Length = LengthB
                    AArray(i).Width = w
                    WidthB += l

                End If
            End If

            i += 1
        Loop
    End Sub

    Sub dimension(ByRef DArray As ArrayList)
        Dim a As operand
        Dim i As Integer

        Static LB, WB As Long

        For Each a In DArray
            If a.brackets = True Then
                dimension(a.ref)
                a.Length = LB
                a.Width = WB
                Console.WriteLine(a.content & " len = " & LB & " width = " & WB)

            Else
                If a.Length = Nothing And a.Width = Nothing Then
                    a.Length = L
                    a.Width = W
                    Console.WriteLine(a.content & " len = " & L & " width = " & W)
                End If
            End If
        Next

        For i = 0 To DArray.Count - 1
            If i = 0 Then
                LB = DArray(i).Length
                WB = DArray(i).Width
            Else
                If DArray(i - 1).operation = _operation.con Then
                    LB += DArray(i).length
                    If WB < DArray(i).width Then
                        WB = DArray(i).width
                    End If
                End If
                If DArray(i - 1).operation = _operation.dis Then
                    WB += DArray(i).width
                    If LB < DArray(i).length Then
                        LB = DArray(i).length
                    End If
                End If
            End If
        Next
        For i = 0 To DArray.Count - 1
            If DArray(0).operation = _operation.con Then
                If (DArray(i).brackets) Then
                    resizeWidth(DArray(i), WB)
                Else
                    DArray(i).width = WB
                End If
            End If
            If DArray(0).operation = _operation.dis Then

                If (DArray(i).brackets) Then
                    resizeLength(DArray(i), LB)
                Else
                    DArray(i).length = LB
                End If

            End If
        Next
    End Sub
    Sub resizeLength(ByRef op As operand, ByVal lb As Long)
        Dim delta As Long
        Dim endOp As operand
        Dim tOp As operand
        If (op.Length < lb) Then
            delta = lb - op.Length
            op.Length = lb
            Console.WriteLine(op.content & " len =" & op.Length)
            If op.brackets Then
                tOp = op.ref(0)
                If (tOp.operation = _operation.dis) Then
                    For Each tOp In op.ref
                        resizeLength(tOp, tOp.Length + delta)
                    Next
                Else

                    endOp = op.ref(op.ref.Count - 1)
                    resizeLength(endOp, endOp.Length + delta)
                End If
            End If

        End If



    End Sub
    Sub resizeWidth(ByRef op As operand, ByVal wb As Long)
        Dim delta As Long
        Dim endOp As operand
        Dim tOp As operand
        If (op.Width < wb) Then
            delta = wb - op.Width
            op.Width = wb
            Console.WriteLine(op.content & " wid =" & op.Width)
            If op.brackets Then
                tOp = op.ref(0)
                If (tOp.operation = _operation.con) Then
                    For Each tOp In op.ref
                        resizeWidth(tOp, tOp.Width + delta)
                    Next
                Else

                    endOp = op.ref(op.ref.Count - 1)
                    resizeWidth(endOp, endOp.Width + delta)
                End If
            End If

        End If



    End Sub
    Sub InitialDimensionAndCoordinates(ByRef ID As operand)
        Dim a As operand
        Dim i As Integer
        Dim LI, WI As Long
        LI = 0
        WI = 0
        Dim op As _operation
        op = ID.ref(0).operation
        For Each a In ID.ref
            If i = 0 Then
                i = 1
                LI += a.Length
                WI += a.Width
            Else
                If op = _operation.con Then
                    LI += a.Length
                ElseIf op = _operation.dis Then
                    WI += a.Width
                End If
            End If
        Next
        ID.Length = LI
        ID.Width = WI
        ID.X = 50
        ID.Y = 10
    End Sub

    Sub coordinates(ByRef COperand As operand)
        Dim a As operand
        Dim i1 As Integer
        Dim CX, CY As Integer
        Dim op As _operation

        CX = COperand.X
        CY = COperand.Y
        op = COperand.ref(0).operation

        For Each a In COperand.ref

            If op = _operation.con Then
                a.X = CX
                a.Y = CY
                CX += a.Length
            End If
            If op = _operation.dis Then
                a.X = CX
                a.Y = CY
                CY += a.Width
            End If
            If op = _operation.none Then
                a.X = CX
                a.Y = CY

            End If
            Console.WriteLine(a.content & " " & a.X & " " & a.Y)
            a = a
        Next
        For Each a In COperand.ref
            If a.brackets = True Then
                coordinates(a)
            End If

        Next
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim intermediate As Boolean
        op = New operand
        words = ""
        operands.Clear()
        initial = Nothing
        var.Clear()
        Try
            words = LCase(TextBox1.Text)

            If words = "" Then
                TextBox2.Text = ""
                TextBox3.Text = ""
                If Me.Panel1.Controls.Count > 0 Then
                    Me.Panel1.Controls.RemoveAt(Me.Panel1.Controls.Count - 1)
                End If
                Exit Sub
            End If
            words = CheckSpace(words)

            i = 0

            divide(words, operands)

            initial = MakeInitialOperand(operands)

            checkbrackets(initial)

            TextBox2.Text = output(initial.ref)
            Morgan(initial.ref)
            TextBox3.Text = output(initial.ref)

            '  arrange(initial.ref)
            dimension(initial.ref)

            InitialDimensionAndCoordinates(initial)

            coordinates(initial)
            i = i
            If Me.Panel1.Controls.Count > 0 Then

                Me.Panel1.Controls.RemoveAt(Me.Panel1.Controls.Count - 1)

            End If
            If Me.Panel2.Controls.Count > 0 Then

                Me.Panel2.Controls.RemoveAt(Me.Panel2.Controls.Count - 1)

            End If
            ' Me.Panel1.Controls.Add(New draw_Panel(initial, initial.Length + 200, initial.Width + 20))
            GeatherVariables(initial)
            mypanel = New ValuesOfJujment(var)
            Me.Panel2.Controls.Add(mypanel)
            ChangePropertyDenial(initial)
            intermediate = True
            initial.OuterValue = CountValue(initial, intermediate)
            Console.WriteLine(initial.OuterValue)
            Me.Panel1.Controls.Add(New draw_Panel(initial, initial.Length + 200, initial.Width + 20))
        Catch err As SchemeExeption
            MsgBox(err.massage)
            TextBox2.Text = ""
            TextBox3.Text = ""
            If Me.Panel1.Controls.Count > 0 Then

                Me.Panel1.Controls.RemoveAt(Me.Panel1.Controls.Count - 1)

            End If
            If Me.Panel2.Controls.Count > 0 Then

                Me.Panel2.Controls.RemoveAt(Me.Panel2.Controls.Count - 1)

            End If

        
        End Try
    End Sub
    Public Sub GeatherVariables(ByVal initial As operand)
        Dim i As Integer
        If Not (initial.ref Is Nothing) Then
            Do While i < initial.ref.Count
                If initial.ref(i).brackets = False And testArray(initial.ref(i).content) = False Then
                    var.Add(initial.ref(i).content)
                Else
                    GeatherVariables(initial.ref(i))
                End If
                ' Console.WriteLine(initial.ref(i).content & " " & initial.ref(i).index)
                i += 1

            Loop

        End If
    End Sub

    Public Function testArray(ByVal ch As String) As Boolean

        Dim i As Integer
        i = 0
        testArray = False
        If var.Count > 0 Then
            Do While i < var.Count
                If var(i) = ch Then
                    testArray = True
                    Exit Do
                End If
                i += 1
            Loop
        End If

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gl.f11.Hide()
        gl.f0.Show()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        gl.f3.Show()
        gl.f3.RichTextBox1.Text = TextBox1.Text
        gl.f3.Button1.PerformClick()
    End Sub
    Sub ChangePropertyDenial(ByVal CInitial As operand)
        Dim i As Integer
        NameValue.Clear()
        Do While i < mypanel.Controls.Count
            NameValue.Add(mypanel.Controls(i).Text, mypanel.Controls(i + 1).Text)
            i += 2
        Loop
        Dim thing As Object
        For Each thing In NameValue.Keys
            Console.WriteLine(thing.ToString() & " " & NameValue(thing).ToString)
        Next

    End Sub
    Public Function CountValue(ByVal CVInitial As operand, ByVal Intermediate As Boolean) As Boolean
        Dim a As operand
        Dim staticint As Boolean
        Dim disint As Boolean
        staticint = Intermediate
        disint = False
        For Each a In CVInitial.ref
            If a.brackets = False Then
                a.Value = NameValue(a.content)
                a.OuterValue = (Not a.denial And CType(a.Value, Boolean)) Or (a.denial And Not CType(a.Value, Boolean))
                Console.WriteLine(a.content & " ov = " & a.OuterValue & " d = " & a.denial & " v = " & a.Value)
            Else
                a.IntermediateValue = Intermediate
                a.OuterValue = CountValue(a, Intermediate)

            End If


            If CVInitial.ref(0).operation = _operation.con Then
                a.IntermediateValue = Intermediate
                Intermediate = a.OuterValue And Intermediate
            ElseIf CVInitial.ref(0).operation = _operation.dis Then
                a.IntermediateValue = staticint
                disint = disint Or a.OuterValue
            ElseIf CVInitial.ref(0).operation = _operation.none Then
                Intermediate = a.OuterValue
            End If

        Next
        If CVInitial.ref(0).operation = _operation.dis Then
            Intermediate = disint And staticint
        End If
        Console.WriteLine(CVInitial.content & " intermidiate = " & Intermediate)
        Return Intermediate
    End Function

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If initial Is Nothing Then
            Exit Sub
        End If
        Dim intermediate As Boolean
        ChangePropertyDenial(initial)

        intermediate = True
        initial.OuterValue = CountValue(initial, intermediate)
        Console.WriteLine(initial.OuterValue)
        If Me.Panel1.Controls.Count > 0 Then

            Me.Panel1.Controls.RemoveAt(Me.Panel1.Controls.Count - 1)

        End If
        Me.Panel1.Controls.Add(New draw_Panel(initial, initial.Length + 200, initial.Width + 20))
    End Sub
    '
    'Private Sub Switch_Schemes_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
    '    Label1.Text = e.X
    '   Label2.Text = e.Y
    'End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

