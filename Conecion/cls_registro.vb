Imports Microsoft.Win32

Public Class cls_registro
    Private Ruta As String = "Software\Coneccion\mysql"
    'Private Ruta As String = "Software\Coneccion"

    Public Function Leer(ByVal Clave As String) As String
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(Ruta, False)
        If key IsNot Nothing Then
            Dim valor As String = key.GetValue(Clave).ToString
            Return valor
        End If
        Return ""
    End Function

End Class
