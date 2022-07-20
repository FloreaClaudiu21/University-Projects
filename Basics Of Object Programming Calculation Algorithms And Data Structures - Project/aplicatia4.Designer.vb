<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aplicatia4
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
        Me.AP4CenterPanel = New System.Windows.Forms.Panel()
        Me.ResultBox = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorLbl = New System.Windows.Forms.Label()
        Me.DeleteVectorBtn = New System.Windows.Forms.Button()
        Me.MainMenuBtn = New System.Windows.Forms.Button()
        Me.ShowLbl = New System.Windows.Forms.Label()
        Me.MainTitleLbl = New System.Windows.Forms.Label()
        Me.MainLabelLbl = New System.Windows.Forms.Label()
        Me.PanelControls = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToBazaCB = New System.Windows.Forms.ComboBox()
        Me.PersILbl = New System.Windows.Forms.Label()
        Me.FromBazaCB = New System.Windows.Forms.ComboBox()
        Me.SalariubazaLbl = New System.Windows.Forms.Label()
        Me.NumarTB = New System.Windows.Forms.RichTextBox()
        Me.ConvertBtn = New System.Windows.Forms.Button()
        Me.AP4CenterPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'AP4CenterPanel
        '
        Me.AP4CenterPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.AP4CenterPanel.Controls.Add(Me.ResultBox)
        Me.AP4CenterPanel.Controls.Add(Me.Panel1)
        Me.AP4CenterPanel.Controls.Add(Me.ShowLbl)
        Me.AP4CenterPanel.Controls.Add(Me.MainTitleLbl)
        Me.AP4CenterPanel.Controls.Add(Me.MainLabelLbl)
        Me.AP4CenterPanel.Controls.Add(Me.PanelControls)
        Me.AP4CenterPanel.Location = New System.Drawing.Point(4, 75)
        Me.AP4CenterPanel.Name = "AP4CenterPanel"
        Me.AP4CenterPanel.Size = New System.Drawing.Size(1015, 690)
        Me.AP4CenterPanel.TabIndex = 1
        Me.AP4CenterPanel.Visible = False
        '
        'ResultBox
        '
        Me.ResultBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ResultBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ResultBox.Location = New System.Drawing.Point(6, 224)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.ResultBox.Size = New System.Drawing.Size(1002, 408)
        Me.ResultBox.TabIndex = 14
        Me.ResultBox.Text = ""
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
        Me.Panel1.Size = New System.Drawing.Size(1021, 52)
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
        Me.DeleteVectorBtn.Location = New System.Drawing.Point(833, 6)
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
        Me.MainMenuBtn.Location = New System.Drawing.Point(666, 8)
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
        Me.MainTitleLbl.Text = "APLICATIA 4"
        '
        'MainLabelLbl
        '
        Me.MainLabelLbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainLabelLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainLabelLbl.Location = New System.Drawing.Point(10, 34)
        Me.MainLabelLbl.Name = "MainLabelLbl"
        Me.MainLabelLbl.Size = New System.Drawing.Size(1003, 100)
        Me.MainLabelLbl.TabIndex = 6
        Me.MainLabelLbl.Text = "Convertor baze" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aceasta aplicatie va permite sa convertiti un numar dintr-o baza " &
    "in alta, de exemplu din baza 10 in baza 16 sau din baza 2 in baza 10 etc."
        Me.MainLabelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelControls
        '
        Me.PanelControls.BackColor = System.Drawing.Color.White
        Me.PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelControls.Controls.Add(Me.Label1)
        Me.PanelControls.Controls.Add(Me.ToBazaCB)
        Me.PanelControls.Controls.Add(Me.PersILbl)
        Me.PanelControls.Controls.Add(Me.FromBazaCB)
        Me.PanelControls.Controls.Add(Me.SalariubazaLbl)
        Me.PanelControls.Controls.Add(Me.NumarTB)
        Me.PanelControls.Controls.Add(Me.ConvertBtn)
        Me.PanelControls.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PanelControls.Location = New System.Drawing.Point(3, 137)
        Me.PanelControls.Name = "PanelControls"
        Me.PanelControls.Size = New System.Drawing.Size(1010, 81)
        Me.PanelControls.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(701, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 26)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "In baza:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ToBazaCB
        '
        Me.ToBazaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToBazaCB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ToBazaCB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ToBazaCB.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToBazaCB.FormattingEnabled = True
        Me.ToBazaCB.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36"})
        Me.ToBazaCB.Location = New System.Drawing.Point(701, 34)
        Me.ToBazaCB.Name = "ToBazaCB"
        Me.ToBazaCB.Size = New System.Drawing.Size(131, 31)
        Me.ToBazaCB.TabIndex = 19
        '
        'PersILbl
        '
        Me.PersILbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PersILbl.Location = New System.Drawing.Point(570, 4)
        Me.PersILbl.Name = "PersILbl"
        Me.PersILbl.Size = New System.Drawing.Size(112, 26)
        Me.PersILbl.TabIndex = 18
        Me.PersILbl.Text = "De la baza:"
        Me.PersILbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FromBazaCB
        '
        Me.FromBazaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FromBazaCB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FromBazaCB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FromBazaCB.FormattingEnabled = True
        Me.FromBazaCB.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36"})
        Me.FromBazaCB.Location = New System.Drawing.Point(570, 34)
        Me.FromBazaCB.Name = "FromBazaCB"
        Me.FromBazaCB.Size = New System.Drawing.Size(112, 31)
        Me.FromBazaCB.TabIndex = 17
        '
        'SalariubazaLbl
        '
        Me.SalariubazaLbl.AutoSize = True
        Me.SalariubazaLbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SalariubazaLbl.Location = New System.Drawing.Point(11, 4)
        Me.SalariubazaLbl.Name = "SalariubazaLbl"
        Me.SalariubazaLbl.Size = New System.Drawing.Size(131, 22)
        Me.SalariubazaLbl.TabIndex = 10
        Me.SalariubazaLbl.Text = "Numarul dorit:"
        Me.SalariubazaLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'NumarTB
        '
        Me.NumarTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NumarTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumarTB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NumarTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.NumarTB.Location = New System.Drawing.Point(11, 34)
        Me.NumarTB.MaxLength = 60
        Me.NumarTB.Multiline = False
        Me.NumarTB.Name = "NumarTB"
        Me.NumarTB.Size = New System.Drawing.Size(532, 31)
        Me.NumarTB.TabIndex = 2
        Me.NumarTB.Text = ""
        '
        'ConvertBtn
        '
        Me.ConvertBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ConvertBtn.FlatAppearance.BorderSize = 0
        Me.ConvertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConvertBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConvertBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ConvertBtn.Location = New System.Drawing.Point(853, 4)
        Me.ConvertBtn.Name = "ConvertBtn"
        Me.ConvertBtn.Size = New System.Drawing.Size(140, 61)
        Me.ConvertBtn.TabIndex = 1
        Me.ConvertBtn.Text = "CONVERTITI NUMARUL"
        Me.ConvertBtn.UseVisualStyleBackColor = False
        '
        'aplicatia4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.AP4CenterPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "aplicatia4"
        Me.Text = "aplicatia4"
        Me.AP4CenterPanel.ResumeLayout(False)
        Me.AP4CenterPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelControls.ResumeLayout(False)
        Me.PanelControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AP4CenterPanel As Panel
    Friend WithEvents ShowLbl As Label
    Friend WithEvents MainTitleLbl As Label
    Friend WithEvents ErrorLbl As Label
    Friend WithEvents DeleteVectorBtn As Button
    Friend WithEvents MainMenuBtn As Button
    Friend WithEvents MainLabelLbl As Label
    Friend WithEvents PanelControls As Panel
    Friend WithEvents NumarTB As RichTextBox
    Friend WithEvents ConvertBtn As Button
    Friend WithEvents SalariubazaLbl As Label
    Friend WithEvents PersILbl As Label
    Friend WithEvents FromBazaCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToBazaCB As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ResultBox As RichTextBox
End Class
