<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Dim BorderEdges1 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.password1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.loginBtn2 = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.adminID1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.password1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.loginBtn2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.adminID1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.backBtn)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Quality = 1000
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(487, 623)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 45)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Admin ID"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(175, 136)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(143, 136)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2CirclePictureBox1.TabIndex = 7
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'password1
        '
        Me.password1.BorderColor = System.Drawing.Color.Transparent
        Me.password1.BorderRadius = 10
        Me.password1.BorderThickness = 0
        Me.password1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password1.DefaultText = ""
        Me.password1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.password1.ForeColor = System.Drawing.Color.Black
        Me.password1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password1.Location = New System.Drawing.Point(148, 372)
        Me.password1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.password1.Name = "password1"
        Me.password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password1.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.password1.PlaceholderText = "Password"
        Me.password1.SelectedText = ""
        Me.password1.Size = New System.Drawing.Size(224, 37)
        Me.password1.TabIndex = 5
        '
        'loginBtn2
        '
        Me.loginBtn2.AllowAnimations = True
        Me.loginBtn2.AllowMouseEffects = True
        Me.loginBtn2.AllowToggling = False
        Me.loginBtn2.AnimationSpeed = 200
        Me.loginBtn2.AutoGenerateColors = False
        Me.loginBtn2.AutoRoundBorders = False
        Me.loginBtn2.AutoSizeLeftIcon = True
        Me.loginBtn2.AutoSizeRightIcon = True
        Me.loginBtn2.BackColor = System.Drawing.Color.Transparent
        Me.loginBtn2.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn2.BackgroundImage = CType(resources.GetObject("loginBtn2.BackgroundImage"), System.Drawing.Image)
        Me.loginBtn2.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn2.ButtonText = "Login"
        Me.loginBtn2.ButtonTextMarginLeft = 0
        Me.loginBtn2.ColorContrastOnClick = 45
        Me.loginBtn2.ColorContrastOnHover = 45
        Me.loginBtn2.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.loginBtn2.CustomizableEdges = BorderEdges1
        Me.loginBtn2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.loginBtn2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.loginBtn2.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.loginBtn2.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.loginBtn2.FocusState = Bunifu.UI.Winforms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.loginBtn2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn2.ForeColor = System.Drawing.Color.White
        Me.loginBtn2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginBtn2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.loginBtn2.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.loginBtn2.IconMarginLeft = 11
        Me.loginBtn2.IconPadding = 10
        Me.loginBtn2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.loginBtn2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.loginBtn2.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.loginBtn2.IconSize = 25
        Me.loginBtn2.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn2.IdleBorderRadius = 10
        Me.loginBtn2.IdleBorderThickness = 3
        Me.loginBtn2.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn2.IdleIconLeftImage = Nothing
        Me.loginBtn2.IdleIconRightImage = Nothing
        Me.loginBtn2.IndicateFocus = False
        Me.loginBtn2.Location = New System.Drawing.Point(181, 463)
        Me.loginBtn2.Name = "loginBtn2"
        Me.loginBtn2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.loginBtn2.OnDisabledState.BorderRadius = 10
        Me.loginBtn2.OnDisabledState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn2.OnDisabledState.BorderThickness = 3
        Me.loginBtn2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.loginBtn2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.loginBtn2.OnDisabledState.IconLeftImage = Nothing
        Me.loginBtn2.OnDisabledState.IconRightImage = Nothing
        Me.loginBtn2.onHoverState.BorderColor = System.Drawing.Color.Lime
        Me.loginBtn2.onHoverState.BorderRadius = 10
        Me.loginBtn2.onHoverState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn2.onHoverState.BorderThickness = 3
        Me.loginBtn2.onHoverState.FillColor = System.Drawing.Color.Lime
        Me.loginBtn2.onHoverState.ForeColor = System.Drawing.Color.White
        Me.loginBtn2.onHoverState.IconLeftImage = Nothing
        Me.loginBtn2.onHoverState.IconRightImage = Nothing
        Me.loginBtn2.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn2.OnIdleState.BorderRadius = 10
        Me.loginBtn2.OnIdleState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn2.OnIdleState.BorderThickness = 3
        Me.loginBtn2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn2.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.loginBtn2.OnIdleState.IconLeftImage = Nothing
        Me.loginBtn2.OnIdleState.IconRightImage = Nothing
        Me.loginBtn2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn2.OnPressedState.BorderRadius = 10
        Me.loginBtn2.OnPressedState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn2.OnPressedState.BorderThickness = 3
        Me.loginBtn2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn2.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.loginBtn2.OnPressedState.IconLeftImage = Nothing
        Me.loginBtn2.OnPressedState.IconRightImage = Nothing
        Me.loginBtn2.Size = New System.Drawing.Size(134, 49)
        Me.loginBtn2.TabIndex = 3
        Me.loginBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.loginBtn2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.loginBtn2.TextMarginLeft = 0
        Me.loginBtn2.TextPadding = New System.Windows.Forms.Padding(0)
        Me.loginBtn2.UseDefaultRadiusAndThickness = True
        '
        'adminID1
        '
        Me.adminID1.BorderColor = System.Drawing.Color.Transparent
        Me.adminID1.BorderRadius = 10
        Me.adminID1.BorderThickness = 0
        Me.adminID1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.adminID1.DefaultText = ""
        Me.adminID1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.adminID1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.adminID1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.adminID1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.adminID1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.adminID1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.adminID1.ForeColor = System.Drawing.Color.Black
        Me.adminID1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.adminID1.Location = New System.Drawing.Point(148, 306)
        Me.adminID1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.adminID1.Name = "adminID1"
        Me.adminID1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.adminID1.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.adminID1.PlaceholderText = "Admin id"
        Me.adminID1.SelectedText = ""
        Me.adminID1.Size = New System.Drawing.Size(224, 37)
        Me.adminID1.TabIndex = 2
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.Transparent
        Me.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.backBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.backBtn.ForeColor = System.Drawing.Color.Transparent
        Me.backBtn.Image = CType(resources.GetObject("backBtn.Image"), System.Drawing.Image)
        Me.backBtn.Location = New System.Drawing.Point(7, 8)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(64, 41)
        Me.backBtn.TabIndex = 0
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 623)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginForm"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents backBtn As Button
    Friend WithEvents adminID1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents loginBtn2 As Bunifu.UI.Winforms.BunifuButton.BunifuButton
    Friend WithEvents password1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
