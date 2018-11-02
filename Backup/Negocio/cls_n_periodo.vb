Public Class cls_n_periodo
    Private id_periodo As Integer
    Private periodo As String
    'Private estado As Boolean
    Private estado As String
    'Private regular As Boolean
    Private regular As String
    Private fecha_inicio As Date
    Private fecha_fin As Date

    Public Property Periodo_Codigo()
        Get
            Return Me.id_periodo
        End Get
        Set(ByVal id_periodo_)
            Me.id_periodo = id_periodo_
        End Set
    End Property

    Public Property Periodo_Nombre()
        Get
            Return Me.periodo
        End Get
        Set(ByVal periodo_)
            Me.periodo = periodo_
        End Set
    End Property

    Public Property Periodo_Estado()
        Get
            Return Me.estado
        End Get
        Set(ByVal estado_)
            Me.estado = estado_
        End Set
    End Property

    Public Property Periodo_Regular()
        Get
            Return Me.regular
        End Get
        Set(ByVal regular_)
            Me.regular = regular_
        End Set
    End Property

    Public Function Periodo_Estado_Boolean() As Boolean
        If (Me.estado = "Abierto") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Periodo_Estado_Boolean(ByVal estado_ As Boolean)
        If (estado_ = True) Then
            Me.estado = "Abierto"
        Else
            Me.estado = "Cerrado"
        End If
    End Sub

    Public Function Periodo_Regular_Boolean() As Boolean
        If (Me.regular = "Si") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Periodo_Regular_Boolean(ByVal regular_ As Boolean)
        If (regular_ = True) Then
            Me.regular = "Si"
        Else
            Me.regular = "No"
        End If
    End Sub

    Public Property Periodo_Fecha_Inicio()
        Get
            Return fecha_inicio.ToString("yyyy/MM/dd")
        End Get
        Set(ByVal fecha_inicio_)
            Me.fecha_inicio = fecha_inicio_
        End Set
    End Property

    Public Property Periodo_Fecha_Fin()
        Get
            Return fecha_fin.ToString("yyyy/MM/dd")
        End Get
        Set(ByVal fecha_fin_)
            Me.fecha_fin = fecha_fin_
        End Set
    End Property
End Class
