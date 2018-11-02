Public Class cls_n_curso_plan_est
    Private id_cur_plan_est As Integer
    Private id_curso As Integer
    Private id_plan_est As Integer
    Private orden As Integer

    Public Property Curso_Plan_Codigo()
        Get
            Return Me.id_cur_plan_est
        End Get
        Set(ByVal id_cur_plan_est_)
            Me.id_cur_plan_est = id_cur_plan_est_
        End Set
    End Property

    Public Property Curso_Plan_Codigo_Curso()
        Get
            Return Me.id_curso
        End Get
        Set(ByVal id_curso_)
            Me.id_curso = id_curso_
        End Set
    End Property

    Public Property Curso_Plan_Codigo_Plan()
        Get
            Return Me.id_plan_est
        End Get
        Set(ByVal id_plan_est_)
            Me.id_plan_est = id_plan_est_
        End Set
    End Property

    Public Property Curso_Plan_Orden()
        Get
            Return Me.orden
        End Get
        Set(ByVal orden_)
            Me.orden = orden_
        End Set
    End Property

End Class
