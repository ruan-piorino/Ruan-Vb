﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btm_Autentica = New System.Windows.Forms.Button()
        Me.Btm_Autentica2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btm_Autentica
        '
        Me.Btm_Autentica.Location = New System.Drawing.Point(15, 53)
        Me.Btm_Autentica.Name = "Btm_Autentica"
        Me.Btm_Autentica.Size = New System.Drawing.Size(177, 37)
        Me.Btm_Autentica.TabIndex = 1
        Me.Btm_Autentica.Text = "Button1"
        Me.Btm_Autentica.UseVisualStyleBackColor = True
        '
        'Btm_Autentica2
        '
        Me.Btm_Autentica2.Location = New System.Drawing.Point(210, 53)
        Me.Btm_Autentica2.Name = "Btm_Autentica2"
        Me.Btm_Autentica2.Size = New System.Drawing.Size(177, 37)
        Me.Btm_Autentica2.TabIndex = 2
        Me.Btm_Autentica2.Text = "Button1"
        Me.Btm_Autentica2.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btm_Autentica2)
        Me.Controls.Add(Me.Btm_Autentica)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Autentica As Button
    Friend WithEvents Btm_Autentica2 As Button
End Class
