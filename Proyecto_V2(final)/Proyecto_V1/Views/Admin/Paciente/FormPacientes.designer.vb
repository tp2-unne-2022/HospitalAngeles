<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPacientes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPacientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_obra_soc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_alta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nroTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.butEliPac = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnActu = New System.Windows.Forms.PictureBox()
        Me.rbBaja = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbAlta = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnActu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 228)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(199, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sección Pacientes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Buscar por Apellido:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.Location = New System.Drawing.Point(12, 453)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(120, 20)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.dni, Me.nombre, Me.apellido, Me.genero, Me.id_obra_soc, Me.fecha_nac, Me.fecha_alta, Me.localidad, Me.provincia, Me.direccion, Me.nroTel, Me.email, Me.baja})
        Me.DataGridView1.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(10, 179)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(590, 256)
        Me.DataGridView1.TabIndex = 9
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'dni
        '
        Me.dni.DataPropertyName = "dni"
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
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
        'genero
        '
        Me.genero.DataPropertyName = "id_genero"
        Me.genero.HeaderText = "Genero"
        Me.genero.Name = "genero"
        Me.genero.ReadOnly = True
        '
        'id_obra_soc
        '
        Me.id_obra_soc.DataPropertyName = "id_obra_soc"
        Me.id_obra_soc.HeaderText = "Obra Social"
        Me.id_obra_soc.Name = "id_obra_soc"
        Me.id_obra_soc.ReadOnly = True
        '
        'fecha_nac
        '
        Me.fecha_nac.DataPropertyName = "fecha_nac"
        Me.fecha_nac.HeaderText = "Fecha Nacimiento"
        Me.fecha_nac.Name = "fecha_nac"
        Me.fecha_nac.ReadOnly = True
        '
        'fecha_alta
        '
        Me.fecha_alta.DataPropertyName = "fecha_alta"
        Me.fecha_alta.HeaderText = "Fecha Alta"
        Me.fecha_alta.Name = "fecha_alta"
        Me.fecha_alta.ReadOnly = True
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
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'nroTel
        '
        Me.nroTel.DataPropertyName = "telefono"
        Me.nroTel.HeaderText = "Nro Telefono"
        Me.nroTel.Name = "nroTel"
        Me.nroTel.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'baja
        '
        Me.baja.DataPropertyName = "deBaja"
        Me.baja.HeaderText = "Baja"
        Me.baja.Name = "baja"
        Me.baja.ReadOnly = True
        '
        'btnModif
        '
        Me.btnModif.BackColor = System.Drawing.Color.SteelBlue
        Me.btnModif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModif.FlatAppearance.BorderSize = 0
        Me.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModif.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModif.Location = New System.Drawing.Point(175, 453)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(120, 20)
        Me.btnModif.TabIndex = 11
        Me.btnModif.Text = "Modificar"
        Me.btnModif.UseVisualStyleBackColor = False
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(412, 142)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(123, 20)
        Me.TxtBusqueda.TabIndex = 23
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Location = New System.Drawing.Point(551, 142)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(49, 20)
        Me.btnBuscar.TabIndex = 22
        Me.btnBuscar.Text = "Buscar Profesional"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'butEliPac
        '
        Me.butEliPac.BackColor = System.Drawing.Color.LightCoral
        Me.butEliPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butEliPac.FlatAppearance.BorderSize = 0
        Me.butEliPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butEliPac.ForeColor = System.Drawing.SystemColors.Control
        Me.butEliPac.Location = New System.Drawing.Point(534, 445)
        Me.butEliPac.Name = "butEliPac"
        Me.butEliPac.Size = New System.Drawing.Size(66, 37)
        Me.butEliPac.TabIndex = 24
        Me.butEliPac.Text = "Dar de Baja"
        Me.butEliPac.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(220, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
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
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnActu
        '
        Me.btnActu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActu.Image = CType(resources.GetObject("btnActu.Image"), System.Drawing.Image)
        Me.btnActu.Location = New System.Drawing.Point(60, 9)
        Me.btnActu.Name = "btnActu"
        Me.btnActu.Size = New System.Drawing.Size(30, 30)
        Me.btnActu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnActu.TabIndex = 58
        Me.btnActu.TabStop = False
        Me.btnActu.Visible = False
        '
        'rbBaja
        '
        Me.rbBaja.AutoSize = True
        Me.rbBaja.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBaja.Location = New System.Drawing.Point(77, 142)
        Me.rbBaja.Name = "rbBaja"
        Me.rbBaja.Size = New System.Drawing.Size(49, 20)
        Me.rbBaja.TabIndex = 62
        Me.rbBaja.Text = "Baja"
        Me.rbBaja.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.Location = New System.Drawing.Point(141, 142)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(56, 20)
        Me.rbTodos.TabIndex = 61
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbAlta
        '
        Me.rbAlta.AutoSize = True
        Me.rbAlta.Checked = True
        Me.rbAlta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlta.Location = New System.Drawing.Point(16, 142)
        Me.rbAlta.Name = "rbAlta"
        Me.rbAlta.Size = New System.Drawing.Size(46, 20)
        Me.rbAlta.TabIndex = 60
        Me.rbAlta.TabStop = True
        Me.rbAlta.Text = "Alta"
        Me.rbAlta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 21)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Mostrar dados de:"
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlta.FlatAppearance.BorderSize = 0
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAlta.Location = New System.Drawing.Point(447, 445)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(66, 37)
        Me.btnAlta.TabIndex = 75
        Me.btnAlta.Text = "Dar de alta"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'FormPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(612, 504)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.rbBaja)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.rbAlta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnActu)
        Me.Controls.Add(Me.butEliPac)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormPacientes"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnActu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModif As Button
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents butEliPac As Button
    Friend WithEvents btnActu As PictureBox
    Friend Shared WithEvents DataGridView1 As DataGridView
    Friend WithEvents rbBaja As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbAlta As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents genero As DataGridViewTextBoxColumn
    Friend WithEvents id_obra_soc As DataGridViewTextBoxColumn
    Friend WithEvents fecha_nac As DataGridViewTextBoxColumn
    Friend WithEvents fecha_alta As DataGridViewTextBoxColumn
    Friend WithEvents localidad As DataGridViewTextBoxColumn
    Friend WithEvents provincia As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents nroTel As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents baja As DataGridViewTextBoxColumn
End Class
