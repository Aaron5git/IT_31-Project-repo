Imports IBM.Data.DB2
Public Class posArea
    Private dbconn As Common.DbConnection
    Private rowIndex As Integer

    Private Sub posArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 767
        With Me.dgvOrderGrid
            .ColumnCount = 4
            .Columns(0).Name = "ID"
            .Columns(1).Name = "Name"
            .Columns(2).Name = "Quantity"
            .Columns(3).Name = "Price"
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cust_Name_TextChanged(sender As Object, e As EventArgs) Handles Cust_Name.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub DeleteOrdersBtn_Click(sender As Object, e As EventArgs) Handles DeleteOrdersBtn.Click
        Dim quantity As Integer
        Dim row As String

        quantity = quantNum.Text
        quantity -= 1
        If (quantity <= 0) Then
            dgvOrderGrid.Rows.RemoveAt(rowIndex)
            quantNum.Text = "0"
            costArea.Text = "0.0"
        Else
            quantNum.Text = quantity
            dgvOrderGrid.Rows(rowIndex).Cells(2).Value = quantity
            quantityAdder()
        End If
    End Sub

    Private Sub EditOrdersBtn_Click(sender As Object, e As EventArgs) Handles EditOrdersBtn.Click
        Dim quantity As Integer
        Dim row As String

        quantity = quantNum.Text
        quantity += 1
        quantNum.Text = quantity

        dgvOrderGrid.Rows(rowIndex).Cells(2).Value = quantity
        quantityAdder()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Width = 984
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Width = 767
    End Sub

    Private Sub btnOpenProdList_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOpenProdList.MouseUp
        Dim modal As New prodModal
        modal.prodType = "COFFEE"
        modal.ShowDialog()
    End Sub

    Private Sub Button11_MouseUp(sender As Object, e As MouseEventArgs) Handles Button11.MouseUp
        Dim modal As New prodModal
        modal.prodType = "DRINKS"
        modal.ShowDialog()
    End Sub

    Private Sub dgvOrderGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvOrderGrid.RowsAdded
        quantityAdder()
    End Sub

    Private Sub dgvOrderGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderGrid.CellContentClick
        If dgvOrderGrid.Rows.Count > 0 Then
            quantNum.Text = dgvOrderGrid.CurrentRow.Cells(2).Value
            rowIndex = dgvOrderGrid.CurrentRow.Index
        End If
    End Sub

    Private Sub quantityAdder()
        Dim totalCost As Double = 0.0
        If dgvOrderGrid.Rows.Count > 0 Then
            Try
                For Each row As DataGridViewRow In dgvOrderGrid.Rows
                    totalCost = totalCost + (row.Cells(2).Value * row.Cells(3).Value)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        costArea.Text = totalCost
    End Sub
End Class