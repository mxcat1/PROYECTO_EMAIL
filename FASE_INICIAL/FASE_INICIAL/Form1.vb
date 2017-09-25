Public Class Form1
    Private Sub btnverificar_Click(sender As Object, e As EventArgs) Handles btnverificar.Click
        Dim fecha_actual As Date = Date.Today
        Dim dia_actual, dia_de_la_semana(6) As String
        dia_de_la_semana(0) = "DOMINGO"
        dia_de_la_semana(1) = "LUNES"
        dia_de_la_semana(2) = "MARTES"
        dia_de_la_semana(3) = "MIERCOLES"
        dia_de_la_semana(4) = "JUEVES"
        dia_de_la_semana(5) = "VIERNES"
        dia_de_la_semana(6) = "SABADO"
        dia_actual = fecha_actual.DayOfWeek

        MsgBox("LA FECHA ACTUAL ES " + fecha_actual + " EL DIA ACTUAL ES: " + dia_de_la_semana(dia_actual))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
