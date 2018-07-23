<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.flag = New System.Windows.Forms.Label()
        CType(Me.login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtid
        '
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtid.Location = New System.Drawing.Point(22, 97)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(184, 14)
        Me.txtid.TabIndex = 0
        Me.txtid.Text = "네이버 아이디"
        '
        'txtpw
        '
        Me.txtpw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtpw.Location = New System.Drawing.Point(22, 138)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(184, 14)
        Me.txtpw.TabIndex = 2
        Me.txtpw.Text = "네이버 비밀번호"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "MADE BY DARU Blog : blog.naver.com/daru_jally"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(647, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "<span class=""c_gn"">"
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.White
        Me.login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login.Image = Global.알림이.My.Resources.Resources.로그인
        Me.login.Location = New System.Drawing.Point(221, 86)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(68, 77)
        Me.login.TabIndex = 10
        Me.login.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PictureBox5.Image = Global.알림이.My.Resources.Resources.x
        Me.PictureBox5.Location = New System.Drawing.Point(280, 10)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(6, 7)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 57
        Me.PictureBox5.TabStop = False
        '
        'flag
        '
        Me.flag.AutoSize = True
        Me.flag.Location = New System.Drawing.Point(86, 173)
        Me.flag.Name = "flag"
        Me.flag.Size = New System.Drawing.Size(11, 12)
        Me.flag.TabIndex = 61
        Me.flag.Text = "0"
        Me.flag.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = Global.알림이.My.Resources.Resources.로그인폼1
        Me.ClientSize = New System.Drawing.Size(300, 194)
        Me.Controls.Add(Me.flag)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.txtid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "블로그 댓글 알림이"
        Me.TransparencyKey = System.Drawing.Color.Gray
        CType(Me.login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtid As TextBox
    Friend WithEvents txtpw As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents login As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents flag As Label
End Class
