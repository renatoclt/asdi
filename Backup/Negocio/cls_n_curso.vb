Public Class cls_n_curso
    Private id_curso As Integer
    Private curso As String
    Private abreviatura As String

    Public Property Curso_Codigo()
        Get
            Return Me.id_curso
        End Get
        Set(ByVal id_curso_)
            Me.id_curso = id_curso_
        End Set
    End Property

    Public Property Curso_Nombre()
        Get
            Return Me.curso
        End Get
        Set(ByVal curso_)
            Me.curso = curso_
        End Set
    End Property

    Public Property Curso_Abreviatura()
        Get
            Return Me.abreviatura
        End Get
        Set(ByVal abreviatura_)
            Me.abreviatura = abreviatura_
        End Set
    End Property
End Class
