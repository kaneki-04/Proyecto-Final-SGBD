
Imports mysql.Data.MySqlClient

Public Class Form1

    Dim conn As New MySqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * from Proveedores"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub bt_nuevo_Click(sender As Object, e As EventArgs) Handles bt_nuevo.Click
        Me.ctId_Proveedores.Text = ""
        Me.ct_nombre.Text = ""
        Me.ct_direccion.Text = ""
        Me.ct_telefono.Text = ""
        Me.ct_correo.Text = ""
        Me.ct_nombre.Focus()

    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        If ct_nombre.Text = "" Then
            MessageBox.Show("Digite el nombre del proveedor")
            ct_nombre.Focus()
            Exit Sub
        End If
        If ct_direccion.Text = "" Then
            MessageBox.Show("Digite la dirección")
            ct_direccion.Focus()
            Exit Sub
        End If
        If ct_telefono.Text = "" Then
            MessageBox.Show("Digite el teléfono")
            ct_telefono.Focus()
            Exit Sub
        End If
        If ct_correo.Text = "" Then
            MessageBox.Show("Digite el correo")
            ct_correo.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Desea guardar el registro?", "Sistema de Inventario",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) = DialogResult.No Then
            Exit Sub
        End If
        Dim SQL, var As String
        SQL = "select id_proveedor from Proveedores WHERE id_proveedor = '" & ctId_Proveedores.Text & "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.HasRows Then
            var = "Actualizado"
            SQL = "UPDATE Proveedores set nombre='" & ct_nombre.Text & "' " & ",direccion='" & ct_direccion.Text & "',telefono='" &
                ct_telefono.Text & "',email='" & ct_correo.Text & "' where id_proveedor='" & ctId_Proveedores.Text & "'"
        Else
            var = "Guardado"
            SQL = "INSERT INTO Proveedores values(null,'" & ct_nombre.Text & "','" & ct_direccion.Text & "','" & ct_telefono.Text & "','" &
                   ct_correo.Text & "')"
        End If

        lectura.Close()
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var)
        bt_nuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from Proveedores order by nombre"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub bt_borrar_Click(sender As Object, e As EventArgs) Handles bt_borrar.Click
        If ctId_Proveedores.Text = "" Then
            MessageBox.Show("Seleccione un proveedor")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?",
       "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) = DialogResult.No Then
            Exit Sub
        End If
        Dim SQL As String
        SQL = "delete from Proveedores WHERE id_proveedor = '" &
        ctId_Proveedores.Text & "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado")
        bt_nuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from Proveedores order by nombre"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub bt_salir_Click(sender As Object, e As EventArgs) Handles bt_salir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Verificar si el índice de la fila es válido
        If e.RowIndex >= 0 Then
            ' Capturar el valor del id_proveedor en la celda seleccionada
            Dim proveedor As String = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            ' Crear la consulta SQL para obtener los detalles del proveedor
            Dim SQL As String = "SELECT * FROM Proveedores WHERE id_proveedor = '" & proveedor & "'"
            Dim cmd As New MySqlCommand(SQL, conn)
            cmd.CommandType = CommandType.Text

            ' Ejecutar la consulta y obtener los resultados
            Try
                Dim lectura As MySqlDataReader = cmd.ExecuteReader()
                If lectura.Read = True Then
                    ' Asignar los valores de la base de datos a los controles del formulario
                    Me.ctId_Proveedores.Text = lectura("id_proveedor").ToString()
                    Me.ct_nombre.Text = lectura("nombre").ToString()
                    Me.ct_direccion.Text = lectura("direccion").ToString()
                    Me.ct_telefono.Text = lectura("telefono").ToString()
                    Me.ct_correo.Text = lectura("email").ToString()
                End If
                lectura.Close()
            Catch ex As Exception
                MessageBox.Show("Error al leer los datos: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ctId_Proveedores_TextChanged(sender As Object, e As EventArgs) Handles ctId_Proveedores.TextChanged

    End Sub
End Class
