Public Class Login

    Private Sub botonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonLogin.Click
        Dim usuario As String = Me.campoUsuario.Text
        Dim clave As String = Me.campoClave.Text


        If String.IsNullOrEmpty(usuario) Or String.IsNullOrEmpty(clave) Then
            MsgBox("INTRODUZCA DATOS VÁLIDOS" + vbCr + "CAMPOS VACÍOS")
        Else
            If comprobar(usuario, clave) Then
                MsgBox("Login con éxito!")
            Else
                MsgBox("Por favor, compruebe los datos o póngase en contacto con un administrador.")
            End If
        End If


    End Sub
End Class
