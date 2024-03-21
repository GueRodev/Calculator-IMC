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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrarPrograma = New System.Windows.Forms.Button()
        Me.PanelVertical = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.btnNinoForm = New System.Windows.Forms.Button()
        Me.btnMujerForm = New System.Windows.Forms.Button()
        Me.btnHombreForm = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnLogo = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelTitulo.SuspendLayout()
        Me.PanelVertical.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.btnLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.Label2)
        Me.PanelTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelTitulo.Controls.Add(Me.btnCerrarPrograma)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Margin = New System.Windows.Forms.Padding(6)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(882, 40)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(738, 0)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(62, 40)
        Me.btnRestaurar.TabIndex = 4
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(668, 0)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(72, 40)
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(738, -4)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(62, 52)
        Me.btnMaximizar.TabIndex = 2
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrarPrograma
        '
        Me.btnCerrarPrograma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarPrograma.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnCerrarPrograma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnCerrarPrograma.FlatAppearance.BorderSize = 0
        Me.btnCerrarPrograma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCerrarPrograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarPrograma.ForeColor = System.Drawing.Color.Transparent
        Me.btnCerrarPrograma.Image = CType(resources.GetObject("btnCerrarPrograma.Image"), System.Drawing.Image)
        Me.btnCerrarPrograma.Location = New System.Drawing.Point(798, 0)
        Me.btnCerrarPrograma.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrarPrograma.Name = "btnCerrarPrograma"
        Me.btnCerrarPrograma.Size = New System.Drawing.Size(84, 40)
        Me.btnCerrarPrograma.TabIndex = 1
        Me.btnCerrarPrograma.UseVisualStyleBackColor = True
        '
        'PanelVertical
        '
        Me.PanelVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelVertical.Controls.Add(Me.PictureBox1)
        Me.PanelVertical.Controls.Add(Me.Label1)
        Me.PanelVertical.Controls.Add(Me.btnApagar)
        Me.PanelVertical.Controls.Add(Me.btnNinoForm)
        Me.PanelVertical.Controls.Add(Me.btnMujerForm)
        Me.PanelVertical.Controls.Add(Me.btnHombreForm)
        Me.PanelVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelVertical.Location = New System.Drawing.Point(0, 40)
        Me.PanelVertical.Margin = New System.Windows.Forms.Padding(6)
        Me.PanelVertical.Name = "PanelVertical"
        Me.PanelVertical.Size = New System.Drawing.Size(180, 575)
        Me.PanelVertical.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 58)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Elige el Sexo:"
        '
        'btnApagar
        '
        Me.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApagar.FlatAppearance.BorderSize = 0
        Me.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnApagar.Image = CType(resources.GetObject("btnApagar.Image"), System.Drawing.Image)
        Me.btnApagar.Location = New System.Drawing.Point(0, 452)
        Me.btnApagar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(180, 67)
        Me.btnApagar.TabIndex = 3
        Me.btnApagar.UseVisualStyleBackColor = True
        '
        'btnNinoForm
        '
        Me.btnNinoForm.FlatAppearance.BorderSize = 0
        Me.btnNinoForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnNinoForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnNinoForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNinoForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNinoForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNinoForm.Image = CType(resources.GetObject("btnNinoForm.Image"), System.Drawing.Image)
        Me.btnNinoForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNinoForm.Location = New System.Drawing.Point(0, 344)
        Me.btnNinoForm.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNinoForm.Name = "btnNinoForm"
        Me.btnNinoForm.Size = New System.Drawing.Size(180, 67)
        Me.btnNinoForm.TabIndex = 2
        Me.btnNinoForm.Text = "Niños"
        Me.btnNinoForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNinoForm.UseVisualStyleBackColor = True
        '
        'btnMujerForm
        '
        Me.btnMujerForm.FlatAppearance.BorderSize = 0
        Me.btnMujerForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMujerForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMujerForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMujerForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMujerForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMujerForm.Image = CType(resources.GetObject("btnMujerForm.Image"), System.Drawing.Image)
        Me.btnMujerForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMujerForm.Location = New System.Drawing.Point(0, 242)
        Me.btnMujerForm.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMujerForm.Name = "btnMujerForm"
        Me.btnMujerForm.Size = New System.Drawing.Size(180, 67)
        Me.btnMujerForm.TabIndex = 1
        Me.btnMujerForm.Text = "Mujer"
        Me.btnMujerForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMujerForm.UseVisualStyleBackColor = True
        '
        'btnHombreForm
        '
        Me.btnHombreForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHombreForm.FlatAppearance.BorderSize = 0
        Me.btnHombreForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnHombreForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnHombreForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHombreForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHombreForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHombreForm.Image = CType(resources.GetObject("btnHombreForm.Image"), System.Drawing.Image)
        Me.btnHombreForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHombreForm.Location = New System.Drawing.Point(0, 137)
        Me.btnHombreForm.Margin = New System.Windows.Forms.Padding(6)
        Me.btnHombreForm.Name = "btnHombreForm"
        Me.btnHombreForm.Size = New System.Drawing.Size(180, 67)
        Me.btnHombreForm.TabIndex = 0
        Me.btnHombreForm.Text = "Hombre"
        Me.btnHombreForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHombreForm.UseVisualStyleBackColor = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.White
        Me.PanelContenedor.Controls.Add(Me.btnLogin)
        Me.PanelContenedor.Controls.Add(Me.btnLogo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(180, 40)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(6)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(702, 575)
        Me.PanelContenedor.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(492, 15)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(204, 63)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnLogo
        '
        Me.btnLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnLogo.Image = CType(resources.GetObject("btnLogo.Image"), System.Drawing.Image)
        Me.btnLogo.Location = New System.Drawing.Point(0, 0)
        Me.btnLogo.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(702, 560)
        Me.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogo.TabIndex = 0
        Me.btnLogo.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Calculadora Fitness IMC"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 615)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelVertical)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.PanelVertical.ResumeLayout(False)
        Me.PanelVertical.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.btnLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PanelVertical As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnLogo As PictureBox
    Friend WithEvents btnHombreForm As Button
    Friend WithEvents btnMujerForm As Button
    Friend WithEvents btnNinoForm As Button
    Friend WithEvents btnApagar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCerrarPrograma As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label2 As Label
End Class
