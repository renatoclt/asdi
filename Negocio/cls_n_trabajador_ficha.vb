Public Class cls_n_trabajador_ficha
    Private id_trabajador As Integer
    Private id_persona As Integer
    Private tramite As Boolean
    Private caja As Boolean
    Private notas As Boolean
    Private matriculas As Boolean
    Private boletas As Boolean
    Private administrador As Boolean
    Private super As Boolean
    Private activo As Boolean

    Public Property Trabajador_Codigo()
        Get
            Return id_trabajador
        End Get
        Set(ByVal id_trabajador_)
            Me.id_trabajador = id_trabajador_
        End Set
    End Property

    Public Property Trabajador_Persona_Codigo()
        Get
            Return id_persona
        End Get
        Set(ByVal id_persona_)
            Me.id_persona = id_persona_
        End Set
    End Property

    Public Property Trabajador_Tramite()
        Get
            Return tramite
        End Get
        Set(ByVal tramite_)
            Me.tramite = tramite_
        End Set
    End Property

    Public Property Trabajador_Caja()
        Get
            Return caja
        End Get
        Set(ByVal caja_)
            Me.caja = caja_
        End Set
    End Property

    Public Property Trabajador_Notas()
        Get
            Return notas
        End Get
        Set(ByVal notas_)
            Me.notas = notas_
        End Set
    End Property

    Public Property Trabajador_Matriculas()
        Get
            Return matriculas
        End Get
        Set(ByVal matriculas_)
            Me.matriculas = matriculas_
        End Set
    End Property

    Public Property Trabajador_Boletas()
        Get
            Return boletas
        End Get
        Set(ByVal boletas_)
            Me.boletas = boletas_
        End Set
    End Property

    Public Property Trabajador_Administrador()
        Get
            Return administrador
        End Get
        Set(ByVal administrador_)
            Me.administrador = administrador_
        End Set
    End Property

    Public Property Trabajador_Super()
        Get
            Return super
        End Get
        Set(ByVal super_)
            Me.super = super_
        End Set
    End Property

    Public Property Trabajador_Activo()
        Get
            Return activo
        End Get
        Set(ByVal activo_)
            Me.activo = activo_
        End Set
    End Property
End Class
