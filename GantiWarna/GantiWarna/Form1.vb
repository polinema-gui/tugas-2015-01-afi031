Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.BackColor = Color.Red
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If MyBase.BackColor = Color.Red Then
            MyBase.BackColor = Color.Blue
        Else
            MyBase.BackColor = Color.Red
        End If
    End Sub
End Class
