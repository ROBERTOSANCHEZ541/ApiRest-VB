<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Token
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
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtNombreGET = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PbxGo = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PbxGo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listBox1
        '
        Me.listBox1.Font = New System.Drawing.Font("Yu Gothic Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 25
        Me.listBox1.Items.AddRange(New Object() {"1"})
        Me.listBox1.Location = New System.Drawing.Point(86, 51)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(35, 29)
        Me.listBox1.TabIndex = 22
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Yu Gothic Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(81, 23)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(42, 25)
        Me.label4.TabIndex = 21
        Me.label4.Text = " id:"
        '
        'txtNombreGET
        '
        Me.txtNombreGET.Location = New System.Drawing.Point(213, 175)
        Me.txtNombreGET.Name = "txtNombreGET"
        Me.txtNombreGET.ReadOnly = True
        Me.txtNombreGET.Size = New System.Drawing.Size(237, 20)
        Me.txtNombreGET.TabIndex = 17
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(155, 178)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 13)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Nombres:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(213, 201)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(237, 20)
        Me.txtEmail.TabIndex = 15
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(155, 204)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Email:"
        '
        'PbxGo
        '
        Me.PbxGo.Image = Global.FormPokedex.My.Resources.Resources.icons8_accede_redondeado_derecho
        Me.PbxGo.Location = New System.Drawing.Point(259, 243)
        Me.PbxGo.Name = "PbxGo"
        Me.PbxGo.Size = New System.Drawing.Size(100, 50)
        Me.PbxGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxGo.TabIndex = 20
        Me.PbxGo.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Location = New System.Drawing.Point(240, 23)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(157, 146)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 13
        Me.pictureBox1.TabStop = False
        '
        'Token
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(546, 323)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.PbxGo)
        Me.Controls.Add(Me.txtNombreGET)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "Token"
        Me.Text = "Token"
        CType(Me.PbxGo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents listBox1 As ListBox
    Private WithEvents label4 As Label
    Private WithEvents PbxGo As PictureBox
    Private WithEvents txtNombreGET As TextBox
    Private WithEvents label2 As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
End Class
