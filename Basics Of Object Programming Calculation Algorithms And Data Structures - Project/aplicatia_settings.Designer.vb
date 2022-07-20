<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aplicatia_settings
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
        Me.APSCenterPanel = New System.Windows.Forms.Panel()
        Me.PrevPageBtn = New System.Windows.Forms.Button()
        Me.NextPageBtn = New System.Windows.Forms.Button()
        Me.FlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorLbl = New System.Windows.Forms.Label()
        Me.MainMenuBtn = New System.Windows.Forms.Button()
        Me.ShowLbl = New System.Windows.Forms.Label()
        Me.MainTitleLbl = New System.Windows.Forms.Label()
        Me.ToolTipDelBtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.APSCenterPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'APSCenterPanel
        '
        Me.APSCenterPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.APSCenterPanel.Controls.Add(Me.PrevPageBtn)
        Me.APSCenterPanel.Controls.Add(Me.NextPageBtn)
        Me.APSCenterPanel.Controls.Add(Me.FlowPanel)
        Me.APSCenterPanel.Controls.Add(Me.TitleLbl)
        Me.APSCenterPanel.Controls.Add(Me.Panel1)
        Me.APSCenterPanel.Controls.Add(Me.ShowLbl)
        Me.APSCenterPanel.Controls.Add(Me.MainTitleLbl)
        Me.APSCenterPanel.Location = New System.Drawing.Point(4, 75)
        Me.APSCenterPanel.Name = "APSCenterPanel"
        Me.APSCenterPanel.Size = New System.Drawing.Size(1015, 690)
        Me.APSCenterPanel.TabIndex = 5
        Me.APSCenterPanel.Visible = False
        '
        'PrevPageBtn
        '
        Me.PrevPageBtn.BackColor = System.Drawing.Color.Indigo
        Me.PrevPageBtn.Enabled = False
        Me.PrevPageBtn.FlatAppearance.BorderSize = 0
        Me.PrevPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrevPageBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PrevPageBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PrevPageBtn.Location = New System.Drawing.Point(764, 46)
        Me.PrevPageBtn.Name = "PrevPageBtn"
        Me.PrevPageBtn.Size = New System.Drawing.Size(125, 51)
        Me.PrevPageBtn.TabIndex = 19
        Me.PrevPageBtn.Text = "Pagina Anterioara"
        Me.PrevPageBtn.UseVisualStyleBackColor = False
        '
        'NextPageBtn
        '
        Me.NextPageBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.NextPageBtn.Enabled = False
        Me.NextPageBtn.FlatAppearance.BorderSize = 0
        Me.NextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextPageBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NextPageBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NextPageBtn.Location = New System.Drawing.Point(895, 45)
        Me.NextPageBtn.Name = "NextPageBtn"
        Me.NextPageBtn.Size = New System.Drawing.Size(113, 52)
        Me.NextPageBtn.TabIndex = 18
        Me.NextPageBtn.Text = "Pagina Urmatoare"
        Me.NextPageBtn.UseVisualStyleBackColor = False
        '
        'FlowPanel
        '
        Me.FlowPanel.AutoScroll = True
        Me.FlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowPanel.Location = New System.Drawing.Point(10, 103)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(998, 516)
        Me.FlowPanel.TabIndex = 15
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.TitleLbl.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TitleLbl.Location = New System.Drawing.Point(10, 55)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(348, 31)
        Me.TitleLbl.TabIndex = 14
        Me.TitleLbl.Text = "(!) Lista de utilizatorii (10/10):"
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.ErrorLbl.Size = New System.Drawing.Size(796, 53)
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
        Me.MainMenuBtn.Size = New System.Drawing.Size(198, 53)
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
        Me.MainTitleLbl.Location = New System.Drawing.Point(370, 4)
        Me.MainTitleLbl.Name = "MainTitleLbl"
        Me.MainTitleLbl.Size = New System.Drawing.Size(308, 30)
        Me.MainTitleLbl.TabIndex = 7
        Me.MainTitleLbl.Text = "SETARILE APLICATIEI"
        '
        'ToolTipDelBtn
        '
        Me.ToolTipDelBtn.IsBalloon = True
        Me.ToolTipDelBtn.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipDelBtn.ToolTipTitle = "Fara permisiune"
        '
        'aplicatia_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.APSCenterPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "aplicatia_settings"
        Me.Text = "problema_comuna"
        Me.APSCenterPanel.ResumeLayout(False)
        Me.APSCenterPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents APSCenterPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorLbl As Label
    Friend WithEvents MainMenuBtn As Button
    Friend WithEvents ShowLbl As Label
    Friend WithEvents MainTitleLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleLbl As Label
    Friend WithEvents FlowPanel As FlowLayoutPanel
    Friend WithEvents PrevPageBtn As Button
    Friend WithEvents NextPageBtn As Button
    Friend WithEvents ToolTipDelBtn As ToolTip
End Class
