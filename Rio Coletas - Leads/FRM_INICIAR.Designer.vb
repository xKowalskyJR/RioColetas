<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_INICIAR
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_INICIAR))
        Me.btnSAIR = New System.Windows.Forms.Button()
        Me.btnTABELAS = New System.Windows.Forms.Button()
        Me.btnPROPOSTA = New System.Windows.Forms.Button()
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbDIA = New System.Windows.Forms.PictureBox()
        Me.lblbomdia = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPÇÕESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizadorDeTabelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmissorDePropostaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmissorDeContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCONTRATO = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbDIA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSAIR
        '
        Me.btnSAIR.BackColor = System.Drawing.Color.DarkGray
        Me.btnSAIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSAIR.Font = New System.Drawing.Font("Footlight MT Light", 15.0!)
        Me.btnSAIR.Location = New System.Drawing.Point(60, 385)
        Me.btnSAIR.Name = "btnSAIR"
        Me.btnSAIR.Size = New System.Drawing.Size(258, 43)
        Me.btnSAIR.TabIndex = 13
        Me.btnSAIR.Text = "F4 - Sair"
        Me.btnSAIR.UseVisualStyleBackColor = False
        '
        'btnTABELAS
        '
        Me.btnTABELAS.BackColor = System.Drawing.Color.DarkGray
        Me.btnTABELAS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTABELAS.Font = New System.Drawing.Font("Footlight MT Light", 15.0!)
        Me.btnTABELAS.Location = New System.Drawing.Point(40, 151)
        Me.btnTABELAS.Name = "btnTABELAS"
        Me.btnTABELAS.Size = New System.Drawing.Size(308, 59)
        Me.btnTABELAS.TabIndex = 14
        Me.btnTABELAS.Text = "F1 - Organizador de Tabelas "
        Me.btnTABELAS.UseVisualStyleBackColor = False
        '
        'btnPROPOSTA
        '
        Me.btnPROPOSTA.BackColor = System.Drawing.Color.DarkGray
        Me.btnPROPOSTA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPROPOSTA.Font = New System.Drawing.Font("Footlight MT Light", 15.0!)
        Me.btnPROPOSTA.Location = New System.Drawing.Point(40, 226)
        Me.btnPROPOSTA.Name = "btnPROPOSTA"
        Me.btnPROPOSTA.Size = New System.Drawing.Size(308, 59)
        Me.btnPROPOSTA.TabIndex = 15
        Me.btnPROPOSTA.Text = "F2 - Emissor de Proposta"
        Me.btnPROPOSTA.UseVisualStyleBackColor = False
        '
        'lblinfo
        '
        Me.lblinfo.Font = New System.Drawing.Font("Eras Demi ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfo.ForeColor = System.Drawing.Color.White
        Me.lblinfo.Location = New System.Drawing.Point(3, 312)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(515, 87)
        Me.lblinfo.TabIndex = 16
        Me.lblinfo.Text = "quinta-feira, 11 de abril de 2024" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "14:10:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbDIA)
        Me.Panel1.Controls.Add(Me.lblbomdia)
        Me.Panel1.Controls.Add(Me.lblinfo)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(402, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 419)
        Me.Panel1.TabIndex = 22
        '
        'pbDIA
        '
        Me.pbDIA.Image = Global.Rio_Coletas___Leads.My.Resources.Resources.NOITE
        Me.pbDIA.Location = New System.Drawing.Point(189, 60)
        Me.pbDIA.Name = "pbDIA"
        Me.pbDIA.Size = New System.Drawing.Size(137, 122)
        Me.pbDIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDIA.TabIndex = 19
        Me.pbDIA.TabStop = False
        '
        'lblbomdia
        '
        Me.lblbomdia.Font = New System.Drawing.Font("Freestyle Script", 45.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomdia.ForeColor = System.Drawing.Color.White
        Me.lblbomdia.Location = New System.Drawing.Point(3, 157)
        Me.lblbomdia.Name = "lblbomdia"
        Me.lblbomdia.Size = New System.Drawing.Size(507, 103)
        Me.lblbomdia.TabIndex = 18
        Me.lblbomdia.Text = "Bom Dia!"
        Me.lblbomdia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPÇÕESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.TabStop = True
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'OPÇÕESToolStripMenuItem
        '
        Me.OPÇÕESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganizadorDeTabelasToolStripMenuItem, Me.EmissorDePropostaToolStripMenuItem, Me.EmissorDeContratoToolStripMenuItem, Me.ToolStripSeparator1, Me.SAIRToolStripMenuItem})
        Me.OPÇÕESToolStripMenuItem.Name = "OPÇÕESToolStripMenuItem"
        Me.OPÇÕESToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.OPÇÕESToolStripMenuItem.Text = "Opções"
        '
        'OrganizadorDeTabelasToolStripMenuItem
        '
        Me.OrganizadorDeTabelasToolStripMenuItem.Name = "OrganizadorDeTabelasToolStripMenuItem"
        Me.OrganizadorDeTabelasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.OrganizadorDeTabelasToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.OrganizadorDeTabelasToolStripMenuItem.Text = "Organizador de Tabelas"
        '
        'EmissorDePropostaToolStripMenuItem
        '
        Me.EmissorDePropostaToolStripMenuItem.Name = "EmissorDePropostaToolStripMenuItem"
        Me.EmissorDePropostaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.EmissorDePropostaToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.EmissorDePropostaToolStripMenuItem.Text = "Emissor de Proposta"
        '
        'EmissorDeContratoToolStripMenuItem
        '
        Me.EmissorDeContratoToolStripMenuItem.Name = "EmissorDeContratoToolStripMenuItem"
        Me.EmissorDeContratoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.EmissorDeContratoToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.EmissorDeContratoToolStripMenuItem.Text = "Emissor de Contrato"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(212, 6)
        '
        'SAIRToolStripMenuItem
        '
        Me.SAIRToolStripMenuItem.Name = "SAIRToolStripMenuItem"
        Me.SAIRToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.SAIRToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SAIRToolStripMenuItem.Text = "Sair"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnCONTRATO
        '
        Me.btnCONTRATO.BackColor = System.Drawing.Color.DarkGray
        Me.btnCONTRATO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCONTRATO.Font = New System.Drawing.Font("Footlight MT Light", 15.0!)
        Me.btnCONTRATO.Location = New System.Drawing.Point(40, 302)
        Me.btnCONTRATO.Name = "btnCONTRATO"
        Me.btnCONTRATO.Size = New System.Drawing.Size(308, 59)
        Me.btnCONTRATO.TabIndex = 23
        Me.btnCONTRATO.Text = "F3 - Emissor de Contrato"
        Me.btnCONTRATO.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Location = New System.Drawing.Point(926, -106)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(5, 700)
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Black
        Me.PictureBox6.Location = New System.Drawing.Point(391, 570)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(537, 5)
        Me.PictureBox6.TabIndex = 21
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Black
        Me.PictureBox5.Location = New System.Drawing.Point(391, -5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(535, 10)
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(391, -20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(5, 700)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(-25, -20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(421, 614)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'FRM_INICIAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(931, 443)
        Me.Controls.Add(Me.btnCONTRATO)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPROPOSTA)
        Me.Controls.Add(Me.btnTABELAS)
        Me.Controls.Add(Me.btnSAIR)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_INICIAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rio Coletas - By Mateus Tamanini"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbDIA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSAIR As Button
    Friend WithEvents btnTABELAS As Button
    Friend WithEvents btnPROPOSTA As Button
    Friend WithEvents lblinfo As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnCONTRATO As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPÇÕESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizadorDeTabelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmissorDePropostaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmissorDeContratoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblbomdia As Label
    Friend WithEvents pbDIA As PictureBox
End Class
