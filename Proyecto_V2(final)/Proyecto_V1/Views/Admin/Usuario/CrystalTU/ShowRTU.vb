﻿Imports System.Runtime.InteropServices

Public Class ShowRTU
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
    Private Sub ShowRTU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Sub Cargar()
        Dim Miform As New CrystalReportTUsuarios
        CrystalReportViewer1.ReportSource = Miform
    End Sub
End Class