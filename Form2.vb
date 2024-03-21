Imports System.ComponentModel

Public Class Form2
    Private Sub btnForm2Volver_Click(sender As Object, e As EventArgs) Handles btnForm2Volver.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcularHombre_Click(sender As Object, e As EventArgs) Handles btnCalcularHombre.Click
        'Declaramos Variables
        Dim pesoHombre As Double
        Dim alturaHombre As Double
        Dim edadHombre As Integer

        Try
            ' Entrada de datos y validación
            If Not Double.TryParse(txtPesoHombre.Text, pesoHombre) OrElse pesoHombre <= 0 Then 'si el texto ingresado en txtPesoMujer no puede ser convertido a un número válido
                MessageBox.Show("Ingrese un peso válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPesoHombre.Focus()
                Exit Sub 'Ayuda a evitar ejecutar el resto del código cuando se detecta un problema con los datos ingresados
            End If

            If Not Double.TryParse(txtAlturaHombre.Text, alturaHombre) OrElse alturaHombre <= 0 Then
                MessageBox.Show("Ingrese una altura válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAlturaHombre.Focus()
                Exit Sub
            End If

            If Not Integer.TryParse(txtEdadHombre.Text, edadHombre) OrElse edadHombre <= 0 Then
                MessageBox.Show("Ingrese una edad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEdadHombre.Focus()
                Exit Sub
            End If

            ' Convertimos la altura a metros
            alturaHombre /= 100

            'Calculos IMC
            Dim imc As Double
            imc = pesoHombre / (alturaHombre * alturaHombre)

            ' Determina el estado basado en el IMC.
            Dim mensaje As String

            'Salida de Datos
            txtResultadoHombre.Text = imc

            If edadHombre >= 20 And edadHombre <= 65 Then
                If imc < 17.7 Then
                    mensaje = "*Delgado*, Se Recomienda: Superávit calórico Controlado, Dieta balanceada rica en Proteína, Entrenamiento de Fuerza para aumentar masa muscular y Cardio ligero para no quemar la masa muscular"
                ElseIf imc > 17.7 And imc < 27.3 Then
                    mensaje = "*Normal*, Se recomienda: Mantener Dieta Balanceada rica en Proteína, Entrenamiento de Fuerza para aumento de masa muscular y Cardio Hit para quemar grasa corporal"
                ElseIf imc >= 27.3 And imc <= 33.4 Then
                    mensaje = "*Sobrepeso*, Se recomienda: Déficit calórico Controlado, Dieta balanceada rica en Proteína,Entrenamiento de fuerza, Cardio Moderado y Mantenerse en movimiento constante"
                End If
            End If

            'Prevencion de Errores
            If mensaje <> "" Then 'Si el mensaje no esta vacio
                'Imprime el mensaje 
                MessageBox.Show("El índice de masa corporal es: " & mensaje, "Estado de IMC", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Datos Incorrectos, Ingrese Nuevamente", "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'Muestra el error o la exception 

        End Try



    End Sub

    Private Sub txtPesoHombre_TextChanged(sender As Object, e As EventArgs) Handles txtPesoHombre.TextChanged

    End Sub

    Private Sub txtPesoHombre_Validating(sender As Object, e As CancelEventArgs) Handles txtPesoHombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'En la longitud de este texto debe ser mayor a 0
            Me.ErrorIconoHombre.SetError(sender, "")

        Else Me.ErrorIconoHombre.SetError(sender, "Dato Obligatorio")

        End If

        'Ingresar solo numeros enteros
        If (Val(txtPesoHombre.Text) - Int(Val(txtPesoHombre.Text)) = 0) Then
            Me.ErrorIconoHombre.SetError(sender, "")

        Else
            Me.ErrorIconoHombre.SetError(sender, "Dato Obligatorio, Valor Entero")

        End If

        'Ingresar solo numeros enteros
        Dim peso As Double

        If Not Double.TryParse(txtPesoHombre.Text, peso) Then
            ' Si el valor ingresado no es número entero, hay error
            Me.ErrorIconoHombre.SetError(txtPesoHombre, "Ingrese un número valido para el Peso.")
        ElseIf peso < 0 Then
            ' Si altura es menor a 0, mostrar un mensaje de error y cancelar la validación
            Me.ErrorIconoHombre.SetError(txtPesoHombre, "Dato Incorrecto, Ingrese Nuevamente.")

        End If
    End Sub

    Private Sub txtAlturaHombre_TextChanged(sender As Object, e As EventArgs) Handles txtAlturaHombre.TextChanged

    End Sub

    Private Sub txtAlturaHombre_Validating(sender As Object, e As CancelEventArgs) Handles txtAlturaHombre.Validating

        'En la longitud de este texto debe ser mayor a 0
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIconoHombre.SetError(sender, "")

        Else Me.ErrorIconoHombre.SetError(sender, "Dato Obligatorio")

        End If

        'Ingresar solo numeros positivos
        If (Val(txtAlturaHombre.Text) - Int(Val(txtAlturaHombre.Text)) >= 0) Then
            Me.ErrorIconoHombre.SetError(sender, "")

        Else
            Me.ErrorIconoHombre.SetError(sender, "Dato Obligatorio, Valor Entero")

        End If

        'Ingresar solo numeros enteros
        Dim altura As Double

        If Not Double.TryParse(txtAlturaHombre.Text, altura) Then
            ' Si el valor ingresado no es número entero, hay error
            Me.ErrorIconoHombre.SetError(txtAlturaHombre, "Ingrese un número valido para la Altura")
        ElseIf altura < 0 Then
            ' Si altura es menor a 0, mostrar un mensaje de error y cancelar la validación
            Me.ErrorIconoHombre.SetError(txtAlturaHombre, "Dato Incorrecto, Ingrese Nuevamente")

        End If


    End Sub

    Private Sub txtEdadHombre_TextChanged(sender As Object, e As EventArgs) Handles txtEdadHombre.TextChanged

    End Sub

    Private Sub txtEdadHombre_Validating(sender As Object, e As CancelEventArgs) Handles txtEdadHombre.Validating

        'En la longitud de este texto debe ser mayor a 0
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIconoHombre.SetError(sender, "")

        Else Me.ErrorIconoHombre.SetError(sender, "Dato Obligatorio")

        End If

        'Ingresar solo numeros enteros
        If (Val(txtEdadHombre.Text) - Int(Val(txtEdadHombre.Text)) = 0) Then
            Me.ErrorIconoHombre.SetError(sender, "")

        Else
            Me.ErrorIconoHombre.SetError(sender, "Dato Obligatorio, Valor Entero")

        End If

        'Ingresar solo numeros enteros
        Dim edad As Integer

        If Not Integer.TryParse(txtPesoHombre.Text, edad) Then
            ' Si el valor ingresado no es número entero, hay error
            Me.ErrorIconoHombre.SetError(txtEdadHombre, "Ingrese un número valido para la Edad")
        ElseIf edad < 0 Then
            ' Si altura es menor a 0, mostrar un mensaje de error y cancelar la validación
            Me.ErrorIconoHombre.SetError(txtEdadHombre, "Dato Incorrecto, Ingrese Nuevamente.")

        End If

    End Sub

    Private Sub txtPesoHombre_MouseHover(sender As Object, e As EventArgs) Handles txtPesoHombre.MouseHover
        ToolTip1.SetToolTip(txtPesoHombre, "Ingrese el Peso")
        ToolTip1.ToolTipTitle = "Peso"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlturaHombre_MouseHover(sender As Object, e As EventArgs) Handles txtAlturaHombre.MouseHover
        ToolTip1.SetToolTip(txtAlturaHombre, "Ingrese la Altura")
        ToolTip1.ToolTipTitle = "Altura"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdadHombre_MouseHover(sender As Object, e As EventArgs) Handles txtEdadHombre.MouseHover
        ToolTip1.SetToolTip(txtEdadHombre, "Ingrese la Edad")
        ToolTip1.ToolTipTitle = "Edad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiarHombre_Click(sender As Object, e As EventArgs) Handles btnLimpiarHombre.Click
        txtAlturaHombre.Clear()
        txtEdadHombre.Clear()
        txtPesoHombre.Clear()
        txtResultadoHombre.Clear()
    End Sub

    Private Sub btnSalirForm2_Click(sender As Object, e As EventArgs) Handles btnSalirForm2.Click
        Dim opcion As DialogResult

        opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir del programa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub

    Private Sub btnCerrarForm2_Click(sender As Object, e As EventArgs) Handles btnCerrarForm2.Click
        Dim opcion As DialogResult

        opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir del programa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub

    Private Sub btnMaximizarForm2_Click(sender As Object, e As EventArgs) Handles btnMaximizarForm2.Click
        Me.WindowState = FormWindowState.Maximized
        btnMaximizarForm2.Visible = False ' Si la ventana está maximizada, oculta el botón de maximizar
        btnRestaurarForm2.Visible = True  'Muestra el simbolo restaurar
    End Sub

    Private Sub btnRestaurarForm2_Click(sender As Object, e As EventArgs) Handles btnRestaurarForm2.Click
        Me.WindowState = FormWindowState.Normal
        btnMaximizarForm2.Visible = True ' Si la ventana no está maximizada, muestra el botón de maximizar
        btnRestaurarForm2.Visible = False  ' Oculta el botón de restaurar
    End Sub

    Private Sub btnMinimizarForm2_Click(sender As Object, e As EventArgs) Handles btnMinimizarForm2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Variables para almacenar la posición inicial del formulario y la posición inicial del mouse al hacer clic en el panel de título.
    Private isDragging As Boolean = False
    Private startPoint As New Point(0, 0)

    ' Evento MouseDown del panel de título
    Private Sub PanelTituloForm2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTituloForm2.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    ' Evento MouseMove del panel de título
    Private Sub PanelTituloForm2_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTituloForm2.MouseMove
        If isDragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - Me.startPoint.X, p.Y - Me.startPoint.Y)
        End If
    End Sub

    ' Evento MouseUp del panel de título
    Private Sub PanelTituloForm2_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTituloForm2.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub


End Class