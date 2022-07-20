Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.ApplicationServices

Public Class aplicatia_comuna
    'EXTERNA FILE BUTTON CLICK'
    Private Sub ExternalFileBtn_Click(SENDER As Object, EV As EventArgs) Handles OpenFileBtn.Click
        login.EXTERNAL.open()
        login.EXTERNAL.read_display()
        Return
    End Sub
    'ANALIZE BUTTON CLICK'
    Private Sub Analyse_Click(sender As Object, e As EventArgs) Handles AnalizaBtn.Click
        login.EXTERNAL.analyze()
        Return
    End Sub
    'OPEN FILE WITH RESULT BUTTON CLICK'
    Private Sub OPENREZBtn_Click(sender As Object, e As EventArgs) Handles OPENREZBtn.Click
        login.EXTERNAL.open_result_file()
        Return
    End Sub
    'DELETE THE TEXTBOX TEXT'
    Private Sub DeleteTextBtn_Click(sender As Object, e As EventArgs) Handles DeleteTextBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa stergi textul introdus?", "Stergere text introdus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            TextTB.Clear()
            ErrorLbl.Text = ""
            Me.Refresh()
        End If
        Return
    End Sub
    'BACK TO MAIN MENU'
    Private Sub MainMenuBtn_Click(sender As Object, e As EventArgs) Handles MainMenuBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa va intoarceti la meniul principal?", "Intoarcere la meniul principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            TextTB.Clear()
            ErrorLbl.Text = ""
            APCCenterPanel.Hide()
            main_menu.hide_user_panel_anim()
            main_menu.CenterPanel.Show()
            main_menu.Size = New Size(New Point(840, 600))
            main_menu.ProfilePanel.Location = New Point(68, 75)
            Return
        End If
    End Sub
End Class
Public Class ExternalFile
    Dim FILE_NAME As String = ""
    Public ANALIZA_FILE_NAME As String = Environment.CurrentDirectory + "\rezultat_analiza_text.txt"
    Public Class Pair
        Implements IComparer(Of Pair)
        Dim FIRST As String
        Dim SECOND As Integer
        Public Sub New(F As String, Optional S As Integer = 0)
            FIRST = F
            SECOND = S
        End Sub
        Public Shared Function find(LIST As String(), FINDS As String, Optional BYWORD As Boolean = False, Optional BYCHAR As Boolean = False) As Integer
            Dim COUNT = 0
            For Each LINIE As String In LIST
                If BYCHAR Then
                    For Each CH As String In LINIE
                        If CH.Equals(FINDS) Then
                            COUNT += 1
                        End If
                    Next
                ElseIf BYWORD Then
                    Dim WS As String() = LINIE.Split(" ")
                    For Each WORD As String In WS
                        If WORD.ToLower.StartsWith(FINDS.ToLower) Then
                            COUNT += 1
                        End If
                    Next
                Else
                    Dim FZ As String() = LINIE.Split(".")
                    For Each FRAZE As String In FZ
                        If FRAZE.ToLower.StartsWith(FINDS.ToLower) Then
                            COUNT += 1
                        End If
                    Next
                End If
            Next
            Return COUNT
        End Function
        'ADD NEW PAIR TO A LIST'
        Public Shared Function add(LIST As List(Of Pair), PAIR As Pair) As Boolean
            Dim FOUND = False
            For Each EL As Pair In LIST
                If EL.FIRST.Equals(PAIR.FIRST) Then
                    FOUND = True
                    Exit For
                End If
            Next
            If FOUND Then
                Return False
            Else
                LIST.Add(PAIR)
                Return True
            End If
        End Function
        Public Shared Function to_string(LIST As List(Of Pair)) As StringBuilder
            Dim SB = New StringBuilder()
            For Each PAIR As Pair In LIST
                SB = SB.Append(New String(PAIR.FIRST + "=> " + PAIR.SECOND.ToString) + Environment.NewLine)
            Next
            Return SB
        End Function
        Private Function IComparer_Compare(x As Pair, y As Pair) As Integer Implements IComparer(Of Pair).Compare
            If x.SECOND >= y.SECOND Then
                Return x.SECOND
            ElseIf x.SECOND < y.SECOND Then
                Return y.SECOND
            End If
            Return y.SECOND
        End Function
    End Class
    'OPEN THE FILE DIALOG'
    Public Sub open()
        aplicatia_comuna.TextOpenFile.FileName = String.Empty
        aplicatia_comuna.TextOpenFile.InitialDirectory = "C:\"
        aplicatia_comuna.TextOpenFile.Title = "Selectati un fisier pentru a analiza textul acestuia..."
        Dim RESULT As DialogResult = aplicatia_comuna.TextOpenFile.ShowDialog()
        If RESULT = DialogResult.OK Then
            FILE_NAME = aplicatia_comuna.TextOpenFile.FileName
        End If
        Return
    End Sub
    'OPEN THE RESULT FILE'
    Public Sub open_result_file()
        If Not File.Exists(ANALIZA_FILE_NAME) Then
            aplicatia_comuna.ErrorLbl.Text = "✗ Trebuie sa executati o analiza a textului inainte de a deschide fisierul cu rezultatul."
            Return
        End If
        Dim FILE_P As New Process
        '-----------------------'
        FILE_P.StartInfo.UseShellExecute = True
        FILE_P.StartInfo.FileName = ANALIZA_FILE_NAME
        FILE_P.StartInfo.RedirectStandardOutput = False
        '----------------------------------------------'
        FILE_P.Start()
        FILE_P.Dispose()
        MessageBox.Show("Fisierul '" + ANALIZA_FILE_NAME + "' a fost deschis cu succes.", "Deschidere fisier cu rezultat", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Return
    End Sub
    'READ THE FILE LINES AND DISPLAY IN THE BOX'
    Public Sub read_display()
        If String.IsNullOrEmpty(FILE_NAME) Then
            Return
        End If
        Dim LINES = File.ReadAllLines(FILE_NAME)
        If LINES.Length <= 0 Then
            aplicatia_comuna.ErrorLbl.Text = "✗ Se pare ca acest fisier nu contine nici un text si este gol, selectati alt fisier text."
            Return
        End If
        aplicatia_comuna.TextTB.Lines = LINES
        Return
    End Sub
    'ANALIZE THE LINES'
    Public Sub analyze()
        Dim IS_E As Boolean = True
        Dim LINES = aplicatia_comuna.TextTB.Lines
        Dim FRAZE_L, CUVINTE_L, CARACTERE_L As New List(Of Pair)
        '------------------------------------------------------'
        If LINES.Length <= 0 Then
            aplicatia_comuna.ErrorLbl.Text = "✗ Trebuie sa introduceti un text inainte de a putea fi analizat."
            Return
        End If
        'ITERATE AND CHECK IF EMPTY'
        For Each LINIE As String In LINES
            If Not String.IsNullOrWhiteSpace(LINIE) Then
                IS_E = False
                Exit For
            End If
        Next
        'EMPTY TEXT BOX'
        If IS_E Then
            aplicatia_comuna.ErrorLbl.Text = "✗ Trebuie sa introduceti un text valid, nu doar spatii goale, inainte de a putea fi analizat."
            Return
        End If
        'LOOP EACH LINE FROM TEXT BOX'
        For Each LINIE As String In LINES
            'SEPARATE FRAZE'
            Dim FRAZE_SP As String() = LINIE.Split(".")
            For Each FRAZE As String In FRAZE_SP
                If Not String.IsNullOrWhiteSpace(FRAZE) Then
                    Pair.add(FRAZE_L, New Pair(FRAZE.ToLower, Pair.find(LINES, FRAZE)))
                End If
            Next
            'SEPARATE WORDS'
            Dim WORD_SP As String() = LINIE.Split(" ")
            For Each WORD As String In WORD_SP
                If Not String.IsNullOrWhiteSpace(WORD) Then
                    Pair.add(CUVINTE_L, New Pair(WORD.ToLower, Pair.find(LINES, WORD, True)))
                    'SEPARATE CARACTERS'
                    For Each CARACTER As String In WORD
                        Pair.add(CARACTERE_L, New Pair(CARACTER, Pair.find(LINES, CARACTER, False, True)))
                    Next
                End If
            Next
        Next
        'RESULT MESSAGE'
        If File.Exists(ANALIZA_FILE_NAME) Then
            File.Delete(ANALIZA_FILE_NAME)
        End If
        Dim RESULT As StringBuilder = New StringBuilder()
        If FRAZE_L.Count <= 0 Or CUVINTE_L.Count <= 0 Or CARACTERE_L.Count <= 0 Then
            Return
        End If
        RESULT = RESULT.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-" + Environment.NewLine)
        RESULT = RESULT.Append("LISTA DE FRAZE => NUMAR DE GASIRI " + Environment.NewLine)
        RESULT = RESULT.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-" + Environment.NewLine)
        RESULT = RESULT.Append(Pair.to_string(FRAZE_L))
        RESULT = RESULT.Append(Environment.NewLine)
        RESULT = RESULT.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=" + Environment.NewLine)
        RESULT = RESULT.Append("LISTA DE CUVINTE => NUMAR DE GASIRI " + Environment.NewLine)
        RESULT = RESULT.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=" + Environment.NewLine)
        RESULT = RESULT.Append(Pair.to_string(CUVINTE_L))
        RESULT = RESULT.Append(Environment.NewLine)
        RESULT = RESULT.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=" + Environment.NewLine)
        RESULT = RESULT.Append("LISTA DE CARACTERE => NUMAR DE GASIRI " + Environment.NewLine)
        RESULT = RESULT.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=" + Environment.NewLine)
        RESULT = RESULT.Append(Pair.to_string(CARACTERE_L))
        RESULT = RESULT.Append(Environment.NewLine)
        'SHOW RESULT IN THE FILE'
        aplicatia_comuna.ErrorLbl.Text = ""
        My.Computer.FileSystem.WriteAllText(ANALIZA_FILE_NAME, RESULT.ToString, False)
        Dim R As DialogResult = MessageBox.Show("Rezultatul a fost generat cu succes, doriti sa deschideti fisierul cu rezultatele?", "Analiza reusita", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'OPEN THE FILE USING THE DEFAULT SYSTEM EDITOR'
        If R = DialogResult.Yes Then
            open_result_file()
        End If
        Return
    End Sub
End Class

