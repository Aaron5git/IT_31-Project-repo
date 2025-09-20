Imports IBM.Data.DB2
Public Class Admin
    Private dbconn As Common.DbConnection

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New DB2Connection("server=localhost;database=cafeproj;" + "uid=db2admin;password=db2admin;")
        dbconn.Open()

    End Sub

    Private Sub Load_Emp(Optional ByVal type As String = "")

    End Sub
End Class