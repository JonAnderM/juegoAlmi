<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Juego
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtRta1 = New System.Windows.Forms.Button()
        Me.txtRta2 = New System.Windows.Forms.Button()
        Me.txtRta3 = New System.Windows.Forms.Button()
        Me.txtRta4 = New System.Windows.Forms.Button()
        Me.txtMenu = New System.Windows.Forms.Button()
        Me.pboxImagen = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPuntuacion = New System.Windows.Forms.Label()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPreguntas = New System.Windows.Forms.Timer(Me.components)
        Me.lblPunt = New System.Windows.Forms.Label()
        CType(Me.pboxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRta1
        '
        Me.txtRta1.BackColor = System.Drawing.Color.Black
        Me.txtRta1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRta1.ForeColor = System.Drawing.Color.White
        Me.txtRta1.Location = New System.Drawing.Point(78, 337)
        Me.txtRta1.Name = "txtRta1"
        Me.txtRta1.Size = New System.Drawing.Size(311, 65)
        Me.txtRta1.TabIndex = 1
        Me.txtRta1.Text = "Respuesta larga sobre el tema"
        Me.txtRta1.UseVisualStyleBackColor = False
        '
        'txtRta2
        '
        Me.txtRta2.BackColor = System.Drawing.Color.Black
        Me.txtRta2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRta2.ForeColor = System.Drawing.Color.White
        Me.txtRta2.Location = New System.Drawing.Point(78, 408)
        Me.txtRta2.Name = "txtRta2"
        Me.txtRta2.Size = New System.Drawing.Size(311, 64)
        Me.txtRta2.TabIndex = 2
        Me.txtRta2.Text = "Respuesta correcta"
        Me.txtRta2.UseVisualStyleBackColor = False
        '
        'txtRta3
        '
        Me.txtRta3.BackColor = System.Drawing.Color.Black
        Me.txtRta3.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRta3.ForeColor = System.Drawing.Color.White
        Me.txtRta3.Location = New System.Drawing.Point(420, 339)
        Me.txtRta3.Name = "txtRta3"
        Me.txtRta3.Size = New System.Drawing.Size(312, 65)
        Me.txtRta3.TabIndex = 3
        Me.txtRta3.Text = "Respuesta mala sobre la pregunta"
        Me.txtRta3.UseVisualStyleBackColor = False
        '
        'txtRta4
        '
        Me.txtRta4.BackColor = System.Drawing.Color.Black
        Me.txtRta4.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRta4.ForeColor = System.Drawing.Color.White
        Me.txtRta4.Location = New System.Drawing.Point(420, 410)
        Me.txtRta4.Name = "txtRta4"
        Me.txtRta4.Size = New System.Drawing.Size(312, 64)
        Me.txtRta4.TabIndex = 4
        Me.txtRta4.Text = "Respuesta extra para rellenar"
        Me.txtRta4.UseVisualStyleBackColor = False
        '
        'txtMenu
        '
        Me.txtMenu.Location = New System.Drawing.Point(12, 12)
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.Size = New System.Drawing.Size(75, 23)
        Me.txtMenu.TabIndex = 5
        Me.txtMenu.Text = "Menu"
        Me.txtMenu.UseVisualStyleBackColor = True
        '
        'pboxImagen
        '
        Me.pboxImagen.BackColor = System.Drawing.Color.Black
        Me.pboxImagen.Location = New System.Drawing.Point(93, 12)
        Me.pboxImagen.Name = "pboxImagen"
        Me.pboxImagen.Size = New System.Drawing.Size(580, 40)
        Me.pboxImagen.TabIndex = 6
        Me.pboxImagen.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(6, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 49)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "+10s"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(6, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 50)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Quita 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(6, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 48)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Sig Preg"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(776, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(69, 200)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comodines"
        '
        'lblPuntuacion
        '
        Me.lblPuntuacion.AutoSize = True
        Me.lblPuntuacion.BackColor = System.Drawing.Color.Black
        Me.lblPuntuacion.ForeColor = System.Drawing.Color.White
        Me.lblPuntuacion.Location = New System.Drawing.Point(679, 12)
        Me.lblPuntuacion.Name = "lblPuntuacion"
        Me.lblPuntuacion.Size = New System.Drawing.Size(64, 13)
        Me.lblPuntuacion.TabIndex = 12
        Me.lblPuntuacion.Text = "Puntuacion:"
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoEllipsis = True
        Me.lblPregunta.BackColor = System.Drawing.Color.Black
        Me.lblPregunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPregunta.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.ForeColor = System.Drawing.Color.White
        Me.lblPregunta.Location = New System.Drawing.Point(78, 260)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(654, 63)
        Me.lblPregunta.TabIndex = 13
        Me.lblPregunta.Text = "¿Cual de estas respuestas responde correctamente a la pregunta?"
        Me.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(368, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 76)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "30"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TimerPreguntas
        '
        Me.TimerPreguntas.Interval = 30000
        '
        'lblPunt
        '
        Me.lblPunt.AutoSize = True
        Me.lblPunt.Location = New System.Drawing.Point(758, 12)
        Me.lblPunt.Name = "lblPunt"
        Me.lblPunt.Size = New System.Drawing.Size(0, 13)
        Me.lblPunt.TabIndex = 15
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.JuegoPreguntas.My.Resources.Resources._1
        Me.ClientSize = New System.Drawing.Size(853, 478)
        Me.Controls.Add(Me.lblPunt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.lblPuntuacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pboxImagen)
        Me.Controls.Add(Me.txtMenu)
        Me.Controls.Add(Me.txtRta4)
        Me.Controls.Add(Me.txtRta3)
        Me.Controls.Add(Me.txtRta2)
        Me.Controls.Add(Me.txtRta1)
        Me.Name = "Juego"
        Me.Text = "PreguntAlmi"
        CType(Me.pboxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRta1 As Button
    Friend WithEvents txtRta2 As Button
    Friend WithEvents txtRta3 As Button
    Friend WithEvents txtRta4 As Button
    Friend WithEvents txtMenu As Button
    Friend WithEvents pboxImagen As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPuntuacion As Label
    Friend WithEvents lblPregunta As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimerPreguntas As Timer
    Friend WithEvents lblPunt As Label
End Class
