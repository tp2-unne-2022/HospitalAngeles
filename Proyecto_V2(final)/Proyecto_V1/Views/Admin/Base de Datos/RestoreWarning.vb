Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class RestoreWarning
    Private conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=master; Integrated Security = true")
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "123456" Then
            Dim ask As MsgBoxResult = MsgBox("El RESTORE se realizará", MsgBoxStyle.YesNo, "Ultima advertencia")
            If ask = MsgBoxResult.Yes Then
                Dim sfd As New OpenFileDialog() With {
            .Filter = "Backup File | *.bak",
            .FileName = ""
            }
                If sfd.ShowDialog = DialogResult.OK Then
                    Cursor = Cursors.WaitCursor
                    Dim sql As String = $"restore database Hospital from disk= '{sfd.FileName}'"
                    Dim cmd As New SqlCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Restore listo")
                    Cursor = Cursors.Default
                End If
            End If
        End If
        Me.Close()
    End Sub
End Class