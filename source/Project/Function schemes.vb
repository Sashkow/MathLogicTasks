
Public Class function_schemes
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.RichTextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(856, 29)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Panel1.Location = New System.Drawing.Point(8, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 472)
        Me.Panel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(592, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 48)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Аналіз логічного виразу"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(592, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(272, 48)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Функціональна схема"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Ivory
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(592, 480)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(272, 48)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Вихід"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(856, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Логічний вираз"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(592, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 232)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = ""
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Ivory
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(592, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(272, 48)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Таблиця істиності"
        '
        'function_schemes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(880, 534)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "function_schemes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Функціональнi схеми"
        Me.ResumeLayout(False)

    End Sub

#End Region



    Public gl As Global = Global.getGlobal
    Dim gelIn As graphElementIn
    Dim gelInv As graphElementInv
    Dim gelCon As graphElementCon
    Dim geldis As graphElementDis
    Dim col As New ArrayList
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j As Integer
        gl.els().Clear()
        Label1.Text = ""
        gl.ind = 0
        Dim s As String
        s = " " & TextBox1.Text
        gl.readStr(s)
        For i = 0 To gl.els.Count - 1
            Label1.Text += "Об'єкт " & Str(i) & " назва - " & gl.els(i).name & " тип - " & typeS(i) & Chr(10)
            For j = 0 To gl.els(i).contact.count - 1
                Label1.Text += "вхід" & LTrim(Str(j)) & " = " & gl.els(i).contact(j) & Chr(10)
            Next
        Next i
    End Sub
    Public Function typeS(ByVal n As Integer) As String
        Dim k As String
        Select Case gl.els(n).type
            Case 1
                k = "вхід"
            Case 2
                k = "вихід"
            Case 3
                k = "інвертор"
            Case 4
                k = "кон'юнктор"
            Case 5
                k = "диз'юнктор"
        End Select
        typeS = k

    End Function
    'button2'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim gels As New ArrayList


    'IN
    Public Class graphElementIn
        Inherits Global.graphElement
        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            e.Graphics.DrawLine(p, 0, h \ 2, w, h \ 2)
        End Sub
        Public Sub New()
            MyBase.New()
            Me.Size = New System.Drawing.Size(w, h)
            Me.BackColor = Color.Ivory
            l1.Visible = False

        End Sub

        Protected Overrides Sub setLocL1()
            MyBase.setLocL1()
            l1.Location = New Point(0, l1.Location.Y - 10)
        End Sub
    End Class


    'NOT
    Public Class graphElementInv
        Inherits Global.graphElement
        Public l2 As New System.Windows.Forms.Label
        Public Sub ContInv(ByVal s As String)
            l2.Text = s
        End Sub
        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)
            e.Graphics.DrawLine(p, 0, h \ 2, k, h \ 2)
            e.Graphics.DrawEllipse(p, (w - 15) - 3, (h \ 2) - 3, 6, 6) '
        End Sub
        Private Sub setLabelLoc()
            l2.Location = New System.Drawing.Point(0, (h - h2) \ 2 - 17)
        End Sub
        Public Sub New()
            MyBase.New()
            l2.Text = "in" ''''
            l2.ForeColor = p.Color
            l2.TextAlign = ContentAlignment.TopRight
            l2.Size = New System.Drawing.Size(ptl)
            setLabelLoc()
            Me.Controls.Add(l2)
            Me.Size = New System.Drawing.Size(w, h)
            Me.BackColor = Color.Ivory
        End Sub

        Public Overrides Sub setObjCont0(ByVal s As String)
            l2.Text = s
        End Sub

        Public Overrides Sub setSize(ByVal sz1 As Integer, ByVal sz2 As Integer)
            MyBase.setSize(sz1, sz2)
            setLabelLoc()
        End Sub
    End Class


    'AND
    Public Class graphElementCon
        Inherits Global.graphElement
        Private l2 As New System.Windows.Forms.Label
        Private l3 As New System.Windows.Forms.Label
        Private l As New System.Windows.Forms.Label
        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)
            e.Graphics.DrawLine(p, 0, (h - h2) \ 2, k, (h - h2) \ 2) '
            e.Graphics.DrawLine(p, 0, h - (h2 \ 2), k, h - (h2 \ 2))
        End Sub
        Private Sub setLabelLoc()
            l2.Location = New System.Drawing.Point(0, (h - h2) \ 2 - 17)
            l3.Location = New System.Drawing.Point(0, h - (h2 \ 2) - 17)
        End Sub
        Public Sub New()
            MyBase.New()
            l.Text = "&&"
            l.ForeColor = p.Color
            l.Size = New System.Drawing.Size(ptl)
            l.Location = New System.Drawing.Point(k + 1, field + 1)
            l2.Text = "c1"
            l2.TextAlign = ContentAlignment.TopRight
            l2.ForeColor = p.Color
            l2.Size = New System.Drawing.Size(ptl)
            l3.Text = "c2"
            l3.ForeColor = p.Color
            l3.TextAlign = ContentAlignment.TopRight
            l3.Size = New System.Drawing.Size(ptl)
            setLabelLoc()
            Me.Controls.Add(l)
            Me.Controls.Add(l2)
            Me.Controls.Add(l3)
            Me.Size = New System.Drawing.Size(w, h)
            Me.BackColor = Color.Ivory
        End Sub

        Public Overrides Sub setObjCont0(ByVal s As String)
            l2.Text = s
        End Sub
        Public Overrides Sub setObjCont1(ByVal s As String)
            l3.Text = s
        End Sub

        Public Overrides Sub setSize(ByVal sz1 As Integer, ByVal sz2 As Integer)
            MyBase.setSize(sz1, sz2)
            setLabelLoc()
        End Sub
    End Class



    'OR
    Public Class graphElementDis
        Inherits Global.graphElement
        Private l2 As New System.Windows.Forms.Label
        Private l3 As New System.Windows.Forms.Label
        Private l As New System.Windows.Forms.Label
        Public Overrides Sub setObjCont0(ByVal s As String)
            l2.Text = s
        End Sub
        Public Overrides Sub setObjCont1(ByVal s As String)
            l3.Text = s
        End Sub
        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)
            e.Graphics.DrawLine(p, 0, (h - h2) \ 2, k, (h - h2) \ 2) '
            e.Graphics.DrawLine(p, 0, h - (h2 \ 2), k, h - (h2 \ 2)) '
        End Sub
        Private Sub setLabelLoc()
            l2.Location = New System.Drawing.Point(0, (h - h2) \ 2 - 17)
            l3.Location = New System.Drawing.Point(0, h - (h2 \ 2) - 17)
        End Sub
        Public Sub New()
            MyBase.New()
            l.Text = "1"
            l.ForeColor = p.Color
            l.Size = New System.Drawing.Size(ptl)
            l.Location = New System.Drawing.Point(k + 1, field + 1)
            l2.Text = "c1"
            l2.TextAlign = ContentAlignment.TopRight
            l2.ForeColor = p.Color
            l2.Size = New System.Drawing.Size(ptl)
            l3.Text = "c2"
            l3.ForeColor = p.Color
            l3.TextAlign = ContentAlignment.TopRight
            l3.Size = New System.Drawing.Size(ptl)
            setLabelLoc()
            Me.Controls.Add(l)
            Me.Controls.Add(l2)
            Me.Controls.Add(l3)
            Me.Size = New System.Drawing.Size(w, h)
            Me.BackColor = Color.Ivory
        End Sub

        Public Overrides Sub setSize(ByVal sz1 As Integer, ByVal sz2 As Integer)
            MyBase.setSize(sz1, sz2)
            setLabelLoc()
        End Sub
    End Class
    Public Sub union()
        Dim i, j As Integer
        Dim e As New Global.element
        Dim gel As Global.graphElement

        For i = 0 To col.Count - 1
            For j = 0 To col(i).Count - 1
                e = col(i)(j)
                If e.type = Global._type.inv Then
                    'Dim gel As graphElementInv
                    gel = New graphElementInv
                    gel.setObjName(e.name)
                    gel.setObjCont0(e.contact(0))
                    gels.Add(gel)
                    e.draw = gel
                End If
                If e.type = Global._type.con Then
                    'Dim gel As graphElementCon
                    gel = New graphElementCon
                    gel.setObjName(e.name)
                    gel.setObjCont0(e.contact(0))
                    gel.setObjCont1(e.contact(1))
                    gels.Add(gel)
                    e.draw = gel
                End If
                If e.type = Global._type.dis Then
                    'Dim gel As graphElementDis
                    gel = New graphElementDis
                    gel.setObjName(e.name)
                    gel.setObjCont0(e.contact(0))
                    gel.setObjCont1(e.contact(1))
                    gels.Add(gel)
                    e.draw = gel
                End If
                If e.type = Global._type.into Then
                    'Dim gel As graphElementIn
                    gel = New graphElementIn
                    gel.setObjName(e.name)
                    gels.Add(gel)
                    e.draw = gel
                End If
            Next
        Next
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        col.Clear()
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText

        Me.Panel1.Controls.Clear()
        col.Add(New ArrayList) ' в масив додається пустий сповпчик
        If gl.els.Count > 0 Then
            col(0).add(gl.els(gl.els.Count - 1)) ' в цей стовпчик додається останній графічний елемент
        End If
        Dim t, i, j, f As Integer
        Dim ne As Global.element

        t = 0 'текущая колонка
        f = 0 'признак конца цикла(в текущей колонке все элементы 'into')
        Do While f = 0
            f = 1
            col.Add(New ArrayList) ' колонка
            For i = 0 To col(t).count - 1 ' все елементы колонки
                If col(t)(i).type <> Global._type.into Then
                    f = 0
                    For j = 0 To col(t)(i).contact.count - 1  'все контакты
                        '
                        ne = gl.objByName(col(t)(i).contact(j)) ' взаємне положення графічних елементів
                        If ne.type = Global._type.into Then
                            ne = ne.Clone() 'тип 'into' всгда клонируем
                        End If
                        col(t + 1).add(ne)   'добавляем елемент в слеующую за текущей колонку
                    Next
                Else
                    ne = col(t)(i).clone() 'тип 'into' всгда клонируем
                    col(t + 1).add(ne)   'добавляем елемент в слеующую за текущей колонку
                End If
            Next
            t += 1
        Loop

        union()

        For t = col.Count - 2 To 0 Step -1
            j = 0
            For i = 0 To col(t).count - 1
                Select Case col(t)(i).type
                    Case Global._type.into
                        col(t)(i).draw.setSize(col(t + 1)(j).draw.getSize(), 0)
                        j += 1
                    Case Global._type.inv
                        col(t)(i).draw.setSize(col(t + 1)(j).draw.getSize(), 0)
                        j += 1
                    Case Global._type.con, Global._type.dis
                        col(t)(i).draw.setSize(col(t + 1)(j).draw.getSize(), col(t + 1)(j + 1).draw.getSize())
                        j += 2
                End Select
            Next
        Next
        'For t = col.Count - 2 To 0 Step -1
        'j = 0
        'For i = 0 To col(t).count - 1
        'Select Case col(t)(i).type
        '    Case Global._type.into, Global._type.inv
        'col(t)(i).draw.setSize(40, 0)
        '    Case Global._type.con, Global._type.dis
        'col(t)(i).draw.setSize(40, 40)
        'End Select
        'Next
        'Next

        Dim pt As System.Drawing.Point
        pt = New System.Drawing.Point ' лівий верхній край 

        For i = col.Count - 2 To 0 Step -1
            pt.Y = 10
            For j = 0 To col(i).count - 1
                pt.X = 10 + (col.Count - 2 - i) * 90
                '                If col(i)(j).type <> 1 Then
                col(i)(j).draw.location = New System.Drawing.Point(pt.X, pt.Y)
                If (i = col.Count - 2) Then
                    col(i)(j).draw.setNameVisible(True)
                End If
                Me.Panel1.Controls.Add(col(i)(j).draw)
                '                End If
                pt.Y += col(i)(j).draw.getSize()
            Next

        Next
        'проміжна побудова 
        'For i = col.Count - 3 To 0 Step -1
        'pt.Y = 10
        'For j = 0 To col(i).count - 1
        'pt.X = 10 + (col.Count - 3 - i) * 85
        'If col(i)(j).type <> 1 Then
        'col(i)(j).draw.location = New System.Drawing.Point(pt.X, pt.Y)
        'If col(i)(j).type = 4 Or col(i)(j).type = 5 Then
        'col(i)(j).draw.setsize(60, 60)
        'End If
        'Me.Panel1.Controls.Add(col(i)(j).draw)
        'pt.Y += col(i)(j).draw.getSize() + 5
        'End If
        '
        '       Next

        '      Next
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        gl.f1.Hide()
        gl.f0.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        gl.f3.Show()
        gl.f3.RichTextBox1.Text = TextBox1.Text
        gl.f3.Button1.PerformClick()

    End Sub
End Class
