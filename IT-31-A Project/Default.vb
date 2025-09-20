Imports IBM.Data.DB2
Public Class Form4
    Dim dbConn As Common.DbConnection

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim name As String
        Dim password As String
        Dim menuBox As Menu
        Try
            menuBox = New Menu()
            name = Cust_Name.Text
            password = userPass.Text
            dbConn = New DB2Connection("server=localhost;database=cafeproj;" + "uid=" + name + ";password=" + password + ";")
            dbConn.Open()
            MessageBox.Show("Log In Successful!")
            menuBox.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR! This is not a valid username and password. Please try again.")
        End Try
    End Sub

    Private Sub Cust_Name_MouseClick(sender As Object, e As MouseEventArgs) Handles Cust_Name.MouseClick
        If Me.Cust_Name.Text = "Enter Username" Then
            Me.Cust_Name.Text = ""
        End If
    End Sub

    Private Sub userPass_MouseClick(sender As Object, e As MouseEventArgs) Handles userPass.MouseClick
        If Me.userPass.Text = "Enter Password" Then
            Me.userPass.Text = ""
        End If
    End Sub
End Class