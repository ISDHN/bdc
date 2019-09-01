<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question))
        Me.QuestionBox = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Yes = New System.Windows.Forms.Button()
        Me.Input = New System.Windows.Forms.TextBox()
        Me.AllChoose = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'QuestionBox
        '
        Me.QuestionBox.FormattingEnabled = True
        resources.ApplyResources(Me.QuestionBox, "QuestionBox")
        Me.QuestionBox.Name = "QuestionBox"
        Me.QuestionBox.ThreeDCheckBoxes = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.Cancel, "Cancel")
        Me.Cancel.Name = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Yes
        '
        resources.ApplyResources(Me.Yes, "Yes")
        Me.Yes.Name = "Yes"
        Me.Yes.UseVisualStyleBackColor = True
        '
        'Input
        '
        Me.Input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        resources.ApplyResources(Me.Input, "Input")
        Me.Input.Name = "Input"
        '
        'AllChoose
        '
        resources.ApplyResources(Me.AllChoose, "AllChoose")
        Me.AllChoose.Name = "AllChoose"
        Me.AllChoose.UseVisualStyleBackColor = True
        '
        'Question
        '
        Me.AcceptButton = Me.Yes
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel
        Me.Controls.Add(Me.AllChoose)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Yes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuestionBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Question"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuestionBox As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents Yes As Button
    Friend WithEvents Input As TextBox
    Friend WithEvents AllChoose As CheckBox
End Class
