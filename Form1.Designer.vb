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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSm = New System.Windows.Forms.Label()
        Me.lblLA = New System.Windows.Forms.Label()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.txtT = New System.Windows.Forms.TextBox()
        Me.txtS = New System.Windows.Forms.TextBox()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salesperson 1's sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salesperson 2's sales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salesperson 3's sales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Smallest is:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Largest is:"
        '
        'lblSm
        '
        Me.lblSm.AutoSize = True
        Me.lblSm.Location = New System.Drawing.Point(146, 142)
        Me.lblSm.Name = "lblSm"
        Me.lblSm.Size = New System.Drawing.Size(0, 13)
        Me.lblSm.TabIndex = 5
        '
        'lblLA
        '
        Me.lblLA.AutoSize = True
        Me.lblLA.Location = New System.Drawing.Point(146, 185)
        Me.lblLA.Name = "lblLA"
        Me.lblLA.Size = New System.Drawing.Size(0, 13)
        Me.lblLA.TabIndex = 6
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(149, 26)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(100, 20)
        Me.txtF.TabIndex = 7
        '
        'txtT
        '
        Me.txtT.Location = New System.Drawing.Point(149, 98)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(100, 20)
        Me.txtT.TabIndex = 8
        '
        'txtS
        '
        Me.txtS.Location = New System.Drawing.Point(149, 60)
        Me.txtS.Name = "txtS"
        Me.txtS.Size = New System.Drawing.Size(100, 20)
        Me.txtS.TabIndex = 9
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(298, 29)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(75, 23)
        Me.btnCompare.TabIndex = 10
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 302)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.txtS)
        Me.Controls.Add(Me.txtT)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.lblLA)
        Me.Controls.Add(Me.lblSm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Largest and Smallest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSm As Label
    Friend WithEvents lblLA As Label
    Friend WithEvents txtF As TextBox
    Friend WithEvents txtT As TextBox
    Friend WithEvents txtS As TextBox
    Friend WithEvents btnCompare As Button
End Class
