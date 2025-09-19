<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryAddEditModal
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
        Me.currentstocktext = New System.Windows.Forms.TextBox()
        Me.invnametext = New System.Windows.Forms.TextBox()
        Me.invidtext = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.minstockleveltext = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lastupdatedtext = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.suppliedfromtext = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'currentstocktext
        '
        Me.currentstocktext.Location = New System.Drawing.Point(232, 190)
        Me.currentstocktext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.currentstocktext.Name = "currentstocktext"
        Me.currentstocktext.Size = New System.Drawing.Size(152, 22)
        Me.currentstocktext.TabIndex = 40
        '
        'invnametext
        '
        Me.invnametext.Location = New System.Drawing.Point(232, 137)
        Me.invnametext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.invnametext.Name = "invnametext"
        Me.invnametext.Size = New System.Drawing.Size(152, 22)
        Me.invnametext.TabIndex = 39
        '
        'invidtext
        '
        Me.invidtext.Location = New System.Drawing.Point(232, 89)
        Me.invidtext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.invidtext.Name = "invidtext"
        Me.invidtext.Size = New System.Drawing.Size(152, 22)
        Me.invidtext.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(68, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 23)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "CURRENTSTOCK:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(121, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 23)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "INVNAME :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(143, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 23)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "INVID: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(158, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 23)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Inventory  Record Details"
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SaveBtn.Location = New System.Drawing.Point(93, 365)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(133, 34)
        Me.SaveBtn.TabIndex = 41
        Me.SaveBtn.Text = "Save "
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CloseBtn.Location = New System.Drawing.Point(305, 365)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(133, 34)
        Me.CloseBtn.TabIndex = 42
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'minstockleveltext
        '
        Me.minstockleveltext.Location = New System.Drawing.Point(232, 233)
        Me.minstockleveltext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.minstockleveltext.Name = "minstockleveltext"
        Me.minstockleveltext.Size = New System.Drawing.Size(152, 22)
        Me.minstockleveltext.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(68, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 23)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "MINSTOCKLEVEL :"
        '
        'lastupdatedtext
        '
        Me.lastupdatedtext.Location = New System.Drawing.Point(232, 273)
        Me.lastupdatedtext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lastupdatedtext.Name = "lastupdatedtext"
        Me.lastupdatedtext.Size = New System.Drawing.Size(152, 22)
        Me.lastupdatedtext.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(68, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 23)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "LASTUPDATED :"
        '
        'suppliedfromtext
        '
        Me.suppliedfromtext.Location = New System.Drawing.Point(232, 311)
        Me.suppliedfromtext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.suppliedfromtext.Name = "suppliedfromtext"
        Me.suppliedfromtext.Size = New System.Drawing.Size(152, 22)
        Me.suppliedfromtext.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(68, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 23)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "SUPPLIED_FROM :"
        '
        'InventoryAddEditModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 454)
        Me.Controls.Add(Me.suppliedfromtext)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lastupdatedtext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.minstockleveltext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.currentstocktext)
        Me.Controls.Add(Me.invnametext)
        Me.Controls.Add(Me.invidtext)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Name = "InventoryAddEditModal"
        Me.Text = "InventoryAddEditModal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents currentstocktext As System.Windows.Forms.TextBox
    Friend WithEvents invnametext As System.Windows.Forms.TextBox
    Friend WithEvents invidtext As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents minstockleveltext As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lastupdatedtext As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents suppliedfromtext As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
