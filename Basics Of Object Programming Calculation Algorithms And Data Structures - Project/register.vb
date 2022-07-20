Public Class register
    Public Valid As validator
    'LOAD THE FORM'
    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Valid = New validator(UserTB, PassTB, UserErrorLbl, PassErrorLbl, MailErrLbl, MailTB, PhoneErrLbl, PhoneTB)
    End Sub
    'BACK BUTTON'
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa va intoarceti inapoi la pagina de logare?", "Inapoi la pagina de logare", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            Me.Hide()
            clear_fields()
            login.Show()
            Return
        End If
    End Sub
    'CLOSE BUTTON'
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
        login.Close()
        Return
    End Sub
    'CLEAR THE FORM FIELDS'
    Public Sub clear_fields()
        UserTB.Clear()
        PassTB.Clear()
        MailTB.Clear()
        PhoneTB.Clear()
        MailErrLbl.Text = ""
        UserErrorLbl.Text = ""
        PassErrorLbl.Text = ""
        PhoneErrLbl.Text = ""
        UtLbl.ForeColor = Color.White
        PrlLbl.ForeColor = Color.White
        MailLbl.ForeColor = Color.White
        PhoneLbl.ForeColor = Color.White
        Return
    End Sub
    'MOVE THE WINDOW AROUND'
    Private Sub Form_MouseDown(sender As Object, EV As System.Windows.Forms.MouseEventArgs) Handles mainpanel.MouseDown, TitleLabel.MouseDown, IconBox.MouseDown
        If (EV.Button = MouseButtons.Left) Then
            login.ReleaseCapture()
            login.SendMessage(Handle, login.WM_NCLBUTTONDOWN, login.HT_CAPTION, 0)
        End If
    End Sub
    'USER TB'
    Private Sub UserTB_Enter(sender As Object, e As EventArgs) Handles UserTB.TextChanged
        Dim CHECK = Valid.user()
        If CHECK Then
            UtLbl.ForeColor = Color.Green
            UserTB.ForeColor = Color.Green
        Else
            UtLbl.ForeColor = Color.LightCoral
            UserTB.ForeColor = Color.LightCoral
        End If
    End Sub
    'PASS TB'
    Private Sub PassTB_Enter(sender As Object, e As EventArgs) Handles PassTB.TextChanged
        Dim CHECK = Valid.password(False)
        If CHECK Then
            PrlLbl.ForeColor = Color.Green
            PassTB.ForeColor = Color.Green
        Else
            PassTB.ForeColor = Color.Red
            PrlLbl.ForeColor = Color.LightCoral
        End If
    End Sub
    'EMAIL TB'
    Private Sub MailTB_Enter(sender As Object, e As EventArgs) Handles MailTB.TextChanged
        Dim CHECK = Valid.mail(False)
        If CHECK Then
            MailLbl.ForeColor = Color.Green
            MailTB.ForeColor = Color.Green
        Else
            MailTB.ForeColor = Color.LightCoral
            MailLbl.ForeColor = Color.LightCoral
        End If
    End Sub
    'PHONE TB'
    Private Sub PhoneTB_Enter(sender As Object, e As EventArgs) Handles PhoneTB.TextChanged
        Dim CHECK = Valid.phone
        If CHECK Then
            PhoneLbl.ForeColor = Color.Green
            PhoneTB.ForeColor = Color.Green
        Else
            PhoneTB.ForeColor = Color.LightCoral
            PhoneTB.ForeColor = Color.LightCoral
        End If
    End Sub
    'REGISTER THE USER'
    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        login.DATABASE.register_user(Me)
        Return
    End Sub
    'ENTER TO REGISTER'
    Private Sub loginbtn_key(sender As Object, e As KeyPressEventArgs) Handles PassTB.KeyPress, UserTB.KeyPress, MailTB.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            login.DATABASE.register_user(Me)
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
End Class