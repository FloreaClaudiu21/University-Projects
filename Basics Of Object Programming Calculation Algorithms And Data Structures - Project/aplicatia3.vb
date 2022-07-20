Imports System.Text

Public Class aplicatia3
    Dim CAS As Integer = 25, CASS As Integer = 10, IMPOZIT_VENIT As Integer = 10
    'CLEAR THE FIELDS'
    Public Sub clear_fields()
        ZileLTB.Clear()
        ErrorLbl.Text = ""
        ResultBox.Text = ""
        SalariuBazaTB.Clear()
        ValoareTicheteTB.Clear()
        PersoaneCB.Enabled = True
        PersoaneCB.SelectedIndex = 0
        FunctieBazaCBox.Checked = True
        ScutitImpozitCBox.Checked = False
        Return
    End Sub
    'DELETE THE TEXTBOX TEXT'
    Private Sub DeleteFieldsBtn_Click(sender As Object, e As EventArgs) Handles DeleteVectorBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa stergi campurile?", "Stergere campuri", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
            AP3CenterPanel.Hide()
            main_menu.hide_user_panel_anim()
            main_menu.CenterPanel.Show()
            main_menu.Size = New Size(New Point(840, 600))
            main_menu.ProfilePanel.Location = New Point(68, 75)
            Return
        End If
    End Sub
    'CHECK OR UNCHECK THE BOX'
    Private Sub FunctieBazaCBox_CheckedChanged(sender As Object, e As EventArgs) Handles FunctieBazaCBox.CheckedChanged
        Dim CB As CheckBox = sender
        If CB.Checked Then
            PersoaneCB.Enabled = True
        Else
            PersoaneCB.Enabled = False
        End If
        Return
    End Sub
    'VALIDATE ITS NUMBER IN THE FIELD'
    Private Sub Fields_TextChanged(SENDER As Object, EV As EventArgs) Handles SalariuBazaTB.TextChanged, ValoareTicheteTB.TextChanged, ZileLTB.TextChanged
        Dim NUMBER As Integer
        Dim TEXT As String = SENDER.Text
        If String.IsNullOrEmpty(TEXT) Then
            ErrorLbl.Text = ""
            Return
        End If
        Try
            NUMBER = Int(TEXT)
            ErrorLbl.Text = ""
            SENDER.ForeColor = Color.Green
        Catch EX As Exception
            SENDER.ForeColor = Color.LightCoral
            ErrorLbl.Text = "✗ Trebuie sa introduceti un numar in casuta, nu un text."
        End Try
        Dim TB As RichTextBox = SENDER
        Select Case TB.Name
            Case "ValoareTicheteTB"
                If (NUMBER > 21) Then
                    SENDER.ForeColor = Color.LightCoral
                    ErrorLbl.Text = "✗ Valoarea maxima a unui tichet de masa este de 21 de lei."
                End If
                Return
            Case "ZileLTB"
                If (NUMBER > 21 Or NUMBER < 1) Then
                    SENDER.ForeColor = Color.LightCoral
                    ErrorLbl.Text = "✗ Zilele lucrate nu pot fi mai multe de 21 sau mai putin de 1."
                End If
                Return
        End Select
        Return
    End Sub
    'CALCULATE SALARY'
    Private Sub CalcBtn_Click(SENDER As Object, EV As EventArgs) Handles CalcBtn.Click
        Dim POVARA_FISCALA As Double
        Dim STRING_B As New StringBuilder
        Dim SALARIU_BAZA, SALARIU_IMPOZABIL, IMPOZIT_SALARIU, BAZA_PRELEVARI, SALARIU_BRUT, SALARIU_NET, ZILE_LUC, TICHETE_MASA, TICHETE_MASA_T, DEDUCERI, PRELEVARI_CAS, PRELEVARI_CASS, TOTAL_PRELEVARI_OBLIGATORII, TOTAL_VENITURI As Integer
        '------------------------------------------------------------------------------------------'
        Dim ZL, SB, VT As String
        ZL = ZileLTB.Text.Trim
        SB = SalariuBazaTB.Text.Trim
        VT = ValoareTicheteTB.Text.Trim
        '------------------------------'
        'CHECK IF EMPTY FIELDS'
        If String.IsNullOrEmpty(ZL) Then
            ErrorLbl.Text = "✗ Casuta cu zile lucrate nu poate fi goala, introduceti zilele lucrate de dumneavoastra."
            Return
        End If
        If String.IsNullOrEmpty(SB) Then
            ErrorLbl.Text = "✗ Casuta cu salariu de baza nu poate fi goala, introduceti salariul de baza."
            Return
        End If
        If String.IsNullOrEmpty(VT) Then
            ErrorLbl.Text = "✗ Casuta cu valoarea tichetului de masa nu poate fi goala, introduceti valoarea tichetului."
            Return
        End If
        'CHECK IF IS NUMBER'
        Try
            ZILE_LUC = Int(ZL)
            SALARIU_BAZA = Int(SB)
            TICHETE_MASA = Int(VT)
            STRING_B = STRING_B.Append("Salariu baza: " + SALARIU_BAZA.ToString + "lei." + Environment.NewLine)
            STRING_B = STRING_B.Append("Zile lucrate: " + ZILE_LUC.ToString + "." + Environment.NewLine)
            STRING_B = STRING_B.Append("Valoarea tichet de masa: " + TICHETE_MASA.ToString + " lei." + Environment.NewLine)
        Catch EX As Exception
            ErrorLbl.Text = "✗ Trebuie sa introduceti un numar in casuta de salariu de baza sau tichete de masa, nu un text."
            Return
        End Try
        'MAXIM SI MINIM ZILE LUCRATE'
        If ZILE_LUC > 21 Or ZILE_LUC < 1 Then
            ErrorLbl.Text = "✗ Zilele lucrate nu pot fi mai multe de 21 sau mai putin de 1."
            Return
        End If
        BAZA_PRELEVARI = SALARIU_BAZA
        STRING_B = STRING_B.Append("Baza calcul contributii la stat: Salariu de baza = " + BAZA_PRELEVARI.ToString + " lei." + Environment.NewLine)
        TICHETE_MASA_T = ZILE_LUC * TICHETE_MASA
        STRING_B = STRING_B.Append("Tichete de masa total: " + TICHETE_MASA_T.ToString + " lei." + Environment.NewLine)
        If FunctieBazaCBox.Checked Then
            DEDUCERI = main_menu.DEDUCERE.get_by_salary(SALARIU_BAZA, PersoaneCB.SelectedItem)
            STRING_B = STRING_B.Append("Deduceri personale: " + DEDUCERI.ToString + " lei / " + PersoaneCB.SelectedItem + " persoane intretinere." + Environment.NewLine)
        Else
            DEDUCERI = 0
            STRING_B = STRING_B.Append("Deduceri personale: 0 lei / Nu detineti o functie de baza." + Environment.NewLine)
        End If
        'CALCULARE SALARIU BRUT'
        SALARIU_BRUT = SALARIU_BAZA + TICHETE_MASA_T
        STRING_B = STRING_B.Append("Salariu brut: Salariu baza + tichete de masa total = " + SALARIU_BRUT.ToString + " lei." + Environment.NewLine)
        'CALCULARE IMPOZIT'
        PRELEVARI_CAS = (BAZA_PRELEVARI * CAS) / 100
        PRELEVARI_CASS = (BAZA_PRELEVARI * CASS) / 100
        STRING_B = STRING_B.Append("Prelevari CAS: Baza calcul contributii la stat x 25% = " + PRELEVARI_CAS.ToString + " lei." + Environment.NewLine)
        STRING_B = STRING_B.Append("Prelevari CASS: Baza calcul contributii la stat x 10% = " + PRELEVARI_CASS.ToString + " lei." + Environment.NewLine)
        'SALARIUL IMPOZABIL'
        SALARIU_IMPOZABIL = SALARIU_BRUT - PRELEVARI_CAS - PRELEVARI_CASS - DEDUCERI
        STRING_B = STRING_B.Append("Salariul impozabil: Salariul brut - Prelevari CAS - Prelevari CASS - Deduceri personale = " + SALARIU_IMPOZABIL.ToString + " lei." + Environment.NewLine)
        'IMPOZIT PE SALARIU'
        If Not ScutitImpozitCBox.Checked Then
            IMPOZIT_SALARIU = (SALARIU_IMPOZABIL * IMPOZIT_VENIT) / 100
            STRING_B = STRING_B.Append("Impozit salariu: Salariul impozabil x 10% = " + IMPOZIT_SALARIU.ToString + " lei." + Environment.NewLine)
        Else
            IMPOZIT_SALARIU = 0
            STRING_B = STRING_B.Append("Impozit salariu: 0 lei / Sunteti scutit de la plata impozitului. " + Environment.NewLine)
        End If
        'SALARIU NET'
        SALARIU_NET = SALARIU_BAZA - PRELEVARI_CAS - PRELEVARI_CASS - IMPOZIT_SALARIU
        STRING_B = STRING_B.Append("Salariul net: Salariul de baza - Prelevari CAS - Prelevari CASS - Impozit salariu = " + SALARIU_NET.ToString + " lei." + Environment.NewLine)
        'POVARA FISCALA'
        TOTAL_PRELEVARI_OBLIGATORII = PRELEVARI_CAS + PRELEVARI_CASS + IMPOZIT_SALARIU
        STRING_B = STRING_B.Append("Total prelevarii obligatorii: Prelevari CAS + Prelevari CASS + Impozit salariu = " + TOTAL_PRELEVARI_OBLIGATORII.ToString + " lei." + Environment.NewLine)
        TOTAL_VENITURI = SALARIU_BAZA + TICHETE_MASA_T
        STRING_B = STRING_B.Append("Total venituri obtinute: Salariul de baza + Tichete de masa total = " + TOTAL_VENITURI.ToString + " lei." + Environment.NewLine)
        POVARA_FISCALA = (TOTAL_PRELEVARI_OBLIGATORII / TOTAL_VENITURI) * 100
        STRING_B = STRING_B.Append("Povara fiscala: Total prelevarii obligatorii / Total venituri obtinute x 100 = " + Math.Round(POVARA_FISCALA, 2).ToString + "%")
        'ARATA REZULTATUL'
        ResultBox.Text = STRING_B.ToString
        Return
    End Sub
End Class