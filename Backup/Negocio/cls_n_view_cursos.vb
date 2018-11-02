Public Class cls_n_view_cursos
    Private id_cur_plan_est As Integer
    Private id_plan_est As Integer
    Private plan_estudio As String
    Private id_curso As Integer
    Private curso As String
    Private orden As String

    Public Property View_Cursos_Codigo()
        Get
            Return Me.id_cur_plan_est
        End Get
        Set(ByVal id_cur_plan_est_)
            Me.id_cur_plan_est = id_cur_plan_est_
        End Set
    End Property

    Public Property View_Cursos_Plan_Codigo()
        Get
            Return Me.id_plan_est
        End Get
        Set(ByVal id_plan_est_)
            Me.id_plan_est = id_plan_est_
        End Set
    End Property

    Public Property View_Cursos_Plan()
        Get
            Return Me.plan_estudio
        End Get
        Set(ByVal plan_estudio_)
            Me.plan_estudio = plan_estudio_
        End Set
    End Property

    Public Property View_Cursos_Curso_Codigo()
        Get
            Return Me.id_curso
        End Get
        Set(ByVal id_curso_)
            Me.id_curso = id_curso_
        End Set
    End Property

    Public Property View_Cursos_Curso()
        Get
            Return Me.curso
        End Get
        Set(ByVal curso_)
            Me.curso = curso_
        End Set
    End Property

    Public Property View_Cursos_Orden()
        Get
            Return Me.orden
        End Get
        Set(ByVal orden_)
            Me.orden = orden_
        End Set
    End Property

End Class
