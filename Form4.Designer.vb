<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.PanelTituloForm4 = New System.Windows.Forms.Panel()
        Me.btnRestaurarForm4 = New System.Windows.Forms.Button()
        Me.btnMinimizarForm4 = New System.Windows.Forms.Button()
        Me.btnMaximizarForm4 = New System.Windows.Forms.Button()
        Me.btnCerrarForm4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnApagarForm4 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnForm4Volver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLimpiarNino = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPesoNino = New System.Windows.Forms.TextBox()
        Me.txtAlturaNino = New System.Windows.Forms.TextBox()
        Me.txtEdadNino = New System.Windows.Forms.TextBox()
        Me.txtResultadoNino = New System.Windows.Forms.TextBox()
        Me.ErrorIconoNino = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCalcularNino = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelTituloForm4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIconoNino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTituloForm4
        '
        Me.PanelTituloForm4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PanelTituloForm4.Controls.Add(Me.Label6)
        Me.PanelTituloForm4.Controls.Add(Me.btnRestaurarForm4)
        Me.PanelTituloForm4.Controls.Add(Me.btnMinimizarForm4)
        Me.PanelTituloForm4.Controls.Add(Me.btnMaximizarForm4)
        Me.PanelTituloForm4.Controls.Add(Me.btnCerrarForm4)
        Me.PanelTituloForm4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTituloForm4.Location = New System.Drawing.Point(0, 0)
        Me.PanelTituloForm4.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelTituloForm4.Name = "PanelTituloForm4"
        Me.PanelTituloForm4.Size = New System.Drawing.Size(880, 40)
        Me.PanelTituloForm4.TabIndex = 0
        '
        'btnRestaurarForm4
        '
        Me.btnRestaurarForm4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurarForm4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnRestaurarForm4.FlatAppearance.BorderSize = 0
        Me.btnRestaurarForm4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnRestaurarForm4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnRestaurarForm4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurarForm4.Image = CType(resources.GetObject("btnRestaurarForm4.Image"), System.Drawing.Image)
        Me.btnRestaurarForm4.Location = New System.Drawing.Point(736, 0)
        Me.btnRestaurarForm4.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRestaurarForm4.Name = "btnRestaurarForm4"
        Me.btnRestaurarForm4.Size = New System.Drawing.Size(72, 40)
        Me.btnRestaurarForm4.TabIndex = 3
        Me.btnRestaurarForm4.UseVisualStyleBackColor = True
        Me.btnRestaurarForm4.Visible = False
        '
        'btnMinimizarForm4
        '
        Me.btnMinimizarForm4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizarForm4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMinimizarForm4.FlatAppearance.BorderSize = 0
        Me.btnMinimizarForm4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMinimizarForm4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMinimizarForm4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizarForm4.Image = CType(resources.GetObject("btnMinimizarForm4.Image"), System.Drawing.Image)
        Me.btnMinimizarForm4.Location = New System.Drawing.Point(668, 0)
        Me.btnMinimizarForm4.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMinimizarForm4.Name = "btnMinimizarForm4"
        Me.btnMinimizarForm4.Size = New System.Drawing.Size(72, 40)
        Me.btnMinimizarForm4.TabIndex = 2
        Me.btnMinimizarForm4.UseVisualStyleBackColor = True
        '
        'btnMaximizarForm4
        '
        Me.btnMaximizarForm4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizarForm4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMaximizarForm4.FlatAppearance.BorderSize = 0
        Me.btnMaximizarForm4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMaximizarForm4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMaximizarForm4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizarForm4.Image = CType(resources.GetObject("btnMaximizarForm4.Image"), System.Drawing.Image)
        Me.btnMaximizarForm4.Location = New System.Drawing.Point(738, 0)
        Me.btnMaximizarForm4.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMaximizarForm4.Name = "btnMaximizarForm4"
        Me.btnMaximizarForm4.Size = New System.Drawing.Size(62, 40)
        Me.btnMaximizarForm4.TabIndex = 1
        Me.btnMaximizarForm4.UseVisualStyleBackColor = True
        '
        'btnCerrarForm4
        '
        Me.btnCerrarForm4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnCerrarForm4.FlatAppearance.BorderSize = 0
        Me.btnCerrarForm4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCerrarForm4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrarForm4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarForm4.Image = CType(resources.GetObject("btnCerrarForm4.Image"), System.Drawing.Image)
        Me.btnCerrarForm4.Location = New System.Drawing.Point(798, 0)
        Me.btnCerrarForm4.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCerrarForm4.Name = "btnCerrarForm4"
        Me.btnCerrarForm4.Size = New System.Drawing.Size(84, 40)
        Me.btnCerrarForm4.TabIndex = 0
        Me.btnCerrarForm4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnApagarForm4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 559)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(880, 58)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(76, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Salir"
        '
        'btnApagarForm4
        '
        Me.btnApagarForm4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApagarForm4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApagarForm4.FlatAppearance.BorderSize = 0
        Me.btnApagarForm4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnApagarForm4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnApagarForm4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagarForm4.Image = CType(resources.GetObject("btnApagarForm4.Image"), System.Drawing.Image)
        Me.btnApagarForm4.Location = New System.Drawing.Point(0, 0)
        Me.btnApagarForm4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnApagarForm4.Name = "btnApagarForm4"
        Me.btnApagarForm4.Size = New System.Drawing.Size(72, 56)
        Me.btnApagarForm4.TabIndex = 0
        Me.btnApagarForm4.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 40)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(28, 519)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(850, 40)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(30, 519)
        Me.Panel3.TabIndex = 2
        '
        'btnForm4Volver
        '
        Me.btnForm4Volver.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnForm4Volver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnForm4Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnForm4Volver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnForm4Volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.btnForm4Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnForm4Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForm4Volver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnForm4Volver.Location = New System.Drawing.Point(650, 381)
        Me.btnForm4Volver.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForm4Volver.Name = "btnForm4Volver"
        Me.btnForm4Volver.Size = New System.Drawing.Size(158, 56)
        Me.btnForm4Volver.TabIndex = 3
        Me.btnForm4Volver.Text = "Volver"
        Me.btnForm4Volver.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(298, 100)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(318, 337)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnLimpiarNino
        '
        Me.btnLimpiarNino.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnLimpiarNino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLimpiarNino.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLimpiarNino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnLimpiarNino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLimpiarNino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarNino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLimpiarNino.Location = New System.Drawing.Point(650, 115)
        Me.btnLimpiarNino.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLimpiarNino.Name = "btnLimpiarNino"
        Me.btnLimpiarNino.Size = New System.Drawing.Size(158, 56)
        Me.btnLimpiarNino.TabIndex = 5
        Me.btnLimpiarNino.Text = "Limpiar"
        Me.btnLimpiarNino.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Peso*  (kg)"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 235)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Altura* (cm)"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 367)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Edad* (6-19 años)"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 481)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Resultado IMC Niños"
        '
        'txtPesoNino
        '
        Me.txtPesoNino.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPesoNino.Location = New System.Drawing.Point(46, 133)
        Me.txtPesoNino.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPesoNino.Name = "txtPesoNino"
        Me.txtPesoNino.Size = New System.Drawing.Size(196, 31)
        Me.txtPesoNino.TabIndex = 11
        '
        'txtAlturaNino
        '
        Me.txtAlturaNino.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAlturaNino.Location = New System.Drawing.Point(46, 267)
        Me.txtAlturaNino.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAlturaNino.Name = "txtAlturaNino"
        Me.txtAlturaNino.Size = New System.Drawing.Size(196, 31)
        Me.txtAlturaNino.TabIndex = 12
        '
        'txtEdadNino
        '
        Me.txtEdadNino.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtEdadNino.Location = New System.Drawing.Point(46, 398)
        Me.txtEdadNino.Margin = New System.Windows.Forms.Padding(6)
        Me.txtEdadNino.Name = "txtEdadNino"
        Me.txtEdadNino.Size = New System.Drawing.Size(196, 31)
        Me.txtEdadNino.TabIndex = 13
        '
        'txtResultadoNino
        '
        Me.txtResultadoNino.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtResultadoNino.Location = New System.Drawing.Point(346, 512)
        Me.txtResultadoNino.Margin = New System.Windows.Forms.Padding(6)
        Me.txtResultadoNino.Name = "txtResultadoNino"
        Me.txtResultadoNino.Size = New System.Drawing.Size(196, 31)
        Me.txtResultadoNino.TabIndex = 14
        '
        'ErrorIconoNino
        '
        Me.ErrorIconoNino.ContainerControl = Me
        '
        'btnCalcularNino
        '
        Me.btnCalcularNino.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCalcularNino.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCalcularNino.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCalcularNino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCalcularNino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnCalcularNino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularNino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCalcularNino.Location = New System.Drawing.Point(650, 235)
        Me.btnCalcularNino.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcularNino.Name = "btnCalcularNino"
        Me.btnCalcularNino.Size = New System.Drawing.Size(158, 63)
        Me.btnCalcularNino.TabIndex = 15
        Me.btnCalcularNino.Text = "Calcular"
        Me.btnCalcularNino.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(13, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Calculadora Fitness IMC"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 617)
        Me.Controls.Add(Me.btnCalcularNino)
        Me.Controls.Add(Me.txtResultadoNino)
        Me.Controls.Add(Me.txtEdadNino)
        Me.Controls.Add(Me.txtAlturaNino)
        Me.Controls.Add(Me.txtPesoNino)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiarNino)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnForm4Volver)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelTituloForm4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PanelTituloForm4.ResumeLayout(False)
        Me.PanelTituloForm4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIconoNino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTituloForm4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnForm4Volver As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLimpiarNino As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPesoNino As TextBox
    Friend WithEvents txtAlturaNino As TextBox
    Friend WithEvents txtEdadNino As TextBox
    Friend WithEvents txtResultadoNino As TextBox
    Friend WithEvents ErrorIconoNino As ErrorProvider
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents btnCalcularNino As Button
    Friend WithEvents btnApagarForm4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCerrarForm4 As Button
    Friend WithEvents btnMaximizarForm4 As Button
    Friend WithEvents btnMinimizarForm4 As Button
    Friend WithEvents btnRestaurarForm4 As Button
    Friend WithEvents Label6 As Label
End Class
