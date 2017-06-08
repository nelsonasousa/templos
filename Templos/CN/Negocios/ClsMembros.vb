Public Class ClsMembros

#Region "Variáveis"

    Private cIDPessoa As Integer
    Private cTipoPessoa As String
    Private cCNPJ As String
    Private cIE As String
    Private cPessoa As String
    Private cEndereco As String
    Private cBairro As String
    Private cCEP As String
    Private cCidade As String
    Private cUF As String
    Private cTelefone As String
    Private cFax As String
    Private cSite As String
    Private cEmail As String
    Private cCelular As String
    Private cIDPai As String
    Private cIDMae As String
    Private cNomePai As String
    Private cNomeMae As String
    Private cIDStatus As Integer
    Private cEstadoCivil As String
    Private cObs As String
    Private cSexo As String
    Private cDataNascimento As String
    Private cNomeUser As String
    Private cDataDigita As String
    Private cPermanente As Boolean

#End Region

#Region "Propriedades"
    Public Sub New()
    End Sub
    Public Sub New(ByVal IDPessoa As Integer, ByVal TipoPessoa As String, _
                   ByVal CNPJ As String, ByVal IE As String, ByVal Pessoa As String, ByVal Endereco As String, _
                   ByVal Bairro As String, ByVal CEP As String, ByVal Cidade As String, ByVal UF As String, _
                   ByVal Telefone As String, ByVal Fax As String, ByVal Site As String, ByVal Email As String, _
                   ByVal Celular As String, ByVal IDPai As Integer, ByVal IDMae As Integer, _
                   ByVal NomePai As String, ByVal NomeMae As String, ByVal DataNascimento As DateTime, _
                   ByVal IDStatus As Integer, ByVal EstadoCivil As String, ByVal Sexo As String, _
                   ByVal Obs As String, ByVal NomeUser As String, ByVal DataDigita As DateTime, ByVal Permanente As Boolean)

        Me.cIDPessoa = IDPessoa
        Me.cTipoPessoa = TipoPessoa
        Me.cCNPJ = CNPJ
        Me.cIE = IE
        Me.cPessoa = Pessoa
        Me.cEndereco = Endereco
        Me.cBairro = Bairro
        Me.cCEP = CEP
        Me.cCidade = Cidade
        Me.cUF = UF
        Me.cTelefone = Telefone
        Me.cFax = Fax
        Me.cSite = Site
        Me.cEmail = Email
        Me.cCelular = Celular
        Me.cIDPai = IDPai
        Me.cIDMae = IDMae
        Me.cNomePai = NomePai
        Me.cNomeMae = NomeMae
        Me.cIDStatus = IDStatus
        Me.cEstadoCivil = EstadoCivil
        Me.cObs = Obs
        Me.cSexo = Sexo
        Me.cDataNascimento = DataNascimento
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
        Me.cPermanente = Permanente

    End Sub

    Public Property IDPessoa() As Integer
        Get
            Return cIDPessoa
        End Get
        Set(ByVal value As Integer)
            cIDPessoa = value
        End Set
    End Property
    Public Property TipoPessoa() As String
        Get
            Return cTipoPessoa
        End Get
        Set(ByVal value As String)
            cTipoPessoa = value
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
    Public Property Pessoa() As String
        Get
            Return cPessoa
        End Get
        Set(ByVal value As String)
            cPessoa = value
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
    Public Property Celular() As String
        Get
            Return cCelular
        End Get
        Set(ByVal value As String)
            cCelular = value
        End Set
    End Property
    Public Property IDPai() As Integer
        Get
            Return cIDPai
        End Get
        Set(ByVal value As Integer)
            cIDPai = value
        End Set
    End Property
    Public Property IDMae() As Integer
        Get
            Return cIDMae
        End Get
        Set(ByVal value As Integer)
            cIDMae = value
        End Set
    End Property
    Public Property NomePai() As String
        Get
            Return cNomePai
        End Get
        Set(ByVal value As String)
            cNomePai = value
        End Set
    End Property
    Public Property NomeMae() As String
        Get
            Return cNomeMae
        End Get
        Set(ByVal value As String)
            cNomeMae = value
        End Set
    End Property
    Public Property EstadoCivil() As String
        Get
            Return cEstadoCivil
        End Get
        Set(ByVal value As String)
            cEstadoCivil = value
        End Set
    End Property
    Public Property IDStatus() As Integer
        Get
            Return cIDStatus
        End Get
        Set(ByVal value As Integer)
            cIDStatus = value
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
    Public Property Sexo() As String
        Get
            Return cSexo
        End Get
        Set(ByVal value As String)
            cSexo = value
        End Set
    End Property
    Public Property DataNascimento() As String
        Get
            Return cDataNascimento
        End Get
        Set(ByVal value As String)
            cDataNascimento = value
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
    Public Property Permanente() As Boolean
        Get
            Return cPermanente
        End Get
        Set(ByVal value As Boolean)
            cPermanente = value
        End Set
    End Property

#End Region

#Region "Métodos da Classe "

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select IDPessoa,TipoPessoa,CNPJ,IE,Pessoa,Endereco,Bairro,CEP,Cidade,UF,Telefone," & _
        " Fax,Site,Email,Celular,IDPai,IDMae,NomePai,NomeMae,IDStatus,EstadoCivil," & _
        " Obs,Sexo,DataNascimento,NomeUser,DataDigita,Permanente From Tbl_Pessoas Where IDPessoa=" & cIDPessoa

        Dim ds As DataSet

        Dim DtPessoas As New ClsDados()

        ds = DtPessoas.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDPessoa = ds.Tables(0).Rows(0).Item(0).ToString
            TipoPessoa = ds.Tables(0).Rows(0).Item(1).ToString
            CNPJ = ds.Tables(0).Rows(0).Item(2).ToString
            IE = ds.Tables(0).Rows(0).Item(3).ToString
            Pessoa = ds.Tables(0).Rows(0).Item(4).ToString
            Endereco = ds.Tables(0).Rows(0).Item(5).ToString
            Bairro = ds.Tables(0).Rows(0).Item(6).ToString
            CEP = ds.Tables(0).Rows(0).Item(7).ToString
            Cidade = ds.Tables(0).Rows(0).Item(8).ToString
            UF = ds.Tables(0).Rows(0).Item(9).ToString
            Telefone = ds.Tables(0).Rows(0).Item(10).ToString
            Fax = ds.Tables(0).Rows(0).Item(11).ToString
            Site = ds.Tables(0).Rows(0).Item(12).ToString
            Email = ds.Tables(0).Rows(0).Item(13).ToString
            Celular = ds.Tables(0).Rows(0).Item(14).ToString
            IDPai = ds.Tables(0).Rows(0).Item(15).ToString
            IDMae = ds.Tables(0).Rows(0).Item(16).ToString
            NomePai = ds.Tables(0).Rows(0).Item(17).ToString
            NomeMae = ds.Tables(0).Rows(0).Item(18).ToString
            IDStatus = ds.Tables(0).Rows(0).Item(19).ToString
            EstadoCivil = ds.Tables(0).Rows(0).Item(20).ToString
            Obs = ds.Tables(0).Rows(0).Item(21).ToString
            Sexo = ds.Tables(0).Rows(0).Item(22).ToString
            If IsDBNull(ds.Tables(0).Rows(0).Item(23).ToString) Or ds.Tables(0).Rows(0).Item(23).ToString = "" Then
                DataNascimento = Date.Today
            Else
                DataNascimento = ds.Tables(0).Rows(0).Item(23).ToString

            End If
            NomeUser = ds.Tables(0).Rows(0).Item(24).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(25).ToString
            Permanente = ds.Tables(0).Rows(0).Item("Permanente").ToString

        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select TOP 1 (IDPessoa) From Tbl_Pessoas order by IDPessoa desc"

        Dim IdBuscado As Integer

        Dim DtPessoas As New ClsDados()

        IdBuscado = DtPessoas.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Pessoas SET CNPJ='" & cCNPJ & "',IE='" & cIE & "', " & _
        " Pessoa='" & cPessoa & "',Endereco='" & cEndereco & "',Bairro='" & cBairro & "', " & _
        " CEP='" & cCEP & "',Cidade='" & cCidade & "',UF='" & cUF & "',Telefone='" & cTelefone & "', " & _
        " Fax='" & cFax & "',Site='" & cSite & "',Email='" & cEmail & "', " & _
        " Celular='" & cCelular & "',IDPai='" & cIDPai & "'," & _
        " IDMae='" & cIDMae & "',NomePai='" & cNomePai & "',NomeMae='" & cNomeMae & "'," & _
        " IDStatus='" & cIDStatus & "',EstadoCivil='" & cEstadoCivil & "', " & _
        " Obs='" & cObs & "',Sexo='" & cSexo & "',DataNascimento='" & cDataNascimento & "'," & _
        " NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "',Permanente=" & cPermanente & " " & _
        " WHERE IDPessoa= " & cIDPessoa & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Pessoas WHERE IDPessoa=" & cIDPessoa
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Pessoas(TipoPessoa,CNPJ,IE,Pessoa,Endereco,Bairro,CEP," & _
        " Cidade,UF,Telefone,Fax,Site,Email,Celular,IDPai,IDMae,NomePai,NomeMae," & _
        " IDStatus,EstadoCivil,Obs,Sexo,DataNascimento,NomeUser,DataDigita,Permanente)" & _
        " VALUES('" & cTipoPessoa & "','" & cCNPJ & "','" & cIE & "'," & _
        " '" & cPessoa & "','" & cEndereco & "','" & cBairro & "','" & cCEP & "','" & cCidade & "'," & _
        " '" & cUF & "','" & cTelefone & "','" & cFax & "','" & cSite & "','" & cEmail & "'," & _
        " '" & cCelular & " ','" & cIDPai & "','" & cIDMae & "','" & cNomePai & "'," & _
        " '" & cNomeMae & "','" & cIDStatus & "','" & cEstadoCivil & "','" & cObs & "','" & cSexo & "'," & _
        " '" & cDataNascimento & "','" & cNomeUser & "','" & cDataDigita & "'," & cPermanente & ");"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String) As DataSet
        Dim strQuery As String

        strQuery = "Select IDPessoa,Pessoa,CNPJ,IE From Tbl_Pessoas where IDPessoa<>1 AND " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function
    Public Sub MudaStatus()

        Dim strQuery As String

        strQuery = "Update Tbl_Pessoas SET IDStatus='" & cIDStatus & "'," & _
        " NomeUser='" & cNomeUser & "',DataDigita='" & cDataDigita & "' " & _
        " WHERE IDPessoa= " & cIDPessoa & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub

#End Region



End Class
