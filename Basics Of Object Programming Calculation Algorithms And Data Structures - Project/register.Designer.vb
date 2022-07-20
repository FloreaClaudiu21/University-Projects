<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.PhoneErrLbl = New System.Windows.Forms.Label()
        Me.PhoneLbl = New System.Windows.Forms.Label()
        Me.PhoneTB = New System.Windows.Forms.TextBox()
        Me.LoadingImg = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.MailErrLbl = New System.Windows.Forms.Label()
        Me.MailTB = New System.Windows.Forms.TextBox()
        Me.MailLbl = New System.Windows.Forms.Label()
        Me.PassErrorLbl = New System.Windows.Forms.Label()
        Me.UserErrorLbl = New System.Windows.Forms.Label()
        Me.RegisterBtn = New System.Windows.Forms.Button()
        Me.PrlLbl = New System.Windows.Forms.Label()
        Me.PassTB = New System.Windows.Forms.TextBox()
        Me.UtLbl = New System.Windows.Forms.Label()
        Me.UserTB = New System.Windows.Forms.TextBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.IconBox = New System.Windows.Forms.PictureBox()
        Me.mainpanel.SuspendLayout()
        CType(Me.LoadingImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainpanel
        '
        Me.mainpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.mainpanel.Controls.Add(Me.PhoneErrLbl)
        Me.mainpanel.Controls.Add(Me.PhoneLbl)
        Me.mainpanel.Controls.Add(Me.PhoneTB)
        Me.mainpanel.Controls.Add(Me.LoadingImg)
        Me.mainpanel.Controls.Add(Me.PictureBox1)
        Me.mainpanel.Controls.Add(Me.BackBtn)
        Me.mainpanel.Controls.Add(Me.MailErrLbl)
        Me.mainpanel.Controls.Add(Me.MailTB)
        Me.mainpanel.Controls.Add(Me.MailLbl)
        Me.mainpanel.Controls.Add(Me.PassErrorLbl)
        Me.mainpanel.Controls.Add(Me.UserErrorLbl)
        Me.mainpanel.Controls.Add(Me.RegisterBtn)
        Me.mainpanel.Controls.Add(Me.PrlLbl)
        Me.mainpanel.Controls.Add(Me.PassTB)
        Me.mainpanel.Controls.Add(Me.UtLbl)
        Me.mainpanel.Controls.Add(Me.UserTB)
        Me.mainpanel.Controls.Add(Me.TitleLabel)
        Me.mainpanel.Controls.Add(Me.CloseBtn)
        Me.mainpanel.Controls.Add(Me.IconBox)
        Me.mainpanel.Location = New System.Drawing.Point(3, 2)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(635, 594)
        Me.mainpanel.TabIndex = 6
        '
        'PhoneErrLbl
        '
        Me.PhoneErrLbl.BackColor = System.Drawing.Color.Transparent
        Me.PhoneErrLbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PhoneErrLbl.ForeColor = System.Drawing.Color.LightCoral
        Me.PhoneErrLbl.Location = New System.Drawing.Point(155, 429)
        Me.PhoneErrLbl.Name = "PhoneErrLbl"
        Me.PhoneErrLbl.Size = New System.Drawing.Size(427, 23)
        Me.PhoneErrLbl.TabIndex = 24
        Me.PhoneErrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneLbl
        '
        Me.PhoneLbl.AutoSize = True
        Me.PhoneLbl.BackColor = System.Drawing.Color.Transparent
        Me.PhoneLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.PhoneLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PhoneLbl.Location = New System.Drawing.Point(55, 429)
        Me.PhoneLbl.Name = "PhoneLbl"
        Me.PhoneLbl.Size = New System.Drawing.Size(64, 20)
        Me.PhoneLbl.TabIndex = 23
        Me.PhoneLbl.Text = "PHONE:"
        '
        'PhoneTB
        '
        Me.PhoneTB.Location = New System.Drawing.Point(55, 455)
        Me.PhoneTB.MaxLength = 60
        Me.PhoneTB.Name = "PhoneTB"
        Me.PhoneTB.PlaceholderText = "Introduceti numarul dumneavoastra de telefon..."
        Me.PhoneTB.Size = New System.Drawing.Size(528, 25)
        Me.PhoneTB.TabIndex = 22
        '
        'LoadingImg
        '
        Me.LoadingImg.BackColor = System.Drawing.Color.Transparent
        Me.LoadingImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LoadingImg.Image = Global.BPO___Proiect___Seminar.My.Resources.Resources.loading
        Me.LoadingImg.Location = New System.Drawing.Point(226, 10)
        Me.LoadingImg.Name = "LoadingImg"
        Me.LoadingImg.Size = New System.Drawing.Size(180, 151)
        Me.LoadingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LoadingImg.TabIndex = 20
        Me.LoadingImg.TabStop = False
        Me.LoadingImg.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.BPO___Proiect___Seminar.My.Resources.Resources.logo_RAU
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 70)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BackBtn.FlatAppearance.BorderSize = 0
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BackBtn.Location = New System.Drawing.Point(190, 530)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(123, 56)
        Me.BackBtn.TabIndex = 18
        Me.BackBtn.Text = "<- INAPOI"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'MailErrLbl
        '
        Me.MailErrLbl.BackColor = System.Drawing.Color.Transparent
        Me.MailErrLbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MailErrLbl.ForeColor = System.Drawing.Color.LightCoral
        Me.MailErrLbl.Location = New System.Drawing.Point(156, 363)
        Me.MailErrLbl.Name = "MailErrLbl"
        Me.MailErrLbl.Size = New System.Drawing.Size(427, 23)
        Me.MailErrLbl.TabIndex = 17
        Me.MailErrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MailTB
        '
        Me.MailTB.Location = New System.Drawing.Point(55, 389)
        Me.MailTB.MaxLength = 60
        Me.MailTB.Name = "MailTB"
        Me.MailTB.PlaceholderText = "Introduceti adresa de email pe care o utilizati..."
        Me.MailTB.Size = New System.Drawing.Size(529, 25)
        Me.MailTB.TabIndex = 16
        '
        'MailLbl
        '
        Me.MailLbl.AutoSize = True
        Me.MailLbl.BackColor = System.Drawing.Color.Transparent
        Me.MailLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.MailLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MailLbl.Location = New System.Drawing.Point(55, 366)
        Me.MailLbl.Name = "MailLbl"
        Me.MailLbl.Size = New System.Drawing.Size(59, 20)
        Me.MailLbl.TabIndex = 15
        Me.MailLbl.Text = "EMAIL:"
        '
        'PassErrorLbl
        '
        Me.PassErrorLbl.BackColor = System.Drawing.Color.Transparent
        Me.PassErrorLbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PassErrorLbl.ForeColor = System.Drawing.Color.LightCoral
        Me.PassErrorLbl.Location = New System.Drawing.Point(155, 303)
        Me.PassErrorLbl.Name = "PassErrorLbl"
        Me.PassErrorLbl.Size = New System.Drawing.Size(430, 23)
        Me.PassErrorLbl.TabIndex = 14
        Me.PassErrorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UserErrorLbl
        '
        Me.UserErrorLbl.BackColor = System.Drawing.Color.Transparent
        Me.UserErrorLbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserErrorLbl.ForeColor = System.Drawing.Color.LightCoral
        Me.UserErrorLbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UserErrorLbl.Location = New System.Drawing.Point(155, 236)
        Me.UserErrorLbl.Name = "UserErrorLbl"
        Me.UserErrorLbl.Size = New System.Drawing.Size(429, 23)
        Me.UserErrorLbl.TabIndex = 13
        Me.UserErrorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RegisterBtn
        '
        Me.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.RegisterBtn.FlatAppearance.BorderSize = 0
        Me.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RegisterBtn.Location = New System.Drawing.Point(319, 530)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(123, 56)
        Me.RegisterBtn.TabIndex = 10
        Me.RegisterBtn.Text = "INREGISTRARE"
        Me.RegisterBtn.UseVisualStyleBackColor = False
        '
        'PrlLbl
        '
        Me.PrlLbl.AutoSize = True
        Me.PrlLbl.BackColor = System.Drawing.Color.Transparent
        Me.PrlLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.PrlLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PrlLbl.Location = New System.Drawing.Point(55, 306)
        Me.PrlLbl.Name = "PrlLbl"
        Me.PrlLbl.Size = New System.Drawing.Size(72, 20)
        Me.PrlLbl.TabIndex = 9
        Me.PrlLbl.Text = "PAROLA:"
        '
        'PassTB
        '
        Me.PassTB.Location = New System.Drawing.Point(55, 329)
        Me.PassTB.MaxLength = 60
        Me.PassTB.Name = "PassTB"
        Me.PassTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTB.PlaceholderText = "Parola trebuie sa contina 2 numere, o litera mare si sa fie mai mare de 6 caracte" &
    "re..."
        Me.PassTB.Size = New System.Drawing.Size(530, 25)
        Me.PassTB.TabIndex = 8
        Me.PassTB.UseSystemPasswordChar = True
        '
        'UtLbl
        '
        Me.UtLbl.AutoSize = True
        Me.UtLbl.BackColor = System.Drawing.Color.Transparent
        Me.UtLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.UtLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UtLbl.Location = New System.Drawing.Point(56, 239)
        Me.UtLbl.Name = "UtLbl"
        Me.UtLbl.Size = New System.Drawing.Size(58, 20)
        Me.UtLbl.TabIndex = 7
        Me.UtLbl.Text = "NUME:"
        '
        'UserTB
        '
        Me.UserTB.Location = New System.Drawing.Point(55, 265)
        Me.UserTB.MaxLength = 60
        Me.UserTB.Name = "UserTB"
        Me.UserTB.PlaceholderText = "Numele trebuie sa fie mai mare de 5 caractere, fara unicode-uri sau simboluri..."
        Me.UserTB.Size = New System.Drawing.Size(530, 25)
        Me.UserTB.TabIndex = 6
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TitleLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.TitleLabel.Location = New System.Drawing.Point(133, 179)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(379, 44)
        Me.TitleLabel.TabIndex = 5
        Me.TitleLabel.Text = "Proiect BPO - Florea Claudiu Valentin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Informatica Manageriala | Anul I | Grupa 6" &
    "04"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.Location = New System.Drawing.Point(560, 10)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(65, 50)
        Me.CloseBtn.TabIndex = 4
        Me.CloseBtn.Text = "✗"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'IconBox
        '
        Me.IconBox.BackColor = System.Drawing.Color.Transparent
        Me.IconBox.BackgroundImage = Global.BPO___Proiect___Seminar.My.Resources.Resources.logo
        Me.IconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconBox.Location = New System.Drawing.Point(226, 10)
        Me.IconBox.Name = "IconBox"
        Me.IconBox.Size = New System.Drawing.Size(180, 151)
        Me.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconBox.TabIndex = 3
        Me.IconBox.TabStop = False
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 600)
        Me.Controls.Add(Me.mainpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "register"
        Me.mainpanel.ResumeLayout(False)
        Me.mainpanel.PerformLayout()
        CType(Me.LoadingImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainpanel As Panel
    Friend WithEvents PassErrorLbl As Label
    Friend WithEvents UserErrorLbl As Label
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents PrlLbl As Label
    Friend WithEvents PassTB As TextBox
    Friend WithEvents UtLbl As Label
    Friend WithEvents UserTB As TextBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents CloseBtn As Button
    Friend WithEvents IconBox As PictureBox
    Friend WithEvents MailLbl As Label
    Friend WithEvents MailTB As TextBox
    Friend WithEvents MailErrLbl As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoadingImg As PictureBox
    Friend WithEvents PhoneErrLbl As Label
    Friend WithEvents PhoneLbl As Label
    Friend WithEvents PhoneTB As TextBox
End Class
