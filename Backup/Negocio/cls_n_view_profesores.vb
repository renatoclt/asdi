Public Class cls_n_view_profesores
    Private id_persona As Integer
    Private id_profesor_ficha As Integer
    Private nombre As String
    Private estado As Boolean

    Public Property View_Profesores_Codigo_Persona()
        Get
            Return Me.id_persona
        End Get
        Set(ByVal id_persona_)
            Me.id_persona = id_persona_
        End Set
    End Property

    Public Property View_Profesores_Codigo_Profesor()
        Get
            Return Me.id_profesor_ficha
        End Get
        Set(ByVal id_profesor_ficha_)
            Me.id_profesor_ficha = id_profesor_ficha_
        End Set
    End Property

    Public Property View_Profesores_Profesor_Nombre()
        Get
            Return Me.nombre
        End Get
        Set(ByVal nombre_)
            Me.nombre = nombre_
        End Set
    End Property

    Public Property View_Profesores_Estado()
        Get
            Return Me.estado
        End Get
        Set(ByVal estado_)
            Me.estado = estado_
        End Set
    End Property

    Public ReadOnly Property View_Profesores_Estado_Cadena()
        Get
            If (estado) Then Return "Si" Else Return "No"
        End Get
    End Property
End Class
