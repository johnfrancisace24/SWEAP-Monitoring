﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        txtbxUsername = New Guna.UI2.WinForms.Guna2TextBox()
        txtbxPassword = New Guna.UI2.WinForms.Guna2TextBox()
        bttLogin = New Guna.UI2.WinForms.Guna2Button()
        CheckBoxShowPass = New Guna.UI2.WinForms.Guna2CheckBox()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Label1 = New Label()
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Label2 = New Label()
        LinkLabelSignUp = New LinkLabel()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2ShadowPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 20
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' txtbxUsername
        ' 
        txtbxUsername.Animated = True
        txtbxUsername.AutoRoundedCorners = True
        txtbxUsername.BackColor = Color.Transparent
        txtbxUsername.BorderColor = Color.White
        txtbxUsername.BorderRadius = 21
        txtbxUsername.CustomizableEdges = CustomizableEdges9
        txtbxUsername.DefaultText = ""
        txtbxUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtbxUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtbxUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtbxUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtbxUsername.FillColor = SystemColors.ControlLight
        txtbxUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtbxUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtbxUsername.ForeColor = Color.Black
        txtbxUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtbxUsername.IconLeft = My.Resources.Resources.user__1_
        txtbxUsername.IconLeftOffset = New Point(10, 0)
        txtbxUsername.IconRightOffset = New Point(10, 0)
        txtbxUsername.Location = New Point(52, 70)
        txtbxUsername.Margin = New Padding(4, 4, 4, 4)
        txtbxUsername.Name = "txtbxUsername"
        txtbxUsername.Padding = New Padding(64, 0, 0, 0)
        txtbxUsername.PasswordChar = ChrW(0)
        txtbxUsername.PlaceholderForeColor = Color.DimGray
        txtbxUsername.PlaceholderText = "USERNAME"
        txtbxUsername.SelectedText = ""
        txtbxUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtbxUsername.Size = New Size(291, 45)
        txtbxUsername.TabIndex = 1
        ' 
        ' txtbxPassword
        ' 
        txtbxPassword.Animated = True
        txtbxPassword.AutoRoundedCorners = True
        txtbxPassword.BackColor = Color.Transparent
        txtbxPassword.BorderColor = Color.White
        txtbxPassword.BorderRadius = 21
        txtbxPassword.CustomizableEdges = CustomizableEdges13
        txtbxPassword.DefaultText = ""
        txtbxPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtbxPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtbxPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtbxPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtbxPassword.FillColor = SystemColors.ControlLight
        txtbxPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtbxPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtbxPassword.ForeColor = Color.Black
        txtbxPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtbxPassword.IconLeft = My.Resources.Resources.padlock
        txtbxPassword.IconLeftOffset = New Point(10, 0)
        txtbxPassword.Location = New Point(52, 143)
        txtbxPassword.Margin = New Padding(4, 4, 4, 4)
        txtbxPassword.Name = "txtbxPassword"
        txtbxPassword.Padding = New Padding(64, 0, 0, 0)
        txtbxPassword.PasswordChar = "*"c
        txtbxPassword.PlaceholderForeColor = Color.DimGray
        txtbxPassword.PlaceholderText = "PASSWORD"
        txtbxPassword.SelectedText = ""
        txtbxPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        txtbxPassword.Size = New Size(291, 45)
        txtbxPassword.TabIndex = 5
        ' 
        ' bttLogin
        ' 
        bttLogin.AutoRoundedCorners = True
        bttLogin.BorderRadius = 20
        bttLogin.CustomizableEdges = CustomizableEdges11
        bttLogin.DisabledState.BorderColor = Color.DarkGray
        bttLogin.DisabledState.CustomBorderColor = Color.DarkGray
        bttLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        bttLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        bttLogin.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        bttLogin.ForeColor = Color.White
        bttLogin.Location = New Point(107, 250)
        bttLogin.Name = "bttLogin"
        bttLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        bttLogin.Size = New Size(180, 45)
        bttLogin.TabIndex = 6
        bttLogin.Text = "LOGIN"
        ' 
        ' CheckBoxShowPass
        ' 
        CheckBoxShowPass.AutoSize = True
        CheckBoxShowPass.CheckedState.BorderColor = SystemColors.ControlLight
        CheckBoxShowPass.CheckedState.BorderRadius = 0
        CheckBoxShowPass.CheckedState.BorderThickness = 0
        CheckBoxShowPass.CheckedState.FillColor = SystemColors.ControlLight
        CheckBoxShowPass.CheckMarkColor = SystemColors.Highlight
        CheckBoxShowPass.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxShowPass.ForeColor = Color.White
        CheckBoxShowPass.Location = New Point(66, 197)
        CheckBoxShowPass.Name = "CheckBoxShowPass"
        CheckBoxShowPass.Size = New Size(167, 21)
        CheckBoxShowPass.TabIndex = 7
        CheckBoxShowPass.Text = "SHOW PASSWORD"
        CheckBoxShowPass.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        CheckBoxShowPass.UncheckedState.BorderRadius = 0
        CheckBoxShowPass.UncheckedState.BorderThickness = 0
        CheckBoxShowPass.UncheckedState.FillColor = Color.White
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BackColor = Color.Transparent
        Guna2PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges15
        Guna2PictureBox1.FillColor = Color.Transparent
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(-480, -64)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2PictureBox1.Size = New Size(1074, 700)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox1.TabIndex = 8
        Guna2PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 14.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(111, 238)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 56)
        Label1.TabIndex = 9
        Label1.Text = "Para sa Kawani" & vbCrLf & "Para sa Bayan"
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.Controls.Add(Label2)
        Guna2ShadowPanel1.Controls.Add(LinkLabelSignUp)
        Guna2ShadowPanel1.Controls.Add(txtbxUsername)
        Guna2ShadowPanel1.Controls.Add(bttLogin)
        Guna2ShadowPanel1.Controls.Add(CheckBoxShowPass)
        Guna2ShadowPanel1.Controls.Add(txtbxPassword)
        Guna2ShadowPanel1.FillColor = Color.DarkRed
        Guna2ShadowPanel1.Location = New Point(329, 12)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.Radius = 15
        Guna2ShadowPanel1.ShadowColor = Color.White
        Guna2ShadowPanel1.Size = New Size(394, 418)
        Guna2ShadowPanel1.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(84, 329)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 20)
        Label2.TabIndex = 9
        Label2.Text = "Don't have an account?"
        ' 
        ' LinkLabelSignUp
        ' 
        LinkLabelSignUp.AutoSize = True
        LinkLabelSignUp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabelSignUp.LinkColor = Color.MediumBlue
        LinkLabelSignUp.Location = New Point(249, 328)
        LinkLabelSignUp.Name = "LinkLabelSignUp"
        LinkLabelSignUp.Size = New Size(65, 21)
        LinkLabelSignUp.TabIndex = 8
        LinkLabelSignUp.TabStop = True
        LinkLabelSignUp.Text = "Sign Up"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(749, 442)
        ControlBox = False
        Controls.Add(Guna2ShadowPanel1)
        Controls.Add(Label1)
        Controls.Add(Guna2PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Guna2ShadowPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents txtbxUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CheckBoxShowPass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents bttLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabelSignUp As LinkLabel
End Class
