Public Class Form1
    Dim N As Integer
    Dim Vector() As Integer
    Dim Matriz(,) As Integer
    Dim aux As Integer
    Dim Cont As Integer
    Dim posrepeat As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        N = Val(TextBox1.Text)
        ReDim Vector(N)
        ReDim Matriz(N, N)

        dgvi.RowCount = N
        dgvi.ColumnCount = N

        For i = 1 To N
            Vector(i) = Aleatorio(0, 18)
            TextBoxVi.Text = TextBoxVi.Text & Vector(i) & vbCrLf
        Next

        For i = 1 To N
            For j = 1 To N
                Matriz(i, j) = Aleatorio(1, 13)
                TextBoxMi.Text = TextBoxMi.Text & Matriz(i, j) & vbTab
            Next
            TextBoxMi.Text = TextBoxMi.Text & vbCrLf
        Next

        For i = 0 To N - 1
            For j = 0 To N - 1
                dgvi.Rows(i).Cells(j).Value = Aleatorio(-10, 10)
            Next
        Next

    End Sub

    Function Aleatorio(LI As Integer, LS As Integer)
        Randomize()
        Aleatorio = Int(LI + Rnd() * (LS - LI + 1))
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 1 To N - 1
            For j = i + 1 To N
                If Vector(i) >= Vector(j) Then
                    aux = Vector(i)
                    Vector(i) = Vector(j)
                    Vector(j) = aux
                End If
            Next
        Next

        For i = 1 To N
            TextBoxVf.Text = TextBoxVf.Text & Vector(i) & vbCrLf
        Next

        TextBoxVf.Text = TextBoxVf.Text & vbCrLf & vbCrLf & vbCrLf

        For i = 1 To N - 1
            For j = i + 1 To N
                If Vector(i) <= Vector(j) Then
                    aux = Vector(i)
                    Vector(i) = Vector(j)
                    Vector(j) = aux
                End If
            Next
        Next

        For i = 1 To N
            TextBoxVf.Text = TextBoxVf.Text & Vector(i) & vbCrLf
        Next

        TextBoxVf.Text = TextBoxVf.Text & vbCrLf & vbCrLf & vbCrLf

        For i = 1 To N - 1
            For j = i + 1 To N
                If Vector(i) = Vector(j) Then
                    Cont = Cont + 1
                    posrepeat = i
                End If
            Next
        Next

        TextBoxVf.Text = TextBoxVf.Text & Vector(posrepeat)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i = 1 To N - 1
            For j = 1 To N
                For k = i + 1 To N
                    For r = j + 1 To N
                        If Matriz(i, j) <= Matriz(k, r) Then
                            aux = Matriz(i, j)
                            Matriz(i, j) = Matriz(k, r)
                            Matriz(k, r) = aux
                        End If
                    Next
                Next
            Next
        Next

        For i = 1 To N
            For j = 1 To N
                TextBoxMi.Text = TextBoxMi.Text & Matriz(i, j) & vbTab
            Next
            TextBoxMi.Text = TextBoxMi.Text & vbCrLf
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        For i = 0 To N - 2
            For j = 0 To N - 1
                For k = i + 1 To N - 1
                    For r = j + 1 To N - 1
                        If dgvi.Rows(i).Cells(j).Value <= dgvi.Rows(k).Cells(r).Value Then
                            aux = dgvi.Rows(i).Cells(j).Value
                            dgvi.Rows(i).Cells(j).Value = dgvi.Rows(k).Cells(r).Value
                            dgvi.Rows(k).Cells(r).Value = aux
                        End If
                    Next
                Next
            Next
        Next

    End Sub
End Class
