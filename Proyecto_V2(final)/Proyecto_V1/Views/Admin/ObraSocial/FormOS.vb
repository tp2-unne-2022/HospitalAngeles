Public Class FormOS
#Region "BOTONES BASICOS"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    'Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    'BUSQUEDA SIN BD
    'Dim i As Integer
    'i = DataGridView1.CurrentRow.Index

    'txtNombre.Text = DataGridView1.Item(1, i).Value
    'txtCobertura.Text = DataGridView1.Item(2, i).Value
    'End Sub
#End Region
#Region "REPORTE"
    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        If rbPaciente.Checked Then
            ShowROSpaciente.crvOS.RefreshReport()
            ShowROSpaciente.Show()
        ElseIf rbPersonal.Checked Then
            ShowROSpersonal.crvOS.RefreshReport()
            ShowROSpersonal.Show()
        Else
            MessageBox.Show("Seleccione una opción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region
#Region "INTERACCION CON BD"
    Private Sub FormOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListadoObraSocial()
    End Sub

    Sub cargarListadoObraSocial()
        Try
            DataGridView1.AutoGenerateColumns = False
            'La fuente de datos va a ser...
            DataGridView1.DataSource = ClaseDatos.listarObrasSociales(Me.TxtBusqueda.Text, 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarListadoObraSocialBaja()
        Try
            DataGridView1.AutoGenerateColumns = False
            'La fuente de datos va a ser...
            DataGridView1.DataSource = ClaseDatos.listarObrasSociales(Me.TxtBusqueda.Text, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarListadoObraSocialCompleto()
        Try
            DataGridView1.AutoGenerateColumns = False
            'La fuente de datos va a ser...
            DataGridView1.DataSource = ClaseDatos.listarObrasSociales(Me.TxtBusqueda.Text, 2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub rbAlta_CheckedChanged(sender As Object, e As EventArgs) Handles rbAlta.CheckedChanged
        cargarListadoObraSocial()
    End Sub

    Private Sub rbBaja_CheckedChanged(sender As Object, e As EventArgs) Handles rbBaja.CheckedChanged
        cargarListadoObraSocialBaja()
    End Sub

    Private Sub rbTodosRegistros_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodosRegistros.CheckedChanged
        cargarListadoObraSocialCompleto()
    End Sub
    Private Sub btnActu_Click(sender As Object, e As EventArgs) Handles btnActu.Click
        'Try
        '    DataGridView1.AutoGenerateColumns = False
        '    'La fuente de datos va a ser...
        '    DataGridView1.DataSource = ClaseDatos.listarObrasSociales("")
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If rbAlta.Checked = True Then
            cargarListadoObraSocial()
        ElseIf rbBaja.Checked = True Then
            cargarListadoObraSocialBaja()
        Else
            cargarListadoObraSocialCompleto()
        End If
        'Busqueda SIN BD
        'For Each row As DataGridViewRow In DataGridView1.Rows
        'If row.Cells("id_obra_social").Value = TxtBusqueda.Text Then
        '    DataGridView1.ClearSelection()
        '    row.Selected = True
        '    Exit For
        'End If
        '    If row.Cells("nombre").Value = TxtBusqueda.Text Then
        '        DataGridView1.ClearSelection()
        '        row.Selected = True
        '        Exit For
        '    End If
        'Next
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        '-----AGREGAR CON ACCESO A BD-----
        rbTodosRegistros.Checked = True
        cargarListadoObraSocialCompleto()
        AgregarObraSocial.ShowDialog()
        '-----AGREGAR SIN ACCESO A BD-----
        'se declara la variable en la que se almacenara el valor total de registros

        'Dim contador As Single

        'se inicia el contador a 0

        'contador = 1

        'con un for se recorre toda el datagridview o dgv

        'For x = 0 To DataGridView1.RowCount - 1

        'con un if se recorre la culumna deseada,

        'notese que (0, x) es: 0 = el indice de la columna es decir la uno se puede cambiar por cualquiera es decir 0, 1, 2... n. y "x" es el recorrido en el dgv

        'If DataGridView1.Item(0, x).Value > 0 Then

        'se inicia el contador de uno en uno

        '        contador += 1
        '    End If
        'Next

        'If txtNombre.Text = "" Or txtPC.Text = "" Then
        '    MessageBox.Show("Rellene todos los campos")
        'Else
        '    Me.DataGridView1.Rows.Add(contador, txtNombre.Text, txtPC.Text)
        '    txtNombre.Text = ""
        '    txtPC.Text = ""
        'End If
    End Sub
    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        '-----MODIFICAR SIN BD-----
        'Dim j As Integer
        'If DataGridView1.SelectedRows.Count = 0 Then
        '    MessageBox.Show("Debes seleccionar los datos a modificar")
        'Else
        '    Dim ask As MsgBoxResult = MsgBox("Seguro que quiere modificar el registro?", MsgBoxStyle.YesNo, "Modificar")
        '    If ask = MsgBoxResult.Yes Then
        '        j = DataGridView1.CurrentRow.Index + 1
        '        DataGridView1.SelectedRows(0).SetValues(j, txtNombre.Text, txtCobertura.Text)
        '    End If
        'End If
        '-----MODIFICAR CON BD-----
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar los datos a modificar")
        Else
            EditObraSocial.ShowDialog()
        End If
    End Sub
    Private Sub butEliPac_Click(sender As Object, e As EventArgs) Handles butEliPac.Click
        '--Eliminar sin BD--
        'If DataGridView1.SelectedRows.Count > 0 Then
        '    Dim ask As MsgBoxResult = MsgBox("Seguro que quiere eliminar el registro?", MsgBoxStyle.YesNo, "Eliminar")
        '    If ask = MsgBoxResult.Yes Then
        '        For i As Integer = DataGridView1.SelectedRows.Count - 1 To 0 Step -1
        '            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(i).Index)
        '        Next
        '    End If
        'Else
        '    MessageBox.Show("Debes seleccionar los datos a eliminar")
        'End If
        '--Eliminar con BD
        'If DataGridView1.SelectedRows.Count = 0 Then
        '    MessageBox.Show("Debes seleccionar el registro a eliminar")
        'Else
        '    Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea eliminar el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '    If resp = MsgBoxResult.Yes Then
        '        Try
        '            ClaseDatos.eliminarObraSocial(DataGridView1.CurrentRow.Cells("Id").Value)
        '            MessageBox.Show("Registro eliminado exitosamente", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            cargarListadoObraSocial()
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message, "Error al eliminar obra social", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End Try
        '    End If
        'End If
        '--Dar de baja
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar el registro a dar de baja")
        ElseIf DataGridView1.CurrentRow.Cells("deBaja").Value = False Then
            MessageBox.Show("El registro ya está dado de Baja")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de baja el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    bajarOS()
                    'ClaseDatos.eliminarPersonal(DataGridView1.CurrentRow.Cells("Id").Value)
                    MessageBox.Show("El registro se ha dado de baja exitosamente", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    rbAlta.Checked = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al eliminar personal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub bajarOS()
        Dim id As Long
        id = DataGridView1.CurrentRow.Cells("Id").Value
        Dim valor As Integer
        valor = 0
        Dim ctx As New HospitalEntities4
        Dim obra_social As Obra_Social = (From c In ctx.Obra_Social
                                          Where c.Id = id
                                          Select c).SingleOrDefault
        With obra_social
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar el registro a dar de alta")
        ElseIf DataGridView1.CurrentRow.Cells("deBaja").Value = True Then
            MessageBox.Show("El registro ya está dado de Alta")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de alta el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    alzarOS()
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

    Private Sub alzarOS()
        Dim id As Long
        id = DataGridView1.CurrentRow.Cells("Id").Value
        Dim valor As Integer
        valor = 1
        Dim ctx As New HospitalEntities4
        Dim obra_social As Obra_Social = (From c In ctx.Obra_Social
                                          Where c.Id = id
                                          Select c).SingleOrDefault
        With obra_social
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub
#End Region
End Class