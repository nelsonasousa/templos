Public Class ClsCategorias
#Region "Variáveis"

    Private cIDCategoria As Integer
    Private cCategoria As String
    Private cTipoCategoria As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDCategoria As Integer, ByVal Categoria As String, ByVal TipoCategoria As String)
        Me.cIDCategoria = IDCategoria
        Me.cCategoria = Categoria
        Me.cTipoCategoria = TipoCategoria
    End Sub
    Public Property IDCategoria() As Integer
        Get
            Return cIDCategoria
        End Get
        Set(ByVal value As Integer)
            cIDCategoria = value
        End Set
    End Property
    Public Property Categoria() As String
        Get
            Return cCategoria
        End Get
        Set(ByVal value As String)
            cCategoria = value
        End Set
    End Property
    Public Property TipoCategoria() As String
        Get
            Return cTipoCategoria
        End Get
        Set(ByVal value As String)
            cTipoCategoria = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select * From Tbl_Categorias Where IDCategoria=" & cIDCategoria
        Dim ds As DataSet

        Dim DtCategoria As New ClsDados()

        ds = DtCategoria.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDCategoria = ds.Tables(0).Rows(0).Item(0).ToString
            Categoria = ds.Tables(0).Rows(0).Item(1).ToString
            TipoCategoria = ds.Tables(0).Rows(0).Item(2).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDCategoria) From Tbl_Categorias order by IDCategoria desc"

        Dim IdBuscado As Integer

        Dim DtCategoria As New ClsDados()

        IdBuscado = DtCategoria.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Categorias SET Categoria='" & cCategoria & "', " &
        " TipoCategoria='" & cTipoCategoria & "' WHERE IDCategoria= " & cIDCategoria & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Categorias WHERE IDCategoria=" & cIDCategoria
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Categorias(Categoria,TipoCategoria)" &
        " VALUES('" & cCategoria & "','" & cTipoCategoria & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDCategoria,Categoria From Tbl_Categorias where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

#End Region

End Class
