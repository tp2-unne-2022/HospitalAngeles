Imports System.Data.SqlClient
Public Class BackUp
    Private conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")

    Private Sub BackUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        Dim AnswerYes As String
        Dim AnswerNo As String
        Dim diaActual As Date = Today
        Dim horaActual As Date = TimeOfDay
        Dim textoFecha As String
        textoFecha = "Hospital " + diaActual.ToString("dd-MM-yyyy") + " " + horaActual.ToString("HH:mm:ss")

        AnswerYes = MsgBox("ATENCIÓN: ¿Esta seguro de realizar dicha acción?", vbInformation + vbYesNo, "BACKUP")

        If AnswerYes = vbYes Then
            Dim sfd As New SaveFileDialog() With {
            .Filter = "Backup File | *.bak",
            .FileName = textoFecha
            }

            If sfd.ShowDialog = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Dim sql As String = $"backup database Hospital to disk = '{sfd.FileName}'"
                Dim cmd As New SqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Backup listo")
                Cursor = Cursors.Default
            End If
        ElseIf AnswerYes = vbNo Then
            Me.Close()
        Else
            MsgBox("ATENCIÓN: ¿Esta seguro de realizar dicha acción?", vbCritical + vbYesNo, "BACKUP")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class