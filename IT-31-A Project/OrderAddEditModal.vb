Imports IBM.Data.DB2

Public Class OrderAddEditModal
    Dim dbConn As Common.DbConnection

    Private Sub EmployeeAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New DB2Connection("server=localhost;database=cafeproj;uid=db2admin;password=db2admin;")
        dbConn.Open()
    End Sub

    ' Save button: insert new employee or update existing one
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim sqlComm As DB2Command

        Try
            Dim orderId As String = orderidtext.Text.Trim()
            Dim orderDate As String = orderdatetext.Text.Trim()
            Dim orderQty As String = orderqtytext.Text.Trim()
            Dim amountPaid As String = amountpaidtext.Text.Trim()
            Dim prodsPurch As String = prodspurchtext.Text.Trim()
            Dim custId As String = custidtext.Text.Trim()


            If orderId = "" Then
                MessageBox.Show("ORDERID is required.")
                Exit Sub
            End If

            ' First check if employee exists
            sqlComm = New DB2Command("SELECT COUNT(*) FROM ORDER WHERE ORDERID = '" & orderId & "'", dbConn)
            Dim exists As Integer = CInt(sqlComm.ExecuteScalar())


            If exists > 0 Then
                ' Update
                sqlComm = New DB2Command("UPDATE ORDER SET ORDERDATE = '" & orderDate & "', ORDERQTY = '" & orderQty & "', AMOUNTPAID = '" & amountPaid & "', PRODSPURCH = '" & prodsPurch & "', CUSTID = '" & custId & "' WHERE ORDERID = '" & orderId & "'", dbConn)
                Dim rowsUpdated As Integer = sqlComm.ExecuteNonQuery()
                MessageBox.Show(rowsUpdated.ToString() & " record(s) updated successfully.")
            Else
                ' Insert
                sqlComm = New DB2Command("INSERT INTO ORDER (ORDERID, ORDERDATE, ORDERQTY, AMOUNTPAID, PRODSPURCH, CUSTID) VALUES ('" & orderId & "', '" & orderDate & "', '" & orderQty & "', '" & amountPaid & "', '" & prodsPurch & "', '" & custId & "')", dbConn)
                Dim rowsInserted As Integer = sqlComm.ExecuteNonQuery()
                MessageBox.Show(rowsInserted.ToString() & " record(s) inserted successfully.")
            End If

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Close button
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Hide()
    End Sub
End Class
