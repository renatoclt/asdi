Public Class cls_n_profesor_reporte
    Private id_profesor_ficha As Integer
    Private nombre As String
    Private estado As String
    Private curso As String
    Private grupo As String
    Private horario As String
    Private aula As String
    Private periodo As String

    Public Property Reporte_Profesor_Codigo()
        Get
            Return Me.id_profesor_ficha
        End Get
        Set(ByVal id_profesor_ficha_)
            Me.id_profesor_ficha = id_profesor_ficha_
        End Set
    End Property

    Public Property Reporte_Profesor_Nombre()
        Get
            Return Me.nombre
        End Get
        Set(ByVal nombre_)
            Me.nombre = nombre_
        End Set
    End Property

    Public Property Reporte_Profesor_Estado()
        Get
            Return Me.estado
        End Get
        Set(ByVal estado_)
            Me.estado = estado_
        End Set
    End Property

    Public Property Reporte_Profesor_Curso()
        Get
            Return Me.curso
        End Get
        Set(ByVal curso_)
            Me.curso = curso_
        End Set
    End Property

    Public Property Reporte_Profesor_Grupo()
        Get
            Return Me.grupo
        End Get
        Set(ByVal grupo_)
            Me.grupo = grupo_
        End Set
    End Property

    Public Property Reporte_Profesor_Horario()
        Get
            Return Me.horario
        End Get
        Set(ByVal horario_)
            Me.horario = horario_
        End Set
    End Property

    Public Property Reporte_Profesor_Aula()
        Get
            Return Me.aula
        End Get
        Set(ByVal aula_)
            Me.aula = aula_
        End Set
    End Property

    Public Property Reporte_Profesor_Periodo()
        Get
            Return Me.periodo
        End Get
        Set(ByVal periodo_)
            Me.periodo = periodo_
        End Set
    End Property
End Class
