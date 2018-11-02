Public Class cls_n_view_alumnos
    Private id_persona As Integer
    Private id_alumno_ficha As Integer
    Private nombre As String
    Private ciclo As Integer
    Private periodo_inicio As String
    Private estado As String

    Public Property View_Alumno_Codigo_Persona()
        Get
            Return Me.id_persona
        End Get
        Set(ByVal id_persona_)
            Me.id_persona = id_persona_
        End Set
    End Property

    Public Property View_Alumno_Codigo_Alumno()
        Get
            Return Me.id_alumno_ficha
        End Get
        Set(ByVal id_alumno_ficha_)
            Me.id_alumno_ficha = id_alumno_ficha_
        End Set
    End Property

    Public Property View_Alumno_Nombre()
        Get
            Return Me.nombre
        End Get
        Set(ByVal nombre_)
            Me.nombre = nombre_
        End Set
    End Property

    Public Property View_Alumno_Ciclo()
        Get
            Return Me.ciclo
        End Get
        Set(ByVal ciclo_)
            Me.ciclo = ciclo_
        End Set
    End Property

    Public Property View_Alumno_Periodo_Inicio()
        Get
            Return Me.periodo_inicio
        End Get
        Set(ByVal periodo_inicio_)
            Me.periodo_inicio = periodo_inicio_
        End Set
    End Property

    Public Property View_Alumno_Estado()
        Get
            Return Me.estado
        End Get
        Set(ByVal estado_)
            Me.estado = estado_
        End Set
    End Property

End Class
