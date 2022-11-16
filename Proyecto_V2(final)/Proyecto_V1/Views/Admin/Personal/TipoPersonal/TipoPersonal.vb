Imports System.Runtime.InteropServices

Public Class TipoPersonal
#Region "BOTONES BASICOS"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
#Region "FUNCIONES"
    Private Sub TipoPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListadoTipoPersonal()
    End Sub
    Sub cargarListadoTipoPersonal()
        Try
            DataGridView1.AutoGenerateColumns = False
            'La fuente de datos va a ser...
            DataGridView1.DataSource = ClaseDatos.listarTipoPersonal(Me.TxtBusqueda.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
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
        cargarListadoTipoPersonal()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
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
        AgregarTipoPersonal.ShowDialog()
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        'Dim j As Integer
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar los datos a modificar")
        Else
            EditTipoPersonal.Show()
            'Dim ask As MsgBoxResult = MsgBox("Seguro que quiere modificar el registro?", MsgBoxStyle.YesNo, "Modificar")
            'If ask = MsgBoxResult.Yes Then
            'j = DataGridView1.CurrentRow.Index + 1
            'DataGridView1.SelectedRows(0).SetValues(j, txtNombre.Text, txtDesc.Text)
            'End If
        End If
    End Sub

    Private Sub butEliPac_Click(sender As Object, e As EventArgs) Handles butEliPac.Click
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
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar el registro a dar de Baja")
        ElseIf DataGridView1.CurrentRow.Cells("deBaja").Value = False Then
            MessageBox.Show("El registro ya está dado de Baja")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de baja el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    darDeBajaTipo()
                    'ClaseDatos.eliminarTipoPersonal(DataGridView1.CurrentRow.Cells("Id").Value)
                    MessageBox.Show("Registro dado de baja exitosamente", "Dar de baja registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cargarListadoTipoPersonal()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al bajar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub darDeBajaTipo()
        Dim id As Long
        id = DataGridView1.CurrentRow.Cells("Id").Value
        Dim valor As Integer
        valor = 0
        Dim ctx As New HospitalEntities4
        Dim tipoPersonal As Tipo_Personal = (From c In ctx.Tipo_Personal
                                             Where c.Id = id
                                             Select c).SingleOrDefault
        With tipoPersonal
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar el registro a dar de Alta")
        ElseIf DataGridView1.CurrentRow.Cells("deBaja").Value = True Then
            MessageBox.Show("El registro ya está dado de Alta")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de alta el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    darDeAltaTipo()
                    'ClaseDatos.eliminarTipoPersonal(DataGridView1.CurrentRow.Cells("Id").Value)
                    MessageBox.Show("Registro dado de alta exitosamente", "Dar de alta registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cargarListadoTipoPersonal()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al alzar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub darDeAltaTipo()
        Dim id As Long
        id = DataGridView1.CurrentRow.Cells("Id").Value
        Dim valor As Integer
        valor = 1
        Dim ctx As New HospitalEntities4
        Dim tipoPersonal As Tipo_Personal = (From c In ctx.Tipo_Personal
                                             Where c.Id = id
                                             Select c).SingleOrDefault
        With tipoPersonal
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub
    'Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    '    Dim i As Integer
    '    i = DataGridView1.CurrentRow.Index

    '    txtNombre.Text = DataGridView1.Item(1, i).Value
    '    txtDesc.Text = DataGridView1.Item(2, i).Value
    'End Sub
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 2 And e.Value IsNot Nothing Then
            If e.Value = False Then
                e.CellStyle.BackColor = Color.LightCoral
            End If
        End If
        If e.ColumnIndex = 2 And e.Value IsNot Nothing Then
            If e.Value = True Then
                e.CellStyle.BackColor = Color.DarkSeaGreen
            End If
        End If
    End Sub
#End Region
End Class