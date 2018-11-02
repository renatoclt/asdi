Public Class cls_n_profesor_ficha
    Private id_profesor As Integer
    Private id_persona As Integer
    Private estado As Boolean

    Public Property Profesor_Codigo()
        Get
            Return Me.id_profesor
        End Get
        Set(ByVal id_profesor_)
            Me.id_profesor = id_profesor_
        End Set
    End Property

    Public Property Profesor_Persona_Codigo()
        Get
            Return Me.id_persona
        End Get
        Set(ByVal id_persona_)
            Me.id_persona = id_persona_
        End Set
    End Property

    Public Property Profesor_Estado()
        Get
            Return Me.estado
        End Get
        Set(ByVal estado_)
            Me.estado = estado_
        End Set
    End Property

End Class
