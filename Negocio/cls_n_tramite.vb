Public Class cls_n_tramite
    Private id_tramite As Integer
    Private id_alumno_ficha As Integer
    Private fecha_creacion As DateTime
    Private id_tp_tramite As Integer
    Private entregado As Boolean
    Private fecha_entregado As DateTime

    Public Property Tramite_Codigo()
        Get
            Return id_tramite
        End Get
        Set(ByVal id_tramite_)
            Me.id_tramite = id_tramite_
        End Set
    End Property

    Public Property Tramite_Alumno_Codigo()
        Get
            Return Me.id_alumno_ficha
        End Get
        Set(ByVal id_alumno_ficha_)
            Me.id_alumno_ficha = id_alumno_ficha_
        End Set
    End Property

    Public Property Tramite_Fecha_Creacion()
        Get
            Return Me.fecha_creacion
        End Get
        Set(ByVal fecha_creacion_)
            Me.fecha_creacion = fecha_creacion_
        End Set
    End Property

    Public Property Tramite_Tipo_Tramite()
        Get
            Return Me.id_tp_tramite
        End Get
        Set(ByVal id_tp_tramite_)
            Me.id_tp_tramite = id_tp_tramite_
        End Set
    End Property

    Public Property Tramite_Entregado()
        Get
            Return Me.entregado
        End Get
        Set(ByVal entregado_)
            Me.entregado = entregado_
        End Set
    End Property

    Public Property Tramite_Fecha_Entregado()
        Get
            Return Me.fecha_entregado
        End Get
        Set(ByVal fecha_entregado_)
            Me.fecha_entregado = fecha_entregado_
        End Set
    End Property

End Class
