Imports IBM.Data.DB2

Public Class ProductAddEditModal
    Dim dbConn As Common.DbConnection

    Private Sub ProductAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New DB2Connection("server=localhost;database=cafeproj;uid=db2admin;password=db2admin;")
        dbConn.Open()
    End Sub
    ' Save button: insert new employee or update existing one
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim prodId As String = prodidtext.Text.Trim()
            Dim prodName As String = prodnametext.Text.Trim()
            Dim prodType As String = prodtypetext.Text.Trim()
            Dim prodPrice As String = prodpricetext.Text.Trim()
            Dim prodStatus As String = prodstatustext.Text.Trim()

            If prodId = "" Then
                MessageBox.Show("PRODID is required.")
                Exit Sub
            End If

            ' --- Check if record exists ---
            Dim checkCmd As New DB2Command("SELECT COUNT(*) FROM PRODUCT WHERE PRODID = @prodId", dbConn)
            checkCmd.Parameters.Add("@prodId", DB2Type.VarChar).Value = prodId
            Dim exists As Integer = CInt(checkCmd.ExecuteScalar())

            If exists > 0 Then
                ' --- UPDATE via stored procedure ---
                Dim values As String = "PRODNAME='" & prodName & "', PRODTYPE='" & prodType & "', " & "PRODPRICE='" & prodPrice & "', PRODSTATUS='" & prodStatus & "'"
                Dim condition As String = "PRODID='" & prodId & "'"

                Dim updateCmd As New DB2Command("CALL UPDATE_GENERAL(?, ?, ?)", dbConn)
                updateCmd.Parameters.Add("@table_name", DB2Type.VarChar).Value = "PRODUCT"
                updateCmd.Parameters.Add("@values", DB2Type.VarChar).Value = values
                updateCmd.Parameters.Add("@condition", DB2Type.VarChar).Value = condition

                updateCmd.ExecuteNonQuery()
                MessageBox.Show("Record updated successfully.")

            Else
                ' --- INSERT via stored procedure ---
                Dim values As String = "('" & prodId & "', '" & prodName & "', '" & prodType & "', '" & prodPrice & "', '" & prodStatus & "')"

                Dim insertCmd As New DB2Command("CALL INSERT_GENERAL(?, ?)", dbConn)
                insertCmd.Parameters.Add("@table_name", DB2Type.VarChar).Value = "PRODUCT"
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
