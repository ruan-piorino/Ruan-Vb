Imports ByteBank.Bibliotecas.Classes

Public Class Frm_PaginaWeb
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Página Web"
        Lbl_URL.Text = "URL"
        Btm_Url.Text = "GO"
        Grp_URL.Text = ""
        Grp_WebBrowser.Text = ""
        Btm_Propriedades.Text = "Prop"

    End Sub

    Private Sub Btm_Url_Click(sender As Object, e As EventArgs) Handles Btm_Url.Click

        Dim URL As String = Txt_URL.Text
        If URL = "" Then
            MsgBox("Favor digitar uma URL.", MsgBoxStyle.Critical, "URL")
        Else
            Wb_Pagina.ScriptErrorsSuppressed = True
            Wb_Pagina.Navigate(URL)
        End If

    End Sub

    Private Sub Btm_Propriedades_Click(sender As Object, e As EventArgs) Handles Btm_Propriedades.Click
        Dim URL As String = Txt_URL.Text
        If URL = "" Then
            MsgBox("Favor digitar uma URL.", MsgBoxStyle.Critical, "URL")
        Else
            URL = Wb_Pagina.Url.ToString
            Txt_URL.Text = URL
            Dim paginaURL As New ExtrairValorDeArgumentosUrl(URL)
            Dim propriedadesURL As String = paginaURL.GetTodosArgumentos
            MsgBox(propriedadesURL, MsgBoxStyle.Information, "URL")

        End If
    End Sub
End Class