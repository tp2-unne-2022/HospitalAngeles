Public Class TablaUsuario
#Region "BOTONES BASICOS"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
#End Region
#Region "BD"
    Private Sub TiposUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListadoUsuario()
    End Sub
    Sub cargarListadoUsuario()
        Try
            DataGridView1.AutoGenerateColumns = False
            'La fuente de datos va a ser...
            DataGridView1.DataSource = ClaseDatos.listarUsuario(Me.TxtBusqueda.Text, 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarListadoUsuarioBaja()
        Try
            DataGridView1.AutoGenerateColumns = False
            'La fuente de datos va a ser...
            DataGridView1.DataSource = ClaseDatos.listarUsuario(Me.TxtBusqueda.Text, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarListadoUsuarioCompleto()
        Try
            DataGridView1.AutoGenerateColumns = False
            'La fuente de datos va a ser...
            DataGridView1.DataSource = ClaseDatos.listarUsuario(Me.TxtBusqueda.Text, 2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub rbAlta_CheckedChanged(sender As Object, e As EventArgs) Handles rbAlta.CheckedChanged
        cargarListadoUsuario()
    End Sub

    Private Sub rbBaja_CheckedChanged(sender As Object, e As EventArgs) Handles rbBaja.CheckedChanged
        cargarListadoUsuarioBaja()
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        cargarListadoUsuarioCompleto()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarUsuario.ShowDialog()
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar los datos a modificar")
        Else
            EditUsuario.ShowDialog()
        End If
    End Sub

    Private Sub butEliPac_Click(sender As Object, e As EventArgs) Handles butEli.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar los datos a modificar")
        ElseIf DataGridView1.CurrentRow.Cells("baja").Value = False Then
            MessageBox.Show("El registro ya está dado de Baja")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de baja el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    'ClaseDatos.eliminarUsuario(DataGridView1.CurrentRow.Cells("Id").Value)
                    eliminarUsuario()
                    MessageBox.Show("Registro dado de baja exitosamente", "Bajar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cargarListadoUsuario()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al dar de baja el tipo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub eliminarUsuario()
        Dim dniUsuario As Long
        Dim idTipo As Integer
        dniUsuario = DataGridView1.CurrentRow.Cells("dni").Value
        idTipo = DataGridView1.CurrentRow.Cells("Tipo").Value
        Dim valor As Integer
        valor = 0
        Dim ctx As New HospitalEntities4
        Dim usuario As Usuario = (From c In ctx.Usuario
                                  Where c.dni = dniUsuario And c.id_tipo_usuario = idTipo
                                  Select c).SingleOrDefault
        With usuario
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If rbAlta.Checked = True Then
            cargarListadoUsuario()
        ElseIf rbBaja.Checked = True Then
            cargarListadoUsuarioBaja()
        Else
            cargarListadoUsuarioCompleto()
        End If
    End Sub

    Private Sub btnTipos_Click(sender As Object, e As EventArgs) Handles btnTipos.Click
        If rbAct.Checked = True Then
            ShowRTU.CrystalReportViewer1.RefreshReport()
            ShowRTU.Show()
        ElseIf rbInactivos.Checked = True Then
            ShowUserInactivo.CrystalReportViewer1.RefreshReport()
            ShowUserInactivo.Show()
        Else
            MessageBox.Show("Debes seleccionar una opción")
        End If
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar el registro a dar de Alta")
        ElseIf DataGridView1.CurrentRow.Cells("baja").Value = True Then
            MessageBox.Show("El registro ya está dado de Alta")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de alta el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    darDeAltaUsuario()
                    'ClaseDatos.eliminarTipoPersonal(DataGridView1.CurrentRow.Cells("Id").Value)
                    MessageBox.Show("Registro dado de alta exitosamente", "Dar de alta registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cargarListadoUsuarioBaja()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al alzar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub darDeAltaUsuario()
        Dim dniUsuario As Long
        Dim idTipo As Integer
        dniUsuario = DataGridView1.CurrentRow.Cells("dni").Value
        idTipo = DataGridView1.CurrentRow.Cells("Tipo").Value
        Dim valor As Integer
        valor = 1
        Dim ctx As New HospitalEntities4
        Dim usuario As Usuario = (From c In ctx.Usuario
                                  Where c.dni = dniUsuario And c.id_tipo_usuario = idTipo
                                  Select c).SingleOrDefault
        With usuario
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub

    'Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
    '    If e.ColumnIndex = 4 And e.Value IsNot Nothing Then
    '        If e.Value = False Then
    '            e.CellStyle.BackColor = Color.LightCoral
    '        End If
    '    End If
    '    If e.ColumnIndex = 4 And e.Value IsNot Nothing Then
    '        If e.Value = True Then
    '            e.CellStyle.BackColor = Color.DarkSeaGreen
    '        End If
    '    End If
    'End Sub
#End Region
End Class