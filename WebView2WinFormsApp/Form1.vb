
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
Imports thread

Public Class Form1

    Public edgeDriver As IWebDriver

    Private debugPort As Integer = 9333 ' 這是我們將要使用的調試埠
    Private environment As CoreWebView2Environment

    Private Async Function InitializeWebView2() As Task
        environment = Await CoreWebView2Environment.CreateAsync(Nothing, Nothing, New CoreWebView2EnvironmentOptions("--remote-debugging-port=" & debugPort))
        Await WebView21.EnsureCoreWebView2Async(environment)


    End Function


    Private Async Sub Form1_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Form Load")
        url_TextBox.Text = "https://www.google.com.tw/"
        Await InitializeWebView2()

        WebView21.Source = New Uri("edge://flags")

        Dim driverManager = New DriverManager()
        driverManager.SetUpDriver(New EdgeConfig(), VersionResolveStrategy.MatchingBrowser) 'automatically download a chromedriver.exe matching the version of the browser
        'driverManager.SetUpDriver(New EdgeConfig())


        Dim environment As CoreWebView2Environment = CoreWebView2Environment.CreateAsync().Result
        Dim edgeVersion As String = environment.BrowserVersionString

        ' 輸出版本信息
        Debug.WriteLine("WebView2 使用的 Microsoft Edge 版本： " & edgeVersion)



        'Exit Sub



        Dim options As EdgeOptions = New EdgeOptions()
        options.AddArguments("--disable-dev-shm-usage", "--no-sandbox")
        options.DebuggerAddress = "localhost:" & debugPort

        Threading.Thread.Sleep(3000)

        'Dim environment As CoreWebView2Environment = CoreWebView2Environment.CreateAsync().Result
        'Dim edgeVersion As String = environment.BrowserVersionString

        ' 輸出版本信息
        'Debug.WriteLine("WebView2 使用的 Microsoft Edge 版本： " & edgeVersion)

        ' 創建RemoteWebDriver並指定選項
        edgeDriver = New EdgeDriver(options)
        ' 打開網頁
        'driver.Navigate().GoToUrl("http://www.example.com")

        'driver.Quit()

    End Sub



    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jsScript As String = "alert('Hello, this is an alert!')"
        'MainWebView2.CoreWebView2.ExecuteScriptAsync(jsScript)

        Await edgeDriver.Navigate.GoToUrlAsync("https://www.facebook.com/")
    End Sub


    Private Async Sub Navigate_to_url_Button_Click(sender As Object, e As EventArgs) Handles Navigate_to_url_Button.Click


        Await mytest_task("https://www.google.com/")

    End Sub


    Public Function mytest_task(url As String)
        Return Task.Run(Function() mytest(url))
    End Function

    Private Function mytest(url)
        'edgeDriver.Navigate.GoToUrl("https://www.facebook.com/")
        Dim myinput = edgeDriver.FindElement(By.CssSelector("[aria-label='留言……']"))
        myinput.SendKeys("my test text")
        Return True
    End Function

End Class
