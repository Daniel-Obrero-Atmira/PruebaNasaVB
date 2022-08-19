
Imports System.IO
Imports System.Linq
Imports System.Net
Imports Newtonsoft.Json
Imports PruebaNasaVB.ModeloJSON

Public Class MeteoritoService
    Public Function ObtenerTop3(ByVal dias As Integer) As List(Of Meteoro)
        Dim fechaActual As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim fechaFinal As String = calcularFecha(dias)
        Dim diaActual = fechaActual.Split("-")
        Dim todosM As List(Of List(Of Fecha)) = New List(Of List(Of Fecha))
        Dim apiCall As New CallAPI()
        Dim request As HttpWebRequest = apiCall.getDatos(fechaActual, fechaFinal)
        Dim response As HttpWebResponse = request.GetResponse()
        Dim stream As Stream = response.GetResponseStream()
        Using reader As StreamReader = New StreamReader(stream)
            Dim p As Integer = Integer.Parse(diaActual(2))
            Dim fecha As String = diaActual(0) + "-" + diaActual(1) + "-"
            Dim json = reader.ReadToEnd()
            Dim fechacambiada As String
            For i As Integer = 0 To dias - 1
                fechacambiada = fecha + p.ToString
                Dim jsonReal = json.Replace(fechacambiada, "fecha")
                Dim ejemplo = JsonConvert.DeserializeObject(Of Todos)(jsonReal)

                todosM.Add(ejemplo.near_earth_objects.fecha)
                p += 1
            Next
        End Using
        Return ordenar(clasificar(todosM))


    End Function

    Protected Function clasificar(ByVal todos As List(Of List(Of Fecha))) As List(Of Meteoro)
        Dim meteoritos As List(Of Meteoro) = New List(Of Meteoro)
        For i As Integer = 0 To todos.Count - 1
            For j As Integer = 0 To todos(i).Count - 1
                Dim nuevo = todos(i)
                If nuevo(j).is_potentially_hazardous_asteroid Then
                    Dim fecha As String = ""
                    Dim media As Single = ((nuevo(j).estimated_diameter.kilometers.estimated_diameter_min + nuevo(j).estimated_diameter.kilometers.estimated_diameter_max) / 2)

                    If i = 0 Then
                        fecha = DateTime.Now.ToString("yyyy-MM-dd")
                    Else
                        fecha = calcularFecha(i)

                    End If

                    Dim meteoro As Meteoro = New Meteoro(nuevo(j).name,
                            media,
                            nuevo(j).close_approach_data(0).relative_velocity.kilometers_per_hour,
                            fecha,
                            nuevo(j).close_approach_data(0).orbiting_body)
                    meteoritos.Add(meteoro)
                End If
            Next
        Next
        Return meteoritos
    End Function

    Protected Function ordenar(ByVal meteoritos As List(Of Meteoro)) As List(Of Meteoro)
        Dim meteoritosOrdenados As List(Of Meteoro) = New List(Of Meteoro)
        Dim Top3 = meteoritos.OrderByDescending(Function(x) x.diametro).Take(3)
        For Each n As Meteoro In Top3
            meteoritosOrdenados.Add(n)
        Next
        Return meteoritosOrdenados
    End Function

    Protected Function calcularFecha(ByVal dias As Integer) As String
        Dim fechaactual As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim diaactual = fechaactual.Split("-")
        Dim dia As Integer = Integer.Parse(diaactual(2)) + dias
        Dim fechafinal As String = ""
        If diaactual(1) = "01" OrElse diaactual(1) = "03" OrElse diaactual(1) = "05" OrElse diaactual(1) = "07" OrElse diaactual(1) = "08" OrElse diaactual(1) = "10" Then

            If (dia > 31) Then

                fechafinal = diaactual(0) + "-" + (Integer.Parse(diaactual(1)) + 1).ToString() + "-" + "0" + (dia - 31).ToString()

            Else

                fechafinal = diaactual(0) + "-" + diaactual(1) + "-" + dia.ToString()
            End If


        ElseIf (diaactual(1) = "04" OrElse diaactual(1) = "06" OrElse diaactual(1) = "09" OrElse diaactual(1) = "11") Then

            If (dia > 30) Then

                fechafinal = diaactual(0) + "-" + (Integer.Parse(diaactual(1)) + 1).ToString() + "-" + "0" + (dia - 30).ToString()

            Else

                fechafinal = diaactual(0) + "-" + diaactual(1) + "-" + dia.ToString()
            End If

        ElseIf (diaactual(1) = "02") Then

            If (dia > 28) Then

                fechafinal = diaactual(0) + "-" + (Integer.Parse(diaactual(1)) + 1).ToString() + "-" + "0" + (dia - 28).ToString()

            Else

                fechafinal = diaactual(0) + "-" + diaactual(1) + "-" + dia.ToString()
            End If

        ElseIf (diaactual(1) = "12") Then

            If (dia > 31) Then

                fechafinal = (Integer.Parse(diaactual(0)) + 1).ToString() + "-" + "01" + "-" + "0" + (dia - 31).ToString()

            Else

                fechafinal = diaactual(0) + "-" + diaactual(1) + "-" + dia.ToString()
            End If
        End If

        Return fechafinal
    End Function

End Class
