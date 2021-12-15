﻿Imports ByteBank.Bibliotecas.Classes.BancoDeDados

Public Class Frm_TestaDBODBC

    Dim DSNNome As String = ""
    Dim Usuario As String = ""
    Dim Password As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DtGrid_Resultado.Columns.Clear()
        DtGrid_Resultado.DataSource = Nothing

        Try
            Dim Dt As New DataTable
            Dim DB As ODBCConn
            If Usuario = "" And Password = "" Then
                DB = New ODBCConn(DSNNome)
            Else
                DB = New ODBCConn(DSNNome, Usuario, Password)
            End If

            Dim Retorno As String = DB.SQLQuery("SELECT CPF, NOME, PROFISSAO FROM CLIENTE", Dt)
            DtGrid_Resultado.DataSource = Dt
            DB.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim Comando As String = "INSERT INTO CLIENTE (CPF, nome, profissao) VALUES ('99433454344','Zanir Moreira','Músico')"
            Dim DB As ODBCConn
            If Usuario = "" And Password = "" Then
                DB = New ODBCConn(DSNNome)
            Else
                DB = New ODBCConn(DSNNome, Usuario, Password)
            End If
            Dim Dt As New DataTable
            Dim Retorno As String = DB.SQLQuery("SELECT CPF,nome,profissao FROM Cliente WHERE CPF = '99433454344'", Dt)
            If Dt.Rows.Count > 0 Then
                MsgBox("Cliente não pode ser incluido porque já existe na base")
            Else
                Dim Retorno2 As String = DB.SQLCommand(Comando)
                MsgBox("Cliente incluido com sucesso")
            End If
            DB.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim Comando As String = "DELETE FROM CLIENTE WHERE CPF = '99433454344'"
            Dim DB As ODBCConn
            If Usuario = "" And Password = "" Then
                DB = New ODBCConn(DSNNome)
            Else
                DB = New ODBCConn(DSNNome, Usuario, Password)
            End If
            Dim Retorno As String = DB.SQLCommand(Comando)
            DB.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DSNNome = "SQLSERVER"
        Usuario = "sa"
        Password = "8ii"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DSNNome = "ORACLE"
        Usuario = "system"
        Password = "oracle"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        DSNNome = "MYSQL"
        Usuario = ""
        Password = ""
    End Sub
End Class