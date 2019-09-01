<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblti = New System.Windows.Forms.Label()
        Me.btnst = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.File = New System.Windows.Forms.ToolStripMenuItem()
        Me.Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRecent = New System.Windows.Forms.ToolStripMenuItem()
        Me.File1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.File2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.File3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.File4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.File5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.File6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.File7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.File8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.File9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.File10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Unload = New System.Windows.Forms.ToolStripMenuItem()
        Me.Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.Revise = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangeQues = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Prefer = New System.Windows.Forms.ToolStripMenuItem()
        Me.Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.About = New System.Windows.Forms.ToolStripMenuItem()
        Me.Player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblti
        '
        resources.ApplyResources(Me.lblti, "lblti")
        Me.lblti.BackColor = System.Drawing.Color.Transparent
        Me.lblti.ForeColor = System.Drawing.Color.Lime
        Me.lblti.Name = "lblti"
        '
        'btnst
        '
        Me.btnst.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnst, "btnst")
        Me.btnst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnst.Name = "btnst"
        Me.btnst.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "wdf"
        resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "wdf"
        Me.SaveFileDialog1.FileName = "Untitled"
        resources.ApplyResources(Me.SaveFileDialog1, "SaveFileDialog1")
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File, Me.Edit, Me.Help})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'File
        '
        Me.File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Open, Me.OpenRecent, Me.SaveAs, Me.Save, Me.ToolStripSeparator1, Me.Unload})
        Me.File.Name = "File"
        resources.ApplyResources(Me.File, "File")
        '
        'Open
        '
        Me.Open.Name = "Open"
        resources.ApplyResources(Me.Open, "Open")
        '
        'OpenRecent
        '
        Me.OpenRecent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File1, Me.File2, Me.File3, Me.File4, Me.File5, Me.File6, Me.File7, Me.File8, Me.File9, Me.File10})
        Me.OpenRecent.Name = "OpenRecent"
        resources.ApplyResources(Me.OpenRecent, "OpenRecent")
        '
        'File1
        '
        Me.File1.Name = "File1"
        resources.ApplyResources(Me.File1, "File1")
        '
        'File2
        '
        Me.File2.Name = "File2"
        resources.ApplyResources(Me.File2, "File2")
        '
        'File3
        '
        Me.File3.Name = "File3"
        resources.ApplyResources(Me.File3, "File3")
        '
        'File4
        '
        Me.File4.Name = "File4"
        resources.ApplyResources(Me.File4, "File4")
        '
        'File5
        '
        Me.File5.Name = "File5"
        resources.ApplyResources(Me.File5, "File5")
        '
        'File6
        '
        Me.File6.Name = "File6"
        resources.ApplyResources(Me.File6, "File6")
        '
        'File7
        '
        Me.File7.Name = "File7"
        resources.ApplyResources(Me.File7, "File7")
        '
        'File8
        '
        Me.File8.Name = "File8"
        resources.ApplyResources(Me.File8, "File8")
        '
        'File9
        '
        Me.File9.Name = "File9"
        resources.ApplyResources(Me.File9, "File9")
        '
        'File10
        '
        Me.File10.Name = "File10"
        resources.ApplyResources(Me.File10, "File10")
        '
        'SaveAs
        '
        Me.SaveAs.Name = "SaveAs"
        resources.ApplyResources(Me.SaveAs, "SaveAs")
        '
        'Save
        '
        Me.Save.Name = "Save"
        resources.ApplyResources(Me.Save, "Save")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'Unload
        '
        Me.Unload.Name = "Unload"
        resources.ApplyResources(Me.Unload, "Unload")
        '
        'Edit
        '
        Me.Edit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add, Me.Delete, Me.Revise, Me.ToolStripSeparator2, Me.ChangeQues, Me.ToolStripSeparator3, Me.Prefer})
        Me.Edit.Name = "Edit"
        resources.ApplyResources(Me.Edit, "Edit")
        '
        'Add
        '
        Me.Add.Name = "Add"
        resources.ApplyResources(Me.Add, "Add")
        '
        'Delete
        '
        Me.Delete.Name = "Delete"
        resources.ApplyResources(Me.Delete, "Delete")
        '
        'Revise
        '
        Me.Revise.Name = "Revise"
        resources.ApplyResources(Me.Revise, "Revise")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ChangeQues
        '
        Me.ChangeQues.Name = "ChangeQues"
        resources.ApplyResources(Me.ChangeQues, "ChangeQues")
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'Prefer
        '
        Me.Prefer.Name = "Prefer"
        resources.ApplyResources(Me.Prefer, "Prefer")
        '
        'Help
        '
        Me.Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.About})
        Me.Help.Name = "Help"
        resources.ApplyResources(Me.Help, "Help")
        '
        'About
        '
        Me.About.Name = "About"
        resources.ApplyResources(Me.About, "About")
        '
        'Player
        '
        resources.ApplyResources(Me.Player, "Player")
        Me.Player.Name = "Player"
        Me.Player.OcxState = CType(resources.GetObject("Player.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'Form1
        '
        Me.AcceptButton = Me.btnst
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.btnst)
        Me.Controls.Add(Me.lblti)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnst As System.Windows.Forms.Button
    Public WithEvents lblti As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Unload As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Revise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeQues As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Prefer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents About As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Public WithEvents OpenRecent As ToolStripMenuItem
    Public WithEvents File1 As ToolStripMenuItem
    Public WithEvents File2 As ToolStripMenuItem
    Public WithEvents File3 As ToolStripMenuItem
    Public WithEvents File4 As ToolStripMenuItem
    Public WithEvents File5 As ToolStripMenuItem
    Public WithEvents File6 As ToolStripMenuItem
    Public WithEvents File7 As ToolStripMenuItem
    Public WithEvents File8 As ToolStripMenuItem
    Public WithEvents File9 As ToolStripMenuItem
    Public WithEvents File10 As ToolStripMenuItem
    Public WithEvents SaveFileDialog1 As SaveFileDialog
End Class
