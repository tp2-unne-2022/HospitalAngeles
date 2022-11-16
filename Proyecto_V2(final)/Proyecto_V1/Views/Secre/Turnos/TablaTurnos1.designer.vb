<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TablaTurnos1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TablaTurnos1))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni_profesional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto_final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbBaja = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbAlta = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnEli = New System.Windows.Forms.Button()
        Me.btnActu = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnActu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SteelBlue
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Location = New System.Drawing.Point(144, 451)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 20)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Modificar Turno"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.hora, Me.dni_profesional, Me.IDPaciente, Me.nro_turno, Me.baja, Me.monto, Me.monto_final})
        Me.DataGridView1.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(15, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(602, 256)
        Me.DataGridView1.TabIndex = 20
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.MinimumWidth = 8
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 150
        '
        'hora
        '
        Me.hora.DataPropertyName = "hora"
        Me.hora.HeaderText = "Hora"
        Me.hora.MinimumWidth = 8
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        Me.hora.Width = 150
        '
        'dni_profesional
        '
        Me.dni_profesional.DataPropertyName = "profesional"
        Me.dni_profesional.HeaderText = "DNI Profesional"
        Me.dni_profesional.MinimumWidth = 8
        Me.dni_profesional.Name = "dni_profesional"
        Me.dni_profesional.ReadOnly = True
        Me.dni_profesional.Width = 150
        '
        'IDPaciente
        '
        Me.IDPaciente.DataPropertyName = "paciente"
        Me.IDPaciente.HeaderText = "ID Paciente"
        Me.IDPaciente.Name = "IDPaciente"
        Me.IDPaciente.ReadOnly = True
        '
        'nro_turno
        '
        Me.nro_turno.DataPropertyName = "nro_turno"
        Me.nro_turno.HeaderText = "Nro Turno"
        Me.nro_turno.Name = "nro_turno"
        Me.nro_turno.ReadOnly = True
        '
        'baja
        '
        Me.baja.DataPropertyName = "deBaja"
        Me.baja.HeaderText = "Baja"
        Me.baja.Name = "baja"
        Me.baja.ReadOnly = True
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'monto_final
        '
        Me.monto_final.DataPropertyName = "monto_final"
        Me.monto_final.HeaderText = "Monto Final"
        Me.monto_final.Name = "monto_final"
        Me.monto_final.ReadOnly = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(201, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(199, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(219, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Sección Turnos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 230)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 12
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(430, 145)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(123, 20)
        Me.TxtBusqueda.TabIndex = 24
        Me.TxtBusqueda.Text = "0"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(568, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 20)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Buscar Profesional"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(18, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 20)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Agregar Turno"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rbBaja
        '
        Me.rbBaja.AutoSize = True
        Me.rbBaja.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBaja.Location = New System.Drawing.Point(89, 145)
        Me.rbBaja.Name = "rbBaja"
        Me.rbBaja.Size = New System.Drawing.Size(49, 20)
        Me.rbBaja.TabIndex = 32
        Me.rbBaja.Text = "Baja"
        Me.rbBaja.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.Location = New System.Drawing.Point(144, 145)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(56, 20)
        Me.rbTodos.TabIndex = 31
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbAlta
        '
        Me.rbAlta.AutoSize = True
        Me.rbAlta.Checked = True
        Me.rbAlta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlta.Location = New System.Drawing.Point(28, 145)
        Me.rbAlta.Name = "rbAlta"
        Me.rbAlta.Size = New System.Drawing.Size(46, 20)
        Me.rbAlta.TabIndex = 30
        Me.rbAlta.TabStop = True
        Me.rbAlta.Text = "Alta"
        Me.rbAlta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 21)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Mostrar dados de:"
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlta.FlatAppearance.BorderSize = 0
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAlta.Location = New System.Drawing.Point(452, 451)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(66, 37)
        Me.btnAlta.TabIndex = 75
        Me.btnAlta.Text = "Dar de alta"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'btnEli
        '
        Me.btnEli.BackColor = System.Drawing.Color.LightCoral
        Me.btnEli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEli.FlatAppearance.BorderSize = 0
        Me.btnEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEli.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEli.Location = New System.Drawing.Point(538, 451)
        Me.btnEli.Name = "btnEli"
        Me.btnEli.Size = New System.Drawing.Size(66, 37)
        Me.btnEli.TabIndex = 74
        Me.btnEli.Text = "Dar de Baja"
        Me.btnEli.UseVisualStyleBackColor = False
        '
        'btnActu
        '
        Me.btnActu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActu.Image = CType(resources.GetObject("btnActu.Image"), System.Drawing.Image)
        Me.btnActu.Location = New System.Drawing.Point(62, 11)
        Me.btnActu.Name = "btnActu"
        Me.btnActu.Size = New System.Drawing.Size(30, 30)
        Me.btnActu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnActu.TabIndex = 76
        Me.btnActu.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(426, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 21)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Buscar por Apellido:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(270, 451)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(176, 20)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "Imprimir Comprobante de Turno"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TablaTurnos1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(651, 504)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnActu)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnEli)
        Me.Controls.Add(Me.rbBaja)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.rbAlta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TablaTurnos1"
        Me.Text = "Turnos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnActu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents rbBaja As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbAlta As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnEli As Button
    Friend WithEvents btnActu As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents hora As DataGridViewTextBoxColumn
    Friend WithEvents dni_profesional As DataGridViewTextBoxColumn
    Friend WithEvents IDPaciente As DataGridViewTextBoxColumn
    Friend WithEvents nro_turno As DataGridViewTextBoxColumn
    Friend WithEvents baja As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents monto_final As DataGridViewTextBoxColumn
    Public Shared WithEvents DataGridView1 As DataGridView
End Class
