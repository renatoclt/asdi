Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_lista_alumnos_pagos
    Dim obj As New Cls_Notas
    Private frm_rpt_listas_ As frm_rpt_listas
    Public frm_rpt_listas_activo As Boolean = False
    Dim pagos_mes As Integer = 1
    Dim pagos_rango As Integer = 0

    Private Sub frm_lista_alumnos_pagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar_rangos()
        obj.Llenar_Alumnos(Cb_Alumno)
        obj.Autocomplementar_Alumno(Cb_Alumno)
        obj.Llenar_periodo(cbx_periodo)
    End Sub

    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        mostrar_pagos()
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Dim dt As New DataTable
        Dim rptDoc As ReportDocument
        Dim numCols As Integer
        With dt
            .Columns.Add("Nro_Boleta")
            .Columns.Add("Nombre")
            .Columns.Add("Concepto")
            .Columns.Add("Fecha_Creacion")
            .Columns.Add("Hora")
            .Columns.Add("Monto")
            .Columns.Add("Descuento")
            .Columns.Add("Total")
        End With

        Dim row As DataRow
        numCols = DgvNotas.ColumnCount
        For Each filaDatos As DataGridViewRow In DgvNotas.Rows
            row = dt.NewRow()
            For i As Integer = 0 To numCols - 1
                row(i) = filaDatos.Cells(i).Value
            Next
            dt.Rows.Add(row)
        Next

        rptDoc = New rpt_lista_alumno_pagos
        rptDoc.SetDataSource(dt)

        If (Not frm_rpt_listas_activo) Then
            frm_rpt_listas_ = New frm_rpt_listas
            frm_rpt_listas_.crv_reportes.ReportSource = rptDoc
            frm_rpt_listas_.SetFrom(Me)
            frm_rpt_listas_.Show()
            ' frm_rpt_listas_activo = True
        Else
            frm_rpt_listas_.Activate()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        pagos_mes = 1
        pagos_rango = 0
        mostrar_rangos()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        pagos_rango = 1
        pagos_mes = 0
        mostrar_rangos()
    End Sub

    Private Sub Cb_Alumno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Alumno.SelectedIndexChanged
        mostrar_pagos()
    End Sub
    Public Sub mostrar_pagos()
        If pagos_mes = 1 Then
            obj.Mostrar_Pagos_Alumnos(DgvNotas, Convert.ToString(Cb_Alumno.SelectedValue), Convert.ToString(cbx_periodo.SelectedValue))
        ElseIf pagos_rango = 1 Then
            obj.Mostrar_Pagos_Alumnos_Rango_Fechas(DgvNotas, Convert.ToString(Cb_Alumno.SelectedValue), DTPinicial.Text, DTPfinal.Text)
        End If
    End Sub
    Public Sub mostrar_rangos()
        If pagos_mes = 1 Then
            Gpb_1.Visible = True
            Gpb_2.Visible = False
        ElseIf pagos_rango = 1 Then
            Gpb_1.Visible = False
            Gpb_2.Visible = True
        End If
    End Sub

    Private Sub DTPinicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPinicial.ValueChanged
        mostrar_pagos()
    End Sub

    Private Sub DTPfinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPfinal.ValueChanged
        mostrar_pagos()
    End Sub
End Class