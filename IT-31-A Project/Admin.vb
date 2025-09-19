Imports IBM.Data.DB2
Public Class Admin

    'DB2 connection string for localhost
    Dim connString As String = "Server=localhost;Database=cafeproj;UID=db2admin;PWD=db2admin;"
    Dim conn As New DB2Connection(connString)

    ' Form Load: Open DB2 connection and disable Delete button
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            DeleteBtn.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Failed to connect to DB2: " & ex.Message)
        End Try
    End Sub

    ' Generic method to load data into DataGrid
    Private Sub LoadData(query As String)
        Try
            Dim cmd As New DB2Command(query, conn)
            Dim adapter As New DB2DataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGrid.DataSource = table
            DataGrid.ClearSelection()
            DeleteBtn.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    ' Inventory button click
    Private Sub InventBtn_Click(sender As Object, e As EventArgs) Handles InventBtn.Click
        Dim sql As String = "SELECT invID, invName, currentstock, minstocklevel, lastupdated, supplied_from FROM Inventory"
        LoadData(sql)
    End Sub

    ' Employees button click
    Private Sub EmpBtn_Click(sender As Object, e As EventArgs) Handles EmpBtn.Click
        Dim sql As String = "SELECT EmpID, EmpName, EmpType, DepID FROM Employee"
        LoadData(sql)
    End Sub

    ' Orders button click
    Private Sub OrdersBtn_Click(sender As Object, e As EventArgs) Handles OrdersBtn.Click
        Dim sql As String = "SELECT orderID, orderdate, orderqty, amountpaid, prodspurch, custid FROM Order"
        LoadData(sql)
    End Sub

    ' Suppliers button click
    Private Sub SuppOrdBtn_Click(sender As Object, e As EventArgs) Handles SuppOrdBtn.Click
        Dim sql As String = "SELECT supporderid, suppID, dateofpurchase, amountpaid FROM SuppOrder"
        LoadData(sql)
    End Sub

    ' Enable Delete button only when a row with actual data is selected
    Private Sub DataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles DataGrid.SelectionChanged
        DeleteBtn.Enabled = False

        If DataGrid.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGrid.SelectedRows(0)
            For Each cell As DataGridViewCell In selectedRow.Cells
                If cell.Value IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cell.Value.ToString()) Then
                    DeleteBtn.Enabled = True
                    Exit For
                End If
            Next
        End If
    End Sub

    ' Delete record using stored procedure DELETE_GENERAL
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                If DataGrid.SelectedRows.Count = 0 Then
                    MessageBox.Show("Please select a row to delete.")
                    Exit Sub
                End If

                Dim currentTable As String = ""
                Dim condition As String = ""

                If DataGrid.Columns.Contains("invID") Then
                    currentTable = "Inventory"
                    Dim invID As String = DataGrid.SelectedRows(0).Cells("invID").Value.ToString()
                    condition = "invID = '" & invID & "'"

                ElseIf DataGrid.Columns.Contains("EmpID") Then
                    currentTable = "Employee"
                    Dim empID As String = DataGrid.SelectedRows(0).Cells("EmpID").Value.ToString()
                    condition = "EmpID = " & empID

                ElseIf DataGrid.Columns.Contains("orderID") Then
                    currentTable = "Order"
                    Dim orderID As String = DataGrid.SelectedRows(0).Cells("orderID").Value.ToString()
                    condition = "orderID = " & orderID

                ElseIf DataGrid.Columns.Contains("supporderid") Then
                    currentTable = "SuppOrder"
                    Dim suppOrderID As String = DataGrid.SelectedRows(0).Cells("supporderid").Value.ToString()
                    condition = "supporderid = " & suppOrderID

                Else
                    MessageBox.Show("Unknown table or unsupported delete operation.")
                    Exit Sub
                End If

                ' Call the stored procedure DELETE_GENERAL
                Dim cmd As New DB2Command("CALL DELETE_GENERAL(?, ?)", conn)
                cmd.Parameters.Add("@table_name", DB2Type.VarChar).Value = currentTable
                cmd.Parameters.Add("@condition", DB2Type.VarChar).Value = condition
                cmd.ExecuteNonQuery()

                MessageBox.Show("Record deleted successfully.")

                ' Refresh the grid
                Select Case currentTable
                    Case "Inventory"
                        InventBtn_Click(Nothing, Nothing)
                    Case "Employee"
                        EmpBtn_Click(Nothing, Nothing)
                    Case "Order"
                        OrdersBtn_Click(Nothing, Nothing)
                    Case "SuppOrder"
                        SuppOrdBtn_Click(Nothing, Nothing)
                End Select

            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message)
            End Try

        End If
    End Sub

    ' Return button click: close Admin form
    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Me.Close()
    End Sub

    ' Add/Edit button click: open the correct modal depending on which table is active
    Private Sub AddEditBtn_Click(sender As Object, e As EventArgs) Handles AddEditBtn.Click
        Try
            If DataGrid.Columns.Contains("INVID") Then
                ' Inventory modal
                Dim modal As New InventoryAddEditModal()
                modal.ShowDialog()
                InventBtn_Click(Nothing, Nothing) ' refresh grid

            ElseIf DataGrid.Columns.Contains("EMPID") Then
                ' Employee modal
                Dim modal As New EmployeeAddEditModal()
                modal.ShowDialog()
                EmpBtn_Click(Nothing, Nothing)

            ElseIf DataGrid.Columns.Contains("ORDERID") Then
                ' Orders modal
                Dim modal As New OrderAddEditModal()
                modal.ShowDialog()
                OrdersBtn_Click(Nothing, Nothing)

            ElseIf DataGrid.Columns.Contains("SUPPORDERID") Then
                ' Supplier Order modal
                Dim modal As New SupplierOrderAddEditModal()
                modal.ShowDialog()
                SuppOrdBtn_Click(Nothing, Nothing)

            Else
                MessageBox.Show("Please select a valid table view before adding or editing.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error opening modal: " & ex.Message)
        End Try
    End Sub

End Class