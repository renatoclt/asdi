Imports Datos
Imports Negocio

Public Class cls_ln_view_trabajadores
    Private obj_datos As cls_dt_view_trabajadores

    Public Sub New()
        obj_datos = New cls_dt_view_trabajadores
    End Sub

    Public Function Buscar_View_Trabajadores_Todos_Nombres(ByVal nombre As String) As List(Of cls_n_view_trabajadores)
        Return obj_datos.Buscar_View_Trabajadores_Todos_Nombres(nombre)
    End Function
End Class
