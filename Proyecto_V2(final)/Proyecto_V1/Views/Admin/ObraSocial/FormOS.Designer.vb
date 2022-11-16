<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOS))
        Me.butEliPac = New System.Windows.Forms.Button()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porcentaje_cobertura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deBaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnActu = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.rbPaciente = New System.Windows.Forms.RadioButton()
        Me.rbPersonal = New System.Windows.Forms.RadioButton()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.rbBaja = New System.Windows.Forms.RadioButton()
        Me.rbTodosRegistros = New System.Windows.Forms.RadioButton()
        Me.rbAlta = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnActu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butEliPac
        '
        Me.butEliPac.BackColor = System.Drawing.Color.LightCoral
        Me.butEliPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butEliPac.FlatAppearance.BorderSize = 0
        Me.butEliPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butEliPac.ForeColor = System.Drawing.SystemColors.Control
        Me.butEliPac.Location = New System.Drawing.Point(484, 451)
        Me.butEliPac.Name = "butEliPac"
        Me.butEliPac.Size = New System.Drawing.Size(66, 37)
        Me.butEliPac.TabIndex = 36
        Me.butEliPac.Text = "Dar de Baja"
        Me.butEliPac.UseVisualStyleBackColor = False
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(359, 255)
        Me.TxtBusqueda.MaxLength = 20
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(123, 20)
        Me.TxtBusqueda.TabIndex = 35
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Location = New System.Drawing.Point(488, 254)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 20)
        Me.btnBuscar.TabIndex = 34
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnModif
        '
        Me.btnModif.BackColor = System.Drawing.Color.SteelBlue
        Me.btnModif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModif.FlatAppearance.BorderSize = 0
        Me.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModif.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModif.Location = New System.Drawing.Point(193, 459)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(120, 20)
        Me.btnModif.TabIndex = 33
        Me.btnModif.Text = "Modificar OS"
        Me.btnModif.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.nombre, Me.porcentaje_cobertura, Me.deBaja})
        Me.DataGridView1.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(57, 294)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(493, 136)
        Me.DataGridView1.TabIndex = 32
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'porcentaje_cobertura
        '
        Me.porcentaje_cobertura.DataPropertyName = "porc_cobertura"
        Me.porcentaje_cobertura.FillWeight = 150.0!
        Me.porcentaje_cobertura.HeaderText = "Cobertura %"
        Me.porcentaje_cobertura.Name = "porcentaje_cobertura"
        Me.porcentaje_cobertura.ReadOnly = True
        Me.porcentaje_cobertura.Width = 150
        '
        'deBaja
        '
        Me.deBaja.DataPropertyName = "deBaja"
        Me.deBaja.HeaderText = "Activo"
        Me.deBaja.Name = "deBaja"
        Me.deBaja.ReadOnly = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.Location = New System.Drawing.Point(57, 459)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(120, 20)
        Me.btnAgregar.TabIndex = 30
        Me.btnAgregar.Text = "Agregar OS"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(359, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(192, 164)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(188, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Sección Obra Social"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 228)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(356, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Búsqueda por Nombre:"
        '
        'btnActu
        '
        Me.btnActu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActu.Image = CType(resources.GetObject("btnActu.Image"), System.Drawing.Image)
        Me.btnActu.Location = New System.Drawing.Point(57, 10)
        Me.btnActu.Name = "btnActu"
        Me.btnActu.Size = New System.Drawing.Size(30, 30)
        Me.btnActu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnActu.TabIndex = 57
        Me.btnActu.TabStop = False
        Me.btnActu.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 18)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Reporte Obra Social:"
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.SteelBlue
        Me.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReporte.Location = New System.Drawing.Point(57, 174)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(120, 20)
        Me.btnReporte.TabIndex = 65
        Me.btnReporte.Text = "Generar Reporte"
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'rbPaciente
        '
        Me.rbPaciente.AutoSize = True
        Me.rbPaciente.Location = New System.Drawing.Point(60, 142)
        Me.rbPaciente.Name = "rbPaciente"
        Me.rbPaciente.Size = New System.Drawing.Size(72, 17)
        Me.rbPaciente.TabIndex = 71
        Me.rbPaciente.TabStop = True
        Me.rbPaciente.Text = "Pacientes"
        Me.rbPaciente.UseVisualStyleBackColor = True
        '
        'rbPersonal
        '
        Me.rbPersonal.AutoSize = True
        Me.rbPersonal.Location = New System.Drawing.Point(138, 142)
        Me.rbPersonal.Name = "rbPersonal"
        Me.rbPersonal.Size = New System.Drawing.Size(66, 17)
        Me.rbPersonal.TabIndex = 73
        Me.rbPersonal.TabStop = True
        Me.rbPersonal.Text = "Personal"
        Me.rbPersonal.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlta.FlatAppearance.BorderSize = 0
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAlta.Location = New System.Drawing.Point(399, 451)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(66, 37)
        Me.btnAlta.TabIndex = 77
        Me.btnAlta.Text = "Dar de alta"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'rbBaja
        '
        Me.rbBaja.AutoSize = True
        Me.rbBaja.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBaja.Location = New System.Drawing.Point(118, 255)
        Me.rbBaja.Name = "rbBaja"
        Me.rbBaja.Size = New System.Drawing.Size(49, 20)
        Me.rbBaja.TabIndex = 81
        Me.rbBaja.Text = "Baja"
        Me.rbBaja.UseVisualStyleBackColor = True
        '
        'rbTodosRegistros
        '
        Me.rbTodosRegistros.AutoSize = True
        Me.rbTodosRegistros.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodosRegistros.Location = New System.Drawing.Point(182, 255)
        Me.rbTodosRegistros.Name = "rbTodosRegistros"
        Me.rbTodosRegistros.Size = New System.Drawing.Size(56, 20)
        Me.rbTodosRegistros.TabIndex = 80
        Me.rbTodosRegistros.Text = "Todos"
        Me.rbTodosRegistros.UseVisualStyleBackColor = True
        '
        'rbAlta
        '
        Me.rbAlta.AutoSize = True
        Me.rbAlta.Checked = True
        Me.rbAlta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlta.Location = New System.Drawing.Point(57, 255)
        Me.rbAlta.Name = "rbAlta"
        Me.rbAlta.Size = New System.Drawing.Size(46, 20)
        Me.rbAlta.TabIndex = 79
        Me.rbAlta.TabStop = True
        Me.rbAlta.Text = "Alta"
        Me.rbAlta.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(53, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 21)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Mostrar dados de:"
        '
        'FormOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(612, 504)
        Me.Controls.Add(Me.rbBaja)
        Me.Controls.Add(Me.rbTodosRegistros)
        Me.Controls.Add(Me.rbAlta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.rbPersonal)
        Me.Controls.Add(Me.rbPaciente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.btnActu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.butEliPac)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormOS"
        Me.Text = "FormOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnActu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butEliPac As Button
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnModif As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Public WithEvents Label3 As Label
    Friend WithEvents btnActu As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReporte As Button
    Friend WithEvents rbPaciente As RadioButton
    Friend WithEvents rbPersonal As RadioButton
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents porcentaje_cobertura As DataGridViewTextBoxColumn
    Friend WithEvents deBaja As DataGridViewTextBoxColumn
    Friend WithEvents btnAlta As Button
    Friend WithEvents rbBaja As RadioButton
    Friend WithEvents rbTodosRegistros As RadioButton
    Friend WithEvents rbAlta As RadioButton
    Friend WithEvents Label7 As Label
    Public Shared WithEvents DataGridView1 As DataGridView
End Class
