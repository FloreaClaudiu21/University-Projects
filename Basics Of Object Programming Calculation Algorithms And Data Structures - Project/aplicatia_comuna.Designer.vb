<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aplicatia_comuna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aplicatia_comuna))
        Me.TextOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.APCCenterPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorLbl = New System.Windows.Forms.Label()
        Me.MainMenuBtn = New System.Windows.Forms.Button()
        Me.ShowLbl = New System.Windows.Forms.Label()
        Me.MainTitleLbl = New System.Windows.Forms.Label()
        Me.MainLabelLbl = New System.Windows.Forms.Label()
        Me.PanelControls = New System.Windows.Forms.Panel()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.AnalizaBtn = New System.Windows.Forms.Button()
        Me.DeleteTextBtn = New System.Windows.Forms.Button()
        Me.OPENREZBtn = New System.Windows.Forms.Button()
        Me.TextTB = New System.Windows.Forms.RichTextBox()
        Me.OpenFileBtn = New System.Windows.Forms.Button()
        Me.APCCenterPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelControls.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextOpenFile
        '
        Me.TextOpenFile.Filter = "Text Files|*.txt"
        Me.TextOpenFile.Title = "Selectati un fisier pentru a analiza textul acestuia..."
        '
        'APCCenterPanel
        '
        Me.APCCenterPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.APCCenterPanel.Controls.Add(Me.Panel1)
        Me.APCCenterPanel.Controls.Add(Me.ShowLbl)
        Me.APCCenterPanel.Controls.Add(Me.MainTitleLbl)
        Me.APCCenterPanel.Controls.Add(Me.MainLabelLbl)
        Me.APCCenterPanel.Controls.Add(Me.PanelControls)
        Me.APCCenterPanel.Location = New System.Drawing.Point(4, 75)
        Me.APCCenterPanel.Name = "APCCenterPanel"
        Me.APCCenterPanel.Size = New System.Drawing.Size(1015, 690)
        Me.APCCenterPanel.TabIndex = 5
        Me.APCCenterPanel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ErrorLbl)
        Me.Panel1.Controls.Add(Me.MainMenuBtn)
        Me.Panel1.Location = New System.Drawing.Point(0, 625)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 73)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.LightCoral
        Me.Label1.Location = New System.Drawing.Point(508, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 15
        '
        'ErrorLbl
        '
        Me.ErrorLbl.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ErrorLbl.ForeColor = System.Drawing.Color.LightCoral
        Me.ErrorLbl.Location = New System.Drawing.Point(10, 6)
        Me.ErrorLbl.Name = "ErrorLbl"
        Me.ErrorLbl.Size = New System.Drawing.Size(796, 60)
        Me.ErrorLbl.TabIndex = 12
        Me.ErrorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainMenuBtn
        '
        Me.MainMenuBtn.BackColor = System.Drawing.Color.Orchid
        Me.MainMenuBtn.FlatAppearance.BorderSize = 0
        Me.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainMenuBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainMenuBtn.ForeColor = System.Drawing.Color.White
        Me.MainMenuBtn.Location = New System.Drawing.Point(812, 6)
        Me.MainMenuBtn.Name = "MainMenuBtn"
        Me.MainMenuBtn.Size = New System.Drawing.Size(198, 54)
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
        Me.MainTitleLbl.Location = New System.Drawing.Point(386, 4)
        Me.MainTitleLbl.Name = "MainTitleLbl"
        Me.MainTitleLbl.Size = New System.Drawing.Size(280, 30)
        Me.MainTitleLbl.TabIndex = 7
        Me.MainTitleLbl.Text = "APLICATIA COMUNA"
        '
        'MainLabelLbl
        '
        Me.MainLabelLbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainLabelLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainLabelLbl.Location = New System.Drawing.Point(3, 34)
        Me.MainLabelLbl.Name = "MainLabelLbl"
        Me.MainLabelLbl.Size = New System.Drawing.Size(1010, 106)
        Me.MainLabelLbl.TabIndex = 6
        Me.MainLabelLbl.Text = resources.GetString("MainLabelLbl.Text")
        Me.MainLabelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelControls
        '
        Me.PanelControls.BackColor = System.Drawing.Color.White
        Me.PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelControls.Controls.Add(Me.PictureBox)
        Me.PanelControls.Controls.Add(Me.AnalizaBtn)
        Me.PanelControls.Controls.Add(Me.DeleteTextBtn)
        Me.PanelControls.Controls.Add(Me.OPENREZBtn)
        Me.PanelControls.Controls.Add(Me.TextTB)
        Me.PanelControls.Controls.Add(Me.OpenFileBtn)
        Me.PanelControls.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PanelControls.Location = New System.Drawing.Point(3, 159)
        Me.PanelControls.Name = "PanelControls"
        Me.PanelControls.Size = New System.Drawing.Size(1015, 437)
        Me.PanelControls.TabIndex = 8
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox.BackgroundImage = Global.BPO___Proiect___Seminar.My.Resources.Resources.editpen
        Me.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(45, 448)
        Me.PictureBox.TabIndex = 10
        Me.PictureBox.TabStop = False
        '
        'AnalizaBtn
        '
        Me.AnalizaBtn.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.AnalizaBtn.FlatAppearance.BorderSize = 0
        Me.AnalizaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnalizaBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AnalizaBtn.ForeColor = System.Drawing.Color.White
        Me.AnalizaBtn.Location = New System.Drawing.Point(809, 323)
        Me.AnalizaBtn.Name = "AnalizaBtn"
        Me.AnalizaBtn.Size = New System.Drawing.Size(198, 100)
        Me.AnalizaBtn.TabIndex = 14
        Me.AnalizaBtn.Text = "ANALIZARE TEXT DAT"
        Me.AnalizaBtn.UseVisualStyleBackColor = False
        '
        'DeleteTextBtn
        '
        Me.DeleteTextBtn.BackColor = System.Drawing.Color.Purple
        Me.DeleteTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteTextBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteTextBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteTextBtn.Location = New System.Drawing.Point(809, 111)
        Me.DeleteTextBtn.Name = "DeleteTextBtn"
        Me.DeleteTextBtn.Size = New System.Drawing.Size(198, 100)
        Me.DeleteTextBtn.TabIndex = 10
        Me.DeleteTextBtn.Text = "STERGERE TEXT"
        Me.DeleteTextBtn.UseVisualStyleBackColor = False
        '
        'OPENREZBtn
        '
        Me.OPENREZBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OPENREZBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OPENREZBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OPENREZBtn.ForeColor = System.Drawing.Color.White
        Me.OPENREZBtn.Location = New System.Drawing.Point(809, 217)
        Me.OPENREZBtn.Name = "OPENREZBtn"
        Me.OPENREZBtn.Size = New System.Drawing.Size(198, 100)
        Me.OPENREZBtn.TabIndex = 13
        Me.OPENREZBtn.Text = "DESHIDE FISIERUL TEXT CU REZULTATUL ANALIZEI"
        Me.OPENREZBtn.UseVisualStyleBackColor = False
        '
        'TextTB
        '
        Me.TextTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextTB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextTB.Location = New System.Drawing.Point(59, 5)
        Me.TextTB.MaxLength = 500
        Me.TextTB.Name = "TextTB"
        Me.TextTB.Size = New System.Drawing.Size(744, 418)
        Me.TextTB.TabIndex = 2
        Me.TextTB.Text = ""
        '
        'OpenFileBtn
        '
        Me.OpenFileBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.OpenFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OpenFileBtn.FlatAppearance.BorderSize = 0
        Me.OpenFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenFileBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OpenFileBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OpenFileBtn.Image = Global.BPO___Proiect___Seminar.My.Resources.Resources.folder
        Me.OpenFileBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.OpenFileBtn.Location = New System.Drawing.Point(809, 5)
        Me.OpenFileBtn.Name = "OpenFileBtn"
        Me.OpenFileBtn.Size = New System.Drawing.Size(198, 100)
        Me.OpenFileBtn.TabIndex = 1
        Me.OpenFileBtn.Text = "DESCHIDETI UN FISIER TEXT"
        Me.OpenFileBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.OpenFileBtn.UseVisualStyleBackColor = False
        '
        'aplicatia_comuna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.APCCenterPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "aplicatia_comuna"
        Me.Text = "problema_comuna"
        Me.APCCenterPanel.ResumeLayout(False)
        Me.APCCenterPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelControls.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextOpenFile As OpenFileDialog
    Friend WithEvents APCCenterPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AnalizaBtn As Button
    Friend WithEvents OPENREZBtn As Button
    Friend WithEvents ErrorLbl As Label
    Friend WithEvents MainMenuBtn As Button
    Friend WithEvents ShowLbl As Label
    Friend WithEvents MainTitleLbl As Label
    Friend WithEvents MainLabelLbl As Label
    Friend WithEvents PanelControls As Panel
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents DeleteTextBtn As Button
    Friend WithEvents TextTB As RichTextBox
    Friend WithEvents OpenFileBtn As Button
    Friend WithEvents Label1 As Label
End Class
