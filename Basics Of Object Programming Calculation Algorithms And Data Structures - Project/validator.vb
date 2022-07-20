Imports System.Text
Imports System.Text.RegularExpressions

Public Class validator
    Dim PassTB, UserTB, MailTB, PhoneTB As TextBox
    Dim UserErrorLbl, PassErrorLbl, MailErrorLbl, PhoneErrorLbl As Label
    Public Sub New(UserT As TextBox, PassT As TextBox, UserErrorLb As Label, PassErrorLb As Label, Optional MailErrorLb As Label = Nothing, Optional MAILT As TextBox = Nothing, Optional PhoneErrorLb As Label = Nothing, Optional PHONET As TextBox = Nothing)
        PassTB = PassT
        UserTB = UserT
        MailTB = MAILT
        PhoneTB = PHONET
        UserErrorLbl = UserErrorLb
        PassErrorLbl = PassErrorLb
        MailErrorLbl = MailErrorLb
        PhoneErrorLbl = PhoneErrorLb
    End Sub
    'VALIDATE PHONE'
    Public Function phone() As Boolean
        Dim TEXT As String = PhoneTB.Text
        TEXT = TEXT.Trim
        PhoneTB.Text = TEXT
        Dim asciiBytesCount = Encoding.ASCII.GetByteCount(TEXT)
        Dim unicodBytesCount = Encoding.UTF8.GetByteCount(TEXT)
        If String.IsNullOrEmpty(TEXT) Then
            PhoneErrorLbl.Text = "✗ Telefonul utilizatorului nu poate fi gol."
            Return False
        End If
        If TEXT.Length < 10 Then
            PhoneErrorLbl.Text = "✗ Telefonul utilizatorului nu poate fi mai mic de 10 numere."
            Return False
        End If
        If TEXT.Length > 10 Then
            PhoneErrorLbl.Text = "✗ Telefonul utilizatorului nu poate fi mai mare de 10 numere."
            Return False
        End If
        If asciiBytesCount <> unicodBytesCount Then
            MailErrorLbl.Text = "✗ Telefonul utilizatorului nu poate sa contina simboluri."
            Return False
        End If
        If TEXT.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1 Then
            PhoneErrorLbl.Text = "✗ Telefonul utilizatorului nu poate sa contina caractere speciale."
            Return False
        End If
        If Not TEXT.StartsWith("0") Then
            PhoneErrorLbl.Text = "✗ Telefonul utilizatorului trebuie sa inceapa cu '0'."
            Return False
        End If
        Dim TEL As Integer
        Try
            TEL = Int(TEXT)
        Catch ex As Exception
            PhoneErrorLbl.Text = "✗ Telefonul utilizatorului trebuie sa fie format numai din numere."
            Return False
        End Try
        PhoneErrorLbl.Text = ""
        Return True
    End Function
    'VALIDATE MAIL'
    Public Function mail(CHECKDB As Boolean, Optional PASSCHECK As Boolean = False) As Boolean
        Dim TEXT As String = MailTB.Text
        TEXT = TEXT.Trim
        MailTB.Text = TEXT
        Dim asciiBytesCount = Encoding.ASCII.GetByteCount(TEXT)
        Dim unicodBytesCount = Encoding.UTF8.GetByteCount(TEXT)
        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailAddressMatch As Match = Regex.Match(TEXT, pattern)
        If String.IsNullOrEmpty(TEXT) Then
            MailErrorLbl.Text = "✗ Email-ul utilizatorului nu poate fi gol."
            Return False
        End If
        If TEXT.Length <= 5 Then
            MailErrorLbl.Text = "✗ Email-ul utilizatorului trebuie sa fie mai mare de 5 caractere."
            Return False
        End If
        If asciiBytesCount <> unicodBytesCount Then
            MailErrorLbl.Text = "✗ Email-ul utilizatorului nu poate sa contina simboluri."
            Return False
        End If
        Dim CM = TEXT.ToLower
        Dim F_A As Boolean = False
        Dim LIST_ALLOWED_ADDRESS = New String() {"@student.rau.ro", "@profesor.rau.ro"}
        For Each EMAIL As String In LIST_ALLOWED_ADDRESS
            If CM.EndsWith(EMAIL) Then
                F_A = True
                Exit For
            End If
        Next
        If Not F_A Then
            MailErrorLbl.Text = "✗ Email-ul utilizatorului trebuie sa se termine cu '@student/profesor.rau.ro'."
            Return False
        End If
        If Not PASSCHECK Then
            If CHECKDB And Not login.DATABASE.mail_exists(TEXT) Then
                MailErrorLbl.Text = "✗ Acest email nu exista in baza de date."
                Return False
            ElseIf Not CHECKDB And login.DATABASE.mail_exists(TEXT) Then
                MailErrorLbl.Text = "✗ Acest email exista deja in baza de date."
                Return False
            End If
        End If
        If emailAddressMatch.Success Then
            MailErrorLbl.Text = ""
            Return True
        Else
            MailErrorLbl.Text = "✗ Email-ul utilizatorului trebuie sa contina simbolurile '@' si '.'"
            Return False
        End If
    End Function
    'VALIDATE PASSWORD'
    Public Function password(CHECKDB As Boolean) As Boolean
        Dim TEXT As String = PassTB.Text
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        '=============================================================='
        TEXT = TEXT.Trim
        PassTB.Text = TEXT
        If String.IsNullOrEmpty(TEXT) Then
            PassErrorLbl.Text = "✗ Parola nu poate fi goala."
            Return False
        End If
        If TEXT.Length <= 6 Then
            PassErrorLbl.Text = "✗ Parola trebuie sa fie mai mare de 6 caractere."
            Return False
        End If
        If TEXT.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1 Then
            PassErrorLbl.Text = "✗ Parola nu poate sa contina caractere speciale."
            Return False
        End If
        If upper.Matches(TEXT).Count < 1 Then
            PassErrorLbl.Text = "✗ Parola trebuie sa contina cel putin o litera mare."
            Return False
        End If
        If number.Matches(TEXT).Count < 2 Then
            PassErrorLbl.Text = "✗ Parola trebuie sa contina 2 numere."
            Return False
        End If
        If CHECKDB And Not login.DATABASE.pass_right(UserTB.Text, TEXT) Then
            PassErrorLbl.Text = "✗ Aceasta parola nu corespunde utilizatorului introdus."
            Return False
        End If
        PassErrorLbl.Text = ""
        Return True
    End Function
    'VALIDATE USER'
    Public Function user() As Boolean
        Dim TEXT As String = UserTB.Text
        TEXT = TEXT.Trim
        UserTB.Text = TEXT
        Dim asciiBytesCount = Encoding.ASCII.GetByteCount(TEXT)
        Dim unicodBytesCount = Encoding.UTF8.GetByteCount(TEXT)
        If String.IsNullOrEmpty(TEXT) Then
            UserErrorLbl.Text = "✗ Numele utilizatorului nu poate fi gol."
            Return False
        End If
        If TEXT.Length <= 5 Then
            UserErrorLbl.Text = "✗ Numele utilizatorului trebuie sa fie mai mare de 5 caractere."
            Return False
        End If
        If TEXT.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1 Then
            UserErrorLbl.Text = "✗ Numele utilizatorului nu poate sa contina caractere speciale."
            Return False
        End If
        If asciiBytesCount <> unicodBytesCount Then
            UserErrorLbl.Text = "✗ Numele utilizatorului nu poate sa contina simboluri."
            Return False
        End If
        UserErrorLbl.Text = ""
        Return True
    End Function
End Class