
Imports ByteBank.Bibliotecas.Classes

Public Class Frm_Principal2
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Formulario Principal 2"
        Lbl_Principal2.Text = "Formulário Principal 2"
        Lbl_URL.Text = "URL"
        Lbl_Argumento.Text = "Argumento"
        Txt_Argumento.ReadOnly = True
        Btm_Processa.Text = "Processa"
        Lbl_Propriedade.Text = "Propriedade"


        ' Inicializando os textbox

        Txt_URL.Text = "https://www.bytebank.com.br/cambio?moedaOrigem=dolar&moedaDestino=real&valor=1500"
        Txt_Propriedade.Text = "moedaDestino"

    End Sub

    Private Sub Btm_Processa_Click(sender As Object, e As EventArgs) Handles Btm_Processa.Click

        Dim vUrl As New ExtrairValorDeArgumentosUrl(Txt_URL.Text)
        If Not vUrl.IsByteBank Then
            MsgBox("URL não é do dominio do banco ByteBank")
        Else
            Txt_Argumento.Text = vUrl.argumento
            Dim vPropriedade As String = Txt_Propriedade.Text
            MsgBox(vUrl.GetValor(vPropriedade))
        End If

    End Sub
End Class