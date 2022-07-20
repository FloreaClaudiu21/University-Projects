<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aplicatia2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AP2CenterPanel = New System.Windows.Forms.Panel()
        Me.ResultLbl = New System.Windows.Forms.Label()
        Me.NrVectorLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorLbl = New System.Windows.Forms.Label()
        Me.DeleteVectorBtn = New System.Windows.Forms.Button()
        Me.MainMenuBtn = New System.Windows.Forms.Button()
        Me.ShowLbl = New System.Windows.Forms.Label()
        Me.MainTitleLbl = New System.Windows.Forms.Label()
        Me.MainLabelLbl = New System.Windows.Forms.Label()
        Me.PanelControls = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChooseBox = New System.Windows.Forms.ComboBox()
        Me.VectorTB = New System.Windows.Forms.RichTextBox()
        Me.CalcBtn = New System.Windows.Forms.Button()
        Me.AP2CenterPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelControls.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AP2CenterPanel
        '
        Me.AP2CenterPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.AP2CenterPanel.Controls.Add(Me.ResultLbl)
        Me.AP2CenterPanel.Controls.Add(Me.NrVectorLbl)
        Me.AP2CenterPanel.Controls.Add(Me.Panel1)
        Me.AP2CenterPanel.Controls.Add(Me.ShowLbl)
        Me.AP2CenterPanel.Controls.Add(Me.MainTitleLbl)
        Me.AP2CenterPanel.Controls.Add(Me.MainLabelLbl)
        Me.AP2CenterPanel.Controls.Add(Me.PanelControls)
        Me.AP2CenterPanel.Location = New System.Drawing.Point(4, 75)
        Me.AP2CenterPanel.Name = "AP2CenterPanel"
        Me.AP2CenterPanel.Size = New System.Drawing.Size(1015, 690)
        Me.AP2CenterPanel.TabIndex = 1
        Me.AP2CenterPanel.Visible = False
        '
        'ResultLbl
        '
        Me.ResultLbl.Font = New System.Drawing.Font("Lucida Console", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ResultLbl.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ResultLbl.Location = New System.Drawing.Point(0, 549)
        Me.ResultLbl.Name = "ResultLbl"
        Me.ResultLbl.Size = New System.Drawing.Size(1021, 79)
        Me.ResultLbl.TabIndex = 15
        Me.ResultLbl.Text = "Rezultatul calculului este: 0."
        Me.ResultLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NrVectorLbl
        '
        Me.NrVectorLbl.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NrVectorLbl.Location = New System.Drawing.Point(13, 231)
        Me.NrVectorLbl.Name = "NrVectorLbl"
        Me.NrVectorLbl.Size = New System.Drawing.Size(1000, 305)
        Me.NrVectorLbl.TabIndex = 14
        Me.NrVectorLbl.Text = "Numerele din vector introduse sunt: "
        Me.NrVectorLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ErrorLbl)
        Me.Panel1.Controls.Add(Me.DeleteVectorBtn)
        Me.Panel1.Controls.Add(Me.MainMenuBtn)
        Me.Panel1.Location = New System.Drawing.Point(0, 635)
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
        Me.DeleteVectorBtn.Location = New System.Drawing.Point(830, 7)
        Me.DeleteVectorBtn.Name = "DeleteVectorBtn"
        Me.DeleteVectorBtn.Size = New System.Drawing.Size(173, 39)
        Me.DeleteVectorBtn.TabIndex = 10
        Me.DeleteVectorBtn.Text = "STERGE VECTORUL"
        Me.DeleteVectorBtn.UseVisualStyleBackColor = False
        '
        'MainMenuBtn
        '
        Me.MainMenuBtn.BackColor = System.Drawing.Color.DarkOrchid
        Me.MainMenuBtn.FlatAppearance.BorderSize = 0
        Me.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainMenuBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainMenuBtn.ForeColor = System.Drawing.Color.White
        Me.MainMenuBtn.Location = New System.Drawing.Point(667, 7)
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
        Me.MainTitleLbl.Text = "APLICATIA 2"
        '
        'MainLabelLbl
        '
        Me.MainLabelLbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainLabelLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainLabelLbl.Location = New System.Drawing.Point(10, 34)
        Me.MainLabelLbl.Name = "MainLabelLbl"
        Me.MainLabelLbl.Size = New System.Drawing.Size(1003, 100)
        Me.MainLabelLbl.TabIndex = 6
        Me.MainLabelLbl.Text = "Metoda recursiva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aceasta aplicatie va permite sa adunati, scadeti, inmultiti sau" &
    " sa impartiti numerele dintr-un vector folosind o metoda recursiva."
        Me.MainLabelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelControls
        '
        Me.PanelControls.BackColor = System.Drawing.Color.White
        Me.PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelControls.Controls.Add(Me.PictureBox1)
        Me.PanelControls.Controls.Add(Me.ChooseBox)
        Me.PanelControls.Controls.Add(Me.VectorTB)
        Me.PanelControls.Controls.Add(Me.CalcBtn)
        Me.PanelControls.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PanelControls.Location = New System.Drawing.Point(3, 137)
        Me.PanelControls.Name = "PanelControls"
        Me.PanelControls.Size = New System.Drawing.Size(1010, 56)
        Me.PanelControls.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.BPO___Proiect___Seminar.My.Resources.Resources.editpen
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
        Me.ChooseBox.Items.AddRange(New Object() {"ADUNARE", "SCADERE", "INMULTIRE", "IMPARTIRE"})
        Me.ChooseBox.Location = New System.Drawing.Point(692, 4)
        Me.ChooseBox.Name = "ChooseBox"
        Me.ChooseBox.Size = New System.Drawing.Size(166, 39)
        Me.ChooseBox.TabIndex = 9
        '
        'VectorTB
        '
        Me.VectorTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.VectorTB.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VectorTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.VectorTB.Location = New System.Drawing.Point(59, 5)
        Me.VectorTB.MaxLength = 30
        Me.VectorTB.Multiline = False
        Me.VectorTB.Name = "VectorTB"
        Me.VectorTB.Size = New System.Drawing.Size(627, 39)
        Me.VectorTB.TabIndex = 2
        Me.VectorTB.Text = ""
        '
        'CalcBtn
        '
        Me.CalcBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CalcBtn.FlatAppearance.BorderSize = 0
        Me.CalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalcBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CalcBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcBtn.Location = New System.Drawing.Point(864, 2)
        Me.CalcBtn.Name = "CalcBtn"
        Me.CalcBtn.Size = New System.Drawing.Size(140, 47)
        Me.CalcBtn.TabIndex = 1
        Me.CalcBtn.Text = "CALCULATI"
        Me.CalcBtn.UseVisualStyleBackColor = False
        '
        'aplicatia2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.AP2CenterPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "aplicatia2"
        Me.Text = "aplicatia2"
        Me.AP2CenterPanel.ResumeLayout(False)
        Me.AP2CenterPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelControls.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AP2CenterPanel As Panel
    Friend WithEvents ShowLbl As Label
    Friend WithEvents MainTitleLbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorLbl As Label
    Friend WithEvents DeleteVectorBtn As Button
    Friend WithEvents MainMenuBtn As Button
    Friend WithEvents MainLabelLbl As Label
    Friend WithEvents PanelControls As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ChooseBox As ComboBox
    Friend WithEvents VectorTB As RichTextBox
    Friend WithEvents CalcBtn As Button
    Friend WithEvents ResultLbl As Label
    Friend WithEvents NrVectorLbl As Label
End Class
