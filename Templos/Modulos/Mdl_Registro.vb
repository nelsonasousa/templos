Imports System
Imports Microsoft.Win32

Module Mdl_Registro
    Public Function VerificaPath() As String
        ' Retorna dados de um registro 
        Dim pRegKey As RegistryKey = Registry.CurrentUser
        pRegKey = pRegKey.OpenSubKey("Software\\Methodus\\CRED\\")
        Dim sPath As String = pRegKey.GetValue("PathBD")
        VerificaPath = sPath
    End Function
    Public Function VerificaServidor() As String
        ' Retorna dados de um registro 
        Dim pRegKey As RegistryKey = Registry.CurrentUser
        pRegKey = pRegKey.OpenSubKey("Software\\Methodus\\CRED\\")
        Dim sServidor As String = pRegKey.GetValue("Servidor")
        VerificaServidor = sServidor
    End Function
    Public Sub ExcluiDoRegistro()
        'Exclui um valor de uma sub key
        Dim delKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\\Methodus\\CRED\\", True)
        delKey.DeleteSubKey("RGT")
    End Sub
    Public Sub MarcaDataInstala()

        ' Retorna dados de um registro 
        Dim pRegKey As RegistryKey = Registry.CurrentUser
        pRegKey = pRegKey.OpenSubKey("Software\\Methodus\\CRED\\")
        Dim sDataInstala As String = pRegKey.GetValue("DTI")

        If sDataInstala = "" Then
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\\Methodus\\CRED\\", True)
            ' Atirbui o valor para a sub chave 
            key.SetValue("DTI", GeraHash(Date.Today.ToString))
        End If

    End Sub
    Public Sub MarcaPathDB(ByVal strPath As String)

        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\\Methodus\\CRED\\", True)
        ' Atirbui o valor para a sub chave 
        key.SetValue("PathBD", strPath)

    End Sub
End Module
