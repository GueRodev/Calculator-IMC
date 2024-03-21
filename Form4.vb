Imports System.ComponentModel

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btnForm4Volver_Click(sender As Object, e As EventArgs) Handles btnForm4Volver.Click
        Me.Close()
        Form1.Show()

    End Sub


    Private Sub txtPesoNino_TextChanged(sender As Object, e As EventArgs) Handles txtPesoNino.TextChanged

    End Sub

    Private Sub btnCalcularNino_Click(sender As Object, e As EventArgs) Handles btnCalcularNino.Click
        ' Declaramos Variables
        Dim pesoNino As Double
        Dim alturaNino As Double
        Dim edadNino As Integer

        Try
            ' Entrada de datos y validación
            If Not Double.TryParse(txtPesoNino.Text, pesoNino) OrElse pesoNino <= 0 Then
                MessageBox.Show("Ingrese un peso válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPesoNino.Focus() 'enfocar donde esta el Error
                Exit Sub
            End If

            If Not Double.TryParse(txtAlturaNino.Text, alturaNino) OrElse alturaNino <= 0 Then
                MessageBox.Show("Ingrese una altura válida ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAlturaNino.Focus()
                Exit Sub
            End If

            If Not Integer.TryParse(txtEdadNino.Text, edadNino) OrElse edadNino <= 0 OrElse edadNino > 20 Then
                MessageBox.Show("Ingrese una edad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEdadNino.Focus()
                Exit Sub
            End If

            ' Convertimos la altura a metros
            alturaNino /= 100

            ' Cálculo de IMC
            Dim imc As Double
            imc = pesoNino / (alturaNino * alturaNino)

            'Salida de Datos
            txtResultadoNino.Text = imc

            ' Determina el estado basado en el IMC y la edad.
            Dim mensaje As String = ""

            If edadNino >= 6 And edadNino <= 8 Then
                If imc < 13 Then
                    mensaje = "*Delgado*, Se Recomienda: Superávit calórico Controlado y actividad física al menos 3 dias a la semana, bajo la supervisión y orientación de un profesional de la salud"
                ElseIf imc >= 13 AndAlso imc < 15 Then
                    mensaje = "*Peso Normal* Se recomienda: Mantener Dieta Balanceada rica en proteína y realizar actividad física al menos 3 dias a la semana bajo la supervisión y orientación de un profesional de la salud"
                ElseIf imc >= 15 AndAlso imc < 17 Then
                    mensaje = "*Sobre Peso*, Se recomienda:Déficit calórico Controlado y realizar actividad física al menos 3 dias a la semana bajo la supervisión y orientación de un profesional de la salud"
                End If

            ElseIf edadNino >= 9 And edadNino <= 11 Then
                If imc < 14 Then
                    mensaje = "*Delgado*, Se Recomienda: Superávit calórico Controlado y actividad física al menos 3 dias a la semana, bajo la supervisión y orientación de un profesional de la salud"
                ElseIf imc >= 14 AndAlso imc < 16 Then
                    mensaje = "*Peso Normal* Se recomienda: Mantener Dieta Balanceada rica en proteína y realizar actividad física al menos 3 dias a la semana bajo la supervisión y orientación de un profesional de la salud"
                ElseIf imc >= 16 AndAlso imc < 20 Then
                    mensaje = "*Sobre Peso*, Se recomienda:Déficit calórico Controlado y realizar actividad física al menos 3 dias a la semana bajo la supervisión y orientación de un profesional de la salud"
                End If

            ElseIf edadNino >= 11 And edadNino <= 13 Then
                If imc < 15 Then
                    mensaje = "*Delgado*, Se Recomienda: Superávit calórico Controlado y actividad física al menos 3 dias a la semana, bajo la supervisión y orientación de un profesional de la salud"
                ElseIf imc >= 15 AndAlso imc < 17 Then
                    mensaje = "*Peso Normal* Se recomienda: Mantener Dieta Balanceada rica en proteina y realizar actividad física al menos 3 dias a la semana bajo la supervisión y orientación de un profesional de la salud"
                ElseIf imc >= 17 AndAlso imc < 19 Then
                    mensaje = "*Sobre Peso*, Se recomienda:Déficit calórico Controlado y realizar actividad física al menos 3 dias a la semana bajo la supervisión y orientación de un profesional de la salud"
                End If

            ElseIf edadNino >= 14 And edadNino <= 16 Then
                If imc < 16 Then
                    mensaje = "*Delgado*, Se Recomienda: Superávit calórico Controlado y actividad física al menos 3 dias a la semana, bajo la supervisión y orientación de un profesional de la salud"
                ElseIf imc >= 16 AndAlso imc < 19 Then
                    mensaje = "*Peso Normal* Se recomienda: Mantener Dieta Balanceada rica en proteina y realizar actividad física al menos 3 dias a la semana bajo la supervisión y orientación de un profesional de la salud"
                ElseIf imc >= 19 AndAlso imc < 21 Then
                    mensaje = "*Sobre Peso*, Se recomienda:Déficit calórico Controlado y realizar actividad física al menos 3 dias a la semana bajo la supervisión y orientación de un profesional de la salud"
                End If

            ElseIf edadNino >= 17 And edadNino <= 19 Then
                If imc < 17 Then
                    mensaje = "*Delgado*, Se Recomienda: Superávit calórico Controlado y actividad fisica al menos 3 dias a la semana, bajo la supervisión y orientación de un profesional de la salud"
                ElseIf imc >= 17 AndAlso imc < 21 Then
                    mensaje = "*Peso Normal* Se recomienda: Mantener Dieta Balanceada rica en proteina y realizar actividad fisica al menos 3 dias a la semana bajo la supervisión y orientación de un profesional de la salud"
                ElseIf imc >= 21 AndAlso imc < 30 Then
                    mensaje = "*Sobre Peso*, Se recomienda:Déficit calórico Controlado y realizar actividad fisica al menos 3 dias a la semana bajo la supervisión y orientación de un profesional de la salud"
                End If

            End If

            ' Presentación de resultados
            If mensaje <> "" Then
                MessageBox.Show("El índice de masa corporal es: " & mensaje, "Estado de IMC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Datos incorrectos. Verifique los valores ingresados.", "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message) ' Muestra el error o la excepción
        End Try

    End Sub

    Private Sub txtPesoNino_Validating(sender As Object, e As CancelEventArgs) Handles txtPesoNino.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'En la longitud de este texto debe ser mayor a 0
            Me.ErrorIconoNino.SetError(sender, "")

        Else Me.ErrorIconoNino.SetError(sender, "Dato Obligatorio")

        End If

        'Ingresar solo numeros enteros
        If (Val(txtPesoNino.Text) - Int(Val(txtPesoNino.Text)) = 0) Then
            Me.ErrorIconoNino.SetError(sender, "")

        Else
            Me.ErrorIconoNino.SetError(sender, "Dato Obligatorio, Valor Entero")

        End If

        'Ingresar solo numeros enteros
        Dim peso As Double

        If Not Double.TryParse(txtPesoNino.Text, peso) Then
            ' Si el valor ingresado no es número entero, hay error
            Me.ErrorIconoNino.SetError(txtPesoNino, "Ingrese un número valido para el Peso")
        ElseIf peso < 0 Then
            ' Si el peso es menor a 0, mostrar un mensaje de error y cancelar la validación
            Me.ErrorIconoNino.SetError(txtPesoNino, "Dato Incorrecto, Ingrese Nuevamente.")

        End If
    End Sub

    Private Sub txtAlturaNino_TextChanged(sender As Object, e As EventArgs) Handles txtAlturaNino.TextChanged

    End Sub

    Private Sub txtAlturaNino_Validating(sender As Object, e As CancelEventArgs) Handles txtAlturaNino.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'En la longitud de este texto debe ser mayor a 0
            Me.ErrorIconoNino.SetError(sender, "")

        Else Me.ErrorIconoNino.SetError(sender, "Dato Obligatorio")

        End If

        'Ingresar solo numeros enteros
        If (Val(txtAlturaNino.Text) - Int(Val(txtAlturaNino.Text)) = 0) Then
            Me.ErrorIconoNino.SetError(sender, "")

        Else
            Me.ErrorIconoNino.SetError(sender, "Dato Obligatorio, Valor Entero")

        End If

        'Ingresar solo numeros enteros
        Dim altura As Double

        If Not Double.TryParse(txtAlturaNino.Text, altura) Then
            ' Si el valor ingresado no es número entero, hay error
            Me.ErrorIconoNino.SetError(txtAlturaNino, "Ingrese un número valido para la Altura")
        ElseIf altura < 0 Then
            ' Si altura es menor a 0, mostrar un mensaje de error y cancelar la validación
            Me.ErrorIconoNino.SetError(txtAlturaNino, "Dato Incorrecto, Ingrese Nuevamente.")

        End If
    End Sub

    Private Sub txtEdadNino_TextChanged(sender As Object, e As EventArgs) Handles txtEdadNino.TextChanged

    End Sub

    Private Sub txtEdadNino_Validating(sender As Object, e As CancelEventArgs) Handles txtEdadNino.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'En la longitud de este texto debe ser mayor a 0
            Me.ErrorIconoNino.SetError(sender, "")

        Else Me.ErrorIconoNino.SetError(sender, "Dato Obligatorio")

        End If

        'Ingresar solo numeros enteros
        If (Val(txtEdadNino.Text) - Int(Val(txtEdadNino.Text)) = 0) Then
            Me.ErrorIconoNino.SetError(sender, "")

        Else
            Me.ErrorIconoNino.SetError(sender, "Dato Obligatorio, Valor Entero")

        End If

        'Ingresar solo numeros enteros
        Dim edad As Double

        If Not Double.TryParse(txtEdadNino.Text, edad) Then
            ' Si el valor ingresado no es número entero, hay error
            Me.ErrorIconoNino.SetError(txtEdadNino, "Ingrese un número valido para la Edad")
        ElseIf edad < 0 Then
            ' Si la edad es menor a 0, mostrar un mensaje de error y cancelar la validación
            Me.ErrorIconoNino.SetError(txtEdadNino, "Dato Incorrecto, Ingrese Nuevamente.")

        End If
    End Sub

    Private Sub txtPesoNino_MouseHover(sender As Object, e As EventArgs) Handles txtPesoNino.MouseHover
        ToolTip3.SetToolTip(txtPesoNino, "Ingrese el Peso")
        ToolTip3.ToolTipTitle = "Peso"
        ToolTip3.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtAlturaNino_MouseHover(sender As Object, e As EventArgs) Handles txtAlturaNino.MouseHover
        ToolTip3.SetToolTip(txtAlturaNino, "Ingrese la Altura")
        ToolTip3.ToolTipTitle = "Altura"
        ToolTip3.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdadNino_MouseHover(sender As Object, e As EventArgs) Handles txtEdadNino.MouseHover
        ToolTip3.SetToolTip(txtEdadNino, "Ingrese la Edad")
        ToolTip3.ToolTipTitle = "Edad"
    End Sub

    Private Sub btnLimpiarNino_Click(sender As Object, e As EventArgs) Handles btnLimpiarNino.Click
        txtPesoNino.Clear()
        txtAlturaNino.Clear()
        txtEdadNino.Clear()
        txtResultadoNino.Clear()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnApagarForm4_Click(sender As Object, e As EventArgs) Handles btnApagarForm4.Click
        Dim opcion As DialogResult

        opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir del programa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub

    Private Sub btnCerrarForm4_Click(sender As Object, e As EventArgs) Handles btnCerrarForm4.Click
        Dim opcion As DialogResult

        opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir del programa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub

    Private Sub btnMaximizarForm4_Click(sender As Object, e As EventArgs) Handles btnMaximizarForm4.Click
        Me.WindowState = FormWindowState.Maximized
        btnMaximizarForm4.Visible = False ' Si la ventana está maximizada, oculta el botón de maximizar
        btnRestaurarForm4.Visible = True  'Muestra el simbolo restaurar
    End Sub

    Private Sub btnRestaurarForm4_Click(sender As Object, e As EventArgs) Handles btnRestaurarForm4.Click
        Me.WindowState = FormWindowState.Normal
        btnMaximizarForm4.Visible = True ' Si la ventana no está maximizada, muestra el botón de maximizar
        btnRestaurarForm4.Visible = False  ' Oculta el botón de restaurar
    End Sub

    Private Sub btnMinimizarForm4_Click(sender As Object, e As EventArgs) Handles btnMinimizarForm4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Variables para almacenar la posición inicial del formulario y la posición inicial del mouse al hacer clic en el panel de título.
    Private isDragging As Boolean = False
    Private startPoint As New Point(0, 0)

    ' Evento MouseDown del panel de título
    Private Sub PanelTituloForm4_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTituloForm4.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    ' Evento MouseMove del panel de título
    Private Sub PanelTituloForm4_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTituloForm4.MouseMove
        If isDragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - Me.startPoint.X, p.Y - Me.startPoint.Y)
        End If
    End Sub

    ' Evento MouseUp del panel de título
    Private Sub PanelTituloForm4_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTituloForm4.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

End Class