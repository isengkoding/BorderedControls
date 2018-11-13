<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ExTextBox1 = New Demo.ExTextBox()
        Me.FlatButton2 = New BorderedControls.FlatButton()
        Me.PanelText4 = New BorderedControls.PanelText()
        Me.PanelText3 = New BorderedControls.PanelText()
        Me.PanelText2 = New BorderedControls.PanelText()
        Me.PanelText1 = New BorderedControls.PanelText()
        Me.FlatButton1 = New BorderedControls.FlatButton()
        Me.FlatPanel1 = New BorderedControls.FlatPanel()
        Me.btnHandle = New System.Windows.Forms.Button()
        Me.FlatPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(279, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.Location = New System.Drawing.Point(279, 178)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(260, 76)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = "Normal Text"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(279, 258)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.Text = "Disabled text"
        '
        'ExTextBox1
        '
        Me.ExTextBox1.Hint = "Hello World"
        Me.ExTextBox1.Location = New System.Drawing.Point(385, 150)
        Me.ExTextBox1.Name = "ExTextBox1"
        Me.ExTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.ExTextBox1.TabIndex = 16
        '
        'FlatButton2
        '
        Me.FlatButton2.FlatAppearance.BorderSize = 0
        Me.FlatButton2.FlatBorderBottom = True
        Me.FlatButton2.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FlatButton2.FlatBorderLeft = False
        Me.FlatButton2.FlatBorderRight = False
        Me.FlatButton2.FlatBorderSize = 2
        Me.FlatButton2.FlatBorderTop = False
        Me.FlatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatButton2.ForeMouseOver = System.Drawing.Color.AliceBlue
        Me.FlatButton2.ImgMouseOver = Nothing
        Me.FlatButton2.Location = New System.Drawing.Point(142, 117)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Size = New System.Drawing.Size(131, 25)
        Me.FlatButton2.TabIndex = 15
        Me.FlatButton2.Text = "FlatButton2"
        Me.FlatButton2.UseVisualStyleBackColor = True
        '
        'PanelText4
        '
        Me.PanelText4.BackColor = System.Drawing.Color.White
        Me.PanelText4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PanelText4.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelText4.ButtonFocusedColor = System.Drawing.Color.AliceBlue
        Me.PanelText4.ButtonImg = CType(resources.GetObject("PanelText4.ButtonImg"), System.Drawing.Image)
        Me.PanelText4.ButtonTxt = Nothing
        Me.PanelText4.ButtonWidth = 25
        Me.PanelText4.FlatBorderBottom = True
        Me.PanelText4.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelText4.FlatBorderFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PanelText4.FlatBorderLeft = False
        Me.PanelText4.FlatBorderRight = False
        Me.PanelText4.FlatBorderSize = 2
        Me.PanelText4.FlatBorderTop = False
        Me.PanelText4.FocusedBackColor = System.Drawing.Color.White
        Me.PanelText4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelText4.Location = New System.Drawing.Point(279, 117)
        Me.PanelText4.Multiline = True
        Me.PanelText4.MultilineText = False
        Me.PanelText4.Name = "PanelText4"
        Me.PanelText4.PanelDoubleBuffer = True
        Me.PanelText4.ShowButton = True
        Me.PanelText4.ShowClrButton = True
        Me.PanelText4.Size = New System.Drawing.Size(261, 25)
        Me.PanelText4.TabIndex = 14
        Me.PanelText4.TextPadding = New System.Windows.Forms.Padding(3)
        Me.PanelText4.WaterMark = "Hello World"
        '
        'PanelText3
        '
        Me.PanelText3.AcceptsReturn = True
        Me.PanelText3.BackColor = System.Drawing.Color.White
        Me.PanelText3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PanelText3.ButtonBackColor = System.Drawing.Color.Cyan
        Me.PanelText3.ButtonFocusedColor = System.Drawing.Color.DodgerBlue
        Me.PanelText3.ButtonImg = CType(resources.GetObject("PanelText3.ButtonImg"), System.Drawing.Image)
        Me.PanelText3.ButtonTxt = ""
        Me.PanelText3.ButtonWidth = 25
        Me.PanelText3.FlatBorderBottom = True
        Me.PanelText3.FlatBorderColor = System.Drawing.Color.Silver
        Me.PanelText3.FlatBorderFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PanelText3.FlatBorderLeft = True
        Me.PanelText3.FlatBorderRight = True
        Me.PanelText3.FlatBorderSize = 1
        Me.PanelText3.FlatBorderTop = True
        Me.PanelText3.FocusedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelText3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelText3.Location = New System.Drawing.Point(13, 176)
        Me.PanelText3.Multiline = True
        Me.PanelText3.MultilineText = True
        Me.PanelText3.Name = "PanelText3"
        Me.PanelText3.PanelDoubleBuffer = True
        Me.PanelText3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.PanelText3.ShowButton = True
        Me.PanelText3.ShowClrButton = True
        Me.PanelText3.Size = New System.Drawing.Size(260, 78)
        Me.PanelText3.TabIndex = 11
        Me.PanelText3.Text = "Hello World ! This is my text with multiline text created based on messed up logi" &
    "c and codes"
        Me.PanelText3.TextPadding = New System.Windows.Forms.Padding(3)
        Me.PanelText3.WaterMark = Nothing
        '
        'PanelText2
        '
        Me.PanelText2.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelText2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PanelText2.ButtonBackColor = System.Drawing.Color.DodgerBlue
        Me.PanelText2.ButtonFocusedColor = System.Drawing.Color.AliceBlue
        Me.PanelText2.ButtonImg = Nothing
        Me.PanelText2.ButtonTxt = Nothing
        Me.PanelText2.ButtonWidth = 25
        Me.PanelText2.Enabled = False
        Me.PanelText2.FlatBorderBottom = True
        Me.PanelText2.FlatBorderColor = System.Drawing.Color.Silver
        Me.PanelText2.FlatBorderFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PanelText2.FlatBorderLeft = True
        Me.PanelText2.FlatBorderRight = True
        Me.PanelText2.FlatBorderSize = 1
        Me.PanelText2.FlatBorderTop = True
        Me.PanelText2.FocusedBackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelText2.Location = New System.Drawing.Point(13, 258)
        Me.PanelText2.Multiline = True
        Me.PanelText2.MultilineText = False
        Me.PanelText2.Name = "PanelText2"
        Me.PanelText2.PanelDoubleBuffer = True
        Me.PanelText2.ShowButton = True
        Me.PanelText2.ShowClrButton = True
        Me.PanelText2.Size = New System.Drawing.Size(260, 22)
        Me.PanelText2.TabIndex = 10
        Me.PanelText2.TextPadding = New System.Windows.Forms.Padding(3)
        Me.PanelText2.WaterMark = Nothing
        '
        'PanelText1
        '
        Me.PanelText1.BackColor = System.Drawing.Color.Blue
        Me.PanelText1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PanelText1.ButtonBackColor = System.Drawing.Color.Cyan
        Me.PanelText1.ButtonFocusedColor = System.Drawing.Color.DodgerBlue
        Me.PanelText1.ButtonImg = CType(resources.GetObject("PanelText1.ButtonImg"), System.Drawing.Image)
        Me.PanelText1.ButtonTxt = ""
        Me.PanelText1.ButtonWidth = 25
        Me.PanelText1.FlatBorderBottom = True
        Me.PanelText1.FlatBorderColor = System.Drawing.Color.Silver
        Me.PanelText1.FlatBorderFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PanelText1.FlatBorderLeft = True
        Me.PanelText1.FlatBorderRight = True
        Me.PanelText1.FlatBorderSize = 1
        Me.PanelText1.FlatBorderTop = True
        Me.PanelText1.FocusedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelText1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelText1.ForeColor = System.Drawing.SystemColors.Window
        Me.PanelText1.Location = New System.Drawing.Point(13, 148)
        Me.PanelText1.Multiline = True
        Me.PanelText1.MultilineText = False
        Me.PanelText1.Name = "PanelText1"
        Me.PanelText1.PanelDoubleBuffer = True
        Me.PanelText1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.PanelText1.ShowButton = True
        Me.PanelText1.ShowClrButton = True
        Me.PanelText1.Size = New System.Drawing.Size(260, 22)
        Me.PanelText1.TabIndex = 7
        Me.PanelText1.Text = "Tet"
        Me.PanelText1.TextPadding = New System.Windows.Forms.Padding(3)
        Me.PanelText1.WaterMark = Nothing
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
        Me.FlatButton1.Location = New System.Drawing.Point(13, 117)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Size = New System.Drawing.Size(123, 25)
        Me.FlatButton1.TabIndex = 1
        Me.FlatButton1.Text = "FlatButton1"
        Me.FlatButton1.UseVisualStyleBackColor = True
        '
        'FlatPanel1
        '
        Me.FlatPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FlatPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlatPanel1.Controls.Add(Me.btnHandle)
        Me.FlatPanel1.FlatBorderBottom = False
        Me.FlatPanel1.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FlatPanel1.FlatBorderLeft = False
        Me.FlatPanel1.FlatBorderRight = False
        Me.FlatPanel1.FlatBorderSize = 4
        Me.FlatPanel1.FlatBorderTop = True
        Me.FlatPanel1.Location = New System.Drawing.Point(13, 12)
        Me.FlatPanel1.Name = "FlatPanel1"
        Me.FlatPanel1.PanelDoubleBuffer = True
        Me.FlatPanel1.Size = New System.Drawing.Size(526, 100)
        Me.FlatPanel1.TabIndex = 2
        '
        'btnHandle
        '
        Me.btnHandle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHandle.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHandle.Location = New System.Drawing.Point(0, 4)
        Me.btnHandle.Name = "btnHandle"
        Me.btnHandle.Size = New System.Drawing.Size(524, 25)
        Me.btnHandle.TabIndex = 12
        Me.btnHandle.Text = "Button2"
        Me.btnHandle.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(550, 288)
        Me.Controls.Add(Me.ExTextBox1)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.PanelText4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PanelText3)
        Me.Controls.Add(Me.PanelText2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PanelText1)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.FlatPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.FlatPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlatButton1 As BorderedControls.FlatButton
    Friend WithEvents FlatPanel1 As BorderedControls.FlatPanel
    Friend WithEvents PanelText1 As BorderedControls.PanelText
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PanelText2 As BorderedControls.PanelText
    Friend WithEvents PanelText3 As BorderedControls.PanelText
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PanelText4 As BorderedControls.PanelText
    Friend WithEvents btnHandle As Button
    Friend WithEvents FlatButton2 As BorderedControls.FlatButton
    Friend WithEvents ExTextBox1 As ExTextBox
End Class
