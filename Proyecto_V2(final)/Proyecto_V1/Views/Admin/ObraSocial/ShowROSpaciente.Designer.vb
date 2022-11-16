<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowROSpaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowROSpaciente))
        Me.crvOS = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.lbOnline = New System.Windows.Forms.Label()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'crvOS
        '
        Me.crvOS.ActiveViewIndex = -1
        Me.crvOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvOS.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvOS.Location = New System.Drawing.Point(1, 108)
        Me.crvOS.Name = "crvOS"
        Me.crvOS.ShowCloseButton = False
        Me.crvOS.ShowGotoPageButton = False
        Me.crvOS.ShowGroupTreeButton = False
        Me.crvOS.ShowParameterPanelButton = False
        Me.crvOS.Size = New System.Drawing.Size(950, 543)
        Me.crvOS.TabIndex = 0
        Me.crvOS.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'dtpHasta
        '
        Me.dtpHasta.CustomFormat = "dd/MM/yy"
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHasta.Location = New System.Drawing.Point(210, 75)
        Me.dtpHasta.MaxDate = New Date(2022, 10, 28, 19, 51, 33, 0)
        Me.dtpHasta.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(82, 20)
        Me.dtpHasta.TabIndex = 75
        Me.dtpHasta.Value = New Date(2022, 9, 20, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 16)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Fecha Nacimiento hasta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 16)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Fecha Nacimiento desde"
        '
        'dtpDesde
        '
        Me.dtpDesde.CustomFormat = "dd/MM/yy"
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDesde.Location = New System.Drawing.Point(210, 43)
        Me.dtpDesde.MaxDate = New Date(2022, 10, 28, 19, 51, 22, 0)
        Me.dtpDesde.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(82, 20)
        Me.dtpDesde.TabIndex = 72
        Me.dtpDesde.Value = New Date(2022, 9, 20, 0, 0, 0, 0)
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.SteelBlue
        Me.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReporte.Location = New System.Drawing.Point(335, 62)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(120, 20)
        Me.btnReporte.TabIndex = 71
        Me.btnReporte.Text = "Generar Reporte"
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(884, 2)
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
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(917, 2)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(24, 21)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTitulo.Controls.Add(Me.lbOnline)
        Me.PanelTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(950, 27)
        Me.PanelTitulo.TabIndex = 77
        '
        'lbOnline
        '
        Me.lbOnline.AutoSize = True
        Me.lbOnline.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOnline.ForeColor = System.Drawing.Color.LightGray
        Me.lbOnline.Location = New System.Drawing.Point(200, 6)
        Me.lbOnline.Name = "lbOnline"
        Me.lbOnline.Size = New System.Drawing.Size(0, 17)
        Me.lbOnline.TabIndex = 16
        '
        'ShowROSpaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.crvOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ShowROSpaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShowROS"
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents crvOS As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Public WithEvents dtpHasta As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Public WithEvents dtpDesde As DateTimePicker
    Friend WithEvents btnReporte As Button
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lbOnline As Label
End Class
