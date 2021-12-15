<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal2
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
        Me.Lbl_Principal2 = New System.Windows.Forms.Label()
        Me.Txt_URL = New System.Windows.Forms.TextBox()
        Me.Lbl_URL = New System.Windows.Forms.Label()
        Me.Lbl_Argumento = New System.Windows.Forms.Label()
        Me.Txt_Argumento = New System.Windows.Forms.TextBox()
        Me.Btm_Processa = New System.Windows.Forms.Button()
        Me.Lbl_Propriedade = New System.Windows.Forms.Label()
        Me.Txt_Propriedade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lbl_Principal2
        '
        Me.Lbl_Principal2.AutoSize = True
        Me.Lbl_Principal2.Location = New System.Drawing.Point(12, 21)
        Me.Lbl_Principal2.Name = "Lbl_Principal2"
        Me.Lbl_Principal2.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal2.TabIndex = 0
        Me.Lbl_Principal2.Text = "Label1"
        '
        'Txt_URL
        '
        Me.Txt_URL.Location = New System.Drawing.Point(16, 60)
        Me.Txt_URL.Multiline = True
        Me.Txt_URL.Name = "Txt_URL"
        Me.Txt_URL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_URL.Size = New System.Drawing.Size(645, 126)
        Me.Txt_URL.TabIndex = 6
        '
        'Lbl_URL
        '
        Me.Lbl_URL.AutoSize = True
        Me.Lbl_URL.Location = New System.Drawing.Point(13, 44)
        Me.Lbl_URL.Name = "Lbl_URL"
        Me.Lbl_URL.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_URL.TabIndex = 5
        Me.Lbl_URL.Text = "Label1"
        '
        'Lbl_Argumento
        '
        Me.Lbl_Argumento.AutoSize = True
        Me.Lbl_Argumento.Location = New System.Drawing.Point(13, 202)
        Me.Lbl_Argumento.Name = "Lbl_Argumento"
        Me.Lbl_Argumento.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Argumento.TabIndex = 7
        Me.Lbl_Argumento.Text = "Label1"
        '
        'Txt_Argumento
        '
        Me.Txt_Argumento.Location = New System.Drawing.Point(16, 221)
        Me.Txt_Argumento.Multiline = True
        Me.Txt_Argumento.Name = "Txt_Argumento"
        Me.Txt_Argumento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Argumento.Size = New System.Drawing.Size(645, 90)
        Me.Txt_Argumento.TabIndex = 8
        '
        'Btm_Processa
        '
        Me.Btm_Processa.Location = New System.Drawing.Point(480, 192)
        Me.Btm_Processa.Name = "Btm_Processa"
        Me.Btm_Processa.Size = New System.Drawing.Size(181, 23)
        Me.Btm_Processa.TabIndex = 9
        Me.Btm_Processa.Text = "Button1"
        Me.Btm_Processa.UseVisualStyleBackColor = True
        '
        'Lbl_Propriedade
        '
        Me.Lbl_Propriedade.AutoSize = True
        Me.Lbl_Propriedade.Location = New System.Drawing.Point(13, 323)
        Me.Lbl_Propriedade.Name = "Lbl_Propriedade"
        Me.Lbl_Propriedade.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Propriedade.TabIndex = 10
        Me.Lbl_Propriedade.Text = "Label1"
        '
        'Txt_Propriedade
        '
        Me.Txt_Propriedade.Location = New System.Drawing.Point(16, 339)
        Me.Txt_Propriedade.Name = "Txt_Propriedade"
        Me.Txt_Propriedade.Size = New System.Drawing.Size(554, 20)
        Me.Txt_Propriedade.TabIndex = 11
        '
        'Frm_Principal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 377)
        Me.Controls.Add(Me.Txt_Propriedade)
        Me.Controls.Add(Me.Lbl_Propriedade)
        Me.Controls.Add(Me.Btm_Processa)
        Me.Controls.Add(Me.Txt_Argumento)
        Me.Controls.Add(Me.Lbl_Argumento)
        Me.Controls.Add(Me.Txt_URL)
        Me.Controls.Add(Me.Lbl_URL)
        Me.Controls.Add(Me.Lbl_Principal2)
        Me.Name = "Frm_Principal2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Principal2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal2 As Label
    Friend WithEvents Txt_URL As TextBox
    Friend WithEvents Lbl_URL As Label
    Friend WithEvents Lbl_Argumento As Label
    Friend WithEvents Txt_Argumento As TextBox
    Friend WithEvents Btm_Processa As Button
    Friend WithEvents Lbl_Propriedade As Label
    Friend WithEvents Txt_Propriedade As TextBox
End Class
