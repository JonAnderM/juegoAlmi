Imports MySql.Data.MySqlClient
Module FuncionesDB



    Dim connStr As String = "server=192.168.6.200; user id=root; password=Almi123 ; database=linkstart;"
    Dim connect As New MySqlConnection()
    Dim sqladapter As New MySqlDataAdapter
    Dim sqlcmd As New MySqlCommand
    Dim dReader As MySqlDataReader
    Public Function conectar() As MySqlConnection
        Try
            connect = New MySqlConnection(connStr)
            connect.Open()
            Return connect
        Catch ex As Exception
            MsgBox(connect.ToString + "error")
            Return Nothing
        End Try
    End Function

    Public Function login(sql As String, cn As MySqlConnection) As MySqlDataReader

        sqlcmd = New MySqlCommand(sql, cn)
        dReader = sqlcmd.ExecuteReader
        Return dReader
    End Function

    Public Function obtenerPreguntas(sql As String, cn As MySqlConnection) As MySqlDataReader
        sqlcmd = New MySqlCommand(sql, cn)
        dReader = sqlcmd.ExecuteReader
        Return dReader
    End Function
    Public Function obtenerRespuestas(sql As String, cn As MySqlConnection) As MySqlDataReader
        sqlcmd = New MySqlCommand(sql, cn)
        dReader = sqlcmd.ExecuteReader
        Return dReader
    End Function
End Module
