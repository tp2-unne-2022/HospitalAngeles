Public Class FormPacientesMedico
#Region "BOTONES BASICOS"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

#End Region
#Region "INTERACCION BD"
    Private Sub FormPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListadoPacientes()
    End Sub

    Sub cargarListadoPacientes()
        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarPacientes(Me.TxtBusqueda.Text, 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarListadoPacientesBaja()
        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarPacientes(Me.TxtBusqueda.Text, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarListadoPacientesCompleto()
        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarPacientes(Me.TxtBusqueda.Text, 2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If rbAlta.Checked = True Then
            cargarListadoPacientes()
        ElseIf rbBaja.Checked = True Then
            cargarListadoPacientesBaja()
        Else
            cargarListadoPacientesCompleto()
        End If
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        cargarListadoPacientesCompleto()
    End Sub

    Private Sub rbBaja_CheckedChanged(sender As Object, e As EventArgs) Handles rbBaja.CheckedChanged
        cargarListadoPacientesBaja()
    End Sub

    Private Sub rbAlta_CheckedChanged(sender As Object, e As EventArgs) Handles rbAlta.CheckedChanged
        cargarListadoPacientes()
    End Sub

#End Region
End Class