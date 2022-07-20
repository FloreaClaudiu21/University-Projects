'MAIN FORM CLASS'
Public Class main_menu
    Public USER As User
    Dim Valid As validator
    Public EDITING = False
    Public EFIELD As TextBox
    Public DEDUCERE As New deducere
    Public ANIM_WORK As Boolean = False
    Dim ANIM_TYPE As Integer = 0
    Public WithEvents ANIM_TIMER As New Timer
    '------------------------------'
    Private Sub main_menu_load(sender As Object, e As EventArgs) Handles MyBase.Load
        USER.ROL = Role.ADMIN
        Valid = New validator(NamePTB, ParolaPTB, ErrorPLbl, ErrorPLbl, ErrorPLbl, MailPTB, ErrorPLbl, PhonePTB)
        ProfilePanel.Size = New Point(621, 393)
        Me.Controls.Add(aplicatia1.AP1CenterPanel)
        Me.Controls.Add(aplicatia2.AP2CenterPanel)
        Me.Controls.Add(aplicatia3.AP3CenterPanel)
        Me.Controls.Add(aplicatia4.AP4CenterPanel)
        Me.Controls.Add(aplicatia5.AP5CenterPanel)
        Me.Controls.Add(aplicatia_settings.APSCenterPanel)
        Me.Controls.Add(aplicatia_comuna.APCCenterPanel)
        aplicatia1.ChooseBox.SelectedIndex = 0
        aplicatia2.ChooseBox.SelectedIndex = 0
        aplicatia3.PersoaneCB.SelectedIndex = 0
        aplicatia4.FromBazaCB.SelectedIndex = 0
        aplicatia4.ToBazaCB.SelectedIndex = 8
        login.ShowScrollBar(aplicatia_settings.FlowPanel.Handle, 1, True)
        Return
    End Sub
    'CLOSE THE PROGRAM'
    Private Sub CloseBtn_Click_1(sender As Object, e As EventArgs) Handles CloseBtn.Click
        hide_user_panel()
        If aplicatia_settings.EDITING Then
            aplicatia_settings.EDITING_HOLDER.edit()
        End If
        Me.Close()
        login.Close()
        Return
    End Sub
    Private Sub ExitAppBtn_Click(sender As Object, e As EventArgs) Handles ExitAppBtn.Click
        Dim RES As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa inchideti aplicatia?", "Inchide aplicatia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If RES = DialogResult.Yes Then
            hide_user_panel()
            Me.Close()
            login.Close()
        End If
        Return
    End Sub
    'MINIMIZE THE WINDOW'
    Private Sub MinBtn_Click(sender As Object, e As EventArgs) Handles MinBtn.Click
        Me.WindowState = 1
        Return
    End Sub
    'MOVE THE WINDOW AROUND'
    Private Sub Form_MouseDown(sender As Object, EV As System.Windows.Forms.MouseEventArgs) Handles TopPanel.MouseDown, TitleLabel.MouseDown, IconBox.MouseDown
        If (EV.Button = MouseButtons.Left) Then
            login.ReleaseCapture()
            login.SendMessage(Handle, login.WM_NCLBUTTONDOWN, login.HT_CAPTION, 0)
        End If
        Return
    End Sub
    'PROFILE PANEL'
    Public Sub Update_Panel()
        ErrorPLbl.Text = ""
        MailPTB.Text = USER.MAIL
        NamePTB.Text = USER.NAME
        PhonePTB.Text = USER.PHONE
        ParolaPTB.Text = USER.PASS
        ProfileBtn.Text = USER.MAIL
        MailLblTop.Text = USER.MAIL
        If USER.ROL = Role.ADMIN Then
            RolePLbl.SelectedIndex = 1
        Else
            RolePLbl.SelectedIndex = 0
        End If
        Return
    End Sub
    'CHANGE GROUP'
    Public Sub change_group(sender As Object, e As EventArgs) Handles RolePLbl.SelectedIndexChanged
        USER.ROL = RolePLbl.SelectedIndex
        Return
    End Sub
    'SHOW THE PROFILE PANEL'
    Public Sub ProfileBtn_Hover(sender As Object, e As EventArgs) Handles ProfileBtn.MouseEnter, MailLblTop.MouseEnter, PictureBox2.MouseEnter
        If ANIM_WORK Then
            Return
        End If
        ANIM_TYPE = 0
        ANIM_WORK = True
        ANIM_TIMER.Interval = 20
        ANIM_TIMER.Start()
        ProfileBtn.BackColor = Color.Black
        MailLblTop.BackColor = Color.Black
        PictureBox2.BackColor = Color.Black
        Return
    End Sub
    'HIDE THE PROFILE PANEL'
    Public Sub TopPanel_Hover(sender As Object, e As EventArgs) Handles TopPanel.MouseEnter, TitleLabel.MouseEnter
        hide_user_panel_anim()
        Return
    End Sub
    'HIDE USER PANEL'
    Public Sub hide_user_panel()
        ANIM_TIMER.Stop()
        ProfilePanel.Hide()
        ProfileBtn.BackColor = Color.Transparent
        MailLblTop.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        If EDITING Then
            Edit_User_Info(EFIELD)
        End If
        ProfilePanel.Location = New Point(ProfilePanel.Location.X, -30)
        Me.Refresh()
        Return
    End Sub
    'HIDE USER PANEL ANIM'
    Public Sub hide_user_panel_anim()
        If ANIM_WORK Then
            Return
        End If
        ANIM_TYPE = 1
        ANIM_WORK = True
        ANIM_TIMER.Interval = 10
        ANIM_TIMER.Start()
        Return
    End Sub
    'ENTER TO EDIT'
    Private Sub tbbtn_key(sender As Object, e As KeyPressEventArgs) Handles ParolaPTB.KeyPress, NamePTB.KeyPress, PhonePTB.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Edit_User_Info(sender)
            Return
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keydata As Keys) As Boolean
        Dim R = login.CONSOLE.key_process(msg, keydata)
        If Not R Then
            Return MyBase.ProcessCmdKey(msg, keydata)
        Else
            Return True
        End If
    End Function
    Private Sub EditPassEmail_Click(sender As Object, e As EventArgs) Handles EditPassEmail.Click
        Edit_User_Info(ParolaPTB)
        Return
    End Sub
    Private Sub EditNameBtn_Click(sender As Object, e As EventArgs) Handles EditNameBtn.Click
        Edit_User_Info(NamePTB)
        Return
    End Sub
    Private Sub EditPhoneBtn_Click(sender As Object, e As EventArgs) Handles EditPhoneBtn.Click
        Edit_User_Info(PhonePTB)
        Return
    End Sub
    'TEXTBOX CONTROL PANEL CHANGED'
    Private Sub NamePTB_TextChanged(sender As Object, e As EventArgs) Handles NamePTB.TextChanged
        If Valid.user() Then
            ErrorPLbl.Text = ""
            NamePTB.ForeColor = Color.Green
            ErrorPLbl.ForeColor = Color.Green
        Else
            NamePTB.ForeColor = Color.LightCoral
            ErrorPLbl.ForeColor = Color.LightCoral
        End If
    End Sub
    'PASSWORD TEXTBOX TEXT CHANGE'
    Private Sub ParolaTB_TextChanged(sender As Object, e As EventArgs) Handles ParolaPTB.TextChanged
        If Valid.password(False) Then
            ErrorPLbl.Text = ""
            ParolaPTB.ForeColor = Color.Green
            ErrorPLbl.ForeColor = Color.Green
        Else
            ParolaPTB.ForeColor = Color.LightCoral
            ErrorPLbl.ForeColor = Color.LightCoral
        End If
    End Sub
    'PHONE TEXTBOX TEXT CHANGE'
    Private Sub PhoneTB_TextChanged(sender As Object, e As EventArgs) Handles PhonePTB.TextChanged
        If Valid.phone() Then
            ErrorPLbl.Text = ""
            PhonePTB.ForeColor = Color.Green
            ErrorPLbl.ForeColor = Color.Green
        Else
            PhonePTB.ForeColor = Color.LightCoral
            ErrorPLbl.ForeColor = Color.LightCoral
        End If
    End Sub
    'EDIT THE USER INFORMATION'
    Public Sub Edit_User_Info(TB As TextBox)
        'START THE EDIT'
        If Not EDITING Then
            EFIELD = TB
            EDITING = True
            TB.Enabled = True
            TB.ReadOnly = False
            TB.BackColor = Color.Gainsboro
            Return
        Else
            'STOP THE EDIT'
            If EFIELD.Name.Equals(TB.Name) Then
                EDITING = False
                TB.Enabled = False
                TB.ReadOnly = True
                TB.ForeColor = Color.Green
                TB.BackColor = Color.Black
                If TB.Name.Equals(ParolaPTB.Name) Then
                    If Valid.password(False) Then
                        ErrorPLbl.Text = ""
                        USER.PASS = ParolaPTB.Text
                        login.DATABASE.pass_replace(USER)
                    Else
                        ParolaPTB.Text = USER.PASS
                        MessageBox.Show("Noua parola nu a putut fi salvata deoarece nu este valida.", "Salavare parola noua", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                ElseIf TB.Name.Equals(PhonePTB.Name) Then
                    If Valid.phone() Then
                        ErrorPLbl.Text = ""
                        USER.PHONE = PhonePTB.Text
                        login.DATABASE.phone_replace(USER)
                    Else
                        PhonePTB.Text = USER.PHONE
                        MessageBox.Show("Noul numar de telefon nu a putut fi salvata deoarece nu este valid.", "Salavare telefon nou", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    If Valid.mail(False, True) Then
                        ErrorPLbl.Text = ""
                        USER.NAME = NamePTB.Text
                        login.DATABASE.name_replace(USER)
                    Else
                        NamePTB.Text = USER.NAME
                        MessageBox.Show("Numele de afisare nu a putut fi salvat deoarece nu este valid.", "Salavare nume de afisare", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub
    'HIDE AND CENTER MAIN WINDOW'
    Private Sub hide_and_center()
        hide_user_panel()
        Me.CenterPanel.Hide()
        Me.Size = New Size(New Point(1024, 768))
        Me.ProfilePanel.Location = New Point(255, -30)
        'CENTER THE WINDOW AND REFRESH'
        Me.CenterToScreen()
        Me.Refresh()
        Return
    End Sub
    'APP 1 BUTTON CLICK'
    Private Sub App1Btn_Click(sender As Object, e As EventArgs) Handles App1Btn.Click
        hide_and_center()
        aplicatia1.AP1CenterPanel.Show()
        Return
    End Sub
    'APP 2 BUTTON CLICK'
    Private Sub App2Btn_Click(sender As Object, e As EventArgs) Handles App2Btn.Click
        hide_and_center()
        aplicatia2.AP2CenterPanel.Show()
        Return
    End Sub
    'APP 3 BUTTON CLICK'
    Private Sub App3Btn_Click(sender As Object, e As EventArgs) Handles App3Btn.Click
        hide_and_center()
        aplicatia3.AP3CenterPanel.Show()
        Return
    End Sub
    'APP 4 BUTTON CLICK'
    Private Sub App4Btn_Click(sender As Object, e As EventArgs) Handles App4Btn.Click
        hide_and_center()
        aplicatia4.AP4CenterPanel.Show()
        Return
    End Sub
    'APP 5 BUTTON CLICK'
    Private Sub App5Btn_Click(sender As Object, e As EventArgs) Handles App5Btn.Click
        hide_and_center()
        aplicatia5.AP5CenterPanel.Show()
        Return
    End Sub
    'APP COMUNA BUTTON CLICK'
    Private Sub AppComunaBtn_Click(sender As Object, e As EventArgs) Handles AppComunaBtn.Click
        If Not User.ROL = Role.ADMIN Then
            MessageBox.Show("Nu aveti permisiune sa accesati acesta aplicatie, trebuie sa faceti parte din grupa adminilor.", "Fara permisiune", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return
        End If
        hide_and_center()
        aplicatia_comuna.APCCenterPanel.Show()
        Return
    End Sub
    'APP SETTINGS BUTTON CLICK'
    Private Sub SettingsAppBtn_Click(sender As Object, e As EventArgs) Handles SettingsAppBtn.Click
        If Not User.ROL = Role.ADMIN Then
            MessageBox.Show("Nu aveti permisiune sa accesati acesta aplicatie, trebuie sa faceti parte din grupa adminilor.", "Fara permisiune", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return
        End If
        hide_and_center()
        aplicatia_settings.APSCenterPanel.Show()
        Return
    End Sub
    'TASK TICKER'
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANIM_TIMER.Tick
        If Not ANIM_WORK Then
            ANIM_TIMER.Stop()
        End If
        'SHOW THE PANEL'
        If ANIM_TYPE = 0 Then
            Dim max_y = 75
            Dim CI = ProfilePanel.Location.Y
            If (CI >= max_y) Then
                ANIM_TIMER.Stop()
                ANIM_WORK = False
                ProfilePanel.Location = New Point(ProfilePanel.Location.X, max_y)
                Return
            End If
            If CI >= 15 Then
                If Not ProfilePanel.Visible Then
                    ProfilePanel.Show()
                End If
            End If
            Dim ADD = CI + 12
            If ADD > max_y Then
                ADD = max_y
            End If
            ProfilePanel.Location = New Point(ProfilePanel.Location.X, ADD)
        Else
            Dim max_y = -30
            Dim CI = ProfilePanel.Location.Y
            If (CI <= max_y) Then
                ANIM_TIMER.Stop()
                ANIM_WORK = False
                If EDITING Then
                    Edit_User_Info(EFIELD)
                End If
                ProfilePanel.Location = New Point(ProfilePanel.Location.X, max_y)
                Return
            End If
            'HIDE PANEL'
            If CI <= 25 Then
                If ProfilePanel.Visible Then
                    ProfilePanel.Hide()
                    ProfileBtn.BackColor = Color.Transparent
                    MailLblTop.BackColor = Color.Transparent
                    PictureBox2.BackColor = Color.Transparent
                End If
            End If
            Dim SUBS = (CI - 8)
            If SUBS <= max_y Then
                SUBS = max_y
            End If
            ProfilePanel.Location = New Point(ProfilePanel.Location.X, SUBS)
        End If
        Return
    End Sub
End Class
