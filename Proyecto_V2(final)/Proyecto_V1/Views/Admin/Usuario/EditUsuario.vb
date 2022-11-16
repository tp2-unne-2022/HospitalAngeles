Imports System.Runtime.InteropServices

Public Class EditUsuario
#Region "BOTONES - X"
    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            Me.Close()
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
    Private Sub txtUser_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region
#Region "Botones bajos"
    Dim valorCBTU As Integer
    Dim valorCBP As Integer
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim user_type As Integer
        If txtUser.Text = "" Or txtPass.Text = "" Or cbPersonal.SelectedIndex = -1 Or cbTUsuario.SelectedIndex = -1 Then
            MessageBox.Show("Debe rellenar todos los campos")
        ElseIf txtPass.Text.Length < 6 Then
            MessageBox.Show("La contraseña debe tener como mínimo 6 caracteres")
        Else
            Try
                Dim valueUsuario As Object = cbTUsuario.SelectedValue
                Dim valuePersonal As Object = cbPersonal.SelectedValue
                If (valueUsuario IsNot Nothing) Then
                    ' Convertimos el valor obtenido al tipo de dato
                    ' adecuado, en éste caso, a un valor Int.
                    '
                    valorCBTU = Convert.ToInt32(valueUsuario)
                End If
                If (valuePersonal IsNot Nothing) Then
                    ' Convertimos el valor obtenido al tipo de dato
                    ' adecuado, en éste caso, a un valor Int.
                    '
                    valorCBP = Convert.ToInt32(valuePersonal)
                End If
                ClaseDatos.actualizarUsuario(valorCBP, valorCBTU, txtUser.Text, txtPass.Text)
                txtUser.Text = ""
                txtPass.Text = ""
                cbPersonal.SelectedIndex = -1
                cbTUsuario.SelectedIndex = -1
                TablaUsuario.cargarListadoUsuario()
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
            Me.Close()
        End If
    End Sub

    Private Sub EditUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarUsuario()
        cargarPersonal()
        Try
            Dim user As Usuario = ClaseDatos.getInfoUsuario(TablaUsuario.DataGridView1.CurrentRow.Cells("dni").Value, TablaUsuario.DataGridView1.CurrentRow.Cells("Tipo").Value)
            With user
                txtUser.Text = .username
                txtPass.Text = .password
                cbTUsuario.SelectedIndex = .id_tipo_usuario - 1
                cbPersonal.SelectedValue = .dni
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar los datos Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cargarUsuario()
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Tipo_Usuario
                     Select c).ToList
        Try
            cbTUsuario.DataSource = datos
            cbTUsuario.DisplayMember = "nombre"
            cbTUsuario.ValueMember = "Id"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cargarPersonal()
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Personal
                     Select c).ToList
        Try
            cbPersonal.DataSource = datos
            cbPersonal.DisplayMember = "dni"
            cbPersonal.ValueMember = "dni"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class