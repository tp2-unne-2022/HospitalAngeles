Imports System.Data.SqlClient

Public Class FormAgendaSecre
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub FormAgendaSecre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListadoHorarios()
    End Sub

    Sub cargarListadoHorarios()

        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")

            Using cmd As SqlCommand = New SqlCommand("SELECT 
	        agenda.dia As dia,
	        agenda.hora_entrada As hora_entrada,
            agenda.hora_salida As hora_salida,
            Personal.nombre As nombre,
            Personal.apellido As apellido,
            Personal.dni As dni
            FROM agenda
            INNER JOIN Personal ON Personal.dni = agenda.profesional", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")

            Using cmd As SqlCommand = New SqlCommand("SELECT 
	        agenda.dia As dia,
	        agenda.hora_entrada As hora_entrada,
            agenda.hora_salida As hora_salida,
            Personal.nombre As nombre,
            Personal.apellido As apellido,
            Personal.dni As dni
            FROM agenda
            INNER JOIN Personal ON Personal.dni = '" & TxtBusqueda.Text & "' ", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class