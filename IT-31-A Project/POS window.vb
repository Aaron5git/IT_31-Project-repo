Imports IBM.Data.DB2
Public Class posArea
    Private dbconn As Common.DbConnection
    Private rowIndex As Integer
    Private id As Integer = 0

    Private Sub posArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New DB2Connection("server=localhost;database=cafeproj;" + "uid=db2admin;password=db2admin;")
        dbconn.Open()
        Me.Width = 767
        With Me.dgvOrderGrid
            .ColumnCount = 4
            .Columns(0).Name = "Name"
            .Columns(1).Name = "Quantity"
            .Columns(2).Name = "Price"
            .Columns(3).Name = "ID"
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cust_Name_TextChanged(sender As Object, e As EventArgs) Handles Cust_Name.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub DeleteOrdersBtn_Click(sender As Object, e As EventArgs) Handles DeleteOrdersBtn.Click
        Dim quantity As Integer
        Dim row As String

        quantity = quantNum.Text
        quantity -= 1
        If (quantity <= 0) Then
            dgvOrderGrid.Rows.RemoveAt(rowIndex)
            quantNum.Text = "0"
            costArea.Text = "0.0"
        Else
            quantNum.Text = quantity
            dgvOrderGrid.Rows(rowIndex).Cells(1).Value = quantity
            quantityAdder()
        End If
    End Sub

    Private Sub EditOrdersBtn_Click(sender As Object, e As EventArgs) Handles EditOrdersBtn.Click
        Dim quantity As Integer

        quantity = quantNum.Text
        quantity += 1
        quantNum.Text = quantity

        dgvOrderGrid.Rows(rowIndex).Cells(1).Value = quantity
        quantityAdder()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Width = 984
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Width = 767
    End Sub

    Private Sub btnOpenProdList_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOpenProdList.MouseUp
        Dim modal As New prodModal
        modal.prodType = "COFFEE"
        modal.ShowDialog()
    End Sub

    Private Sub btnDrinksArea_MouseUp(sender As Object, e As MouseEventArgs) Handles btnDrinksArea.MouseUp
        Dim modal As New prodModal
        modal.prodType = "DRINKS"
        modal.ShowDialog()
    End Sub

    Private Sub btnSnacksArea_Click(sender As Object, e As EventArgs) Handles btnSnacksArea.Click
        Dim modal As New prodModal
        modal.prodType = "SNACKS"
        modal.ShowDialog()
    End Sub

    Private Sub btnMealsArea_Click(sender As Object, e As EventArgs) Handles btnMealsArea.Click
        Dim modal As New prodModal
        modal.prodType = "MEALS"
        modal.ShowDialog()
    End Sub

    Private Sub dgvOrderGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvOrderGrid.RowsAdded
        quantityAdder()
    End Sub

    Private Sub dgvOrderGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderGrid.CellContentClick
        If dgvOrderGrid.Rows.Count > 0 Then
            quantNum.Text = dgvOrderGrid.CurrentRow.Cells(1).Value
            rowIndex = dgvOrderGrid.CurrentRow.Index
        End If
    End Sub

    Private Sub quantityAdder()
        Dim totalCost As Double = 0.0
        If dgvOrderGrid.Rows.Count > 0 Then
            Try
                For Each row As DataGridViewRow In dgvOrderGrid.Rows
                    totalCost = totalCost + (row.Cells(1).Value * row.Cells(2).Value)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        costArea.Text = totalCost
    End Sub

    Private Sub btnSaveCust_Click(sender As Object, e As EventArgs) Handles btnSaveCust.Click
        Dim name As String = custName.Text
        Dim phoneNum As String = Cust_PhoneNum.Text
        Dim address As String = Cust_Address.Text
        Dim dbComm As DB2Command
        Dim dbRead As DB2DataReader
        Try
            dbComm = dbconn.CreateCommand()
            dbComm = New DB2Command("call db2admin.gennumid(?, ?, ?)", dbconn)
            Dim param1 As DB2Parameter = dbComm.Parameters.Add("@tableName", DB2Type.VarChar)
            param1.Direction = ParameterDirection.Input
            dbComm.Parameters("@tableName").Value = "customer"
            Dim param2 As DB2Parameter = dbComm.Parameters.Add("@colName", DB2Type.VarChar)
            param2.Direction = ParameterDirection.Input
            dbComm.Parameters("@colName").Value = "custID"
            Dim resultparam As DB2Parameter = dbComm.Parameters.Add("@output", DB2Type.Integer)
            resultparam.Direction = ParameterDirection.Output
            dbComm.ExecuteNonQuery()
            If IsDBNull(dbComm.Parameters("@output").Value) Then
                id = 10000
            Else
                id = dbComm.Parameters("@output").Value + 10001
            End If
            MessageBox.Show("The value is: " & id)

            'For creating a new record for Customer
            dbComm = New DB2Command("call db2admin.insert_general('customer', ?)", dbconn)

            Dim param3 As DB2Parameter = dbComm.Parameters.Add("@values", DB2Type.VarChar)
            param3.Direction = ParameterDirection.Input
            dbComm.Parameters("@values").Value = "(" & id & ", '" & name & "', " & phoneNum & ", '" & address & "')"
            dbRead = dbComm.ExecuteReader
            MessageBox.Show("Customer is saved successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dbComm As DB2Command
        Dim dbRead As DB2DataReader
        Dim orderid As Integer = 0
        Dim currDate As Date = DateTime.Today

        Try
            dbComm = dbconn.CreateCommand()
            dbComm = New DB2Command("call db2admin.gennumid(?, ?, ?)", dbconn)
            Dim param1 As DB2Parameter = dbComm.Parameters.Add("@tableName", DB2Type.VarChar)
            param1.Direction = ParameterDirection.Input
            dbComm.Parameters("@tableName").Value = "order"
            Dim param2 As DB2Parameter = dbComm.Parameters.Add("@colName", DB2Type.VarChar)
            param2.Direction = ParameterDirection.Input
            dbComm.Parameters("@colName").Value = "orderID"
            Dim resultparam As DB2Parameter = dbComm.Parameters.Add("@output", DB2Type.Integer)
            resultparam.Direction = ParameterDirection.Output
            dbComm.ExecuteNonQuery()
            If IsDBNull(dbComm.Parameters("@output").Value) Then
                orderid = 1
            Else
                orderid = dbComm.Parameters("@output").Value + 1
            End If
            Dim param3 As DB2Parameter
            Dim costProd As Double
            For Each row As DataGridViewRow In dgvOrderGrid.Rows
                costProd = row.Cells(2).Value * row.Cells(1).Value
                MessageBox.Show(costProd)
                If id > 0 Then
                    dbComm = New DB2Command("call db2admin.insert_orders('order', ?, ?, ?)", dbconn)
                    param3 = dbComm.Parameters.Add("@col1", DB2Type.VarChar)
                    param3.Direction = ParameterDirection.Input
                    dbComm.Parameters("@col1").Value = "(" & orderid
                    param3 = dbComm.Parameters.Add("@col2", DB2Type.VarChar)
                    param3.Direction = ParameterDirection.Input
                    dbComm.Parameters("@col2").Value = ", " & row.Cells(1).Value & ", " & costProd & ", " & row.Cells(3).Value
                    param3 = dbComm.Parameters.Add("@col2", DB2Type.VarChar)
                    param3.Direction = ParameterDirection.Input
                    dbComm.Parameters("@col3").Value = id & ")"
                Else
                    dbComm = New DB2Command("call db2admin.insert_orders('order', ?, ?)", dbconn)
                    param3 = dbComm.Parameters.Add("@col1", DB2Type.Integer)
                    param3.Direction = ParameterDirection.Input
                    dbComm.Parameters("@col1").Value = orderid
                    param3 = dbComm.Parameters.Add("@col2", DB2Type.VarChar)
                    param3.Direction = ParameterDirection.Input
                    dbComm.Parameters("@col2").Value = ", " & row.Cells(1).Value & ", " & costProd & ", " & row.Cells(3).Value & ")"
                End If
                dbRead = dbComm.ExecuteReader
                orderid = orderid + 1
            Next
            MessageBox.Show("Orders are saved successfully!")
            dgvOrderGrid.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class