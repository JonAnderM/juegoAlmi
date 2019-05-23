
Imports MySql.Data.MySqlClient
Public Class Juego
    Dim btnArray As ArrayList
    Dim bonusTiempo As Integer = 0
    Dim arrayPreguntas As ArrayList
    Dim arrayRespuestas As ArrayList
    Dim puntos As Integer = 0
    Dim correcta As String
    Dim numCorrecta As Integer
    Dim numPreguntas As Integer
    Dim numRespuestas As Integer
    Dim dReader As MySqlDataReader
    Dim daAdapter As MySqlDataAdapter
    Dim readerRespuestas As MySqlDataReader
    Dim dataPreguntas As DataSet
    Dim dataRespuestas As DataSet
    Dim idPregunta As String
    Dim sql As String = "SELECT * FROM preguntasFOL"
    Dim sqlRespuestas As String = "SELECT * FROM respuestasFOL WHERE pregunta="
    Dim cn As MySqlConnection
    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPunt.Text = 0
        lblPunt.ForeColor = Color.White
        lblPunt.BackColor = Color.Black

        arrayPreguntas = New ArrayList
        btnArray = New ArrayList
        rectBotones()


        dataPreguntas = New DataSet
        Dim cn As MySqlConnection
        cn = conectar()
        daAdapter = New MySqlDataAdapter(sql, cn)
        daAdapter.Fill(dataPreguntas, "preguntasFOL")
        cn.Close()
        Dim i As Integer = 0
        Do While dataPreguntas.Tables("preguntasFOL").Rows.Count > i
            arrayPreguntas.Add(dataPreguntas.Tables("preguntasFOL").Rows(i).Item("pregunta"))
            i += 1
        Loop


        numPreguntas = 0
        numRespuestas = 0
        Timer1.Enabled = True
        TimerPreguntas.Enabled = True
        Timer1.Start()
        TimerPreguntas.Start()
        mostrarPreguntas()
        mostrarRespuestas()



    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text = 0 Then
            finPregunta(0)

        Else
            Label1.Text = Label1.Text - 1
        End If
    End Sub

    Private Sub mostrarPreguntas()
        'Dim sql As String = "SELECT * FROM respuestasFOL WHERE idRespuesta ="
        cn = conectar()
        If numPreguntas > dataPreguntas.Tables("preguntasFOL").Rows.Count - 1 Then
            MsgBox("FIN DEL JUEGO")

        End If
        idPregunta = dataPreguntas.Tables("preguntasFOL").Rows(numPreguntas).Item("idPregunta")
        daAdapter = New MySqlDataAdapter(sqlRespuestas + idPregunta, cn)
        daAdapter.Fill(dataPreguntas, "respuestasFOL")
        lblPregunta.Text = arrayPreguntas(numPreguntas)
        numPreguntas += 1


    End Sub

    Private Sub mostrarRespuestas()
        mostrarBotones()
        txtRta1.BackColor = Color.Black
        txtRta2.BackColor = Color.Black
        txtRta3.BackColor = Color.Black
        txtRta4.BackColor = Color.Black


        If dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("correcta") = True Then
            numCorrecta = numRespuestas
            correcta = dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("respuesta")
        End If
        txtRta1.Text = dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("respuesta")
        numRespuestas += 1
        If dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("correcta") = True Then
            numCorrecta = numRespuestas
            correcta = dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("respuesta")
        End If
        txtRta2.Text = dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("respuesta")
        numRespuestas += 1
        If dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("correcta") = True Then
            numCorrecta = numRespuestas
            correcta = dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("respuesta")
        End If
        txtRta3.Text = dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("respuesta")
        numRespuestas += 1
        If dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("correcta") = True Then
            numCorrecta = numRespuestas
            correcta = dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("respuesta")
        End If
        txtRta4.Text = dataPreguntas.Tables("respuestasFOL").Rows(numRespuestas).Item("respuesta")
        numRespuestas += 1


    End Sub

    Private Sub TimerPreguntas_Tick(sender As Object, e As EventArgs) Handles TimerPreguntas.Tick
        mostrarPreguntas()
        mostrarRespuestas()

    End Sub

    Private Sub txtRta1_Click(sender As Object, e As EventArgs) Handles txtRta1.Click
        finPregunta(sender)

    End Sub

    Private Sub txtRta2_Click(sender As Object, e As EventArgs) Handles txtRta2.Click
        finPregunta(sender)

    End Sub
    Private Sub txtRta3_Click(sender As Object, e As EventArgs) Handles txtRta3.Click
        finPregunta(sender)
    End Sub
    Private Sub txtRta4_Click(sender As Object, e As EventArgs) Handles txtRta4.Click
        finPregunta(sender)

    End Sub
    Private Sub finPregunta(respuesta As Object)
        Timer1.Stop()
        TimerPreguntas.Stop()
        If respuesta.Equals(Nothing) Then
            MsgBox("FIN DEL TIEMPO + infoextramala")
        Else
            If correcta = respuesta.Text Then
                respuesta.BackColor = Color.Green
                puntos += 100
                bonusTiempo = Label1.Text * 10
                puntos += bonusTiempo
                lblPunt.Text = puntos

                Dim infoextra As String = dataPreguntas.Tables("respuestasFOL").Rows(numCorrecta).Item("infoExtra")

                MsgBox("RESPUESTA CORRECTA" + vbCrLf + infoextra)
            Else
                respuesta.BackColor = Color.Red
                MsgBox("RESPUESTA INCORRECTA :'(")
            End If
        End If



        Timer1.Start()
        TimerPreguntas.Start()
        mostrarPreguntas()
        mostrarRespuestas()
        Label1.Text = 30

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text += 10
        Button1.BackColor = Color.Black
        Button1.Enabled = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dataPreguntas.Tables("respuestasFOL").Rows(numCorrecta).Item("respuesta") = txtRta1.Text Then
            txtRta2.Hide()
            txtRta3.Hide()

        End If
        If dataPreguntas.Tables("respuestasFOL").Rows(numCorrecta).Item("respuesta") = txtRta2.Text Then
            txtRta1.Hide()
            txtRta3.Hide()

        End If
        If dataPreguntas.Tables("respuestasFOL").Rows(numCorrecta).Item("respuesta") = txtRta3.Text Then
            txtRta2.Hide()
            txtRta4.Hide()

        End If
        If dataPreguntas.Tables("respuestasFOL").Rows(numCorrecta).Item("respuesta") = txtRta4.Text Then
            txtRta1.Hide()
            txtRta3.Hide()
        End If
    End Sub
    Private Sub mostrarBotones()
        randomize(btnArray)
        'MsgBox(btnArray.Item(0).ToString)
        txtRta1.Bounds = btnArray.Item(0)
        txtRta2.Bounds = btnArray.Item(1)
        txtRta3.Bounds = btnArray.Item(2)
        txtRta4.Bounds = btnArray.Item(3)

        txtRta1.Show()
        txtRta2.Show()
        txtRta3.Show()
        txtRta4.Show()


    End Sub
    Private Sub randomize(btnArray As ArrayList)
        Dim r As Random = New Random()
        For cnt As Integer = 0 To btnArray.Count - 1
            Dim tmp As Object = btnArray(cnt)
            Dim idx As Integer = r.Next(btnArray.Count - cnt) + cnt
            btnArray(cnt) = btnArray(idx)
            btnArray(idx) = tmp
        Next cnt
    End Sub

    Private Sub rectBotones()
        Dim rect1 As Rectangle
        Dim rect2 As Rectangle
        Dim rect3 As Rectangle
        Dim rect4 As Rectangle

        rect1 = txtRta1.Bounds
        rect2 = txtRta2.Bounds
        rect3 = txtRta3.Bounds
        rect4 = txtRta4.Bounds
        btnArray.Add(rect1)
        btnArray.Add(rect2)
        btnArray.Add(rect3)
        btnArray.Add(rect4)

    End Sub
End Class