Imports System.Data
Public Class Form1
    Private expression As String = ""
    Private openParenthesisCount As Integer = 0

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles Button17.Click, Button16.Click, Button15.Click, Button14.Click
        Dim btn = CType(sender, Button)
        If TextBox1.Text <> "" AndAlso Not TextBox1.Text.EndsWith(" ") Then
            TextBox1.Text &= " " & btn.Text & " "
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        expression = TextBox1.Text.Replace("x", "*")

        Try
            Dim result As Double = Convert.ToDouble(New DataTable().Compute(expression, Nothing))
            TextBox1.Text = result.ToString()
        Catch ex As Exception
            TextBox1.Text = "Error"
        End Try
    End Sub

    Private Sub Buttontonton_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim secondForm As New Form2
        secondForm.Show()

    End Sub

    Private Sub Num_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button8.Click, Button12.Click, Button2.Click, Button7.Click, Button11.Click, Button3.Click, Button6.Click, Button10.Click, Button9.Click, Button5.Click
        Dim btn As Button = CType(sender, Button)
        TextBox1.Text &= btn.Text
    End Sub
    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If
    End Sub

    Private Sub ButtonCE_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        expression = ""
        openParenthesisCount = 0
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub ButtonParenthesis_Click(sender As Object, e As EventArgs) Handles Button19.Click, Button20.Click
        If TextBox1.Text = "" OrElse TextBox1.Text.EndsWith(" ") Then
            If TextBox1.Text <> "" AndAlso Char.IsDigit(TextBox1.Text.Last()) Then
                TextBox1.Text &= " * ("
            Else
                TextBox1.Text &= "("
            End If
            openParenthesisCount += 1
        ElseIf openParenthesisCount > 0 Then
            TextBox1.Text &= ")"
            openParenthesisCount -= 1
        End If
    End Sub

    Private Sub ButtonFactorial_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            Dim num As Integer = Integer.Parse(TextBox1.Text)

            If num < 0 Then
                TextBox1.Text = "Error"
            Else
                TextBox1.Text = Factorial(num).ToString()
            End If
        Catch ex As Exception
            TextBox1.Text = "Error"
        End Try
    End Sub


    Private Function Factorial(n As Integer) As Integer
        If n = 0 OrElse n = 1 Then
            Return 1
        Else
            Return n * Factorial(n - 1)
        End If
    End Function

    Private Sub ButtonInverse_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If TextBox1.Text <> "" Then
            Dim num As Double
            If Double.TryParse(TextBox1.Text, num) AndAlso num <> 0 Then
                TextBox1.Text = (1 / num).ToString()
            Else
                TextBox1.Text = "Error"
            End If
        End If
    End Sub

    Private Sub ButtonPi_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox1.Text <> "" AndAlso Not TextBox1.Text.EndsWith(" ") Then
            TextBox1.Text &= " * " & Math.PI.ToString()
        Else
            TextBox1.Text &= Math.PI.ToString()
        End If
    End Sub


End Class
