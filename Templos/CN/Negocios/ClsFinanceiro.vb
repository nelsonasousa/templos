Public Class ClsFinanceiro

#Region "Variáveis"

    Private cIDMovFinanceiro As Integer
    Private cTipoFinanceiro As String
    Private cTitulo As String
    Private cIDPessoa As Integer
    Private cIDCategoria As Integer
    Private cDataEmissao As String
    Private cDataVencimento As String
    Private cDataPagamento As String
    Private cValorTitulo As Decimal
    Private cObservacao As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDMovFinanceiro As Integer, ByVal TipoFinanceiro As String,
                   ByVal Titulo As String, ByVal DataEmissao As DateTime, ByVal ValorTitulo As String,
                   ByVal DataVencimento As DateTime, ByVal IDPessoa As Integer, ByVal IDCategoria As Integer,
                   ByVal Observacao As String, ByVal DataPagamento As DateTime,
                   ByVal NomeUser As String, ByVal DataDigita As DateTime)

        Me.cIDMovFinanceiro = IDMovFinanceiro
        Me.cTipoFinanceiro = TipoFinanceiro
        Me.cTitulo = Titulo
        Me.cDataEmissao = DataEmissao
        Me.cValorTitulo = ValorTitulo
        Me.cDataVencimento = DataVencimento
        Me.cIDPessoa = IDPessoa
        Me.cIDCategoria = IDCategoria
        Me.cObservacao = Observacao
        Me.cDataPagamento = DataPagamento
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita

    End Sub
    Public Property IDMovFinanceiro() As Integer
        Get
            Return cIDMovFinanceiro
        End Get
        Set(ByVal value As Integer)
            cIDMovFinanceiro = value
        End Set
    End Property
    Public Property TipoFinanceiro() As String
        Get
            Return cTipoFinanceiro
        End Get
        Set(ByVal value As String)
            cTipoFinanceiro = value
        End Set
    End Property
    Public Property Titulo() As String
        Get
            Return cTitulo
        End Get
        Set(ByVal value As String)
            cTitulo = value
        End Set
    End Property
    Public Property DataEmissao() As String
        Get
            Return cDataEmissao
        End Get
        Set(ByVal value As String)
            cDataEmissao = value
        End Set
    End Property
    Public Property ValorTitulo() As String
        Get
            Return cValorTitulo
        End Get
        Set(ByVal value As String)
            cValorTitulo = value
        End Set
    End Property
    Public Property DataVencimento() As String
        Get
            Return cDataVencimento
        End Get
        Set(ByVal value As String)
            cDataVencimento = value
        End Set
    End Property
    Public Property IDPessoa() As String
        Get
            Return cIDPessoa
        End Get
        Set(ByVal value As String)
            cIDPessoa = value
        End Set
    End Property
    Public Property IDCategoria() As String
        Get
            Return cIDCategoria
        End Get
        Set(ByVal value As String)
            cIDCategoria = value
        End Set
    End Property
    Public Property Observacao() As String
        Get
            Return cObservacao
        End Get
        Set(ByVal value As String)
            cObservacao = value
        End Set
    End Property
    Public Property DataPagamento() As String
        Get
            Return cDataPagamento
        End Get
        Set(ByVal value As String)
            cDataPagamento = value
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

#Region "Métodos da Classe Fornecedores"

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select * From Tbl_Mov_Financeiros Where IDFinanceiro=" & cIDMovFinanceiro
        Dim ds As DataSet

        Dim DtAgenda As New ClsDados()

        ds = DtAgenda.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDMovFinanceiro = ds.Tables(0).Rows(0).Item(0).ToString
            TipoFinanceiro = ds.Tables(0).Rows(0).Item(1).ToString
            Titulo = ds.Tables(0).Rows(0).Item(2).ToString
            IDPessoa = ds.Tables(0).Rows(0).Item(3).ToString
            DataEmissao = ds.Tables(0).Rows(0).Item(4).ToString
            DataVencimento = ds.Tables(0).Rows(0).Item(5).ToString
            DataPagamento = ds.Tables(0).Rows(0).Item(6).ToString
            ValorTitulo = ds.Tables(0).Rows(0).Item(7).ToString
            Observacao = ds.Tables(0).Rows(0).Item(8).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(9).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(10).ToString
            IDCategoria = ds.Tables(0).Rows(0).Item(11).ToString

        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select TOP 1 (IDFinanceiro) From Tbl_Mov_Financeiros order by IDFinanceiro desc;"

        Dim IdBuscado As Integer

        Dim DtAgenda As New ClsDados()

        IdBuscado = DtAgenda.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Editar()
        'Dim sValorTitulo As String = cValorTitulo.ToString
        'sValorTitulo = sValorTitulo.Replace(",", ".")

        Dim strQuery As String

        strQuery = "Update Tbl_Mov_Financeiros SET IDPessoa=" & cIDPessoa & ",ValorTitulo='" & cValorTitulo & "', " &
        " DataVencimento='" & cDataVencimento & "',Observacao='" & cObservacao & "'," &
        " NomeUser='" & cNomeUser & "', DataDigita='" & cDataDigita & "',IDCategoria=" & cIDCategoria & " " &
        " WHERE IDFinanceiro= " & cIDMovFinanceiro & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Pagar()

        Dim strQuery As String

        strQuery = "Update Tbl_Mov_Financeiros SET DataPagamento='" & cDataPagamento & "' " & _
        " ,NomeUser='" & cNomeUser & "', DataDigita='" & cDataDigita & "' " & _
        " WHERE IDFinanceiro= " & cIDMovFinanceiro & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Mov_Financeiros WHERE IDFinanceiro=" & cIDMovFinanceiro
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()
        'Dim sValorTitulo As String = cValorTitulo.ToString
        'sValorTitulo = sValorTitulo.Replace(",", ".")
        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Mov_Financeiros(TipoFinanceiro,Titulo,IDPessoa," &
        " DataEmissao,DataVencimento,ValorTitulo,Observacao,NomeUser,DataDigita,IDCategoria)" &
        " VALUES('" & cTipoFinanceiro & "','" & cTitulo & "','" & cIDPessoa & "','" & cDataEmissao & "'," &
        " '" & cDataVencimento & "','" & cValorTitulo & "','" & cObservacao & "', " &
        " '" & cNomeUser & "','" & cDataDigita & "'," & cIDCategoria & ");"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDFinanceiro,Titulo From Tbl_Mov_Financeiros where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

#End Region

End Class
