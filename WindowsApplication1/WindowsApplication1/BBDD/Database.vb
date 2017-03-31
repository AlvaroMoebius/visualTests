Imports System.Data.Odbc

Public Module Database
    Public Function comprobarUsuarios(ByVal usuario As String, ByVal clave As String) As Boolean
        Dim conexion As New Odbc.OdbcConnection
        Dim reader As Odbc.OdbcDataReader
        Dim consulta As String = "Select claveUsuario from Clientes where idUsuario like '" + usuario + "';"
        Dim comando As New OdbcCommand(consulta, conexion)

        conexion.ConnectionString = "DSN=PostgreSQL30;Server=localhost;Port=5432;Database=Clientes;Uid=postgres;Pwd=6014;sslmode=Prefer"
        Try
            conexion.Open()
            reader = comando.ExecuteReader(CommandBehavior.CloseConnection)

            If reader.Read() And reader.FieldCount > 0 Then
                Dim dbClave As String = reader.GetString(0)

                Return String.Equals(clave, dbClave)
            Else
                Return False
            End If

        Catch exc As OdbcException
            MsgBox(exc.ToString())
        Finally
            conexion.Close()
        End Try

    End Function

End Module
