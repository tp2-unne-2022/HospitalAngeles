<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProfesionales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProfesionales))
        Me.cbTPersonal = New System.Windows.Forms.ComboBox()
        Me.LTPersonal = New System.Windows.Forms.Label()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LGenero = New System.Windows.Forms.Label()
        Me.cbOS = New System.Windows.Forms.ComboBox()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnC = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnMini = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.EmailProfesional = New System.Windows.Forms.TextBox()
        Me.NroTelProfesional = New System.Windows.Forms.TextBox()
        Me.DireccionProfesional = New System.Windows.Forms.TextBox()
        Me.LocalidadProfesional = New System.Windows.Forms.TextBox()
        Me.ProvinciaProfesional = New System.Windows.Forms.TextBox()
        Me.dtpIngre = New System.Windows.Forms.DateTimePicker()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.DniProfesional = New System.Windows.Forms.TextBox()
        Me.txtApellidoProfesional = New System.Windows.Forms.TextBox()
        Me.txtNombreProfesional = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbTPersonal
        '
        Me.cbTPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTPersonal.FormattingEnabled = True
        Me.cbTPersonal.Items.AddRange(New Object() {"Ninguno"})
        Me.cbTPersonal.Location = New System.Drawing.Point(386, 184)
        Me.cbTPersonal.Name = "cbTPersonal"
        Me.cbTPersonal.Size = New System.Drawing.Size(104, 21)
        Me.cbTPersonal.TabIndex = 98
        '
        'LTPersonal
        '
        Me.LTPersonal.AutoSize = True
        Me.LTPersonal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.LTPersonal.Location = New System.Drawing.Point(287, 186)
        Me.LTPersonal.Name = "LTPersonal"
        Me.LTPersonal.Size = New System.Drawing.Size(96, 17)
        Me.LTPersonal.TabIndex = 97
        Me.LTPersonal.Text = "Tipo Personal:"
        '
        'cbGenero
        '
        Me.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"Femenino", "Maculino"})
        Me.cbGenero.Location = New System.Drawing.Point(81, 182)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(104, 21)
        Me.cbGenero.TabIndex = 96
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(15, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 17)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Obra Social:"
        '
        'LGenero
        '
        Me.LGenero.AutoSize = True
        Me.LGenero.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.LGenero.Location = New System.Drawing.Point(15, 184)
        Me.LGenero.Name = "LGenero"
        Me.LGenero.Size = New System.Drawing.Size(60, 17)
        Me.LGenero.TabIndex = 92
        Me.LGenero.Text = "Genero:"
        '
        'cbOS
        '
        Me.cbOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOS.FormattingEnabled = True
        Me.cbOS.Items.AddRange(New Object() {"Ninguna", "IOSCOR", "PAMI"})
        Me.cbOS.Location = New System.Drawing.Point(108, 212)
        Me.cbOS.Name = "cbOS"
        Me.cbOS.Size = New System.Drawing.Size(104, 21)
        Me.cbOS.TabIndex = 91
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTitulo.Controls.Add(Me.PictureBox5)
        Me.PanelTitulo.Controls.Add(Me.btnC)
        Me.PanelTitulo.Controls.Add(Me.PictureBox4)
        Me.PanelTitulo.Controls.Add(Me.btnMini)
        Me.PanelTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(676, 26)
        Me.PanelTitulo.TabIndex = 90
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(634, 2)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 21)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 60
        Me.PictureBox5.TabStop = False
        '
        'btnC
        '
        Me.btnC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC.Location = New System.Drawing.Point(1146, 2)
        Me.btnC.Margin = New System.Windows.Forms.Padding(2)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(24, 21)
        Me.btnC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnC.TabIndex = 34
        Me.btnC.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(599, 2)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 21)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 59
        Me.PictureBox4.TabStop = False
        '
        'btnMini
        '
        Me.btnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMini.Location = New System.Drawing.Point(1111, 2)
        Me.btnMini.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(24, 21)
        Me.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMini.TabIndex = 33
        Me.btnMini.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Location = New System.Drawing.Point(1758, 3)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(24, 21)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Location = New System.Drawing.Point(1791, 3)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(24, 21)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'EmailProfesional
        '
        Me.EmailProfesional.Location = New System.Drawing.Point(343, 154)
        Me.EmailProfesional.MaxLength = 40
        Me.EmailProfesional.Name = "EmailProfesional"
        Me.EmailProfesional.Size = New System.Drawing.Size(190, 20)
        Me.EmailProfesional.TabIndex = 89
        '
        'NroTelProfesional
        '
        Me.NroTelProfesional.Location = New System.Drawing.Point(386, 126)
        Me.NroTelProfesional.MaxLength = 9
        Me.NroTelProfesional.Name = "NroTelProfesional"
        Me.NroTelProfesional.Size = New System.Drawing.Size(147, 20)
        Me.NroTelProfesional.TabIndex = 88
        '
        'DireccionProfesional
        '
        Me.DireccionProfesional.Location = New System.Drawing.Point(366, 31)
        Me.DireccionProfesional.MaxLength = 40
        Me.DireccionProfesional.Name = "DireccionProfesional"
        Me.DireccionProfesional.Size = New System.Drawing.Size(168, 20)
        Me.DireccionProfesional.TabIndex = 87
        '
        'LocalidadProfesional
        '
        Me.LocalidadProfesional.Location = New System.Drawing.Point(366, 63)
        Me.LocalidadProfesional.MaxLength = 40
        Me.LocalidadProfesional.Name = "LocalidadProfesional"
        Me.LocalidadProfesional.Size = New System.Drawing.Size(168, 20)
        Me.LocalidadProfesional.TabIndex = 86
        '
        'ProvinciaProfesional
        '
        Me.ProvinciaProfesional.Location = New System.Drawing.Point(366, 96)
        Me.ProvinciaProfesional.MaxLength = 40
        Me.ProvinciaProfesional.Name = "ProvinciaProfesional"
        Me.ProvinciaProfesional.Size = New System.Drawing.Size(168, 20)
        Me.ProvinciaProfesional.TabIndex = 85
        '
        'dtpIngre
        '
        Me.dtpIngre.CustomFormat = "dd/MM/yy"
        Me.dtpIngre.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIngre.Location = New System.Drawing.Point(141, 156)
        Me.dtpIngre.Name = "dtpIngre"
        Me.dtpIngre.Size = New System.Drawing.Size(77, 20)
        Me.dtpIngre.TabIndex = 84
        Me.dtpIngre.Value = New Date(2022, 10, 31, 0, 0, 0, 0)
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.CustomFormat = "dd/MM/yy"
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNacimiento.Location = New System.Drawing.Point(172, 124)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(82, 20)
        Me.dtpNacimiento.TabIndex = 83
        Me.dtpNacimiento.Value = New Date(2022, 10, 31, 0, 0, 0, 0)
        '
        'DniProfesional
        '
        Me.DniProfesional.Location = New System.Drawing.Point(86, 95)
        Me.DniProfesional.MaxLength = 8
        Me.DniProfesional.Name = "DniProfesional"
        Me.DniProfesional.Size = New System.Drawing.Size(168, 20)
        Me.DniProfesional.TabIndex = 82
        '
        'txtApellidoProfesional
        '
        Me.txtApellidoProfesional.Location = New System.Drawing.Point(86, 62)
        Me.txtApellidoProfesional.MaxLength = 40
        Me.txtApellidoProfesional.Name = "txtApellidoProfesional"
        Me.txtApellidoProfesional.Size = New System.Drawing.Size(168, 20)
        Me.txtApellidoProfesional.TabIndex = 81
        '
        'txtNombreProfesional
        '
        Me.txtNombreProfesional.Location = New System.Drawing.Point(86, 30)
        Me.txtNombreProfesional.MaxLength = 40
        Me.txtNombreProfesional.Name = "txtNombreProfesional"
        Me.txtNombreProfesional.Size = New System.Drawing.Size(168, 20)
        Me.txtNombreProfesional.TabIndex = 80
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(287, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 17)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Provincia:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(287, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Localidad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(287, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(15, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 17)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Fecha de Nacimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(15, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 17)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Fecha de Ingreso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(287, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Nro. teléfono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(287, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(15, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "DNI:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(15, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(15, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Nombre: "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(540, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(503, 238)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 20)
        Me.btnCancelar.TabIndex = 68
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Location = New System.Drawing.Point(239, 238)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 20)
        Me.btnGuardar.TabIndex = 67
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'EditProfesionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(672, 270)
        Me.Controls.Add(Me.cbTPersonal)
        Me.Controls.Add(Me.LTPersonal)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LGenero)
        Me.Controls.Add(Me.cbOS)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.EmailProfesional)
        Me.Controls.Add(Me.NroTelProfesional)
        Me.Controls.Add(Me.DireccionProfesional)
        Me.Controls.Add(Me.LocalidadProfesional)
        Me.Controls.Add(Me.ProvinciaProfesional)
        Me.Controls.Add(Me.dtpIngre)
        Me.Controls.Add(Me.dtpNacimiento)
        Me.Controls.Add(Me.DniProfesional)
        Me.Controls.Add(Me.txtApellidoProfesional)
        Me.Controls.Add(Me.txtNombreProfesional)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditProfesionales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditProfesionales"
        Me.PanelTitulo.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents cbTPersonal As ComboBox
    Public WithEvents LTPersonal As Label
    Public WithEvents cbGenero As ComboBox
    Public WithEvents Label12 As Label
    Public WithEvents LGenero As Label
    Public WithEvents cbOS As ComboBox
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnC As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnMini As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Public WithEvents EmailProfesional As TextBox
    Public WithEvents NroTelProfesional As TextBox
    Public WithEvents DireccionProfesional As TextBox
    Public WithEvents LocalidadProfesional As TextBox
    Public WithEvents ProvinciaProfesional As TextBox
    Public WithEvents dtpIngre As DateTimePicker
    Public WithEvents dtpNacimiento As DateTimePicker
    Public WithEvents DniProfesional As TextBox
    Public WithEvents txtApellidoProfesional As TextBox
    Public WithEvents txtNombreProfesional As TextBox
    Public WithEvents Label11 As Label
    Public WithEvents Label10 As Label
    Public WithEvents Label8 As Label
    Public WithEvents Label7 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancelar As Button
    Public WithEvents btnGuardar As Button
End Class
