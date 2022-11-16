Imports System.Runtime.InteropServices

Public Class FormMantPacientes
#Region "LOAD"
    Private Sub FormMantPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGenero()
        CargarOS()
    End Sub
    Private Sub CargarGenero()
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Genero
                     Where c.deBaja = True
                     Select c).ToList
        Try
            cbGenero.DataSource = datos
            cbGenero.DisplayMember = "nombre"
            cbGenero.ValueMember = "Id"
            cbGenero.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarOS()
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Obra_Social
                     Where c.deBaja = True
                     Select c).ToList
        Try
            cbOS.DataSource = datos
            cbOS.DisplayMember = "nombre"
            cbOS.ValueMember = "Id"
            cbOS.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
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
    Private Sub txtNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dtpNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpNacimiento.ValueChanged
        dtpNacimiento.MaxDate = DateTime.Today
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles dtpAlta.ValueChanged
        dtpAlta.MaxDate = DateTime.Today
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtLoc.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtProv.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtTelef.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDirec_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtDirec.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            txtNombre.Text = ""
            txtApellido.Text = ""
            txtDNI.Text = ""
            dtpNacimiento.ResetText()
            dtpAlta.ResetText()
            cbOS.SelectedIndex = -1
            cbGenero.SelectedIndex = -1
            txtDirec.Text = ""
            txtLoc.Text = ""
            txtProv.Text = ""
            txtTelef.Text = ""
            txtEmail.Text = ""
            Me.Close()
        End If
    End Sub
#End Region
#Region "AGREGADO"
    Private mru As FormPacientes
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim valorCBGenero As Integer
        Dim valorCBOS As Integer

        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Paciente).ToList

        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtDNI.Text = "" Or txtDirec.Text = "" Or txtLoc.Text = "" Or txtProv.Text = "" Or cbOS.SelectedIndex = -1 Or cbGenero.SelectedIndex = -1 Or txtTelef.Text = "" Or txtEmail.Text = "" Then
            MessageBox.Show("Complete todos los campos")
        ElseIf txtEmail.Text.Contains("@gmail.com") Or txtEmail.Text.Contains("@outlook.com") Or txtEmail.Text.Contains("@live.com") Or txtEmail.Text.Contains("@yahoo.com") Or txtEmail.Text.Contains("@hotmail.com") Then
            Try
                Dim valueG As Object = cbGenero.SelectedValue
                Dim valueOS As Object = cbOS.SelectedValue
                If (valueG IsNot Nothing) Then
                    ' Convertimos el valor obtenido al tipo de dato
                    ' adecuado, en éste caso, a un valor Int.
                    '
                    valorCBGenero = Convert.ToInt32(valueG)
                End If
                If (valueOS IsNot Nothing) Then
                    ' Convertimos el valor obtenido al tipo de dato
                    ' adecuado, en éste caso, a un valor Int.
                    '
                    valorCBOS = Convert.ToInt32(valueOS)
                End If

                Dim valorDeBaja As Boolean
                Dim contarFilas As Integer
                valorDeBaja = True
                contarFilas = FormPacientes.DataGridView1.Rows.Count + 1
                ClaseDatos.insertarPaciente(New Paciente() With {
                                            .Id = contarFilas, .deBaja = valorDeBaja, .nombre = Me.txtNombre.Text, .apellido = Me.txtApellido.Text, .dni = Me.txtDNI.Text, .localidad = Me.txtLoc.Text, .provincia = Me.txtProv.Text, .direccion = Me.txtDirec.Text, .telefono = Me.txtTelef.Text, .fecha_alta = Me.dtpAlta.Text, .id_obra_soc = valorCBOS, .id_genero = valorCBGenero, .fecha_nac = Me.dtpNacimiento.Text, .email = Me.txtEmail.Text})
                '.id_hist_clin = Nothing
                FormPacientes.cargarListadoPacientes()
                MessageBox.Show("Registro creado exitosamente", "Añadir registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNombre.Text = ""
                txtApellido.Text = ""
                txtDNI.Text = ""
                txtLoc.Text = ""
                txtProv.Text = ""
                txtDirec.Text = ""
                txtTelef.Text = ""
                txtEmail.Text = ""
                dtpNacimiento.ResetText()
                dtpAlta.ResetText()
                cbOS.SelectedIndex = -1
                cbGenero.SelectedIndex = -1
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al añadir paciente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Coloque un email válido")
        End If
    End Sub

    Private Sub btnActuObraSocial_Click(sender As Object, e As EventArgs) Handles btnActuObraSocial.Click
        cbOS.SelectedIndex = -1
    End Sub

    Private Sub btnActuGenero_Click(sender As Object, e As EventArgs) Handles btnActuGenero.Click
        cbGenero.SelectedIndex = -1
    End Sub
#End Region
End Class