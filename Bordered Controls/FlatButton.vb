Imports System.Windows.Forms
Imports System.Drawing

Public Class FlatButton
    Inherits System.Windows.Forms.Button

    Dim _ForeMouseOver As Color = Color.AliceBlue
    Dim _ImgMouseOver As Image = Nothing
    Dim _FlatBorderBottom As Boolean
    Dim _FlatBorderTop As Boolean
    Dim _FlatBorderLeft As Boolean
    Dim _FlatBorderRight As Boolean
    Dim _FlatBorderColor As Color
    Dim _FlatBorderSize As Integer = 4

    Dim defImage As Image = Nothing
    Dim defForeColor As Color
    Dim l As Label = New Label With {.Dock = DockStyle.Left, .Width = 4, .BackColor = Color.Green, .Visible = False}
    Dim r As Label = New Label With {.Dock = DockStyle.Right, .Width = 4, .BackColor = Color.Green, .Visible = False}
    Dim t As Label = New Label With {.Dock = DockStyle.Top, .Height = 4, .BackColor = Color.Green, .Visible = False}
    Dim b As Label = New Label With {.Dock = DockStyle.Bottom, .Height = 4, .BackColor = Color.Green, .Visible = False}

    Public Sub New()
        'default size
        Me.Size = New Size(100, 25)
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Controls.AddRange(New Control() {l, r, t, b})
        Me.Update()
    End Sub

    Public Property ForeMouseOver As Color
        Get
            defForeColor = Me.ForeColor
            Return _ForeMouseOver
        End Get
        Set(value As Color)
            _ForeMouseOver = value
        End Set
    End Property

    Public Property ImgMouseOver As Image
        Get
            defImage = Me.Image
            Return IIf(IsNothing(_ImgMouseOver), defImage, _ImgMouseOver)
        End Get
        Set(value As Image)
            _ImgMouseOver = value
        End Set
    End Property

#Region "FlatBordered Properties"

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
#End Region

    Private Sub FlatButton_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Me.ForeColor = ForeMouseOver
        Me.Image = ImgMouseOver
    End Sub

    Private Sub FlatButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.ForeColor = defForeColor
        Me.Image = defImage
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'FlatButton
        '
        Me.ResumeLayout(False)

    End Sub
End Class
