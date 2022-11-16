Imports System.Data.SqlClient

Public Class Restore
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult = MsgBox("Seguro que quiere continuar?", MsgBoxStyle.YesNo, "RESTORE")
        If ask = MsgBoxResult.Yes Then
            RestoreWarning.ShowDialog()
        End If

    End Sub
End Class