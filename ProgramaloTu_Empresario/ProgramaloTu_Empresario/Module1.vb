Imports MySql.Data.MySqlClient
Module Module1
    Public cadenaConexion As String = "Server=localhost;Database=empresa_prueba;Uid=root;Pwd=;port=3306;SslMode=none"
    Public conn As New MySqlConnection(cadenaConexion)
    Public READER As MySqlDataReader
    Public Command As MySqlCommand
End Module
