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
        Me.Navigate_to_url_Button = New System.Windows.Forms.Button()
        Me.Send_Comment_Button = New System.Windows.Forms.Button()
        Me.Comment_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.url_TextBox = New System.Windows.Forms.TextBox()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Navigate_to_url_Button
        '
        Me.Navigate_to_url_Button.Location = New System.Drawing.Point(736, 770)
        Me.Navigate_to_url_Button.Name = "Navigate_to_url_Button"
        Me.Navigate_to_url_Button.Size = New System.Drawing.Size(153, 29)
        Me.Navigate_to_url_Button.TabIndex = 1
        Me.Navigate_to_url_Button.Text = "前往網址"
        Me.Navigate_to_url_Button.UseVisualStyleBackColor = True
        '
        'Send_Comment_Button
        '
        Me.Send_Comment_Button.Location = New System.Drawing.Point(895, 770)
        Me.Send_Comment_Button.Name = "Send_Comment_Button"
        Me.Send_Comment_Button.Size = New System.Drawing.Size(529, 29)
        Me.Send_Comment_Button.TabIndex = 2
        Me.Send_Comment_Button.Text = "送出留言"
        Me.Send_Comment_Button.UseVisualStyleBackColor = True
        '
        'Comment_RichTextBox
        '
        Me.Comment_RichTextBox.Location = New System.Drawing.Point(895, 12)
        Me.Comment_RichTextBox.Name = "Comment_RichTextBox"
        Me.Comment_RichTextBox.Size = New System.Drawing.Size(529, 752)
        Me.Comment_RichTextBox.TabIndex = 3
        Me.Comment_RichTextBox.Text = ""
        '
        'url_TextBox
        '
        Me.url_TextBox.Location = New System.Drawing.Point(12, 772)
        Me.url_TextBox.Name = "url_TextBox"
        Me.url_TextBox.Size = New System.Drawing.Size(718, 27)
        Me.url_TextBox.TabIndex = 4
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.WebView21.Location = New System.Drawing.Point(12, 12)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(877, 752)
        Me.WebView21.TabIndex = 5
        Me.WebView21.ZoomFactor = 1.0R
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1436, 811)
        Me.Controls.Add(Me.WebView21)
        Me.Controls.Add(Me.url_TextBox)
        Me.Controls.Add(Me.Comment_RichTextBox)
        Me.Controls.Add(Me.Send_Comment_Button)
        Me.Controls.Add(Me.Navigate_to_url_Button)
        Me.Name = "Form1"
        Me.Text = "WebView2Form - Loading"
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Navigate_to_url_Button As Button
    Friend WithEvents Send_Comment_Button As Button
    Friend WithEvents Comment_RichTextBox As RichTextBox
    Friend WithEvents url_TextBox As TextBox
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2

End Class
