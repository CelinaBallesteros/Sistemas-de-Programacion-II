Public Class Form1
    Dim nom, ApP1, ApM1 As String
    Dim cadena As String
    Dim d, m, a As String

    Private Sub btnRFC_Click(sender As Object, e As EventArgs) Handles btnRFC.Click
        If TxtNombre.Text = "" Or TxtApPaterno.Text = "" Or TxtApMaterno.Text = "" Or TxtD.Text = "" Or TxtM.Text = "" Or TxtA.Text = "" Then
            MessageBox.Show("Uno o mas campos estan vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            For i = 1 To Len(TxtApPaterno.Text)
                cadena = Mid(TxtApPaterno.Text, i, 1)
                If i = 1 Then
                    ApP1 = cadena
                ElseIf i > 1 And cadena = "A" Or cadena = "E" Or cadena = "I" Or cadena = "O" Or cadena = "U" Then
                    ApP1 = ApP1 + cadena
                    Exit For
                End If
            Next
            TxtRFC.Text = ApP1
            For i = 1 To Len(TxtApMaterno.Text)
                cadena = Mid(TxtApMaterno.Text, i, 1)
                If i = 1 Then
                    ApM1 = cadena
                    Exit For
                End If
            Next
            TxtRFC.Text = ApP1 + ApM1
            For i = 1 To Len(TxtNombre.Text)
                cadena = Mid(TxtNombre.Text, i, 1)
                If i = 1 Then
                    nom = cadena
                    Exit For
                End If
            Next
            TxtRFC.Text = ApP1 + ApM1 + nom
            If TxtD.Text > 31 Or TxtM.Text > 12 Then
                MessageBox.Show("La fecha es incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                d = TxtD.Text
                m = TxtM.Text
                a = TxtA.Text
                TxtRFC.Text = ApP1 + ApM1 + nom + d + m + a
            End If



        End If

    End Sub
End Class
