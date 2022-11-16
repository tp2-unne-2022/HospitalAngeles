Imports System.Runtime.InteropServices
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class EntradaHC
    Dim dniProf As New Personal
#Region "LOAD"
    Private Sub EntradaHC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListadoTurno()
    End Sub
    Sub cargarListadoTurno()
        Try
            Dim dniP As Long
            dniP = Convert.ToInt64(FormPrincipalMedico.lbDni.Text)
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = listarTurnosCargados(dniP)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Shared Function listarTurnosCargados(dniProf As Long)
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.turnos
                     Where c.deBaja = True And c.profesional = dniProf).ToList
        Return datos
    End Function
#End Region
#Region "BOTONES PARTE SUPERIOR"
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btnC.Click
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
#Region "RESTRICCIONES"
    Private Sub txtNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtMotivo.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtDiagnostico.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtTratamiento.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region
#Region "AGREGADO"
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            txtMotivo.Text = ""
            txtDiagnostico.Text = ""
            txtTratamiento.Text = ""
            Me.Close()
        End If
    End Sub
    Sub cargarDNI(dni As Long)
        dniProf.dni = dni
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un registro")
        ElseIf txtDiagnostico.Text = "" Or txtMotivo.Text = "" Or txtTratamiento.Text = "" Then
            MessageBox.Show("Complete todos los campos")
        Else
            Try
                'Dim contarFilas As Integer
                Dim nro__turno As Integer
                nro__turno = DataGridView1.CurrentRow.Cells("turno").Value
                Dim idPac As Integer
                Dim hoy As Date
                Dim dni As Long

                'If contarFilas = Nothing Then
                '    contarFilas = 1
                'Else
                '    contarFilas = DataGridView1.Rows.Count + 1
                'End If
                idPac = Convert.ToInt32(DataGridView1.Item(3, DataGridView1.SelectedRows.Count - 1).Value)
                hoy = DateAndTime.Now
                dni = Convert.ToInt64(DataGridView1.Item(4, DataGridView1.SelectedRows.Count - 1).Value)

                ClaseDatos.insertarHIstoriaClinica(New Historia_Clinica() With {
                                                        .Id = nro__turno, .id_paciente = idPac, .motivo_consulta = txtMotivo.Text, .diagnostico = txtDiagnostico.Text, .tratamiento = txtTratamiento.Text, .fecha = hoy, .id_profesional = dni})
                MessageBox.Show("Registro creado exitosamente", "Añadir registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ''''''''''''''''''''
                Dim nro_de_turno As Integer
                nro_de_turno = DataGridView1.CurrentRow.Cells("turno").Value
                Dim valor As Integer
                valor = 0
                Dim ctx As New HospitalEntities4
                Dim turno As turnos = (From c In ctX.turnos
                                       Where c.nro_turno = nro_de_turno
                                       Select c).SingleOrDefault
                With turno
                    .deBaja = valor
                End With
                ctX.SaveChanges()
                ''''''''''''''''''''
                txtMotivo.Text = ""
                txtDiagnostico.Text = ""
                txtTratamiento.Text = ""
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
#End Region
End Class