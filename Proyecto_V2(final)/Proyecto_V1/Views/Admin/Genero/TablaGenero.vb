Public Class TablaGenero
#Region "BOTONES BASICOS"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
#End Region
#Region "ACCESO A BD"
    Private Sub TablaGenero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListadoGenero()
    End Sub
    Sub cargarListadoGenero()
        Try
            DataGridView1.AutoGenerateColumns = False
            'La fuente de datos va a ser...
            DataGridView1.DataSource = ClaseDatos.listarGeneros(Me.TxtBusqueda.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        '--Agregar SIN bd--
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

        'If txtNombre.Text = "" Or txtDesc.Text = "" Then
        '    MessageBox.Show("Rellene todos los campos")
        'Else
        '    Me.DataGridView1.Rows.Add(contador, txtNombre.Text, txtDesc.Text)
        '    txtNombre.Text = ""
        '    txtDesc.Text = ""
        'End If

        '--Agregar CON bd--
        AgregarGenero.ShowDialog()
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        '--Modificar sin BD--
        'Dim j As Integer
        'If DataGridView1.SelectedRows.Count = 0 Then
        '    MessageBox.Show("Debes seleccionar los datos a modificar")
        'Else
        '    Dim ask As MsgBoxResult = MsgBox("Seguro que quiere modificar el registro?", MsgBoxStyle.YesNo, "Modificar")
        '    If ask = MsgBoxResult.Yes Then
        '        j = DataGridView1.CurrentRow.Index + 1
        '        DataGridView1.SelectedRows(0).SetValues(j, txtNombre.Text, txtDesc.Text)
        '    End If
        'End If
        '--Modificar con BD--
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un registro")
        Else
            EditGenero.ShowDialog()
        End If
    End Sub

    Private Sub butEliPac_Click(sender As Object, e As EventArgs) Handles butEli.Click
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
        '--Eliminar con BD--
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar el registro a eliminar")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea eliminar el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    ClaseDatos.eliminarGenero(DataGridView1.CurrentRow.Cells("Id").Value)
                    MessageBox.Show("Registro eliminado exitosamente", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cargarListadoGenero()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al eliminar el genero", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    'Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    '    Dim i As Integer
    '    i = DataGridView1.CurrentRow.Index

    '    txtNombre.Text = DataGridView1.Item(1, i).Value
    '    txtDesc.Text = DataGridView1.Item(2, i).Value
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        '--Busqueda SIN BD--
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
        '--Busqueda CON BD--
        cargarListadoGenero()
    End Sub
#End Region
End Class