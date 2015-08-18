<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopMenu))
        Me.DateTime = New System.Windows.Forms.TextBox()
        Me.FormSelectorPRI = New System.Windows.Forms.ListBox()
        Me.DestSumbit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTime
        '
        Me.DateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTime.BackColor = System.Drawing.SystemColors.Window
        Me.DateTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DateTime.Cursor = System.Windows.Forms.Cursors.No
        Me.DateTime.Font = New System.Drawing.Font("Poor Richard", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime.ForeColor = System.Drawing.Color.Maroon
        Me.DateTime.Location = New System.Drawing.Point(452, 93)
        Me.DateTime.Multiline = True
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(390, 63)
        Me.DateTime.TabIndex = 3
        '
        'FormSelectorPRI
        '
        Me.FormSelectorPRI.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FormSelectorPRI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormSelectorPRI.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSelectorPRI.FormattingEnabled = True
        Me.FormSelectorPRI.ItemHeight = 19
        Me.FormSelectorPRI.Items.AddRange(New Object() {"Please Select A Destination", "Leasing Agent Interface", "Title Agent Interface", "Administrative Interface", "Reporting Interface", "Financial Interface"})
        Me.FormSelectorPRI.Location = New System.Drawing.Point(275, 529)
        Me.FormSelectorPRI.Name = "FormSelectorPRI"
        Me.FormSelectorPRI.Size = New System.Drawing.Size(204, 23)
        Me.FormSelectorPRI.TabIndex = 1
        '
        'DestSumbit
        '
        Me.DestSumbit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DestSumbit.BackColor = System.Drawing.Color.LawnGreen
        Me.DestSumbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestSumbit.Location = New System.Drawing.Point(485, 529)
        Me.DestSumbit.Name = "DestSumbit"
        Me.DestSumbit.Size = New System.Drawing.Size(68, 24)
        Me.DestSumbit.TabIndex = 2
        Me.DestSumbit.Text = "Submit"
        Me.DestSumbit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(650, 529)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exit Program"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Pristina", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(703, 85)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "O.M.E.G.A. NadaNet Systems"
        '
        'TopMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 9.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(866, 576)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DestSumbit)
        Me.Controls.Add(Me.FormSelectorPRI)
        Me.Controls.Add(Me.DateTime)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TopMenu"
        Me.Text = "LandStalker V 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTime As System.Windows.Forms.TextBox
    Friend WithEvents FormSelectorPRI As System.Windows.Forms.ListBox
    Friend WithEvents DestSumbit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
