Public Class Form1
    Dim Em As Double
    Dim G As Double
    Dim v As Double
    Dim Vs As Double
    Dim Pe As Double
    Dim B As Double
    Dim Bd As Integer
    Dim n As Integer
    Dim filas As Integer
    Dim columnas As Integer
    Dim h As Double


    Private Sub DEFORMACIONES_Click(sender As Object, e As EventArgs) Handles DEFORMACIONES.Click
        Em = Val(Rigidez.Text)
        G = Val(Elasticidad.Text)
        Vs = Val(Vonda.Text)
        B = Val(Zapata.Text)
        Bd = Val(RelacionBd.Text)
        n = Val(Nodosd.Text)
        v = Val(Poisson.Text)
        Pe = Val(PesoE.Text)
        h = B / (Bd * (n + 1))
        filas = 10 * Bd * (n + 1) + 1
        columnas = 21 * Bd * (n + 1) + 1
        DGV.RowCount = filas
        DGV.ColumnCount = columnas

        If Poisson.Text = "" Then
            v = Em / (2 * G) - 1
        ElseIf Elasticidad.Text = "" Then
            G = Em / (2 * (1 + v))
        ElseIf Rigidez.Text = "" Then
            Em = 2 * G * (1 + v)
        End If

        For i = 0 To filas - 1
            For j = 0 To columnas - 1
                DGV.Rows(i).Cells(j).Value = 5
            Next
        Next

        For i = 2 To filas - 3
            For j = 2 To columnas - 3
                DGV.Rows(i).Cells(j).Value = (8 * (DGV.Rows(i + 1).Cells(j).Value + DGV.Rows(i - 1).Cells(j).Value + DGV.Rows(i).Cells(j + 1).Value + DGV.Rows(i).Cells(j - 1).Value) - 2 * (DGV.Rows(i + 1).Cells(j - 1).Value + DGV.Rows(i - 1).Cells(j + 1).Value + DGV.Rows(i + 1).Cells(j + 1).Value + DGV.Rows(i - 1).Cells(j - 1).Value) - (DGV.Rows(i + 2).Cells(j).Value + DGV.Rows(i - 2).Cells(j).Value + DGV.Rows(i).Cells(j + 2).Value + DGV.Rows(i).Cells(j - 2).Value)) * h ^ 4 / 20
            Next
        Next

        For i = 2 To filas - 3
            DGV.Rows(i).Cells(1).Value = (8 * (DGV.Rows(i + 1).Cells(1).Value + DGV.Rows(i - 1).Cells(1).Value + DGV.Rows(i).Cells(2).Value + DGV.Rows(i).Cells(0).Value) - 2 * (DGV.Rows(i + 1).Cells(0).Value + DGV.Rows(i - 1).Cells(2).Value + DGV.Rows(i + 1).Cells(2).Value + DGV.Rows(i - 1).Cells(0).Value) - (DGV.Rows(i + 2).Cells(1).Value + DGV.Rows(i - 2).Cells(1).Value + 2 * DGV.Rows(i).Cells(3).Value)) * h ^ 4 / 20
            DGV.Rows(i).Cells(1).Value = (8 * (DGV.Rows(i + 1).Cells(columnas - 2).Value + DGV.Rows(i - 1).Cells(columnas - 2).Value + DGV.Rows(i).Cells(columnas - 3).Value + DGV.Rows(i).Cells(columnas - 1).Value) - 2 * (DGV.Rows(i + 1).Cells(columnas - 1).Value + DGV.Rows(i - 1).Cells(columnas - 3).Value + DGV.Rows(i + 1).Cells(columnas - 3).Value + DGV.Rows(i - 1).Cells(columnas - 1).Value) - (DGV.Rows(i + 2).Cells(columnas - 2).Value + DGV.Rows(i - 2).Cells(columnas - 2).Value + 2 * DGV.Rows(i).Cells(columnas - 4).Value)) * h ^ 4 / 20
        Next

        For j = 2 To columnas - 3
            DGV.Rows(filas - 2).Cells(j).Value = (8 * (DGV.Rows(filas - 1).Cells(j).Value + DGV.Rows(filas - 3).Cells(j).Value + DGV.Rows(filas - 2).Cells(j + 1).Value + DGV.Rows(filas - 2).Cells(j - 1).Value) - 2 * (DGV.Rows(filas - 1).Cells(j - 1).Value + DGV.Rows(filas - 3).Cells(j + 1).Value + DGV.Rows(filas - 1).Cells(j + 1).Value + DGV.Rows(filas - 3).Cells(j - 1).Value) - (2 * DGV.Rows(filas - 4).Cells(j).Value + DGV.Rows(filas - 2).Cells(j + 2).Value + DGV.Rows(filas - 2).Cells(j - 2).Value)) * h ^ 4 / 20
        Next

        DGV.Rows(1).Cells(1).Value = (8 * (DGV.Rows(2).Cells(1).Value + DGV.Rows(0).Cells(1).Value + DGV.Rows(1).Cells(2).Value + DGV.Rows(1).Cells(0).Value) - 2 * (DGV.Rows(2).Cells(0).Value + DGV.Rows(0).Cells(2).Value + DGV.Rows(2).Cells(2).Value + DGV.Rows(0).Cells(0).Value) - 2 * (DGV.Rows(3).Cells(1).Value + DGV.Rows(1).Cells(3).Value)) * h ^ 4 / 20
        DGV.Rows(filas - 2).Cells(1).Value = (8 * (DGV.Rows(filas - 3).Cells(1).Value + DGV.Rows(filas - 1).Cells(1).Value + DGV.Rows(filas - 2).Cells(2).Value + DGV.Rows(filas - 2).Cells(0).Value) - 2 * (DGV.Rows(filas - 3).Cells(0).Value + DGV.Rows(filas - 1).Cells(2).Value + DGV.Rows(filas - 3).Cells(2).Value + DGV.Rows(filas - 1).Cells(0).Value) - 2 * (DGV.Rows(filas - 4).Cells(1).Value + DGV.Rows(filas - 2).Cells(3).Value)) * h ^ 4 / 20
        DGV.Rows(1).Cells(columnas - 2).Value = (8 * (DGV.Rows(2).Cells(columnas - 2).Value + DGV.Rows(0).Cells(columnas - 2).Value + DGV.Rows(1).Cells(columnas - 3).Value + DGV.Rows(1).Cells(columnas - 1).Value) - 2 * (DGV.Rows(2).Cells(columnas - 1).Value + DGV.Rows(0).Cells(columnas - 3).Value + DGV.Rows(2).Cells(columnas - 3).Value + DGV.Rows(0).Cells(columnas - 1).Value) - 2 * (DGV.Rows(3).Cells(columnas - 2).Value + DGV.Rows(1).Cells(columnas - 4).Value)) * h ^ 4 / 20
        DGV.Rows(filas - 2).Cells(columnas - 2).Value = (8 * (DGV.Rows(filas - 3).Cells(columnas - 2).Value + DGV.Rows(filas - 1).Cells(columnas - 2).Value + DGV.Rows(filas - 2).Cells(columnas - 3).Value + DGV.Rows(filas - 2).Cells(columnas - 1).Value) - 2 * (DGV.Rows(filas - 3).Cells(columnas - 1).Value + DGV.Rows(filas - 1).Cells(columnas - 3).Value + DGV.Rows(filas - 3).Cells(columnas - 3).Value + DGV.Rows(filas - 1).Cells(columnas - 1).Value) - 2 * (DGV.Rows(filas - 4).Cells(columnas - 2).Value + DGV.Rows(filas - 2).Cells(columnas - 4).Value)) * h ^ 4 / 20



    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Rigidez.Text = ""
        Elasticidad.Text = ""
        Vonda.Text = ""
        Zapata.Text = ""
        RelacionBd.Text = ""
        Nodosd.Text = ""
        Poisson.Text = ""
        PesoE.Text = ""
    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        End
    End Sub

End Class
