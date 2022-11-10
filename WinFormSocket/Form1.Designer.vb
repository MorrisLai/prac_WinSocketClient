<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Status："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IP："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Port："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(132, 45)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(37, 12)
        Me.lbStatus.TabIndex = 4
        Me.lbStatus.Text = "Label4"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(120, 80)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(153, 22)
        Me.txtIP.TabIndex = 5
        Me.txtIP.Text = "127.0.0.1"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(120, 112)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(153, 22)
        Me.txtPort.TabIndex = 6
        Me.txtPort.Text = "8888"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(64, 211)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(90, 35)
        Me.btnStop.TabIndex = 7
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(64, 261)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(90, 35)
        Me.btnSend.TabIndex = 8
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(195, 160)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(366, 135)
        Me.TextBox1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 386)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbStatus As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnStop As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents TextBox1 As TextBox
End Class
