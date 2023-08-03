<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pregunta1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pregunta1))
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_Incorrecta2 = New System.Windows.Forms.Label()
        Me.lbl_Correcta2 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Incorrecta = New System.Windows.Forms.Label()
        Me.lbl_Correcta = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.imagenWari = New System.Windows.Forms.PictureBox()
        Me.imagenChavin = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVerChavin = New System.Windows.Forms.Button()
        Me.btnSiguietne = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.imagenWari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenChavin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnValidar
        '
        Me.btnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.Image = CType(resources.GetObject("btnValidar.Image"), System.Drawing.Image)
        Me.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnValidar.Location = New System.Drawing.Point(319, 613)
        Me.btnValidar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(139, 54)
        Me.btnValidar.TabIndex = 54
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lbl_Incorrecta2)
        Me.Panel2.Controls.Add(Me.lbl_Correcta2)
        Me.Panel2.Controls.Add(Me.RadioButton4)
        Me.Panel2.Controls.Add(Me.RadioButton5)
        Me.Panel2.Controls.Add(Me.RadioButton6)
        Me.Panel2.Location = New System.Drawing.Point(577, 370)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 222)
        Me.Panel2.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "siguiente imagen?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "2.-¿A que cultura pertenece la"
        '
        'lbl_Incorrecta2
        '
        Me.lbl_Incorrecta2.AutoSize = True
        Me.lbl_Incorrecta2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Incorrecta2.ForeColor = System.Drawing.Color.Red
        Me.lbl_Incorrecta2.Location = New System.Drawing.Point(231, 117)
        Me.lbl_Incorrecta2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_Incorrecta2.Name = "lbl_Incorrecta2"
        Me.lbl_Incorrecta2.Size = New System.Drawing.Size(31, 31)
        Me.lbl_Incorrecta2.TabIndex = 11
        Me.lbl_Incorrecta2.Text = "✘"
        Me.lbl_Incorrecta2.Visible = False
        '
        'lbl_Correcta2
        '
        Me.lbl_Correcta2.AutoSize = True
        Me.lbl_Correcta2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Correcta2.ForeColor = System.Drawing.Color.Green
        Me.lbl_Correcta2.Location = New System.Drawing.Point(227, 110)
        Me.lbl_Correcta2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_Correcta2.Name = "lbl_Correcta2"
        Me.lbl_Correcta2.Size = New System.Drawing.Size(41, 31)
        Me.lbl_Correcta2.TabIndex = 11
        Me.lbl_Correcta2.Text = "✔"
        Me.lbl_Correcta2.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(35, 151)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(144, 24)
        Me.RadioButton4.TabIndex = 6
        Me.RadioButton4.Text = "CULTURA WARI"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(35, 117)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(175, 24)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.Text = "CULTURA PARACAS"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.CausesValidation = False
        Me.RadioButton6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(35, 81)
        Me.RadioButton6.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(178, 24)
        Me.RadioButton6.TabIndex = 4
        Me.RadioButton6.Text = "CULTURA MOCHICA"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lbl_Incorrecta)
        Me.Panel1.Controls.Add(Me.lbl_Correcta)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(120, 370)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 222)
        Me.Panel1.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 39)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "siguiente imagen?"
        '
        'lbl_Incorrecta
        '
        Me.lbl_Incorrecta.AutoSize = True
        Me.lbl_Incorrecta.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Incorrecta.ForeColor = System.Drawing.Color.Red
        Me.lbl_Incorrecta.Location = New System.Drawing.Point(231, 110)
        Me.lbl_Incorrecta.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_Incorrecta.Name = "lbl_Incorrecta"
        Me.lbl_Incorrecta.Size = New System.Drawing.Size(31, 31)
        Me.lbl_Incorrecta.TabIndex = 11
        Me.lbl_Incorrecta.Text = "✘"
        Me.lbl_Incorrecta.Visible = False
        '
        'lbl_Correcta
        '
        Me.lbl_Correcta.AutoSize = True
        Me.lbl_Correcta.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Correcta.ForeColor = System.Drawing.Color.Green
        Me.lbl_Correcta.Location = New System.Drawing.Point(231, 111)
        Me.lbl_Correcta.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_Correcta.Name = "lbl_Correcta"
        Me.lbl_Correcta.Size = New System.Drawing.Size(41, 31)
        Me.lbl_Correcta.TabIndex = 11
        Me.lbl_Correcta.Text = "✔"
        Me.lbl_Correcta.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(35, 151)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.Text = "TIAHUANACO"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(33, 117)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(144, 24)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.Text = "CULTURA WARI"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.CausesValidation = False
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(37, 81)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(163, 24)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.Text = "CULTURA CHAVIN"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "1.-¿A que cultura pertenece la"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(673, 311)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 39)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Ver Imagen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'imagenWari
        '
        Me.imagenWari.Image = CType(resources.GetObject("imagenWari.Image"), System.Drawing.Image)
        Me.imagenWari.Location = New System.Drawing.Point(593, 92)
        Me.imagenWari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imagenWari.Name = "imagenWari"
        Me.imagenWari.Size = New System.Drawing.Size(276, 197)
        Me.imagenWari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagenWari.TabIndex = 49
        Me.imagenWari.TabStop = False
        '
        'imagenChavin
        '
        Me.imagenChavin.Image = CType(resources.GetObject("imagenChavin.Image"), System.Drawing.Image)
        Me.imagenChavin.Location = New System.Drawing.Point(148, 92)
        Me.imagenChavin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imagenChavin.Name = "imagenChavin"
        Me.imagenChavin.Size = New System.Drawing.Size(276, 197)
        Me.imagenChavin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagenChavin.TabIndex = 48
        Me.imagenChavin.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(691, 42)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "APRENDER CULTURA ES DIVERTIDO"
        '
        'btnVerChavin
        '
        Me.btnVerChavin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerChavin.Location = New System.Drawing.Point(200, 311)
        Me.btnVerChavin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVerChavin.Name = "btnVerChavin"
        Me.btnVerChavin.Size = New System.Drawing.Size(153, 39)
        Me.btnVerChavin.TabIndex = 56
        Me.btnVerChavin.Text = "Ver Imagen"
        Me.btnVerChavin.UseVisualStyleBackColor = True
        '
        'btnSiguietne
        '
        Me.btnSiguietne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguietne.Image = CType(resources.GetObject("btnSiguietne.Image"), System.Drawing.Image)
        Me.btnSiguietne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSiguietne.Location = New System.Drawing.Point(593, 613)
        Me.btnSiguietne.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnSiguietne.Name = "btnSiguietne"
        Me.btnSiguietne.Size = New System.Drawing.Size(180, 54)
        Me.btnSiguietne.TabIndex = 57
        Me.btnSiguietne.Text = "Siguiente"
        Me.btnSiguietne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSiguietne.UseVisualStyleBackColor = True
        '
        'pregunta1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1005, 702)
        Me.Controls.Add(Me.btnSiguietne)
        Me.Controls.Add(Me.btnVerChavin)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.imagenWari)
        Me.Controls.Add(Me.imagenChavin)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "pregunta1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pregunta1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imagenWari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenChavin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnValidar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_Incorrecta2 As Label
    Friend WithEvents lbl_Correcta2 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_Incorrecta As Label
    Friend WithEvents lbl_Correcta As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents imagenWari As PictureBox
    Friend WithEvents imagenChavin As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVerChavin As Button
    Friend WithEvents btnSiguietne As Button
End Class
