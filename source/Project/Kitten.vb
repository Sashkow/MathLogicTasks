Imports System
Imports System.IO
Public Class Kitten
    Inherits System.Windows.Forms.Form
    Public gl As Global = Global.getGlobal
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(384, 32)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Формалізована умова  задачі"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(384, 32)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "        Умова задачі"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(384, 32)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "        Умовні позначення в таблиці"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(704, 504)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(552, 32)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Відповідь"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(704, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(560, 32)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Таблиця істинності"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(1128, 672)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 48)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Вихід"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(704, 48)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(552, 448)
        Me.RichTextBox1.TabIndex = 32
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 672)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 48)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Розв'язати задачу"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(8, 40)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox3.Size = New System.Drawing.Size(648, 192)
        Me.RichTextBox3.TabIndex = 43
        Me.RichTextBox3.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(704, 544)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(552, 88)
        Me.Label1.TabIndex = 44
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(8, 280)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox2.Size = New System.Drawing.Size(648, 192)
        Me.RichTextBox2.TabIndex = 45
        Me.RichTextBox2.Text = ""
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.AntiqueWhite
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(8, 552)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox4.Size = New System.Drawing.Size(648, 80)
        Me.RichTextBox4.TabIndex = 46
        Me.RichTextBox4.Text = "F = ( not F or not T ) and ( not H or not P ) and ( not U or F )  and ( not T or " & _
        "not E ) and ( U or H ) and P"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(160, 680)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(960, 24)
        Me.ProgressBar1.TabIndex = 47
        '
        'Kitten
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1284, 726)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Kitten"
        Me.Text = "Кошеня "
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub RichTextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox3.TextChanged

    End Sub

    Private Sub Kitten_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox3.LoadFile("kitten_Task.rtf")
        RichTextBox3.ReadOnly = True
        RichTextBox2.LoadFile("kitten_Var.rtf")
        RichTextBox2.ReadOnly = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox2.SaveFile("kitten_Var.rtf")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'gl.f3.Visible = False
        'gl.f3.Show()
        gl.f3.RichTextBox1.Text = " ( not F or not T ) and ( not H or not P ) and ( not U or F )  and ( not T or not E ) and ( U or H ) and P"
        gl.f3.MakeTable(ProgressBar1)
        'gl.f3.Button1.PerformClick()
        RichTextBox1.Text = gl.f3.RichTextBox2.Text
        'gl.f3.Hide()
        Label1.Text = "Кошеня, що любить грати з мавпою, любить рибу і має вуса. "
    End Sub

    
End Class
