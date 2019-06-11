Public Class SetPage
    Private Sub 页面设置_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSize.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles butOK.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles butClose.Click
        Me.Close()
    End Sub
End Class