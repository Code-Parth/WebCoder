Public Class EditerControlByUser
    Private Sub BtnWebRun_Click(sender As Object, e As EventArgs) Handles BtnWebRun.Click
        If CodeEditorForTypeCode.Visible = True Then
            CodeEditorForTypeCode.Visible = False
            CodeOutputRunOnWebBrowser.Visible = True
            CodeOutputRunOnWebBrowser.DocumentText = CodeEditorForTypeCode.Text
        Else
            CodeEditorForTypeCode.Visible = True
            CodeOutputRunOnWebBrowser.Visible = False
        End If
    End Sub
    Private Sub BtnHtmlFile_Click(sender As Object, e As EventArgs) Handles BtnHtmlFile.Click
        If CodeOutputRunOnWebBrowser.Visible = True Then
            CodeEditorForTypeCode.Visible = True
            CodeOutputRunOnWebBrowser.Visible = False
        Else
            CodeEditorForTypeCode.Visible = True
            CodeOutputRunOnWebBrowser.Visible = False
        End If
    End Sub
    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        CodeEditorForTypeCode.Copy()
    End Sub
    Private Sub BtnPaste_Click(sender As Object, e As EventArgs) Handles BtnPaste.Click
        CodeEditorForTypeCode.Paste()
    End Sub
    Private Sub BtnSelectAll_Click(sender As Object, e As EventArgs) Handles BtnSelectAll.Click
        CodeEditorForTypeCode.SelectAll()
    End Sub
    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        CodeEditorForTypeCode.Undo()
    End Sub
    Private Sub BtnRedo_Click(sender As Object, e As EventArgs) Handles BtnRedo.Click
        CodeEditorForTypeCode.Redo()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        CodeEditorForTypeCode.Clear()
    End Sub
End Class