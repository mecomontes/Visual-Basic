Public Class Form1

    Dim n As Integer
    Dim golfavor() As Integer
    Dim golcontra() As Integer
    Dim acumfav As Integer
    Dim acumcon As Integer
    Dim puntos() As Integer
    Dim acumpuntos As Integer
    Dim mayor As Integer
    Dim equipomayor As String
    Dim acumpuntaje As Integer
    Dim media As Double
    Dim moda As Integer
    Dim desviacion As Double


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonequipos.Click

        n = Val(TextBoxequipos.Text)
        DGVnombres.RowCount = n
        DGVnombres.ColumnCount = 1

    End Sub

    Private Sub Buttonmarcadores_Click(sender As Object, e As EventArgs) Handles Buttonmarcadores.Click
        DGV.RowCount = n + 1
        DGV.ColumnCount = n + 1
        DGV.Rows(0).Cells(0).Value = "EQUIPOS"

        For i = 1 To n
            DGV.Rows(i).Cells(0).Value = DGVnombres.Rows(i - 1).Cells(0).Value
            DGV.Rows(0).Cells(i).Value = DGVnombres.Rows(i - 1).Cells(0).Value
            DGV.Rows(i).Cells(i).Value = 0
        Next
    End Sub

    Private Sub Buttonpuntajes_Click(sender As Object, e As EventArgs) Handles Buttonpuntajes.Click
        ReDim golfavor(n)
        ReDim golcontra(n)
        ReDim puntos(n)
        mayor = 0

        For i = 1 To n
            acumfav = 0
            acumcon = 0
            acumpuntos = 0

            For j = 1 To n

                If i <> j Then
                    If DGV.Rows(i).Cells(j).Value < DGV.Rows(j).Cells(i).Value Then
                        acumpuntos = acumpuntos + 3

                    ElseIf DGV.Rows(i).Cells(j).Value = DGV.Rows(j).Cells(i).Value Then
                        acumpuntos = acumpuntos + 1
                    End If

                End If
                acumfav = acumfav + DGV.Rows(j).Cells(i).Value
                acumcon = acumcon + DGV.Rows(i).Cells(j).Value
            Next
            golfavor(i) = acumfav
            golcontra(i) = acumcon
            puntos(i) = acumpuntos
        Next


        DGVposiciones.RowCount = n + 1
        DGVposiciones.ColumnCount = 5
        DGVposiciones.Rows(0).Cells(0).Value = "EQUIPO"
        DGVposiciones.Rows(0).Cells(1).Value = "Golfav"
        DGVposiciones.Rows(0).Cells(2).Value = "Golcon"
        DGVposiciones.Rows(0).Cells(3).Value = "Goldif"
        DGVposiciones.Rows(0).Cells(4).Value = "Puntos"

        For i = 1 To n - 1
            If puntos(i + 1) > puntos(i) Then

                equipomayor = DGVnombres.Rows(i - 1).Cells(0).Value
                DGVnombres.Rows(i - 1).Cells(0).Value = DGVnombres.Rows(i).Cells(0).Value
                DGVnombres.Rows(i).Cells(0).Value = equipomayor

                mayor = puntos(i)
                puntos(i) = puntos(i + 1)
                puntos(i + 1) = mayor

                mayor = golfavor(i)
                golfavor(i) = golfavor(i + 1)
                golfavor(i + 1) = mayor

                mayor = golcontra(i)
                golcontra(i) = golcontra(i + 1)
                golcontra(i + 1) = mayor

            ElseIf puntos(i + 1) = puntos(i) Then
                If golfavor(i + 1) > golfavor(i) Then

                    equipomayor = DGVnombres.Rows(i - 1).Cells(0).Value
                    DGVnombres.Rows(i - 1).Cells(0).Value = DGVnombres.Rows(i).Cells(0).Value
                    DGVnombres.Rows(i).Cells(0).Value = equipomayor

                    mayor = puntos(i)
                    puntos(i) = puntos(i + 1)
                    puntos(i + 1) = mayor

                    mayor = golfavor(i)
                    golfavor(i) = golfavor(i + 1)
                    golfavor(i + 1) = mayor

                    mayor = golcontra(i)
                    golcontra(i) = golcontra(i + 1)
                    golcontra(i + 1) = mayor

                End If
            End If
        Next



        For i = 1 To n
            DGVposiciones.Rows(i).Cells(0).Value = DGVnombres.Rows(i - 1).Cells(0).Value
            DGVposiciones.Rows(i).Cells(1).Value = golfavor(i)
            DGVposiciones.Rows(i).Cells(2).Value = golcontra(i)
            DGVposiciones.Rows(i).Cells(3).Value = golfavor(i) - golcontra(i)
            DGVposiciones.Rows(i).Cells(4).Value = puntos(i)
            acumpuntaje = acumpuntaje + puntos(i)
        Next
        media = acumpuntaje / n
        TextBox1.Text = media
    End Sub
End Class
