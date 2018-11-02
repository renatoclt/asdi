Public Class cls_n_view_curso_grupos
    Private id_curso_grupo As Integer
    Private id_profesor_ficha As Integer
    Private profesor As String
    Private id_curso_ofertado As Integer
    Private curso_ofertado As String
    Private id_horario As Integer
    Private horario As String
    Private id_aula As Integer
    Private aula As String
    Private nombre_grupo As String
    Private matriculados As Integer

    Public Property View_Curso_Grupo_Codigo()
        Get
            Return Me.id_curso_grupo
        End Get
        Set(ByVal id_curso_grupo_)
            Me.id_curso_grupo = id_curso_grupo_
        End Set
    End Property

    Public Property View_Curso_Grupo_Profesor_Codigo()
        Get
            Return Me.id_profesor_ficha
        End Get
        Set(ByVal id_profesor_ficha_)
            Me.id_profesor_ficha = id_profesor_ficha_
        End Set
    End Property

    Public Property View_Curso_Grupo_Profesor()
        Get
            Return Me.profesor
        End Get
        Set(ByVal profesor_)
            Me.profesor = profesor_
        End Set
    End Property

    Public Property View_Curso_Grupo_Curso_Ofertado_Codigo()
        Get
            Return Me.id_curso_ofertado
        End Get
        Set(ByVal id_curso_ofertado_)
            Me.id_curso_ofertado = id_curso_ofertado_
        End Set
    End Property

    Public Property View_Curso_Grupo_Curso_Ofertado()
        Get
            Return Me.curso_ofertado
        End Get
        Set(ByVal curso_ofertado_)
            Me.curso_ofertado = curso_ofertado_
        End Set
    End Property

    Public Property View_Curso_Grupo_Horario_Codigo()
        Get
            Return Me.id_horario
        End Get
        Set(ByVal id_horario_)
            Me.id_horario = id_horario_
        End Set
    End Property

    Public Property View_Curso_Grupo_Horario()
        Get
            Return Me.horario
        End Get
        Set(ByVal horario_)
            Me.horario = horario_
        End Set
    End Property

    Public Property View_Curso_Grupo_Aula_Codigo()
        Get
            Return Me.id_aula
        End Get
        Set(ByVal id_aula_)
            Me.id_aula = id_aula_
        End Set
    End Property

    Public Property View_Curso_Grupo_Aula()
        Get
            Return Me.aula
        End Get
        Set(ByVal aula_)
            Me.aula = aula_
        End Set
    End Property

    Public Property View_Curso_Grupo_Nombre()
        Get
            Return Me.nombre_grupo
        End Get
        Set(ByVal nombre_grupo_)
            Me.nombre_grupo = nombre_grupo_
        End Set
    End Property

    Public Property View_Curso_Grupo_Matriculados()
        Get
            Return Me.matriculados
        End Get
        Set(ByVal matriculados_)
            Me.matriculados = matriculados_
        End Set
    End Property

End Class
