Imports IBM.Data.DB2

Public Class InventoryAddEditModal
    Dim dbConn As Common.DbConnection

    Private Sub InventoryAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New DB2Connection("server=localhost;database=cafeproj;uid=db2admin;password=db2admin;")
        dbConn.Open()
    End Sub
    ' Save button: insert new employee or update existing one
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim invId As String = invidtext.Text.Trim()
            Dim invName As String = invnametext.Text.Trim()
            Dim currentStock As String = currentstocktext.Text.Trim()
            Dim minStockLevel As String = minstockleveltext.Text.Trim()
            Dim lastUpdated As String = lastupdateddata.Value.ToString("yyyy-MM-dd")
            Dim suppliedFrom As String = suppliedfromtext.Text.Trim()

            If invId = "" Then
                MessageBox.Show("INVID is required.")
                Exit Sub
            End If

            ' --- Check if record exists ---
            Dim checkCmd As DB2Command = New DB2Command("call db2admin.gennumId('db2admin.inventory', 'invID', ?)", dbConn)
            Dim param1 As DB2Parameter = checkCmd.Parameters.Add("@output", DB2Type.Integer)
            param1.Direction = ParameterDirection.Output

            Dim exists As Integer = CInt(checkCmd.ExecuteScalar())

            If exists > 0 Then
                ' --- UPDATE via stored procedure ---
                invId = checkCmd.Parameters("@output").Value
                Dim values As String = "INVNAME='" & invName & "', CURRENTSTOCK='" & currentStock & "', " & "MINSTOCKLEVEL='" & minStockLevel & "', LASTUPDATED='" & lastUpdated & "', " & "SUPPLIED_FROM='" & suppliedFrom & "'"
                Dim condition As String = "INVID='" & invId & "'"

                Dim updateCmd As New DB2Command("CALL UPDATE_GENERAL(?, ?, ?)", dbConn)
                updateCmd.Parameters.Add("@table_name", DB2Type.VarChar).Value = "INVENTORY"
                updateCmd.Parameters.Add("@values", DB2Type.VarChar).Value = values
                updateCmd.Parameters.Add("@condition", DB2Type.VarChar).Value = condition

                updateCmd.ExecuteNonQuery()
                MessageBox.Show("Record updated successfully.")

            Else
                invId = checkCmd.Parameters("@output").Value
                ' --- INSERT via stored procedure ---
                Dim values As String = "('" & invId & "', '" & invName & "', '" & currentStock & "', '" & minStockLevel & "', '" & lastUpdated & "', '" & suppliedFrom & "')"

                Dim insertCmd As New DB2Command("CALL INSERT_GENERAL(?, ?)", dbConn)
                insertCmd.Parameters.Add("@table_name", DB2Type.VarChar).Value = "INVENTORY"
                insertCmd.Parameters.Add("@values", DB2Type.VarChar).Value = values

                insertCmd.ExecuteNonQuery()
                MessageBox.Show("Record inserted successfully.")
            End If

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message)
        End Try
    End Sub


    ' Close button
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Hide()
    End Sub
End Class
