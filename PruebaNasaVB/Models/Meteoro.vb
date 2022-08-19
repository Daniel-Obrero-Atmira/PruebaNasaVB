
Public Class Meteoro

    Public nombre As String
    Public diametro As Decimal
    Public velocidad As String
    Public fecha As String
    Public planeta As String

    Public Sub New()

    End Sub

    Public Sub New(_nombre As String, _diametro As Decimal, _velocidad As String, _fecha As String, _planeta As String)
        nombre = _nombre
        diametro = _diametro
        velocidad = _velocidad
        fecha = _fecha
        planeta = _planeta
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim meteoro = TryCast(obj, Meteoro)
        Return meteoro IsNot Nothing AndAlso
               nombre = meteoro.nombre
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = -1449437152
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(nombre)).GetHashCode()
        Return hashCode
    End Function
End Class
