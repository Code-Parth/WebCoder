Public Class FormWebCoder
    Private Sub Load_Editor()
        Dim EditorControlByUser As New EditerControlByUser
        With EditorControlByUser
            .Dock = DockStyle.Fill
        End With
        Dim t As New TabPage
        With t
            .Text = "Web Coder"
            .Name = "New Editor"
        End With
        t.Controls.Add(EditorControlByUser)
        Me.CodeEditorArea.Controls.Add(t)
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub
    Private Sub BtnBigSmall_Click(sender As Object, e As EventArgs) Handles BtnBigSmall.Click
        If WindowState = FormWindowState.Maximized Then
            BtnBigSmall.Image = PicMaximize.Image
            BtnBigSmall.HoverState.Image = PicMaximizeHover.Image
            WindowState = FormWindowState.Normal
            RoundCorners0.BorderRadius = 20
        ElseIf WindowState = FormWindowState.Normal Then
            BtnBigSmall.Image = PicRestoreDown.Image
            BtnBigSmall.HoverState.Image = PicRestoreDownHover.Image
            WindowState = FormWindowState.Maximized
            RoundCorners0.BorderRadius = 0
        End If
    End Sub
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub FormWebCoder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Load_Editor()
    End Sub
End Class