﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5466
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''<summary>
'''Represents a strongly typed in-memory cache of data.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
 Global.System.Serializable(),  _
 Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 Global.System.Xml.Serialization.XmlRootAttribute("lista_profesor"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class lista_profesor
    Inherits Global.System.Data.DataSet
    
    Private tablelista_profesor As lista_profesorDataTable
    
    Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet
            ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("lista_profesor")) Is Nothing) Then
                MyBase.Tables.Add(New lista_profesorDataTable(ds.Tables("lista_profesor")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.Browsable(false),  _
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property _lista_profesor() As lista_profesorDataTable
        Get
            Return Me.tablelista_profesor
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.BrowsableAttribute(true),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overrides Function Clone() As Global.System.Data.DataSet
        Dim cln As lista_profesor = CType(MyBase.Clone,lista_profesor)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet
            ds.ReadXml(reader)
            If (Not (ds.Tables("lista_profesor")) Is Nothing) Then
                MyBase.Tables.Add(New lista_profesorDataTable(ds.Tables("lista_profesor")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
        Dim stream As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
        Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tablelista_profesor = CType(MyBase.Tables("lista_profesor"),lista_profesorDataTable)
        If (initTable = true) Then
            If (Not (Me.tablelista_profesor) Is Nothing) Then
                Me.tablelista_profesor.InitVars
            End If
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub InitClass()
        Me.DataSetName = "lista_profesor"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/lista_profesor.xsd"
        Me.EnforceConstraints = true
        Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
        Me.tablelista_profesor = New lista_profesorDataTable
        MyBase.Tables.Add(Me.tablelista_profesor)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Function ShouldSerialize_lista_profesor() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
        Dim ds As lista_profesor = New lista_profesor
        Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType
        Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence
        Dim any As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
        If xs.Contains(dsSchema.TargetNamespace) Then
            Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
            Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
            Try 
                Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                dsSchema.Write(s1)
                Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                Do While schemas.MoveNext
                    schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                    s2.SetLength(0)
                    schema.Write(s2)
                    If (s1.Length = s2.Length) Then
                        s1.Position = 0
                        s2.Position = 0
                        
                        Do While ((s1.Position <> s1.Length)  _
                                    AndAlso (s1.ReadByte = s2.ReadByte))
                            
                            
                        Loop
                        If (s1.Position = s1.Length) Then
                            Return type
                        End If
                    End If
                    
                Loop
            Finally
                If (Not (s1) Is Nothing) Then
                    s1.Close
                End If
                If (Not (s2) Is Nothing) Then
                    s2.Close
                End If
            End Try
        End If
        xs.Add(dsSchema)
        Return type
    End Function
    
    Public Delegate Sub lista_profesorRowChangeEventHandler(ByVal sender As Object, ByVal e As lista_profesorRowChangeEvent)
    
    '''<summary>
    '''Represents the strongly named DataTable class.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
     Global.System.Serializable(),  _
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class lista_profesorDataTable
        Inherits Global.System.Data.TypedTableBase(Of lista_profesorRow)
        
        Private columnid_profesor_ficha As Global.System.Data.DataColumn
        
        Private columnnombre As Global.System.Data.DataColumn
        
        Private columnestado As Global.System.Data.DataColumn
        
        Private columncurso As Global.System.Data.DataColumn
        
        Private columngrupo As Global.System.Data.DataColumn
        
        Private columnhorario As Global.System.Data.DataColumn
        
        Private columnaula As Global.System.Data.DataColumn
        
        Private columnperiodo As Global.System.Data.DataColumn
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "lista_profesor"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property id_profesor_fichaColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnid_profesor_ficha
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property nombreColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnnombre
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property estadoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnestado
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property cursoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columncurso
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property grupoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columngrupo
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property horarioColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnhorario
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property aulaColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnaula
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property periodoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnperiodo
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As lista_profesorRow
            Get
                Return CType(Me.Rows(index),lista_profesorRow)
            End Get
        End Property
        
        Public Event lista_profesorRowChanging As lista_profesorRowChangeEventHandler
        
        Public Event lista_profesorRowChanged As lista_profesorRowChangeEventHandler
        
        Public Event lista_profesorRowDeleting As lista_profesorRowChangeEventHandler
        
        Public Event lista_profesorRowDeleted As lista_profesorRowChangeEventHandler
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Sub Addlista_profesorRow(ByVal row As lista_profesorRow)
            Me.Rows.Add(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Function Addlista_profesorRow(ByVal id_profesor_ficha As Short, ByVal nombre As String, ByVal estado As String, ByVal curso As String, ByVal grupo As String, ByVal horario As String, ByVal aula As String, ByVal periodo As String) As lista_profesorRow
            Dim rowlista_profesorRow As lista_profesorRow = CType(Me.NewRow,lista_profesorRow)
            Dim columnValuesArray() As Object = New Object() {id_profesor_ficha, nombre, estado, curso, grupo, horario, aula, periodo}
            rowlista_profesorRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowlista_profesorRow)
            Return rowlista_profesorRow
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As lista_profesorDataTable = CType(MyBase.Clone,lista_profesorDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New lista_profesorDataTable
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub InitVars()
            Me.columnid_profesor_ficha = MyBase.Columns("id_profesor_ficha")
            Me.columnnombre = MyBase.Columns("nombre")
            Me.columnestado = MyBase.Columns("estado")
            Me.columncurso = MyBase.Columns("curso")
            Me.columngrupo = MyBase.Columns("grupo")
            Me.columnhorario = MyBase.Columns("horario")
            Me.columnaula = MyBase.Columns("aula")
            Me.columnperiodo = MyBase.Columns("periodo")
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitClass()
            Me.columnid_profesor_ficha = New Global.System.Data.DataColumn("id_profesor_ficha", GetType(Short), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnid_profesor_ficha)
            Me.columnnombre = New Global.System.Data.DataColumn("nombre", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnnombre)
            Me.columnestado = New Global.System.Data.DataColumn("estado", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnestado)
            Me.columncurso = New Global.System.Data.DataColumn("curso", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columncurso)
            Me.columngrupo = New Global.System.Data.DataColumn("grupo", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columngrupo)
            Me.columnhorario = New Global.System.Data.DataColumn("horario", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnhorario)
            Me.columnaula = New Global.System.Data.DataColumn("aula", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnaula)
            Me.columnperiodo = New Global.System.Data.DataColumn("periodo", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnperiodo)
            Me.ExtendedProperties.Add("Generator_TablePropName", "_lista_profesor")
            Me.ExtendedProperties.Add("Generator_UserTableName", "lista_profesor")
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function Newlista_profesorRow() As lista_profesorRow
            Return CType(Me.NewRow,lista_profesorRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New lista_profesorRow(builder)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(lista_profesorRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.lista_profesorRowChangedEvent) Is Nothing) Then
                RaiseEvent lista_profesorRowChanged(Me, New lista_profesorRowChangeEvent(CType(e.Row,lista_profesorRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.lista_profesorRowChangingEvent) Is Nothing) Then
                RaiseEvent lista_profesorRowChanging(Me, New lista_profesorRowChangeEvent(CType(e.Row,lista_profesorRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.lista_profesorRowDeletedEvent) Is Nothing) Then
                RaiseEvent lista_profesorRowDeleted(Me, New lista_profesorRowChangeEvent(CType(e.Row,lista_profesorRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.lista_profesorRowDeletingEvent) Is Nothing) Then
                RaiseEvent lista_profesorRowDeleting(Me, New lista_profesorRowChangeEvent(CType(e.Row,lista_profesorRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Removelista_profesorRow(ByVal row As lista_profesorRow)
            Me.Rows.Remove(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence
            Dim ds As lista_profesor = New lista_profesor
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "lista_profesorDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
                Try 
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0
                            
                            Do While ((s1.Position <> s1.Length)  _
                                        AndAlso (s1.ReadByte = s2.ReadByte))
                                
                                
                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If
                        
                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class
    
    '''<summary>
    '''Represents strongly named DataRow class.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Partial Public Class lista_profesorRow
        Inherits Global.System.Data.DataRow
        
        Private tablelista_profesor As lista_profesorDataTable
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tablelista_profesor = CType(Me.Table,lista_profesorDataTable)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property id_profesor_ficha() As Short
            Get
                Try 
                    Return CType(Me(Me.tablelista_profesor.id_profesor_fichaColumn),Short)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'id_profesor_ficha' in table 'lista_profesor' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablelista_profesor.id_profesor_fichaColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property nombre() As String
            Get
                Try 
                    Return CType(Me(Me.tablelista_profesor.nombreColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'nombre' in table 'lista_profesor' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablelista_profesor.nombreColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property estado() As String
            Get
                Try 
                    Return CType(Me(Me.tablelista_profesor.estadoColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'estado' in table 'lista_profesor' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablelista_profesor.estadoColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property curso() As String
            Get
                Try 
                    Return CType(Me(Me.tablelista_profesor.cursoColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'curso' in table 'lista_profesor' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablelista_profesor.cursoColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property grupo() As String
            Get
                Try 
                    Return CType(Me(Me.tablelista_profesor.grupoColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'grupo' in table 'lista_profesor' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablelista_profesor.grupoColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property horario() As String
            Get
                Try 
                    Return CType(Me(Me.tablelista_profesor.horarioColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'horario' in table 'lista_profesor' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablelista_profesor.horarioColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property aula() As String
            Get
                Try 
                    Return CType(Me(Me.tablelista_profesor.aulaColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'aula' in table 'lista_profesor' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablelista_profesor.aulaColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property periodo() As String
            Get
                Try 
                    Return CType(Me(Me.tablelista_profesor.periodoColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'periodo' in table 'lista_profesor' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablelista_profesor.periodoColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function Isid_profesor_fichaNull() As Boolean
            Return Me.IsNull(Me.tablelista_profesor.id_profesor_fichaColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Setid_profesor_fichaNull()
            Me(Me.tablelista_profesor.id_profesor_fichaColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsnombreNull() As Boolean
            Return Me.IsNull(Me.tablelista_profesor.nombreColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetnombreNull()
            Me(Me.tablelista_profesor.nombreColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsestadoNull() As Boolean
            Return Me.IsNull(Me.tablelista_profesor.estadoColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetestadoNull()
            Me(Me.tablelista_profesor.estadoColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IscursoNull() As Boolean
            Return Me.IsNull(Me.tablelista_profesor.cursoColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetcursoNull()
            Me(Me.tablelista_profesor.cursoColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsgrupoNull() As Boolean
            Return Me.IsNull(Me.tablelista_profesor.grupoColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetgrupoNull()
            Me(Me.tablelista_profesor.grupoColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IshorarioNull() As Boolean
            Return Me.IsNull(Me.tablelista_profesor.horarioColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SethorarioNull()
            Me(Me.tablelista_profesor.horarioColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsaulaNull() As Boolean
            Return Me.IsNull(Me.tablelista_profesor.aulaColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetaulaNull()
            Me(Me.tablelista_profesor.aulaColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsperiodoNull() As Boolean
            Return Me.IsNull(Me.tablelista_profesor.periodoColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetperiodoNull()
            Me(Me.tablelista_profesor.periodoColumn) = Global.System.Convert.DBNull
        End Sub
    End Class
    
    '''<summary>
    '''Row event argument class
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Public Class lista_profesorRowChangeEvent
        Inherits Global.System.EventArgs
        
        Private eventRow As lista_profesorRow
        
        Private eventAction As Global.System.Data.DataRowAction
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New(ByVal row As lista_profesorRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Row() As lista_profesorRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
