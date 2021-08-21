Public Class Form1
    Dim no1 As Decimal
    Dim no2 As Decimal
    Dim op As Integer = 0 '8=add, 1=subtract, 2=multiply, 3=division, 4=square root, 5=square, 6=cube 7=cube root
    Dim result As Decimal
    Dim op_pressed As Boolean = False
    Dim just_pressed As Boolean = False
    Dim subString As String
    Dim mem As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles negate.Click
        If TextBox1.Text <> "0" Then
            If Not TextBox1.Text.Contains("-") Then
                TextBox1.Text = "-" + TextBox1.Text
            Else
                TextBox1.Text = Mid(TextBox1.Text, 2)
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub one_Click(sender As Object, e As EventArgs) Handles one.Click
        If just_pressed = False Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text = TextBox1.Text + "1"
            ElseIf TextBox1.Text = "0" Then
                TextBox1.Text = "1"
            End If
        Else
            TextBox1.Text = "1"
            just_pressed = False
        End If
    End Sub

    Private Sub two_Click(sender As Object, e As EventArgs) Handles two.Click
        If just_pressed = False Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text = TextBox1.Text + "2"
            ElseIf TextBox1.Text = "0" Then
                TextBox1.Text = "2"
            End If
        Else
            TextBox1.Text = "2"
            just_pressed = False
        End If
    End Sub

    Private Sub three_Click(sender As Object, e As EventArgs) Handles three.Click
        If just_pressed = False Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text = TextBox1.Text + "3"
            ElseIf TextBox1.Text = "0" Then
                TextBox1.Text = "3"
            End If
        Else
            TextBox1.Text = "3"
            just_pressed = False
        End If
    End Sub

    Private Sub four_Click(sender As Object, e As EventArgs) Handles four.Click
        If just_pressed = False Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text = TextBox1.Text + "4"
            ElseIf TextBox1.Text = "0" Then
                TextBox1.Text = "4"
            End If
        Else
            TextBox1.Text = "4"
            just_pressed = False
        End If
    End Sub

    Private Sub five_Click(sender As Object, e As EventArgs) Handles five.Click
        If just_pressed = False Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text = TextBox1.Text + "5"
            ElseIf TextBox1.Text = "0" Then
                TextBox1.Text = "5"
            End If
        Else
            TextBox1.Text = "5"
            just_pressed = False
        End If
    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click
        If just_pressed = False Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text = TextBox1.Text + "6"
            ElseIf TextBox1.Text = "0" Then
                TextBox1.Text = "6"
            End If
        Else
            TextBox1.Text = "6"
            just_pressed = False
        End If
    End Sub

    Private Sub seven_Click(sender As Object, e As EventArgs) Handles seven.Click
        If just_pressed = False Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text = TextBox1.Text + "7"
            ElseIf TextBox1.Text = "0" Then
                TextBox1.Text = "7"
            End If
        Else
            TextBox1.Text = "7"
            just_pressed = False
        End If
    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click
        If just_pressed = False Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text = TextBox1.Text + "8"
            ElseIf TextBox1.Text = "0" Then
                TextBox1.Text = "8"
            End If
        Else
            TextBox1.Text = "8"
            just_pressed = False
        End If
    End Sub

    Private Sub nine_Click(sender As Object, e As EventArgs) Handles nine.Click
        If just_pressed = False Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text = TextBox1.Text + "9"
            ElseIf TextBox1.Text = "0" Then
                TextBox1.Text = "9"
            End If
        Else
            TextBox1.Text = "9"
            just_pressed = False
        End If
    End Sub

    Private Sub multiply_Click(sender As Object, e As EventArgs) Handles multiply.Click
        just_pressed = True
        If op_pressed = False Then
            op_pressed = True
            no1 = Val(TextBox1.Text)
        Else
            TextBox1.Text = calculate(no1, Val(TextBox1.Text), op)
            no1 = Val(TextBox1.Text)
        End If
        op = 2
    End Sub

    Private Sub inverse_Click(sender As Object, e As EventArgs) Handles inverse.Click
        TextBox1.Text = 1 / TextBox1.Text
    End Sub

    Private Sub square_Click(sender As Object, e As EventArgs) Handles square.Click
        TextBox1.Text = TextBox1.Text * TextBox1.Text
    End Sub


    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        just_pressed = True
        If op_pressed = False Then
            op_pressed = True
            no1 = Val(TextBox1.Text)
        Else
            TextBox1.Text = calculate(no1, Val(TextBox1.Text), op)
            no1 = Val(TextBox1.Text)
        End If
        op = 3
    End Sub

    Private Sub square_root_Click(sender As Object, e As EventArgs) Handles square_root.Click
        TextBox1.Text = Math.Sqrt(Val(TextBox1.Text))

    End Sub

    Private Sub decimal_point_Click(sender As Object, e As EventArgs) Handles decimal_point.Click
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.Text = TextBox1.Text + "."
        End If
    End Sub

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
        If just_pressed = False Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text = TextBox1.Text + "0"
            End If
        Else
            TextBox1.Text = "0"
            'just_pressed = False
        End If
    End Sub

    Private Sub btn_backspace_Click(sender As Object, e As EventArgs) Handles btn_backspace.Click
        If TextBox1.Text.Length = 1 Then
            TextBox1.Text = "0"
        ElseIf TextBox1.Text.Length = 2 And TextBox1.Text.Contains("-") Then
            TextBox1.Text = "0"
        ElseIf TextBox1.Text <> "0" Then
            TextBox1.Text = Microsoft.VisualBasic.Strings.Left(TextBox1.Text, TextBox1.Text.Length - 1)
        End If
    End Sub

    Private Sub ce_Click(sender As Object, e As EventArgs) Handles ce.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        just_pressed = True
        If op_pressed = False Then
            op_pressed = True
            no1 = Val(TextBox1.Text)
            'TextBox1.Text = "0"
        Else
            TextBox1.Text = calculate(no1, Val(TextBox1.Text), op)
            no1 = Val(TextBox1.Text)
        End If
        op = 8
    End Sub

    Private Sub equal_to_sign_Click(sender As Object, e As EventArgs) Handles equal_to_sign.Click
        no2 = Val(TextBox1.Text)
        TextBox1.Text = calculate(no1, no2, op)
    End Sub
    Private Function calculate(digi1, digi2, oper) As Decimal
        If oper = 8 Then
            calculate = Val(digi1) + Val(digi2)
        ElseIf oper = 1 Then
            calculate = Val(digi1) - Val(digi2)
        ElseIf oper = 2 Then
            calculate = Val(digi1) * Val(digi2)
        ElseIf oper = 3 Then
            calculate = Val(digi1) / Val(digi2)

        End If
    End Function

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        just_pressed = True
        If op_pressed = False Then
            op_pressed = True
            no1 = Val(TextBox1.Text)
        Else
            TextBox1.Text = calculate(no1, Val(TextBox1.Text), op)
            no1 = Val(TextBox1.Text)
        End If
        op = 1
    End Sub

    Private Sub c_Click(sender As Object, e As EventArgs) Handles c.Click
        just_pressed = False
        op = 0
        no1 = 0
        no2 = 0
        TextBox1.Text = "0"
        op_pressed = False
    End Sub

    Private Sub cube_root_Click(sender As Object, e As EventArgs) Handles cube_root.Click
        TextBox1.Text = Math.Cbrt(Val(TextBox1.Text))
    End Sub

    Private Sub cube_Click(sender As Object, e As EventArgs) Handles cube.Click
        TextBox1.Text = TextBox1.Text * TextBox1.Text * TextBox1.Text
    End Sub

    Private Sub memory_store_Click(sender As Object, e As EventArgs) Handles memory_store.Click
        mem = TextBox1.Text
    End Sub

    Private Sub memory_recall_Click(sender As Object, e As EventArgs) Handles memory_recall.Click
        If Not mem = 0 Then
            TextBox1.Text = mem
        End If
    End Sub

    Private Sub memory_clear_Click(sender As Object, e As EventArgs) Handles memory_clear.Click
        mem = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mem = mem + TextBox1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mem = mem - TextBox1.Text
    End Sub
End Class
