Imports IBM.Data.DB2

Public Class SupplierOrderAddEditModal
    Dim dbConn As Common.DbConnection

    Private Sub EmployeeAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New DB2Connection("server=localhost;database=cafeproj;uid=db2admin;password=db2admin;")
        dbConn.Open()
    End Sub

    ' Save button: insert new supplier order or update existing one
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim supporderId As String = supporderidtext.Text.Trim()
            Dim suppId As String = suppidtext.Text.Trim()
            Dim suppQty As String = suppqtytext.Text.Trim()
            Dim dateOfPurchase As String = dateofpurchasetext.Text.Trim()
            Dim amountPaid As String = amountpaidtext.Text.Trim()

            If supporderId = "" Then
                MessageBox.Show("SUPPORDERID is required.")
                Exit Sub
            End If

            ' --- Check if record exists ---
            Dim checkCmd As New DB2Command("SELECT COUNT(*) FROM SUPPORDER WHERE SUPPORDERID = @supporderId", dbConn)
            checkCmd.Parameters.Add("@supporderId", DB2Type.VarChar).Value = supporderId
            Dim exists As Integer = CInt(checkCmd.ExecuteScalar())

            If exists > 0 Then
                ' --- UPDATE via stored procedure ---
                Dim values As String = "SUPPID='" & suppId & "', SUPPQTY='" & suppQty & "', " & "DATEOFPURCHASE='" & dateOfPurchase & "', AMOUNTPAID='" & amountPaid & "'"
                Dim condition As String = "SUPPORDERID='" & supporderId & "'"

                Dim updateCmd As New DB2Command("CALL UPDATE_GENERAL(?, ?, ?)", dbConn)
                updateCmd.Parameters.Add("@table_name", DB2Type.VarChar).Value = "SUPPORDER"
                updateCmd.Parameters.Add("@values", DB2Type.VarChar).Value = values
                updateCmd.Parameters.Add("@condition", DB2Type.VarChar).Value = condition

                updateCmd.ExecuteNonQuery()
                MessageBox.Show("Supplier Order updated successfully.")

            Else
                ' --- INSERT via stored procedure ---
                Dim values As String = "('" & supporderId & "', '" & suppId & "', '" & suppQty & "', '" & dateOfPurchase & "', '" & amountPaid & "')"

                Dim insertCmd As New DB2Command("CALL INSERT_GENERAL(?, ?)", dbConn)
                insertCmd.Parameters.Add("@table_name", DB2Type.VarChar).Value = "SUPPORDER"
                insertCmd.Parameters.Add("@values", DB2Type.VarChar).Value = values

                insertCmd.ExecuteNonQuery()
                MessageBox.Show("Supplier Order inserted successfully.")
            End If

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error saving Supplier Order: " & ex.Message)
        End Try
    End Sub


    ' Close button
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Hide()
    End Sub
End Class
