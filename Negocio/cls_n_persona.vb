Public Class cls_n_persona
    Private id_persona As Integer
    Private nombres As String
    Private apellido_paterno As String
    Private apellido_materno As String
    Private fecha_nacimiento As Date
    Private id_tp_documento As Integer
    Private nro_documento As String
    Private usuario As String
    Private contrasenia As String
    Private correo_institucional As String
    Private correo_personal As String
    Private telefono_fijo As String
    Private telefono_celular As String
    Private direccion As String
    Private sexo As Char
    Private tipo As Char

    Public Property Persona_Codigo()
        Get
            Return Me.id_persona
        End Get
        Set(ByVal id_persona_)
            Me.id_persona = id_persona_
        End Set
    End Property

    Public Property Persona_Nombres()
        Get
            Return Me.nombres
        End Get
        Set(ByVal nombres_)
            Me.nombres = nombres_
        End Set
    End Property

    Public Property Persona_Apellido_Paterno()
        Get
            Return Me.apellido_paterno
        End Get
        Set(ByVal apellido_paterno_)
            Me.apellido_paterno = apellido_paterno_
        End Set
    End Property

    Public Property Persona_Apellido_Materno()
        Get
            Return Me.apellido_materno
        End Get
        Set(ByVal apellido_materno_)
            Me.apellido_materno = apellido_materno_
        End Set
    End Property

    Public Property Persona_Fecha_Nacimiento()
        Get
            Return Me.fecha_nacimiento
        End Get
        Set(ByVal fecha_nacimiento_)
            Me.fecha_nacimiento = fecha_nacimiento_
        End Set
    End Property

    Public Property Persona_Id_Tp_Documento()
        Get
            Return Me.id_tp_documento
        End Get
        Set(ByVal id_tp_documento_)
            Me.id_tp_documento = id_tp_documento_
        End Set
    End Property

    Public Property Persona_Nro_Documento()
        Get
            Return Me.nro_documento
        End Get
        Set(ByVal nro_documento_)
            Me.nro_documento = nro_documento_
        End Set
    End Property

    Public Property Persona_Usuario()
        Get
            Return Me.usuario
        End Get
        Set(ByVal usuario_)
            Me.usuario = usuario_
        End Set
    End Property

    Public Property Persona_Contrasenia()
        Get
            Return Me.contrasenia
        End Get
        Set(ByVal contrasenia_)
            Me.contrasenia = contrasenia_
        End Set
    End Property

    Public Property Persona_Correo_Institucional()
        Get
            Return Me.correo_institucional
        End Get
        Set(ByVal correo_institucional_)
            Me.correo_institucional = correo_institucional_
        End Set
    End Property

    Public Property Persona_Correo_Personal()
        Get
            Return Me.correo_personal
        End Get
        Set(ByVal correo_persona_)
            Me.correo_personal = correo_persona_
        End Set
    End Property

    Public Property Persona_Telefono_Fijo()
        Get
            Return Me.telefono_fijo
        End Get
        Set(ByVal telefono_fijo_)
            Me.telefono_fijo = telefono_fijo_
        End Set
    End Property

    Public Property Persona_Telefono_Celular()
        Get
            Return Me.telefono_celular
        End Get
        Set(ByVal telefono_celular_)
            Me.telefono_celular = telefono_celular_
        End Set
    End Property

    Public Property Persona_Direccion()
        Get
            Return Me.direccion
        End Get
        Set(ByVal direccion_)
            Me.direccion = direccion_
        End Set
    End Property

    Public Property Persona_Sexo()
        Get
            Return Me.sexo
        End Get
        Set(ByVal sexo_)
            Me.sexo = sexo_
        End Set
    End Property

    Public Property Persona_Tipo()
        Get
            Return Me.tipo
        End Get
        Set(ByVal tipo_)
            Me.tipo = tipo_
        End Set
    End Property

End Class
