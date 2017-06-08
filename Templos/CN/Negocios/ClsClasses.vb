Public Class ClsClasses

#Region "Variáveis"

    Private cIDClasse As Integer
    Private cClasse As String
    Private cEscola As String
    Private cIDProfessor As String
    Private cIDProfessor2 As String
    Private cIDProfessor3 As String
    Private cIDProfessor4 As String
    Private cDataCriacao As String
    Private cDataDesativa As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDClasse As Integer, ByVal Classe As String, ByVal Escola As String, _
                 ByVal IDProfessor As Integer, ByVal IDProfessor2 As Integer, ByVal IDProfessor3 As Integer, _
                 ByVal IDProfessor4 As Integer, ByVal DataCriacao As DateTime, _
                 ByVal DataDesativa As DateTime, ByVal NomeUser As String, ByVal DataDigita As DateTime)
        Me.cIDClasse = IDClasse
        Me.cClasse = Classe
        Me.cEscola = Escola
        Me.cIDProfessor = IDProfessor
        Me.cIDProfessor2 = IDProfessor2
        Me.cIDProfessor3 = IDProfessor3
        Me.cIDProfessor4 = IDProfessor4
        Me.cDataCriacao = DataCriacao
        Me.cDataDesativa = DataDesativa
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDClasse() As Integer
        Get
            Return cIDClasse
        End Get
        Set(ByVal value As Integer)
            cIDClasse = value
        End Set
    End Property
    Public Property Classe() As String
        Get
            Return cClasse
        End Get
        Set(ByVal value As String)
            cClasse = value
        End Set
    End Property
    Public Property Escola() As String
        Get
            Return cEscola
        End Get
        Set(ByVal value As String)
            cEscola = value
        End Set
    End Property
    Public Property IDProfessor() As Integer
        Get
            Return cIDProfessor
        End Get
        Set(ByVal value As Integer)
            cIDProfessor = value
        End Set
    End Property
    Public Property IDProfessor2() As Integer
        Get
            Return cIDProfessor2
        End Get
        Set(ByVal value As Integer)
            cIDProfessor2 = value
        End Set
    End Property
    Public Property IDProfessor3() As Integer
        Get
            Return cIDProfessor3
        End Get
        Set(ByVal value As Integer)
            cIDProfessor3 = value
        End Set
    End Property
    Public Property IDProfessor4() As Integer
        Get
            Return cIDProfessor4
        End Get
        Set(ByVal value As Integer)
            cIDProfessor4 = value
        End Set
    End Property
    Public Property DataCriacao() As String
        Get
            Return cDataCriacao
        End Get
        Set(ByVal value As String)
            cDataCriacao = value
        End Set
    End Property
    Public Property DataDesativa() As String
        Get
            Return cDataDesativa
        End Get
        Set(ByVal value As String)
            cDataDesativa = value
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

        cSql = "Select * From Tbl_Classes Where IDClasse=" & cIDClasse
        Dim ds As DataSet

        Dim DtClasse As New ClsDados()

        ds = DtClasse.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDClasse = ds.Tables(0).Rows(0).Item(0).ToString
            Classe = ds.Tables(0).Rows(0).Item(1).ToString
            Escola = ds.Tables(0).Rows(0).Item(2).ToString
            IDProfessor = ds.Tables(0).Rows(0).Item(3).ToString
            IDProfessor2 = ds.Tables(0).Rows(0).Item(4).ToString
            IDProfessor3 = ds.Tables(0).Rows(0).Item(5).ToString
            IDProfessor4 = ds.Tables(0).Rows(0).Item(6).ToString
            DataCriacao = ds.Tables(0).Rows(0).Item(7).ToString
            DataDesativa = ds.Tables(0).Rows(0).Item(8).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(9).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(10).ToString
        End If

    End Sub
    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Classes SET Classe='" & cClasse & "'," & _
        " Escola='" & cEscola & "',IDProfessor=" & cIDProfessor & ",IDProfessor2=" & cIDProfessor2 & "," & _
        " IDProfessor3=" & cIDProfessor3 & ",IDProfessor4=" & cIDProfessor4 & ",DataCriacao='" & cDataCriacao & "',NomeUser='" & cNomeUser & "'," & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDClasse= " & cIDClasse & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Classes WHERE IDClasse=" & cIDClasse
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Classes(Classe,Escola,IDProfessor,IDProfessor2,IDProfessor3,IDProfessor4,DataCriacao,NomeUser,DataDigita)" & _
        " VALUES('" & cClasse & "','" & cEscola & "','" & cIDProfessor & "','" & cIDProfessor2 & "','" & cIDProfessor3 & "','" & cIDProfessor4 & "','" & cDataCriacao & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDClasse,Classe From Tbl_Classes where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function
    Public Sub Desativar()

        Dim strQuery As String

        strQuery = "Update Tbl_Classes SET DataDesativa='" & cDataDesativa & "', " & _
        "NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "' " & _
        " WHERE IDClasse= " & cIDClasse & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub

#End Region
End Class
