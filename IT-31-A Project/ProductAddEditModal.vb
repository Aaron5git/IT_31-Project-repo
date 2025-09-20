Imports IBM.Data.DB2

Public Class ProductAddEditModal
    Dim dbConn As Common.DbConnection

    Private Sub ProductAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New DB2Connection("server=localhost;database=cafeproj;uid=db2admin;password=db2admin;")
        dbConn.Open()
    End Sub
    ' Save button: insert new product or update existing one
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            ' --- Collect values from controls ---
            Dim prodId As String = prodidtext.Text.Trim()
            Dim prodName As String = prodnametext.Text.Trim()
            Dim prodPrice As String = prodpricetext.Text.Trim()

            ' Safely read ComboBox values
            Dim prodType As String = If(prodtypedata.SelectedItem IsNot Nothing, prodtypedata.SelectedItem.ToString(), Nothing)
            Dim prodStatus As String = If(prodstatusdata.SelectedItem IsNot Nothing, prodstatusdata.SelectedItem.ToString(), Nothing)

            ' --- Validate required fields ---
            If String.IsNullOrWhiteSpace(prodId) Then
                MessageBox.Show("PRODID is required.")
                Exit Sub
            End If

            ' --- Check if record exists ---
            Dim checkCmd As New DB2Command("SELECT COUNT(*) FROM PRODUCT WHERE PRODID = ?", dbConn)
            checkCmd.Parameters.Add(New DB2Parameter("prodId", DB2Type.VarChar, 20)).Value = prodId
            Dim exists As Integer = CInt(checkCmd.ExecuteScalar())

            If exists > 0 Then
                ' --- UPDATE existing record ---
                Dim values As String = "PRODNAME='" & prodName & "', " &
                                       "PRODTYPE='" & prodType & "', " &
                                       "PRODPRICE='" & prodPrice & "', " &
                                       "PRODSTATUS='" & prodStatus & "'"
                Dim condition As String = "PRODID='" & prodId & "'"

                Using updateCmd As New DB2Command("CALL UPDATE_GENERAL(?, ?, ?)", dbConn)
                    updateCmd.Parameters.Add(New DB2Parameter("table_name", DB2Type.VarChar, 50)).Value = "PRODUCT"
                    updateCmd.Parameters.Add(New DB2Parameter("values", DB2Type.VarChar, 200)).Value = values
                    updateCmd.Parameters.Add(New DB2Parameter("condition", DB2Type.VarChar, 100)).Value = condition
                    updateCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Record updated successfully.")

            Else
                ' --- INSERT new record ---
                Dim values As String = "('" & prodId & "', '" & prodName & "', '" & prodType & "', '" & prodPrice & "', '" & prodStatus & "')"

                Using insertCmd As New DB2Command("CALL INSERT_GENERAL(?, ?)", dbConn)
                    insertCmd.Parameters.Add(New DB2Parameter("table_name", DB2Type.VarChar, 50)).Value = "PRODUCT"
                    insertCmd.Parameters.Add(New DB2Parameter("values", DB2Type.VarChar, 200)).Value = values
                    insertCmd.ExecuteNonQuery()
                End Using

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
