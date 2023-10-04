<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMovies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addMovies))
        Dim BorderEdges1 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.descriptionTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.clearBtn = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.saveBtn = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.releaseDateTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.durationTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.languageTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.genreTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.typeTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.castTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.directorTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.titleTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.picPanel = New System.Windows.Forms.Panel()
        Me.addPic = New System.Windows.Forms.PictureBox()
        Me.adddock = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addMovieClose = New Bunifu.UI.Winforms.BunifuImageButton()
        Me.AddDocksys = New Bunifu.UI.Winforms.BunifuFormDock()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.picPanel.SuspendLayout()
        CType(Me.addPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adddock.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label6)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.descriptionTxt)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Panel1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.picPanel)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.adddock)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1073, 830)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(35, 613)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 28)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Description"
        '
        'descriptionTxt
        '
        Me.descriptionTxt.BorderColor = System.Drawing.Color.Gray
        Me.descriptionTxt.BorderRadius = 10
        Me.descriptionTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.descriptionTxt.DefaultText = ""
        Me.descriptionTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.descriptionTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.descriptionTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.descriptionTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.descriptionTxt.FillColor = System.Drawing.Color.Transparent
        Me.descriptionTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.descriptionTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionTxt.ForeColor = System.Drawing.Color.Gainsboro
        Me.descriptionTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.descriptionTxt.Location = New System.Drawing.Point(31, 652)
        Me.descriptionTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.descriptionTxt.Multiline = True
        Me.descriptionTxt.Name = "descriptionTxt"
        Me.descriptionTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.descriptionTxt.PlaceholderForeColor = System.Drawing.Color.Transparent
        Me.descriptionTxt.PlaceholderText = ""
        Me.descriptionTxt.SelectedText = ""
        Me.descriptionTxt.Size = New System.Drawing.Size(439, 146)
        Me.descriptionTxt.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.clearBtn)
        Me.Panel1.Controls.Add(Me.saveBtn)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.releaseDateTxt)
        Me.Panel1.Controls.Add(Me.durationTxt)
        Me.Panel1.Controls.Add(Me.languageTxt)
        Me.Panel1.Controls.Add(Me.genreTxt)
        Me.Panel1.Controls.Add(Me.typeTxt)
        Me.Panel1.Controls.Add(Me.castTxt)
        Me.Panel1.Controls.Add(Me.directorTxt)
        Me.Panel1.Controls.Add(Me.titleTxt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(492, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 774)
        Me.Panel1.TabIndex = 5
        '
        'clearBtn
        '
        Me.clearBtn.AllowAnimations = True
        Me.clearBtn.AllowMouseEffects = True
        Me.clearBtn.AllowToggling = False
        Me.clearBtn.AnimationSpeed = 200
        Me.clearBtn.AutoGenerateColors = False
        Me.clearBtn.AutoRoundBorders = False
        Me.clearBtn.AutoSizeLeftIcon = True
        Me.clearBtn.AutoSizeRightIcon = True
        Me.clearBtn.BackColor = System.Drawing.Color.Transparent
        Me.clearBtn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.clearBtn.BackgroundImage = CType(resources.GetObject("clearBtn.BackgroundImage"), System.Drawing.Image)
        Me.clearBtn.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.clearBtn.ButtonText = "Clear"
        Me.clearBtn.ButtonTextMarginLeft = 0
        Me.clearBtn.ColorContrastOnClick = 45
        Me.clearBtn.ColorContrastOnHover = 45
        Me.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.clearBtn.CustomizableEdges = BorderEdges1
        Me.clearBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.clearBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.clearBtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.clearBtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.clearBtn.FocusState = Bunifu.UI.Winforms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.clearBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.Color.White
        Me.clearBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clearBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.clearBtn.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.clearBtn.IconMarginLeft = 11
        Me.clearBtn.IconPadding = 10
        Me.clearBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.clearBtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.clearBtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.clearBtn.IconSize = 25
        Me.clearBtn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.clearBtn.IdleBorderRadius = 10
        Me.clearBtn.IdleBorderThickness = 3
        Me.clearBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.clearBtn.IdleIconLeftImage = Nothing
        Me.clearBtn.IdleIconRightImage = Nothing
        Me.clearBtn.IndicateFocus = False
        Me.clearBtn.Location = New System.Drawing.Point(336, 641)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.clearBtn.OnDisabledState.BorderRadius = 10
        Me.clearBtn.OnDisabledState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.clearBtn.OnDisabledState.BorderThickness = 3
        Me.clearBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.clearBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.clearBtn.OnDisabledState.IconLeftImage = Nothing
        Me.clearBtn.OnDisabledState.IconRightImage = Nothing
        Me.clearBtn.onHoverState.BorderColor = System.Drawing.Color.Lime
        Me.clearBtn.onHoverState.BorderRadius = 10
        Me.clearBtn.onHoverState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.clearBtn.onHoverState.BorderThickness = 3
        Me.clearBtn.onHoverState.FillColor = System.Drawing.Color.Lime
        Me.clearBtn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.clearBtn.onHoverState.IconLeftImage = Nothing
        Me.clearBtn.onHoverState.IconRightImage = Nothing
        Me.clearBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.clearBtn.OnIdleState.BorderRadius = 10
        Me.clearBtn.OnIdleState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.clearBtn.OnIdleState.BorderThickness = 3
        Me.clearBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.clearBtn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.clearBtn.OnIdleState.IconLeftImage = Nothing
        Me.clearBtn.OnIdleState.IconRightImage = Nothing
        Me.clearBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.clearBtn.OnPressedState.BorderRadius = 10
        Me.clearBtn.OnPressedState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.clearBtn.OnPressedState.BorderThickness = 3
        Me.clearBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.clearBtn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.clearBtn.OnPressedState.IconLeftImage = Nothing
        Me.clearBtn.OnPressedState.IconRightImage = Nothing
        Me.clearBtn.Size = New System.Drawing.Size(134, 49)
        Me.clearBtn.TabIndex = 53
        Me.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.clearBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.clearBtn.TextMarginLeft = 0
        Me.clearBtn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.clearBtn.UseDefaultRadiusAndThickness = True
        '
        'saveBtn
        '
        Me.saveBtn.AllowAnimations = True
        Me.saveBtn.AllowMouseEffects = True
        Me.saveBtn.AllowToggling = False
        Me.saveBtn.AnimationSpeed = 200
        Me.saveBtn.AutoGenerateColors = False
        Me.saveBtn.AutoRoundBorders = False
        Me.saveBtn.AutoSizeLeftIcon = True
        Me.saveBtn.AutoSizeRightIcon = True
        Me.saveBtn.BackColor = System.Drawing.Color.Transparent
        Me.saveBtn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.saveBtn.BackgroundImage = CType(resources.GetObject("saveBtn.BackgroundImage"), System.Drawing.Image)
        Me.saveBtn.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.saveBtn.ButtonText = "Save"
        Me.saveBtn.ButtonTextMarginLeft = 0
        Me.saveBtn.ColorContrastOnClick = 45
        Me.saveBtn.ColorContrastOnHover = 45
        Me.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.saveBtn.CustomizableEdges = BorderEdges2
        Me.saveBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.saveBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.saveBtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.saveBtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.saveBtn.FocusState = Bunifu.UI.Winforms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.saveBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.Color.White
        Me.saveBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.saveBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.saveBtn.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.saveBtn.IconMarginLeft = 11
        Me.saveBtn.IconPadding = 10
        Me.saveBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.saveBtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.saveBtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.saveBtn.IconSize = 25
        Me.saveBtn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.saveBtn.IdleBorderRadius = 10
        Me.saveBtn.IdleBorderThickness = 3
        Me.saveBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.saveBtn.IdleIconLeftImage = Nothing
        Me.saveBtn.IdleIconRightImage = Nothing
        Me.saveBtn.IndicateFocus = False
        Me.saveBtn.Location = New System.Drawing.Point(132, 641)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.saveBtn.OnDisabledState.BorderRadius = 10
        Me.saveBtn.OnDisabledState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.saveBtn.OnDisabledState.BorderThickness = 3
        Me.saveBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.saveBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.saveBtn.OnDisabledState.IconLeftImage = Nothing
        Me.saveBtn.OnDisabledState.IconRightImage = Nothing
        Me.saveBtn.onHoverState.BorderColor = System.Drawing.Color.Lime
        Me.saveBtn.onHoverState.BorderRadius = 10
        Me.saveBtn.onHoverState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.saveBtn.onHoverState.BorderThickness = 3
        Me.saveBtn.onHoverState.FillColor = System.Drawing.Color.Lime
        Me.saveBtn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.saveBtn.onHoverState.IconLeftImage = Nothing
        Me.saveBtn.onHoverState.IconRightImage = Nothing
        Me.saveBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.saveBtn.OnIdleState.BorderRadius = 10
        Me.saveBtn.OnIdleState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.saveBtn.OnIdleState.BorderThickness = 3
        Me.saveBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.saveBtn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.saveBtn.OnIdleState.IconLeftImage = Nothing
        Me.saveBtn.OnIdleState.IconRightImage = Nothing
        Me.saveBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.saveBtn.OnPressedState.BorderRadius = 10
        Me.saveBtn.OnPressedState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.saveBtn.OnPressedState.BorderThickness = 3
        Me.saveBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.saveBtn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.saveBtn.OnPressedState.IconLeftImage = Nothing
        Me.saveBtn.OnPressedState.IconRightImage = Nothing
        Me.saveBtn.Size = New System.Drawing.Size(134, 49)
        Me.saveBtn.TabIndex = 52
        Me.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.saveBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.saveBtn.TextMarginLeft = 0
        Me.saveBtn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.saveBtn.UseDefaultRadiusAndThickness = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(32, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 41)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Detail"
        '
        'releaseDateTxt
        '
        Me.releaseDateTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.releaseDateTxt.AutoSize = True
        Me.releaseDateTxt.BorderColor = System.Drawing.Color.Transparent
        Me.releaseDateTxt.BorderRadius = 10
        Me.releaseDateTxt.BorderThickness = 0
        Me.releaseDateTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.releaseDateTxt.DefaultText = ""
        Me.releaseDateTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.releaseDateTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.releaseDateTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.releaseDateTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.releaseDateTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.releaseDateTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.releaseDateTxt.ForeColor = System.Drawing.Color.Black
        Me.releaseDateTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.releaseDateTxt.Location = New System.Drawing.Point(232, 288)
        Me.releaseDateTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.releaseDateTxt.Name = "releaseDateTxt"
        Me.releaseDateTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.releaseDateTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.releaseDateTxt.PlaceholderText = "Release Date"
        Me.releaseDateTxt.SelectedText = ""
        Me.releaseDateTxt.Size = New System.Drawing.Size(260, 37)
        Me.releaseDateTxt.TabIndex = 50
        Me.releaseDateTxt.Tag = ""
        '
        'durationTxt
        '
        Me.durationTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.durationTxt.AutoSize = True
        Me.durationTxt.BorderColor = System.Drawing.Color.Transparent
        Me.durationTxt.BorderRadius = 10
        Me.durationTxt.BorderThickness = 0
        Me.durationTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.durationTxt.DefaultText = ""
        Me.durationTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.durationTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.durationTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.durationTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.durationTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.durationTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.durationTxt.ForeColor = System.Drawing.Color.Black
        Me.durationTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.durationTxt.Location = New System.Drawing.Point(192, 338)
        Me.durationTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.durationTxt.Name = "durationTxt"
        Me.durationTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.durationTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.durationTxt.PlaceholderText = "Duration"
        Me.durationTxt.SelectedText = ""
        Me.durationTxt.Size = New System.Drawing.Size(300, 37)
        Me.durationTxt.TabIndex = 49
        Me.durationTxt.Tag = ""
        '
        'languageTxt
        '
        Me.languageTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.languageTxt.AutoSize = True
        Me.languageTxt.BorderColor = System.Drawing.Color.Transparent
        Me.languageTxt.BorderRadius = 10
        Me.languageTxt.BorderThickness = 0
        Me.languageTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.languageTxt.DefaultText = ""
        Me.languageTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.languageTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.languageTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.languageTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.languageTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.languageTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.languageTxt.ForeColor = System.Drawing.Color.Black
        Me.languageTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.languageTxt.Location = New System.Drawing.Point(200, 388)
        Me.languageTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.languageTxt.Name = "languageTxt"
        Me.languageTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.languageTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.languageTxt.PlaceholderText = "Language"
        Me.languageTxt.SelectedText = ""
        Me.languageTxt.Size = New System.Drawing.Size(292, 37)
        Me.languageTxt.TabIndex = 48
        Me.languageTxt.Tag = ""
        '
        'genreTxt
        '
        Me.genreTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.genreTxt.AutoSize = True
        Me.genreTxt.BorderColor = System.Drawing.Color.Transparent
        Me.genreTxt.BorderRadius = 10
        Me.genreTxt.BorderThickness = 0
        Me.genreTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.genreTxt.DefaultText = ""
        Me.genreTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.genreTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.genreTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.genreTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.genreTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.genreTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.genreTxt.ForeColor = System.Drawing.Color.Black
        Me.genreTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.genreTxt.Location = New System.Drawing.Point(168, 437)
        Me.genreTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.genreTxt.Name = "genreTxt"
        Me.genreTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.genreTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.genreTxt.PlaceholderText = "Genre"
        Me.genreTxt.SelectedText = ""
        Me.genreTxt.Size = New System.Drawing.Size(323, 37)
        Me.genreTxt.TabIndex = 47
        Me.genreTxt.Tag = ""
        '
        'typeTxt
        '
        Me.typeTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.typeTxt.AutoSize = True
        Me.typeTxt.BorderColor = System.Drawing.Color.Transparent
        Me.typeTxt.BorderRadius = 10
        Me.typeTxt.BorderThickness = 0
        Me.typeTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.typeTxt.DefaultText = ""
        Me.typeTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.typeTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.typeTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.typeTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.typeTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.typeTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.typeTxt.ForeColor = System.Drawing.Color.Black
        Me.typeTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.typeTxt.Location = New System.Drawing.Point(155, 485)
        Me.typeTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.typeTxt.Name = "typeTxt"
        Me.typeTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.typeTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.typeTxt.PlaceholderText = "Type"
        Me.typeTxt.SelectedText = ""
        Me.typeTxt.Size = New System.Drawing.Size(337, 37)
        Me.typeTxt.TabIndex = 46
        Me.typeTxt.Tag = ""
        '
        'castTxt
        '
        Me.castTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.castTxt.AutoSize = True
        Me.castTxt.BorderColor = System.Drawing.Color.Transparent
        Me.castTxt.BorderRadius = 10
        Me.castTxt.BorderThickness = 0
        Me.castTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.castTxt.DefaultText = ""
        Me.castTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.castTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.castTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.castTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.castTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.castTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.castTxt.ForeColor = System.Drawing.Color.Black
        Me.castTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.castTxt.Location = New System.Drawing.Point(152, 239)
        Me.castTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.castTxt.Name = "castTxt"
        Me.castTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.castTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.castTxt.PlaceholderText = "Cast"
        Me.castTxt.SelectedText = ""
        Me.castTxt.Size = New System.Drawing.Size(339, 37)
        Me.castTxt.TabIndex = 45
        Me.castTxt.Tag = ""
        '
        'directorTxt
        '
        Me.directorTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.directorTxt.AutoSize = True
        Me.directorTxt.BorderColor = System.Drawing.Color.Transparent
        Me.directorTxt.BorderRadius = 10
        Me.directorTxt.BorderThickness = 0
        Me.directorTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.directorTxt.DefaultText = ""
        Me.directorTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.directorTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.directorTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.directorTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.directorTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.directorTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.directorTxt.ForeColor = System.Drawing.Color.Black
        Me.directorTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.directorTxt.Location = New System.Drawing.Point(219, 192)
        Me.directorTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.directorTxt.Name = "directorTxt"
        Me.directorTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.directorTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.directorTxt.PlaceholderText = "Directed by"
        Me.directorTxt.SelectedText = ""
        Me.directorTxt.Size = New System.Drawing.Size(273, 37)
        Me.directorTxt.TabIndex = 44
        Me.directorTxt.Tag = ""
        '
        'titleTxt
        '
        Me.titleTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.titleTxt.AutoSize = True
        Me.titleTxt.BorderColor = System.Drawing.Color.Transparent
        Me.titleTxt.BorderRadius = 10
        Me.titleTxt.BorderThickness = 0
        Me.titleTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.titleTxt.DefaultText = ""
        Me.titleTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.titleTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.titleTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.titleTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.titleTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.titleTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.titleTxt.ForeColor = System.Drawing.Color.Black
        Me.titleTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.titleTxt.Location = New System.Drawing.Point(154, 143)
        Me.titleTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.titleTxt.Name = "titleTxt"
        Me.titleTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.titleTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.titleTxt.PlaceholderText = "Title"
        Me.titleTxt.SelectedText = ""
        Me.titleTxt.Size = New System.Drawing.Size(337, 37)
        Me.titleTxt.TabIndex = 43
        Me.titleTxt.Tag = ""
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(79, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 28)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Type :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(79, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 28)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Title :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(79, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 28)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Genre :"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(79, 390)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 28)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Language :"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(79, 340)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 28)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Duration :"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(79, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 28)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Release Date :"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(79, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 28)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Cast :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(79, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 28)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Directed by :"
        '
        'picPanel
        '
        Me.picPanel.BackColor = System.Drawing.Color.Transparent
        Me.picPanel.Controls.Add(Me.addPic)
        Me.picPanel.Location = New System.Drawing.Point(33, 85)
        Me.picPanel.Name = "picPanel"
        Me.picPanel.Size = New System.Drawing.Size(422, 494)
        Me.picPanel.TabIndex = 4
        '
        'addPic
        '
        Me.addPic.BackColor = System.Drawing.Color.Transparent
        Me.addPic.BackgroundImage = CType(resources.GetObject("addPic.BackgroundImage"), System.Drawing.Image)
        Me.addPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.addPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addPic.Location = New System.Drawing.Point(0, 0)
        Me.addPic.Name = "addPic"
        Me.addPic.Size = New System.Drawing.Size(422, 494)
        Me.addPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addPic.TabIndex = 3
        Me.addPic.TabStop = False
        '
        'adddock
        '
        Me.adddock.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.adddock.Controls.Add(Me.Label1)
        Me.adddock.Controls.Add(Me.addMovieClose)
        Me.adddock.Dock = System.Windows.Forms.DockStyle.Top
        Me.adddock.Location = New System.Drawing.Point(0, 0)
        Me.adddock.Name = "adddock"
        Me.adddock.Size = New System.Drawing.Size(1073, 56)
        Me.adddock.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(73, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 50)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "APK Cinema"
        '
        'addMovieClose
        '
        Me.addMovieClose.ActiveImage = Nothing
        Me.addMovieClose.AllowAnimations = True
        Me.addMovieClose.AllowBuffering = False
        Me.addMovieClose.AllowToggling = False
        Me.addMovieClose.AllowZooming = True
        Me.addMovieClose.AllowZoomingOnFocus = False
        Me.addMovieClose.BackColor = System.Drawing.Color.Transparent
        Me.addMovieClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.addMovieClose.ErrorImage = CType(resources.GetObject("addMovieClose.ErrorImage"), System.Drawing.Image)
        Me.addMovieClose.FadeWhenInactive = False
        Me.addMovieClose.Flip = Bunifu.UI.Winforms.BunifuImageButton.FlipOrientation.Normal
        Me.addMovieClose.Image = CType(resources.GetObject("addMovieClose.Image"), System.Drawing.Image)
        Me.addMovieClose.ImageActive = Nothing
        Me.addMovieClose.ImageLocation = Nothing
        Me.addMovieClose.ImageMargin = 10
        Me.addMovieClose.ImageSize = New System.Drawing.Size(39, 37)
        Me.addMovieClose.ImageZoomSize = New System.Drawing.Size(49, 47)
        Me.addMovieClose.InitialImage = CType(resources.GetObject("addMovieClose.InitialImage"), System.Drawing.Image)
        Me.addMovieClose.Location = New System.Drawing.Point(9, 3)
        Me.addMovieClose.Name = "addMovieClose"
        Me.addMovieClose.Rotation = 0
        Me.addMovieClose.ShowActiveImage = True
        Me.addMovieClose.ShowCursorChanges = True
        Me.addMovieClose.ShowImageBorders = True
        Me.addMovieClose.ShowSizeMarkers = False
        Me.addMovieClose.Size = New System.Drawing.Size(49, 47)
        Me.addMovieClose.TabIndex = 3
        Me.addMovieClose.ToolTipText = ""
        Me.addMovieClose.WaitOnLoad = False
        Me.addMovieClose.Zoom = 10
        Me.addMovieClose.ZoomSpeed = 10
        '
        'AddDocksys
        '
        Me.AddDocksys.AllowFormDragging = True
        Me.AddDocksys.AllowFormDropShadow = True
        Me.AddDocksys.AllowFormResizing = False
        Me.AddDocksys.AllowHidingBottomRegion = True
        Me.AddDocksys.AllowOpacityChangesWhileDragging = False
        Me.AddDocksys.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver
        Me.AddDocksys.BorderOptions.BottomBorder.BorderThickness = 1
        Me.AddDocksys.BorderOptions.BottomBorder.ShowBorder = True
        Me.AddDocksys.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver
        Me.AddDocksys.BorderOptions.LeftBorder.BorderThickness = 1
        Me.AddDocksys.BorderOptions.LeftBorder.ShowBorder = True
        Me.AddDocksys.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver
        Me.AddDocksys.BorderOptions.RightBorder.BorderThickness = 1
        Me.AddDocksys.BorderOptions.RightBorder.ShowBorder = True
        Me.AddDocksys.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver
        Me.AddDocksys.BorderOptions.TopBorder.BorderThickness = 1
        Me.AddDocksys.BorderOptions.TopBorder.ShowBorder = True
        Me.AddDocksys.ContainerControl = Me
        Me.AddDocksys.DockingIndicatorsColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.AddDocksys.DockingIndicatorsOpacity = 0.5R
        Me.AddDocksys.DockingOptions.DockAll = True
        Me.AddDocksys.DockingOptions.DockBottomLeft = True
        Me.AddDocksys.DockingOptions.DockBottomRight = True
        Me.AddDocksys.DockingOptions.DockFullScreen = True
        Me.AddDocksys.DockingOptions.DockLeft = True
        Me.AddDocksys.DockingOptions.DockRight = True
        Me.AddDocksys.DockingOptions.DockTopLeft = True
        Me.AddDocksys.DockingOptions.DockTopRight = True
        Me.AddDocksys.FormDraggingOpacity = 0.9R
        Me.AddDocksys.ParentForm = Me
        Me.AddDocksys.ShowCursorChanges = False
        Me.AddDocksys.ShowDockingIndicators = False
        Me.AddDocksys.TitleBarOptions.AllowFormDragging = True
        Me.AddDocksys.TitleBarOptions.BunifuFormDock = Me.AddDocksys
        Me.AddDocksys.TitleBarOptions.DoubleClickToExpandWindow = True
        Me.AddDocksys.TitleBarOptions.TitleBarControl = Me.adddock
        Me.AddDocksys.TitleBarOptions.UseBackColorOnDockingIndicators = False
        '
        'addMovies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 830)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addMovies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "u"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.picPanel.ResumeLayout(False)
        CType(Me.addPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adddock.ResumeLayout(False)
        Me.adddock.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents addPic As PictureBox
    Friend WithEvents adddock As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents addMovieClose As Bunifu.UI.Winforms.BunifuImageButton
    Friend WithEvents picPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents castTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents directorTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents titleTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents releaseDateTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents durationTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents languageTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents genreTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents typeTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents descriptionTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clearBtn As Bunifu.UI.Winforms.BunifuButton.BunifuButton
    Friend WithEvents saveBtn As Bunifu.UI.Winforms.BunifuButton.BunifuButton
    Friend WithEvents Label6 As Label
    Friend WithEvents AddDocksys As Bunifu.UI.Winforms.BunifuFormDock
End Class
