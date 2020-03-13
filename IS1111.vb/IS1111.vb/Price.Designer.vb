<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrice
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
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtLogo = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(51, 76)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(60, 17)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Subtotal"
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Location = New System.Drawing.Point(51, 142)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(40, 17)
        Me.lblLogo.TabIndex = 1
        Me.lblLogo.Text = "Logo"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Location = New System.Drawing.Point(51, 220)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(35, 17)
        Me.lblVat.TabIndex = 2
        Me.lblVat.Text = "VAT"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(51, 295)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 17)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(186, 71)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 22)
        Me.txtSubtotal.TabIndex = 4
        '
        'txtLogo
        '
        Me.txtLogo.Location = New System.Drawing.Point(186, 136)
        Me.txtLogo.Name = "txtLogo"
        Me.txtLogo.ReadOnly = True
        Me.txtLogo.Size = New System.Drawing.Size(100, 22)
        Me.txtLogo.TabIndex = 5
        '
        'txtVat
        '
        Me.txtVat.Location = New System.Drawing.Point(186, 215)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(100, 22)
        Me.txtVat.TabIndex = 6
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(186, 290)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtTotal.TabIndex = 7
        '
        'frmPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 632)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.txtLogo)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Name = "frmPrice"
        Me.Text = "Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblLogo As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtLogo As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtTotal As TextBox
End Class
