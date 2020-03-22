Public Class Form1
    Dim matrizdinero(8, 8) As Integer
    Dim matrizparroco(8, 8) As String
    Dim parroco, sumaeuca, sumadia, eucajuan, eucamateo, eucamarcos, eucalucas, totaleuca(8) As Integer
    Dim dinerototal, dinerojuan, menor, mayor, fmenor, cmenor, fmayor, cmayor, aux As Integer
    Dim diamenor, diamayor, auxparroco As String
    Dim repite As Boolean
    Dim promeuca As Single


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgv.RowCount = 10
        dgv.ColumnCount = 18
        dgv.Rows(0).Cells(1).Value = "Domingo"
        dgv.Rows(0).Cells(2).Value = "Lunes"
        dgv.Rows(0).Cells(3).Value = "Martes"
        dgv.Rows(0).Cells(4).Value = "Miercoles"
        dgv.Rows(0).Cells(5).Value = "Jueves"
        dgv.Rows(0).Cells(6).Value = "Viernes"
        dgv.Rows(0).Cells(7).Value = "Sabado"
        dgv.Rows(0).Cells(8).Value = "Domingo"
        dgv.Rows(0).Cells(17).Value = "TOTAL"
        dgv.Rows(9).Cells(8).Value = "TOTAL"

        For i = 1 To 8
            dgv.Rows(i).Cells(0).Value = "Eucaristía" & i
            dgv.Rows(0).Cells(i + 8).Value = dgv.Rows(0).Cells(i).Value
        Next

        eucajuan = 0
        eucamateo = 0
        eucamarcos = 0
        eucalucas = 0

        For j = 1 To 8
            repite = False

            For i = 1 To 8
                parroco = aleatorio(1, 4)
                If parroco = 1 Then
                    matrizparroco(i, j) = "Lucas"
                    eucalucas = eucalucas + 1
                    dgv.Rows(i).Cells(j).Value = matrizparroco(i, j)

                ElseIf parroco = 2 Then
                    matrizparroco(i, j) = "Marcos"
                    eucamarcos = eucamarcos + 1
                    dgv.Rows(i).Cells(j).Value = matrizparroco(i, j)

                ElseIf parroco = 3 Then
                    If repite = False Then
                        matrizparroco(i, j) = "Juan"
                        dgv.Rows(i).Cells(j).Value = matrizparroco(i, j)
                        eucajuan = eucajuan + 1
                        repite = True
                    Else
                        matrizparroco(i, j) = "Marcos"
                        eucamarcos = eucamarcos + 1
                        dgv.Rows(i).Cells(j).Value = matrizparroco(i, j)
                    End If

                ElseIf parroco = 4 Then
                    matrizparroco(i, j) = "Mateo"
                    eucamateo = eucamateo + 1
                    dgv.Rows(i).Cells(j).Value = matrizparroco(i, j)
                End If

                matrizdinero(i, j) = aleatorio(50000, 625000)
                dgv.Rows(i).Cells(j + 8).Value = matrizdinero(i, j)
            Next
        Next
        total()

        dinerojuan = 0

        For i = 1 To 8
            For j = 1 To 8
                If matrizparroco(i, j) = "Juan" Then
                    dinerojuan = dinerojuan + matrizdinero(i, j)
                End If
            Next
        Next
        promeuca = eucajuan * 100 / 68

        TextBox1.Text = "El promedio de eucaristias de Juan fue " & promeuca & "%" & vbCrLf
        TextBox2.Text = "El total de dinero recaudado por Juan fue " & dinerojuan & " pesos"
        TextBox3.Text = "Mateo dirigio " & eucamateo & " eucaristias en total" & vbCrLf & "Marcos dirigio " & eucamarcos & " eucaristias en total" & vbCrLf & "Lucas dirigio " & eucalucas & " eucaristias en total" & vbCrLf

        mayormenor()
        TextBox4.Text = "La mayor cantidad de dinero se recogio: " & vbCrLf & diamayor & " con el parroco " & matrizparroco(fmayor, cmayor) & " y un total de " & matrizdinero(fmayor, cmayor) & " pesos" & vbCrLf
        TextBox4.Text = TextBox4.Text & "La menor cantidad de dinero se recogio: " & vbCrLf & diamenor & " con el parroco " & matrizparroco(fmenor, cmenor) & " y un total de " & matrizdinero(fmenor, cmenor) & " pesos"

    End Sub

    Private Sub mayormenor()
        mayor = 0
        menor = 8 * 625000
        For i = 1 To 8
            For j = 1 To 8
                If matrizdinero(i, j) >= mayor Then
                    fmayor = i
                    cmayor = j
                    mayor = matrizdinero(i, j)
                End If
                If matrizdinero(i, j) <= menor Then
                    fmenor = i
                    cmenor = j
                    menor = matrizdinero(i, j)
                End If
            Next
        Next
    End Sub

    Private Sub total()
        dinerototal = 0
        For i = 1 To 8
            sumaeuca = 0
            sumadia = 0

            For j = 1 To 8
                sumaeuca = sumaeuca + matrizdinero(i, j)
                sumadia = sumadia + matrizdinero(j, i)
            Next
            totaleuca(i) = sumaeuca
            dgv.Rows(9).Cells(i + 8).Value = sumadia
            dgv.Rows(i).Cells(17).Value = sumaeuca
            dinerototal = dinerototal + sumaeuca
        Next

        If cmayor = 1 Then
            diamayor = "Domingo ramos"
        ElseIf cmayor = 2 Then
            diamayor = "Lunes"
        ElseIf cmayor = 3 Then
            diamayor = "Martes"
        ElseIf cmayor = 4 Then
            diamayor = "Miercoles"
        ElseIf cmayor = 5 Then
            diamayor = "Jueves"
        ElseIf cmayor = 6 Then
            diamayor = "Viernes"
        ElseIf cmayor = 7 Then
            diamayor = "Sabado"
        Else
            diamayor = "Domingo resurreccion"
        End If

        If cmenor = 1 Then
            diamenor = "Domingo ramos"
        ElseIf cmenor = 2 Then
            diamenor = "Lunes"
        ElseIf cmenor = 3 Then
            diamenor = "Martes"
        ElseIf cmenor = 4 Then
            diamenor = "Miercoles"
        ElseIf cmenor = 5 Then
            diamenor = "Jueves"
        ElseIf cmenor = 6 Then
            diamenor = "Viernes"
        ElseIf cmenor = 7 Then
            diamenor = "Sabado"
        Else
            diamenor = "Domingo resurreccion"
        End If

    End Sub

    Function aleatorio(LI As Integer, LS As Integer)
        Randomize()
        aleatorio = Int(LI + Rnd() * (LS - LI + 1))
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dgv0.RowCount = 10
        dgv0.ColumnCount = 18
        dgv0.Rows(0).Cells(1).Value = "Domingo"
        dgv0.Rows(0).Cells(2).Value = "Lunes"
        dgv0.Rows(0).Cells(3).Value = "Martes"
        dgv0.Rows(0).Cells(4).Value = "Miercoles"
        dgv0.Rows(0).Cells(5).Value = "Jueves"
        dgv0.Rows(0).Cells(6).Value = "Viernes"
        dgv0.Rows(0).Cells(7).Value = "Sabado"
        dgv0.Rows(0).Cells(8).Value = "Domingo"
        dgv0.Rows(0).Cells(17).Value = "TOTAL"
        dgv0.Rows(9).Cells(8).Value = "TOTAL"

        For i = 1 To 8
            dgv0.Rows(i).Cells(0).Value = "Eucaristía" & i
            dgv0.Rows(0).Cells(i + 8).Value = dgv.Rows(0).Cells(i).Value
        Next

        For i = 1 To 8
            For j = i + 1 To 8
                If totaleuca(i) > totaleuca(j) Then

                    For k = 1 To 8
                        aux = matrizdinero(i, k)
                        matrizdinero(i, k) = matrizdinero(j, k)
                        matrizdinero(j, k) = aux
                        auxparroco = matrizparroco(i, k)
                        matrizparroco(i, k) = matrizparroco(j, k)
                        matrizparroco(j, k) = auxparroco
                    Next
                    aux = totaleuca(i)
                    totaleuca(i) = totaleuca(j)
                    totaleuca(j) = aux


                End If
            Next
        Next

        For i = 1 To 8
            dgv0.Rows(i).Cells(17).Value = totaleuca(i)
            For j = 1 To 8
                dgv0.Rows(i).Cells(j).Value = matrizparroco(i, j)
                dgv0.Rows(i).Cells(j + 8).Value = matrizdinero(i, j)
            Next
        Next


    End Sub
End Class
