'Name
'Details
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim f As Integer 'Declaring first integer number as f
        Dim s As Integer 'Declaring second integer number as s
        Dim t As Integer 'Declaring third  integer number as t
        Dim lar As Integer 'Declaring largest number as lar
        Dim sma As Integer 'Declaring smallest number as sma
        f = Val(txtF.Text) 'Assigning integer value to text box
        s = Val(txtS.Text) 'Assigning integer value to text box
        t = Val(txtT.Text) 'Assigning integer value to text box
        If f > s Then 'Comparing the largest integer between f and s
            lar = f 'Output for largest value between f and s
        Else
            lar = s
        End If
        If lar < t Then
            lar = t
        End If
        If f < s Then 'Comparing the smallest integer between f and s
            sma = f 'Output for smallest value between f and s
        Else
            sma = s
        End If
        If sma > t Then 'Comparing the smallest integer between sma and t
            sma = t 'Output for smallest value between sma and t
        End If
        lblLA.Text = lar 'Declaring output label for largest number
        lblSm.Text = sma 'Declaring output label for smallest number
    End Sub

    Private Sub txtF_TextChanged(sender As Object, e As EventArgs) Handles txtF.TextChanged

    End Sub
End Class
