Public Class ClsAvisos
#Region "Variáveis"

    Private cIDAviso As Integer
    Private cIDEscola As Integer
    Private cAviso As String
    Private CObs As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDAviso As Integer, ByVal IDEscola As Integer, ByVal Aviso As String, _
      ByVal Obs As String, ByVal NomeUser As String, ByVal DataDigita As DateTime)
        Me.cIDAviso = IDAviso
        Me.cIDEscola = IDEscola
        Me.cAviso = Aviso
        Me.CObs = Obs
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDAviso() As Integer
        Get
            Return cIDAviso
        End Get
        Set(ByVal value As Integer)
            cIDAviso = value
        End Set
    End Property
    Public Property IDEscola() As Integer
        Get
            Return cIDEscola
        End Get
        Set(ByVal value As Integer)
            cIDEscola = value
        End Set
    End Property
    Public Property Aviso() As String
        Get
            Return cAviso
        End Get
        Set(ByVal value As String)
            cAviso = value
        End Set
    End Property
    Public Property Obs() As String
        Get
            Return CObs
        End Get
        Set(ByVal value As String)
            CObs = value
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

        cSql = "Select * From Tbl_Avisos Where IDAviso=" & cIDAviso
        Dim ds As DataSet

        Dim DtAvisos As New ClsDados()

        ds = DtAvisos.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDAviso = ds.Tables(0).Rows(0).Item(0).ToString
            IDEscola = ds.Tables(0).Rows(0).Item(1).ToString
            Aviso = ds.Tables(0).Rows(0).Item(2).ToString
            Obs = ds.Tables(0).Rows(0).Item(3).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(4).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(5).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDAviso) From Tbl_Avisos order by IDAviso desc"

        Dim IdBuscado As Integer

        Dim DtAvisos As New ClsDados()

        IdBuscado = DtAvisos.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Avisos SET IDEscola='" & cIDEscola & "', " & _
        " Aviso='" & cAviso & "',Obs='" & CObs & "',NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDAviso= " & cIDAviso & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Avisos WHERE IDAviso=" & cIDAviso
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Avisos(IDEscola,Aviso,Obs,NomeUser,DataDigita)" & _
        " VALUES('" & cIDEscola & "','" & cAviso & "','" & cObs & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDAviso,IDEscola From Tbl_Avisos where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

#End Region

End Class
