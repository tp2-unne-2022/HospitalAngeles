<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TablaUsuario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TablaUsuario))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.butEli = New System.Windows.Forms.Button()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTipos = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.rbBaja = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbAlta = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbAct = New System.Windows.Forms.RadioButton()
        Me.rbInactivos = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(413, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 17)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Búsqueda por Nombre:"
        '
        'butEli
        '
        Me.butEli.BackColor = System.Drawing.Color.LightCoral
        Me.butEli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butEli.FlatAppearance.BorderSize = 0
        Me.butEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butEli.ForeColor = System.Drawing.SystemColors.Control
        Me.butEli.Location = New System.Drawing.Point(544, 443)
        Me.butEli.Name = "butEli"
        Me.butEli.Size = New System.Drawing.Size(56, 41)
        Me.butEli.TabIndex = 96
        Me.butEli.Text = "Dar de Baja"
        Me.butEli.UseVisualStyleBackColor = False
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(413, 216)
        Me.TxtBusqueda.MaxLength = 20
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(123, 20)
        Me.TxtBusqueda.TabIndex = 95
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(542, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 20)
        Me.Button2.TabIndex = 94
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnModif
        '
        Me.btnModif.BackColor = System.Drawing.Color.SteelBlue
        Me.btnModif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModif.FlatAppearance.BorderSize = 0
        Me.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModif.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModif.Location = New System.Drawing.Point(8, 289)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(64, 20)
        Me.btnModif.TabIndex = 93
        Me.btnModif.Text = "Modificar"
        Me.btnModif.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.Tipo, Me.Username, Me.contraseña, Me.baja})
        Me.DataGridView1.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(78, 252)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(460, 232)
        Me.DataGridView1.TabIndex = 92
        '
        'dni
        '
        Me.dni.DataPropertyName = "dni"
        Me.dni.HeaderText = "dni"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "id_tipo_usuario"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Username
        '
        Me.Username.DataPropertyName = "username"
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        '
        'contraseña
        '
        Me.contraseña.DataPropertyName = "password"
        Me.contraseña.FillWeight = 150.0!
        Me.contraseña.HeaderText = "contraseña"
        Me.contraseña.Name = "contraseña"
        Me.contraseña.ReadOnly = True
        Me.contraseña.Width = 150
        '
        'baja
        '
        Me.baja.DataPropertyName = "deBaja"
        Me.baja.HeaderText = "baja"
        Me.baja.Name = "baja"
        Me.baja.ReadOnly = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.Location = New System.Drawing.Point(8, 252)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(64, 20)
        Me.btnAgregar.TabIndex = 91
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(220, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(148, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 90
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(202, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Sección Usuarios"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(298, 236)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 87
        '
        'btnTipos
        '
        Me.btnTipos.BackColor = System.Drawing.Color.DimGray
        Me.btnTipos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTipos.FlatAppearance.BorderSize = 0
        Me.btnTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTipos.Location = New System.Drawing.Point(413, 156)
        Me.btnTipos.Name = "btnTipos"
        Me.btnTipos.Size = New System.Drawing.Size(84, 20)
        Me.btnTipos.TabIndex = 98
        Me.btnTipos.Text = "Generar"
        Me.btnTipos.UseVisualStyleBackColor = False
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlta.FlatAppearance.BorderSize = 0
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAlta.Location = New System.Drawing.Point(544, 396)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(56, 41)
        Me.btnAlta.TabIndex = 99
        Me.btnAlta.Text = "Dar de Alta"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'rbBaja
        '
        Me.rbBaja.AutoSize = True
        Me.rbBaja.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBaja.Location = New System.Drawing.Point(139, 215)
        Me.rbBaja.Name = "rbBaja"
        Me.rbBaja.Size = New System.Drawing.Size(49, 20)
        Me.rbBaja.TabIndex = 103
        Me.rbBaja.Text = "Baja"
        Me.rbBaja.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.Location = New System.Drawing.Point(203, 215)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(56, 20)
        Me.rbTodos.TabIndex = 102
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbAlta
        '
        Me.rbAlta.AutoSize = True
        Me.rbAlta.Checked = True
        Me.rbAlta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlta.Location = New System.Drawing.Point(78, 215)
        Me.rbAlta.Name = "rbAlta"
        Me.rbAlta.Size = New System.Drawing.Size(46, 20)
        Me.rbAlta.TabIndex = 101
        Me.rbAlta.TabStop = True
        Me.rbAlta.Text = "Alta"
        Me.rbAlta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(74, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 21)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Mostrar dados de:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(412, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 21)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Reporte:"
        '
        'rbAct
        '
        Me.rbAct.AutoSize = True
        Me.rbAct.Location = New System.Drawing.Point(413, 124)
        Me.rbAct.Name = "rbAct"
        Me.rbAct.Size = New System.Drawing.Size(60, 17)
        Me.rbAct.TabIndex = 105
        Me.rbAct.TabStop = True
        Me.rbAct.Text = "Activos"
        Me.rbAct.UseVisualStyleBackColor = True
        '
        'rbInactivos
        '
        Me.rbInactivos.AutoSize = True
        Me.rbInactivos.Location = New System.Drawing.Point(479, 124)
        Me.rbInactivos.Name = "rbInactivos"
        Me.rbInactivos.Size = New System.Drawing.Size(68, 17)
        Me.rbInactivos.TabIndex = 106
        Me.rbInactivos.TabStop = True
        Me.rbInactivos.Text = "Inactivos"
        Me.rbInactivos.UseVisualStyleBackColor = True
        '
        'TablaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(612, 504)
        Me.Controls.Add(Me.rbInactivos)
        Me.Controls.Add(Me.rbAct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbBaja)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.rbAlta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnTipos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.butEli)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TablaUsuario"
        Me.Text = "TablaUsuario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Label3 As Label
    Friend WithEvents butEli As Button
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnModif As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTipos As Button
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents contraseña As DataGridViewTextBoxColumn
    Friend WithEvents baja As DataGridViewTextBoxColumn
    Friend WithEvents btnAlta As Button
    Friend WithEvents rbBaja As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbAlta As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbAct As RadioButton
    Friend WithEvents rbInactivos As RadioButton
    Public WithEvents DataGridView1 As DataGridView
End Class
