Imports mysql.Data.MySqlClient ' Asegúrate de tener el conector MySQL instalado

Module Module1
    ' Función para conectar a la base de datos
    Public Function conectar() As MySqlConnection
        Dim conexion As New MySqlConnection
        Try
            ' Cadena de conexión para la base de datos
            conexion.ConnectionString = "server=localhost;user id=root;password=kevin121204;database=inventario;"
            conexion.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido realizar la conexión a la base de datos: " & ex.Message)
            End
        End Try
        Return conexion
    End Function

    ' Función para cargar datos en un DataGrid
    Function cargar_grid(ByVal sql As String, ByVal conn As MySqlConnection) As DataTable
        Dim da As New MySqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        Try
            ' Intentar llenar el DataSet
            da.Fill(ds)

            ' Verificar si el DataSet tiene al menos una tabla
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0) ' Retornar la primera tabla
            Else
                MessageBox.Show("No se encontraron resultados en la consulta.")
                Return Nothing
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error al ejecutar la consulta SQL: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Module

