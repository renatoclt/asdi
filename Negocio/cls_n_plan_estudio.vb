Public Class cls_n_plan_estudio
    Private id_plan_est As Integer
    Private plan_estudio As String

    Public Property Plan_Codigo()
        Get
            Return Me.id_plan_est
        End Get
        Set(ByVal id_plan_est_)
            Me.id_plan_est = id_plan_est_
        End Set
    End Property

    Public Property Plan_Nombre()
        Get
            Return Me.plan_estudio
        End Get
        Set(ByVal plan_estudio_)
            Me.plan_estudio = plan_estudio_
        End Set
    End Property

End Class
