Public Class message
    Dim tempcolor As Color
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal ipClassName As String, ByVal IpWindowName As String) As Long
    Public Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal IParam As Long) As Long
    Public Const WM_DESTORY = &H2
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Object) As Integer
    Private Declare Function ReleaseCapture Lib "user32" () As Integer

    Private Sub message_Load(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        ReleaseCapture()
        SendMessage(Me.Handle.ToInt32, &HA1S, 2, 0)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form1.flag.Text = "0"
        Me.Close()

    End Sub

    Private Sub message_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class