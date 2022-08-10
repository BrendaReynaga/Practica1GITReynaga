Public Class Form2
    Private Sub BtnUn_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        End
    End Sub

    Private Sub BtnDos_Click(sender As Object, e As EventArgs) Handles BtnUn.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Show()
    End Sub
End Class
