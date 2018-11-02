Public Class cls_n_horario
    Private id_horario As Integer
    Private horario As String
    Private costo As Decimal
    Private id_plan_est As Integer
    Private plan_est As String

    Public Property Horario_Codigo()
        Get
            Return Me.id_horario
        End Get
        Set(ByVal id_horario_)
            Me.id_horario = id_horario_
        End Set
    End Property

    Public Property Horario_Nombre()
        Get
            Return Me.horario
        End Get
        Set(ByVal horario_)
            Me.horario = horario_
        End Set
    End Property

    Public Property Horario_Costo()
        Get
            Return Me.costo
        End Get
        Set(ByVal costo_)
            Me.costo = costo_
        End Set
    End Property

    Public Property Horario_Plan_Est()
        Get
            Return Me.plan_est
        End Get
        Set(ByVal plan_est_)
            Me.plan_est = plan_est_
        End Set
    End Property
    Public Property Horario_Id_Plan_Est()
        Get
            Return Me.id_plan_est
        End Get
        Set(ByVal id_plan_est_)
            Me.id_plan_est = id_plan_est_
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return horario
    End Function

End Class
