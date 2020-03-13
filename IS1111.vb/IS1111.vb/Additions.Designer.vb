<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdditions
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
        Me.grpCustomisation = New System.Windows.Forms.GroupBox()
        Me.chkAdditional = New System.Windows.Forms.CheckBox()
        Me.chkCharacter = New System.Windows.Forms.CheckBox()
        Me.chkHeel = New System.Windows.Forms.CheckBox()
        Me.chkHeelTab = New System.Windows.Forms.CheckBox()
        Me.chkEyestay = New System.Windows.Forms.CheckBox()
        Me.chkVamp = New System.Windows.Forms.CheckBox()
        Me.chkQuarter = New System.Windows.Forms.CheckBox()
        Me.txtAdditional = New System.Windows.Forms.TextBox()
        Me.txtCharacter = New System.Windows.Forms.TextBox()
        Me.txtQuarter = New System.Windows.Forms.TextBox()
        Me.txtVamp = New System.Windows.Forms.TextBox()
        Me.txtEyestay = New System.Windows.Forms.TextBox()
        Me.txtHeelTab = New System.Windows.Forms.TextBox()
        Me.txtHeel = New System.Windows.Forms.TextBox()
        Me.lblLaces = New System.Windows.Forms.Label()
        Me.cboLaces = New System.Windows.Forms.ComboBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.txtAddText = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpCustomisation.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustomisation
        '
        Me.grpCustomisation.Controls.Add(Me.chkAdditional)
        Me.grpCustomisation.Controls.Add(Me.chkCharacter)
        Me.grpCustomisation.Controls.Add(Me.chkHeel)
        Me.grpCustomisation.Controls.Add(Me.chkHeelTab)
        Me.grpCustomisation.Controls.Add(Me.chkEyestay)
        Me.grpCustomisation.Controls.Add(Me.chkVamp)
        Me.grpCustomisation.Controls.Add(Me.chkQuarter)
        Me.grpCustomisation.Controls.Add(Me.txtAdditional)
        Me.grpCustomisation.Controls.Add(Me.txtCharacter)
        Me.grpCustomisation.Controls.Add(Me.txtQuarter)
        Me.grpCustomisation.Controls.Add(Me.txtVamp)
        Me.grpCustomisation.Controls.Add(Me.txtEyestay)
        Me.grpCustomisation.Controls.Add(Me.txtHeelTab)
        Me.grpCustomisation.Controls.Add(Me.txtHeel)
        Me.grpCustomisation.Location = New System.Drawing.Point(46, 107)
        Me.grpCustomisation.Name = "grpCustomisation"
        Me.grpCustomisation.Size = New System.Drawing.Size(415, 355)
        Me.grpCustomisation.TabIndex = 0
        Me.grpCustomisation.TabStop = False
        Me.grpCustomisation.Text = "Choose Customisation:"
        '
        'chkAdditional
        '
        Me.chkAdditional.AutoSize = True
        Me.chkAdditional.Location = New System.Drawing.Point(17, 318)
        Me.chkAdditional.Name = "chkAdditional"
        Me.chkAdditional.Size = New System.Drawing.Size(176, 21)
        Me.chkAdditional.TabIndex = 16
        Me.chkAdditional.Text = "Per Additional Charcter"
        Me.chkAdditional.UseVisualStyleBackColor = True
        '
        'chkCharacter
        '
        Me.chkCharacter.AutoSize = True
        Me.chkCharacter.Location = New System.Drawing.Point(17, 274)
        Me.chkCharacter.Name = "chkCharacter"
        Me.chkCharacter.Size = New System.Drawing.Size(190, 21)
        Me.chkCharacter.TabIndex = 15
        Me.chkCharacter.Text = "Text (Up to 10 Charcters)"
        Me.chkCharacter.UseVisualStyleBackColor = True
        '
        'chkHeel
        '
        Me.chkHeel.AutoSize = True
        Me.chkHeel.Location = New System.Drawing.Point(17, 228)
        Me.chkHeel.Name = "chkHeel"
        Me.chkHeel.Size = New System.Drawing.Size(148, 21)
        Me.chkHeel.TabIndex = 14
        Me.chkHeel.Text = "Heel/Back Counter"
        Me.chkHeel.UseVisualStyleBackColor = True
        '
        'chkHeelTab
        '
        Me.chkHeelTab.AutoSize = True
        Me.chkHeelTab.Location = New System.Drawing.Point(17, 179)
        Me.chkHeelTab.Name = "chkHeelTab"
        Me.chkHeelTab.Size = New System.Drawing.Size(88, 21)
        Me.chkHeelTab.TabIndex = 13
        Me.chkHeelTab.Text = "Heel Tab"
        Me.chkHeelTab.UseVisualStyleBackColor = True
        '
        'chkEyestay
        '
        Me.chkEyestay.AutoSize = True
        Me.chkEyestay.Location = New System.Drawing.Point(17, 140)
        Me.chkEyestay.Name = "chkEyestay"
        Me.chkEyestay.Size = New System.Drawing.Size(80, 21)
        Me.chkEyestay.TabIndex = 12
        Me.chkEyestay.Text = "Eyestay"
        Me.chkEyestay.UseVisualStyleBackColor = True
        '
        'chkVamp
        '
        Me.chkVamp.AutoSize = True
        Me.chkVamp.Location = New System.Drawing.Point(17, 92)
        Me.chkVamp.Name = "chkVamp"
        Me.chkVamp.Size = New System.Drawing.Size(66, 21)
        Me.chkVamp.TabIndex = 11
        Me.chkVamp.Text = "Vamp"
        Me.chkVamp.UseVisualStyleBackColor = True
        '
        'chkQuarter
        '
        Me.chkQuarter.AutoSize = True
        Me.chkQuarter.Location = New System.Drawing.Point(17, 30)
        Me.chkQuarter.Name = "chkQuarter"
        Me.chkQuarter.Size = New System.Drawing.Size(79, 21)
        Me.chkQuarter.TabIndex = 10
        Me.chkQuarter.Text = "Quarter"
        Me.chkQuarter.UseVisualStyleBackColor = True
        '
        'txtAdditional
        '
        Me.txtAdditional.Location = New System.Drawing.Point(250, 318)
        Me.txtAdditional.Name = "txtAdditional"
        Me.txtAdditional.ReadOnly = True
        Me.txtAdditional.Size = New System.Drawing.Size(100, 22)
        Me.txtAdditional.TabIndex = 9
        '
        'txtCharacter
        '
        Me.txtCharacter.Location = New System.Drawing.Point(250, 272)
        Me.txtCharacter.Name = "txtCharacter"
        Me.txtCharacter.ReadOnly = True
        Me.txtCharacter.Size = New System.Drawing.Size(100, 22)
        Me.txtCharacter.TabIndex = 8
        '
        'txtQuarter
        '
        Me.txtQuarter.Location = New System.Drawing.Point(250, 30)
        Me.txtQuarter.Name = "txtQuarter"
        Me.txtQuarter.ReadOnly = True
        Me.txtQuarter.Size = New System.Drawing.Size(100, 22)
        Me.txtQuarter.TabIndex = 1
        '
        'txtVamp
        '
        Me.txtVamp.Location = New System.Drawing.Point(250, 92)
        Me.txtVamp.Name = "txtVamp"
        Me.txtVamp.ReadOnly = True
        Me.txtVamp.Size = New System.Drawing.Size(100, 22)
        Me.txtVamp.TabIndex = 2
        '
        'txtEyestay
        '
        Me.txtEyestay.Location = New System.Drawing.Point(250, 140)
        Me.txtEyestay.Name = "txtEyestay"
        Me.txtEyestay.ReadOnly = True
        Me.txtEyestay.Size = New System.Drawing.Size(100, 22)
        Me.txtEyestay.TabIndex = 3
        '
        'txtHeelTab
        '
        Me.txtHeelTab.Location = New System.Drawing.Point(250, 179)
        Me.txtHeelTab.Name = "txtHeelTab"
        Me.txtHeelTab.ReadOnly = True
        Me.txtHeelTab.Size = New System.Drawing.Size(100, 22)
        Me.txtHeelTab.TabIndex = 4
        '
        'txtHeel
        '
        Me.txtHeel.Location = New System.Drawing.Point(250, 228)
        Me.txtHeel.Name = "txtHeel"
        Me.txtHeel.ReadOnly = True
        Me.txtHeel.Size = New System.Drawing.Size(100, 22)
        Me.txtHeel.TabIndex = 5
        '
        'lblLaces
        '
        Me.lblLaces.AutoSize = True
        Me.lblLaces.Location = New System.Drawing.Point(46, 31)
        Me.lblLaces.Name = "lblLaces"
        Me.lblLaces.Size = New System.Drawing.Size(157, 17)
        Me.lblLaces.TabIndex = 1
        Me.lblLaces.Text = "Would You Like Laces?"
        '
        'cboLaces
        '
        Me.cboLaces.FormattingEnabled = True
        Me.cboLaces.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboLaces.Location = New System.Drawing.Point(278, 31)
        Me.cboLaces.Name = "cboLaces"
        Me.cboLaces.Size = New System.Drawing.Size(121, 24)
        Me.cboLaces.TabIndex = 2
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(571, 405)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(142, 17)
        Me.lblText.TabIndex = 4
        Me.lblText.Text = "Enter Your Text Here"
        Me.lblText.Visible = False
        '
        'txtAddText
        '
        Me.txtAddText.Location = New System.Drawing.Point(574, 425)
        Me.txtAddText.Name = "txtAddText"
        Me.txtAddText.Size = New System.Drawing.Size(257, 22)
        Me.txtAddText.TabIndex = 5
        Me.txtAddText.Visible = False
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(492, 545)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(276, 22)
        Me.txtSubtotal.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(544, 499)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(191, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(755, 181)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(152, 71)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmAdditions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 616)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtAddText)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.cboLaces)
        Me.Controls.Add(Me.lblLaces)
        Me.Controls.Add(Me.grpCustomisation)
        Me.Name = "frmAdditions"
        Me.Text = "Additions"
        Me.grpCustomisation.ResumeLayout(False)
        Me.grpCustomisation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCustomisation As GroupBox
    Friend WithEvents txtQuarter As TextBox
    Friend WithEvents txtVamp As TextBox
    Friend WithEvents txtEyestay As TextBox
    Friend WithEvents txtHeelTab As TextBox
    Friend WithEvents txtHeel As TextBox
    Friend WithEvents txtAdditional As TextBox
    Friend WithEvents txtCharacter As TextBox
    Friend WithEvents lblLaces As Label
    Friend WithEvents cboLaces As ComboBox
    Friend WithEvents lblText As Label
    Friend WithEvents txtAddText As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents chkAdditional As CheckBox
    Friend WithEvents chkCharacter As CheckBox
    Friend WithEvents chkHeel As CheckBox
    Friend WithEvents chkHeelTab As CheckBox
    Friend WithEvents chkEyestay As CheckBox
    Friend WithEvents chkVamp As CheckBox
    Friend WithEvents chkQuarter As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNext As Button
End Class
