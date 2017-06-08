
Public Class clsAgenda

#Region "Variáveis"

    Private cIDAgenda As Integer
    Private cNome As String
    Private cTelefone As String
    Private cObs As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDAgenda As Integer, ByVal Nome As String, ByVal Telefone As String, ByVal Obs As String, _
     ByVal NomeUser As String, ByVal DataDigita As DateTime)
        Me.cIDAgenda = IDAgenda
        Me.cNome = Nome
        Me.cTelefone = Telefone
        Me.cObs = Obs
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDAgenda() As Integer
        Get
            Return cIDAgenda
        End Get
        Set(ByVal value As Integer)
            cIDAgenda = value
        End Set
    End Property
    Public Property Nome() As String
        Get
            Return cNome
        End Get
        Set(ByVal value As String)
            cNome = value
        End Set
    End Property
    Public Property Telefone() As String
        Get
            Return cTelefone
        End Get
        Set(ByVal value As String)
            cTelefone = value
        End Set
    End Property
    Public Property Obs() As String
        Get
            Return cObs
        End Get
        Set(ByVal value As String)
            cObs = value
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

        cSql = "Select * From Tbl_Agenda Where IDAgenda=" & cIDAgenda
        Dim ds As DataSet

        Dim DtAgenda As New ClsDados()

        ds = DtAgenda.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDAgenda = ds.Tables(0).Rows(0).Item(0).ToString
            Nome = ds.Tables(0).Rows(0).Item(1).ToString
            Telefone = ds.Tables(0).Rows(0).Item(2).ToString
            Obs = ds.Tables(0).Rows(0).Item(3).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(4).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(5).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDAgenda) From Tbl_Agenda order by IDAgenda desc"

        Dim IdBuscado As Integer

        Dim DtAgenda As New ClsDados()

        IdBuscado = DtAgenda.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Agenda SET Nome='" & cNome & "', " & _
        " Telefone='" & cTelefone & "',Obs='" & cObs & "',NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDAgenda= " & cIDAgenda & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Agenda WHERE IDAgenda=" & cIDAgenda
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Agenda(Nome,Telefone,Obs,NomeUser,DataDigita)" & _
        " VALUES('" & cNome & "','" & cTelefone & "','" & cObs & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDAgenda,Nome From Tbl_Agenda where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

#End Region

End Class