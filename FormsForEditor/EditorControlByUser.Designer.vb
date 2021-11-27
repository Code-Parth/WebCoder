<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditerControlByUser
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditerControlByUser))
        Me.SettingPanel = New System.Windows.Forms.Panel()
        Me.BtnRedo = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnDelete = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnUndo = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnSelectAll = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnPaste = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnCopy = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnHtmlFile = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnWebRun = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CodeOutputRunOnWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.CodeEditorForTypeCode = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SettingPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CodeEditorForTypeCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SettingPanel
        '
        Me.SettingPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SettingPanel.Controls.Add(Me.BtnRedo)
        Me.SettingPanel.Controls.Add(Me.BtnDelete)
        Me.SettingPanel.Controls.Add(Me.BtnUndo)
        Me.SettingPanel.Controls.Add(Me.BtnSelectAll)
        Me.SettingPanel.Controls.Add(Me.BtnPaste)
        Me.SettingPanel.Controls.Add(Me.BtnCopy)
        Me.SettingPanel.Controls.Add(Me.BtnHtmlFile)
        Me.SettingPanel.Controls.Add(Me.BtnWebRun)
        Me.SettingPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SettingPanel.Location = New System.Drawing.Point(0, 0)
        Me.SettingPanel.Name = "SettingPanel"
        Me.SettingPanel.Size = New System.Drawing.Size(40, 450)
        Me.SettingPanel.TabIndex = 3
        '
        'BtnRedo
        '
        Me.BtnRedo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRedo.CheckedState.Parent = Me.BtnRedo
        Me.BtnRedo.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.BtnRedo.HoverState.Parent = Me.BtnRedo
        Me.BtnRedo.Image = Global.WebCoder.My.Resources.Resources.Redo
        Me.BtnRedo.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnRedo.Location = New System.Drawing.Point(2, 411)
        Me.BtnRedo.Name = "BtnRedo"
        Me.BtnRedo.PressedState.Parent = Me.BtnRedo
        Me.BtnRedo.Size = New System.Drawing.Size(36, 36)
        Me.BtnRedo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnRedo, "Redo")
        '
        'BtnDelete
        '
        Me.BtnDelete.CheckedState.Parent = Me.BtnDelete
        Me.BtnDelete.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.BtnDelete.HoverState.Parent = Me.BtnDelete
        Me.BtnDelete.Image = Global.WebCoder.My.Resources.Resources.Delete
        Me.BtnDelete.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnDelete.Location = New System.Drawing.Point(2, 216)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.PressedState.Parent = Me.BtnDelete
        Me.BtnDelete.Size = New System.Drawing.Size(36, 36)
        Me.BtnDelete.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnDelete, "Clear All")
        '
        'BtnUndo
        '
        Me.BtnUndo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnUndo.CheckedState.Parent = Me.BtnUndo
        Me.BtnUndo.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.BtnUndo.HoverState.Parent = Me.BtnUndo
        Me.BtnUndo.Image = Global.WebCoder.My.Resources.Resources.Undo
        Me.BtnUndo.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnUndo.Location = New System.Drawing.Point(2, 369)
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.PressedState.Parent = Me.BtnUndo
        Me.BtnUndo.Size = New System.Drawing.Size(36, 36)
        Me.BtnUndo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnUndo, "Undo")
        '
        'BtnSelectAll
        '
        Me.BtnSelectAll.CheckedState.Parent = Me.BtnSelectAll
        Me.BtnSelectAll.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.BtnSelectAll.HoverState.Parent = Me.BtnSelectAll
        Me.BtnSelectAll.Image = Global.WebCoder.My.Resources.Resources.SelectAll
        Me.BtnSelectAll.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnSelectAll.Location = New System.Drawing.Point(2, 174)
        Me.BtnSelectAll.Name = "BtnSelectAll"
        Me.BtnSelectAll.PressedState.Parent = Me.BtnSelectAll
        Me.BtnSelectAll.Size = New System.Drawing.Size(36, 36)
        Me.BtnSelectAll.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnSelectAll, "Select All")
        '
        'BtnPaste
        '
        Me.BtnPaste.CheckedState.Parent = Me.BtnPaste
        Me.BtnPaste.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.BtnPaste.HoverState.Parent = Me.BtnPaste
        Me.BtnPaste.Image = Global.WebCoder.My.Resources.Resources.Paste
        Me.BtnPaste.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnPaste.Location = New System.Drawing.Point(2, 132)
        Me.BtnPaste.Name = "BtnPaste"
        Me.BtnPaste.PressedState.Parent = Me.BtnPaste
        Me.BtnPaste.Size = New System.Drawing.Size(36, 36)
        Me.BtnPaste.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnPaste, "Paste Code")
        '
        'BtnCopy
        '
        Me.BtnCopy.CheckedState.Parent = Me.BtnCopy
        Me.BtnCopy.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.BtnCopy.HoverState.Parent = Me.BtnCopy
        Me.BtnCopy.Image = Global.WebCoder.My.Resources.Resources.Copy
        Me.BtnCopy.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnCopy.Location = New System.Drawing.Point(2, 90)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.PressedState.Parent = Me.BtnCopy
        Me.BtnCopy.Size = New System.Drawing.Size(36, 36)
        Me.BtnCopy.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnCopy, "Copy Code")
        '
        'BtnHtmlFile
        '
        Me.BtnHtmlFile.CheckedState.Parent = Me.BtnHtmlFile
        Me.BtnHtmlFile.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.BtnHtmlFile.HoverState.Parent = Me.BtnHtmlFile
        Me.BtnHtmlFile.Image = CType(resources.GetObject("BtnHtmlFile.Image"), System.Drawing.Image)
        Me.BtnHtmlFile.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnHtmlFile.Location = New System.Drawing.Point(2, 48)
        Me.BtnHtmlFile.Name = "BtnHtmlFile"
        Me.BtnHtmlFile.PressedState.Parent = Me.BtnHtmlFile
        Me.BtnHtmlFile.Size = New System.Drawing.Size(36, 36)
        Me.BtnHtmlFile.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnHtmlFile, "Show Code")
        '
        'BtnWebRun
        '
        Me.BtnWebRun.CheckedState.Parent = Me.BtnWebRun
        Me.BtnWebRun.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.BtnWebRun.HoverState.Parent = Me.BtnWebRun
        Me.BtnWebRun.Image = Global.WebCoder.My.Resources.Resources.WebSolution
        Me.BtnWebRun.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnWebRun.Location = New System.Drawing.Point(2, 6)
        Me.BtnWebRun.Name = "BtnWebRun"
        Me.BtnWebRun.PressedState.Parent = Me.BtnWebRun
        Me.BtnWebRun.Size = New System.Drawing.Size(36, 36)
        Me.BtnWebRun.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnWebRun, "Go Live")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CodeEditorForTypeCode)
        Me.Panel1.Controls.Add(Me.CodeOutputRunOnWebBrowser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(40, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 450)
        Me.Panel1.TabIndex = 6
        '
        'CodeOutputRunOnWebBrowser
        '
        Me.CodeOutputRunOnWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeOutputRunOnWebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.CodeOutputRunOnWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CodeOutputRunOnWebBrowser.Name = "CodeOutputRunOnWebBrowser"
        Me.CodeOutputRunOnWebBrowser.Size = New System.Drawing.Size(760, 450)
        Me.CodeOutputRunOnWebBrowser.TabIndex = 0
        '
        'CodeEditorForTypeCode
        '
        Me.CodeEditorForTypeCode.AutoCompleteBrackets = True
        Me.CodeEditorForTypeCode.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.CodeEditorForTypeCode.AutoScrollMinSize = New System.Drawing.Size(380, 18)
        Me.CodeEditorForTypeCode.BackBrush = Nothing
        Me.CodeEditorForTypeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CodeEditorForTypeCode.CharHeight = 18
        Me.CodeEditorForTypeCode.CharWidth = 9
        Me.CodeEditorForTypeCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CodeEditorForTypeCode.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CodeEditorForTypeCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeEditorForTypeCode.Font = New System.Drawing.Font("Cascadia Code", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.CodeEditorForTypeCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.CodeEditorForTypeCode.IndentBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CodeEditorForTypeCode.IsReplaceMode = False
        Me.CodeEditorForTypeCode.LineNumberColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.CodeEditorForTypeCode.Location = New System.Drawing.Point(0, 0)
        Me.CodeEditorForTypeCode.Name = "CodeEditorForTypeCode"
        Me.CodeEditorForTypeCode.Paddings = New System.Windows.Forms.Padding(0)
        Me.CodeEditorForTypeCode.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CodeEditorForTypeCode.ServiceColors = CType(resources.GetObject("CodeEditorForTypeCode.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.CodeEditorForTypeCode.Size = New System.Drawing.Size(760, 450)
        Me.CodeEditorForTypeCode.TabIndex = 1
        Me.CodeEditorForTypeCode.Text = "<html><body>Hello World !</body></html>"
        Me.CodeEditorForTypeCode.Zoom = 100
        '
        'EditerControlByUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SettingPanel)
        Me.Name = "EditerControlByUser"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.SettingPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.CodeEditorForTypeCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SettingPanel As Panel
    Friend WithEvents BtnWebRun As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnDelete As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnSelectAll As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnPaste As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnCopy As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnHtmlFile As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnRedo As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnUndo As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CodeEditorForTypeCode As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents CodeOutputRunOnWebBrowser As WebBrowser
    Friend WithEvents ToolTip1 As ToolTip
End Class
