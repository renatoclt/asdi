Public Class cls_n_view_tramites
    Private id_tramite As Integer
    Private nombre As String
    Private tramite As String
    Private fecha_creacion As DateTime
    Private entregado As String
    Private fecha_entregado As DateTime

    Public Property View_Tramite_Codigo_Tramite()
        Get
            Return Me.id_tramite
        End Get
        Set(ByVal id_tramite_)
            Me.id_tramite = id_tramite_
        End Set
    End Property

    Public Property View_Tramite_Nombre_Alumno()
        Get
            Return Me.nombre
        End Get
        Set(ByVal nombre_)
            Me.nombre = nombre_
        End Set
    End Property

    Public Property View_Tramite_Tramite_Nombre()
        Get
            Return Me.tramite
        End Get
        Set(ByVal tramite_)
            Me.tramite = tramite_
        End Set
    End Property

    Public Property View_Tramite_Fecha_Creacion()
        Get
            Return Me.fecha_creacion
        End Get
        Set(ByVal fecha_creacion_)
            Me.fecha_creacion = fecha_creacion_
        End Set
    End Property

    Public Property View_Tramite_Entregado()
        Get
            Return Me.entregado
        End Get
        Set(ByVal entregado_)
            Me.entregado = entregado_
        End Set
    End Property

    Public Property View_Tramite_Fecha_Entregado()
        Get
            Return Me.fecha_entregado
        End Get
        Set(ByVal fecha_entregado_)
            Me.fecha_entregado = fecha_entregado_
        End Set
    End Property

End Class
