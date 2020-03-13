Public Class frmPrice
    Private Sub Price_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSubtotal.Text = (frmAdditions.dblQuarter + frmAdditions.dblPrice + frmAdditions.dblEyestay + frmAdditions.dblHeelTab + frmAdditions.dblHeel + frmAdditions.dblCharacter + frmAdditions.dblAdditional)
    End Sub
End Class