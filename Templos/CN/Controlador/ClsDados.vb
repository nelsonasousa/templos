'Classe - Camada de Dados (Lidar diretamente com os dados)

'Imports System.Data
'Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb


Public Class ClsDados

    'Dim strConexao As String
    ' Dim strConexao As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strLocalBase
    Dim strConexao As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & strLocalBase

    ' Dim strConexao As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=" & strLocalBase & "\BaseSGT.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"

    Private Function AbrirBanco() As OleDbConnection
        Dim cn As New OleDbConnection
        cn.ConnectionString = strConexao
        cn.Open()
        Return cn
    End Function

    Private Sub FecharBanco(ByVal cn As OleDbConnection)
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub

    Public Sub ExecutarComando(ByVal strQuery As String)
        Dim cn As New OleDbConnection()
        Try
            'Abrir o banco de dados e passar os
            'parametros da consulta SQL, parametros
            'e ordem de execução.

            cn = AbrirBanco()

            Dim cmdCommand As New OleDbCommand

            With cmdCommand
                .CommandText = strQuery.ToString
                .CommandType = CommandType.Text
                .Connection = cn
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            Throw ex
        Finally
            FecharBanco(cn)
        End Try
    End Sub

    Public Function RetornarDataSet(ByVal strQuery As String) As DataSet

        Dim cn As New OleDbConnection()

        Try
            'Abrir o banco de dados e passar os
            'parametros da consulta SQL, parametros
            'e ordem de execução.
            cn = AbrirBanco()
            Dim cmdCommand As New OleDbCommand
            With cmdCommand
                .CommandText = strQuery.ToString
                .CommandType = CommandType.Text
                .Connection = cn
                '.ExecuteNonQuery()
            End With
            'Declarado um dataadapter e um dataset
            'passar o comando para o dtAdapter e 
            'carregar o dataset com resultado da busca

            Dim dtAdapter As New OleDbDataAdapter
            Dim dsDataSet As New DataSet

            With dtAdapter
                    .SelectCommand = cmdCommand
                    .Fill(dsDataSet)
            End With

            'Retorna o Dataset

            Return dsDataSet
        Catch ex As Exception
            Throw ex
        Finally
            FecharBanco(cn)
        End Try
    End Function

    Public Function RetornarDataReader(ByVal strQuery As String) As OleDbDataReader
        Dim cn As New OleDbConnection()
        Try

            'Abrir o banco de dados e passar os
            'parametros da consulta SQL, parametros
            'e ordem de execução e retorna DataReader.

            cn = AbrirBanco()

            Dim cmdCommand As New OleDbCommand

            With cmdCommand
                .CommandText = strQuery.ToString
                .CommandType = CommandType.Text
                .Connection = cn
            End With

            Return cmdCommand.ExecuteReader

        Catch ex As Exception

            Throw ex

        Finally

            FecharBanco(cn)

        End Try

    End Function

    Public Function RetornarIdNumerico(ByVal strQuery As String) As Integer

        Dim cn As New OleDbConnection()

        Try

            'Abrir o banco de dados e passar os
            'parametros da consulta SQL, parametros
            'e ordem de execução e retorna um inteiro.

            cn = AbrirBanco()

            Dim cmdCommand As New OleDbCommand

            With cmdCommand
                .CommandText = strQuery.ToString
                .CommandType = CommandType.Text
                .Connection = cn
            End With

            Dim dtReader As OleDbDataReader

            dtReader = cmdCommand.ExecuteReader()

            Dim codigo As Integer

            If dtReader.Read() Then
                'Retorna o último ID inserido
                codigo = dtReader(0)
            End If

            Return codigo

        Catch ex As Exception

            Throw ex

        Finally

            FecharBanco(cn)

        End Try

    End Function

    Public Function RetornarValorTotal(ByVal strQuery As String) As Decimal

        Dim cn As New OleDbConnection()

        Try

            'Abrir o banco de dados e passar os
            'parametros da consulta SQL, parametros
            'e ordem de execução e retorna um inteiro.

            cn = AbrirBanco()

            Dim cmdCommand As New OleDbCommand

            With cmdCommand
                .CommandText = strQuery.ToString
                .CommandType = CommandType.Text
                .Connection = cn
            End With

            Dim dtReader As OleDbDataReader

            dtReader = cmdCommand.ExecuteReader()

            Dim ValorTotal As Decimal

            If dtReader.Read() Then

                ValorTotal = dtReader(0)

            End If

            Return ValorTotal

        Catch ex As Exception

            Throw ex

        Finally

            FecharBanco(cn)

        End Try

    End Function
    Public Function ExecutaSQL(ByVal strQuery As String) As Boolean
        Dim cn As New OleDbConnection()
        Dim Retorno As Boolean = False

        Try
            'Abrir o banco de dados e passar os
            'parametros da consulta OleDB, parametros
            'e ordem de execução.

            cn = AbrirBanco()

            Dim cmdCommand As New OleDbCommand

            With cmdCommand
                .CommandText = strQuery.ToString
                .CommandType = CommandType.Text
                .Connection = cn
                .ExecuteNonQuery()
            End With
            Retorno = True
        Catch ex As Exception
            Retorno = False
            Throw ex
        Finally
            FecharBanco(cn)
        End Try
        Return Retorno
    End Function

    Public Function RetornarDataTAble(ByVal strQuery As String) As DataTable

        Dim cn As New OleDbConnection()

        Try
            'Abrir o banco de dados e passar os
            'parametros da consulta SQL, parametros
            'e ordem de execução.
            cn = AbrirBanco()
            Dim cmdCommand As New OleDbCommand
            With cmdCommand
                .CommandText = strQuery.ToString
                .CommandType = CommandType.Text
                .Connection = cn
                .ExecuteNonQuery()
            End With
            'Declarado um dataadapter e um dataset
            'passar o comando para o dtAdapter e 
            'carregar o dataset com resultado da busca

            Dim dtAdapter As New OleDbDataAdapter
            Dim dsDataTbl As New DataTable

            With dtAdapter
                .SelectCommand = cmdCommand
                .Fill(dsDataTbl)
            End With

            'Retorna o Dataset

            Return dsDataTbl
        Catch ex As Exception
            Throw ex
        Finally
            FecharBanco(cn)
        End Try
    End Function


End Class
