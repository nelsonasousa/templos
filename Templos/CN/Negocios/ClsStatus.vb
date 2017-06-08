Public Class ClsStatus

#Region "Variáveis"

    Private cIDStatus As Integer
    Private cStatus As String
    Private cMostra As Boolean
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDStatus As Integer, ByVal Status As String, ByVal Mostra As Boolean, _
     ByVal NomeUser As String, ByVal DataDigita As DateTime)
        Me.cIDStatus = IDStatus
        Me.cStatus = Status
        Me.cMostra = Mostra
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDStatus() As Integer
        Get
            Return cIDStatus
        End Get
        Set(ByVal value As Integer)
            cIDStatus = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return cStatus
        End Get
        Set(ByVal value As String)
            cStatus = value
        End Set
    End Property
    Public Property Mostra() As Boolean
        Get
            Return cMostra
        End Get
        Set(ByVal value As Boolean)
            cMostra = value
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

        cSql = "Select * From Tbl_Status Where IDStatus=" & cIDStatus
        Dim ds As DataSet

        Dim DtStatus As New ClsDados()

        ds = DtStatus.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDStatus = ds.Tables(0).Rows(0).Item("IDStatus").ToString
            Status = ds.Tables(0).Rows(0).Item("Status").ToString
            Mostra = ds.Tables(0).Rows(0).Item("Mostra").ToString
            NomeUser = ds.Tables(0).Rows(0).Item("NomeUser").ToString
            DataDigita = ds.Tables(0).Rows(0).Item("DataDigita").ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDStatus) From Tbl_Status order by IDStatus desc"

        Dim IdBuscado As Integer

        Dim DtStatus As New ClsDados()

        IdBuscado = DtStatus.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function
    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Status SET Status='" & cStatus & "',Mostra=" & cMostra & ", " & _
        " NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "' " & _
        " WHERE IDStatus= " & cIDStatus & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Status WHERE IDStatus=" & cIDStatus
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Status(Status,Mostra,NomeUser,DataDigita)" & _
        " VALUES('" & cStatus & "'," & cMostra & ",'" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDStatus,Status From Tbl_Status where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

#End Region

End Class
