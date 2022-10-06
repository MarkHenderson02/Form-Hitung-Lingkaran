Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim r As Double
        Const phi = 3.14

        r = Val(tbJarijari.Text)
        tbLuas.Text = phi * r * r
        tbKeliling.Text = 2 * phi * r

    End Sub
End Class
