Public Class cls_n_persona_anexo
    Private id_persona As Integer
    Private lugar_nacimiento As String
    Private nombre_padre As String
    Private nombre_madre As String
    Private contacto_emergencia As String
    Private telefono_emergencia As String
    'Private foto() As Byte

    Public Property Persona_Anexo_Persona_Codigo()
        Get
            Return Me.id_persona
        End Get
        Set(ByVal id_persona_)
            Me.id_persona = id_persona_
        End Set
    End Property

    Public Property Persona_Anexo_Lugar_Nacimiento()
        Get
            Return Me.lugar_nacimiento
        End Get
        Set(ByVal lugar_nacimiento_)
            Me.lugar_nacimiento = lugar_nacimiento_
        End Set
    End Property

    Public Property Persona_Anexo_Nombre_Padre()
        Get
            Return Me.nombre_padre
        End Get
        Set(ByVal nombre_padre_)
            Me.nombre_padre = nombre_padre_
        End Set
    End Property

    Public Property Persona_Anexo_Nombre_Madre()
        Get
            Return Me.nombre_madre
        End Get
        Set(ByVal nombre_madre_)
            Me.nombre_madre = nombre_madre_
        End Set
    End Property

    Public Property Persona_Anexo_Contacto_Emergencia()
        Get
            Return Me.contacto_emergencia
        End Get
        Set(ByVal contacto_emergencia_)
            Me.contacto_emergencia = contacto_emergencia_
        End Set
    End Property

    Public Property Persona_Anexo_Telefono_Emergencia()
        Get
            Return Me.telefono_emergencia
        End Get
        Set(ByVal telefono_emergencia_)
            Me.telefono_emergencia = telefono_emergencia_
        End Set
    End Property


End Class
