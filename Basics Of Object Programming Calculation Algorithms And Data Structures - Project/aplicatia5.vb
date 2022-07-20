Imports System.Net
Imports System.IO
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

'APLICATIA 5 CLASS'
Public Class aplicatia5
    Dim SR As SearchResult
    Dim BC As New baseconverter
    Dim CUR_PAGE As Integer = 1
    Dim LAST_SEARCH As String = ""
    Dim DICTIONARY As New Dictionary(Of Object, Object)
    Dim LINK As String = "https://api.unsplash.com/search/photos/?client_id=lURSk-e6HHRvRmzkSD32XgcjcLWgmzw1QRYHj-PeKJM&per_page=9&query="
    'CLEAR THE FIELDS'
    Public Sub clear_fields()
        CUR_PAGE = 1
        hide_fields()
        TermenTB.Clear()
        LAST_SEARCH = ""
        ResultLbl.Text = ""
        GaleryPanel.Controls.Clear()
        Return
    End Sub
    'HIDE THE FIELDS'
    Public Sub hide_fields()
        JumpTB.Hide()
        LabelJump.Hide()
        NextPageBtn.Hide()
        PrevPageBtn.Hide()
        ErrorLbl.Text = ""
        Return
    End Sub
    'SHOW THE FIELDS'
    Public Sub show_fields()
        If SR.MAX_PAGES > 1 Then
            JumpTB.Show()
            LabelJump.Show()
            NextPageBtn.Show()
        End If
    End Sub
    'DELETE THE TEXTBOX TEXT'
    Private Sub DeleteFieldsBtn_Click(sender As Object, e As EventArgs) Handles DeleteSBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa stergi termenul introdus?", "Stergere termen", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            clear_fields()
            Me.Refresh()
        End If
        Return
    End Sub
    'BACK TO MAIN MENU'
    Private Sub MainMenuBtn_Click(sender As Object, e As EventArgs) Handles MainMenuBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa va intoarceti la meniul principal?", "Intoarcere la meniul principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            clear_fields()
            AP5CenterPanel.Hide()
            main_menu.hide_user_panel_anim()
            main_menu.CenterPanel.Show()
            main_menu.Size = New Size(New Point(840, 600))
            main_menu.ProfilePanel.Location = New Point(68, 75)
            Return
        End If
    End Sub
    'EXECUTE THE SEARCH METHOD'
    Private Function execute_search() As String
        Dim TEXT As String = TermenTB.Text
        '--------------------------------'
        TEXT = TEXT.Trim
        If String.IsNullOrWhiteSpace(TEXT) Then
            ErrorLbl.Text = "✗ Trebuie sa introduceti un termen inainte de a incepe cautarea."
            Return ""
        End If
        TEXT = TEXT.ToLower
        If TEXT.Equals(LAST_SEARCH) Then
            ErrorLbl.Text = "✗ Se pare ca ati cautat deja acest termen."
            Return ""
        End If
        Dim URL = LINK + TEXT + "&page=" + CUR_PAGE.ToString
        get_search_result(URL, TEXT, 1)
        Return URL
    End Function
    'ENTER TO START THE SEARCH'
    Private Sub SearchBar_key(SENDER As Object, EV As KeyPressEventArgs) Handles TermenTB.KeyPress
        If EV.KeyChar = ChrW(Keys.Enter) Then
            EV.Handled = True
            execute_search()
            Return
        End If
    End Sub
    'SEARCH BUTTON'
    Private Sub SearchBtn_Click(SENDER As Object, EV As EventArgs) Handles SearchBtn.Click
        execute_search()
        Return
    End Sub
    'JUMP BOX TEXT'
    Private Sub JumpBar_key(SENDER As Object, EV As KeyPressEventArgs) Handles JumpTB.KeyPress
        If EV.KeyChar = ChrW(Keys.Enter) Then
            EV.Handled = True
            Dim NUMBER As Integer
            Try
                NUMBER = Int(JumpTB.Text)
            Catch ex As Exception
                ErrorLbl.Text = "✗ Trebuie sa introduceti un numar in casuta, nu un text."
                Return
            End Try
            If NUMBER <= 0 Then
                SENDER.ForeColor = Color.LightCoral
                ErrorLbl.Text = "✗ Numarul introdus trebuie sa fie mai mare de 0."
                Return
            End If
            If NUMBER > SR.MAX_PAGES Then
                SENDER.ForeColor = Color.LightCoral
                ErrorLbl.Text = "✗ Numarul introdus depaseste numarul maxim de pagini, acesta fiind " + SR.MAX_PAGES.ToString + "."
                Return
            End If
            Dim URL = LINK + LAST_SEARCH + "&page=" + NUMBER.ToString
            get_search_result(URL, LAST_SEARCH, NUMBER)
            Return
        End If
    End Sub
    Private Sub JumpTB_TextChanged(sender As Object, e As EventArgs) Handles JumpTB.TextChanged
        Dim NUMBER As Integer
        Dim TEXT As String = sender.Text
        If String.IsNullOrEmpty(TEXT) Then
            ErrorLbl.Text = ""
            Return
        End If
        Try
            NUMBER = Int(TEXT)
            ErrorLbl.Text = ""
            sender.ForeColor = Color.Green
        Catch EX As Exception
            sender.ForeColor = Color.LightCoral
            ErrorLbl.Text = "✗ Trebuie sa introduceti un numar in casuta, nu un text."
        End Try
        If NUMBER <= 0 Then
            sender.ForeColor = Color.LightCoral
            ErrorLbl.Text = "✗ Numarul introdus trebuie sa fie mai mare de 0."
            Return
        End If
        If NUMBER > SR.MAX_PAGES Then
            sender.ForeColor = Color.LightCoral
            ErrorLbl.Text = "✗ Numarul introdus depaseste numarul maxim de pagini, acesta fiind " + SR.MAX_PAGES.ToString + "."
            Return
        End If
        Return
    End Sub
    'NEXT PAGE BUTTON'
    Private Sub NextPageBtn_Click(sender As Object, e As EventArgs) Handles NextPageBtn.Click
        Dim NEXT_P As Integer = (CUR_PAGE + 1)
        If NEXT_P > SR.MAX_PAGES Then
            ErrorLbl.Text = "✗ Ati ajuns la ultima pagina a cautari :("
            Return
        End If
        Dim URL = LINK + LAST_SEARCH + "&page=" + NEXT_P.ToString
        get_search_result(URL, LAST_SEARCH, NEXT_P)
        Return
    End Sub
    'PREV PAGE BUTTON'
    Private Sub PrevPageBtn_Click(sender As Object, e As EventArgs) Handles PrevPageBtn.Click
        Dim PREV_P As Integer = (CUR_PAGE - 1)
        If PREV_P < 1 Then
            ErrorLbl.Text = "✗ Sunteti deja la prima pagina a cautari!"
            Return
        End If
        Dim URL = LINK + LAST_SEARCH + "&page=" + PREV_P.ToString
        get_search_result(URL, LAST_SEARCH, PREV_P)
        Return
    End Sub
    'GET THE RESPONSE'
    Async Sub get_search_result(URL As String, TERMEN As String, PAGE_NUMBER As Integer)
        Using client As HttpClient = New HttpClient()
            Using response As HttpResponseMessage = Await client.GetAsync(URL)
                Using content As HttpContent = response.Content
                    Dim result As String = Await content.ReadAsStringAsync()
                    If String.IsNullOrWhiteSpace(result) Or result.Length < 50 Then
                        ErrorLbl.Text = "✗ Nici o imagine nu a fost gasita pentru aceasta cautare."
                        Return
                    End If
                    Try
                        hide_fields()
                        GaleryPanel.Hide()
                        GaleryPanel.Controls.Clear()
                        DICTIONARY = JsonConvert.DeserializeObject(Of Dictionary(Of Object, Object))(result)
                        SR = New SearchResult(DICTIONARY)
                    Catch EX As Exception
                        MessageBox.Show(EX.ToString)
                    End Try
                End Using
            End Using
        End Using
        'REDRAW THE SCREEN'
        Me.Refresh()
        CUR_PAGE = PAGE_NUMBER
        show_fields()
        LAST_SEARCH = TERMEN
        If CUR_PAGE > 1 Then
            PrevPageBtn.Show()
        Else
            PrevPageBtn.Hide()
        End If
        JumpTB.Clear()
        GaleryPanel.Show()
        ErrorLbl.Text = ""
        ResultLbl.Text = "(!) Arata rezultatele pentru termenul '" + TERMEN + "'. (Pagina " + CUR_PAGE.ToString + " din " + SR.MAX_PAGES.ToString + ")"
        MessageBox.Show("Cautarea pentru termenul '" + TERMEN + "' a fost efectuata cu succes, pagina " + CUR_PAGE.ToString + "/" + SR.MAX_PAGES.ToString + ".", "Cautare cu succes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Return
    End Sub
End Class
'SEARCH RESULT'
Public Class SearchResult
    Dim RESULTS As JArray
    Public FOUND As Integer = 0
    Public MAX_PAGES As Integer = 0
    Public Sub New(DIC As Dictionary(Of Object, Object))
        RESULTS = DIC.GetValueOrDefault("results")
        MAX_PAGES = Val(DIC.GetValueOrDefault("total_pages"))
#Disable Warning SYSLIB0014 ' Type or member is obsolete
        Using CLIENT As New WebClient()
#Enable Warning SYSLIB0014 ' Type or member is obsolete
            For I = 0 To RESULTS.Count - 1 Step +1
                Try
                    Dim NAME As String = RESULTS.SelectToken("[" + I.ToString + "].id").ToString
                    Dim URL As String = RESULTS.SelectToken("[" + I.ToString + "].urls.regular").ToString
                    Dim tImage As Bitmap = Image.FromStream(New MemoryStream(CLIENT.DownloadData(URL)))
                    Dim GI As New Galery_Image_Holder(NAME, tImage)
                    FOUND += 1
                Catch EX As Exception
                    MessageBox.Show(EX.Message)
                End Try
            Next
        End Using
    End Sub
End Class
Public Class Galery_Image_Holder
    Inherits Panel
    Dim FILE_NAME As String
    Friend WithEvents DescarcaBtn As New Button
    Friend WithEvents BoxImage As New PictureBox
    Public Sub New(NAME As String, IMAGE As Bitmap)
        FILE_NAME = NAME.Trim
        Me.TabIndex = 1
        Me.Name = "Galery_Image_Hold"
        Me.Size = New Size(320, 320)
        Me.Controls.Add(Me.DescarcaBtn)
        Me.Controls.Add(Me.BoxImage)
        Me.BackColor = Color.FromArgb(210, 0, 0, 0)
        '
        'BoxImage
        '
        Me.BoxImage.TabIndex = 0
        Me.BoxImage.TabStop = False
        Me.BoxImage.Name = "BoxImage"
        Me.BoxImage.BackgroundImage = IMAGE
        Me.BoxImage.Size = New Size(314, 314)
        Me.BoxImage.Location = New Point(3, 3)
        Me.BoxImage.BackColor = Color.Transparent
        Me.BoxImage.BackgroundImageLayout = ImageLayout.Stretch
        '
        'DescarcaBtn
        '
        Me.DescarcaBtn.TabIndex = 1
        Me.DescarcaBtn.Text = "DESCARCA"
        Me.DescarcaBtn.Name = "DescarcaBtn"
        Me.DescarcaBtn.FlatAppearance.BorderSize = 0
        Me.DescarcaBtn.FlatStyle = FlatStyle.Flat
        Me.DescarcaBtn.Size = New Size(65, 65)
        Me.DescarcaBtn.ForeColor = Color.WhiteSmoke
        Me.DescarcaBtn.BackColor = Color.FromArgb(25, Color.Black)
        Me.DescarcaBtn.Location = New Point(250, 5)
        Me.DescarcaBtn.UseVisualStyleBackColor = False
        Me.DescarcaBtn.TextAlign = ContentAlignment.BottomCenter
        Me.DescarcaBtn.BackgroundImageLayout = ImageLayout.Center
        Me.DescarcaBtn.BackgroundImage = Global.BPO___Proiect___Seminar.My.Resources.Resources.download_icon
        Me.DescarcaBtn.Font = New Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        'ADD TO PARENT'
        aplicatia5.GaleryPanel.Controls.Add(Me)
        Return
    End Sub
    'SAVE THE IMAGE'
    Private Sub DownloadBTN_Click(sender As Object, e As EventArgs) Handles DescarcaBtn.MouseClick
        Dim FD = New SaveFileDialog
        FD.DefaultExt = "png"
        FD.FileName = FILE_NAME
        FD.AddExtension = True
        FD.Filter = "PNG Files (*.png)|*.png"
        Dim R = FD.ShowDialog()
        If R = DialogResult.OK Then
            Dim FN = FD.FileName
            If (String.IsNullOrEmpty(FN)) Then
                Return
            End If
            Dim fs As Stream = FD.OpenFile()
            Dim FI As FileInfo = New FileInfo(FN)
            BoxImage.BackgroundImage.Save(fs, Imaging.ImageFormat.Png)
            MessageBox.Show("Imaginea '" + FN + "' a fost salvata cu success in directorul '" + FI.DirectoryName + "'.", "Imagine descarcata", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            fs.Close()
            Dim RES = MessageBox.Show("Doriti sa vizualizati imaginea descarcata?", "Vizualizare imagine", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If RES = DialogResult.Yes Then
                open_download_file(FN)
            End If
        End If
        Return
    End Sub
    'OPEN THE RESULT FILE'
    Private Sub open_download_file(FILE_NAME As String)
        If Not File.Exists(FILE_NAME) Then
            aplicatia5.ErrorLbl.Text = "✗ Fisierul nu a putut fi gasit."
            Return
        End If
        Dim FILE_P As New Process
        '-----------------------'
        FILE_P.StartInfo.FileName = FILE_NAME
        FILE_P.StartInfo.UseShellExecute = True
        FILE_P.StartInfo.RedirectStandardOutput = False
        '----------------------------------------------'
        FILE_P.Start()
        FILE_P.Dispose()
        MessageBox.Show("Fisierul '" + FILE_NAME + "' a fost deschis cu succes.", "Deschidere fisier descarcat", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Return
    End Sub
End Class