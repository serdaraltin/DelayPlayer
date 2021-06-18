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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GösterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaWGUIThemeContainer1 = New Delay_Player.BaWGUIThemeContainer()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.BaWGUIButton5 = New Delay_Player.BaWGUIButton()
        Me.BaWGUIProgressBar1 = New Delay_Player.BaWGUIProgressBar()
        Me.BaWGUICheckBox2 = New Delay_Player.BaWGUICheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BaWGUICheckBox1 = New Delay_Player.BaWGUICheckBox()
        Me.BaWGUITrackBar1 = New Delay_Player.BaWGUITrackBar()
        Me.BaWGUIButton4 = New Delay_Player.BaWGUIButton()
        Me.BaWGUIButton3 = New Delay_Player.BaWGUIButton()
        Me.BaWGUIButton2 = New Delay_Player.BaWGUIButton()
        Me.BaWGUIButton1 = New Delay_Player.BaWGUIButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BaWGUICheckBox3 = New Delay_Player.BaWGUICheckBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.BaWGUIThemeContainer1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 35)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 61)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 35)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(192, 61)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Delay"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GösterToolStripMenuItem, Me.KapatToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 48)
        '
        'GösterToolStripMenuItem
        '
        Me.GösterToolStripMenuItem.Name = "GösterToolStripMenuItem"
        Me.GösterToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.GösterToolStripMenuItem.Text = "Göster"
        '
        'KapatToolStripMenuItem
        '
        Me.KapatToolStripMenuItem.Name = "KapatToolStripMenuItem"
        Me.KapatToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.KapatToolStripMenuItem.Text = "Kapat"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(92, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripMenuItem1.Text = "Çal"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripMenuItem2.Text = "Sil"
        '
        'BaWGUIThemeContainer1
        '
        Me.BaWGUIThemeContainer1.BackColor = System.Drawing.Color.White
        Me.BaWGUIThemeContainer1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton5)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIProgressBar1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUICheckBox2)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.ListBox1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUICheckBox1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUITrackBar1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton4)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton3)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton2)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label2)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUICheckBox3)
        Me.BaWGUIThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaWGUIThemeContainer1.DrawButtonStrings = True
        Me.BaWGUIThemeContainer1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BaWGUIThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.BaWGUIThemeContainer1.Name = "BaWGUIThemeContainer1"
        Me.BaWGUIThemeContainer1.Size = New System.Drawing.Size(350, 450)
        Me.BaWGUIThemeContainer1.TabIndex = 0
        Me.BaWGUIThemeContainer1.Text = "Delay"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(340, 438)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(10, 10)
        Me.AxWindowsMediaPlayer1.TabIndex = 31
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'BaWGUIButton5
        '
        Me.BaWGUIButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BaWGUIButton5.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIButton5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BaWGUIButton5.Location = New System.Drawing.Point(277, 9)
        Me.BaWGUIButton5.Name = "BaWGUIButton5"
        Me.BaWGUIButton5.Size = New System.Drawing.Size(61, 35)
        Me.BaWGUIButton5.TabIndex = 30
        Me.BaWGUIButton5.Text = "Aç"
        '
        'BaWGUIProgressBar1
        '
        Me.BaWGUIProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BaWGUIProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIProgressBar1.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.BaWGUIProgressBar1.Location = New System.Drawing.Point(7, 216)
        Me.BaWGUIProgressBar1.Maximum = 100
        Me.BaWGUIProgressBar1.MinimumSize = New System.Drawing.Size(60, 80)
        Me.BaWGUIProgressBar1.Name = "BaWGUIProgressBar1"
        Me.BaWGUIProgressBar1.Size = New System.Drawing.Size(344, 80)
        Me.BaWGUIProgressBar1.TabIndex = 28
        Me.BaWGUIProgressBar1.Text = "BaWGUIProgressBar1"
        Me.BaWGUIProgressBar1.Value = 0
        '
        'BaWGUICheckBox2
        '
        Me.BaWGUICheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BaWGUICheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUICheckBox2.Checked = True
        Me.BaWGUICheckBox2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BaWGUICheckBox2.Location = New System.Drawing.Point(12, 339)
        Me.BaWGUICheckBox2.Name = "BaWGUICheckBox2"
        Me.BaWGUICheckBox2.Size = New System.Drawing.Size(107, 26)
        Me.BaWGUICheckBox2.TabIndex = 27
        Me.BaWGUICheckBox2.Text = "Otomatik"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ListBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 58)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(326, 128)
        Me.ListBox1.TabIndex = 26
        '
        'BaWGUICheckBox1
        '
        Me.BaWGUICheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BaWGUICheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUICheckBox1.Checked = False
        Me.BaWGUICheckBox1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BaWGUICheckBox1.Location = New System.Drawing.Point(12, 307)
        Me.BaWGUICheckBox1.Name = "BaWGUICheckBox1"
        Me.BaWGUICheckBox1.Size = New System.Drawing.Size(101, 26)
        Me.BaWGUICheckBox1.TabIndex = 25
        Me.BaWGUICheckBox1.Text = "Karıştır"
        '
        'BaWGUITrackBar1
        '
        Me.BaWGUITrackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BaWGUITrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUITrackBar1.Location = New System.Drawing.Point(12, 404)
        Me.BaWGUITrackBar1.Maximum = 100
        Me.BaWGUITrackBar1.Minimum = 0
        Me.BaWGUITrackBar1.Name = "BaWGUITrackBar1"
        Me.BaWGUITrackBar1.Size = New System.Drawing.Size(326, 37)
        Me.BaWGUITrackBar1.TabIndex = 23
        Me.BaWGUITrackBar1.Text = "BaWGUITrackBar1"
        Me.BaWGUITrackBar1.Value = 0
        '
        'BaWGUIButton4
        '
        Me.BaWGUIButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BaWGUIButton4.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIButton4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BaWGUIButton4.Location = New System.Drawing.Point(222, 345)
        Me.BaWGUIButton4.Name = "BaWGUIButton4"
        Me.BaWGUIButton4.Size = New System.Drawing.Size(45, 36)
        Me.BaWGUIButton4.TabIndex = 22
        Me.BaWGUIButton4.Text = "▷ ▷"
        '
        'BaWGUIButton3
        '
        Me.BaWGUIButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BaWGUIButton3.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIButton3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BaWGUIButton3.Location = New System.Drawing.Point(120, 345)
        Me.BaWGUIButton3.Name = "BaWGUIButton3"
        Me.BaWGUIButton3.Size = New System.Drawing.Size(45, 36)
        Me.BaWGUIButton3.TabIndex = 21
        Me.BaWGUIButton3.Text = "◁ ◁"
        '
        'BaWGUIButton2
        '
        Me.BaWGUIButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BaWGUIButton2.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIButton2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BaWGUIButton2.Location = New System.Drawing.Point(171, 303)
        Me.BaWGUIButton2.Name = "BaWGUIButton2"
        Me.BaWGUIButton2.Size = New System.Drawing.Size(45, 36)
        Me.BaWGUIButton2.TabIndex = 20
        Me.BaWGUIButton2.Text = "▷"
        '
        'BaWGUIButton1
        '
        Me.BaWGUIButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BaWGUIButton1.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIButton1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BaWGUIButton1.Location = New System.Drawing.Point(171, 345)
        Me.BaWGUIButton1.Name = "BaWGUIButton1"
        Me.BaWGUIButton1.Size = New System.Drawing.Size(45, 36)
        Me.BaWGUIButton1.TabIndex = 19
        Me.BaWGUIButton1.Text = "| |"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(11, 382)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 18)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Ses Seviyesi"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(15, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 19)
        Me.Label2.TabIndex = 29
        '
        'BaWGUICheckBox3
        '
        Me.BaWGUICheckBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BaWGUICheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUICheckBox3.Checked = False
        Me.BaWGUICheckBox3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BaWGUICheckBox3.Location = New System.Drawing.Point(243, 307)
        Me.BaWGUICheckBox3.Name = "BaWGUICheckBox3"
        Me.BaWGUICheckBox3.Size = New System.Drawing.Size(107, 26)
        Me.BaWGUICheckBox3.TabIndex = 32
        Me.BaWGUICheckBox3.Text = "Sessiz"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 450)
        Me.Controls.Add(Me.BaWGUIThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Delay"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.BaWGUIThemeContainer1.ResumeLayout(False)
        Me.BaWGUIThemeContainer1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Public WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GösterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KapatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BaWGUIButton1 As Delay_Player.BaWGUIButton
    Friend WithEvents BaWGUIButton2 As Delay_Player.BaWGUIButton
    Friend WithEvents BaWGUIButton3 As Delay_Player.BaWGUIButton
    Friend WithEvents BaWGUIButton4 As Delay_Player.BaWGUIButton
    Friend WithEvents BaWGUITrackBar1 As Delay_Player.BaWGUITrackBar
    Friend WithEvents BaWGUICheckBox1 As Delay_Player.BaWGUICheckBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents BaWGUICheckBox2 As Delay_Player.BaWGUICheckBox
    Friend WithEvents BaWGUIProgressBar1 As Delay_Player.BaWGUIProgressBar
    Friend WithEvents BaWGUIButton5 As Delay_Player.BaWGUIButton
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents BaWGUIThemeContainer1 As Delay_Player.BaWGUIThemeContainer
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaWGUICheckBox3 As Delay_Player.BaWGUICheckBox

End Class
