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
        Button2 = New Button()
        RichTextBox1 = New RichTextBox()
        url_TextBox = New TextBox()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Navigate_to_url_Button
        ' 
        Navigate_to_url_Button.Location = New Point(736, 770)
        Navigate_to_url_Button.Name = "Navigate_to_url_Button"
        Navigate_to_url_Button.Size = New Size(153, 29)
        Navigate_to_url_Button.TabIndex = 1
        Navigate_to_url_Button.Text = "前往"
        Navigate_to_url_Button.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(895, 770)
        Button2.Name = "Button2"
        Button2.Size = New Size(529, 29)
        Button2.TabIndex = 2
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(895, 12)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(529, 752)
        RichTextBox1.TabIndex = 3
        RichTextBox1.Text = ""
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 19.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1436, 811)
        Controls.Add(WebView21)
        Controls.Add(url_TextBox)
        Controls.Add(RichTextBox1)
        Controls.Add(Button2)
        Controls.Add(Navigate_to_url_Button)
        Name = "Form1"
        Text = "WebView2Form"
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Navigate_to_url_Button As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents url_TextBox As TextBox
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2

End Class
