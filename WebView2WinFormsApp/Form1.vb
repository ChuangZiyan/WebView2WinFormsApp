
Imports System.Reflection.Metadata
Imports Microsoft.Web.WebView2.Core
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Edge
Imports OpenQA.Selenium.Interactions
Imports WebDriverManager
Imports WebDriverManager.DriverConfigs.Impl
Imports WebDriverManager.Helpers

Public Class Form1

    Public edgeDriver As IWebDriver
    Private debugPort As Integer = 9333 ' 這是我們將要使用的調試埠
    Private environment As CoreWebView2Environment

    Private Async Function InitializeWebView2() As Task
        environment = Await CoreWebView2Environment.CreateAsync(Nothing, Nothing, New CoreWebView2EnvironmentOptions("--remote-debugging-port=" & debugPort))
        Await WebView21.EnsureCoreWebView2Async(environment)
    End Function


    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Form1 Load")
        url_TextBox.Text = "https://www.facebook.com/"
        Await InitializeWebView2()
        'WebView21.Source = New Uri("https://google.com.tw/")
        'WebView21.Source = New Uri("https://www.facebook.com/groups/8217730601630579/posts/9747843095285981/")
        Dim driverManager = New DriverManager()
        driverManager.SetUpDriver(New EdgeConfig(), VersionResolveStrategy.MatchingBrowser) 'automatically download a chromedriver.exe matching the version of the browser
        'driverManager.SetUpDriver(New EdgeConfig())

        ' show webview2 edge verion
        'Dim environment As CoreWebView2Environment = CoreWebView2Environment.CreateAsync().Result
        'Dim edgeVersion As String = environment.BrowserVersionString
        'Debug.WriteLine("WebView2 Microsoft Edge verion： " & edgeVersion)

        'Exit Sub

        Dim options As EdgeOptions = New EdgeOptions()
        options.AddArguments("--disable-dev-shm-usage", "--no-sandbox")
        options.DebuggerAddress = "localhost:" & debugPort

        Dim serv As EdgeDriverService = EdgeDriverService.CreateDefaultService
        serv.HideCommandPromptWindow = True 'hide cmd

        Threading.Thread.Sleep(500)
        edgeDriver = New EdgeDriver(serv, options)

        Me.Text = "WebView2Form - Ready"
    End Sub

    Private Async Sub Navigate_to_url_Button_Click(sender As Object, e As EventArgs) Handles Navigate_to_url_Button.Click
        Await Navigate_GoToUrl_Task(url_TextBox.Text)
    End Sub

    Private Function isAlertPresent()
        Try
            Dim alert As IAlert = edgeDriver.SwitchTo().Alert()
            alert.Accept()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Async Sub Send_Comment_Button_Click(sender As Object, e As EventArgs) Handles Send_Comment_Button.Click
        Debug.WriteLine("Send comment bnt click")
        Dim mytext As String = Comment_RichTextBox.Text
        Clipboard.SetText(mytext)
        Await Send_Comment_Task(mytext)
    End Sub



    Public Function Navigate_GoToUrl_Task(url) As Task(Of Boolean)
        Return Task.Run(Function() Navigate_GoToUrl(url))
    End Function

    Public Function Navigate_GoToUrl(url As String) As Boolean
        Try
            edgeDriver.Navigate.GoToUrl(url)
            Threading.Thread.Sleep(300)
            If isAlertPresent() Then
                Debug.WriteLine("Alert Present")
            End If
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex)
            Return False
        End Try

    End Function


    Public Function Send_Comment_Task(comment_text) As Task(Of Boolean)
        Return Task.Run(Function() Send_Comment(comment_text))
    End Function

    Private Function Send_Comment(comment_text As String) As Boolean
        Try

            Dim comment_eles = edgeDriver.FindElements(By.CssSelector("div[aria-label='留言']"))
            comment_eles(comment_eles.Count - 1).Click()
            Threading.Thread.Sleep(1000)
            Dim actions As New Actions(edgeDriver)
            'actions.SendKeys(Keys.LeftControl + "V").Perform()
            'actions.KeyDown(Keys.LeftControl).SendKeys("V").Perform()
            actions.KeyDown(Keys.LeftControl)
            Threading.Thread.Sleep(100)
            actions.SendKeys("v")
            Threading.Thread.Sleep(100)
            actions.KeyUp(Keys.LeftControl)
            Threading.Thread.Sleep(100)
            actions.Perform()
            Threading.Thread.Sleep(1000)
            Dim send_comment_btn = edgeDriver.FindElement(By.CssSelector("#focused-state-composer-submit > span > div"))
            send_comment_btn.Click()
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex)
            Return False
        End Try

    End Function

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        edgeDriver.Quit()
    End Sub

End Class
