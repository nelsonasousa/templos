Public Class ClsOcorrencias
#Region "Variáveis"

    Private cIDOcorrencia As Integer
    Private cIDPessoa As Integer
    Private cOcorrencia As String
    Private cDataOcorrencia As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDOcorrencia As Integer, ByVal IDPessoa As Integer, _
                   ByVal Ocorrencia As String, ByVal DataOcorrencia As DateTime, _
                   ByVal NomeUser As String, ByVal DataDigita As DateTime)

        Me.cIDOcorrencia = IDOcorrencia
        Me.cIDPessoa = IDPessoa
        Me.cOcorrencia = Ocorrencia
        Me.cDataOcorrencia = DataOcorrencia
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDOcorrencia() As Integer
        Get
            Return cIDOcorrencia
        End Get
        Set(ByVal value As Integer)
            cIDOcorrencia = value
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
    Public Property Ocorrencia() As String
        Get
            Return cOcorrencia
        End Get
        Set(ByVal value As String)
            cOcorrencia = value
        End Set
    End Property
    Public Property DataOcorrencia() As String
        Get
            Return cDataOcorrencia
        End Get
        Set(ByVal value As String)
            cDataOcorrencia = value
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

        cSql = "Select * From Tbl_Ocorrencias Where IDOcorrencia=" & cIDOcorrencia
        Dim ds As DataSet

        Dim DtOcorrencia As New ClsDados()

        ds = DtOcorrencia.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDOcorrencia = ds.Tables(0).Rows(0).Item(0).ToString
            Ocorrencia = ds.Tables(0).Rows(0).Item(1).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(2).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(3).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDOcorrencia) From Tbl_Ocorrencias order by IDOcorrencia desc"

        Dim IdBuscado As Integer

        Dim DtOcorrencia As New ClsDados()

        IdBuscado = DtOcorrencia.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function
    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Ocorrencias SET Ocorrencia='" & cOcorrencia & "', " & _
        " NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "' " & _
        " WHERE IDOcorrencia= " & cIDOcorrencia & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Ocorrencias WHERE IDOcorrencia=" & cIDOcorrencia
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Ocorrencias(Ocorrencia,NomeUser,DataDigita)" & _
        " VALUES('" & cOcorrencia & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDOcorrencia,Ocorrencia From Tbl_Ocorrencias where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

    Public Sub IncluirOcorrencia()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Pessoas_Ocorrencias(IDOcorrencia,IDPessoa,DataOcorrencia," & _
        " NomeUser,DataDigita)" & _
        " VALUES('" & cIDOcorrencia & "','" & cIDPessoa & "','" & cDataOcorrencia & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub


#End Region

End Class
