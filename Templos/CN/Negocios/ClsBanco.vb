Public Class ClsBanco

#Region "Variáveis"

    Private cIDDepositario As Integer
    Private cCodDepositario As Integer
    Private cAtivo As String
    Private cDepositario As String
    Private cConta As String
    Private cLimite As String
    Private cSaldo As String
    Private cDataSaldo As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDDepositario As Integer, ByVal CodDepositario As Integer, ByVal Ativo As String, _
                   ByVal Depositario As String, ByVal Conta As String, ByVal Limite As String, ByVal Saldo As String, ByVal DataSaldo As String, ByVal NomeUser As String, ByVal DataDigita As DateTime)

        Me.cIDDepositario = IDDepositario
        Me.cCodDepositario = CodDepositario
        Me.cAtivo = Ativo
        Me.cDepositario = Depositario
        Me.cConta = Conta
        Me.cLimite = Limite
        Me.cSaldo = Saldo
        Me.cDataSaldo = DataSaldo
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita

    End Sub

    Public Property IDDepositario() As Integer
        Get
            Return cIDDepositario
        End Get
        Set(ByVal value As Integer)
            cIDDepositario = value
        End Set
    End Property
    Public Property CodDepositario() As Integer
        Get
            Return cCodDepositario
        End Get
        Set(ByVal value As Integer)
            cCodDepositario = value
        End Set
    End Property
    Public Property Ativo() As String
        Get
            Return cAtivo
        End Get
        Set(ByVal value As String)
            cAtivo = value
        End Set
    End Property
    Public Property Depositario() As String
        Get
            Return cDepositario
        End Get
        Set(ByVal value As String)
            cDepositario = value
        End Set
    End Property
    Public Property Conta() As String
        Get
            Return cConta
        End Get
        Set(ByVal value As String)
            cConta = value
        End Set
    End Property
    Public Property Limite() As String
        Get
            Return cLimite
        End Get
        Set(ByVal value As String)
            cLimite = value
        End Set
    End Property
    Public Property Saldo() As String
        Get
            Return cSaldo
        End Get
        Set(ByVal value As String)
            cSaldo = value
        End Set
    End Property
    Public Property DataSaldo() As String
        Get
            Return cDataSaldo
        End Get
        Set(ByVal value As String)
            cDataSaldo = value
        End Set
    End Property
    Public Property NomeUser() As String
        Get
            Return cNomeUser
        End Get
        Set(ByVal value As String)
            cNomeUser = value
        End Set
    End Property
    Public Property DataDigita() As String
        Get
            Return cDataDigita
        End Get
        Set(ByVal value As String)
            cDataDigita = value
        End Set
    End Property

#End Region

#Region "Métodos da Classe Categoria"

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select * From Tbl_Depositarios Where IDDepositario=" & cIDDepositario
        Dim ds As DataSet

        Dim DtDepositarios As New ClsDados()

        ds = DtDepositarios.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDDepositario = ds.Tables(0).Rows(0).Item(0).ToString
            CodDepositario = ds.Tables(0).Rows(0).Item(1).ToString
            Depositario = ds.Tables(0).Rows(0).Item(2).ToString
            Ativo = ds.Tables(0).Rows(0).Item(3).ToString
            Conta = ds.Tables(0).Rows(0).Item(4).ToString
            Limite = ds.Tables(0).Rows(0).Item(5).ToString
            Saldo = ds.Tables(0).Rows(0).Item(6).ToString
            DataSaldo = ds.Tables(0).Rows(0).Item(7).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(8).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(9).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDDepositario) From Tbl_Depositarios order by IDDepositario desc"

        Dim IdBuscado As Integer

        Dim DtDepositarios As New ClsDados()

        IdBuscado = DtDepositarios.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function
    Public Sub Editar()

        'Dim sSaldo As String = cSaldo.ToString
        'Dim sLimite As String = cLimite.ToString
        'sSaldo = sSaldo.Replace(",", ".")
        'sLimite = sLimite.Replace(",", ".")
        Dim strQuery As String

        strQuery = "Update Tbl_Depositarios SET CodDepositario='" & cCodDepositario & "', " & _
        " Depositario='" & cDepositario & "',Ativo='" & cAtivo & "',Conta='" & cConta & "',Limite='" & cLimite & "',Saldo='" & cSaldo & "',DataSaldo='" & cDataSaldo & "',NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDDepositario= " & cIDDepositario & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Depositarios WHERE IDDepositario=" & cIDDepositario
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()
        'Dim sSaldo As String = cSaldo.ToString
        'Dim sLimite As String = cLimite.ToString
        'sSaldo = sSaldo.Replace(",", ".")
        'sLimite = sLimite.Replace(",", ".")
        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Depositarios(CodDepositario,Depositario,Ativo,Conta,Limite,Saldo,DataSaldo,NomeUser,DataDigita)" & _
        " VALUES('" & cCodDepositario & "','" & cDepositario & "','" & cAtivo & "','" & cConta & "','" & cLimite & "','" & cSaldo & "','" & cDataSaldo & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDDepositario,Nome,Conta From Tbl_Depositarios where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

#End Region

End Class
