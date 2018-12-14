<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.FlatPanel1 = New BorderedControls.FlatPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatPanel2 = New BorderedControls.FlatPanel()
        Me.cmdMinimizeWindow = New System.Windows.Forms.Button()
        Me.cmdMaximize = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.FlatPanel1.SuspendLayout()
        Me.FlatPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlatPanel1
        '
        Me.FlatPanel1.Controls.Add(Me.FlatPanel2)
        Me.FlatPanel1.Controls.Add(Me.Panel1)
        Me.FlatPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlatPanel1.FlatBorderBottom = True
        Me.FlatPanel1.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FlatPanel1.FlatBorderLeft = True
        Me.FlatPanel1.FlatBorderRight = True
        Me.FlatPanel1.FlatBorderSize = 1
        Me.FlatPanel1.FlatBorderTop = True
        Me.FlatPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlatPanel1.Name = "FlatPanel1"
        Me.FlatPanel1.PanelDoubleBuffer = True
        Me.FlatPanel1.Size = New System.Drawing.Size(570, 430)
        Me.FlatPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 3)
        Me.Panel1.TabIndex = 4
        '
        'FlatPanel2
        '
        Me.FlatPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FlatPanel2.Controls.Add(Me.cmdMinimizeWindow)
        Me.FlatPanel2.Controls.Add(Me.cmdMaximize)
        Me.FlatPanel2.Controls.Add(Me.cmdClose)
        Me.FlatPanel2.Controls.Add(Me.lblTitle)
        Me.FlatPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlatPanel2.FlatBorderBottom = False
        Me.FlatPanel2.FlatBorderColor = System.Drawing.Color.Empty
        Me.FlatPanel2.FlatBorderLeft = False
        Me.FlatPanel2.FlatBorderRight = False
        Me.FlatPanel2.FlatBorderSize = 4
        Me.FlatPanel2.FlatBorderTop = False
        Me.FlatPanel2.Location = New System.Drawing.Point(1, 4)
        Me.FlatPanel2.Name = "FlatPanel2"
        Me.FlatPanel2.PanelDoubleBuffer = True
        Me.FlatPanel2.Size = New System.Drawing.Size(568, 28)
        Me.FlatPanel2.TabIndex = 5
        '
        'cmdMinimizeWindow
        '
        Me.cmdMinimizeWindow.BackColor = System.Drawing.Color.Transparent
        Me.cmdMinimizeWindow.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdMinimizeWindow.FlatAppearance.BorderSize = 0
        Me.cmdMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMinimizeWindow.Image = CType(resources.GetObject("cmdMinimizeWindow.Image"), System.Drawing.Image)
        Me.cmdMinimizeWindow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdMinimizeWindow.Location = New System.Drawing.Point(463, 0)
        Me.cmdMinimizeWindow.Name = "cmdMinimizeWindow"
        Me.cmdMinimizeWindow.Size = New System.Drawing.Size(35, 28)
        Me.cmdMinimizeWindow.TabIndex = 10
        Me.cmdMinimizeWindow.TabStop = False
        Me.cmdMinimizeWindow.UseVisualStyleBackColor = False
        '
        'cmdMaximize
        '
        Me.cmdMaximize.BackColor = System.Drawing.Color.Transparent
        Me.cmdMaximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdMaximize.FlatAppearance.BorderSize = 0
        Me.cmdMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMaximize.Image = CType(resources.GetObject("cmdMaximize.Image"), System.Drawing.Image)
        Me.cmdMaximize.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdMaximize.Location = New System.Drawing.Point(498, 0)
        Me.cmdMaximize.Name = "cmdMaximize"
        Me.cmdMaximize.Size = New System.Drawing.Size(35, 28)
        Me.cmdMaximize.TabIndex = 9
        Me.cmdMaximize.TabStop = False
        Me.cmdMaximize.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClose.FlatAppearance.BorderSize = 0
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(533, 0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(35, 28)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.TabStop = False
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(568, 28)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "..:: ZSoft Attendance - Simple Payroll && SMS Attendance ::.."
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 430)
        Me.Controls.Add(Me.FlatPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.FlatPanel1.ResumeLayout(False)
        Me.FlatPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlatPanel1 As BorderedControls.FlatPanel
    Friend WithEvents FlatPanel2 As BorderedControls.FlatPanel
    Public WithEvents cmdMinimizeWindow As Button
    Public WithEvents cmdMaximize As Button
    Public WithEvents cmdClose As Button
    Friend WithEvents Panel1 As Panel
    Public WithEvents lblTitle As Label
End Class
