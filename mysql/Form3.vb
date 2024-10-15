Imports mysql.Data.MySqlClient

Public Class FormRegister
    Private oConexion As MySqlConnection

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oConexion = New MySqlConnection()
        oConexion.ConnectionString = "server=localhost;user id=root;password=kevin121204;database=inventario;"
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            oConexion.Open()
            Dim SQL As String = "INSERT INTO Usuarios (username, password, rol) VALUES (@username, @password, @rol)"
            Dim cmd As New MySqlCommand(SQL, oConexion)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@rol", cmbRole.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Usuario registrado exitosamente.")
            Me.Close() ' Cerrar el formulario de registro
        Catch ex As Exception
            MessageBox.Show("Error al registrar el usuario: " & ex.Message)
        Finally
            oConexion.Close()
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles cmbRole.TextChanged

    End Sub




    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub btnMostrarContraseña_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMostrarContraseña.MouseDown
        txtPassword.PasswordChar = ""
    End Sub

    Private Sub btnMostrarContraseña_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMostrarContraseña.MouseUp
        txtPassword.PasswordChar = "*"
    End Sub




End Class
