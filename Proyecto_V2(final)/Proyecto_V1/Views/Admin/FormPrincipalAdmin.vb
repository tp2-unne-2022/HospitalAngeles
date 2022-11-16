Imports System.Runtime.InteropServices

Public Class FormPrincipalAdmin
#Region "Funcionalidades del Formulario"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    'Dim cGrip As Integer = 10
    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    If (m.Msg = 132) Then
    '        Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
    '        pos = Me.PointToClient(pos)
    '        If ((pos.X _
    '                >= (Me.ClientSize.Width - cGrip)) _
    '                AndAlso (pos.Y _
    '                >= (Me.ClientSize.Height - cGrip))) Then
    '            m.Result = CType(17, IntPtr)
    '            Return
    '        End If
    '    End If
    '    MyBase.WndProc(m)
    'End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    'Dim sizeGripRectangle As Rectangle
    'Dim tolerance As Integer = 15
    'Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
    '    MyBase.OnSizeChanged(e)
    '    Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
    '    sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
    '    region.Exclude(sizeGripRectangle)
    '    Me.PanelContenedor.Region = region
    '    Me.Invalidate()
    'End Sub
    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    'Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
    '    Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
    '    e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
    '    MyBase.OnPaint(e)
    '    ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    'End Sub

    'Arrastrar al formulario
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

    'Private Sub btnMaximizar_Click(sender As Object, e As EventArgs)
    'Los valores van a ser iguales a los valores actuales del formulario
    'lx = Me.Location.X
    'ly = Me.Location.Y
    'sw = Me.Size.Width
    'sh = Me.Size.Height

    'Intercambio de visibilidades de botones
    '    btnMaximizar.Visible = False
    '    btnRestaurar.Visible = True

    '    Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    '    Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    'End Sub

    'Private Sub btnRestaurar_Click(sender As Object, e As EventArgs)
    'Asignan nuevas localizaciones
    'Me.Size = New Size(sw, sh)
    '    Me.Location = New Point(lx, ly)

    'Intercambio de visibilidades de botones
    '    btnMaximizar.Visible = True
    '    btnRestaurar.Visible = False

    'End Sub
#End Region
#Region "Apertura de formularios"
    'Metodo para abrir formulario
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOS.Click
        AbrirFormEnPanel(Of FormOS)()
        'btnOS.BackColor = Color.SpringGreen
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        AbrirFormEnPanel(Of TablaProfesionales)()
        'btnEmpleados.BackColor = Color.SpringGreen
    End Sub
    Private Sub btnTPersonal_Click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(Of TipoPersonal)()
        'btnTPersonal.BackColor = Color.SpringGreen
    End Sub

    Private Sub btnGenero_Click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(Of TablaGenero)()
        'btnGenero.BackColor = Color.SpringGreen
    End Sub
    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        AbrirFormEnPanel(Of TablaUsuario)()
        'btnGenero.BackColor = Color.SpringGreen
    End Sub
    'Private Sub btnTUsuario_Click(sender As Object, e As EventArgs)
    '    AbrirFormEnPanel(Of TiposUsuario)()
    '    'btnGenero.BackColor = Color.SpringGreen
    'End Sub

    Private Sub btnPacinte_Click(sender As Object, e As EventArgs) Handles btnPacinte.Click
        AbrirFormEnPanel(Of FormPacientes)()
        'btnPacinte.BackColor = Color.SpringGreen
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(Of BackUp)()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormEnPanel(Of Restore)()
    End Sub

    'METODO O EVENTO PARA CERRAR FORMULARIOS
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'Condicion si formulario esta abierto
        If (Application.OpenForms("Form1") Is Nothing) Then
            btnOS.BackColor = Color.SkyBlue
        End If
        If (Application.OpenForms("Form2") Is Nothing) Then
            btnEmpleados.BackColor = Color.SkyBlue
        End If
        'If (Application.OpenForms("Form3") Is Nothing) Then
        '    btnTurnos.BackColor = Color.SkyBlue
        'End If
        'If (Application.OpenForms("Form4") Is Nothing) Then
        '    btnAgenda.BackColor = Color.SkyBlue
        'End If
    End Sub

    'Boton Menu para cambiar el width del panel
    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
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

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        lblHora.Text = DateTime.Now.ToString("HH:mm")
        lblFecha.Text = DateTime.Now.ToLongDateString
    End Sub
    Sub cargarNombre()
        lbOnline.Text = "Sesión: " + LogginForm.txtUsuario.Text + "(admin)"
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