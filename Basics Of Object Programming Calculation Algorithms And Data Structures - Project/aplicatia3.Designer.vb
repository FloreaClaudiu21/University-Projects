<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aplicatia3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AP3CenterPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorLbl = New System.Windows.Forms.Label()
        Me.DeleteVectorBtn = New System.Windows.Forms.Button()
        Me.MainMenuBtn = New System.Windows.Forms.Button()
        Me.ShowLbl = New System.Windows.Forms.Label()
        Me.MainTitleLbl = New System.Windows.Forms.Label()
        Me.MainLabelLbl = New System.Windows.Forms.Label()
        Me.PanelControls = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PersILbl = New System.Windows.Forms.Label()
        Me.PersoaneCB = New System.Windows.Forms.ComboBox()
        Me.FunctieBazaCBox = New System.Windows.Forms.CheckBox()
        Me.ScutitImpozitCBox = New System.Windows.Forms.CheckBox()
        Me.ZileLucrate = New System.Windows.Forms.Label()
        Me.ZileLTB = New System.Windows.Forms.RichTextBox()
        Me.ValoareTicheteTB = New System.Windows.Forms.RichTextBox()
        Me.SalariubazaLbl = New System.Windows.Forms.Label()
        Me.ValoareTicheteLbl = New System.Windows.Forms.Label()
        Me.SalariuBazaTB = New System.Windows.Forms.RichTextBox()
        Me.CalcBtn = New System.Windows.Forms.Button()
        Me.ResultBox = New System.Windows.Forms.RichTextBox()
        Me.AP3CenterPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'AP3CenterPanel
        '
        Me.AP3CenterPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.AP3CenterPanel.Controls.Add(Me.ResultBox)
        Me.AP3CenterPanel.Controls.Add(Me.Panel1)
        Me.AP3CenterPanel.Controls.Add(Me.ShowLbl)
        Me.AP3CenterPanel.Controls.Add(Me.MainTitleLbl)
        Me.AP3CenterPanel.Controls.Add(Me.MainLabelLbl)
        Me.AP3CenterPanel.Controls.Add(Me.PanelControls)
        Me.AP3CenterPanel.Location = New System.Drawing.Point(4, 75)
        Me.AP3CenterPanel.Name = "AP3CenterPanel"
        Me.AP3CenterPanel.Size = New System.Drawing.Size(1015, 690)
        Me.AP3CenterPanel.TabIndex = 1
        Me.AP3CenterPanel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ErrorLbl)
        Me.Panel1.Controls.Add(Me.DeleteVectorBtn)
        Me.Panel1.Controls.Add(Me.MainMenuBtn)
        Me.Panel1.Location = New System.Drawing.Point(0, 638)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1015, 52)
        Me.Panel1.TabIndex = 12
        '
        'ErrorLbl
        '
        Me.ErrorLbl.AutoSize = True
        Me.ErrorLbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ErrorLbl.ForeColor = System.Drawing.Color.LightCoral
        Me.ErrorLbl.Location = New System.Drawing.Point(7, 17)
        Me.ErrorLbl.Name = "ErrorLbl"
        Me.ErrorLbl.Size = New System.Drawing.Size(0, 20)
        Me.ErrorLbl.TabIndex = 12
        '
        'DeleteVectorBtn
        '
        Me.DeleteVectorBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.DeleteVectorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteVectorBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteVectorBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DeleteVectorBtn.Location = New System.Drawing.Point(833, 8)
        Me.DeleteVectorBtn.Name = "DeleteVectorBtn"
        Me.DeleteVectorBtn.Size = New System.Drawing.Size(173, 39)
        Me.DeleteVectorBtn.TabIndex = 10
        Me.DeleteVectorBtn.Text = "STERGE CAMPURILE"
        Me.DeleteVectorBtn.UseVisualStyleBackColor = False
        '
        'MainMenuBtn
        '
        Me.MainMenuBtn.BackColor = System.Drawing.Color.DarkOrchid
        Me.MainMenuBtn.FlatAppearance.BorderSize = 0
        Me.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainMenuBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainMenuBtn.ForeColor = System.Drawing.Color.White
        Me.MainMenuBtn.Location = New System.Drawing.Point(664, 8)
        Me.MainMenuBtn.Name = "MainMenuBtn"
        Me.MainMenuBtn.Size = New System.Drawing.Size(157, 39)
        Me.MainMenuBtn.TabIndex = 11
        Me.MainMenuBtn.Text = "MENIUL PRINCIPAL"
        Me.MainMenuBtn.UseVisualStyleBackColor = False
        '
        'ShowLbl
        '
        Me.ShowLbl.AutoSize = True
        Me.ShowLbl.Font = New System.Drawing.Font("Sitka Banner", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShowLbl.Location = New System.Drawing.Point(3, 210)
        Me.ShowLbl.Name = "ShowLbl"
        Me.ShowLbl.Size = New System.Drawing.Size(0, 21)
        Me.ShowLbl.TabIndex = 13
        '
        'MainTitleLbl
        '
        Me.MainTitleLbl.AutoSize = True
        Me.MainTitleLbl.Font = New System.Drawing.Font("Algerian", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.MainTitleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainTitleLbl.Location = New System.Drawing.Point(417, 4)
        Me.MainTitleLbl.Name = "MainTitleLbl"
        Me.MainTitleLbl.Size = New System.Drawing.Size(186, 30)
        Me.MainTitleLbl.TabIndex = 7
        Me.MainTitleLbl.Text = "APLICATIA 3"
        '
        'MainLabelLbl
        '
        Me.MainLabelLbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainLabelLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainLabelLbl.Location = New System.Drawing.Point(10, 34)
        Me.MainLabelLbl.Name = "MainLabelLbl"
        Me.MainLabelLbl.Size = New System.Drawing.Size(1003, 100)
        Me.MainLabelLbl.TabIndex = 6
        Me.MainLabelLbl.Text = "Salariul net" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aceasta aplicatie va permite sa calculati salariu net obtinut in ur" &
    "ma impozitarii salariului de baza, dar si povara fiscala suportata de dumneavoas" &
    "tra."
        Me.MainLabelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelControls
        '
        Me.PanelControls.BackColor = System.Drawing.Color.White
        Me.PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelControls.Controls.Add(Me.Label2)
        Me.PanelControls.Controls.Add(Me.Label1)
        Me.PanelControls.Controls.Add(Me.PersILbl)
        Me.PanelControls.Controls.Add(Me.PersoaneCB)
        Me.PanelControls.Controls.Add(Me.FunctieBazaCBox)
        Me.PanelControls.Controls.Add(Me.ScutitImpozitCBox)
        Me.PanelControls.Controls.Add(Me.ZileLucrate)
        Me.PanelControls.Controls.Add(Me.ZileLTB)
        Me.PanelControls.Controls.Add(Me.ValoareTicheteTB)
        Me.PanelControls.Controls.Add(Me.SalariubazaLbl)
        Me.PanelControls.Controls.Add(Me.ValoareTicheteLbl)
        Me.PanelControls.Controls.Add(Me.SalariuBazaTB)
        Me.PanelControls.Controls.Add(Me.CalcBtn)
        Me.PanelControls.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PanelControls.Location = New System.Drawing.Point(3, 137)
        Me.PanelControls.Name = "PanelControls"
        Me.PanelControls.Size = New System.Drawing.Size(1010, 94)
        Me.PanelControls.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label2.Location = New System.Drawing.Point(340, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 29)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "LEI"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(115, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "LEI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PersILbl
        '
        Me.PersILbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PersILbl.Location = New System.Drawing.Point(549, 0)
        Me.PersILbl.Name = "PersILbl"
        Me.PersILbl.Size = New System.Drawing.Size(112, 45)
        Me.PersILbl.TabIndex = 18
        Me.PersILbl.Text = "Persoane in intretinere:"
        Me.PersILbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PersoaneCB
        '
        Me.PersoaneCB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PersoaneCB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PersoaneCB.FormattingEnabled = True
        Me.PersoaneCB.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5+"})
        Me.PersoaneCB.Location = New System.Drawing.Point(549, 48)
        Me.PersoaneCB.Name = "PersoaneCB"
        Me.PersoaneCB.Size = New System.Drawing.Size(112, 31)
        Me.PersoaneCB.TabIndex = 17
        '
        'FunctieBazaCBox
        '
        Me.FunctieBazaCBox.Checked = True
        Me.FunctieBazaCBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FunctieBazaCBox.FlatAppearance.BorderSize = 0
        Me.FunctieBazaCBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FunctieBazaCBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FunctieBazaCBox.Location = New System.Drawing.Point(680, 4)
        Me.FunctieBazaCBox.Name = "FunctieBazaCBox"
        Me.FunctieBazaCBox.Size = New System.Drawing.Size(152, 35)
        Me.FunctieBazaCBox.TabIndex = 16
        Me.FunctieBazaCBox.Text = "Functie de baza"
        Me.FunctieBazaCBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FunctieBazaCBox.UseVisualStyleBackColor = True
        '
        'ScutitImpozitCBox
        '
        Me.ScutitImpozitCBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ScutitImpozitCBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScutitImpozitCBox.Location = New System.Drawing.Point(680, 49)
        Me.ScutitImpozitCBox.Name = "ScutitImpozitCBox"
        Me.ScutitImpozitCBox.Size = New System.Drawing.Size(151, 28)
        Me.ScutitImpozitCBox.TabIndex = 15
        Me.ScutitImpozitCBox.Text = "Scutit impozit"
        Me.ScutitImpozitCBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ScutitImpozitCBox.UseVisualStyleBackColor = True
        '
        'ZileLucrate
        '
        Me.ZileLucrate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ZileLucrate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ZileLucrate.Location = New System.Drawing.Point(412, 4)
        Me.ZileLucrate.Name = "ZileLucrate"
        Me.ZileLucrate.Size = New System.Drawing.Size(113, 26)
        Me.ZileLucrate.TabIndex = 14
        Me.ZileLucrate.Text = "Zile lucrate:"
        Me.ZileLucrate.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ZileLTB
        '
        Me.ZileLTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ZileLTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ZileLTB.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ZileLTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ZileLTB.Location = New System.Drawing.Point(412, 48)
        Me.ZileLTB.MaxLength = 2
        Me.ZileLTB.Multiline = False
        Me.ZileLTB.Name = "ZileLTB"
        Me.ZileLTB.Size = New System.Drawing.Size(113, 31)
        Me.ZileLTB.TabIndex = 13
        Me.ZileLTB.Text = ""
        '
        'ValoareTicheteTB
        '
        Me.ValoareTicheteTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ValoareTicheteTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValoareTicheteTB.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ValoareTicheteTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ValoareTicheteTB.Location = New System.Drawing.Point(181, 50)
        Me.ValoareTicheteTB.MaxLength = 6
        Me.ValoareTicheteTB.Multiline = False
        Me.ValoareTicheteTB.Name = "ValoareTicheteTB"
        Me.ValoareTicheteTB.Size = New System.Drawing.Size(146, 29)
        Me.ValoareTicheteTB.TabIndex = 11
        Me.ValoareTicheteTB.Text = ""
        '
        'SalariubazaLbl
        '
        Me.SalariubazaLbl.AutoSize = True
        Me.SalariubazaLbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SalariubazaLbl.Location = New System.Drawing.Point(11, 8)
        Me.SalariubazaLbl.Name = "SalariubazaLbl"
        Me.SalariubazaLbl.Size = New System.Drawing.Size(146, 22)
        Me.SalariubazaLbl.TabIndex = 10
        Me.SalariubazaLbl.Text = "Salariul de baza:"
        Me.SalariubazaLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ValoareTicheteLbl
        '
        Me.ValoareTicheteLbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ValoareTicheteLbl.Location = New System.Drawing.Point(181, 4)
        Me.ValoareTicheteLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.ValoareTicheteLbl.Name = "ValoareTicheteLbl"
        Me.ValoareTicheteLbl.Size = New System.Drawing.Size(201, 26)
        Me.ValoareTicheteLbl.TabIndex = 12
        Me.ValoareTicheteLbl.Text = "Valoare tichet de masa:"
        Me.ValoareTicheteLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'SalariuBazaTB
        '
        Me.SalariuBazaTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SalariuBazaTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalariuBazaTB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SalariuBazaTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SalariuBazaTB.Location = New System.Drawing.Point(11, 48)
        Me.SalariuBazaTB.MaxLength = 8
        Me.SalariuBazaTB.Multiline = False
        Me.SalariuBazaTB.Name = "SalariuBazaTB"
        Me.SalariuBazaTB.Size = New System.Drawing.Size(98, 31)
        Me.SalariuBazaTB.TabIndex = 2
        Me.SalariuBazaTB.Text = ""
        '
        'CalcBtn
        '
        Me.CalcBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CalcBtn.FlatAppearance.BorderSize = 0
        Me.CalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalcBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CalcBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcBtn.Location = New System.Drawing.Point(853, 4)
        Me.CalcBtn.Name = "CalcBtn"
        Me.CalcBtn.Size = New System.Drawing.Size(140, 80)
        Me.CalcBtn.TabIndex = 1
        Me.CalcBtn.Text = "CALCULATI SALARIUL NET"
        Me.CalcBtn.UseVisualStyleBackColor = False
        '
        'ResultBox
        '
        Me.ResultBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ResultBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ResultBox.Location = New System.Drawing.Point(3, 237)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.ResultBox.Size = New System.Drawing.Size(1009, 395)
        Me.ResultBox.TabIndex = 15
        Me.ResultBox.Text = ""
        '
        'aplicatia3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.AP3CenterPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "aplicatia3"
        Me.Text = "aplicatia3"
        Me.AP3CenterPanel.ResumeLayout(False)
        Me.AP3CenterPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelControls.ResumeLayout(False)
        Me.PanelControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AP3CenterPanel As Panel
    Friend WithEvents ShowLbl As Label
    Friend WithEvents MainTitleLbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorLbl As Label
    Friend WithEvents DeleteVectorBtn As Button
    Friend WithEvents MainMenuBtn As Button
    Friend WithEvents MainLabelLbl As Label
    Friend WithEvents PanelControls As Panel
    Friend WithEvents SalariuBazaTB As RichTextBox
    Friend WithEvents CalcBtn As Button
    Friend WithEvents SalariubazaLbl As Label
    Friend WithEvents PersILbl As Label
    Friend WithEvents PersoaneCB As ComboBox
    Friend WithEvents FunctieBazaCBox As CheckBox
    Friend WithEvents ScutitImpozitCBox As CheckBox
    Friend WithEvents ZileLucrate As Label
    Friend WithEvents ZileLTB As RichTextBox
    Friend WithEvents ValoareTicheteLbl As Label
    Friend WithEvents ValoareTicheteTB As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ResultBox As RichTextBox
End Class
