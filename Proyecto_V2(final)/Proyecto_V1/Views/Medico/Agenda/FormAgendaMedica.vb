Imports System.Data.SqlClient

Public Class FormAgendaMedica
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAgenda.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim i As Integer = DataGridView1.SelectedRows(0).Index
        DataGridView1.Rows.RemoveAt(i)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub FormAgendaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListadoHorarios()
    End Sub

    Sub cargarListadoHorarios()
        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarAgenda()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar los datos a modificar")
        Else
            FormEditAgenda.ShowDialog()
        End If
    End Sub

    Private Sub btnActu_Click(sender As Object, e As EventArgs) Handles btnActu.Click
        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarAgenda()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class