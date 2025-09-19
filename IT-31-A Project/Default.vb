Imports IBM.Data.DB2
Public Class Form4
    Dim dbConn As Common.DbConnection
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim name As String
        Dim password As String
        Dim menuBox As Menu
        Try
            name = Cust_Name.Text
            password = userPass.Text
            dbConn = New DB2Connection("server=localhost;database=cafeproj;" + "uid=" & name & ";password=" & password & ";")
            dbConn.Open()
            MessageBox.Show("Log In Successful!")
            menuBox.Show()
        Catch ex As Exception
            MessageBox.Show("ERROR! This is not a valid username and password. Please try again.")
        End Try
    End Sub
End Class