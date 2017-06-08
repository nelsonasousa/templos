Public Class ClsProdutos
    Private cIDProduto As Integer
    Private cProduto As String
    Private cReferencia As String
    Private cIDPessoa As Integer
    Private cIDCategoria As Integer
    Private cIDFornecimento As Integer
    Private cDescontinuado As String
    Private cPeso As Integer
    Private cMargemLucro As Decimal
    Private cImpostos As Decimal
    Private cComissao As Decimal
    Private cFrete As Decimal
    Private cNomeUser As String
    Private cDataDigita As String


    Public Sub New()
    End Sub
    Public Sub New(ByVal IDProduto As Integer, ByVal Produto As String, ByVal Referencia As String, _
                   ByVal IDPessoa As Integer, ByVal IDCategoria As Integer, ByVal IDFornecimento As Integer, _
                   ByVal Descontinuado As String, ByVal Peso As Integer, ByVal MargemLucro As Decimal, _
                   ByVal Impostos As Decimal, ByVal Comissao As Decimal, ByVal Frete As Decimal, _
                   ByVal NomeUser As String, ByVal DataDigita As DateTime)

        Me.cIDProduto = IDProduto
        Me.cIDPessoa = IDPessoa
        Me.cDescontinuado = Descontinuado
        Me.cReferencia = Referencia
        Me.cProduto = Produto
        Me.cIDCategoria = IDCategoria
        Me.cIDFornecimento = IDFornecimento
        Me.cPeso = Peso
        Me.cMargemLucro = MargemLucro
        Me.cComissao = Comissao
        Me.cFrete = Frete
        Me.cImpostos = Impostos
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDProduto() As Integer
        Get
            Return cIDProduto
        End Get
        Set(ByVal value As Integer)
            cIDProduto = value
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
    Public Property Descontinuado() As String
        Get
            Return cDescontinuado
        End Get
        Set(ByVal value As String)
            cDescontinuado = value
        End Set
    End Property
    Public Property Referencia() As String
        Get
            Return cReferencia
        End Get
        Set(ByVal value As String)
            cReferencia = value
        End Set
    End Property
    Public Property Produto() As String
        Get
            Return cProduto
        End Get
        Set(ByVal value As String)
            cProduto = value
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
    Public Property IDFornecimento() As String
        Get
            Return cIDFornecimento
        End Get
        Set(ByVal value As String)
            cIDFornecimento = value
        End Set
    End Property
    Public Property Peso() As String
        Get
            Return cPeso
        End Get
        Set(ByVal value As String)
            cPeso = value
        End Set
    End Property
    Public Property MargemLucro() As String
        Get
            Return cMargemLucro
        End Get
        Set(ByVal value As String)
            cMargemLucro = value
        End Set
    End Property
    Public Property Comissao() As String
        Get
            Return cComissao
        End Get
        Set(ByVal value As String)
            cComissao = value
        End Set
    End Property
    Public Property Frete() As String
        Get
            Return cFrete
        End Get
        Set(ByVal value As String)
            cFrete = value
        End Set
    End Property
    Public Property Impostos() As String
        Get
            Return cImpostos
        End Get
        Set(ByVal value As String)
            cImpostos = value
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


    'Métodos da Classe Produtos

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select * From Tbl_Produtos Where IDProduto=" & cIDProduto
        Dim ds As DataSet

        Dim DtAgenda As New ClsDados()

        ds = DtAgenda.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDProduto = ds.Tables(0).Rows(0).Item(0).ToString
            Produto = ds.Tables(0).Rows(0).Item(1).ToString
            Referencia = ds.Tables(0).Rows(0).Item(2).ToString
            IDPessoa = ds.Tables(0).Rows(0).Item(3).ToString
            IDCategoria = ds.Tables(0).Rows(0).Item(4).ToString
            IDFornecimento = ds.Tables(0).Rows(0).Item(5).ToString
            Descontinuado = ds.Tables(0).Rows(0).Item(6).ToString
            Peso = ds.Tables(0).Rows(0).Item(7).ToString
            MargemLucro = ds.Tables(0).Rows(0).Item(8).ToString
            Impostos = ds.Tables(0).Rows(0).Item(9).ToString
            Comissao = ds.Tables(0).Rows(0).Item(10).ToString
            Frete = ds.Tables(0).Rows(0).Item(11).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(12).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(13).ToString

        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDProduto) From Tbl_Produtos order by IDProduto desc"

        Dim IdBuscado As Integer

        Dim DtProduto As New ClsDados()

        IdBuscado = DtProduto.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function
 
    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Produtos SET Produto='" & cProduto & "',Referencia='" & cReferencia & "', " & _
        " IDPessoa='" & cIDPessoa & "',IDCategoria='" & cIDCategoria & "', IDFornecimento='" & cIDFornecimento & "', " & _
        " Descontinuado='" & cDescontinuado & "',Peso='" & cPeso & "', MargemLucro='" & cMargemLucro & "', " & _
        " Impostos='" & cImpostos & "',Comissao='" & cComissao & "',Frete='" & cFrete & "', " & _
        " NomeUser='" & cNomeUser & "',  DataDigita='" & cDataDigita & "' WHERE IDProduto= " & cIDProduto & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Produtos WHERE IDProduto=" & cIDProduto
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Produtos(Produto,Referencia,IDPessoa,IDCategoria,IDFornecimento, " & _
        " Descontinuado,Peso,MargemLucro,Impostos,Comissao,Frete,NomeUser,DataDigita)" & _
        " VALUES('" & cProduto & "','" & cReferencia & "','" & cIDPessoa & "','" & cIDCategoria & "', " & _
        " '" & cIDFornecimento & "','" & Descontinuado & "','" & cPeso & "','" & cMargemLucro & "', " & _
        " '" & cImpostos & "','" & cComissao & "','" & cFrete & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select * From Tbl_Produtos where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function
    Public Function VerificaVenda() As Boolean
        Dim cSql As String

        cSql = "Select * From Tbl_Mov_Estoque_Det Where IDProduto=" & cIDProduto
        Dim ds As DataSet

        Dim DtProduto As New ClsDados()

        ds = DtProduto.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then
            VerificaVenda = True
        Else
            VerificaVenda = False
        End If
    End Function
End Class