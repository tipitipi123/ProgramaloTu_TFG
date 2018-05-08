Imports MySql.Data.MySqlClient
Module Module1
    Public cadenaConexion As String = "Server=localhost;Database=empresa_prueba;Uid=root;Pwd=;port=3306;SslMode=none"
    Public conn As New MySqlConnection(cadenaConexion)
    Public READER As MySqlDataReader
    Public Command As MySqlCommand


    Public Function insertar_bd(ByRef sentencia As String)
        Try
            conn.Open()
            Dim Query As String
            Query = sentencia
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader
            READER.Close()
            conn.Close()
            Return True
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
        READER.Close()
        conn.Close()
        Return False
    End Function

    Public Function borrar_bd(ByRef sentencia As String)
        Try
            conn.Open()
            Dim Query As String
            Query = sentencia
            Command = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader
            READER.Close()
            conn.Close()
            Return True
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        Catch ex2 As System.InvalidOperationException
        End Try
        READER.Close()
        conn.Close()
        Return False
    End Function

    Public Function consulta_bd(ByRef sentencia As String)
        Try
            conn.Open()
            Command = New MySqlCommand(sentencia, conn)
            READER = Command.ExecuteReader()
            If READER.Read = Nothing Then
                READER.Close()
                conn.Close()
                Return True
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
        READER.Close()
        conn.Close()
        Return False
    End Function

    Public Sub cargar_dataGridView(ByRef query As String, ByRef dgvShow As DataGridView)
        Try
            conn.Close()
            conn.Open()
            Command = New MySqlCommand(query, conn)
            READER = Command.ExecuteReader()
            'Creamos un DataTable y le pasamos la consulta 
            Dim dt = New DataTable()
            dt.Load(READER)
            'Cargamos el DataTable en el GridDataView
            dgvShow.AutoGenerateColumns = True
            dgvShow.DataSource = dt
            dgvShow.Refresh()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
        READER.Close()
        conn.Close()
    End Sub

End Module
