Module Mdl_CaixaAlta
    Public Function SmartCase(ByVal Texto)
        'Retorna o texto em caixa própria
        Dim str As String

        'Sai se for nulo
        If Texto = Nothing Then
            SmartCase = Nothing
            Exit Function
        End If

        str = Texto
        str = StrConv(str, vbProperCase)
        'Lista para substituição
        str = FindAndReplace(str, " De ", " de ")
        str = FindAndReplace(str, " Da ", " da ")
        str = FindAndReplace(str, " Do ", " do ")
        str = FindAndReplace(str, " Das ", " das ")
        str = FindAndReplace(str, " Dos ", " dos ")
        str = FindAndReplace(str, " E ", " e ")

        SmartCase = UCase(str)
    End Function


    Function FindAndReplace(ByVal strInString As String, _
            ByVal strFindString As String, _
            ByVal strReplaceString As String) As String
        FindAndReplace = ""
        Dim intPtr As Integer
        If Len(strFindString) > 0 Then
            Do
                intPtr = InStr(strInString, strFindString)
                If intPtr > 0 Then
                    FindAndReplace = FindAndReplace & Left(strInString, intPtr - 1) & _
                                            strReplaceString
                    strInString = Mid(strInString, intPtr + Len(strFindString))
                End If
            Loop While intPtr > 0
        End If
        FindAndReplace = FindAndReplace & strInString
    End Function


End Module
