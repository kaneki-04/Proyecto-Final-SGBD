Imports mysql.Data.MySqlClient

Public Class FormLogin
    Private oConexion As MySqlConnection

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oConexion = New MySqlConnection()
        oConexion.ConnectionString = "server=localhost;user id=root;password=kevin121204;database=inventario;"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ' Este método puede ser eliminado si no es necesario
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            oConexion.Open()
            Dim SQL = "SELECT * FROM Usuarios WHERE username=@username AND password=@password"
            Dim cmd As New MySqlCommand(SQL, oConexion)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)

            Dim reader = cmd.ExecuteReader
            If reader.HasRows Then
                ' Credenciales válidas, abrir la interfaz principal
                MessageBox.Show("Inicio de sesión exitoso!")
                Dim mainForm As New Form1
                mainForm.Show()
                Hide()
            Else
                MessageBox.Show("Nombre de usuario o contraseña incorrectos...")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
        Finally
            oConexion.Close()
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim registerForm As New FormRegister()
        registerForm.Show()
    End Sub

End Class
