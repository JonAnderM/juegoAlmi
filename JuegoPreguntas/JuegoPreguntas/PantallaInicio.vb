
Imports MySql.Data.MySqlClient

Public Class PantInicio
    Private Sub PantInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = 0





    End Sub

    Private Sub validarLogin()
        Dim juego As Juego
        Dim logon As Boolean
        Dim dReader As MySqlDataReader
        Dim sql As String = "SELECT * FROM usuarios WHERE admin = 1"
        Dim cn As MySqlConnection
        juego = New Juego
        cn = conectar()

        dReader = login(sql, cn)

        If dReader.HasRows Then
            Do While dReader.Read()
                If txtUsuario.Text = dReader.Item("nombre") And txtUsuario.Text = dReader.Item("password") Then
                    logon = True
                    Exit Do
                Else
                    logon = False
                End If
            Loop
        End If
        If logon Then
            juego.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o contraseña no válidos")
        End If



        'txtPassword.Text

    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        validarLogin()
    End Sub
End Class
