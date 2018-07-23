Public Class setting
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal ipClassName As String, ByVal IpWindowName As String) As Long
    Public Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal IParam As Long) As Long
    Public Const WM_DESTORY = &H2
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Object) As Integer
    Private Declare Function ReleaseCapture Lib "user32" () As Integer

    Private Sub setting_move(sender As Object, e As EventArgs) Handles MyBase.MouseMove

        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        ReleaseCapture()
        SendMessage(Me.Handle.ToInt32, &HA1S, 2, 0)

    End Sub

    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = main.RadioButton1.Checked
        RadioButton2.Checked = main.RadioButton2.Checked
        RadioButton3.Checked = main.RadioButton3.Checked
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        main.RadioButton1.Checked = RadioButton1.Checked
        main.RadioButton2.Checked = RadioButton2.Checked
        main.RadioButton3.Checked = RadioButton3.Checked
        main.flag.Text = 0

        Me.Close()

    End Sub
End Class