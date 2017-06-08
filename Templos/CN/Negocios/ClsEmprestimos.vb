Public Class ClsEmprestimos
#Region "Variáveis"

    Private cIDEmprestimo As Integer
    Private cIDMembro As Integer
    Private cIDLivro As Integer
    Private cDataEmprestimo As String
    Private cDataDevolucao As String
    Private cDisponivel As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDEmprestimo As Integer, ByVal IDMembro As Integer, ByVal IDLivro As Integer, _
                   ByVal DataEmprestimo As DateTime, ByVal DataDevolucao As DateTime, _
                    ByVal Disponivel As String, ByVal NomeUser As String, ByVal DataDigita As DateTime)
        Me.cIDEmprestimo = IDEmprestimo
        Me.cIDMembro = IDMembro
        Me.cIDLivro = IDLivro
        Me.cDataEmprestimo = DataEmprestimo
        Me.cDataDevolucao = DataDevolucao
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDEmprestimo() As Integer
        Get
            Return cIDEmprestimo
        End Get
        Set(ByVal value As Integer)
            cIDEmprestimo = value
        End Set
    End Property
    Public Property IDMembro() As Integer
        Get
            Return cIDMembro
        End Get
        Set(ByVal value As Integer)
            cIDMembro = value
        End Set
    End Property
    Public Property IDLivro() As Integer
        Get
            Return cIDLivro
        End Get
        Set(ByVal value As Integer)
            cIDLivro = value
        End Set
    End Property
    Public Property DataEmprestimo() As String
        Get
            Return cDataEmprestimo
        End Get
        Set(ByVal value As String)
            cDataEmprestimo = value
        End Set
    End Property
    Public Property DataDevolucao() As String
        Get
            Return cDataDevolucao
        End Get
        Set(ByVal value As String)
            cDataDevolucao = value
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

        cSql = "Select * From Tbl_Emprestimos Where IDEmprestimo=" & cIDEmprestimo 

        Dim ds As DataSet

        Dim DtEmprestimo As New ClsDados()

        ds = DtEmprestimo.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDEmprestimo = ds.Tables(0).Rows(0).Item(0).ToString
            IDMembro = ds.Tables(0).Rows(0).Item(1).ToString
            IDLivro = ds.Tables(0).Rows(0).Item(2).ToString
            DataEmprestimo = ds.Tables(0).Rows(0).Item(3).ToString
            DataDevolucao = ds.Tables(0).Rows(0).Item(4).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(5).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(6).ToString
        End If

    End Sub
    Public Sub Devolver()

        Dim strQuery As String

        strQuery = "Update Tbl_Emprestimos SET DataDevolucao='" & cDataDevolucao & "', " & _
        " NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDEmprestimo= " & cIDEmprestimo & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Emprestimos WHERE IDEmprestimo=" & cIDEmprestimo
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Emprestimos(IDMembro,IDLivro,DataEmprestimo,NomeUser,DataDigita)" & _
        " VALUES('" & cIDMembro & "','" & cIDLivro & "','" & cDataEmprestimo & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Disponibiliza()

        Dim strQuery As String

        strQuery = "Update Tbl_Livros SET Disponivel='" & cDisponivel & "', " & _
        " NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDLivro= " & cIDLivro & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub

#End Region
End Class
