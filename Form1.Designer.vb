<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbGenerarCodigo = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgregarAlumno = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnGenerarCodigo = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbDatosDelAlumno = New System.Windows.Forms.GroupBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtDui = New System.Windows.Forms.TextBox()
        Me.lblDui = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.datosAlumnos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxGenero = New System.Windows.Forms.ComboBox()
        Me.gbGenerarCodigo.SuspendLayout()
        Me.gbDatosDelAlumno.SuspendLayout()
        CType(Me.datosAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbGenerarCodigo
        '
        Me.gbGenerarCodigo.Controls.Add(Me.btnLimpiar)
        Me.gbGenerarCodigo.Controls.Add(Me.btnAgregarAlumno)
        Me.gbGenerarCodigo.Controls.Add(Me.txtCodigo)
        Me.gbGenerarCodigo.Controls.Add(Me.btnGenerarCodigo)
        Me.gbGenerarCodigo.Location = New System.Drawing.Point(12, 50)
        Me.gbGenerarCodigo.Name = "gbGenerarCodigo"
        Me.gbGenerarCodigo.Size = New System.Drawing.Size(765, 60)
        Me.gbGenerarCodigo.TabIndex = 0
        Me.gbGenerarCodigo.TabStop = False
        Me.gbGenerarCodigo.Text = "Generar Codigo"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(555, 19)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(111, 23)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar campos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAgregarAlumno
        '
        Me.btnAgregarAlumno.Location = New System.Drawing.Point(365, 19)
        Me.btnAgregarAlumno.Name = "btnAgregarAlumno"
        Me.btnAgregarAlumno.Size = New System.Drawing.Size(118, 23)
        Me.btnAgregarAlumno.TabIndex = 2
        Me.btnAgregarAlumno.Text = "Agregar Alumno"
        Me.btnAgregarAlumno.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(16, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(143, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'btnGenerarCodigo
        '
        Me.btnGenerarCodigo.Location = New System.Drawing.Point(180, 22)
        Me.btnGenerarCodigo.Name = "btnGenerarCodigo"
        Me.btnGenerarCodigo.Size = New System.Drawing.Size(90, 23)
        Me.btnGenerarCodigo.TabIndex = 1
        Me.btnGenerarCodigo.Text = "Generar Codigo"
        Me.btnGenerarCodigo.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(187, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(391, 26)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "INGRESO DE DATOS ESTUDIANTES"
        '
        'gbDatosDelAlumno
        '
        Me.gbDatosDelAlumno.Controls.Add(Me.cbxGenero)
        Me.gbDatosDelAlumno.Controls.Add(Me.txtDireccion)
        Me.gbDatosDelAlumno.Controls.Add(Me.lblDireccion)
        Me.gbDatosDelAlumno.Controls.Add(Me.txtEdad)
        Me.gbDatosDelAlumno.Controls.Add(Me.lblEdad)
        Me.gbDatosDelAlumno.Controls.Add(Me.txtCorreo)
        Me.gbDatosDelAlumno.Controls.Add(Me.lblCorreo)
        Me.gbDatosDelAlumno.Controls.Add(Me.txtDui)
        Me.gbDatosDelAlumno.Controls.Add(Me.lblDui)
        Me.gbDatosDelAlumno.Controls.Add(Me.lblGenero)
        Me.gbDatosDelAlumno.Controls.Add(Me.txtApellido)
        Me.gbDatosDelAlumno.Controls.Add(Me.lblApellido)
        Me.gbDatosDelAlumno.Controls.Add(Me.txtNombre)
        Me.gbDatosDelAlumno.Controls.Add(Me.lblNombre)
        Me.gbDatosDelAlumno.Location = New System.Drawing.Point(12, 149)
        Me.gbDatosDelAlumno.Name = "gbDatosDelAlumno"
        Me.gbDatosDelAlumno.Size = New System.Drawing.Size(765, 189)
        Me.gbDatosDelAlumno.TabIndex = 2
        Me.gbDatosDelAlumno.TabStop = False
        Me.gbDatosDelAlumno.Text = "Datos del Alumno"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(86, 149)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(221, 20)
        Me.txtDireccion.TabIndex = 13
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(7, 152)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 12
        Me.lblDireccion.Text = "Direccion"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(441, 110)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(69, 20)
        Me.txtEdad.TabIndex = 11
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(362, 113)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad.TabIndex = 10
        Me.lblEdad.Text = "Edad"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(441, 72)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(221, 20)
        Me.txtCorreo.TabIndex = 9
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(362, 75)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 8
        Me.lblCorreo.Text = "Correo"
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(441, 31)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(221, 20)
        Me.txtDui.TabIndex = 7
        '
        'lblDui
        '
        Me.lblDui.AutoSize = True
        Me.lblDui.Location = New System.Drawing.Point(362, 34)
        Me.lblDui.Name = "lblDui"
        Me.lblDui.Size = New System.Drawing.Size(26, 13)
        Me.lblDui.TabIndex = 6
        Me.lblDui.Text = "DUI"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(7, 113)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(42, 13)
        Me.lblGenero.TabIndex = 4
        Me.lblGenero.Text = "Genero"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(86, 72)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(221, 20)
        Me.txtApellido.TabIndex = 3
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(7, 75)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(86, 31)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(221, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(7, 34)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'datosAlumnos
        '
        Me.datosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datosAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column7, Me.Column8, Me.Column4, Me.Column6})
        Me.datosAlumnos.Location = New System.Drawing.Point(17, 356)
        Me.datosAlumnos.Name = "datosAlumnos"
        Me.datosAlumnos.Size = New System.Drawing.Size(760, 82)
        Me.datosAlumnos.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Apellido"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Genero"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Edad"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "DUI"
        Me.Column8.Name = "Column8"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Correo"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Direccion"
        Me.Column6.Name = "Column6"
        '
        'cbxGenero
        '
        Me.cbxGenero.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cbxGenero.Location = New System.Drawing.Point(86, 109)
        Me.cbxGenero.Name = "cbxGenero"
        Me.cbxGenero.Size = New System.Drawing.Size(121, 21)
        Me.cbxGenero.TabIndex = 14
        Me.cbxGenero.Text = "Elejir..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.datosAlumnos)
        Me.Controls.Add(Me.gbGenerarCodigo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gbDatosDelAlumno)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbGenerarCodigo.ResumeLayout(False)
        Me.gbGenerarCodigo.PerformLayout()
        Me.gbDatosDelAlumno.ResumeLayout(False)
        Me.gbDatosDelAlumno.PerformLayout()
        CType(Me.datosAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbGenerarCodigo As GroupBox
    Friend WithEvents btnAgregarAlumno As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnGenerarCodigo As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbDatosDelAlumno As GroupBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtDui As TextBox
    Friend WithEvents lblDui As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents datosAlumnos As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cbxGenero As ComboBox
End Class
