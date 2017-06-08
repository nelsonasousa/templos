Public Class ClsClasseAlunos
#Region "Variáveis"

    Private cIDClasse As Integer
    Private cIDPessoa As Integer
    Private cDataMatricula As String
    Private cDataBaixa As String
    Private cNomeClasse As String
    Private cNomeUser As String
    Private cDataDigita As String
    Private cContar_Presenca As Boolean

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDClasse As Integer, ByVal IDPessoa As String, ByVal DataMatricula As DateTime, _
                   ByVal DataBaixa As DateTime, ByVal NomeClasse As String, ByVal NomeUser As String, ByVal DataDigita As DateTime, _
                    ByVal Contar_Presenca As Boolean)
        Me.cIDClasse = IDClasse
        Me.cIDPessoa = IDPessoa
        Me.cDataMatricula = DataMatricula
        Me.cDataBaixa = DataBaixa
        Me.cNomeClasse = NomeClasse
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
        Me.cContar_Presenca = Contar_Presenca
    End Sub
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
    Public Property DataMatricula() As String
        Get
            Return cDataMatricula
        End Get
        Set(ByVal value As String)
            cDataMatricula = value
        End Set
    End Property
    Public Property DataBaixa() As String
        Get
            Return cDataBaixa
        End Get
        Set(ByVal value As String)
            cDataBaixa = value
        End Set
    End Property
    Public Property NomeClasse() As String
        Get
            Return cNomeClasse
        End Get
        Set(ByVal value As String)
            cNomeClasse = value
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
    Public Property Contar_Presenca() As Boolean
        Get
            Return cContar_Presenca
        End Get
        Set(ByVal value As Boolean)
            cContar_Presenca = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select * From Tbl_Pessoas_Grupos Where IDClasse=" & cIDClasse & " AND IDPessoa=" & cIDPessoa & " AND DataBaixa IS NULL"
        Dim ds As DataSet

        Dim DtGrupos As New ClsDados()

        ds = DtGrupos.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDClasse = ds.Tables(0).Rows(0).Item("IDClasse").ToString
            IDPessoa = ds.Tables(0).Rows(0).Item("IDPessoa").ToString
            DataMatricula = ds.Tables(0).Rows(0).Item("DataMatricula").ToString
            DataBaixa = ds.Tables(0).Rows(0).Item("DataBaixa").ToString
            NomeUser = ds.Tables(0).Rows(0).Item("NomeUser").ToString
            DataDigita = ds.Tables(0).Rows(0).Item("DataDigita").ToString
            Contar_Presenca = ds.Tables(0).Rows(0).Item("Contar_Presenca").ToString
        End If

    End Sub

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Pessoas_Grupos SET DataMatricula='" & cDataMatricula & "'," & _
        " NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "',Contar_Presenca=" & cContar_Presenca & " " & _
        " WHERE IDClasse=" & cIDClasse & " AND IDPessoa=" & cIDPessoa & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Pessoas_Grupos WHERE IDClasse=" & cIDClasse & " AND IDPessoa=" & cIDPessoa & ";"
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Pessoas_Grupos(IDClasse,IDPessoa,DataMatricula,NomeUser,DataDigita)" & _
        " VALUES(" & cIDClasse & "," & cIDPessoa & ",'" & cDataMatricula & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Baixar()

        Dim strQuery As String

        strQuery = "Update Tbl_Pessoas_Grupos SET DataBaixa='" & cDataBaixa & "'," & _
        " NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "' " & _
        " WHERE IDClasse=" & cIDClasse & " AND IDPessoa=" & cIDPessoa & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub BuscaMatricula()

        Dim cSql As String

        cSql = "SELECT Tbl_Pessoas_Grupos.IDClasse,Tbl_Classes.Classe FROM Tbl_Classes INNER JOIN Tbl_Pessoas_Grupos" & _
        " ON Tbl_Classes.IDClasse = Tbl_Pessoas_Grupos.IDClasse" & _
        " WHERE (Tbl_Classes.Escola = 'Sim') AND (Tbl_Pessoas_Grupos.DataBaixa IS NULL) AND IDPessoa=" & cIDPessoa & " "
        Dim ds As DataSet

        Dim DtGrupos As New ClsDados()

        ds = DtGrupos.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDClasse = ds.Tables(0).Rows(0).Item(0)
            NomeClasse = ds.Tables(0).Rows(0).Item(1)

        End If

    End Sub
    Public Function VerificaMatricula() As Boolean

        Dim cSql As String

        cSql = "SELECT Tbl_Pessoas_Grupos.IDClasse,Tbl_Classes.Classe FROM Tbl_Classes INNER JOIN Tbl_Pessoas_Grupos" & _
        " ON Tbl_Classes.IDClasse = Tbl_Pessoas_Grupos.IDClasse" & _
        " WHERE (Tbl_Classes.Escola = 'Sim') AND (Tbl_Pessoas_Grupos.DataBaixa IS NULL) AND IDPessoa=" & cIDPessoa & " "
        Dim ds As DataSet

        Dim DtGrupos As New ClsDados()

        ds = DtGrupos.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If

    End Function

    Public Function VerificaClasse() As Boolean

        Dim cSql As String

        cSql = "SELECT Tbl_Classes.IDClasse,Tbl_Classes.Classe FROM Tbl_Classes" & _
        " WHERE (Tbl_Classes.Escola = 'Sim') AND IDclasse=" & cIDClasse & ";"
        Dim ds As DataSet

        Dim DtGrupos As New ClsDados()

        ds = DtGrupos.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If

    End Function

#End Region
End Class
