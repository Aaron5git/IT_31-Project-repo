<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.Search_bar = New System.Windows.Forms.TextBox()
        Me.AddEditBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.EmpBtn = New System.Windows.Forms.Button()
        Me.SuppOrdBtn = New System.Windows.Forms.Button()
        Me.OrdersBtn = New System.Windows.Forms.Button()
        Me.InventBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReturnBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProductBtn = New System.Windows.Forms.Button()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search_bar
        '
        Me.Search_bar.Location = New System.Drawing.Point(304, 156)
        Me.Search_bar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Search_bar.Name = "Search_bar"
        Me.Search_bar.Size = New System.Drawing.Size(344, 22)
        Me.Search_bar.TabIndex = 41
        Me.Search_bar.Text = "Enter Item"
        '
        'AddEditBtn
        '
        Me.AddEditBtn.BackColor = System.Drawing.Color.Lime
        Me.AddEditBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.AddEditBtn.Location = New System.Drawing.Point(654, 143)
        Me.AddEditBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddEditBtn.Name = "AddEditBtn"
        Me.AddEditBtn.Size = New System.Drawing.Size(99, 39)
        Me.AddEditBtn.TabIndex = 42
        Me.AddEditBtn.Text = "Add/Edit"
        Me.AddEditBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.IndianRed
        Me.DeleteBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DeleteBtn.Location = New System.Drawing.Point(759, 143)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(109, 39)
        Me.DeleteBtn.TabIndex = 43
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'DataGrid
        '
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(304, 207)
        Me.DataGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(564, 319)
        Me.DataGrid.TabIndex = 45
        '
        'EmpBtn
        '
        Me.EmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmpBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.EmpBtn.Location = New System.Drawing.Point(1, 196)
        Me.EmpBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpBtn.Name = "EmpBtn"
        Me.EmpBtn.Size = New System.Drawing.Size(251, 38)
        Me.EmpBtn.TabIndex = 68
        Me.EmpBtn.Text = "Employees"
        Me.EmpBtn.UseVisualStyleBackColor = True
        '
        'SuppOrdBtn
        '
        Me.SuppOrdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SuppOrdBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SuppOrdBtn.Location = New System.Drawing.Point(1, 315)
        Me.SuppOrdBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SuppOrdBtn.Name = "SuppOrdBtn"
        Me.SuppOrdBtn.Size = New System.Drawing.Size(251, 38)
        Me.SuppOrdBtn.TabIndex = 69
        Me.SuppOrdBtn.Text = "Suppliers"
        Me.SuppOrdBtn.UseVisualStyleBackColor = True
        '
        'OrdersBtn
        '
        Me.OrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrdersBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.OrdersBtn.Location = New System.Drawing.Point(1, 255)
        Me.OrdersBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.OrdersBtn.Name = "OrdersBtn"
        Me.OrdersBtn.Size = New System.Drawing.Size(251, 38)
        Me.OrdersBtn.TabIndex = 70
        Me.OrdersBtn.Text = "Orders"
        Me.OrdersBtn.UseVisualStyleBackColor = True
        '
        'InventBtn
        '
        Me.InventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.InventBtn.Location = New System.Drawing.Point(1, 143)
        Me.InventBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.InventBtn.Name = "InventBtn"
        Me.InventBtn.Size = New System.Drawing.Size(251, 38)
        Me.InventBtn.TabIndex = 71
        Me.InventBtn.Text = "Inventory"
        Me.InventBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(73, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 36)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 29)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.YellowGreen
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(87, 426)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 29)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Return"
        '
        'ReturnBtn
        '
        Me.ReturnBtn.BackColor = System.Drawing.Color.White
        Me.ReturnBtn.FlatAppearance.BorderSize = 0
        Me.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.ReturnBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ReturnBtn.Location = New System.Drawing.Point(92, 457)
        Me.ReturnBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReturnBtn.Name = "ReturnBtn"
        Me.ReturnBtn.Size = New System.Drawing.Size(75, 60)
        Me.ReturnBtn.TabIndex = 76
        Me.ReturnBtn.Text = "←"
        Me.ReturnBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ReturnBtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.YellowGreen
        Me.PictureBox2.Location = New System.Drawing.Point(1, 116)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(251, 432)
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.IT_31_A_Project.My.Resources.Resources.cafe_name
        Me.PictureBox5.Location = New System.Drawing.Point(656, 10)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(233, 86)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = Global.IT_31_A_Project.My.Resources.Resources.logo_placeholder
        Me.PictureBox4.Location = New System.Drawing.Point(527, 10)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(124, 86)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(903, 118)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ProductBtn
        '
        Me.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ProductBtn.Location = New System.Drawing.Point(1, 370)
        Me.ProductBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductBtn.Name = "ProductBtn"
        Me.ProductBtn.Size = New System.Drawing.Size(251, 38)
        Me.ProductBtn.TabIndex = 78
        Me.ProductBtn.Text = "Products"
        Me.ProductBtn.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 548)
        Me.Controls.Add(Me.ProductBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InventBtn)
        Me.Controls.Add(Me.OrdersBtn)
        Me.Controls.Add(Me.SuppOrdBtn)
        Me.Controls.Add(Me.EmpBtn)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.AddEditBtn)
        Me.Controls.Add(Me.Search_bar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Search_bar As System.Windows.Forms.TextBox
    Friend WithEvents AddEditBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents EmpBtn As System.Windows.Forms.Button
    Friend WithEvents SuppOrdBtn As System.Windows.Forms.Button
    Friend WithEvents OrdersBtn As System.Windows.Forms.Button
    Friend WithEvents InventBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ReturnBtn As System.Windows.Forms.Button
    Friend WithEvents ProductBtn As System.Windows.Forms.Button
End Class
