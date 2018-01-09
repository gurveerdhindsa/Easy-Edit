Imports System.IO

Public Class SimpleTextEditor
    'Name of file being edited
    Private fileName As String
    'Path of file being edited
    Private filePath As FileInfo

    'Loading the form...
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'File menu items
    'New document
    Private Sub FNew_Click(sender As Object, e As EventArgs) Handles FNew.Click, TNew.Click
        Document.Clear()
        Document.Enabled = True
        fileName = "*Untitled"      'Default file name: Untitled
        'Update tab to display file name
        TabPage.Text = fileName
    End Sub

    'Opening a document
    Private Sub FOpen_Click(sender As Object, e As EventArgs) Handles FOpen.Click, TOpen.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "TXT Files|*.txt"       'Set to only open .txt files
        If openFileDialog.ShowDialog = DialogResult.OK Then
            Document.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText)
        End If

        Document.Enabled = True
        filePath = New FileInfo(openFileDialog.FileName)
        fileName = filePath.Name
        TabPage.Text = fileName
    End Sub

    'Saving a file
    Private Sub FSave_Click(sender As Object, e As EventArgs) Handles FSave.Click, TSave.Click
        'File has not been saved before
        If fileName.Contains("Untitled") Then
            FSaveAs_Click(sender, e)
        Else
            Document.SaveFile(filePath.ToString, RichTextBoxStreamType.PlainText)
        End If

        fileName = fileName.Replace("*", "")
        TabPage.Text = fileName
    End Sub

    'Saving a file under a different location
    Private Sub FSaveAs_Click(sender As Object, e As EventArgs) Handles FSaveAs.Click
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "TXT Files (*.txt*)|*.txt"
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            Document.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText)
        End If

        filePath = New FileInfo(saveFileDialog.FileName)
        fileName = filePath.Name
        TabPage.Text = fileName
    End Sub

    Private Sub FPrint_Click(sender As Object, e As EventArgs) Handles FPrint.Click, TPrint.Click
        Dim printDialog As New PrintDialog
        printDialog.ShowDialog()
    End Sub

    'Exiting the text editor
    Private Sub FExit_Click(sender As Object, e As EventArgs) Handles FExit.Click
        Me.Close()
    End Sub

    'Edit menu items
    'Undo text change
    Private Sub EUndo_Click(sender As Object, e As EventArgs) Handles EUndo.Click
        Document.Undo()
    End Sub

    'Redo text change
    Private Sub ERedo_Click(sender As Object, e As EventArgs) Handles ERedo.Click
        Document.Redo()
    End Sub

    'Cut text
    Private Sub ECut_Click(sender As Object, e As EventArgs) Handles ECut.Click, TCut.Click
        Document.Cut()
    End Sub

    'Copy text
    Private Sub ECopy_Click(sender As Object, e As EventArgs) Handles ECopy.Click, TCopy.Click
        Document.Copy()
    End Sub

    'Paste text
    Private Sub EPaste_Click(sender As Object, e As EventArgs) Handles EPaste.Click, TPaste.Click
        Document.Paste()
    End Sub

    'Select all text
    Private Sub ESelectAll_Click(sender As Object, e As EventArgs) Handles ESelectAll.Click
        Document.SelectAll()
    End Sub

    'Text field
    Private Sub Document_Changed(sender As Object, e As EventArgs) Handles Document.TextChanged
        'Indicate the document has been changed if in a saved state
        If (Not TabPage.Text.Contains("*")) Then
            TabPage.Text = "*" + fileName
        End If
    End Sub
End Class
