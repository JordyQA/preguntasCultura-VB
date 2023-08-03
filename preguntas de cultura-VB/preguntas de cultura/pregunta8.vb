Public Class pregunta8
    Private Sub pregunta8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imagenChavin.Visible = False
        imagenWari.Visible = False
        btnSiguietne.Enabled = False
    End Sub

    Private Sub btnVerChavin_Click(sender As Object, e As EventArgs) Handles btnVerChavin.Click
        imagenChavin.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        imagenWari.Visible = True
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        If RadioButton1.Checked Then
            lbl_Correcta.Visible = True
            lbl_Incorrecta.Visible = False
        End If
        If RadioButton2.Checked Then
            lbl_Correcta.Visible = False
            lbl_Incorrecta.Visible = True
        End If
        If RadioButton3.Checked Then
            lbl_Correcta.Visible = False
            lbl_Incorrecta.Visible = True
        End If

        If RadioButton6.Checked Then
            lbl_Correcta2.Visible = False
            lbl_Incorrecta2.Visible = True
        End If
        If RadioButton5.Checked Then
            lbl_Correcta2.Visible = False
            lbl_Incorrecta2.Visible = True
        End If
        If RadioButton4.Checked Then
            lbl_Correcta2.Visible = True
            lbl_Incorrecta2.Visible = False
        End If

        btnSiguietne.Enabled = True
    End Sub

    Private Sub btnSiguietne_Click(sender As Object, e As EventArgs) Handles btnSiguietne.Click
        pregunta9.Show()
        Me.Hide()
    End Sub
End Class