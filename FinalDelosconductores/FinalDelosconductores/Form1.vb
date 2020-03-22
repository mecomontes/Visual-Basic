Public Class Form1
    Dim datos(,) As Integer
    Dim n As Integer
    Dim f, c As Byte


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        n = Val(InputBox("Ingrese numero de buses(N)"))

        f = n
        c = 9

        Dgv.RowCount = n + 1
        Dgv.ColumnCount = 10 + 2

        ReDim datos(f, c)


        Dgv.Rows(0).Cells(0).Value = "Nombre"
        Dgv.Rows(0).Cells(1).Value = "Municipio"
        Dgv.Rows(0).Cells(2).Value = "Marca"
        Dgv.Rows(0).Cells(3).Value = "Genero"
        Dgv.Rows(0).Cells(4).Value = "Edad"
        Dgv.Rows(0).Cells(5).Value = "Lunes"
        Dgv.Rows(0).Cells(6).Value = "Martes"
        Dgv.Rows(0).Cells(7).Value = "Miercoles"
        Dgv.Rows(0).Cells(8).Value = "Jueves"
        Dgv.Rows(0).Cells(9).Value = "Viernes"

        For i = 1 To n
            Dgv.Rows(i).Cells(0).Value = "Conductor " & i
        Next

        Call genrand()




    End Sub
    Sub genrand()
        Randomize()

        For i = 1 To n
            For j = 1 To 9
                datos(i, 1) = Int(1 + Rnd() * (4 - 1 + 1))
                Dgv.Rows(i).Cells(1).Value = datos(i, 1)

                datos(i, 2) = Int(0 + Rnd() * (7 - 0 + 1))
                Dgv.Rows(i).Cells(2).Value = datos(i, 2)

                datos(i, 3) = Int(100 + Rnd() * (101 - 100 + 1))
                If datos(i, 3) = 100 Then
                    Dgv.Rows(i).Cells(3).Value = "M"
                Else
                    Dgv.Rows(i).Cells(3).Value = "F"

                End If

                datos(i, 4) = Int(18 + Rnd() * (65 - 18 + 1))
                Dgv.Rows(i).Cells(4).Value = datos(i, 4)

                datos(i, 5) = Int(50 + Rnd() * (250 - 50 + 1))
                Dgv.Rows(i).Cells(5).Value = datos(i, 5)

                datos(i, 6) = Int(50 + Rnd() * (250 - 50 + 1))
                Dgv.Rows(i).Cells(6).Value = datos(i, 6)

                datos(i, 7) = Int(50 + Rnd() * (250 - 50 + 1))
                Dgv.Rows(i).Cells(7).Value = datos(i, 7)

                datos(i, 8) = Int(50 + Rnd() * (250 - 50 + 1))
                Dgv.Rows(i).Cells(8).Value = datos(i, 8)

                datos(i, 9) = Int(50 + Rnd() * (250 - 50 + 1))
                Dgv.Rows(i).Cells(9).Value = datos(i, 9)
            Next

        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sumamujeres As Long
        Dim sumahombres As Long
        sumahombres = 0

        sumamujeres = 0
        For i = 1 To f

            If datos(i, 3) = 101 And datos(i, 6) > 70 And datos(i, 9) > 70 Then
                sumamujeres = sumamujeres + 1

            End If

            If datos(i, 3) = 100 And datos(i, 5) < 80 Or datos(i, 8) < 80 Then
                sumahombres = sumahombres + 1
            End If



        Next

        txt.Text = txt.Text & "Cantidad mujeres: " & sumamujeres & vbCrLf & "Cantidad de hombres: " & sumahombres & vbCrLf


    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim totalconductor(c) As Integer
        Dim max As Integer
        Dim minmax As Byte

        For j = 5 To 9
            totalconductor(j) = 0
            For i = 0 To f
                totalconductor(i) = totalconductor(i) + datos(i, j)
                Dgv.Rows(i).Cells(10).Value = totalconductor(i)
            Next

        Next

        max = Val(Dgv.Rows(1).Cells(10).Value)

        For i = 1 To f
            If Val(Dgv.Rows(i).Cells(10).Value) > max Then
                max = Val(Dgv.Rows(i).Cells(10).Value)
                minmax = Val(Dgv.Rows(i).Cells(1).Value)
            End If

        Next

        txt.Text = txt.Text & "municipio con mayor pasajeros " & minmax & "con " & max & "pasajeros " & vbCrLf & datos(f, c) & vbCrLf

    End Sub
End Class
