<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fRandomizer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fRandomizer))
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.nmQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRandomName = New System.Windows.Forms.Label()
        Me.btnRandomize = New System.Windows.Forms.Button()
        CType(Me.nmQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 15
        Me.lstNames.Location = New System.Drawing.Point(24, 12)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(178, 259)
        Me.lstNames.TabIndex = 0
        '
        'txtNames
        '
        Me.txtNames.Location = New System.Drawing.Point(24, 343)
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Size = New System.Drawing.Size(178, 23)
        Me.txtNames.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(93, 395)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(109, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(58, 277)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'nmQuantity
        '
        Me.nmQuantity.Location = New System.Drawing.Point(24, 395)
        Me.nmQuantity.Name = "nmQuantity"
        Me.nmQuantity.Size = New System.Drawing.Size(47, 23)
        Me.nmQuantity.TabIndex = 4
        Me.nmQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Add Name"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(24, 373)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(53, 15)
        Me.lblQuantity.TabIndex = 6
        Me.lblQuantity.Text = "Quantity"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblRandomName)
        Me.Panel1.Controls.Add(Me.btnRandomize)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 424)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 151)
        Me.Panel1.TabIndex = 7
        '
        'lblRandomName
        '
        Me.lblRandomName.Location = New System.Drawing.Point(23, 33)
        Me.lblRandomName.Name = "lblRandomName"
        Me.lblRandomName.Size = New System.Drawing.Size(178, 40)
        Me.lblRandomName.TabIndex = 1
        '
        'btnRandomize
        '
        Me.btnRandomize.Location = New System.Drawing.Point(57, 115)
        Me.btnRandomize.Name = "btnRandomize"
        Me.btnRandomize.Size = New System.Drawing.Size(109, 23)
        Me.btnRandomize.TabIndex = 0
        Me.btnRandomize.Text = "Randomize"
        Me.btnRandomize.UseVisualStyleBackColor = True
        '
        'fRandomizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 575)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nmQuantity)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.lstNames)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fRandomizer"
        Me.Text = "Randomizer"
        CType(Me.nmQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstNames As ListBox
    Friend WithEvents txtNames As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents nmQuantity As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRandomName As Label
    Friend WithEvents btnRandomize As Button
End Class
