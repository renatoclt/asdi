Public Class cls_n_aula
    Private id_aula As Integer
    Private aula As String
    Private capacidad As Integer

    Public Property Aula_Codigo()
        Get
            Return Me.id_aula
        End Get
        Set(ByVal id_aula_)
            Me.id_aula = id_aula_
        End Set
    End Property

    Public Property Aula_Nombre()
        Get
            Return Me.aula
        End Get
        Set(ByVal aula_)
            Me.aula = aula_
        End Set
    End Property

    Public Property Aula_Capacidad()
        Get
            Return Me.capacidad
        End Get
        Set(ByVal capacidad_)
            Me.capacidad = capacidad_
        End Set
    End Property

    Public Function Aula_Nombre_Capacidad()
        Return Me.aula + "(" + Me.capacidad.ToString + ")"
    End Function

End Class
