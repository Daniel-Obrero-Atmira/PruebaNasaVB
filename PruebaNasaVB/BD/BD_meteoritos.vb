Imports System.Data
Imports System.Data.SqlClient
Public Class BD_meteoritos

    Public status = New List(Of String)
    ReadOnly conexionBD = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Meteoritos.mdf;Integrated Security=True"
    Private ReadOnly conexion As New SqlConnection(conexionBD)
    Private comando As New SqlCommand
    Private ReadOnly adaptador As New SqlDataAdapter
    Private ReadOnly datos As New DataSet


    Public Function Conectarse()

        Comprobardatabase()

        Dim estado As Boolean
        Try
            conexion.Open()
            estado = True
        Catch ex As Exception
            estado = False
        End Try

        Return estado

    End Function

    Public Function Comprobar_meteorito(ByVal nombre As String)
        Conectarse()

        Dim rr As String
        comando = New SqlCommand("dbo.Comprobar_Meteorito", conexion)

        With comando
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@nombre", nombre)
        End With

        Try
            rr = comando.ExecuteScalar()
            Desconectarse()
        Catch ex As Exception
            rr = "no esta"
        End Try

        Return rr

    End Function

    Public Function Comprobardatabase()

        If (conexion.State = ConnectionState.Open) Then
            conexion.Close()
        End If

        Dim rm As String = "SELECT * FROM dbo.Meteoritos"
        Try
            conexion.Open()

            Dim cmd1 As New SqlCommand(rm, conexion)
            Dim rdr As String = cmd1.ExecuteNonQuery

            If rdr Is Nothing Then
                Crearbasededatos()
            End If
        Catch ex As Exception

        End Try

    End Function

    Public Function Ingresar_meteoritos(ByVal nombre As String, ByVal diametro As Double, ByVal fecha As String, ByVal velocidad As String, ByVal planeta As String)

        Dim nombrebd = Comprobar_meteorito(nombre)

        If nombrebd = nombre Then
            status.Add(nombrebd)
        Else
            Conectarse()

            comando = New SqlCommand("dbo.InsertarMeteoritos", conexion)
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@nombre", nombre)
                .Parameters.AddWithValue("@diametro", diametro)
                .Parameters.AddWithValue("@fecha", fecha)
                .Parameters.AddWithValue("@velocidad", velocidad)
                .Parameters.AddWithValue("@planeta", planeta)
            End With

            Try
                comando.ExecuteScalar()
                Desconectarse()
            Catch ex As Exception

            End Try

        End If

        Return status

    End Function

    Public Function Crearbasededatos()

        Dim Str = "CREATE DATABASE Meteoritos ON PRIMARY " &
            "(NAME = Meteoritos, " &
            " FILENAME = 'C:\MyFolder\Meteoritos.mdf', " &
            " SIZE = 2MB, " &
            " MAXSIZE = 10MB, " &
        " FILEGROWTH = 10%)"

        Dim myCommand As New SqlCommand(Str, conexion)
        Dim obj As SqlCommand = conexion.CreateCommand()
        Dim strSQL = "CREATE TABLE " & "Meteoritos" & ". Meteoro (" &
          "nombre varchar(40) NOT NULL PRIMARY KEY, " &
          "diametro  float, " &
          "fecha VARCHAR(20), " &
          "velocidad   VARCHAR(50) " &
          "planeta   VARCHAR(50) " &
          ") "

        obj.CommandText = strSQL
        obj.ExecuteNonQuery()
    End Function

    Public Function Desconectarse()
        conexion.Close()
    End Function
End Class
