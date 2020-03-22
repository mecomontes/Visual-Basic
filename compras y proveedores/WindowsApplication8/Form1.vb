Public Class Form1
    Dim N As Integer
    Dim M As Integer
    Dim totalcompras As Integer
    Dim valorcompra As Integer
    Dim articulos As Integer
    Dim totalarticulos As Integer
    Dim valorunitario As Single
    Dim acumtotalarticulos As Integer
    Dim promaticulos As Single
    Dim grantotal As Integer
    Dim menor As Single
    Dim posicionmenor As Integer

    Private Sub Buttoncalcular_Click(sender As Object, e As EventArgs) Handles Buttoncalcular.Click
        N = Val(TextBox1.Text)
        totalcompras = aleatorio(1, 2000)

        DGV.RowCount = totalcompras + 1
        DGV.ColumnCount = N + 3
        DGV.Rows(0).Cells(N + 1).Value = "total compra"
        DGV.Rows(0).Cells(N + 2).Value = "valor unitario"


        For i = 1 To N
            DGV.Rows(0).Cells(i).Value = "proveedor" & i
           
        Next

        For i = 1 To totalcompras
            valorcompra = aleatorio(5000, 500000)
            DGV.Rows(i).Cells(0).Value = "compra " & i
            DGV.Rows(i).Cells(N + 1).Value = valorcompra
        Next

        For i = 1 To totalcompras
            For j = 1 To N
                articulos = aleatorio(1, 255)
                DGV.Rows(i).Cells(j).Value = articulos
            Next
        Next

        For i = 1 To totalcompras
            totalarticulos = 0
            For j = 1 To N
                totalarticulos = totalarticulos + DGV.Rows(i).Cells(j).Value
            Next

            valorunitario = DGV.Rows(i).Cells(N + 1).Value / totalarticulos
            DGV.Rows(i).Cells(N + 2).Value = valorunitario
            grantotal = grantotal + totalarticulos

        Next

        For i = 1 To totalcompras
            acumtotalarticulos = acumtotalarticulos + DGV.Rows(i).Cells(N + 1).Value
        Next
        promaticulos = acumtotalarticulos / grantotal
        TextBox2.Text = promaticulos

        menor = 500000

        For i = 1 To totalcompras
            If DGV.Rows(i).Cells(N + 2).Value < menor Then
                menor = DGV.Rows(i).Cells(N + 2).Value
                posicionmenor = i
            End If
        Next
        TextBox3.Text = promaticulos

    End Sub

    Private Sub Buttonsalir_Click(sender As Object, e As EventArgs) Handles Buttonsalir.Click
        End
    End Sub

    Private Sub Buttonborrar_Click(sender As Object, e As EventArgs) Handles Buttonborrar.Click
        TextBox1.Text = " "
    End Sub

    Function aleatorio(LI As Integer, LS As Integer)
        Randomize()
        aleatorio = (LI + Rnd() * (LS - LI + 1))
    End Function

End Class
