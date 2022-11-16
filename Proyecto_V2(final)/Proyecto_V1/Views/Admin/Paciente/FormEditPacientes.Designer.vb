<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditPacientes))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnC = New System.Windows.Forms.PictureBox()
        Me.btnMini = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.cbOS = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelef = New System.Windows.Forms.TextBox()
        Me.txtDirec = New System.Windows.Forms.TextBox()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.txtProv = New System.Windows.Forms.TextBox()
        Me.dtpAlta = New System.Windows.Forms.DateTimePicker()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lProv = New System.Windows.Forms.Label()
        Me.lLoc = New System.Windows.Forms.Label()
        Me.lIdOS = New System.Windows.Forms.Label()
        Me.lEmail = New System.Windows.Forms.Label()
        Me.fNac = New System.Windows.Forms.Label()
        Me.lFAlta = New System.Windows.Forms.Label()
        Me.lTel = New System.Windows.Forms.Label()
        Me.ldirec = New System.Windows.Forms.Label()
        Me.lDni = New System.Windows.Forms.Label()
        Me.lApellido = New System.Windows.Forms.Label()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.LGenero = New System.Windows.Forms.Label()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.btnC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTitulo.Controls.Add(Me.btnC)
        Me.PanelTitulo.Controls.Add(Me.btnMini)
        Me.PanelTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(676, 26)
        Me.PanelTitulo.TabIndex = 58
        '
        'btnC
        '
        Me.btnC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC.Image = CType(resources.GetObject("btnC.Image"), System.Drawing.Image)
        Me.btnC.Location = New System.Drawing.Point(641, 2)
        Me.btnC.Margin = New System.Windows.Forms.Padding(2)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(24, 21)
        Me.btnC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnC.TabIndex = 34
        Me.btnC.TabStop = False
        '
        'btnMini
        '
        Me.btnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMini.Image = CType(resources.GetObject("btnMini.Image"), System.Drawing.Image)
        Me.btnMini.Location = New System.Drawing.Point(606, 2)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(1253, 3)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1286, 3)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(24, 21)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'cbOS
        '
        Me.cbOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOS.FormattingEnabled = True
        Me.cbOS.Items.AddRange(New Object() {"IOSCOR"})
        Me.cbOS.Location = New System.Drawing.Point(107, 193)
        Me.cbOS.Name = "cbOS"
        Me.cbOS.Size = New System.Drawing.Size(104, 21)
        Me.cbOS.TabIndex = 57
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(339, 164)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(190, 20)
        Me.txtEmail.TabIndex = 56
        '
        'txtTelef
        '
        Me.txtTelef.Location = New System.Drawing.Point(385, 133)
        Me.txtTelef.Name = "txtTelef"
        Me.txtTelef.Size = New System.Drawing.Size(147, 20)
        Me.txtTelef.TabIndex = 55
        '
        'txtDirec
        '
        Me.txtDirec.Location = New System.Drawing.Point(365, 39)
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(168, 20)
        Me.txtDirec.TabIndex = 54
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(365, 72)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(168, 20)
        Me.txtLoc.TabIndex = 53
        '
        'txtProv
        '
        Me.txtProv.Location = New System.Drawing.Point(364, 104)
        Me.txtProv.Name = "txtProv"
        Me.txtProv.Size = New System.Drawing.Size(168, 20)
        Me.txtProv.TabIndex = 52
        '
        'dtpAlta
        '
        Me.dtpAlta.CustomFormat = "dd/MM/yy"
        Me.dtpAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAlta.Location = New System.Drawing.Point(122, 164)
        Me.dtpAlta.Name = "dtpAlta"
        Me.dtpAlta.Size = New System.Drawing.Size(77, 20)
        Me.dtpAlta.TabIndex = 51
        Me.dtpAlta.Value = New Date(2022, 9, 20, 0, 0, 0, 0)
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.CustomFormat = "dd/MM/yy"
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNacimiento.Location = New System.Drawing.Point(170, 132)
        Me.dtpNacimiento.MaxDate = New Date(2022, 9, 20, 0, 0, 0, 0)
        Me.dtpNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(82, 20)
        Me.dtpNacimiento.TabIndex = 50
        Me.dtpNacimiento.Value = New Date(2022, 9, 20, 0, 0, 0, 0)
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(84, 104)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(168, 20)
        Me.txtDNI.TabIndex = 49
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(84, 72)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(168, 20)
        Me.txtApellido.TabIndex = 48
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(84, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtNombre.TabIndex = 47
        '
        'lProv
        '
        Me.lProv.AutoSize = True
        Me.lProv.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lProv.Location = New System.Drawing.Point(286, 106)
        Me.lProv.Name = "lProv"
        Me.lProv.Size = New System.Drawing.Size(72, 17)
        Me.lProv.TabIndex = 46
        Me.lProv.Text = "Provincia:"
        '
        'lLoc
        '
        Me.lLoc.AutoSize = True
        Me.lLoc.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lLoc.Location = New System.Drawing.Point(286, 74)
        Me.lLoc.Name = "lLoc"
        Me.lLoc.Size = New System.Drawing.Size(77, 17)
        Me.lLoc.TabIndex = 45
        Me.lLoc.Text = "Localidad:"
        '
        'lIdOS
        '
        Me.lIdOS.AutoSize = True
        Me.lIdOS.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lIdOS.Location = New System.Drawing.Point(14, 193)
        Me.lIdOS.Name = "lIdOS"
        Me.lIdOS.Size = New System.Drawing.Size(87, 17)
        Me.lIdOS.TabIndex = 44
        Me.lIdOS.Text = "Obra Social:"
        '
        'lEmail
        '
        Me.lEmail.AutoSize = True
        Me.lEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lEmail.Location = New System.Drawing.Point(286, 166)
        Me.lEmail.Name = "lEmail"
        Me.lEmail.Size = New System.Drawing.Size(47, 17)
        Me.lEmail.TabIndex = 43
        Me.lEmail.Text = "Email:"
        '
        'fNac
        '
        Me.fNac.AutoSize = True
        Me.fNac.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.fNac.Location = New System.Drawing.Point(14, 136)
        Me.fNac.Name = "fNac"
        Me.fNac.Size = New System.Drawing.Size(152, 17)
        Me.fNac.TabIndex = 42
        Me.fNac.Text = "Fecha de Nacimiento:"
        '
        'lFAlta
        '
        Me.lFAlta.AutoSize = True
        Me.lFAlta.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lFAlta.Location = New System.Drawing.Point(14, 166)
        Me.lFAlta.Name = "lFAlta"
        Me.lFAlta.Size = New System.Drawing.Size(102, 17)
        Me.lFAlta.TabIndex = 41
        Me.lFAlta.Text = "Fecha de Alta:"
        '
        'lTel
        '
        Me.lTel.AutoSize = True
        Me.lTel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lTel.Location = New System.Drawing.Point(286, 136)
        Me.lTel.Name = "lTel"
        Me.lTel.Size = New System.Drawing.Size(97, 17)
        Me.lTel.TabIndex = 40
        Me.lTel.Text = "Nro. teléfono:"
        '
        'ldirec
        '
        Me.ldirec.AutoSize = True
        Me.ldirec.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.ldirec.Location = New System.Drawing.Point(286, 41)
        Me.ldirec.Name = "ldirec"
        Me.ldirec.Size = New System.Drawing.Size(73, 17)
        Me.ldirec.TabIndex = 39
        Me.ldirec.Text = "Dirección:"
        '
        'lDni
        '
        Me.lDni.AutoSize = True
        Me.lDni.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lDni.Location = New System.Drawing.Point(14, 106)
        Me.lDni.Name = "lDni"
        Me.lDni.Size = New System.Drawing.Size(35, 17)
        Me.lDni.TabIndex = 38
        Me.lDni.Text = "DNI:"
        '
        'lApellido
        '
        Me.lApellido.AutoSize = True
        Me.lApellido.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lApellido.Location = New System.Drawing.Point(14, 74)
        Me.lApellido.Name = "lApellido"
        Me.lApellido.Size = New System.Drawing.Size(65, 17)
        Me.lApellido.TabIndex = 37
        Me.lApellido.Text = "Apellido:"
        '
        'lNombre
        '
        Me.lNombre.AutoSize = True
        Me.lNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lNombre.Location = New System.Drawing.Point(14, 41)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(65, 17)
        Me.lNombre.TabIndex = 36
        Me.lNombre.Text = "Nombre:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(339, 238)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 20)
        Me.btnCancelar.TabIndex = 34
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
        Me.btnGuardar.Location = New System.Drawing.Point(170, 238)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 20)
        Me.btnGuardar.TabIndex = 33
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(539, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'cbGenero
        '
        Me.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"Femenino", "Maculino"})
        Me.cbGenero.Location = New System.Drawing.Point(352, 192)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(174, 21)
        Me.cbGenero.TabIndex = 98
        '
        'LGenero
        '
        Me.LGenero.AutoSize = True
        Me.LGenero.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.LGenero.Location = New System.Drawing.Point(286, 194)
        Me.LGenero.Name = "LGenero"
        Me.LGenero.Size = New System.Drawing.Size(60, 17)
        Me.LGenero.TabIndex = 97
        Me.LGenero.Text = "Genero:"
        '
        'FormEditPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(672, 270)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.LGenero)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.cbOS)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelef)
        Me.Controls.Add(Me.txtDirec)
        Me.Controls.Add(Me.txtLoc)
        Me.Controls.Add(Me.txtProv)
        Me.Controls.Add(Me.dtpAlta)
        Me.Controls.Add(Me.dtpNacimiento)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lProv)
        Me.Controls.Add(Me.lLoc)
        Me.Controls.Add(Me.lIdOS)
        Me.Controls.Add(Me.lEmail)
        Me.Controls.Add(Me.fNac)
        Me.Controls.Add(Me.lFAlta)
        Me.Controls.Add(Me.lTel)
        Me.Controls.Add(Me.ldirec)
        Me.Controls.Add(Me.lDni)
        Me.Controls.Add(Me.lApellido)
        Me.Controls.Add(Me.lNombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEditPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEditPacientes"
        Me.PanelTitulo.ResumeLayout(False)
        CType(Me.btnC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents btnC As PictureBox
    Friend WithEvents btnMini As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Public WithEvents cbOS As ComboBox
    Public WithEvents txtEmail As TextBox
    Public WithEvents txtTelef As TextBox
    Public WithEvents txtDirec As TextBox
    Public WithEvents txtLoc As TextBox
    Public WithEvents txtProv As TextBox
    Public WithEvents dtpAlta As DateTimePicker
    Public WithEvents dtpNacimiento As DateTimePicker
    Public WithEvents txtDNI As TextBox
    Public WithEvents txtApellido As TextBox
    Public WithEvents txtNombre As TextBox
    Public WithEvents lProv As Label
    Public WithEvents lLoc As Label
    Public WithEvents lIdOS As Label
    Public WithEvents lEmail As Label
    Public WithEvents fNac As Label
    Public WithEvents lFAlta As Label
    Public WithEvents lTel As Label
    Public WithEvents ldirec As Label
    Friend WithEvents lDni As Label
    Public WithEvents lApellido As Label
    Public WithEvents lNombre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancelar As Button
    Public WithEvents btnGuardar As Button
    Public WithEvents cbGenero As ComboBox
    Public WithEvents LGenero As Label
End Class
