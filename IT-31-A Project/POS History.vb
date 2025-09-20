Imports IBM.Data.DB2
Public Class PosHistory
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbconn As Common.DbConnection = New DB2Connection("server=localhost;database=cafeproj;uid=db2admin;password=db2admin;")
        Dim dbComm As DB2Command
        Dim dataReader As DB2DataReader
        Dim row As String()
        dbconn.Open()
        Me.Width = 767
        With Me.dgvOrdersView
            .ColumnCount = 4
            .Columns(0).Name = "ID"
            .Columns(1).Name = "Quantity"
            .Columns(2).Name = "Amount Total"
            .Columns(3).Name = "Purchased Product ID"
        End With
        dgvOrdersView.Rows.Clear()
        dbComm = dbconn.CreateCommand
        dbComm = New DB2Command("select * from table (searchOrderTab()) as t", dbconn)
        dataReader = dbComm.ExecuteReader
        While dataReader.Read
            row = New String() {dataReader.GetString(0), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4)}
            dgvOrdersView.Rows.Add(row)
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim posOrders As posArea = New posArea()
        posOrders.Show()
        Me.Hide()
    End Sub
End Class