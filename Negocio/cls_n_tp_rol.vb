Public Class cls_n_tp_rol
    Private id_tp_rol As Integer
    Private tp_rol As String

    Public Property Tipo_Rol_Codigo()
        Get
            Return Me.id_tp_rol
        End Get
        Set(ByVal id_tp_rol_)
            Me.id_tp_rol = id_tp_rol_
        End Set
    End Property

    Public Property Tipo_Rol_Nombre()
        Get
            Return Me.tp_rol
        End Get
        Set(ByVal tp_rol_)
            Me.tp_rol = tp_rol_
        End Set
    End Property

End Class
