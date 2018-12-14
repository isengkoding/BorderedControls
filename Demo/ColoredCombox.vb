Imports System.Drawing.Drawing2D

Public Class ColoredCombo
    Inherits ComboBox

    Private Const WM_PAINT As Integer = &HF
    Private buttonWidth As Integer = SystemInformation.HorizontalScrollBarArrowWidth
    Enum States
        Normal
        Focused
    End Enum
    Dim iStat As States = States.Normal
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        If m.Msg = WM_PAINT Then

            Using g = Graphics.FromHwnd(Handle)
                Dim clr As Color
                If iStat = States.Normal Then
                    clr = Color.Silver
                ElseIf iStat = States.Focused Then
                    clr = Color.FromArgb(0, 0, 128)
                End If
                Using p = New Pen(clr)
                    Dim ButtonRect As Rectangle
                    If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                        ButtonRect = New Rectangle(Me.Width - 18, 1, 17, Me.Height - 2)
                    Else
                        ButtonRect = New Rectangle(1, 1, 17, Me.Height - 2)
                    End If
                    g.DrawRectangle(p, 0, 0, Width - 1, Height - 1)

                    'draw button
                    Dim BtnBrush As Brush
                    If iStat = States.Focused Then
                        BtnBrush = New LinearGradientBrush(ButtonRect, Color.FromArgb(255, 242, 200), Color.FromArgb(255, 210, 148), LinearGradientMode.Vertical)
                    Else
                        BtnBrush = New LinearGradientBrush(ButtonRect, Color.FromArgb(214, 232, 253), Color.FromArgb(156, 189, 235), LinearGradientMode.Vertical)
                    End If
                    g.FillRectangle(BtnBrush, ButtonRect)
                    g.DrawLine(p, Width - buttonWidth - 1, 0, Width - buttonWidth - 1, Height)

                    'draw arrow
                    Dim VerticalMiddle As Integer
                    Dim pntArrow(2) As PointF
                    Dim arrowBrush As Brush = New SolidBrush(Color.Black)
                    VerticalMiddle = CInt(Me.Height / 2)
                    If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                        pntArrow(0) = New PointF(Me.Width - 11, VerticalMiddle - 1)
                        pntArrow(1) = New PointF(Me.Width - 9, VerticalMiddle + 2)
                        pntArrow(2) = New PointF(Me.Width - 6, VerticalMiddle - 1)
                    Else
                        pntArrow(0) = New PointF(7, VerticalMiddle - 1)
                        pntArrow(1) = New PointF(9, VerticalMiddle + 2)
                        pntArrow(2) = New PointF(12, VerticalMiddle - 1)
                    End If
                    g.FillPolygon(arrowBrush, pntArrow)
                End Using
            End Using

        End If
    End Sub

    Private Sub ColoredCombo_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        iStat = States.Normal
    End Sub

    Private Sub ColoredCombo_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        iStat = States.Focused
    End Sub

    Private Sub ColoredCombo_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        iStat = States.Normal
    End Sub

    Private Sub ColoredCombo_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        iStat = States.Focused
    End Sub

    Private Sub ColoredCombo_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        iStat = States.Focused
    End Sub
End Class
