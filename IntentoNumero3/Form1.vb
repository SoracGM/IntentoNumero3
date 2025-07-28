Public Class Form1
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim usuario As String
        Dim contraseña As String

        usuario = "admin"
        contraseña = "1234"

        If txtusuario.Text = usuario And txtcontrase.Text = contraseña Then
            Gestion.Show()
            Me.Hide()
        Else
            MsgBox("contraseña o usuario incorrecto")
        End If
    End Sub
End Class
