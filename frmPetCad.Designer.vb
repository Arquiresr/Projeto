<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPetCad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPetCad))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRegPet = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.txtRaca = New System.Windows.Forms.TextBox()
        Me.txtNomePet = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(138, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'btnRegPet
        '
        Me.btnRegPet.BackColor = System.Drawing.Color.Transparent
        Me.btnRegPet.BackgroundImage = CType(resources.GetObject("btnRegPet.BackgroundImage"), System.Drawing.Image)
        Me.btnRegPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRegPet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegPet.FlatAppearance.BorderSize = 0
        Me.btnRegPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegPet.Image = CType(resources.GetObject("btnRegPet.Image"), System.Drawing.Image)
        Me.btnRegPet.Location = New System.Drawing.Point(97, 335)
        Me.btnRegPet.Name = "btnRegPet"
        Me.btnRegPet.Size = New System.Drawing.Size(191, 66)
        Me.btnRegPet.TabIndex = 18
        Me.btnRegPet.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(73, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Idade:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(80, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Raça:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(73, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nome:"
        '
        'txtIdade
        '
        Me.txtIdade.Location = New System.Drawing.Point(137, 260)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(173, 20)
        Me.txtIdade.TabIndex = 14
        '
        'txtRaca
        '
        Me.txtRaca.Location = New System.Drawing.Point(137, 219)
        Me.txtRaca.Name = "txtRaca"
        Me.txtRaca.Size = New System.Drawing.Size(173, 20)
        Me.txtRaca.TabIndex = 12
        '
        'txtNomePet
        '
        Me.txtNomePet.Location = New System.Drawing.Point(137, 132)
        Me.txtNomePet.Name = "txtNomePet"
        Me.txtNomePet.Size = New System.Drawing.Size(173, 20)
        Me.txtNomePet.TabIndex = 10
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(137, 174)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(173, 20)
        Me.txtID.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(64, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ID Pet:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(77, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Peso:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(137, 298)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(173, 20)
        Me.txtPeso.TabIndex = 20
        '
        'frmPetCad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(393, 407)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRegPet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdade)
        Me.Controls.Add(Me.txtRaca)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtNomePet)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPetCad"
        Me.Text = "Cadastro de Pet"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRegPet As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdade As System.Windows.Forms.TextBox
    Friend WithEvents txtRaca As System.Windows.Forms.TextBox
    Friend WithEvents txtNomePet As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
End Class
