<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListadoNodos = New System.Windows.Forms.DataGridView()
        Me.Id_autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_postal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contrato = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tbSalidaXML = New System.Windows.Forms.TextBox()
        Me.btnLeerXML = New System.Windows.Forms.Button()
        Me.btnMostrarEsquema = New System.Windows.Forms.Button()
        CType(Me.ListadoNodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListadoNodos
        '
        Me.ListadoNodos.AllowUserToAddRows = False
        Me.ListadoNodos.AllowUserToDeleteRows = False
        Me.ListadoNodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoNodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_autor, Me.apellidos, Me.nombre, Me.telefono, Me.direccion, Me.ciudad, Me.provincia, Me.codigo_postal, Me.contrato})
        Me.ListadoNodos.Location = New System.Drawing.Point(3, 3)
        Me.ListadoNodos.Name = "ListadoNodos"
        Me.ListadoNodos.ReadOnly = True
        Me.ListadoNodos.Size = New System.Drawing.Size(916, 150)
        Me.ListadoNodos.TabIndex = 0
        '
        'Id_autor
        '
        Me.Id_autor.HeaderText = "Id Autor"
        Me.Id_autor.Name = "Id_autor"
        Me.Id_autor.ReadOnly = True
        '
        'apellidos
        '
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'telefono
        '
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'direccion
        '
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'ciudad
        '
        Me.ciudad.HeaderText = "Ciudad"
        Me.ciudad.Name = "ciudad"
        Me.ciudad.ReadOnly = True
        '
        'provincia
        '
        Me.provincia.HeaderText = "Provincia"
        Me.provincia.Name = "provincia"
        Me.provincia.ReadOnly = True
        '
        'codigo_postal
        '
        Me.codigo_postal.HeaderText = "Código Postal"
        Me.codigo_postal.Name = "codigo_postal"
        Me.codigo_postal.ReadOnly = True
        '
        'contrato
        '
        Me.contrato.HeaderText = "Contrato"
        Me.contrato.Name = "contrato"
        Me.contrato.ReadOnly = True
        '
        'tbSalidaXML
        '
        Me.tbSalidaXML.Location = New System.Drawing.Point(13, 169)
        Me.tbSalidaXML.Multiline = True
        Me.tbSalidaXML.Name = "tbSalidaXML"
        Me.tbSalidaXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbSalidaXML.Size = New System.Drawing.Size(906, 86)
        Me.tbSalidaXML.TabIndex = 1
        Me.tbSalidaXML.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLeerXML
        '
        Me.btnLeerXML.Location = New System.Drawing.Point(209, 280)
        Me.btnLeerXML.Name = "btnLeerXML"
        Me.btnLeerXML.Size = New System.Drawing.Size(88, 33)
        Me.btnLeerXML.TabIndex = 2
        Me.btnLeerXML.Text = "Leer XML"
        Me.btnLeerXML.UseVisualStyleBackColor = True
        '
        'btnMostrarEsquema
        '
        Me.btnMostrarEsquema.Location = New System.Drawing.Point(631, 280)
        Me.btnMostrarEsquema.Name = "btnMostrarEsquema"
        Me.btnMostrarEsquema.Size = New System.Drawing.Size(101, 33)
        Me.btnMostrarEsquema.TabIndex = 3
        Me.btnMostrarEsquema.Text = "Mostrar Esquema"
        Me.btnMostrarEsquema.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 450)
        Me.Controls.Add(Me.btnMostrarEsquema)
        Me.Controls.Add(Me.btnLeerXML)
        Me.Controls.Add(Me.tbSalidaXML)
        Me.Controls.Add(Me.ListadoNodos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ListadoNodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListadoNodos As DataGridView
    Friend WithEvents Id_autor As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents ciudad As DataGridViewTextBoxColumn
    Friend WithEvents provincia As DataGridViewTextBoxColumn
    Friend WithEvents codigo_postal As DataGridViewTextBoxColumn
    Friend WithEvents contrato As DataGridViewCheckBoxColumn
    Friend WithEvents tbSalidaXML As TextBox
    Friend WithEvents btnLeerXML As Button
    Friend WithEvents btnMostrarEsquema As Button
End Class
