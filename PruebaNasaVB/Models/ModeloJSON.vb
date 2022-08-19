Public Class ModeloJSON

    Public Class RootObject
        Public datos As List(Of Todos)
    End Class
    Public Class Todos
        Public Property links As Links
        Public Property element_count As Integer
        Public Property near_earth_objects As Near_Earth_Objects
    End Class

    Public Class Links
        Public Property _next As String
        Public Property prev As String
        Public Property self As String
    End Class

    Public Class Near_Earth_Objects
        Public Property fecha() As List(Of Fecha)
    End Class

    Public Class Fecha
        Public Property links As Links1
        Public Property id As String
        Public Property neo_reference_id As String
        Public Property name As String
        Public Property nasa_jpl_url As String
        Public Property absolute_magnitude_h As Single
        Public Property estimated_diameter As Estimated_Diameter
        Public Property is_potentially_hazardous_asteroid As Boolean
        Public Property close_approach_data As List(Of Close_Approach_Data)
        Public Property is_sentry_object As Boolean
    End Class

    Public Class Links1
        Public Property self As String
    End Class

    Public Class Estimated_Diameter
        Public Property kilometers As Kilometers
        Public Property meters As Meters
        Public Property miles As Miles
        Public Property feet As Feet
    End Class

    Public Class Kilometers
        Public Property estimated_diameter_min As Single
        Public Property estimated_diameter_max As Single
    End Class

    Public Class Meters
        Public Property estimated_diameter_min As Single
        Public Property estimated_diameter_max As Single
    End Class

    Public Class Miles
        Public Property estimated_diameter_min As Single
        Public Property estimated_diameter_max As Single
    End Class

    Public Class Feet
        Public Property estimated_diameter_min As Single
        Public Property estimated_diameter_max As Single
    End Class

    Public Class Close_Approach_Data
        Public Property close_approach_date As String
        Public Property close_approach_date_full As String
        Public Property epoch_date_close_approach As Long
        Public Property relative_velocity As Relative_Velocity
        Public Property miss_distance As Miss_Distance
        Public Property orbiting_body As String
    End Class

    Public Class Relative_Velocity
        Public Property kilometers_per_second As String
        Public Property kilometers_per_hour As String
        Public Property miles_per_hour As String
    End Class

    Public Class Miss_Distance
        Public Property astronomical As String
        Public Property lunar As String
        Public Property kilometers As String
        Public Property miles As String
    End Class

    Public Class Links2
        Public Property self As String
    End Class

    Public Class Estimated_Diameter1
        Public Property kilometers As Kilometers1
        Public Property meters As Meters1
        Public Property miles As Miles1
        Public Property feet As Feet1
    End Class

    Public Class Kilometers1
        Public Property estimated_diameter_min As Single
        Public Property estimated_diameter_max As Single
    End Class

    Public Class Meters1
        Public Property estimated_diameter_min As Single
        Public Property estimated_diameter_max As Single
    End Class

    Public Class Miles1
        Public Property estimated_diameter_min As Single
        Public Property estimated_diameter_max As Single
    End Class

    Public Class Feet1
        Public Property estimated_diameter_min As Single
        Public Property estimated_diameter_max As Single
    End Class

    Public Class Close_Approach_Data1
        Public Property close_approach_date As String
        Public Property close_approach_date_full As String
        Public Property epoch_date_close_approach As Long
        Public Property relative_velocity As Relative_Velocity1
        Public Property miss_distance As Miss_Distance1
        Public Property orbiting_body As String
    End Class

    Public Class Relative_Velocity1
        Public Property kilometers_per_second As String
        Public Property kilometers_per_hour As String
        Public Property miles_per_hour As String
    End Class

    Public Class Miss_Distance1
        Public Property astronomical As String
        Public Property lunar As String
        Public Property kilometers As String
        Public Property miles As String
    End Class

End Class
