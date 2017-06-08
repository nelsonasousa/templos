Public Class ClsTarefas
    Private cIDTarefa As Integer
    Private cIDPessoa As Integer
    Private cIDEnvia As Integer
    Private cDataTarefa As String
    Private cTarefa As String
    Private cDataCumprir As String
    Private cDataExecucao As String
    Private cNomeUser As String
    Private cDataDigita As String


    Public Sub New()
    End Sub
    Public Sub New(ByVal IDTarefa As Integer, ByVal IDPessoa As Integer, ByVal IDEnvia As Integer, _
                   ByVal DataTarefa As DateTime, ByVal Tarefa As String, ByVal DataCumprir As DateTime, _
                   ByVal DataExecucao As DateTime, ByVal NomeUser As String, ByVal DataDigita As DateTime)

        Me.cIDTarefa = IDTarefa
        Me.cIDPessoa = IDPessoa
        Me.cIDEnvia = IDEnvia
        Me.cDataTarefa = DataTarefa
        Me.cTarefa = Tarefa
        Me.cDataCumprir = DataCumprir
        Me.cDataExecucao = DataExecucao
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDTarefa() As Integer
        Get
            Return cIDTarefa
        End Get
        Set(ByVal value As Integer)
            cIDTarefa = value
        End Set
    End Property
    Public Property IDPessoa() As String
        Get
            Return cIDPessoa
        End Get
        Set(ByVal value As String)
            cIDPessoa = value
        End Set
    End Property
    Public Property IDEnvia() As String
        Get
            Return cIDEnvia
        End Get
        Set(ByVal value As String)
            cIDEnvia = value
        End Set
    End Property
    Public Property DataTarefa() As String
        Get
            Return cDataTarefa
        End Get
        Set(ByVal value As String)
            cDataTarefa = value
        End Set
    End Property
    Public Property Tarefa() As String
        Get
            Return cTarefa
        End Get
        Set(ByVal value As String)
            cTarefa = value
        End Set
    End Property
    Public Property DataCumprir() As String
        Get
            Return cDataCumprir
        End Get
        Set(ByVal value As String)
            cDataCumprir = value
        End Set
    End Property
    Public Property DataExecucao() As String
        Get
            Return cDataExecucao
        End Get
        Set(ByVal value As String)
            cDataExecucao = value
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


    'Métodos da Classe Tarefa

    Public Sub Buscar()

        Dim cSql As String

        cSql = "Select * From Tbl_Tarefas Where IDTarefa=" & cIDTarefa
        Dim ds As DataSet

        Dim DtTarefa As New ClsDados()

        ds = DtTarefa.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDTarefa = ds.Tables(0).Rows(0).Item(0).ToString
            IDPessoa = ds.Tables(0).Rows(0).Item(1).ToString
            IDEnvia = ds.Tables(0).Rows(0).Item(2).ToString
            DataTarefa = ds.Tables(0).Rows(0).Item(3).ToString
            Tarefa = ds.Tables(0).Rows(0).Item(4).ToString
            DataCumprir = ds.Tables(0).Rows(0).Item(5).ToString
            DataExecucao = ds.Tables(0).Rows(0).Item(6).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(7).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(8).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select (IDTarefa) From Tbl_Tarefas order by IDTarefa desc Limit 1"

        Dim IdBuscado As Integer

        Dim DtTarefa As New ClsDados()

        IdBuscado = DtTarefa.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function
    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Tarefas SET Tarefa='" & cTarefa & "',DataCumprir='" & cDataCumprir & "', " & _
        " NomeUser='" & cNomeUser & "', DataDigita='" & cDataDigita & "' " & _
        " WHERE IDTarefa= " & cIDTarefa & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Tarefas WHERE IDTarefa=" & cIDTarefa
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Executar()

        Dim strQuery As String

        strQuery = "Update Tbl_Tarefas SET DataExecucao='" & cDataExecucao & "', " & _
        " NomeUser='" & cNomeUser & "', DataDigita='" & cDataDigita & "' " & _
        " WHERE IDTarefa= " & cIDTarefa & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub ExecutarTodos()

        Dim strQuery As String

        strQuery = "Update Tbl_Tarefas SET DataExecucao='" & cDataExecucao & "', " & _
        " NomeUser='" & cNomeUser & "', DataDigita='" & cDataDigita & "' " & _
        " WHERE IDPessoa= " & cIDPessoa & " AND DataExecucao IS NULL;"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Tarefas(IDPessoa,IDEnvia,DataTarefa,Tarefa,DataCumprir,NomeUser,DataDigita)" & _
        " VALUES('" & cIDPessoa & "','" & cIDEnvia & "','" & cDataTarefa & "','" & cTarefa & "', " & _
        " '" & cDataCumprir & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select * From Tbl_Tarefas where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function
    Public Function VerificaTarefa() As Boolean
        Dim cSql As String

        cSql = "Select * From Tbl_Tarefas Where IDExecutor=" & cIDPessoa & " AND DataExecucao IS NULL;"
        Dim ds As DataSet

        Dim DtTarefa As New ClsDados()

        ds = DtTarefa.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then
            VerificaTarefa = True
        Else
            VerificaTarefa = False
        End If
    End Function
End Class
