Public Class cls_n_curso_reporte
    Private periodo As String
    Private curso As String
    Private grupo As String
    Private profesor As String
    Private horario As String
    Private aula As String
    Private matriculados As Integer

    Public Property Reporte_Curso_Periodo()
        Get
            Return Me.periodo
        End Get
        Set(ByVal periodo_)
            Me.periodo = periodo_
        End Set
    End Property

    Public Property Reporte_Curso_Curso()
        Get
            Return Me.curso
        End Get
        Set(ByVal curso_)
            Me.curso = curso_
        End Set
    End Property

    Public Property Reporte_Curso_Grupo()
        Get
            Return Me.grupo
        End Get
        Set(ByVal grupo_)
            Me.grupo = grupo_
        End Set
    End Property

    Public Property Reporte_Curso_Profesor()
        Get
            Return Me.profesor
        End Get
        Set(ByVal profesor_)
            Me.profesor = profesor_
        End Set
    End Property

    Public Property Reporte_Curso_Horario()
        Get
            Return Me.horario
        End Get
        Set(ByVal horario_)
            Me.horario = horario_
        End Set
    End Property

    Public Property Reporte_Curso_Aula()
        Get
            Return Me.aula
        End Get
        Set(ByVal aula_)
            Me.aula = aula_
        End Set
    End Property

    Public Property Reporte_Curso_Matriculados()
        Get
            Return Me.matriculados
        End Get
        Set(ByVal matriculados_)
            Me.matriculados = matriculados_
        End Set
    End Property
End Class
