Public Class ClsForms
#Region "Variáveis"

    Private cIDForm As Integer
    Private cFormulario As String
    Private cDescricao As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDForm As Integer, ByVal Formulario As String, ByVal Descricao As String, _
     ByVal NomeUser As String, ByVal DataDigita As DateTime)
        Me.cIDForm = IDForm
        Me.cFormulario = Formulario
        Me.cDescricao = Descricao
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDForm() As Integer
        Get
            Return cIDForm
        End Get
        Set(ByVal value As Integer)
            cIDForm = value
        End Set
    End Property
    Public Property Formulario() As String
        Get
            Return cFormulario
        End Get
        Set(ByVal value As String)
            cFormulario = value
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

        cSql = "Select * From Tbl_Forms Where IDForm=" & cIDForm
        Dim ds As DataSet

        Dim DtForm As New ClsDados()

        ds = DtForm.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDForm = ds.Tables(0).Rows(0).Item(0).ToString
            Formulario = ds.Tables(0).Rows(0).Item(1).ToString
            Descricao = ds.Tables(0).Rows(0).Item(2).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(3).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(4).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDForm) From Tbl_Forms order by IDForm desc"

        Dim IdBuscado As Integer

        Dim DtForm As New ClsDados()

        IdBuscado = DtForm.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Forms SET Formulario='" & cFormulario & "', " & _
        " Descricao='" & cDescricao & "',NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDForm=" & cIDForm & ";"

        Dim BancoSGE As New ClsDados()

        BancoSGE.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Forms WHERE IDForm=" & cIDForm
        Dim BancoSGE As New ClsDados()

        BancoSGE.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Forms(Formulario,Descricao,NomeUser,DataDigita)" & _
        " VALUES('" & cFormulario & "','" & cDescricao & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGE As New ClsDados()

        BancoSGE.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDForm,Nome From Tbl_Forms where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGE As New ClsDados()

        ds = BancoSGE.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

#End Region

End Class
