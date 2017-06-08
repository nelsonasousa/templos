Public Class ClsLivros
#Region "Variáveis"

    Private cIDLivro As Integer
    Private cTitulo As String
    Private cAutor As String
    Private cSinopse As String
    Private cDataCompra As String
    Private cObs As String
    Private cDisponivel As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDLivro As Integer, ByVal Titulo As String, ByVal Autor As String, ByVal Sinopse As String, _
     ByVal DataCompra As DateTime, ByVal Obs As String, ByVal Disponivel As String, ByVal NomeUser As String, ByVal DataDigita As DateTime)
        Me.cIDLivro = IDLivro
        Me.cTitulo = Titulo
        Me.cAutor = Autor
        Me.cSinopse = Sinopse
        Me.cDataCompra = DataCompra
        Me.cObs = Obs
        Me.cDisponivel = Disponivel
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDLivro() As Integer
        Get
            Return cIDLivro
        End Get
        Set(ByVal value As Integer)
            cIDLivro = value
        End Set
    End Property
    Public Property Titulo() As String
        Get
            Return cTitulo
        End Get
        Set(ByVal value As String)
            cTitulo = value
        End Set
    End Property
    Public Property Autor() As String
        Get
            Return cAutor
        End Get
        Set(ByVal value As String)
            cAutor = value
        End Set
    End Property
    Public Property Sinopse() As String
        Get
            Return cSinopse
        End Get
        Set(ByVal value As String)
            cSinopse = value
        End Set
    End Property
    Public Property DataCompra() As String
        Get
            Return cDataCompra
        End Get
        Set(ByVal value As String)
            cDataCompra = value
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
    Public Property Disponivel() As String
        Get
            Return cDisponivel
        End Get
        Set(ByVal value As String)
            cDisponivel = value
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

        cSql = "Select * From Tbl_Livros Where IDLivro=" & cIDLivro
        Dim ds As DataSet

        Dim DtLivro As New ClsDados()

        ds = DtLivro.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDLivro = ds.Tables(0).Rows(0).Item(0).ToString
            Titulo = ds.Tables(0).Rows(0).Item(1).ToString
            Autor = ds.Tables(0).Rows(0).Item(2).ToString
            Sinopse = ds.Tables(0).Rows(0).Item(3).ToString
            DataCompra = ds.Tables(0).Rows(0).Item(4).ToString
            Obs = ds.Tables(0).Rows(0).Item(5).ToString
            Disponivel = ds.Tables(0).Rows(0).Item(6).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(7).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(8).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDLivro) From Tbl_Livros order by IDLivro desc"

        Dim IdBuscado As Integer

        Dim DtLivro As New ClsDados()

        IdBuscado = DtLivro.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function
    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Livros SET Titulo='" & cTitulo & "', " & _
        " Autor='" & cAutor & "',Sinopse='" & cSinopse & "',DataCompra='" & cDataCompra & "'," & _
        " Obs='" & cObs & "',Disponivel='" & cDisponivel & "',NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDLivro= " & cIDLivro & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Livros WHERE IDLivro=" & cIDLivro
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Livros(Titulo,Autor,Sinopse,DataCompra,Obs,Disponivel," & _
        " NomeUser,DataDigita)" & _
        " VALUES('" & cTitulo & "','" & cAutor & "','" & cSinopse & "','" & cDataCompra & "'," & _
        " '" & cObs & "','" & cDisponivel & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDLivro,Titulo From Tbl_Livros where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function
    Public Sub EmprestarDevolver()

        Dim strQuery As String

        strQuery = "Update Tbl_Livros SET Disponivel='" & cDisponivel & "',NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDLivro= " & cIDLivro & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub


#End Region
End Class
