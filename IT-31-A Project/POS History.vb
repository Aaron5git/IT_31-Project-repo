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
            .ColumnCount = 5
            .Columns(0).Name = "ID"
            .Columns(1).Name = "Quantity"
            .Columns(2).Name = "Purchased Product ID"
            .Columns(3).Name = "Amount Total"
            .Columns(4).Name = "Customer ID"
        End With
        dgvOrdersView.Rows.Clear()
        dbComm = dbconn.CreateCommand
        dbComm = New DB2Command("select * from table (searchOrderTab()) as t", dbconn)
        dataReader = dbComm.ExecuteReader
        While dataReader.Read
            row = New String() {dataReader.GetString(0), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), "" + If(dataReader.GetValues(5) Is DBNull.Value, String.Empty, dataReader.GetString(5))}
            dgvOrdersView.Rows.Add(row)
        End While
    End Sub
End Class