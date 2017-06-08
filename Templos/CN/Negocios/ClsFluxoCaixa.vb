Public Class ClsFluxoCaixa

#Region "Variáveis"

    Private cIDMovFinanceiro As Integer
    Private cDataVencimento As String
    Private cEntidade As String
    Private cTitulo As String
    Private cCRD As Decimal
    Private cDBT As Decimal
    Private cDataPagamento As String

    Private cIDDepositario As Integer
    Private cSaldoAnterior As Decimal
    Private cSaldoAtual As Decimal
    Private cDataSaldoAtual As String
    Private cDataSaldoAnterior As String
    Private cNomeUser As String
    Private cDataDigita As String

    Private cTipoMov As String
    Private cDataEmissao As String
    Private cValorTitulo As Decimal
    Private cIDPessoa As Integer
    Private cDataMovimento As String

    Private cIDCategoria As Integer
    Private cCategoria As String
    Private cIDSubCategoria As Integer
    Private cIDHistorico As Integer
    Private cDesconto As Decimal
    Private cValorDesconto As Decimal

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDMovFinanceiro As Integer, ByVal DataVencimento As DateTime, ByVal Entidade As String,
                   ByVal Titulo As String, ByVal CRD As Decimal, ByVal DBT As Decimal, ByVal IDDepositario As Integer,
                   ByVal DataPagamento As DateTime, ByVal SaldoAnterior As Decimal, ByVal SaldoAtual As Decimal,
                   ByVal DataSaldoAtual As DateTime, ByVal DataSaldoAnterior As DateTime, ByVal Categoria As String,
                   ByVal TipoMov As String, ByVal DataEmissao As DateTime, ByVal DataMovimento As DateTime,
                   ByVal ValorTitulo As Decimal, ByVal IDPessoa As Integer, ByVal IDCategoria As Integer,
                   ByVal IDSubCategoria As Integer, ByVal IDHistorico As Integer, ByVal Desconto As Decimal,
                   ByVal ValorDesconto As Decimal, ByVal NomeUser As String, ByVal DataDigita As DateTime)

        Me.cIDMovFinanceiro = IDMovFinanceiro
        Me.cEntidade = Entidade
        Me.cDataVencimento = DataVencimento
        Me.cTitulo = Titulo
        Me.cCRD = CRD
        Me.cDBT = DBT
        Me.cDataPagamento = DataPagamento
        Me.cSaldoAnterior = SaldoAnterior
        Me.cSaldoAtual = SaldoAtual
        Me.cDataSaldoAnterior = DataSaldoAnterior
        Me.cDataSaldoAtual = DataSaldoAtual
        Me.cIDDepositario = IDDepositario
        Me.cTipoMov = TipoMov
        Me.cDataEmissao = DataEmissao
        Me.cDataMovimento = DataMovimento
        Me.cValorTitulo = ValorTitulo
        Me.cIDPessoa = IDPessoa
        Me.cIDCategoria = IDCategoria
        Me.cCategoria = Categoria
        Me.cIDSubCategoria = IDSubCategoria
        Me.cIDHistorico = IDHistorico
        Me.cDesconto = Desconto
        Me.cValorDesconto = ValorDesconto
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
    Public Property Entidade() As String
        Get
            Return cEntidade
        End Get
        Set(ByVal value As String)
            cEntidade = value
        End Set
    End Property
    Public Property Categoria() As String
        Get
            Return cCategoria
        End Get
        Set(ByVal value As String)
            cCategoria = value
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
    Public Property Titulo() As String
        Get
            Return cTitulo
        End Get
        Set(ByVal value As String)
            cTitulo = value
        End Set
    End Property
    Public Property CRD() As String
        Get
            Return cCRD
        End Get
        Set(ByVal value As String)
            cCRD = value
        End Set
    End Property
    Public Property DBT() As String
        Get
            Return cDBT
        End Get
        Set(ByVal value As String)
            cDBT = value
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
    Public Property SaldoAnterior() As String
        Get
            Return cSaldoAnterior
        End Get
        Set(ByVal value As String)
            cSaldoAnterior = value
        End Set
    End Property
    Public Property SaldoAtual() As String
        Get
            Return cSaldoAtual
        End Get
        Set(ByVal value As String)
            cSaldoAtual = value
        End Set
    End Property
    Public Property DataSaldoAnterior() As String
        Get
            Return cDataSaldoAnterior
        End Get
        Set(ByVal value As String)
            cDataSaldoAnterior = value
        End Set
    End Property
    Public Property DataSaldoAtual() As String
        Get
            Return cDataSaldoAtual
        End Get
        Set(ByVal value As String)
            cDataSaldoAtual = value
        End Set
    End Property
    Public Property IDDepositario() As Integer
        Get
            Return cIDDepositario
        End Get
        Set(ByVal value As Integer)
            cIDDepositario = value
        End Set
    End Property
    Public Property TipoMov() As String
        Get
            Return cTipoMov
        End Get
        Set(ByVal value As String)
            cTipoMov = value
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
    Public Property DataMovimento() As String
        Get
            Return cDataMovimento
        End Get
        Set(ByVal value As String)
            cDataMovimento = value
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
    Public Property IDPessoa() As Integer
        Get
            Return cIDPessoa
        End Get
        Set(ByVal value As Integer)
            cIDPessoa = value
        End Set
    End Property
    Public Property IDCategoria() As Integer
        Get
            Return cIDCategoria
        End Get
        Set(ByVal value As Integer)
            cIDCategoria = value
        End Set
    End Property
    Public Property IDSubCategoria() As Integer
        Get
            Return cIDSubCategoria
        End Get
        Set(ByVal value As Integer)
            cIDSubCategoria = value
        End Set
    End Property
    Public Property IDHistorico() As Integer
        Get
            Return cIDHistorico
        End Get
        Set(ByVal value As Integer)
            cIDHistorico = value
        End Set
    End Property
    Public Property Desconto() As Decimal
        Get
            Return cDesconto
        End Get
        Set(ByVal value As Decimal)
            cDesconto = value
        End Set
    End Property
    Public Property ValorDesconto() As Decimal
        Get
            Return cValorDesconto
        End Get
        Set(ByVal value As Decimal)
            cValorDesconto = value
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

#Region "Métodos"

    Public Sub CreditaDebitaMesmaConta()
        'Dim sValorTitulo As String = cValorTitulo.ToString
        'Dim sDesconto As String = cDesconto.ToString
        'Dim sValorDesconto As String = cValorDesconto.ToString
        'sValorTitulo = sValorTitulo.Replace(",", ".")
        'sDesconto = sDesconto.Replace(",", ".")
        'sValorDesconto = sValorDesconto.Replace(",", ".")

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Mov_Financeiros(TipoMov,Titulo,ValorTitulo," & _
        " DataMovimento,DataEmissao,DataVencimento,IDPessoa,IDDepositario," & _
        " IDCategoria,IDSubCategoria,IDHistorico,Desconto,ValorDesconto)" & _
        " VALUES('" & cTipoMov & "','" & cTitulo & "','" & cValorTitulo & "', " & _
        " '" & cDataMovimento & "','" & cDataEmissao & "','" & cDataVencimento & "', " & _
        " '" & cIDPessoa & "','" & cIDDepositario & "','" & cIDCategoria & "','" & cIDSubCategoria & "', " & _
        " '" & cIDHistorico & "','" & cDesconto & "', '" & cValorDesconto & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub ExcluirCaixa()

        Dim strQuery As String

        strQuery = "DELETE * FROM Tbl_Financeiro_Temp "
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub GravarCaixa()
        'Dim sDBT As String = cDBT.ToString
        'Dim sCRD As String = cCRD.ToString

        'sDBT = Replace(sDBT, ",", ".")
        'sCRD = Replace(sCRD, ",", ".")

        Dim strQuery As String
        If cDataPagamento = "NULL" Then
            strQuery = "INSERT INTO Tbl_Financeiro_Temp(DtMov,Nome,Titulo,CD,DB,Pagamento,Categoria,IDFinanceiro)" &
                    " VALUES('" & cDataVencimento & "','" & cEntidade & "'," &
                    " '" & cTitulo & "','" & cCRD & "','" & cDBT & "'," & cDataPagamento & ",'" & cCategoria & "'," & cIDMovFinanceiro & ");"
        Else
            strQuery = "INSERT INTO Tbl_Financeiro_Temp(DtMov,Nome,Titulo,CD,DB,Pagamento,Categoria,IDFinanceiro)" &
            " VALUES('" & cDataVencimento & "','" & cEntidade & "'," &
            " '" & cTitulo & "','" & cCRD & "','" & cDBT & "','" & cDataPagamento & "','" & cCategoria & "'," & cIDMovFinanceiro & ");"
        End If

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub GravaSaldoAtual()
        'Dim sSaldoAtual As String = cSaldoAtual.ToString

        'sSaldoAtual = Replace(sSaldoAtual, ",", ".")

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Saldo_Depositarios(IDDepositario,SaldoDia,DataSaldoDia,NomeUser,DataDigita)" & _
        " VALUES('" & cIDDepositario & "','" & cSaldoAtual & "','" & cDataSaldoAtual & "'," & _
        " '" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub CreditaDebitaOutraConta()
        'Dim sValorTitulo As String = cValorTitulo.ToString
        'Dim sDesconto As String = cDesconto.ToString
        'Dim sValorDesconto As String = cValorDesconto.ToString
        'sValorTitulo = sValorTitulo.Replace(",", ".")
        'sDesconto = sDesconto.Replace(",", ".")
        'sValorDesconto = sValorDesconto.Replace(",", ".")

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Mov_Financeiros(TipoMov,Titulo,ValorTitulo," & _
        " DataMovimento,DataEmissao,DataVencimento,IDPessoa,IDDepositario," & _
        " IDCategoria,IDSubCategoria,IDHistorico,Desconto,ValorDesconto)" & _
        " VALUES('" & cTipoMov & "','" & cTitulo & "','" & cValorTitulo & "', " & _
        " '" & cDataMovimento & "','" & cDataEmissao & "','" & cDataVencimento & "', " & _
        " '" & cIDPessoa & "','" & cIDDepositario & "','" & cIDCategoria & "','" & cIDSubCategoria & "', " & _
        " '" & cIDHistorico & "','" & cDesconto & "', '" & cValorDesconto & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub BuscaTransferencia()

        Dim cSql As String

        cSql = "Select IDMovFinanceiro,TipoMov,Titulo,DataEmissao,DataVencimento,ValorTitulo,IDPessoa,IDDepositario From Tbl_Mov_Financeiros Where IDMovFinanceiro=" & cIDMovFinanceiro
        Dim ds As DataSet

        Dim DtSaldo As New ClsDados()

        ds = DtSaldo.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDMovFinanceiro = ds.Tables(0).Rows(0).Item(0)
            TipoMov = ds.Tables(0).Rows(0).Item(1)
            Titulo = ds.Tables(0).Rows(0).Item(2)
            DataEmissao = ds.Tables(0).Rows(0).Item(3).ToString
            DataVencimento = ds.Tables(0).Rows(0).Item(4).ToString
            ValorTitulo = ds.Tables(0).Rows(0).Item(5).ToString
            IDPessoa = ds.Tables(0).Rows(0).Item(6).ToString
            IDDepositario = ds.Tables(0).Rows(0).Item(7).ToString

        End If

    End Sub
    Public Sub BuscaSaldo()

        Dim cSql As String

        cSql = "Select TOP 1 * From Tbl_Saldos ORDER BY DataSaldo DESC"
        Dim ds As DataSet

        Dim DtSaldo As New ClsDados()

        ds = DtSaldo.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            DataSaldoAnterior = ds.Tables(0).Rows(0).Item(0)
            SaldoAnterior = ds.Tables(0).Rows(0).Item(1)
            NomeUser = ds.Tables(0).Rows(0).Item(2).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(3).ToString
        End If

    End Sub
    Public Sub ExcluirFluxo()

        Dim strQuery As String

        strQuery = "DELETE * FROM Tbl_Fluxo_Caixa "
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub GravarFluxo()
        'Dim sDBT As String = cDBT.ToString
        'Dim sCRD As String = cCRD.ToString

        'sDBT = Replace(sDBT, ",", ".")
        'sCRD = Replace(sCRD, ",", ".")

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Fluxo_Caixa(IDMov,DtMov,Nome,Titulo,CD,DB)" & _
        " VALUES('" & cIDMovFinanceiro & "','" & cDataVencimento & "','" & cEntidade & "'," & _
        " '" & cTitulo & "','" & cCRD & "','" & cDBT & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub

#End Region

End Class
