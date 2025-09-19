<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderAddEditModal
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
        Me.orderidtext = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.custidtext = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.prodspurchtext = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.amountpaidtext = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.orderqtytext = New System.Windows.Forms.TextBox()
        Me.orderdatetext = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'orderidtext
        '
        Me.orderidtext.Location = New System.Drawing.Point(210, 122)
        Me.orderidtext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.orderidtext.Name = "orderidtext"
        Me.orderidtext.Size = New System.Drawing.Size(152, 22)
        Me.orderidtext.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(108, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "ORDERID: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(136, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 23)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Order Record Details"
        '
        'custidtext
        '
        Me.custidtext.Location = New System.Drawing.Point(210, 335)
        Me.custidtext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.custidtext.Name = "custidtext"
        Me.custidtext.Size = New System.Drawing.Size(152, 22)
        Me.custidtext.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(108, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "CUSTID  :"
        '
        'prodspurchtext
        '
        Me.prodspurchtext.Location = New System.Drawing.Point(210, 297)
        Me.prodspurchtext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.prodspurchtext.Name = "prodspurchtext"
        Me.prodspurchtext.Size = New System.Drawing.Size(152, 22)
        Me.prodspurchtext.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(62, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 23)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "PRODSPURCH :"
        '
        'amountpaidtext
        '
        Me.amountpaidtext.Location = New System.Drawing.Point(210, 257)
        Me.amountpaidtext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.amountpaidtext.Name = "amountpaidtext"
        Me.amountpaidtext.Size = New System.Drawing.Size(152, 22)
        Me.amountpaidtext.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(62, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "AMOUNTPAID :"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CloseBtn.Location = New System.Drawing.Point(283, 389)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(133, 34)
        Me.CloseBtn.TabIndex = 70
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SaveBtn.Location = New System.Drawing.Point(71, 389)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(133, 34)
        Me.SaveBtn.TabIndex = 69
        Me.SaveBtn.Text = "Save "
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'orderqtytext
        '
        Me.orderqtytext.Location = New System.Drawing.Point(210, 214)
        Me.orderqtytext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.orderqtytext.Name = "orderqtytext"
        Me.orderqtytext.Size = New System.Drawing.Size(152, 22)
        Me.orderqtytext.TabIndex = 68
        '
        'orderdatetext
        '
        Me.orderdatetext.Location = New System.Drawing.Point(210, 161)
        Me.orderdatetext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.orderdatetext.Name = "orderdatetext"
        Me.orderdatetext.Size = New System.Drawing.Size(152, 22)
        Me.orderdatetext.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(88, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 23)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "ORDERQTY :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(77, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 23)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "ORDERDATE :"
        '
        'OrdersAddEditModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 499)
        Me.Controls.Add(Me.custidtext)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.prodspurchtext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.amountpaidtext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.orderqtytext)
        Me.Controls.Add(Me.orderdatetext)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.orderidtext)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Name = "OrdersAddEditModal"
        Me.Text = "OrdersAddEditModal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents orderidtext As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents custidtext As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents prodspurchtext As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents amountpaidtext As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents orderqtytext As System.Windows.Forms.TextBox
    Friend WithEvents orderdatetext As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
