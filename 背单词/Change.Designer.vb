<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Change))
        Me.English = New System.Windows.Forms.ComboBox()
        Me.Chinese = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Yes = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'English
        '
        Me.English.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.English.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.English.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.English.FormattingEnabled = True
        resources.ApplyResources(Me.English, "English")
        Me.English.Name = "English"
        '
        'Chinese
        '
        Me.Chinese.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Chinese.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Chinese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.Chinese.FormattingEnabled = True
        resources.ApplyResources(Me.Chinese, "Chinese")
        Me.Chinese.Name = "Chinese"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Yes
        '
        resources.ApplyResources(Me.Yes, "Yes")
        Me.Yes.Name = "Yes"
        Me.Yes.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.Cancel, "Cancel")
        Me.Cancel.Name = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Change
        '
        Me.AcceptButton = Me.Yes
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Yes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chinese)
        Me.Controls.Add(Me.English)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents English As ComboBox
    Friend WithEvents Chinese As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Yes As Button
    Friend WithEvents Cancel As Button
End Class
