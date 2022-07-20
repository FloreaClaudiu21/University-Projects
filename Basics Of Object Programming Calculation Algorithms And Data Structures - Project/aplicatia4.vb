Imports System.Text

Public Class aplicatia4
    Dim BC As New baseconverter
    'CLEAR THE FIELDS'
    Public Sub clear_fields()
        NumarTB.Clear()
        ErrorLbl.Text = ""
        ResultBox.Clear()
        ToBazaCB.SelectedIndex = 8
        FromBazaCB.SelectedIndex = 0
        Return
    End Sub
    'DELETE THE TEXTBOX TEXT'
    Private Sub DeleteFieldsBtn_Click(sender As Object, e As EventArgs) Handles DeleteVectorBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa stergi numarul introdus?", "Stergere numar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
            AP4CenterPanel.Hide()
            main_menu.hide_user_panel_anim()
            main_menu.CenterPanel.Show()
            main_menu.Size = New Size(New Point(840, 600))
            main_menu.ProfilePanel.Location = New Point(68, 75)
            Return
        End If
    End Sub
    'VALIDATE IF THE NUMBER CORESPONDS WITH THE BASE'
    Private Sub Fields_TextChanged(SENDER As Object, EV As EventArgs) Handles NumarTB.TextChanged
        Dim TEXT As String = SENDER.Text
        Dim BASE_FROM As Byte = FromBazaCB.SelectedItem
        If String.IsNullOrEmpty(TEXT) Then
            ErrorLbl.Text = ""
            Return
        End If
        If BC.IsValidNumBase(TEXT, BASE_FROM) Then
            ErrorLbl.Text = ""
            SENDER.ForeColor = Color.Green
        Else
            SENDER.ForeColor = Color.LightCoral
            ErrorLbl.Text = "✗ Numarul introdus nu corespunde cu baza principala aleasa."
        End If
        Return
    End Sub
    'WHEN CHANGE FROM BASE'
    Private Sub FromBazaCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FromBazaCB.SelectedIndexChanged
        Dim TEXT As String = NumarTB.Text
        Dim BASE_FROM As Byte = FromBazaCB.SelectedItem
        If String.IsNullOrEmpty(TEXT) Then
            ErrorLbl.Text = ""
            Return
        End If
        If Val(TEXT) >= Double.MaxValue Then
            ErrorLbl.Text = "✗ Numarul introdus nu poate fi mai mare decat numarul maxim acceptat."
            Return
        End If
        If BC.IsValidNumBase(TEXT, BASE_FROM) Then
            ErrorLbl.Text = ""
            NumarTB.ForeColor = Color.Green
        Else
            NumarTB.ForeColor = Color.LightCoral
            ErrorLbl.Text = "✗ Numarul introdus nu corespunde cu baza principala aleasa."
        End If
        Return
    End Sub
    'CONVERT BUTTON'
    Private Sub ConvertBtn_Click(SENDER As Object, EV As EventArgs) Handles ConvertBtn.Click
        Dim FROM, TOB As Byte
        Dim RESULT As String = ""
        Dim SB As New StringBuilder
        Dim TEXT As String = NumarTB.Text
        '--------------------------------'
        TEXT = TEXT.Trim
        If String.IsNullOrWhiteSpace(TEXT) Then
            ErrorLbl.Text = "✗ Trebuie sa introduceti un numar inainte de a transforma."
            Return
        End If
        TOB = Val(ToBazaCB.SelectedItem)
        FROM = Val(FromBazaCB.SelectedItem)
        If Not BC.IsValidNumBase(TEXT, FROM) Then
            NumarTB.ForeColor = Color.LightCoral
            ErrorLbl.Text = "✗ Numarul introdus nu corespunde cu baza principala aleasa."
            Return
        End If
        If Val(TEXT) >= Double.MaxValue Then
            ErrorLbl.Text = "✗ Numarul introdus nu poate fi mai mare decat numarul maxim acceptat."
            Return
        End If
        RESULT = BC.Convert(FROM, TOB, TEXT)
        Dim RBAZA10 = BC.Convert(FROM, 10, TEXT)
        SB = SB.Append("Rezultatul conversiei din baza " + FROM.ToString + " in baza " + TOB.ToString + " este: " + RESULT.ToString)
        If Not FROM = 10 Then
            SB = SB.Append(BC.base2decimal(TEXT, RBAZA10, FROM))
        End If
        If Not TOB = 10 Then
            SB = SB.Append(BC.decimal2base(RBAZA10, RESULT, TOB))
        End If
        'ARATA REZULTATUL
        ResultBox.Text = SB.ToString
        Me.Refresh()
        Return
    End Sub
End Class