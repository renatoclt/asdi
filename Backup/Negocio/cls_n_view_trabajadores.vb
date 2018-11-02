Public Class cls_n_view_trabajadores
    Private id_persona As Integer
    Private id_trabajador_ficha As Integer
    Private nombre As String
    Private usuario As String
    Private contrasenia As String
    Private activo As Boolean

    Public Property View_Trabajadores_Codigo_Persona()
        Get
            Return Me.id_persona
        End Get
        Set(ByVal id_persona_)
            Me.id_persona = id_persona_
        End Set
    End Property

    Public Property View_Trabajadores_Codigo_Trabajador()
        Get
            Return Me.id_trabajador_ficha
        End Get
        Set(ByVal id_trabajador_ficha_)
            Me.id_trabajador_ficha = id_trabajador_ficha_
        End Set
    End Property

    Public Property View_Trabajadores_Trabajador_Nombre()
        Get
            Return Me.nombre
        End Get
        Set(ByVal nombre_)
            Me.nombre = nombre_
        End Set
    End Property

    Public Property View_Trabajadores_Usuario()
        Get
            Return usuario
        End Get
        Set(ByVal usuario_)
            Me.usuario = usuario_
        End Set
    End Property

    Public Property View_Trabajadores_Contrasenia()
        Get
            Return contrasenia
        End Get
        Set(ByVal contrasenia_)
            Me.contrasenia = contrasenia_
        End Set
    End Property

    Public Property View_Trabajadores_Activo()
        Get
            Return activo
        End Get
        Set(ByVal activo_)
            Me.activo = activo_
        End Set
    End Property

    Public ReadOnly Property View_Trabajadores_Activo_Cadena()
        Get
            If (activo) Then Return "Si" Else Return "No"
        End Get
    End Property

End Class
