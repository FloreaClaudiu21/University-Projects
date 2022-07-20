<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aplicatia5
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
        Me.components = New System.ComponentModel.Container()
        Me.AP5CenterPanel = New System.Windows.Forms.Panel()
        Me.JumpTB = New System.Windows.Forms.TextBox()
        Me.LabelJump = New System.Windows.Forms.Label()
        Me.PrevPageBtn = New System.Windows.Forms.Button()
        Me.NextPageBtn = New System.Windows.Forms.Button()
        Me.ResultLbl = New System.Windows.Forms.Label()
        Me.GaleryPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorLbl = New System.Windows.Forms.Label()
        Me.DeleteSBtn = New System.Windows.Forms.Button()
        Me.MainMenuBtn = New System.Windows.Forms.Button()
        Me.ShowLbl = New System.Windows.Forms.Label()
        Me.MainTitleLbl = New System.Windows.Forms.Label()
        Me.MainLabelLbl = New System.Windows.Forms.Label()
        Me.PanelControls = New System.Windows.Forms.Panel()
        Me.TermenTB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SalariubazaLbl = New System.Windows.Forms.Label()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AP5CenterPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelControls.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AP5CenterPanel
        '
        Me.AP5CenterPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.AP5CenterPanel.Controls.Add(Me.JumpTB)
        Me.AP5CenterPanel.Controls.Add(Me.LabelJump)
        Me.AP5CenterPanel.Controls.Add(Me.PrevPageBtn)
        Me.AP5CenterPanel.Controls.Add(Me.NextPageBtn)
        Me.AP5CenterPanel.Controls.Add(Me.ResultLbl)
        Me.AP5CenterPanel.Controls.Add(Me.GaleryPanel)
        Me.AP5CenterPanel.Controls.Add(Me.Panel1)
        Me.AP5CenterPanel.Controls.Add(Me.ShowLbl)
        Me.AP5CenterPanel.Controls.Add(Me.MainTitleLbl)
        Me.AP5CenterPanel.Controls.Add(Me.MainLabelLbl)
        Me.AP5CenterPanel.Controls.Add(Me.PanelControls)
        Me.AP5CenterPanel.Location = New System.Drawing.Point(4, 75)
        Me.AP5CenterPanel.Name = "AP5CenterPanel"
        Me.AP5CenterPanel.Size = New System.Drawing.Size(1015, 690)
        Me.AP5CenterPanel.TabIndex = 1
        Me.AP5CenterPanel.Visible = False
        '
        'JumpTB
        '
        Me.JumpTB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.JumpTB.Location = New System.Drawing.Point(835, 254)
        Me.JumpTB.MaxLength = 6
        Me.JumpTB.Name = "JumpTB"
        Me.JumpTB.PlaceholderText = "Numarul pagini..."
        Me.JumpTB.Size = New System.Drawing.Size(161, 23)
        Me.JumpTB.TabIndex = 19
        Me.JumpTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.JumpTB.Visible = False
        '
        'LabelJump
        '
        Me.LabelJump.AutoSize = True
        Me.LabelJump.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.LabelJump.Location = New System.Drawing.Point(857, 232)
        Me.LabelJump.Name = "LabelJump"
        Me.LabelJump.Size = New System.Drawing.Size(118, 19)
        Me.LabelJump.TabIndex = 18
        Me.LabelJump.Text = "Sari la pagina:"
        Me.LabelJump.Visible = False
        '
        'PrevPageBtn
        '
        Me.PrevPageBtn.BackColor = System.Drawing.Color.Indigo
        Me.PrevPageBtn.FlatAppearance.BorderSize = 0
        Me.PrevPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrevPageBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PrevPageBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PrevPageBtn.Location = New System.Drawing.Point(587, 232)
        Me.PrevPageBtn.Name = "PrevPageBtn"
        Me.PrevPageBtn.Size = New System.Drawing.Size(125, 55)
        Me.PrevPageBtn.TabIndex = 17
        Me.PrevPageBtn.Text = "Pagina Anterioara"
        Me.PrevPageBtn.UseVisualStyleBackColor = False
        Me.PrevPageBtn.Visible = False
        '
        'NextPageBtn
        '
        Me.NextPageBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.NextPageBtn.FlatAppearance.BorderSize = 0
        Me.NextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextPageBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NextPageBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NextPageBtn.Location = New System.Drawing.Point(718, 231)
        Me.NextPageBtn.Name = "NextPageBtn"
        Me.NextPageBtn.Size = New System.Drawing.Size(113, 55)
        Me.NextPageBtn.TabIndex = 16
        Me.NextPageBtn.Text = "Pagina Urmatoare"
        Me.NextPageBtn.UseVisualStyleBackColor = False
        Me.NextPageBtn.Visible = False
        '
        'ResultLbl
        '
        Me.ResultLbl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultLbl.ForeColor = System.Drawing.Color.Purple
        Me.ResultLbl.Location = New System.Drawing.Point(8, 232)
        Me.ResultLbl.Name = "ResultLbl"
        Me.ResultLbl.Size = New System.Drawing.Size(559, 55)
        Me.ResultLbl.TabIndex = 15
        Me.ResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GaleryPanel
        '
        Me.GaleryPanel.AutoScroll = True
        Me.GaleryPanel.Location = New System.Drawing.Point(6, 292)
        Me.GaleryPanel.Name = "GaleryPanel"
        Me.GaleryPanel.Size = New System.Drawing.Size(1006, 340)
        Me.GaleryPanel.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ErrorLbl)
        Me.Panel1.Controls.Add(Me.DeleteSBtn)
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
        'DeleteSBtn
        '
        Me.DeleteSBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.DeleteSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteSBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteSBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DeleteSBtn.Location = New System.Drawing.Point(833, 8)
        Me.DeleteSBtn.Name = "DeleteSBtn"
        Me.DeleteSBtn.Size = New System.Drawing.Size(173, 39)
        Me.DeleteSBtn.TabIndex = 10
        Me.DeleteSBtn.Text = "STERGE CAMPURILE"
        Me.DeleteSBtn.UseVisualStyleBackColor = False
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
        Me.MainTitleLbl.Text = "APLICATIA 5"
        '
        'MainLabelLbl
        '
        Me.MainLabelLbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainLabelLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainLabelLbl.Location = New System.Drawing.Point(10, 34)
        Me.MainLabelLbl.Name = "MainLabelLbl"
        Me.MainLabelLbl.Size = New System.Drawing.Size(1003, 100)
        Me.MainLabelLbl.TabIndex = 6
        Me.MainLabelLbl.Text = "Galeria de imagini" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aceasta aplicatie va permite sa cauti anumite imagini in func" &
    "tie de parametrul introdus, si sa le salvati in calculatorul dumneavoastra. "
        Me.MainLabelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelControls
        '
        Me.PanelControls.BackColor = System.Drawing.Color.White
        Me.PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelControls.Controls.Add(Me.TermenTB)
        Me.PanelControls.Controls.Add(Me.PictureBox1)
        Me.PanelControls.Controls.Add(Me.SalariubazaLbl)
        Me.PanelControls.Controls.Add(Me.SearchBtn)
        Me.PanelControls.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PanelControls.Location = New System.Drawing.Point(3, 137)
        Me.PanelControls.Name = "PanelControls"
        Me.PanelControls.Size = New System.Drawing.Size(1010, 81)
        Me.PanelControls.TabIndex = 8
        '
        'TermenTB
        '
        Me.TermenTB.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TermenTB.ForeColor = System.Drawing.Color.MediumOrchid
        Me.TermenTB.Location = New System.Drawing.Point(73, 36)
        Me.TermenTB.MaxLength = 100
        Me.TermenTB.Name = "TermenTB"
        Me.TermenTB.PlaceholderText = "Introduceti termenul pe care doriti sa il cautati..."
        Me.TermenTB.Size = New System.Drawing.Size(747, 29)
        Me.TermenTB.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Image = Global.BPO___Proiect___Seminar.My.Resources.Resources.editpen
        Me.PictureBox1.Location = New System.Drawing.Point(9, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'SalariubazaLbl
        '
        Me.SalariubazaLbl.AutoSize = True
        Me.SalariubazaLbl.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SalariubazaLbl.Location = New System.Drawing.Point(70, 4)
        Me.SalariubazaLbl.Name = "SalariubazaLbl"
        Me.SalariubazaLbl.Size = New System.Drawing.Size(189, 24)
        Me.SalariubazaLbl.TabIndex = 10
        Me.SalariubazaLbl.Text = "Ce doriti sa cautati?"
        Me.SalariubazaLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SearchBtn.Location = New System.Drawing.Point(830, 4)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(163, 61)
        Me.SearchBtn.TabIndex = 1
        Me.SearchBtn.Text = "INCEPETI CAUTAREA"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'aplicatia5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.AP5CenterPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "aplicatia5"
        Me.Text = "aplicatia4"
        Me.AP5CenterPanel.ResumeLayout(False)
        Me.AP5CenterPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelControls.ResumeLayout(False)
        Me.PanelControls.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AP5CenterPanel As Panel
    Friend WithEvents ShowLbl As Label
    Friend WithEvents MainTitleLbl As Label
    Friend WithEvents ErrorLbl As Label
    Friend WithEvents DeleteSBtn As Button
    Friend WithEvents MainMenuBtn As Button
    Friend WithEvents MainLabelLbl As Label
    Friend WithEvents PanelControls As Panel
    Friend WithEvents SearchBtn As Button
    Friend WithEvents SalariubazaLbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GaleryPanel As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TermenTB As TextBox
    Friend WithEvents SaveDialog As SaveFileDialog
    Friend WithEvents JumpTB As TextBox
    Friend WithEvents LabelJump As Label
    Friend WithEvents PrevPageBtn As Button
    Friend WithEvents NextPageBtn As Button
    Friend WithEvents ResultLbl As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
