Imports System.Net

Public Class CallAPI

    Public Function getDatos(ByVal fechaactual As String, ByVal fechafinal As String) As HttpWebRequest
        Dim request As HttpWebRequest
        request = WebRequest.Create("http://www.neowsapp.com/rest/v1/feed?start_date=" + fechaactual + "&end_date=" + fechafinal + "&detailed=false&api_key=nUIaTOBMbI7BNyvjiRruwLrAWeARkE9qaOcbUBg3")
        Return request
    End Function

End Class
