Public Class cls_n_curso_pertenece
    Private id_curso As Integer
    Private curso As String
    Private pertenece As Boolean

    Public Property Curso_Pertenece_Codigo()
        Get
            Return Me.id_curso
        End Get
        Set(ByVal id_curso_)
            Me.id_curso = id_curso_
        End Set
    End Property

    Public Property Curso_Pertenece_Nombre()
        Get
            Return Me.curso
        End Get
        Set(ByVal curso_)
            Me.curso = curso_
        End Set
    End Property

    Public Property Curso_Pertenece_Pertenece()
        Get
            Return Me.pertenece
        End Get
        Set(ByVal pertenece_)
            Me.pertenece = pertenece_
        End Set
    End Property
End Class
