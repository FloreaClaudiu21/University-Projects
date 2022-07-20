Public Class aplicatia2
    Dim VECTOR As New List(Of Double)
    'CLEAR THE FIELDS'
    Public Sub clear_fields()
        VECTOR.Clear()
        VectorTB.Clear()
        ErrorLbl.Text = ""
        ChooseBox.SelectedIndex = 0
        ResultLbl.Text = "Rezultatul calculului este: 0"
        NrVectorLbl.Text = "Numerele din vector introduse sunt: "
        Return
    End Sub
    'DELETE THE VECTOR'
    Private Sub DeleteVectorBtn_Click(sender As Object, e As EventArgs) Handles DeleteVectorBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa stergi vectorul?", "Stergere vector", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            clear_fields()
            VECTOR.Clear()
            Me.Refresh()
        End If
        Return
    End Sub
    'BACK TO MAIN MENU'
    Private Sub MainMenuBtn_Click(sender As Object, e As EventArgs) Handles MainMenuBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa va intoarceti la meniul principal?", "Intoarcere la meniul principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            clear_fields()
            AP2CenterPanel.Hide()
            main_menu.hide_user_panel_anim()
            main_menu.CenterPanel.Show()
            main_menu.Size = New Size(New Point(840, 600))
            main_menu.ProfilePanel.Location = New Point(68, 75)
            Return
        End If
    End Sub
    'ENTER TO ADD INT IN LIST'
    Private Sub tbbtn_key(sender As Object, e As KeyPressEventArgs) Handles VectorTB.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Dim NR As Double
            Dim PRE As String
            Try
                If VECTOR.Count <= 0 Then
                    PRE = Environment.NewLine
                Else
                    PRE = ", "
                End If
                NR = CDbl(Val(VectorTB.Text))
                If VECTOR.Count >= 100 Then
                    ErrorLbl.Text = "✗ Ati atins limita de 100 de numere per vector."
                    Return
                End If
                VECTOR.Add(NR)
                VectorTB.Clear()
                ErrorLbl.Text = ""
                VectorTB.ForeColor = Color.Green
                NrVectorLbl.Text += (PRE + NR.ToString.Replace(",", "."))
                Return
            Catch EX As Exception
                VectorTB.ForeColor = Color.LightCoral
                ErrorLbl.Text = "✗ Trebuie sa introduceti un numar in vector, nu un text."
                Return
            End Try
        End If
    End Sub
    'VALIDATE ITS NUMBER'
    Private Sub VectorTB_TextChanged(SENDER As Object, EV As EventArgs) Handles VectorTB.TextChanged
        Dim TEXT As String = VectorTB.Text
        If String.IsNullOrEmpty(TEXT) Then
            ErrorLbl.Text = ""
            Return
        End If
        Try
            Int(TEXT)
            ErrorLbl.Text = ""
            VectorTB.ForeColor = Color.Green
        Catch EX As Exception
            VectorTB.ForeColor = Color.LightCoral
            ErrorLbl.Text = "✗ Trebuie sa introduceti un numar in vector, nu un text."
        End Try
        Return
    End Sub
    'CALCULATE THE NUMBERS FROM THE VECTOR'
    Private Sub CalcBtn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click
        If VECTOR.Count <= 0 Then
            ErrorLbl.Text = "✗ Trebuie sa introduceti numere in vector inainte de a calcula suma acestora."
            Return
        End If
        If VECTOR.Count = 1 Then
            ErrorLbl.Text = "✗ Trebuie sa introduceti mai multe numere."
            Return
        End If
        Dim REZ As Double = calc_vector(VECTOR.Count, ChooseBox.SelectedItem)
        ResultLbl.Text = "Rezultatul calculului este: " + Math.Round(REZ, 2).ToString + "."
        MessageBox.Show("Numerele din vector au fost calculate cu succes, rezultatul calcului este: " + REZ.ToString + ".", "Vector calculat cu succes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Return
    End Sub
    'METODA RECURSIVA'
    Public Function calc_vector(N As Integer, TYPE As String) As Double
        If String.IsNullOrEmpty(TYPE) Then
            Return 0
        End If
        Dim EL As Integer = (N - 1)
        Dim T As String = TYPE.ToLower
        '-----------------------------'
        If N = 0 Then
            If T = "scadere" Or T = "adunare" Then
                Return 0
            Else
                Return 1
            End If
        End If
        'SUM'
        If T = "scadere" Then
            Return calc_vector(EL, TYPE) - VECTOR.ElementAt(EL)
        ElseIf T = "adunare" Then
            Return calc_vector(EL, TYPE) + VECTOR.ElementAt(EL)
        ElseIf T = "inmultire" Then
            Return calc_vector(EL, TYPE) * VECTOR.ElementAt(EL)
        Else
            Return calc_vector(EL, TYPE) / VECTOR.ElementAt(EL)
        End If
    End Function
End Class