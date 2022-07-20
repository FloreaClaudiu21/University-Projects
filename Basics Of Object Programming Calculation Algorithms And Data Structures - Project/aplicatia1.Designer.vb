<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aplicatia1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aplicatia1))
        Me.MainLabelLbl = New System.Windows.Forms.Label()
        Me.MainTitleLbl = New System.Windows.Forms.Label()
        Me.PanelControls = New System.Windows.Forms.Panel()
        Me.AmountTB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChooseBox = New System.Windows.Forms.ComboBox()
        Me.ProductTB = New System.Windows.Forms.RichTextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.FlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeleteListBtn = New System.Windows.Forms.Button()
        Me.MainMenuBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorLbl = New System.Windows.Forms.Label()
        Me.AP1CenterPanel = New System.Windows.Forms.Panel()
        Me.ShowLbl = New System.Windows.Forms.Label()
        Me.PanelControls.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.AP1CenterPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLabelLbl
        '
        Me.MainLabelLbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainLabelLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainLabelLbl.Location = New System.Drawing.Point(10, 34)
        Me.MainLabelLbl.Name = "MainLabelLbl"
        Me.MainLabelLbl.Size = New System.Drawing.Size(1003, 100)
        Me.MainLabelLbl.TabIndex = 6
        Me.MainLabelLbl.Text = resources.GetString("MainLabelLbl.Text")
        Me.MainLabelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainTitleLbl
        '
        Me.MainTitleLbl.AutoSize = True
        Me.MainTitleLbl.Font = New System.Drawing.Font("Algerian", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.MainTitleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainTitleLbl.Location = New System.Drawing.Point(415, 4)
        Me.MainTitleLbl.Name = "MainTitleLbl"
        Me.MainTitleLbl.Size = New System.Drawing.Size(186, 30)
        Me.MainTitleLbl.TabIndex = 7
        Me.MainTitleLbl.Text = "APLICATIA 1"
        '
        'PanelControls
        '
        Me.PanelControls.BackColor = System.Drawing.Color.White
        Me.PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelControls.Controls.Add(Me.AmountTB)
        Me.PanelControls.Controls.Add(Me.PictureBox1)
        Me.PanelControls.Controls.Add(Me.ChooseBox)
        Me.PanelControls.Controls.Add(Me.ProductTB)
        Me.PanelControls.Controls.Add(Me.AddBtn)
        Me.PanelControls.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PanelControls.Location = New System.Drawing.Point(3, 137)
        Me.PanelControls.Name = "PanelControls"
        Me.PanelControls.Size = New System.Drawing.Size(1010, 56)
        Me.PanelControls.TabIndex = 8
        '
        'AmountTB
        '
        Me.AmountTB.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AmountTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.AmountTB.Location = New System.Drawing.Point(615, 5)
        Me.AmountTB.MaxLength = 6
        Me.AmountTB.Name = "AmountTB"
        Me.AmountTB.Size = New System.Drawing.Size(122, 39)
        Me.AmountTB.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.BPO___Proiect___Seminar.My.Resources.Resources.search_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(8, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'ChooseBox
        '
        Me.ChooseBox.BackColor = System.Drawing.Color.White
        Me.ChooseBox.DropDownHeight = 145
        Me.ChooseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ChooseBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChooseBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChooseBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ChooseBox.FormattingEnabled = True
        Me.ChooseBox.IntegralHeight = False
        Me.ChooseBox.Items.AddRange(New Object() {"BUC", "KG", "L"})
        Me.ChooseBox.Location = New System.Drawing.Point(743, 4)
        Me.ChooseBox.Name = "ChooseBox"
        Me.ChooseBox.Size = New System.Drawing.Size(115, 39)
        Me.ChooseBox.TabIndex = 9
        '
        'ProductTB
        '
        Me.ProductTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProductTB.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProductTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProductTB.Location = New System.Drawing.Point(59, 5)
        Me.ProductTB.MaxLength = 10
        Me.ProductTB.Multiline = False
        Me.ProductTB.Name = "ProductTB"
        Me.ProductTB.Size = New System.Drawing.Size(550, 39)
        Me.ProductTB.TabIndex = 2
        Me.ProductTB.Text = ""
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.AddBtn.FlatAppearance.BorderSize = 0
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddBtn.Location = New System.Drawing.Point(864, 2)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(140, 47)
        Me.AddBtn.TabIndex = 1
        Me.AddBtn.Text = "ADAUGARE"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'FlowPanel
        '
        Me.FlowPanel.AutoScroll = True
        Me.FlowPanel.Location = New System.Drawing.Point(3, 245)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(1010, 400)
        Me.FlowPanel.TabIndex = 9
        '
        'DeleteListBtn
        '
        Me.DeleteListBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.DeleteListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteListBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteListBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DeleteListBtn.Location = New System.Drawing.Point(866, 7)
        Me.DeleteListBtn.Name = "DeleteListBtn"
        Me.DeleteListBtn.Size = New System.Drawing.Size(140, 39)
        Me.DeleteListBtn.TabIndex = 10
        Me.DeleteListBtn.Text = "STERGE LISTA"
        Me.DeleteListBtn.UseVisualStyleBackColor = False
        '
        'MainMenuBtn
        '
        Me.MainMenuBtn.BackColor = System.Drawing.Color.DarkOrchid
        Me.MainMenuBtn.FlatAppearance.BorderSize = 0
        Me.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainMenuBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainMenuBtn.ForeColor = System.Drawing.Color.White
        Me.MainMenuBtn.Location = New System.Drawing.Point(704, 7)
        Me.MainMenuBtn.Name = "MainMenuBtn"
        Me.MainMenuBtn.Size = New System.Drawing.Size(157, 39)
        Me.MainMenuBtn.TabIndex = 11
        Me.MainMenuBtn.Text = "MENIUL PRINCIPAL"
        Me.MainMenuBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ErrorLbl)
        Me.Panel1.Controls.Add(Me.DeleteListBtn)
        Me.Panel1.Controls.Add(Me.MainMenuBtn)
        Me.Panel1.Location = New System.Drawing.Point(0, 634)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1018, 56)
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
        'AP1CenterPanel
        '
        Me.AP1CenterPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.AP1CenterPanel.Controls.Add(Me.ShowLbl)
        Me.AP1CenterPanel.Controls.Add(Me.MainTitleLbl)
        Me.AP1CenterPanel.Controls.Add(Me.Panel1)
        Me.AP1CenterPanel.Controls.Add(Me.FlowPanel)
        Me.AP1CenterPanel.Controls.Add(Me.MainLabelLbl)
        Me.AP1CenterPanel.Controls.Add(Me.PanelControls)
        Me.AP1CenterPanel.Location = New System.Drawing.Point(4, 75)
        Me.AP1CenterPanel.Name = "AP1CenterPanel"
        Me.AP1CenterPanel.Size = New System.Drawing.Size(1015, 690)
        Me.AP1CenterPanel.TabIndex = 0
        Me.AP1CenterPanel.Visible = False
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
        'aplicatia1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.AP1CenterPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "aplicatia1"
        Me.Text = "aplicatia1"
        Me.PanelControls.ResumeLayout(False)
        Me.PanelControls.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.AP1CenterPanel.ResumeLayout(False)
        Me.AP1CenterPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainLabelLbl As Label
    Friend WithEvents MainTitleLbl As Label
    Friend WithEvents PanelControls As Panel
    Friend WithEvents AddBtn As Button
    Friend WithEvents ChooseBox As ComboBox
    Friend WithEvents ProductTB As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowPanel As FlowLayoutPanel
    Friend WithEvents DeleteListBtn As Button
    Friend WithEvents MainMenuBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AP1CenterPanel As Panel
    Friend WithEvents AmountTB As TextBox
    Friend WithEvents ShowLbl As Label
    Friend WithEvents ErrorLbl As Label
End Class
