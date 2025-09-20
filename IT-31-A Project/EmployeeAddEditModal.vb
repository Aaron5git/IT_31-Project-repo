Imports IBM.Data.DB2

Public Class EmployeeAddEditModal
    Dim dbConn As Common.DbConnection

    Private Sub EmployeeAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New DB2Connection("server=localhost;database=cafeproj;uid=db2admin;password=db2admin;")
        dbConn.Open()
    End Sub
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim empID As String = empidtext.Text.Trim()
            Dim empName As String = empnametext.Text.Trim()
            Dim empType As String = emptypetext.Text.Trim()
            Dim depID As String = depidtext.Text.Trim()

            ' 1. Check if record already exists
            Dim checkCmd As New DB2Command("SELECT COUNT(*) FROM EMPLOYEE WHERE EMPID = @empID", dbConn)
            checkCmd.Parameters.Add("@empID", DB2Type.Integer).Value = Convert.ToInt32(empID)
            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            Dim cmd As DB2Command

            If exists = 0 Then
                ' INSERT
                Dim values As String = "('" & empID & "', '" & empName & "', '" & depID & "', '" & empType & "')"
                cmd = New DB2Command("CALL INSERT_GENERAL(?, ?)", dbConn)
                cmd.Parameters.Add("@table_name", DB2Type.VarChar).Value = "Employee"
                cmd.Parameters.Add("@values", DB2Type.VarChar).Value = values

                cmd.ExecuteNonQuery()
                MessageBox.Show("Record inserted successfully.")
            Else
                ' UPDATE
                Dim setValues As String = "EMPNAME='" & empName & "', DEPID='" & depID & "', EMPTYPE='" & empType & "'"
                Dim condition As String = "EMPID=" & empID
                cmd = New DB2Command("CALL UPDATE_GENERAL(?, ?, ?)", dbConn)
                cmd.Parameters.Add("@table_name", DB2Type.VarChar).Value = "Employee"
                cmd.Parameters.Add("@values", DB2Type.VarChar).Value = setValues
                cmd.Parameters.Add("@condition", DB2Type.VarChar).Value = condition

                cmd.ExecuteNonQuery()
                MessageBox.Show("Record updated successfully.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub


    ' Close button
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Hide()
    End Sub
End Class
