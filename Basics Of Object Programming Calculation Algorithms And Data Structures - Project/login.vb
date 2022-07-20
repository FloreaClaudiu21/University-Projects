Imports System.Runtime.InteropServices
Imports System.IO

Public Class login
    Public Valid As validator
    Public CONSOLE As New console
    Public DATABASE As New database
    Public EXTERNAL As New ExternalFile
    Public Const HTBOTTOM As Integer = 15
    Public Const HT_CAPTION As Integer = 2
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    'CLOSE THE PROGRAM'
    Private Sub login_Close(sender As Object, e As EventArgs) Handles MyBase.Closed, MyBase.Disposed
        CONSOLE.dispose()
        DATABASE.disconnect()
        'STERGE FISIERUL CU ANALIZA TEXTULUI'
        If File.Exists(EXTERNAL.ANALIZA_FILE_NAME) Then
            File.Delete(EXTERNAL.ANALIZA_FILE_NAME)
        End If
        Process.GetProcessesByName("BPO-Proiect-Seminar")(0).Kill()
        Return
    End Sub
    'LOAD THE PROGRAM'
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DATABASE.connect()
        Valid = New validator(MailTB, PassTB, MailErrorLbl, PassErrorLbl, MailErrorLbl, MailTB)
    End Sub
    'CLOSE THE PROGRAM FROM BUTTON'
    Private Sub CloseBtn_Click_1(sender As Object, e As EventArgs) Handles CloseBtn.Click
        CONSOLE.dispose()
        DATABASE.disconnect()
        Me.Close()
        Return
    End Sub
    'CLEAR THE FORM FIELDS'
    Public Function clear_fields() As Boolean
        MailTB.Clear()
        PassTB.Clear()
        MailErrorLbl.Text = ""
        PassErrorLbl.Text = ""
        UtLbl.ForeColor = Color.White
        PrlLbl.ForeColor = Color.White
        Return True
    End Function
    'MAIL TB'
    Private Sub MailTB_Text(sender As Object, e As EventArgs) Handles MailTB.TextChanged
        Dim CHECK = Valid.mail(True)
        If CHECK Then
            UtLbl.ForeColor = Color.Green
            MailTB.ForeColor = Color.Green
            ForgotPassBtn.Enabled = True
        Else
            UtLbl.ForeColor = Color.LightCoral
            MailTB.ForeColor = Color.LightCoral
            ForgotPassBtn.Enabled = False
        End If
    End Sub
    'PASS TB'
    Private Sub PassTB_Enter(sender As Object, e As EventArgs) Handles PassTB.TextChanged
        Dim CHECK = Valid.password(True)
        If CHECK Then
            PrlLbl.ForeColor = Color.Green
            PassTB.ForeColor = Color.Green
        Else
            PassTB.ForeColor = Color.Red
            PrlLbl.ForeColor = Color.LightCoral
        End If
    End Sub
    'REGISTER BTN'
    Private Sub RegisterBtn_Hover(sender As Object, e As EventArgs) Handles RegisterBtn.MouseEnter
        Dim FONT = RegisterBtn.Font
        RegisterBtn.ForeColor = Color.Magenta
        RegisterBtn.Font = New Font(FONT, FontStyle.Underline)
    End Sub
    Private Sub RegisterBtn_Leave(sender As Object, e As EventArgs) Handles RegisterBtn.MouseLeave
        Dim FONT = RegisterBtn.Font
        RegisterBtn.ForeColor = Color.CornflowerBlue
        RegisterBtn.Font = New Font(FONT, FontStyle.Regular)
    End Sub
    'FORGOT PASSWORD BTN'
    Private Sub PassForgotBtn_Hover(sender As Object, e As EventArgs) Handles ForgotPassBtn.MouseEnter
        Dim FONT = ForgotPassBtn.Font
        ForgotPassBtn.ForeColor = Color.Magenta
        ForgotPassBtn.Font = New Font(FONT, FontStyle.Underline)
    End Sub
    Private Sub PassForgotBtn_Leave(sender As Object, e As EventArgs) Handles ForgotPassBtn.MouseLeave
        Dim FONT = ForgotPassBtn.Font
        ForgotPassBtn.ForeColor = Color.White
        ForgotPassBtn.Font = New Font(FONT, FontStyle.Regular)
    End Sub
    'WINDOWS SHARED FUNCTIONS FOR MOVING WINDOW'
    <DllImport("User32")> Public Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer, bShow As Boolean) As Boolean
    End Function
    <DllImport("User32")> Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImport("User32")> Public Shared Function ReleaseCapture() As Boolean
    End Function
    'MOVE THE WINDOW AROUND'
    Private Sub Form_MouseDown(sender As Object, EV As System.Windows.Forms.MouseEventArgs) Handles mainpanel.MouseDown, TitleLabel.MouseDown, IconBox.MouseDown
        If (EV.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            Return
        End If
    End Sub
    'LOGIN THE USER'
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        DATABASE.login_user(Me)
        Return
    End Sub
    'GO TO THE REGISTER PAGE'
    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Me.Hide()
        clear_fields()
        register.Show()
        Return
    End Sub
    'GENERATE THE PASSWORD AND SEND THE MAIL'
    Private Function Hint_Phone(PHONE As String) As String
        If String.IsNullOrEmpty(PHONE) Or PHONE.Length < 10 Then
            Return String.Empty
        End If
        Dim TEXT1 = ""
        Dim TEXT = PHONE
        Dim L = TEXT.Length
        For I As Integer = 0 To L Step +1
            If I > 3 Then
                TEXT1 += "#"
            Else
                TEXT1 += TEXT.ElementAt(I)
            End If
        Next
        Return TEXT1
    End Function
    'CLICK ON THE FORGOT PASSWORD BUTTON'
    Private Sub ForgotPassBtn_Click(sender As Object, e As EventArgs) Handles ForgotPassBtn.Click
        If Not ForgotPassBtn.Enabled Then
            Return
        End If
        Dim EMAIL As String = MailTB.Text
        EMAIL = EMAIL.ToLower
        If EMAIL.Equals(DATABASE.ADMIN_USER.MAIL) Then
            MessageBox.Show("Puteti afla parola acestui cont numai daca accesati baza de date si cautati utilizatorul '" + EMAIL + "'.", "Eroare schimbare parola utilizator general", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return
        End If
        Dim TRIES As Integer = 3
        Dim USERDATA As User = DATABASE.user_by_mail(MailTB.Text)
        Do While TRIES > 0
            Dim PHONE_IN As String = InputBox("Introduceti numarul de telefon asociat acestui email, indiciu " + Hint_Phone(USERDATA.PHONE) + " ,mai aveti " + TRIES.ToString + " incercari ramase.", "Introducere numar de telefon asociat contului")
            If PHONE_IN.ToLower.Equals(USERDATA.PHONE) Then
                Me.LoadingImg.Show()
                Me.Update()
                DATABASE.mailer.send_generatedpassword(USERDATA, Me.LoadingImg)
                Return
            End If
            TRIES -= 1
        Loop
        MessageBox.Show("Din pacate nu ati reusit sa introduceti numarul de telefon asociat acestui email.", "Numarul de telefon a fost introdus gresit", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return
    End Sub
    'ENTER TO LOGIN'
    Private Sub loginbtn_key(sender As Object, e As KeyPressEventArgs) Handles PassTB.KeyPress, MailTB.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            DATABASE.login_user(Me)
            Return
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keydata As Keys) As Boolean
        Dim R = CONSOLE.key_process(msg, keydata)
        If Not R Then
            Return MyBase.ProcessCmdKey(msg, keydata)
        Else
            Return True
        End If
    End Function
End Class
Public Enum Role As Integer
    USER = 0
    ADMIN = 1
End Enum
'CREATE THE USER INFO'
Public Structure User
    Public ROL As Role
    Public NAME, PASS, MAIL, PHONE As String
    Public Sub New(NAM As String, PAS As String, MAI As String, PHON As String, ROLU As Role)
        ROL = ROLU
        NAME = NAM
        PASS = PAS
        MAIL = MAI
        PHONE = PHON
    End Sub
End Structure