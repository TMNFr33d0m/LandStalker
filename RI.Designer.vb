<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RI
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
        Me.Title = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.ReportList = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.OliveDrab
        Me.Title.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(10, 14)
        Me.Title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(317, 38)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Report Interface"
        '
        'Title2
        '
        Me.Title2.AutoSize = True
        Me.Title2.Font = New System.Drawing.Font("Stencil", 10.0!)
        Me.Title2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Title2.Location = New System.Drawing.Point(14, 62)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(386, 17)
        Me.Title2.TabIndex = 1
        Me.Title2.Text = "Please Select The Type Of Report You'd Like To See:"
        '
        'ReportList
        '
        Me.ReportList.FormattingEnabled = True
        Me.ReportList.Items.AddRange(New Object() {"Title Information Report - All Tracts", "Title Information Report - Per Tract by Tract ID / Georeference", "Leasing Report - Open Tracts", "Leasing Report - Leased Tracts", "Leasing Report - All Tracts", "Rule 37 Report - All Rule 37 Status Tracts", "Rule 37 Report - Per Tract by Tract ID / Georeference", "Fiscal Report All Projects", "Fiscal Report Per Project"})
        Me.ReportList.Location = New System.Drawing.Point(20, 90)
        Me.ReportList.Name = "ReportList"
        Me.ReportList.Size = New System.Drawing.Size(171, 21)
        Me.ReportList.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Vijaya", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(204, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Request Report"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(409, 164)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportList)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.Title)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "RI"
        Me.Text = "Report Interface"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Title2 As System.Windows.Forms.Label
    Friend WithEvents ReportList As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
