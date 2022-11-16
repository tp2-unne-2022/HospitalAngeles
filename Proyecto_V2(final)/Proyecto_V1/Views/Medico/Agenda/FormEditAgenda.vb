Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class FormEditAgenda
    Dim resultado As String
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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            Me.Hide()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        Hora2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Hora2.CustomFormat = "HH:mm"
        Hora2.ShowUpDown = True
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs)
        Hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Hora.CustomFormat = "HH:mm"
        Hora.ShowUpDown = True
    End Sub

    Sub buscarDia(dia As String)
        Dim dni As Long
        dni = FormPrincipalMedico.lbDni.Text
        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
            Using cmd As SqlCommand = New SqlCommand("SELECT TOP 1 dia from agenda where profesional = '" & dni & "' And dia = '" & dia & "'", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    conn.Open()
                    resultado = CStr(cmd.ExecuteScalar)
                End Using
            End Using
        End Using
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim dni As Long
        Dim diaTexto As String
        dni = FormPrincipalMedico.lbDni.Text
        diaTexto = Convert.ToString(Me.DomainUpDown1.SelectedItem)
        buscarDia(Me.DomainUpDown1.SelectedItem)
        Debug.Print(resultado)
        'If String.IsNullOrEmpty(DomainUpDown1.Text) = False Then
        If resultado <> "Lunes" And resultado <> "Jueves" And resultado <> "Martes" And resultado <> "Miercoles" And resultado <> "Viernes" And resultado <> "Sabado" And resultado <> "dia" Then
            'ClaseDatos.insertarHorario(New agenda() With {
            '.dia = Me.DomainUpDown1.SelectedItem, .hora_entrada = Hora.Value.TimeOfDay(), .hora_salida = Hora2.Value.TimeOfDay(), .profesional = dni})
            ClaseDatos.actualizarAgenda(FormAgendaMedica.DataGridView1.CurrentRow.Cells("id_agenda").Value, Hora.Value.TimeOfDay(), Hora2.Value.TimeOfDay(), Me.DomainUpDown1.SelectedItem, dni)
            MsgBox("Se modificó el horario", vbInformation, "Exito")
            Me.Hide()
        Else
            MsgBox("El dia seleccionado ya esta en la agenda", vbCritical, "Requerido")
        End If
        'Else
        '    MsgBox("Hay campos requeridos", vbCritical, "Requerido")
        'Me.Hide()
        'End If
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged

    End Sub

    Private Sub FormAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DomainUpDown1.Items.Add("Lunes")
        DomainUpDown1.Items.Add("Martes")
        DomainUpDown1.Items.Add("Miercoles")
        DomainUpDown1.Items.Add("Jueves")
        DomainUpDown1.Items.Add("Viernes")
        DomainUpDown1.Items.Add("Sabado")

        Hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Hora.CustomFormat = "HH:mm"
        Hora.ShowUpDown = True

        Hora2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Hora2.CustomFormat = "HH:mm"
        Hora2.ShowUpDown = True



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        ''ACA IRIA EL id del usuario que ingreso o el nombre asi puede guardarse la agenda
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
    '        Using cmd As SqlCommand = New SqlCommand("Select dni, apellido from Personal where dni = '" & TextBox2.Text & "' ", conn)
    '            Using da As New SqlDataAdapter
    '                da.SelectCommand = cmd
    '                Using dt As New DataTable
    '                    da.Fill(dt)
    '                    If dt.Rows.Count > 0 Then
    '                        TextBox2.Text = dt.Rows(0)(0).ToString()
    '                    End If
    '                End Using
    '            End Using
    '        End Using
    '    End Using
    'End Sub

    Private Sub DateTimePicker3_ValueChanged_1(sender As Object, e As EventArgs) Handles Hora.ValueChanged
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            Me.Hide()
        End If
    End Sub
End Class