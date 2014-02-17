
Public Class Main
    Inherits sample

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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Main))
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Info
        Me.Button10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.Location = New System.Drawing.Point(1104, 24)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(128, 56)
        Me.Button10.TabIndex = 7
        Me.Button10.Tag = ""
        Me.Button10.Text = "Словник термінів"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Ivory
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button3.Location = New System.Drawing.Point(856, 472)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 72)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Побудова таблиці істнності за логічним виразом"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button2.Location = New System.Drawing.Point(624, 472)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 72)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Побудова ДДНФ, ДКНФ за таблицею істнності"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button1.Location = New System.Drawing.Point(624, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 72)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Функціональні схеми"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.OldLace
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 72)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Логічні текстові задачі"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.OldLace
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(624, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 72)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Задачі на представлення складних суджень"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Ivory
        Me.Button11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button11.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button11.Location = New System.Drawing.Point(856, 368)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(200, 72)
        Me.Button11.TabIndex = 12
        Me.Button11.Text = "Схеми перемикачів"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Ivory
        Me.Button9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button9.Location = New System.Drawing.Point(296, 520)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(208, 72)
        Me.Button9.TabIndex = 21
        Me.Button9.Text = "Чотири дівчини"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Ivory
        Me.Button8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.Location = New System.Drawing.Point(296, 416)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(208, 72)
        Me.Button8.TabIndex = 20
        Me.Button8.Text = "Екзамен"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Ivory
        Me.Button7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.Location = New System.Drawing.Point(296, 312)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(208, 72)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Хто вивчає логігку?"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Ivory
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.Location = New System.Drawing.Point(24, 520)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(208, 72)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Розклад"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Ivory
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.Location = New System.Drawing.Point(24, 416)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(208, 72)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Змагання"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Ivory
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(32, 312)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 72)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = " Антикварна  ваза"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Ivory
        Me.Button12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button12.Location = New System.Drawing.Point(160, 608)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(208, 72)
        Me.Button12.TabIndex = 22
        Me.Button12.Text = "Кошеня"
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1256, 718)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gl As Global

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gl.f1.Show()
        'gl.f0.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gl.f2.Show()
        'gl.f0.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        gl.f3.Show()
        'gl.f0.Hide()
    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gl = Global.getGlobal(Me)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        gl.f10.Show()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        gl.f11.Show()
    End Sub

    
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        gl.f4.Show() 'vase.show
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        gl.f5.Show()
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        gl.f6.Show()
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        gl.f7.Show()
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        gl.f8.Show()
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        gl.f9.Show()
    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        gl.f12.Show() ' kitten
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
