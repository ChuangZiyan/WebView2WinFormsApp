<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainWebView2 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Navigate_to_url_Button = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.url_TextBox = New System.Windows.Forms.TextBox()
        CType(Me.MainWebView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainWebView2
        '
        Me.MainWebView2.AllowExternalDrop = True
        Me.MainWebView2.CreationProperties = Nothing
        Me.MainWebView2.DefaultBackgroundColor = System.Drawing.Color.White
        Me.MainWebView2.Location = New System.Drawing.Point(12, 12)
        Me.MainWebView2.Name = "MainWebView2"
        Me.MainWebView2.Size = New System.Drawing.Size(877, 752)
        Me.MainWebView2.Source = New System.Uri("https://www.bing.com/", System.UriKind.Absolute)
        Me.MainWebView2.TabIndex = 0
        Me.MainWebView2.ZoomFactor = 1.0R
        '
        'Navigate_to_url_Button
        '
        Me.Navigate_to_url_Button.Location = New System.Drawing.Point(736, 770)
        Me.Navigate_to_url_Button.Name = "Navigate_to_url_Button"
        Me.Navigate_to_url_Button.Size = New System.Drawing.Size(153, 29)
        Me.Navigate_to_url_Button.TabIndex = 1
        Me.Navigate_to_url_Button.Text = "前往"
        Me.Navigate_to_url_Button.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(895, 770)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(529, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(895, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(529, 752)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'url_TextBox
        '
        Me.url_TextBox.Location = New System.Drawing.Point(12, 772)
        Me.url_TextBox.Name = "url_TextBox"
        Me.url_TextBox.Size = New System.Drawing.Size(718, 27)
        Me.url_TextBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1436, 811)
        Me.Controls.Add(Me.url_TextBox)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Navigate_to_url_Button)
        Me.Controls.Add(Me.MainWebView2)
        Me.Name = "Form1"
        Me.Text = "WebView2Form"
        CType(Me.MainWebView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainWebView2 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Navigate_to_url_Button As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents url_TextBox As TextBox
End Class
