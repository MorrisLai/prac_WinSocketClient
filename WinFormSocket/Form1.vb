Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Threading


Public Class Form1
    Dim myTcpClient As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myTcpClient = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Button1.Enabled = True

        Dim myIPEndPoint As New IPEndPoint(IPAddress.Any, 0)
        Dim iPort As Integer
        iPort = txtPort.Text

        Dim ServerIpAddress As IPAddress
        Try
            ServerIpAddress = IPAddress.Parse(txtIP.Text)
        Catch ex As Exception
            MessageBox.Show("ServerIP 設定錯誤")
            Exit Sub
        End Try

        Dim RemoteIPEndPoint As New IPEndPoint(ServerIpAddress, iPort)
        Try
            myTcpClient.Connect(RemoteIPEndPoint)
            lbStatus.Text = "已連線"
        Catch ex As Exception
            MessageBox.Show("無法連線")
        End Try
    End Sub
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Try
            myTcpClient.Shutdown(SocketShutdown.Both)
            myTcpClient.Disconnect(False)
            myTcpClient.Dispose()
            myTcpClient = Nothing
            lbStatus.Text = "未連線"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim myBytes As Byte()
        myBytes = Encoding.GetEncoding(950).GetBytes(Trim(TextBox1.Text).TrimEnd())
        Try
            myTcpClient.Send(myBytes, myBytes.Length, 0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
