Imports System.Runtime.InteropServices

Public Class EditObraSocial
#Region "BOTONES - X"
    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            txtNombre.Text = ""
            txtCobertura.Text = ""
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
    Private Sub txtNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCobertura_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtCobertura.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region
#Region "BOTONES ACEPTAR Y CANCELAR"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Or txtCobertura.Text = "" Then
            MessageBox.Show("Debe rellenar todos los campos")
        Else
            Try
                ClaseDatos.actualizarObraSoc(FormOS.DataGridView1.CurrentRow.Cells("Id").Value, txtNombre.Text, txtCobertura.Text)
                txtNombre.Text = ""
                txtCobertura.Text = ""
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
            txtNombre.Text = ""
            txtCobertura.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub EditObraSocial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim os As Obra_Social = ClaseDatos.getInfoObraSocial(FormOS.DataGridView1.CurrentRow.Cells("Id").Value)
            With os
                txtNombre.Text = .nombre
                txtCobertura.Text = .porc_cobertura
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al seleccionar Obra Social", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class