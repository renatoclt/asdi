Public Class cls_n_matricula
    Private id_matricula As Integer
    Private id_alumno_fichas As Integer
    Private nombre As String
    Private id_curso_grupo As Integer
    Private promedio As Decimal
    Private id_periodo As Integer
    Private fecha_creacion As DateTime
    Private aprobo As Boolean
    Private reserva As Boolean

    Public Property Matricula_Codigo()
        Get
            Return Me.id_matricula
        End Get
        Set(ByVal id_matricula_)
            Me.id_matricula = id_matricula_
        End Set
    End Property

    Public Property Matricula_Alumno_Codigo()
        Get
            Return Me.id_alumno_fichas
        End Get
        Set(ByVal id_alumno_ficha_)
            Me.id_alumno_fichas = id_alumno_ficha_
        End Set
    End Property

    Public Property Matricula_Alumno_Nombre()
        Get
            Return Me.nombre
        End Get
        Set(ByVal nombre_)
            Me.nombre = nombre_
        End Set
    End Property

    Public Property Matricula_Curso_Grupo_Codigo()
        Get
            Return Me.id_curso_grupo
        End Get
        Set(ByVal id_curso_grupo_)
            Me.id_curso_grupo = id_curso_grupo_
        End Set
    End Property

    Public Property Matricula_Promedio()
        Get
            Return Me.promedio
        End Get
        Set(ByVal promedio_)
            Me.promedio = promedio_
        End Set
    End Property

    Public Property Matricula_Periodo_Codigo()
        Get
            Return Me.id_periodo
        End Get
        Set(ByVal id_periodo_)
            Me.id_periodo = id_periodo_
        End Set
    End Property

    Public Property Matricula_Fecha_Creacion()
        Get
            Return Me.fecha_creacion
        End Get
        Set(ByVal fecha_creacion_)
            Me.fecha_creacion = fecha_creacion_
        End Set
    End Property

    Public Property Matricula_Aprobado()
        Get
            Return Me.aprobo
        End Get
        Set(ByVal aprobado_)
            Me.aprobo = aprobado_
        End Set
    End Property

    Public Property Matricula_Reserva()
        Get
            Return reserva
        End Get
        Set(ByVal reserva_)
            Me.reserva = reserva_
        End Set
    End Property
End Class
