<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelText1 = New BorderedControls.PanelText()
        Me.FlatText2 = New BorderedControls.FlatText()
        Me.FlatPanel1 = New BorderedControls.FlatPanel()
        Me.FlatButton1 = New BorderedControls.FlatButton()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(418, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(360, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 97)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(194, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(303, 180)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(209, 38)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "asd adsad sad sad sad asd sad sad sad sad ad as daasd asd "
        '
        'PanelText1
        '
        Me.PanelText1.FlatBorderBottom = True
        Me.PanelText1.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelText1.FlatBorderFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PanelText1.FlatBorderLeft = False
        Me.PanelText1.FlatBorderRight = False
        Me.PanelText1.FlatBorderSize = 4
        Me.PanelText1.FlatBorderTop = False
        Me.PanelText1.Location = New System.Drawing.Point(12, 180)
        Me.PanelText1.MultiLine = False
        Me.PanelText1.Name = "PanelText1"
        Me.PanelText1.PanelDoubleBuffer = True
        Me.PanelText1.ScrolBars = System.Windows.Forms.ScrollBars.None
        Me.PanelText1.Size = New System.Drawing.Size(285, 23)
        Me.PanelText1.TabIndex = 7
        Me.PanelText1.Text = "Hello World ! s"
        Me.PanelText1.TextPadding = New System.Windows.Forms.Padding(3)
        '
        'FlatText2
        '
        Me.FlatText2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FlatText2.FlatBorderBottom = True
        Me.FlatText2.FlatBorderColor = System.Drawing.Color.Empty
        Me.FlatText2.FlatBorderFocusedColor = System.Drawing.Color.Aqua
        Me.FlatText2.FlatBorderLeft = True
        Me.FlatText2.FlatBorderRight = True
        Me.FlatText2.FlatBorderSize = 1
        Me.FlatText2.FlatBorderTop = True
        Me.FlatText2.Location = New System.Drawing.Point(12, 12)
        Me.FlatText2.Name = "FlatText2"
        Me.FlatText2.Size = New System.Drawing.Size(118, 25)
        Me.FlatText2.TabIndex = 3
        '
        'FlatPanel1
        '
        Me.FlatPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FlatPanel1.FlatBorderBottom = False
        Me.FlatPanel1.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FlatPanel1.FlatBorderLeft = False
        Me.FlatPanel1.FlatBorderRight = False
        Me.FlatPanel1.FlatBorderSize = 4
        Me.FlatPanel1.FlatBorderTop = True
        Me.FlatPanel1.Location = New System.Drawing.Point(12, 43)
        Me.FlatPanel1.Name = "FlatPanel1"
        Me.FlatPanel1.PanelDoubleBuffer = True
        Me.FlatPanel1.Size = New System.Drawing.Size(260, 100)
        Me.FlatPanel1.TabIndex = 2
        '
        'FlatButton1
        '
        Me.FlatButton1.FlatAppearance.BorderSize = 0
        Me.FlatButton1.FlatBorderBottom = True
        Me.FlatButton1.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FlatButton1.FlatBorderLeft = True
        Me.FlatButton1.FlatBorderRight = True
        Me.FlatButton1.FlatBorderSize = 2
        Me.FlatButton1.FlatBorderTop = True
        Me.FlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatButton1.ForeMouseOver = System.Drawing.Color.AliceBlue
        Me.FlatButton1.ImgMouseOver = Nothing
        Me.FlatButton1.Location = New System.Drawing.Point(12, 149)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Size = New System.Drawing.Size(136, 25)
        Me.FlatButton1.TabIndex = 1
        Me.FlatButton1.Text = "FlatButton1"
        Me.FlatButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 262)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelText1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FlatText2)
        Me.Controls.Add(Me.FlatPanel1)
        Me.Controls.Add(Me.FlatButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlatButton1 As BorderedControls.FlatButton
    Friend WithEvents FlatPanel1 As BorderedControls.FlatPanel
    Friend WithEvents FlatText2 As BorderedControls.FlatText
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelText1 As BorderedControls.PanelText
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
