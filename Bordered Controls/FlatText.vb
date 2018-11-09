Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices

Public Class FlatText
    Inherits TextBox

    Dim _FlatBorderBottom As Boolean
    Dim _FlatBorderTop As Boolean
    Dim _FlatBorderLeft As Boolean
    Dim _FlatBorderRight As Boolean
    Dim _FlatBorderColor As Color
    Dim _FlatBorderSize As Integer = 1
    Dim _FlatBorderFocusedColor As Color

    Dim l As Label = New Label With {.Dock = DockStyle.Left, .Width = 1, .BackColor = Color.Green, .Visible = False}
    Dim r As Label = New Label With {.Dock = DockStyle.Right, .Width = 1, .BackColor = Color.Green, .Visible = False}
    Dim t As Label = New Label With {.Dock = DockStyle.Top, .Height = 1, .BackColor = Color.Green, .Visible = False}
    Dim b As Label = New Label With {.Dock = DockStyle.Bottom, .Height = 1, .BackColor = Color.Green, .Visible = False}

    Private Const EM_SETMARGINS As Integer = &HD3
    Private Const EC_RIGHTMARGIN As Integer = 2
    Private Const EC_LEFTMARGIN As Integer = 1
    Private p As Integer = 10
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr

    End Function
    Public Sub New()
        Me.Size = New Size(100, 22)
        Me.BorderStyle = BorderStyle.None
        AutoSize = False 'allow to resizing controls
        Me.Padding = New Padding(3)
        Controls.AddRange(New Control() {l, r, t, b})
        Me.Update()
    End Sub

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        setMargin()
    End Sub

    Private Sub setMargin()
        'SendMessage(Handle, EM_SETMARGINS, EC_RIGHTMARGIN, p << 16)
        SendMessage(Handle, EM_SETMARGINS, EC_LEFTMARGIN, p)
    End Sub

#Region "FlatBordered Properties"
    Public Property FlatBorderSize As Integer
        Get
            Return _FlatBorderSize
        End Get
        Set(value As Integer)
            _FlatBorderSize = value
            Me.Padding = New Padding(_FlatBorderSize + 3)
            l.Width = _FlatBorderSize
            r.Width = _FlatBorderSize
            t.Height = _FlatBorderSize
            b.Height = _FlatBorderSize
        End Set
    End Property

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
            r.Visible = _FlatBorderLeft
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

    Public Property FlatBorderFocusedColor As Color
        Get
            Return _FlatBorderFocusedColor
        End Get
        Set(value As Color)
            _FlatBorderFocusedColor = value
        End Set
    End Property
#End Region

#Region "Events"

    Private Sub FlatText_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        l.BackColor = _FlatBorderFocusedColor
        r.BackColor = _FlatBorderFocusedColor
        t.BackColor = _FlatBorderFocusedColor
        b.BackColor = _FlatBorderFocusedColor
    End Sub

    Private Sub FlatText_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        l.BackColor = _FlatBorderColor
        r.BackColor = _FlatBorderColor
        t.BackColor = _FlatBorderColor
        b.BackColor = _FlatBorderColor
    End Sub
#End Region
End Class
