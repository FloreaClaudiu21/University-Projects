Imports System.Text

Public Class aplicatia_settings
    Dim CUR_PAGE As Integer = 0
    Public EDITING As Boolean = False
    Public EDITING_USER As User
    Public EDITING_HOLDER As User_holder
    'LOAD THE USERS'
    Public Sub load_users()
        Dim I = CUR_PAGE * 5
        Dim max = I + 5
        FlowPanel.Controls.Clear()
        Dim LIST = login.DATABASE.USERS
        If max >= LIST.Count Then
            max = LIST.Count
        End If
        'ADD THE USERS IN THE PANEL'
        For I = CUR_PAGE * 5 To max Step +1
            If (I >= max) Then
                Exit For
            End If
            Dim USER = LIST.ElementAt(I)
            Dim UH = New User_holder(USER)
            UH.CountLbl.Text = (I + 1).ToString
            Continue For
        Next
        Dim HASNEXT As Boolean = True
        If ((CUR_PAGE + 1) * 5) >= LIST.Count Then
            HASNEXT = False
        End If
        If LIST.Count > 5 And HASNEXT Then
            NextPageBtn.Enabled = True
        Else
            NextPageBtn.Enabled = False
        End If
        If CUR_PAGE >= 1 Then
            PrevPageBtn.Enabled = True
        Else
            PrevPageBtn.Enabled = False
        End If
        TitleLbl.Text = "(!) Lista de utilizatorii (" + I.ToString + "/" + LIST.Count.ToString + "):"
        Me.Refresh()
        Return
    End Sub
    'BACK TO MAIN MENU'
    Private Sub MainMenuBtn_Click(sender As Object, e As EventArgs) Handles MainMenuBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa va intoarceti la meniul principal?", "Intoarcere la meniul principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            If EDITING Then
                EDITING_HOLDER.edit()
            End If
            ErrorLbl.Text = ""
            APSCenterPanel.Hide()
            main_menu.hide_user_panel_anim()
            main_menu.CenterPanel.Show()
            main_menu.Size = New Size(New Point(840, 600))
            main_menu.ProfilePanel.Location = New Point(68, 75)
            Return
        End If
    End Sub
    'NEXT PAGE BUTTON'
    Private Sub NextPageBtn_Click(sender As Object, e As EventArgs) Handles NextPageBtn.Click
        CUR_PAGE += 1
        load_users()
        Return
    End Sub
    'PREV PAGE BUTTON'
    Private Sub PrevPageBtn_Click(sender As Object, e As EventArgs) Handles PrevPageBtn.Click
        CUR_PAGE -= 1
        load_users()
        Return
    End Sub
End Class
'PRODUCT HOLDER'
Public Class User_holder
    Inherits Panel
    Dim USERU As User
    Dim Valid As validator
    Friend WithEvents MailLblTop As New Label
    Friend WithEvents PictureBox2 As New PictureBox
    Friend WithEvents ProfileBtn As New Button
    Friend WithEvents TitleLabel As New Label
    Friend WithEvents IconBox As New PictureBox
    Friend WithEvents MinBtn As New Button
    Friend WithEvents CloseBtn As New Button
    Friend WithEvents Panel1 As New Panel
    Friend WithEvents MainMenuBtn As New Button
    Friend WithEvents ShowLbl As New Label
    Friend WithEvents MainTitleLbl As New Label
    Friend WithEvents Label1 As New Label
    Friend WithEvents TitleLbl As New Label
    Friend WithEvents Panel3 As New Panel
    Friend WithEvents Panel2 As New Panel
    Friend WithEvents CountLbl As New Label
    Friend WithEvents EditBtn As New Button
    Friend WithEvents DeleteBtn As New Button
    Friend WithEvents TextBox3 As New TextBox
    Friend WithEvents TextBox2 As New TextBox
    Friend WithEvents TelephoneLbl As New Label
    Friend WithEvents PassLbl As New Label
    Friend WithEvents RoleCB As New ComboBox
    Friend WithEvents TextBox1 As New TextBox
    Friend WithEvents EmailLbl As New Label
    Friend WithEvents ImageB As New PictureBox
    Friend WithEvents PassHImg As New PictureBox
    Dim PASS_VISIBLE As Boolean = False

    Public Sub New(USE As User)
        USERU = USE
        Me.Size = New System.Drawing.Size(972, 110)
        Me.Panel3.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.CountLbl)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(972, 110)
        Me.Panel3.TabIndex = 1
        Me.Controls.Add(Panel3)
        Valid = New validator(TextBox1, TextBox2, aplicatia_settings.ErrorLbl, aplicatia_settings.ErrorLbl, aplicatia_settings.ErrorLbl, TextBox1, aplicatia_settings.ErrorLbl, TextBox3)
        '
        'CountLbl
        '
        Me.CountLbl.BackColor = System.Drawing.Color.Black
        Me.CountLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CountLbl.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CountLbl.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CountLbl.Location = New System.Drawing.Point(0, 0)
        Me.CountLbl.Name = "CountLbl"
        Me.CountLbl.Size = New System.Drawing.Size(65, 106)
        Me.CountLbl.TabIndex = 0
        Me.CountLbl.Text = "1"
        Me.CountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PassHImg)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TelephoneLbl)
        Me.Panel2.Controls.Add(Me.PassLbl)
        Me.Panel2.Controls.Add(Me.RoleCB)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.EmailLbl)
        Me.Panel2.Controls.Add(Me.ImageB)
        Me.Panel2.Controls.Add(Me.EditBtn)
        Me.Panel2.Controls.Add(Me.DeleteBtn)
        Me.Panel2.Location = New System.Drawing.Point(59, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(940, 100)
        Me.Panel2.TabIndex = 0
        '
        'PassHImg
        '
        Me.PassHImg.TabIndex = 10
        Me.PassHImg.TabStop = False
        Me.PassHImg.Name = "PassHImg"
        Me.PassHImg.Size = New Size(29, 28)
        Me.PassHImg.Location = New Point(730, 62)
        Me.PassHImg.BackgroundImage = My.Resources.hidden_icon
        Me.PassHImg.BackgroundImageLayout = ImageLayout.Stretch
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.Location = New System.Drawing.Point(198, 37)
        Me.TextBox3.MaxLength = 60
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(560, 19)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = USERU.PHONE
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(198, 64)
        Me.TextBox2.MaxLength = 60
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(527, 26)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Text = USERU.PASS
        '
        'TelephoneLbl
        '
        Me.TelephoneLbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.TelephoneLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TelephoneLbl.Location = New System.Drawing.Point(96, 34)
        Me.TelephoneLbl.Name = "TelephoneLbl"
        Me.TelephoneLbl.Size = New System.Drawing.Size(96, 22)
        Me.TelephoneLbl.TabIndex = 7
        Me.TelephoneLbl.Text = "Telefon: "
        Me.TelephoneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PassLbl
        '
        Me.PassLbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.PassLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PassLbl.Location = New System.Drawing.Point(96, 65)
        Me.PassLbl.Name = "PassLbl"
        Me.PassLbl.Size = New System.Drawing.Size(96, 22)
        Me.PassLbl.TabIndex = 6
        Me.PassLbl.Text = "Parola: "
        Me.PassLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoleCB
        '
        Me.RoleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoleCB.Enabled = False
        Me.RoleCB.FormattingEnabled = True
        Me.RoleCB.Items.AddRange(New Object() {"USER", "ADMIN"})
        Me.RoleCB.Location = New System.Drawing.Point(11, 64)
        Me.RoleCB.Name = "RoleCB"
        Me.RoleCB.Size = New System.Drawing.Size(79, 25)
        Me.RoleCB.TabIndex = 5
        If USERU.ROL = Role.ADMIN Then
            Me.RoleCB.SelectedIndex = 1
        Else
            Me.RoleCB.SelectedIndex = 0
        End If
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(198, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(560, 19)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = USERU.MAIL
        '
        'EmailLbl
        '
        Me.EmailLbl.AutoSize = True
        Me.EmailLbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.EmailLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EmailLbl.Location = New System.Drawing.Point(96, 6)
        Me.EmailLbl.Name = "EmailLbl"
        Me.EmailLbl.Size = New System.Drawing.Size(96, 22)
        Me.EmailLbl.TabIndex = 3
        Me.EmailLbl.Text = "Utilizator: "
        Me.EmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageB
        '
        Me.ImageB.BackgroundImage = Global.BPO___Proiect___Seminar.My.Resources.Resources.user
        Me.ImageB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ImageB.Location = New System.Drawing.Point(11, -1)
        Me.ImageB.Name = "ImageB"
        Me.ImageB.Size = New System.Drawing.Size(79, 60)
        Me.ImageB.TabIndex = 2
        Me.ImageB.TabStop = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.EditBtn.BackgroundImage = Global.BPO___Proiect___Seminar.My.Resources.Resources.editpen
        Me.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.EditBtn.FlatAppearance.BorderSize = 2
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EditBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EditBtn.Location = New System.Drawing.Point(770, 6)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(62, 84)
        Me.EditBtn.TabIndex = 1
        Me.EditBtn.Text = "EDITARE"
        Me.EditBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.DarkRed
        Me.DeleteBtn.BackgroundImage = My.Resources.Resources.delete_icon
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.DeleteBtn.FlatAppearance.BorderSize = 2
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteBtn.Location = New System.Drawing.Point(842, 6)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(62, 84)
        Me.DeleteBtn.TabIndex = 0
        Me.DeleteBtn.Text = "STERGE"
        Me.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.DeleteBtn.UseVisualStyleBackColor = False
        aplicatia_settings.FlowPanel.Controls.Add(Me)
        Return
    End Sub
    'SHOW PASSWORD'
    Public Sub Show_Pass() Handles PassHImg.MouseClick
        If PASS_VISIBLE Then
            PASS_VISIBLE = False
            Me.TextBox2.PasswordChar = "#"
            Me.PassHImg.BackgroundImage = My.Resources.Resources.hidden_icon
        Else
            PASS_VISIBLE = True
            Me.TextBox2.PasswordChar = ""
            Me.PassHImg.BackgroundImage = My.Resources.Resources.eye_icon
        End If
        Return
    End Sub
    'ENTER TO EDIT'
    Private Sub Enter_key(SENDER As Object, EV As KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox3.KeyPress
        If EV.KeyChar = ChrW(Keys.Enter) Then
            EV.Handled = True
            If aplicatia_settings.EDITING Then
                edit()
            End If
            Return
        End If
    End Sub
    'TEXT CHANGED'
    Private Sub TB_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox3.TextChanged
        Dim TEXT As String = sender.Text
        If String.IsNullOrEmpty(TEXT) Then
            aplicatia_settings.ErrorLbl.Text = ""
            Return
        End If
        Dim S As TextBox = sender
        If S.Name.Equals(TextBox2.Name) Then
            If Valid.password(False) Then
                sender.ForeColor = Color.Green
                Return
            Else
                sender.ForeColor = Color.LightCoral
                Return
            End If
        Else
            If Valid.phone Then
                sender.ForeColor = Color.Green
                Return
            Else
                sender.ForeColor = Color.LightCoral
                Return
            End If
        End If
        Return
    End Sub
    Public Sub edit()
        'IF NOT EDITING START THE EDIT'
        If Not aplicatia_settings.EDITING Then
            If Not USERU.MAIL.Equals(login.DATABASE.ADMIN_USER.MAIL) Then
                RoleCB.Enabled = True
            End If
            TextBox2.ReadOnly = False
            TextBox3.ReadOnly = False
            aplicatia_settings.EDITING = True
            aplicatia_settings.EDITING_HOLDER = Me
            aplicatia_settings.EDITING_USER = USERU
            MessageBox.Show("Ati activat editarea de informatii pentru utilizatorul '" + USERU.MAIL + "'.", "Activare editare utilizator", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Return
        End If
        'NOT SAME USER'
        If aplicatia_settings.EDITING And Not aplicatia_settings.EDITING_USER.MAIL.Equals(USERU.MAIL) Then
            aplicatia_settings.ErrorLbl.Text = "✗ Terminati de editat utilizatorul " + aplicatia_settings.EDITING_USER.MAIL + " inainte de a deschide alta editare."
            Return
        End If
        'SAVE IF EDITING'
        If aplicatia_settings.EDITING And aplicatia_settings.EDITING_USER.MAIL.Equals(USERU.MAIL) Then
            Dim SB As New StringBuilder
            If Valid.phone Then
                SB = SB.Append("Telefonul nou a fost salvat." + Environment.NewLine)
                USERU.PHONE = TextBox3.Text
            Else
                SB = SB.Append("Telefonul nou nu a putut fi salvat deoarece este invalid." + Environment.NewLine)
                TextBox3.Text = USERU.PHONE
            End If
            If Valid.password(False) Then
                SB = SB.Append("Parola noua a fost salvata." + Environment.NewLine)
                USERU.PASS = TextBox2.Text
            Else
                SB = SB.Append("Parola noua nu a putut fi salvata deoarece este invalida." + Environment.NewLine)
                TextBox2.Text = USERU.PASS
            End If
            If Not USERU.ROL = RoleCB.SelectedIndex Then
                USERU.ROL = RoleCB.SelectedIndex
                SB = SB.Append("Rolul nou a fost salvat." + Environment.NewLine)
            Else
                RoleCB.SelectedIndex = USERU.ROL
                SB = SB.Append("Rolul nu a fost salvat doarece acest utilizator are deja acest rol." + Environment.NewLine)
            End If
            RoleCB.Enabled = False
            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
            aplicatia_settings.EDITING = False
            MessageBox.Show(SB.ToString, "Salvare informatii utilizator '" + USERU.MAIL + "'", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Return
        End If
    End Sub
    'EDIT USER INFO'
    Public Sub Edit_User() Handles EditBtn.MouseClick
        edit()
        Return
    End Sub
    'DELETE PRODUCT FROM THE LIST'
    Public Sub Delete_USER() Handles DeleteBtn.Click
        If USERU.MAIL.Equals(login.DATABASE.ADMIN_USER.MAIL) Then
            MessageBox.Show("Nu puteti sterge acest utilizator din baza de date, acesta este un cont general cu permisiuni de admin!", "Eroare stergere utilizator general", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return
        End If
        If USERU.MAIL.Equals(main_menu.USER.MAIL) Then
            MessageBox.Show("Nu puteti sa va stergeti propriul utilizator din baza de date!", "Eroare stergere utilizator propriu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return
        End If
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa stergeti utilizatorul '" + USERU.MAIL + "' din baza de date?", "Stergere utilizator", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            login.DATABASE.USERS.Remove(USERU)
            aplicatia_settings.load_users()
            MessageBox.Show("Utilizatorul '" + USERU.MAIL + "' a fost sters din baza de date cu succes!", "Utilizator sters din baza de date", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
    End Sub
End Class
