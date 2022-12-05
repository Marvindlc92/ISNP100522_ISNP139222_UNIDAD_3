Public Class Form1
    Dim alumno As New Alumno



    Function ok() As Boolean
        If (txtNombre.Text <> "") Then
            ok = True
        End If
        ok = False

    End Function


    Private Sub btnAgregarAlumno_Click(sender As Object, e As EventArgs) Handles btnAgregarAlumno.Click

        If cbxGenero.Text <> "MASCULINO" And cbxGenero.Text <> "FEMENINO" Then
            MsgBox("Genero: MASCULINO O FEMENINO", MsgBoxStyle.Critical, "Error")
        Else
            If txtDui.Text.Length = 0 Then
                MsgBox("agrege su DUI")
            ElseIf txtDui.Text.Length = 10 Then

                If InStr(txtDui.Text, "-") = False Then
                    MsgBox("DUI: El guion es requerido", MsgBoxStyle.Critical, "Error")
                Else
                    If UCase(txtCorreo.Text).Contains("@GMAIL.COM") Or UCase(txtCorreo.Text).Contains("@hotmail.com") Or UCase(txtCorreo.Text).Contains("@yahoo.com") Then
                        alumno.datosAlumno(txtCodigo.Text,
                                               txtNombre.Text,
                                               txtApellido.Text,
                                               cbxGenero.Text,
                                               txtEdad.Text,
                                               txtDui.Text,
                                               txtCorreo.Text,
                                               txtDireccion.Text)

                        datosAlumnos.Rows.Add(txtCodigo.Text,
                            alumno.nombreAlumno,
                            alumno.apellidoAlumno,
                            alumno.generoAlumno,
                            alumno.edadAlumno,
                            alumno.duiAlumno,
                            alumno.correoAlumno,
                            alumno.direccionAlumno
                )

                        If alumno.datosAceptados = False Then

                            MsgBox("Alumno " & alumno.nombreAlumno & " Registrado")
                        End If

                        Call nuevo()
                    Else
                        MsgBox("Correos validos: @gmail.com, @hotmail.com o @yahoo.com", MsgBoxStyle.Critical, "Error")
                    End If

                End If

            Else
                MsgBox("Ingrese DUI valido", MsgBoxStyle.Critical, "Error")
            End If
        End If

    End Sub

    Private Sub btnGenerarCodigo_Click(sender As Object, e As EventArgs) Handles btnGenerarCodigo.Click
        If txtNombre.Text = "" Then
            MsgBox("Nombre requerido", MsgBoxStyle.Critical, "Ayuda")
        Else
            txtCodigo.Text = alumno.generarCodigo(txtNombre.Text)
        End If

    End Sub
    Sub nuevo()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCorreo.Text = ""
        cbxGenero.Text = "Elejir..."
        txtEdad.Text = ""
        txtDui.Text = ""
        txtDireccion.Text = ""
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Call nuevo()
    End Sub

End Class
