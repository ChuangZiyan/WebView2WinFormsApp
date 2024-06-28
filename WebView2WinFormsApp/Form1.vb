
Imports Microsoft.Web.WebView2.Core

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Form Load")
        url_TextBox.Text = "https://www.google.com.tw/"
    End Sub



    Private Sub Navigate_to_url_Button_Click(sender As Object, e As EventArgs) Handles Navigate_to_url_Button.Click

        MainWebView2.CoreWebView2.Navigate(url_TextBox.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jsScript As String = "alert('Hello, this is an alert!')"
        MainWebView2.CoreWebView2.ExecuteScriptAsync(jsScript)
    End Sub

End Class
