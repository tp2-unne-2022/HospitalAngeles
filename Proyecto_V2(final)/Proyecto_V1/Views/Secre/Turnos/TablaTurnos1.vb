Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Reflection.Emit
Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports GemBox.Pdf
Imports GemBox.Pdf.Content

Public Class TablaTurnos1
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EntradaTurnos.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea eliminar el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = MsgBoxResult.Yes Then
            Try
                ClaseDatos.eliminarTurno(DataGridView1.CurrentRow.Cells("Id").Value)
                MessageBox.Show("Registro eliminado exitosamente", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cargarListadoTurnos()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al eliminar paciente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar los datos a modificar")
        Else
            'Dim i As Integer

            'i = DataGridView1.CurrentRow.Index
            'EntradaEditTurnos.FechaTurno.Value = DataGridView1.Item(1, i).Value.ToString()
            'EntradaEditTurnos.Hora.Value = DataGridView1.Item(2, i).Value.ToTimeInterval().ToString()
            'EntradaEditTurnos.ID_paciente.Text = DataGridView1.Item(3, i).Value.ToString()
            'EntradaEditTurnos.DNIProfesional.Text = DataGridView1.Item(4, i).Value.ToString()
            ' Dim i As Integer
            'i = DataGridView1.SelectedCells(0).RowIndex
            'EntradaEditTurnos.FechaTurno.Value = DataGridView1.CurrentRow.Cells("Fecha").Value.ToString
            'EntradaEditTurnos.Hora.Value = DataGridView1.Rows(i).Cells(1).Value.TimeOfDay()
            'EntradaEditTurnos.ID_paciente.Text = DataGridView1.Rows(i).Cells(4).Value.ToString()
            'EntradaEditTurnos.Hora.Value = DataGridView1.CurrentRow.Cells("Hora").Value.ToString
            ''EntradaEditTurnos.ID_paciente.Text = DataGridView1.CurrentRow.Cells("ID Paciente").Value.ToString
            ''EntradaEditTurnos.DNIProfesional.Text = DataGridView1.CurrentRow.Cells("DNI Profesional").Value.ToString

            EntradaEditTurnos.ShowDialog()
        End If
    End Sub



    Private Sub TablaTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListadoTurnos()
    End Sub

    Sub buscarTurnos()

        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")

            Using cmd As SqlCommand = New SqlCommand("SELECT 
	        turnos.nro_turno As nro_turno,
	        turnos.fecha As fecha,
	        turnos.hora As hora,
            turnos.deBaja As deBaja,
            turnos.monto As monto,
            turnos.monto_final As monto_final,
            Paciente.Id As paciente,
	        Paciente.dni As dni,
            Paciente.Id As idpaciente,
			p.dni AS dni_profesional
            FROM turnos
            JOIN Paciente ON turnos.paciente = Paciente.id
            INNER JOIN Personal as p ON turnos.profesional = p.dni
            WHERE Paciente.apellido = '" & TxtBusqueda.Text & "'", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Sub cargarListadoTurnos()
        'Dim dni As Long
        'Dim bln As Boolean = Integer.TryParse(TxtBusqueda.Text, dni)
        'If bln Then
        'MessageBox.Show("Debe insertar un nro de documento")
        'Else
        'MessageBox.Show("El dato ingresado debe ser el numero")
        'End If
        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarTurnos(2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub cargarListadoTurnosAlta()

        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarTurnos(1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub cargarListadoTurnosBaja()

        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarTurnos(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        buscarTurnos()
    End Sub

    Private Sub darDeAltaTurno()
        Dim id As Long
        id = DataGridView1.CurrentRow.Cells("nro_turno").Value
        Dim valor As Integer
        valor = 1
        Dim ctx As New HospitalEntities4
        Dim turno As turnos = (From c In ctx.turnos
                               Where c.nro_turno = id
                               Select c).SingleOrDefault
        With turno
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar el registro a dar de alta")
        ElseIf DataGridView1.CurrentRow.Cells("Baja").Value = True Then
            MessageBox.Show("El registro ya está dado de Alta")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de alta el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    darDeAltaTurno()
                    'ClaseDatos.eliminarPersonal(DataGridView1.CurrentRow.Cells("Id").Value)
                    MessageBox.Show("El registro se ha dado de alta exitosamente", "Dar de alta registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cargarListadoPacientes()
                    rbAlta.Checked = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al alzar al personal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub bajarTurno()
        Dim id As Long
        id = DataGridView1.CurrentRow.Cells("nro_turno").Value
        Dim valor As Integer
        valor = 0
        Dim ctx As New HospitalEntities4
        Dim turno As turnos = (From c In ctx.turnos
                               Where c.nro_turno = id
                               Select c).SingleOrDefault
        With turno
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub

    Private Sub btnEli_Click(sender As Object, e As EventArgs) Handles btnEli.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar el registro a dar de baja")
        ElseIf DataGridView1.CurrentRow.Cells("Baja").Value = False Then
            MessageBox.Show("El registro ya está dado de Baja")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de baja el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    bajarTurno()
                    'ClaseDatos.eliminarPersonal(DataGridView1.CurrentRow.Cells("Id").Value)
                    MessageBox.Show("El registro se ha dado de baja exitosamente", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    rbAlta.Checked = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al eliminar personal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub


    Private Sub rbAlta_CheckedChanged(sender As Object, e As EventArgs) Handles rbAlta.CheckedChanged
        cargarListadoTurnosAlta()
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        cargarListadoTurnos()
    End Sub

    Private Sub rbBaja_CheckedChanged(sender As Object, e As EventArgs) Handles rbBaja.CheckedChanged
        cargarListadoTurnosBaja()
    End Sub

    Private Sub btnActu_Click(sender As Object, e As EventArgs) Handles btnActu.Click
        If rbAlta.Checked Then
            cargarListadoTurnosAlta()
        ElseIf rbBaja.Checked Then
            cargarListadoTurnosBaja()
        Else
            cargarListadoTurnos()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim diaHora As Date = Date.Now
        Dim i As Integer
        Dim turno As New turnos
        i = DataGridView1.SelectedCells(0).RowIndex
        turno.fecha = DataGridView1.Rows(i).Cells(0).Value.ToString()
        turno.hora = DataGridView1.Rows(i).Cells(1).Value.ToString()
        turno.paciente = DataGridView1.Rows(i).Cells(3).Value.ToString()
        turno.profesional = DataGridView1.Rows(i).Cells(2).Value.ToString()
        If DataGridView1.Rows(i).Cells(6).Value Is Nothing Then
            turno.monto = 0
        Else
            turno.monto = DataGridView1.Rows(i).Cells(6).Value.ToString()
        End If
        If DataGridView1.Rows(i).Cells(7).Value Is Nothing Then
            turno.monto_final = 0
        Else
            turno.monto_final = DataGridView1.Rows(i).Cells(7).Value.ToString()
        End If
        'ID_paciente.Text = DataGridView1.Rows(i).Cells(4).Value.ToString()
        ''EntradaEditTurnos.DNIProfesional.Text = DataGridView1.CurrentRow.Cells("DNI Profesional").Value.ToString

        ComponentInfo.SetLicense("FREE-LIMITED-KEY")
        Using document = New PdfDocument()
            Dim regDate As Date = Date.Today()
            ' Add a page.
            Dim page = document.Pages.Add()

            Using formattedText = New PdfFormattedText()
                formattedText.FontFamily = New PdfFontFamily("Times New Roman")
                formattedText.Color = PdfColor.FromRgb(0, 0, 0)
                formattedText.FontSize = 11
                formattedText.AppendLine(diaHora)
                formattedText.AppendLine("  ")
                formattedText.AppendLine("  ")
                formattedText.AppendLine("  ")

                ' Set font family and size.
                ' All text appended next uses the specified font family and size.
                formattedText.FontFamily = New PdfFontFamily("Times New Roman")
                formattedText.Color = PdfColor.FromRgb(0, 0, 255)
                formattedText.FontSize = 24

                formattedText.AppendLine("Hospital Angeles - Comprobante de Pago")
                formattedText.AppendLine("  ")
                formattedText.FontFamily = New PdfFontFamily("Times New Roman")
                formattedText.Color = PdfColor.FromRgb(0, 0, 0)
                formattedText.FontSize = 10
                ''formattedText.Append(regDate)
                ' Reset font family and size for all text appended next.
                formattedText.FontFamily = New PdfFontFamily("Calibri")
                formattedText.Color = PdfColor.FromRgb(0, 0, 255)
                formattedText.FontSize = 11

                formattedText.Append("      Fecha" + "          ")
                formattedText.Append("      Hora")
                formattedText.Append("        Id Paciente ")
                formattedText.Append("      Dni Profesional")
                formattedText.Append("    Monto   ")
                formattedText.Append("    Monto Final   ")
                formattedText.AppendLine("  ")
                formattedText.FontFamily = New PdfFontFamily("Calibri")
                formattedText.Color = PdfColor.FromRgb(0, 0, 0)
                formattedText.FontSize = 12
                ''formattedText.Append(DomainUpDown2.SelectedItem)

                formattedText.Append(turno.fecha)
                formattedText.Append("         ")
                formattedText.Append(turno.hora.ToString("hh\:mm\:ss"))
                formattedText.Append("         ")
                formattedText.Append(turno.paciente)
                formattedText.Append("               ")
                formattedText.Append(turno.profesional)
                formattedText.Append("          ")
                If turno.monto Is Nothing Then
                    turno.monto = 0
                    formattedText.Append(turno.monto)
                    formattedText.Append("         ")
                Else
                    formattedText.Append(turno.monto)
                    formattedText.Append("         ")
                End If

                If turno.monto Is Nothing Then
                    turno.monto_final = 0
                    Debug.Print(turno.monto_final)
                    formattedText.Append("       ")
                    formattedText.Append(turno.monto_final)

                Else
                    Debug.Print(turno.monto_final)
                    formattedText.Append("       ")
                    formattedText.Append(turno.monto_final)


                End If


                ' Set font style and color for all text appended next.
                formattedText.FontStyle = PdfFontStyle.Italic
                formattedText.Color = PdfColor.FromRgb(0, 0, 0)

                formattedText.AppendLine("")
                formattedText.AppendLine("")
                formattedText.AppendLine("")
                formattedText.AppendLine("")
                formattedText.Append("FIRMA MEDICO:")

                ' Reset font style and color for all text appended next.
                formattedText.FontStyle = PdfFontStyle.Normal
                formattedText.Color = PdfColor.FromRgb(0, 0, 0)

                formattedText.Append("__________________     ")

                ' Set font style and color for all text appended next.
                formattedText.FontStyle = PdfFontStyle.Italic
                formattedText.Color = PdfColor.FromRgb(0, 0, 0)

                formattedText.Append("FIRMA PACIENTE")

                ' Reset font style and color for all text appended next.
                formattedText.FontStyle = PdfFontStyle.Normal
                formattedText.Color = PdfColor.FromRgb(0, 0, 0)

                formattedText.Append("__________________")

                ' Set the location of the bottom-left corner of the text.
                ' We want top-left corner of the text to be at location (100, 100)
                ' from the top-left corner of the page.
                ' NOTE: In PDF, location (0, 0) is at the bottom-left corner of the page
                ' and the positive y axis extends vertically upward.
                Dim x As Double = 100, y As Double = page.CropBox.Top - 100 - formattedText.Height

                ' Draw text to the page.
                page.Content.DrawText(formattedText, New PdfPoint(x, y))
            End Using

            Dim image = PdfImage.Load("D:\Unne Santi\Taller de Programacion 2\TaPr2\Proyecto\Imagenes proyecto\imagen-comp.png")

            For Each page In document.Pages

                ' Make sure the watermark is correctly transformed even if
                ' the page has a custom crop box origin, is rotated, or has custom units.
                Dim transform = page.Transform
                transform.Invert()

                ' Center the watermark on the page.
                Dim pageSize = page.Size
                transform.Translate((pageSize.Width - 3) / 4, (pageSize.Height - 5) / 2.5)

                ' Calculate the scaling factor so that the watermark fits the page.
                Dim cropBox = page.CropBox
                Dim scale = Math.Min(cropBox.Width, cropBox.Height)

                ' Scale the watermark so that it fits the page.
                transform.Scale(scale, scale, 0.3, 0.3)

                ' Draw the centered and scaled watermark.
                page.Content.DrawImage(image, transform)
            Next

            ''If Not System.IO.File.Exists("C:\Comprobantes\ComprobanteDePago.pdf") = True Then
            ''Dim file As System.IO.FileStream
            '' file = System.IO.File.Create("C:\Comprobantes\ComprobanteDePago.pdf")
            Dim AnswerYes As String
            Dim AnswerNo As String
            AnswerYes = MsgBox("¿Esta seguro de realizar dicha acción?", vbInformation + vbYesNo, "Imprimir")
            If AnswerYes = vbYes Then
                Dim sfd As New SaveFileDialog() With {
                    .Filter = "Imagen | *.pdf",
                    .FileName = ""
            }

                If sfd.ShowDialog = DialogResult.OK Then
                    Cursor = Cursors.WaitCursor
                    document.Save(sfd.FileName)
                    MsgBox("Comprobante listo")
                    Cursor = Cursors.Default
                End If
            ElseIf AnswerYes = vbNo Then
                Me.Close()
            Else
                MsgBox("¿Esta seguro de realizar dicha acción?", vbCritical + vbYesNo, "Imprimir")
            End If
            ''  file.Close()
            '' End If
            'MessageBox.Show("PDF creado")
        End Using



    End Sub
End Class