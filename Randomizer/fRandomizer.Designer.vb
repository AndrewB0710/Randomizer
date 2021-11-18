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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRandomName = New System.Windows.Forms.Label()
        Me.btnRandomize = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nmQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.nmQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblRandomName)
        Me.Panel1.Controls.Add(Me.btnRandomize)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 484)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 91)
        Me.Panel1.TabIndex = 7
        '
        'lblRandomName
        '
        Me.lblRandomName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRandomName.Location = New System.Drawing.Point(23, 11)
        Me.lblRandomName.Name = "lblRandomName"
        Me.lblRandomName.Size = New System.Drawing.Size(181, 40)
        Me.lblRandomName.TabIndex = 1
        Me.lblRandomName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRandomize
        '
        Me.btnRandomize.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRandomize.Location = New System.Drawing.Point(59, 63)
        Me.btnRandomize.Name = "btnRandomize"
        Me.btnRandomize.Size = New System.Drawing.Size(109, 23)
        Me.btnRandomize.TabIndex = 0
        Me.btnRandomize.Text = "Randomize"
        Me.btnRandomize.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblQuantity)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.nmQuantity)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.txtNames)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 377)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(234, 107)
        Me.Panel3.TabIndex = 0
        '
        'lblQuantity
        '
        Me.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(26, 59)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(53, 15)
        Me.lblQuantity.TabIndex = 6
        Me.lblQuantity.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Add Name"
        '
        'nmQuantity
        '
        Me.nmQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.nmQuantity.Location = New System.Drawing.Point(26, 77)
        Me.nmQuantity.Name = "nmQuantity"
        Me.nmQuantity.Size = New System.Drawing.Size(47, 23)
        Me.nmQuantity.TabIndex = 4
        Me.nmQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAdd.Location = New System.Drawing.Point(95, 77)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(109, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtNames
        '
        Me.txtNames.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNames.Location = New System.Drawing.Point(11, 25)
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Size = New System.Drawing.Size(210, 23)
        Me.txtNames.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(234, 0)
        Me.Panel4.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Location = New System.Drawing.Point(60, 348)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lstNames
        '
        Me.lstNames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 15
        Me.lstNames.Location = New System.Drawing.Point(12, 8)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(210, 334)
        Me.lstNames.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lstNames)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 484)
        Me.Panel2.TabIndex = 8
        '
        'fRandomizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 575)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(250, 39)
        Me.Name = "fRandomizer"
        Me.Text = "Randomizer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.nmQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRandomName As Label
    Friend WithEvents btnRandomize As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nmQuantity As NumericUpDown
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtNames As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents lstNames As ListBox
    Friend WithEvents Panel2 As Panel
End Class
