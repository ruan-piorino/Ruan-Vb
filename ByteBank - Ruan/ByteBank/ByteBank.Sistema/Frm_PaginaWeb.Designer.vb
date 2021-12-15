<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PaginaWeb
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
        Me.Lbl_URL = New System.Windows.Forms.Label()
        Me.Txt_URL = New System.Windows.Forms.TextBox()
        Me.Wb_Pagina = New System.Windows.Forms.WebBrowser()
        Me.Btm_Url = New System.Windows.Forms.Button()
        Me.Grp_URL = New System.Windows.Forms.GroupBox()
        Me.Grp_WebBrowser = New System.Windows.Forms.GroupBox()
        Me.Btm_Propriedades = New System.Windows.Forms.Button()
        Me.Grp_URL.SuspendLayout()
        Me.Grp_WebBrowser.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_URL
        '
        Me.Lbl_URL.AutoSize = True
        Me.Lbl_URL.Location = New System.Drawing.Point(3, 23)
        Me.Lbl_URL.Name = "Lbl_URL"
        Me.Lbl_URL.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_URL.TabIndex = 0
        Me.Lbl_URL.Text = "Label1"
        '
        'Txt_URL
        '
        Me.Txt_URL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_URL.Location = New System.Drawing.Point(6, 42)
        Me.Txt_URL.Multiline = True
        Me.Txt_URL.Name = "Txt_URL"
        Me.Txt_URL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_URL.Size = New System.Drawing.Size(797, 56)
        Me.Txt_URL.TabIndex = 1
        '
        'Wb_Pagina
        '
        Me.Wb_Pagina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wb_Pagina.Location = New System.Drawing.Point(3, 16)
        Me.Wb_Pagina.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Wb_Pagina.Name = "Wb_Pagina"
        Me.Wb_Pagina.Size = New System.Drawing.Size(814, 229)
        Me.Wb_Pagina.TabIndex = 2
        '
        'Btm_Url
        '
        Me.Btm_Url.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btm_Url.Location = New System.Drawing.Point(647, 13)
        Me.Btm_Url.Name = "Btm_Url"
        Me.Btm_Url.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Url.TabIndex = 3
        Me.Btm_Url.Text = "Button1"
        Me.Btm_Url.UseVisualStyleBackColor = True
        '
        'Grp_URL
        '
        Me.Grp_URL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grp_URL.Controls.Add(Me.Btm_Propriedades)
        Me.Grp_URL.Controls.Add(Me.Txt_URL)
        Me.Grp_URL.Controls.Add(Me.Btm_Url)
        Me.Grp_URL.Controls.Add(Me.Lbl_URL)
        Me.Grp_URL.Location = New System.Drawing.Point(15, 12)
        Me.Grp_URL.Name = "Grp_URL"
        Me.Grp_URL.Size = New System.Drawing.Size(816, 117)
        Me.Grp_URL.TabIndex = 4
        Me.Grp_URL.TabStop = False
        Me.Grp_URL.Text = "GroupBox1"
        '
        'Grp_WebBrowser
        '
        Me.Grp_WebBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grp_WebBrowser.Controls.Add(Me.Wb_Pagina)
        Me.Grp_WebBrowser.Location = New System.Drawing.Point(12, 135)
        Me.Grp_WebBrowser.Name = "Grp_WebBrowser"
        Me.Grp_WebBrowser.Size = New System.Drawing.Size(820, 248)
        Me.Grp_WebBrowser.TabIndex = 5
        Me.Grp_WebBrowser.TabStop = False
        Me.Grp_WebBrowser.Text = "GroupBox1"
        '
        'Btm_Propriedades
        '
        Me.Btm_Propriedades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btm_Propriedades.Location = New System.Drawing.Point(728, 13)
        Me.Btm_Propriedades.Name = "Btm_Propriedades"
        Me.Btm_Propriedades.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Propriedades.TabIndex = 4
        Me.Btm_Propriedades.Text = "Button1"
        Me.Btm_Propriedades.UseVisualStyleBackColor = True
        '
        'Frm_PaginaWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 395)
        Me.Controls.Add(Me.Grp_WebBrowser)
        Me.Controls.Add(Me.Grp_URL)
        Me.Name = "Frm_PaginaWeb"
        Me.Text = "Frm_PaginaWeb"
        Me.Grp_URL.ResumeLayout(False)
        Me.Grp_URL.PerformLayout()
        Me.Grp_WebBrowser.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_URL As Label
    Friend WithEvents Txt_URL As TextBox
    Friend WithEvents Wb_Pagina As WebBrowser
    Friend WithEvents Btm_Url As Button
    Friend WithEvents Grp_URL As GroupBox
    Friend WithEvents Grp_WebBrowser As GroupBox
    Friend WithEvents Btm_Propriedades As Button
End Class
