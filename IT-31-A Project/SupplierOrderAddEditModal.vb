Imports IBM.Data.DB2

Public Class SupplierOrderAddEditModal
    Dim dbConn As Common.DbConnection

    Private Sub EmployeeAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New DB2Connection("server=localhost;database=cafeproj;uid=db2admin;password=db2admin;")
        dbConn.Open()
    End Sub

    ' Save button: insert new employee or update existing one
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim sqlComm As DB2Command

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

            ' First check if employee exists
            sqlComm = New DB2Command("SELECT COUNT(*) FROM SUPPORDER WHERE SUPPORDERID = '" & supporderId & "'", dbConn)
            Dim exists As Integer = CInt(sqlComm.ExecuteScalar())


            If exists > 0 Then
                ' Update
                sqlComm = New DB2Command("UPDATE SUPPORDER SET SUPPID = '" & suppId & "', SUPPQTY = '" & suppQty & "', DATEOFPURCHASE = '" & dateOfPurchase & "', AMOUNTPAID = '" & amountPaid & "', WHERE SUPPORDERID = '" & supporderId & "'", dbConn)
                Dim rowsUpdated As Integer = sqlComm.ExecuteNonQuery()
                MessageBox.Show(rowsUpdated.ToString() & " record(s) updated successfully.")
            Else
                ' Insert
                sqlComm = New DB2Command("INSERT INTO SUPPORDER (SUPPORDERID, SUPPID, SUPPQTY, DATEOFPURCHASE, AMOUNTPAID) VALUES ('" & supporderId & "', '" & suppId & "', '" & suppQty & "', '" & dateOfPurchase & "', '" & amountPaid & "')", dbConn)
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
