<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cust_Name = New System.Windows.Forms.TextBox()
        Me.Cust_PhoneNum = New System.Windows.Forms.TextBox()
        Me.Item_Select = New System.Windows.Forms.TextBox()
        Me.Item_Quantity = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.OrderedItemsTable = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EditOrdersBtn = New System.Windows.Forms.Button()
        Me.DeleteOrdersBtn = New System.Windows.Forms.Button()
        Me.SaveOrderBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Cust_Address = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Item_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderedItemsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(50, 426)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 49)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "←"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(222, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Customer Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(490, 115)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Order Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(222, 155)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Name: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(222, 194)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Phone no:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(222, 233)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(490, 155)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Item:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(485, 190)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Quantity: "
        '
        'Cust_Name
        '
        Me.Cust_Name.Location = New System.Drawing.Point(289, 151)
        Me.Cust_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.Cust_Name.Name = "Cust_Name"
        Me.Cust_Name.Size = New System.Drawing.Size(115, 20)
        Me.Cust_Name.TabIndex = 19
        '
        'Cust_PhoneNum
        '
        Me.Cust_PhoneNum.Location = New System.Drawing.Point(289, 190)
        Me.Cust_PhoneNum.Margin = New System.Windows.Forms.Padding(2)
        Me.Cust_PhoneNum.Name = "Cust_PhoneNum"
        Me.Cust_PhoneNum.Size = New System.Drawing.Size(115, 20)
        Me.Cust_PhoneNum.TabIndex = 20
        '
        'Item_Select
        '
        Me.Item_Select.Location = New System.Drawing.Point(548, 151)
        Me.Item_Select.Margin = New System.Windows.Forms.Padding(2)
        Me.Item_Select.Name = "Item_Select"
        Me.Item_Select.Size = New System.Drawing.Size(115, 20)
        Me.Item_Select.TabIndex = 22
        '
        'Item_Quantity
        '
        Me.Item_Quantity.Location = New System.Drawing.Point(548, 190)
        Me.Item_Quantity.Margin = New System.Windows.Forms.Padding(2)
        Me.Item_Quantity.Name = "Item_Quantity"
        Me.Item_Quantity.Size = New System.Drawing.Size(114, 20)
        Me.Item_Quantity.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(343, 302)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 18)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Ordered Items Table"
        '
        'OrderedItemsTable
        '
        Me.OrderedItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderedItemsTable.Location = New System.Drawing.Point(208, 330)
        Me.OrderedItemsTable.Margin = New System.Windows.Forms.Padding(2)
        Me.OrderedItemsTable.Name = "OrderedItemsTable"
        Me.OrderedItemsTable.RowTemplate.Height = 24
        Me.OrderedItemsTable.Size = New System.Drawing.Size(381, 135)
        Me.OrderedItemsTable.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(627, 302)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 18)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Action"
        '
        'EditOrdersBtn
        '
        Me.EditOrdersBtn.BackColor = System.Drawing.Color.Lime
        Me.EditOrdersBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.EditOrdersBtn.Location = New System.Drawing.Point(597, 330)
        Me.EditOrdersBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.EditOrdersBtn.Name = "EditOrdersBtn"
        Me.EditOrdersBtn.Size = New System.Drawing.Size(56, 24)
        Me.EditOrdersBtn.TabIndex = 27
        Me.EditOrdersBtn.Text = "Edit"
        Me.EditOrdersBtn.UseVisualStyleBackColor = False
        '
        'DeleteOrdersBtn
        '
        Me.DeleteOrdersBtn.BackColor = System.Drawing.Color.IndianRed
        Me.DeleteOrdersBtn.Font = New System.Drawing.Font("Palatino Linotype", 8.75!, System.Drawing.FontStyle.Bold)
        Me.DeleteOrdersBtn.Location = New System.Drawing.Point(657, 330)
        Me.DeleteOrdersBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.DeleteOrdersBtn.Name = "DeleteOrdersBtn"
        Me.DeleteOrdersBtn.Size = New System.Drawing.Size(56, 24)
        Me.DeleteOrdersBtn.TabIndex = 28
        Me.DeleteOrdersBtn.Text = "Delete"
        Me.DeleteOrdersBtn.UseVisualStyleBackColor = False
        '
        'SaveOrderBtn
        '
        Me.SaveOrderBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.SaveOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveOrderBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SaveOrderBtn.Location = New System.Drawing.Point(208, 479)
        Me.SaveOrderBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveOrderBtn.Name = "SaveOrderBtn"
        Me.SaveOrderBtn.Size = New System.Drawing.Size(100, 28)
        Me.SaveOrderBtn.TabIndex = 29
        Me.SaveOrderBtn.Text = "Save Order"
        Me.SaveOrderBtn.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CloseBtn.Location = New System.Drawing.Point(488, 479)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(100, 28)
        Me.CloseBtn.TabIndex = 30
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'Cust_Address
        '
        Me.Cust_Address.Location = New System.Drawing.Point(289, 233)
        Me.Cust_Address.Margin = New System.Windows.Forms.Padding(2)
        Me.Cust_Address.Name = "Cust_Address"
        Me.Cust_Address.Size = New System.Drawing.Size(115, 20)
        Me.Cust_Address.TabIndex = 33
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = Global.IT_31_A_Project.My.Resources.Resources.logo_placeholder
        Me.PictureBox4.Location = New System.Drawing.Point(433, 7)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(87, 66)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.IT_31_A_Project.My.Resources.Resources.cafe_name
        Me.PictureBox5.Location = New System.Drawing.Point(527, 7)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(186, 70)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 34
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(722, 91)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.YellowGreen
        Me.PictureBox2.Location = New System.Drawing.Point(-2, 89)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(188, 429)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(-2, 233)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(188, 31)
        Me.Button5.TabIndex = 69
        Me.Button5.Text = "Inventory"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(-2, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 31)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "View Orders"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(-2, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 31)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "New Orders"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Niagara Solid", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(63, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 26)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Niagara Solid", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Cashier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.YellowGreen
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 23)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Return"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 517)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Cust_Address)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveOrderBtn)
        Me.Controls.Add(Me.DeleteOrdersBtn)
        Me.Controls.Add(Me.EditOrdersBtn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.OrderedItemsTable)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Item_Quantity)
        Me.Controls.Add(Me.Item_Select)
        Me.Controls.Add(Me.Cust_PhoneNum)
        Me.Controls.Add(Me.Cust_Name)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Item_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderedItemsTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Cust_Name As System.Windows.Forms.TextBox
    Friend WithEvents Cust_PhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents Item_Select As System.Windows.Forms.TextBox
    Friend WithEvents Item_Quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents OrderedItemsTable As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents EditOrdersBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteOrdersBtn As System.Windows.Forms.Button
    Friend WithEvents SaveOrderBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents Cust_Address As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
