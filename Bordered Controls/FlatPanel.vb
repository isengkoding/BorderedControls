Imports System.Windows.Forms
Imports System.Drawing

Public Class FlatPanel
    Inherits Panel

    Dim _PanelDoubleBuffer As Boolean = True
    Dim _FlatBorderBottom As Boolean
    Dim _FlatBorderTop As Boolean
    Dim _FlatBorderLeft As Boolean
    Dim _FlatBorderRight As Boolean
    Dim _FlatBorderColor As Color
    Dim _FlatBorderSize As Integer = 4

    Dim l As Label = New Label With {.Name = "lblLeft", .Dock = DockStyle.Left, .Width = 4, .BackColor = Color.Green, .Visible = False}
    Dim r As Label = New Label With {.Name = "lblRight", .Dock = DockStyle.Right, .Width = 4, .BackColor = Color.Green, .Visible = False}
    Dim t As Label = New Label With {.Name = "lblTop", .Dock = DockStyle.Top, .Height = 4, .BackColor = Color.Green, .Visible = False}
    Dim b As Label = New Label With {.Name = "lblBottom", .Dock = DockStyle.Bottom, .Height = 4, .BackColor = Color.Green, .Visible = False}
    Public Sub New()
        Me.DoubleBuffered = True
        Me.Size = New Size(200, 100)
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
        ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        'Controls.AddRange(New Control() {l, r, r, b})
        Controls.AddRange(New Control() {l, r, t, b})
        Me.Update()
    End Sub

    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        setPosition()
    End Sub

    Private Sub setPosition()
        For Each obj As Control In MyBase.Controls
            If obj.Name = l.Name Or obj.Name = t.Name Or obj.Name = r.Name Or obj.Name = b.Name Then
                'obj.BringToFront()
                obj.SendToBack()
            End If
        Next
    End Sub

    Public Property FlatBorderBottom As Boolean
        Get
            Return _FlatBorderBottom
        End Get
        Set(value As Boolean)
            _FlatBorderBottom = value
            b.Visible = _FlatBorderBottom
        End Set
    End Property

    Public Property FlatBorderTop As Boolean
        Get
            Return _FlatBorderTop
        End Get
        Set(value As Boolean)
            _FlatBorderTop = value
            t.Visible = _FlatBorderTop
        End Set
    End Property

    Public Property FlatBorderLeft As Boolean
        Get
            Return _FlatBorderLeft
        End Get
        Set(value As Boolean)
            _FlatBorderLeft = value
            l.Visible = _FlatBorderLeft
        End Set
    End Property

    Public Property FlatBorderRight As Boolean
        Get
            Return _FlatBorderRight
        End Get
        Set(value As Boolean)
            _FlatBorderRight = value
            r.Visible = _FlatBorderRight
        End Set
    End Property

    Public Property FlatBorderColor As Color
        Get
            Return _FlatBorderColor
        End Get
        Set(value As Color)
            _FlatBorderColor = value
            l.BackColor = _FlatBorderColor
            r.BackColor = _FlatBorderColor
            t.BackColor = _FlatBorderColor
            b.BackColor = _FlatBorderColor
        End Set
    End Property

    Public Property PanelDoubleBuffer As Boolean
        Get
            Return _PanelDoubleBuffer
        End Get
        Set(value As Boolean)
            _PanelDoubleBuffer = value
            Me.DoubleBuffered = _PanelDoubleBuffer
        End Set
    End Property

    Public Property FlatBorderSize As Integer
        Get
            Return _FlatBorderSize
        End Get
        Set(value As Integer)
            _FlatBorderSize = value
            l.Width = _FlatBorderSize
            r.Width = _FlatBorderSize
            t.Height = _FlatBorderSize
            b.Height = _FlatBorderSize
        End Set
    End Property

End Class
