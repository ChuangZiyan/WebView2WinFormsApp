
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Edge
Imports OpenQA.Selenium.Remote
Imports Selenium
Imports WebDriverManager
Imports WebDriverManager.DriverConfigs.Impl
Imports WebDriverManager.Helpers

Public Class Form1

    'Public edgeDriver As IWebDriver

    Private debugPort As Integer = 9222 ' 這是我們將要使用的調試埠
    Private environment As CoreWebView2Environment

    Private Async Function InitializeWebView2() As Task
        environment = Await CoreWebView2Environment.CreateAsync(Nothing, Nothing, New CoreWebView2EnvironmentOptions("--remote-debugging-port=" & debugPort))
        Await WebView21.EnsureCoreWebView2Async(environment)

    End Function


    Private Async Sub Form1_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Form Load")
        url_TextBox.Text = "https://www.google.com.tw/"
        Await InitializeWebView2()

        Dim driverManager = New DriverManager()
        'driverManager.SetUpDriver(New EdgeConfig(), VersionResolveStrategy.MatchingBrowser) 'automatically download a chromedriver.exe matching the version of the browser
        driverManager.SetUpDriver(New EdgeConfig())


        Dim options As EdgeOptions = New EdgeOptions()
        options.DebuggerAddress = "localhost:9222"


        Dim environment As CoreWebView2Environment = CoreWebView2Environment.CreateAsync().Result
        Dim edgeVersion As String = environment.BrowserVersionString

        ' 輸出版本信息
        Debug.WriteLine("WebView2 使用的 Microsoft Edge 版本： " & edgeVersion)

        ' 創建RemoteWebDriver並指定選項
        Dim driver As IWebDriver = New RemoteWebDriver(options)
        ' 打開網頁
        driver.Navigate().GoToUrl("http://www.example.com")

        driver.Quit()


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jsScript As String = "alert('Hello, this is an alert!')"
        'MainWebView2.CoreWebView2.ExecuteScriptAsync(jsScript)

        'edgeDriver.Navigate.GoToUrl("https://google.com.tw/")
    End Sub


    Private Sub Navigate_to_url_Button_Click(sender As Object, e As EventArgs) Handles Navigate_to_url_Button.Click



        'edgeDriver.Navigate.GoToUrl("https://www.google.com/")

    End Sub
End Class
