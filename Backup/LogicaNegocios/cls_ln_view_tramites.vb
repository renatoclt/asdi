Imports Datos
Imports Negocio

Public Class cls_ln_view_tramites
    Private obj_datos As cls_dt_view_tramites

    Public Sub New()
        obj_datos = New cls_dt_view_tramites
    End Sub

    Public Function Buscar_View_Tramites() As List(Of cls_n_view_tramites)
        Return obj_datos.Buscar_View_Tramites()
    End Function

    Public Function Buscar_View_Tramites(ByVal tramite As String, ByVal nombre As String) As List(Of cls_n_view_tramites)
        Return obj_datos.Buscar_View_Tramites(tramite, nombre)
    End Function

    Public Function Buscar_View_Tramites(ByVal nombre As String) As List(Of cls_n_view_tramites)
        Return obj_datos.Buscar_View_Tramites(nombre)
    End Function

    Public Function Buscar_View_Tramites_No(ByVal nombre As String) As List(Of cls_n_view_tramites)
        Return obj_datos.Buscar_View_Tramites_No(nombre)
    End Function

End Class
