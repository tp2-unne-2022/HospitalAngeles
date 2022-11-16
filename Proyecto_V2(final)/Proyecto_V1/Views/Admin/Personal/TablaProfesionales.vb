Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TablaProfesionales
    'Private dtTable As New DataTable
    'Private dtTableGrd As DataTable
#Region "BOTONES BASICOS"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

#End Region
#Region "INTERACCION BD"
    Private Sub FormPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        EntradaProfesionales.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnEli.Click
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
            MessageBox.Show("Debes seleccionar el registro a dar de baja")
        ElseIf DataGridView1.CurrentRow.Cells("Baja").Value = False Then
            MessageBox.Show("El registro ya está dado de Baja")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de baja el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    eliminarAlPersonal()
                    'ClaseDatos.eliminarPersonal(DataGridView1.CurrentRow.Cells("Id").Value)
                    MessageBox.Show("El registro se ha dado de baja exitosamente", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cargarListadoPersonalAlta()
                    rbAlta.Checked = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al eliminar personal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub eliminarAlPersonal()
        Dim dniPersonal As Long
        dniPersonal = DataGridView1.CurrentRow.Cells("dni").Value
        Dim valor As Integer
        valor = 0
        Dim ctx As New HospitalEntities4
        Dim personal As Personal = (From c In ctx.Personal
                                    Where c.dni = dniPersonal
                                    Select c).SingleOrDefault
        With personal
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar el registro a dar de alta")
        ElseIf DataGridView1.CurrentRow.Cells("Baja").Value = True Then
            MessageBox.Show("El registro ya está dado de Alta")
        Else
            Dim resp As MsgBoxResult = MessageBox.Show("Confirme que desea dar de alta el registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Try
                    darDeAltaAlPersonal()
                    'ClaseDatos.eliminarPersonal(DataGridView1.CurrentRow.Cells("Id").Value)
                    MessageBox.Show("El registro se ha dado de alta exitosamente", "Dar de alta registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cargarListadoPersonalAlta()
                    rbAlta.Checked = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al alzar al personal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub darDeAltaAlPersonal()
        Dim dniPersonal As Long
        dniPersonal = DataGridView1.CurrentRow.Cells("dni").Value
        Dim valor As Integer
        valor = 1
        Dim ctx As New HospitalEntities4
        Dim personal As Personal = (From c In ctx.Personal
                                    Where c.dni = dniPersonal
                                    Select c).SingleOrDefault
        With personal
            .deBaja = valor
        End With
        ctx.SaveChanges()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    If row.Cells("apellido").Value = TxtBusqueda.Text Then
        '        DataGridView1.ClearSelection()
        '        row.Selected = True
        '        Exit For
        '    End If
        '    If row.Cells("dni").Value = TxtBusqueda.Text Then
        '        DataGridView1.ClearSelection()
        '        row.Selected = True
        '        Exit For
        '    End If
        'Next
        If rbAlta.Checked = True Then
            cargarListadoPersonalAlta()
        ElseIf rbBaja.Checked = True Then
            cargarListadoPersonalBaja()
        Else
            cargarListadoPersonalCompleto()
        End If

    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debes seleccionar los datos a modificar")
        Else
            EditProfesionales.ShowDialog()
        End If
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

    'Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
    '    If e.ColumnIndex = 13 And e.Value IsNot Nothing Then
    '        If e.Value = False Then
    '            e.CellStyle.BackColor = Color.LightCoral
    '        End If
    '    End If
    '    If e.ColumnIndex = 13 And e.Value IsNot Nothing Then
    '        If e.Value = True Then
    '            e.CellStyle.BackColor = Color.DarkSeaGreen
    '        End If
    '    End If
    'End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TipoPersonal.ShowDialog()
    End Sub
#End Region
End Class