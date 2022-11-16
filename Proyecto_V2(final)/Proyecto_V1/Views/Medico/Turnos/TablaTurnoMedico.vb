Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Data.SqlClient
Imports System.Net
Imports System.Windows.Controls

Public Class TablaTurnoMedico
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub TablaTurnoMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListadoTurnosAlta()
    End Sub

    Sub cargarListadoTurnos()
        Dim dni As Long
        dni = Convert.ToInt64(FormPrincipalMedico.lbDni.Text)

        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")

            Using cmd As SqlCommand = New SqlCommand("SELECT 
	        turnos.nro_turno As nro_turno,
	        turnos.fecha As fecha,
	        turnos.hora As hora,
            turnos.deBaja As deBaja,
            Paciente.Id As paciente,
            Paciente.nombre AS nombre,
	        Paciente.apellido As apellido,
	        Paciente.dni As dni,
            Paciente.Id As idpaciente,
            p.nombre AS nombre_profesional,
			p.apellido AS apellido_profesional,
			p.dni AS dni_profesional
            FROM turnos
            JOIN Paciente ON turnos.paciente = Paciente.id
            INNER JOIN Personal as p ON turnos.profesional = p.dni WHERE p.dni = '" & dni & "'", conn)
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

    Sub cargarListadoTurnosBaja()
        Dim dni As Long
        dni = Convert.ToInt64(FormPrincipalMedico.lbDni.Text)

        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")

            Using cmd As SqlCommand = New SqlCommand("SELECT 
	        turnos.nro_turno As nro_turno,
	        turnos.fecha As fecha,
	        turnos.hora As hora,
            turnos.deBaja As deBaja,
            Paciente.Id As paciente,
            Paciente.nombre AS nombre,
	        Paciente.apellido As apellido,
	        Paciente.dni As dni,
            Paciente.Id As idpaciente,
            p.nombre AS nombre_profesional,
			p.apellido AS apellido_profesional,
			p.dni AS dni_profesional
            FROM turnos
            JOIN Paciente ON turnos.paciente = Paciente.id
            INNER JOIN Personal as p ON turnos.profesional = p.dni WHERE turnos.deBaja = 0 and p.dni = '" & dni & "'", conn)
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

    Sub cargarListadoTurnosAlta()
        Dim dni As Long
        dni = Convert.ToInt64(FormPrincipalMedico.lbDni.Text)

        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")

            Using cmd As SqlCommand = New SqlCommand("SELECT 
	        turnos.nro_turno As nro_turno,
	        turnos.fecha As fecha,
	        turnos.hora As hora,
            turnos.deBaja As deBaja,
            Paciente.Id As paciente,
            Paciente.nombre AS nombre,
	        Paciente.apellido As apellido,
	        Paciente.dni As dni,
            Paciente.Id As idpaciente,
            p.nombre AS nombre_profesional,
			p.apellido AS apellido_profesional,
			p.dni AS dni_profesional
            FROM turnos
            JOIN Paciente ON turnos.paciente = Paciente.id
            INNER JOIN Personal as p ON turnos.profesional = p.dni WHERE turnos.deBaja = 1 and p.dni = '" & dni & "'", conn)
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
    Private Sub rbAlta_CheckedChanged(sender As Object, e As EventArgs) Handles rbAlta.CheckedChanged
        cargarListadoTurnosAlta()
    End Sub

    Private Sub rbBaja_CheckedChanged(sender As Object, e As EventArgs) Handles rbBaja.CheckedChanged
        cargarListadoTurnosBaja()
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        cargarListadoTurnos()
    End Sub

    Sub buscarTurnos()

        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")

            Using cmd As SqlCommand = New SqlCommand("SELECT 
	        turnos.nro_turno As nro_turno,
	        turnos.fecha As fecha,
	        turnos.hora As hora,
            turnos.deBaja As deBaja,
            Paciente.Id As paciente,
            Paciente.nombre AS nombre,
	        Paciente.apellido As apellido,
	        Paciente.dni As dni,
            Paciente.Id As idpaciente,
            p.nombre AS nombre_profesional,
			p.apellido AS apellido_profesional,
			p.dni AS dni_profesional
            FROM turnos
            JOIN Paciente ON turnos.paciente = Paciente.id
            INNER JOIN Personal as p ON turnos.profesional = p.dni
            WHERE Paciente.apellido = '" & TxtBusqueda.Text & "'", conn)
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
        buscarTurnos()
    End Sub
End Class