
Public Class Form1

    Dim winhttp As New WinHttp.WinHttpRequest

    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal ipClassName As String, ByVal IpWindowName As String) As Long
    Public Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal IParam As Long) As Long
    Public Const WM_DESTORY = &H2
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Object) As Integer
    Private Declare Function ReleaseCapture Lib "user32" () As Integer

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click

        winhttp.Open("POST", "https://nid.naver.com/nidlogin.login")
        winhttp.SetRequestHeader("Referer", "http://static.nid.naver.com/login.nhn?")
        winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        winhttp.Send("id=" & txtid.Text & "&pw=" & txtpw.Text & "&enctp=1")

        If InStr(winhttp.ResponseText, "새로운 기기") Then
            MsgBox("로그인을 보류중입니다." + vbCrLf + "회원님은 ""새로운기기로그인알림""기능을 사용하고계십니다." + vbCrLf + "새로운기기로그인알림을 해제하고 사용해주세요.", 48, "로그인 보류중")
        ElseIf InStr(winhttp.ResponseText, "회원님이 로그인을 허용하지 않은 지역입니다.") Then
            MsgBox("로그인을 보류중입니다." + vbCrLf + "회원님은 ""타지역 로그인 차단""기능을 사용하고계십니다." + vbCrLf + "현재 회원님이 로그인을 허용하지 않은 지역입니다.", 48, "로그인 보류중")
        ElseIf InStr(winhttp.ResponseText, "location.replace") Then
            main.Show()
            Me.Hide()
        Else
            flag.Text = "1"

            message.Show()
        End If ' 저작자: N.Gauss

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        End
    End Sub

    Private Sub Form1(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        If flag.Text = "0" Then
            Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
            ReleaseCapture()
            SendMessage(Me.Handle.ToInt32, &HA1S, 2, 0)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.Click
        txtid.Text = ""
    End Sub

    Private Sub txtpw_TextChanged(sender As Object, e As EventArgs) Handles txtpw.GotFocus
        txtpw.Text = ""
        txtpw.PasswordChar = "*"
    End Sub
End Class
