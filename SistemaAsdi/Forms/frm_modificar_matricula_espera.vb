Public Class frm_modificar_matricula_espera
    Dim obj As New Cls_Anulacion_Matricula
    Dim obj1 As New Cls_Matricula
    Dim id_alu_fic As Integer
    Dim nombre As String
    Dim id_grupo As Integer
    Dim nom_curso As String

    Private id_plan_est As Integer
    Private id_periodo As Integer
    Private id_matricula As Integer
    Private ciclo As Integer
    Private cd As String

    Private Sub frm_modificar_matricula_espera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.Mostrar_alumnos(DgvAlumnos)
        obj1.Llenar_periodo(cbx_periodo)
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub DgvAlumnos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvAlumnos.CellClick
        Try
            Dim i As Integer
            Dim resp As Integer
            i = DgvAlumnos.CurrentRow.Index
            id_alu_fic = DgvAlumnos.Item(0, i).Value
            nombre = DgvAlumnos.Item(1, i).Value
            id_periodo = DgvAlumnos.Item(2, i).Value
            resp = MsgBox(nombre, MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Alumno Seleccionado")
            If (resp = vbYes) Then
                'btn_Aceptar.Enabled = True
                txt_nombre.Text = nombre
                Buscar_nombre_persona(Convert.ToString(id_alu_fic), Convert.ToString(id_periodo))
                'btn_Aceptar.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Buscar_nombre_persona(ByVal a As String, ByVal b As String)
        txt_nombre.Text = obj1.consulta_nombre_persona(a)
        txt_tipo_alumno.Text = obj1.consulta_tipo_alumno(a)
        txt_plan_estudio.Text = obj1.consulta_plan_estudios(a)
        txt_codigo_alumno.Text = a
        id_grupo = obj1.Obtener_id_grupo_curso(a, b)
        id_plan_est = Convert.ToInt32(obj1.consulta_id_plan_estudios(a))
        id_alu_fic = Convert.ToInt32(a)
        id_matricula = Convert.ToInt32(obj1.consulta_id_matricula_actualizar1(a, b))
        ciclo = Convert.ToInt32(obj1.consulta_curso(a))
        nom_curso = Convert.ToString(obj.consulta_nombre_curso_a(ciclo))
        txt_ciclo.Text = Convert.ToString(ciclo)
        txtnomcur.Text = nom_curso
        TxtIdMatricula.Text = Convert.ToString(id_matricula)
        'cbx_periodo.SelectedValue = b
        cd = "Ok"
        Cargar_Datos()
        btn_Borrar.Enabled = True
    End Sub
    Public Sub Cargar_Datos()
        obj1.Llenar_grupo_curso(cbx_cursos, Convert.ToString(ciclo), Convert.ToString(id_plan_est), Convert.ToString(cbx_periodo.SelectedValue))
    End Sub

    Private Sub cbx_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_periodo.SelectedIndexChanged
        If cd = "Ok" Then
            Cargar_Datos()
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If cbx_cursos.Text = "" Or txt_nombre.Text = "" Then
            MsgBox("Los campos necesarios no estan llenos")
        Else
            If (MessageBox.Show("Desea actualizar los datos de Matricula", "Asdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                If obj1.Verificar_Periodo(cbx_periodo.SelectedValue) >= 1 Then
                    obj1.Actualizar_matricula(id_matricula, Convert.ToInt32(cbx_cursos.SelectedValue), Convert.ToInt32(cbx_periodo.SelectedValue))
                    MsgBox("Se actualizaron los datos")
                    limpiar()
                Else
                    MsgBox("El Periodo ya caduco")
                End If
            End If
        End If
    End Sub
    Public Sub limpiar()
        txt_nombre.Clear()
        txt_tipo_alumno.Clear()
        txt_plan_estudio.Clear()
        txt_codigo_alumno.Clear()
        TxtIdMatricula.Clear()
        id_plan_est = 0
        id_alu_fic = 0
        id_matricula = 0
        ciclo = 0
        txt_ciclo.Clear()
        cd = "No"
        Cargar_Datos()
        obj.Mostrar_alumnos(DgvAlumnos)
        btn_Borrar.Enabled = False
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        If TxtIdMatricula.Text = "" Then
            MsgBox("Seleccione un alumno")
        Else
            Dim resp As Integer
            resp = MsgBox("Desea anular la matricula separada del alumno(a): " + nombre, MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Asdi")
            If (resp = vbYes) Then
                obj.Anulacion_de_Matricula(id_matricula)
                MsgBox("Se anulo la matricula")
                limpiar()
            End If
        End If
    End Sub
End Class