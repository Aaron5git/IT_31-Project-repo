Imports IBM.Data.DB2

Public Class EmployeeAddEditModal
    Dim dbConn As Common.DbConnection

    Private Sub EmployeeAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New DB2Connection("server=localhost;database=cafeproj;uid=db2admin;password=db2admin;")
        dbConn.Open()
    End Sub

    ' Save button: insert new employee or update existing one
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim sqlComm As DB2Command

        Try
            Dim empId As String = empidtext.Text.Trim()
            Dim empName As String = empnametext.Text.Trim()
            Dim depId As String = depidtext.Text.Trim()
            Dim empType As String = emptypetext.Text.Trim()

            If empId = "" Then
                MessageBox.Show("EMPID is required.")
                Exit Sub
            End If

            ' First check if employee exists
            sqlComm = New DB2Command("SELECT COUNT(*) FROM Employee WHERE EmpID = '" & empId & "'", dbConn)
            Dim exists As Integer = CInt(sqlComm.ExecuteScalar())


            If exists > 0 Then
                ' Update
                sqlComm = New DB2Command("UPDATE Employee SET EmpName = '" & empName & "', DepID = '" & depId & "', EmpType = '" & empType & "' WHERE EmpID = '" & empId & "'", dbConn)
                Dim rowsUpdated As Integer = sqlComm.ExecuteNonQuery()
                MessageBox.Show(rowsUpdated.ToString() & " record(s) updated successfully.")
            Else
                ' Insert
                sqlComm = New DB2Command("INSERT INTO Employee (EmpID, EmpName, DepID, EmpType) VALUES ('" & empId & "', '" & empName & "', '" & depId & "', '" & empType & "')", dbConn)
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
