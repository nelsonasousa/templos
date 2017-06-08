Public Class ClsDizimos
#Region "Variáveis"

    Private cIDDizimo As Integer
    Private cIDPessoa As String
    Private cDataDizimo As String
    Private cValorDizimo As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDDizimo As Integer, ByVal IDPessoa As Integer, ByVal DataDizimo As String, ByVal ValorDizimo As String, _
     ByVal NomeUser As String, ByVal DataDigita As DateTime)
        Me.cIDDizimo = IDDizimo
        Me.cIDPessoa = IDPessoa
        Me.cDataDizimo = DataDizimo
        Me.cValorDizimo = ValorDizimo
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDDizimo() As Integer
        Get
            Return cIDDizimo
        End Get
        Set(ByVal value As Integer)
            cIDDizimo = value
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
    Public Property DataDizimo() As String
        Get
            Return cDataDizimo
        End Get
        Set(ByVal value As String)
            cDataDizimo = value
        End Set
    End Property
    Public Property ValorDizimo() As String
        Get
            Return cValorDizimo
        End Get
        Set(ByVal value As String)
            cValorDizimo = value
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

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select * From Tbl_Dizimos Where IDDizimo=" & cIDDizimo
        Dim ds As DataSet

        Dim DtAgenda As New ClsDados()

        ds = DtAgenda.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDDizimo = ds.Tables(0).Rows(0).Item(0).ToString
            IDPessoa = ds.Tables(0).Rows(0).Item(1).ToString
            DataDizimo = ds.Tables(0).Rows(0).Item(2).ToString
            ValorDizimo = ds.Tables(0).Rows(0).Item(3).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(4).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(5).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDDizimo) From Tbl_Dizimos order by IDDizimo desc"

        Dim IdBuscado As Integer

        Dim DtAgenda As New ClsDados()

        IdBuscado = DtAgenda.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Dizimos SET IDPessoa='" & cIDPessoa & "', " & _
        " DataDizimo='" & cDataDizimo & "',ValorDizimo='" & cValorDizimo & "',NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDDizimo= " & cIDDizimo & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Dizimos WHERE IDDizimo=" & cIDDizimo
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Dizimos(IDPessoa,DataDizimo,ValorDizimo,NomeUser,DataDigita)" & _
        " VALUES('" & cIDPessoa & "','" & cDataDizimo & "','" & cValorDizimo & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDDizimo,IDPessoa From Tbl_Dizimos where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function
#End Region

End Class
