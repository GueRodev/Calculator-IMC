Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btnCerrarPrograma_Click(sender As Object, e As EventArgs)
        Dim opcion As DialogResult

        opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir del programa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            End
        End If

    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click

    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click

        Dim opcion As DialogResult

        opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir del programa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            End
        End If

    End Sub

    Private Sub btnHombreForm_Click(sender As Object, e As EventArgs) Handles btnHombreForm.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnMujerForm_Click(sender As Object, e As EventArgs) Handles btnMujerForm.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnNinoForm_Click(sender As Object, e As EventArgs) Handles btnNinoForm.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub PanelVertical_Paint(sender As Object, e As PaintEventArgs) Handles PanelVertical.Paint

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim nombre As String

        nombre = InputBox("Ingrese su Usuario:", "Registro de Datos",
                      "Nombre", 550, 300)

        MessageBox.Show("Bienvenido usuario: " & nombre, "Registro de Datos",
                   MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCerrarPrograma_Click_1(sender As Object, e As EventArgs) Handles btnCerrarPrograma.Click
        Dim opcion As DialogResult

        opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir del programa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click


        Me.WindowState = FormWindowState.Maximized
        btnMaximizar.Visible = False ' Si la ventana está maximizada, oculta el botón de maximizar
        btnRestaurar.Visible = True  'Muestra el simbolo restaurar

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal

        btnMaximizar.Visible = True ' Si la ventana no está maximizada, muestra el botón de maximizar
        btnRestaurar.Visible = False  ' Oculta el botón de restaurar
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    ' Variables para almacenar la posición inicial del formulario y la posición inicial del mouse al hacer clic en el panel de título.
    Private isDragging As Boolean = False
    Private startPoint As New Point(0, 0)

    ' Evento MouseDown del panel de título
    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    ' Evento MouseMove del panel de título
    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        If isDragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - Me.startPoint.X, p.Y - Me.startPoint.Y)
        End If
    End Sub

    ' Evento MouseUp del panel de título
    Private Sub PanelTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

End Class
