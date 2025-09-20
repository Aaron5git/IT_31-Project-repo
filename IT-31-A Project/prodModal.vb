Imports IBM.Data.DB2
Public Class prodModal
    Public prodType As String
    Dim dbConn As Common.DbConnection

    Private Sub prodModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New DB2Connection("server=localhost;database=cafeproj;" + "uid=db2admin;password=db2admin;")
        dbConn.Open()
        With Me.dgvProductView
            .ColumnCount = 5
            .Columns(0).Name = "ID"
            .Columns(0).Width = 80
            .Columns(1).Name = "Item"
            .Columns(1).Width = 150
            .Columns(2).Name = "Type"
            .Columns(2).Width = 150
            .Columns(3).Name = "Price"
            .Columns(3).Width = 150
            .Columns(4).Name = "STATUS"
            .Columns(4).Width = 80
        End With
        loadGridView()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        Dim input As String = searchBox.Text
        loadGridView(input)
    End Sub

    Private Sub loadGridView(Optional ByVal condition As String = "")
        Dim row As String()
        Dim sqlcomm As DB2Command
        Dim sqlReader As DB2DataReader

        dgvProductView.Rows.Clear()

        Try
            If (condition = "") Then
                sqlcomm = New DB2Command("select * from table (db2admin.prodSearchTab('" & prodType & "')) as t", dbConn)
                sqlReader = sqlcomm.ExecuteReader
                While sqlReader.Read
                    row = New String() {sqlReader.GetString(0), sqlReader.GetString(1), sqlReader.GetString(2), sqlReader.GetString(3), sqlReader.GetString(4)}
                    dgvProductView.Rows.Add(row)
                End While
            Else
                sqlcomm = New DB2Command("select * from table (db2admin.prodSearchTab('" & prodType & "')) as t join table (db2admin.prodSearchTab('" & condition & "')) using (prodID)", dbConn)
                sqlReader = sqlcomm.ExecuteReader
                While sqlReader.Read
                    row = New String() {sqlReader.GetString(0), sqlReader.GetString(1), sqlReader.GetString(2), sqlReader.GetString(3), sqlReader.GetString(4)}
                    dgvProductView.Rows.Add(row)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvProductView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductView.CellContentClick
        posArea.dgvOrderGrid.Rows.Add(dgvProductView.CurrentRow.Cells(1).Value, "1", dgvProductView.CurrentRow.Cells(3).Value, dgvProductView.CurrentRow.Cells(0).Value)
        Me.Hide()
    End Sub
End Class