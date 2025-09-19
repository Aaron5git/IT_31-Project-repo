Imports IBM.Data.DB2

Public Class InventoryAddEditModal
    Dim dbConn As Common.DbConnection

    Private Sub EmployeeAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New DB2Connection("server=localhost;database=cafeproj;uid=db2admin;password=db2admin;")
        dbConn.Open()
    End Sub

    ' Save button: insert new employee or update existing one
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim sqlComm As DB2Command

        Try
            Dim invId As String = invidtext.Text.Trim()
            Dim invName As String = invnametext.Text.Trim()
            Dim currentStock As String = currentstocktext.Text.Trim()
            Dim minStockLevel As String = minstockleveltext.Text.Trim()
            Dim lastUpdated As String = lastupdatedtext.Text.Trim()
            Dim suppliedFrom As String = suppliedfromtext.Text.Trim()


            If invId = "" Then
                MessageBox.Show("INVID is required.")
                Exit Sub
            End If

            ' First check if employee exists
            sqlComm = New DB2Command("SELECT COUNT(*) FROM INVENTORY WHERE INVID = '" & invId & "'", dbConn)
            Dim exists As Integer = CInt(sqlComm.ExecuteScalar())


            If exists > 0 Then
                ' Update
                sqlComm = New DB2Command("UPDATE INVENTORY SET INVNAME = '" & invName & "', CURRENTSTOCK = '" & currentStock & "', MINSTOCKLEVEL = '" & minStockLevel & "', LASTUPDATED = '" & lastUpdated & "', SUPPLIED_FORM = '" & suppliedFrom & "' WHERE INVID = '" & invId & "'", dbConn)
                Dim rowsUpdated As Integer = sqlComm.ExecuteNonQuery()
                MessageBox.Show(rowsUpdated.ToString() & " record(s) updated successfully.")
            Else
                ' Insert
                sqlComm = New DB2Command("INSERT INTO INVENTORY (INVID, INVNAME, CURRENTSTOCK, MINSTOCKLEVEL, LASTUPDATED, SUPPLIED_FROM) VALUES ('" & invId & "', '" & invName & "', '" & currentStock & "', '" & minStockLevel & "', '" & lastUpdated & "', '" & suppliedFrom & "')", dbConn)
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
