Public Class PacientesSecre
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
    Private Sub rbAlta_CheckedChanged(sender As Object, e As EventArgs) Handles rbAlta.CheckedChanged
        cargarListadoPacientes()
    End Sub

    Private Sub rbBaja_CheckedChanged(sender As Object, e As EventArgs) Handles rbBaja.CheckedChanged
        cargarListadoPacientesBaja()
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        cargarListadoPacientesCompleto()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMantPacientes.ShowDialog()
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar los datos a modificar")
        Else
            FormEditPacientes.ShowDialog()
        End If
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

    Private Sub darDeAltaAlPaciente()
        Dim id As Long
        id = DataGridView1.CurrentRow.Cells("Id").Value
        Dim valor As Integer
        valor = 1
        Dim ctx As New HospitalEntities4
        Dim paciente As Paciente = (From c In ctx.Paciente
                                    Where c.Id = id
                                    Select c).SingleOrDefault
        With paciente
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub

    Private Sub bajarPaciente()
        Dim id As Long
        id = DataGridView1.CurrentRow.Cells("Id").Value
        Dim valor As Integer
        valor = 0
        Dim ctx As New HospitalEntities4
        Dim paciente As Paciente = (From c In ctx.Paciente
                                    Where c.Id = id
                                    Select c).SingleOrDefault
        With paciente
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar el registro a dar de alta")
        ElseIf DataGridView1.CurrentRow.Cells("baja").Value = True Then
            MessageBox.Show("El registro ya está dado de Alta")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de alta el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    darDeAltaAlPaciente()
                    'ClaseDatos.eliminarPersonal(DataGridView1.CurrentRow.Cells("Id").Value)
                    MessageBox.Show("El registro se ha dado de alta exitosamente", "Dar de alta registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cargarListadoPacientes()
                    rbAlta.Checked = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al alzar al personal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnEli_Click(sender As Object, e As EventArgs) Handles btnEli.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar el registro a dar de baja")
        ElseIf DataGridView1.CurrentRow.Cells("Baja").Value = False Then
            MessageBox.Show("El registro ya está dado de Baja")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de baja el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    bajarPaciente()
                    'ClaseDatos.eliminarPersonal(DataGridView1.CurrentRow.Cells("Id").Value)
                    MessageBox.Show("El registro se ha dado de baja exitosamente", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    rbAlta.Checked = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al eliminar personal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnActu_Click(sender As Object, e As EventArgs) Handles btnActu.Click
        If rbAlta.Checked = True Then
            cargarListadoPacientes()
        ElseIf rbBaja.Checked = True Then
            cargarListadoPacientesBaja()
        Else
            cargarListadoPacientesCompleto()
        End If
    End Sub
#End Region
End Class