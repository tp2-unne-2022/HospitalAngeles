Imports System.Runtime.InteropServices

Public Class FormPrincipalMedico
#Region "BOTONES BASICOS"
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'Application.Exit()
        Dim ask As MsgBoxResult = MsgBox("Seguro que quiere salir?", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            MsgBox("Regresará al loggin", vbInformation, "Sistema")
            LogginForm.Show()
            Me.Hide()
        End If


    End Sub

    'Valores para restaurar
    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'Condicion si formulario esta abierto
        If (Application.OpenForms("Form3") Is Nothing) Then
            btnTurnos.BackColor = Color.SkyBlue
        End If
        If (Application.OpenForms("Form4") Is Nothing) Then
            btnAgenda.BackColor = Color.SkyBlue
        End If
    End Sub

    Private Sub btnAgenda_Click(sender As Object, e As EventArgs) Handles btnAgenda.Click
        AbrirFormEnPanel(Of FormAgendaMedica)()
        'btnAgenda.BackColor = Color.SpringGreen
    End Sub

    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        AbrirFormEnPanel(Of FormPacientesMedico)()
        'btnAgenda.BackColor = Color.SpringGreen
    End Sub
    Private Sub btnTurnos_Click(sender As Object, e As EventArgs) Handles btnTurnos.Click
        AbrirFormEnPanel(Of TablaTurnoMedico)()
        'btnTurnos.BackColor = Color.SpringGreen
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(Of HistoriaClinica)()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim ask As MsgBoxResult = MsgBox("Seguro que quiere salir?", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            MsgBox("Regresará al loggin", vbInformation, "Sistema")
            LogginForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult = MsgBox("Seguro que quiere salir?", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            MsgBox("Regresará al loggin", vbInformation, "Sistema")
            LogginForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AbrirFormEnPanel(Of MiForm As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormulario.Controls.OfType(Of MiForm)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue encontrado/no existe
        If Formulario Is Nothing Then
            Formulario = New MiForm()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PanelFormulario.Controls.Add(Formulario)
            PanelFormulario.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        lblHora.Text = DateTime.Now.ToString("HH:mm")
        lblFecha.Text = DateTime.Now.ToLongDateString
    End Sub
    Sub cargarNombre()
        lbOnline.Text = "Sesión: " + LogginForm.txtUsuario.Text + "(médic@)"
    End Sub

    Sub cargarDNI(dni As Long)
        lbDni.Text = dni
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If PanelMenu.Width = 200 Then
            tmOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMostrarMenu.Enabled = True
        End If
    End Sub
    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If PanelMenu.Width >= 200 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub
#End Region
End Class