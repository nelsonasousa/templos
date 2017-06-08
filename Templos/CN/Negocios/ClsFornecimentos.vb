Public Class ClsFornecimentos

#Region "Variáveis"
    Private cIDFornecimento As Integer
    Private cSigla As String
    Private cFornecimento As String
    Private cNomeUser As String
    Private cDataDigita As String
#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDFornecimento As Integer, ByVal Sigla As String, ByVal Descricao As String, ByVal NomeUser As String, ByVal DataDigita As DateTime)
        Me.cIDFornecimento = IDFornecimento
        Me.cSigla = Sigla
        Me.cFornecimento = Descricao
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub

    Public Property IDFornecimento() As Integer
        Get
            Return cIDFornecimento
        End Get
        Set(ByVal value As Integer)
            cIDFornecimento = value
        End Set
    End Property
    Public Property Sigla() As String
        Get
            Return cSigla
        End Get
        Set(ByVal value As String)
            cSigla = value
        End Set
    End Property
    Public Property Descricao() As String
        Get
            Return cFornecimento
        End Get
        Set(ByVal value As String)
            cFornecimento = value
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

#Region "Métodos da Classe Fornecimento"

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select * From Tbl_Unidade_Fornecimento Where IDFornecimento=" & cIDFornecimento
        Dim ds As DataSet

        Dim DtAgenda As New ClsDados()

        ds = DtAgenda.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDFornecimento = ds.Tables(0).Rows(0).Item(0).ToString
            Sigla = ds.Tables(0).Rows(0).Item(1).ToString
            Descricao = ds.Tables(0).Rows(0).Item(2).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(3).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(4).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDFornecimento) From Tbl_Unidade_Fornecimento order by IDFornecimento desc"

        Dim IdBuscado As Integer

        Dim DtAgenda As New ClsDados()

        IdBuscado = DtAgenda.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Unidade_Fornecimento SET Sigla='" & cSigla & "', " & _
        " Descricao='" & cFornecimento & "',NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDFornecimento= " & cIDFornecimento & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Unidade_Fornecimento WHERE IDFornecimento=" & cIDFornecimento
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Unidade_Fornecimento(Sigla,Descricao,NomeUser,DataDigita)" & _
        " VALUES('" & cSigla & "','" & cFornecimento & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDFornecimento,Sigla From Tbl_Unidade_Fornecimento where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

#End Region

End Class
