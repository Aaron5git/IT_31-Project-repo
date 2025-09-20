Imports IBM.Data.DB2

Public Class OrderAddEditModal
    Dim dbConn As Common.DbConnection

    Private Sub OrderAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New DB2Connection("server=localhost;database=cafeproj;uid=db2admin;password=db2admin;")
        dbConn.Open()
    End Sub

    ' Save button: insert new order or update existing one
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim orderId As String = orderidtext.Text.Trim()
            Dim orderDate As String = orderdatedata.Value.ToString("yyyy-MM-dd")
            Dim orderQty As String = orderqtytext.Text.Trim()
            Dim amountPaid As String = amountpaidtext.Text.Trim()
            Dim prodsPurch As String = prodspurchtext.Text.Trim()
            Dim custId As String = custidtext.Text.Trim()

            If orderId = "" Then
                MessageBox.Show("ORDERID is required.")
                Exit Sub
            End If

            ' --- Check if record exists ---
            Dim checkCmd As DB2Command = New DB2Command("SELECT COUNT(*) FROM ""ORDER"" WHERE ORDERID ", dbConn)
            checkCmd.Parameters.Add("@orderId", DB2Type.VarChar).Value = orderId
            Dim exists As Integer = CInt(checkCmd.ExecuteScalar())

            If exists > 0 Then
                ' --- UPDATE via stored procedure ---
                Dim values As String = "ORDERDATE='" & orderDate & "', ORDERQTY='" & orderQty & "', " & "AMOUNTPAID='" & amountPaid & "', PRODSPURCH='" & prodsPurch & "', " & "CUSTID='" & custId & "'"
                Dim condition As String = "ORDERID='" & orderId & "'"

                Dim updateCmd As New DB2Command("CALL UPDATE_GENERAL(?, ?, ?)", dbConn)
                updateCmd.Parameters.Add("@table_name", DB2Type.VarChar).Value = "ORDER"
                updateCmd.Parameters.Add("@values", DB2Type.VarChar).Value = values
                updateCmd.Parameters.Add("@condition", DB2Type.VarChar).Value = condition

                updateCmd.ExecuteNonQuery()
                MessageBox.Show("Order updated successfully.")

            Else
                ' --- INSERT via stored procedure ---
                Dim values As String = "('" & orderId & "', '" & orderDate & "', '" & orderQty & "', '" & amountPaid & "', '" & prodsPurch & "', '" & custId & "')"

                Dim insertCmd As New DB2Command("CALL INSERT_GENERAL(?, ?)", dbConn)
                insertCmd.Parameters.Add("@table_name", DB2Type.VarChar).Value = "ORDER"
                insertCmd.Parameters.Add("@values", DB2Type.VarChar).Value = values

                insertCmd.ExecuteNonQuery()
                MessageBox.Show("Order inserted successfully.")
            End If

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error saving order: " & ex.Message)
        End Try
    End Sub


    ' Close button
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Hide()
    End Sub
End Class
