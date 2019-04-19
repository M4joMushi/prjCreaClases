Public Class CMiembroMySQL

#Region "Miembros Privados"
    Private m_str_NombreCompleto As String
    Private m_str_Propiedad As String
    Private m_str_Ambito As String
    Private m_str_Tipo As String
    Private m_str_TipoBD As String
    Private m_s_Tamano As Short
    Private m_str_Prefijo As String
    Private m_bol_EsPK As Boolean
    Private m_str_campoBD As String
    Private m_str_TipoBDCompleto As String
    Private m_str_Default As String
    Private m_str_extra As String

    'Indica si la fila ha sido modificada
    Private m_chr_EstadoFila As Char
#End Region

#Region "Public Properties"
    Public Property TipoBDCompleto() As String
        Get
            Return m_str_TipoBDCompleto
        End Get
        Set(ByVal Value As String)
            m_str_TipoBDCompleto = Value
        End Set
    End Property

    Public Property CampoBD() As String
        Get
            Return m_str_campoBD
        End Get
        Set(ByVal Value As String)
            m_str_campoBD = Value

        End Set
    End Property

    Public Property Tamano() As Short
        Get
            Return m_s_Tamano
        End Get
        Set(ByVal Value As Short)
            m_s_Tamano = Value
        End Set
    End Property

    Public Property EsPK() As Boolean
        Get
            Return m_bol_EsPK
        End Get
        Set(ByVal Value As Boolean)
            m_bol_EsPK = Value
        End Set
    End Property

    Public Property TipoBD() As String
        Get
            Return m_str_TipoBD
        End Get
        Set(ByVal Value As String)
            m_str_TipoBD = Value.Trim()
        End Set
    End Property

    Public Property NombreCompleto() As String
        Get
            Return m_str_NombreCompleto
        End Get
        Set(ByVal Value As String)
            m_str_NombreCompleto = Value
        End Set
    End Property

    Public Property Prefijo() As String
        Get
            Return m_str_Prefijo
        End Get
        Set(ByVal Value As String)
            m_str_Prefijo = Value
        End Set
    End Property

    Public Property Propiedad() As String
        Get
            Return m_str_Propiedad
        End Get
        Set(ByVal Value As String)
            m_str_Propiedad = Value
            'U = Updated
            m_chr_EstadoFila = "U"
        End Set
    End Property

    Public Property Ambito() As String
        Get
            Return m_str_Ambito
        End Get
        Set(ByVal Value As String)
            m_str_Ambito = Value
            'U = Updated
            m_chr_EstadoFila = "U"
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return m_str_Tipo
        End Get
        Set(ByVal Value As String)
            m_str_Tipo = Value
            'U = Updated
            m_chr_EstadoFila = "U"
        End Set
    End Property

    Public Property V_Default() As String
        Get
            Return m_str_Default
        End Get
        Set(ByVal value As String)
            m_str_Default = value
        End Set
    End Property

    Public Property EstadoFila() As Char
        Get
            Return m_chr_EstadoFila
        End Get
        Set(ByVal Value As Char)
            m_chr_EstadoFila = Value
        End Set
    End Property

    Public Property Extra() As String
        Get
            Return m_str_extra
        End Get
        Set(ByVal value As String)
            m_str_extra = value
        End Set
    End Property

#End Region

#Region "Public Methods"

    Public Sub New()
        m_str_Propiedad = ""
        m_str_Ambito = ""
        m_str_Tipo = ""
        m_str_TipoBD = ""
        'N = New
        m_chr_EstadoFila = "N"
        m_bol_EsPK = False
        m_s_Tamano = -1
        m_str_campoBD = ""
        m_str_TipoBDCompleto = ""
        m_str_extra = ""
    End Sub

    'Public Sub New(ByVal pNombreCompleto As String, ByVal pPropiedad As String, ByVal pAmbito As String, ByVal pTipo As String, ByVal pTipoBD As String, ByVal pEsPK As Boolean)
    '    m_str_NombreCompleto = pNombreCompleto
    '    m_str_Propiedad = pPropiedad
    '    m_str_Ambito = pAmbito
    '    m_str_Tipo = pTipo
    '    m_str_TipoBD = pTipoBD
    '    m_bol_EsPK = pEsPK
    '    'N = New
    '    m_chr_EstadoFila = "N"
    'End Sub

    Public Sub Delete()
        'D = Deleted
        m_chr_EstadoFila = "D"
    End Sub
#End Region

End Class

Public Class CMiembrosMySQL
    Inherits CollectionBase

#Region "Miembros Privados"
    Private m_str_NombreClase As String
    Private m_str_NombreColeccion As String
#End Region

#Region "Propiedades"

    Public Property NombreClase() As String
        Get
            Return m_str_NombreClase
        End Get
        Set(ByVal Value As String)
            m_str_NombreClase = Value
        End Set
    End Property

    Public Property NombreColeccion() As String
        Get
            Return m_str_NombreColeccion
        End Get
        Set(ByVal Value As String)
            m_str_NombreColeccion = Value
        End Set
    End Property

#End Region

    Enum Tipo_Tabla
        Tabla
        Vista
    End Enum


#Region "Public Methods"

    Public Sub New()
        MyBase.New()
    End Sub

    'Mediante esta función se buscan los objetos que han sido modificados
    'No es utilizada en el programa
    Public Function ChangedRecords() As CMiembrosMySQL
        Dim objBase As CMiembroMySQL
        Dim objColeccion As CMiembrosMySQL

        For Each objBase In Me
            If objBase.EstadoFila = "U" Then
                objColeccion.Agregar(objBase)
            End If
        Next
        Return objColeccion
    End Function

    'Permite insertar un elemento en la colección con un indice específico
    Public Sub Insertar(ByVal iIndex As Integer, ByVal objBase As CMiembroMySQL)
        InnerList.Insert(iIndex, objBase)
    End Sub

    'Borra un elemento de la colección
    Public Sub Borrar(ByVal objBase As CMiembroMySQL)
        InnerList.Remove(objBase)
    End Sub

    'Indica el indice de un objeto en la coleccion
    Public Function IndiceDe(ByVal objBase As CMiembroMySQL) As Integer
        Return InnerList.IndexOf(objBase)
    End Function

    'Indica si un objeto esta contenido en la colección
    Public Function Contiene(ByVal objBase As CMiembroMySQL) As Boolean
        Return InnerList.Contains(objBase)
    End Function

    'Permite agregar elementos en la coleccion
    Public Function Agregar(ByVal objBase As CMiembroMySQL) As Integer
        Return InnerList.Add(objBase)
    End Function


    'Mediante esta función y los datos que se proveen, 
    'se genera una clase con sus datos miembro y las propiedades para
    'accederlos, tambien se genera una colección para almacenar objetos
    'y al final una clase que permite ordenar la colección de objetos
    'Se agrego el manejo de Vista para que ponga un namespace extra con la palabra "Vista"
    Public Function GeneraClase(Optional ByVal frm As frmCCMySQLSchema = Nothing, _
                                Optional TTabla As Tipo_Tabla = Tipo_Tabla.Tabla) As String
        Dim objBase As CMiembroMySQL
        Dim strTEMPO As String
        Dim CUENTA As Integer
        Dim CUENTA1 As Integer
        'Dim mTab As String = Chr(9)
        Dim Tiene_LLave As Boolean = False
        Dim Clase As New System.Text.StringBuilder

        GeneraClase = ""
        Try

            'Verifico si la tabla tiene una llave principal
            For Each objBase In Me
                If objBase.EsPK = True Then
                    Tiene_LLave = True
                    Exit For
                End If
            Next

            Clase.Append("NameSpace " & frm.cbNameSpace.Text & vbNewLine)

            'Primero Crea la Clase Base
            If frm.txtSubNameSpace.Text.Length <> 0 Then
                Clase.Append(MTab(1) & "NameSpace " & frm.txtSubNameSpace.Text & vbNewLine)
            End If

            If TTabla = Tipo_Tabla.Vista Then
                Clase.Append(MTab(1) & "NameSpace Vista" & vbNewLine)
            End If

            Clase.Append(MTab(1) & "Public Class " & Me.NombreClase & vbNewLine & vbNewLine)

            'Primero carga todos los datos miembro dentro de una region "Miembros"
            Clase.Append("#Region ""Miembros""" & vbNewLine & vbNewLine)

            'Genero la Estructura que me guarda un registro entero
            Clase.Append(MTab(1) & "<Serializable()> Public Structure " & frm.lvTABLAS.SelectedItems(0).Text.ToUpper & vbNewLine & _
                         MTab(2) & "Dim Simon_REGISTRO as Boolean" & vbNewLine & _
                         MTab(2) & "Dim MERROR as String" & vbNewLine)

            For Each objBase In Me
                Clase.Append(MTab(2) & "Dim " & objBase.Propiedad.ToUpper & " As " & objBase.Tipo & vbNewLine)
            Next

            'Se esta agregando manejo de reset a la structura para borrar campos.

            Clase.Append(MTab(2) & "Sub ReSet(Optional Tipo_ReSet As Definicion.ReSet_Struc = Definicion.ReSet_Struc.Total)" & vbNewLine)
            Clase.Append(MTab(3) & "If Tipo_ReSet = Definicion.ReSet_Struc.Total OrElse Tipo_ReSet = Definicion.ReSet_Struc.Llave Then" & vbNewLine)
            'Aqui va la limpieza de la LLave
            For Each objBase In Me
                If objBase.EsPK = True Then
                    Select Case UCase(objBase.Tipo)
                        Case "DECIMAL", "INTEGER", "SHORT", "LONG"
                            Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = 0" & vbNewLine)
                        Case "BOOLEAN"
                            Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = false" & vbNewLine)
                        Case "DATETIME", "MYSQLDATETIME"
                            Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)" & vbNewLine)
                        Case "TIMESPAN"
                            Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = New TimeSpan(0, 0, 0)" & vbNewLine)
                        Case Else
                            If InStr(objBase.TipoBD.ToUpper, "BLOB", CompareMethod.Text) <> 0 Or _
                               InStr(objBase.TipoBD.ToUpper, "BINARY", CompareMethod.Text) <> 0 Then
                                Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = Nothing" & vbNewLine)
                            Else
                                Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = """"" & vbNewLine)
                            End If
                    End Select
                End If
            Next
            Clase.Append(MTab(3) & "End if" & vbNewLine & _
                         MTab(3) & "If Tipo_ReSet = Definicion.ReSet_Struc.Total OrElse Tipo_ReSet = Definicion.ReSet_Struc.No_Llave Then" & vbNewLine)
            'Aqui va la limpieza de los campos No Llave
            For Each objBase In Me
                If objBase.EsPK = False Then
                    Select Case UCase(objBase.Tipo)
                        Case "DECIMAL", "INTEGER", "SHORT", "LONG"
                            Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = 0" & vbNewLine)
                        Case "BOOLEAN"
                            Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = false" & vbNewLine)
                        Case "DATETIME", "MYSQLDATETIME"
                            Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)" & vbNewLine)
                        Case "TIMESPAN"
                            Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = New TimeSpan(0, 0, 0)" & vbNewLine)
                        Case Else
                            If InStr(objBase.TipoBD.ToUpper, "BLOB", CompareMethod.Text) <> 0 Or _
                               InStr(objBase.TipoBD.ToUpper, "BINARY", CompareMethod.Text) <> 0 Then
                                Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = Nothing" & vbNewLine)
                            Else
                                Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & " = """"" & vbNewLine)
                            End If
                    End Select
                End If
            Next

            Clase.Append(MTab(3) & "End If" & vbNewLine)
            Clase.Append(MTab(2) & "End Sub" & vbNewLine)

            'Agrego función de Hash
            Clase.Append(MTab(2) & "Public Overrides Function GetHashCode() as Integer" & vbNewLine)
            Clase.Append(MTab(3) & "Try" & vbNewLine)
            'Pongo los campos a calcular su hash
            CUENTA = 0
            For Each objBase In Me
                CUENTA += 1
                If objBase.TipoBD = "TIMESTAMP" Then Continue For
                Select Case CUENTA
                    Case 1
                        Clase.Append(MTab(4) & "Return " & objBase.Propiedad.ToUpper & ".GetHashCode xor _" & vbNewLine)
                    Case Me.Count
                        Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & ".GetHashCode" & vbNewLine)
                    Case Else
                        Clase.Append(MTab(4) & objBase.Propiedad.ToUpper & ".GetHashCode xor _" & vbNewLine)
                End Select
            Next
            'Tengo que quitar el ultimo _
            If Mid(Clase.ToString, Clase.Length - 6, 5) = "xor _" Then
                Clase.Remove(Clase.Length - 7, 5)
            End If


            Clase.Append(MTab(3) & "Catch ex As Exception" & vbNewLine)
            Clase.Append(MTab(4) & "Throw New System.Exception(""Error Calculando HashCode"",ex)" & vbNewLine)
            Clase.Append(MTab(3) & "End Try" & vbNewLine)
            Clase.Append(MTab(2) & "End Function" & vbNewLine)

            Clase.Append(MTab(1) & "End Structure" & vbNewLine & vbNewLine)

            'Creo las variables internas de la clase
            For Each objBase In Me
                Clase.Append(MTab(1) & objBase.Ambito & " " & objBase.NombreCompleto & " As " & objBase.Tipo & vbNewLine)
            Next
            'Agrega 1 datos miembro, estado del objeto
            Clase.Append(MTab(1) & "Private MENSAJE As String" & vbNewLine & _
                         MTab(1) & "Private Cantidad_de_la_Clase As Integer = 0" & vbNewLine & _
                         MTab(1) & "Private CON As MySqlConnection" & vbNewLine & _
                         MTab(1) & "Private TRA As MySqlTransaction" & vbNewLine & _
                         MTab(1) & "Private REA As MysqlDataReader" & vbNewLine & _
                         MTab(1) & "Private CONstr As String" & vbNewLine & _
                         MTab(1) & "Dim _Usar_Transaccion_Select As Boolean = False" & vbNewLine & _
                         MTab(1) & "Dim _TimeOut as Integer = 30" & vbNewLine & vbNewLine & _
                         "#End Region" & vbNewLine & vbNewLine)

            'Luego crea las propiedades para acceder 
            Clase.Append("#Region ""Propiedades""" & vbNewLine & vbNewLine)

            For Each objBase In Me
                Clase.Append(MTab(1) & "Public Property " & objBase.Propiedad.ToUpper & "() As " & objBase.Tipo & vbNewLine & _
                             MTab(1) & "Get" & vbNewLine)
                If objBase.Tipo = "String" Then
                    Clase.Append(MTab(2) & "return " & objBase.NombreCompleto & ".Trim()" & vbNewLine)
                Else
                    Clase.Append(MTab(2) & "return " & objBase.NombreCompleto & vbNewLine)
                End If
                Clase.Append(MTab(1) & "End Get" & vbNewLine & _
                             MTab(1) & "Set (ByVal Value As " & objBase.Tipo & ")" & vbNewLine & _
                             MTab(2) & objBase.NombreCompleto & " = Value " & vbNewLine & _
                             MTab(1) & "End Set" & vbNewLine & _
                             MTab(1) & "End Property" & vbNewLine & vbNewLine)

                If UCase(objBase.Tipo) = "MYSQLDATETIME" Then
                    'Le creo una propiedad con tipo datetime para asignar fechas del net más facil
                    Clase.Append(MTab(1) & "Public WriteOnly Property " & objBase.Propiedad & "_NET() As DateTime" & vbNewLine & _
                                 MTab(1) & "Set (ByVal Value As DateTime)" & vbNewLine & _
                                 MTab(2) & objBase.NombreCompleto & " = new MySQLDATETIME(Value) " & vbNewLine & _
                                 MTab(1) & "End Set" & vbNewLine & _
                                 MTab(1) & "End Property" & vbNewLine & vbNewLine)
                End If
            Next

            Clase.Append(MTab(1) & "Public ReadOnly Property CantRecorSet() as Integer" & vbNewLine & _
                         MTab(2) & "Get" & vbNewLine & _
                         MTab(3) & "Return Cantidad_de_la_Clase" & vbNewLine & _
                         MTab(2) & "End Get" & vbNewLine & _
                         MTab(1) & "End Property" & vbNewLine & vbNewLine & _
                         MTab(1) & "Public Property CONEXION() As String" & vbNewLine & _
                         MTab(2) & "Set (ByVal VALUE as string)" & vbNewLine & _
                         MTab(3) & "CONstr = VALUE" & vbNewLine & _
                         MTab(3) & "Try" & vbNewLine & _
                         MTab(4) & "MENSAJE = """"" & vbNewLine & _
                         MTab(4) & "Dim Status As Tipo_Status_Ping = Verifica_PING(VALUE)" & vbNewLine & _
                         MTab(4) & "If Status <> Tipo_Status_Ping.OK Then" & vbNewLine & _
                         MTab(5) & "Mensaje = ""BiblioTABLAS - " & Me.NombreClase & " - CONEXION No se logro hacer pineo a Servidor Error:"" & _" & vbNewLine & _
                         MTab(5) & "          Status.ToString" & vbNewLine & _
                         MTab(5) & "Throw New System.Exception(""Error. No se logro hacer pineo a Servidor"" & vbNewLine & _" & vbNewLine & _
                         MTab(5) & "                           ""Conexión:"" & VALUE & vbNewLine & ""Error:"" & Status.ToString)" & vbNewLine & _
                         MTab(5) & "Exit Property" & vbNewLine & _
                         MTab(4) & "End If" & vbNewLine & _
                         MTab(4) & "If isnothing(CON) = true then" & vbNewLine & _
                         MTab(5) & "CON = new MySqlConnection" & vbNewLine & _
                         MTab(4) & "End If" & vbNewLine & _
                         MTab(4) & "If CON.State = ConnectionState.Open then" & vbNewLine & _
                         MTab(5) & "CON.Close()" & vbNewLine & _
                         MTab(4) & "End If" & vbNewLine & _
                         MTab(4) & "CON.ConnectionString = CONstr" & vbNewLine & _
                         MTab(4) & "CON.Open()" & vbNewLine & _
                         MTab(3) & "Catch MyEX as MySqlException" & vbNewLine & _
                         MTab(4) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - CONEXION MyError="" & MyEX.ToString" & vbNewLine & _
                         MTab(4) & "Throw New System.Exception(""MySQLError#:"" & MyEX.Number.ToString(""0000"") & "" Error MySQL Conectando con Servidor"" & vbNewline & ""Conexión:"" & value , MyEX)" & vbNewLine & _
                         MTab(3) & "Catch EX as Exception" & vbNewLine & _
                         MTab(4) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - CONEXION Error="" & EX.ToString" & vbNewLine & _
                         MTab(4) & "Throw New System.Exception(""Error no contemplado Conectando Servidor"" & vbNewline & ""Conexión:"" & Value, Ex)" & vbNewLine & _
                         MTab(3) & "End Try" & vbNewLine & _
                         MTab(2) & "End Set" & vbNewLine & _
                         MTab(2) & "Get" & vbNewLine & _
                         MTab(3) & "Return CONstr" & vbNewLine & _
                         MTab(2) & "End Get" & vbNewLine & _
                         MTab(1) & "End Property" & vbNewLine & vbNewLine & _
                         MTab(1) & "Public WriteOnly Property TRANSACCION() As MySqlTransaction" & vbNewLine & _
                         MTab(2) & "Set (ByVal VALUE as MySqlTransaction)" & vbNewLine & _
                         MTab(3) & "TRA = VALUE" & vbNewLine & _
                         MTab(3) & "_Usar_Transaccion_Select = False" & vbNewLine & _
                         MTab(3) & "If IsNothing(VALUE) = False then _Usar_Transaccion_Select = True" & vbNewLine & _
                         MTab(2) & "End Set" & vbNewLine & _
                         MTab(1) & "End Property" & vbNewLine & vbNewLine & _
                         MTab(1) & "Public ReadOnly Property MERROR() As String" & vbNewLine & _
                         MTab(2) & "Get" & vbNewLine & _
                         MTab(3) & "Return MENSAJE" & vbNewLine & _
                         MTab(2) & "End Get" & vbNewLine & _
                         MTab(1) & "End Property" & vbNewLine & vbNewLine & _
                         MTab(1) & "Public Property Usar_Transaccion_Select as Boolean" & vbNewLine & _
                         MTab(2) & "Get" & vbNewLine & _
                         MTab(3) & "Return _Usar_Transaccion_Select" & vbNewLine & _
                         MTab(2) & "End Get" & vbNewLine & _
                         MTab(2) & "Set(ByVal Value as Boolean)" & vbNewLine & _
                         MTab(3) & "_Usar_Transaccion_Select = Value" & vbNewLine & _
                         MTab(2) & "End Set" & vbNewLine & _
                         MTab(1) & "End Property" & vbNewLine & vbNewLine & _
                         MTab(1) & "Public Property TimeOut() As Integer" & vbNewLine & _
                         MTab(2) & "Get" & vbNewLine & _
                         MTab(3) & "Return _TimeOut" & vbNewLine & _
                         MTab(2) & "End Get" & vbNewLine & _
                         MTab(2) & "Set(ByVal Value As Integer)" & vbNewLine & _
                         MTab(3) & "_TimeOut = Value" & vbNewLine & _
                         MTab(2) & "End Set" & vbNewLine & _
                         MTab(1) & "End Property" & vbNewLine & vbNewLine & _
                         "#End Region" & vbNewLine & vbNewLine)

            'POR ÚLTIMO CREA LA FUNCIÓN PARA GUARDAR
            Clase.Append("#Region ""Funciones Publicas""" & vbNewLine & vbNewLine)

            'PRIMERO, AGREGA EL CONSTRUCTOR DE LA CLASE, YA QUE A MANO ES UN PAIN IN THE ASS
            Clase.Append(MTab(1) & "Public Sub New()" & vbNewLine)
            For Each objBase In Me
                Select Case UCase(objBase.Tipo)
                    Case "DECIMAL", "INTEGER", "SHORT", "LONG"
                        Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = 0" & vbNewLine)
                    Case "BOOLEAN"
                        Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = false" & vbNewLine)
                    Case "DATETIME", "MYSQLDATETIME"
                        Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)" & vbNewLine)
                    Case "TIMESPAN"
                        Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = New TimeSpan(0, 0, 0)" & vbNewLine)
                    Case Else
                        If InStr(objBase.TipoBD.ToUpper, "BLOB", CompareMethod.Text) <> 0 Or _
                           InStr(objBase.TipoBD.ToUpper, "BINARY", CompareMethod.Text) <> 0 Then
                            Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = Nothing" & vbNewLine)
                        Else
                            Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = """"" & vbNewLine)
                        End If
                End Select
            Next
            Clase.Append(MTab(1) & "End Sub" & vbNewLine & vbNewLine)

            Clase.Append(MTab(1) & "Public Sub Reset(Optional ByVal Tipo as Definicion.TipoReset = Definicion.TipoReset.Data)" & vbNewLine & _
                         MTab(2) & "Try" & vbNewLine & _
                         MTab(3) & "MENSAJE = """"" & vbNewLine & _
                         MTab(3) & "_Usar_Transaccion_Select = False" & vbNewLine)
            If Tiene_LLave = True Then Clase.Append(MTab(3) & "INIT_LLAVE()" & vbNewLine)
            Clase.Append(MTab(3) & "INIT()" & vbNewLine & _
                            MTab(3) & "If Tipo = Definicion.TipoReset.Full Then" & vbNewLine & _
                            MTab(4) & "Dispose()" & vbNewLine & _
                            MTab(3) & "End If" & vbNewLine & _
                            MTab(2) & "Catch Ex as Exception" & vbNewLine & _
                            MTab(3) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - RESET No se pudo hacer el Reset de la Clase"" & Ex.ToString" & vbNewLine & _
                            MTab(3) & "Throw new System.Exception(""Error no Contemplado"", Ex)" & vbNewLine & _
                            MTab(2) & "End Try" & vbNewLine & _
                            MTab(1) & "End Sub" & vbNewLine & vbNewLine & _
                            MTab(1) & "Public Sub Dispose()" & vbNewLine & _
                            MTab(2) & "Try" & vbNewLine & _
                            MTab(3) & "If IsNothing(REA) = False then" & vbNewLine & _
                            MTab(4) & "Rea.Close" & vbNewLine & _
                            MTab(3) & "End If" & vbNewLine & _
                            MTab(3) & "If isnothing(CON) = False Then" & vbNewLine & _
                            MTab(4) & "if CON.State = ConnectionState.Open then" & vbNewLine & _
                            MTab(5) & "CON.Close()" & vbNewLine & _
                            MTab(4) & "End If" & vbNewLine & _
                            MTab(3) & "End If" & vbNewLine & _
                            MTab(3) & "CON = Nothing" & vbNewLine & _
                            MTab(3) & "REA = Nothing" & vbNewLine & _
                            MTab(3) & "_Usar_Transaccion_Select = false" & vbNewLine & _
                            MTab(3) & "TRA = Nothing" & vbNewLine & _
                            MTab(2) & "Catch EX as Exception" & vbNewLine & _
                            MTab(2) & "End Try" & vbNewLine & _
                            MTab(1) & "End Sub" & vbNewLine & vbNewLine)

            Clase.Append(MTab(1) & "Private Sub INIT()" & vbNewLine)
            For Each objBase In Me
                If objBase.EsPK = False Then
                    Select Case UCase(objBase.Tipo)
                        Case "DECIMAL", "INTEGER", "SHORT", "LONG"
                            Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = 0" & vbNewLine)
                        Case "BOOLEAN"
                            Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = false" & vbNewLine)
                        Case "DATETIME", "MYSQLDATETIME"
                            Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)" & vbNewLine)
                        Case "TIMESPAN"
                            Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = New TimeSpan(0, 0, 0)" & vbNewLine)
                        Case Else
                            If InStr(objBase.TipoBD.ToUpper, "BLOB", CompareMethod.Text) <> 0 Or _
                               InStr(objBase.TipoBD.ToUpper, "BINARY", CompareMethod.Text) <> 0 Then
                                Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = Nothing" & vbNewLine)
                            Else
                                Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = """"" & vbNewLine)
                            End If
                    End Select
                End If
            Next
            Clase.Append(MTab(2) & "Cantidad_de_la_Clase = 0" & vbNewLine & _
                         MTab(1) & "End Sub" & vbNewLine & vbNewLine)

            strTEMPO = ""
            If Tiene_LLave = True Then
                Clase.Append(MTab(1) & "Private Sub INIT_LLAVE()" & vbNewLine)
                For Each objBase In Me
                    If objBase.EsPK = True Then
                        strTEMPO = "XX"  'Solo para que tenga algun valor
                        Select Case UCase(objBase.Tipo)
                            Case "DECIMAL", "INTEGER", "SHORT", "LONG"
                                Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = 0" & vbNewLine)
                            Case "BOOLEAN"
                                Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = false" & vbNewLine)
                            Case "DATETIME", "MYSQLDATETIME"
                                Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)" & vbNewLine)
                            Case "TIMESPAN"
                                Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = New TimeSpan(0, 0, 0)" & vbNewLine)
                            Case Else
                                If InStr(objBase.TipoBD.ToUpper, "BLOB", CompareMethod.Text) <> 0 Or _
                                   InStr(objBase.TipoBD.ToUpper, "BINARY", CompareMethod.Text) <> 0 Then
                                    Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = Nothing" & vbNewLine)
                                Else
                                    Clase.Append(MTab(2) & objBase.Propiedad.ToUpper & " = """"" & vbNewLine)
                                End If
                        End Select
                    End If
                Next
                Clase.Append(MTab(1) & "End Sub" & vbNewLine & vbNewLine)
            End If

            ''Creo función que verifica la conexion de la transaccion o de la conecion a la base de datos
            'Clase.AppendLine("Private Function Verifica_Conexion(Operacion As Definicion.Tipo_de_Funcion) As Boolean")
            'Clase.AppendLine(mTab & "Dim Status As Tipo_Status_Ping" & vbNewLine)
            'Clase.AppendLine(mTab & "Verifica_Conexion = False" & vbNewLine)
            'Clase.Append(mTab & "If _Usar_Transaccion_Select Then" & vbNewLine & _
            '             mTab & mTab & "If IsNothing(TRA) = True Then Throw New System.Exception(""Se quiere usar Transacción sin tenerla Definida."")" & vbNewLine & _
            '             mTab & mTab & "If Tra.Connection.Ping = False then Throw New System.Exception(""Conexión de la Transacción Caida."")" & vbNewLine & _
            '             mTab & "Else" & vbNewLine & _
            '             mTab & mTab & "If Operacion = Definicion.Tipo_de_Funcion.Lectura Then" & vbNewLine & _
            '             mTab & mTab & mTab & "If IsNothing(REA) = False Then" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "REA.CLOSE()" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "REA = Nothing" & vbNewLine & _
            '             mTab & mTab & mTab & "End If" & vbNewLine & _
            '             mTab & mTab & "End If" & vbNewLine & _
            '             mTab & mTab & "If IsNothing(CON) = True Then" & vbNewLine & _
            '             mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - Verifica_Conexion Conexión no definida""" & vbNewLine & _
            '             mTab & mTab & mTab & "Throw new System.Exception(""Sin Conexión definida."")" & vbNewLine & _
            '             mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '             mTab & mTab & "End If" & vbNewLine & _
            '             mTab & mTab & "If Con.State = ConnectionState.Open Or CON.State = ConnectionState.Executing Or _" & vbNewLine & _
            '             mTab & mTab & "   CON.State = ConnectionState.Fetching Or CON.State = ConnectionState.Connecting Then CON.Ping()" & vbNewLine & _
            '             mTab & mTab & "If CON.State = ConnectionState.Closed Or CON.State = ConnectionState.Broken Then" & vbNewLine & _
            '             mTab & mTab & mTab & "If CON.ConnectionString.Length <> 0 Then" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "Try" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "Status = Verifica_PING(CON.ConnectionString)" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "If Status <> Tipo_Status_Ping.OK Then" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - Verifica_Conexion No se logro hacer pineo a Servidor Error:"" & _" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & mTab & "          Status.ToString" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error. No se logro hacer pineo a Servidor"" & vbNewLine & _" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & mTab & "                           ""Conexión:"" & CON.ConnectionString & vbNewLine & ""Error:"" & Status.ToString)" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "End If" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "CON.Open()" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "Catch MYEX As MySqlException" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - Verifica_Conexion Error#="" & MYEX.Number & "" "" & MYEX.ToString" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL"", MYEX)" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "Catch EX As Exception" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - Verifica_Conexion Error="" & EX.ToString" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error no contemplado en Conexión a MySQL"", EX)" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "End Try" & vbNewLine & _
            '             mTab & mTab & mTab & "Else" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - Verifica_Conexion String de Conexión no definido""" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "Throw New System.Exception(""Conexión sin string de conexión definido."")" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '             mTab & mTab & mTab & "End If" & vbNewLine & _
            '             mTab & mTab & "End If" & vbNewLine & _
            '             mTab & "End If" & vbNewLine)
            'Clase.AppendLine(mTab & "Verifica_Conexion = True")
            'Clase.AppendLine("End Function" & vbNewLine)


            'Creo funcion que recupera valores del recordset hacia la clase
            Clase.AppendLine("Private Function Pone_Valores_Internos(REA_Local as MySqlDataReader) as Boolean")
            Clase.AppendLine(MTab(1) & "Pone_Valores_Internos = False")
            Clase.AppendLine(MTab(1) & "Try")


            For Each objBase In Me
                'Se hace la verificación si esta nulo y si no se asigna el valor
                Clase.Append(MTab(2) & "If REA_Local.IsDBNull(REA_Local.GetOrdinal(""" & objBase.Propiedad & """)) = False Then" & vbNewLine)
                Select Case UCase(objBase.Tipo)
                    Case "DECIMAL"
                        Clase.Append(MTab(3) & objBase.NombreCompleto.ToUpper & " = REA_Local.GetDecimal(""" & objBase.Propiedad & """)" & vbNewLine)
                    Case "INTEGER"
                        Clase.Append(MTab(3) & objBase.NombreCompleto.ToUpper & " = REA_Local.GetInt32(""" & objBase.Propiedad & """)" & vbNewLine)
                    Case "SHORT"
                        Clase.Append(MTab(3) & objBase.NombreCompleto.ToUpper & " = REA_Local.GetInt16(""" & objBase.Propiedad & """)" & vbNewLine)
                    Case "LONG"
                        Clase.Append(MTab(3) & objBase.NombreCompleto.ToUpper & " = REA_Local.GetInt64(""" & objBase.Propiedad & """)" & vbNewLine)
                    Case "BOOLEAN"
                        Clase.Append(MTab(3) & objBase.NombreCompleto.ToUpper & " = REA_Local.GetBoolean(""" & objBase.Propiedad & """)" & vbNewLine)
                    Case "DATETIME", "MYSQLDATETIME"
                        Clase.Append(MTab(3) & objBase.NombreCompleto.ToUpper & " = REA_Local.GetMySQLDateTime(""" & objBase.Propiedad & """)" & vbNewLine)
                        'Clase.Append(mTab & mTab & mTab & "If " & objBase.NombreCompleto.ToUpper & ".IsValidDateTime = False then " & objBase.NombreCompleto.ToUpper & " = New MySsqlDateTime(1900,1,1,0,0,0,0)")
                        Clase.Append(MTab(3) & "If " & objBase.NombreCompleto.ToUpper & ".IsValidDateTime = False then " & vbNewLine)
                        Clase.Append(MTab(4) & "if " & objBase.NombreCompleto.ToUpper & ".toString = ""0000-00-00 00:00:00"" Then " & vbNewLine)
                        Clase.Append(MTab(5) & objBase.NombreCompleto.ToUpper & " = New MySqlDateTime(1900,1,1,0,0,0,0)" & vbNewLine)
                        Clase.Append(MTab(4) & "End If" & vbNewLine)
                        Clase.Append(MTab(3) & "End if" & vbNewLine)
                    Case "TIMESPAN"
                        Clase.Append(MTab(3) & objBase.NombreCompleto.ToUpper & " = REA_Local.GetTimeSpan(""" & objBase.Propiedad & """)" & vbNewLine)
                    Case Else
                        If InStr(objBase.TipoBD.ToUpper, "BLOB", CompareMethod.Text) <> 0 Or _
                        InStr(objBase.TipoBD.ToUpper, "BINARY", CompareMethod.Text) <> 0 Then
                            'Es binario y se tiene que manejar de manera correcta.
                            Clase.Append(MTab(3) & "Dim LTam As Long" & vbNewLine & _
                                         MTab(3) & "LTam = REA_Local.GetBytes(REA_Local.GetOrdinal(""" & objBase.Propiedad & """), 0, Nothing, 0, 0)" & vbNewLine & _
                                         MTab(3) & "Dim VecByte(CInt(LTam)) As Byte" & vbNewLine & _
                                         MTab(3) & "LTam = REA_Local.GetBytes(REA_Local.GetOrdinal(""" & objBase.Propiedad & """), 0, VecByte, 0, CInt(LTam))" & vbNewLine & _
                                         MTab(3) & objBase.NombreCompleto.ToUpper & " =  VecByte" & vbNewLine)
                        Else
                            'Se maneja como string
                            Clase.Append(MTab(4) & objBase.NombreCompleto.ToUpper & " = REA_Local.GetString(""" & objBase.Propiedad & """)" & vbNewLine)
                        End If
                End Select
                Select Case objBase.Tipo.ToUpper
                    Case "INTEGER", "SHORT", "LONG"
                        Clase.Append(MTab(2) & "Else" & vbNewLine & _
                                     MTab(3) & objBase.NombreCompleto.ToUpper & " = -1" & vbNewLine)
                    Case "STRING"
                        Clase.Append(MTab(2) & "Else" & vbNewLine & _
                                     MTab(3) & objBase.NombreCompleto.ToUpper & " = ""NULL""" & vbNewLine)
                End Select
                Clase.Append(MTab(2) & "End If" & vbNewLine)
            Next
            Clase.AppendLine(MTab(2) & "Pone_Valores_Internos = True")
            Clase.AppendLine(MTab(1) & "Catch EX as Exception")
            Clase.AppendLine(MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - Pone_Valores_Internos Error="" & EX.ToString")
            Clase.AppendLine(MTab(2) & "Throw New System.Exception(""Error No Contemplado"",ex)")
            Clase.AppendLine(MTab(1) & "End Try")
            Clase.AppendLine("End Function" & vbNewLine)

            'AGREGA LA LECTURA DE LOS OBJETOS INDIVIDUALES
            Clase.Append("Public Function PMOVE_NEXT() As Boolean" & vbNewLine & _
                            MTab(1) & "PMOVE_NEXT = False" & vbNewLine & _
                            MTab(1) & "MENSAJE = """"" & vbNewLine & _
                            MTab(1) & "INIT()" & vbNewLine)
            If Tiene_LLave = True Then Clase.Append(MTab(1) & "INIT_LLAVE()" & vbNewLine)
            Clase.Append(MTab(1) & "If IsNothing(REA) = True Then" & vbNewLine & _
                         MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PMOVE_NEXT Conexión no definida""" & vbNewLine & _
                         MTab(2) & "Throw New System.Exception(""Para ejecutar el PMOVE_NEXT, antes tiene que ejecutar PSELECT_RECORDSET"")" & vbNewLine & _
                         MTab(2) & "Exit Function" & vbNewLine & _
                         MTab(1) & "End If" & vbNewLine & _
                         MTab(1) & "Try" & vbNewLine & _
                         MTab(2) & "If REA.Read = False Then" & vbNewLine & _
                         MTab(3) & "REA.Close()" & vbNewLine & _
                         MTab(3) & "Rea = Nothing" & vbNewLine & _
                         MTab(3) & "Exit Function" & vbNewLine & _
                         MTab(2) & "End If" & vbNewLine & vbNewLine)
            'For Each objBase In Me
            '    'Se hace la verificación si esta nulo y si no se asigna el valor
            '    Clase.Append(mTab & mTab & "If REA.IsDBNull(REA.GetOrdinal(""" & objBase.Propiedad & """)) = False Then" & vbNewLine)
            '    Select Case UCase(objBase.Tipo)
            '        Case "DECIMAL"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = REA.GetDecimal(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case "INTEGER"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = REA.GetInt32(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case "SHORT"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = REA.GetInt16(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case "LONG"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = REA.GetInt64(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case "BOOLEAN"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = REA.GetBoolean(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case "DATETIME", "MYSQLDATETIME"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = REA.GetMySQLDateTime(""" & objBase.Propiedad & """)" & vbNewLine)
            '            'Clase.Append(mTab & mTab & mTab & "If " & objBase.NombreCompleto.ToUpper & ".IsValidDateTime = False then " & objBase.NombreCompleto.ToUpper & " = New MySsqlDateTime(1900,1,1,0,0,0,0)")
            '            Clase.Append(mTab & mTab & mTab & "If " & objBase.NombreCompleto.ToUpper & ".IsValidDateTime = False then " & vbNewLine)
            '            Clase.Append(mTab & mTab & mTab & mTab & "if " & objBase.NombreCompleto.ToUpper & ".toString = ""0000-00-00 00:00:00"" Then " & vbNewLine)
            '            Clase.Append(mTab & mTab & mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = New MySqlDateTime(1900,1,1,0,0,0,0)" & vbNewLine)
            '            Clase.Append(mTab & mTab & mTab & mTab & "End If" & vbNewLine)
            '            Clase.Append(mTab & mTab & mTab & "End if" & vbNewLine)
            '        Case "TIMESPAN"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = REA.GetTimeSpan(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case Else
            '            If InStr(objBase.TipoBD.ToUpper, "BLOB", CompareMethod.Text) <> 0 Or _
            '            InStr(objBase.TipoBD.ToUpper, "BINARY", CompareMethod.Text) <> 0 Then
            '                'Es binario y se tiene que manejar de manera correcta.
            '                Clase.Append(mTab & mTab & mTab & "Dim LTam As Long" & vbNewLine & _
            '                             mTab & mTab & mTab & "LTam = REA.GetBytes(REA.GetOrdinal(""" & objBase.Propiedad & """), 0, Nothing, 0, 0)" & vbNewLine & _
            '                             mTab & mTab & mTab & "Dim VecByte(CInt(LTam)) As Byte" & vbNewLine & _
            '                             mTab & mTab & mTab & "LTam = REA.GetBytes(REA.GetOrdinal(""" & objBase.Propiedad & """), 0, VecByte, 0, CInt(LTam))" & vbNewLine & _
            '                             mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " =  VecByte" & vbNewLine)
            '            Else
            '                'Se maneja como string
            '                Clase.Append(mTab & mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = REA.GetString(""" & objBase.Propiedad & """)" & vbNewLine)
            '            End If
            '    End Select
            '    Select Case objBase.Tipo.ToUpper
            '        Case "INTEGER", "SHORT", "LONG"
            '            Clase.Append(mTab & mTab & "Else" & vbNewLine & _
            '                         mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = -1" & vbNewLine)
            '        Case "STRING"
            '            Clase.Append(mTab & mTab & "Else" & vbNewLine & _
            '                         mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = ""NULL""" & vbNewLine)
            '    End Select
            '    Clase.Append(mTab & mTab & "End If" & vbNewLine)
            'Next
            Clase.AppendLine(MTab(2) & "PMOVE_NEXT = Pone_Valores_Internos(REA)" & vbNewLine)
            Clase.Append(MTab(1) & "Catch MYEX As MySqlException" & vbNewLine & _
                         MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PMOVE_NEXT Error="" & MYEX.ToString" & vbNewLine & _
                         MTab(2) & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL"", MYEX)" & vbNewLine & _
                         MTab(1) & "Catch EX As Exception" & vbNewLine & _
                         MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PMOVE_NEXT Error="" & EX.ToString" & vbNewLine & _
                         MTab(2) & "Throw New System.Exception(""Error No Contemplado"", Ex)" & vbNewLine & _
                         MTab(1) & "End Try" & vbNewLine & _
                         "End Function" & vbNewLine & vbNewLine)



            'Funcion PSELECT_RECORDSET
            'Clase.Append("Public Function PSELECT_RECORDSET(Optional ByVal CONDICION As String = """", Optional ByVal ORDENAMIENTO As String = """", Optional ByVal Solo_Contar As Boolean = False) As Boolean" & vbNewLine & _
            '             mTab & "Dim COM As MySqlCommand" & vbNewLine & _
            '             mTab & "Dim SQL As String" & vbNewLine & _
            '             mTab & "DIM SQL1 as String" & vbNewLine & _
            '             mTab & "Dim Status As Tipo_Status_Ping" & vbNewLine & vbNewLine & _
            '             mTab & "PSELECT_RECORDSET = False" & vbNewLine & _
            '             mTab & "MENSAJE = """"" & vbNewLine & _
            '             mTab & "If _Usar_Transaccion_Select Then" & vbNewLine & _
            '             mTab & mTab & "If IsNothing(TRA) = True Then Throw New System.Exception(""Se quiere usar Transacción sin tenerla Definida."")" & vbNewLine & _
            '             mTab & mTab & "If Tra.Connection.Ping = False then Throw New System.Exception(""Conexión de la Transacción Caida."")" & vbNewLine & _
            '             mTab & "Else" & vbNewLine & _
            '             mTab & mTab & "If IsNothing(REA) = False Then" & vbNewLine & _
            '             mTab & mTab & mTab & "REA.CLOSE()" & vbNewLine & _
            '             mTab & mTab & mTab & "REA = Nothing" & vbNewLine & _
            '             mTab & mTab & "End If" & vbNewLine & _
            '             mTab & mTab & "If IsNothing(CON) = True Then" & vbNewLine & _
            '             mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_RECORDSET Conexión no definida""" & vbNewLine & _
            '             mTab & mTab & mTab & "Throw new System.Exception(""Sin Conexión definida."")" & vbNewLine & _
            '             mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '             mTab & mTab & "End If" & vbNewLine & _
            '             mTab & mTab & "If Con.State = ConnectionState.Open Or CON.State = ConnectionState.Executing Or _" & vbNewLine & _
            '             mTab & mTab & "   CON.State = ConnectionState.Fetching Or CON.State = ConnectionState.Connecting Then CON.Ping()" & vbNewLine & _
            '             mTab & mTab & "If CON.State = ConnectionState.Closed Or CON.State = ConnectionState.Broken Then" & vbNewLine & _
            '             mTab & mTab & mTab & "If CON.ConnectionString.Length <> 0 Then" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "Try" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "Status = Verifica_PING(CON.ConnectionString)" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "If Status <> Tipo_Status_Ping.OK Then" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_RECORDSET No se logro hacer pineo a Servidor Error:"" & _" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & mTab & "          Status.ToString" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error. No se logro hacer pineo a Servidor"" & vbNewLine & _" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & mTab & "                           ""Conexión:"" & CON.ConnectionString & vbNewLine & ""Error:"" & Status.ToString)" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "End If" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "CON.Open()" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "Catch MYEX As MySqlException" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_RECORDSET Error#="" & MYEX.Number & "" "" & MYEX.ToString" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL"", MYEX)" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "Catch EX As Exception" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_RECORDSET Error="" & EX.ToString" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error no contemplado en Conexión a MySQL"", EX)" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "End Try" & vbNewLine & _
            '             mTab & mTab & mTab & "Else" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_RECORDSET String de Conexión no definido""" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "Throw New System.Exception(""Conexión sin string de conexión definido."")" & vbNewLine & _
            '             mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '             mTab & mTab & mTab & "End If" & vbNewLine & _
            '             mTab & mTab & "End If" & vbNewLine & _
            '             mTab & "End If" & vbNewLine & _
            '             mTab & "COM = NOTHING" & vbNewLine & _
            '             mTab & "Sql = ""Select * from " & frm.lvTABLAS.SelectedItems(0).Text & """" & vbNewLine & _
            '             mTab & "If CONDICION.Length <> 0 Then" & vbNewLine & _
            '             mTab & mTab & "Sql &= "" Where "" & CONDICION" & vbNewLine & _
            '             mTab & "End If" & vbNewLine & _
            '             mTab & "If ORDENAMIENTO.Length <> 0 Then" & vbNewLine & _
            '             mTab & mTab & "Sql &= "" Order By "" & ORDENAMIENTO" & vbNewLine & _
            '             mTab & "End If" & vbNewLine & _
            '             mTab & "SQL1 = ""Select Count(*) as Cuenta from " & frm.lvTABLAS.SelectedItems(0).Text & """" & vbNewLine & _
            '             mTab & "If CONDICION.Length <> 0 Then" & vbNewLine & _
            '             mTab & mTab & "Sql1 &= "" Where "" & CONDICION" & vbNewLine & _
            '             mTab & "End If" & vbNewLine & _
            '             mTab & "Try" & vbNewLine & _
            '             mTab & mTab & "INIT()" & vbNewLine)

            Clase.Append("Public Function PSELECT_RECORDSET(Optional ByVal CONDICION As String = """", Optional ByVal ORDENAMIENTO As String = """", Optional ByVal Solo_Contar As Boolean = False) As Boolean" & vbNewLine & _
                         MTab(1) & "Dim COM As MySqlCommand" & vbNewLine & _
                         MTab(1) & "Dim SQL As String" & vbNewLine & _
                         MTab(1) & "DIM SQL1 as String" & vbNewLine & vbNewLine & _
                         MTab(1) & "PSELECT_RECORDSET = False" & vbNewLine & _
                         MTab(1) & "MENSAJE = """"" & vbNewLine & vbNewLine & _
                         MTab(1) & "Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, REA, Definicion.Tipo_de_Funcion.Lectura)" & vbNewLine & vbNewLine & _
                         MTab(1) & "COM = NOTHING" & vbNewLine & _
                         MTab(1) & "Sql = ""Select * from " & frm.lvTABLAS.SelectedItems(0).Text & """" & vbNewLine & _
                         MTab(1) & "If CONDICION.Length <> 0 Then" & vbNewLine & _
                         MTab(2) & "Sql &= "" Where "" & CONDICION" & vbNewLine & _
                         MTab(1) & "End If" & vbNewLine & _
                         MTab(1) & "If ORDENAMIENTO.Length <> 0 Then" & vbNewLine & _
                         MTab(2) & "Sql &= "" Order By "" & ORDENAMIENTO" & vbNewLine & _
                         MTab(1) & "End If" & vbNewLine & _
                         MTab(1) & "SQL1 = ""Select Count(*) as Cuenta from " & frm.lvTABLAS.SelectedItems(0).Text & """" & vbNewLine & _
                         MTab(1) & "If CONDICION.Length <> 0 Then" & vbNewLine & _
                         MTab(2) & "Sql1 &= "" Where "" & CONDICION" & vbNewLine & _
                         MTab(1) & "End If" & vbNewLine & _
                         MTab(1) & "Try" & vbNewLine & _
                         MTab(2) & "INIT()" & vbNewLine)



            If Tiene_LLave = True Then Clase.Append(MTab(2) & "INIT_LLAVE()" & vbNewLine)
            Clase.Append(MTab(2) & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                         MTab(3) & "COM = New MySqlCommand(SQL1, TRA.Connection)" & vbNewLine & _
                         MTab(3) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                         MTab(3) & "COM.CommandTimeout = _TimeOut" & vbNewLine & _
                         MTab(3) & "Cantidad_de_la_Clase = CInt(COM.ExecuteScalar())" & vbNewLine & _
                         MTab(3) & "COM.Dispose()" & vbNewLine & _
                         MTab(3) & "COM = Nothing" & vbNewLine & vbNewLine & _
                         MTab(3) & "If Not Solo_Contar Then" & vbNewLine & _
                         MTab(4) & "COM = New MySqlCommand(SQL, TRA.Connection)" & vbNewLine & _
                         MTab(4) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                         MTab(4) & "COM.CommandTimeout = _TimeOut" & vbNewLine & _
                         MTab(4) & "REA = COM.ExecuteReader" & vbNewLine & _
                         MTab(3) & "End If" & vbNewLine & _
                         MTab(2) & "Else" & vbNewLine & _
                         MTab(3) & "COM = New MySqlCommand(SQL1,CON)" & vbNewLine & _
                         MTab(3) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                         MTab(3) & "COM.CommandTimeout = _TimeOut" & vbNewLine & _
                         MTab(3) & "Cantidad_de_la_Clase = CInt(COM.ExecuteScalar())" & vbNewLine & _
                         MTab(3) & "COM.Dispose()" & vbNewLine & _
                         MTab(3) & "COM = Nothing" & vbNewLine & vbNewLine & _
                         MTab(3) & "If Not Solo_Contar Then" & vbNewLine & _
                         MTab(4) & "COM = New MySqlCommand(Sql, CON)" & vbNewLine & _
                         MTab(4) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                         MTab(4) & "COM.CommandTimeout = _TimeOut" & vbNewLine & _
                         MTab(4) & "REA = COM.ExecuteReader" & vbNewLine & _
                         MTab(3) & "End If" & vbNewLine & _
                         MTab(2) & "End If" & vbNewLine & _
                         MTab(2) & "If Cantidad_de_la_Clase = 0 Then  'No hay data que procesar, asi que puedo terminar" & vbNewLine & _
                         MTab(3) & "PSELECT_RECORDSET = False" & vbNewLine & _
                         MTab(2) & "Else" & vbNewLine & _
                         MTab(3) & "PSELECT_RECORDSET = True" & vbNewLine & _
                         MTab(2) & "End If" & vbNewLine & _
                         MTab(1) & "Catch MYEX As MySqlException" & vbNewLine & _
                         MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_RECORDSET MyError#="" & MYEX.Number & "" MyError="" & MYEX.ToString" & vbNewLine & _
                         MTab(2) & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL Condición:"" & CONDICION & vbNewLine & ""Ordenamiento:"" & ORDENAMIENTO, MYEX)" & vbNewLine & _
                         MTab(1) & "Catch EX As Exception" & vbNewLine & _
                         MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_RECORDSET Error="" & EX.ToString" & vbNewLine & _
                         MTab(2) & "Throw New System.Exception(""Error no contemplado Condición:"" & CONDICION & vbNewLine & ""Ordenamiento:"" & ORDENAMIENTO, EX)" & vbNewLine & _
                         MTab(1) & "Finally" & vbNewLine & _
                         MTab(2) & "If IsNothing(COM) = False Then" & vbNewLine & _
                         MTab(3) & "COM.Dispose()" & vbNewLine & _
                         MTab(3) & "COM = Nothing" & vbNewLine & _
                         MTab(2) & "End If" & vbNewLine & _
                         MTab(1) & "End Try" & vbNewLine & _
                         "End Function" & vbNewLine & vbNewLine)

            'PSelect
            If Tiene_LLave = True Then
                CUENTA1 = 0 'La ocupo para sabe si tengo que poner coma al final de la definicion del campo
                For Each objBase In Me
                    If objBase.EsPK = True Then CUENTA1 += 1
                Next
                Clase.Append("Public Function PSELECT(")
                CUENTA = 0
                For Each objBase In Me
                    If objBase.EsPK = True Then 'Quiero solo los campos llaves
                        CUENTA = CUENTA + 1
                        Clase.Append("ByVal K" & objBase.CampoBD.ToUpper & " as ")
                        Select Case UCase(objBase.Tipo)
                            Case "DECIMAL"
                                Clase.Append("Double")
                            Case "INTEGER"
                                Clase.Append("Integer")
                            Case "SHORT"
                                Clase.Append("Short")
                            Case "LONG"
                                Clase.Append("LONG")
                            Case "BOOLEAN"
                                Clase.Append("Boolean")
                            Case "DATETIME", "MYSQLDATETIME"
                                Clase.Append("MySQLDatetime")
                            Case "TIMESPAN"
                                Clase.Append("TimeSpan")
                            Case Else 'String o cualquier otro
                                Clase.Append("String")
                        End Select
                        If CUENTA <> CUENTA1 Then Clase.Append(", ")
                    End If
                Next
                'Clase.Append(") AS Boolean" & vbNewLine & _
                '                mTab & "Dim READER As MySqlDataReader" & vbNewLine & _
                '                mTab & "Dim COM As MySqlCommand" & vbNewLine & _
                '                mTab & "Dim SQL as String" & vbNewLine & _
                '                mTab & "Dim Status as Tipo_Status_Ping" & vbNewLine & vbNewLine & _
                '                mTab & "Mensaje " & " = """"" & vbNewLine & _
                '                mTab & "PSELECT = False" & vbNewLine & _
                '                mTab & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                '                mTab & mTab & "If IsNothing(TRA) = True Then Throw New System.Exception(""Se quiere usar Transacción sin tenerla Definida."")" & vbNewLine & _
                '                mTab & mTab & "If Tra.Connection.Ping = False then Throw New System.Exception(""Conexión de la Transacción Caida."")" & vbNewLine & _
                '                mTab & "Else" & vbNewLine & _
                '                mTab & mTab & "If IsNothing(REA) = False Then" & vbNewLine & _
                '                mTab & mTab & mTab & "REA.CLOSE()" & vbNewLine & _
                '                mTab & mTab & mTab & "REA = Nothing" & vbNewLine & _
                '                mTab & mTab & "End If" & vbNewLine & _
                '                mTab & mTab & "If IsNothing(CON) = True Then" & vbNewLine & _
                '                mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT Conexión no definida""" & vbNewLine & _
                '                mTab & mTab & mTab & "Throw new System.Exception(""Sin Conexión definida."")" & vbNewLine & _
                '                mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '                mTab & mTab & "End If" & vbNewLine & _
                '                mTab & mTab & "If Con.State = ConnectionState.Open Or CON.State = ConnectionState.Executing Or _" & vbNewLine & _
                '                mTab & mTab & "   CON.State = ConnectionState.Fetching Or CON.State = ConnectionState.Connecting Then CON.Ping()" & vbNewLine & _
                '                mTab & mTab & "If CON.State = ConnectionState.Closed Or CON.State = ConnectionState.Broken Then" & vbNewLine & _
                '                mTab & mTab & mTab & "If CON.ConnectionString.Length <> 0 Then" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & "Try" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & "Status = Verifica_PING(CON.ConnectionString)" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & "If Status <> Tipo_Status_Ping.OK Then" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT No se logro hacer pineo a Servidor Error:"" & _" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & mTab & "          Status.ToString" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error. No se logro hacer pineo a Servidor"" & vbNewLine & _" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & mTab & "                           ""Conexión:"" & CON.ConnectionString & vbNewLine & ""Error:"" & Status.ToString)" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & "End If" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & "CON.Open()" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & "Catch MYEX As MySqlException" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT Error#="" & MYEX.Number & "" "" & MYEX.ToString" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL"", MYEX)" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & "Catch EX As Exception" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT Error="" & EX.ToString" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error no contemplado en Conexión a MySQL"", EX)" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & "End Try" & vbNewLine & _
                '                mTab & mTab & mTab & "Else" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT String de Conexión no definido""" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & "Throw New System.Exception(""Conexión sin string de conexión definido."")" & vbNewLine & _
                '                mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '                mTab & mTab & mTab & "End If" & vbNewLine & _
                '                mTab & mTab & "End If" & vbNewLine & _
                '                mTab & "End If" & vbNewLine & vbNewLine & _
                '                mTab & "SQL = ""SELECT * FROM " & frm.lvTABLAS.SelectedItems(0).Text & " WHERE ")

                Clase.Append(") AS Boolean" & vbNewLine & _
                                MTab(1) & "Dim READER As MySqlDataReader" & vbNewLine & _
                                MTab(1) & "Dim COM As MySqlCommand" & vbNewLine & _
                                MTab(1) & "Dim SQL as String" & vbNewLine & vbNewLine & _
                                MTab(1) & "Mensaje " & " = """"" & vbNewLine & _
                                MTab(1) & "PSELECT = False" & vbNewLine & vbNewLine & _
                                MTab(1) & "Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, REA, Definicion.Tipo_de_Funcion.Lectura)" & vbNewLine & vbNewLine & _
                                MTab(1) & "SQL = ""SELECT * FROM " & frm.lvTABLAS.SelectedItems(0).Text & " WHERE ")

                strTEMPO = ""
                CUENTA = 0
                For Each objBase In Me
                    If objBase.EsPK Then
                        CUENTA += 1
                        If CUENTA = 1 Then
                            Clase.Append(objBase.CampoBD.ToUpper & " = ?P" & CUENTA.ToString)
                        Else
                            Clase.Append(" AND " & objBase.CampoBD.ToUpper & " = ?P" & CUENTA.ToString)
                        End If
                        If UCase(objBase.Tipo) = "MYSQLDATETIME" Then
                            strTEMPO &= MTab(2) & "If K" & objBase.CampoBD.ToUpper & ".IsValidDateTime = True then" & vbNewLine & _
                                        MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,K" & objBase.CampoBD.ToUpper & ".value)" & vbNewLine & _
                                        MTab(2) & "Else" & vbNewLine & _
                                        MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,DBNull.Value)" & vbNewLine & _
                                        MTab(2) & "End If" & vbNewLine
                        Else
                            strTEMPO &= MTab(2) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,K" & objBase.CampoBD.ToUpper & ")" & vbNewLine
                        End If
                    End If
                Next
                Clase.Append("""" & vbNewLine & _
                             MTab(1) & "READER = NOTHING" & vbNewLine & _
                             MTab(1) & "COM = NOTHING" & vbNewLine & _
                             MTab(1) & "TRY" & vbNewLine & _
                             MTab(2) & "INIT()" & vbNewLine & _
                             MTab(2) & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                             MTab(3) & " COM = New MySqlCommand(SQL, TRA.Connection)" & vbNewLine & _
                             MTab(2) & "Else" & vbNewLine & _
                             MTab(3) & "COM = New MySqlCommand(SQL,CON)" & vbNewLine & _
                             MTab(2) & "End If" & vbNewLine & _
                             MTab(2) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                             MTab(2) & "COM.CommandTimeout = _TimeOut" & vbNewLine & _
                             strTEMPO & _
                             MTab(2) & "READER = COM.ExecuteReader(CommandBehavior.SingleRow)" & vbNewLine & _
                             MTab(2) & "READER.Read()" & vbNewLine & _
                             MTab(2) & "If READER.HasRows = False Then" & vbNewLine & _
                             MTab(3) & "MENSAJE = """"" & vbNewLine & _
                             MTab(3) & "PSELECT = False" & vbNewLine & _
                             MTab(3) & "Exit Function" & vbNewLine & _
                             MTab(2) & "End If" & vbNewLine & vbNewLine)
                'For Each objBase In Me
                '    'Se hace la verificación si esta nulo y si no se asigna el valor
                '    Clase.Append(mTab & mTab & "If READER.IsDBNull(READER.GetOrdinal(""" & objBase.Propiedad & """)) = False Then" & vbNewLine)
                '    Select Case UCase(objBase.Tipo)
                '        Case "DECIMAL"
                '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetDecimal(""" & objBase.Propiedad & """)" & vbNewLine)
                '        Case "INTEGER"
                '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetInt32(""" & objBase.Propiedad & """)" & vbNewLine)
                '        Case "SHORT"
                '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetInt16(""" & objBase.Propiedad & """)" & vbNewLine)
                '        Case "LONG"
                '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetInt64(""" & objBase.Propiedad & """)" & vbNewLine)
                '        Case "BOOLEAN"
                '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetBoolean(""" & objBase.Propiedad & """)" & vbNewLine)
                '        Case "DATETIME", "MYSQLDATETIME"
                '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetMySQLDateTime(""" & objBase.Propiedad & """)" & vbNewLine)
                '            Clase.Append(mTab & mTab & mTab & "If " & objBase.NombreCompleto.ToUpper & ".IsValidDateTime = False then " & vbNewLine)
                '            Clase.Append(mTab & mTab & mTab & mTab & "if " & objBase.NombreCompleto.ToUpper & ".toString = ""0000-00-00 00:00:00"" Then " & vbNewLine)
                '            Clase.Append(mTab & mTab & mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = New MySqlDateTime(1900,1,1,0,0,0,0)" & vbNewLine)
                '            Clase.Append(mTab & mTab & mTab & mTab & "End If" & vbNewLine)
                '            Clase.Append(mTab & mTab & mTab & "End if" & vbNewLine)
                '        Case "TIMESPAN"
                '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetTimeSpan(""" & objBase.Propiedad & """)" & vbNewLine)
                '        Case Else
                '            If InStr(objBase.TipoBD.ToUpper, "BLOB", CompareMethod.Text) <> 0 Or _
                '               InStr(objBase.TipoBD.ToUpper, "BINARY", CompareMethod.Text) <> 0 Then
                '                'Es binario y se tiene que manejar de manera correcta.
                '                Clase.Append(mTab & mTab & mTab & "Dim LTam As Long" & vbNewLine & _
                '                             mTab & mTab & mTab & "LTam = READER.GetBytes(READER.GetOrdinal(""" & objBase.Propiedad & """), 0, Nothing, 0, 0)" & vbNewLine & _
                '                             mTab & mTab & mTab & "Dim VecByte(CInt(LTam)) As Byte" & vbNewLine & _
                '                             mTab & mTab & mTab & "LTam = READER.GetBytes(READER.GetOrdinal(""" & objBase.Propiedad & """), 0, VecByte, 0, CInt(LTam))" & vbNewLine & _
                '                             mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " =  VecByte" & vbNewLine)
                '            Else
                '                'Se maneja como string
                '                Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetString(""" & objBase.Propiedad & """)" & vbNewLine)
                '            End If
                '    End Select
                '    Select Case objBase.Tipo.ToUpper
                '        Case "INTEGER"
                '            Clase.Append(mTab & mTab & "Else" & vbNewLine & _
                '                         mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = -1" & vbNewLine)
                '        Case "STRING"
                '            Clase.Append(mTab & mTab & "Else" & vbNewLine & _
                '                         mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = ""NULL""" & vbNewLine)
                '    End Select
                '    Clase.Append(mTab & mTab & "End If" & vbNewLine)
                'Next

                Clase.AppendLine("PSELECT = Pone_Valores_Internos(READER)" & vbNewLine)

                'Clase.Append(mTab & mTab & vbNewLine & "PSELECT = TRUE" & vbNewLine & _
                Clase.Append(MTab(1) & "Catch MYEX As MySqlException" & vbNewLine & _
                             MTab(2) & "Dim tt as String = ""Llave:"" ")
                strTEMPO = ""
                CUENTA = 0
                For Each objBase In Me
                    If objBase.EsPK = True Then 'Quiero solo los campos llaves
                        CUENTA = CUENTA + 1
                        If CUENTA = 1 Then
                            strTEMPO &= " & K" & objBase.CampoBD.ToUpper
                            Select Case objBase.TipoBD.ToUpper
                                Case "MYSQLDATETIME", "DATE", "TIME"
                                    strTEMPO &= ".ToString"
                            End Select
                        Else
                            strTEMPO &= " & ""-"" & K" & objBase.CampoBD.ToUpper
                            Select Case objBase.TipoBD.ToUpper
                                Case "MYSQLDATETIME", "DATE", "TIME"
                                    strTEMPO &= ".ToString"
                            End Select
                        End If
                    End If
                Next
                Clase.Append(strTEMPO & vbNewLine & _
                             MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT MyError#="" & MYEX.Number & "" MyError="" & MYEX.ToString" & vbNewLine & _
                             MTab(2) & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL. "" & tt, MYEX)" & vbNewLine & _
                             MTab(1) & "Catch EX As Exception" & vbNewLine & _
                             MTab(2) & "Dim tt as String = ""Llave:""" & strTEMPO & vbNewLine & _
                             MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT Error="" & EX.ToString" & vbNewLine & _
                             MTab(2) & "Throw New System.Exception(""Error no Contemplado. "" & tt, EX)" & vbNewLine & _
                             MTab(1) & "Finally" & vbNewLine & _
                             MTab(2) & "If IsNothing(READER) = False Then" & vbNewLine & _
                             MTab(3) & "READER.Close()" & vbNewLine & _
                             MTab(3) & "READER = Nothing" & vbNewLine & _
                             MTab(2) & "End If" & vbNewLine & _
                             MTab(2) & "If IsNothing(COM) = False Then" & vbNewLine & _
                             MTab(3) & "COM.Dispose()" & vbNewLine & _
                             MTab(3) & "COM = Nothing" & vbNewLine & _
                             MTab(2) & "End If" & vbNewLine & _
                             MTab(1) & "End Try" & vbNewLine & _
                             "End Function" & vbNewLine & vbNewLine)
            End If


            'AGREGO PSELECT_CONDICION
            'Clase.Append("Public Function PSELECT_CONDICION(BYVAL CONDICION AS STRING) AS Boolean" & vbNewLine & _
            '                mTab & "Dim READER As MySqlDataReader" & vbNewLine & _
            '                mTab & "Dim COM As MySqlCommand" & vbNewLine & _
            '                mTab & "Dim SQL as String" & vbNewLine & _
            '                mTab & "Dim Status as Tipo_Status_Ping" & vbNewLine & vbNewLine & _
            '                mTab & "Mensaje " & " = """"" & vbNewLine & _
            '                mTab & "PSELECT_CONDICION = False" & vbNewLine & _
            '                mTab & "If _Usar_Transaccion_Select Then" & vbNewLine & _
            '                mTab & mTab & "If IsNothing(TRA) = True Then Throw New System.Exception(""Se quiere usar Transacción sin tenerla Definida."")" & vbNewLine & _
            '                mTab & mTab & "If Tra.Connection.Ping = False then Throw New System.Exception(""Conexión de la Transacción Caida."")" & vbNewLine & _
            '                mTab & "Else" & vbNewLine & _
            '                mTab & mTab & "If IsNothing(REA) = False Then" & vbNewLine & _
            '                mTab & mTab & mTab & "REA.CLOSE()" & vbNewLine & _
            '                mTab & mTab & mTab & "REA = Nothing" & vbNewLine & _
            '                mTab & mTab & "End If" & vbNewLine & _
            '                mTab & mTab & "If IsNothing(CON) = True Then" & vbNewLine & _
            '                mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_CONDICION Conexión no definida""" & vbNewLine & _
            '                mTab & mTab & mTab & "Throw new System.Exception(""Sin Conexión definida."")" & vbNewLine & _
            '                mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '                mTab & mTab & "End If" & vbNewLine & _
            '                mTab & mTab & "If Con.State = ConnectionState.Open Or CON.State = ConnectionState.Executing Or _" & vbNewLine & _
            '                mTab & mTab & "   CON.State = ConnectionState.Fetching Or CON.State = ConnectionState.Connecting Then CON.Ping()" & vbNewLine & _
            '                mTab & mTab & "If CON.State = ConnectionState.Closed Or CON.State = ConnectionState.Broken Then" & vbNewLine & _
            '                mTab & mTab & mTab & "If CON.ConnectionString.Length <> 0 Then" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Try" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "Status = Verifica_PING(CON.ConnectionString)" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "If Status <> Tipo_Status_Ping.OK Then" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_CONDICION No se logro hacer pineo a Servidor Error:"" & _" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & mTab & "          Status.ToString" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error. No se logro hacer pineo a Servidor"" & vbNewLine & _" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & mTab & "                           ""Conexión:"" & CON.ConnectionString & vbNewLine & ""Error:"" & Status.ToString)" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "End If" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "CON.Open()" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Catch MYEX As MySqlException" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_CONDICION Error#="" & MYEX.Number & "" "" & MYEX.ToString" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL"", MYEX)" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Catch EX As Exception" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_CONDICION Error="" & EX.ToString" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error no contemplado en Conexión a MySQL"", EX)" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "End Try" & vbNewLine & _
            '                mTab & mTab & mTab & "Else" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_CONDICION String de Conexión no definido""" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Throw New System.Exception(""Conexión sin string de conexión definido."")" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '                mTab & mTab & mTab & "End If" & vbNewLine & _
            '                mTab & mTab & "End If" & vbNewLine & _
            '                mTab & "End If" & vbNewLine & vbNewLine & _
            '                mTab & "SQL = ""SELECT * FROM " & frm.lvTABLAS.SelectedItems(0).Text & " WHERE " & _
            '                """" & " & CONDICION" & vbNewLine & _
            '                mTab & "READER = NOTHING" & vbNewLine & _
            '                mTab & "COM = NOTHING" & vbNewLine & _
            '                mTab & "TRY" & vbNewLine & _
            '                mTab & mTab & "INIT()" & vbNewLine)

            Clase.Append("Public Function PSELECT_CONDICION(BYVAL CONDICION AS STRING) AS Boolean" & vbNewLine & _
                            MTab(1) & "Dim READER As MySqlDataReader" & vbNewLine & _
                            MTab(1) & "Dim COM As MySqlCommand" & vbNewLine & _
                            MTab(1) & "Dim SQL as String" & vbNewLine & vbNewLine & _
                            MTab(1) & "Mensaje " & " = """"" & vbNewLine & _
                            MTab(1) & "PSELECT_CONDICION = False" & vbNewLine & vbNewLine & _
                            MTab(1) & "Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, REA, Definicion.Tipo_de_Funcion.Lectura)" & vbNewLine & vbNewLine & _
                            MTab(1) & "SQL = ""SELECT * FROM " & frm.lvTABLAS.SelectedItems(0).Text & " WHERE " & _
                            """" & " & CONDICION" & vbNewLine & _
                            MTab(1) & "READER = NOTHING" & vbNewLine & _
                            MTab(1) & "COM = NOTHING" & vbNewLine & _
                            MTab(1) & "TRY" & vbNewLine & _
                            MTab(2) & "INIT()" & vbNewLine)



            If Tiene_LLave Then Clase.Append(MTab(2) & "INIT_LLAVE()" & vbNewLine)
            Clase.Append(MTab(2) & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                            MTab(3) & "COM = New MySqlCommand(SQL, TRA.Connection)" & vbNewLine & _
                            MTab(2) & "Else" & vbNewLine & _
                            MTab(3) & "COM = New MySqlCommand(SQL,CON)" & vbNewLine & _
                            MTab(2) & "End If" & vbNewLine & _
                            MTab(2) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                            MTab(2) & "COM.CommandTimeout = _TimeOut" & vbNewLine & _
                            MTab(2) & "READER = COM.ExecuteReader(CommandBehavior.SingleRow)" & vbNewLine & _
                            MTab(2) & "READER.Read()" & vbNewLine & _
                            MTab(2) & "If READER.HasRows = False Then" & vbNewLine & _
                            MTab(3) & " MENSAJE = """"" & vbNewLine & _
                            MTab(3) & "PSELECT_CONDICION = False" & vbNewLine & _
                            MTab(3) & "Exit Function" & vbNewLine & _
                            MTab(2) & "End If" & vbNewLine & vbNewLine)
            'For Each objBase In Me
            '    'Se hace la verificación si esta nulo y si no se asigna el valor
            '    Clase.Append(mTab & mTab & "If READER.IsDBNull(READER.GetOrdinal(""" & objBase.Propiedad & """)) = False Then" & vbNewLine)
            '    Select Case UCase(objBase.Tipo)
            '        Case "DECIMAL"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetDecimal(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case "INTEGER"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetInt32(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case "SHORT"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetInt16(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case "LONG"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetInt64(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case "BOOLEAN"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetBoolean(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case "DATETIME", "MYSQLDATETIME"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetMySQLDateTime(""" & objBase.Propiedad & """)" & vbNewLine)
            '            Clase.Append(mTab & mTab & mTab & "If " & objBase.NombreCompleto.ToUpper & ".IsValidDateTime = False then " & vbNewLine)
            '            Clase.Append(mTab & mTab & mTab & mTab & "if " & objBase.NombreCompleto.ToUpper & ".toString = ""0000-00-00 00:00:00"" Then " & vbNewLine)
            '            Clase.Append(mTab & mTab & mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = New MySqlDateTime(1900,1,1,0,0,0,0)" & vbNewLine)
            '            Clase.Append(mTab & mTab & mTab & mTab & "End If" & vbNewLine)
            '            Clase.Append(mTab & mTab & mTab & "End if" & vbNewLine)
            '        Case "TIMESPAN"
            '            Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetTimeSpan(""" & objBase.Propiedad & """)" & vbNewLine)
            '        Case Else
            '            If InStr(objBase.TipoBD.ToUpper, "BLOB", CompareMethod.Text) <> 0 Or _
            '               InStr(objBase.TipoBD.ToUpper, "BINARY", CompareMethod.Text) <> 0 Then
            '                'Es binario y se tiene que manejar de manera correcta.
            '                Clase.Append(mTab & mTab & mTab & "Dim LTam As Long" & vbNewLine & _
            '                             mTab & mTab & mTab & "LTam = READER.GetBytes(READER.GetOrdinal(""" & objBase.Propiedad & """), 0, Nothing, 0, 0)" & vbNewLine & _
            '                             mTab & mTab & mTab & "Dim VecByte(CInt(LTam)) As Byte" & vbNewLine & _
            '                             mTab & mTab & mTab & "LTam = READER.GetBytes(READER.GetOrdinal(""" & objBase.Propiedad & """), 0, VecByte, 0, CInt(LTam))" & vbNewLine & _
            '                             mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " =  VecByte" & vbNewLine)
            '            Else
            '                'Se maneja como string
            '                Clase.Append(mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = READER.GetString(""" & objBase.Propiedad & """)" & vbNewLine)
            '            End If
            '    End Select
            '    Select Case objBase.Tipo.ToUpper
            '        Case "INTEGER"
            '            Clase.Append(mTab & mTab & "Else" & vbNewLine & _
            '                         mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = -1" & vbNewLine)
            '        Case "STRING"
            '            Clase.Append(mTab & mTab & "Else" & vbNewLine & _
            '                         mTab & mTab & mTab & objBase.NombreCompleto.ToUpper & " = ""NULL""" & vbNewLine)
            '    End Select
            '    Clase.Append(mTab & mTab & "End If" & vbNewLine)
            'Next

            Clase.AppendLine("PSELECT_CONDICION = Pone_Valores_Internos(READER)" & vbNewLine)

            'Clase.Append(vbNewLine & mTab & mTab & "PSELECT_CONDICION = TRUE" & vbNewLine & _
            Clase.Append(MTab(1) & "Catch MYEX As MySqlException" & vbNewLine & _
                            MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_CONDICION MyError#="" & MYEX.Number & "" MyError="" & MYEX.ToString" & vbNewLine & _
                            MTab(2) & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL. Condición:"" & CONDICION, MYEX)" & vbNewLine & _
                            MTab(1) & "Catch EX As Exception" & vbNewLine & _
                            MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_CONDICION Error="" & EX.ToString" & vbNewLine & _
                            MTab(2) & "Throw New System.Exception(""Error no contemplado. Condición:"" & CONDICION, EX)" & vbNewLine & _
                            MTab(1) & "Finally" & vbNewLine & _
                            MTab(2) & "If IsNothing(READER) = False Then" & vbNewLine & _
                            MTab(3) & "READER.Close()" & vbNewLine & _
                            MTab(3) & "READER = Nothing" & vbNewLine & _
                            MTab(2) & "End If" & vbNewLine & _
                            MTab(2) & "If IsNothing(COM) = False Then" & vbNewLine & _
                            MTab(3) & "COM.Dispose()" & vbNewLine & _
                            MTab(3) & "COM = Nothing" & vbNewLine & _
                            MTab(2) & "End If" & vbNewLine & _
                            MTab(1) & "End Try" & vbNewLine & _
                            "End Function" & vbNewLine & vbNewLine)

            'VOY A AGREGAR PSELECT_READER
            'Clase.Append("Public Function PSELECT_READER(ByRef READER As MySqlDataReader, _" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Optional ByVal CAMPOS As String = """", _" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Optional ByVal CONDICION As String = """", _" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Optional ByVal ORDENAMIENTO As String = """") AS Boolean" & vbNewLine & _
            '                mTab & "Dim COM As MySqlCommand" & vbNewLine & _
            '                mTab & "Dim SQL as String" & vbNewLine & _
            '                mTab & "Dim SQL1 as String" & vbNewLine & _
            '                mTab & "Dim Status as Tipo_Status_Ping" & vbNewLine & vbNewLine & _
            '                mTab & "Mensaje " & " = """"" & vbNewLine & _
            '                mTab & "PSELECT_READER = False" & vbNewLine & _
            '                mTab & "If _Usar_Transaccion_Select Then" & vbNewLine & _
            '                mTab & mTab & "If IsNothing(TRA) = True Then Throw New System.Exception(""Se quiere usar Transacción sin tenerla Definida."")" & vbNewLine & _
            '                mTab & mTab & "If Tra.Connection.Ping = False then Throw New System.Exception(""Conexión de la Transacción Caida."")" & vbNewLine & _
            '                mTab & "Else" & vbNewLine & _
            '                mTab & mTab & "If IsNothing(REA) = False Then" & vbNewLine & _
            '                mTab & mTab & mTab & "REA.CLOSE()" & vbNewLine & _
            '                mTab & mTab & mTab & "REA = Nothing" & vbNewLine & _
            '                mTab & mTab & "End If" & vbNewLine & _
            '                mTab & mTab & "If IsNothing(CON) = True Then" & vbNewLine & _
            '                mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_READER Conexión no definida""" & vbNewLine & _
            '                mTab & mTab & mTab & "Throw new System.Exception(""Sin Conexión definida."")" & vbNewLine & _
            '                mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '                mTab & mTab & "End If" & vbNewLine & _
            '                mTab & mTab & "If Con.State = ConnectionState.Open Or CON.State = ConnectionState.Executing Or _" & vbNewLine & _
            '                mTab & mTab & "   CON.State = ConnectionState.Fetching Or CON.State = ConnectionState.Connecting Then CON.Ping()" & vbNewLine & _
            '                mTab & mTab & "If CON.State = ConnectionState.Closed Or CON.State = ConnectionState.Broken Then" & vbNewLine & _
            '                mTab & mTab & mTab & "If CON.ConnectionString.Length <> 0 Then" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Try" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "Status = Verifica_PING(CON.ConnectionString)" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "If Status <> Tipo_Status_Ping.OK Then" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_READER No se logro hacer pineo a Servidor Error:"" & _" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & mTab & "          Status.ToString" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error. No se logro hacer pineo a Servidor"" & vbNewLine & _" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & mTab & "                           ""Conexión:"" & CON.ConnectionString & vbNewLine & ""Error:"" & Status.ToString)" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "End If" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "CON.Open()" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Catch MYEX As MySqlException" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_READER Error#="" & MYEX.Number & "" "" & MYEX.ToString" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL"", MYEX)" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Catch EX As Exception" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_READER Error="" & EX.ToString" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error no contemplado en Conexión a MySQL"", EX)" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "End Try" & vbNewLine & _
            '                mTab & mTab & mTab & "Else" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_READER String de Conexión no definido""" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Throw New System.Exception(""Conexión sin string de conexión definido."")" & vbNewLine & _
            '                mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
            '                mTab & mTab & mTab & "End If" & vbNewLine & _
            '                mTab & mTab & "End If" & vbNewLine & _
            '                mTab & "End If" & vbNewLine & vbNewLine & _
            '                mTab & "If CAMPOS.Length = 0 Then" & vbNewLine & _
            '                mTab & mTab & "Sql = ""Select * from " & frm.lvTABLAS.SelectedItems(0).Text & """" & vbNewLine & _
            '                mTab & "Else" & vbNewLine & _
            '                mTab & mTab & "Sql = ""SELECT "" & CAMPOS & "" FROM " & frm.lvTABLAS.SelectedItems(0).Text & """" & vbNewLine & _
            '                mTab & "End If" & vbNewLine & _
            '                mTab & "If CONDICION.Length <> 0 Then" & vbNewLine & _
            '                mTab & mTab & "Sql &= "" Where "" & CONDICION" & vbNewLine & _
            '                mTab & "End If" & vbNewLine & _
            '                mTab & "If ORDENAMIENTO.Length <> 0 Then" & vbNewLine & _
            '                mTab & mTab & "Sql &= "" Order By "" & ORDENAMIENTO" & vbNewLine & _
            '                mTab & "End If" & vbNewLine & vbNewLine & _
            '                mTab & mTab & "Sql1 = ""Select Count(*) as Cuenta from " & frm.lvTABLAS.SelectedItems(0).Text & """" & vbNewLine & _
            '                mTab & "If CONDICION.Length <> 0 Then" & vbNewLine & _
            '                mTab & mTab & "Sql1 &= "" Where "" & CONDICION" & vbNewLine & _
            '                mTab & "End If" & vbNewLine & vbNewLine & _
            '                mTab & "READER = NOTHING" & vbNewLine & _
            '                mTab & "COM = NOTHING" & vbNewLine & _
            '                mTab & "TRY" & vbNewLine & _
            '                mTab & mTab & "INIT()" & vbNewLine)

            Clase.Append("Public Function PSELECT_READER(ByRef READER As MySqlDataReader, _" & vbNewLine & _
                            MTab(4) & "Optional ByVal CAMPOS As String = """", _" & vbNewLine & _
                            MTab(4) & "Optional ByVal CONDICION As String = """", _" & vbNewLine & _
                            MTab(4) & "Optional ByVal ORDENAMIENTO As String = """") AS Boolean" & vbNewLine & _
                            MTab(1) & "Dim COM As MySqlCommand" & vbNewLine & _
                            MTab(1) & "Dim SQL as String" & vbNewLine & _
                            MTab(1) & "Dim SQL1 as String" & vbNewLine & vbNewLine & _
                            MTab(1) & "Mensaje " & " = """"" & vbNewLine & _
                            MTab(1) & "PSELECT_READER = False" & vbNewLine & vbNewLine & _
                            MTab(1) & "Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, REA, Definicion.Tipo_de_Funcion.Lectura)" & vbNewLine & vbNewLine & _
                            MTab(1) & "If CAMPOS.Length = 0 Then" & vbNewLine & _
                            MTab(2) & "Sql = ""Select * from " & frm.lvTABLAS.SelectedItems(0).Text & """" & vbNewLine & _
                            MTab(1) & "Else" & vbNewLine & _
                            MTab(2) & "Sql = ""SELECT "" & CAMPOS & "" FROM " & frm.lvTABLAS.SelectedItems(0).Text & """" & vbNewLine & _
                            MTab(1) & "End If" & vbNewLine & _
                            MTab(1) & "If CONDICION.Length <> 0 Then" & vbNewLine & _
                            MTab(2) & "Sql &= "" Where "" & CONDICION" & vbNewLine & _
                            MTab(1) & "End If" & vbNewLine & _
                            MTab(1) & "If ORDENAMIENTO.Length <> 0 Then" & vbNewLine & _
                            MTab(2) & "Sql &= "" Order By "" & ORDENAMIENTO" & vbNewLine & _
                            MTab(1) & "End If" & vbNewLine & vbNewLine & _
                            MTab(2) & "Sql1 = ""Select Count(*) as Cuenta from " & frm.lvTABLAS.SelectedItems(0).Text & """" & vbNewLine & _
                            MTab(1) & "If CONDICION.Length <> 0 Then" & vbNewLine & _
                            MTab(2) & "Sql1 &= "" Where "" & CONDICION" & vbNewLine & _
                            MTab(1) & "End If" & vbNewLine & vbNewLine & _
                            MTab(1) & "READER = NOTHING" & vbNewLine & _
                            MTab(1) & "COM = NOTHING" & vbNewLine & _
                            MTab(1) & "TRY" & vbNewLine & _
                            MTab(2) & "INIT()" & vbNewLine)


            If Tiene_LLave Then Clase.Append(MTab(2) & "INIT_LLAVE()" & vbNewLine)
            Clase.Append(MTab(2) & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                            MTab(3) & "COM = New MySqlCommand(SQL1, TRA.Connection)" & vbNewLine & _
                            MTab(2) & "Else" & vbNewLine & _
                            MTab(3) & "COM = New MySqlCommand(SQL1,CON)" & vbNewLine & _
                            MTab(2) & "End If" & vbNewLine & _
                            MTab(2) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                            MTab(2) & "COM.CommandTimeout = _TimeOut" & vbNewLine & _
                            MTab(2) & "Cantidad_de_la_Clase = CInt(COM.ExecuteScalar())" & vbNewLine & _
                            MTab(2) & "COM.Dispose()" & vbNewLine & _
                            MTab(2) & "COM = Nothing" & vbNewLine & vbNewLine & _
                            MTab(2) & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                            MTab(3) & "COM = New MySqlCommand(SQL, TRA.Connection)" & vbNewLine & _
                            MTab(2) & "Else" & vbNewLine & _
                            MTab(3) & "COM = New MySqlCommand(SQL,CON)" & vbNewLine & _
                            MTab(2) & "End If" & vbNewLine & _
                            MTab(2) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                            MTab(2) & "COM.CommandTimeout = _TimeOut" & vbNewLine & _
                            MTab(2) & "READER = COM.ExecuteReader()" & vbNewLine & _
                            MTab(2) & "PSELECT_READER = TRUE" & vbNewLine & _
                            MTab(1) & "Catch MYEX As MySqlException" & vbNewLine & _
                            MTab(2) & "Dim tt As String = vbNewLine & ""Campos:"" & CAMPOS & vbNewLine & _" & vbNewLine & _
                            MTab(3) & """Condición:"" & CONDICION & vbNewLine & _" & vbNewLine & _
                            MTab(3) & """Ordenamiento:"" & ORDENAMIENTO" & vbNewLine & _
                            MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_READER MyError#="" & MYEX.Number & "" MyError="" & MYEX.ToString" & vbNewLine & _
                            MTab(2) & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL. SQL1="" & SQL1 & vbNewLine & ""Sql="" & SQL & tt, MYEX)" & vbNewLine & _
                            MTab(1) & "Catch EX As Exception" & vbNewLine & _
                            MTab(2) & "Dim tt As String = vbNewLine & ""Campos:"" & CAMPOS & vbNewLine & _" & vbNewLine & _
                            MTab(4) & """Condición:"" & CONDICION & vbNewLine & _" & vbNewLine & _
                            MTab(4) & """Ordenamiento:"" & ORDENAMIENTO" & vbNewLine & _
                            MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PSELECT_READER Error="" & EX.ToString" & vbNewLine & _
                            MTab(2) & "Throw New System.Exception(""Error no contemplado."" & tt, EX)" & vbNewLine & _
                            MTab(1) & "Finally" & vbNewLine & _
                            MTab(2) & "If IsNothing(COM) = False Then" & vbNewLine & _
                            MTab(3) & "COM.Dispose()" & vbNewLine & _
                            MTab(3) & "COM = Nothing" & vbNewLine & _
                            MTab(2) & "End If" & vbNewLine & _
                            MTab(1) & "End Try" & vbNewLine & _
                            "End Function" & vbNewLine & vbNewLine)

            If Tiene_LLave = True Then
                'VOY A AGREGAR PINSERT
                'Clase.Append("Public Function PINSERT() AS Boolean" & vbNewLine & _
                '            mTab & "Dim COM As MySqlCommand" & vbNewLine & _
                '            mTab & "Dim SQL as String" & vbNewLine & _
                '            mTab & "Dim Status as Tipo_Status_Ping" & vbNewLine & vbNewLine & _
                '            mTab & "MENSAJE = """"" & vbNewLine & _
                '            mTab & "PINSERT = False" & vbNewLine & _
                '            mTab & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                '            mTab & mTab & "If IsNothing(TRA) = True Then Throw New System.Exception(""Se quiere usar Transacción sin tenerla Definida."")" & vbNewLine & _
                '            mTab & mTab & "If Tra.Connection.Ping = False then Throw New System.Exception(""Conexión de la Transacción Caida."")" & vbNewLine & _
                '            mTab & "Else" & vbNewLine & _
                '            mTab & mTab & "If IsNothing(CON) = True Then" & vbNewLine & _
                '            mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PINSERT Conexión no definida""" & vbNewLine & _
                '            mTab & mTab & mTab & "Throw new System.Exception(""Sin Conexión definida."")" & vbNewLine & _
                '            mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '            mTab & mTab & "End If" & vbNewLine & _
                '            mTab & mTab & "If Con.State = ConnectionState.Open Or CON.State = ConnectionState.Executing Or _" & vbNewLine & _
                '            mTab & mTab & "   CON.State = ConnectionState.Fetching Or CON.State = ConnectionState.Connecting Then CON.Ping()" & vbNewLine & _
                '            mTab & mTab & "If CON.State = ConnectionState.Closed Or CON.State = ConnectionState.Broken Then" & vbNewLine & _
                '            mTab & mTab & mTab & "If CON.ConnectionString.Length <> 0 Then" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & "Try" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & "Status = Verifica_PING(CON.ConnectionString)" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & "If Status <> Tipo_Status_Ping.OK Then" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PINSERT No se logro hacer pineo a Servidor Error:"" & _" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & mTab & "          Status.ToString" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error. No se logro hacer pineo a Servidor"" & vbNewLine & _" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & mTab & "                           ""Conexión:"" & CON.ConnectionString & vbNewLine & ""Error:"" & Status.ToString)" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & "End If" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & "CON.Open()" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & "Catch MYEX As MySqlException" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PINSERT Error#="" & MYEX.Number & "" "" & MYEX.ToString" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL"", MYEX)" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & "Catch EX As Exception" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PINSERT Error="" & EX.ToString" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error no contemplado en Conexión a MySQL"", EX)" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & "End Try" & vbNewLine & _
                '            mTab & mTab & mTab & "Else" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PINSERT String de Conexión no definido""" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & "Throw New System.Exception(""Conexión sin string de conexión definido."")" & vbNewLine & _
                '            mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '            mTab & mTab & mTab & "End If" & vbNewLine & _
                '            mTab & mTab & "End If" & vbNewLine & _
                '            mTab & "End If" & vbNewLine & vbNewLine & _
                '            mTab & "COM = Nothing" & vbNewLine & _
                '            mTab & "TRY" & vbNewLine & _
                '            mTab & mTab & "SQL = ""INSERT INTO " & frm.lvTABLAS.SelectedItems(0).Text & " (")

                Clase.Append("Public Function PINSERT() AS Boolean" & vbNewLine & _
                            MTab(1) & "Dim COM As MySqlCommand" & vbNewLine & _
                            MTab(1) & "Dim SQL as String" & vbNewLine & vbNewLine & _
                            MTab(1) & "MENSAJE = """"" & vbNewLine & _
                            MTab(1) & "PINSERT = False" & vbNewLine & vbNewLine & _
                            MTab(1) & "Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, REA, Definicion.Tipo_de_Funcion.Insert)" & vbNewLine & vbNewLine & _
                            MTab(1) & "COM = Nothing" & vbNewLine & _
                            MTab(1) & "TRY" & vbNewLine & _
                            MTab(2) & "SQL = ""INSERT INTO " & frm.lvTABLAS.SelectedItems(0).Text & " (")

                strTEMPO = ""
                CUENTA = 0
                For Each objBase In Me
                    Clase.Append(objBase.CampoBD & ",")
                Next
                Clase.Remove(Clase.Length - 1, 1) '<-----Falta por Verificar esta línea
                Clase.Append(") "" & _" & vbNewLine & MTab(3) & """VALUES(")
                For Each objBase In Me
                    'CUENTA += 1
                    Clase.Append("?P" & CUENTA.ToString & ",")
                Next
                Clase.Remove(Clase.Length - 1, 1) '<-----Falta por Verificar esta línea
                Clase.Append(")""" & vbNewLine & _
                             MTab(2) & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                             MTab(3) & "COM = New MySqlCommand(Sql, tra.Connection, TRA)" & vbNewLine & _
                             MTab(2) & "Else" & vbNewLine & _
                             MTab(3) & "COM = New MySqlCommand(Sql, CON)" & vbNewLine & _
                             MTab(2) & "End If" & vbNewLine & _
                             MTab(2) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                             MTab(2) & "COM.CommandTimeout = _TimeOut" & vbNewLine)
                CUENTA = 0
                For Each objBase In Me
                    CUENTA += 1
                    Select Case UCase(objBase.Tipo)
                        Case "MYSQLDATETIME"
                            'Tengo que verificar por Fecha o TimeStamp
                            If InStr(objBase.TipoBD.ToUpper, "TIMESTAMP", CompareMethod.Text) <> 0 Then
                                'Es tipo timestamp y siempre tiene que tener la fecha en NOW
                                Clase.Append(MTab(2) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,Now)" & vbNewLine)
                            Else
                                'Es fecha y verifico el valor a grabar.
                                Clase.Append(MTab(2) & "If " & objBase.NombreCompleto & ".IsValidDateTime = False then" & vbNewLine & _
                                             MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,DBNull.Value)" & vbNewLine & _
                                             MTab(2) & "Else" & vbNewLine & _
                                             MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ".value)" & vbNewLine & _
                                             MTab(2) & "End If" & vbNewLine)
                            End If
                        Case "INTEGER"
                            'Verifico por -1 que es el valor que asigne a nulo y que es lo que quiero grabar.
                            Clase.Append(MTab(2) & "If " & objBase.NombreCompleto & " = -1 then" & vbNewLine & _
                                         MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,DBNull.Value)" & vbNewLine & _
                                         MTab(2) & "Else" & vbNewLine & _
                                         MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ")" & vbNewLine & _
                                         MTab(2) & "End If" & vbNewLine)
                        Case "STRING"
                            Clase.Append(MTab(2) & "If " & objBase.NombreCompleto & ".ToUpper = ""NULL"" then" & vbNewLine & _
                                         MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,DBNull.Value)" & vbNewLine & _
                                         MTab(2) & "Else" & vbNewLine & _
                                         MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ")" & vbNewLine & _
                                         MTab(2) & "End If" & vbNewLine)
                        Case Else
                            Clase.Append(MTab(2) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ")" & vbNewLine)
                    End Select
                Next
                Clase.Append(MTab(2) & "COM.ExecuteNonQuery()" & vbNewLine)
                'Tengo que verificar si hay alguna columna con autoincrement y si el valor de la columna es cero(0) para recuperar el valor
                'Tengo que ver como se haria algo asi
                'select last_insert_id

                For Each objBase In Me
                    If objBase.Extra.ToUpper = "AUTO_INCREMENT" Then
                        'Si tiene autoincrement
                        'Verifico si el campo viene con 0 para recuperar el valor
                        Clase.Append(MTab(2) & "If " & objBase.NombreCompleto & " = 0 Then" & vbNewLine & _
                                     MTab(3) & "SQL = ""Select Last_Insert_ID()""" & vbNewLine & _
                                     MTab(3) & "If _Usar_Transaccion_Select then" & vbNewLine & _
                                     MTab(4) & "COM = New MySqlCommand(SQL,TRA.Connection, TRA)" & vbNewLine & _
                                     MTab(3) & "Else" & vbNewLine & _
                                     MTab(4) & "COM = New MySqlCommand(SQL, CON)" & vbNewLine & _
                                     MTab(3) & "End If" & vbNewLine & _
                                     MTab(3) & objBase.NombreCompleto & " = Cint(COM.ExecuteScalar())" & vbNewLine & _
                                     MTab(3) & "COM.Dispose()" & vbNewLine & _
                                     MTab(3) & "COM = Nothing" & vbNewLine & _
                                     MTab(2) & "End If" & vbNewLine)
                    End If
                Next
                Clase.Append(MTab(2) & "PINSERT = True" & vbNewLine & _
                             MTab(1) & "Catch MYEX As MySqlException" & vbNewLine & _
                             MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PINSERT MyError#="" & MYEX.Number & "" MyError="" & MYEX.ToString" & vbNewLine & _
                             MTab(2) & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL."", MYEX)" & vbNewLine & _
                             MTab(1) & "Catch ex As Exception" & vbNewLine & _
                             MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PINSERT Error="" & ex.ToString" & vbNewLine & _
                             MTab(2) & "Throw New System.Exception(""Error no contemplado."", ex)" & vbNewLine & _
                             MTab(1) & "Finally" & vbNewLine & _
                             MTab(2) & "If IsNothing(COM) = False Then" & vbNewLine & _
                             MTab(3) & "COM.Dispose()" & vbNewLine & _
                             MTab(3) & "COM = Nothing" & vbNewLine & _
                             MTab(2) & "End If" & vbNewLine & _
                             MTab(1) & "End Try" & vbNewLine & _
                             "End Function" & vbNewLine & vbNewLine)

                'VOY A AGREGAR PDELETE
                'Clase.Append("Public Function PDELETE(Optional ByVal Condicion as String = """") AS Boolean" & vbNewLine & _
                '             mTab & "Dim COM As MySqlCommand" & vbNewLine & _
                '             mTab & "Dim SQL as String = """"" & vbNewLine & _
                '             mTab & "Dim Status as Tipo_Status_Ping" & vbNewLine & vbNewLine & _
                '             mTab & "MENSAJE = """"" & vbNewLine & _
                '             mTab & "PDELETE = False" & vbNewLine & _
                '             mTab & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                '             mTab & mTab & "If IsNothing(TRA) = True Then Throw New System.Exception(""Se quiere usar Transacción sin tenerla Definida."")" & vbNewLine & _
                '             mTab & mTab & "If Tra.Connection.Ping = False then Throw New System.Exception(""Conexión de la Transacción Caida."")" & vbNewLine & _
                '             mTab & "Else" & vbNewLine & _
                '             mTab & mTab & "If IsNothing(CON) = True Then" & vbNewLine & _
                '             mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PDELETE Conexión no definida""" & vbNewLine & _
                '             mTab & mTab & mTab & "Throw new System.Exception(""Sin Conexión definida."")" & vbNewLine & _
                '             mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '             mTab & mTab & "End If" & vbNewLine & _
                '             mTab & mTab & "If Con.State = ConnectionState.Open Or CON.State = ConnectionState.Executing Or _" & vbNewLine & _
                '             mTab & mTab & "   CON.State = ConnectionState.Fetching Or CON.State = ConnectionState.Connecting Then CON.Ping()" & vbNewLine & _
                '             mTab & mTab & "If CON.State = ConnectionState.Closed Or CON.State = ConnectionState.Broken Then" & vbNewLine & _
                '             mTab & mTab & mTab & "If CON.ConnectionString.Length <> 0 Then" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "Try" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "Status = Verifica_PING(CON.ConnectionString)" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "If Status <> Tipo_Status_Ping.OK Then" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PDELETE No se logro hacer pineo a Servidor Error:"" & _" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & mTab & "          Status.ToString" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error. No se logro hacer pineo a Servidor"" & vbNewLine & _" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & mTab & "                           ""Conexión:"" & CON.ConnectionString & vbNewLine & ""Error:"" & Status.ToString)" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "End If" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "CON.Open()" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "Catch MYEX As MySqlException" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PDELETE Error#="" & MYEX.Number & "" "" & MYEX.ToString" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL"", MYEX)" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "Catch EX As Exception" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PDELETE Error="" & EX.ToString" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error no contemplado en Conexión a MySQL"", EX)" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "End Try" & vbNewLine & _
                '             mTab & mTab & mTab & "Else" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PDELETE String de Conexión no definido""" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "Throw New System.Exception(""Conexión sin string de conexión definido."")" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '             mTab & mTab & mTab & "End If" & vbNewLine & _
                '             mTab & mTab & "End If" & vbNewLine & _
                '             mTab & "End If" & vbNewLine & vbNewLine & _
                '             mTab & "COM = Nothing" & vbNewLine & _
                '             mTab & "TRY" & vbNewLine & _
                '             mTab & mTab & "If Condicion.Length <> 0 then" & vbNewLine & _
                '             mTab & mTab & mTab & "SQL = ""DELETE FROM " & frm.lvTABLAS.SelectedItems(0).Text & " WHERE "" & Condicion" & vbNewLine & _
                '             mTab & mTab & mTab & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "COM = New MySqlCommand(Sql, tra.Connection, TRA)" & vbNewLine & _
                '             mTab & mTab & mTab & "Else" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "COM = New MySqlCommand(Sql, CON)" & vbNewLine & _
                '             mTab & mTab & mTab & "End If" & vbNewLine & _
                '             mTab & mTab & mTab & "COM.CommandType = CommandType.Text" & vbNewLine & _
                '             mTab & mTab & mTab & "COM.CommandTimeout = _TimeOut" & vbNewLine & _
                '             mTab & mTab & "Else" & vbNewLine & _
                '             mTab & mTab & mTab & "SQL = ""DELETE FROM " & frm.lvTABLAS.SelectedItems(0).Text & " WHERE ")


                Clase.Append("Public Function PDELETE(Optional ByVal Condicion as String = """") AS Boolean" & vbNewLine & _
                             MTab(1) & "Dim COM As MySqlCommand" & vbNewLine & _
                             MTab(1) & "Dim SQL as String = """"" & vbNewLine & vbNewLine & _
                             MTab(1) & "MENSAJE = """"" & vbNewLine & _
                             MTab(1) & "PDELETE = False" & vbNewLine & vbNewLine & _
                             MTab(1) & "Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, REA, Definicion.Tipo_de_Funcion.Delete)" & vbNewLine & vbNewLine & _
                             MTab(1) & "COM = Nothing" & vbNewLine & _
                             MTab(1) & "TRY" & vbNewLine & _
                             MTab(2) & "If Condicion.Length <> 0 then" & vbNewLine & _
                             MTab(3) & "SQL = ""DELETE FROM " & frm.lvTABLAS.SelectedItems(0).Text & " WHERE "" & Condicion" & vbNewLine & _
                             MTab(3) & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                             MTab(4) & "COM = New MySqlCommand(Sql, tra.Connection, TRA)" & vbNewLine & _
                             MTab(3) & "Else" & vbNewLine & _
                             MTab(4) & "COM = New MySqlCommand(Sql, CON)" & vbNewLine & _
                             MTab(3) & "End If" & vbNewLine & _
                             MTab(3) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                             MTab(3) & "COM.CommandTimeout = _TimeOut" & vbNewLine & _
                             MTab(2) & "Else" & vbNewLine & _
                             MTab(3) & "SQL = ""DELETE FROM " & frm.lvTABLAS.SelectedItems(0).Text & " WHERE ")

                CUENTA = 0
                strTEMPO = ""
                For Each objBase In Me
                    If objBase.EsPK = True Then
                        CUENTA += 1
                        If CUENTA = 1 Then
                            Clase.Append(objBase.Propiedad & " = ?P" & CUENTA.ToString & " ")
                        Else
                            Clase.Append(" AND " & objBase.Propiedad & " = ?P" & CUENTA.ToString & " ")
                        End If
                        strTEMPO &= MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """, " & objBase.NombreCompleto & ")" & vbNewLine
                    End If
                Next
                Clase.Append("""" & vbNewLine & _
                             MTab(3) & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                             MTab(4) & "COM = New MySqlCommand(Sql, tra.Connection, TRA)" & vbNewLine & _
                             MTab(3) & "Else" & vbNewLine & _
                             MTab(4) & "COM = New MySqlCommand(Sql, CON)" & vbNewLine & _
                             MTab(3) & "End If" & vbNewLine & _
                             MTab(3) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                             MTab(3) & "COM.CommandTimeout = _TimeOut" & vbNewLine & _
                             strTEMPO & _
                             MTab(2) & "End If" & vbNewLine & _
                             MTab(2) & "If COM.ExecuteNonQuery <= 0 Then" & vbNewLine & _
                             MTab(3) & "PDELETE = False" & vbNewLine & _
                             MTab(2) & "Else" & vbNewLine & _
                             MTab(3) & "PDELETE = True" & vbNewLine & _
                             MTab(2) & "End If" & vbNewLine & _
                             MTab(1) & "Catch MYEX As MySqlException" & vbNewLine)

                Clase.Append(MTab(2) & "Dim tt as String = vbNewLine & ""Llave:"" ")
                strTEMPO = ""
                CUENTA = 0
                For Each objBase In Me
                    If objBase.EsPK = True Then 'Quiero solo los campos llaves
                        CUENTA = CUENTA + 1
                        If CUENTA = 1 Then
                            strTEMPO &= " & " & objBase.NombreCompleto.ToUpper
                            Select Case objBase.TipoBD.ToUpper
                                Case "MYSQLDATETIME", "DATE", "TIME"
                                    strTEMPO &= ".ToString"
                            End Select
                        Else
                            strTEMPO &= " & ""-"" & " & objBase.NombreCompleto.ToUpper
                            Select Case objBase.TipoBD.ToUpper
                                Case "MYSQLDATETIME", "DATE", "TIME"
                                    strTEMPO &= ".ToString"
                            End Select
                        End If
                    End If
                Next
                Clase.Append(strTEMPO & vbNewLine)

                Clase.Append(MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PDELETE MyError#="" & MYEX.Number & "" MyError="" & MYEX.ToString" & vbNewLine & _
                             MTab(2) & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL. SQL="" & SQL & tt, MYEX)" & vbNewLine & _
                             MTab(1) & "Catch ex As Exception" & vbNewLine & _
                             MTab(2) & "Dim tt as String = vbNewLine & ""Llave:"" " & strTEMPO & vbNewLine & _
                             MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PDELETE Error="" & ex.ToString" & vbNewLine & _
                             MTab(2) & "Throw New System.Exception(""Error no Contemplado Sql=."" & SQL & tt, ex)" & vbNewLine & _
                             MTab(1) & "Finally" & vbNewLine & _
                             MTab(2) & "If IsNothing(COM) = False Then" & vbNewLine & _
                             MTab(3) & "COM.Dispose()" & vbNewLine & _
                             MTab(3) & "COM = Nothing" & vbNewLine & _
                             MTab(2) & "End If" & vbNewLine & _
                             MTab(1) & "End Try" & vbNewLine & _
                             "End Function" & vbNewLine & vbNewLine)

                'VOY A AGREGAR PUPDATE
                'Clase.Append("Public Function PUPDATE() AS Boolean" & vbNewLine & _
                '             mTab & "Dim COM As MySqlCommand" & vbNewLine & _
                '             mTab & "Dim SQL as String = """"" & vbNewLine & _
                '             mTab & "Dim Status as Tipo_Status_Ping" & vbNewLine & vbNewLine & _
                '             mTab & "MENSAJE = """"" & vbNewLine & _
                '             mTab & "PUPDATE = False" & vbNewLine & _
                '             mTab & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                '             mTab & mTab & "If IsNothing(TRA) = True Then Throw New System.Exception(""Se quiere usar Transacción sin tenerla Definida."")" & vbNewLine & _
                '             mTab & mTab & "If Tra.Connection.Ping = False then Throw New System.Exception(""Conexión de la Transacción Caida."")" & vbNewLine & _
                '             mTab & "Else" & vbNewLine & _
                '             mTab & mTab & "If IsNothing(CON) = True Then" & vbNewLine & _
                '             mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PUPDATE Conexión no definida""" & vbNewLine & _
                '             mTab & mTab & mTab & "Throw new System.Exception(""Sin Conexión definida."")" & vbNewLine & _
                '             mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '             mTab & mTab & "End If" & vbNewLine & _
                '             mTab & mTab & "If Con.State = ConnectionState.Open Or CON.State = ConnectionState.Executing Or _" & vbNewLine & _
                '             mTab & mTab & "   CON.State = ConnectionState.Fetching Or CON.State = ConnectionState.Connecting Then CON.Ping()" & vbNewLine & _
                '             mTab & mTab & "If CON.State = ConnectionState.Closed Or CON.State = ConnectionState.Broken Then" & vbNewLine & _
                '             mTab & mTab & mTab & "If CON.ConnectionString.Length <> 0 Then" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "Try" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "Status = Verifica_PING(CON.ConnectionString)" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "If Status <> Tipo_Status_Ping.OK Then" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PUPDATE No se logro hacer pineo a Servidor Error:"" & _" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & mTab & "          Status.ToString" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error. No se logro hacer pineo a Servidor"" & vbNewLine & _" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & mTab & "                           ""Conexión:"" & CON.ConnectionString & vbNewLine & ""Error:"" & Status.ToString)" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "End If" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "CON.Open()" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "Catch MYEX As MySqlException" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PUPDATE Error#="" & MYEX.Number & "" "" & MYEX.ToString" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL"", MYEX)" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "Catch EX As Exception" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PUPDATE Error="" & EX.ToString" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "Throw New System.Exception(""Error no contemplado en Conexión a MySQL"", EX)" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "End Try" & vbNewLine & _
                '             mTab & mTab & mTab & "Else" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PUPDATE String de Conexión no definido""" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "Throw New System.Exception(""Conexión sin string de conexión definido."")" & vbNewLine & _
                '             mTab & mTab & mTab & mTab & "Exit Function" & vbNewLine & _
                '             mTab & mTab & mTab & "End If" & vbNewLine & _
                '             mTab & mTab & "End If" & vbNewLine & _
                '             mTab & "End If" & vbNewLine & _
                '             mTab & "COM = Nothing" & vbNewLine & _
                '             mTab & "TRY" & vbNewLine & _
                '             mTab & mTab & "SQL = ""UPDATE " & frm.lvTABLAS.SelectedItems(0).Text & " SET ")

                Clase.Append("Public Function PUPDATE() AS Boolean" & vbNewLine & _
                             MTab(1) & "Dim COM As MySqlCommand" & vbNewLine & _
                             MTab(1) & "Dim SQL as String = """"" & vbNewLine & vbNewLine & _
                             MTab(1) & "MENSAJE = """"" & vbNewLine & _
                             MTab(1) & "PUPDATE = False" & vbNewLine & vbNewLine & _
                             MTab(1) & "Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, REA, Definicion.Tipo_de_Funcion.Update)" & vbNewLine & vbNewLine & _
                             MTab(1) & "COM = Nothing" & vbNewLine & _
                             MTab(1) & "TRY" & vbNewLine & _
                             MTab(2) & "SQL = ""UPDATE " & frm.lvTABLAS.SelectedItems(0).Text & " SET ")

                CUENTA = 0
                CUENTA1 = 0
                strTEMPO = ""
                For Each objBase In Me
                    If objBase.EsPK = False Then
                        CUENTA += 1
                        CUENTA1 += 1
                        If CUENTA1 = 1 Then
                            Clase.Append(objBase.Propiedad & " = ?P" & CUENTA.ToString)
                        Else
                            Clase.Append(", " & objBase.Propiedad & " = ?P" & CUENTA.ToString)
                        End If

                        Select Case UCase(objBase.Tipo)
                            Case "MYSQLDATETIME"
                                'Tengo que verificar por Date o TimeStamp

                                If InStr(objBase.TipoBD.ToUpper, "TIMESTAMP", CompareMethod.Text) <> 0 Then
                                    strTEMPO &= MTab(2) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,Now)  'Es TimeStamp , Pongo Fecha Actual." & vbNewLine
                                Else
                                    strTEMPO &= MTab(2) & "If " & objBase.NombreCompleto & ".IsValidDateTime = False then" & vbNewLine
                                    strTEMPO &= MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,DBNull.Value)" & vbNewLine & _
                                                MTab(2) & "Else" & vbNewLine & _
                                                MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ".value)" & vbNewLine & _
                                                MTab(2) & "End If" & vbNewLine
                                End If

                            Case "INTEGER"
                                'Verifico por -1 que es el valor que asigne a nulo y que es lo que quiero grabar.
                                strTEMPO &= MTab(2) & "If " & objBase.NombreCompleto & " = -1 then" & vbNewLine & _
                                            MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,DBNull.Value)" & vbNewLine & _
                                            MTab(2) & "Else" & vbNewLine & _
                                            MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ")" & vbNewLine & _
                                            MTab(2) & "End If" & vbNewLine
                            Case "STRING"
                                strTEMPO &= MTab(2) & "If " & objBase.NombreCompleto & ".ToUpper = ""NULL"" then" & vbNewLine & _
                                            MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,DBNull.Value)" & vbNewLine & _
                                            MTab(2) & "Else" & vbNewLine & _
                                            MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ")" & vbNewLine & _
                                            MTab(2) & "End If" & vbNewLine
                            Case Else
                                strTEMPO &= MTab(2) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ")" & vbNewLine
                        End Select
                    Else
                        CUENTA += 1
                    End If
                Next
                Clase.Append(" WHERE ")
                CUENTA1 = 0
                CUENTA = 0
                For Each objBase In Me
                    CUENTA += 1
                    If objBase.EsPK = True Then
                        CUENTA1 += 1
                        If UCase(objBase.Tipo) = "MYSQLDATETIME" Then
                            strTEMPO &= MTab(2) & "If " & objBase.NombreCompleto & ".IsValidDateTime = False then" & vbNewLine
                            If InStr(objBase.NombreCompleto, "Escritura", CompareMethod.Text) <> 0 Then
                                strTEMPO &= MTab(3) & objBase.Propiedad & "_NET = Now()" & vbNewLine & _
                                            MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ".value)" & vbNewLine & _
                                            MTab(2) & "Else" & vbNewLine & _
                                            MTab(3) & objBase.Propiedad & "_NET = Now()" & vbNewLine & _
                                            MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ".value)" & vbNewLine & _
                                            MTab(2) & "End If" & vbNewLine
                            Else
                                strTEMPO &= MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """,DBNull.Value)" & vbNewLine & _
                                            MTab(2) & "Else" & vbNewLine & _
                                            MTab(3) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ".value)" & vbNewLine & _
                                            MTab(2) & "End If" & vbNewLine
                            End If
                        Else
                            strTEMPO &= MTab(2) & "COM.Parameters.AddWithValue(""?P" & CUENTA.ToString & """," & objBase.NombreCompleto & ")" & vbNewLine
                        End If

                        If CUENTA1 = 1 Then
                            Clase.Append(objBase.Propiedad & " = ?P" & CUENTA.ToString)
                        Else
                            Clase.Append(" AND " & objBase.Propiedad & " = ?P" & CUENTA.ToString)
                        End If
                    End If
                Next
                Clase.Append("""" & vbNewLine & _
                             MTab(2) & "If _Usar_Transaccion_Select Then" & vbNewLine & _
                             MTab(3) & "COM = New MySqlCommand(Sql, tra.Connection, TRA)" & vbNewLine & _
                             MTab(2) & "Else" & vbNewLine & _
                             MTab(3) & "COM = New MySqlCommand(Sql, CON)" & vbNewLine & _
                             MTab(2) & "End If" & vbNewLine & _
                             MTab(2) & "COM.CommandType = CommandType.Text" & vbNewLine & _
                             MTab(2) & "COM.CommandTimeout = _TimeOut" & vbNewLine & vbNewLine & _
                             strTEMPO & _
                             MTab(2) & "If COM.ExecuteNonQuery <= 0 Then" & vbNewLine & _
                             MTab(3) & "PUPDATE = False" & vbNewLine & _
                             MTab(2) & "Else" & vbNewLine & _
                             MTab(3) & "PUPDATE = True" & vbNewLine & _
                             MTab(2) & "End If" & vbNewLine & _
                             MTab(1) & "Catch MYEX As MySqlException" & vbNewLine)

                Clase.Append(MTab(2) & "Dim tt as String = vbnewline & ""Llave:"" ")
                strTEMPO = ""
                CUENTA = 0
                For Each objBase In Me
                    If objBase.EsPK = True Then 'Quiero solo los campos llaves
                        CUENTA = CUENTA + 1
                        If CUENTA = 1 Then
                            strTEMPO &= " & " & objBase.NombreCompleto.ToUpper
                            Select Case objBase.TipoBD.ToUpper
                                Case "MYSQLDATETIME", "DATE", "TIME"
                                    strTEMPO &= ".ToString"
                            End Select
                        Else
                            strTEMPO &= " & ""-"" & " & objBase.NombreCompleto.ToUpper
                            Select Case objBase.TipoBD.ToUpper
                                Case "MYSQLDATETIME", "DATE", "TIME"
                                    strTEMPO &= ".ToString"
                            End Select
                        End If
                    End If
                Next
                Clase.Append(strTEMPO & vbNewLine)

                Clase.Append(MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PUPDATE MyError#="" & MYEX.Number & "" MyError="" & MYEX.ToString" & vbNewLine & _
                             MTab(2) & "Throw New System.Exception(""MySQLError#:"" & MYEX.Number.ToString(""0000"") & "" Error de MySQL. SQL="" & SQL & TT, MYEX)" & vbNewLine & _
                             MTab(1) & "Catch ex As Exception" & vbNewLine & _
                             MTab(2) & "Dim tt as String = vbnewline & ""Llave:"" " & strTEMPO & vbNewLine & _
                             MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PUPDATE Error="" & ex.ToString" & vbNewLine & _
                             MTab(2) & "Throw New System.Exception(""Error no contemplado."" & TT, ex)" & vbNewLine & _
                             MTab(1) & "Finally" & vbNewLine & _
                             MTab(2) & "If IsNothing(COM) = False Then" & vbNewLine & _
                             MTab(3) & "COM.Dispose()" & vbNewLine & _
                             MTab(3) & "COM = Nothing" & vbNewLine & _
                             MTab(2) & "End If" & vbNewLine & _
                             MTab(1) & "End Try" & vbNewLine & _
                             "End Function" & vbNewLine & vbNewLine)
            End If
            'Agrego el Metodo de PRECUPERA_REGISTRO
            Clase.Append("Function PRECUPERA_REGISTRO() as " & frm.lvTABLAS.SelectedItems(0).Text.ToUpper & vbNewLine & _
                         MTab(1) & "Dim VAL as New " & frm.lvTABLAS.SelectedItems(0).Text.ToUpper & vbNewLine)
            For Each objBase In Me
                If objBase.EsPK = True Then
                    Select Case UCase(objBase.Tipo)
                        Case "DECIMAL", "INTEGER", "SHORT", "LONG"
                            Clase.Append(MTab(1) & "VAL." & objBase.Propiedad.ToUpper & " = 0" & vbNewLine)
                        Case "BOOLEAN"
                            Clase.Append(MTab(1) & "VAL." & objBase.Propiedad.ToUpper & " = false" & vbNewLine)
                        Case "DATETIME", "MYSQLDATETIME"
                            Clase.Append(MTab(1) & "VAL." & objBase.Propiedad.ToUpper & " = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)" & vbNewLine)
                        Case "TIMESPAN"
                            Clase.Append(MTab(1) & "VAL." & objBase.Propiedad.ToUpper & " = New TimeSpan(0, 0, 0)" & vbNewLine)
                        Case Else
                            Clase.Append(MTab(1) & "VAL." & objBase.Propiedad.ToUpper & " = """"" & vbNewLine)
                    End Select
                End If
            Next
            Clase.Append(MTab(1) & "Val.Simon_REGISTRO = False" & vbNewLine & _
                         MTab(1) & "Val.MERROR = """"" & vbNewLine & _
                         MTab(1) & "PRECUPERA_REGISTRO = VAL" & vbNewLine & _
                         MTab(1) & "Try" & vbNewLine)
            'Realizo las Asignaciones
            For Each objBase In Me
                Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = " & objBase.Propiedad.ToUpper & vbNewLine)
            Next
            Clase.Append(MTab(3) & "VAL.Simon_REGISTRO = True" & vbNewLine & _
                         MTab(3) & "PRECUPERA_REGISTRO = VAL" & vbNewLine & _
                         MTab(1) & "Catch Ex as Exception" & vbNewLine & _
                         MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PRECUPERA_REGISTRO Error="" & ex.ToString" & vbNewLine & _
                         MTab(2) & "Throw New System.Exception(""Error no Contemplado"", Ex)" & vbNewLine & _
                         MTab(1) & "End Try" & vbNewLine & _
                         "End Function" & vbNewLine & vbNewLine)

            'Agrego el Metodo de Asignacion del Registro
            Clase.Append("Function PPONE_REGISTRO(ByVal VAL As " & frm.lvTABLAS.SelectedItems(0).Text.ToUpper & ") as Boolean" & vbNewLine & _
                         MTab(1) & "PPONE_REGISTRO = False" & vbNewLine & _
                         MTab(1) & "Try" & vbNewLine)
            'Realizo las Asignaciones
            For Each objBase In Me
                Clase.Append(MTab(3) & objBase.Propiedad.ToUpper & " = " & "VAL." & objBase.Propiedad.ToUpper & vbNewLine)
            Next
            Clase.Append(MTab(3) & "PPONE_REGISTRO = True" & vbNewLine & _
                         MTab(1) & "Catch Ex as Exception" & vbNewLine & _
                         MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - PPONE_REGISTRO Error="" & ex.ToString" & vbNewLine & _
                         MTab(2) & "Throw New System.Exception(""Error No Contemplado"", EX)" & vbNewLine & _
                         MTab(1) & "End Try" & vbNewLine & _
                         "End Function" & vbNewLine & vbNewLine)

            'Coloco la Rutina para la carga de una colección de registros del tipo de la tabla
            Dim Tempo As String = ""

            'Verifico la llave principal de la tabla y si no la tiene tengo que generar un metodo unico de llave para los registros.
            strTEMPO = ""
            CUENTA = 0
            For Each objBase In Me
                If objBase.EsPK = True Then
                    CUENTA += 1
                    If CUENTA = 1 Then
                        strTEMPO &= "TEMPO." & objBase.Propiedad & ".toString"
                    Else
                        strTEMPO &= " & ""|"" & TEMPO." & objBase.Propiedad & ".toString"
                    End If
                End If
            Next

            Tempo = "Function PLLENA_COLECCION(ByRef COLECCION as Collection, ByVal CONDICION as String, Optional ByVal ORDENAMIENTO as String = """") as Boolean" & vbNewLine
            Tempo &= MTab(1) & "Dim CC as New " & frm.cbNameSpace.Text & "."
            If frm.txtSubNameSpace.Text.Length <> 0 Then
                Tempo &= frm.txtSubNameSpace.Text & "."
            End If
            If TTabla = Tipo_Tabla.Vista Then
                Tempo &= "Vista."
            End If
            Tempo &= Me.NombreClase & vbNewLine

            Tempo &= MTab(1) & "Dim TEMPO as " & frm.lvTABLAS.SelectedItems(0).Text.ToUpper & vbNewLine & _
                     MTab(1) & "Dim Llave as String" & vbNewLine
            If strTEMPO.Length = 0 Then
                Tempo &= MTab(1) & "Dim Cuenta as Integer = 0" & vbNewLine
            End If
            Tempo &= vbNewLine

            Tempo &= MTab(1) & "PLLENA_COLECCION = False" & vbNewLine
            Tempo &= MTab(1) & "Try" & vbNewLine
            Tempo &= MTab(2) & "If IsNothing(CON) = True Then" & vbNewLine & _
                     MTab(3) & "Mensaje = ""BiblioTABLAS - " & Me.NombreClase & " - PLLENA_COLLECION Error = No se ha definido el String de Conexión a la base de datos.""" & vbNewLine & _
                     MTab(3) & "Throw New System.Exception(""Sin Conexión"")" & vbNewLine & _
                     MTab(3) & "Exit Function" & vbNewLine & _
                     MTab(2) & "End If" & vbNewLine & vbNewLine & _
                     MTab(2) & "CC.CONEXION = CONstr" & vbNewLine & _
                     MTab(2) & "CC.PSELECT_RECORDSET(CONDICION,ORDENAMIENTO)" & vbNewLine & vbNewLine & _
                     MTab(2) & "Do While CC.PMOVE_NEXT = True" & vbNewLine & _
                     MTab(3) & "TEMPO = CC.PRECUPERA_REGISTRO" & vbNewLine

            'Tengo que recuperar la llave principal y hacer el Key
            If strTEMPO.Length = 0 Then
                Tempo &= MTab(3) & "Cuenta +=1" & vbNewLine & _
                         MTab(3) & "Llave = Cuenta.ToString" & vbNewLine
            Else
                strTEMPO = MTab(3) & "Llave = "
                CUENTA = 0
                For Each objBase In Me
                    If objBase.EsPK = True Then
                        CUENTA += 1
                        If CUENTA = 1 Then
                            strTEMPO &= "TEMPO." & objBase.Propiedad & ".toString"
                        Else
                            strTEMPO &= " & ""|"" & TEMPO." & objBase.Propiedad & ".toString"
                        End If
                    End If
                Next
            End If

            Tempo &= strTEMPO & vbNewLine
            Tempo &= MTab(3) & "COLECCION.Add(TEMPO,Llave)" & vbNewLine & _
                     MTab(2) & "Loop" & vbNewLine & _
                     MTab(2) & "PLLENA_COLECCION = True" & vbNewLine & _
                     MTab(1) & "Catch EX as Exception" & vbNewLine & _
                     MTab(2) & "MENSAJE=""BiblioTABLAS - " & Me.NombreClase & " - PLLENA_COLECCION Error="" & Ex.ToString" & vbNewLine & _
                     MTab(2) & "Throw New System.Exception(""Error No Contemplado"", EX)" & vbNewLine & _
                     MTab(1) & "Finally" & vbNewLine & _
                     MTab(2) & "CC.Dispose()" & vbNewLine & _
                     MTab(2) & "CC = Nothing" & vbNewLine & _
                     MTab(2) & "Tempo = Nothing" & vbNewLine & vbNewLine & _
                     MTab(2) & "System.GC.Collect()" & vbNewLine & _
                     MTab(1) & "End Try" & vbNewLine
            Tempo &= "End Function" & vbNewLine & vbNewLine

            Clase.Append(Tempo)

            'Verificar la data
            Clase.Append("Function POBTIENE_DEFAULT() as " & frm.lvTABLAS.SelectedItems(0).Text.ToUpper & vbNewLine & _
                         MTab(1) & "Dim VAL as New " & frm.lvTABLAS.SelectedItems(0).Text.ToUpper & vbNewLine & _
                         MTab(1) & "Val.Simon_REGISTRO = False" & vbNewLine & _
                         MTab(1) & "Val.MERROR = """"" & vbNewLine & _
                         MTab(1) & "POBTIENE_DEFAULT = VAL" & vbNewLine & _
                         MTab(1) & "Try" & vbNewLine)
            'Realizo las Asignaciones
            For Each objBase In Me
                Select Case UCase(objBase.Tipo)
                    Case "DECIMAL"
                        If objBase.V_Default = "" Or objBase.V_Default = "(null)" Then
                            Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = 0.00D" & vbNewLine)
                        Else
                            Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = " & objBase.V_Default & "D" & vbNewLine)
                        End If
                    Case "INTEGER", "SHORT", "LONG"
                        If objBase.V_Default = "" Or objBase.V_Default = "(null)" Then
                            Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = 0" & vbNewLine)
                        Else
                            Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = " & objBase.V_Default & vbNewLine)
                        End If
                    Case "DATETIME", "MYSQLDATETIME"
                        If objBase.V_Default = "" Or objBase.V_Default = "(null)" Then
                            Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = new MysqlDateTime(0,0,0,0,0,0,0)" & vbNewLine)
                        Else
                            If objBase.V_Default = "CURRENT_TIMESTAMP" Then
                                Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = New MySqlDateTime(Now)" & vbNewLine)
                            Else
                                Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = New MySqlDateTime(""" & objBase.V_Default & """)" & vbNewLine)
                            End If
                        End If
                    Case "TIMESPAN"
                        If objBase.V_Default = "" Or objBase.V_Default = "(null)" Then
                            Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = new TimeSpan(0,0,0)" & vbNewLine)
                        Else
                            'Tengo que cambiar los valores : por ,
                            Dim V() As Char = objBase.V_Default.ToCharArray
                            Dim Pos As Integer
                            For Pos = 0 To V.Length - 1
                                If V(Pos) = ":"c Then
                                    V(Pos) = ","
                                End If
                            Next
                            Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = new TimeSpan(" & CType(V, String) & ")" & vbNewLine)
                        End If
                    Case Else
                        If objBase.V_Default = "" Or objBase.V_Default = "(null)" Then
                            Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = """" " & vbNewLine)
                        Else
                            Clase.Append(MTab(3) & "VAL." & objBase.Propiedad.ToUpper & " = """ & objBase.V_Default & """" & vbNewLine)
                        End If
                End Select
            Next

            Clase.Append(MTab(3) & "VAL.Simon_REGISTRO = True" & vbNewLine & _
                         MTab(3) & "POBTIENE_DEFAULT = VAL" & vbNewLine & _
                         MTab(1) & "Catch Ex as Exception" & vbNewLine & _
                         MTab(2) & "MENSAJE = ""BiblioTABLAS - " & Me.NombreClase & " - POBTIENE_DEFAULT Error="" & ex.ToString" & vbNewLine & _
                         MTab(2) & "Throw New System.Exception(""Error no contemplado"", Ex)" & vbNewLine & _
                         MTab(1) & "End Try" & vbNewLine & _
                         "End Function" & vbNewLine & vbNewLine)

            'mTab & mTab & "DS = New DataSet(""" & frm.lvTABLAS.SelectedItems(0).Text.ToUpper & """)" & vbNewLine & _
            Clase.Append("Function ToDataTable() as DataTable" & vbNewLine & _
                         MTab(1) & "Dim DT as new DataTable(""" & frm.lvTABLAS.SelectedItems(0).Text.ToUpper & """)" & vbNewLine & _
                         MTab(1) & "Try" & vbNewLine & _
                         MTab(2) & "If IsNothing(REA) = True Then" & vbNewLine & _
                         MTab(3) & "Throw New System.Exception(""Tiene que Ejecutar PSelect_RecordSet Antes."")" & vbNewLine & _
                         MTab(3) & "Exit Function" & vbNewLine & _
                         MTab(2) & "End If" & vbNewLine & _
                         MTab(2) & "DT.Load(REA)" & vbNewLine & _
                         MTab(2) & "Return DT" & vbNewLine & _
                         MTab(1) & "Catch ex as Exception" & vbNewLine & _
                         MTab(2) & "Throw New System.Exception(""Error no contemplado"", Ex)" & vbNewLine & _
                         MTab(1) & "Finally" & vbNewLine & _
                         MTab(2) & "If IsNothing(DT) = False then " & vbNewLine & _
                         MTab(3) & "DT.Dispose()" & vbNewLine & _
                         MTab(3) & "DT = Nothing" & vbNewLine & _
                         MTab(2) & "End If" & vbNewLine & vbNewLine & _
                         MTab(2) & "System.GC.Collect()" & vbNewLine & _
                         MTab(1) & "End Try" & vbNewLine & _
                         "End Function" & vbNewLine)

            Clase.Append(vbNewLine & _
                         "#End REGION" & vbNewLine & vbNewLine & "End Class" & vbNewLine)

            If frm.txtSubNameSpace.Text.Length <> 0 Then
                Clase.Append("End NameSpace" & vbNewLine)
            End If

            If TTabla = Tipo_Tabla.Vista Then
                Clase.Append("End NameSpace" & vbNewLine)
            End If
            Clase.Append("End NameSpace" & vbNewLine)

            Return Clase.ToString
        Catch EX As Exception
            MsgBox("Error " & EX.ToString)
        End Try
    End Function

    Public Function GeneraSPs() As String
        Dim objBase As CMiembroMySQL
        Dim strResultado As String
        'Dim iCont As Integer
        Dim strKey As String = "", strNoKey As String = ""
        Dim strParams As String


        strResultado = ""

        'PRIMERO AÑADE UN PROCEDIMIENTO PARA GUARDAR Y/O EDITAR LOS REGISTROS, TOMA LOS CAMPOS
        'LLAVE PARA SABER SI EXISTE. SI EXISTE, ACTUALIZA, SI NO, INSERTA
        strResultado &= "CREATE PRODEDURE 'sp_AC_" & Me.NombreClase & "' (" & Chr(10)

        strParams = ""
        For Each objBase In Me
            strParams &= Tabs(1) & "_" & objBase.CampoBD & " " & objBase.TipoBDCompleto & "," & Chr(10)
        Next
        'Le quita el enter y el ,
        If strParams <> "" Then strParams = Left$(strParams, strParams.Length() - 2)

        strResultado &= strParams & Chr(10) & ")" & Chr(10) & Chr(10) & _
            Tabs(1) & "NOT DETERMINISTIC" & Chr(10) & _
            Tabs(1) & "SQL SECURITY DEFINER" & Chr(10) & _
            Tabs(1) & "BEGIN " & Chr(10) & Chr(10)

        strKey = ""
        For Each objBase In Me
            If objBase.EsPK Then
                strKey &= Tabs(2) & objBase.CampoBD & " = _" & objBase.CampoBD & " AND" & Chr(10)
            Else
                strNoKey &= Tabs(3) & objBase.CampoBD & " = _" & objBase.CampoBD & "," & Chr(10)
            End If
        Next

        'Quita el ultimo and
        strKey = Left$(strKey, strKey.Length - 4)
        strNoKey = Left$(strNoKey, strNoKey.Length - 2)

        strResultado &= _
            Tabs(1) & "IF EXISTS(SELECT * FROM TABLA " & Chr(10) & _
            Tabs(1) & "WHERE" & Chr(10) & _
            strKey & ") THEN " & Chr(10) & _
            Tabs(2) & "UPDATE TABLA SET " & Chr(10) & _
            strNoKey & Chr(10) & _
            Tabs(2) & "WHERE" & Chr(10) & _
            Tabs(1) & strKey & ";" & Chr(10)

        strParams = ""
        For Each objBase In Me
            strParams &= objBase.CampoBD & ","
        Next
        'Quita la ultima coma
        strParams = Left$(strParams, strParams.Length - 1)

        strResultado &= _
            Tabs(1) & "ELSE" & Chr(10) & _
            Tabs(2) & "INSERT INTO TABLA(" & strParams & ")" & Chr(10)

        strParams = ""
        For Each objBase In Me
            strParams &= "_" & objBase.CampoBD & ","
        Next
        'Quita la ultima coma
        strParams = Left$(strParams, strParams.Length - 1)
        strResultado &= Tabs(2) & "VALUES (" & strParams & ")" & Chr(10) & Chr(10)

        strResultado &= Tabs(1) & "END IF;" & Chr(10) & _
            "END;" & Chr(10) & Chr(10) & Chr(10)


        'DESPUES AÑADE UN PROCEDIMIENTO PARA LEER LOS REGISTROS
        'EL PROCEDIMIENTO FUNCIONARÁ PARA CATALOGOS QUE NO ESTEN RELACIONADOS CON SUBCATALOGOS
        '(LAS UNIONES DEBERÁN ESCRIBIRSE APARTE). AYUDA A CREAR LA BASE QUE RECIBIRÁ LOS 
        'PARÁMETROS Y CONSULTARÁ EL CATALOGO PRINCIPAL
        strResultado &= "CREATE PROCEDURE sp_L_" & Me.NombreClase & " (" & Chr(10)

        strParams = ""
        For Each objBase In Me
            strParams &= Tabs(1) & "_" & objBase.CampoBD & " " & objBase.TipoBDCompleto & "," & Chr(10)
        Next
        'Le quita el enter y el ,
        If strParams <> "" Then strParams = Left$(strParams, strParams.Length() - 2)

        strResultado &= strParams & Chr(10) & ")" & Chr(10) & Chr(10) & _
            Tabs(1) & "NOT DETERMINISTIC" & Chr(10) & _
            Tabs(1) & "SQL SECURITY DEFINER" & Chr(10) & _
            "BEGIN " & Chr(10) & Chr(10)

        strKey = ""
        strNoKey = ""
        For Each objBase In Me
            If objBase.EsPK Then
                strKey &= Tabs(2) & objBase.CampoBD & " = _" & objBase.CampoBD & " AND" & Chr(10)
            Else
                strNoKey &= Tabs(2) & objBase.CampoBD & "," & Chr(10)
            End If
        Next

        'Quita el ultimo and
        strKey = Left$(strKey, strKey.Length - 4)
        strNoKey = Left$(strNoKey, strNoKey.Length - 2)

        strResultado &= _
            Tabs(1) & "SELECT " & Chr(10) & _
            strNoKey & Chr(10) & _
            Tabs(1) & "FROM TABLA " & Chr(10) & _
            Tabs(2) & "WHERE" & Chr(10) & _
            strKey & ";" & Chr(10)

        strResultado &= "END;"

        Return strResultado
    End Function

    Private Function Tabs(ByVal n As Short) As String
        Dim mtab As String = Chr(9)
        For i As Short = 1 To n - 1
            mtab &= mtab
        Next

        Return mtab
    End Function

#End Region

End Class
