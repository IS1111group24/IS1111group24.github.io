Public Class frmAdditions
    Public dblPrice As Double
    Public dblQuarter As Double
    Public dblEyestay As Double
    Public dblHeelTab As Double
    Public dblHeel As Double
    Public dblCharacter As Double
    Public dblAdditional As Double

    Private Sub frmAdditions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtQuarter.Text = "€8.99"

        txtVamp.Text = "€14.99"

        txtEyestay.Text = "€5"
        txtHeelTab.Text = "€4.99"
        txtHeel.Text = "€6.49"
        txtCharacter.Text = "€0.45"
        txtAdditional.Text = "€0.05"
    End Sub


    Private Sub radText_CheckedChanged(sender As Object, e As EventArgs)
        If chkCharacter.Checked = True Then
            txtAddText.Visible = True
        ElseIf txtAddText.Visible = False Then
        End If

        If chkCharacter.Checked = True Then
            lblText.Visible = True
        ElseIf lblText.Visible = False Then
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtSubtotal.Text = (dblQuarter + dblPrice + dblEyestay + dblHeelTab + dblHeel + dblCharacter + dblAdditional)
    End Sub

    Private Sub chkQuarter_CheckedChanged(sender As Object, e As EventArgs) Handles chkQuarter.CheckedChanged
        If chkQuarter.Checked = True Then
            Me.dblQuarter = "8.99"
        Else Me.dblQuarter = "0"
        End If

    End Sub

    Private Sub chkVamp_CheckedChanged(sender As Object, e As EventArgs) Handles chkVamp.CheckedChanged
        If chkVamp.Checked = True Then
            Me.dblPrice = "14.99"
        Else Me.dblPrice = "0"
        End If

    End Sub

    Private Sub chkEyestay_CheckedChanged(sender As Object, e As EventArgs) Handles chkEyestay.CheckedChanged
        If chkEyestay.Checked = True Then
            Me.dblEyestay = "5.00"
        Else Me.dblEyestay = "0"
        End If
    End Sub

    Private Sub chkHeelTab_CheckedChanged(sender As Object, e As EventArgs) Handles chkHeelTab.CheckedChanged
        If chkHeelTab.Checked = True Then
            Me.dblHeelTab = "4.99"
        Else Me.dblHeelTab = "0"
        End If
    End Sub

    Private Sub chkHeel_CheckedChanged(sender As Object, e As EventArgs) Handles chkHeel.CheckedChanged
        If chkHeel.Checked = True Then
            Me.dblHeel = "6.49"
        Else Me.dblHeel = "0"

        End If
    End Sub

    Private Sub chkCharacter_CheckedChanged(sender As Object, e As EventArgs) Handles chkCharacter.CheckedChanged
        If chkCharacter.Checked = True Then
            txtAddText.Visible = True
        ElseIf txtAddText.Visible = False Then
        End If

        If chkCharacter.Checked = True Then
            lblText.Visible = True
        ElseIf lblText.Visible = False Then
        End If


        If chkCharacter.Checked = True Then
            Me.dblCharacter = "0.45"
        Else Me.dblCharacter = "0"

        End If
    End Sub

    Private Sub chkAdditional_CheckedChanged(sender As Object, e As EventArgs) Handles chkAdditional.CheckedChanged
        If chkAdditional.Checked = True Then
            Me.dblAdditional = "0.05"
        Else Me.dblAdditional = "0"
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmPrice.Show()
    End Sub
End Class