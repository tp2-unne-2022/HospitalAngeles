Public Class FormProfesionalesSecre
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub FormProfesionalesSecre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListadoPersonalAlta()
    End Sub

    Sub cargarListadoPersonalAlta()
        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarPersonal(Me.TxtBusqueda.Text, 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub cargarListadoPersonalBaja()
        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarPersonal(Me.TxtBusqueda.Text, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarListadoPersonalCompleto()
        Try
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarPersonal(Me.TxtBusqueda.Text, 2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbAlta_CheckedChanged(sender As Object, e As EventArgs) Handles rbAlta.CheckedChanged
        cargarListadoPersonalAlta()
    End Sub

    Private Sub rbBaja_CheckedChanged(sender As Object, e As EventArgs) Handles rbBaja.CheckedChanged
        cargarListadoPersonalBaja()
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        cargarListadoPersonalCompleto()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If rbAlta.Checked = True Then
            cargarListadoPersonalAlta()
        ElseIf rbBaja.Checked = True Then
            cargarListadoPersonalBaja()
        Else
            cargarListadoPersonalCompleto()
        End If
    End Sub
End Class