﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Video05
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
        Me.Lbl_Video05 = New System.Windows.Forms.Label()
        Me.Btm_Fechar = New System.Windows.Forms.Button()
        Me.Grp_Movimentacao = New System.Windows.Forms.GroupBox()
        Me.Lbl_Saldo2 = New System.Windows.Forms.Label()
        Me.Btm_Transferir = New System.Windows.Forms.Button()
        Me.Lbl_Saldo = New System.Windows.Forms.Label()
        Me.Btm_Saque = New System.Windows.Forms.Button()
        Me.Txt_Valor = New System.Windows.Forms.TextBox()
        Me.Lbl_Movimentacao = New System.Windows.Forms.Label()
        Me.Lbl_ContaCorrente = New System.Windows.Forms.Label()
        Me.Lbl_ContaCorrente2 = New System.Windows.Forms.Label()
        Me.Btm_Stack = New System.Windows.Forms.Button()
        Me.Txt_Stack = New System.Windows.Forms.TextBox()
        Me.Lbl_SaquesErrados = New System.Windows.Forms.Label()
        Me.Lbl_TransferErrados = New System.Windows.Forms.Label()
        Me.Grp_Movimentacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Video05
        '
        Me.Lbl_Video05.AutoSize = True
        Me.Lbl_Video05.Location = New System.Drawing.Point(33, 9)
        Me.Lbl_Video05.Name = "Lbl_Video05"
        Me.Lbl_Video05.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Video05.TabIndex = 0
        Me.Lbl_Video05.Text = "Label1"
        '
        'Btm_Fechar
        '
        Me.Btm_Fechar.Location = New System.Drawing.Point(349, 4)
        Me.Btm_Fechar.Name = "Btm_Fechar"
        Me.Btm_Fechar.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Fechar.TabIndex = 1
        Me.Btm_Fechar.Text = "Button1"
        Me.Btm_Fechar.UseVisualStyleBackColor = True
        '
        'Grp_Movimentacao
        '
        Me.Grp_Movimentacao.Controls.Add(Me.Lbl_TransferErrados)
        Me.Grp_Movimentacao.Controls.Add(Me.Lbl_SaquesErrados)
        Me.Grp_Movimentacao.Controls.Add(Me.Lbl_Saldo2)
        Me.Grp_Movimentacao.Controls.Add(Me.Btm_Transferir)
        Me.Grp_Movimentacao.Controls.Add(Me.Lbl_Saldo)
        Me.Grp_Movimentacao.Controls.Add(Me.Btm_Saque)
        Me.Grp_Movimentacao.Controls.Add(Me.Txt_Valor)
        Me.Grp_Movimentacao.Controls.Add(Me.Lbl_Movimentacao)
        Me.Grp_Movimentacao.Location = New System.Drawing.Point(27, 61)
        Me.Grp_Movimentacao.Name = "Grp_Movimentacao"
        Me.Grp_Movimentacao.Size = New System.Drawing.Size(297, 145)
        Me.Grp_Movimentacao.TabIndex = 2
        Me.Grp_Movimentacao.TabStop = False
        Me.Grp_Movimentacao.Text = "GroupBox1"
        '
        'Lbl_Saldo2
        '
        Me.Lbl_Saldo2.AutoSize = True
        Me.Lbl_Saldo2.Location = New System.Drawing.Point(151, 93)
        Me.Lbl_Saldo2.Name = "Lbl_Saldo2"
        Me.Lbl_Saldo2.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Saldo2.TabIndex = 5
        Me.Lbl_Saldo2.Text = "Label1"
        '
        'Btm_Transferir
        '
        Me.Btm_Transferir.Location = New System.Drawing.Point(207, 55)
        Me.Btm_Transferir.Name = "Btm_Transferir"
        Me.Btm_Transferir.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Transferir.TabIndex = 4
        Me.Btm_Transferir.Text = "Button1"
        Me.Btm_Transferir.UseVisualStyleBackColor = True
        '
        'Lbl_Saldo
        '
        Me.Lbl_Saldo.AutoSize = True
        Me.Lbl_Saldo.Location = New System.Drawing.Point(6, 93)
        Me.Lbl_Saldo.Name = "Lbl_Saldo"
        Me.Lbl_Saldo.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Saldo.TabIndex = 3
        Me.Lbl_Saldo.Text = "Label1"
        '
        'Btm_Saque
        '
        Me.Btm_Saque.Location = New System.Drawing.Point(115, 55)
        Me.Btm_Saque.Name = "Btm_Saque"
        Me.Btm_Saque.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Saque.TabIndex = 2
        Me.Btm_Saque.Text = "Button1"
        Me.Btm_Saque.UseVisualStyleBackColor = True
        '
        'Txt_Valor
        '
        Me.Txt_Valor.Location = New System.Drawing.Point(9, 58)
        Me.Txt_Valor.Name = "Txt_Valor"
        Me.Txt_Valor.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Valor.TabIndex = 1
        '
        'Lbl_Movimentacao
        '
        Me.Lbl_Movimentacao.AutoSize = True
        Me.Lbl_Movimentacao.Location = New System.Drawing.Point(6, 42)
        Me.Lbl_Movimentacao.Name = "Lbl_Movimentacao"
        Me.Lbl_Movimentacao.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Movimentacao.TabIndex = 0
        Me.Lbl_Movimentacao.Text = "Label1"
        '
        'Lbl_ContaCorrente
        '
        Me.Lbl_ContaCorrente.AutoSize = True
        Me.Lbl_ContaCorrente.Location = New System.Drawing.Point(33, 36)
        Me.Lbl_ContaCorrente.Name = "Lbl_ContaCorrente"
        Me.Lbl_ContaCorrente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ContaCorrente.TabIndex = 3
        Me.Lbl_ContaCorrente.Text = "Label1"
        '
        'Lbl_ContaCorrente2
        '
        Me.Lbl_ContaCorrente2.AutoSize = True
        Me.Lbl_ContaCorrente2.Location = New System.Drawing.Point(255, 36)
        Me.Lbl_ContaCorrente2.Name = "Lbl_ContaCorrente2"
        Me.Lbl_ContaCorrente2.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ContaCorrente2.TabIndex = 4
        Me.Lbl_ContaCorrente2.Text = "Label1"
        '
        'Btm_Stack
        '
        Me.Btm_Stack.Location = New System.Drawing.Point(27, 212)
        Me.Btm_Stack.Name = "Btm_Stack"
        Me.Btm_Stack.Size = New System.Drawing.Size(149, 23)
        Me.Btm_Stack.TabIndex = 5
        Me.Btm_Stack.Text = "Button1"
        Me.Btm_Stack.UseVisualStyleBackColor = True
        '
        'Txt_Stack
        '
        Me.Txt_Stack.Location = New System.Drawing.Point(27, 241)
        Me.Txt_Stack.Multiline = True
        Me.Txt_Stack.Name = "Txt_Stack"
        Me.Txt_Stack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Stack.Size = New System.Drawing.Size(387, 99)
        Me.Txt_Stack.TabIndex = 6
        '
        'Lbl_SaquesErrados
        '
        Me.Lbl_SaquesErrados.AutoSize = True
        Me.Lbl_SaquesErrados.Location = New System.Drawing.Point(6, 129)
        Me.Lbl_SaquesErrados.Name = "Lbl_SaquesErrados"
        Me.Lbl_SaquesErrados.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_SaquesErrados.TabIndex = 6
        Me.Lbl_SaquesErrados.Text = "Label1"
        '
        'Lbl_TransferErrados
        '
        Me.Lbl_TransferErrados.AutoSize = True
        Me.Lbl_TransferErrados.Location = New System.Drawing.Point(151, 129)
        Me.Lbl_TransferErrados.Name = "Lbl_TransferErrados"
        Me.Lbl_TransferErrados.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_TransferErrados.TabIndex = 7
        Me.Lbl_TransferErrados.Text = "Label1"
        '
        'Frm_Video05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 352)
        Me.Controls.Add(Me.Txt_Stack)
        Me.Controls.Add(Me.Btm_Stack)
        Me.Controls.Add(Me.Lbl_ContaCorrente2)
        Me.Controls.Add(Me.Lbl_ContaCorrente)
        Me.Controls.Add(Me.Grp_Movimentacao)
        Me.Controls.Add(Me.Btm_Fechar)
        Me.Controls.Add(Me.Lbl_Video05)
        Me.Name = "Frm_Video05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Video05"
        Me.Grp_Movimentacao.ResumeLayout(False)
        Me.Grp_Movimentacao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Video05 As Label
    Friend WithEvents Btm_Fechar As Button
    Friend WithEvents Grp_Movimentacao As GroupBox
    Friend WithEvents Txt_Valor As TextBox
    Friend WithEvents Lbl_Movimentacao As Label
    Friend WithEvents Btm_Saque As Button
    Friend WithEvents Lbl_ContaCorrente As Label
    Friend WithEvents Lbl_Saldo As Label
    Friend WithEvents Btm_Transferir As Button
    Friend WithEvents Lbl_ContaCorrente2 As Label
    Friend WithEvents Lbl_Saldo2 As Label
    Friend WithEvents Btm_Stack As Button
    Friend WithEvents Txt_Stack As TextBox
    Friend WithEvents Lbl_SaquesErrados As Label
    Friend WithEvents Lbl_TransferErrados As Label
End Class
