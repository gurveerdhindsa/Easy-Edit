<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleTextEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimpleTextEditor))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.FSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.FSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ERedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ECut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ECopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.EPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ESelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolBar = New System.Windows.Forms.ToolStrip()
        Me.TNew = New System.Windows.Forms.ToolStripButton()
        Me.TOpen = New System.Windows.Forms.ToolStripButton()
        Me.TSave = New System.Windows.Forms.ToolStripButton()
        Me.TPrint = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TCut = New System.Windows.Forms.ToolStripButton()
        Me.TCopy = New System.Windows.Forms.ToolStripButton()
        Me.TPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileTab = New System.Windows.Forms.TabControl()
        Me.TabPage = New System.Windows.Forms.TabPage()
        Me.Document = New System.Windows.Forms.RichTextBox()
        Me.menuBar.SuspendLayout()
        Me.toolBar.SuspendLayout()
        Me.FileTab.SuspendLayout()
        Me.TabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'menuBar
        '
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.menuBar.Location = New System.Drawing.Point(0, 0)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(571, 24)
        Me.menuBar.TabIndex = 2
        Me.menuBar.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FNew, Me.FOpen, Me.toolStripSeparator, Me.FSave, Me.FSaveAs, Me.toolStripSeparator1, Me.FPrint, Me.toolStripSeparator2, Me.FExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'FNew
        '
        Me.FNew.Image = CType(resources.GetObject("FNew.Image"), System.Drawing.Image)
        Me.FNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FNew.Name = "FNew"
        Me.FNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.FNew.Size = New System.Drawing.Size(146, 22)
        Me.FNew.Text = "&New"
        '
        'FOpen
        '
        Me.FOpen.Image = CType(resources.GetObject("FOpen.Image"), System.Drawing.Image)
        Me.FOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FOpen.Name = "FOpen"
        Me.FOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.FOpen.Size = New System.Drawing.Size(146, 22)
        Me.FOpen.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
        '
        'FSave
        '
        Me.FSave.Image = CType(resources.GetObject("FSave.Image"), System.Drawing.Image)
        Me.FSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FSave.Name = "FSave"
        Me.FSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.FSave.Size = New System.Drawing.Size(146, 22)
        Me.FSave.Text = "&Save"
        '
        'FSaveAs
        '
        Me.FSaveAs.Name = "FSaveAs"
        Me.FSaveAs.Size = New System.Drawing.Size(146, 22)
        Me.FSaveAs.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'FPrint
        '
        Me.FPrint.Image = CType(resources.GetObject("FPrint.Image"), System.Drawing.Image)
        Me.FPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FPrint.Name = "FPrint"
        Me.FPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.FPrint.Size = New System.Drawing.Size(146, 22)
        Me.FPrint.Text = "&Print"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'FExit
        '
        Me.FExit.BackColor = System.Drawing.SystemColors.Control
        Me.FExit.Name = "FExit"
        Me.FExit.Size = New System.Drawing.Size(146, 22)
        Me.FExit.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EUndo, Me.ERedo, Me.toolStripSeparator3, Me.ECut, Me.ECopy, Me.EPaste, Me.toolStripSeparator4, Me.ESelectAll})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'EUndo
        '
        Me.EUndo.Name = "EUndo"
        Me.EUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.EUndo.Size = New System.Drawing.Size(144, 22)
        Me.EUndo.Text = "&Undo"
        '
        'ERedo
        '
        Me.ERedo.Name = "ERedo"
        Me.ERedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.ERedo.Size = New System.Drawing.Size(144, 22)
        Me.ERedo.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'ECut
        '
        Me.ECut.Image = CType(resources.GetObject("ECut.Image"), System.Drawing.Image)
        Me.ECut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ECut.Name = "ECut"
        Me.ECut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ECut.Size = New System.Drawing.Size(144, 22)
        Me.ECut.Text = "Cu&t"
        '
        'ECopy
        '
        Me.ECopy.Image = CType(resources.GetObject("ECopy.Image"), System.Drawing.Image)
        Me.ECopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ECopy.Name = "ECopy"
        Me.ECopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ECopy.Size = New System.Drawing.Size(144, 22)
        Me.ECopy.Text = "&Copy"
        '
        'EPaste
        '
        Me.EPaste.Image = CType(resources.GetObject("EPaste.Image"), System.Drawing.Image)
        Me.EPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EPaste.Name = "EPaste"
        Me.EPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EPaste.Size = New System.Drawing.Size(144, 22)
        Me.EPaste.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        'ESelectAll
        '
        Me.ESelectAll.Name = "ESelectAll"
        Me.ESelectAll.Size = New System.Drawing.Size(144, 22)
        Me.ESelectAll.Text = "Select &All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'toolBar
        '
        Me.toolBar.BackColor = System.Drawing.SystemColors.Control
        Me.toolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TNew, Me.TOpen, Me.TSave, Me.TPrint, Me.toolStripSeparator5, Me.TCut, Me.TCopy, Me.TPaste, Me.toolStripSeparator6})
        Me.toolBar.Location = New System.Drawing.Point(0, 24)
        Me.toolBar.Name = "toolBar"
        Me.toolBar.Size = New System.Drawing.Size(571, 25)
        Me.toolBar.TabIndex = 4
        Me.toolBar.Text = "ToolStrip1"
        '
        'TNew
        '
        Me.TNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TNew.Image = CType(resources.GetObject("TNew.Image"), System.Drawing.Image)
        Me.TNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TNew.Name = "TNew"
        Me.TNew.Size = New System.Drawing.Size(23, 22)
        Me.TNew.Text = "&New"
        '
        'TOpen
        '
        Me.TOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TOpen.Image = CType(resources.GetObject("TOpen.Image"), System.Drawing.Image)
        Me.TOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TOpen.Name = "TOpen"
        Me.TOpen.Size = New System.Drawing.Size(23, 22)
        Me.TOpen.Text = "&Open"
        '
        'TSave
        '
        Me.TSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSave.Image = CType(resources.GetObject("TSave.Image"), System.Drawing.Image)
        Me.TSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSave.Name = "TSave"
        Me.TSave.Size = New System.Drawing.Size(23, 22)
        Me.TSave.Text = "&Save"
        '
        'TPrint
        '
        Me.TPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TPrint.Image = CType(resources.GetObject("TPrint.Image"), System.Drawing.Image)
        Me.TPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TPrint.Name = "TPrint"
        Me.TPrint.Size = New System.Drawing.Size(23, 22)
        Me.TPrint.Text = "&Print"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'TCut
        '
        Me.TCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TCut.Image = CType(resources.GetObject("TCut.Image"), System.Drawing.Image)
        Me.TCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TCut.Name = "TCut"
        Me.TCut.Size = New System.Drawing.Size(23, 22)
        Me.TCut.Text = "C&ut"
        '
        'TCopy
        '
        Me.TCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TCopy.Image = CType(resources.GetObject("TCopy.Image"), System.Drawing.Image)
        Me.TCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TCopy.Name = "TCopy"
        Me.TCopy.Size = New System.Drawing.Size(23, 22)
        Me.TCopy.Text = "&Copy"
        '
        'TPaste
        '
        Me.TPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TPaste.Image = CType(resources.GetObject("TPaste.Image"), System.Drawing.Image)
        Me.TPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TPaste.Name = "TPaste"
        Me.TPaste.Size = New System.Drawing.Size(23, 22)
        Me.TPaste.Text = "&Paste"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'FileTab
        '
        Me.FileTab.Controls.Add(Me.TabPage)
        Me.FileTab.Location = New System.Drawing.Point(12, 52)
        Me.FileTab.Name = "FileTab"
        Me.FileTab.SelectedIndex = 0
        Me.FileTab.Size = New System.Drawing.Size(547, 452)
        Me.FileTab.TabIndex = 5
        '
        'TabPage
        '
        Me.TabPage.Controls.Add(Me.Document)
        Me.TabPage.Location = New System.Drawing.Point(4, 22)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage.Size = New System.Drawing.Size(539, 426)
        Me.TabPage.TabIndex = 0
        Me.TabPage.UseVisualStyleBackColor = True
        '
        'Document
        '
        Me.Document.BackColor = System.Drawing.SystemColors.Window
        Me.Document.Enabled = False
        Me.Document.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Document.Location = New System.Drawing.Point(0, 0)
        Me.Document.Name = "Document"
        Me.Document.Size = New System.Drawing.Size(539, 426)
        Me.Document.TabIndex = 0
        Me.Document.Text = ""
        '
        'SimpleTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(571, 532)
        Me.Controls.Add(Me.FileTab)
        Me.Controls.Add(Me.toolBar)
        Me.Controls.Add(Me.menuBar)
        Me.Name = "SimpleTextEditor"
        Me.Text = "Simple Text Editor"
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.toolBar.ResumeLayout(False)
        Me.toolBar.PerformLayout()
        Me.FileTab.ResumeLayout(False)
        Me.TabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents menuBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FNew As ToolStripMenuItem
    Friend WithEvents FOpen As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents FSave As ToolStripMenuItem
    Friend WithEvents FSaveAs As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FPrint As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FExit As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EUndo As ToolStripMenuItem
    Friend WithEvents ERedo As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ECut As ToolStripMenuItem
    Friend WithEvents ECopy As ToolStripMenuItem
    Friend WithEvents EPaste As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ESelectAll As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents toolBar As ToolStrip
    Friend WithEvents TNew As ToolStripButton
    Friend WithEvents TOpen As ToolStripButton
    Friend WithEvents TSave As ToolStripButton
    Friend WithEvents TPrint As ToolStripButton
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TCut As ToolStripButton
    Friend WithEvents TCopy As ToolStripButton
    Friend WithEvents TPaste As ToolStripButton
    Friend WithEvents toolStripSeparator6 As ToolStripSeparator
    Friend WithEvents TabPage As TabPage
    Friend WithEvents FileTab As TabControl
    Friend WithEvents Document As RichTextBox
End Class
