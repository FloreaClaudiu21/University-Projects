Imports System.Net.Mail

Public Class mailer
    Dim SERVER As New SmtpClient
    Const MAIN_MAIL As String = "florea.rf.claudiuvalentin21@student.rau.ro"
    'NEW INSTANCE'
    Public Sub New()
        SERVER.Port = 587
        SERVER.EnableSsl = True
        SERVER.Host = "smtp.office365.com"
        SERVER.UseDefaultCredentials = False
        SERVER.Credentials = New Net.NetworkCredential(MAIN_MAIL, "Asasiasa0")
        Return
    End Sub
    'SEND THE REGISTRATION CODE'
    Public Function send_registercode(USER As String, MAILTO As String, VALID As validator, IMAGE As PictureBox)
        'CHECK IF MAIL IS VALID'
        If Not VALID.mail(False, True) Then
            MessageBox.Show("Codul de inregistrare a contului nu a fost trimis deoarece mail-ul introdus nu este valid!", "Codul de inregistrare nu a fost trimis", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Dim TRIES As Integer = 3
        Dim MAIL = New MailMessage()
        Dim RANDOM_KEY As Integer = CInt(Math.Ceiling(Rnd() * 100000)) + 1
        For I As Integer = 0 To I < 2 Step +1
            RANDOM_KEY += CInt(Math.Ceiling(Rnd() * 100000)) + 1
        Next
        '-----------------------------------------------------------------'
        Try
            MAIL.To.Add(MAILTO)
            MAIL.IsBodyHtml = False
            MAIL.From = New MailAddress(MAIN_MAIL)
            MAIL.Subject = "Proiect BPO - Florea Claudiu - Codul de autentificare"
            MAIL.Body = "Bun venit " + USER + ", ma bucur ca doresti sa iti creezi un cont! Codul de autentificare generat de catre program este '" + RANDOM_KEY.ToString + "'. O zi buna :)"
            SERVER.Send(MAIL)
            MessageBox.Show("Codul generat de catre program a fost trimis cu success la adresa de mail '" + MAILTO + "', accesati email-ul si copiati codul generat aici, pentru a finaliza inregistrarea.", "Codul de autentificare a fost trimis", MessageBoxButtons.OK, MessageBoxIcon.Information)
            While TRIES > 0
                Dim CODUL_IN As String = InputBox("Introduceti codul de autentificare generat de catre program, mai aveti " + TRIES.ToString + " incercari ramase.", "Introducere cod autentificare")
                If CODUL_IN.Equals(RANDOM_KEY.ToString) Then
                    Return True
                End If
                TRIES -= 1
            End While
            IMAGE.Hide()
            MessageBox.Show("Din pacate nu ati reusit sa introduceti corect codul de autentificare, incercati din nou :(", "Codul de autentificare a fost introdus gresit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Catch EX As Exception
            IMAGE.Hide()
            MessageBox.Show("Eroare trimitere mail: " + EX.Message, "Codul de inregistrare a contului nu a fost trimis deoarece a aparut o eroare", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    'SEND THE NEW GENERATED PASSWORD'
    Public Function send_generatedpassword(USER As User, IMAGE As PictureBox)
        Dim NR As Integer = 0
        Dim MAIL = New MailMessage()
        For I As Integer = 0 To I < 2 Step +1
            NR += Int((100000 * Rnd()) + 1)
        Next
        Dim RANDOM_PASS As String = "RandomP" + NR.ToString
        '--------------------------------------------------'
        Try
            MAIL.To.Add(USER.MAIL)
            MAIL.IsBodyHtml = False
            MAIL.From = New MailAddress(MAIN_MAIL)
            MAIL.Subject = "Proiect BPO - Florea Claudiu - Parola noua generata"
            MAIL.Body = "Salut " + USER.NAME + ", se pare ca ti-ai uitat parola! O noua parola a fost generata de catre program, aceasta este '" + RANDOM_PASS + "', logheaza-te cu aceasta. O zi buna :)"
            SERVER.Send(MAIL)
            MessageBox.Show("Parola generata de catre program a fost trimisa cu success la adresa de mail '" + USER.MAIL + "', accesati email-ul si logati-va folosind aceea parola.", "Parola noua a fost trimisa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            IMAGE.Hide()
            USER.PASS = RANDOM_PASS
            login.DATABASE.pass_replace(USER)
            Return False
        Catch EX As Exception
            IMAGE.Hide()
            MessageBox.Show("Eroare trimitere mail: " + EX.Message, "Parola noua generata a contului nu a fost trimisa deoarece a aparut o eroare...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
