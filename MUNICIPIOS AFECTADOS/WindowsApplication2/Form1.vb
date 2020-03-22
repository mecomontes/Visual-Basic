Public Class Form1
    Dim nombre(), auxs As String
    Dim CD(), CM(), CNA(), PP(), total, mayor, posmayor, auxi As Integer
    Dim IR(), porCD(), porCM(), porNA(), portCD, portCM, portNA, auxr As Single
    Dim N, totalpersonas(), totalCD, totalCM, totalNA, dinero() As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        N = Val(InputBox("Ingrese el numero total de municipios afectados"))
        ReDim CD(N), CM(N), CNA(N), PP(N), IR(N), totalpersonas(N), porCD(N), porCM(N), porNA(N), dinero(N)
        dgv0.RowCount = N + 3
        dgv0.ColumnCount = 9

        totalCD = 0
        totalCM = 0
        totalNA = 0
        For i = 1 To N
            dgv0.Rows(i).Cells(0).Value = "Municipio" & i
            CD(i) = aleatorio(0, 5)
            dgv0.Rows(i).Cells(1).Value = CD(i)
            CM(i) = aleatorio(0, 2)
            dgv0.Rows(i).Cells(2).Value = CM(i)
            CNA(i) = aleatorio(80, 100)
            dgv0.Rows(i).Cells(3).Value = CNA(i)
            PP(i) = aleatorio(5000000, 35000000)
            dgv0.Rows(i).Cells(4).Value = PP(i)
            IR(i) = aleatorio(0, 1000) / 1000
            dgv0.Rows(i).Cells(5).Value = IR(i)
            totalCD = totalCD + CD(i)
            totalCM = totalCM + CM(i)
            totalNA = totalNA + CNA(i)
        Next

        dgv0.Rows(N + 1).Cells(0).Value = "TOTAL"
        dgv0.Rows(N + 2).Cells(0).Value = "% del TOTAL"
        dgv0.Rows(0).Cells(0).Value = "NOMBRE"
        dgv0.Rows(0).Cells(1).Value = "CD"
        dgv0.Rows(0).Cells(2).Value = "CM"
        dgv0.Rows(0).Cells(3).Value = "CNA"
        dgv0.Rows(0).Cells(4).Value = "PP"
        dgv0.Rows(0).Cells(5).Value = "IR"
        dgv0.Rows(0).Cells(6).Value = "%D"
        dgv0.Rows(0).Cells(7).Value = "%M"
        dgv0.Rows(0).Cells(8).Value = "%NA"
        total = totalCD + totalCM + totalNA

        For i = 1 To N
            totalpersonas(i) = CD(i) + CM(i) + CNA(i)
            porCD(i) = CD(i) * 100 / totalpersonas(i)
            dgv0.Rows(i).Cells(6).Value = porCD(i)
            porCM(i) = CM(i) * 100 / totalpersonas(i)
            dgv0.Rows(i).Cells(7).Value = porCM(i)
            porNA(i) = CNA(i) * 100 / totalpersonas(i)
            dgv0.Rows(i).Cells(8).Value = porNA(i)
        Next

        dgv0.Rows(N + 1).Cells(1).Value = totalCD
        dgv0.Rows(N + 1).Cells(2).Value = totalCM
        dgv0.Rows(N + 1).Cells(3).Value = totalNA
        portCD = totalCD * 100 / total
        portCM = totalCM * 100 / total
        portNA = totalNA * 100 / total
        dgv0.Rows(N + 2).Cells(1).Value = portCD
        dgv0.Rows(N + 2).Cells(2).Value = portCM
        dgv0.Rows(N + 2).Cells(3).Value = portNA

        TextBox1.Text = "el dinero recuperado por cada municipio es: " & vbCrLf
        For i = 1 To N
            dinero(i) = dinerorecuperado(i)
            TextBox1.Text = TextBox1.Text & "Municipio" & i & ":  " & dinero(i) & " pesos" & vbCrLf
        Next
        municipiomayor()
        MsgBox("El municipio con mas muertos fue el municipio" & posmayor & " con " & mayor & "muertos")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dgv1.RowCount = N + 3
        dgv1.ColumnCount = 9
        dgv1.Rows(N + 1).Cells(0).Value = "TOTAL"
        dgv1.Rows(N + 2).Cells(0).Value = "% del TOTAL"
        dgv1.Rows(0).Cells(0).Value = "NOMBRE"
        dgv1.Rows(0).Cells(1).Value = "CD"
        dgv1.Rows(0).Cells(2).Value = "CM"
        dgv1.Rows(0).Cells(3).Value = "CNA"
        dgv1.Rows(0).Cells(4).Value = "PP"
        dgv1.Rows(0).Cells(5).Value = "IR"
        dgv1.Rows(0).Cells(6).Value = "%D"
        dgv1.Rows(0).Cells(7).Value = "%M"
        dgv1.Rows(0).Cells(8).Value = "%NA"

        For i = 1 To N + 2
            For j = 0 To 8
                dgv1.Rows(i).Cells(j).Value = dgv0.Rows(i).Cells(j).Value
            Next
        Next

        For i = 1 To N
            For j = i + 1 To N
                If CNA(i) <= CNA(j) Then
                    auxi = CD(i)
                    CD(i) = CD(j)
                    CD(j) = auxi
                    auxi = CM(i)
                    CM(i) = CM(j)
                    CM(j) = auxi
                    auxi = CNA(i)
                    CNA(i) = CNA(j)
                    CNA(j) = auxi
                    auxi = PP(i)
                    PP(i) = PP(j)
                    PP(j) = auxi
                    auxr = IR(i)
                    IR(i) = IR(j)
                    IR(j) = auxr
                    auxr = porCD(i)
                    porCD(i) = porCD(j)
                    porCD(j) = auxr
                    auxr = porCM(i)
                    porCM(i) = porCM(j)
                    porCM(j) = auxr
                    auxr = porNA(i)
                    porNA(i) = porNA(j)
                    porNA(j) = auxr
                    auxs = dgv1.Rows(i).Cells(0).Value
                    dgv1.Rows(i).Cells(0).Value = dgv1.Rows(j).Cells(0).Value
                    dgv1.Rows(j).Cells(0).Value = auxs

                End If
            Next
        Next

        For i = 1 To N
            dgv1.Rows(i).Cells(1).Value = CD(i)
            dgv1.Rows(i).Cells(2).Value = CM(i)
            dgv1.Rows(i).Cells(3).Value = CNA(i)
            dgv1.Rows(i).Cells(4).Value = PP(i)
            dgv1.Rows(i).Cells(5).Value = IR(i)
            dgv1.Rows(i).Cells(6).Value = porCD(i)
            dgv1.Rows(i).Cells(7).Value = porCM(i)
            dgv1.Rows(i).Cells(8).Value = porNA(i)
        Next

    End Sub

    Function dinerorecuperado(i As Integer)
        dinerorecuperado = IR(i) * totalpersonas(i) * (CD(i) + CM(i) + CNA(i))
    End Function

    Private Sub municipiomayor()
        mayor = 0
        For i = 1 To N
            If CM(i) > mayor Then
                posmayor = i
                mayor = CM(i)
            ElseIf CM(i) = mayor Then
                If CNA(i) > CNA(i - 1) Then
                    posmayor = i
                    mayor = CM(i)
                End If
            End If
        Next
    End Sub

    Function aleatorio(LI As Integer, LS As Integer)
        Randomize()
        aleatorio = Int(LI + Rnd() * (LS - LI + 1))
    End Function

End Class
