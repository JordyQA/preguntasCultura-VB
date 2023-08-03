<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pregunta10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pregunta10))
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Incorrecta2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.btnVerChavin = New System.Windows.Forms.Button()
        Me.imagenWari = New System.Windows.Forms.PictureBox()
        Me.imagenChavin = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.btnValidar.Location = New System.Drawing.Point(268, 497)
        Me.btnValidar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(104, 44)
        Me.btnValidar.TabIndex = 63
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lbl_Incorrecta2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lbl_Correcta2)
        Me.Panel2.Controls.Add(Me.RadioButton4)
        Me.Panel2.Controls.Add(Me.RadioButton5)
        Me.Panel2.Controls.Add(Me.RadioButton6)
        Me.Panel2.Location = New System.Drawing.Point(462, 300)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 180)
        Me.Panel2.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "el lugar de la imagen?"
        '
        'lbl_Incorrecta2
        '
        Me.lbl_Incorrecta2.AutoSize = True
        Me.lbl_Incorrecta2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Incorrecta2.ForeColor = System.Drawing.Color.Red
        Me.lbl_Incorrecta2.Location = New System.Drawing.Point(170, 95)
        Me.lbl_Incorrecta2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Incorrecta2.Name = "lbl_Incorrecta2"
        Me.lbl_Incorrecta2.Size = New System.Drawing.Size(29, 26)
        Me.lbl_Incorrecta2.TabIndex = 11
        Me.lbl_Incorrecta2.Text = "✘"
        Me.lbl_Incorrecta2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 14)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "20.-¿Donde se encuentra ubicado"
        '
        'lbl_Correcta2
        '
        Me.lbl_Correcta2.AutoSize = True
        Me.lbl_Correcta2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Correcta2.ForeColor = System.Drawing.Color.Green
        Me.lbl_Correcta2.Location = New System.Drawing.Point(170, 89)
        Me.lbl_Correcta2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Correcta2.Name = "lbl_Correcta2"
        Me.lbl_Correcta2.Size = New System.Drawing.Size(39, 26)
        Me.lbl_Correcta2.TabIndex = 11
        Me.lbl_Correcta2.Text = "✔"
        Me.lbl_Correcta2.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(26, 123)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(68, 21)
        Me.RadioButton4.TabIndex = 6
        Me.RadioButton4.Text = "CUZCO"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(26, 95)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(90, 21)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.Text = "APURIMAC"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.CausesValidation = False
        Me.RadioButton6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(26, 66)
        Me.RadioButton6.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(83, 21)
        Me.RadioButton6.TabIndex = 4
        Me.RadioButton6.Text = "ABANCAY"
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
        Me.Panel1.Location = New System.Drawing.Point(119, 300)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 180)
        Me.Panel1.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "el lugar de la imagen?"
        '
        'lbl_Incorrecta
        '
        Me.lbl_Incorrecta.AutoSize = True
        Me.lbl_Incorrecta.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Incorrecta.ForeColor = System.Drawing.Color.Red
        Me.lbl_Incorrecta.Location = New System.Drawing.Point(177, 95)
        Me.lbl_Incorrecta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Incorrecta.Name = "lbl_Incorrecta"
        Me.lbl_Incorrecta.Size = New System.Drawing.Size(29, 26)
        Me.lbl_Incorrecta.TabIndex = 11
        Me.lbl_Incorrecta.Text = "✘"
        Me.lbl_Incorrecta.Visible = False
        '
        'lbl_Correcta
        '
        Me.lbl_Correcta.AutoSize = True
        Me.lbl_Correcta.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Correcta.ForeColor = System.Drawing.Color.Green
        Me.lbl_Correcta.Location = New System.Drawing.Point(173, 90)
        Me.lbl_Correcta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Correcta.Name = "lbl_Correcta"
        Me.lbl_Correcta.Size = New System.Drawing.Size(39, 26)
        Me.lbl_Correcta.TabIndex = 11
        Me.lbl_Correcta.Text = "✔"
        Me.lbl_Correcta.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(26, 123)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(56, 21)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.Text = "LIMA"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(25, 95)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(87, 21)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.Text = "AREQUIPA"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.CausesValidation = False
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(28, 66)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(68, 21)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.Text = "CUZCO"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "19.-¿Donde se encuentra ubicado"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(552, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Ver Imagen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnVerChavin
        '
        Me.btnVerChavin.Location = New System.Drawing.Point(186, 270)
        Me.btnVerChavin.Name = "btnVerChavin"
        Me.btnVerChavin.Size = New System.Drawing.Size(75, 23)
        Me.btnVerChavin.TabIndex = 59
        Me.btnVerChavin.Text = "Ver Imagen"
        Me.btnVerChavin.UseVisualStyleBackColor = True
        '
        'imagenWari
        '
        Me.imagenWari.Image = CType(resources.GetObject("imagenWari.Image"), System.Drawing.Image)
        Me.imagenWari.Location = New System.Drawing.Point(474, 74)
        Me.imagenWari.Name = "imagenWari"
        Me.imagenWari.Size = New System.Drawing.Size(207, 160)
        Me.imagenWari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagenWari.TabIndex = 58
        Me.imagenWari.TabStop = False
        '
        'imagenChavin
        '
        Me.imagenChavin.Image = CType(resources.GetObject("imagenChavin.Image"), System.Drawing.Image)
        Me.imagenChavin.Location = New System.Drawing.Point(140, 74)
        Me.imagenChavin.Name = "imagenChavin"
        Me.imagenChavin.Size = New System.Drawing.Size(207, 160)
        Me.imagenChavin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagenChavin.TabIndex = 57
        Me.imagenChavin.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(528, 32)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "APRENDER CULTURA ES DIVERTIDO"
        '
        'btnSiguietne
        '
        Me.btnSiguietne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguietne.Image = CType(resources.GetObject("btnSiguietne.Image"), System.Drawing.Image)
        Me.btnSiguietne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSiguietne.Location = New System.Drawing.Point(502, 497)
        Me.btnSiguietne.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSiguietne.Name = "btnSiguietne"
        Me.btnSiguietne.Size = New System.Drawing.Size(135, 44)
        Me.btnSiguietne.TabIndex = 64
        Me.btnSiguietne.Text = "Siguiente"
        Me.btnSiguietne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSiguietne.UseVisualStyleBackColor = True
        '
        'pregunta10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 562)
        Me.Controls.Add(Me.btnSiguietne)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnVerChavin)
        Me.Controls.Add(Me.imagenWari)
        Me.Controls.Add(Me.imagenChavin)
        Me.Controls.Add(Me.Label2)
        Me.Name = "pregunta10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pregunta10"
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
    Friend WithEvents btnVerChavin As Button
    Friend WithEvents imagenWari As PictureBox
    Friend WithEvents imagenChavin As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSiguietne As Button
End Class
