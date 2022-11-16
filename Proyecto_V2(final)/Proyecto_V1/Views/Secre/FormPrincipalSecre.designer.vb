<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipalSecre
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipalSecre))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.lbOnline = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnAgenda = New System.Windows.Forms.Button()
        Me.btnTurnos = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.HoraFecha = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTitulo.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFormulario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTitulo.Controls.Add(Me.lbOnline)
        Me.PanelTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelTitulo.Controls.Add(Me.lblHora)
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(814, 27)
        Me.PanelTitulo.TabIndex = 8
        '
        'lbOnline
        '
        Me.lbOnline.AutoSize = True
        Me.lbOnline.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOnline.ForeColor = System.Drawing.Color.LightGray
        Me.lbOnline.Location = New System.Drawing.Point(210, 4)
        Me.lbOnline.Name = "lbOnline"
        Me.lbOnline.Size = New System.Drawing.Size(0, 17)
        Me.lbOnline.TabIndex = 20
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(748, 2)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(24, 21)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Linen
        Me.lblHora.Location = New System.Drawing.Point(5, 4)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(47, 21)
        Me.lblHora.TabIndex = 18
        Me.lblHora.Text = "Hora"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(781, 2)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(24, 21)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.SkyBlue
        Me.PanelMenu.Controls.Add(Me.lblFecha)
        Me.PanelMenu.Controls.Add(Me.btnPaciente)
        Me.PanelMenu.Controls.Add(Me.btnAgenda)
        Me.PanelMenu.Controls.Add(Me.btnTurnos)
        Me.PanelMenu.Controls.Add(Me.btnEmpleados)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.PictureBox8)
        Me.PanelMenu.Controls.Add(Me.PictureBox7)
        Me.PanelMenu.Controls.Add(Me.LTitulo)
        Me.PanelMenu.Controls.Add(Me.PictureBox5)
        Me.PanelMenu.Controls.Add(Me.PictureBox4)
        Me.PanelMenu.Controls.Add(Me.PictureBox3)
        Me.PanelMenu.Controls.Add(Me.PictureBox2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 27)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 536)
        Me.PanelMenu.TabIndex = 9
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.ForeColor = System.Drawing.Color.DimGray
        Me.lblFecha.Location = New System.Drawing.Point(6, 2)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(34, 13)
        Me.lblFecha.TabIndex = 19
        Me.lblFecha.Text = "fecha"
        '
        'btnPaciente
        '
        Me.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPaciente.FlatAppearance.BorderSize = 0
        Me.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen
        Me.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaciente.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnPaciente.ForeColor = System.Drawing.Color.Black
        Me.btnPaciente.Image = CType(resources.GetObject("btnPaciente.Image"), System.Drawing.Image)
        Me.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaciente.Location = New System.Drawing.Point(9, 166)
        Me.btnPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(189, 26)
        Me.btnPaciente.TabIndex = 12
        Me.btnPaciente.Text = "Pacientes"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'btnAgenda
        '
        Me.btnAgenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgenda.FlatAppearance.BorderSize = 0
        Me.btnAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen
        Me.btnAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgenda.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAgenda.ForeColor = System.Drawing.Color.Black
        Me.btnAgenda.Image = CType(resources.GetObject("btnAgenda.Image"), System.Drawing.Image)
        Me.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgenda.Location = New System.Drawing.Point(9, 255)
        Me.btnAgenda.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.Size = New System.Drawing.Size(191, 26)
        Me.btnAgenda.TabIndex = 15
        Me.btnAgenda.Text = "Agenda"
        Me.btnAgenda.UseVisualStyleBackColor = True
        '
        'btnTurnos
        '
        Me.btnTurnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTurnos.FlatAppearance.BorderSize = 0
        Me.btnTurnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen
        Me.btnTurnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTurnos.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnTurnos.ForeColor = System.Drawing.Color.Black
        Me.btnTurnos.Image = CType(resources.GetObject("btnTurnos.Image"), System.Drawing.Image)
        Me.btnTurnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTurnos.Location = New System.Drawing.Point(9, 224)
        Me.btnTurnos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTurnos.Name = "btnTurnos"
        Me.btnTurnos.Size = New System.Drawing.Size(189, 26)
        Me.btnTurnos.TabIndex = 14
        Me.btnTurnos.Text = "Turnos"
        Me.btnTurnos.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnEmpleados.ForeColor = System.Drawing.Color.Black
        Me.btnEmpleados.Image = CType(resources.GetObject("btnEmpleados.Image"), System.Drawing.Image)
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(9, 195)
        Me.btnEmpleados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(188, 26)
        Me.btnEmpleados.TabIndex = 13
        Me.btnEmpleados.Text = "Profesionales"
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(2, 465)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 61)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(163, 5)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(34, 30)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(67, 54)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(60, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.LTitulo.ForeColor = System.Drawing.Color.DimGray
        Me.LTitulo.Location = New System.Drawing.Point(21, 120)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(150, 24)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Hospital Angeles"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox5.Location = New System.Drawing.Point(0, 195)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(4, 26)
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox4.Location = New System.Drawing.Point(0, 224)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(4, 26)
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox3.Location = New System.Drawing.Point(0, 255)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(4, 26)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox2.Location = New System.Drawing.Point(0, 166)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(4, 26)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PanelFormulario
        '
        Me.PanelFormulario.BackColor = System.Drawing.Color.Lavender
        Me.PanelFormulario.Controls.Add(Me.Label1)
        Me.PanelFormulario.Controls.Add(Me.PictureBox1)
        Me.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormulario.Location = New System.Drawing.Point(200, 27)
        Me.PanelFormulario.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(614, 536)
        Me.PanelFormulario.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(202, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Bienvenid@ Secretari@"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(108, 82)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'HoraFecha
        '
        Me.HoraFecha.Enabled = True
        '
        'FormPrincipalSecre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 563)
        Me.Controls.Add(Me.PanelFormulario)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPrincipalSecre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPrincipalSecre"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFormulario.ResumeLayout(False)
        Me.PanelFormulario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents LTitulo As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelFormulario As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnAgenda As Button
    Friend WithEvents btnTurnos As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents HoraFecha As Timer
    Friend WithEvents lbOnline As Label
End Class
