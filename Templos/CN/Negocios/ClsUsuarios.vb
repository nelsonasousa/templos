Public Class ClsUsuarios


    Private cIDUsuario As Integer
    Private cUsuario As String
    Private cSenha As String
    Private cNomeUser As String
    Private cDataDigita As String



    Public Sub New()
    End Sub
    Public Sub New(ByVal IDUsuario As Integer, ByVal Usuario As String, ByVal Senha As String, _
                    ByVal NomeUser As String, ByVal DataDigita As DateTime)

        Me.cIDUsuario = IDUsuario
        Me.cUsuario = Usuario
        Me.cSenha = Senha
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita

    End Sub
    Public Property IDUsuario() As Integer
        Get
            Return cIDUsuario
        End Get
        Set(ByVal value As Integer)
            cIDUsuario = value
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return cUsuario
        End Get
        Set(ByVal value As String)
            cUsuario = value
        End Set
    End Property
    Public Property Senha() As String
        Get
            Return cSenha
        End Get
        Set(ByVal value As String)
            cSenha = value
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

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select IDUser,Usuario,Senha,NomeUser,DataDigita From Tbl_Usuarios Where IDUser=" & cIDUsuario
        Dim ds As DataSet

        Dim DtUsuario As New ClsDados()

        ds = DtUsuario.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDUsuario = ds.Tables(0).Rows(0).Item(0).ToString
            Usuario = ds.Tables(0).Rows(0).Item(1).ToString
            Senha = ds.Tables(0).Rows(0).Item(2).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(3).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(4).ToString
        End If

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Usuarios(Usuario,Senha,NomeUser,DataDigita)" & _
        " VALUES('" & cUsuario & "','" & cSenha & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Usuarios SET Usuario='" & cUsuario & "', " & _
        " Senha='" & cSenha & "',NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDUser= " & cIDUsuario & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDUser,Usuario From Tbl_Usuarios where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function


End Class
