<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CalcButton1 = New System.Windows.Forms.Button()
        Me.axLabel = New System.Windows.Forms.Label()
        Me.bxLabel = New System.Windows.Forms.Label()
        Me.cLabel = New System.Windows.Forms.Label()
        Me.x1Label = New System.Windows.Forms.Label()
        Me.x2Label = New System.Windows.Forms.Label()
        Me.axT = New System.Windows.Forms.TextBox()
        Me.bxT = New System.Windows.Forms.TextBox()
        Me.cT = New System.Windows.Forms.TextBox()
        Me.x2 = New System.Windows.Forms.TextBox()
        Me.x1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CalcButton1
        '
        Me.CalcButton1.Location = New System.Drawing.Point(125, 96)
        Me.CalcButton1.Name = "CalcButton1"
        Me.CalcButton1.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton1.TabIndex = 0
        Me.CalcButton1.Text = "Calc"
        Me.CalcButton1.UseVisualStyleBackColor = True
        '
        'axLabel
        '
        Me.axLabel.AutoSize = True
        Me.axLabel.Location = New System.Drawing.Point(12, 24)
        Me.axLabel.Name = "axLabel"
        Me.axLabel.Size = New System.Drawing.Size(21, 13)
        Me.axLabel.TabIndex = 1
        Me.axLabel.Text = "ax²"
        '
        'bxLabel
        '
        Me.bxLabel.AutoSize = True
        Me.bxLabel.Location = New System.Drawing.Point(12, 50)
        Me.bxLabel.Name = "bxLabel"
        Me.bxLabel.Size = New System.Drawing.Size(18, 13)
        Me.bxLabel.TabIndex = 2
        Me.bxLabel.Text = "bx"
        '
        'cLabel
        '
        Me.cLabel.AutoSize = True
        Me.cLabel.Location = New System.Drawing.Point(12, 73)
        Me.cLabel.Name = "cLabel"
        Me.cLabel.Size = New System.Drawing.Size(13, 13)
        Me.cLabel.TabIndex = 3
        Me.cLabel.Text = "c"
        '
        'x1Label
        '
        Me.x1Label.AutoSize = True
        Me.x1Label.Location = New System.Drawing.Point(114, 50)
        Me.x1Label.Name = "x1Label"
        Me.x1Label.Size = New System.Drawing.Size(21, 13)
        Me.x1Label.TabIndex = 4
        Me.x1Label.Text = "x 1"
        '
        'x2Label
        '
        Me.x2Label.AutoSize = True
        Me.x2Label.Location = New System.Drawing.Point(114, 24)
        Me.x2Label.Name = "x2Label"
        Me.x2Label.Size = New System.Drawing.Size(21, 13)
        Me.x2Label.TabIndex = 5
        Me.x2Label.Text = "x 2"
        '
        'axT
        '
        Me.axT.Location = New System.Drawing.Point(39, 21)
        Me.axT.Name = "axT"
        Me.axT.Size = New System.Drawing.Size(59, 20)
        Me.axT.TabIndex = 6
        '
        'bxT
        '
        Me.bxT.Location = New System.Drawing.Point(39, 47)
        Me.bxT.Name = "bxT"
        Me.bxT.Size = New System.Drawing.Size(59, 20)
        Me.bxT.TabIndex = 7
        '
        'cT
        '
        Me.cT.Location = New System.Drawing.Point(39, 73)
        Me.cT.Name = "cT"
        Me.cT.Size = New System.Drawing.Size(59, 20)
        Me.cT.TabIndex = 8
        '
        'x2
        '
        Me.x2.Location = New System.Drawing.Point(141, 21)
        Me.x2.Name = "x2"
        Me.x2.Size = New System.Drawing.Size(59, 20)
        Me.x2.TabIndex = 9
        '
        'x1
        '
        Me.x1.Location = New System.Drawing.Point(141, 47)
        Me.x1.Name = "x1"
        Me.x1.Size = New System.Drawing.Size(59, 20)
        Me.x1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Delta"
        '
        'dT
        '
        Me.dT.Location = New System.Drawing.Point(141, 70)
        Me.dT.Name = "dT"
        Me.dT.Size = New System.Drawing.Size(59, 20)
        Me.dT.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 125)
        Me.Controls.Add(Me.dT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.x1)
        Me.Controls.Add(Me.x2)
        Me.Controls.Add(Me.cT)
        Me.Controls.Add(Me.bxT)
        Me.Controls.Add(Me.axT)
        Me.Controls.Add(Me.x2Label)
        Me.Controls.Add(Me.x1Label)
        Me.Controls.Add(Me.cLabel)
        Me.Controls.Add(Me.bxLabel)
        Me.Controls.Add(Me.axLabel)
        Me.Controls.Add(Me.CalcButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DETO - Bhaskara"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalcButton1 As Button
    Friend WithEvents axLabel As Label
    Friend WithEvents bxLabel As Label
    Friend WithEvents cLabel As Label
    Friend WithEvents x1Label As Label
    Friend WithEvents x2Label As Label
    Friend WithEvents axT As TextBox
    Friend WithEvents bxT As TextBox
    Friend WithEvents cT As TextBox
    Friend WithEvents x2 As TextBox
    Friend WithEvents x1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dT As TextBox
End Class
