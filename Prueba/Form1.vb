Public Class Form1
    Dim anchoCheckBox As Integer = 45



    Private Sub centerForm() ''Centrar Formulario en pantalla

        Dim r = Screen.PrimaryScreen.WorkingArea
        Dim x = r.Width - Me.Width
        Dim y = r.Height - Me.Height

        x = CInt(x / 2)
        y = CInt(y / 2)
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(x, y)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Ha ocurrido un error", "error")
        centerForm()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numeroCasilla = 1

        Dim left As Integer = 1
        Dim top As Integer = 1
        centerForm()
        ' Generamos los checkboxes en tiempo de ejecucion 
        For i = 0 To 6
            For j = 0 To 6
                Dim checkBox As New CheckBox
                checkBox.Text = ":" & numeroCasilla
                checkBox.RightToLeft = RightToLeft.Yes
                checkBox.Anchor = AnchorStyles.None
                checkBox.Width = anchoCheckBox
                checkBox.Left = left
                checkBox.Top = top
                checkBox.Font = New Font(Me.Font, FontStyle.Bold)
                panelCheckBoxes.Controls.Add(checkBox)
                numeroCasilla = numeroCasilla + 1
                left = left + 62
            Next j
            left = 0
            top = top + 42
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Recorre todos los checkboxes y les pone el check
        For i = 0 To panelCheckBoxes.Controls.Count - 1
            Dim checkbox As CheckBox
            checkbox = panelCheckBoxes.Controls(i)
            checkbox.Checked = True
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Recorre todos los checkboxes y les quita el check
        For i = 0 To panelCheckBoxes.Controls.Count - 1
            Dim checkbox As CheckBox
            checkbox = panelCheckBoxes.Controls(i)
            checkbox.Checked = False
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim startsSoundPlayer = New System.Media.SoundPlayer("C:\Windows\media\chord.wav")
        startsSoundPlayer.Play()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer = 0
        Do

            MsgBox("El valor es:" & i)
            i += 1
        Loop While i < 5
    End Sub

    Private Sub Imagen_Click(sender As Object, e As EventArgs) Handles Imagen.Click
        'Mostrar el cuadro de diálogo Abrir archivo. Si el usuario hace clic en Aceptar, cargue la
        'imagen que el usuario eligió.
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            PictureBox1.Load(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub BorrarImagen_Click(sender As Object, e As EventArgs) Handles BorrarImagen.Click
        'clear the picture 
        PictureBox1.Image = Nothing
        'checkWinner()
    End Sub

    Public Sub checkWinner()
        'No Funciona
        Dim position3(1, 2, 3)
        Dim position3_1(4, 5, 6)
        Dim position3_2(7, 8, 9)
        Dim position3_3(1, 5, 9)
        Dim position3_4(7, 5, 3)

        '
        'Dim position4 As ArrayList =
        'Dim position5 As ArrayList = 
        Dim checkWinnerArray As Array = {1, 2, 4}

        If UBound(checkWinnerArray) > UBound(position3) Then
            MessageBox.Show("Ganador", "Winner")
        Else
            MessageBox.Show("Perdedor", "Loser")
        End If







    End Sub



End Class
