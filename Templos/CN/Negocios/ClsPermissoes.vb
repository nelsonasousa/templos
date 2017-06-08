Public Class ClsPermissoes
    Private cIDUser As Integer
    Private cIDForm As Integer
    Private cFormulario As String
    Private cNomeUser As String
    Private cDataDigita As String

    Public Sub New()

    End Sub
    Public Sub New(ByVal IDUser As Integer, ByVal IDForm As Integer, ByVal Formulario As String, ByVal NomeUser As String, _
     ByVal DataDigita As DateTime)

        Me.cIDUser = IDUser
        Me.cIDForm = IDForm
        Me.cFormulario = Formulario
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub

    Public Property IDUser() As Integer
        Get
            Return cIDUser
        End Get
        Set(ByVal value As Integer)
            cIDUser = value
        End Set
    End Property
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

        cSql = "Select * From Tbl_Forms_Users Where IDUser=" & cIDUser & " AND Formulario='" & cFormulario & "' "
        Dim ds As DataSet

        Dim DTFormUser As New ClsDados()

        ds = DTFormUser.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDUser = ds.Tables(0).Rows(0).Item(0).ToString
            IDForm = ds.Tables(0).Rows(0).Item(1).ToString
            Formulario = ds.Tables(0).Rows(0).Item(2).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(3).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(4).ToString
        End If

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Forms_Users WHERE IDUser=" & cIDUser & " AND IDForm=" & cIDForm & ""
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Forms_Users(IDUser,IDForm,Formulario,NomeUser,DataDigita)" & _
        " VALUES(" & cIDUser & ",'" & cIDForm & "','" & cFormulario & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select * From Tbl_Forms_Users where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function
    Public Function Verifica() As Boolean
        Dim cSql As String

        cSql = "Select * From Tbl_Forms_Users Where IDUser=" & cIDUser & " And Formulario = '" & cFormulario & "'"
        Dim ds As DataSet

        Dim DTFormUser As New ClsDados()

        ds = DTFormUser.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
