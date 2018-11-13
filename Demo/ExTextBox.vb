Imports System.Drawing
Imports System.Windows.Forms

Public Class ExTextBox
    Inherits TextBox

    Private _Hint As String

    Public Property Hint As String
        Get
            Return _Hint
        End Get
        Set(ByVal value As String)
            _Hint = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = &HF Then
            If Not Me.Focused AndAlso String.IsNullOrEmpty(Me.Text) AndAlso Not String.IsNullOrEmpty(Me.Hint) Then
                Using g = Me.CreateGraphics()
                    TextRenderer.DrawText(g, Me.Hint, Me.Font, Me.ClientRectangle, SystemColors.GrayText, Me.BackColor, TextFormatFlags.Top Or TextFormatFlags.Left)
                End Using
            End If
        End If
    End Sub
End Class
