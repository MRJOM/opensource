Public Class main

    Dim winhttp As New WinHttp.WinHttpRequest


    Dim type(5) As String
    Dim title(5) As String
    Dim titleTemp(5) As String

    Dim replyid(5) As String
    Dim bynickname(5) As String
    Dim read(5) As Boolean
    Dim countbyrea(5) As Integer
    Dim temCount(5) As Integer

    Dim ReplyLink(5) As String
    Dim createTime(5) As String
    Dim messagetimekey(5) As String
    Dim tempz(5) As Integer

    Dim DoubleColon As String = Chr(34)
    Dim tempcolor As Color
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal ipClassName As String, ByVal IpWindowName As String) As Long
    Public Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal IParam As Long) As Long
    Public Const WM_DESTORY = &H2
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Object) As Integer
    Private Declare Function ReleaseCapture Lib "user32" () As Integer

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tray.MouseDoubleClick
        Me.Show()
    End Sub



    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        winhttp.Open("POST", "https://nid.naver.com/nidlogin.login")
        winhttp.SetRequestHeader("Referer", "http://static.nid.naver.com/login.nhn?")
        winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        winhttp.Send("id=" & Form1.txtid.Text & "&pw=" & Form1.txtpw.Text & "&enctp=1")

        getToday()
        getReply()
        tempcolor = PictureBox1.BackColor

        Timer1.Interval = 1000
        Timer1.Enabled = True

    End Sub

    Private Sub main_move(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        If flag.Text = "0" Then
            Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
            ReleaseCapture()
            SendMessage(Me.Handle.ToInt32, &HA1S, 2, 0)
        End If

    End Sub

    Private Sub main_mousemove(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        PictureBox1.BackColor = tempcolor
        PictureBox2.BackColor = tempcolor
        PictureBox3.BackColor = tempcolor
    End Sub

    Private Sub getToday()
        '방문수 
        winhttp.Open("GET", "http://section.blog.naver.com/")
        winhttp.Send()

        count.Text = Split(Split(winhttp.ResponseText, "오늘 방문수 <em>")(1), "</em>")(0)
    End Sub

    Private Sub getReply()

        Dim Temp As String
        Dim check As String

        winhttp.Open("GET", "http://section.blog.naver.com/main/MyBlogNewsListAsync.nhn?currentPage=1&lastMessageTimeKey=&pagingMode=next")
        winhttp.Send()
        Temp = Replace(winhttp.ResponseText, DoubleColon, "")

        For i = 1 To 5
            read(i) = True
        Next

        For i = 1 To UBound(Split(Temp, "read"))
            check = Split(Split(Temp, "title:")(i), ",")(0)
            If check = "" Then
                If Split(Split(Temp, "commcastCategoryType:")(i), ",")(0) = "BUDDY_PROPOSAL" Then
                    title(i) = "서로이웃추가 신청 받았습니다."
                    type(i) = "MSG"
                Else
                    title(i) = "서로이웃이 되었습니다"
                    type(i) = "MSG"
                End If
            Else
                title(i) = Split(Split(check + ",", "<\/strong> ")(1), ",")(0)
                type(i) = Split(Split(check, "<strong>")(1), "<\/strong>")(0)


                If Split(Split(Temp, "read:")(1), ",")(i) = "true" Then
                Else
                    read(i) = False
                End If

                countbyrea(i) = Val(Split(Split(Temp, "commentCount:")(i), ",")(0))
                createTime(i) = Split(Split(Temp, "createTimeLabel:")(i), ",")(0)
            End If
            bynickname(i) = Split(Split(Temp, "byNickName:")(i), ",")(0)
            ReplyLink(i) = Split(Split(Temp, "url:")(i), "}")(0)
            replyid(i) = Split(Split(Temp, "blogId:")(i), ",")(0)
            messagetimekey(i) = Split(Split(Temp, "messageTimeKey:")(i), ",")(0)
        Next i

        type1.Text = title(1)
        type2.Text = title(2)
        type3.Text = title(3)
        type4.Text = title(4)
        type5.Text = title(5)

        by1.Text = "작성자 : " + bynickname(1) + "(" + replyid(1) + ")" + " [" + CStr(countbyrea(1)) + "] " + createTime(1)
        by2.Text = "작성자 : " + bynickname(2) + "(" + replyid(2) + ")" + " [" + CStr(countbyrea(2)) + "] " + createTime(2)
        by3.Text = "작성자 : " + bynickname(3) + "(" + replyid(3) + ")" + " [" + CStr(countbyrea(3)) + "] " + createTime(3)
        by4.Text = "작성자 : " + bynickname(4) + "(" + replyid(4) + ")" + " [" + CStr(countbyrea(4)) + "] " + createTime(4)
        by5.Text = "작성자 : " + bynickname(5) + "(" + replyid(5) + ")" + " [" + CStr(countbyrea(5)) + "] " + createTime(5)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Enabled = False

        For i = 1 To 5
            temCount(i) = countbyrea(i)
            titleTemp(i) = title(i)
        Next

        getToday()
        getReply()

        If titleTemp(1) <> title(1) Or temCount(1) < countbyrea(1) Then
            tray.ShowBalloonTip(3000, "알림", "확인하지 않은 새로운 댓글이 있습니다.", 1)
            My.Computer.Audio.Play("sound.wav", AudioPlayMode.Background)
            If RadioButton1.Checked Then
                Shell("explorer " + Split(ReplyLink(1), "?")(0))
            End If
        End If

        Timer1.Enabled = True

    End Sub


    Private Sub type1_Click(sender As Object, e As EventArgs) Handles type1.Click
        Shell("explorer " + Split(ReplyLink(1), "?")(0))
    End Sub

    Private Sub type2_Click(sender As Object, e As EventArgs) Handles type2.Click
        Shell("explorer " + Split(ReplyLink(2), "?")(0))
    End Sub

    Private Sub type3_Click(sender As Object, e As EventArgs) Handles type3.Click
        Shell("explorer " + Split(ReplyLink(3), "?")(0))
    End Sub

    Private Sub type4_Click(sender As Object, e As EventArgs) Handles type4.Click
        Shell("explorer " + Split(ReplyLink(4), "?")(0))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub gotray_mousemove(sender As Object, e As EventArgs) Handles gotray.MouseMove
        PictureBox1.BackColor = Color.White
    End Sub

    Private Sub godeveloper_mousemove(sender As Object, e As EventArgs) Handles godeveloper.MouseMove
        PictureBox2.BackColor = Color.White
    End Sub

    Private Sub godesigner_mousemove(sender As Object, e As EventArgs) Handles godesigner.MouseMove
        PictureBox3.BackColor = Color.White
    End Sub

    Private Sub gotray_Click(sender As Object, e As EventArgs) Handles gotray.Click
        Me.Hide()
    End Sub

    Private Sub godeveloper_Click(sender As Object, e As EventArgs) Handles godeveloper.Click
        Shell("explorer http://blog.naver.com/daru_jally")
    End Sub

    Private Sub godesigner_Click(sender As Object, e As EventArgs) Handles godesigner.Click
        Shell("explorer http://creativesins_.blog.me/")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        setting.Show()
        flag.Text = 1

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        End
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Shell("explorer http://mail.naver.com/")
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        Shell("explorer http://note.naver.com/")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Shell("explorer http://blog.naver.com/daru_jally")
    End Sub
End Class
