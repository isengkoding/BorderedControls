Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

Public Class PanelText
    Inherits System.Windows.Forms.Panel

    Dim _PanelDoubleBuffer As Boolean = True
    Dim _FlatBorderBottom As Boolean
    Dim _FlatBorderTop As Boolean
    Dim _FlatBorderLeft As Boolean
    Dim _FlatBorderRight As Boolean
    Dim _FlatBorderColor As Color = Color.LightGray
    Dim _FlatBorderFocused As Color = Color.FromArgb(0, 174, 231)
    Dim _FlatBorderSize As Integer = 1
    Dim _BorderAlwaysShow As Boolean = True
    Dim _Text As String
    Dim _TextPadding As Padding
    Dim _TextBackColor As Color = Color.White
    Dim _ScrolBars As ScrollBars
    Dim _MultiLine As Boolean
    Dim txt As TextBox = New TextBox With {.Dock = DockStyle.Fill, .BorderStyle = BorderStyle.None, .Multiline = True}
    Dim l As Label = New Label With {.Dock = DockStyle.Left, .Width = 1, .BackColor = Color.Green, .Visible = True}
    Dim r As Label = New Label With {.Dock = DockStyle.Right, .Width = 1, .BackColor = Color.Green, .Visible = True}
    Dim t As Label = New Label With {.Dock = DockStyle.Top, .Height = 1, .BackColor = Color.Green, .Visible = True}
    Dim b As Label = New Label With {.Dock = DockStyle.Bottom, .Height = 1, .BackColor = Color.Green, .Visible = True}
    Dim pnlTxt As Panel = New Panel With {.Dock = DockStyle.Fill, .BackColor = Color.Transparent}

    Public Sub New()
        Me.DoubleBuffered = True
        Me.Size = New Size(200, 100)
        Me.BackColor = Color.White
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
        ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
        Controls.AddRange(New Control() {pnlTxt, l, r, t, b})
        pnlTxt.Controls.Add(txt)
        AddHandler txt.LostFocus, AddressOf txtLost
        AddHandler txt.GotFocus, AddressOf txtFocus
        Me.Update()
    End Sub
    Private Sub txtFocus(sender As Object, e As EventArgs)
        changeBorderColor(_FlatBorderFocused)
        SendKeys.Send("{Home}+{End}")
    End Sub
    Private Sub txtLost(sender As Object, e As EventArgs)
        changeBorderColor(_FlatBorderColor)
    End Sub

    Private Sub changeBorderColor(ByVal clr As Color)
        l.BackColor = clr
        r.BackColor = clr
        t.BackColor = clr
        b.BackColor = clr
    End Sub

    Private Sub PanelText_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        txt.Focus()
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
            changeBorderColor(_FlatBorderColor)
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

    <Browsable(True), System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overrides Property Text() As String
        Get
            Return txt.Text
        End Get
        Set(ByVal Value As String)
            txt.Text = Value
        End Set
    End Property

    <Browsable(True), System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overrides Property BackColor() As Color
        Get
            Return _TextBackColor
        End Get
        Set(ByVal value As Color)
            _TextBackColor = value
            txt.BackColor = _TextBackColor
        End Set
    End Property

    Public Property TextPadding As Padding
        Get
            Return _TextPadding
        End Get
        Set(ByVal value As Padding)
            _TextPadding = value
            pnlTxt.Padding = _TextPadding
        End Set
    End Property

    Public Property ScrolBars As ScrollBars
        Get
            Return _ScrolBars
        End Get
        Set(value As ScrollBars)
            _ScrolBars = value
            txt.ScrollBars = _ScrolBars
        End Set
    End Property

    Public Property MultiLine As Boolean
        Get
            Return _MultiLine
        End Get
        Set(value As Boolean)
            _MultiLine = value
            txt.Multiline = _MultiLine
        End Set
    End Property

    Public Property FlatBorderFocused As Color
        Get
            Return _FlatBorderFocused
        End Get
        Set(value As Color)
            _FlatBorderFocused = value
        End Set
    End Property
End Class
