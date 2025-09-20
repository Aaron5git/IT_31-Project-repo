<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierOrderAddEditModal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.suppqtytext = New System.Windows.Forms.TextBox()
        Me.suppidtext = New System.Windows.Forms.TextBox()
        Me.supporderidtext = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.amountpaidtext = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateofpurchasedata = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(52, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 23)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "DATEOFPURCHASE:"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CloseBtn.Location = New System.Drawing.Point(319, 364)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(133, 34)
        Me.CloseBtn.TabIndex = 68
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SaveBtn.Location = New System.Drawing.Point(112, 364)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(133, 34)
        Me.SaveBtn.TabIndex = 67
        Me.SaveBtn.Text = "Save "
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'suppqtytext
        '
        Me.suppqtytext.Location = New System.Drawing.Point(244, 221)
        Me.suppqtytext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.suppqtytext.Name = "suppqtytext"
        Me.suppqtytext.Size = New System.Drawing.Size(152, 22)
        Me.suppqtytext.TabIndex = 66
        '
        'suppidtext
        '
        Me.suppidtext.Location = New System.Drawing.Point(244, 168)
        Me.suppidtext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.suppidtext.Name = "suppidtext"
        Me.suppidtext.Size = New System.Drawing.Size(152, 22)
        Me.suppidtext.TabIndex = 65
        '
        'supporderidtext
        '
        Me.supporderidtext.Location = New System.Drawing.Point(244, 120)
        Me.supporderidtext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.supporderidtext.Name = "supporderidtext"
        Me.supporderidtext.Size = New System.Drawing.Size(152, 22)
        Me.supporderidtext.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(125, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 23)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "SUPPQTY   :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(154, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 23)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "SUPPID :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(91, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 23)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "SUPPORDERID : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(170, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 23)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Supplier Order Details"
        '
        'amountpaidtext
        '
        Me.amountpaidtext.Location = New System.Drawing.Point(244, 311)
        Me.amountpaidtext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.amountpaidtext.Name = "amountpaidtext"
        Me.amountpaidtext.Size = New System.Drawing.Size(152, 22)
        Me.amountpaidtext.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(84, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 23)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "AMOUNTPAID  :"
        '
        'dateofpurchasedata
        '
        Me.dateofpurchasedata.Location = New System.Drawing.Point(244, 265)
        Me.dateofpurchasedata.Name = "dateofpurchasedata"
        Me.dateofpurchasedata.Size = New System.Drawing.Size(152, 22)
        Me.dateofpurchasedata.TabIndex = 73
        '
        'SupplierOrderAddEditModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 485)
        Me.Controls.Add(Me.dateofpurchasedata)
        Me.Controls.Add(Me.amountpaidtext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.suppqtytext)
        Me.Controls.Add(Me.suppidtext)
        Me.Controls.Add(Me.supporderidtext)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Name = "SupplierOrderAddEditModal"
        Me.Text = "SupplierOrderAddEditModal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents suppqtytext As System.Windows.Forms.TextBox
    Friend WithEvents suppidtext As System.Windows.Forms.TextBox
    Friend WithEvents supporderidtext As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents amountpaidtext As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dateofpurchasedata As System.Windows.Forms.DateTimePicker
End Class
