Public Class ClsAtas
#Region "Variáveis"

    Private cIDAta As Integer
    Private cID_Classe As String
    Private cCodigo_Ata As String
    Private cData_Ata As String
    Private cPalavras_Chave As String
    Private cResumo_Ata As String
    Private cLivro As String
    Private cFolha As String
    Private cPasta As String
    Private cNome_Doc As String
    Private cQtde_Paginas As String
    Private cNome_User As String
    Private cData_Digita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDAta As Integer, ByVal ID_Classe As String, ByVal Codigo_Ata As String, ByVal Data_Ata As String, _
                   ByVal Palavras_Chave As String, ByVal Resumo_Ata As String, ByVal Livro As String, ByVal Folha As String, _
                   ByVal Pasta As String, ByVal Nome_Doc As String, ByVal Qtde_Paginas As String, ByVal Nome_User As String, ByVal Data_Digita As DateTime)
        Me.cIDAta = IDAta
        Me.cID_Classe = ID_Classe
        Me.cCodigo_Ata = Codigo_Ata
        Me.cData_Ata = Data_Ata
        Me.cPalavras_Chave = Palavras_Chave
        Me.cResumo_Ata = Resumo_Ata
        Me.cLivro = Livro
        Me.cFolha = Folha
        Me.cPasta = Pasta
        Me.cNome_Doc = Nome_Doc
        Me.cQtde_Paginas = Qtde_Paginas
        Me.cNome_User = Nome_User
        Me.cData_Digita = Data_Digita
    End Sub
    Public Property IDAta() As Integer
        Get
            Return cIDAta
        End Get
        Set(ByVal value As Integer)
            cIDAta = value
        End Set
    End Property
    Public Property ID_Classe() As String
        Get
            Return cID_Classe
        End Get
        Set(ByVal value As String)
            cID_Classe = value
        End Set
    End Property
    Public Property Codigo_Ata() As String
        Get
            Return cCodigo_Ata
        End Get
        Set(ByVal value As String)
            cCodigo_Ata = value
        End Set
    End Property
    Public Property Data_Ata() As String
        Get
            Return cData_Ata
        End Get
        Set(ByVal value As String)
            cData_Ata = value
        End Set
    End Property
    Public Property Palavras_Chave() As String
        Get
            Return cPalavras_Chave
        End Get
        Set(ByVal value As String)
            cPalavras_Chave = value
        End Set
    End Property
    Public Property Resumo_Ata() As String
        Get
            Return cResumo_Ata
        End Get
        Set(ByVal value As String)
            cResumo_Ata = value
        End Set
    End Property
    Public Property Livro() As String
        Get
            Return cLivro
        End Get
        Set(ByVal value As String)
            cLivro = value
        End Set
    End Property
    Public Property Folha() As String
        Get
            Return cFolha
        End Get
        Set(ByVal value As String)
            cFolha = value
        End Set
    End Property
    Public Property Pasta() As String
        Get
            Return cPasta
        End Get
        Set(ByVal value As String)
            cPasta = value
        End Set
    End Property
    Public Property Nome_Doc() As String
        Get
            Return cNome_Doc
        End Get
        Set(ByVal value As String)
            cNome_Doc = value
        End Set
    End Property
    Public Property Qtde_Paginas() As String
        Get
            Return cQtde_Paginas
        End Get
        Set(ByVal value As String)
            cQtde_Paginas = value
        End Set
    End Property
    Public Property Nome_User() As String
        Get
            Return cNome_User
        End Get
        Set(ByVal value As String)
            cNome_User = value
        End Set
    End Property
    Public Property Data_Digita() As String
        Get
            Return cData_Digita
        End Get
        Set(ByVal value As String)
            cData_Digita = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select * From Tbl_Atas Where IDAta=" & cIDAta
        Dim ds As DataSet

        Dim DtAgenda As New ClsDados()

        ds = DtAgenda.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDAta = ds.Tables(0).Rows(0).Item("IDAta").ToString
            ID_Classe = ds.Tables(0).Rows(0).Item("ID_Classe").ToString
            Codigo_Ata = ds.Tables(0).Rows(0).Item("Codigo_Ata").ToString
            Data_Ata = ds.Tables(0).Rows(0).Item("Data_Ata").ToString
            Palavras_Chave = ds.Tables(0).Rows(0).Item("Palavras_Chave").ToString
            Resumo_Ata = ds.Tables(0).Rows(0).Item("Resumo_Ata").ToString
            Livro = ds.Tables(0).Rows(0).Item("Livro").ToString
            Folha = ds.Tables(0).Rows(0).Item("Folha").ToString
            Pasta = ds.Tables(0).Rows(0).Item("Pasta").ToString
            Nome_Doc = ds.Tables(0).Rows(0).Item("Nome_Doc").ToString
            Qtde_Paginas = ds.Tables(0).Rows(0).Item("Qtde_Paginas").ToString
            Nome_User = ds.Tables(0).Rows(0).Item("Nome_User").ToString
            Data_Digita = ds.Tables(0).Rows(0).Item("Data_Digita").ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDAta) From Tbl_Atas order by IDAta desc"

        Dim IdBuscado As Integer

        Dim DtAgenda As New ClsDados()

        IdBuscado = DtAgenda.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Busca_Ultima_Ata()

        Dim cSql As String

        cSql = "Select TOP 1 * From Tbl_Atas Where ID_Classe=" & cID_Classe & " ORDER BY IDAta DESC"
        Dim ds As DataSet

        Dim DtAgenda As New ClsDados()

        ds = DtAgenda.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDAta = ds.Tables(0).Rows(0).Item("IDAta").ToString
            ID_Classe = ds.Tables(0).Rows(0).Item("ID_Classe").ToString
            Codigo_Ata = ds.Tables(0).Rows(0).Item("Codigo_Ata").ToString
            Data_Ata = ds.Tables(0).Rows(0).Item("Data_Ata").ToString
            Palavras_Chave = ds.Tables(0).Rows(0).Item("Palavras_Chave").ToString
            Resumo_Ata = ds.Tables(0).Rows(0).Item("Resumo_Ata").ToString
            Livro = ds.Tables(0).Rows(0).Item("Livro").ToString
            Folha = ds.Tables(0).Rows(0).Item("Folha").ToString
            Pasta = ds.Tables(0).Rows(0).Item("Pasta").ToString
            Nome_Doc = ds.Tables(0).Rows(0).Item("Nome_Doc").ToString
            Qtde_Paginas = ds.Tables(0).Rows(0).Item("Qtde_Paginas").ToString
            Nome_User = ds.Tables(0).Rows(0).Item("Nome_User").ToString
            Data_Digita = ds.Tables(0).Rows(0).Item("Data_Digita").ToString
        End If

    End Sub

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Atas SET ID_Classe=" & cID_Classe & ",Codigo_Ata='" & cCodigo_Ata & "',Data_Ata='" & cData_Ata & "'," & _
            " Palavras_Chave='" & cPalavras_Chave & "',Resumo_Ata='" & cResumo_Ata & "',Livro=" & cLivro & ",Folha=" & cFolha & "," & _
            " Pasta='" & cPasta & "',Nome_Doc='" & cNome_Doc & "',Qtde_Paginas=" & cQtde_Paginas & ",Nome_User='" & cNome_User & "', Data_Digita='" & cData_Digita & "' " & _
            " WHERE IDAta= " & cIDAta & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Atas WHERE IDAta=" & cIDAta
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Atas(ID_Classe,Codigo_Ata,Data_Ata,Palavras_Chave,Resumo_Ata,Livro,Folha,Pasta,Nome_Doc," & _
            " Qtde_Paginas,Nome_User,Data_Digita)" & _
        " VALUES(" & cID_Classe & ",'" & cCodigo_Ata & "','" & cData_Ata & "','" & cPalavras_Chave & "','" & cResumo_Ata & "'," & cLivro & "," & _
        " " & cFolha & ",'" & cPasta & "','" & cNome_Doc & "'," & cQtde_Paginas & ",'" & cNome_User & "','" & cData_Digita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDAta,ID_Classe From Tbl_Atas where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

#End Region

End Class
