Public Class Scedule
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(1072, 680)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Вихід"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(8, 680)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Розв'язати задачу"
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Snow
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(80, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 40)
        Me.CheckBox1.TabIndex = 2
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.Snow
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(80, 88)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(112, 40)
        Me.CheckBox2.TabIndex = 3
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.Color.Snow
        Me.CheckBox3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(80, 128)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(112, 40)
        Me.CheckBox3.TabIndex = 4
        '
        'CheckBox4
        '
        Me.CheckBox4.BackColor = System.Drawing.Color.Snow
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(192, 48)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(112, 40)
        Me.CheckBox4.TabIndex = 5
        '
        'CheckBox5
        '
        Me.CheckBox5.BackColor = System.Drawing.Color.Snow
        Me.CheckBox5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox5.Location = New System.Drawing.Point(192, 88)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(112, 40)
        Me.CheckBox5.TabIndex = 6
        '
        'CheckBox6
        '
        Me.CheckBox6.BackColor = System.Drawing.Color.Snow
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox6.Location = New System.Drawing.Point(192, 128)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(112, 40)
        Me.CheckBox6.TabIndex = 7
        '
        'CheckBox7
        '
        Me.CheckBox7.BackColor = System.Drawing.Color.Snow
        Me.CheckBox7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox7.Location = New System.Drawing.Point(304, 48)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(112, 40)
        Me.CheckBox7.TabIndex = 8
        '
        'CheckBox8
        '
        Me.CheckBox8.BackColor = System.Drawing.Color.Snow
        Me.CheckBox8.Checked = True
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox8.Location = New System.Drawing.Point(304, 88)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(112, 40)
        Me.CheckBox8.TabIndex = 9
        '
        'CheckBox9
        '
        Me.CheckBox9.BackColor = System.Drawing.Color.Snow
        Me.CheckBox9.Checked = True
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox9.Location = New System.Drawing.Point(304, 128)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(112, 40)
        Me.CheckBox9.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Математика"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SeaShell
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 32)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Фізика"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SeaShell
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 32)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Географія"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SeaShell
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 40)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "1."
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SeaShell
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 40)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "2."
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SeaShell
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 40)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "3."
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(640, 200)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(536, 160)
        Me.RichTextBox1.TabIndex = 17
        Me.RichTextBox1.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SeaShell
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 32)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "№"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(640, 376)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(536, 296)
        Me.RichTextBox2.TabIndex = 19
        Me.RichTextBox2.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(632, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(544, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Рядки таблиці, що відповідають розв'язкам"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(640, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(536, 24)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Відповідь"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(480, 24)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Таблицая істинності"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(8, 200)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(568, 472)
        Me.RichTextBox3.TabIndex = 23
        Me.RichTextBox3.Text = ""
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(424, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(832, 112)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Є день тижня. В цей день є три предмети: математика, фізика, географія.Кожен вчит" & _
        "ель може відмітити уроки (перший, другий чи третій), на яких йому зручно виклада" & _
        "ти. Треба знайти оптимальний розклад для всіх вчителів."
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(416, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(480, 32)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Умова задачі"
        '
        'Scedule
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1272, 734)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Name = "Scedule"
        Me.Text = "Scedule"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public gl As Global = Global.getGlobal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gl.f6.Hide()
        'gl.f0.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim m1, m2, m3, f1, f2, f3, g1, g2, g3, a, b, c, a1, b1, c1 As Integer
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        RichTextBox3.Text = ""
        RichTextBox3.Text += "М1" & Chr(9) & "М2" & Chr(9) & "М3" & Chr(9) & "Ф1" & Chr(9) & "Ф2" & Chr(9) & "Ф3" & Chr(9) & "Г1" & Chr(9) & "Г2" & Chr(9) & "Г3" & Chr(9) & Chr(9) & "F()" & Chr(10)
        RichTextBox1.Text += "М1" & Chr(9) & "М2" & Chr(9) & "М3" & Chr(9) & "Ф1" & Chr(9) & "Ф2" & Chr(9) & "Ф3" & Chr(9) & "Г1" & Chr(9) & "Г2" & Chr(9) & "Г3" & Chr(9) & Chr(10)
        For m1 = False To CheckBox1.CheckState
            For m2 = False To CheckBox2.CheckState
                For m3 = False To CheckBox3.CheckState
                    For f1 = False To CheckBox4.CheckState
                        For f2 = False To CheckBox5.CheckState
                            For f3 = False To CheckBox6.CheckState
                                For g1 = False To CheckBox7.CheckState
                                    For g2 = False To CheckBox8.CheckState
                                        For g3 = False To CheckBox9.CheckState
                                            a = (m1 Xor m2 Xor m3) And (1 - (m1 And m2 And m3))
                                            b = (f1 Xor f2 Xor f3) And (1 - (f1 And f2 And f3))
                                            c = (g1 Xor g2 Xor g3) And (1 - (g1 And g2 And g3))

                                            a1 = (m1 Xor f1 Xor g1) And (1 - (m1 And f1 And g1))
                                            b1 = (m2 Xor f2 Xor g2) And (1 - (m2 And f2 And g2))
                                            c1 = (m3 Xor f3 Xor g3) And (1 - (m3 And f3 And g3))

                                            RichTextBox3.Text += m1 & Chr(9) & m2 & Chr(9) & m3 & Chr(9) & f1 & Chr(9) & f2 & Chr(9) & f3 & Chr(9) & g1 & Chr(9) & g2 & Chr(9) & g3 & Chr(9) & (a And b And c And a1 And b1 And c1) & Chr(10)
                                            If (a And b And c And a1 And b1 And c1) = 1 Then
                                                RichTextBox1.Text += m1 & Chr(9) & m2 & Chr(9) & m3 & Chr(9) & f1 & Chr(9) & f2 & Chr(9) & f3 & Chr(9) & g1 & Chr(9) & g2 & Chr(9) & g3 & Chr(9) & Chr(10)
                                                If m1 = 1 Then
                                                    RichTextBox2.Text += "1.Математика" & Chr(10)
                                                End If
                                                If f1 = 1 Then
                                                    RichTextBox2.Text += "1.Фізика" & Chr(10)
                                                End If
                                                If g1 = 1 Then
                                                    RichTextBox2.Text += "1.Географія" & Chr(10)
                                                End If
                                                If m2 = 1 Then
                                                    RichTextBox2.Text += "2.Математика" & Chr(10)
                                                End If
                                                If f2 = 1 Then
                                                    RichTextBox2.Text += "2.Фізика" & Chr(10)
                                                End If
                                                If g2 = 1 Then
                                                    RichTextBox2.Text += "2.Географія" & Chr(10)
                                                End If
                                                If m3 = 1 Then
                                                    RichTextBox2.Text += "3.Математика" & Chr(10)
                                                End If
                                                If f3 = 1 Then
                                                    RichTextBox2.Text += "3.Фізика" & Chr(10)
                                                End If
                                                If g3 = 1 Then
                                                    RichTextBox2.Text += "3.Географія" & Chr(10)
                                                End If
                                                RichTextBox2.Text += Chr(10)
                                            End If
                                        Next g3
                                    Next g2
                                Next g1
                            Next f3
                        Next f2
                    Next f1
                Next m3
            Next m2
        Next m1

    End Sub

    Private Sub Scedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
