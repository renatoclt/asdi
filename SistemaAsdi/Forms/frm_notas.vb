Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Data
Public Class frm_notas
    'Definir enlace a datos y objetos del form
    Dim obj As New Cls_Notas
    'Private MiConexion As New MySqlConnection("Database=asdi ;Data Source=192.168.1.43;User Id=asdi;Password=YES")
    Private MiConexion As New MySqlConnection("Database=asdi ;Data Source=localhost;User Id=root;Password=YES")
    Private MiAdaptador As MySqlDataAdapter = New MySqlDataAdapter()
    'Private MiAdaptador As New MySqlDataAdapter("SELECT id_matricula as Id_matricula, id_alumno_ficha as Id_alumno, promedio_final as Promedio_Final, aprobo as Aprobo FROM matricula", MiConexion)
    'Private MiAdaptador As New MySqlDataAdapter("SELECT id_matricula as Id_matricula, id_alumno_ficha as Id_alumno, promedio_final as Promedio_Final, aprobo as Aprobo FROM matricula where id_curso_grupo = '" & a & "' and id_periodo ='" & a & "'", MiConexion)
    Private MiDataSet As New DataSet()
    Private MiEnlazador As New BindingSource
    'Private MidataGriView As New DataGridView
    'Private BotonGuardar As New Button
    Dim a As String
    Dim b As String

    Private Sub frm_notas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.Llenar_periodo(CbPeriodo)
        Panel1.Visible = True
        Panel2.Visible = False
        GroupBox2.Visible = False
        'MessageBox.Show(My.Computer.FileSystem.CurrentDirectory)
        'Poner titulo a la aplicacion
        'Me.Text = "Mantenimiento de Shippers"
        'Añadir DataGriView
        'MidataGriView.Dock = DockStyle.Top
        'Me.Controls.Add(MidataGriView)
        'BotonGuardar.Dock = DockStyle.Bottom
        ''Añadir Boton de Guardar
        'BotonGuardar.Text = "Guardar Cambios"
        'Me.Controls.Add(BotonGuardar)
   
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Me.MiAdaptador.Update(CType(Me.MiEnlazador.DataSource, DataTable))
        obj.Actualizar_matricula_aprobacion()
        MsgBox("Se actualizaron las notas")
        Panel1.Visible = True
        Panel2.Visible = False
        GroupBox2.Visible = False
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Panel2.Visible = False
        GroupBox2.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub CbPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbPeriodo.SelectedIndexChanged
        DataGridView1.DataSource = Nothing
        obj.Llenar_horario(cbx_turno, Convert.ToString(CbPeriodo.SelectedValue))
    End Sub

    Private Sub cbx_turno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_turno.SelectedIndexChanged
        DataGridView1.DataSource = Nothing
        obj.Llenar_curso(Cb_Curso, Convert.ToString(CbPeriodo.SelectedValue), Convert.ToString(cbx_turno.SelectedValue))
    End Sub

    Private Sub Cb_Curso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Curso.SelectedIndexChanged
        DataGridView1.DataSource = Nothing
        obj.Llenar_aula(Cb_Seccion, Convert.ToString(Cb_Curso.SelectedValue), Convert.ToString(cbx_turno.SelectedValue))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mostrar()
    End Sub
    Public Sub mostrar()
        Try
            DataGridView1.DataSource = Nothing
            MiDataSet.Clear()
            a = Convert.ToString(Cb_Curso.SelectedValue)
            b = Convert.ToString(CbPeriodo.SelectedValue)

            Dim command As MySqlCommand = New MySqlCommand("SELECT id_matricula as Id_matricula, id_alumno_ficha as Id_alumno, promedio_final as Promedio_Final, aprobo as Aprobo FROM matricula where id_curso_grupo = '" & a & "' and id_periodo ='" & b & "'", MiConexion)
            Me.MiAdaptador.SelectCommand = command
            AddHandler Guardar.Click, AddressOf Guardar_Click
            Dim commandbuilder As New MySqlCommandBuilder(Me.MiAdaptador)
            MiConexion.Open()
            MiAdaptador.Fill(MiDataSet)
            MiEnlazador.DataSource = MiDataSet.Tables(0)
            DataGridView1.DataSource = MiEnlazador
            MiConexion.Close()

            Lbl_Aula.Text = obj.consulta_aula(a)
            Lbl_Profesor.Text = obj.consulta_profesor(a)
            Panel1.Visible = False
            Panel2.Visible = True
            GroupBox2.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Lb_Codigo.Text = Convert.ToString(DataGridView1.CurrentRow.Cells(1).Value)
        LblNombre.Text = obj.consulta_nombre_persona(Convert.ToString(DataGridView1.CurrentRow.Cells(1).Value))
    End Sub

    'SELECT id_alumno_ficha, nombre, id_curso, nombre_grupo, curso, fecha_creacion, promedio_final  from (Select a.id_alumno_ficha, concat (p.apellido_paterno,' ',p.apellido_materno,' ',p.nombres) as nombre, s.id_curso, c.nombre_grupo, s.curso, insert(m.fecha_creacion,8,12,' ') as fecha_creacion, m.promedio_final from persona p, alumno_ficha a, curso_grupo c, curso_ofertado o, matricula m, curso s where p.id_persona = a.id_persona and o.id_curso_ofertado = c.id_curso_ofertado and m.id_alumno_ficha = a.id_alumno_ficha and m.id_curso_grupo = c.id_curso_grupo and o.id_curso = s.id_curso order by s.curso , m.promedio_final DESC) as datos where id_alumno_ficha='13' group by curso ;

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class