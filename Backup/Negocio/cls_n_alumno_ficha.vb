Public Class cls_n_alumno_ficha
    Private id_alumno_ficha As Integer
    Private id_persona As Integer
    Private id_plan_est As Integer
    Private ciclo As Integer
    Private periodo_inicio As Integer
    Private periodo_fin As Integer
    Private id_tp_est_alum As Integer

    Public Property Alumno_Codigo()
        Get
            Return Me.id_alumno_ficha
        End Get
        Set(ByVal id_alumno_ficha_)
            Me.id_alumno_ficha = id_alumno_ficha_
        End Set
    End Property

    Public Property Alumno_Persona_Codigo()
        Get
            Return Me.id_persona
        End Get
        Set(ByVal id_persona_)
            Me.id_persona = id_persona_
        End Set
    End Property

    Public Property Alumno_Plan_Estudio()
        Get
            Return Me.id_plan_est
        End Get
        Set(ByVal id_plan_est_)
            Me.id_plan_est = id_plan_est_
        End Set
    End Property

    Public Property Alumno_Ciclo()
        Get
            Return Me.ciclo
        End Get
        Set(ByVal ciclo_)
            Me.ciclo = ciclo_
        End Set
    End Property

    Public Property Alumno_Periodo_Inicio()
        Get
            Return Me.periodo_inicio
        End Get
        Set(ByVal periodo_inicio_)
            Me.periodo_inicio = periodo_inicio_
        End Set
    End Property

    Public Property Alumno_Periodo_Fin()
        Get
            Return Me.periodo_fin
        End Get
        Set(ByVal periodo_fin_)
            Me.periodo_fin = periodo_fin_
        End Set
    End Property

    Public Property Alumno_Tipo_Alumno()
        Get
            Return Me.id_tp_est_alum
        End Get
        Set(ByVal id_tp_est_alum_)
            Me.id_tp_est_alum = id_tp_est_alum_
        End Set
    End Property

End Class
