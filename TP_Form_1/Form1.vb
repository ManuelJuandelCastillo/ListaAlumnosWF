Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(txt_nombre.Text) <> "" Then
            Dim nombre As String = txt_nombre.Text
            Dim nota1 As Integer = notaM.SelectedItem
            Dim nota2 As Integer = notaF.SelectedItem
            Dim nota3 As Integer = notaB.SelectedItem
            Dim nota4 As Integer = notaQ.SelectedItem
            Dim nota5 As Integer = notaD.SelectedItem

            Dim promedio As Integer = Math.Round((nota1 + nota2 + nota3 + nota4 + nota5) / 5)

            If promedio > 0 And promedio < 3 Then
                DataGridView1.Rows.Add(nombre, "a febrero")
            End If
            If promedio > 2 And promedio < 7 Then
                DataGridView1.Rows.Add(nombre, "a diciembre")
            End If
            If promedio > 6 And promedio < 12 Then
                DataGridView1.Rows.Add(nombre, "aprobado")
            End If
            If promedio = 12 Then
                DataGridView1.Rows.Add(nombre, "con honores")
            End If

            txt_nombre.Clear()
            txt_nombre.Select()
            notaM.SelectedIndex = 0
            notaF.SelectedIndex = 0
            notaB.SelectedIndex = 0
            notaQ.SelectedIndex = 0
            notaD.SelectedIndex = 0
        End If
    End Sub
End Class
