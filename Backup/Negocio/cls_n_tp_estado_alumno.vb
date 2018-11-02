Public Class cls_n_tp_estado_alumno
    Private id_tp_est_alum As Integer
    Private tp_est_alum As String

    Public Property Tipo_Estado_Alumno_Codigo()
        Get
            Return Me.id_tp_est_alum
        End Get
        Set(ByVal id_tp_est_alum_)
            Me.id_tp_est_alum = id_tp_est_alum_
        End Set
    End Property

    Public Property Tipo_Estado_Alumno_Nombre()
        Get
            Return Me.tp_est_alum
        End Get
        Set(ByVal tp_est_alum_)
            Me.tp_est_alum = tp_est_alum_
        End Set
    End Property

End Class
