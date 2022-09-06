Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim lista As List(Of Meteoro)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim api = New MeteoritoService()
        lista = api.ObtenerTop3(Integer.Parse(DropDownList1.SelectedItem.Value))

        If top1.Visible Then
            top1.Visible = False
            top2.Visible = False
            top3.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            GridView1.Visible = False
            Label46.Visible = False
            Button3.Text = "Mostrar Datos"
        End If
        If lista.Count > 0 Then
            If lista.Count = 1 Then
                top1.Visible = True
                Button2.Visible = True
                Button3.Visible = True
                valorn1.Text = lista(0).nombre
                valord1.Text = lista(0).diametro
                valorf1.Text = lista(0).fecha
                valorp1.Text = lista(0).planeta
                valorv1.Text = lista(0).velocidad
            ElseIf lista.Count = 2 Then
                top1.Visible = True
                top2.Visible = True
                Button2.Visible = True
                Button3.Visible = True
                valorn1.Text = lista(0).nombre
                valord1.Text = lista(0).diametro
                valorf1.Text = lista(0).fecha
                valorp1.Text = lista(0).planeta
                valorv1.Text = lista(0).velocidad
                valorn2.Text = lista(1).nombre
                valord2.Text = lista(1).diametro
                valorf2.Text = lista(1).fecha
                valorp2.Text = lista(1).planeta
                valorv2.Text = lista(1).velocidad
            ElseIf lista.Count = 3 Then
                top1.Visible = True
                top2.Visible = True
                top3.Visible = True
                Button2.Visible = True
                Button3.Visible = True
                valorn1.Text = lista(0).nombre
                valord1.Text = lista(0).diametro
                valorf1.Text = lista(0).fecha
                valorp1.Text = lista(0).planeta
                valorv1.Text = lista(0).velocidad
                valorn2.Text = lista(1).nombre
                valord2.Text = lista(1).diametro
                valorf2.Text = lista(1).fecha
                valorp2.Text = lista(1).planeta
                valorv2.Text = lista(1).velocidad
                valorn3.Text = lista(2).nombre
                valord3.Text = lista(2).diametro
                valorf3.Text = lista(2).fecha
                valorp3.Text = lista(2).planeta
                valorv3.Text = lista(2).velocidad
            End If

        End If




    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label46.Visible = False
        If GridView1.Visible Then
            GridView1.Visible = False
            Button3.Text = "Mostrar datos"
        Else
            GridView1.Visible = True
            Button3.Text = "Ocultar datos"
        End If

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj_meteorito = New BD_meteoritos
        Dim api = New MeteoritoService()
        Dim errores = New List(Of String)
        lista = api.ObtenerTop3(Integer.Parse(DropDownList1.SelectedItem.Value))
        For index = 0 To lista.Count - 1
            obj_meteorito.Ingresar_meteoritos(lista(index).nombre, lista(index).diametro, lista(index).fecha, lista(index).velocidad, lista(index).planeta)
        Next

        errores = obj_meteorito.status
        If errores.Count = 0 Then
            Label46.Text = "Datos insertados con éxito"
        Else
            If errores.Count = 3 Then
                Label46.Text = "Los datos ya existen"
            Else
                Label46.Text = "Datos insertados correctamente excepto, los meteoritos con el siguiente nombre:" + vbCr + " "
                For index1 = 0 To errores.Count - 1
                    If errores.Count - 1 = index1 Then
                        Label46.Text += errores(index1)
                    Else
                        Label46.Text += errores(index1) + vbCr
                    End If

                Next
            End If


        End If

        Label46.Visible = True
    End Sub
End Class