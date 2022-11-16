Imports System.Data.SqlClient

Public Class HistoriaClinica
#Region "BOTONES BASICOS"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
#End Region
    Private Sub HistoriaClinica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Debe completar todos los datos del paciente", "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            cargarListadoHistoriaClinica()
        End If
    End Sub
    Sub cargarListadoHistoriaClinica()
        Try
            Dim id_pac As Integer
            Dim dniP As Long
            id_pac = Convert.ToInt32(TextBox1.Text)
            dniP = Convert.ToInt64(FormPrincipalMedico.lbDni.Text)
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ClaseDatos.listarHistoriaClinica(id_pac, dniP)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnCargar_Click(sender As Object, e As EventArgs)
        cargarListadoHistoriaClinica()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        EntradaHC.ShowDialog()
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un registro")
        Else
            ModifHC.ShowDialog()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
            Using cmd As SqlCommand = New SqlCommand("Select Id, nombre, apellido, dni from Paciente where nombre = '" & txtNombre.Text & "' ", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            TextBox1.Text = dt.Rows(0)(0).ToString()
                            txtNombre.Text = dt.Rows(0)(1).ToString()
                            txtApellido.Text = dt.Rows(0)(2).ToString()
                            txtDNI.Text = dt.Rows(0)(3).ToString()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
            Using cmd As SqlCommand = New SqlCommand("Select Id, nombre, apellido, dni from Paciente where apellido = '" & txtApellido.Text & "' ", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            TextBox1.Text = dt.Rows(0)(0).ToString()
                            txtNombre.Text = dt.Rows(0)(1).ToString()
                            txtApellido.Text = dt.Rows(0)(2).ToString()
                            txtDNI.Text = dt.Rows(0)(3).ToString()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
            Using cmd As SqlCommand = New SqlCommand("Select Id, nombre, apellido, dni from Paciente where dni = '" & txtDNI.Text & "' ", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            TextBox1.Text = dt.Rows(0)(0).ToString()
                            txtNombre.Text = dt.Rows(0)(1).ToString()
                            txtApellido.Text = dt.Rows(0)(2).ToString()
                            txtDNI.Text = dt.Rows(0)(3).ToString()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Using conn As SqlConnection = New SqlConnection("Data Source= DESKTOP-B3EFOL9; Initial Catalog=Hospital; Integrated Security = true")
            Using cmd As SqlCommand = New SqlCommand("Select Id, nombre, apellido, dni from Paciente where Id = '" & TextBox1.Text & "' ", conn)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            TextBox1.Text = dt.Rows(0)(0).ToString()
                            txtNombre.Text = dt.Rows(0)(1).ToString()
                            txtApellido.Text = dt.Rows(0)(2).ToString()
                            txtDNI.Text = dt.Rows(0)(3).ToString()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class