Public Class cls_n_curso_ofertado
    Private id_curso_ofertado As Integer
    Private id_curso As Integer
    Private curso As String
    Private ofertado As Boolean

    Public Property Curso_Ofertado_Codigo()
        Get
            Return Me.id_curso_ofertado
        End Get
        Set(ByVal id_curso_ofertado_)
            Me.id_curso_ofertado = id_curso_ofertado_
        End Set
    End Property

    Public Property Curso_Ofertado_Curso_Codigo()
        Get
            Return Me.id_curso
        End Get
        Set(ByVal id_curso_)
            Me.id_curso = id_curso_
        End Set
    End Property

    Public Property Curso_Ofertado_Curso_Nombre()
        Get
            Return Me.curso
        End Get
        Set(ByVal curso_)
            Me.curso = curso_
        End Set
    End Property

    Public Property Curso_Ofertado_Ofertado()
        Get
            Return Me.ofertado
        End Get
        Set(ByVal ofertado_)
            Me.ofertado = ofertado_
        End Set
    End Property

End Class
