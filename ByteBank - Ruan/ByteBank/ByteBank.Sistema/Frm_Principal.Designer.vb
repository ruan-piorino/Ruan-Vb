<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.Btm_Principal = New System.Windows.Forms.Button()
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Lbl_URL = New System.Windows.Forms.Label()
        Me.Txt_URL = New System.Windows.Forms.TextBox()
        Me.Btm_Principal2 = New System.Windows.Forms.Button()
        Me.Txt_Separador = New System.Windows.Forms.TextBox()
        Me.Lbl_Separador = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(15, 122)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(133, 34)
        Me.Btm_Principal.TabIndex = 0
        Me.Btm_Principal.Text = "Button1"
        Me.Btm_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 21)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 1
        Me.Lbl_Principal.Text = "Label1"
        '
        'Lbl_URL
        '
        Me.Lbl_URL.AutoSize = True
        Me.Lbl_URL.Location = New System.Drawing.Point(12, 61)
        Me.Lbl_URL.Name = "Lbl_URL"
        Me.Lbl_URL.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_URL.TabIndex = 2
        Me.Lbl_URL.Text = "Label1"
        '
        'Txt_URL
        '
        Me.Txt_URL.Location = New System.Drawing.Point(93, 58)
        Me.Txt_URL.Name = "Txt_URL"
        Me.Txt_URL.Size = New System.Drawing.Size(398, 20)
        Me.Txt_URL.TabIndex = 4
        '
        'Btm_Principal2
        '
        Me.Btm_Principal2.Location = New System.Drawing.Point(176, 122)
        Me.Btm_Principal2.Name = "Btm_Principal2"
        Me.Btm_Principal2.Size = New System.Drawing.Size(133, 34)
        Me.Btm_Principal2.TabIndex = 6
        Me.Btm_Principal2.Text = "Button1"
        Me.Btm_Principal2.UseVisualStyleBackColor = True
        '
        'Txt_Separador
        '
        Me.Txt_Separador.Location = New System.Drawing.Point(93, 82)
        Me.Txt_Separador.Name = "Txt_Separador"
        Me.Txt_Separador.Size = New System.Drawing.Size(55, 20)
        Me.Txt_Separador.TabIndex = 5
        '
        'Lbl_Separador
        '
        Me.Lbl_Separador.AutoSize = True
        Me.Lbl_Separador.Location = New System.Drawing.Point(12, 85)
        Me.Lbl_Separador.Name = "Lbl_Separador"
        Me.Lbl_Separador.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Separador.TabIndex = 3
        Me.Lbl_Separador.Text = "Label2"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 184)
        Me.Controls.Add(Me.Btm_Principal2)
        Me.Controls.Add(Me.Txt_Separador)
        Me.Controls.Add(Me.Txt_URL)
        Me.Controls.Add(Me.Lbl_Separador)
        Me.Controls.Add(Me.Lbl_URL)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Lbl_URL As Label
    Friend WithEvents Txt_URL As TextBox
    Friend WithEvents Btm_Principal2 As Button
    Friend WithEvents Txt_Separador As TextBox
    Friend WithEvents Lbl_Separador As Label
End Class
