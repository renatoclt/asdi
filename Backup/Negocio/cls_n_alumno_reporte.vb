Public Class cls_n_alumno_reporte
    Private id_alumno_ficha As Integer
    Private nombre As String
    Private nombre_grupo As String
    Private horario As String

    Public Property Reporte_Alumno_Codigo()
        Get
            Return Me.id_alumno_ficha
        End Get
        Set(ByVal id_alumno_ficha)
            Me.id_alumno_ficha = id_alumno_ficha
        End Set
    End Property

    Public Property Reporte_Alumno_Nombre()
        Get
            Return Me.nombre
        End Get
        Set(ByVal nombre_)
            Me.nombre = nombre_
        End Set
    End Property

    Public Property Reporte_Grupo_Nombre()
        Get
            Return Me.nombre_grupo
        End Get
        Set(ByVal nombre_grupo_)
            Me.nombre_grupo = nombre_grupo_
        End Set
    End Property

    Public Property Reporte_Horario()
        Get
            Return Me.horario
        End Get
        Set(ByVal horario_)
            Me.horario = horario_
        End Set
    End Property
End Class
