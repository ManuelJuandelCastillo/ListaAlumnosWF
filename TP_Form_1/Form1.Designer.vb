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
        Me.notaM = New System.Windows.Forms.ComboBox()
        Me.notaF = New System.Windows.Forms.ComboBox()
        Me.notaB = New System.Windows.Forms.ComboBox()
        Me.notaQ = New System.Windows.Forms.ComboBox()
        Me.notaD = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Alumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEvaluacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'notaM
        '
        Me.notaM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.notaM.FormattingEnabled = True
        Me.notaM.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.notaM.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.notaM.Location = New System.Drawing.Point(129, 70)
        Me.notaM.Name = "notaM"
        Me.notaM.Size = New System.Drawing.Size(45, 21)
        Me.notaM.TabIndex = 1
        '
        'notaF
        '
        Me.notaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.notaF.FormattingEnabled = True
        Me.notaF.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.notaF.Location = New System.Drawing.Point(129, 97)
        Me.notaF.Name = "notaF"
        Me.notaF.Size = New System.Drawing.Size(45, 21)
        Me.notaF.TabIndex = 2
        '
        'notaB
        '
        Me.notaB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.notaB.FormattingEnabled = True
        Me.notaB.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.notaB.Location = New System.Drawing.Point(129, 124)
        Me.notaB.Name = "notaB"
        Me.notaB.Size = New System.Drawing.Size(45, 21)
        Me.notaB.TabIndex = 3
        '
        'notaQ
        '
        Me.notaQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.notaQ.FormattingEnabled = True
        Me.notaQ.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.notaQ.Location = New System.Drawing.Point(129, 151)
        Me.notaQ.Name = "notaQ"
        Me.notaQ.Size = New System.Drawing.Size(45, 21)
        Me.notaQ.TabIndex = 4
        '
        'notaD
        '
        Me.notaD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.notaD.FormattingEnabled = True
        Me.notaD.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.notaD.Location = New System.Drawing.Point(129, 178)
        Me.notaD.Name = "notaD"
        Me.notaD.Size = New System.Drawing.Size(45, 21)
        Me.notaD.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Matemática:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(85, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Física:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(76, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Biología:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(75, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Química:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(72, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Derecho:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(23, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Alumno:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(15, 38)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(163, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Alumno, Me.ColumnEvaluacion})
        Me.DataGridView1.Location = New System.Drawing.Point(221, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(248, 270)
        Me.DataGridView1.TabIndex = 12
        Me.DataGridView1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(26, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 49)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cargar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Alumno
        '
        Me.Alumno.HeaderText = "Alumno"
        Me.Alumno.Name = "Alumno"
        Me.Alumno.ReadOnly = True
        '
        'ColumnEvaluacion
        '
        Me.ColumnEvaluacion.HeaderText = "Evaluación"
        Me.ColumnEvaluacion.Name = "ColumnEvaluacion"
        Me.ColumnEvaluacion.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(488, 319)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.notaD)
        Me.Controls.Add(Me.notaQ)
        Me.Controls.Add(Me.notaB)
        Me.Controls.Add(Me.notaF)
        Me.Controls.Add(Me.notaM)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Carga de Notas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents notaM As ComboBox
    Friend WithEvents notaF As ComboBox
    Friend WithEvents notaB As ComboBox
    Friend WithEvents notaQ As ComboBox
    Friend WithEvents notaD As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Alumno As DataGridViewTextBoxColumn
    Friend WithEvents ColumnEvaluacion As DataGridViewTextBoxColumn
End Class
