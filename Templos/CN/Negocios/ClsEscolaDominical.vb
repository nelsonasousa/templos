Public Class ClsEscolaDominical
#Region "Variáveis"

    Private cIDEscola As Integer
    Private cDataEscola As String
    Private cTotalMatriculados As Integer
    Private cAlunosPresentes As Integer
    Private cVisitantes As Integer
    Private cBiblias As Integer
    Private cRevistas As Integer
    Private cOfertas As Decimal

    Private cIDClasse As Integer

    Private cIDPessoa As Integer
    Private cPresente As String
    Private cBiblia As String
    Private cRevista As String

    Private cNomeUser As String
    Private cDataDigita As String
    Private cDataFechamento As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDEscola As Integer, ByVal DataEscola As DateTime, ByVal TotalMatriculados As Integer, _
                   ByVal AlunosPresentes As Integer, ByVal Visitantes As Integer, _
                    ByVal Biblias As Integer, ByVal Revistas As Integer, ByVal Ofertas As Decimal, _
                     ByVal IDClasse As Integer, ByVal IDPessoa As Integer, ByVal Presente As String, _
                      ByVal Biblia As String, ByVal Revista As String, ByVal NomeUser As String, ByVal DataDigita As DateTime)

        Me.cIDEscola = IDEscola
        Me.cDataEscola = DataEscola
        Me.cTotalMatriculados = TotalMatriculados
        Me.cAlunosPresentes = AlunosPresentes
        Me.cVisitantes = Visitantes
        Me.cBiblias = Biblias
        Me.cRevistas = Revistas
        Me.cOfertas = Ofertas
        Me.cIDClasse = IDClasse
        Me.cIDPessoa = IDPessoa
        Me.cPresente = Presente
        Me.cBiblia = Biblia
        Me.cRevista = Revista
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDEscola() As Integer
        Get
            Return cIDEscola
        End Get
        Set(ByVal value As Integer)
            cIDEscola = value
        End Set
    End Property
    Public Property DataEscola() As String
        Get
            Return cDataEscola
        End Get
        Set(ByVal value As String)
            cDataEscola = value
        End Set
    End Property
    Public Property TotalMatriculados() As String
        Get
            Return cTotalMatriculados
        End Get
        Set(ByVal value As String)
            cTotalMatriculados = value
        End Set
    End Property
    Public Property AlunosPresentes() As Integer
        Get
            Return cAlunosPresentes
        End Get
        Set(ByVal value As Integer)
            cAlunosPresentes = value
        End Set
    End Property
    Public Property Visitantes() As Integer
        Get
            Return cVisitantes
        End Get
        Set(ByVal value As Integer)
            cVisitantes = value
        End Set
    End Property
    Public Property Biblias() As Integer
        Get
            Return cBiblias
        End Get
        Set(ByVal value As Integer)
            cBiblias = value
        End Set
    End Property
    Public Property Revistas() As Integer
        Get
            Return cRevistas
        End Get
        Set(ByVal value As Integer)
            cRevistas = value
        End Set
    End Property
    Public Property Ofertas() As String
        Get
            Return cOfertas
        End Get
        Set(ByVal value As String)
            cOfertas = value
        End Set
    End Property
    Public Property IDClasse() As Integer
        Get
            Return cIDClasse
        End Get
        Set(ByVal value As Integer)
            cIDClasse = value
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
    Public Property Presente() As String
        Get
            Return cPresente
        End Get
        Set(ByVal value As String)
            cPresente = value
        End Set
    End Property
    Public Property Biblia() As String
        Get
            Return cBiblia
        End Get
        Set(ByVal value As String)
            cBiblia = value
        End Set
    End Property
    Public Property Revista() As String
        Get
            Return cRevista
        End Get
        Set(ByVal value As String)
            cRevista = value
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
    Public Property DataFechamento() As String
        Get
            Return cDataFechamento
        End Get
        Set(ByVal value As String)
            cDataFechamento = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select * From Tbl_Escola_Dominical Where IDEscola=" & cIDEscola
        Dim ds As DataSet

        Dim DtEscola As New ClsDados()

        ds = DtEscola.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDEscola = ds.Tables(0).Rows(0).Item("IDEscola").ToString
            DataEscola = ds.Tables(0).Rows(0).Item("DataEscola").ToString
            TotalMatriculados = ds.Tables(0).Rows(0).Item("TotalMatriculados").ToString
            AlunosPresentes = ds.Tables(0).Rows(0).Item("AlunosPresentes").ToString
            Visitantes = ds.Tables(0).Rows(0).Item("Visitantes").ToString
            Biblias = ds.Tables(0).Rows(0).Item("Biblias").ToString
            Revistas = ds.Tables(0).Rows(0).Item("Revistas").ToString
            Ofertas = ds.Tables(0).Rows(0).Item("Ofertas").ToString
            NomeUser = ds.Tables(0).Rows(0).Item("NomeUser").ToString
            DataDigita = ds.Tables(0).Rows(0).Item("DataDigita").ToString
            DataFechamento = ds.Tables(0).Rows(0).Item("DataFechamento").ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDEscola) From Tbl_Escola_Dominical order by IDEscola desc"

        Dim IdBuscado As Integer

        Dim DtEscola As New ClsDados()

        IdBuscado = DtEscola.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function
    Public Sub BuscarData()

        Dim cSql As String

        cSql = "Select * From Tbl_Escola_Dominical Where DataEscola=#" & cDataEscola & "#;"
        Dim ds As DataSet

        Dim DtEscola As New ClsDados()

        ds = DtEscola.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDEscola = ds.Tables(0).Rows(0).Item("IDEscola").ToString
            DataEscola = ds.Tables(0).Rows(0).Item("DataEscola").ToString
            TotalMatriculados = ds.Tables(0).Rows(0).Item("TotalMatriculados").ToString
            AlunosPresentes = ds.Tables(0).Rows(0).Item("AlunosPresentes").ToString
            Visitantes = ds.Tables(0).Rows(0).Item("Visitantes").ToString
            Biblias = ds.Tables(0).Rows(0).Item("Biblias").ToString
            Revistas = ds.Tables(0).Rows(0).Item("Revistas").ToString
            Ofertas = ds.Tables(0).Rows(0).Item("Ofertas").ToString
            NomeUser = ds.Tables(0).Rows(0).Item("NomeUser").ToString
            DataDigita = ds.Tables(0).Rows(0).Item("DataDigita").ToString
            DataFechamento = ds.Tables(0).Rows(0).Item("DataFechamento").ToString
        End If

    End Sub

    Public Sub Editar()

        'Dim sOfertas As String = cOfertas.ToString
        'sOfertas = sOfertas.Replace(",", ".")

        Dim strQuery As String

        strQuery = "Update Tbl_Escola_Dominical SET TotalMatriculados='" & cTotalMatriculados & "'," & _
        " AlunosPresentes='" & cAlunosPresentes & "',Visitantes='" & cVisitantes & "'," & _
        " Biblias='" & cBiblias & "', Revistas='" & cRevistas & "',Ofertas='" & cOfertas & "'," & _
        " DataFechamento='" & cDataFechamento & "',NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "' " & _
        " WHERE IDEscola= " & cIDEscola & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Escola_Dominical WHERE IDEscola=" & cIDEscola
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Escola_Dominical(DataEscola,TotalMatriculados,NomeUser,DataDigita)" & _
        " VALUES('" & cDataEscola & "','" & cTotalMatriculados & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDEscola,DataEscola From Tbl_Escola_Dominical where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

    Public Sub InsereClasse()
        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Escola_Dominical_Det(IDEscola,IDClasse,TotalMatriculados,AlunosPresentes," & _
        " Biblias,Revistas,NomeUser,DataDigita)" & _
        " VALUES('" & cIDEscola & "','" & cIDClasse & "','" & cTotalMatriculados & "','" & cAlunosPresentes & "','" & cBiblias & "','" & cRevistas & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub EditaClasse()
        'Dim sValorOferta As String = cOfertas.ToString
        'sValorOferta = Replace(sValorOferta, ",", ".")

        Dim strQuery As String

        strQuery = "Update Tbl_Escola_Dominical_Det SET TotalMatriculados='" & cTotalMatriculados & "'," & _
        " AlunosPresentes='" & cAlunosPresentes & "',Visitantes='" & cVisitantes & "'," & _
        " Biblias='" & cBiblias & "', " & _
        " Revistas='" & cRevistas & "',Ofertas='" & cOfertas & "'," & _
        " NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "' " & _
        " WHERE IDEscola= " & cIDEscola & " AND IDClasse=" & cIDClasse & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Exclui_Todas_Classes_Domingo()
        'Dim sValorOferta As String = cOfertas.ToString
        'sValorOferta = Replace(sValorOferta, ",", ".")

        Dim strQuery As String

        strQuery = "DELETE * FROM Tbl_Escola_Dominical_Det WHERE IDEscola= " & cIDEscola & " ;"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Exclui_Classe_Domingo()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Escola_Dominical_Det WHERE IDEscola=" & cIDEscola & " AND IDClasse=" & cIDClasse & ";"
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub

    Public Function RetonaPresentes() As Integer
        Dim cSql As String

        cSql = "Select count(IDEscola) From Tbl_Escola_Dominical_Presenca Where IDEscola=" & cIDEscola & "" & _
        " AND IDClasse=" & cIDClasse & " AND Presente='Sim'"
        Dim ds As DataSet

        Dim DtEscola As New ClsDados()

        ds = DtEscola.RetornarDataSet(cSql)


        Return ds.Tables(0).Rows(0).Item(0)

    End Function
    Public Function RetonaBiblias() As Integer
        Dim cSql As String

        cSql = "Select count(IDEscola) From Tbl_Escola_Dominical_Presenca Where IDEscola=" & cIDEscola & "" & _
        " AND IDClasse=" & cIDClasse & " AND Biblia='Sim'"
        Dim ds As DataSet

        Dim DtEscola As New ClsDados()

        ds = DtEscola.RetornarDataSet(cSql)


        Return ds.Tables(0).Rows(0).Item(0)

    End Function
    Public Function RetonaRevistas() As Integer
        Dim cSql As String

        cSql = "Select count(IDEscola) From Tbl_Escola_Dominical_Presenca Where IDEscola=" & cIDEscola & "" & _
        " AND IDClasse=" & cIDClasse & " AND Revista='Sim'"
        Dim ds As DataSet

        Dim DtEscola As New ClsDados()

        ds = DtEscola.RetornarDataSet(cSql)


        Return ds.Tables(0).Rows(0).Item(0)

    End Function

    Public Sub InsereAluno()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Escola_Dominical_Presenca(IDEscola,IDPessoa,IDClasse,DataEscola,Presente,Biblia,Revista,NomeUser,DataDigita)" & _
        " VALUES('" & cIDEscola & "','" & cIDPessoa & "','" & cIDClasse & "','" & cDataEscola & "','" & cPresente & "','" & Biblia & "','" & cRevista & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub BuscaAluno()

        Dim cSql As String

        cSql = "Select * From Tbl_Escola_Dominical_Presenca Where IDEscola=" & cIDEscola & " AND IDPessoa=" & cIDPessoa & " AND IDClasse=" & cIDClasse & ""
        Dim ds As DataSet

        Dim DtEscola As New ClsDados()

        ds = DtEscola.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDEscola = ds.Tables(0).Rows(0).Item(0)
            IDPessoa = ds.Tables(0).Rows(0).Item(1)
            IDClasse = ds.Tables(0).Rows(0).Item(2)
            DataEscola = ds.Tables(0).Rows(0).Item(3)
            Presente = ds.Tables(0).Rows(0).Item(4)
            Biblia = ds.Tables(0).Rows(0).Item(5)
            Revista = ds.Tables(0).Rows(0).Item(6)
            NomeUser = ds.Tables(0).Rows(0).Item(7)
            DataDigita = ds.Tables(0).Rows(0).Item(8)
        End If

    End Sub
    Public Sub Exclui_Todos_Alunos_Domingo()
        'Dim sValorOferta As String = cOfertas.ToString
        'sValorOferta = Replace(sValorOferta, ",", ".")

        Dim strQuery As String

        strQuery = "DELETE * FROM Tbl_Escola_Dominical_Presenca WHERE IDEscola= " & cIDEscola & " ;"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub

    Public Sub EditaPresenca()

        Dim strQuery As String

        strQuery = "Update Tbl_Escola_Dominical_Presenca SET Presente='" & cPresente & "',Biblia='" & cBiblia & "'," & _
        " Revista='" & cRevista & "',NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "' " & _
        " WHERE IDEscola= " & cIDEscola & " AND IDPessoa=" & cIDPessoa & " AND IDClasse=" & cIDClasse & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Exclui_Aluno()

        Dim strQuery As String

        strQuery = "Delete FROM Tbl_Escola_Dominical_Presenca  WHERE IDEscola= " & cIDEscola & " AND IDPessoa=" & cIDPessoa & " AND IDClasse=" & cIDClasse & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub

#End Region

End Class
