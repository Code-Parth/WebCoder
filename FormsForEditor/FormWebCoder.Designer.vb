<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormWebCoder
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormWebCoder))
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.AppName = New System.Windows.Forms.Label()
        Me.AppIcon = New System.Windows.Forms.PictureBox()
        Me.BtnMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnBigSmall = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Drag0 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Drag1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.RoundCorners0 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PicRestoreDownHover = New System.Windows.Forms.PictureBox()
        Me.PicRestoreDown = New System.Windows.Forms.PictureBox()
        Me.PicMaximizeHover = New System.Windows.Forms.PictureBox()
        Me.PicMaximize = New System.Windows.Forms.PictureBox()
        Me.CodeEditorArea = New System.Windows.Forms.TabControl()
        Me.TitleBarPanel.SuspendLayout()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRestoreDownHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRestoreDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMaximizeHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleBarPanel
        '
        Me.TitleBarPanel.Controls.Add(Me.AppName)
        Me.TitleBarPanel.Controls.Add(Me.AppIcon)
        Me.TitleBarPanel.Controls.Add(Me.BtnMinimize)
        Me.TitleBarPanel.Controls.Add(Me.BtnBigSmall)
        Me.TitleBarPanel.Controls.Add(Me.BtnClose)
        Me.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.TitleBarPanel.Name = "TitleBarPanel"
        Me.TitleBarPanel.Size = New System.Drawing.Size(800, 30)
        Me.TitleBarPanel.TabIndex = 1
        '
        'AppName
        '
        Me.AppName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppName.Font = New System.Drawing.Font("Cascadia Code SemiBold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AppName.ForeColor = System.Drawing.Color.White
        Me.AppName.Location = New System.Drawing.Point(30, 0)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(680, 30)
        Me.AppName.TabIndex = 4
        Me.AppName.Text = "Web Coder"
        Me.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AppIcon
        '
        Me.AppIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.AppIcon.ErrorImage = Nothing
        Me.AppIcon.Image = Global.WebCoder.My.Resources.Resources.Web_Browser
        Me.AppIcon.InitialImage = Nothing
        Me.AppIcon.Location = New System.Drawing.Point(0, 0)
        Me.AppIcon.Name = "AppIcon"
        Me.AppIcon.Size = New System.Drawing.Size(30, 30)
        Me.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppIcon.TabIndex = 3
        Me.AppIcon.TabStop = False
        '
        'BtnMinimize
        '
        Me.BtnMinimize.CheckedState.Parent = Me.BtnMinimize
        Me.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMinimize.HoverState.Image = Global.WebCoder.My.Resources.Resources.BtnMinimizeHover
        Me.BtnMinimize.HoverState.ImageSize = New System.Drawing.Size(28, 28)
        Me.BtnMinimize.HoverState.Parent = Me.BtnMinimize
        Me.BtnMinimize.Image = Global.WebCoder.My.Resources.Resources.BtnMinimize
        Me.BtnMinimize.ImageSize = New System.Drawing.Size(28, 28)
        Me.BtnMinimize.Location = New System.Drawing.Point(710, 0)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.PressedState.Parent = Me.BtnMinimize
        Me.BtnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.BtnMinimize.TabIndex = 2
        '
        'BtnBigSmall
        '
        Me.BtnBigSmall.CheckedState.Parent = Me.BtnBigSmall
        Me.BtnBigSmall.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnBigSmall.HoverState.Image = Global.WebCoder.My.Resources.Resources.BtnMaximizeHover
        Me.BtnBigSmall.HoverState.ImageSize = New System.Drawing.Size(28, 28)
        Me.BtnBigSmall.HoverState.Parent = Me.BtnBigSmall
        Me.BtnBigSmall.Image = Global.WebCoder.My.Resources.Resources.BtnMaximize
        Me.BtnBigSmall.ImageSize = New System.Drawing.Size(28, 28)
        Me.BtnBigSmall.Location = New System.Drawing.Point(740, 0)
        Me.BtnBigSmall.Name = "BtnBigSmall"
        Me.BtnBigSmall.PressedState.Parent = Me.BtnBigSmall
        Me.BtnBigSmall.Size = New System.Drawing.Size(30, 30)
        Me.BtnBigSmall.TabIndex = 1
        '
        'BtnClose
        '
        Me.BtnClose.CheckedState.Parent = Me.BtnClose
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnClose.HoverState.Image = Global.WebCoder.My.Resources.Resources.BtnCloseHover
        Me.BtnClose.HoverState.ImageSize = New System.Drawing.Size(28, 28)
        Me.BtnClose.HoverState.Parent = Me.BtnClose
        Me.BtnClose.Image = Global.WebCoder.My.Resources.Resources.BtnClose
        Me.BtnClose.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnClose.Location = New System.Drawing.Point(770, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.PressedState.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(30, 30)
        Me.BtnClose.TabIndex = 0
        '
        'Drag0
        '
        Me.Drag0.TargetControl = Me.AppIcon
        '
        'Drag1
        '
        Me.Drag1.TargetControl = Me.AppName
        '
        'RoundCorners0
        '
        Me.RoundCorners0.BorderRadius = 20
        Me.RoundCorners0.TargetControl = Me
        '
        'PicRestoreDownHover
        '
        Me.PicRestoreDownHover.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicRestoreDownHover.ErrorImage = Nothing
        Me.PicRestoreDownHover.Image = Global.WebCoder.My.Resources.Resources.BtnRestoreDownHover
        Me.PicRestoreDownHover.InitialImage = Nothing
        Me.PicRestoreDownHover.Location = New System.Drawing.Point(799, 499)
        Me.PicRestoreDownHover.Name = "PicRestoreDownHover"
        Me.PicRestoreDownHover.Size = New System.Drawing.Size(1, 1)
        Me.PicRestoreDownHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRestoreDownHover.TabIndex = 7
        Me.PicRestoreDownHover.TabStop = False
        '
        'PicRestoreDown
        '
        Me.PicRestoreDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicRestoreDown.ErrorImage = Nothing
        Me.PicRestoreDown.Image = Global.WebCoder.My.Resources.Resources.BtnRestoreDown
        Me.PicRestoreDown.InitialImage = Nothing
        Me.PicRestoreDown.Location = New System.Drawing.Point(799, 499)
        Me.PicRestoreDown.Name = "PicRestoreDown"
        Me.PicRestoreDown.Size = New System.Drawing.Size(1, 1)
        Me.PicRestoreDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRestoreDown.TabIndex = 6
        Me.PicRestoreDown.TabStop = False
        '
        'PicMaximizeHover
        '
        Me.PicMaximizeHover.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicMaximizeHover.ErrorImage = Nothing
        Me.PicMaximizeHover.Image = Global.WebCoder.My.Resources.Resources.BtnMaximizeHover
        Me.PicMaximizeHover.InitialImage = Nothing
        Me.PicMaximizeHover.Location = New System.Drawing.Point(799, 499)
        Me.PicMaximizeHover.Name = "PicMaximizeHover"
        Me.PicMaximizeHover.Size = New System.Drawing.Size(1, 1)
        Me.PicMaximizeHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMaximizeHover.TabIndex = 5
        Me.PicMaximizeHover.TabStop = False
        '
        'PicMaximize
        '
        Me.PicMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicMaximize.ErrorImage = Nothing
        Me.PicMaximize.Image = Global.WebCoder.My.Resources.Resources.BtnMaximize
        Me.PicMaximize.InitialImage = Nothing
        Me.PicMaximize.Location = New System.Drawing.Point(799, 499)
        Me.PicMaximize.Name = "PicMaximize"
        Me.PicMaximize.Size = New System.Drawing.Size(1, 1)
        Me.PicMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMaximize.TabIndex = 4
        Me.PicMaximize.TabStop = False
        '
        'CodeEditorArea
        '
        Me.CodeEditorArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeEditorArea.Location = New System.Drawing.Point(0, 30)
        Me.CodeEditorArea.Name = "CodeEditorArea"
        Me.CodeEditorArea.SelectedIndex = 0
        Me.CodeEditorArea.Size = New System.Drawing.Size(800, 470)
        Me.CodeEditorArea.TabIndex = 8
        '
        'FormWebCoder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.CodeEditorArea)
        Me.Controls.Add(Me.PicRestoreDownHover)
        Me.Controls.Add(Me.PicRestoreDown)
        Me.Controls.Add(Me.PicMaximizeHover)
        Me.Controls.Add(Me.PicMaximize)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormWebCoder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Web Coder"
        Me.TitleBarPanel.ResumeLayout(False)
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRestoreDownHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRestoreDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMaximizeHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents BtnBigSmall As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents AppIcon As PictureBox
    Friend WithEvents AppName As Label
    Friend WithEvents Drag0 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Drag1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents RoundCorners0 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PicRestoreDownHover As PictureBox
    Friend WithEvents PicRestoreDown As PictureBox
    Friend WithEvents PicMaximizeHover As PictureBox
    Friend WithEvents PicMaximize As PictureBox
    Friend WithEvents CodeEditorArea As TabControl
End Class
