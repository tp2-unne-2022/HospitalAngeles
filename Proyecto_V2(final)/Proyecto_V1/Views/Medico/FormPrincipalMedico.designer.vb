<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipalMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipalMedico))
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnAgenda = New System.Windows.Forms.Button()
        Me.btnTurnos = New System.Windows.Forms.Button()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.lbDni = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.lbOnline = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.HoraFecha = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFormulario.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(314, 83)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.SkyBlue
        Me.PanelMenu.Controls.Add(Me.PictureBox4)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.lblFecha)
        Me.PanelMenu.Controls.Add(Me.PictureBox3)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.PictureBox8)
        Me.PanelMenu.Controls.Add(Me.PictureBox7)
        Me.PanelMenu.Controls.Add(Me.LTitulo)
        Me.PanelMenu.Controls.Add(Me.PictureBox5)
        Me.PanelMenu.Controls.Add(Me.PictureBox2)
        Me.PanelMenu.Controls.Add(Me.btnAgenda)
        Me.PanelMenu.Controls.Add(Me.btnTurnos)
        Me.PanelMenu.Controls.Add(Me.btnPaciente)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 536)
        Me.PanelMenu.TabIndex = 5
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox4.Location = New System.Drawing.Point(0, 258)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(4, 26)
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 258)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 26)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Historia Clínica"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.ForeColor = System.Drawing.Color.DimGray
        Me.lblFecha.Location = New System.Drawing.Point(7, 2)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(34, 13)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "fecha"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox3.Location = New System.Drawing.Point(0, 226)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(4, 26)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
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
        Me.PictureBox7.Location = New System.Drawing.Point(50, 54)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(104, 72)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.LTitulo.ForeColor = System.Drawing.Color.DimGray
        Me.LTitulo.Location = New System.Drawing.Point(25, 129)
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
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox2.Location = New System.Drawing.Point(0, 166)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(4, 26)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
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
        Me.btnAgenda.Location = New System.Drawing.Point(2, 196)
        Me.btnAgenda.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.Size = New System.Drawing.Size(200, 26)
        Me.btnAgenda.TabIndex = 3
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
        Me.btnTurnos.Location = New System.Drawing.Point(2, 166)
        Me.btnTurnos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTurnos.Name = "btnTurnos"
        Me.btnTurnos.Size = New System.Drawing.Size(200, 26)
        Me.btnTurnos.TabIndex = 2
        Me.btnTurnos.Text = "Turnos"
        Me.btnTurnos.UseVisualStyleBackColor = True
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
        Me.btnPaciente.Location = New System.Drawing.Point(2, 226)
        Me.btnPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(200, 26)
        Me.btnPaciente.TabIndex = 14
        Me.btnPaciente.Text = "Pacientes"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'PanelFormulario
        '
        Me.PanelFormulario.BackColor = System.Drawing.Color.Lavender
        Me.PanelFormulario.Controls.Add(Me.lbDni)
        Me.PanelFormulario.Controls.Add(Me.Label2)
        Me.PanelFormulario.Controls.Add(Me.Label1)
        Me.PanelFormulario.Controls.Add(Me.PanelMenu)
        Me.PanelFormulario.Controls.Add(Me.PictureBox1)
        Me.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormulario.Location = New System.Drawing.Point(0, 27)
        Me.PanelFormulario.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(814, 536)
        Me.PanelFormulario.TabIndex = 7
        '
        'lbDni
        '
        Me.lbDni.AutoSize = True
        Me.lbDni.Location = New System.Drawing.Point(231, 5)
        Me.lbDni.Name = "lbDni"
        Me.lbDni.Size = New System.Drawing.Size(0, 13)
        Me.lbDni.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "DNI:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(421, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Bienvenid@ Medic@"
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
        Me.PanelTitulo.TabIndex = 6
        '
        'lbOnline
        '
        Me.lbOnline.AutoSize = True
        Me.lbOnline.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOnline.ForeColor = System.Drawing.Color.LightGray
        Me.lbOnline.Location = New System.Drawing.Point(202, 6)
        Me.lbOnline.Name = "lbOnline"
        Me.lbOnline.Size = New System.Drawing.Size(0, 17)
        Me.lbOnline.TabIndex = 17
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Linen
        Me.lblHora.Location = New System.Drawing.Point(6, 5)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(47, 21)
        Me.lblHora.TabIndex = 16
        Me.lblHora.Text = "Hora"
        '
        'HoraFecha
        '
        Me.HoraFecha.Enabled = True
        '
        'FormPrincipalMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 563)
        Me.Controls.Add(Me.PanelFormulario)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPrincipalMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPrincipalMedico"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFormulario.ResumeLayout(False)
        Me.PanelFormulario.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents LTitulo As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnAgenda As Button
    Friend WithEvents btnTurnos As Button
    Friend WithEvents btnPaciente As Button
    Friend WithEvents PanelFormulario As Panel
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents HoraFecha As Timer
    Friend WithEvents lbOnline As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lbDni As Label
    Friend WithEvents Label2 As Label
End Class
