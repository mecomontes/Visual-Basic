Public Class Form1


    Dim vnombre() As String
    Dim vmaxima() As Integer
    Dim vruta() As String
    Dim mpasajeros(,), mpasajeros2(,) As Integer
    Dim rnd As New Random
    Dim n, aux As Integer
    Dim auxmaxima As Integer
    Dim auxruta As Integer
    Dim vdias() As Integer
    Dim vsuma() As Integer
    Dim suma As Integer
    Dim vprecio() As Integer
    Dim promedio, vprom(28) As Double
    Dim totalsur, totalcentro, totalnorte As Integer
    Dim pasajerossur, pasajerosnorte, pasajeroscentro As Integer
    Dim totalpasajeros As Integer
    Dim procentajesur, porcentajenorte, porcentajecentro As Double

    Function generarmaxima() As Integer
        auxmaxima = Rnd.Next(1, 4)
        If auxmaxima = 1 Then
            Return 13
        End If
        If auxmaxima = 2 Then
            Return 19
        End If
        If auxmaxima = 3 Then
            Return 31
        End If

    End Function

    Function generarurta() As String
        auxruta = Rnd.Next(1, 4)
        If auxruta = 1 Then
            Return "Sur"
        End If
        If auxruta = 2 Then
            Return "Centro"
        End If
        If auxruta = 3 Then
            Return "Norte"
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = InputBox("Ingrese numero de Buses")

        dgv.RowCount = n + 2
        dgv.ColumnCount = 33

        dgv1.RowCount = n + 2
        dgv1.ColumnCount = 33

        ReDim vnombre(n - 1)
        ReDim vruta(n - 1)
        ReDim vmaxima(n - 1)
        ReDim mpasajeros(n - 1, 27)
        ReDim mpasajeros2(n - 1, 27)


        dgv.Item(0, 0).Value = "Buses"
        dgv.Item(1, 0).Value = "Ruta"
        dgv.Item(2, 0).Value = "Cap Maxima"

        dgv1.Item(0, 0).Value = "Buses"
        dgv1.Item(1, 0).Value = "Ruta"
        dgv1.Item(2, 0).Value = "Cap Maxima"

        For i = 1 To 28
            dgv.Item(i + 2, 0).Value = i
            dgv1.Item(i + 2, 0).Value = i
        Next
        For i = 0 To n - 1
            vnombre(i) = "Bus" & i + 1
            vruta(i) = generarurta()
            vmaxima(i) = generarmaxima()

            dgv.Item(0, i + 1).Value = vnombre(i)
            dgv.Item(1, i + 1).Value = vruta(i)
            dgv.Item(2, i + 1).Value = vmaxima(i)

            dgv1.Item(0, i + 1).Value = vnombre(i)
            dgv1.Item(1, i + 1).Value = vruta(i)
            dgv1.Item(2, i + 1).Value = vmaxima(i)

            For j = 0 To 27

                If vmaxima(i) = 13 Then
                    mpasajeros(i, j) = rnd.Next(1, 14)
                End If
                If vmaxima(i) = 19 Then
                    mpasajeros(i, j) = rnd.Next(1, 20)
                End If
                If vmaxima(i) = 31 Then
                    mpasajeros(i, j) = rnd.Next(1, 32)
                End If

                dgv.Item(j + 3, i + 1).Value = mpasajeros(i, j)
            Next
        Next
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReDim vsuma(n - 1)

        dgv.Item(31, 0).Value = "Total Pasajeros"
        dgv1.Item(31, 0).Value = "Total Pasajeros"
        suma = 0

        For i = 0 To n - 1
            For j = 0 To 27
                suma = suma + mpasajeros(i, j)
                vsuma(i) = suma
            Next
            dgv.Item(31, i + 1).Value = vsuma(i)
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ReDim vprecio(n - 1)

        dgv.Item(32, 0).Value = "Total Dinero"
        dgv1.Item(32, 0).Value = "Total Dinero"

        For i = 0 To n - 1
            If vmaxima(i) = 13 Then
                vprecio(i) = vsuma(i) * 1200
            End If
            If vmaxima(i) = 19 Then
                vprecio(i) = vsuma(i) * 1500
            End If
            If vmaxima(i) = 31 Then
                vprecio(i) = vsuma(i) * 2000
            End If
            dgv.Item(32, i + 1).Value = vprecio(i)
        Next
    End Sub

    Sub mostrarprom()


        Dim acum As Double
        For j = 0 To 27
            acum = 0

            For i = 0 To n - 1
                acum = mpasajeros(i, j) + acum
            Next
            vprom(j + 1) = acum / n
            dgv.Item(j + 3, n + 1).Value = vprom(j + 1)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dgv.Item(2, n + 1).Value = "Promedio"
        mostrarprom()
    End Sub


    Sub platarutas(vruta() As String, vprecio() As Integer)
        totalsur = 0
        totalcentro = 0
        totalnorte = 0

        For i = 0 To n - 1
            If vruta(i) = "Sur" Then
                totalsur = totalsur + vprecio(i)
            End If
            If vruta(i) = "Centro" Then
                totalcentro = totalcentro + vprecio(i)
            End If
            If vruta(i) = "Norte" Then
                totalnorte = totalnorte + vprecio(i)
            End If
        Next

        MsgBox("Total Recaudado en la Ruta Sur es : " & totalsur & "El de la Ruta Centro es :" & totalcentro & "El de la Ruta Norte es :" & totalnorte)
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        platarutas(vruta, vprecio)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        pasajerossur = 0
        pasajerosnorte = 0
        pasajerossur = 0
        totalpasajeros = 0

        For i = 0 To n - 1
            If vruta(i) = "Sur" Then
                pasajerossur = pasajerossur + vsuma(i)
            End If
            If vruta(i) = "Centro" Then
                pasajeroscentro = pasajeroscentro + vsuma(i)
            End If
            If vruta(i) = "Norte" Then
                pasajerosnorte = pasajerosnorte + vsuma(i)
            End If

            totalpasajeros = totalpasajeros + vsuma(i)

        Next

        procentajesur = (pasajerossur * 100) / totalpasajeros
        porcentajenorte = (pasajerosnorte * 100) / totalpasajeros
        porcentajecentro = (pasajeroscentro * 100) / totalpasajeros

        MsgBox("Pasajeros Sur" & procentajesur & "%" & "Pasajeros Centro" & pasajeroscentro & "%" & "Pasajeros Norte" & pasajerosnorte & "%")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For i = 1 To 32
            For j = 1 To n
                dgv1.Item(i, j).Value = dgv.Item(i, j).Value
            Next
        Next
        dgv1.Item(2, n + 1).Value = "Promedio"

        For i = 1 To 28
            For j = i + 1 To 28
                If vprom(i) <= vprom(j) Then

                    For k = 1 To n
                        aux = dgv1.Rows(k).Cells(i + 2).Value
                        dgv1.Rows(k).Cells(i + 2).Value = dgv1.Rows(k).Cells(j + 2).Value
                        dgv1.Rows(k).Cells(j + 2).Value = aux

                    Next

                    auxruta = dgv1.Rows(0).Cells(i + 2).Value
                    dgv1.Rows(0).Cells(i + 2).Value = dgv1.Rows(0).Cells(j + 2).Value
                    dgv1.Rows(0).Cells(j + 2).Value = auxruta

                    aux = vprom(i)
                    vprom(i) = vprom(j)
                    vprom(j) = aux
                End If
            Next
        Next

        For i = 1 To 28
            dgv1.Rows(n + 1).Cells(i + 2).Value = vprom(i)
        Next


    End Sub
End Class
  