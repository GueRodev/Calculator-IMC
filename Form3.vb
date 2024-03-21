Imports System.ComponentModel

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btnForm3Volver_Click(sender As Object, e As EventArgs) Handles btnForm3Volver.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnCalcularMujer_Click(sender As Object, e As EventArgs) Handles btnCalcularMujer.Click
        'Declaramos Variables
        Dim pesoMujer As Double
        Dim alturaMujer As Double
        Dim edadMujer As Integer

        Try
            ' Entrada de datos y validación
            If Not Double.TryParse(txtPesoMujer.Text, pesoMujer) OrElse pesoMujer <= 0 Then 'si el texto ingresado en txtPesoMujer no puede ser convertido a un número válido
                MessageBox.Show("Ingrese un peso válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPesoMujer.Focus()
                Exit Sub 'Ayuda a evitar ejecutar el resto del código cuando se detecta un problema con los datos ingresados
            End If

            If Not Double.TryParse(txtAlturaMujer.Text, alturaMujer) OrElse alturaMujer <= 0 Then
                MessageBox.Show("Ingrese una altura válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAlturaMujer.Focus()
                Exit Sub
            End If

            If Not Integer.TryParse(txtEdadMujer.Text, edadMujer) OrElse edadMujer <= 0 Then
                MessageBox.Show("Ingrese una edad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEdadMujer.Focus()
                Exit Sub
            End If

            ' Convertimos la altura a metros
            alturaMujer /= 100

            'Calculos IMC
            Dim imc As Double
            imc = pesoMujer / (alturaMujer * alturaMujer)

            ' Determina el estado basado en el IMC.
            Dim mensaje As String = ""

            'Salida de Datos
            txtResultadoMujer.Text = imc

            If edadMujer >= 20 And edadMujer <= 65 Then
                If imc < 17.7 Then
                    mensaje = "*Delgada*, Se Recomienda: Superávit calórico Controlado, Dieta balanceada rica en Proteína, Entrenamiento de Fuerza para aumentar masa muscular y Cardio ligero para no quemar la masa muscular"
                ElseIf imc > 17.7 And imc < 27.3 Then
                    mensaje = "*Normal*, Se recomienda: Mantener Dieta Balanceada rica en Proteína, Entrenamiento de Fuerza para aumento de masa muscular y Cardio Hit para quemar grasa corporal"
                ElseIf imc >= 27.4 And imc <= 33.4 Then
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

    Private Sub txtPesoMujer_TextChanged(sender As Object, e As EventArgs) Handles txtPesoMujer.TextChanged

    End Sub

    Private Sub txtPesoMujer_Validating(sender As Object, e As CancelEventArgs) Handles txtPesoMujer.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'En la longitud de este texto debe ser mayor a 0
            Me.ErrorIconoMujer.SetError(sender, "")

        Else Me.ErrorIconoMujer.SetError(sender, "Dato Obligatorio")

        End If

        'Ingresar solo numeros enteros
        If (Val(txtPesoMujer.Text) - Int(Val(txtPesoMujer.Text)) = 0) Then
            Me.ErrorIconoMujer.SetError(sender, "")

        Else
            Me.ErrorIconoMujer.SetError(sender, "Dato Obligatorio, Valor Entero")

        End If

        'Ingresar solo numeros enteros
        Dim peso As Double

        If Not Double.TryParse(txtPesoMujer.Text, peso) Then
            ' Si el valor ingresado no es número entero, hay error
            Me.ErrorIconoMujer.SetError(txtPesoMujer, "Ingrese un número valido para el Peso")
        ElseIf peso < 0 Then
            ' Si el peso es menor a 0, mostrar un mensaje de error y cancelar la validación
            Me.ErrorIconoMujer.SetError(txtPesoMujer, "Dato Incorrecto, Ingrese Nuevamente.")

        End If
    End Sub

    Private Sub txtAlturaMujer_TextChanged(sender As Object, e As EventArgs) Handles txtAlturaMujer.TextChanged

    End Sub

    Private Sub txtAlturaMujer_Validating(sender As Object, e As CancelEventArgs) Handles txtAlturaMujer.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'En la longitud de este texto debe ser mayor a 0
            Me.ErrorIconoMujer.SetError(sender, "")

        Else Me.ErrorIconoMujer.SetError(sender, "Dato Obligatorio")

        End If

        'Ingresar solo numeros enteros
        If (Val(txtAlturaMujer.Text) - Int(Val(txtAlturaMujer.Text)) = 0) Then
            Me.ErrorIconoMujer.SetError(sender, "")

        Else
            Me.ErrorIconoMujer.SetError(sender, "Dato Obligatorio, Valor Entero")

        End If

        'Ingresar solo numeros enteros
        Dim altura As Double

        If Not Double.TryParse(txtAlturaMujer.Text, altura) Then
            ' Si el valor ingresado no es número entero, hay error
            Me.ErrorIconoMujer.SetError(txtAlturaMujer, "Ingrese un número valido para la Altura")
        ElseIf altura < 0 Then
            ' Si altura es menor a 0, mostrar un mensaje de error y cancelar la validación
            Me.ErrorIconoMujer.SetError(txtAlturaMujer, "Dato Incorrecto, Ingrese Nuevamente")

        End If
    End Sub

    Private Sub txtEdadMujer_TextChanged(sender As Object, e As EventArgs) Handles txtEdadMujer.TextChanged

    End Sub

    Private Sub txtEdadMujer_Validating(sender As Object, e As CancelEventArgs) Handles txtEdadMujer.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'En la longitud de este texto debe ser mayor a 0
            Me.ErrorIconoMujer.SetError(sender, "")

        Else Me.ErrorIconoMujer.SetError(sender, "Dato Obligatorio")

        End If

        'Ingresar solo numeros enteros
        If (Val(txtEdadMujer.Text) - Int(Val(txtEdadMujer.Text)) = 0) Then
            Me.ErrorIconoMujer.SetError(sender, "")

        Else
            Me.ErrorIconoMujer.SetError(sender, "Dato Obligatorio, Valor Entero")

        End If

        'Ingresar solo numeros enteros
        Dim edad As Integer

        If Not Integer.TryParse(txtEdadMujer.Text, edad) Then
            ' Si el valor ingresado no es número entero, hay error
            Me.ErrorIconoMujer.SetError(txtEdadMujer, "Ingrese un número valido para la Edad")
        ElseIf edad < 0 Then
            ' Si la edad es menor a 0, mostrar un mensaje de error y cancelar la validación
            Me.ErrorIconoMujer.SetError(txtEdadMujer, "Dato Incorrecto, Ingrese Nuevamente")

        End If
    End Sub


    Private Sub txtPesoMujer_MouseHover(sender As Object, e As EventArgs) Handles txtPesoMujer.MouseHover
        ToolTip2.SetToolTip(txtPesoMujer, "Ingrese el Peso")
        ToolTip2.ToolTipTitle = "Peso"
        ToolTip2.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlturaMujer_MouseHover(sender As Object, e As EventArgs) Handles txtAlturaMujer.MouseHover
        ToolTip2.SetToolTip(txtAlturaMujer, "Ingrese la Altura")
        ToolTip2.ToolTipTitle = "Altura"
        ToolTip2.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdadMujer_MouseHover(sender As Object, e As EventArgs) Handles txtEdadMujer.MouseHover
        ToolTip2.SetToolTip(txtEdadMujer, "Ingrese la Edad")
        ToolTip2.ToolTipTitle = "Edad"
        ToolTip2.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiarMujer_Click(sender As Object, e As EventArgs) Handles btnLimpiarMujer.Click
        txtAlturaMujer.Clear()
        txtEdadMujer.Clear()
        txtPesoMujer.Clear()
        txtResultadoMujer.Clear()
    End Sub

    Private Sub btnSalirForm3_Click(sender As Object, e As EventArgs) Handles btnSalirForm3.Click
        Dim opcion As DialogResult

        opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir del programa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub

    Private Sub btnCerrarForm3_Click(sender As Object, e As EventArgs) Handles btnCerrarForm3.Click
        Dim opcion As DialogResult

        opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir del programa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub

    Private Sub btnMaximizarForm3_Click(sender As Object, e As EventArgs) Handles btnMaximizarForm3.Click
        Me.WindowState = FormWindowState.Maximized
        btnMaximizarForm3.Visible = False ' Si la ventana está maximizada, oculta el botón de maximizar
        btnRestaurarForm3.Visible = True  'Muestra el simbolo restaurar
    End Sub

    Private Sub btnRestaurarForm3_Click(sender As Object, e As EventArgs) Handles btnRestaurarForm3.Click
        Me.WindowState = FormWindowState.Normal
        btnMaximizarForm3.Visible = True ' Si la ventana no está maximizada, muestra el botón de maximizar
        btnRestaurarForm3.Visible = False  ' Oculta el botón de restaurar
    End Sub

    Private Sub btnMinimizarForm3_Click(sender As Object, e As EventArgs) Handles btnMinimizarForm3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Variables para almacenar la posición inicial del formulario y la posición inicial del mouse al hacer clic en el panel de título.
    Private isDragging As Boolean = False
    Private startPoint As New Point(0, 0)

    ' Evento MouseDown del panel de título
    Private Sub PanelTituloForm3_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTituloForm3.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    ' Evento MouseMove del panel de título
    Private Sub PanelTituloForm3_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTituloForm3.MouseMove
        If isDragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - Me.startPoint.X, p.Y - Me.startPoint.Y)
        End If
    End Sub

    ' Evento MouseUp del panel de título
    Private Sub PanelTituloForm3_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTituloForm3.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

End Class