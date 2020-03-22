Public Class Form1
    Dim N As Integer
    Dim aux As Integer
    Dim auxP As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        N = Val(InputBox("INGRESE EL NUMERO DE PERSONAS"))

        DGV.RowCount = N + 1
        DGV.ColumnCount = 6

        DGV.Rows(0).Cells(1).Value = "EDAD"
        DGV.Rows(0).Cells(2).Value = "TALLA"
        DGV.Rows(0).Cells(3).Value = "PESO"
        DGV.Rows(0).Cells(4).Value = "CARNET"
        DGV.Rows(0).Cells(5).Value = "TELEFONO"

        For i = 1 To N
            DGV.Rows(i).Cells(0).Value = "PERSONA" & i
        Next

        For i = 1 To N
            DGV.Rows(i).Cells(1).Value = Val(InputBox("INGRESE LA EDAD PARA LA PERSONA" & i))
            DGV.Rows(i).Cells(2).Value = Aleatorio(150, 210)
            DGV.Rows(i).Cells(3).Value = Aleatorio(40, 200)
            DGV.Rows(i).Cells(4).Value = Aleatorio(7500000, 44000000)
            DGV.Rows(i).Cells(5).Value = Aleatorio(200000, 9000000)
        Next

    End Sub

    Function Aleatorio(LI As Integer, LS As Integer)
        Randomize()
        Aleatorio = Int(LI + Rnd() * (LS - LI + 1))
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 1 To N - 1
            For j = i + 1 To N
                If DGV.Rows(i).Cells(3).Value >= DGV.Rows(j).Cells(3).Value Then

                    For k = 1 To 5
                        aux = DGV.Rows(i).Cells(k).Value
                        DGV.Rows(i).Cells(k).Value = DGV.Rows(j).Cells(k).Value
                        DGV.Rows(j).Cells(k).Value = aux
                    Next

                    auxP = DGV.Rows(i).Cells(0).Value
                    DGV.Rows(i).Cells(0).Value = DGV.Rows(j).Cells(0).Value
                    DGV.Rows(j).Cells(0).Value = auxP

                End If
            Next
        Next
    End Sub
End Class
