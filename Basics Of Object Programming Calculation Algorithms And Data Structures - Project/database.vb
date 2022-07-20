Imports System.IO
Imports System.Text

Public Class database
    Public mailer As New mailer
    Public USERS As New List(Of User)
    Private NAME As String = Environment.CurrentDirectory & "\database.dat"
    Public ADMIN_USER As User = New User("AdminUser", "Admin1234", "admin@student.rau.ro", "0723333333", Role.ADMIN)
    'DISCONNECT TO THE DATABASE'
    Public Sub disconnect()
        If USERS.Count <= 0 Then
            Return
        End If
        Dim SB As New StringBuilder
        'SAVE USERS TO DATABASE'
        For Each USER In USERS
            SB = SB.Append(USER.NAME + ";" + USER.PASS + ";" + USER.MAIL + ";" + USER.PHONE + ";" + Int(User.ROL).ToString)
            SB = SB.Append(Environment.NewLine)
        Next
        'SAVE IN FILE'
        File.WriteAllText(NAME, SB.ToString)
        Return
    End Sub
    'CONNECT TO THE DATABASE' 
    Public Sub connect()
        Dim EXISTS = File.Exists(NAME)
        Dim ADMIN_F As Boolean = False
        If Not EXISTS Then
            Dim FS = File.Create(NAME)
            FS.Close()
        End If
        Dim LINES = File.ReadAllLines(NAME)
        '---------------------------------'
        For Each LINE As String In LINES
            If String.IsNullOrEmpty(LINE) Then
                Continue For
            End If
            Try
                If LINE.Contains(";"c) Then
                    Dim ROLE As Role
                    Dim USER As String, PHONE As String, PASS As String, MAIL As String
                    Dim ARGS = LINE.Split(";")
                    If ARGS.Length < 5 Then
                        Continue For
                    End If
                    USER = ARGS(0)
                    PASS = ARGS(1)
                    MAIL = ARGS(2).ToLower
                    PHONE = ARGS(3)
                    ROLE = ARGS(4)
                    Dim USERDATA As User = New User(USER, PASS, MAIL, PHONE, ROLE)
                    'ADD USER IN THE DATA LIST'
                    USERS.Add(USERDATA)
                    If USERDATA.MAIL.Equals(ADMIN_USER.MAIL) Then
                        ADMIN_F = True
                    End If
                End If
            Catch EX As Exception
                MessageBox.Show(EX.Message)
                Continue For
            End Try
        Next
        'FORCE ADDING ADMIN USER TO THE DATABASE'
        If Not ADMIN_F Then
            USERS.Add(ADMIN_USER)
        End If
        Return
    End Sub
    'CHECK IF USER EXISTS IN THE DATABASE'
    Public Function mail_exists(USER As User) As Boolean
        Return mail_exists(USER.MAIL)
    End Function
    Public Function mail_exists(MAIL As String) As Boolean
        If String.IsNullOrEmpty(MAIL) Then
            Return False
        End If
        MAIL = MAIL.ToLower
        For Each U As User In USERS
            If U.MAIL.Equals(MAIL) Then
                Return True
            End If
        Next
        Return False
    End Function
    'GET USER BY NAME'
    Public Function user_by_name(NAME As String) As User
        If String.IsNullOrEmpty(NAME) Then
            Return Nothing
        End If
        For Each U As User In USERS
            If U.NAME.Equals(NAME) Then
                Return U
            End If
        Next
        Return Nothing
    End Function
    'GET USER BY MAIL'
    Public Function user_by_mail(MAIL As String) As User
        If String.IsNullOrEmpty(MAIL) Then
            Return Nothing
        End If
        MAIL = MAIL.ToLower
        For Each U As User In USERS
            If U.MAIL.Equals(MAIL) Then
                Return U
            End If
        Next
        Return Nothing
    End Function
    'REPLACE THE PASSWORD'
    Public Function pass_replace(USER As User) As Boolean
        Dim REMOVE_USER As User = Nothing
        For Each U As User In USERS
            If U.NAME.Equals(USER.NAME) And U.MAIL.Equals(USER.MAIL) Then
                REMOVE_USER = U
                Exit For
            End If
        Next
        USERS.Remove(REMOVE_USER)
        USERS.Add(USER)
        Return True
    End Function
    'REPLACE THE PHONE'
    Public Function phone_replace(USER As User) As Boolean
        Dim REMOVE_USER As User = Nothing
        For Each U As User In USERS
            If U.NAME.Equals(USER.NAME) And U.MAIL.Equals(USER.MAIL) Then
                REMOVE_USER = U
                Exit For
            End If
        Next
        USERS.Remove(REMOVE_USER)
        USERS.Add(USER)
        Return True
    End Function
    'REPLACE THE DISPLAY NAME'
    Public Function name_replace(USER As User) As Boolean
        Dim REMOVE_USER As User = Nothing
        For Each U As User In USERS
            If U.PHONE.Equals(USER.PHONE) And U.MAIL.Equals(USER.MAIL) Then
                REMOVE_USER = U
                Exit For
            End If
        Next
        USERS.Remove(REMOVE_USER)
        USERS.Add(USER)
        Return True
    End Function
    'CHECK IF PASSWORD IS RIGHT'
    Public Function pass_right(USER As User) As Boolean
        Return pass_right(USER.MAIL, USER.PASS)
    End Function
    'CHECK IF PASSWORD IS RIGHT'
    Public Function pass_right(MAIL As String, PASS As String) As Boolean
        If String.IsNullOrEmpty(MAIL) Then
            Return False
        End If
        If String.IsNullOrEmpty(PASS) Then
            Return False
        End If
        MAIL = MAIL.ToLower
        For Each U As User In USERS
            If U.MAIL.Equals(MAIL) And U.PASS.Equals(PASS) Then
                Return True
            End If
        Next
        Return False
    End Function
    'CHECK IF MAIL IS RIGHT'
    Public Function mail_right(USER As User) As Boolean
        Return mail_right(USER.NAME, USER.MAIL)
    End Function
    Public Function mail_right(MAIL As String, PHONE As String) As Boolean
        If String.IsNullOrEmpty(PHONE) Then
            Return False
        End If
        If String.IsNullOrEmpty(MAIL) Then
            Return False
        End If
        MAIL = MAIL.ToLower
        For Each U As User In USERS
            If U.PHONE.Equals(PHONE) And U.MAIL.Equals(MAIL) Then
                Return True
            End If
        Next
        Return False
    End Function
    'REGISTER THE USER'
    Public Function register_user(REGISTER As register) As Boolean
        If String.IsNullOrEmpty(REGISTER.MailTB.Text) Then
            MessageBox.Show("Email-ul utilizatorului introdus de dumneavoastra nu este valid!", "Ëroare email utilizator", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return False
        End If
        If Not REGISTER.Valid.mail(False) Then
            MessageBox.Show("Email-ul introdus de dumneavoastra exista deja in baza de date!", "Ëroare email utilizator", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return False
        End If
        If Not REGISTER.Valid.password(False) Then
            MessageBox.Show("Parola introdusa de dumneavoastra nu este valida!", "Ëroare parola utilizator", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return False
        End If
        If Not REGISTER.Valid.user() Then
            MessageBox.Show("Numele utilizatorului introdus de dumneavoastra nu este valid!", "Ëroare nume utilizator", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return False
        End If
        If Not REGISTER.Valid.phone() Then
            MessageBox.Show("Telefonul introdus de dumneavoastra nu este valid!", "Ëroare telefon utilizator", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return False
        End If
        '--------------------------------------'
        Dim ROLE As Role = Role.USER
        Dim NAME = REGISTER.UserTB.Text
        Dim PHONE = REGISTER.PhoneTB.Text
        Dim PASSWORD = REGISTER.PassTB.Text
        Dim MAIL = REGISTER.MailTB.Text.ToLower
        Dim USERH As User = New User(NAME, PASSWORD, MAIL, PHONE, ROLE)
        'VALIDATE ERROR'
        If String.IsNullOrEmpty(USERH.NAME) Then
            Return False
        End If
        'VALIDATE MAIL'
        REGISTER.LoadingImg.Show()
        REGISTER.Update()
        If Not mailer.send_registercode(USERH.NAME, MAIL, REGISTER.Valid, REGISTER.LoadingImg) Then
            REGISTER.clear_fields()
            Return False
        End If
        REGISTER.clear_fields()
        MessageBox.Show("Inregistrare cu success, v-ati inregistrat ca si utilizatorul " + USERH.NAME + "!", "Inregistrare reusita", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        login.Show()
        REGISTER.Hide()
        'ADD USER IN THE LIST'
        USERS.Add(USERH)
        Return True
    End Function
    'LOGIN THE USER'
    Public Function login_user(LOGIN As login) As Boolean
        If String.IsNullOrEmpty(LOGIN.MailTB.Text) Then
            MessageBox.Show("Adresa de email a utilizatorului introdus de dumneavoastra nu este valid!", "Ëroare nume utilizator", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return False
        End If
        If Not LOGIN.Valid.mail(True) Then
            MessageBox.Show("Adresa de email a utilizatorului introdus de dumneavoastra nu exista in baza de date!", "Ëroare email utilizator", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return False
        End If
        If Not LOGIN.Valid.password(True) Then
            MessageBox.Show("Parola introdusa de dumneavoastra nu corespunde utilizatorului introdus!", "Ëroare parola utilizator", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return False
        End If
        '-----------------------------------'
        Dim USERH As User = user_by_mail(LOGIN.MailTB.Text)
        'VALIDATE ERROR'
        If String.IsNullOrEmpty(USERH.NAME) Then
            Return False
        End If
        LOGIN.clear_fields()
        MessageBox.Show("Autentificare cu success, v-ati conectat ca si utilizatorul " + USERH.NAME + "!", "Autentificare reusita", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        main_menu.Show()
        main_menu.USER = USERH
        main_menu.Update_Panel()
        aplicatia_settings.load_users()
        LOGIN.Hide()
        Return True
    End Function
End Class