Public Class cls_n_view_separata_curso
    Private id_separata As Integer
    Private id_curso As Integer
    Private curso As String
    Private separata As String
    Private costo As Decimal
    Private activo As Boolean

    Public Property View_Separata_Curso_Separata_Codigo()
        Get
            Return id_separata
        End Get
        Set(ByVal id_separata_)
            Me.id_separata = id_separata_
        End Set
    End Property

    Public Property View_Separata_Curso_Curso_Codigo()
        Get
            Return id_curso
        End Get
        Set(ByVal id_curso_)
            Me.id_curso = id_curso_
        End Set
    End Property

    Public Property View_Separata_Curso_Curso_Nombre()
        Get
            Return curso
        End Get
        Set(ByVal curso_)
            Me.curso = curso_
        End Set
    End Property

    Public Property View_Separata_Curso_Separata_Nombre()
        Get
            Return separata
        End Get
        Set(ByVal separata_)
            Me.separata = separata_
        End Set
    End Property

    Public Property View_Separata_Curso_Separata_Activo()
        Get
            Return activo
        End Get
        Set(ByVal activo_)
            Me.activo = activo_
        End Set
    End Property

    Public ReadOnly Property View_Separata_Curso_Separata_Activo_Cadena()
        Get
            If (activo) Then Return "Si" Else Return "No"
        End Get
    End Property

    Public Property View_Separata_Curso_Separata_Costo()
        Get
            Return costo
        End Get
        Set(ByVal costo_)
            Me.costo = costo_
        End Set
    End Property
End Class
