Imports System.Data
Imports System.Data.SqlClient
Public Class BD_meteoritos
    public Dim status = New List(Of String)
    Dim ConexionBD = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Meteoritos.mdf;Integrated Security=True"
    Private conexion As New SqlConnection(ConexionBD)
    Private comando As New SqlCommand
    Private adaptador As New SqlDataAdapter
    Private datos As New DataSet


    Public Function Conectarse()
        Dim estado As Boolean
        Try
            conexion.Open()
            estado = True
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Public Function comprobar_meteorito(ByVal nombre As String)
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

    Public Function ingresar_meteoritos(ByVal nombre As String, ByVal diametro As Double, ByVal fecha As String, ByVal velocidad As String, ByVal planeta As String)

        Dim nombrebd = comprobar_meteorito(nombre)
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
    Public Function Desconectarse()
        conexion.Close()
    End Function
End Class
