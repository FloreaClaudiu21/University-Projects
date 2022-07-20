Public Class aplicatia1
    Public LIST_PRODUCTS As New List(Of product_holder)
    'CLEAR THE FIELDS'
    Public Sub clear_fields()
        AmountTB.Clear()
        ProductTB.Clear()
        ErrorLbl.Text = ""
        ChooseBox.SelectedIndex = 0
        Return
    End Sub
    'DELETE THE LIST'
    Private Sub DeleteListBtn_Click(sender As Object, e As EventArgs) Handles DeleteListBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa stergi lista?", "Stergere lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            clear_fields()
            LIST_PRODUCTS.Clear()
            FlowPanel.Controls.Clear()
            Me.Refresh()
        End If
        Return
    End Sub
    'BACK TO MAIN MENU'
    Private Sub MainMenuBtn_Click(sender As Object, e As EventArgs) Handles MainMenuBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa va intoarceti la meniul principal?", "Intoarcere la meniul principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            clear_fields()
            AP1CenterPanel.Hide()
            main_menu.hide_user_panel_anim()
            main_menu.CenterPanel.Show()
            main_menu.Size = New Size(New Point(840, 600))
            main_menu.ProfilePanel.Location = New Point(68, 75)
            Return
        End If
    End Sub
    'ADD THE PRODUCT BUTTON'
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim TEXT As String = ProductTB.Text
        Dim AMOUNT_T As String = AmountTB.Text
        Dim UNIT As String = ChooseBox.SelectedItem
        TEXT = TEXT.Trim
        AMOUNT_T = AMOUNT_T.Trim
        ProductTB.Text = TEXT
        Dim VA As New Validate
        'CHECK IF ITS EMPTY'
        If String.IsNullOrEmpty(TEXT) Then
            ErrorLbl.Text = "✗ Numele produsului nu poate fi gol."
            Return
        End If
        'CHECK LENGTH'
        If TEXT.Length < 3 Then
            ErrorLbl.Text = "✗ Numele produsului nu poate fi mai mic de 3 litere."
            Return
        End If
        'CHECK ILLEGAL SYMBOLS'
        If TEXT.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1 Then
            ErrorLbl.Text = "✗ Numele produsului nu poate sa contina caractere speciale."
            Return
        End If
        'CHECK IF PRODUCT EXISTS'
        If VA.exists_product(TEXT) Then
            ErrorLbl.Text = "✗ Produsul '" + TEXT + "' exista deja in lista de cumparaturi."
            Return
        End If
        'CHECK IF VALID AMOUNT'
        Try
            Int(AMOUNT_T)
        Catch ex As Exception
            ErrorLbl.Text = "✗ Cantitatea produsului nu este valida, aceasta trebuie sa fie un numar."
            Return
        End Try
        Dim INDEX As Integer = LIST_PRODUCTS.Count + 1
        Dim HOLDER As New product_holder(INDEX, TEXT, "Cantitate: " + AMOUNT_T + " " + UNIT)
        'ADD THE NEW PRODUCT'
        clear_fields()
        LIST_PRODUCTS.Add(HOLDER)
        Draw_List(TEXT)
        ShowLbl.Text = "Arata toate produsele din lista (" + LIST_PRODUCTS.Count.ToString + ")"
        MessageBox.Show("Produsul '" + TEXT + "' a fost adaugat cu success in lista de cumparaturi.", "Adaugare cu succes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Return
    End Sub
    'SEARCH OR ADD NEW ITEM'
    Private Sub ProductTB_TextChanged(SENDER As Object, EV As EventArgs) Handles ProductTB.TextChanged
        Dim TEXT As String = ProductTB.Text
        Draw_List(TEXT)
        Return
    End Sub
    'AMOUNT TEXT BOX TEXT CHANGED EVENT'
    Private Sub AmountTB_TextChanged(SENDER As Object, EV As EventArgs) Handles AmountTB.TextChanged
        Dim TEXT As String = AmountTB.Text
        If String.IsNullOrEmpty(TEXT) Then
            AmountTB.ForeColor = Color.LightCoral
            Return
        End If
        TEXT = TEXT.Trim
        Try
            Int(TEXT)
            ErrorLbl.Text = ""
            AmountTB.ForeColor = Color.Green
        Catch EX As Exception
            AmountTB.ForeColor = Color.LightCoral
            ErrorLbl.Text = "✗ Cantitatea produsului nu este valida, aceasta trebuie sa fie un numar."
        End Try
        Return
    End Sub
    'DRAW THE PRODUCTS' 
    Public Sub Draw_List(TEXT As String)
        Dim INDEX = 0
        TEXT = TEXT.Trim
        TEXT = TEXT.ToLower
        Dim F_I As Integer = 0
        FlowPanel.Controls.Clear()
        Dim FOUND_SAME As Boolean = False
        Dim FOUND_START As Boolean = False
        'IF STRING IS NULL'
        If String.IsNullOrEmpty(TEXT) Then
            For Each PRODUCT As product_holder In LIST_PRODUCTS
                INDEX += 1
                PRODUCT.IndexLbl.Text = INDEX.ToString
                FlowPanel.Controls.Add(PRODUCT)
            Next
            Me.Refresh()
            ShowLbl.Text = "Arata toate produsele din lista (" + LIST_PRODUCTS.Count.ToString + ")"
            Return
        End If
        'FOR EACH PRODUCT'
        For Each PRODUCT As product_holder In LIST_PRODUCTS
            If PRODUCT.INDENTITY_NAME.Equals(TEXT) Then
                FOUND_SAME = True
            End If
            If PRODUCT.INDENTITY_NAME.StartsWith(TEXT) Then
                F_I += 1
                INDEX += 1
                FOUND_START = True
                PRODUCT.IndexLbl.Text = INDEX.ToString
                FlowPanel.Controls.Add(PRODUCT)
                Me.Refresh()
            End If
        Next
        'IF FOUND THE PRODUCT IN THE LIST'
        If FOUND_SAME Then
            ProductTB.ForeColor = Color.LightCoral
        Else
            ProductTB.ForeColor = Color.Green
        End If
        ShowLbl.Text = "Arata toate produsele din lista care incep cu '" + TEXT + "' (" + F_I.ToString + ")"
        'IF NOTHING STARTS WITH THE TEXT'
        If Not FOUND_START Then
            For Each PRODUCT As product_holder In LIST_PRODUCTS
                INDEX += 1
                PRODUCT.IndexLbl.Text = INDEX.ToString
                FlowPanel.Controls.Add(PRODUCT)
                Me.Refresh()
            Next
            ShowLbl.Text = "Arata toate produsele din lista (" + LIST_PRODUCTS.Count.ToString + ")"
        End If
        Return
    End Sub
End Class
Public Class Validate
    'CHECK IF PRODUCT EXISTS IN THE LIST'
    Public Function exists_product(PRODUS As product_holder) As Boolean
        Return exists_product(PRODUS.INDENTITY_NAME)
    End Function
    'CHECK IF PRODUCT EXISTS IN THE LIST'
    Public Function exists_product(NAME As String) As Boolean
        If String.IsNullOrEmpty(NAME) Then
            Return False
        End If
        NAME = NAME.ToLower
        For Each PRODUS As product_holder In aplicatia1.LIST_PRODUCTS
            If PRODUS.INDENTITY_NAME.Equals(NAME) Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
'PRODUCT HOLDER'
Public Class product_holder
    Inherits Panel
    Public INDENTITY_NAME As String
    Friend WithEvents ProdLbl As Label
    Friend WithEvents IndexLbl As Label
    Friend WithEvents PanelBar As Panel
    Friend WithEvents PanelBar1 As Panel
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ProdInfoLbl As Label
    Public Sub New(INDEX As Integer, TEXT As String, CANT_TEXT As String)
        Me.PanelBar = New Panel()
        Me.PanelBar1 = New Panel()
        Me.ProdLbl = New Label()
        Me.IndexLbl = New Label()
        Me.DeleteBtn = New Button()
        Me.ProdInfoLbl = New Label()
        Me.INDENTITY_NAME = TEXT.ToLower
        '
        'ProductHolder
        '
        Me.TabIndex = 1
        Me.Name = "ProductHolder"
        Me.BackColor = System.Drawing.Color.White
        Me.Location = New System.Drawing.Point(3, 3)
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Size = New System.Drawing.Size(aplicatia1.FlowPanel.Size.Width - 6, 89)
        Me.Controls.Add(Me.PanelBar)
        Me.Controls.Add(Me.ProdInfoLbl)
        Me.Controls.Add(Me.PanelBar1)
        Me.Controls.Add(Me.ProdLbl)
        Me.Controls.Add(Me.IndexLbl)
        Me.Controls.Add(Me.DeleteBtn)
        '
        'DeleteBtn
        '
        Me.DeleteBtn.TabIndex = 0
        Me.DeleteBtn.Text = "STERGE"
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.FlatAppearance.BorderSize = 0
        Me.DeleteBtn.Size = New System.Drawing.Size(100, 87)
        Me.DeleteBtn.BackColor = System.Drawing.Color.DarkRed
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteBtn.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DeleteBtn.Image = Global.BPO___Proiect___Seminar.My.Resources.Resources.delete_icon
        Me.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteBtn.Location = New System.Drawing.Point(899, -2)
        Me.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'IndexLbl
        '
        Me.IndexLbl.TabIndex = 1
        Me.IndexLbl.Name = "IndexLbl"
        Me.IndexLbl.Text = INDEX.ToString
        Me.IndexLbl.ForeColor = Color.WhiteSmoke
        Me.IndexLbl.Size = New System.Drawing.Size(73, 89)
        Me.IndexLbl.Location = New System.Drawing.Point(-2, -2)
        Me.IndexLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IndexLbl.Font = New System.Drawing.Font("Castellar", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IndexLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProdLbl
        '
        Me.ProdLbl.Text = TEXT
        Me.ProdLbl.TabIndex = 2
        Me.ProdLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProdLbl.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdLbl.Location = New System.Drawing.Point(77, 4)
        Me.ProdLbl.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ProdLbl.Name = "ProdLbl"
        Me.ProdLbl.Size = New System.Drawing.Size(796, 42)
        Me.ProdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.PanelBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelBar.Location = New System.Drawing.Point(890, -5)
        Me.PanelBar.Name = "Panel1"
        Me.PanelBar.Size = New System.Drawing.Size(10, 93)
        Me.PanelBar.TabIndex = 3
        '
        'ProdInfoLbl
        '
        Me.ProdInfoLbl.Font = New System.Drawing.Font("Sitka Banner", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdInfoLbl.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ProdInfoLbl.Location = New System.Drawing.Point(80, 55)
        Me.ProdInfoLbl.Name = "ProdInfoLbl"
        Me.ProdInfoLbl.Size = New System.Drawing.Size(790, 30)
        Me.ProdInfoLbl.TabIndex = 4
        Me.ProdInfoLbl.Text = CANT_TEXT
        '
        'Panel2
        '
        Me.PanelBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelBar1.Location = New System.Drawing.Point(63, -2)
        Me.PanelBar1.Name = "Panel2"
        Me.PanelBar1.Size = New System.Drawing.Size(11, 93)
        Me.PanelBar1.TabIndex = 5
        Return
    End Sub
    'DELETE PRODUCT FROM THE LIST'
    Public Sub Delete_Product() Handles DeleteBtn.Click
        Dim R As DialogResult = MessageBox.Show("Sunteti sigur ca doriti sa stergeti produsul '" + ProdLbl.Text + "'?", "Stergere produs", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = DialogResult.Yes Then
            aplicatia1.clear_fields()
            aplicatia1.LIST_PRODUCTS.Remove(Me)
            aplicatia1.Draw_List("")
            MessageBox.Show("Produsul '" + ProdLbl.Text + "' a fost sters din lista cu succes!", "Produs sters din lista", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
    End Sub
End Class