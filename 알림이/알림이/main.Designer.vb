<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.by5 = New System.Windows.Forms.Label()
        Me.type5 = New System.Windows.Forms.Label()
        Me.tray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.type1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.type2 = New System.Windows.Forms.Label()
        Me.type3 = New System.Windows.Forms.Label()
        Me.type4 = New System.Windows.Forms.Label()
        Me.by1 = New System.Windows.Forms.Label()
        Me.by2 = New System.Windows.Forms.Label()
        Me.by3 = New System.Windows.Forms.Label()
        Me.by4 = New System.Windows.Forms.Label()
        Me.count = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.gotray = New System.Windows.Forms.PictureBox()
        Me.godeveloper = New System.Windows.Forms.PictureBox()
        Me.godesigner = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.flag = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gotray, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.godeveloper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.godesigner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.by5)
        Me.GroupBox1.Controls.Add(Me.type5)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(763, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 260)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "목록"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 12)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "댓글을 클릭하면 이동합니다"
        '
        'by5
        '
        Me.by5.Location = New System.Drawing.Point(6, 221)
        Me.by5.Name = "by5"
        Me.by5.Size = New System.Drawing.Size(31, 12)
        Me.by5.TabIndex = 41
        Me.by5.Text = "by : "
        '
        'type5
        '
        Me.type5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.type5.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.type5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.type5.Location = New System.Drawing.Point(6, 201)
        Me.type5.Name = "type5"
        Me.type5.Size = New System.Drawing.Size(37, 12)
        Me.type5.TabIndex = 39
        Me.type5.Text = "댓글 :"
        '
        'tray
        '
        Me.tray.Icon = CType(resources.GetObject("tray.Icon"), System.Drawing.Icon)
        Me.tray.Text = "블로그 댓글 알림이"
        Me.tray.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 396)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 139)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "설정"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(15, 64)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton2.TabIndex = 24
        Me.RadioButton2.Text = "댓글달기"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0.1", "0.2", "0.3", "0.5", "1.0"})
        Me.ComboBox1.Location = New System.Drawing.Point(83, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(42, 20)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.Text = "1.5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 12)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "/초"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 12)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "새로고침 간격"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(15, 42)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(127, 16)
        Me.RadioButton3.TabIndex = 18
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "아무것도 하지 않기"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(247, 16)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.Text = "새 댓글이 달리면 해당 게시글로 이동하기"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(222, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "트레이로"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000000
        '
        'type1
        '
        Me.type1.BackColor = System.Drawing.Color.White
        Me.type1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.type1.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.type1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.type1.Location = New System.Drawing.Point(55, 130)
        Me.type1.Name = "type1"
        Me.type1.Size = New System.Drawing.Size(381, 11)
        Me.type1.TabIndex = 24
        Me.type1.Text = "None"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(25, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 12)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "제목"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(25, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 12)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "제목"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(25, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 12)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "제목"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(25, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 12)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "제목"
        '
        'type2
        '
        Me.type2.BackColor = System.Drawing.Color.White
        Me.type2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.type2.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.type2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.type2.Location = New System.Drawing.Point(55, 191)
        Me.type2.Name = "type2"
        Me.type2.Size = New System.Drawing.Size(381, 12)
        Me.type2.TabIndex = 29
        Me.type2.Text = "None"
        '
        'type3
        '
        Me.type3.BackColor = System.Drawing.Color.White
        Me.type3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.type3.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.type3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.type3.Location = New System.Drawing.Point(55, 253)
        Me.type3.Name = "type3"
        Me.type3.Size = New System.Drawing.Size(381, 12)
        Me.type3.TabIndex = 32
        Me.type3.Text = "None"
        '
        'type4
        '
        Me.type4.BackColor = System.Drawing.Color.White
        Me.type4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.type4.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.type4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.type4.Location = New System.Drawing.Point(55, 316)
        Me.type4.Name = "type4"
        Me.type4.Size = New System.Drawing.Size(381, 12)
        Me.type4.TabIndex = 36
        Me.type4.Text = "None"
        '
        'by1
        '
        Me.by1.BackColor = System.Drawing.Color.White
        Me.by1.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.by1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.by1.Location = New System.Drawing.Point(30, 146)
        Me.by1.Name = "by1"
        Me.by1.Size = New System.Drawing.Size(406, 13)
        Me.by1.TabIndex = 37
        Me.by1.Text = "작성자 : "
        '
        'by2
        '
        Me.by2.BackColor = System.Drawing.Color.White
        Me.by2.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.by2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.by2.Location = New System.Drawing.Point(30, 208)
        Me.by2.Name = "by2"
        Me.by2.Size = New System.Drawing.Size(406, 14)
        Me.by2.TabIndex = 44
        Me.by2.Text = "작성자 : "
        '
        'by3
        '
        Me.by3.BackColor = System.Drawing.Color.White
        Me.by3.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.by3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.by3.Location = New System.Drawing.Point(30, 270)
        Me.by3.Name = "by3"
        Me.by3.Size = New System.Drawing.Size(406, 15)
        Me.by3.TabIndex = 45
        Me.by3.Text = "작성자 : "
        '
        'by4
        '
        Me.by4.BackColor = System.Drawing.Color.White
        Me.by4.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.by4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.by4.Location = New System.Drawing.Point(30, 333)
        Me.by4.Name = "by4"
        Me.by4.Size = New System.Drawing.Size(404, 14)
        Me.by4.TabIndex = 46
        Me.by4.Text = "작성자 : "
        '
        'count
        '
        Me.count.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.count.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.count.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.count.Location = New System.Drawing.Point(107, 95)
        Me.count.Name = "count"
        Me.count.Size = New System.Drawing.Size(22, 13)
        Me.count.TabIndex = 47
        Me.count.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(178, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(3, 14)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(271, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(3, 14)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(376, 50)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(3, 14)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'gotray
        '
        Me.gotray.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.gotray.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gotray.Image = Global.알림이.My.Resources.Resources.트레이_모드
        Me.gotray.Location = New System.Drawing.Point(190, 50)
        Me.gotray.Name = "gotray"
        Me.gotray.Size = New System.Drawing.Size(66, 14)
        Me.gotray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.gotray.TabIndex = 52
        Me.gotray.TabStop = False
        '
        'godeveloper
        '
        Me.godeveloper.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.godeveloper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.godeveloper.Image = Global.알림이.My.Resources.Resources.개발자_블로그
        Me.godeveloper.Location = New System.Drawing.Point(282, 50)
        Me.godeveloper.Name = "godeveloper"
        Me.godeveloper.Size = New System.Drawing.Size(79, 14)
        Me.godeveloper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.godeveloper.TabIndex = 53
        Me.godeveloper.TabStop = False
        '
        'godesigner
        '
        Me.godesigner.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.godesigner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.godesigner.Image = Global.알림이.My.Resources.Resources.디자이너_블로그
        Me.godesigner.Location = New System.Drawing.Point(386, 50)
        Me.godesigner.Name = "godesigner"
        Me.godesigner.Size = New System.Drawing.Size(91, 14)
        Me.godesigner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.godesigner.TabIndex = 54
        Me.godesigner.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.PictureBox4.Image = Global.알림이.My.Resources.Resources.설정
        Me.PictureBox4.Location = New System.Drawing.Point(525, 43)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 28)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 55
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PictureBox5.Image = Global.알림이.My.Resources.Resources.x
        Me.PictureBox5.Location = New System.Drawing.Point(551, 10)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(6, 7)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 56
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.알림이.My.Resources.Resources.네이버_메일
        Me.PictureBox6.Location = New System.Drawing.Point(480, 99)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(80, 81)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 57
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.알림이.My.Resources.Resources.네이버_쪽지
        Me.PictureBox7.Location = New System.Drawing.Point(480, 186)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(80, 81)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 58
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Image = Global.알림이.My.Resources.Resources.신버전_확인
        Me.PictureBox8.Location = New System.Drawing.Point(480, 274)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(80, 81)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 59
        Me.PictureBox8.TabStop = False
        '
        'flag
        '
        Me.flag.AutoSize = True
        Me.flag.Location = New System.Drawing.Point(269, 95)
        Me.flag.Name = "flag"
        Me.flag.Size = New System.Drawing.Size(11, 12)
        Me.flag.TabIndex = 60
        Me.flag.Text = "0"
        Me.flag.Visible = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = Global.알림이.My.Resources.Resources.size1
        Me.ClientSize = New System.Drawing.Size(571, 376)
        Me.Controls.Add(Me.flag)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.godesigner)
        Me.Controls.Add(Me.godeveloper)
        Me.Controls.Add(Me.gotray)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.count)
        Me.Controls.Add(Me.by4)
        Me.Controls.Add(Me.by3)
        Me.Controls.Add(Me.by2)
        Me.Controls.Add(Me.by1)
        Me.Controls.Add(Me.type4)
        Me.Controls.Add(Me.type3)
        Me.Controls.Add(Me.type2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.type1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "블로그 관리기 : MADE BY DARU - Blog , blog.naver.com/daru_jally"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gotray, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.godeveloper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.godesigner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tray As NotifyIcon
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents by5 As Label
    Friend WithEvents type5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents type1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents type2 As Label
    Friend WithEvents type3 As Label
    Friend WithEvents type4 As Label
    Friend WithEvents by1 As Label
    Friend WithEvents by2 As Label
    Friend WithEvents by3 As Label
    Friend WithEvents by4 As Label
    Friend WithEvents count As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents gotray As PictureBox
    Friend WithEvents godeveloper As PictureBox
    Friend WithEvents godesigner As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents flag As Label
End Class
