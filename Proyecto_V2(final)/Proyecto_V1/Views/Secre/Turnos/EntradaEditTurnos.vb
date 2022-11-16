Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class EntradaEditTurnos
    Dim descuento As Integer
    Dim descuentoFinal As Double
    Dim montoFinal As Double
#Region "BOTONES PARTE SUPERIOR"
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            Me.Hide()
        End If
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub

    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            Me.Hide()
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrEmpty(txtApellido.Text) = False And String.IsNullOrEmpty(txtApeProfesional.Text) = False And (String.IsNullOrEmpty(DNIProfesional.Text) = False And IsNumeric(DNIProfesional.Text) = True) And (String.IsNullOrEmpty(txtDNI.Text) = False And IsNumeric(txtDNI.Text) = True) Then
            Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
                Using cmd As SqlCommand = New SqlCommand("SELECT 
	            turnos.nro_turno As nro_turno,
	            turnos.fecha As fecha,
	            turnos.hora As hora,
                turnos.profesional AS profesional,
                a.dia As dia
                FROM turnos
                INNER JOIN agenda as a ON a.profesional = turnos.profesional WHERE a.dia = '" & Date.Today.ToString("Dddd") & "'
			    and fecha = '" & FechaTurno.Value.ToString("yyyy-MM-dd") & "' 
                and hora  = '" & Hora.Value.ToShortTimeString() & "' 
                and turnos.profesional = '" & DNIProfesional.Text & "'
                ", conn)

                    Using da As New SqlDataAdapter
                        da.SelectCommand = cmd
                        Using dt As New DataTable

                            If dt.Rows.Count > 0 Then
                                Debug.Print(Date.Today.ToString("Dddd"))
                                MsgBox("Ya existe un turno para la fecha y el horario ingresado con el profesional seleccionado", vbExclamation, "Error")
                            Else

                                buscarObraSocial(Me.ID_paciente.Text)
                                Debug.Print(descuento.ToString)
                                descuentoFinal = TextBox1.Text / 100 * descuento.ToString
                                montoFinal = TextBox1.Text - descuentoFinal
                                Debug.Print(montoFinal)
                                Try
                                    Dim id As Integer
                                    Dim dni As Long
                                    Dim monto As Decimal
                                    id = Convert.ToInt32(ID_paciente.Text)
                                    dni = Convert.ToInt64(DNIProfesional.Text)
                                    monto = Convert.ToDecimal(TextBox1.Text)
                                    ClaseDatos.actualizarTurno(TablaTurnos1.DataGridView1.CurrentRow.Cells("nro_turno").Value, FechaTurno.Value, Hora.Value, id, dni, monto, montoFinal)
                                    MessageBox.Show("Registro modificado exitosamente", "Modificar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    TablaTurnos1.cargarListadoTurnos()
                                    Me.Hide()
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, "Error al modificar paciente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                                'ClaseDatos.insertarTurno(New turnos() With {
                                '    .fecha = Me.FechaTurno.Value.ToString("yyyy-MM-dd"), .hora = Me.Hora.Value, .paciente = Me.TextBox1.Text, .profesional = Me.DNIProfesional.Text, .deBaja = 1, .monto = TextBox2.Text, .monto_final = montoFinal})
                                'MsgBox("Se insertó un nuevo Turno", vbInformation, "Exito")
                            End If
                        End Using
                    End Using
                End Using
            End Using

        Else
            MsgBox("Hay campos requeridos", vbCritical, "Requerido")
        End If
    End Sub

    Sub buscarObraSocial(id As Integer)

        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
            Using cmd As SqlCommand = New SqlCommand("SELECT porc_cobertura from Obra_Social where Id = (
				SELECT id_obra_soc from Paciente where Id = (SELECT TOP 1
				turnos.paciente as id_paciente
                FROM turnos WHERE turnos.paciente = '" & id & "'
				))", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    conn.Open()
                    descuento = CInt(cmd.ExecuteScalar)
                End Using
            End Using
        End Using
    End Sub

    Private Sub EntradaEditTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim turno As turnos = ClaseDatos.getInfoTurnos(TablaTurnos1.DataGridView1.CurrentRow.Cells("nro_turno").Value)
            With turno
                FechaTurno.Value = .fecha
                Hora.Value = .hora
                ID_paciente.Text = .paciente
                DNIProfesional.Text = .profesional
                TextBox1.Text = .monto
                TextBox2.Text = .monto_final
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al seleccionar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'EntradaEditTurnos.FechaTurno.Value = DataGridView1.CurrentRow.Cells("Fecha").Value.ToString


    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
            Using cmd As SqlCommand = New SqlCommand("Select Id, nombre, apellido, dni from Paciente where Id = '" & ID_paciente.Text & "' ", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            ID_paciente.Text = dt.Rows(0)(0).ToString()
                            txtNombre.Text = dt.Rows(0)(1).ToString()
                            txtApellido.Text = dt.Rows(0)(2).ToString()
                            txtDNI.Text = dt.Rows(0)(3).ToString()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
            Using cmd As SqlCommand = New SqlCommand("Select Id, nombre, apellido, dni from Paciente where dni = '" & txtDNI.Text & "' ", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            ID_paciente.Text = dt.Rows(0)(0).ToString()
                            txtNombre.Text = dt.Rows(0)(1).ToString()
                            txtApellido.Text = dt.Rows(0)(2).ToString()
                            txtDNI.Text = dt.Rows(0)(3).ToString()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
            Using cmd As SqlCommand = New SqlCommand("Select Id, nombre, apellido, dni from Paciente where apellido = '" & txtApellido.Text & "' ", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            ID_paciente.Text = dt.Rows(0)(0).ToString()
                            txtNombre.Text = dt.Rows(0)(1).ToString()
                            txtApellido.Text = dt.Rows(0)(2).ToString()
                            txtDNI.Text = dt.Rows(0)(3).ToString()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
            Using cmd As SqlCommand = New SqlCommand("Select Id, nombre, apellido, dni from Paciente where nombre = '" & txtNombre.Text & "' ", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            ID_paciente.Text = dt.Rows(0)(0).ToString()
                            txtNombre.Text = dt.Rows(0)(1).ToString()
                            txtApellido.Text = dt.Rows(0)(2).ToString()
                            txtDNI.Text = dt.Rows(0)(3).ToString()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Hora.ValueChanged
        Hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Hora.CustomFormat = "HH:mm"
        Hora.ShowUpDown = True

        If Hora.Value.Minute Mod 15 = 0 Then
            Return
        End If

        If Hora.Value.Minute Mod 15 = 1 Then
            Hora.Value = Hora.Value.AddMinutes(14)
        End If

        If Hora.Value.Minute Mod 15 = 14 Then
            Hora.Value = Hora.Value.AddMinutes(-14)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
            Using cmd As SqlCommand = New SqlCommand("Select nombre, apellido, dni from Personal as p INNER JOIN agenda as a ON a.profesional = p.dni where dni = '" & DNIProfesional.Text & "' and a.dia = '" & FechaTurno.Value.ToString("dddd") & "' ", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            txtNombreProfesional.Text = dt.Rows(0)(0).ToString()
                            txtApeProfesional.Text = dt.Rows(0)(1).ToString()
                            DNIProfesional.Text = dt.Rows(0)(2).ToString()
                        Else
                            MsgBox("El profesional ingresado no trabaja el dia ingresado", vbExclamation, "Error")
                            Me.Hide()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class