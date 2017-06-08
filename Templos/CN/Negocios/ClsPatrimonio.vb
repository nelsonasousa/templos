Public Class ClsPatrimonio

#Region "Variáveis"
    Private cIDAparelho As Integer
    Private cDescricao As String
    Private cModelo As String
    Private cSerie As String
    Private cTensao As String
    Private cIDCor As Integer
    Private cDataRegistro As String
    Private cDataCompra As String
    Private cDataAtendimento As String
    Private cValorCompra As Decimal
    Private cNotaFiscal As String
    Private cDepreciacao As Decimal
    Private cIDRevendedor As Integer
    Private cLocal As String
    Private cAparelhoFiscal As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"
    Public Sub New()
    End Sub
    Public Sub New(ByVal IDAparelho As Integer, ByVal Descricao As String, _
                   ByVal Modelo As String, ByVal Serie As String, ByVal Tensao As String, ByVal IDCor As Integer, _
                   ByVal DataRegistro As DateTime, ByVal DataCompra As DateTime, ByVal DataAtendimento As DateTime, _
                   ByVal ValorCompra As Decimal, ByVal NotaFiscal As String, ByVal Depreciacao As Decimal, _
                   ByVal IDRevendedor As Integer, ByVal Local As String, _
                   ByVal AparelhoFiscal As String, _
                   ByVal NomeUser As String, ByVal DataDigita As DateTime)

        Me.cIDAparelho = IDAparelho
        Me.cDescricao = Descricao
        Me.cModelo = Modelo
        Me.cSerie = Serie
        Me.cTensao = Tensao
        Me.cIDCor = IDCor
        Me.cDataRegistro = DataRegistro
        Me.cDataCompra = DataCompra
        Me.cDataAtendimento = DataAtendimento
        Me.cValorCompra = ValorCompra
        Me.cNotaFiscal = NotaFiscal
        Me.cDepreciacao = Depreciacao
        Me.cIDRevendedor = IDRevendedor
        Me.cLocal = Local
        Me.cAparelhoFiscal = AparelhoFiscal
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita

    End Sub

    Public Property IDAparelho() As Integer
        Get
            Return cIDAparelho
        End Get
        Set(ByVal value As Integer)
            cIDAparelho = value
        End Set
    End Property
    Public Property Descricao() As String
        Get
            Return cDescricao
        End Get
        Set(ByVal value As String)
            cDescricao = value
        End Set
    End Property
    Public Property Modelo() As String
        Get
            Return cModelo
        End Get
        Set(ByVal value As String)
            cModelo = value
        End Set
    End Property
    Public Property Serie() As String
        Get
            Return cSerie
        End Get
        Set(ByVal value As String)
            cSerie = value
        End Set
    End Property
    Public Property Tensao() As String
        Get
            Return cTensao
        End Get
        Set(ByVal value As String)
            cTensao = value
        End Set
    End Property
    Public Property IDCor() As Integer
        Get
            Return cIDCor
        End Get
        Set(ByVal value As Integer)
            cIDCor = value
        End Set
    End Property
    Public Property DataRegistro() As String
        Get
            Return cDataRegistro
        End Get
        Set(ByVal value As String)
            cDataRegistro = value
        End Set
    End Property
    Public Property DataCompra() As String
        Get
            Return cDataCompra
        End Get
        Set(ByVal value As String)
            cDataCompra = value
        End Set
    End Property
    Public Property DataAtendimento() As String
        Get
            Return cDataAtendimento
        End Get
        Set(ByVal value As String)
            cDataAtendimento = value
        End Set
    End Property
    Public Property ValorCompra() As Decimal
        Get
            Return cValorCompra
        End Get
        Set(ByVal value As Decimal)
            cValorCompra = value
        End Set
    End Property
    Public Property NotaFiscal() As String
        Get
            Return cNotaFiscal
        End Get
        Set(ByVal value As String)
            cNotaFiscal = value
        End Set
    End Property
    Public Property Depreciacao() As Decimal
        Get
            Return cDepreciacao
        End Get
        Set(ByVal value As Decimal)
            cDepreciacao = value
        End Set
    End Property
    Public Property IDRevendedor() As Integer
        Get
            Return cIDRevendedor
        End Get
        Set(ByVal value As Integer)
            cIDRevendedor = value
        End Set
    End Property
    Public Property Local() As String
        Get
            Return cLocal
        End Get
        Set(ByVal value As String)
            cLocal = value
        End Set
    End Property
    Public Property AparelhoFiscal() As String
        Get
            Return cAparelhoFiscal
        End Get
        Set(ByVal value As String)
            cAparelhoFiscal = value
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

        cSql = "Select * From Tbl_Patrimonio Where IDAparelho=" & cIDAparelho

        Dim ds As DataSet

        Dim DtFornecedor As New ClsDados()

        ds = DtFornecedor.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDAparelho = ds.Tables(0).Rows(0).Item(0).ToString
            Descricao = ds.Tables(0).Rows(0).Item(1).ToString
            Modelo = ds.Tables(0).Rows(0).Item(2).ToString
            Serie = ds.Tables(0).Rows(0).Item(3).ToString
            Tensao = ds.Tables(0).Rows(0).Item(4).ToString
            IDCor = ds.Tables(0).Rows(0).Item(5).ToString
            DataRegistro = ds.Tables(0).Rows(0).Item(6).ToString
            DataCompra = ds.Tables(0).Rows(0).Item(7).ToString
            DataAtendimento = ds.Tables(0).Rows(0).Item(8).ToString
            ValorCompra = ds.Tables(0).Rows(0).Item(9).ToString
            NotaFiscal = ds.Tables(0).Rows(0).Item(10).ToString
            Depreciacao = ds.Tables(0).Rows(0).Item(11).ToString
            IDRevendedor = ds.Tables(0).Rows(0).Item(12).ToString
            Local = ds.Tables(0).Rows(0).Item(13).ToString
            AparelhoFiscal = ds.Tables(0).Rows(0).Item(14).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(15).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(16).ToString

        End If

    End Sub

    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select (IDAparelho) From Tbl_Patrimonio order by IDAparelho desc Limit 1"

        Dim IdBuscado As Integer

        Dim DtPatrimonio As New ClsDados()

        IdBuscado = DtPatrimonio.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Editar()

        'Dim sValorCompra As String = cValorCompra.ToString
        'Dim sDepreciacao As String = cDepreciacao.ToString
        'sValorCompra = sValorCompra.Replace(",", ".")
        'sDepreciacao = sDepreciacao.Replace(",", ".")

        Dim strQuery As String

        strQuery = "Update Tbl_Patrimonio SET Descricao='" & cDescricao & "',Modelo='" & cModelo & "',Serie='" & cSerie & "', " & _
        " Tensao='" & cTensao & "',IDCor='" & cIDCor & "',DataRegistro='" & cDataRegistro & "', " & _
        " DataCompra='" & cDataCompra & "',DataAtendimento='" & cDataAtendimento & "',ValorCompra='" & cValorCompra & "', " & _
        " NotaFiscal='" & cNotaFiscal & "',Depreciacao='" & cDepreciacao & "',IDRevendedor='" & cIDRevendedor & "', " & _
        " Local='" & cLocal & "',AparelhoFiscal='" & cAparelhoFiscal & "', " & _
        " NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "' " & _
        " WHERE IDAparelho= " & cIDAparelho & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Patrimonio WHERE IDAparelho=" & cIDAparelho
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        'Dim sValorCompra As String = cValorCompra.ToString
        'Dim sDepreciacao As String = cDepreciacao.ToString
        'sValorCompra = sValorCompra.Replace(",", ".")
        'sDepreciacao = sDepreciacao.Replace(",", ".")

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Patrimonio(Descricao,Modelo,Serie,Tensao,IDCor,DataRegistro,DataCompra, " & _
        " DataAtendimento,ValorCompra,NotaFiscal,Depreciacao,IDRevendedor,Local,AparelhoFiscal, " & _
        " NomeUser,DataDigita)" & _
        " VALUES('" & cDescricao & "','" & cModelo & "','" & cSerie & "','" & cTensao & "', " & _
        " '" & cIDCor & "','" & cDataRegistro & "','" & cDataCompra & "','" & cDataAtendimento & "', " & _
        " '" & cValorCompra & "','" & cNotaFiscal & "','" & cDepreciacao & "','" & cIDRevendedor & "', " & _
        " '" & cLocal & "','" & cAparelhoFiscal & "', " & _
        " '" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDAparelho,Descricao,Serie From Tbl_Patrimonio where  " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

#End Region

End Class
