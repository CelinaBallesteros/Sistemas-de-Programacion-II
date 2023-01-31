Public Class FrmDistancia
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_x1.Text = ""
        Txt_x2.Text = ""
        Txt_y1.Text = ""
        Txt_y2.Text = ""
        TxtDistancia.Text = ""
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim x1 As Double
        Dim x2 As Double
        Dim y1 As Double
        Dim y2 As Double

        x1 = Txt_x1.Text
        x2 = Txt_x2.Text
        y1 = Txt_y1.Text
        y2 = Txt_y2.Text

        TxtDistancia.Text = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class
