<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductAddEditModal
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.prodnametext = New System.Windows.Forms.TextBox()
        Me.prodidtext = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prodpricetext = New System.Windows.Forms.TextBox()
        Me.prodtypedata = New System.Windows.Forms.ComboBox()
        Me.prodstatusdata = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(94, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 23)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "PRODSTATUS  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(118, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 23)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "PRODPRICE:"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CloseBtn.Location = New System.Drawing.Point(329, 355)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(133, 34)
        Me.CloseBtn.TabIndex = 82
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = false
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SaveBtn.Location = New System.Drawing.Point(122, 355)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(133, 34)
        Me.SaveBtn.TabIndex = 81
        Me.SaveBtn.Text = "Save "
        Me.SaveBtn.UseVisualStyleBackColor = false
        '
        'prodnametext
        '
        Me.prodnametext.Location = New System.Drawing.Point(254, 159)
        Me.prodnametext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.prodnametext.Name = "prodnametext"
        Me.prodnametext.Size = New System.Drawing.Size(152, 22)
        Me.prodnametext.TabIndex = 79
        '
        'prodidtext
        '
        Me.prodidtext.Location = New System.Drawing.Point(254, 111)
        Me.prodidtext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.prodidtext.Name = "prodidtext"
        Me.prodidtext.Size = New System.Drawing.Size(152, 22)
        Me.prodidtext.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(122, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 23)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "PRODTYPE :"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(114, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 23)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "PRODNAME:"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(148, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 23)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "PRODID : "
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(196, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 23)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Product Details"
        '
        'prodpricetext
        '
        Me.prodpricetext.Location = New System.Drawing.Point(254, 255)
        Me.prodpricetext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.prodpricetext.Name = "prodpricetext"
        Me.prodpricetext.Size = New System.Drawing.Size(152, 22)
        Me.prodpricetext.TabIndex = 86
        '
        'prodtypedata
        '
        Me.prodtypedata.FormattingEnabled = true
        Me.prodtypedata.Items.AddRange(New Object() {"coffee", "snack", "meal", "drink"})
        Me.prodtypedata.Location = New System.Drawing.Point(254, 211)
        Me.prodtypedata.Name = "prodtypedata"
        Me.prodtypedata.Size = New System.Drawing.Size(152, 24)
        Me.prodtypedata.TabIndex = 87
        '
        'prodstatusdata
        '
        Me.prodstatusdata.FormattingEnabled = True
        Me.prodstatusdata.Items.AddRange(New Object() {"AVAIL", "UNAV"})
        Me.prodstatusdata.Location = New System.Drawing.Point(254, 300)
        Me.prodstatusdata.Name = "prodstatusdata"
        Me.prodstatusdata.Size = New System.Drawing.Size(152, 24)
        Me.prodstatusdata.TabIndex = 88
        '
        'ProductAddEditModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 463)
        Me.Controls.Add(Me.prodstatusdata)
        Me.Controls.Add(Me.prodtypedata)
        Me.Controls.Add(Me.prodpricetext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.prodnametext)
        Me.Controls.Add(Me.prodidtext)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Name = "ProductAddEditModal"
        Me.Text = "ProductAddEditModal"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents prodnametext As System.Windows.Forms.TextBox
    Friend WithEvents prodidtext As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents prodpricetext As System.Windows.Forms.TextBox
    Friend WithEvents prodtypedata As System.Windows.Forms.ComboBox
    Friend WithEvents prodstatusdata As System.Windows.Forms.ComboBox
End Class
