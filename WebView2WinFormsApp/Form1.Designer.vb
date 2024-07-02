Imports Microsoft.Web.WebView2.Core

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
        Navigate_to_url_Button = New Button()
        Send_Comment_Button = New Button()
        Comment_RichTextBox = New RichTextBox()
        url_TextBox = New TextBox()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Button1 = New Button()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Navigate_to_url_Button
        ' 
        Navigate_to_url_Button.Location = New Point(736, 770)
        Navigate_to_url_Button.Name = "Navigate_to_url_Button"
        Navigate_to_url_Button.Size = New Size(153, 29)
        Navigate_to_url_Button.TabIndex = 1
        Navigate_to_url_Button.Text = "前往網址"
        Navigate_to_url_Button.UseVisualStyleBackColor = True
        ' 
        ' Send_Comment_Button
        ' 
        Send_Comment_Button.Location = New Point(895, 770)
        Send_Comment_Button.Name = "Send_Comment_Button"
        Send_Comment_Button.Size = New Size(529, 29)
        Send_Comment_Button.TabIndex = 2
        Send_Comment_Button.Text = "送出留言"
        Send_Comment_Button.UseVisualStyleBackColor = True
        ' 
        ' Comment_RichTextBox
        ' 
        Comment_RichTextBox.Location = New Point(895, 12)
        Comment_RichTextBox.Name = "Comment_RichTextBox"
        Comment_RichTextBox.Size = New Size(529, 597)
        Comment_RichTextBox.TabIndex = 3
        Comment_RichTextBox.Text = ""
        ' 
        ' url_TextBox
        ' 
        url_TextBox.Location = New Point(12, 772)
        url_TextBox.Name = "url_TextBox"
        url_TextBox.Size = New Size(718, 27)
        url_TextBox.TabIndex = 4
        ' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.WhiteSmoke
        WebView21.Location = New Point(12, 12)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(877, 752)
        WebView21.TabIndex = 5
        WebView21.ZoomFactor = 1.0R
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(915, 663)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 19.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1436, 811)
        Controls.Add(Button1)
        Controls.Add(WebView21)
        Controls.Add(url_TextBox)
        Controls.Add(Comment_RichTextBox)
        Controls.Add(Send_Comment_Button)
        Controls.Add(Navigate_to_url_Button)
        Name = "Form1"
        Text = "WebView2Form - Loading"
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Navigate_to_url_Button As Button
    Friend WithEvents Send_Comment_Button As Button
    Friend WithEvents Comment_RichTextBox As RichTextBox
    Friend WithEvents url_TextBox As TextBox
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Button1 As Button
End Class
