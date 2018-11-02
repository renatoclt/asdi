Public Class cls_n_tp_documento
    Private id_tp_documento As Integer
    Private tp_documento As String

    Public Property Documento_Codigo()
        Get
            Return Me.id_tp_documento
        End Get
        Set(ByVal id_tp_documento_)
            Me.id_tp_documento = id_tp_documento_
        End Set
    End Property

    Public Property Documento_Nombre()
        Get
            Return Me.tp_documento
        End Get
        Set(ByVal tp_documento_)
            Me.tp_documento = tp_documento_
        End Set
    End Property

End Class
