<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal3
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
        Me.Lbl_Principal3 = New System.Windows.Forms.Label()
        Me.Btm_Principal3 = New System.Windows.Forms.Button()
        Me.Btm_Principal03a = New System.Windows.Forms.Button()
        Me.Btm_Principal03b = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal3
        '
        Me.Lbl_Principal3.AutoSize = True
        Me.Lbl_Principal3.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Principal3.Name = "Lbl_Principal3"
        Me.Lbl_Principal3.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal3.TabIndex = 0
        Me.Lbl_Principal3.Text = "Label1"
        '
        'Btm_Principal3
        '
        Me.Btm_Principal3.Location = New System.Drawing.Point(15, 46)
        Me.Btm_Principal3.Name = "Btm_Principal3"
        Me.Btm_Principal3.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Principal3.TabIndex = 1
        Me.Btm_Principal3.Text = "Button1"
        Me.Btm_Principal3.UseVisualStyleBackColor = True
        '
        'Btm_Principal03a
        '
        Me.Btm_Principal03a.Location = New System.Drawing.Point(15, 88)
        Me.Btm_Principal03a.Name = "Btm_Principal03a"
        Me.Btm_Principal03a.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Principal03a.TabIndex = 2
        Me.Btm_Principal03a.Text = "Button1"
        Me.Btm_Principal03a.UseVisualStyleBackColor = True
        '
        'Btm_Principal03b
        '
        Me.Btm_Principal03b.Location = New System.Drawing.Point(15, 134)
        Me.Btm_Principal03b.Name = "Btm_Principal03b"
        Me.Btm_Principal03b.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Principal03b.TabIndex = 3
        Me.Btm_Principal03b.Text = "Button1"
        Me.Btm_Principal03b.UseVisualStyleBackColor = True
        '
        'Frm_Principal3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 214)
        Me.Controls.Add(Me.Btm_Principal03b)
        Me.Controls.Add(Me.Btm_Principal03a)
        Me.Controls.Add(Me.Btm_Principal3)
        Me.Controls.Add(Me.Lbl_Principal3)
        Me.Name = "Frm_Principal3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Principal3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal3 As Label
    Friend WithEvents Btm_Principal3 As Button
    Friend WithEvents Btm_Principal03a As Button
    Friend WithEvents Btm_Principal03b As Button
End Class
