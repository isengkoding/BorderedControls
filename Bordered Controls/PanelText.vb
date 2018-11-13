Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports BorderedControls

Public Class PanelText
    Inherits System.Windows.Forms.TextBox


    Dim _PanelDoubleBuffer As Boolean = True
    'Border properties
    Dim _FlatBorderBottom As Boolean = True
    Dim _FlatBorderTop As Boolean = True
    Dim _FlatBorderLeft As Boolean = True
    Dim _FlatBorderRight As Boolean = True
    Dim _FlatBorderColor As Color = Color.Silver
    Dim _FlatBorderFocused As Color = Color.FromArgb(0, 174, 231)
    Dim _FlatBorderSize As Integer = 1
    'Dim _BorderAlwaysShow As Boolean = True

    'Text properties
    Dim _FocusedBackColor As Color = Color.White
    Dim _Text As String = Me.Name
    Dim _TextPadding As Padding = New Padding(3, 3, 3, 3)
    Dim _TextBackColor As Color = Color.White
    Dim _ScrolBars As ScrollBars
    Dim _ShowButton As Boolean = True
    Dim _ShowClrButton As Boolean = True
    Dim _MultiLine As Boolean = True
    Dim _UsePasswordChar As Boolean = False
    Dim _PasswordChar As Char
    Dim _MultilineText As Boolean
    Dim _WaterMark As String

    'CustomButton Properties
    Dim _ButtonWidth As Integer = 25
    Dim _ButtonImg As Image
    Dim _ButtonTxt As String
    Dim _ButtonBackColor As Color = Color.DodgerBlue
    Dim _ButtonFocusedColor As Color = Color.AliceBlue

    'Declare support controls
    Dim txt As TextBox = New TextBox With {.Dock = DockStyle.Fill, .BorderStyle = BorderStyle.None, .Multiline = True}
    Dim l As Label = New Label With {.Dock = DockStyle.Left, .Width = 1, .BackColor = _FlatBorderColor, .Visible = True}
    Dim r As Label = New Label With {.Dock = DockStyle.Right, .Width = 1, .BackColor = _FlatBorderColor, .Visible = True}
    Dim t As Label = New Label With {.Dock = DockStyle.Top, .Height = 1, .BackColor = _FlatBorderColor, .Visible = True}
    Dim b As Label = New Label With {.Dock = DockStyle.Bottom, .Height = 1, .BackColor = _FlatBorderColor, .Visible = True}
    Dim pnlTxt As Panel = New Panel With {.Dock = DockStyle.Fill, .BackColor = Color.Transparent}
    Dim btn As Button = New Button With {.Dock = DockStyle.Right, .Width = 25, .FlatStyle = FlatStyle.Flat,
        .BackColor = _ButtonBackColor, .Visible = _ShowButton}
    Dim lblClear As Label = New Label With {.Dock = DockStyle.Right, .AutoSize = False, .Width = 25, .Text = "X", .Visible = _ShowClrButton, .TextAlign = ContentAlignment.MiddleCenter, .ForeColor = Color.LightGray}

    'Public events
    Public Event ButtonClick As EventHandler

    Public Sub New()
        Me.DoubleBuffered = True
        Me.Size = New Size(174, 25)
        Me.BackColor = Color.White
        Me.BorderStyle = BorderStyle.None
        Me.Multiline = True
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
        ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
        Controls.AddRange(New Control() {pnlTxt, lblClear, btn, l, r, t, b})
        'pnlTxt.Visible = False
        txt.TabStop = False
        pnlTxt.Controls.Add(txt)
        pnlTxt.Padding = _TextPadding
        AddHandler txt.LostFocus, AddressOf txtLost
        AddHandler txt.Enter, AddressOf txtFocus
        AddHandler txt.TextChanged, AddressOf txtChanged
        AddHandler txt.Click, AddressOf txtClick
        AddHandler txt.DoubleClick, AddressOf txtDoubleClick
        AddHandler txt.KeyPress, AddressOf txtKeyPress
        AddHandler txt.KeyDown, AddressOf txtKeyDown
        AddHandler txt.KeyUp, AddressOf txtKeyUp
        AddHandler lblClear.Click, AddressOf clearText
        AddHandler btn.Click, AddressOf btnClick
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = _ButtonFocusedColor
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Arrow
        lblClear.Cursor = Cursors.Arrow
        Me.Text = Me.Name
        Me.Update()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        Dim sTxt As String = Me.Text
        sTxt = IIf(sTxt.Length = 0, txt.Text, sTxt)
        If m.Msg = &HF Then
            If Not Me.Focused AndAlso String.IsNullOrEmpty(sTxt) AndAlso Not String.IsNullOrEmpty(Me.WaterMark) Then
                Using g = Me.CreateGraphics()
                    TextRenderer.DrawText(g, Me.WaterMark, Me.Font, Me.ClientRectangle, Color.Red, Me.BackColor, TextFormatFlags.Top Or TextFormatFlags.Left)
                End Using
            End If
            MyBase.Update()
        End If
    End Sub

    Private Sub txtKeyUp(sender As Object, e As KeyEventArgs)
        OnKeyUp(e)
        'If e.KeyCode = Keys.Enter Then e.SuppressKeyPress = Not _MultilineText
    End Sub

    Private Sub txtKeyDown(sender As Object, e As KeyEventArgs)
        OnKeyDown(e)
        If e.KeyCode = Keys.Enter Then e.SuppressKeyPress = Not _MultilineText ' : MyBase.OnKeyPress(New KeyPressEventArgs(Chr(Keys.Enter)))
    End Sub

    Private Sub txtKeyPress(sender As Object, e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        If e.KeyChar = Chr(Keys.Enter) And Not _MultilineText Then e.KeyChar = Nothing
    End Sub

    Private Sub txtDoubleClick(sender As Object, e As EventArgs)
        MyBase.OnDoubleClick(e)
    End Sub

    Private Sub txtClick(sender As Object, e As EventArgs)
        txt.Focus()
        MyBase.OnClick(e)
    End Sub

    Private Sub txtChanged(sender As Object, e As EventArgs)
        MyBase.OnTextChanged(e)
    End Sub

    'Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
    '    setPasswordStyle()
    'End Sub

    'Private Sub setPasswordStyle()
    '    txt.UseSystemPasswordChar = _UsePasswordChar
    '    txt.PasswordChar = _PasswordChar
    'End Sub

    Private Sub btnClick(sender As Object, e As EventArgs)
        RaiseEvent ButtonClick(sender, e)
    End Sub

    Private Sub clearText(sender As Object, e As EventArgs)
        txt.Text = ""
        txt.Focus()
    End Sub

    Private Sub txtFocus(sender As Object, e As EventArgs)
        changeBorderColor(_FlatBorderFocused)
        changeTextBackColor(_FocusedBackColor)
        changeSupportCtrlColor(_FocusedBackColor)
        lblClear.ForeColor = Color.Gray
        If txt.Text = WaterMark And WaterMark IsNot Nothing And WaterMark <> "" Then
            txt.Text = ""
            txt.Font = New Font(txt.Font, FontStyle.Regular)
        End If
        txt.SelectAll()
        MyBase.OnGotFocus(e)
    End Sub

    Private Sub txtLost(sender As Object, e As EventArgs)
        changeTextBackColor(BackColor)
        changeBorderColor(_FlatBorderColor)
        changeSupportCtrlColor(_TextBackColor)
        lblClear.ForeColor = Color.LightGray
        If (txt.Text = WaterMark Or txt.Text.Length = 0) And WaterMark IsNot Nothing And WaterMark <> "" Then
            txt.Text = WaterMark
            txt.Font = New Font(txt.Font, FontStyle.Italic)
        End If
        MyBase.OnLostFocus(e)
    End Sub

    Private Sub changeTextBackColor(ByVal clr As Color)
        txt.BackColor = clr
    End Sub

    Private Sub changeSupportCtrlColor(ByVal clr As Color)
        pnlTxt.BackColor = clr
        lblClear.BackColor = clr
    End Sub

    Private Sub changeBorderColor(ByVal clr As Color)
        l.BackColor = clr
        r.BackColor = clr
        t.BackColor = clr
        b.BackColor = clr
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
            If txt.Text = WaterMark And WaterMark IsNot Nothing And WaterMark <> "" Then
                Return ""
            Else
                Return txt.Text
            End If
        End Get
        Set(ByVal Value As String)
            txt.Text = Value
        End Set
    End Property

    <Browsable(True), System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overloads Property TextAlign() As HorizontalAlignment
        Get
            Return txt.TextAlign
        End Get
        Set(ByVal Value As HorizontalAlignment)
            txt.TextAlign = Value
        End Set
    End Property

    <Browsable(False), System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overloads Property UseSystemPasswordChar() As Boolean
        Get
            Return _UsePasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UsePasswordChar = value
            txt.UseSystemPasswordChar = _UsePasswordChar
        End Set
    End Property

    <Browsable(True), System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overloads Property PasswordChar() As Char
        Get
            Return _PasswordChar
        End Get
        Set(ByVal value As Char)
            _PasswordChar = value
            MyBase.PasswordChar = _PasswordChar
            txt.PasswordChar = _PasswordChar
            Me.Update()
        End Set
    End Property

    <Browsable(True), System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overloads Property WordWrap() As Boolean
        Get
            Return txt.WordWrap
        End Get
        Set(ByVal value As Boolean)
            txt.WordWrap = value
        End Set
    End Property

    <Browsable(True), System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overloads Property ShortcutsEnabled() As Boolean
        Get
            Return txt.ShortcutsEnabled
        End Get
        Set(ByVal value As Boolean)
            txt.ShortcutsEnabled = value
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
            MyBase.BackColor = _TextBackColor
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
    'Public Overloads Property ForeColor As Color
    '    Get
    '        Return txt.ForeColor
    '    End Get
    '    Set(value As Color)
    '        txt.ForeColor = value
    '    End Set
    'End Property

    Public Overloads Property ScrollBars As ScrollBars
        Get
            Return _ScrolBars
        End Get
        Set(value As ScrollBars)
            _ScrolBars = value
            txt.ScrollBars = _ScrolBars
        End Set
    End Property

    <Browsable(False), System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overloads Property Multiline As Boolean
        Get
            Return _MultiLine
        End Get
        Set(value As Boolean)
            _MultiLine = value
            txt.Multiline = _MultiLine
            MyBase.Multiline = _MultiLine
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

    Public Property FocusedBackColor As Color
        Get
            Return _FocusedBackColor
        End Get
        Set(value As Color)
            _FocusedBackColor = value
        End Set
    End Property

    Public Property ShowButton As Boolean
        Get
            Return _ShowButton
        End Get
        Set(value As Boolean)
            _ShowButton = value
            btn.Visible = _ShowButton
        End Set
    End Property

    Public Property ShowClrButton As Boolean
        Get
            Return _ShowClrButton
        End Get
        Set(value As Boolean)
            _ShowClrButton = value
            lblClear.Visible = _ShowClrButton
        End Set
    End Property

    Public Property ButtonWidth As Integer
        Get
            Return _ButtonWidth
        End Get
        Set(value As Integer)
            _ButtonWidth = value
            btn.Width = _ButtonWidth
        End Set
    End Property

    Public Property ButtonImg As Image
        Get
            Return _ButtonImg
        End Get
        Set(value As Image)
            _ButtonImg = value
            btn.Image = _ButtonImg
        End Set
    End Property

    Public Property ButtonTxt As String
        Get
            Return _ButtonTxt
        End Get
        Set(value As String)
            _ButtonTxt = value
            btn.Text = _ButtonTxt
        End Set
    End Property

    Public Property ButtonBackColor As Color
        Get
            Return _ButtonBackColor
        End Get
        Set(value As Color)
            _ButtonBackColor = value
            btn.BackColor = _ButtonBackColor
        End Set
    End Property

    Public Property ButtonFocusedColor As Color
        Get
            Return _ButtonFocusedColor
        End Get
        Set(value As Color)
            _ButtonFocusedColor = value
            btn.FlatAppearance.MouseOverBackColor = _ButtonFocusedColor
        End Set
    End Property

    Public Property MultilineText As Boolean
        Get
            Return _MultilineText
        End Get
        Set(value As Boolean)
            _MultilineText = value
            txt.AcceptsReturn = value
            MyBase.AcceptsReturn = value
        End Set
    End Property

    Public Property WaterMark As String
        Get
            Return _WaterMark
        End Get
        Set(value As String)
            _WaterMark = value
            If txt.Text.Length = 0 Then txt.Text = _WaterMark
        End Set
    End Property

    Private Sub PanelText_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        For Each ctrl As Control In Me.Controls
            ctrl.Dispose()
        Next
    End Sub

    Private Sub PanelText_ReadOnlyChanged(sender As Object, e As EventArgs) Handles MyBase.ReadOnlyChanged
        txt.ReadOnly = MyBase.ReadOnly
    End Sub

    Private Sub PanelText_ForeColorChanged(sender As Object, e As EventArgs) Handles Me.ForeColorChanged
        txt.ForeColor = MyBase.ForeColor
    End Sub

    Private Sub PanelText_FontChanged(sender As Object, e As EventArgs) Handles Me.FontChanged
        txt.Font = MyBase.Font
    End Sub

    Private Sub PanelText_CursorChanged(sender As Object, e As EventArgs) Handles Me.CursorChanged
        txt.Cursor = MyBase.Cursor
    End Sub

    Private Sub PanelText_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        txt.Focus()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'PanelText
        '
        Me.ResumeLayout(False)

    End Sub
End Class