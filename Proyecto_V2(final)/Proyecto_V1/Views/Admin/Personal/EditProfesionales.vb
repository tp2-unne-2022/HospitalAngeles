Imports System.Runtime.InteropServices

Public Class EditProfesionales
#Region "LOAD"
    Private Sub EditProfesionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGenero()
        CargarOS()
        CargarTipoPersonal()
        Try
            Dim personal As Personal = ClaseDatos.getInfoPersonal(TablaProfesionales.DataGridView1.CurrentRow.Cells("dni").Value)
            With personal
                txtNombreProfesional.Text = .nombre
                txtApellidoProfesional.Text = .apellido
                DniProfesional.Text = .dni
                dtpNacimiento.Text = .fecha_nac
                dtpIngre.Text = .fecha_ingreso
                cbGenero.Text = .id_genero
                cbOS.Text = .id_obra_soc
                DireccionProfesional.Text = .domicilio
                LocalidadProfesional.Text = .localidad
                ProvinciaProfesional.Text = .provincia
                NroTelProfesional.Text = .num_tel
                EmailProfesional.Text = .email
                cbGenero.SelectedIndex = .id_genero - 1
                cbOS.SelectedIndex = .id_obra_soc - 1
                cbTPersonal.SelectedIndex = .cod_tipo_personal - 1
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al seleccionar personal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarGenero()
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Genero
                     Select c).ToList
        Try
            cbGenero.DataSource = datos
            cbGenero.DisplayMember = "nombre"
            cbGenero.ValueMember = "Id"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarOS()
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Obra_Social
                     Select c).ToList
        Try
            cbOS.DataSource = datos
            cbOS.DisplayMember = "nombre_obra_soc"
            cbOS.ValueMember = "Id"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarTipoPersonal()
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Tipo_Personal
                     Select c).ToList
        Try
            cbTPersonal.DataSource = datos
            cbTPersonal.DisplayMember = "nombre"
            cbTPersonal.ValueMember = "Id"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "BOTONES PARTE SUPERIOR"
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            txtNombreProfesional.Text = ""
            txtApellidoProfesional.Text = ""
            DniProfesional.Text = ""
            dtpNacimiento.ResetText()
            dtpIngre.ResetText()
            cbGenero.SelectedIndex = -1
            cbOS.SelectedIndex = -1
            DireccionProfesional.Text = ""
            LocalidadProfesional.Text = ""
            ProvinciaProfesional.Text = ""
            NroTelProfesional.Text = ""
            EmailProfesional.Text = ""
            cbTPersonal.SelectedIndex = -1
            Me.Close()
        End If
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub

    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
#Region "RESTRICCIONES"
    Private Sub txtNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtNombreProfesional.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtApellidoProfesional.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles DniProfesional.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dtpNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpNacimiento.ValueChanged
        dtpNacimiento.MaxDate = DateTime.Today
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles dtpIngre.ValueChanged
        dtpIngre.MaxDate = DateTime.Today
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As KeyPressEventArgs) Handles LocalidadProfesional.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ProvinciaProfesional.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As KeyPressEventArgs) Handles NroTelProfesional.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDirec_TextChanged(sender As Object, e As KeyPressEventArgs) Handles DireccionProfesional.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As KeyPressEventArgs) Handles EmailProfesional.KeyPress

    End Sub

    Private Sub cbOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOS.SelectedIndexChanged

    End Sub
#End Region
#Region "AGREGADO"
    Private mru As FormPacientes
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            txtNombreProfesional.Text = ""
            txtApellidoProfesional.Text = ""
            DniProfesional.Text = ""
            dtpNacimiento.ResetText()
            dtpIngre.ResetText()
            cbGenero.SelectedIndex = -1
            cbOS.SelectedIndex = -1
            DireccionProfesional.Text = ""
            LocalidadProfesional.Text = ""
            ProvinciaProfesional.Text = ""
            NroTelProfesional.Text = ""
            EmailProfesional.Text = ""
            cbTPersonal.SelectedIndex = -1
            Me.Close()
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Dim obraSoc As Integer
        'Dim genero As Integer
        'Dim usuario As Integer
        'Dim j As Integer
        'j = TablaProfesionales.DataGridView1.CurrentRow.Index + 1

        'If cbOS.Text = "IOSCOR" Then
        '    obraSoc = 1
        'ElseIf cbOS.Text = "PAMI" Then
        '    obraSoc = 2
        'Else
        '    obraSoc = 0
        'End If

        'If cbGenero.Text = "Masculino" Then
        '    genero = 1
        'ElseIf cbGenero.Text = "Femenino" Then
        '    genero = 2
        'Else
        '    genero = 3
        'End If

        'Select Case cbUsuario.Text
        '    Case "Admin"
        '        usuario = 1
        '    Case "Secre"
        '        usuario = 2
        '    Case "Medico"
        '        usuario = 3
        '    Case Else
        '        usuario = 0
        'End Select

        'se declara la variable en la que se almacenara el valor total de registros

        'Dim contador As Single

        'se inicia el contador a 0

        'contador = 1

        'con un for se recorre toda el datagridview o dgv

        'For x = 0 To TablaProfesionales.DataGridView1.RowCount - 1

        'con un if se recorre la culumna deseada,

        'notese que (0, x) es: 0 = el indice de la columna es decir la uno se puede cambiar por cualquiera es decir 0, 1, 2... n. y "x" es el recorrido en el dgv

        'If TablaProfesionales.DataGridView1.Item(0, x).Value > 0 Then

        'se inicia el contador de uno en uno

        'contador += 1
        '    End If
        'Next
        Dim valorCBGenero As Integer
        Dim valorCBOS As Integer
        Dim valorTP As Integer

        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Personal).ToList

        If txtNombreProfesional.Text = "" Or txtApellidoProfesional.Text = "" Or DniProfesional.Text = "" Or DireccionProfesional.Text = "" Or LocalidadProfesional.Text = "" Or ProvinciaProfesional.Text = "" Or NroTelProfesional.Text = "" Or EmailProfesional.Text = "" Or cbGenero.SelectedIndex = -1 Or cbTPersonal.SelectedIndex = -1 Or cbOS.SelectedIndex = -1 Then
            MessageBox.Show("Rellene todos los campos")
        ElseIf EmailProfesional.Text.Contains("@gmail.com") Or EmailProfesional.Text.Contains("@outlook.com") Or EmailProfesional.Text.Contains("@live.com") Or EmailProfesional.Text.Contains("@yahoo.com") Or EmailProfesional.Text.Contains("@hotmail.com") Then
            Try
                Dim valueG As Object = cbGenero.SelectedValue
                Dim valueOS As Object = cbOS.SelectedValue
                Dim valueTP As Object = cbTPersonal.SelectedValue
                If (valueG IsNot Nothing) Then
                    ' Convertimos el valor obtenido al tipo de dato
                    ' adecuado, en éste caso, a un valor Int.
                    '
                    valorCBGenero = Convert.ToInt32(valueG)
                End If
                If (valueOS IsNot Nothing) Then
                    ' Convertimos el valor obtenido al tipo de dato
                    ' adecuado, en éste caso, a un valor Int.
                    '
                    valorCBOS = Convert.ToInt32(valueOS)
                End If
                If (valueTP IsNot Nothing) Then
                    ' Convertimos el valor obtenido al tipo de dato
                    ' adecuado, en éste caso, a un valor Int.
                    '
                    valorTP = Convert.ToInt32(valueTP)
                End If

                ClaseDatos.actualizarPersonal(Me.DniProfesional.Text, valorTP, valorCBOS, valorCBGenero, Me.txtNombreProfesional.Text, Me.txtApellidoProfesional.Text, Me.dtpNacimiento.Value, Me.dtpIngre.Value, Me.LocalidadProfesional.Text, Me.ProvinciaProfesional.Text, Me.DireccionProfesional.Text, Me.NroTelProfesional.Text, Me.EmailProfesional.Text)
                TablaProfesionales.cargarListadoPersonalAlta()
                TablaProfesionales.rbAlta.Checked = True
                MessageBox.Show("Registro modificado exitosamente", "Modificar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al modificar personal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Coloque un email válido")
        End If
    End Sub

    'Private Sub EditProfesionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Dim i As Integer
    'i = TablaProfesionales.DataGridView1.CurrentRow.Index

    'cbTPersonal.SelectedValue = TablaProfesionales.DataGridView1.Item(1, i).Value
    'cbUsuario.SelectedValue = TablaProfesionales.DataGridView1.Item(2, i).Value
    'cbOS.SelectedValue = TablaProfesionales.DataGridView1.Item(3, i).Value
    'cbGenero.SelectedValue = TablaProfesionales.DataGridView1.Item(4, i).Value
    'txtNombreProfesional.Text = TablaProfesionales.DataGridView1.Item(5, i).Value
    'txtApellidoProfesional.Text = TablaProfesionales.DataGridView1.Item(6, i).Value
    'DniProfesional.Text = TablaProfesionales.DataGridView1.Item(7, i).Value
    'dtpNacimiento.Value = TablaProfesionales.DataGridView1.Item(8, i).Value
    'dtpIngre.Value = TablaProfesionales.DataGridView1.Item("fecha_ingreso", i).Value
    'LocalidadProfesional.Text = TablaProfesionales.DataGridView1.Item(10, i).Value
    'ProvinciaProfesional.Text = TablaProfesionales.DataGridView1.Item(11, i).Value
    'DireccionProfesional.Text = TablaProfesionales.DataGridView1.Item(12, i).Value
    'NroTelProfesional.Text = TablaProfesionales.DataGridView1.Item(13, i).Value
    'EmailProfesional.Text = TablaProfesionales.DataGridView1.Item(14, i).Value
    'End Sub
#End Region
End Class