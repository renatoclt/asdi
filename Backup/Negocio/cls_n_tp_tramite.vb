Public Class cls_n_tp_tramite
    Private id_tp_tramite As Integer
    Private tp_tramite As String
    Private costo As Decimal

    Public Property Tipo_Tramite_Codgio()
        Get
            Return Me.id_tp_tramite
        End Get
        Set(ByVal id_tp_tramite_)
            Me.id_tp_tramite = id_tp_tramite_
        End Set
    End Property

    Public Property Tipo_Tramite_Nombre()
        Get
            Return Me.tp_tramite
        End Get
        Set(ByVal tp_tramite_)
            Me.tp_tramite = tp_tramite_
        End Set
    End Property

    Public Property Tipo_Tramite_Costo()
        Get
            Return Me.costo
        End Get
        Set(ByVal costo_)
            Me.costo = costo_
        End Set
    End Property
End Class
