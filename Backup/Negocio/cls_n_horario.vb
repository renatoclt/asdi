Public Class cls_n_horario
    Private id_horario As Integer
    Private horario As String
    Private costo As Decimal

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

    Public Overrides Function ToString() As String
        Return horario
    End Function

End Class
