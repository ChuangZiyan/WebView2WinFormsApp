Imports System.IO
Imports System.IO.Pipes

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Form Load")
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pipeName As String = "MyNamedPipe"
        Using pipeClient As New NamedPipeClientStream(".", pipeName, PipeDirection.In)
            Debug.WriteLine("tring to connect pipe...")
            pipeClient.Connect()
            Debug.WriteLine("connected to pipe ...")

            Dim reader As New StreamReader(pipeClient)
            Dim message As String = reader.ReadLine()

            Debug.WriteLine("received : " & message)
            'MainWebView2.CoreWebView2.Navigate("https://baidu.com/")

        End Using
    End Sub



End Class
