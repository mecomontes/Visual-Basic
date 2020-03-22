Public Class Form1
    Dim pos, posicion(12), mayor, menor, posmayor, posmenor, sumapuntos(12), sumapar, sumaimpar, total, aux As Integer
    Dim repetido As Boolean
    Dim porpar, porimpar As Single
    Dim auxcorredor As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgv.RowCount = 13
        dgv.ColumnCount = 11
        dgv.Rows(0).Cells(1).Value = "Pos Carr1"
        dgv.Rows(0).Cells(2).Value = "Puntos"
        dgv.Rows(0).Cells(3).Value = "Pos Carr2"
        dgv.Rows(0).Cells(4).Value = "Puntos"
        dgv.Rows(0).Cells(5).Value = "Pos Carr3"
        dgv.Rows(0).Cells(6).Value = "Puntos"
        dgv.Rows(0).Cells(7).Value = "Pos Carr4"
        dgv.Rows(0).Cells(8).Value = "Puntos"
        dgv.Rows(0).Cells(9).Value = "TOTAL"
        dgv.Rows(0).Cells(10).Value = "Promedio"

        For i = 1 To 12
            dgv.Rows(i).Cells(0).Value = "Corredor" & i
            sumapuntos(i) = 0
        Next

        For k = 1 To 4
            For i = 1 To 12
                repetido = False
                pos = aleatorio(1, 12)
                While repetido = False
                    For j = 1 To i
                        If i > 1 Then
                            If pos = posicion(j) Then
                                repetido = False
                                pos = aleatorio(1, 12)
                                j = -1
                            ElseIf j = i - 1 Then
                                repetido = True
                            End If
                        Else
                            repetido = True
                        End If
                    Next j
                End While
                posicion(i) = pos
            Next i

            For i = 1 To 12
                dgv.Rows(i).Cells(2 * k - 1).Value = posicion(i)
                If posicion(i) = 1 Then
                    dgv.Rows(i).Cells(2 * k).Value = 15
                    sumapuntos(i) = sumapuntos(i) + 15
                ElseIf posicion(i) = 2 Then
                    dgv.Rows(i).Cells(2 * k).Value = 12
                    sumapuntos(i) = sumapuntos(i) + 12
                ElseIf posicion(i) = 3 Then
                    dgv.Rows(i).Cells(2 * k).Value = 10
                    sumapuntos(i) = sumapuntos(i) + 10
                ElseIf posicion(i) = 4 Then
                    dgv.Rows(i).Cells(2 * k).Value = 9
                    sumapuntos(i) = sumapuntos(i) + 9
                ElseIf posicion(i) = 5 Then
                    dgv.Rows(i).Cells(2 * k).Value = 8
                    sumapuntos(i) = sumapuntos(i) + 8
                ElseIf posicion(i) = 6 Then
                    dgv.Rows(i).Cells(2 * k).Value = 7
                    sumapuntos(i) = sumapuntos(i) + 7
                ElseIf posicion(i) = 7 Then
                    dgv.Rows(i).Cells(2 * k).Value = 6
                    sumapuntos(i) = sumapuntos(i) + 6
                ElseIf posicion(i) = 8 Then
                    dgv.Rows(i).Cells(2 * k).Value = 5
                    sumapuntos(i) = sumapuntos(i) + 5
                ElseIf posicion(i) = 9 Then
                    dgv.Rows(i).Cells(2 * k).Value = 4
                    sumapuntos(i) = sumapuntos(i) + 4
                ElseIf posicion(i) = 10 Then
                    dgv.Rows(i).Cells(2 * k).Value = 3
                    sumapuntos(i) = sumapuntos(i) + 3
                ElseIf posicion(i) = 11 Then
                    dgv.Rows(i).Cells(2 * k).Value = 2
                    sumapuntos(i) = sumapuntos(i) + 2
                Else
                    dgv.Rows(i).Cells(2 * k).Value = 1
                    sumapuntos(i) = sumapuntos(i) + 1
                End If
            Next
        Next

        For i = 1 To 12
            dgv.Rows(i).Cells(9).Value = sumapuntos(i)
            dgv.Rows(i).Cells(10).Value = sumapuntos(i) / 4
        Next
        mayormenor()
        MsgBox("El corredor con mas puntos fue el corredor" & posmayor & vbCrLf & "El corredor con menos puntos fue el corredor" & posmenor)

        sumapar = 0
        sumaimpar = 0
        total = 0
        For i = 1 To 12
            total = total + sumapuntos(i)
        Next
        For i = 1 To 6
            sumapar = sumapar + sumapuntos(2 * i)
            sumaimpar = sumaimpar + sumapuntos(2 * i - 1)
        Next
        porpar = sumapar * 100 / total
        porimpar = sumapar * 100 / sumaimpar
        MsgBox("El porcentaje de puntos obtenidos por los corredores pares fue " & porpar & "%" & vbCrLf & "El porcentaje de puntos obtenidos por los corredores pares con respecto a los puntos obtenidos por los corredores impares fue " & porimpar & "%")

    End Sub

    Function aleatorio(LI As Integer, LS As Integer)
        Randomize()
        aleatorio = Int(LI + Rnd() * (LS - LI + 1))
    End Function

    Private Sub mayormenor()
        mayor = 0
        menor = 60
        For i = 1 To 12
            If sumapuntos(i) >= mayor Then
                posmayor = i
                mayor = sumapuntos(i)
            End If
            If sumapuntos(i) <= menor Then
                posmenor = i
                menor = sumapuntos(i)
            End If

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dgv0.RowCount = 13
        dgv0.ColumnCount = 11
        dgv0.Rows(0).Cells(1).Value = "Pos Carr1"
        dgv0.Rows(0).Cells(2).Value = "Puntos"
        dgv0.Rows(0).Cells(3).Value = "Pos Carr2"
        dgv0.Rows(0).Cells(4).Value = "Puntos"
        dgv0.Rows(0).Cells(5).Value = "Pos Carr3"
        dgv0.Rows(0).Cells(6).Value = "Puntos"
        dgv0.Rows(0).Cells(7).Value = "Pos Carr4"
        dgv0.Rows(0).Cells(8).Value = "Puntos"
        dgv0.Rows(0).Cells(9).Value = "TOTAL"
        dgv0.Rows(0).Cells(10).Value = "Promedio"

        For i = 1 To 12
            dgv0.Rows(i).Cells(0).Value = "Corredor" & i
            For j = 1 To 10
                dgv0.Rows(i).Cells(j).Value = dgv.Rows(i).Cells(j).Value
            Next
        Next

        For i = 1 To 12
            For j = i + 1 To 12
                If sumapuntos(i) <= sumapuntos(j) Then

                    For k = 1 To 8
                        aux = dgv0.Rows(i).Cells(k).Value
                        dgv0.Rows(i).Cells(k).Value = dgv0.Rows(j).Cells(k).Value
                        dgv0.Rows(j).Cells(k).Value = aux

                    Next
                    auxcorredor = dgv0.Rows(i).Cells(0).Value
                    dgv0.Rows(i).Cells(0).Value = dgv0.Rows(j).Cells(0).Value
                    dgv0.Rows(j).Cells(0).Value = auxcorredor

                    aux = sumapuntos(i)
                    sumapuntos(i) = sumapuntos(j)
                    sumapuntos(j) = aux
                End If
            Next
        Next

        For i = 1 To 12
            dgv0.Rows(i).Cells(9).Value = sumapuntos(i)
            dgv.Rows(i).Cells(10).Value = sumapuntos(i) / 4
        Next
    End Sub
End Class