<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CartaoCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CartaoCredito))
        Me.Lbl_ContaCorrenteCriada = New System.Windows.Forms.Label()
        Me.Grp_ContaCorrente = New System.Windows.Forms.GroupBox()
        Me.DTP_Vencimento = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Vencimento = New System.Windows.Forms.Label()
        Me.Btm_Criar = New System.Windows.Forms.Button()
        Me.Txt_ContaCorrente = New System.Windows.Forms.TextBox()
        Me.Txt_Agencia = New System.Windows.Forms.TextBox()
        Me.Lbl_ContaCorrente = New System.Windows.Forms.Label()
        Me.Lbl_Agencia = New System.Windows.Forms.Label()
        Me.Pic_Logo = New System.Windows.Forms.PictureBox()
        Me.Lbl_Mensagem = New System.Windows.Forms.Label()
        Me.Lbl_Mensagem2 = New System.Windows.Forms.Label()
        Me.Grp_ContaCorrente.SuspendLayout()
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_ContaCorrenteCriada
        '
        Me.Lbl_ContaCorrenteCriada.AutoSize = True
        Me.Lbl_ContaCorrenteCriada.Location = New System.Drawing.Point(12, 207)
        Me.Lbl_ContaCorrenteCriada.Name = "Lbl_ContaCorrenteCriada"
        Me.Lbl_ContaCorrenteCriada.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ContaCorrenteCriada.TabIndex = 5
        Me.Lbl_ContaCorrenteCriada.Text = "Label1"
        '
        'Grp_ContaCorrente
        '
        Me.Grp_ContaCorrente.Controls.Add(Me.DTP_Vencimento)
        Me.Grp_ContaCorrente.Controls.Add(Me.Lbl_Vencimento)
        Me.Grp_ContaCorrente.Controls.Add(Me.Btm_Criar)
        Me.Grp_ContaCorrente.Controls.Add(Me.Txt_ContaCorrente)
        Me.Grp_ContaCorrente.Controls.Add(Me.Txt_Agencia)
        Me.Grp_ContaCorrente.Controls.Add(Me.Lbl_ContaCorrente)
        Me.Grp_ContaCorrente.Controls.Add(Me.Lbl_Agencia)
        Me.Grp_ContaCorrente.Location = New System.Drawing.Point(84, 12)
        Me.Grp_ContaCorrente.Name = "Grp_ContaCorrente"
        Me.Grp_ContaCorrente.Size = New System.Drawing.Size(256, 186)
        Me.Grp_ContaCorrente.TabIndex = 4
        Me.Grp_ContaCorrente.TabStop = False
        Me.Grp_ContaCorrente.Text = "GroupBox1"
        '
        'DTP_Vencimento
        '
        Me.DTP_Vencimento.Location = New System.Drawing.Point(9, 145)
        Me.DTP_Vencimento.Name = "DTP_Vencimento"
        Me.DTP_Vencimento.Size = New System.Drawing.Size(241, 20)
        Me.DTP_Vencimento.TabIndex = 6
        '
        'Lbl_Vencimento
        '
        Me.Lbl_Vencimento.AutoSize = True
        Me.Lbl_Vencimento.Location = New System.Drawing.Point(6, 123)
        Me.Lbl_Vencimento.Name = "Lbl_Vencimento"
        Me.Lbl_Vencimento.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Vencimento.TabIndex = 5
        Me.Lbl_Vencimento.Text = "Label2"
        '
        'Btm_Criar
        '
        Me.Btm_Criar.Location = New System.Drawing.Point(119, 19)
        Me.Btm_Criar.Name = "Btm_Criar"
        Me.Btm_Criar.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Criar.TabIndex = 4
        Me.Btm_Criar.Text = "Button1"
        Me.Btm_Criar.UseVisualStyleBackColor = True
        '
        'Txt_ContaCorrente
        '
        Me.Txt_ContaCorrente.Location = New System.Drawing.Point(9, 91)
        Me.Txt_ContaCorrente.Name = "Txt_ContaCorrente"
        Me.Txt_ContaCorrente.Size = New System.Drawing.Size(100, 20)
        Me.Txt_ContaCorrente.TabIndex = 3
        '
        'Txt_Agencia
        '
        Me.Txt_Agencia.Location = New System.Drawing.Point(9, 46)
        Me.Txt_Agencia.Name = "Txt_Agencia"
        Me.Txt_Agencia.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Agencia.TabIndex = 2
        '
        'Lbl_ContaCorrente
        '
        Me.Lbl_ContaCorrente.AutoSize = True
        Me.Lbl_ContaCorrente.Location = New System.Drawing.Point(6, 75)
        Me.Lbl_ContaCorrente.Name = "Lbl_ContaCorrente"
        Me.Lbl_ContaCorrente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ContaCorrente.TabIndex = 1
        Me.Lbl_ContaCorrente.Text = "Label2"
        '
        'Lbl_Agencia
        '
        Me.Lbl_Agencia.AutoSize = True
        Me.Lbl_Agencia.Location = New System.Drawing.Point(6, 32)
        Me.Lbl_Agencia.Name = "Lbl_Agencia"
        Me.Lbl_Agencia.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Agencia.TabIndex = 0
        Me.Lbl_Agencia.Text = "Label1"
        '
        'Pic_Logo
        '
        Me.Pic_Logo.Image = CType(resources.GetObject("Pic_Logo.Image"), System.Drawing.Image)
        Me.Pic_Logo.Location = New System.Drawing.Point(12, 12)
        Me.Pic_Logo.Name = "Pic_Logo"
        Me.Pic_Logo.Size = New System.Drawing.Size(66, 66)
        Me.Pic_Logo.TabIndex = 3
        Me.Pic_Logo.TabStop = False
        '
        'Lbl_Mensagem
        '
        Me.Lbl_Mensagem.AutoSize = True
        Me.Lbl_Mensagem.Location = New System.Drawing.Point(12, 235)
        Me.Lbl_Mensagem.Name = "Lbl_Mensagem"
        Me.Lbl_Mensagem.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Mensagem.TabIndex = 6
        Me.Lbl_Mensagem.Text = "Label1"
        '
        'Lbl_Mensagem2
        '
        Me.Lbl_Mensagem2.AutoSize = True
        Me.Lbl_Mensagem2.Location = New System.Drawing.Point(12, 264)
        Me.Lbl_Mensagem2.Name = "Lbl_Mensagem2"
        Me.Lbl_Mensagem2.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Mensagem2.TabIndex = 7
        Me.Lbl_Mensagem2.Text = "Label1"
        '
        'Frm_CartaoCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 300)
        Me.Controls.Add(Me.Lbl_Mensagem2)
        Me.Controls.Add(Me.Lbl_Mensagem)
        Me.Controls.Add(Me.Lbl_ContaCorrenteCriada)
        Me.Controls.Add(Me.Grp_ContaCorrente)
        Me.Controls.Add(Me.Pic_Logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_CartaoCredito"
        Me.Text = "Frm_CartaoCredito"
        Me.Grp_ContaCorrente.ResumeLayout(False)
        Me.Grp_ContaCorrente.PerformLayout()
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_ContaCorrenteCriada As Label
    Friend WithEvents Grp_ContaCorrente As GroupBox
    Friend WithEvents Btm_Criar As Button
    Friend WithEvents Txt_ContaCorrente As TextBox
    Friend WithEvents Txt_Agencia As TextBox
    Friend WithEvents Lbl_ContaCorrente As Label
    Friend WithEvents Lbl_Agencia As Label
    Friend WithEvents Pic_Logo As PictureBox
    Friend WithEvents Lbl_Vencimento As Label
    Friend WithEvents DTP_Vencimento As DateTimePicker
    Friend WithEvents Lbl_Mensagem As Label
    Friend WithEvents Lbl_Mensagem2 As Label
End Class
