Public Class ClsTemplo
#Region "Variáveis"
    Private cIDTemplo As Integer
    Private cTemplo As String
    Private cEndereco As String
    Private cBairro As String
    Private cCEP As String
    Private cCidade As String
    Private cUF As String
    Private cTelefone As String
    Private cFax As String
    Private cSite As String
    Private cEmail As String
    Private cCNPJ As String
    Private cIE As String
    Private cMensagem As String
    Private cBRIndividual As String
    Private cLogoPath As String
    Private cNomeUser As String
    Private cDataDigita As String
#End Region

#Region "Propriedades"
    Public Sub New()
    End Sub
    Public Sub New(ByVal IDTemplo As Integer, ByVal Templo As String, ByVal Endereco As String, _
                   ByVal Bairro As String, ByVal CEP As String, ByVal Cidade As String, ByVal UF As String, _
                   ByVal Telefone As String, ByVal Fax As String, ByVal Site As String, _
                   ByVal Email As String, ByVal CNPJ As String, ByVal IE As String, ByVal Mensagem As String, _
                    ByVal BRIndividual As String, ByVal LogoPath As String, ByVal NomeUser As String, ByVal DataDigita As DateTime)

        Me.cIDTemplo = IDTemplo
        Me.cTemplo = Templo
        Me.cEndereco = Endereco
        Me.cBairro = Bairro
        Me.cCEP = CEP
        Me.cCidade = Cidade
        Me.cUF = UF
        Me.cTelefone = Telefone
        Me.cFax = Fax
        Me.cSite = Site
        Me.cEmail = Email
        Me.cCNPJ = CNPJ
        Me.cIE = IE
        Me.cMensagem = Mensagem
        Me.cBRIndividual = BRIndividual
        Me.cLogoPath = LogoPath
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub

    Public Property IDTemplo() As Integer
        Get
            Return cIDTemplo
        End Get
        Set(ByVal value As Integer)
            cIDTemplo = value
        End Set
    End Property
    Public Property Templo() As String
        Get
            Return cTemplo
        End Get
        Set(ByVal value As String)
            cTemplo = value
        End Set
    End Property
    Public Property Endereco() As String
        Get
            Return cEndereco
        End Get
        Set(ByVal value As String)
            cEndereco = value
        End Set
    End Property
    Public Property Bairro() As String
        Get
            Return cBairro
        End Get
        Set(ByVal value As String)
            cBairro = value
        End Set
    End Property
    Public Property CEP() As String
        Get
            Return cCEP
        End Get
        Set(ByVal value As String)
            cCEP = value
        End Set
    End Property
    Public Property Cidade() As String
        Get
            Return cCidade
        End Get
        Set(ByVal value As String)
            cCidade = value
        End Set
    End Property
    Public Property UF() As String
        Get
            Return cUF
        End Get
        Set(ByVal value As String)
            cUF = value
        End Set
    End Property
    Public Property Telefone() As String
        Get
            Return cTelefone
        End Get
        Set(ByVal value As String)
            cTelefone = value
        End Set
    End Property
    Public Property Fax() As String
        Get
            Return cFax
        End Get
        Set(ByVal value As String)
            cFax = value
        End Set
    End Property
    Public Property Site() As String
        Get
            Return cSite
        End Get
        Set(ByVal value As String)
            cSite = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return cEmail
        End Get
        Set(ByVal value As String)
            cEmail = value
        End Set
    End Property
    Public Property CNPJ() As String
        Get
            Return cCNPJ
        End Get
        Set(ByVal value As String)
            cCNPJ = value
        End Set
    End Property
    Public Property IE() As String
        Get
            Return cIE
        End Get
        Set(ByVal value As String)
            cIE = value
        End Set
    End Property
    Public Property Mensagem() As String
        Get
            Return cMensagem
        End Get
        Set(ByVal value As String)
            cMensagem = value
        End Set
    End Property
    Public Property BRIndividual() As String
        Get
            Return cBRIndividual
        End Get
        Set(ByVal value As String)
            cBRIndividual = value
        End Set
    End Property
    Public Property LogoPath() As String
        Get
            Return cLogoPath
        End Get
        Set(ByVal value As String)
            cLogoPath = value
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

#Region "Métodos da Classe Empresa"

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select * From Tbl_Templo Where IDTemplo=" & cIDTemplo
        Dim ds As DataSet

        Dim DtTemplo As New ClsDados()

        ds = DtTemplo.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDTemplo = ds.Tables(0).Rows(0).Item(0).ToString
            Templo = ds.Tables(0).Rows(0).Item(1).ToString
            Endereco = ds.Tables(0).Rows(0).Item(2).ToString
            Bairro = ds.Tables(0).Rows(0).Item(3).ToString
            CEP = ds.Tables(0).Rows(0).Item(4).ToString
            Cidade = ds.Tables(0).Rows(0).Item(5).ToString
            UF = ds.Tables(0).Rows(0).Item(6).ToString
            Telefone = ds.Tables(0).Rows(0).Item(7).ToString
            Fax = ds.Tables(0).Rows(0).Item(8).ToString
            Site = ds.Tables(0).Rows(0).Item(9).ToString
            Email = ds.Tables(0).Rows(0).Item(10).ToString
            CNPJ = ds.Tables(0).Rows(0).Item(11).ToString
            IE = ds.Tables(0).Rows(0).Item(12).ToString
            Mensagem = ds.Tables(0).Rows(0).Item(13).ToString
            BRIndividual = ds.Tables(0).Rows(0).Item(14).ToString
            LogoPath = ds.Tables(0).Rows(0).Item(15).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(16).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(17).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select (IDTemplo) From Tbl_Templo order by IDTemplo desc"

        Dim IdBuscado As Integer

        Dim DtTemplo As New ClsDados()

        IdBuscado = DtTemplo.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Templo SET Templo='" & cTemplo & "',Endereco='" & cEndereco & "', " & _
        " Bairro='" & cBairro & "',CEP='" & cCEP & "',Cidade='" & cCidade & "',UF='" & cUF & "', " & _
        " Telefone='" & cTelefone & "',FAX='" & cFax & "',Site='" & cSite & "',Email='" & cEmail & "', " & _
        " CNPJ='" & cCNPJ & "',IE='" & cIE & "'," & _
        " Mensagem='" & cMensagem & "',BRIndividual='" & cBRIndividual & "',LogoPath='" & cLogoPath & "',NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "' " & _
        " WHERE IDTemplo= " & cIDTemplo & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Templo WHERE IDTemplo=" & cIDTemplo
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Templo(Templo,Endereco,Bairro,CEP,Cidade,UF,Telefone,Fax,Site,Email," & _
        " CNPJ,IE,Mensagem,BRIndividual,LogoPath,NomeUser,DataDigita)" & _
        " VALUES('" & cTemplo & "','" & cEndereco & "','" & cBairro & "','" & cCEP & "','" & cCidade & "'," & _
        " '" & cUF & "','" & cTelefone & "','" & cFax & "','" & cSite & "','" & cEmail & "'," & _
        " '" & cCNPJ & "','" & cIE & "','" & cMensagem & "','" & cBRIndividual & "','" & cLogoPath & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select * From Tbl_Templo where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function
    Public Function BuscarBR() As String

        Dim cSql As String

        cSql = "Select BRIndividual From Tbl_Templo Where IDTemplo=" & cIDTemplo
        Dim ds As DataSet

        Dim DtTemplo As New ClsDados()

        ds = DtTemplo.RetornarDataSet(cSql)



        Return ds.Tables(0).Rows(0).Item(0)

    End Function

#End Region

End Class
