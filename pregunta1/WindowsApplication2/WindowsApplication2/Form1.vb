Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
       
        If a > b And a > c Then GoTo mayorA Else GoTo compara1
mayorA:
        TextBox4.Text = a.ToString() + " : Es el numero Mayor"
        GoTo salir
compara1:
        If b > a And b > c Then GoTo mayorB Else GoTo compara2
        GoTo salir
mayorB:
        TextBox4.Text = b.ToString() + " : Es el numero Mayor"
        GoTo salir
compara2:
        If c > a And c > b Then GoTo mayorC Else GoTo compara3
        GoTo salir
mayorC:
        TextBox4.Text = c.ToString() + " : Es el numero Mayor"
        GoTo salir
compara3:
        If a = b And a = c And c = b Then GoTo iguales Else GoTo compara4
        GoTo salir
iguales:
        TextBox4.Text = " los 3 numeros son iguales"
        GoTo salir
compara4:
        If a = b Then GoTo iguales2 Else GoTo compara5
        GoTo salir
iguales2:
        TextBox4.Text = " a y b son numeros mayores/iguales"
        GoTo salir
compara5:
        If a = c Then GoTo iguales3 Else GoTo compara6
        GoTo salir
iguales3:
        TextBox4.Text = " a y c son numeros mayores/iguales"
        GoTo salir
compara6:
        If b = c Then GoTo iguales4 Else GoTo salir
        GoTo salir
iguales4:
        TextBox4.Text = " b y c son numeros mayores/iguales"
        GoTo salir
salir:
    End Sub
End Class
