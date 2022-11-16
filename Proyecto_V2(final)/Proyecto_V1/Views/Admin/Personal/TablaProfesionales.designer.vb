<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TablaProfesionales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TablaProfesionales))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnEli = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbAlta = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbBaja = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_tipo_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_obra_soc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.cod_tipo_personal, Me.id_obra_soc, Me.id_genero, Me.nombre, Me.apellido, Me.fecha_nac, Me.fecha_ingreso, Me.localidad, Me.provincia, Me.domicilio, Me.num_telefono, Me.email, Me.Baja})
        Me.DataGridView1.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(18, 179)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(585, 256)
        Me.DataGridView1.TabIndex = 18
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Location = New System.Drawing.Point(554, 133)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(49, 20)
        Me.btnBuscar.TabIndex = 16
        Me.btnBuscar.Text = "Buscar Profesional"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.Location = New System.Drawing.Point(18, 462)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(120, 20)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(205, 42)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(199, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(210, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Sección Personal"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(303, 228)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 10
        '
        'btnModif
        '
        Me.btnModif.BackColor = System.Drawing.Color.SteelBlue
        Me.btnModif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModif.FlatAppearance.BorderSize = 0
        Me.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModif.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModif.Location = New System.Drawing.Point(155, 462)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(120, 20)
        Me.btnModif.TabIndex = 20
        Me.btnModif.Text = "Modificar"
        Me.btnModif.UseVisualStyleBackColor = False
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(415, 133)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(123, 20)
        Me.TxtBusqueda.TabIndex = 21
        '
        'btnEli
        '
        Me.btnEli.BackColor = System.Drawing.Color.LightCoral
        Me.btnEli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEli.FlatAppearance.BorderSize = 0
        Me.btnEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEli.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEli.Location = New System.Drawing.Point(537, 451)
        Me.btnEli.Name = "btnEli"
        Me.btnEli.Size = New System.Drawing.Size(66, 37)
        Me.btnEli.TabIndex = 22
        Me.btnEli.Text = "Dar de Baja"
        Me.btnEli.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(411, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Buscar por apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 21)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Mostrar dados de:"
        '
        'rbAlta
        '
        Me.rbAlta.AutoSize = True
        Me.rbAlta.Checked = True
        Me.rbAlta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlta.Location = New System.Drawing.Point(30, 133)
        Me.rbAlta.Name = "rbAlta"
        Me.rbAlta.Size = New System.Drawing.Size(46, 20)
        Me.rbAlta.TabIndex = 26
        Me.rbAlta.TabStop = True
        Me.rbAlta.Text = "Alta"
        Me.rbAlta.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.Location = New System.Drawing.Point(155, 133)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(56, 20)
        Me.rbTodos.TabIndex = 27
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbBaja
        '
        Me.rbBaja.AutoSize = True
        Me.rbBaja.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBaja.Location = New System.Drawing.Point(91, 133)
        Me.rbBaja.Name = "rbBaja"
        Me.rbBaja.Size = New System.Drawing.Size(49, 20)
        Me.rbBaja.TabIndex = 28
        Me.rbBaja.Text = "Baja"
        Me.rbBaja.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(503, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 21)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Tipo Personal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(414, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 21)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Acceder:"
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlta.FlatAppearance.BorderSize = 0
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAlta.Location = New System.Drawing.Point(451, 451)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(66, 37)
        Me.btnAlta.TabIndex = 73
        Me.btnAlta.Text = "Dar de alta"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'dni
        '
        Me.dni.DataPropertyName = "dni"
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        '
        'cod_tipo_personal
        '
        Me.cod_tipo_personal.DataPropertyName = "cod_tipo_personal"
        Me.cod_tipo_personal.HeaderText = "Tipo Personal"
        Me.cod_tipo_personal.Name = "cod_tipo_personal"
        Me.cod_tipo_personal.ReadOnly = True
        '
        'id_obra_soc
        '
        Me.id_obra_soc.DataPropertyName = "id_obra_soc"
        Me.id_obra_soc.HeaderText = "Obra Social"
        Me.id_obra_soc.Name = "id_obra_soc"
        Me.id_obra_soc.ReadOnly = True
        '
        'id_genero
        '
        Me.id_genero.DataPropertyName = "id_genero"
        Me.id_genero.HeaderText = "Genero"
        Me.id_genero.Name = "id_genero"
        Me.id_genero.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        '
        'fecha_nac
        '
        Me.fecha_nac.DataPropertyName = "fecha_nac"
        Me.fecha_nac.HeaderText = "Fecha Nacimiento"
        Me.fecha_nac.Name = "fecha_nac"
        Me.fecha_nac.ReadOnly = True
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.DataPropertyName = "fecha_ingreso"
        Me.fecha_ingreso.HeaderText = "Fecha Ingreso"
        Me.fecha_ingreso.Name = "fecha_ingreso"
        Me.fecha_ingreso.ReadOnly = True
        '
        'localidad
        '
        Me.localidad.DataPropertyName = "localidad"
        Me.localidad.HeaderText = "Localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        '
        'provincia
        '
        Me.provincia.DataPropertyName = "provincia"
        Me.provincia.HeaderText = "Provincia"
        Me.provincia.Name = "provincia"
        Me.provincia.ReadOnly = True
        '
        'domicilio
        '
        Me.domicilio.DataPropertyName = "domicilio"
        Me.domicilio.HeaderText = "Domicilio"
        Me.domicilio.Name = "domicilio"
        Me.domicilio.ReadOnly = True
        '
        'num_telefono
        '
        Me.num_telefono.DataPropertyName = "num_tel"
        Me.num_telefono.HeaderText = "Telefono"
        Me.num_telefono.Name = "num_telefono"
        Me.num_telefono.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'Baja
        '
        Me.Baja.DataPropertyName = "deBaja"
        Me.Baja.HeaderText = "Activo"
        Me.Baja.Name = "Baja"
        Me.Baja.ReadOnly = True
        '
        'TablaProfesionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(651, 504)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rbBaja)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.rbAlta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEli)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TablaProfesionales"
        Me.Text = "Profesionales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModif As Button
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents btnEli As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Public Shared WithEvents DataGridView1 As DataGridView
    Friend WithEvents rbAlta As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbBaja As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents cod_tipo_personal As DataGridViewTextBoxColumn
    Friend WithEvents id_obra_soc As DataGridViewTextBoxColumn
    Friend WithEvents id_genero As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents fecha_nac As DataGridViewTextBoxColumn
    Friend WithEvents fecha_ingreso As DataGridViewTextBoxColumn
    Friend WithEvents localidad As DataGridViewTextBoxColumn
    Friend WithEvents provincia As DataGridViewTextBoxColumn
    Friend WithEvents domicilio As DataGridViewTextBoxColumn
    Friend WithEvents num_telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents Baja As DataGridViewTextBoxColumn
End Class
