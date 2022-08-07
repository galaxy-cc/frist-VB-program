Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lalName.Click

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Display a message box greeting to the user
        MessageBox.Show("你好，" & txtName.Text &
                        "! 欢迎使用Visual Basic 2015.",
                        "Hello User Message")
    End Sub

    Private Sub bntExit_Click(sender As Object, e As EventArgs) Handles bntExit.Click
        'End the program and close the form
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
