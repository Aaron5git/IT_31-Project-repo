Public Class Menu

    Private Sub suppOpener_btn_Click(sender As Object, e As EventArgs) Handles suppOpener_btn.Click

    End Sub

    Private Sub logOut_btn_Click(sender As Object, e As EventArgs) Handles logOut_btn.Click
        Me.Close()
    End Sub

    Private Sub posOpener_btn_Click(sender As Object, e As EventArgs) Handles posOpener_btn.Click
        Dim newPos As posArea = New posArea
        newPos.Show()
    End Sub
End Class