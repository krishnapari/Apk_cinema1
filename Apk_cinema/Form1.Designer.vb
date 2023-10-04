<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim BorderEdges1 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.registerBtn = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.loginBtn1 = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.BunifuImageButton1 = New Bunifu.UI.Winforms.BunifuImageButton()
        Me.BunifuFormDock1 = New Bunifu.UI.Winforms.BunifuFormDock()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.registerBtn)
        Me.Panel1.Controls.Add(Me.loginBtn1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1186, 651)
        Me.Panel1.TabIndex = 0
        '
        'registerBtn
        '
        Me.registerBtn.AllowAnimations = True
        Me.registerBtn.AllowMouseEffects = True
        Me.registerBtn.AllowToggling = False
        Me.registerBtn.AnimationSpeed = 200
        Me.registerBtn.AutoGenerateColors = False
        Me.registerBtn.AutoRoundBorders = False
        Me.registerBtn.AutoSizeLeftIcon = True
        Me.registerBtn.AutoSizeRightIcon = True
        Me.registerBtn.BackColor = System.Drawing.Color.Transparent
        Me.registerBtn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.registerBtn.BackgroundImage = CType(resources.GetObject("registerBtn.BackgroundImage"), System.Drawing.Image)
        Me.registerBtn.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.registerBtn.ButtonText = "Register"
        Me.registerBtn.ButtonTextMarginLeft = 0
        Me.registerBtn.ColorContrastOnClick = 45
        Me.registerBtn.ColorContrastOnHover = 45
        Me.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.registerBtn.CustomizableEdges = BorderEdges1
        Me.registerBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.registerBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.registerBtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.registerBtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.registerBtn.FocusState = Bunifu.UI.Winforms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.registerBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerBtn.ForeColor = System.Drawing.Color.White
        Me.registerBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.registerBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.registerBtn.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.registerBtn.IconMarginLeft = 11
        Me.registerBtn.IconPadding = 10
        Me.registerBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.registerBtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.registerBtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.registerBtn.IconSize = 25
        Me.registerBtn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.registerBtn.IdleBorderRadius = 10
        Me.registerBtn.IdleBorderThickness = 3
        Me.registerBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.registerBtn.IdleIconLeftImage = Nothing
        Me.registerBtn.IdleIconRightImage = Nothing
        Me.registerBtn.IndicateFocus = False
        Me.registerBtn.Location = New System.Drawing.Point(548, 505)
        Me.registerBtn.Name = "registerBtn"
        Me.registerBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.registerBtn.OnDisabledState.BorderRadius = 10
        Me.registerBtn.OnDisabledState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.registerBtn.OnDisabledState.BorderThickness = 3
        Me.registerBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.registerBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.registerBtn.OnDisabledState.IconLeftImage = Nothing
        Me.registerBtn.OnDisabledState.IconRightImage = Nothing
        Me.registerBtn.onHoverState.BorderColor = System.Drawing.Color.Lime
        Me.registerBtn.onHoverState.BorderRadius = 10
        Me.registerBtn.onHoverState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.registerBtn.onHoverState.BorderThickness = 3
        Me.registerBtn.onHoverState.FillColor = System.Drawing.Color.Lime
        Me.registerBtn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.registerBtn.onHoverState.IconLeftImage = Nothing
        Me.registerBtn.onHoverState.IconRightImage = Nothing
        Me.registerBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.registerBtn.OnIdleState.BorderRadius = 10
        Me.registerBtn.OnIdleState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.registerBtn.OnIdleState.BorderThickness = 3
        Me.registerBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.registerBtn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.registerBtn.OnIdleState.IconLeftImage = Nothing
        Me.registerBtn.OnIdleState.IconRightImage = Nothing
        Me.registerBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.registerBtn.OnPressedState.BorderRadius = 10
        Me.registerBtn.OnPressedState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.registerBtn.OnPressedState.BorderThickness = 3
        Me.registerBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.registerBtn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.registerBtn.OnPressedState.IconLeftImage = Nothing
        Me.registerBtn.OnPressedState.IconRightImage = Nothing
        Me.registerBtn.Size = New System.Drawing.Size(134, 49)
        Me.registerBtn.TabIndex = 1
        Me.registerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.registerBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.registerBtn.TextMarginLeft = 0
        Me.registerBtn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.registerBtn.UseDefaultRadiusAndThickness = True
        '
        'loginBtn1
        '
        Me.loginBtn1.AllowAnimations = True
        Me.loginBtn1.AllowMouseEffects = True
        Me.loginBtn1.AllowToggling = False
        Me.loginBtn1.AnimationSpeed = 200
        Me.loginBtn1.AutoGenerateColors = False
        Me.loginBtn1.AutoRoundBorders = False
        Me.loginBtn1.AutoSizeLeftIcon = True
        Me.loginBtn1.AutoSizeRightIcon = True
        Me.loginBtn1.BackColor = System.Drawing.Color.Transparent
        Me.loginBtn1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn1.BackgroundImage = CType(resources.GetObject("loginBtn1.BackgroundImage"), System.Drawing.Image)
        Me.loginBtn1.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn1.ButtonText = "Login"
        Me.loginBtn1.ButtonTextMarginLeft = 0
        Me.loginBtn1.ColorContrastOnClick = 45
        Me.loginBtn1.ColorContrastOnHover = 45
        Me.loginBtn1.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.loginBtn1.CustomizableEdges = BorderEdges2
        Me.loginBtn1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.loginBtn1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.loginBtn1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.loginBtn1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.loginBtn1.FocusState = Bunifu.UI.Winforms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.loginBtn1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn1.ForeColor = System.Drawing.Color.White
        Me.loginBtn1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginBtn1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.loginBtn1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.loginBtn1.IconMarginLeft = 11
        Me.loginBtn1.IconPadding = 10
        Me.loginBtn1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.loginBtn1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.loginBtn1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.loginBtn1.IconSize = 25
        Me.loginBtn1.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn1.IdleBorderRadius = 10
        Me.loginBtn1.IdleBorderThickness = 3
        Me.loginBtn1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn1.IdleIconLeftImage = Nothing
        Me.loginBtn1.IdleIconRightImage = Nothing
        Me.loginBtn1.IndicateFocus = False
        Me.loginBtn1.Location = New System.Drawing.Point(548, 433)
        Me.loginBtn1.Name = "loginBtn1"
        Me.loginBtn1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.loginBtn1.OnDisabledState.BorderRadius = 10
        Me.loginBtn1.OnDisabledState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn1.OnDisabledState.BorderThickness = 3
        Me.loginBtn1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.loginBtn1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.loginBtn1.OnDisabledState.IconLeftImage = Nothing
        Me.loginBtn1.OnDisabledState.IconRightImage = Nothing
        Me.loginBtn1.onHoverState.BorderColor = System.Drawing.Color.Lime
        Me.loginBtn1.onHoverState.BorderRadius = 10
        Me.loginBtn1.onHoverState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn1.onHoverState.BorderThickness = 3
        Me.loginBtn1.onHoverState.FillColor = System.Drawing.Color.Lime
        Me.loginBtn1.onHoverState.ForeColor = System.Drawing.Color.White
        Me.loginBtn1.onHoverState.IconLeftImage = Nothing
        Me.loginBtn1.onHoverState.IconRightImage = Nothing
        Me.loginBtn1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn1.OnIdleState.BorderRadius = 10
        Me.loginBtn1.OnIdleState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn1.OnIdleState.BorderThickness = 3
        Me.loginBtn1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn1.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.loginBtn1.OnIdleState.IconLeftImage = Nothing
        Me.loginBtn1.OnIdleState.IconRightImage = Nothing
        Me.loginBtn1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn1.OnPressedState.BorderRadius = 10
        Me.loginBtn1.OnPressedState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn1.OnPressedState.BorderThickness = 3
        Me.loginBtn1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.loginBtn1.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.loginBtn1.OnPressedState.IconLeftImage = Nothing
        Me.loginBtn1.OnPressedState.IconRightImage = Nothing
        Me.loginBtn1.Size = New System.Drawing.Size(134, 49)
        Me.loginBtn1.TabIndex = 0
        Me.loginBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.loginBtn1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.loginBtn1.TextMarginLeft = 0
        Me.loginBtn1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.loginBtn1.UseDefaultRadiusAndThickness = True
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.ActiveImage = Nothing
        Me.BunifuImageButton1.AllowAnimations = True
        Me.BunifuImageButton1.AllowBuffering = False
        Me.BunifuImageButton1.AllowToggling = False
        Me.BunifuImageButton1.AllowZooming = True
        Me.BunifuImageButton1.AllowZoomingOnFocus = False
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuImageButton1.ErrorImage = CType(resources.GetObject("BunifuImageButton1.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton1.FadeWhenInactive = False
        Me.BunifuImageButton1.Flip = Bunifu.UI.Winforms.BunifuImageButton.FlipOrientation.Normal
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.ImageLocation = Nothing
        Me.BunifuImageButton1.ImageMargin = 10
        Me.BunifuImageButton1.ImageSize = New System.Drawing.Size(33, 31)
        Me.BunifuImageButton1.ImageZoomSize = New System.Drawing.Size(43, 41)
        Me.BunifuImageButton1.InitialImage = CType(resources.GetObject("BunifuImageButton1.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1137, 7)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Rotation = 0
        Me.BunifuImageButton1.ShowActiveImage = True
        Me.BunifuImageButton1.ShowCursorChanges = True
        Me.BunifuImageButton1.ShowImageBorders = True
        Me.BunifuImageButton1.ShowSizeMarkers = False
        Me.BunifuImageButton1.Size = New System.Drawing.Size(43, 41)
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.ToolTipText = ""
        Me.BunifuImageButton1.WaitOnLoad = False
        Me.BunifuImageButton1.Zoom = 10
        Me.BunifuImageButton1.ZoomSpeed = 10
        '
        'BunifuFormDock1
        '
        Me.BunifuFormDock1.AllowFormDragging = True
        Me.BunifuFormDock1.AllowFormDropShadow = True
        Me.BunifuFormDock1.AllowFormResizing = True
        Me.BunifuFormDock1.AllowHidingBottomRegion = True
        Me.BunifuFormDock1.AllowOpacityChangesWhileDragging = False
        Me.BunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = True
        Me.BunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = True
        Me.BunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.RightBorder.ShowBorder = True
        Me.BunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.TopBorder.ShowBorder = True
        Me.BunifuFormDock1.ContainerControl = Me
        Me.BunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BunifuFormDock1.DockingIndicatorsOpacity = 0.5R
        Me.BunifuFormDock1.DockingOptions.DockAll = True
        Me.BunifuFormDock1.DockingOptions.DockBottomLeft = True
        Me.BunifuFormDock1.DockingOptions.DockBottomRight = True
        Me.BunifuFormDock1.DockingOptions.DockFullScreen = True
        Me.BunifuFormDock1.DockingOptions.DockLeft = True
        Me.BunifuFormDock1.DockingOptions.DockRight = True
        Me.BunifuFormDock1.DockingOptions.DockTopLeft = True
        Me.BunifuFormDock1.DockingOptions.DockTopRight = True
        Me.BunifuFormDock1.FormDraggingOpacity = 0.9R
        Me.BunifuFormDock1.ParentForm = Me
        Me.BunifuFormDock1.ShowCursorChanges = True
        Me.BunifuFormDock1.ShowDockingIndicators = True
        Me.BunifuFormDock1.TitleBarOptions.AllowFormDragging = True
        Me.BunifuFormDock1.TitleBarOptions.BunifuFormDock = Me.BunifuFormDock1
        Me.BunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = True
        Me.BunifuFormDock1.TitleBarOptions.TitleBarControl = Nothing
        Me.BunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1186, 710)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.UI.Winforms.BunifuImageButton
    Friend WithEvents BunifuFormDock1 As Bunifu.UI.Winforms.BunifuFormDock
    Friend WithEvents registerBtn As Bunifu.UI.Winforms.BunifuButton.BunifuButton
    Friend WithEvents loginBtn1 As Bunifu.UI.Winforms.BunifuButton.BunifuButton
End Class
