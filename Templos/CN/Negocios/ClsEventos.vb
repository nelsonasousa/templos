Public Class ClsEventos
#Region "Variáveis"

    Private cIDEvento As Integer
    Private cEvento As String
    Private cDataRealizacao As String
    Private cHoraRealizacao As String
    Private cOrganizador As String
    Private cPalestrante As String
    Private cObservacao As String
    Private cNomeUser As String
    Private cDataDigita As String

#End Region

#Region "Propriedades"

    Public Sub New()
    End Sub
    Public Sub New(ByVal IDEvento As Integer, ByVal Evento As String, ByVal DataRealizacao As DateTime, _
                   ByVal HoraRealizacao As DateTime, ByVal Organizador As String, ByVal Palestrante As String, _
                   ByVal Observacao As String, ByVal NomeUser As String, ByVal DataDigita As DateTime)

        Me.cIDEvento = IDEvento
        Me.cEvento = Evento
        Me.cDataRealizacao = DataRealizacao
        Me.cHoraRealizacao = HoraRealizacao
        Me.cOrganizador = Organizador
        Me.cPalestrante = Palestrante
        Me.cObservacao = Observacao
        Me.cNomeUser = NomeUser
        Me.cDataDigita = DataDigita
    End Sub
    Public Property IDEvento() As Integer
        Get
            Return cIDEvento
        End Get
        Set(ByVal value As Integer)
            cIDEvento = value
        End Set
    End Property
    Public Property Evento() As String
        Get
            Return cEvento
        End Get
        Set(ByVal value As String)
            cEvento = value
        End Set
    End Property
    Public Property DataRealizacao() As String
        Get
            Return cDataRealizacao
        End Get
        Set(ByVal value As String)
            cDataRealizacao = value
        End Set
    End Property
    Public Property HoraRealizacao() As String
        Get
            Return cHoraRealizacao
        End Get
        Set(ByVal value As String)
            cHoraRealizacao = value
        End Set
    End Property
    Public Property Organizador() As String
        Get
            Return cOrganizador
        End Get
        Set(ByVal value As String)
            cOrganizador = value
        End Set
    End Property
    Public Property Palestrante() As String
        Get
            Return cPalestrante
        End Get
        Set(ByVal value As String)
            cPalestrante = value
        End Set
    End Property
    Public Property Observacao() As String
        Get
            Return cObservacao
        End Get
        Set(ByVal value As String)
            cObservacao = value
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

        cSql = "Select * From Tbl_Eventos Where IDEvento=" & cIDEvento
        Dim ds As DataSet

        Dim DtAgenda As New ClsDados()

        ds = DtAgenda.RetornarDataSet(cSql)

        If ds.Tables(0).Rows.Count > 0 Then

            IDEvento = ds.Tables(0).Rows(0).Item(0).ToString
            Evento = ds.Tables(0).Rows(0).Item(1).ToString
            DataRealizacao = ds.Tables(0).Rows(0).Item(2).ToString
            HoraRealizacao = ds.Tables(0).Rows(0).Item(3).ToString
            Organizador = ds.Tables(0).Rows(0).Item(4).ToString
            Palestrante = ds.Tables(0).Rows(0).Item(5).ToString
            Observacao = ds.Tables(0).Rows(0).Item(6).ToString
            NomeUser = ds.Tables(0).Rows(0).Item(7).ToString
            DataDigita = ds.Tables(0).Rows(0).Item(8).ToString
        End If

    End Sub
    Public Function BuscarId() As Integer

        Dim cSql As String

        cSql = "Select Top 1 (IDEvento) From Tbl_Eventos order by IDEvento desc"

        Dim IdBuscado As Integer

        Dim DtAgenda As New ClsDados()

        IdBuscado = DtAgenda.RetornarIdNumerico(cSql)

        Return IdBuscado

    End Function

    Public Sub Editar()

        Dim strQuery As String

        strQuery = "Update Tbl_Eventos SET Evento='" & cEvento & "', " & _
        " DataRealizacao='" & cDataRealizacao & "',HoraREalizacao='" & cHoraRealizacao & "'," & _
        " Organizador='" & cOrganizador & "',Palestrante='" & cPalestrante & "'," & _
        " Observacao='" & cObservacao & "',NomeUser='" & cNomeUser & "', " & _
        " DataDigita='" & cDataDigita & "' " & _
        " WHERE IDEvento= " & cIDEvento & ";"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Excluir()

        Dim strQuery As String

        strQuery = "Delete From Tbl_Eventos WHERE IDEvento=" & cIDEvento
        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Sub Gravar()

        Dim strQuery As String

        strQuery = "INSERT INTO Tbl_Eventos(Evento,DataRealizacao,HoraRealizacao,Organizador," & _
        " Palestrante,Observacao,NomeUser,DataDigita)" & _
        " VALUES('" & cEvento & "','" & cDataRealizacao & "','" & cHoraRealizacao & "'," & _
        " '" & cOrganizador & "','" & cPalestrante & "','" & cObservacao & "','" & cNomeUser & "','" & cDataDigita & "');"

        Dim BancoSGT As New ClsDados()

        BancoSGT.ExecutarComando(strQuery.ToString)

    End Sub
    Public Function Pesquisar(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As DataSet

        Dim strQuery As String

        strQuery = "Select IDEvento,Evento From Tbl_Eventos where " & Campo & " " & Parametro & " " & Valor & ""

        Dim a As String = strQuery.ToString()

        Dim ds As DataSet

        Dim BancoSGT As New ClsDados()

        ds = BancoSGT.RetornarDataSet(strQuery.ToString)

        Return ds

    End Function

#End Region
End Class
