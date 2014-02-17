Public Class NoBracketExeption
    Inherits Exception
End Class
Public Class Global
    Private m_els As ArrayList
    Public ind As Integer
    Public f0 As Form
    Public f1 As function_schemes
    Public f2 As Table_to_SDNF
    Public f3 As SDNF_to_table
    Public f4 As Vase
    Public f5 As Competitions
    Public f6 As Scedule
    Public f7 As study_logic
    Public f8 As exam
    Public f9 As four
    Public f10 As dict
    Public f11 As Switch_Schemes
    Public f12 As Kitten

    Public Sub New()
        ind = 0
        els = New ArrayList
    End Sub
    Private Shared gl As Global
    Public Class cF1
        Inherits function_schemes
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    'dispose
    Public Class cF2
        Inherits Table_to_SDNF
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    Public Class cF3
        Inherits SDNF_to_table
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    Public Class cF4
        Inherits Vase
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    Public Class cF5
        Inherits Competitions
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    Public Class cF6
        Inherits Scedule
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    Public Class cF7
        Inherits study_logic
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    Public Class cF8
        Inherits exam
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    Public Class cF9
        Inherits four
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    Public Class cF10
        Inherits dict
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    Public Class cF11
        Inherits Switch_Schemes
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    Public Class cF12
        Inherits Kitten
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.Hide()
        End Sub
    End Class
    Public Shared Function getGlobal(ByVal main As Form) As Global
        If gl Is Nothing Then
            gl = New Global
            gl.f0 = main
            gl.f1 = New cF1
            gl.f2 = New cF2
            gl.f3 = New cF3
            gl.f4 = New cF4
            gl.f5 = New cF5
            gl.f6 = New cF6
            gl.f7 = New cF7
            gl.f8 = New cF8
            gl.f9 = New cF9
            gl.f10 = New cF10
            gl.f11 = New cF11
            gl.f12 = New cF12
        End If
        Return gl
    End Function
    Public Shared Function getGlobal() As Global '?
        Return gl '?
    End Function '?

    Public Property els() As ArrayList
        Get
            Return m_els
        End Get
        Set(ByVal Value As ArrayList)
            m_els = Value
        End Set
    End Property
    Public Function place() As Integer ' for SDNF to table: property 'value' 
        Dim i As Integer
        For i = 0 To els.Count - 1

            Select Case els(i).type
                Case _type.into
                Case _type.inv
                    els(i).value = 1 - objByName(els(i).contact(0)).value
                Case _type.con
                    els(i).value = objByName(els(i).contact(0)).value And _
                    objByName(els(i).contact(1)).value
                Case _type.dis
                    els(i).value = objByName(els(i).contact(0)).value Or _
                                        objByName(els(i).contact(1)).value
            End Select
        Next
        Return els(els.Count - 1).value
    End Function

    Public Function objByName(ByVal c As String) As Global.element 'визначає об'єкт за його ім'ям
        Dim i As Integer
        For i = 0 To els.Count - 1
            If els(i).name = c Then
                Return els(i)
            End If
        Next
    End Function

    Public Enum _type
        into = 1
        outto = 2
        inv = 3
        con = 4
        dis = 5
    End Enum

    Public Class element
        Private m_type As _type
        Private m_contact As ArrayList 'ТОЛЬКО входы
        Private m_name As String
        Private m_draw As graphElement
        Private m_value As Integer
        Private m_typeS As String
        Public Property typeS() As String
            Get
                Return m_type
            End Get
            Set(ByVal Value As String)
                m_typeS = Value
            End Set
        End Property
        Public Property type() As _type
            Get
                Return m_type
            End Get
            Set(ByVal Value As _type)
                m_type = Value
            End Set
        End Property
        Public Property contact() As ArrayList
            Get
                Return m_contact
            End Get
            Set(ByVal Value As ArrayList)
                m_contact = Value
            End Set
        End Property
        Public Property name() As String
            Get
                Return m_name
            End Get
            Set(ByVal Value As String)
                m_name = Value
            End Set
        End Property
        Public Property draw()
            Get
                Return m_draw
            End Get
            Set(ByVal Value)
                m_draw = Value
            End Set
        End Property
        Public Property value() As Integer
            Get
                Return m_value
            End Get
            Set(ByVal Value As Integer)
                m_value = Value
            End Set
        End Property
        Public Sub New()
            m_contact = New ArrayList
        End Sub

        Public Function Clone() As Global.element
            Dim el As element = New element
            el.type = type
            el.contact = contact
            el.name = name
            'el.draw = nothing
            el.value = value
            el.typeS = typeS
            Return el
        End Function

    End Class
    Public Class graphElement
        Inherits System.Windows.Forms.Panel
        Protected ptl As New System.Drawing.Point(28, 15)
        Protected l1 As New System.Windows.Forms.Label
        Protected p As New System.Drawing.Pen(Color.Brown, 2)
        Public h As Integer
        Protected h2 As Integer
        Public Const w = 90
        Public Const k = 30
        Protected Const field = 5
        Private typeSize As Integer

        Public Overridable Sub setObjCont0(ByVal s As String)
            '   'empty
        End Sub
        Public Overridable Sub setObjCont1(ByVal s As String)
            '    'empty
        End Sub
        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            e.Graphics.DrawRectangle(p, k, field, w - k - 15, h - field * 2)
            e.Graphics.DrawLine(p, w - 15, h \ 2, w, h \ 2)
        End Sub
        Public Sub setObjName(ByVal s As String)
            l1.Text = s
        End Sub
        Public Sub setNameVisible(ByVal b As Boolean)
            l1.Visible = b
        End Sub

        Public Overridable Sub setSize(ByVal sz1 As Integer, ByVal sz2 As Integer)
            h = sz1 + sz2
            h2 = sz2
            Me.Size = New System.Drawing.Size(w, h)
            setLocL1()
        End Sub
        Public Function getSize() As Integer
            Return h
        End Function
        Protected Overridable Sub setLocL1()
            l1.Location = New System.Drawing.Point(k + 2, h \ 2 - 6)
        End Sub
        Public Sub New()
            MyBase.New()
            h = 40
            h2 = 0
            l1.Text = "b" ''''
            l1.TextAlign = ContentAlignment.TopCenter
            l1.ForeColor = p.Color
            l1.Size = New System.Drawing.Size(40, 15)
            setLocL1()
            Me.Controls.Add(l1)
            Me.Size = New System.Drawing.Size(w, h)
            Me.BackColor = Color.Ivory
        End Sub
    End Class
    Dim asdg As New graphElement
    Public Function readStr(ByVal s As String) As String
        s = trimB(s)
        s = invReplace(s)
        s = conReplace(s)
        s = disReplace(s)
        Return s
    End Function
    Public Function trimB(ByVal s As String) As String
        Dim i As Integer
        Dim braket, k, begin As Integer
        braket = 0
        Dim s1, s2, s3 As String
        i = 1
        Do While i <= s.Length
            If Mid(s, i, 1) = "(" Then
                braket = 1
                k = i + 1
                Do While braket <> 0 And k <= s.Length
                    If Mid(s, k, 1) = "(" Then
                        braket += 1
                    ElseIf Mid(s, k, 1) = ")" Then
                        braket -= 1
                    End If
                    k += 1
                Loop
                If braket <> 0 Then

                    MsgBox("Нема дужки ')'")
                    Throw New NoBracketExeption

                End If
                s1 = Mid(s, i + 1, k - i - 2) 'без скобок
                s2 = Mid(s, i, k - i)  ' со скобками
                s3 = readStr(s1)

                s = Mid(s, 1, i - 1) & _
                   " " & s3 & " " & _
                    Mid(s, k, s.Length)

                '                Replace(s, s2, s3, 1, k - i)
                i = k - 1 - (s2.Length - s3.Length)
            End If
            i += 1
        Loop
        Return s
    End Function
    Sub AddVar(ByVal var As String)
        Dim i As Integer
        Dim e As element
        i = 0
        '        Do While i < els.Count
        '       e = els(i)
        '       If e.name = var Then
        'Exit Sub
        '       End If
        '       i += 1
        '        Loop
        e = New element
        e.type = _type.into
        e.name = var
        els.Add(e)
    End Sub
    Public Function invReplace(ByVal s As String) As String
        Dim i, p As Integer
        Dim sL As String
        Dim e As element
        Dim var As String
        Const snot = "not"
        Do
            sL = LCase(s)
            i = 1
            p = InStr(sL, snot)
            If p = 0 Then
                Exit Do
            End If
            i = p + 3
            Do While i <= s.Length And Mid(s, i, 1) = " " 'пропустим пробелы
                i += 1
            Loop
            var = ""
            Do While i <= s.Length And Mid(s, i, 1) <> " " 'переменная
                var = var & Mid(s, i, 1)
                i += 1
            Loop
            AddVar(var)
            e = New element
            e.type = _type.inv
            e.name = GenName()
            e.contact.Add(var)
            els.Add(e)
            s = Mid(s, 1, p - 1) & " " & e.name & " " & Mid(s, i, s.Length - i + 1)

        Loop
        Return s
    End Function '    Public Function conReplace(ByVal s As String) As String
    Public Function conReplace(ByVal s As String) As String
        Dim i, p, c As Integer
        Dim sL As String
        Dim e As element
        Dim var1, var2 As String
        Const sand = "and"
        Do
            var1 = ""
            var2 = ""
            sL = LCase(s)
            i = 1
            p = InStr(sL, sand)
            If p = 0 Then
                Exit Do
            End If
            i = p - 1
            Do While i > 0 And Mid(s, i, 1) = " " 'пропустим пробелы
                i -= 1
            Loop
            Do While i > 0 And Mid(s, i, 1) <> " " ' первая переменная
                var1 = Mid(s, i, 1) & var1
                i -= 1
                If i = 0 Then
                    Exit Do
                End If
            Loop
            c = i
            i = p + 3                                    'and
            Do While i <= s.Length And Mid(s, i, 1) = " " 'пропустим пробелы
                i += 1
            Loop
            Do While i <= s.Length And Mid(s, i, 1) <> " " 'вторая переменная
                var2 = var2 & Mid(s, i, 1)
                i += 1
            Loop
            AddVar(var1)
            AddVar(var2)
            e = New element
            e.type = _type.con
            e.name = GenName() 'туду
            e.contact.Add(var1)
            e.contact.Add(var2)
            els.Add(e)
            If c = 0 Then
                s = e.name & " " & Mid(s, i + 1, s.Length - i + 1)
            Else
                s = Mid(s, 1, c) & " " & e.name & " " & Mid(s, i + 1, s.Length - i + 1)
            End If
        Loop
        Return s
    End Function
    Public Function disReplace(ByVal s As String) As String
        Dim i, p, c As Integer
        Dim sL As String
        Dim e As element
        Dim var1, var2 As String
        Const sor = "or"
        Do
            var1 = ""
            var2 = ""
            sL = LCase(s)
            i = 1
            p = InStr(sL, sor)
            If p = 0 Then
                Exit Do
            End If
            i = p - 1
            Do While i > 0 And Mid(s, i, 1) = " "  'пропустим пробелы
                i -= 1
            Loop
            Do While i > 0 AndAlso Mid(s, i, 1) <> " "  ' первая переменная
                var1 = Mid(s, i, 1) & var1
                i -= 1
            Loop
            c = i
            i = p + 2                                     'or
            Do While i <= s.Length And Mid(s, i, 1) = " "  'пропустим пробелы
                i += 1
            Loop
            Do While i <= s.Length And Mid(s, i, 1) <> " "  'вторая переменная
                var2 = var2 & Mid(s, i, 1)
                i += 1
            Loop
            AddVar(var1)
            AddVar(var2)
            e = New element
            e.type = _type.dis
            e.name = GenName() 'туду
            e.contact.Add(var1)
            e.contact.Add(var2)
            els.Add(e)
            If c = 0 Then
                s = e.name & " " & Mid(s, i + 1, s.Length - i + 1)
            Else
                s = Mid(s, 1, c) & " " & e.name & " " & Mid(s, i + 1, s.Length - i + 1)
            End If
        Loop
        Return s
    End Function
    Public Function GenName() As String
        ind += 1
        Return "a" & LTrim(Str(ind))
    End Function

End Class


