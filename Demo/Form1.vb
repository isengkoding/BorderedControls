Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelText1_Paint(sender As Object, e As PaintEventArgs) Handles PanelText1.Paint

    End Sub

    Private Sub PanelText1_TextChanged(sender As Object, e As EventArgs) Handles PanelText1.TextChanged
        Me.Text = PanelText1.Text
    End Sub

    Private Sub PanelText1_ButtonClick(sender As Object, e As EventArgs) Handles PanelText1.ButtonClick
        MsgBox("clicked")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnHandle.Click

    End Sub

    Private Sub PanelText1_GotFocus(sender As Object, e As EventArgs) Handles PanelText1.GotFocus
        FlatButton1.Text = "Focused"
    End Sub

    Private Sub PanelText1_LostFocus(sender As Object, e As EventArgs) Handles PanelText1.LostFocus
        FlatButton1.Text = "Lost Focused"
    End Sub

    Private Sub PanelText1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PanelText1.KeyPress

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox2.PreviewKeyDown

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyUp
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PanelText1_KeyDown(sender As Object, e As KeyEventArgs) Handles PanelText1.KeyDown
        If e.KeyCode = Keys.Return Then MsgBox("Entered")
    End Sub

    Private Sub PanelText4_TextChanged(sender As Object, e As EventArgs) Handles PanelText4.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Paint(sender As Object, e As PaintEventArgs) Handles TextBox1.Paint

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If TextBox1.Text = "" Then
            TextBox1.CreateGraphics.DrawString("Enter Text Here", TextBox1.Font, New SolidBrush(Color.Blue), 0, 0)
        End If
    End Sub

    Private Sub PanelText4_ButtonClick(sender As Object, e As EventArgs) Handles PanelText4.ButtonClick
        Me.Text = PanelText4.Text
    End Sub
End Class
