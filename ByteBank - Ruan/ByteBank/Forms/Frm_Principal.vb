﻿
Imports ByteBank.Classes
Imports System.IO

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Projeto ByteBank"
        Lbl_Principal.Text = "Projeto ByteBank"
        Lbl_Denominador.Text = "Digite o Denominador"
        Lbl_Agencia.Text = "Agencia"
        Lbl_Conta.Text = "Conta"

    End Sub

    Private Sub Video01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video01ToolStripMenuItem.Click

        Dim conta As New ContaCorrente(237, 117333)
        MsgBox("O número de contas correntes criadas são de " + ContaCorrente.TotalDeContasCriadas.ToString)
        MsgBox("O valor da taxa de operacões eatá em " + ContaCorrente.TaxaOperacao.ToString)

    End Sub

    Private Sub Video02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video02ToolStripMenuItem.Click

        Dim denominador As Integer = Val(Txt_Denominador.Text)
        Dim resposta As Integer = TestarDivisao(denominador)
        If resposta = -1 Then
            MsgBox("Não é possível fazer a divisão porque o denominador é igual a zero")
        ElseIf resposta = -2 Then
            MsgBox("Não é possível fazer a divisão porque o denominador é maior que o numerador")
        Else
            MsgBox("O valor da divisão entre 10 e " + denominador.ToString + " é de " + resposta.ToString)
        End If

    End Sub

    Function TestarDivisao(Valor As Integer) As Integer
        Dim Resultado As Integer = efetuardivisao(10, Valor)
        If Resultado = -1 Then
            Return -1
        ElseIf Resultado = -2 Then
            Return -2
        End If
        Return Resultado

    End Function

    Function efetuardivisao(Numerador As Integer, Denominador As Integer) As Integer

        If Denominador = 0 Then
            Return -1
        End If

        If Denominador > Numerador Then
            Return -2
        End If

        Return Numerador / Denominador
    End Function

    Private Sub Vídeo03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo03ToolStripMenuItem.Click
        Dim denominador As Integer = Val(Txt_Denominador.Text)
        Try
            TestarDivisao2(denominador)
        Catch ex As InvalidCastException
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
            MsgBox("Houve um erro de conversão de um Double para um String em algum MsgBox.")
        Catch ex As OverflowException
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
            MsgBox("Houver um erro de divisão por zero.")
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
            MsgBox("Houve um erro genérico. Observe a mensagem de retorno da exceção")
        End Try


    End Sub

    Sub TestarDivisao2(Valor As Integer)

        Dim Resultado As Integer = efetuardivisao2(10, Valor)

        MsgBox("Erro de divisão occoreu mas estou continuando o programa")

        If Valor = 5 Then
            Dim Conta As New ContaCorrente(277, 344445)
            MsgBox(Conta.titular.nome)
        End If

        MsgBox("O valor da divisão entre 10 e " + Valor.ToString + " é de " + Resultado)

    End Sub

    Function efetuardivisao2(Numerador As Integer, Denominador As Integer) As Integer

        Try
            Return Numerador / Denominador
        Catch ex As OverflowException
            MsgBox("Tentamos dividir o número " + Numerador.ToString + " por " + Denominador.ToString)
            Throw

        End Try

    End Function

    Private Sub Vídeo04ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo04ToolStripMenuItem.Click

        Try

            Dim vAgencia As Integer = Val(Txt_Agencia.Text)
            Dim vConta As Integer = Val(Txt_Conta.Text)

            Dim Conta As New ContaCorrente(vAgencia, vConta)
            MsgBox("O codigo da agencia e conta são " + Conta.agencia.ToString +
                " - " + Conta.numero.ToString)

        Catch ex As ArgumentException
            MsgBox(ex.Message)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub Vídeo05ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo05ToolStripMenuItem.Click

        Dim f As New Frm_Video05
        f.ShowDialog()

    End Sub

    Private Sub Vídeo06ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo06ToolStripMenuItem.Click

        Try
            LeituraArquivo()
        Catch ex As Exception
            Console.WriteLine("Erro no arquivo")
        End Try

    End Sub

    Sub LeituraArquivo()

        Using X As New LeitorDeArquivo("ContaCorrente.txt")
            X.LeituraLinha()
            X.LeituraLinha()
            X.LeituraLinha()
            X.LeituraLinha()
            X.LeituraLinha()
        End Using

        'Dim X As LeitorDeArquivo
        'Try
        '    X = New LeitorDeArquivo("ContaCorrente.txt")
        '    X.LeituraLinha()
        '    X.LeituraLinha()
        '    X.LeituraLinha()
        '    X.LeituraLinha()
        '    X.LeituraLinha()
        'Finally
        '    If Not (X Is Nothing) Then
        '        X.FecharArquivo()
        '    End If
        'End Try

    End Sub


End Class
