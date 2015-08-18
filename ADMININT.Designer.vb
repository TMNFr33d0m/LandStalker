<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMININT
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
        Me.Admnintlbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Admnintlbl
        '
        Me.Admnintlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Admnintlbl.AutoSize = True
        Me.Admnintlbl.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Admnintlbl.Cursor = System.Windows.Forms.Cursors.No
        Me.Admnintlbl.Font = New System.Drawing.Font("Lucida Handwriting", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admnintlbl.Location = New System.Drawing.Point(7, 10)
        Me.Admnintlbl.Name = "Admnintlbl"
        Me.Admnintlbl.Size = New System.Drawing.Size(507, 37)
        Me.Admnintlbl.TabIndex = 0
        Me.Admnintlbl.Text = "Administrative User Interface"
        '
        'ADMININT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(876, 528)
        Me.Controls.Add(Me.Admnintlbl)
        Me.Name = "ADMININT"
        Me.Text = "Administrative User Interface Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Admnintlbl As System.Windows.Forms.Label
End Class
