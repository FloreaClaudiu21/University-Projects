<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.LoadingImg = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PassErrorLbl = New System.Windows.Forms.Label()
        Me.MailErrorLbl = New System.Windows.Forms.Label()
        Me.RegisterBtn = New System.Windows.Forms.Button()
        Me.ForgotPassBtn = New System.Windows.Forms.Button()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.PrlLbl = New System.Windows.Forms.Label()
        Me.PassTB = New System.Windows.Forms.TextBox()
        Me.UtLbl = New System.Windows.Forms.Label()
        Me.MailTB = New System.Windows.Forms.TextBox()
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
        Me.mainpanel.Controls.Add(Me.LoadingImg)
        Me.mainpanel.Controls.Add(Me.PictureBox1)
        Me.mainpanel.Controls.Add(Me.PassErrorLbl)
        Me.mainpanel.Controls.Add(Me.MailErrorLbl)
        Me.mainpanel.Controls.Add(Me.RegisterBtn)
        Me.mainpanel.Controls.Add(Me.ForgotPassBtn)
        Me.mainpanel.Controls.Add(Me.LoginBtn)
        Me.mainpanel.Controls.Add(Me.PrlLbl)
        Me.mainpanel.Controls.Add(Me.PassTB)
        Me.mainpanel.Controls.Add(Me.UtLbl)
        Me.mainpanel.Controls.Add(Me.MailTB)
        Me.mainpanel.Controls.Add(Me.TitleLabel)
        Me.mainpanel.Controls.Add(Me.CloseBtn)
        Me.mainpanel.Controls.Add(Me.IconBox)
        Me.mainpanel.Location = New System.Drawing.Point(2, 2)
        Me.mainpanel.Margin = New System.Windows.Forms.Padding(32)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(636, 635)
        Me.mainpanel.TabIndex = 5
        '
        'LoadingImg
        '
        Me.LoadingImg.BackColor = System.Drawing.Color.Transparent
        Me.LoadingImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LoadingImg.Image = Global.BPO___Proiect___Seminar.My.Resources.Resources.loading
        Me.LoadingImg.Location = New System.Drawing.Point(221, 79)
        Me.LoadingImg.Name = "LoadingImg"
        Me.LoadingImg.Size = New System.Drawing.Size(211, 167)
        Me.LoadingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LoadingImg.TabIndex = 21
        Me.LoadingImg.TabStop = False
        Me.LoadingImg.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.BPO___Proiect___Seminar.My.Resources.Resources.logo_RAU
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(10, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 72)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PassErrorLbl
        '
        Me.PassErrorLbl.BackColor = System.Drawing.Color.Transparent
        Me.PassErrorLbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PassErrorLbl.ForeColor = System.Drawing.Color.LightCoral
        Me.PassErrorLbl.Location = New System.Drawing.Point(173, 417)
        Me.PassErrorLbl.Name = "PassErrorLbl"
        Me.PassErrorLbl.Size = New System.Drawing.Size(408, 23)
        Me.PassErrorLbl.TabIndex = 14
        Me.PassErrorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MailErrorLbl
        '
        Me.MailErrorLbl.BackColor = System.Drawing.Color.Transparent
        Me.MailErrorLbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MailErrorLbl.ForeColor = System.Drawing.Color.LightCoral
        Me.MailErrorLbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MailErrorLbl.Location = New System.Drawing.Point(173, 353)
        Me.MailErrorLbl.Name = "MailErrorLbl"
        Me.MailErrorLbl.Size = New System.Drawing.Size(408, 23)
        Me.MailErrorLbl.TabIndex = 13
        Me.MailErrorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RegisterBtn
        '
        Me.RegisterBtn.BackColor = System.Drawing.Color.Transparent
        Me.RegisterBtn.FlatAppearance.BorderSize = 0
        Me.RegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterBtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RegisterBtn.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.RegisterBtn.Location = New System.Drawing.Point(363, 474)
        Me.RegisterBtn.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(224, 30)
        Me.RegisterBtn.TabIndex = 12
        Me.RegisterBtn.Text = "Nu aveti un cont? Inregistrati-va aici!"
        Me.RegisterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RegisterBtn.UseVisualStyleBackColor = False
        '
        'ForgotPassBtn
        '
        Me.ForgotPassBtn.BackColor = System.Drawing.Color.Transparent
        Me.ForgotPassBtn.Enabled = False
        Me.ForgotPassBtn.FlatAppearance.BorderSize = 0
        Me.ForgotPassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ForgotPassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ForgotPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForgotPassBtn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForgotPassBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ForgotPassBtn.Location = New System.Drawing.Point(80, 474)
        Me.ForgotPassBtn.Name = "ForgotPassBtn"
        Me.ForgotPassBtn.Size = New System.Drawing.Size(102, 30)
        Me.ForgotPassBtn.TabIndex = 11
        Me.ForgotPassBtn.Text = "Ati uitat parola?"
        Me.ForgotPassBtn.UseVisualStyleBackColor = False
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.LoginBtn.FlatAppearance.BorderSize = 0
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LoginBtn.Location = New System.Drawing.Point(258, 570)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(123, 56)
        Me.LoginBtn.TabIndex = 10
        Me.LoginBtn.Text = "LOGARE"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'PrlLbl
        '
        Me.PrlLbl.AutoSize = True
        Me.PrlLbl.BackColor = System.Drawing.Color.Transparent
        Me.PrlLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.PrlLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PrlLbl.Location = New System.Drawing.Point(80, 420)
        Me.PrlLbl.Name = "PrlLbl"
        Me.PrlLbl.Size = New System.Drawing.Size(72, 20)
        Me.PrlLbl.TabIndex = 9
        Me.PrlLbl.Text = "PAROLA:"
        '
        'PassTB
        '
        Me.PassTB.Location = New System.Drawing.Point(80, 443)
        Me.PassTB.MaxLength = 60
        Me.PassTB.Name = "PassTB"
        Me.PassTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTB.PlaceholderText = "Parola trebuie sa contina 2 numere, o litera mare si sa fie mai mare de 6 caracte" &
    "re..."
        Me.PassTB.Size = New System.Drawing.Size(501, 25)
        Me.PassTB.TabIndex = 8
        Me.PassTB.UseSystemPasswordChar = True
        '
        'UtLbl
        '
        Me.UtLbl.AutoSize = True
        Me.UtLbl.BackColor = System.Drawing.Color.Transparent
        Me.UtLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.UtLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UtLbl.Location = New System.Drawing.Point(80, 353)
        Me.UtLbl.Name = "UtLbl"
        Me.UtLbl.Size = New System.Drawing.Size(59, 20)
        Me.UtLbl.TabIndex = 7
        Me.UtLbl.Text = "EMAIL:"
        '
        'MailTB
        '
        Me.MailTB.Location = New System.Drawing.Point(80, 379)
        Me.MailTB.MaxLength = 60
        Me.MailTB.Name = "MailTB"
        Me.MailTB.PlaceholderText = "Introduceti adresa de email pe care o detineti..."
        Me.MailTB.Size = New System.Drawing.Size(501, 25)
        Me.MailTB.TabIndex = 6
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TitleLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.TitleLabel.Location = New System.Drawing.Point(114, 273)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(420, 48)
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
        Me.CloseBtn.Location = New System.Drawing.Point(561, 10)
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
        Me.IconBox.Location = New System.Drawing.Point(221, 79)
        Me.IconBox.Name = "IconBox"
        Me.IconBox.Size = New System.Drawing.Size(211, 167)
        Me.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconBox.TabIndex = 3
        Me.IconBox.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 640)
        Me.Controls.Add(Me.mainpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.mainpanel.ResumeLayout(False)
        Me.mainpanel.PerformLayout()
        CType(Me.LoadingImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainpanel As Panel
    Friend WithEvents IconBox As PictureBox
    Friend WithEvents CloseBtn As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents PrlLbl As Label
    Friend WithEvents PassTB As TextBox
    Friend WithEvents UtLbl As Label
    Friend WithEvents MailTB As TextBox
    Friend WithEvents ForgotPassBtn As Button
    Friend WithEvents LoginBtn As Button
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents PassErrorLbl As Label
    Friend WithEvents MailErrorLbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoadingImg As PictureBox
End Class
