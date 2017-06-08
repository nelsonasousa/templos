Imports System.Security.Cryptography
Imports System.Text

Module mdl_Global

    Public Sub Limpar(ByRef f As GroupBox)
        For Each ctl As Control In f.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
            If TypeOf ctl Is ComboBox Then ctl.Text = ""
            If TypeOf ctl Is ComboboxAutoComplete Then ctl.Text = ""
            If TypeOf ctl Is MaskedTextBox Then ctl.Text = ""
        Next ctl
    End Sub
    Public Sub LimparTab(ByRef f As TabControl)
        Dim I As Byte
        For I = 0 To (f.Controls.Count - 1)
            For Each ctl As Control In f.Controls.Item(I).Controls
                If TypeOf ctl Is TextBox Then ctl.Text = ""
                If TypeOf ctl Is ComboBox Then ctl.Text = ""
                If TypeOf ctl Is ComboboxAutoComplete Then ctl.Text = ""
                If TypeOf ctl Is MaskedTextBox Then ctl.Text = ""
            Next ctl
        Next I
    End Sub
    Public Sub ParaGravar(ByRef f As GroupBox)
        For Each ctl As Control In f.Controls
            If ctl.Name = "cmdIncluir" Or ctl.Name = "cmdIncluirProduto" Then
                ctl.Enabled = True
            End If

            If ctl.Name = "cmdCancelar" Then
                ctl.Enabled = True
            End If

            If ctl.Name = "cmdAlterar" Or ctl.Name = "cmdAlterarProduto" Then
                ctl.Enabled = False
            End If

            If ctl.Name = "cmdExcluir" Or ctl.Name = "cmdExcluirProduto" Then
                ctl.Enabled = False
            End If
        Next

    End Sub
    Public Sub ParaAlterar(ByRef f As GroupBox)
        For Each ctl As Control In f.Controls
            If ctl.Name = "cmdIncluir" Or ctl.Name = "cmdIncluirProduto" Then
                ctl.Enabled = False
            End If

            If ctl.Name = "cmdCancelar" Then
                ctl.Enabled = True
            End If
            If ctl.Name = "cmdAlterar" Or ctl.Name = "cmdAlterarProduto" Then
                ctl.Enabled = True
            End If
            If ctl.Name = "cmdExcluir" Or ctl.Name = "cmdExcluirProduto" Then
                ctl.Enabled = True
            End If
        Next
    End Sub
    Public Sub Liberar(ByRef f As GroupBox)
        For Each ctl As Control In f.Controls
            If ctl.Name = "cmdPesquisar" Then
                ctl.Enabled = True
            Else
                ctl.Enabled = False
            End If
        Next
    End Sub
    Public Function Confirma(ByVal strMensagem As String) As Boolean
        'Função pública que emite uma MsgBox com a mensagem passada pelo sistema.
        'Usada para confirmar operações com registros.
        If MsgBox(strMensagem, 32 + 4, strSistema) = 6 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ValidaUser(ByVal strForm As String) As Boolean
        Dim verifica As New ClsPermissoes
        verifica.IDUser = strIDUser

        verifica.Formulario = GeraHash(strForm)


        If verifica.Verifica = True Then
            ValidaUser = True
        Else
            ValidaUser = False
        End If

    End Function
    Public Function GeraHash(ByVal texto As String) As String
        'Cria um objeto enconding para assegurar o padrão
        'de encondig para o texto origem
        Dim Ue As New UnicodeEncoding()

        'Retorna um byte array baseado no texto origem
        Dim ByteSourceText() As Byte = Ue.GetBytes(texto)
        'Instancia um objeto MD5
        Dim Md5 As New MD5CryptoServiceProvider()
        'Calcula o valor do hash para o texto origem
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        'Converte o valor obtido para o formato string
        Return Convert.ToBase64String(ByteHash)
    End Function
    Public Function ValidaCPF(ByVal CPF As String) As Boolean
        Dim i, a, n1, n2 As Integer

        CPF = CPF.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "")
        CPF = CPF.Trim

        If CPF = "" OrElse _
          CPF.Trim.Length <> 11 OrElse _
          CPF = "11111111111" OrElse _
          CPF = "22222222222" OrElse _
          CPF = "33333333333" OrElse _
          CPF = "44444444444" OrElse _
          CPF = "55555555555" OrElse _
          CPF = "66666666666" OrElse _
          CPF = "77777777777" OrElse _
          CPF = "88888888888" OrElse _
          CPF = "99999999999" Then
            Return False
        End If

        For a = 0 To 1
            n1 = 0
            For i = 1 To 9 + a
                n1 = n1 + Val(Mid(CPF, i, 1)) * (11 + a - i)
            Next
            n2 = 11 - (n1 - (Int(n1 / 11) * 11))
            If n2 = 10 Or n2 = 11 Then n2 = 0
            If n2 <> Val(Mid(CPF, 10 + a, 1)) Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Function ValidaCNPJ(ByVal CGC As String) As Boolean
        Dim RecebeCNPJ As String
        Dim Numero(14) As Integer
        Dim Soma, Resultado1, Resultado2 As Integer

        RecebeCNPJ = CGC.Trim

        If RecebeCNPJ.Length <> 14 Or _
        RecebeCNPJ = "00000000000000" Or _
        RecebeCNPJ = "11111111111111" Or _
        RecebeCNPJ = "22222222222222" Or _
        RecebeCNPJ = "33333333333333" Or _
        RecebeCNPJ = "44444444444444" Or _
        RecebeCNPJ = "55555555555555" Or _
        RecebeCNPJ = "66666666666666" Or _
        RecebeCNPJ = "77777777777777" Or _
        RecebeCNPJ = "88888888888888" Or _
        RecebeCNPJ = "99999999999999" Then
            Return False
        Else
            Numero(1) = CInt(Mid(RecebeCNPJ, 1, 1))
            Numero(2) = CInt(Mid(RecebeCNPJ, 2, 1))
            Numero(3) = CInt(Mid(RecebeCNPJ, 3, 1))
            Numero(4) = CInt(Mid(RecebeCNPJ, 4, 1))
            Numero(5) = CInt(Mid(RecebeCNPJ, 5, 1))
            Numero(6) = CInt(Mid(RecebeCNPJ, 6, 1))
            Numero(7) = CInt(Mid(RecebeCNPJ, 7, 1))
            Numero(8) = CInt(Mid(RecebeCNPJ, 8, 1))
            Numero(9) = CInt(Mid(RecebeCNPJ, 9, 1))
            Numero(10) = CInt(Mid(RecebeCNPJ, 10, 1))
            Numero(11) = CInt(Mid(RecebeCNPJ, 11, 1))
            Numero(12) = CInt(Mid(RecebeCNPJ, 12, 1))
            Numero(13) = CInt(Mid(RecebeCNPJ, 13, 1))
            Numero(14) = CInt(Mid(RecebeCNPJ, 14, 1))
            Soma = Numero(1) * 5 + Numero(2) * 4 + Numero(3) * 3 + Numero(4) * 2 + Numero(5) * 9 + Numero(6) * 8 + Numero(7) * 7 + Numero(8) * 6 + Numero(9) * 5 + Numero(10) * 4 + Numero(11) * 3 + Numero(12) * 2
            Soma = Soma - (11 * (Int(Soma / 11)))



            If Soma = 0 Or Soma = 1 Then
                Resultado1 = 0
            Else
                Resultado1 = 11 - Soma
            End If

            If Resultado1 = Numero(13) Then
                Soma = Numero(1) * 6 + Numero(2) * 5 + Numero(3) * 4 + Numero(4) * 3 + Numero(5) * 2 + Numero(6) * 9 + Numero(7) * 8 + Numero(8) * 7 + Numero(9) * 6 + Numero(10) * 5 + Numero(11) * 4 + Numero(12) * 3 + Numero(13) * 2
                Soma = Soma - (11 * (Int(Soma / 11)))

                If Soma = 0 Or Soma = 1 Then
                    Resultado2 = 0
                Else
                    Resultado2 = 11 - Soma
                End If

                If Resultado2 = Numero(14) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End If
    End Function
    Public Function RetornaMatriculados(ByVal strIDClasse As String) As Integer
        Dim ds As New DataSet
        Dim Busca As New ClsDados
      

        ds = Busca.RetornarDataSet("SELECT Count(IDClasse) AS TTMat" & _
                                   " FROM Tbl_Pessoas_Grupos" & _
                                   " WHERE (DataBaixa IS NULL) AND (IDClasse=" & strIDClasse & ") AND (Contar_Presenca=true);")

        Return ds.Tables(0).Rows(0).Item(0)

        ds = Nothing
        Busca = Nothing
    End Function
    Public Function DBExists(ByVal strVerifica As String) As Boolean
        Return IO.File.Exists(strVerifica)
    End Function
    Function RemoveAcentos(ByVal Str As String) As String
        Dim ComAcento As String
        Dim SemAcento As String
        Dim X As Integer
        Dim NovaStr As String = ""
        Dim cAtual As String = ""

        ComAcento = "àâêôûãõáéíóúçüÀÂÊÔÛÃÕÁÉÍÓÚÇÜ"
        SemAcento = "aaeouaoaeioucuAAEOUAOAEIOUCU"

        For X = 1 To Len(Str)
            cAtual = Mid(Str, X, 1)

            If InStr(1, ComAcento, cAtual, vbBinaryCompare) <> 0 Then
                cAtual = Mid(SemAcento, InStr(1, ComAcento, cAtual, vbBinaryCompare), 1)
            End If

            NovaStr = NovaStr + cAtual
        Next
        Return NovaStr
    End Function
    Public Sub AbrirPPT(ByVal NomeArquivo As String)
        Try
            Process.Start(NomeArquivo)
        Catch ex As Exception

        End Try
    End Sub
    Public Function CalculaTempo(ByVal Entrada As Date)
        Dim Anos, iMeses As Double
        Dim diasDiff As String = ""
        Anos = DateDiff(DateInterval.Year, Entrada, Date.Today)
        Entrada = DateAdd(DateInterval.Year, Anos, Entrada)
        If Entrada < Date.Today Then
            iMeses = DateDiff(DateInterval.Month, Date.Today, Entrada)
            diasDiff = DatePart(DateInterval.Day, Date.Today) - DatePart(DateInterval.Day, Entrada)
        ElseIf Entrada = Date.Today Then
            iMeses = DateDiff(DateInterval.Month, Entrada, Date.Today)
            diasDiff = DatePart(DateInterval.Day, Date.Today) - DatePart(DateInterval.Day, Entrada)
        ElseIf Entrada > Date.Today Then
            Anos = Anos - 1
            iMeses = 12 - DateDiff(DateInterval.Month, Date.Today, Entrada)
            diasDiff = DatePart(DateInterval.Day, Date.Today) - DatePart(DateInterval.Day, Entrada)
        End If
        Dim diamesDtAdmin As Double = Date.DaysInMonth(DatePart(DateInterval.Year, Date.Today), DatePart(DateInterval.Month, Date.Today))
        If diasDiff = diamesDtAdmin Then
            diasDiff = 0
            iMeses = iMeses + 1
        End If
        If iMeses = 12 Then
            Anos = Anos + 1
        End If
        Dim AnosTexto, MesesTexto, DiasTexto As String
        If CInt(Anos) = 1 Then
            AnosTexto = " Ano, "
        Else
            AnosTexto = " Anos, "
        End If
        If iMeses = 1 Then
            MesesTexto = " mês e "
        Else
            MesesTexto = " meses e "
        End If
        If diasDiff = 1 Then
            DiasTexto = " dia."
        Else
            DiasTexto = " dias."
        End If
        Dim sRet As String = CInt(Anos) & AnosTexto & Math.Abs(iMeses) & MesesTexto & Math.Abs(CInt(diasDiff)) & DiasTexto
        Return sRet

    End Function
    Public Function ZerosEsquerda(ByVal intNumero As Integer, ByVal nzeros As Integer) As String

        'Pega a qtde de dígitos do número repassado
        Dim intTN As Integer = Len(CStr(intNumero))
        'Pega a qtde de zeros a complementar
        Dim totalDeZeros As Integer = nzeros - intTN


        Dim strNum As String = CStr(intNumero)


        For i As Integer = 1 To totalDeZeros

            strNum = strNum.Insert(0, "0")

        Next

        Return strNum

    End Function

End Module
