<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtPATHARQUIVO = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gbopcoes = New System.Windows.Forms.GroupBox()
        Me.cbDuplicados = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbSalvar = New System.Windows.Forms.CheckBox()
        Me.cbADDCODIGO55 = New System.Windows.Forms.CheckBox()
        Me.cbREMOVERCARACTERES = New System.Windows.Forms.CheckBox()
        Me.cbREMOVERCONTATOSSEMTELEFONE = New System.Windows.Forms.CheckBox()
        Me.cbAPAGARCOLUNAS = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmissãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerarPropostaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbopcoes.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.SplitContainer1)
        Me.GroupBox2.Location = New System.Drawing.Point(221, 9)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(923, 71)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Arquivo"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(8, 20)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPATHARQUIVO)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Size = New System.Drawing.Size(906, 42)
        Me.SplitContainer1.SplitterDistance = 742
        Me.SplitContainer1.TabIndex = 5
        '
        'txtPATHARQUIVO
        '
        Me.txtPATHARQUIVO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPATHARQUIVO.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.txtPATHARQUIVO.Location = New System.Drawing.Point(4, 4)
        Me.txtPATHARQUIVO.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPATHARQUIVO.Name = "txtPATHARQUIVO"
        Me.txtPATHARQUIVO.Size = New System.Drawing.Size(736, 29)
        Me.txtPATHARQUIVO.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(4, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Procurar Arquivo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(769, 436)
        Me.DataGridView1.TabIndex = 3
        '
        'gbopcoes
        '
        Me.gbopcoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbopcoes.Controls.Add(Me.cbDuplicados)
        Me.gbopcoes.Controls.Add(Me.Button4)
        Me.gbopcoes.Controls.Add(Me.Button3)
        Me.gbopcoes.Controls.Add(Me.cbSalvar)
        Me.gbopcoes.Controls.Add(Me.cbADDCODIGO55)
        Me.gbopcoes.Controls.Add(Me.cbREMOVERCARACTERES)
        Me.gbopcoes.Controls.Add(Me.cbREMOVERCONTATOSSEMTELEFONE)
        Me.gbopcoes.Controls.Add(Me.cbAPAGARCOLUNAS)
        Me.gbopcoes.Controls.Add(Me.Button2)
        Me.gbopcoes.Enabled = False
        Me.gbopcoes.Location = New System.Drawing.Point(791, 92)
        Me.gbopcoes.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.gbopcoes.Name = "gbopcoes"
        Me.gbopcoes.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.gbopcoes.Size = New System.Drawing.Size(351, 436)
        Me.gbopcoes.TabIndex = 4
        Me.gbopcoes.TabStop = False
        Me.gbopcoes.Text = "Opções"
        '
        'cbDuplicados
        '
        Me.cbDuplicados.Checked = True
        Me.cbDuplicados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDuplicados.Location = New System.Drawing.Point(8, 145)
        Me.cbDuplicados.Name = "cbDuplicados"
        Me.cbDuplicados.Size = New System.Drawing.Size(334, 23)
        Me.cbDuplicados.TabIndex = 10
        Me.cbDuplicados.Text = "Remover Duplicados"
        Me.cbDuplicados.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(9, 378)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(333, 48)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Limpar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 300)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(333, 48)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Salvar CSV"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cbSalvar
        '
        Me.cbSalvar.Checked = True
        Me.cbSalvar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSalvar.Location = New System.Drawing.Point(8, 196)
        Me.cbSalvar.Name = "cbSalvar"
        Me.cbSalvar.Size = New System.Drawing.Size(334, 23)
        Me.cbSalvar.TabIndex = 7
        Me.cbSalvar.Text = "Salvar após processar"
        Me.cbSalvar.UseVisualStyleBackColor = True
        '
        'cbADDCODIGO55
        '
        Me.cbADDCODIGO55.Checked = True
        Me.cbADDCODIGO55.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbADDCODIGO55.Location = New System.Drawing.Point(9, 116)
        Me.cbADDCODIGO55.Name = "cbADDCODIGO55"
        Me.cbADDCODIGO55.Size = New System.Drawing.Size(334, 23)
        Me.cbADDCODIGO55.TabIndex = 6
        Me.cbADDCODIGO55.Text = "Adicionar Código 55 no telefone"
        Me.cbADDCODIGO55.UseVisualStyleBackColor = True
        '
        'cbREMOVERCARACTERES
        '
        Me.cbREMOVERCARACTERES.Checked = True
        Me.cbREMOVERCARACTERES.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbREMOVERCARACTERES.Location = New System.Drawing.Point(9, 87)
        Me.cbREMOVERCARACTERES.Name = "cbREMOVERCARACTERES"
        Me.cbREMOVERCARACTERES.Size = New System.Drawing.Size(334, 23)
        Me.cbREMOVERCARACTERES.TabIndex = 5
        Me.cbREMOVERCARACTERES.Text = "Remover Caracteres do Telefone"
        Me.cbREMOVERCARACTERES.UseVisualStyleBackColor = True
        '
        'cbREMOVERCONTATOSSEMTELEFONE
        '
        Me.cbREMOVERCONTATOSSEMTELEFONE.Checked = True
        Me.cbREMOVERCONTATOSSEMTELEFONE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbREMOVERCONTATOSSEMTELEFONE.Location = New System.Drawing.Point(9, 58)
        Me.cbREMOVERCONTATOSSEMTELEFONE.Name = "cbREMOVERCONTATOSSEMTELEFONE"
        Me.cbREMOVERCONTATOSSEMTELEFONE.Size = New System.Drawing.Size(334, 23)
        Me.cbREMOVERCONTATOSSEMTELEFONE.TabIndex = 4
        Me.cbREMOVERCONTATOSSEMTELEFONE.Text = "Remover Contatos sem Telefone"
        Me.cbREMOVERCONTATOSSEMTELEFONE.UseVisualStyleBackColor = True
        '
        'cbAPAGARCOLUNAS
        '
        Me.cbAPAGARCOLUNAS.Checked = True
        Me.cbAPAGARCOLUNAS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAPAGARCOLUNAS.Location = New System.Drawing.Point(9, 29)
        Me.cbAPAGARCOLUNAS.Name = "cbAPAGARCOLUNAS"
        Me.cbAPAGARCOLUNAS.Size = New System.Drawing.Size(334, 23)
        Me.cbAPAGARCOLUNAS.TabIndex = 3
        Me.cbAPAGARCOLUNAS.Text = "Apagar outras Colunas"
        Me.cbAPAGARCOLUNAS.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 226)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(333, 66)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Processar Dados"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpçõesToolStripMenuItem, Me.EmissãoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1150, 27)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'OpçõesToolStripMenuItem
        '
        Me.OpçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.OpçõesToolStripMenuItem.Image = CType(resources.GetObject("OpçõesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpçõesToolStripMenuItem.Name = "OpçõesToolStripMenuItem"
        Me.OpçõesToolStripMenuItem.Size = New System.Drawing.Size(86, 23)
        Me.OpçõesToolStripMenuItem.Text = "Opções"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'EmissãoToolStripMenuItem
        '
        Me.EmissãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerarPropostaToolStripMenuItem})
        Me.EmissãoToolStripMenuItem.Image = CType(resources.GetObject("EmissãoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmissãoToolStripMenuItem.Name = "EmissãoToolStripMenuItem"
        Me.EmissãoToolStripMenuItem.Size = New System.Drawing.Size(91, 23)
        Me.EmissãoToolStripMenuItem.Text = "Emissão"
        '
        'GerarPropostaToolStripMenuItem
        '
        Me.GerarPropostaToolStripMenuItem.Image = CType(resources.GetObject("GerarPropostaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerarPropostaToolStripMenuItem.Name = "GerarPropostaToolStripMenuItem"
        Me.GerarPropostaToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.GerarPropostaToolStripMenuItem.Text = "Gerar Proposta"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1150, 540)
        Me.Controls.Add(Me.gbopcoes)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbopcoes.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPATHARQUIVO As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents gbopcoes As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents cbADDCODIGO55 As CheckBox
    Friend WithEvents cbREMOVERCARACTERES As CheckBox
    Friend WithEvents cbREMOVERCONTATOSSEMTELEFONE As CheckBox
    Friend WithEvents cbAPAGARCOLUNAS As CheckBox
    Friend WithEvents cbSalvar As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents cbDuplicados As CheckBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmissãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerarPropostaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
