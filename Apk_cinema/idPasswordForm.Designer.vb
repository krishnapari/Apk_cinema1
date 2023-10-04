<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class idPasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(idPasswordForm))
        Dim BorderEdges1 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges()
        Me.conPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.confirmBtn = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.adminID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'conPass
        '
        Me.conPass.BorderColor = System.Drawing.Color.Transparent
        Me.conPass.BorderRadius = 10
        Me.conPass.BorderThickness = 0
        Me.conPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.conPass.DefaultText = ""
        Me.conPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.conPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.conPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.conPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.conPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.conPass.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.conPass.ForeColor = System.Drawing.Color.Black
        Me.conPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.conPass.Location = New System.Drawing.Point(156, 236)
        Me.conPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.conPass.Name = "conPass"
        Me.conPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.conPass.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.conPass.PlaceholderText = "Con. Password"
        Me.conPass.SelectedText = ""
        Me.conPass.Size = New System.Drawing.Size(224, 37)
        Me.conPass.TabIndex = 10
        '
        'confirmBtn
        '
        Me.confirmBtn.AllowAnimations = True
        Me.confirmBtn.AllowMouseEffects = True
        Me.confirmBtn.AllowToggling = False
        Me.confirmBtn.AnimationSpeed = 200
        Me.confirmBtn.AutoGenerateColors = False
        Me.confirmBtn.AutoRoundBorders = False
        Me.confirmBtn.AutoSizeLeftIcon = True
        Me.confirmBtn.AutoSizeRightIcon = True
        Me.confirmBtn.BackColor = System.Drawing.Color.Transparent
        Me.confirmBtn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.confirmBtn.BackgroundImage = CType(resources.GetObject("confirmBtn.BackgroundImage"), System.Drawing.Image)
        Me.confirmBtn.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.confirmBtn.ButtonText = "Confirm"
        Me.confirmBtn.ButtonTextMarginLeft = 0
        Me.confirmBtn.ColorContrastOnClick = 45
        Me.confirmBtn.ColorContrastOnHover = 45
        Me.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.confirmBtn.CustomizableEdges = BorderEdges1
        Me.confirmBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.confirmBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.confirmBtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.confirmBtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.confirmBtn.FocusState = Bunifu.UI.Winforms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.confirmBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmBtn.ForeColor = System.Drawing.Color.White
        Me.confirmBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.confirmBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.confirmBtn.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.confirmBtn.IconMarginLeft = 11
        Me.confirmBtn.IconPadding = 10
        Me.confirmBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.confirmBtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.confirmBtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.confirmBtn.IconSize = 25
        Me.confirmBtn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.confirmBtn.IdleBorderRadius = 10
        Me.confirmBtn.IdleBorderThickness = 3
        Me.confirmBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.confirmBtn.IdleIconLeftImage = Nothing
        Me.confirmBtn.IdleIconRightImage = Nothing
        Me.confirmBtn.IndicateFocus = False
        Me.confirmBtn.Location = New System.Drawing.Point(162, 321)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.confirmBtn.OnDisabledState.BorderRadius = 10
        Me.confirmBtn.OnDisabledState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.confirmBtn.OnDisabledState.BorderThickness = 3
        Me.confirmBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.confirmBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.confirmBtn.OnDisabledState.IconLeftImage = Nothing
        Me.confirmBtn.OnDisabledState.IconRightImage = Nothing
        Me.confirmBtn.onHoverState.BorderColor = System.Drawing.Color.Lime
        Me.confirmBtn.onHoverState.BorderRadius = 10
        Me.confirmBtn.onHoverState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.confirmBtn.onHoverState.BorderThickness = 3
        Me.confirmBtn.onHoverState.FillColor = System.Drawing.Color.Lime
        Me.confirmBtn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.confirmBtn.onHoverState.IconLeftImage = Nothing
        Me.confirmBtn.onHoverState.IconRightImage = Nothing
        Me.confirmBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.confirmBtn.OnIdleState.BorderRadius = 10
        Me.confirmBtn.OnIdleState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.confirmBtn.OnIdleState.BorderThickness = 3
        Me.confirmBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.confirmBtn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.confirmBtn.OnIdleState.IconLeftImage = Nothing
        Me.confirmBtn.OnIdleState.IconRightImage = Nothing
        Me.confirmBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.confirmBtn.OnPressedState.BorderRadius = 10
        Me.confirmBtn.OnPressedState.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.confirmBtn.OnPressedState.BorderThickness = 3
        Me.confirmBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.confirmBtn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.confirmBtn.OnPressedState.IconLeftImage = Nothing
        Me.confirmBtn.OnPressedState.IconRightImage = Nothing
        Me.confirmBtn.Size = New System.Drawing.Size(134, 49)
        Me.confirmBtn.TabIndex = 8
        Me.confirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.confirmBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.confirmBtn.TextMarginLeft = 0
        Me.confirmBtn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.confirmBtn.UseDefaultRadiusAndThickness = True
        '
        'adminID
        '
        Me.adminID.BorderColor = System.Drawing.Color.Transparent
        Me.adminID.BorderRadius = 10
        Me.adminID.BorderThickness = 0
        Me.adminID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.adminID.DefaultText = ""
        Me.adminID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.adminID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.adminID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.adminID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.adminID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.adminID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.adminID.ForeColor = System.Drawing.Color.Black
        Me.adminID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.adminID.Location = New System.Drawing.Point(155, 170)
        Me.adminID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.adminID.Name = "adminID"
        Me.adminID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.adminID.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.adminID.PlaceholderText = "Admin ID"
        Me.adminID.SelectedText = ""
        Me.adminID.Size = New System.Drawing.Size(224, 37)
        Me.adminID.TabIndex = 7
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.Transparent
        Me.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.backBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.backBtn.ForeColor = System.Drawing.Color.Transparent
        Me.backBtn.Image = CType(resources.GetObject("backBtn.Image"), System.Drawing.Image)
        Me.backBtn.Location = New System.Drawing.Point(8, 7)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(64, 41)
        Me.backBtn.TabIndex = 11
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Tag = "regDetail"
        Me.Label1.Text = "Admin ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Tag = "regDetail"
        Me.Label2.Text = "Con. Password"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Font = New System.Drawing.Font("Segoe UI Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(96, 67)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(273, 38)
        Me.Label.TabIndex = 22
        Me.Label.Tag = "regDetail"
        Me.Label.Text = "Confirm Password"
        '
        'idPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(448, 418)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.conPass)
        Me.Controls.Add(Me.confirmBtn)
        Me.Controls.Add(Me.adminID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "idPasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "idPasswordForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents conPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents confirmBtn As Bunifu.UI.Winforms.BunifuButton.BunifuButton
    Friend WithEvents adminID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents backBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
End Class
