Imports System.Runtime.InteropServices

Public Class ModifHC
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
#Region "BOTONES ACEPTAR Y CANCELAR"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtDiagnostico.Text = "" Or txtMotivo.Text = "" Or txtTratamiento.Text = "" Then
            MessageBox.Show("Debe rellenar todos los campos")
        Else
            Try
                ClaseDatos.actualizarHistoriaClinica(HistoriaClinica.DataGridView1.CurrentRow.Cells("id").Value, HistoriaClinica.DataGridView1.CurrentRow.Cells("paciente").Value, txtMotivo.Text, txtDiagnostico.Text, txtTratamiento.Text, HistoriaClinica.DataGridView1.CurrentRow.Cells("prof").Value)
                txtDiagnostico.Text = ""
                txtMotivo.Text = ""
                txtTratamiento.Text = ""
                FormOS.cargarListadoObraSocialCompleto()
                MessageBox.Show("Registro actualizado exitosamente", "Actualizar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al actualizar registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            txtDiagnostico.Text = ""
            txtMotivo.Text = ""
            txtTratamiento.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub EditObraSocial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim id As Integer
            Dim paciente As Integer
            id = Convert.ToInt32(HistoriaClinica.DataGridView1.Item(0, HistoriaClinica.DataGridView1.CurrentRow.Index).Value)
            paciente = Convert.ToInt32(HistoriaClinica.DataGridView1.Item(1, HistoriaClinica.DataGridView1.CurrentRow.Index).Value)
            Dim hc As Historia_Clinica = ClaseDatos.getInfoHistoriaClinica(id, paciente)
            With hc
                txtDiagnostico.Text = .diagnostico
                txtMotivo.Text = .motivo_consulta
                txtTratamiento.Text = .tratamiento
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class