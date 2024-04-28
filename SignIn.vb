Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class SignIn
    Dim firebase As New FireBaseApp()
    Public isAdministrator As Boolean = False
    Private Sub HideButton_Click_1(sender As Object, e As EventArgs) Handles HideButton.Click
        password_txt.UseSystemPasswordChar = Not password_txt.UseSystemPasswordChar
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles password_txt.TextChanged
        If password_txt.Text = "" Then
            HideButton.Visible = False
        Else
            HideButton.Visible = True
        End If
    End Sub
    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideButton.Visible = False
    End Sub

    Private Sub Sign_In_Click(sender As Object, e As EventArgs) Handles Sign_In.Click

    End Sub
    Private Sub username_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username_txt.KeyPress
        If username_txt.Text = "Username" Then
            username_txt.Text = ""
        End If
    End Sub
    Private Sub password_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password_txt.KeyPress
        If password_txt.Text = "Password" Then
            password_txt.Text = ""
        End If
    End Sub
End Class