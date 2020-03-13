<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShoe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShoe))
        Me.radRetro = New System.Windows.Forms.RadioButton()
        Me.picRetro = New System.Windows.Forms.PictureBox()
        Me.picClassic = New System.Windows.Forms.PictureBox()
        Me.picVintage = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.radClassic = New System.Windows.Forms.RadioButton()
        Me.radVintage = New System.Windows.Forms.RadioButton()
        Me.grpShoe = New System.Windows.Forms.GroupBox()
        CType(Me.picRetro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClassic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVintage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpShoe.SuspendLayout()
        Me.SuspendLayout()
        '
        'radRetro
        '
        Me.radRetro.AutoSize = True
        Me.radRetro.Location = New System.Drawing.Point(95, 43)
        Me.radRetro.Name = "radRetro"
        Me.radRetro.Size = New System.Drawing.Size(64, 21)
        Me.radRetro.TabIndex = 0
        Me.radRetro.TabStop = True
        Me.radRetro.Text = "Retro"
        Me.radRetro.UseVisualStyleBackColor = True
        '
        'picRetro
        '
        Me.picRetro.BackgroundImage = CType(resources.GetObject("picRetro.BackgroundImage"), System.Drawing.Image)
        Me.picRetro.Location = New System.Drawing.Point(12, 134)
        Me.picRetro.Name = "picRetro"
        Me.picRetro.Size = New System.Drawing.Size(382, 252)
        Me.picRetro.TabIndex = 3
        Me.picRetro.TabStop = False
        '
        'picClassic
        '
        Me.picClassic.BackgroundImage = CType(resources.GetObject("picClassic.BackgroundImage"), System.Drawing.Image)
        Me.picClassic.Location = New System.Drawing.Point(400, 134)
        Me.picClassic.Name = "picClassic"
        Me.picClassic.Size = New System.Drawing.Size(389, 252)
        Me.picClassic.TabIndex = 4
        Me.picClassic.TabStop = False
        '
        'picVintage
        '
        Me.picVintage.BackgroundImage = CType(resources.GetObject("picVintage.BackgroundImage"), System.Drawing.Image)
        Me.picVintage.Location = New System.Drawing.Point(795, 134)
        Me.picVintage.Name = "picVintage"
        Me.picVintage.Size = New System.Drawing.Size(379, 252)
        Me.picVintage.TabIndex = 5
        Me.picVintage.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(828, 490)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(240, 71)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'radClassic
        '
        Me.radClassic.AutoSize = True
        Me.radClassic.Location = New System.Drawing.Point(527, 43)
        Me.radClassic.Name = "radClassic"
        Me.radClassic.Size = New System.Drawing.Size(73, 21)
        Me.radClassic.TabIndex = 1
        Me.radClassic.TabStop = True
        Me.radClassic.Text = "Classic"
        Me.radClassic.UseVisualStyleBackColor = True
        '
        'radVintage
        '
        Me.radVintage.AutoSize = True
        Me.radVintage.Location = New System.Drawing.Point(939, 43)
        Me.radVintage.Name = "radVintage"
        Me.radVintage.Size = New System.Drawing.Size(77, 21)
        Me.radVintage.TabIndex = 2
        Me.radVintage.TabStop = True
        Me.radVintage.Text = "Vintage"
        Me.radVintage.UseVisualStyleBackColor = True
        '
        'grpShoe
        '
        Me.grpShoe.Controls.Add(Me.radClassic)
        Me.grpShoe.Controls.Add(Me.radVintage)
        Me.grpShoe.Controls.Add(Me.radRetro)
        Me.grpShoe.Location = New System.Drawing.Point(12, 12)
        Me.grpShoe.Name = "grpShoe"
        Me.grpShoe.Size = New System.Drawing.Size(1147, 100)
        Me.grpShoe.TabIndex = 7
        Me.grpShoe.TabStop = False
        Me.grpShoe.Text = "Choose your shoe"
        '
        'frmShoe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 632)
        Me.Controls.Add(Me.grpShoe)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.picVintage)
        Me.Controls.Add(Me.picClassic)
        Me.Controls.Add(Me.picRetro)
        Me.Name = "frmShoe"
        Me.Text = "Choose your Shoe"
        CType(Me.picRetro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClassic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVintage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpShoe.ResumeLayout(False)
        Me.grpShoe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radRetro As RadioButton
    Friend WithEvents picRetro As PictureBox
    Friend WithEvents picClassic As PictureBox
    Friend WithEvents picVintage As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents radClassic As RadioButton
    Friend WithEvents radVintage As RadioButton
    Friend WithEvents grpShoe As GroupBox
End Class
