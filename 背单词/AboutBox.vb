Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LabelProductName.Text &= My.Application.Info.ProductName
        LabelVersion.Text = String.Format(LabelVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Revision)
        LabelCopyright.Text &= My.Application.Info.Copyright
        LabelCompanyName.Text &= My.Application.Info.CompanyName
        TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click_1(sender As Object, e As EventArgs) Handles OKButton.Click
        Close()
    End Sub
End Class
