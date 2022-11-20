<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelCheckBoxes = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Handlers = New System.Windows.Forms.Button()
        Me.Imagen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BorrarImagen = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "MessageBox"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'panelCheckBoxes
        '
        Me.panelCheckBoxes.Location = New System.Drawing.Point(39, 70)
        Me.panelCheckBoxes.Name = "panelCheckBoxes"
        Me.panelCheckBoxes.Size = New System.Drawing.Size(444, 341)
        Me.panelCheckBoxes.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 429)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Marcar Todo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(290, 429)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Desmarcar Todo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(118, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Sonido"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(210, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Do While"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Handlers
        '
        Me.Handlers.Location = New System.Drawing.Point(509, 70)
        Me.Handlers.Name = "Handlers"
        Me.Handlers.Size = New System.Drawing.Size(75, 23)
        Me.Handlers.TabIndex = 6
        Me.Handlers.Text = "Handlers"
        Me.Handlers.UseVisualStyleBackColor = True
        '
        'Imagen
        '
        Me.Imagen.Location = New System.Drawing.Point(52, 596)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(84, 23)
        Me.Imagen.TabIndex = 7
        Me.Imagen.Text = "Cargar Imagen"
        Me.Imagen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(39, 498)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 92)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BorrarImagen
        '
        Me.BorrarImagen.Location = New System.Drawing.Point(52, 625)
        Me.BorrarImagen.Name = "BorrarImagen"
        Me.BorrarImagen.Size = New System.Drawing.Size(84, 23)
        Me.BorrarImagen.TabIndex = 9
        Me.BorrarImagen.Text = "Borrar Imagen"
        Me.BorrarImagen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 648)
        Me.Controls.Add(Me.BorrarImagen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.Handlers)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.panelCheckBoxes)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents panelCheckBoxes As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Handlers As Button
    Friend WithEvents Imagen As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BorrarImagen As Button
End Class
